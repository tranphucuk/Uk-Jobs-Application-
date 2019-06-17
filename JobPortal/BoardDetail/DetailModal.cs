using JobPortal.JobData;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace JobPortal
{
    public partial class DetailModal : DevExpress.XtraEditors.XtraForm
    {
        public DetailModal()
        {
            InitializeComponent();
        }

        public DetailModal(JobInfo jobInfo)
        {
            InitializeComponent();
            teIndustry.Text = jobInfo.Industry;
            teCompany.Text = jobInfo.Company;
            teTier.Text = jobInfo.Tier;
            teWebsite.Text = jobInfo.Website;
            teSocial.Text = jobInfo.Social;
            teCity.Text = jobInfo.City;
            teDate.Text = jobInfo.AddedDate;
        }

        private void lblCloseModal_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public bool BeingDragged = false;
        public int MouseDownX, MousedownY;

        private void lblModalDetails_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                BeingDragged = true;
                MouseDownX = e.X;
                MousedownY = e.Y;
            }
        }

        private void lblModalDetails_MouseMove(object sender, MouseEventArgs e)
        {
            if (BeingDragged == true)
            {
                var form = this.FindForm();
                Point mousePoint = new Point();
                mousePoint.X = form.Location.X + (e.X - MouseDownX);
                mousePoint.Y = form.Location.Y + (e.Y - MousedownY);
                form.Location = mousePoint;
            }
        }

        private void btnSaveModalForm_Click(object sender, EventArgs e)
        {
            var ofd = new SaveFileDialog();
            ofd.Title = "Save job";
            ofd.Filter = "File text|*.txt";
            if (ofd.ShowDialog() == DialogResult.Cancel) return;

            var filePath = ofd.FileName;
            File.WriteAllText(filePath,
                $"{teIndustry.Text}|{teCompany.Text}|{teTier.Text}|{teCity.Text}|{teWebsite.Text}|{teSocial.Text}|{teDate.Text}");
            Process.Start(filePath);
        }

        private void lblModalDetails_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                BeingDragged = false;
            }
        }
    }
}