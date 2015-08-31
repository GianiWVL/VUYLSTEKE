using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TIS.Client.Vacation
{
    public partial class Vacations : DevExpress.XtraEditors.XtraForm
    {
        public Vacations()
        {
            InitializeComponent();
        }

        private void btnExportExcel_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            sfd.Filter = "Excel Documents (*.xlsx, *.xls)|*.xlsx;*.xls";
            sfd.DefaultExt = ".xlsx";

            if (sfd.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                gdcVacation.ExportToXlsx(sfd.FileName);
                ProcessStartInfo psi = new ProcessStartInfo(sfd.FileName);
                psi.UseShellExecute = true;
                Process.Start(psi);
            }
        }
    }
}
