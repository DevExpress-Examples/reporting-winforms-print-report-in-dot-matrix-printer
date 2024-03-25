Imports System
Imports System.ComponentModel
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Diagnostics

Namespace RepPrintOnDotMatrix

    Public Partial Class Form1
        Inherits Form

        Public Sub New()
            InitializeComponent()
        End Sub

        Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs)
            Dim report As XtraReport1 = New XtraReport1()
            report.CreateDocument()
            printControl1.PrintingSystem = report.PrintingSystem
        End Sub

        Private Sub barButtonItem2_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs)
            printControl1.PrintingSystem.ExportToCsv(Application.StartupPath & "\temporary.csv", New DevExpress.XtraPrinting.CsvExportOptions(",", Encoding.Default))
            Dim psi As ProcessStartInfo = New ProcessStartInfo()
            psi.FileName = Application.StartupPath & "\temporary.csv"
            psi.Verb = "Print"
            Call Process.Start(psi)
        End Sub
    End Class
End Namespace
