namespace JobPortal
{
    partial class frmJobScanner
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJobScanner));
            this.defaultLookAndFeel1 = new DevExpress.LookAndFeel.DefaultLookAndFeel(this.components);
            this.lblMoveForm = new DevExpress.XtraEditors.LabelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.lblTotalRecord = new DevExpress.XtraEditors.LabelControl();
            this.lblStatus = new DevExpress.XtraEditors.LabelControl();
            this.lblClock = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.btnShowDetails = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSave = new System.Windows.Forms.ToolStripMenuItem();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.leIndustry = new DevExpress.XtraEditors.LookUpEdit();
            this.leTier = new DevExpress.XtraEditors.LookUpEdit();
            this.teCity = new DevExpress.XtraEditors.TextEdit();
            this.btnSearch = new System.Windows.Forms.Button();
            this.lblCloseForm = new DevExpress.XtraEditors.LabelControl();
            this.lblHideForm = new DevExpress.XtraEditors.LabelControl();
            this.tmrClock = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leIndustry.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.leTier.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCity.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // defaultLookAndFeel1
            // 
            this.defaultLookAndFeel1.LookAndFeel.SkinName = "Office 2013";
            // 
            // lblMoveForm
            // 
            this.lblMoveForm.Appearance.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblMoveForm.Appearance.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMoveForm.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblMoveForm.Appearance.Options.UseBackColor = true;
            this.lblMoveForm.Appearance.Options.UseFont = true;
            this.lblMoveForm.Appearance.Options.UseForeColor = true;
            this.lblMoveForm.Appearance.Options.UseTextOptions = true;
            this.lblMoveForm.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblMoveForm.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblMoveForm.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblMoveForm.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblMoveForm.Location = new System.Drawing.Point(0, 0);
            this.lblMoveForm.Name = "lblMoveForm";
            this.lblMoveForm.Size = new System.Drawing.Size(768, 43);
            this.lblMoveForm.TabIndex = 0;
            this.lblMoveForm.Text = "UK Sponsor Jobs Scanner";
            this.lblMoveForm.MouseDown += new System.Windows.Forms.MouseEventHandler(this.lblMoveForm_MouseDown);
            this.lblMoveForm.MouseMove += new System.Windows.Forms.MouseEventHandler(this.lblMoveForm_MouseMove);
            this.lblMoveForm.MouseUp += new System.Windows.Forms.MouseEventHandler(this.lblMoveForm_MouseUp);
            // 
            // panelControl2
            // 
            this.panelControl2.Appearance.BackColor = System.Drawing.Color.Black;
            this.panelControl2.Appearance.BackColor2 = System.Drawing.Color.Black;
            this.panelControl2.Appearance.BorderColor = System.Drawing.Color.Black;
            this.panelControl2.Appearance.ForeColor = System.Drawing.Color.Black;
            this.panelControl2.Appearance.Options.UseBackColor = true;
            this.panelControl2.Appearance.Options.UseBorderColor = true;
            this.panelControl2.Appearance.Options.UseForeColor = true;
            this.panelControl2.Controls.Add(this.lblTotalRecord);
            this.panelControl2.Controls.Add(this.lblStatus);
            this.panelControl2.Controls.Add(this.lblClock);
            this.panelControl2.Controls.Add(this.labelControl1);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 452);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(768, 34);
            this.panelControl2.TabIndex = 7;
            // 
            // lblTotalRecord
            // 
            this.lblTotalRecord.Appearance.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblTotalRecord.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F);
            this.lblTotalRecord.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblTotalRecord.Appearance.Options.UseBackColor = true;
            this.lblTotalRecord.Appearance.Options.UseFont = true;
            this.lblTotalRecord.Appearance.Options.UseForeColor = true;
            this.lblTotalRecord.Appearance.Options.UseTextOptions = true;
            this.lblTotalRecord.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTotalRecord.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblTotalRecord.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTotalRecord.Location = new System.Drawing.Point(226, 4);
            this.lblTotalRecord.Name = "lblTotalRecord";
            this.lblTotalRecord.Size = new System.Drawing.Size(311, 28);
            this.lblTotalRecord.TabIndex = 14;
            this.lblTotalRecord.Text = "Copyright © Tran Phuc";
            // 
            // lblStatus
            // 
            this.lblStatus.Appearance.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblStatus.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblStatus.Appearance.Image = global::JobPortal.Properties.Resources.batquai1;
            this.lblStatus.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblStatus.Appearance.Options.UseBackColor = true;
            this.lblStatus.Appearance.Options.UseFont = true;
            this.lblStatus.Appearance.Options.UseForeColor = true;
            this.lblStatus.Appearance.Options.UseImage = true;
            this.lblStatus.Appearance.Options.UseImageAlign = true;
            this.lblStatus.Appearance.Options.UseTextOptions = true;
            this.lblStatus.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Far;
            this.lblStatus.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblStatus.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblStatus.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblStatus.Location = new System.Drawing.Point(2, 2);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(85, 30);
            this.lblStatus.TabIndex = 13;
            this.lblStatus.Text = "Ready...";
            // 
            // lblClock
            // 
            this.lblClock.Appearance.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblClock.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClock.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblClock.Appearance.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.lblClock.Appearance.Options.UseBackColor = true;
            this.lblClock.Appearance.Options.UseFont = true;
            this.lblClock.Appearance.Options.UseForeColor = true;
            this.lblClock.Appearance.Options.UseImageAlign = true;
            this.lblClock.Appearance.Options.UseTextOptions = true;
            this.lblClock.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblClock.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblClock.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblClock.Dock = System.Windows.Forms.DockStyle.Right;
            this.lblClock.Location = new System.Drawing.Point(695, 2);
            this.lblClock.Name = "lblClock";
            this.lblClock.Size = new System.Drawing.Size(71, 30);
            this.lblClock.TabIndex = 8;
            this.lblClock.Text = "00:00:00 ";
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.labelControl1.Appearance.Options.UseBackColor = true;
            this.labelControl1.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.labelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelControl1.Location = new System.Drawing.Point(2, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(764, 30);
            this.labelControl1.TabIndex = 0;
            // 
            // gridControl1
            // 
            this.gridControl1.ContextMenuStrip = this.contextMenuStrip1;
            this.gridControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gridControl1.Location = new System.Drawing.Point(0, 130);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(768, 322);
            this.gridControl1.TabIndex = 8;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnShowDetails,
            this.btnSave});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(119, 56);
            // 
            // btnShowDetails
            // 
            this.btnShowDetails.Image = global::JobPortal.Properties.Resources.eye;
            this.btnShowDetails.Name = "btnShowDetails";
            this.btnShowDetails.Size = new System.Drawing.Size(118, 26);
            this.btnShowDetails.Text = "Show";
            this.btnShowDetails.Click += new System.EventHandler(this.btnShowDetails_Click);
            // 
            // btnSave
            // 
            this.btnSave.Image = global::JobPortal.Properties.Resources.download_button;
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(118, 26);
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // gridView1
            // 
            this.gridView1.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.None;
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsBehavior.Editable = false;
            this.gridView1.OptionsBehavior.ReadOnly = true;
            this.gridView1.OptionsMenu.EnableColumnMenu = false;
            this.gridView1.OptionsMenu.EnableFooterMenu = false;
            this.gridView1.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // leIndustry
            // 
            this.leIndustry.EditValue = "---------Select an industry---------";
            this.leIndustry.Location = new System.Drawing.Point(12, 75);
            this.leIndustry.Name = "leIndustry";
            this.leIndustry.Properties.AllowFocused = false;
            this.leIndustry.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leIndustry.Properties.Appearance.Options.UseFont = true;
            this.leIndustry.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leIndustry.Properties.AppearanceDropDown.Options.UseFont = true;
            this.leIndustry.Properties.AutoHeight = false;
            this.leIndustry.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.leIndustry.Properties.DisplayMember = "Name";
            this.leIndustry.Properties.ShowFooter = false;
            this.leIndustry.Properties.ValueMember = "Id";
            this.leIndustry.Size = new System.Drawing.Size(265, 29);
            this.leIndustry.TabIndex = 9;
            // 
            // leTier
            // 
            this.leTier.Location = new System.Drawing.Point(296, 75);
            this.leTier.Name = "leTier";
            this.leTier.Properties.AllowFocused = false;
            this.leTier.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leTier.Properties.Appearance.Options.UseFont = true;
            this.leTier.Properties.AppearanceDropDown.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.leTier.Properties.AppearanceDropDown.Options.UseFont = true;
            this.leTier.Properties.AutoHeight = false;
            this.leTier.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.leTier.Properties.DisplayMember = "Name";
            this.leTier.Properties.ShowFooter = false;
            this.leTier.Properties.ValueMember = "Id";
            this.leTier.Size = new System.Drawing.Size(129, 29);
            this.leTier.TabIndex = 9;
            // 
            // teCity
            // 
            this.teCity.Location = new System.Drawing.Point(447, 75);
            this.teCity.Name = "teCity";
            this.teCity.Properties.Appearance.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teCity.Properties.Appearance.Options.UseFont = true;
            this.teCity.Properties.AutoHeight = false;
            this.teCity.Properties.NullValuePrompt = "City...ex: London";
            this.teCity.Size = new System.Drawing.Size(165, 29);
            this.teCity.TabIndex = 10;
            this.teCity.KeyUp += new System.Windows.Forms.KeyEventHandler(this.teCity_KeyUp);
            // 
            // btnSearch
            // 
            this.btnSearch.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSearch.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.Image = global::JobPortal.Properties.Resources.Start;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(630, 75);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(124, 36);
            this.btnSearch.TabIndex = 15;
            this.btnSearch.Text = "Search...";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // lblCloseForm
            // 
            this.lblCloseForm.Appearance.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblCloseForm.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCloseForm.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblCloseForm.Appearance.Options.UseBackColor = true;
            this.lblCloseForm.Appearance.Options.UseFont = true;
            this.lblCloseForm.Appearance.Options.UseForeColor = true;
            this.lblCloseForm.Appearance.Options.UseTextOptions = true;
            this.lblCloseForm.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblCloseForm.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblCloseForm.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblCloseForm.Location = new System.Drawing.Point(734, 7);
            this.lblCloseForm.Name = "lblCloseForm";
            this.lblCloseForm.Size = new System.Drawing.Size(26, 16);
            this.lblCloseForm.TabIndex = 17;
            this.lblCloseForm.Text = "X";
            this.lblCloseForm.Click += new System.EventHandler(this.lblCloseForm_Click);
            // 
            // lblHideForm
            // 
            this.lblHideForm.Appearance.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.lblHideForm.Appearance.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHideForm.Appearance.ForeColor = System.Drawing.Color.White;
            this.lblHideForm.Appearance.Options.UseBackColor = true;
            this.lblHideForm.Appearance.Options.UseFont = true;
            this.lblHideForm.Appearance.Options.UseForeColor = true;
            this.lblHideForm.Appearance.Options.UseTextOptions = true;
            this.lblHideForm.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblHideForm.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblHideForm.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblHideForm.Location = new System.Drawing.Point(715, 4);
            this.lblHideForm.Name = "lblHideForm";
            this.lblHideForm.Size = new System.Drawing.Size(10, 16);
            this.lblHideForm.TabIndex = 16;
            this.lblHideForm.Text = "-";
            this.lblHideForm.Click += new System.EventHandler(this.lblHideForm_Click);
            // 
            // tmrClock
            // 
            this.tmrClock.Enabled = true;
            this.tmrClock.Interval = 1000;
            this.tmrClock.Tick += new System.EventHandler(this.tmrClock_Tick);
            // 
            // frmJobScanner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 486);
            this.Controls.Add(this.lblCloseForm);
            this.Controls.Add(this.lblHideForm);
            this.Controls.Add(this.lblMoveForm);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.teCity);
            this.Controls.Add(this.leTier);
            this.Controls.Add(this.leIndustry);
            this.Controls.Add(this.gridControl1);
            this.Controls.Add(this.panelControl2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = false;
            this.Name = "frmJobScanner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leIndustry.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.leTier.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teCity.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.LookAndFeel.DefaultLookAndFeel defaultLookAndFeel1;
        private DevExpress.XtraEditors.LabelControl lblMoveForm;
        private DevExpress.XtraEditors.LabelControl lblClock;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl lblStatus;
        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.LookUpEdit leIndustry;
        private DevExpress.XtraEditors.LookUpEdit leTier;
        private DevExpress.XtraEditors.TextEdit teCity;
        private System.Windows.Forms.Button btnSearch;
        private DevExpress.XtraEditors.LabelControl lblCloseForm;
        private DevExpress.XtraEditors.LabelControl lblHideForm;
        private System.Windows.Forms.Timer tmrClock;
        private DevExpress.XtraEditors.LabelControl lblTotalRecord;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem btnShowDetails;
        private System.Windows.Forms.ToolStripMenuItem btnSave;
    }
}

