using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using JobPortal.ActionModule;
using JobPortal.BoardDetail;
using JobPortal.JobData;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Windows.Forms;

namespace JobPortal
{
    public partial class frmJobScanner : DevExpress.XtraEditors.XtraForm
    {
        private ScanJob scanner = new ScanJob();
        public frmJobScanner()
        {
            InitializeComponent();
            InitializeData();
            CheckForIllegalCrossThreadCalls = false;
            scanner.UpdateJobData += Scanner_UpdateJobData;
            scanner.CompleteTask += Scanner_CompleteTask;
            scanner.UpdateRecord += Scanner_UpdateRecord;
            scanner.StopThreads += Scanner_StopThreads;
        }

        private void Scanner_StopThreads(object sender, Events.StopThreadEventArg e)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                lblTotalRecord.Text = e.Status;
                if (e.isStopped)
                {
                    btnSearch.Enabled = true;
                    btnSearch.Text = "Search...";
                    lblStatus.Text = "Ready...";
                    btnSearch.Image = Properties.Resources.Stop;
                    lblStatus.Appearance.Image = Properties.Resources.batquai1;
                }
            }));
        }

        private void Scanner_CompleteTask(object sender, Events.TaskSuccessEventArg e)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                if (e.IsComplete)
                {
                    XtraMessageBox.Show($"Found {e.Total.Count} jobs!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnSearch.Image = Properties.Resources.Start;
                    btnSearch.Text = "Search...";
                    lblStatus.Text = "Done...";
                    lblStatus.Appearance.Image = Properties.Resources.batquai1;
                    btnSearch.Enabled = true;
                    scanner.isStopped = true;
                }
            }));
        }

        private void Scanner_UpdateRecord(object sender, JobEventArg e)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                lblTotalRecord.Text = $"Total Record: {e.Data.Count()}";
            }));
        }

        private void Scanner_UpdateJobData(object sender, JobEventArg e)
        {
            this.Invoke(new MethodInvoker(() =>
            {
                gridControl1.DataSource = e.Data;
                gridControl1.RefreshDataSource();
            }));
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            scanner.isStopped = !scanner.isStopped;
            Configuration();
            new Thread(() =>
            {
                scanner.StartScan(new InfoRun()
                {
                    Industry = leIndustry.EditValue.ToString(),
                    City = teCity.Text,
                    Tier = leTier.EditValue.ToString()
                });
            })
            { IsBackground = true }.Start();
        }

        private void Configuration()
        {
            if (scanner.isStopped)
            {
                btnSearch.Enabled = false;
            }
            else
            {
                btnSearch.Text = "Stop...";
                lblStatus.Text = "Running";
                btnSearch.Image = Properties.Resources.Stop;
                lblStatus.Appearance.Image = Properties.Resources.loadinfo_net__5_; ;
            }
        }

        private void InitializeData()
        {
            gridControl1.DataSource = new List<JobInfo>();
            gridView1.Columns["Tier"].Visible = false;
            gridView1.Columns["AddedDate"].Visible = false;
            gridView1.Columns["Social"].Visible = false;
            gridView1.Columns["City"].Width = 40;

            var industry = JobStatic.Instance.Industries;
            leIndustry.Properties.DataSource = industry;
            leIndustry.Properties.Columns.Add(new LookUpColumnInfo("Name", string.Empty));
            leIndustry.EditValue = industry[0].Id;

            var tiers = JobStatic.Instance.Tiers;
            leTier.Properties.DataSource = tiers;
            leTier.Properties.Columns.Add(new LookUpColumnInfo("Name", string.Empty));
            leTier.EditValue = industry[0].Id;
            tmrClock.Start();
        }

        private void lblCloseForm_Click(object sender, EventArgs e)
        {
            var closeConfirm = XtraMessageBox.Show("Close this application ?", "Message", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (closeConfirm == DialogResult.OK)
            {
                if (System.Windows.Forms.Application.MessageLoop)
                {
                    // WinForms app
                    System.Windows.Forms.Application.Exit();
                }
                else
                {
                    // Console app
                    System.Environment.Exit(1);
                }
            }
        }

        private void lblHideForm_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        public bool BeingDragged = false;
        public int MouseDownX, MousedownY;

        private void lblMoveForm_MouseUp(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                BeingDragged = false;
            }
        }

        private void lblMoveForm_MouseDown(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                BeingDragged = true;
                MouseDownX = e.X;
                MousedownY = e.Y;
            }
        }

        private int timeValue;
        private object obj = new object();

        private void tmrClock_Tick(object sender, EventArgs e)
        {
            timeValue++;
            lblClock.Text = TimeSpan.FromSeconds(timeValue).ToString();
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            var rowSelected = gridView1.GetFocusedRow() as JobInfo;
            if (rowSelected == null) return;

            var modal = new DetailModal();
            var modalResult = new DetailModal(rowSelected);
            modalResult.StartPosition = FormStartPosition.CenterScreen;
            modalResult.ShowDialog();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var rowSelected = gridView1.GetFocusedRow() as JobInfo;
            if (rowSelected == null) return;

            var ofd = new SaveFileDialog();
            ofd.Title = "Save job";
            ofd.Filter = "File text|*.txt";
            if (ofd.ShowDialog() == DialogResult.Cancel) return;

            var filePath = ofd.FileName;
            File.WriteAllText(filePath,
                $"{rowSelected.Industry}|{rowSelected.Company}|{rowSelected.Tier}|{rowSelected.City}|" +
                $"{rowSelected.Website}|{rowSelected.Social}|{rowSelected.AddedDate}");

            Process.Start(filePath);
        }

        private void teCity_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnSearch_Click(this, null);
            }
        }

        private void lblMoveForm_MouseMove(object sender, MouseEventArgs e)
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
    }
}