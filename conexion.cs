using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Security.Cryptography.X509Certificates;

namespace Evaluacion_IM
{
    class Conexion  
    {
        SqlConnection cn;
        //SqlCommand cmd;
        //SqlDataReader dr;
        public void Conectar()
        {
            cn = new SqlConnection("Data Source=DESKTOP-2LL65V4\\SQLEXPRESS;Initial Catalog=EVALUACION;Integrated Security=True");
            cn.Open();
            //MessageBox.Show("Conexión Exitosa");
            //try
            //{


            //}
            //catch (Exception)
            //{
            //MessageBox.Show("Fallo la conexión" + ex.ToString());
            //}
        }

        public void EjecutarSQL(String Query) 
        {
            SqlCommand cmd = new SqlCommand(Query,cn);
            //string salida = "";
            try
            {
                //cmd = new SqlCommand("Select *from TblEmpresas where EmpresaID="+EmpresaID+"", cn);

                int FilasAfectadas = cmd.ExecuteNonQuery();

                if (FilasAfectadas > 0)
                    MessageBox.Show("Operación realizada","La db se ha modificado",MessageBoxButtons.OK, MessageBoxIcon.Information);
                else
                    MessageBox.Show("No se pudo modificar la DB", "Error del sistema =(", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //dr = cmd.ExecuteReader();
            }
            catch (Exception)
            {
                //salida = "No se conecto " + ex.ToString();
            }
            //return salida;
            
        }

        public void ActualizarGrid(DataGridView dg, String Query)
        {
            this.Conectar();
            //DataSet
            System.Data.DataSet ds = new System.Data.DataSet();
            //Adaptador de datos
            SqlDataAdapter da = new SqlDataAdapter(Query, cn);
            
            //Llena DataSet
            da.Fill(ds, "TblEmpresas");
            
            //asignando valores al DataGrid
            dg.DataSource = ds;
            dg.DataMember = "TblEmpresas";

            cn.Close();
        }
    }
}
