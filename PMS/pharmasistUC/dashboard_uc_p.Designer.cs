namespace PMS.pharmasistUC
{
    partial class dashboard_uc_p
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(dashboard_uc_p));
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.reloadbtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
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
            this.bunifuLabel1.Location = new System.Drawing.Point(30, 29);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(179, 47);
            this.bunifuLabel1.TabIndex = 41;
            this.bunifuLabel1.Text = "Dashboard";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.reloadbtn);
            this.panel1.Controls.Add(this.chart1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(30, 97);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1021, 628);
            this.panel1.TabIndex = 42;
            // 
            // reloadbtn
            // 
            this.reloadbtn.AllowAnimations = true;
            this.reloadbtn.AllowMouseEffects = true;
            this.reloadbtn.AllowToggling = true;
            this.reloadbtn.AnimationSpeed = 200;
            this.reloadbtn.AutoGenerateColors = false;
            this.reloadbtn.AutoRoundBorders = false;
            this.reloadbtn.AutoSizeLeftIcon = true;
            this.reloadbtn.AutoSizeRightIcon = true;
            this.reloadbtn.BackColor = System.Drawing.Color.Transparent;
            this.reloadbtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(34)))), ((int)(((byte)(50)))));
            this.reloadbtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("reloadbtn.BackgroundImage")));
            this.reloadbtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.reloadbtn.ButtonText = "Reload";
            this.reloadbtn.ButtonTextMarginLeft = 0;
            this.reloadbtn.ColorContrastOnClick = 45;
            this.reloadbtn.ColorContrastOnHover = 45;
            this.reloadbtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.reloadbtn.CustomizableEdges = borderEdges1;
            this.reloadbtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.reloadbtn.DisabledBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.reloadbtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.reloadbtn.DisabledForecolor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.reloadbtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.reloadbtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reloadbtn.ForeColor = System.Drawing.Color.White;
            this.reloadbtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.reloadbtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.reloadbtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.reloadbtn.IconMarginLeft = 11;
            this.reloadbtn.IconPadding = 10;
            this.reloadbtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.reloadbtn.IconRightCursor = System.Windows.Forms.Cursors.Arrow;
            this.reloadbtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.reloadbtn.IconSize = 25;
            this.reloadbtn.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(123)))), ((int)(((byte)(50)))));
            this.reloadbtn.IdleBorderRadius = 35;
            this.reloadbtn.IdleBorderThickness = 2;
            this.reloadbtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(34)))), ((int)(((byte)(50)))));
            this.reloadbtn.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("reloadbtn.IdleIconLeftImage")));
            this.reloadbtn.IdleIconRightImage = null;
            this.reloadbtn.IndicateFocus = true;
            this.reloadbtn.Location = new System.Drawing.Point(869, 479);
            this.reloadbtn.Name = "reloadbtn";
            this.reloadbtn.OnDisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.reloadbtn.OnDisabledState.BorderRadius = 35;
            this.reloadbtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.reloadbtn.OnDisabledState.BorderThickness = 2;
            this.reloadbtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.reloadbtn.OnDisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(168)))), ((int)(((byte)(160)))), ((int)(((byte)(168)))));
            this.reloadbtn.OnDisabledState.IconLeftImage = null;
            this.reloadbtn.OnDisabledState.IconRightImage = null;
            this.reloadbtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(34)))), ((int)(((byte)(50)))));
            this.reloadbtn.onHoverState.BorderRadius = 35;
            this.reloadbtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.reloadbtn.onHoverState.BorderThickness = 2;
            this.reloadbtn.onHoverState.FillColor = System.Drawing.Color.White;
            this.reloadbtn.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(34)))), ((int)(((byte)(50)))));
            this.reloadbtn.onHoverState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("resource.IconLeftImage")));
            this.reloadbtn.onHoverState.IconRightImage = null;
            this.reloadbtn.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(123)))), ((int)(((byte)(50)))));
            this.reloadbtn.OnIdleState.BorderRadius = 35;
            this.reloadbtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.reloadbtn.OnIdleState.BorderThickness = 2;
            this.reloadbtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(34)))), ((int)(((byte)(50)))));
            this.reloadbtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.reloadbtn.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("signupbtn.OnIdleState.IconLeftImage")));
            this.reloadbtn.OnIdleState.IconRightImage = null;
            this.reloadbtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(34)))), ((int)(((byte)(50)))));
            this.reloadbtn.OnPressedState.BorderRadius = 35;
            this.reloadbtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.reloadbtn.OnPressedState.BorderThickness = 2;
            this.reloadbtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(123)))), ((int)(((byte)(50)))));
            this.reloadbtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.reloadbtn.OnPressedState.IconLeftImage = null;
            this.reloadbtn.OnPressedState.IconRightImage = null;
            this.reloadbtn.Size = new System.Drawing.Size(137, 46);
            this.reloadbtn.TabIndex = 56;
            this.reloadbtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.reloadbtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.reloadbtn.TextMarginLeft = 0;
            this.reloadbtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.reloadbtn.UseDefaultRadiusAndThickness = true;
            this.reloadbtn.Click += new System.EventHandler(this.reloadbtn_Click);
            // 
            // chart1
            // 
            this.chart1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(553, 39);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            series1.Legend = "Legend1";
            series1.Name = "Expired Medicine";
            series2.ChartArea = "ChartArea1";
            series2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(118)))), ((int)(((byte)(225)))));
            series2.Legend = "Legend1";
            series2.Name = "Valid Medicine";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(453, 540);
            this.chart1.TabIndex = 1;
            this.chart1.Text = "  v";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(32, 39);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(512, 540);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // dashboard_uc_p
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.bunifuLabel1);
            this.Name = "dashboard_uc_p";
            this.Size = new System.Drawing.Size(1071, 744);
            this.Load += new System.EventHandler(this.dashboard_uc_p_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton reloadbtn;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
