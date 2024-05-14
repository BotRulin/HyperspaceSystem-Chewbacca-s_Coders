using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace HyperspaceSystem_Chewbacca_s_Coders
{
    public partial class frmHES : Form
    {
        XmlDocument doc = new XmlDocument();
        public frmHES()
        {
            InitializeComponent();
        }

        private void frmHES_Load(object sender, EventArgs e)
        {
            doc.Load("DataBank.xml");

            XmlNode root = doc.DocumentElement;
            XmlNodeList planetNodes = root.SelectNodes("//planet");

            List<string> planetNames = new List<string>();

            foreach (XmlNode node in planetNodes)
            {
                string planetName = node.SelectSingleNode("name").InnerText;
                planetNames.Add(planetName);
            }

            planetNames.Sort();

            foreach (string name in planetNames)
            {
                cmbOriginData.Items.Add(name);
            }
        }

        private void cmbOriginData_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDestinationData1.Items.Clear();
            cmbDestinationData1.Text = "";
            cmbDestinationData2.Items.Clear();
            cmbDestinationData2.Text = "";

            dgvDestination.DataSource = null;

            lblPlanetData.Text = "";
            lblSectorData.Text = "";
            lblFiliationData.Text = "";
            lblLongitudeData.Text = "";
            lblLatitudeData.Text = "";
            lblNativesData.Text = "";
            lblOriginPlanetData.Text = "";
            lblRouteNameData.Text = "";
            lblTypeRouteData.Text = "";
            lblDestinationPlanetData.Text = "";
            
            lbRoutesData.Items.Clear();

            imgPlanet1.Image = null;
            imgOriginPlanet.Image = null;

            pnlDestination.Visible = true;
            pnlOrigin.Visible = false;
            pnlData.Visible = false;

            cmbDestinationData1.Items.Add("filiations");
            cmbDestinationData1.Items.Add("regions");
        }

        private void cmbDestinationData1_SelectedIndexChanged(object sender, EventArgs e)
        {
            cmbDestinationData2.Items.Clear();
            cmbDestinationData2.Text = "";

            dgvDestination.DataSource = null;

            string selected = cmbDestinationData1.SelectedItem.ToString();

            switch (selected)
            {
                case "filiations":
                    foreach (XmlNode node in doc.DocumentElement[selected].ChildNodes)
                    {
                        cmbDestinationData2.Items.Add(node.InnerText);
                    }
                    break;

                case "regions":
                    foreach (XmlNode node in doc.DocumentElement[selected].ChildNodes)
                    {
                        cmbDestinationData2.Items.Add(node["nameRegion"].InnerText);
                    }
                    break;

                default:
                    break;
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt.Columns.Add("Name");
            dt.Columns.Add("Sector");
            dt.Columns.Add("Filiation");
            dt.Columns.Add("Natives");

            XmlNodeList planets = doc.DocumentElement.SelectNodes("planets/planet");

            foreach (XmlNode planet in planets)
            {
                string selected1 = cmbDestinationData1.SelectedItem?.ToString();
                string selected2 = cmbDestinationData2.SelectedItem?.ToString();

                if (selected1 == "filiations" && planet["filiation"].InnerText == selected2 ||
                    selected1 == "regions" && planet["sector"].InnerText.Contains(selected2))
                {
                    DataRow row = dt.NewRow();
                    row["Name"] = planet["name"].InnerText;
                    row["Sector"] = planet["sector"].InnerText;
                    row["Filiation"] = planet["filiation"].InnerText;
                    row["Natives"] = planet["natives"].InnerText;
                    dt.Rows.Add(row);
                }
            }

            dgvDestination.DataSource = dt;
        }

        private void dgvDestination_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            pnlData.Visible = true;
            pnlOrigin.Visible = false;

            string selectedPlanet = dgvDestination.Rows[e.RowIndex].Cells["Name"].Value.ToString();
            XmlNode planet = doc.DocumentElement.SelectSingleNode($"//planet[name='{selectedPlanet}']");

            if (planet != null)
            {
                lblPlanetData.Text = planet["name"].InnerText;
                lblSectorData.Text = planet["sector"].InnerText;
                lblFiliationData.Text = planet["filiation"].InnerText;
                lblLongitudeData.Text = planet.SelectSingleNode("situation/long").InnerText;
                lblLatitudeData.Text = planet.SelectSingleNode("situation/lat").InnerText;
                lblNativesData.Text = planet["natives"].InnerText;

                var hyperspaceRoutes = planet.SelectNodes("hyperspaceRoute/route");
                lbRoutesData.Items.Clear();
                foreach (XmlNode route in hyperspaceRoutes)
                {
                    lbRoutesData.Items.Add(route.InnerText);
                }

                string planetName = lblPlanetData.Text;
                CargarImagen(planetName, imgPlanet1, "planetes");
            }
        }

        private void lbRoutesData_SelectedIndexChanged(object sender, EventArgs e)
        {
            pnlOrigin.Visible = true;

            string selectedRoute = lbRoutesData.SelectedItem.ToString();
            XmlNode route = doc.DocumentElement.SelectSingleNode($"//hyperspaceRoutes/Route[nameRoute='{selectedRoute}']");

            if (route != null)
            {
                lblOriginPlanetData.Text = route["start"].InnerText;
                lblRouteNameData.Text = route["nameRoute"].InnerText;
                lblTypeRouteData.Text = route["type"].InnerText;
                lblDestinationPlanetData.Text = route["end"].InnerText;

                if (route["mapRoute"] != null)
                {
                    string imgOrigin = route["mapRoute"].InnerText;
                    CargarImagen(imgOrigin, imgOriginPlanet, "planetes");
                }
                else
                {
                    imgOriginPlanet.Image = null; // o la imagen por defecto que quieras mostrar
                }
            }
        }

        private void CargarImagen(string planetName, PictureBox imgControl, string folder)
        {
            string basePath = Path.Combine(Application.StartupPath, folder);
            string jpgPath = Path.Combine(basePath, $"{planetName}.jpg");
            string pngPath = Path.Combine(basePath, $"{planetName}.png");
            string nadaPath = Path.Combine(basePath, $"{planetName}");


            if (File.Exists(jpgPath))
            {
                imgControl.Image = Image.FromFile(jpgPath);
            }
            else if (File.Exists(pngPath))
            {
                imgControl.Image = Image.FromFile(pngPath);
            }
            else if (File.Exists(nadaPath))
            {
                imgControl.Image = Image.FromFile(nadaPath);
            }
        }
    }
}
