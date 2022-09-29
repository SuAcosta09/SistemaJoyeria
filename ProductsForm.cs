using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winformadvance
{
    public partial class ProductsForm : Form
    {
        int pos;
        public ProductsForm()
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

            txt_cod.Clear();
            txt_nombre.Clear();
            txt_compra.Clear();
            txt_venta.Clear();
            txt_stock.Clear();
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        /// <summary>
        /// Verifica si estan completos todos los campos
        /// si está bien entonces te pregunta si quieres guardar los datos 
        /// y sino te indica que completes correctamente todos los datos
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (txt_cod.Text == "" || txt_nombre.Text == "" || txt_venta.Text == "" ||
                txt_compra.Text == "" || txt_stock.Text == "" )
            {
                MessageBox.Show("Debe completar todos los campos!", "ERROR!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Seguro que desea guardar el producto?",
                            "Datos Guardados!",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    string cod, nombre, venta, compra, gen, marca, stock;

                    cod = txt_cod.Text;
                    nombre = txt_nombre.Text;
                    venta = txt_venta.Text;
                    compra = txt_compra.Text;
                    gen = combo_genero.Text;
                    marca = combo_marca.Text;
                    stock = txt_stock.Text;

                    dtg_prod.Rows.Add(cod, nombre, venta,compra, gen, marca, stock);
                    limpiar();
                }
                else
                {
                    limpiar();
                }
            }
        }

        /// <summary>
        /// carga los datos en los textbox para ser visualizados o aplicarle cambios al registro
        /// a demás deshabilita el boton guardar  y habilita el modificar y eliminar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dtg_prod_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;


            txt_cod.Text = dtg_prod.CurrentRow.Cells["cod"].Value.ToString();
            txt_nombre.Text = dtg_prod.CurrentRow.Cells["name"].Value.ToString();
            txt_venta.Text = dtg_prod.CurrentRow.Cells["venta"].Value.ToString();
            txt_compra.Text = dtg_prod.CurrentRow.Cells["compra"].Value.ToString();
            combo_genero.Text = dtg_prod.CurrentRow.Cells["Gen"].Value.ToString();
            combo_marca.Text = dtg_prod.CurrentRow.Cells["marca"].Value.ToString();
            txt_stock.Text = dtg_prod.CurrentRow.Cells["Stock"].Value.ToString();


            btn_guardar.Enabled = false;
            btn_guardar.BackColor = Color.Transparent;

            btn_eliminar.Enabled = true;
            btn_eliminar.BackColor = Color.FromArgb(194, 59, 60);
            btn_modif.Enabled = true;
            btn_modif.BackColor = Color.FromArgb(194, 59, 60);
        }
        private void btn_modif_Click(object sender, EventArgs e)
        {
            if (txt_cod.Text == "" || txt_nombre.Text == "" || txt_venta.Text == "" ||
                txt_compra.Text == "" || txt_stock.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos!", "ERROR!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Seguro que desea modificar el producto?",
                            "Datos Guardados!",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    string cod, nombre, venta, compra, gen, marca, stock;

                    cod = txt_cod.Text;
                    nombre = txt_nombre.Text;
                    venta = txt_venta.Text;
                    compra = txt_compra.Text;
                    gen = combo_genero.Text;
                    marca = combo_marca.Text;
                    stock = txt_stock.Text;

                    dtg_prod[0, pos].Value = txt_cod.Text;
                    dtg_prod[1, pos].Value = txt_nombre.Text;
                    dtg_prod[2, pos].Value = txt_venta.Text;
                    dtg_prod[3, pos].Value = txt_compra.Text;
                    dtg_prod[4, pos].Value = combo_genero.Text;
                    dtg_prod[5, pos].Value = combo_marca.Text;
                    dtg_prod[6, pos].Value = txt_stock.Text;

                    limpiar();
                }
                else
                {
                    limpiar();
                }
            }
        }

        /// <summary>
        /// elimina el producto seleccionado preguntando previamente una confirmacion 
        /// y limpia los textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea eliminar el producto?", "Eliminar Datos!", MessageBoxButtons.YesNo,
                MessageBoxIcon.Question, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {
                dtg_prod.Rows.RemoveAt(pos);
                limpiar();
            }
            else
            {
                limpiar();
            }
        }

        //*********************************** VALIDACIONES ***********************************

        /// <summary>
        /// solo permite ingresar números 
        /// y luego pasa el foco al textbox de nombre del producto
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_cod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txt_nombre.Focus();
        }

        /// <summary>
        /// Solo permite ingresar letars y espacio en blanco
        /// luego pasa elfoco al tetbox de 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_nombre_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txt_venta.Focus();
        }

        /// <summary>
        /// permite ingresar solo números y un solo punto para representar dinero
        /// luego enfoca al textbox de compra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_venta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                e.Handled = true;

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txt_compra.Focus();
        }

        /// <summary>
        /// permite ingresar solo números y un solo punto para representar dinero
        /// luego enfoca al textbox de compra
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_compra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                e.Handled = true;

            if (e.KeyChar == Convert.ToChar(Keys.Enter))
                txt_stock.Focus();
        }

        /// <summary>
        /// permite ingresar solo números
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txt_stock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
