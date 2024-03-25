Namespace RepPrintOnDotMatrix

    Partial Class XtraReport1

        ''' <summary>
        ''' Required designer variable.
        ''' </summary>
        Private components As System.ComponentModel.IContainer = Nothing

        ''' <summary> 
        ''' Clean up any resources being used.
        ''' </summary>
        ''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        Protected Overrides Sub Dispose(ByVal disposing As Boolean)
            If disposing AndAlso (Me.components IsNot Nothing) Then
                Me.components.Dispose()
            End If

            MyBase.Dispose(disposing)
        End Sub

'#Region "Designer generated code"
        ''' <summary>
        ''' Required method for Designer support - do not modify
        ''' the contents of this method with the code editor.
        ''' </summary>
        Private Sub InitializeComponent()
            Me.Detail = New DevExpress.XtraReports.UI.DetailBand()
            Me.xrLabel2 = New DevExpress.XtraReports.UI.XRLabel()
            Me.xrLabel1 = New DevExpress.XtraReports.UI.XRLabel()
            Me.PageHeader = New DevExpress.XtraReports.UI.PageHeaderBand()
            Me.PageFooter = New DevExpress.XtraReports.UI.PageFooterBand()
            Me.nwindDataSet1 = New RepPrintOnDotMatrix.nwindDataSet()
            Me.categoriesTableAdapter = New RepPrintOnDotMatrix.nwindDataSetTableAdapters.CategoriesTableAdapter()
            Me.xrPanel1 = New DevExpress.XtraReports.UI.XRPanel()
            CType((Me.nwindDataSet1), System.ComponentModel.ISupportInitialize).BeginInit()
            CType((Me), System.ComponentModel.ISupportInitialize).BeginInit()
            ' 
            ' Detail
            ' 
            Me.Detail.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrPanel1})
            Me.Detail.Height = 75
            Me.Detail.Name = "Detail"
            Me.Detail.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' xrLabel2
            ' 
            Me.xrLabel2.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.Description", "")})
            Me.xrLabel2.ForeColor = System.Drawing.Color.Blue
            Me.xrLabel2.Location = New System.Drawing.Point(8, 42)
            Me.xrLabel2.Name = "xrLabel2"
            Me.xrLabel2.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel2.Size = New System.Drawing.Size(333, 25)
            Me.xrLabel2.StylePriority.UseBackColor = False
            Me.xrLabel2.StylePriority.UseForeColor = False
            Me.xrLabel2.Text = "xrLabel2"
            ' 
            ' xrLabel1
            ' 
            Me.xrLabel1.BorderColor = System.Drawing.Color.Yellow
            Me.xrLabel1.Borders = CType(((((DevExpress.XtraPrinting.BorderSide.Left Or DevExpress.XtraPrinting.BorderSide.Top) Or DevExpress.XtraPrinting.BorderSide.Right) Or DevExpress.XtraPrinting.BorderSide.Bottom)), DevExpress.XtraPrinting.BorderSide)
            Me.xrLabel1.DataBindings.AddRange(New DevExpress.XtraReports.UI.XRBinding() {New DevExpress.XtraReports.UI.XRBinding("Text", Nothing, "Categories.CategoryName", "")})
            Me.xrLabel1.ForeColor = System.Drawing.Color.Red
            Me.xrLabel1.Location = New System.Drawing.Point(8, 8)
            Me.xrLabel1.Name = "xrLabel1"
            Me.xrLabel1.Padding = New DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F)
            Me.xrLabel1.Size = New System.Drawing.Size(175, 25)
            Me.xrLabel1.StylePriority.UseBorderColor = False
            Me.xrLabel1.StylePriority.UseBorders = False
            Me.xrLabel1.StylePriority.UseForeColor = False
            Me.xrLabel1.Text = "xrLabel1"
            ' 
            ' PageHeader
            ' 
            Me.PageHeader.Height = 30
            Me.PageHeader.Name = "PageHeader"
            Me.PageHeader.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.PageHeader.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' PageFooter
            ' 
            Me.PageFooter.Height = 30
            Me.PageFooter.Name = "PageFooter"
            Me.PageFooter.Padding = New DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F)
            Me.PageFooter.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft
            ' 
            ' nwindDataSet1
            ' 
            Me.nwindDataSet1.DataSetName = "nwindDataSet"
            Me.nwindDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema
            ' 
            ' categoriesTableAdapter
            ' 
            Me.categoriesTableAdapter.ClearBeforeFill = True
            ' 
            ' xrPanel1
            ' 
            Me.xrPanel1.BackColor = System.Drawing.Color.FromArgb((CInt(((CByte((192)))))), (CInt(((CByte((255)))))), (CInt(((CByte((255)))))))
            Me.xrPanel1.Controls.AddRange(New DevExpress.XtraReports.UI.XRControl() {Me.xrLabel2, Me.xrLabel1})
            Me.xrPanel1.Location = New System.Drawing.Point(0, 0)
            Me.xrPanel1.Name = "xrPanel1"
            Me.xrPanel1.Size = New System.Drawing.Size(650, 75)
            Me.xrPanel1.StylePriority.UseBackColor = False
            ' 
            ' XtraReport1
            ' 
            Me.Bands.AddRange(New DevExpress.XtraReports.UI.Band() {Me.Detail, Me.PageHeader, Me.PageFooter})
            Me.DataAdapter = Me.categoriesTableAdapter
            Me.DataMember = "Categories"
            Me.DataSource = Me.nwindDataSet1
            Me.Version = "9.1"
            CType((Me.nwindDataSet1), System.ComponentModel.ISupportInitialize).EndInit()
            CType((Me), System.ComponentModel.ISupportInitialize).EndInit()
        End Sub

'#End Region
        Private Detail As DevExpress.XtraReports.UI.DetailBand

        Private PageHeader As DevExpress.XtraReports.UI.PageHeaderBand

        Private PageFooter As DevExpress.XtraReports.UI.PageFooterBand

        Private nwindDataSet1 As RepPrintOnDotMatrix.nwindDataSet

        Private categoriesTableAdapter As RepPrintOnDotMatrix.nwindDataSetTableAdapters.CategoriesTableAdapter

        Private xrLabel2 As DevExpress.XtraReports.UI.XRLabel

        Private xrLabel1 As DevExpress.XtraReports.UI.XRLabel

        Private xrPanel1 As DevExpress.XtraReports.UI.XRPanel
    End Class
End Namespace
