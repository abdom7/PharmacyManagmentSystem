namespace PMS.adminUC
{
    partial class ViewUser_uc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewUser_uc));
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties1 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties2 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties3 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            Bunifu.UI.WinForms.BunifuTextBox.StateProperties stateProperties4 = new Bunifu.UI.WinForms.BunifuTextBox.StateProperties();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges borderEdges1 = new Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderEdges();
            this.syncbtn = new Guna.UI2.WinForms.Guna2Button();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.bunifuLabel2 = new Bunifu.UI.WinForms.BunifuLabel();
            this.fullnametxt = new Bunifu.UI.WinForms.BunifuTextBox();
            this.UserGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.deletebtn = new Bunifu.UI.WinForms.BunifuButton.BunifuButton();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // syncbtn
            // 
            this.syncbtn.CheckedState.Parent = this.syncbtn;
            this.syncbtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.syncbtn.CustomImages.Parent = this.syncbtn;
            this.syncbtn.FillColor = System.Drawing.Color.Transparent;
            this.syncbtn.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.syncbtn.ForeColor = System.Drawing.Color.Transparent;
            this.syncbtn.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.syncbtn.HoverState.Parent = this.syncbtn;
            this.syncbtn.Image = ((System.Drawing.Image)(resources.GetObject("syncbtn.Image")));
            this.syncbtn.ImageSize = new System.Drawing.Size(40, 40);
            this.syncbtn.Location = new System.Drawing.Point(278, 52);
            this.syncbtn.Name = "syncbtn";
            this.syncbtn.PressedColor = System.Drawing.Color.Transparent;
            this.syncbtn.ShadowDecoration.Parent = this.syncbtn;
            this.syncbtn.Size = new System.Drawing.Size(44, 45);
            this.syncbtn.TabIndex = 7;
            this.syncbtn.Click += new System.EventHandler(this.syncbtn_Click);
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BorderRadius = 40;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(258, 36);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(81, 81);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.bunifuPictureBox1.TabIndex = 6;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.CursorType = System.Windows.Forms.Cursors.Default;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 26.25F, System.Drawing.FontStyle.Bold);
            this.bunifuLabel1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(22)))), ((int)(((byte)(33)))));
            this.bunifuLabel1.Location = new System.Drawing.Point(73, 50);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(163, 47);
            this.bunifuLabel1.TabIndex = 8;
            this.bunifuLabel1.Text = "View User";
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // bunifuLabel2
            // 
            this.bunifuLabel2.AllowParentOverrides = false;
            this.bunifuLabel2.AutoEllipsis = false;
            this.bunifuLabel2.CursorType = null;
            this.bunifuLabel2.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuLabel2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(34)))), ((int)(((byte)(50)))));
            this.bunifuLabel2.Location = new System.Drawing.Point(331, 206);
            this.bunifuLabel2.Name = "bunifuLabel2";
            this.bunifuLabel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel2.Size = new System.Drawing.Size(114, 32);
            this.bunifuLabel2.TabIndex = 44;
            this.bunifuLabel2.Text = "Username";
            this.bunifuLabel2.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel2.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // fullnametxt
            // 
            this.fullnametxt.AcceptsReturn = false;
            this.fullnametxt.AcceptsTab = false;
            this.fullnametxt.AnimationSpeed = 200;
            this.fullnametxt.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.None;
            this.fullnametxt.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.None;
            this.fullnametxt.BackColor = System.Drawing.Color.Transparent;
            this.fullnametxt.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("fullnametxt.BackgroundImage")));
            this.fullnametxt.BorderColorActive = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(123)))), ((int)(((byte)(50)))));
            this.fullnametxt.BorderColorDisabled = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            this.fullnametxt.BorderColorHover = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(34)))), ((int)(((byte)(50)))));
            this.fullnametxt.BorderColorIdle = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(136)))));
            this.fullnametxt.BorderRadius = 1;
            this.fullnametxt.BorderThickness = 2;
            this.fullnametxt.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.fullnametxt.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.fullnametxt.DefaultFont = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fullnametxt.DefaultText = "";
            this.fullnametxt.FillColor = System.Drawing.Color.White;
            this.fullnametxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(34)))), ((int)(((byte)(50)))));
            this.fullnametxt.HideSelection = true;
            this.fullnametxt.IconLeft = null;
            this.fullnametxt.IconLeftCursor = System.Windows.Forms.Cursors.IBeam;
            this.fullnametxt.IconPadding = 10;
            this.fullnametxt.IconRight = null;
            this.fullnametxt.IconRightCursor = System.Windows.Forms.Cursors.IBeam;
            this.fullnametxt.Lines = new string[0];
            this.fullnametxt.Location = new System.Drawing.Point(506, 201);
            this.fullnametxt.MaxLength = 32767;
            this.fullnametxt.MinimumSize = new System.Drawing.Size(1, 1);
            this.fullnametxt.Modified = false;
            this.fullnametxt.Multiline = false;
            this.fullnametxt.Name = "fullnametxt";
            stateProperties1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(123)))), ((int)(((byte)(50)))));
            stateProperties1.FillColor = System.Drawing.Color.Empty;
            stateProperties1.ForeColor = System.Drawing.Color.Empty;
            stateProperties1.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.fullnametxt.OnActiveState = stateProperties1;
            stateProperties2.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(204)))), ((int)(((byte)(204)))), ((int)(((byte)(204)))));
            stateProperties2.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            stateProperties2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(109)))), ((int)(((byte)(109)))), ((int)(((byte)(109)))));
            stateProperties2.PlaceholderForeColor = System.Drawing.Color.DarkGray;
            this.fullnametxt.OnDisabledState = stateProperties2;
            stateProperties3.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(34)))), ((int)(((byte)(50)))));
            stateProperties3.FillColor = System.Drawing.Color.Empty;
            stateProperties3.ForeColor = System.Drawing.Color.Empty;
            stateProperties3.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.fullnametxt.OnHoverState = stateProperties3;
            stateProperties4.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(136)))));
            stateProperties4.FillColor = System.Drawing.Color.White;
            stateProperties4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(34)))), ((int)(((byte)(50)))));
            stateProperties4.PlaceholderForeColor = System.Drawing.Color.Empty;
            this.fullnametxt.OnIdleState = stateProperties4;
            this.fullnametxt.Padding = new System.Windows.Forms.Padding(3);
            this.fullnametxt.PasswordChar = '\0';
            this.fullnametxt.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(53)))), ((int)(((byte)(68)))));
            this.fullnametxt.PlaceholderText = "Username";
            this.fullnametxt.ReadOnly = false;
            this.fullnametxt.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.fullnametxt.SelectedText = "";
            this.fullnametxt.SelectionLength = 0;
            this.fullnametxt.SelectionStart = 0;
            this.fullnametxt.ShortcutsEnabled = true;
            this.fullnametxt.Size = new System.Drawing.Size(332, 42);
            this.fullnametxt.Style = Bunifu.UI.WinForms.BunifuTextBox._Style.Bunifu;
            this.fullnametxt.TabIndex = 43;
            this.fullnametxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.fullnametxt.TextMarginBottom = 0;
            this.fullnametxt.TextMarginLeft = 3;
            this.fullnametxt.TextMarginTop = 0;
            this.fullnametxt.TextPlaceholder = "Username";
            this.fullnametxt.UseSystemPasswordChar = false;
            this.fullnametxt.WordWrap = true;
            this.fullnametxt.TextChanged += new System.EventHandler(this.fullnametxt_TextChanged);
            // 
            // UserGridView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(75)))));
            this.UserGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.UserGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.UserGridView.BackgroundColor = System.Drawing.Color.White;
            this.UserGridView.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.UserGridView.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.UserGridView.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(113)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.UserGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.UserGridView.ColumnHeadersHeight = 40;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(75)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.UserGridView.DefaultCellStyle = dataGridViewCellStyle3;
            this.UserGridView.EnableHeadersVisualStyles = false;
            this.UserGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.UserGridView.Location = new System.Drawing.Point(39, 303);
            this.UserGridView.Margin = new System.Windows.Forms.Padding(0);
            this.UserGridView.Name = "UserGridView";
            this.UserGridView.RowHeadersVisible = false;
            this.UserGridView.RowTemplate.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            this.UserGridView.RowTemplate.DefaultCellStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(75)))));
            this.UserGridView.RowTemplate.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.UserGridView.RowTemplate.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(75)))));
            this.UserGridView.RowTemplate.DividerHeight = 1;
            this.UserGridView.RowTemplate.Height = 40;
            this.UserGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.UserGridView.Size = new System.Drawing.Size(1027, 338);
            this.UserGridView.TabIndex = 45;
            this.UserGridView.Theme = Guna.UI2.WinForms.Enums.DataGridViewPresetThemes.Carrot;
            this.UserGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.UserGridView.ThemeStyle.AlternatingRowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(113)))));
            this.UserGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.UserGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(75)))));
            this.UserGridView.ThemeStyle.BackColor = System.Drawing.Color.White;
            this.UserGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(218)))), ((int)(((byte)(218)))), ((int)(((byte)(218)))));
            this.UserGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.UserGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.UserGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(61)))), ((int)(((byte)(113)))));
            this.UserGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.UserGridView.ThemeStyle.HeaderStyle.Height = 40;
            this.UserGridView.ThemeStyle.ReadOnly = false;
            this.UserGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.UserGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.UserGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UserGridView.ThemeStyle.RowsStyle.Height = 40;
            this.UserGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(239)))), ((int)(((byte)(239)))), ((int)(((byte)(239)))));
            this.UserGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(40)))), ((int)(((byte)(75)))));
            this.UserGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.UserGridView_CellClick);
            // 
            // deletebtn
            // 
            this.deletebtn.AllowAnimations = true;
            this.deletebtn.AllowMouseEffects = true;
            this.deletebtn.AllowToggling = true;
            this.deletebtn.AnimationSpeed = 200;
            this.deletebtn.AutoGenerateColors = false;
            this.deletebtn.AutoRoundBorders = false;
            this.deletebtn.AutoSizeLeftIcon = true;
            this.deletebtn.AutoSizeRightIcon = true;
            this.deletebtn.BackColor = System.Drawing.Color.Transparent;
            this.deletebtn.BackColor1 = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(34)))), ((int)(((byte)(50)))));
            this.deletebtn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("deletebtn.BackgroundImage")));
            this.deletebtn.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.deletebtn.ButtonText = "Delete";
            this.deletebtn.ButtonTextMarginLeft = 0;
            this.deletebtn.ColorContrastOnClick = 45;
            this.deletebtn.ColorContrastOnHover = 45;
            this.deletebtn.Cursor = System.Windows.Forms.Cursors.Default;
            borderEdges1.BottomLeft = true;
            borderEdges1.BottomRight = true;
            borderEdges1.TopLeft = true;
            borderEdges1.TopRight = true;
            this.deletebtn.CustomizableEdges = borderEdges1;
            this.deletebtn.DialogResult = System.Windows.Forms.DialogResult.None;
            this.deletebtn.DisabledBorderColor = System.Drawing.Color.White;
            this.deletebtn.DisabledFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(34)))), ((int)(((byte)(50)))));
            this.deletebtn.DisabledForecolor = System.Drawing.Color.White;
            this.deletebtn.FocusState = Bunifu.UI.WinForms.BunifuButton.BunifuButton.ButtonStates.Idle;
            this.deletebtn.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deletebtn.ForeColor = System.Drawing.Color.White;
            this.deletebtn.IconLeftAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.deletebtn.IconLeftCursor = System.Windows.Forms.Cursors.Default;
            this.deletebtn.IconLeftPadding = new System.Windows.Forms.Padding(11, 3, 3, 3);
            this.deletebtn.IconMarginLeft = 11;
            this.deletebtn.IconPadding = 10;
            this.deletebtn.IconRightAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.deletebtn.IconRightCursor = System.Windows.Forms.Cursors.Arrow;
            this.deletebtn.IconRightPadding = new System.Windows.Forms.Padding(3, 3, 7, 3);
            this.deletebtn.IconSize = 25;
            this.deletebtn.IdleBorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(123)))), ((int)(((byte)(50)))));
            this.deletebtn.IdleBorderRadius = 35;
            this.deletebtn.IdleBorderThickness = 1;
            this.deletebtn.IdleFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(34)))), ((int)(((byte)(50)))));
            this.deletebtn.IdleIconLeftImage = ((System.Drawing.Image)(resources.GetObject("deletebtn.IdleIconLeftImage")));
            this.deletebtn.IdleIconRightImage = null;
            this.deletebtn.IndicateFocus = true;
            this.deletebtn.Location = new System.Drawing.Point(906, 666);
            this.deletebtn.Name = "deletebtn";
            this.deletebtn.OnDisabledState.BorderColor = System.Drawing.Color.White;
            this.deletebtn.OnDisabledState.BorderRadius = 35;
            this.deletebtn.OnDisabledState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.deletebtn.OnDisabledState.BorderThickness = 1;
            this.deletebtn.OnDisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(34)))), ((int)(((byte)(50)))));
            this.deletebtn.OnDisabledState.ForeColor = System.Drawing.Color.White;
            this.deletebtn.OnDisabledState.IconLeftImage = null;
            this.deletebtn.OnDisabledState.IconRightImage = null;
            this.deletebtn.onHoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(34)))), ((int)(((byte)(50)))));
            this.deletebtn.onHoverState.BorderRadius = 35;
            this.deletebtn.onHoverState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.deletebtn.onHoverState.BorderThickness = 1;
            this.deletebtn.onHoverState.FillColor = System.Drawing.Color.White;
            this.deletebtn.onHoverState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(34)))), ((int)(((byte)(50)))));
            this.deletebtn.onHoverState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("resource.IconLeftImage")));
            this.deletebtn.onHoverState.IconRightImage = null;
            this.deletebtn.OnIdleState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(123)))), ((int)(((byte)(50)))));
            this.deletebtn.OnIdleState.BorderRadius = 35;
            this.deletebtn.OnIdleState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.deletebtn.OnIdleState.BorderThickness = 1;
            this.deletebtn.OnIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(34)))), ((int)(((byte)(50)))));
            this.deletebtn.OnIdleState.ForeColor = System.Drawing.Color.White;
            this.deletebtn.OnIdleState.IconLeftImage = ((System.Drawing.Image)(resources.GetObject("deletebtn.OnIdleState.IconLeftImage")));
            this.deletebtn.OnIdleState.IconRightImage = null;
            this.deletebtn.OnPressedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(17)))), ((int)(((byte)(34)))), ((int)(((byte)(50)))));
            this.deletebtn.OnPressedState.BorderRadius = 35;
            this.deletebtn.OnPressedState.BorderStyle = Bunifu.UI.WinForms.BunifuButton.BunifuButton.BorderStyles.Solid;
            this.deletebtn.OnPressedState.BorderThickness = 1;
            this.deletebtn.OnPressedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(7)))), ((int)(((byte)(123)))), ((int)(((byte)(50)))));
            this.deletebtn.OnPressedState.ForeColor = System.Drawing.Color.White;
            this.deletebtn.OnPressedState.IconLeftImage = null;
            this.deletebtn.OnPressedState.IconRightImage = null;
            this.deletebtn.Size = new System.Drawing.Size(160, 45);
            this.deletebtn.TabIndex = 46;
            this.deletebtn.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.deletebtn.TextAlignment = System.Windows.Forms.HorizontalAlignment.Center;
            this.deletebtn.TextMarginLeft = 0;
            this.deletebtn.TextPadding = new System.Windows.Forms.Padding(0);
            this.deletebtn.UseDefaultRadiusAndThickness = true;
            this.deletebtn.Click += new System.EventHandler(this.deletebtn_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.TargetControl = this;
            // 
            // ViewUser_uc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.deletebtn);
            this.Controls.Add(this.UserGridView);
            this.Controls.Add(this.bunifuLabel2);
            this.Controls.Add(this.fullnametxt);
            this.Controls.Add(this.bunifuLabel1);
            this.Controls.Add(this.syncbtn);
            this.Controls.Add(this.bunifuPictureBox1);
            this.Name = "ViewUser_uc";
            this.Size = new System.Drawing.Size(1098, 744);
            this.Load += new System.EventHandler(this.ViewUser_uc_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UserGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button syncbtn;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel2;
        private Bunifu.UI.WinForms.BunifuTextBox fullnametxt;
        private Guna.UI2.WinForms.Guna2DataGridView UserGridView;
        private Bunifu.UI.WinForms.BunifuButton.BunifuButton deletebtn;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}
