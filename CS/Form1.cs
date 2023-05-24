using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace RepPrintOnDotMatrix {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

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

    }
}