using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winformadvance
{
    public partial class UsersForm : Form
    {
        public UsersForm()
        {
            InitializeComponent();
            limpiar();
        }

        private void limpiar()
        {
            btn_eliminar.Enabled = false;
            btn_eliminar.BackColor = Color.Transparent;
            btn_modif.Enabled = false;
            btn_modif.BackColor = Color.Transparent;
            btn_guardar.Enabled = true;

            txt_nombre.Clear();
            txt_apellido.Clear();
            txt_dni.Clear();
            txt_email.Clear();
            txt_tel.Clear();
            txt_dir.Clear();
            txt_usuario.Clear();
            txt_contra.Clear();
            cal_nacimiento.Value = DateTime.Now;

        }
        private bool ValidateEmail()
        {
            string email = txt_email.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            return match.Success;
            /**
            if (match.Success)
            {
                return true;
            }

            else
            {
                return false;
            }
            **/
        }

        private void bunifuTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuDatePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuLabel4_Click(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            /* Metodo que solo permite ingresar texto en caracteres y sin espacios en blanco
            primero se debe activar el evento keypress con ayuda del IDE */
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

            // con este flujo de datos se toma el enter cuando es presionado y cambia el focus
            // al text box inmediato
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txt_apellido.Focus();
            }
        }

        private void txt_apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txt_dni.Focus();
            }
        }

        private void txt_dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if(e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txt_email.Focus();
            }
        }

        private void txt_email_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txt_tel.Focus();
            }
        }

        private void txt_tel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txt_dir.Focus();
            }
        }

        private void txt_dir_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txt_usuario.Focus();
            }
        }

        private void txt_usuario_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar))
            {
                e.Handled = true;
            }

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                txt_contra.Focus();
            }
        }

        private void txt_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            limpiar();
        }
    }
}
