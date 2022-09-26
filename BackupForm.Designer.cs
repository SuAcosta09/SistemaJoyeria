namespace winformadvance
{
    partial class BackupForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BackupForm));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.save_btn = new FontAwesome.Sharp.IconButton();
            this.Cal = new FontAwesome.Sharp.IconButton();
            this.bunifuLabel1 = new Bunifu.UI.WinForms.BunifuLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1078, 298);
            this.panel2.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.save_btn);
            this.panel1.Controls.Add(this.Cal);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 297);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1078, 316);
            this.panel1.TabIndex = 22;
            // 
            // save_btn
            // 
            this.save_btn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.save_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(59)))), ((int)(((byte)(60)))));
            this.save_btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.save_btn.ForeColor = System.Drawing.Color.White;
            this.save_btn.IconChar = FontAwesome.Sharp.IconChar.Server;
            this.save_btn.IconColor = System.Drawing.Color.White;
            this.save_btn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.save_btn.IconSize = 50;
            this.save_btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.save_btn.Location = new System.Drawing.Point(440, 151);
            this.save_btn.Name = "save_btn";
            this.save_btn.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.save_btn.Size = new System.Drawing.Size(211, 77);
            this.save_btn.TabIndex = 33;
            this.save_btn.Text = "Backup";
            this.save_btn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.save_btn.UseVisualStyleBackColor = false;
            // 
            // Cal
            // 
            this.Cal.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Cal.BackColor = System.Drawing.Color.Transparent;
            this.Cal.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Cal.FlatAppearance.BorderSize = 0;
            this.Cal.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Cal.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cal.ForeColor = System.Drawing.Color.White;
            this.Cal.IconChar = FontAwesome.Sharp.IconChar.Database;
            this.Cal.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(59)))), ((int)(((byte)(60)))));
            this.Cal.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.Cal.IconSize = 150;
            this.Cal.Location = new System.Drawing.Point(469, 7);
            this.Cal.Name = "Cal";
            this.Cal.Padding = new System.Windows.Forms.Padding(10, 0, 20, 0);
            this.Cal.Size = new System.Drawing.Size(164, 138);
            this.Cal.TabIndex = 32;
            this.Cal.UseVisualStyleBackColor = false;
            // 
            // bunifuLabel1
            // 
            this.bunifuLabel1.AllowParentOverrides = false;
            this.bunifuLabel1.AutoEllipsis = false;
            this.bunifuLabel1.CursorType = null;
            this.bunifuLabel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bunifuLabel1.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.bunifuLabel1.Location = new System.Drawing.Point(0, 5);
            this.bunifuLabel1.Name = "bunifuLabel1";
            this.bunifuLabel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.bunifuLabel1.Size = new System.Drawing.Size(601, 150);
            this.bunifuLabel1.TabIndex = 1;
            this.bunifuLabel1.Text = resources.GetString("bunifuLabel1.Text");
            this.bunifuLabel1.TextAlignment = System.Drawing.ContentAlignment.TopLeft;
            this.bunifuLabel1.TextFormat = Bunifu.UI.WinForms.BunifuLabel.TextFormattingOptions.Default;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(1059, 87);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BackupForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightPink;
            this.ClientSize = new System.Drawing.Size(1078, 613);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "BackupForm";
            this.Text = "BackupForm";
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel1;
        private FontAwesome.Sharp.IconButton Cal;
        private FontAwesome.Sharp.IconButton save_btn;
        private System.Windows.Forms.Label label1;
        private Bunifu.UI.WinForms.BunifuLabel bunifuLabel1;
    }
}