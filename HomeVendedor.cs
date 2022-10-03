using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Media;
using FontAwesome.Sharp;
using System.Runtime.InteropServices;


using Color = System.Drawing.Color;
using System.Diagnostics.Tracing;

namespace winformadvance
{
    public partial class HomeVendedor : Form
    {

        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public HomeVendedor()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(15, 80);
            pnl_menu.Controls.Add(leftBorderBtn);

            //form
            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
        }

        private void openChildForm(Form childForm)
        {
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panel_primary.Controls.Add(childForm);
            childForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        public struct RGBcolors
        {
             public static Color color1 = Color.FromArgb(172,126,241);
             public static Color color2 = Color.FromArgb(249,118,176);
             public static Color color3 = Color.FromArgb(253,138,114);
             public static Color color4 = Color.FromArgb(222, 191, 30);
             public static Color color5 = Color.FromArgb(249,88,115);
             public static Color color6 = Color.FromArgb(24,161,251);
        }

        private void activateButton(object senderBtn, Color color)
        {
            if(senderBtn != null)
            {
                //buttons colors
                disableBtn();
                currentBtn = (IconButton)senderBtn;
                currentBtn.BackColor = Color.FromArgb(37, 36, 81);
                currentBtn.ForeColor = color;
                currentBtn.TextAlign = ContentAlignment.MiddleCenter;
                currentBtn.IconColor = color;
                currentBtn.TextImageRelation = TextImageRelation.TextBeforeImage;
                currentBtn.ImageAlign = ContentAlignment.MiddleRight;

                //side minipanel
                leftBorderBtn.BackColor = color;
                leftBorderBtn.Location = new Point(0, currentBtn.Location.Y);
                leftBorderBtn.Visible = false;
                leftBorderBtn.BringToFront();

                //current icon tittle
                lbl_tit.Text = currentBtn.Text;
                currentIcon.IconChar = currentBtn.IconChar;
                currentIcon.IconColor = color;
            }
        }

        private void disableBtn()
        {
            if(currentBtn != null)
            {
                currentBtn.BackColor = Color.FromArgb(184, 28, 29);
                currentBtn.ForeColor = Color.White;
                
                currentBtn.TextAlign = ContentAlignment.MiddleLeft;
                currentBtn.IconColor = Color.White;
                currentBtn.TextImageRelation = TextImageRelation.ImageBeforeText;
                currentBtn.ImageAlign = ContentAlignment.MiddleLeft;
            }
        }

        private void btn_user_Click(object sender, EventArgs e)
        {
            activateButton(sender, RGBcolors.color1);
            //lbl_tit.Text = btn_user.Text;
            openChildForm(new UsersForm());
        }

        private void btn_client_Click(object sender, EventArgs e)
        {
            activateButton(sender, RGBcolors.color2);
            openChildForm(new ClientForm());
        }

        private void btn_prod_Click(object sender, EventArgs e)
        {
            activateButton(sender, RGBcolors.color3);
            openChildForm(new FacturarForm());
        }

        private void btn_ventas_Click(object sender, EventArgs e)
        {
            activateButton(sender, RGBcolors.color4);
            openChildForm(new VentasForm());
        }

        private void iconButton4_Click(object sender, EventArgs e)
        {
            activateButton(sender, RGBcolors.color5);
            openChildForm(new ReportesForm());
        }

        private void btn_backup_Click(object sender, EventArgs e)
        {
            activateButton(sender, RGBcolors.color6);
            openChildForm(new BackupForm());
        }

        private void btn_home_Click(object sender, EventArgs e)
        {

            Reset();
        }

        private void Reset()
        {
            disableBtn();
            leftBorderBtn.Visible = false;
            currentIcon.IconChar = IconChar.Home;
            currentIcon.BackColor = Color.FromArgb(132, 15, 18);
            lbl_tit.Text = "Home";

            //try
            //{
            //    currentChildForm.Close();
            //}
            //catch(NullReferenceException e)
            //{
            //    return;
            //}
            

        }


        //drag and move the window

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();

        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);
        


        private void panel2_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_maximize_Click(object sender, EventArgs e)
        {
            if(WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void btn_minimize_Click(object sender, EventArgs e)
        {
            WindowState=FormWindowState.Minimized;
        }

        private void horafecha_Tick(object sender, EventArgs e)
        {
            lbl_hora.Text = DateTime.Now.ToLongTimeString();
            lbl_fecha.Text = DateTime.Now.ToShortDateString();
        }

        private void panel_primary_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea cerrar sesión?",
                            "Cerrar Sesión!",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                this.Close();
                Login pri_Form = new Login();
                pri_Form.Show();
            }
        }
    }
}
