Namespace ZoomToFitOnRouteCalculated
    Partial Public Class Form1
        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary>
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (components IsNot Nothing) Then
                components.Dispose()
            End If
            MyBase.Dispose(disposing)
        End Sub

        #Region "Windows Form Designer generated code"

        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.components = New System.ComponentModel.Container()
            Dim imageLayer1 As New DevExpress.XtraMap.ImageLayer()
            Dim openStreetMapDataProvider1 As New DevExpress.XtraMap.OpenStreetMapDataProvider()
            Dim informationLayer1 As New DevExpress.XtraMap.InformationLayer()
            Dim bingRouteDataProvider1 As New DevExpress.XtraMap.BingRouteDataProvider()
            Me.mapControl = New DevExpress.XtraMap.MapControl()
            Me.splashScreenManager = New DevExpress.XtraSplashScreen.SplashScreenManager(Me, GetType(Global.ZoomToFitOnRouteCalculated.WaitForm1), True, True)
            Me.defaultLookAndFeel = New DevExpress.LookAndFeel.DefaultLookAndFeel(Me.components)
            DirectCast(Me.mapControl, System.ComponentModel.ISupportInitialize).BeginInit()
            Me.SuspendLayout()
            ' 
            ' mapControl
            ' 
            Me.mapControl.Dock = System.Windows.Forms.DockStyle.Fill
            imageLayer1.DataProvider = openStreetMapDataProvider1
            bingRouteDataProvider1.BingKey = "INSERT_YOUR_BING_KEY"
            informationLayer1.DataProvider = bingRouteDataProvider1
            informationLayer1.ItemStyle.Stroke = System.Drawing.Color.FromArgb((CInt((CByte(0)))), (CInt((CByte(114)))), (CInt((CByte(194)))))
            informationLayer1.ItemStyle.StrokeWidth = 4
            Me.mapControl.Layers.Add(imageLayer1)
            Me.mapControl.Layers.Add(informationLayer1)
            Me.mapControl.Location = New System.Drawing.Point(0, 0)
            Me.mapControl.Name = "mapControl"
            Me.mapControl.Size = New System.Drawing.Size(570, 442)
            Me.mapControl.TabIndex = 0
            ' 
            ' splashScreenManager
            ' 
            Me.splashScreenManager.ClosingDelay = 500
            ' 
            ' defaultLookAndFeel
            ' 
            Me.defaultLookAndFeel.LookAndFeel.SkinName = "Office 2016 Colorful"
            ' 
            ' Form1
            ' 
            Me.AutoScaleDimensions = New System.Drawing.SizeF(6F, 13F)
            Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
            Me.ClientSize = New System.Drawing.Size(570, 442)
            Me.Controls.Add(Me.mapControl)
            Me.Name = "Form1"
            Me.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen
            Me.Text = "Form1"
            DirectCast(Me.mapControl, System.ComponentModel.ISupportInitialize).EndInit()
            Me.ResumeLayout(False)

        End Sub

        #End Region

        Private mapControl As DevExpress.XtraMap.MapControl
        Private splashScreenManager As DevExpress.XtraSplashScreen.SplashScreenManager
        Private defaultLookAndFeel As DevExpress.LookAndFeel.DefaultLookAndFeel
    End Class
End Namespace

