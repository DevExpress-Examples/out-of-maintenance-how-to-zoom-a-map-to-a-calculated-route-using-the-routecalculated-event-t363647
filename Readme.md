<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128576857/16.1.4%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/T363647)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
<!-- default badges end -->
<!-- default file list -->
*Files to look at*:

* [Form1.cs](./CS/ZoomToFitOnRouteCalculated/Form1.cs) (VB: [Form1.vb](./VB/ZoomToFitOnRouteCalculated/Form1.vb))
<!-- default file list end -->
# How to zoom a map to a calculated route using the RouteCalculated event


This example demonstrates how to zoom a map to the calculated route.


<h3>Description</h3>

<p>To do this, handle the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteDataProvider_RouteCalculatedtopic">BingRouteDataProvider.RouteCalculated</a>&nbsp;event. In the event handler, using the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapBingRouteResult_BoundingBoxtopic">BingRouteResult.BoundingBox</a>&nbsp;property, get the top-left (using the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapSearchBoundingBox_NorthLatitudetopic">SearchBoundingBox.NorthLatitude</a>&nbsp;and <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapSearchBoundingBox_WestLongitudetopic">SearchBoundingBox.WestLongitude</a>&nbsp;properties) and right-bottom corner (using the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapSearchBoundingBox_SouthLatitudetopic">SearchBoundingBox.SouthLatitude</a>&nbsp;and <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapSearchBoundingBox_EastLongitudetopic">SearchBoundingBox.EastLongitude</a>&nbsp;properties) of the required region. Then, using the <a href="https://documentation.devexpress.com/#WindowsForms/DevExpressXtraMapMapControl_ZoomToRegiontopic">MapControl.ZoomToRegion</a>&nbsp;method, zoom the map to the required rectangle specified by the corners.</p>

<br/>


