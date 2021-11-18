namespace PMS.pharmasistUC
{
    partial class MedicineValidityCheck
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MedicineValidityCheck));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.checktxt = new Guna.UI2.WinForms.Guna2ComboBox();
            this.bunifuLabel9 = new Bunifu.UI.WinForms.BunifuLabel();
            this.MedicineGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.setlabel = new Bunifu.UI.WinForms.BunifuLabel();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MedicineGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.bunifuLabel1.Location = new System.Drawing.Point(59, 55);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(231, 47);
            this.bunifuLabel1.TabIndex = 42;
            this.bunifuLabel1.Text = "Add Medicine";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // checktxt
            // 
            this.checktxt.Animated = true;
            this.checktxt.BackColor = System.Drawing.Color.Transparent;
            this.checktxt.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(136)))));
            this.checktxt.BorderRadius = 10;
            this.checktxt.BorderThickness = 2;
            this.checktxt.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.checktxt.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.checktxt.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checktxt.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.checktxt.FocusedState.Parent = this.checktxt;
            this.checktxt.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold);
            this.checktxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(34)))), ((int)(((byte)(50)))));
            this.checktxt.HoverState.Parent = this.checktxt;
            this.checktxt.ItemHeight = 30;
            this.checktxt.Items.AddRange(new object[] {
            "Valid Medicines",
            "Expired Medcinies ",
            "View All Medcinies"});
            this.checktxt.ItemsAppearance.Parent = this.checktxt;
            this.checktxt.Location = new System.Drawing.Point(474, 179);
            this.checktxt.Name = "checktxt";
            this.checktxt.ShadowDecoration.Parent = this.checktxt;
            this.checktxt.Size = new System.Drawing.Size(332, 36);
            this.checktxt.TabIndex = 83;
            this.checktxt.SelectedIndexChanged += new System.EventHandler(this.checktxt_SelectedIndexChanged);
            // 
            // bunifuLabel9
            // 
            this.bunifuLabel9.AllowParentOverrides = false;
            this.bunifuLabel9.AutoEllipsis = false;
            this.bunifuLabel9.CursorType = null;
            this.bunifuLabel9.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(34)))), ((int)(((byte)(50)))));
            this.bunifuLabel9.Location = new System.Drawing.Point(370, 179);
            this.bunifuLabel9.Name = "bunifuLabel9";
            this.bunifuLabel9.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel9.Size = new System.Drawing.Size(59, 30);
            this.bunifuLabel9.TabIndex = 82;
            this.bunifuLabel9.Text = "Check";
            this.bunifuLabel9.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel9.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // MedicineGridView
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(75)))));
            this.MedicineGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.MedicineGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MedicineGridView.BackgroundColor = System.Drawing.Color.White;
            this.MedicineGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MedicineGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.MedicineGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.MedicineGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.MedicineGridView.ColumnHeadersHeight = 40;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.MedicineGridView.DefaultCellStyle = dataGridViewCellStyle9;
            this.MedicineGridView.EnableHeadersVisualStyles = false;
            this.MedicineGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.MedicineGridView.Location = new System.Drawing.Point(26, 296);
            this.MedicineGridView.Margin = new System.Windows.Forms.Padding(0);
            this.MedicineGridView.Name = "MedicineGridView";
            this.MedicineGridView.RowHeadersVisible = false;
            this.MedicineGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.MedicineGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(75)))));
            this.MedicineGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MedicineGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(75)))));
            this.MedicineGridView.RowTemplate.DividerHeight = 1;
            this.MedicineGridView.RowTemplate.Height = 40;
            this.MedicineGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MedicineGridView.Size = new System.Drawing.Size(1017, 338);
            this.MedicineGridView.TabIndex = 84;
            this.MedicineGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Carrot;
            this.MedicineGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.MedicineGridView.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedicineGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(113)))));
            this.MedicineGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.MedicineGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(75)))));
            this.MedicineGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.MedicineGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.MedicineGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.MedicineGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.MedicineGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedicineGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(113)))));
            this.MedicineGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.MedicineGridView.ThemeStyle.HeaderStyle.Height = 40;
            this.MedicineGridView.ThemeStyle.ReadOnly = false;
            this.MedicineGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.MedicineGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.MedicineGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MedicineGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MedicineGridView.ThemeStyle.RowsStyle.Height = 40;
            this.MedicineGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.MedicineGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(75)))));
            // 
            // setlabel
            // 
            this.setlabel.AllowParentOverrides = false;
            this.setlabel.AutoEllipsis = false;
            this.setlabel.CursorType = null;
            this.setlabel.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Bold);
            this.setlabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(34)))), ((int)(((byte)(50)))));
            this.setlabel.Location = new System.Drawing.Point(26, 263);
            this.setlabel.Name = "setlabel";
            this.setlabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.setlabel.Size = new System.Drawing.Size(59, 30);
            this.setlabel.TabIndex = 85;
            this.setlabel.Text = "Check";
            this.setlabel.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.setlabel.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // MedicineValidityCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.setlabel);
            this.Controls.Add(this.MedicineGridView);
            this.Controls.Add(this.checktxt);
            this.Controls.Add(this.bunifuLabel9);
            this.Controls.Add(this.bunifuLabel1);
            this.Name = "MedicineValidityCheck";
            this.Size = new System.Drawing.Size(1071, 744);
            this.Load += new System.EventHandler(this.MedicineValidityCheck_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MedicineGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Guna.UI2.WinForms.Guna2ComboBox checktxt;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel9;
        private Guna.UI2.WinForms.Guna2DataGridView MedicineGridView;
        private Bunifu.UI.WinForms.BunifuLabel setlabel;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
