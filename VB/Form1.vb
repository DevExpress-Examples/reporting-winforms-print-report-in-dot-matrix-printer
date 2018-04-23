Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.ComponentModel
Imports System.Data
Imports System.Drawing
Imports System.Text
Imports System.Windows.Forms
Imports System.Diagnostics

Namespace RepPrintOnDotMatrix
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
		End Sub

		Private Sub Form1_Load(ByVal sender As Object, ByVal e As EventArgs) Handles MyBase.Load
			Dim report As New XtraReport1()

			report.CreateDocument()
			printControl1.PrintingSystem = report.PrintingSystem
		End Sub

		Private Sub barButtonItem2_ItemClick(ByVal sender As Object, ByVal e As DevExpress.XtraBars.ItemClickEventArgs) Handles barButtonItem2.ItemClick
			printControl1.PrintingSystem.ExportToCsv(Application.StartupPath & "\temporary.csv", New DevExpress.XtraPrinting.CsvExportOptions(",", Encoding.Default))

			Dim psi As New ProcessStartInfo()

			psi.FileName = Application.StartupPath & "\temporary.csv"
			psi.Verb = "Print"

			Process.Start(psi)
		End Sub

	End Class
End Namespace