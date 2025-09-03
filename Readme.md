<!-- default badges list -->
![](https://img.shields.io/endpoint?url=https://codecentral.devexpress.com/api/v1/VersionRange/128602332/24.2.1%2B)
[![](https://img.shields.io/badge/Open_in_DevExpress_Support_Center-FF7200?style=flat-square&logo=DevExpress&logoColor=white)](https://supportcenter.devexpress.com/ticket/details/E1467)
[![](https://img.shields.io/badge/📖_How_to_use_DevExpress_Examples-e9f6fc?style=flat-square)](https://docs.devexpress.com/GeneralInformation/403183)
[![](https://img.shields.io/badge/💬_Leave_Feedback-feecdd?style=flat-square)](#does-this-example-address-your-development-requirementsobjectives)
<!-- default badges end -->

# Reporting for WinForms - How to Print a Report on a Dot Matrix Printer

To print a DevExpress report on a dot matrix printer, use the following workaround:

* Export the report to text format (CSV or TXT).
* Send the resulting file to the printer.  

## Implementation Details

* Export the report to CSV and save it to a temporary file (temporary.csv, in this example). 
* Create a [ProcessStartInfo](https://learn.microsoft.com/en-us/dotnet/api/system.diagnostics.processstartinfo) object and assign “Print" to the `Verb` property (if this verb is listed among supported options).
* Call the [Process.Start](https://learn.microsoft.com/en-us/dotnet/api/system.diagnostics.process.start) method and pass the customized `ProcessStartInfo` object as the parameter.

```cs
private void Form1_Load(object sender, EventArgs e) {
   XtraReport1 report = new XtraReport1();
   report.CreateDocument();
   printControl1.PrintingSystem = report.PrintingSystem;
}

private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e) {
    printControl1.PrintingSystem.ExportToCsv(Application.StartupPath + "\\temporary.csv", new DevExpress.XtraPrinting.CsvExportOptions(",", Encoding.Default));
    ProcessStartInfo startInfo = new ProcessStartInfo(Application.StartupPath + "\\temporary.csv");
    startInfo.Verb = "Open";
    foreach (var verb in startInfo.Verbs) {
        if (verb == "Print") startInfo.Verb = "Print";
    }
    Process.Start(startInfo);
}
```

## Files to Review

* [Form1.cs](./CS/Form1.cs) (VB: [Form1.vb](./VB/Form1.vb))

## Documentation

- [Print Reports](https://docs.devexpress.com/XtraReports/15797/detailed-guide-to-devexpress-reporting/store-and-distribute-reports/print-reports)
- [Export Reports](https://docs.devexpress.com/XtraReports/1302/detailed-guide-to-devexpress-reporting/store-and-distribute-reports/export-reports)

<!-- feedback -->
## Does this example address your development requirements/objectives?

[<img src="https://www.devexpress.com/support/examples/i/yes-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-winforms-print-report-in-dot-matrix-printer&~~~was_helpful=yes) [<img src="https://www.devexpress.com/support/examples/i/no-button.svg"/>](https://www.devexpress.com/support/examples/survey.xml?utm_source=github&utm_campaign=reporting-winforms-print-report-in-dot-matrix-printer&~~~was_helpful=no)

(you will be redirected to DevExpress.com to submit your response)
<!-- feedback end -->


