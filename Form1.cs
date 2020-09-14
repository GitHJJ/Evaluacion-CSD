using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluacion_IM
{
   //Conexion c = new Conexion();
   public partial class Form1 : Form
   {
      Conexion UsarDatos = new Conexion();
      public Form1()
      { 
        InitializeComponent();

            pictureBox1.Image = Image.FromFile("buscar.gif");    
      }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Conexion objeto = new Conexion();
            //objeto.ActualizarGrid(this.dgvEmpresas, "select *from TblEmpresas");
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Limpiartxt();
            //UsarDatos.ActualizarGrid(this.dgvEmpresas, "select * from TblEmpresas where Nombre like '" + txtCodigo.Text + "%';");
            //UsarDatos.ActualizarGrid(this.dgvEmpresas, "select * from TblEmpresas where Nombre like '" + txtNombre.Text + "%';");
            //MessageBox.Show("Conexión Exitosa!");
        }

        public void Limpiartxt(){
            txtCodigo.Text = "";
            txtNombre.Text = "";
            Focus(); 
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void txtCodigo_KeyUp(object sender, KeyEventArgs e)
        {
            UsarDatos.ActualizarGrid(this.dgvEmpresas, "select * from TblEmpresas where EmpresaCodigo like '" + txtCodigo.Text + "%';");
           
        }

        private void txtNombre_KeyUp(object sender, KeyEventArgs e)
        {
            UsarDatos.ActualizarGrid(this.dgvEmpresas, "select * from TblEmpresas where Nombre like '" + txtNombre.Text + "%';");
        }
    }
}
