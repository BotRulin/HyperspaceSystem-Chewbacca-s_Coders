
namespace HyperspaceSystem_Chewbacca_s_Coders
{
    partial class frmHES
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblOrigin = new System.Windows.Forms.Label();
            this.cmbOriginData = new System.Windows.Forms.ComboBox();
            this.pnlDestination = new System.Windows.Forms.Panel();
            this.dgvDestination = new System.Windows.Forms.DataGridView();
            this.btnSearch = new System.Windows.Forms.Button();
            this.cmbDestinationData2 = new System.Windows.Forms.ComboBox();
            this.cmbDestinationData1 = new System.Windows.Forms.ComboBox();
            this.lblDestination = new System.Windows.Forms.Label();
            this.pnlData = new System.Windows.Forms.Panel();
            this.imgPlanet1 = new System.Windows.Forms.PictureBox();
            this.lbRoutesData = new System.Windows.Forms.ListBox();
            this.lblRoutes = new System.Windows.Forms.Label();
            this.lblLatitudeData = new System.Windows.Forms.Label();
            this.lblLatitude = new System.Windows.Forms.Label();
            this.lblLongitudeData = new System.Windows.Forms.Label();
            this.lblLongitude = new System.Windows.Forms.Label();
            this.lblFiliationData = new System.Windows.Forms.Label();
            this.lblFiliation = new System.Windows.Forms.Label();
            this.lblNativesData = new System.Windows.Forms.Label();
            this.lblNatives = new System.Windows.Forms.Label();
            this.lblSectorData = new System.Windows.Forms.Label();
            this.lblSector = new System.Windows.Forms.Label();
            this.lblPlanetData = new System.Windows.Forms.Label();
            this.lblPlanet = new System.Windows.Forms.Label();
            this.pnlOrigin = new System.Windows.Forms.Panel();
            this.lblTypeRouteData = new System.Windows.Forms.Label();
            this.imgOriginPlanet = new System.Windows.Forms.PictureBox();
            this.lblTypeRoute = new System.Windows.Forms.Label();
            this.lblDestinationPlanetData = new System.Windows.Forms.Label();
            this.lblDestinationPlanet = new System.Windows.Forms.Label();
            this.lblRouteNameData = new System.Windows.Forms.Label();
            this.lblRouteName = new System.Windows.Forms.Label();
            this.lblOriginPlanetData = new System.Windows.Forms.Label();
            this.lblOriginPlanet = new System.Windows.Forms.Label();
            this.pnlLeft = new System.Windows.Forms.Panel();
            this.pnlDestination.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestination)).BeginInit();
            this.pnlData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlanet1)).BeginInit();
            this.pnlOrigin.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgOriginPlanet)).BeginInit();
            this.pnlLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblOrigin
            // 
            this.lblOrigin.AutoSize = true;
            this.lblOrigin.Location = new System.Drawing.Point(12, 7);
            this.lblOrigin.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblOrigin.Name = "lblOrigin";
            this.lblOrigin.Size = new System.Drawing.Size(63, 22);
            this.lblOrigin.TabIndex = 0;
            this.lblOrigin.Text = "Origin:";
            // 
            // cmbOriginData
            // 
            this.cmbOriginData.FormattingEnabled = true;
            this.cmbOriginData.Location = new System.Drawing.Point(83, 4);
            this.cmbOriginData.Name = "cmbOriginData";
            this.cmbOriginData.Size = new System.Drawing.Size(181, 28);
            this.cmbOriginData.TabIndex = 1;
            this.cmbOriginData.SelectedIndexChanged += new System.EventHandler(this.cmbOriginData_SelectedIndexChanged);
            // 
            // pnlDestination
            // 
            this.pnlDestination.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlDestination.Controls.Add(this.dgvDestination);
            this.pnlDestination.Controls.Add(this.btnSearch);
            this.pnlDestination.Controls.Add(this.cmbDestinationData2);
            this.pnlDestination.Controls.Add(this.cmbDestinationData1);
            this.pnlDestination.Controls.Add(this.lblDestination);
            this.pnlDestination.Location = new System.Drawing.Point(16, 53);
            this.pnlDestination.Name = "pnlDestination";
            this.pnlDestination.Size = new System.Drawing.Size(922, 243);
            this.pnlDestination.TabIndex = 2;
            // 
            // dgvDestination
            // 
            this.dgvDestination.AllowUserToAddRows = false;
            this.dgvDestination.AllowUserToDeleteRows = false;
            this.dgvDestination.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDestination.Location = new System.Drawing.Point(274, 12);
            this.dgvDestination.Name = "dgvDestination";
            this.dgvDestination.ReadOnly = true;
            this.dgvDestination.Size = new System.Drawing.Size(612, 205);
            this.dgvDestination.TabIndex = 6;
            this.dgvDestination.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvDestination_CellContentClick);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(20, 124);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(101, 38);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // cmbDestinationData2
            // 
            this.cmbDestinationData2.FormattingEnabled = true;
            this.cmbDestinationData2.Location = new System.Drawing.Point(20, 71);
            this.cmbDestinationData2.Name = "cmbDestinationData2";
            this.cmbDestinationData2.Size = new System.Drawing.Size(181, 28);
            this.cmbDestinationData2.TabIndex = 4;
            // 
            // cmbDestinationData1
            // 
            this.cmbDestinationData1.FormattingEnabled = true;
            this.cmbDestinationData1.Location = new System.Drawing.Point(20, 37);
            this.cmbDestinationData1.Name = "cmbDestinationData1";
            this.cmbDestinationData1.Size = new System.Drawing.Size(181, 28);
            this.cmbDestinationData1.TabIndex = 3;
            this.cmbDestinationData1.SelectedIndexChanged += new System.EventHandler(this.cmbDestinationData1_SelectedIndexChanged);
            // 
            // lblDestination
            // 
            this.lblDestination.AutoSize = true;
            this.lblDestination.Location = new System.Drawing.Point(16, 12);
            this.lblDestination.Margin = new System.Windows.Forms.Padding(5, 0, 5, 0);
            this.lblDestination.Name = "lblDestination";
            this.lblDestination.Size = new System.Drawing.Size(105, 22);
            this.lblDestination.TabIndex = 3;
            this.lblDestination.Text = "Destination:";
            // 
            // pnlData
            // 
            this.pnlData.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlData.Controls.Add(this.imgPlanet1);
            this.pnlData.Controls.Add(this.lbRoutesData);
            this.pnlData.Controls.Add(this.lblRoutes);
            this.pnlData.Controls.Add(this.lblLatitudeData);
            this.pnlData.Controls.Add(this.lblLatitude);
            this.pnlData.Controls.Add(this.lblLongitudeData);
            this.pnlData.Controls.Add(this.lblLongitude);
            this.pnlData.Controls.Add(this.lblFiliationData);
            this.pnlData.Controls.Add(this.lblFiliation);
            this.pnlData.Controls.Add(this.lblNativesData);
            this.pnlData.Controls.Add(this.lblNatives);
            this.pnlData.Controls.Add(this.lblSectorData);
            this.pnlData.Controls.Add(this.lblSector);
            this.pnlData.Controls.Add(this.lblPlanetData);
            this.pnlData.Controls.Add(this.lblPlanet);
            this.pnlData.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.pnlData.Location = new System.Drawing.Point(16, 317);
            this.pnlData.Name = "pnlData";
            this.pnlData.Size = new System.Drawing.Size(922, 323);
            this.pnlData.TabIndex = 3;
            this.pnlData.Visible = false;
            // 
            // imgPlanet1
            // 
            this.imgPlanet1.Location = new System.Drawing.Point(672, 9);
            this.imgPlanet1.Name = "imgPlanet1";
            this.imgPlanet1.Size = new System.Drawing.Size(231, 292);
            this.imgPlanet1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgPlanet1.TabIndex = 14;
            this.imgPlanet1.TabStop = false;
            // 
            // lbRoutesData
            // 
            this.lbRoutesData.BackColor = System.Drawing.SystemColors.Control;
            this.lbRoutesData.FormattingEnabled = true;
            this.lbRoutesData.ItemHeight = 16;
            this.lbRoutesData.Location = new System.Drawing.Point(18, 185);
            this.lbRoutesData.Name = "lbRoutesData";
            this.lbRoutesData.Size = new System.Drawing.Size(201, 116);
            this.lbRoutesData.TabIndex = 13;
            this.lbRoutesData.SelectedIndexChanged += new System.EventHandler(this.lbRoutesData_SelectedIndexChanged);
            // 
            // lblRoutes
            // 
            this.lblRoutes.AutoSize = true;
            this.lblRoutes.Location = new System.Drawing.Point(15, 164);
            this.lblRoutes.Name = "lblRoutes";
            this.lblRoutes.Size = new System.Drawing.Size(59, 17);
            this.lblRoutes.TabIndex = 12;
            this.lblRoutes.Text = "Routes";
            // 
            // lblLatitudeData
            // 
            this.lblLatitudeData.AutoSize = true;
            this.lblLatitudeData.ForeColor = System.Drawing.Color.Blue;
            this.lblLatitudeData.Location = new System.Drawing.Point(547, 45);
            this.lblLatitudeData.Name = "lblLatitudeData";
            this.lblLatitudeData.Size = new System.Drawing.Size(0, 17);
            this.lblLatitudeData.TabIndex = 11;
            this.lblLatitudeData.Tag = "";
            // 
            // lblLatitude
            // 
            this.lblLatitude.AutoSize = true;
            this.lblLatitude.Location = new System.Drawing.Point(547, 13);
            this.lblLatitude.Name = "lblLatitude";
            this.lblLatitude.Size = new System.Drawing.Size(67, 17);
            this.lblLatitude.TabIndex = 10;
            this.lblLatitude.Text = "Latitude";
            // 
            // lblLongitudeData
            // 
            this.lblLongitudeData.AutoSize = true;
            this.lblLongitudeData.ForeColor = System.Drawing.Color.Blue;
            this.lblLongitudeData.Location = new System.Drawing.Point(547, 132);
            this.lblLongitudeData.Name = "lblLongitudeData";
            this.lblLongitudeData.Size = new System.Drawing.Size(0, 17);
            this.lblLongitudeData.TabIndex = 9;
            this.lblLongitudeData.Tag = "";
            // 
            // lblLongitude
            // 
            this.lblLongitude.AutoSize = true;
            this.lblLongitude.Location = new System.Drawing.Point(547, 100);
            this.lblLongitude.Name = "lblLongitude";
            this.lblLongitude.Size = new System.Drawing.Size(80, 17);
            this.lblLongitude.TabIndex = 8;
            this.lblLongitude.Text = "Longitude";
            // 
            // lblFiliationData
            // 
            this.lblFiliationData.AutoSize = true;
            this.lblFiliationData.ForeColor = System.Drawing.Color.Blue;
            this.lblFiliationData.Location = new System.Drawing.Point(419, 41);
            this.lblFiliationData.Name = "lblFiliationData";
            this.lblFiliationData.Size = new System.Drawing.Size(0, 17);
            this.lblFiliationData.TabIndex = 7;
            this.lblFiliationData.Tag = "";
            // 
            // lblFiliation
            // 
            this.lblFiliation.AutoSize = true;
            this.lblFiliation.Location = new System.Drawing.Point(419, 9);
            this.lblFiliation.Name = "lblFiliation";
            this.lblFiliation.Size = new System.Drawing.Size(65, 17);
            this.lblFiliation.TabIndex = 6;
            this.lblFiliation.Text = "Filiation";
            // 
            // lblNativesData
            // 
            this.lblNativesData.AutoSize = true;
            this.lblNativesData.ForeColor = System.Drawing.Color.Blue;
            this.lblNativesData.Location = new System.Drawing.Point(241, 41);
            this.lblNativesData.Name = "lblNativesData";
            this.lblNativesData.Size = new System.Drawing.Size(0, 17);
            this.lblNativesData.TabIndex = 5;
            this.lblNativesData.Tag = "";
            // 
            // lblNatives
            // 
            this.lblNatives.AutoSize = true;
            this.lblNatives.Location = new System.Drawing.Point(241, 9);
            this.lblNatives.Name = "lblNatives";
            this.lblNatives.Size = new System.Drawing.Size(62, 17);
            this.lblNatives.TabIndex = 4;
            this.lblNatives.Text = "Natives";
            // 
            // lblSectorData
            // 
            this.lblSectorData.AutoSize = true;
            this.lblSectorData.ForeColor = System.Drawing.Color.Blue;
            this.lblSectorData.Location = new System.Drawing.Point(15, 121);
            this.lblSectorData.Name = "lblSectorData";
            this.lblSectorData.Size = new System.Drawing.Size(0, 17);
            this.lblSectorData.TabIndex = 3;
            this.lblSectorData.Tag = "";
            // 
            // lblSector
            // 
            this.lblSector.AutoSize = true;
            this.lblSector.Location = new System.Drawing.Point(15, 89);
            this.lblSector.Name = "lblSector";
            this.lblSector.Size = new System.Drawing.Size(55, 17);
            this.lblSector.TabIndex = 2;
            this.lblSector.Text = "Sector";
            // 
            // lblPlanetData
            // 
            this.lblPlanetData.AutoSize = true;
            this.lblPlanetData.ForeColor = System.Drawing.Color.Blue;
            this.lblPlanetData.Location = new System.Drawing.Point(15, 42);
            this.lblPlanetData.Name = "lblPlanetData";
            this.lblPlanetData.Size = new System.Drawing.Size(0, 17);
            this.lblPlanetData.TabIndex = 1;
            this.lblPlanetData.Tag = "";
            // 
            // lblPlanet
            // 
            this.lblPlanet.AutoSize = true;
            this.lblPlanet.Location = new System.Drawing.Point(15, 9);
            this.lblPlanet.Name = "lblPlanet";
            this.lblPlanet.Size = new System.Drawing.Size(54, 17);
            this.lblPlanet.TabIndex = 0;
            this.lblPlanet.Text = "Planet";
            // 
            // pnlOrigin
            // 
            this.pnlOrigin.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOrigin.Controls.Add(this.lblTypeRouteData);
            this.pnlOrigin.Controls.Add(this.imgOriginPlanet);
            this.pnlOrigin.Controls.Add(this.lblTypeRoute);
            this.pnlOrigin.Controls.Add(this.lblDestinationPlanetData);
            this.pnlOrigin.Controls.Add(this.lblDestinationPlanet);
            this.pnlOrigin.Controls.Add(this.lblRouteNameData);
            this.pnlOrigin.Controls.Add(this.lblRouteName);
            this.pnlOrigin.Controls.Add(this.lblOriginPlanetData);
            this.pnlOrigin.Controls.Add(this.lblOriginPlanet);
            this.pnlOrigin.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.pnlOrigin.Location = new System.Drawing.Point(16, 656);
            this.pnlOrigin.Name = "pnlOrigin";
            this.pnlOrigin.Size = new System.Drawing.Size(922, 312);
            this.pnlOrigin.TabIndex = 15;
            this.pnlOrigin.Visible = false;
            // 
            // lblTypeRouteData
            // 
            this.lblTypeRouteData.AutoSize = true;
            this.lblTypeRouteData.ForeColor = System.Drawing.Color.Blue;
            this.lblTypeRouteData.Location = new System.Drawing.Point(18, 192);
            this.lblTypeRouteData.Name = "lblTypeRouteData";
            this.lblTypeRouteData.Size = new System.Drawing.Size(0, 17);
            this.lblTypeRouteData.TabIndex = 15;
            this.lblTypeRouteData.Tag = "";
            // 
            // imgOriginPlanet
            // 
            this.imgOriginPlanet.Location = new System.Drawing.Point(469, 9);
            this.imgOriginPlanet.Name = "imgOriginPlanet";
            this.imgOriginPlanet.Size = new System.Drawing.Size(434, 292);
            this.imgOriginPlanet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.imgOriginPlanet.TabIndex = 14;
            this.imgOriginPlanet.TabStop = false;
            // 
            // lblTypeRoute
            // 
            this.lblTypeRoute.AutoSize = true;
            this.lblTypeRoute.Location = new System.Drawing.Point(15, 164);
            this.lblTypeRoute.Name = "lblTypeRoute";
            this.lblTypeRoute.Size = new System.Drawing.Size(111, 17);
            this.lblTypeRoute.TabIndex = 12;
            this.lblTypeRoute.Text = "Type of Route";
            // 
            // lblDestinationPlanetData
            // 
            this.lblDestinationPlanetData.AutoSize = true;
            this.lblDestinationPlanetData.ForeColor = System.Drawing.Color.Blue;
            this.lblDestinationPlanetData.Location = new System.Drawing.Point(241, 41);
            this.lblDestinationPlanetData.Name = "lblDestinationPlanetData";
            this.lblDestinationPlanetData.Size = new System.Drawing.Size(0, 17);
            this.lblDestinationPlanetData.TabIndex = 5;
            this.lblDestinationPlanetData.Tag = "";
            // 
            // lblDestinationPlanet
            // 
            this.lblDestinationPlanet.AutoSize = true;
            this.lblDestinationPlanet.Location = new System.Drawing.Point(241, 9);
            this.lblDestinationPlanet.Name = "lblDestinationPlanet";
            this.lblDestinationPlanet.Size = new System.Drawing.Size(90, 17);
            this.lblDestinationPlanet.TabIndex = 4;
            this.lblDestinationPlanet.Text = "Destination";
            // 
            // lblRouteNameData
            // 
            this.lblRouteNameData.AutoSize = true;
            this.lblRouteNameData.ForeColor = System.Drawing.Color.Blue;
            this.lblRouteNameData.Location = new System.Drawing.Point(15, 121);
            this.lblRouteNameData.Name = "lblRouteNameData";
            this.lblRouteNameData.Size = new System.Drawing.Size(0, 17);
            this.lblRouteNameData.TabIndex = 3;
            this.lblRouteNameData.Tag = "";
            // 
            // lblRouteName
            // 
            this.lblRouteName.AutoSize = true;
            this.lblRouteName.Location = new System.Drawing.Point(15, 89);
            this.lblRouteName.Name = "lblRouteName";
            this.lblRouteName.Size = new System.Drawing.Size(97, 17);
            this.lblRouteName.TabIndex = 2;
            this.lblRouteName.Text = "Route Name";
            // 
            // lblOriginPlanetData
            // 
            this.lblOriginPlanetData.AutoSize = true;
            this.lblOriginPlanetData.ForeColor = System.Drawing.Color.Blue;
            this.lblOriginPlanetData.Location = new System.Drawing.Point(18, 41);
            this.lblOriginPlanetData.Name = "lblOriginPlanetData";
            this.lblOriginPlanetData.Size = new System.Drawing.Size(0, 17);
            this.lblOriginPlanetData.TabIndex = 1;
            this.lblOriginPlanetData.Tag = "";
            // 
            // lblOriginPlanet
            // 
            this.lblOriginPlanet.AutoSize = true;
            this.lblOriginPlanet.Location = new System.Drawing.Point(15, 9);
            this.lblOriginPlanet.Name = "lblOriginPlanet";
            this.lblOriginPlanet.Size = new System.Drawing.Size(52, 17);
            this.lblOriginPlanet.TabIndex = 0;
            this.lblOriginPlanet.Text = "Origin";
            // 
            // pnlLeft
            // 
            this.pnlLeft.AutoScroll = true;
            this.pnlLeft.Controls.Add(this.pnlDestination);
            this.pnlLeft.Controls.Add(this.pnlOrigin);
            this.pnlLeft.Controls.Add(this.lblOrigin);
            this.pnlLeft.Controls.Add(this.pnlData);
            this.pnlLeft.Controls.Add(this.cmbOriginData);
            this.pnlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnlLeft.Location = new System.Drawing.Point(0, 0);
            this.pnlLeft.Name = "pnlLeft";
            this.pnlLeft.Size = new System.Drawing.Size(972, 1061);
            this.pnlLeft.TabIndex = 16;
            // 
            // frmHES
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1924, 1061);
            this.Controls.Add(this.pnlLeft);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmHES";
            this.Text = "HyperSpace Engine System";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmHES_Load);
            this.pnlDestination.ResumeLayout(false);
            this.pnlDestination.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDestination)).EndInit();
            this.pnlData.ResumeLayout(false);
            this.pnlData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgPlanet1)).EndInit();
            this.pnlOrigin.ResumeLayout(false);
            this.pnlOrigin.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgOriginPlanet)).EndInit();
            this.pnlLeft.ResumeLayout(false);
            this.pnlLeft.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lblOrigin;
        private System.Windows.Forms.ComboBox cmbOriginData;
        private System.Windows.Forms.Panel pnlDestination;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.ComboBox cmbDestinationData2;
        private System.Windows.Forms.ComboBox cmbDestinationData1;
        private System.Windows.Forms.Label lblDestination;
        private System.Windows.Forms.DataGridView dgvDestination;
        private System.Windows.Forms.Panel pnlData;
        private System.Windows.Forms.PictureBox imgPlanet1;
        private System.Windows.Forms.ListBox lbRoutesData;
        private System.Windows.Forms.Label lblRoutes;
        private System.Windows.Forms.Label lblLatitudeData;
        private System.Windows.Forms.Label lblLatitude;
        private System.Windows.Forms.Label lblLongitudeData;
        private System.Windows.Forms.Label lblLongitude;
        private System.Windows.Forms.Label lblFiliationData;
        private System.Windows.Forms.Label lblFiliation;
        private System.Windows.Forms.Label lblNativesData;
        private System.Windows.Forms.Label lblNatives;
        private System.Windows.Forms.Label lblSectorData;
        private System.Windows.Forms.Label lblSector;
        private System.Windows.Forms.Label lblPlanetData;
        private System.Windows.Forms.Label lblPlanet;
        private System.Windows.Forms.Panel pnlOrigin;
        private System.Windows.Forms.Label lblTypeRouteData;
        private System.Windows.Forms.PictureBox imgOriginPlanet;
        private System.Windows.Forms.Label lblTypeRoute;
        private System.Windows.Forms.Label lblDestinationPlanetData;
        private System.Windows.Forms.Label lblDestinationPlanet;
        private System.Windows.Forms.Label lblRouteNameData;
        private System.Windows.Forms.Label lblRouteName;
        private System.Windows.Forms.Label lblOriginPlanetData;
        private System.Windows.Forms.Label lblOriginPlanet;
        private System.Windows.Forms.Panel pnlLeft;
    }
}

