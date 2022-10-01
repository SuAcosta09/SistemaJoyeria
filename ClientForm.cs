using CapaEntidad;
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
using CapaNegocio;

namespace winformadvance
{
    public partial class ClientForm : Form
    {
        int pos;
        public ClientForm()
        {
            InitializeComponent();
            limpiar();
        }


        //******************************** BOTONES PRINCIPALES ********************************

        /// <summary>
        /// Deshabilita los botones de modificar y eliminar
        /// y resetea todos los campos
        /// </summary>
        private void limpiar()
        {
            btn_eliminar.Enabled = false;
            btn_eliminar.BackColor = Color.Transparent;
            btn_modif.Enabled = false;
            btn_modif.BackColor = Color.Transparent;
            btn_guardar.Enabled = true;
            btn_guardar.BackColor = Color.FromArgb(194, 59, 60);

            txt_nombre.Clear();
            txt_apellido.Clear();
            txt_dni.Clear();
            txt_email.Clear();
            txt_tel.Clear();
            txt_dir.Clear();
            cal_nacimiento.Value = DateTime.Now;
        }

        /// <summary>
        /// retorna true si posee un @ y un . (punto) sino retorna false
        /// </summary>
        /// <returns></returns>
        private bool ValidateEmail()
        {
            string email = txt_email.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            Match match = regex.Match(email);
            return match.Success;
        }

        /// <summary>
        /// ejecuta limpiar cada vez que se oprime el boton para restaurar los campos en blanco
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_clear_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        /// <summary>
        /// Verifica si estan completos todos los campos y si el email cumple con los requisitos
        /// si está bien entonces te pregunta si quieres guardar los datos 
        /// y sino te indica que completes correctamente todos los datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (txt_nombre.Text == "" || txt_apellido.Text == "" || txt_dni.Text == "" ||
                txt_email.Text == "" || txt_tel.Text == "" || txt_dir.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos!", "ERROR!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                if (ValidateEmail())
                {
                    if (MessageBox.Show("Seguro que desea eliminar al cliente?",
                            "Eliminar Datos!",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        string nombre, apellido, dni, email, tel, dir, nac;

                        nombre = txt_nombre.Text;
                        apellido = txt_apellido.Text;
                        dni = txt_dni.Text;
                        email = txt_email.Text;
                        tel = txt_tel.Text;
                        dir = txt_dir.Text;
                        nac = cal_nacimiento.Text;

                        dtg_clientes.Rows.Add(nombre, apellido, dni, email, tel, dir, nac);
                        limpiar();
                    }
                    else
                    {
                        limpiar();
                    }
                }
                else
                {
                    MessageBox.Show("Formato de correo no valido! intente de nuevo", "ERROR!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    txt_email.Clear();
                    txt_email.Focus();
                }
            }
        }

        /// <summary>
        /// Verifica si estan completos todos los campos y si el email cumple con los requisitos
        /// si está bien entonces te pregunta si quieres actualizar los datos 
        /// y sino te indica que completes correctamente todos los datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_modif_Click(object sender, EventArgs e)
        {
            if (txt_nombre.Text == "" || txt_apellido.Text == "" || txt_dni.Text == "" ||
                txt_email.Text == "" || txt_tel.Text == "" || txt_dir.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos!", "ERROR!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                if (ValidateEmail())
                {
                    if (MessageBox.Show("Seguro que desea modificar al cliente?",
                           "Modificar Datos!",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                    {
                        string nombre, apellido, dni, email, tel, dir, nac;

                        nombre = txt_nombre.Text;
                        apellido = txt_apellido.Text;
                        dni = txt_dni.Text;
                        email = txt_email.Text;
                        tel = txt_tel.Text;
                        dir = txt_dir.Text;
                        nac = cal_nacimiento.Text;

                        dtg_clientes[0, pos].Value = txt_nombre.Text;
                        dtg_clientes[1, pos].Value = txt_apellido.Text;
                        dtg_clientes[2, pos].Value = txt_dni.Text;
                        dtg_clientes[3, pos].Value = txt_email.Text;
                        dtg_clientes[4, pos].Value = txt_tel.Text;
                        dtg_clientes[5, pos].Value = txt_dir.Text;
                        dtg_clientes[6, pos].Value = cal_nacimiento.Text;

                        limpiar();
                    }
                    else
                    {
                        limpiar();
                    }
                }
                else
                {
                    MessageBox.Show("Formato de correo no valido! intente de nuevo", "ERROR!",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    txt_email.Clear();
                    txt_email.Focus();
                }
            }
        }

        /// <summary>
        /// primero pregunta para confirmar si quieres eliminar
        /// de ser una respuesta afirmativa elimina el registro y sino lo deja como estaba
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea eliminar al cliente?", "Eliminar Datos!", MessageBoxButtons.YesNo,
                 MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                dtg_clientes.Rows.RemoveAt(pos);
                limpiar();
            }
            else
            {
                limpiar();
            }
        }

        /// <summary>
        /// carga los datos en los textbox para ser visualizados o aplicarle cambios al registro
        /// a demás deshabilita el boton guardar  y habilita el modificar y eliminar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtg_clientes_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            txt_nombre.Text = dtg_clientes.CurrentRow.Cells["name"].Value.ToString();
            txt_apellido.Text = dtg_clientes.CurrentRow.Cells["lastname"].Value.ToString();
            txt_dni.Text = dtg_clientes.CurrentRow.Cells["dni"].Value.ToString();
            txt_email.Text = dtg_clientes.CurrentRow.Cells["email"].Value.ToString();
            txt_tel.Text = dtg_clientes.CurrentRow.Cells["tel"].Value.ToString();
            txt_dir.Text = dtg_clientes.CurrentRow.Cells["dir"].Value.ToString();
            cal_nacimiento.Text = dtg_clientes.CurrentRow.Cells["nac"].Value.ToString();

            btn_guardar.Enabled = false;
            btn_guardar.BackColor = Color.Transparent;

            btn_eliminar.Enabled = true;
            btn_eliminar.BackColor = Color.FromArgb(194, 59, 60);
            btn_modif.Enabled = true;
            btn_modif.BackColor = Color.FromArgb(194, 59, 60);
        }

        //*********************************** VALIDACIONES ***********************************

        /// <summary>
        /// En el textbox de nombre solo permite el ingreso de letras y espacio
        /// tambien fija el foco del cursos al textbox de apellido
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txt_apellido.Focus();
        }

        /// <summary>
        /// En el textbox de apellido solo permite el ingreso de letras y espacio
        /// tambien fija el foco del cursos al textbox de DNI
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_apellido_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txt_dni.Focus();
        }

        /// <summary>
        /// En el textbox de DNI solo permite el ingreso de números
        /// tambien fija el foco del cursos al textbox de email
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_dni_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txt_email.Focus();
        }

        /// <summary>
        /// Permite el ingreso del email del usuario
        /// y luego fija el cursor en el textbox de teléfono
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_mail_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txt_tel.Focus();
        }

        /// <summary>
        /// En el textbox de Teléfono solo permite el ingreso de números
        /// tambien fija el foco del cursos al textbox de dirección
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_tel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txt_dir.Focus();
        }

        /// <summary>
        /// Permite caracteres alfanuméricos en el textbox de dirección
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_dir_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            List<Cliente> lista_cliente = new CN_cliente().ListarClientes();

            foreach(Cliente cli in lista_cliente)
            {
                dtg_clientes.Rows.Add(new object[]
                {
                    cli.nombre,
                    cli.apellido,
                    cli.dni,
                    cli.email,
                    cli.tel,
                    cli.direccion,
                    cli.fecha_nacimiento
                });
            }
        }
    }
}
