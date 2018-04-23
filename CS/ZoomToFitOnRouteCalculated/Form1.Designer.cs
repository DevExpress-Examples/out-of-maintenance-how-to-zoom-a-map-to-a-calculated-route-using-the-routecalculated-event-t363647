namespace ZoomToFitOnRouteCalculated {
    partial class Form1 {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if(disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraMap.ImageLayer imageLayer1 = new DevExpress.XtraMap.ImageLayer();
            DevExpress.XtraMap.OpenStreetMapDataProvider openStreetMapDataProvider1 = new DevExpress.XtraMap.OpenStreetMapDataProvider();
            DevExpress.XtraMap.InformationLayer informationLayer1 = new DevExpress.XtraMap.InformationLayer();
            DevExpress.XtraMap.BingRouteDataProvider bingRouteDataProvider1 = new DevExpress.XtraMap.BingRouteDataProvider();
            this.mapControl = new DevExpress.XtraMap.MapControl();
            this.splashScreenManager = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::ZoomToFitOnRouteCalculated.WaitForm1), true, true);
            this.defaultLookAndFeel = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.mapControl)).BeginInit();
            this.SuspendLayout();
            // 
            // mapControl
            // 
            this.mapControl.Dock = System.Windows.Forms.DockStyle.Fill;
            imageLayer1.DataProvider = openStreetMapDataProvider1;
            bingRouteDataProvider1.BingKey = "INSERT_YOUR_BING_KEY";
            informationLayer1.DataProvider = bingRouteDataProvider1;
            informationLayer1.ItemStyle.Stroke = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(114)))), ((int)(((byte)(194)))));
            informationLayer1.ItemStyle.StrokeWidth = 4;
            this.mapControl.Layers.Add(imageLayer1);
            this.mapControl.Layers.Add(informationLayer1);
            this.mapControl.Location = new System.Drawing.Point(0, 0);
            this.mapControl.Name = "mapControl";
            this.mapControl.Size = new System.Drawing.Size(570, 442);
            this.mapControl.TabIndex = 0;
            // 
            // splashScreenManager
            // 
            this.splashScreenManager.ClosingDelay = 500;
            // 
            // defaultLookAndFeel
            // 
            this.defaultLookAndFeel.LookAndFeel.SkinName = "Office 2016 Colorful";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(570, 442);
            this.Controls.Add(this.mapControl);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.mapControl)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraMap.MapControl mapControl;
        private DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager;
        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel;
    }
}

