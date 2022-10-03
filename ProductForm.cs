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
    public partial class ProductForm : Form
    {
        int pos;
        public ProductForm()
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
            btn_guardar.BackColor = Color.FromArgb(194, 59, 60);


            txt_cod.Clear();
            txt_nombre.Clear();
            txt_venta.Clear();
            txt_compra.Clear();
            txt_stock.Clear();
            
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void txt_cod_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void txt_nombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsLetter(e.KeyChar) && !char.IsWhiteSpace(e.KeyChar))
                e.Handled = true;
        }

        private void txt_venta_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                e.Handled = true;
        }

        private void txt_compra_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
                e.Handled = true;

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
                e.Handled = true;
        }

        private void txt_stock_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (txt_cod.Text == "" || txt_nombre.Text == "" || txt_compra.Text == ""
                || txt_venta.Text == "" || txt_stock.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos!", "ERROR!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Seguro que desea guardar al producto?",
                            "Guardar Datos!",
                            MessageBoxButtons.YesNo,
                            MessageBoxIcon.Question,
                            MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    string cod, nombre, pcompra, pventa, stock, marca, gen;

                    cod = txt_cod.Text;
                    nombre = txt_nombre.Text;
                    pcompra = txt_compra.Text;
                    pventa = txt_venta.Text;
                    stock = txt_stock.Text;
                    marca = combo_marca.Text;
                    gen = combo_gen.Text;

                    dtg_prod.Rows.Add(cod, nombre, pcompra, pventa, stock, marca, gen);
                    limpiar();
                }
                else
                {
                    limpiar();
                }
            }
        }

        private void dtg_prod_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex == -1) return;

            txt_cod.Text = dtg_prod.CurrentRow.Cells["cod"].Value.ToString();
            txt_nombre.Text = dtg_prod.CurrentRow.Cells["nombre"].Value.ToString();
            txt_venta.Text = dtg_prod.CurrentRow.Cells["pventa"].Value.ToString();
            txt_compra.Text = dtg_prod.CurrentRow.Cells["pcompra"].Value.ToString();
            txt_stock.Text = dtg_prod.CurrentRow.Cells["stock"].Value.ToString();
            combo_marca.Text = dtg_prod.CurrentRow.Cells["marca"].Value.ToString();
            combo_gen.Text = dtg_prod.CurrentRow.Cells["Genero"].Value.ToString();

            btn_guardar.Enabled = false;
            btn_guardar.BackColor = Color.Transparent;

            btn_eliminar.Enabled = true;
            btn_eliminar.BackColor = Color.FromArgb(194, 59, 60);
            btn_modif.Enabled = true;
            btn_modif.BackColor = Color.FromArgb(194, 59, 60);
        }

        private void btn_modif_Click(object sender, EventArgs e)
        {
            if (txt_cod.Text == "" || txt_nombre.Text == "" || txt_compra.Text == ""
                || txt_venta.Text == "" || txt_stock.Text == "")
            {
                MessageBox.Show("Debe completar todos los campos!", "ERROR!",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            else
            {
                if (MessageBox.Show("Seguro que desea modificar al producto?",
                           "Modificar Datos!",
                           MessageBoxButtons.YesNo,
                           MessageBoxIcon.Question,
                           MessageBoxDefaultButton.Button1) == DialogResult.Yes)
                {
                    string cod, nombre, pcompra, pventa, stock, marca, gen;

                    cod = txt_cod.Text;
                    nombre = txt_nombre.Text;
                    pcompra = txt_compra.Text;
                    pventa = txt_venta.Text;
                    stock = txt_stock.Text;
                    marca = combo_marca.Text;
                    gen = combo_gen.Text;


                    dtg_prod[0, pos].Value = txt_cod.Text;
                    dtg_prod[1, pos].Value = txt_nombre.Text;
                    dtg_prod[2, pos].Value = txt_venta.Text;
                    dtg_prod[3, pos].Value = txt_compra.Text;
                    dtg_prod[4, pos].Value = txt_stock.Text;
                    dtg_prod[5, pos].Value = combo_marca.Text;
                    dtg_prod[6, pos].Value = combo_gen.Text;

                    limpiar();
                }
                else
                {
                    limpiar();
                }
            }
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Seguro que desea eliminar al producto?", "Eliminar Datos!", MessageBoxButtons.YesNo,
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
    }
}
