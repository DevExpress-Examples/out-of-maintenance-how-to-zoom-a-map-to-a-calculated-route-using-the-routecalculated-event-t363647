using DevExpress.XtraMap;
using System.Collections.Generic;
using System.Windows.Forms;

namespace ZoomToFitOnRouteCalculated {
    public partial class Form1 : Form {
        InformationLayer Layer { get { return (InformationLayer)mapControl.Layers[1]; } }
        BingRouteDataProvider Provider { get { return (BingRouteDataProvider)Layer.DataProvider; } }
        public Form1() {
            InitializeComponent();
        }
        void OnRouteCalculated(object sender, BingRouteCalculatedEventArgs e) {
            SearchBoundingBox bBox = e.CalculationResult.RouteResults[0].BoundingBox;
            mapControl.ZoomToRegion(new GeoPoint(bBox.NorthLatitude, bBox.WestLongitude), new GeoPoint(bBox.SouthLatitude, bBox.EastLongitude), 0.4);
            splashScreenManager.CloseWaitForm();
        }
        private void Form1_Load(object sender, System.EventArgs e) {
            Provider.RouteCalculated += OnRouteCalculated;
            Provider.CalculateRoute(new List<RouteWaypoint> {
                new RouteWaypoint("New York", new GeoPoint(41.145556, -73.995)),
                new RouteWaypoint("Oklahoma", new GeoPoint(36.131389, -95.937222)),
                new RouteWaypoint("Las Vegas", new GeoPoint(36.175, -115.136389))
            });
            splashScreenManager.ShowWaitForm();
        }
    }
}
