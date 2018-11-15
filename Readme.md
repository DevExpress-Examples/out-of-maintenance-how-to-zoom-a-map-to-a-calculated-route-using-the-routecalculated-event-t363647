<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/ZoomToFitOnRouteCalculated/Form1.cs) (VB: [Form1.vb](./VB/ZoomToFitOnRouteCalculated/Form1.vb))
<!-- default file list end -->
# How to zoom a map to a calculated route using the RouteCalculated event


This example demonstrates how to zoom a map to the calculated route.


<h3>Description</h3>

<p>To do this, handle the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteDataProvider_RouteCalculatedtopic">BingRouteDataProvider.RouteCalculated</a>&nbsp;event. In the event handler, using the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteResult_BoundingBoxtopic">BingRouteResult.BoundingBox</a>&nbsp;property, get the top-left (using the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapSearchBoundingBox_NorthLatitudetopic">SearchBoundingBox.NorthLatitude</a>&nbsp;and <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapSearchBoundingBox_WestLongitudetopic">SearchBoundingBox.WestLongitude</a>&nbsp;properties) and right-bottom corner (using the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapSearchBoundingBox_SouthLatitudetopic">SearchBoundingBox.SouthLatitude</a>&nbsp;and <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapSearchBoundingBox_EastLongitudetopic">SearchBoundingBox.EastLongitude</a>&nbsp;properties) of the required region. Then, using the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapMapControl_ZoomToRegiontopic">MapControl.ZoomToRegion</a>&nbsp;method, zoom the map to the required rectangle specified by the corners.</p>

<br/>


