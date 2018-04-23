Imports DevExpress.XtraMap
Imports System.Collections.Generic
Imports System.Windows.Forms

Namespace ZoomToFitOnRouteCalculated
    Partial Public Class Form1
        Inherits Form

        Private ReadOnly Property Layer() As InformationLayer
            Get
                Return CType(mapControl.Layers(1), InformationLayer)
            End Get
        End Property
        Private ReadOnly Property Provider() As BingRouteDataProvider
            Get
                Return CType(Layer.DataProvider, BingRouteDataProvider)
            End Get
        End Property
        Public Sub New()
            InitializeComponent()
        End Sub
        Private Sub OnRouteCalculated(ByVal sender As Object, ByVal e As BingRouteCalculatedEventArgs)
            Dim bBox As SearchBoundingBox = e.CalculationResult.RouteResults(0).BoundingBox
            mapControl.ZoomToRegion(New GeoPoint(bBox.NorthLatitude, bBox.WestLongitude), New GeoPoint(bBox.SouthLatitude, bBox.EastLongitude), 0.4)
            splashScreenManager.CloseWaitForm()
        End Sub
        Private Sub Form1_Load(ByVal sender As Object, ByVal e As System.EventArgs) Handles MyBase.Load
            AddHandler Provider.RouteCalculated, AddressOf OnRouteCalculated
            Provider.CalculateRoute(New List(Of RouteWaypoint) From { _
                New RouteWaypoint("New York", New GeoPoint(41.145556, -73.995)), _
                New RouteWaypoint("Oklahoma", New GeoPoint(36.131389, -95.937222)), _
                New RouteWaypoint("Las Vegas", New GeoPoint(36.175, -115.136389)) _
            })
            splashScreenManager.ShowWaitForm()
        End Sub
    End Class
End Namespace
