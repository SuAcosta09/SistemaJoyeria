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
    public partial class Login : Form
    {

        private IconButton currentBtn;
        private Panel leftBorderBtn;
        private Form currentChildForm;
        public Login()
        {
            InitializeComponent();
            leftBorderBtn = new Panel();
            leftBorderBtn.Size = new Size(15, 80);
            //pnl_menu.Controls.Add(leftBorderBtn);

            //form
            this.Text = String.Empty;
            this.ControlBox = false;
            this.DoubleBuffered = true;
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

        private void panel_primary_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            //HomeAdmin
            pri_form pri_Form = new pri_form();
            pri_Form.Show();
            this.Hide();
        }

        private void exit_btn_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
