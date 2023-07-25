using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Entidad;
using Capa_Negocios;

namespace Registro
{
    public partial class Form1 : Form
    {
        ClassEntidad objent = new ClassEntidad();
        ClassNegocio objneg = new ClassNegocio();



        public Form1()
        {
            InitializeComponent();
        }

        void Mantenimiento(String accion)
        {
            objent.Codigo = TB_Codigo.Text;
            objent.Nombre = TB_Nombre.Text;
            objent.Edad = Convert.ToInt32(TB_Edad.Text);
            objent.Telefono = Convert.ToInt32(TB_Telefono.Text);
            objent.Accion = accion;
            string men = objneg.N_Mantenimiento_Cliente(objent);
            MessageBox.Show(men, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        void Limpiar()
        {
            TB_Codigo.Text = "";
            TB_Nombre.Text = "";
            TB_Edad.Text = "";
            TB_Telefono.Text = "";
            BuscarNombre_TB.Text = "";
            DGV_Lista.DataSource = objneg.N_Listar_Personal();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DGV_Lista.DataSource = objneg.N_Listar_Personal();
        }

        private void BT_Nuevo_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void BT_Registrar_Click(object sender, EventArgs e)
        {
            if (TB_Codigo.Text == "")
            {
                if (MessageBox.Show("Desaeas registrar a" + TB_Nombre.Text + "?", "Mensaje", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                Mantenimiento("1");
                Limpiar();
                }


            }
        }

        private void BT_Modificar_Click(object sender, EventArgs e)
        {
            if (TB_Codigo.Text != "")
            {
                if (MessageBox.Show("Desaeas Modificar a" + TB_Nombre.Text + "?", "Mensaje", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    Mantenimiento("2");
                    Limpiar();
                }


            }
        }

        private void BT_Eliminar_Click(object sender, EventArgs e)
        {
            if (TB_Codigo.Text != "")
            {
                if (MessageBox.Show("Desaeas Eliminar a" + TB_Nombre.Text + "?", "Mensaje", MessageBoxButtons.YesNo,
                    MessageBoxIcon.Information) == System.Windows.Forms.DialogResult.Yes)
                {
                    Mantenimiento("3");
                    Limpiar();
                }


            }
        }

        private void BuscarNombre_TB_TextChanged(object sender, EventArgs e)
        {
            if (BuscarNombre_TB.Text != "")
            {
                objent.Nombre = BuscarNombre_TB.Text;
                DataTable dt = new DataTable();
                dt = objneg.N_Buscar_Clientes(objent);
                DGV_Lista.DataSource= dt; 
            }
            else
            {
                DGV_Lista.DataSource = objneg.N_Listar_Personal();
            }
        }

        private void DGV_Lista_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = DGV_Lista.CurrentCell.RowIndex;

            TB_Codigo.Text = DGV_Lista[0, fila].Value.ToString();
            TB_Nombre.Text = DGV_Lista[1,fila].Value.ToString();
            TB_Edad.Text = DGV_Lista[2,fila].Value.ToString();
            TB_Telefono.Text= DGV_Lista[3,fila].Value.ToString();
        }

        private void TB_Telefono_TextChanged(object sender, EventArgs e)
        {

        }
    }
    }

