namespace winformadvance
{
    partial class pri_form
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(pri_form));
            this.pnl_menu = new System.Windows.Forms.Panel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.btn_backup = new FontAwesome.Sharp.IconButton();
            this.iconButton4 = new FontAwesome.Sharp.IconButton();
            this.btn_ventas = new FontAwesome.Sharp.IconButton();
            this.btn_prod = new FontAwesome.Sharp.IconButton();
            this.btn_client = new FontAwesome.Sharp.IconButton();
            this.btn_user = new FontAwesome.Sharp.IconButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_home = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_minimize = new FontAwesome.Sharp.IconPictureBox();
            this.btn_maximize = new FontAwesome.Sharp.IconPictureBox();
            this.exit_btn = new FontAwesome.Sharp.IconPictureBox();
            this.lbl_tit = new System.Windows.Forms.Label();
            this.currentIcon = new FontAwesome.Sharp.IconPictureBox();
            this.panel_primary = new System.Windows.Forms.Panel();
            this.bunifuPictureBox1 = new Bunifu.UI.WinForms.BunifuPictureBox();
            this.lbl_hora = new System.Windows.Forms.Label();
            this.lbl_fecha = new System.Windows.Forms.Label();
            this.horafecha = new System.Windows.Forms.Timer(this.components);
            this.pnl_menu.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_home)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit_btn)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentIcon)).BeginInit();
            this.panel_primary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pnl_menu
            // 
            this.pnl_menu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(184)))), ((int)(((byte)(28)))), ((int)(((byte)(29)))));
            this.pnl_menu.Controls.Add(this.iconButton1);
            this.pnl_menu.Controls.Add(this.btn_backup);
            this.pnl_menu.Controls.Add(this.iconButton4);
            this.pnl_menu.Controls.Add(this.btn_ventas);
            this.pnl_menu.Controls.Add(this.btn_prod);
            this.pnl_menu.Controls.Add(this.btn_client);
            this.pnl_menu.Controls.Add(this.btn_user);
            this.pnl_menu.Controls.Add(this.panel1);
            this.pnl_menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.pnl_menu.Location = new System.Drawing.Point(0, 0);
            this.pnl_menu.Name = "pnl_menu";
            this.pnl_menu.Size = new System.Drawing.Size(220, 744);
            this.pnl_menu.TabIndex = 0;
            // 
            // iconButton1
            // 
            this.iconButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton1.ForeColor = System.Drawing.Color.White;
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.ExternalLinkAlt;
            this.iconButton1.IconColor = System.Drawing.Color.White;
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 50;
            this.iconButton1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.Location = new System.Drawing.Point(0, 664);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton1.Size = new System.Drawing.Size(220, 80);
            this.iconButton1.TabIndex = 8;
            this.iconButton1.Text = "Logout";
            this.iconButton1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // btn_backup
            // 
            this.btn_backup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_backup.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_backup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_backup.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_backup.ForeColor = System.Drawing.Color.White;
            this.btn_backup.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.btn_backup.IconColor = System.Drawing.Color.White;
            this.btn_backup.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_backup.IconSize = 50;
            this.btn_backup.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_backup.Location = new System.Drawing.Point(0, 521);
            this.btn_backup.Name = "btn_backup";
            this.btn_backup.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_backup.Size = new System.Drawing.Size(220, 80);
            this.btn_backup.TabIndex = 7;
            this.btn_backup.Text = "Backup";
            this.btn_backup.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_backup.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_backup.UseVisualStyleBackColor = true;
            this.btn_backup.Click += new System.EventHandler(this.btn_backup_Click);
            // 
            // iconButton4
            // 
            this.iconButton4.Cursor = System.Windows.Forms.Cursors.Hand;
            this.iconButton4.Dock = System.Windows.Forms.DockStyle.Top;
            this.iconButton4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.iconButton4.ForeColor = System.Drawing.Color.White;
            this.iconButton4.IconChar = FontAwesome.Sharp.IconChar.ChartSimple;
            this.iconButton4.IconColor = System.Drawing.Color.White;
            this.iconButton4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton4.IconSize = 50;
            this.iconButton4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.Location = new System.Drawing.Point(0, 441);
            this.iconButton4.Name = "iconButton4";
            this.iconButton4.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.iconButton4.Size = new System.Drawing.Size(220, 80);
            this.iconButton4.TabIndex = 6;
            this.iconButton4.Text = "Reportes";
            this.iconButton4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.iconButton4.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.iconButton4.UseVisualStyleBackColor = true;
            this.iconButton4.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // btn_ventas
            // 
            this.btn_ventas.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_ventas.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_ventas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_ventas.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_ventas.ForeColor = System.Drawing.Color.White;
            this.btn_ventas.IconChar = FontAwesome.Sharp.IconChar.MoneyCheckDollar;
            this.btn_ventas.IconColor = System.Drawing.Color.White;
            this.btn_ventas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_ventas.IconSize = 50;
            this.btn_ventas.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ventas.Location = new System.Drawing.Point(0, 361);
            this.btn_ventas.Name = "btn_ventas";
            this.btn_ventas.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_ventas.Size = new System.Drawing.Size(220, 80);
            this.btn_ventas.TabIndex = 5;
            this.btn_ventas.Text = "Ventas";
            this.btn_ventas.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_ventas.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_ventas.UseVisualStyleBackColor = true;
            this.btn_ventas.Click += new System.EventHandler(this.btn_ventas_Click);
            // 
            // btn_prod
            // 
            this.btn_prod.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_prod.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_prod.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_prod.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_prod.ForeColor = System.Drawing.Color.White;
            this.btn_prod.IconChar = FontAwesome.Sharp.IconChar.ClockFour;
            this.btn_prod.IconColor = System.Drawing.Color.White;
            this.btn_prod.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_prod.IconSize = 50;
            this.btn_prod.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_prod.Location = new System.Drawing.Point(0, 281);
            this.btn_prod.Name = "btn_prod";
            this.btn_prod.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_prod.Size = new System.Drawing.Size(220, 80);
            this.btn_prod.TabIndex = 4;
            this.btn_prod.Text = "Productos";
            this.btn_prod.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_prod.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_prod.UseVisualStyleBackColor = true;
            this.btn_prod.Click += new System.EventHandler(this.btn_prod_Click);
            // 
            // btn_client
            // 
            this.btn_client.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_client.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_client.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_client.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_client.ForeColor = System.Drawing.Color.White;
            this.btn_client.IconChar = FontAwesome.Sharp.IconChar.UserTag;
            this.btn_client.IconColor = System.Drawing.Color.White;
            this.btn_client.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_client.IconSize = 50;
            this.btn_client.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_client.Location = new System.Drawing.Point(0, 201);
            this.btn_client.Name = "btn_client";
            this.btn_client.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_client.Size = new System.Drawing.Size(220, 80);
            this.btn_client.TabIndex = 3;
            this.btn_client.Text = "Clientes";
            this.btn_client.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_client.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_client.UseVisualStyleBackColor = true;
            this.btn_client.Click += new System.EventHandler(this.btn_client_Click);
            // 
            // btn_user
            // 
            this.btn_user.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_user.Dock = System.Windows.Forms.DockStyle.Top;
            this.btn_user.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_user.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_user.ForeColor = System.Drawing.Color.White;
            this.btn_user.IconChar = FontAwesome.Sharp.IconChar.UserTie;
            this.btn_user.IconColor = System.Drawing.Color.White;
            this.btn_user.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_user.IconSize = 50;
            this.btn_user.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_user.Location = new System.Drawing.Point(0, 121);
            this.btn_user.Name = "btn_user";
            this.btn_user.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.btn_user.Size = new System.Drawing.Size(220, 80);
            this.btn_user.TabIndex = 2;
            this.btn_user.Text = "Usuarios";
            this.btn_user.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_user.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn_user.UseVisualStyleBackColor = true;
            this.btn_user.Click += new System.EventHandler(this.btn_user_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_home);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 121);
            this.panel1.TabIndex = 0;
            // 
            // btn_home
            // 
            this.btn_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_home.Image = ((System.Drawing.Image)(resources.GetObject("btn_home.Image")));
            this.btn_home.Location = new System.Drawing.Point(51, 22);
            this.btn_home.Name = "btn_home";
            this.btn_home.Size = new System.Drawing.Size(107, 74);
            this.btn_home.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_home.TabIndex = 0;
            this.btn_home.TabStop = false;
            this.btn_home.Click += new System.EventHandler(this.btn_home_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(15)))), ((int)(((byte)(18)))));
            this.panel2.Controls.Add(this.btn_minimize);
            this.panel2.Controls.Add(this.btn_maximize);
            this.panel2.Controls.Add(this.exit_btn);
            this.panel2.Controls.Add(this.lbl_tit);
            this.panel2.Controls.Add(this.currentIcon);
            this.panel2.Cursor = System.Windows.Forms.Cursors.NoMove2D;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(220, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1100, 75);
            this.panel2.TabIndex = 1;
            this.panel2.MouseDown += new System.Windows.Forms.MouseEventHandler(this.panel2_MouseDown);
            // 
            // btn_minimize
            // 
            this.btn_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_minimize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(15)))), ((int)(((byte)(18)))));
            this.btn_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_minimize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(176)))));
            this.btn_minimize.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.btn_minimize.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(176)))));
            this.btn_minimize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_minimize.IconSize = 54;
            this.btn_minimize.Location = new System.Drawing.Point(917, 12);
            this.btn_minimize.Name = "btn_minimize";
            this.btn_minimize.Size = new System.Drawing.Size(56, 54);
            this.btn_minimize.TabIndex = 4;
            this.btn_minimize.TabStop = false;
            this.btn_minimize.Click += new System.EventHandler(this.btn_minimize_Click);
            // 
            // btn_maximize
            // 
            this.btn_maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_maximize.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(15)))), ((int)(((byte)(18)))));
            this.btn_maximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_maximize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(176)))));
            this.btn_maximize.IconChar = FontAwesome.Sharp.IconChar.WindowMaximize;
            this.btn_maximize.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(176)))));
            this.btn_maximize.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_maximize.IconSize = 54;
            this.btn_maximize.Location = new System.Drawing.Point(979, 12);
            this.btn_maximize.Name = "btn_maximize";
            this.btn_maximize.Size = new System.Drawing.Size(56, 54);
            this.btn_maximize.TabIndex = 3;
            this.btn_maximize.TabStop = false;
            this.btn_maximize.Click += new System.EventHandler(this.btn_maximize_Click);
            // 
            // exit_btn
            // 
            this.exit_btn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.exit_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(15)))), ((int)(((byte)(18)))));
            this.exit_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exit_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(176)))));
            this.exit_btn.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            this.exit_btn.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(217)))), ((int)(((byte)(175)))), ((int)(((byte)(176)))));
            this.exit_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.exit_btn.IconSize = 54;
            this.exit_btn.Location = new System.Drawing.Point(1041, 12);
            this.exit_btn.Name = "exit_btn";
            this.exit_btn.Size = new System.Drawing.Size(56, 54);
            this.exit_btn.TabIndex = 2;
            this.exit_btn.TabStop = false;
            this.exit_btn.Click += new System.EventHandler(this.exit_btn_Click);
            // 
            // lbl_tit
            // 
            this.lbl_tit.AutoSize = true;
            this.lbl_tit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_tit.ForeColor = System.Drawing.Color.White;
            this.lbl_tit.Location = new System.Drawing.Point(77, 22);
            this.lbl_tit.Name = "lbl_tit";
            this.lbl_tit.Size = new System.Drawing.Size(78, 29);
            this.lbl_tit.TabIndex = 1;
            this.lbl_tit.Text = "Home";
            // 
            // currentIcon
            // 
            this.currentIcon.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(15)))), ((int)(((byte)(18)))));
            this.currentIcon.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(200)))), ((int)(((byte)(219)))));
            this.currentIcon.IconChar = FontAwesome.Sharp.IconChar.Home;
            this.currentIcon.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(200)))), ((int)(((byte)(219)))));
            this.currentIcon.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.currentIcon.IconSize = 54;
            this.currentIcon.Location = new System.Drawing.Point(6, 12);
            this.currentIcon.Name = "currentIcon";
            this.currentIcon.Size = new System.Drawing.Size(56, 54);
            this.currentIcon.TabIndex = 0;
            this.currentIcon.TabStop = false;
            // 
            // panel_primary
            // 
            this.panel_primary.BackColor = System.Drawing.Color.LightPink;
            this.panel_primary.Controls.Add(this.lbl_fecha);
            this.panel_primary.Controls.Add(this.lbl_hora);
            this.panel_primary.Controls.Add(this.bunifuPictureBox1);
            this.panel_primary.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_primary.Location = new System.Drawing.Point(220, 75);
            this.panel_primary.Name = "panel_primary";
            this.panel_primary.Size = new System.Drawing.Size(1100, 669);
            this.panel_primary.TabIndex = 2;
            this.panel_primary.Paint += new System.Windows.Forms.PaintEventHandler(this.panel_primary_Paint);
            // 
            // bunifuPictureBox1
            // 
            this.bunifuPictureBox1.AllowFocused = false;
            this.bunifuPictureBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bunifuPictureBox1.AutoSizeHeight = true;
            this.bunifuPictureBox1.BackColor = System.Drawing.Color.Crimson;
            this.bunifuPictureBox1.BorderRadius = 179;
            this.bunifuPictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("bunifuPictureBox1.Image")));
            this.bunifuPictureBox1.IsCircle = true;
            this.bunifuPictureBox1.Location = new System.Drawing.Point(371, 155);
            this.bunifuPictureBox1.Name = "bunifuPictureBox1";
            this.bunifuPictureBox1.Size = new System.Drawing.Size(358, 358);
            this.bunifuPictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.bunifuPictureBox1.TabIndex = 0;
            this.bunifuPictureBox1.TabStop = false;
            this.bunifuPictureBox1.Type = Bunifu.UI.WinForms.BunifuPictureBox.Types.Circle;
            // 
            // lbl_hora
            // 
            this.lbl_hora.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_hora.AutoSize = true;
            this.lbl_hora.Font = new System.Drawing.Font("Segoe UI Emoji", 26F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hora.Location = new System.Drawing.Point(411, 81);
            this.lbl_hora.Name = "lbl_hora";
            this.lbl_hora.Size = new System.Drawing.Size(282, 69);
            this.lbl_hora.TabIndex = 1;
            this.lbl_hora.Text = "7:50:51 PM";
            // 
            // lbl_fecha
            // 
            this.lbl_fecha.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_fecha.AutoSize = true;
            this.lbl_fecha.Font = new System.Drawing.Font("Segoe UI Emoji", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_fecha.Location = new System.Drawing.Point(455, 523);
            this.lbl_fecha.Name = "lbl_fecha";
            this.lbl_fecha.Size = new System.Drawing.Size(187, 53);
            this.lbl_fecha.TabIndex = 2;
            this.lbl_fecha.Text = "00/00/00";
            // 
            // horafecha
            // 
            this.horafecha.Enabled = true;
            this.horafecha.Tick += new System.EventHandler(this.horafecha_Tick);
            // 
            // pri_form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 744);
            this.Controls.Add(this.panel_primary);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.pnl_menu);
            this.Name = "pri_form";
            this.pnl_menu.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_home)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_minimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.btn_maximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.exit_btn)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.currentIcon)).EndInit();
            this.panel_primary.ResumeLayout(false);
            this.panel_primary.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bunifuPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_menu;
        private FontAwesome.Sharp.IconButton btn_user;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton iconButton4;
        private FontAwesome.Sharp.IconButton btn_ventas;
        private FontAwesome.Sharp.IconButton btn_prod;
        private FontAwesome.Sharp.IconButton btn_client;
        private FontAwesome.Sharp.IconButton btn_backup;
        private System.Windows.Forms.PictureBox btn_home;
        private FontAwesome.Sharp.IconButton iconButton1;
        private System.Windows.Forms.Panel panel2;
        private FontAwesome.Sharp.IconPictureBox currentIcon;
        private System.Windows.Forms.Label lbl_tit;
        private FontAwesome.Sharp.IconPictureBox exit_btn;
        private System.Windows.Forms.Panel panel_primary;
        private FontAwesome.Sharp.IconPictureBox btn_minimize;
        private FontAwesome.Sharp.IconPictureBox btn_maximize;
        private Bunifu.UI.WinForms.BunifuPictureBox bunifuPictureBox1;
        private System.Windows.Forms.Label lbl_fecha;
        private System.Windows.Forms.Label lbl_hora;
        private System.Windows.Forms.Timer horafecha;
    }
}

