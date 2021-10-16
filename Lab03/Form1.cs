using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Lab03
{
    public partial class frmConDb : Form
    {
        SqlConnection conn;
        public frmConDb()
        {
            InitializeComponent();
        }

        private void txtServidor_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBaseDatos_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmConDb_Load(object sender, EventArgs e)
        {

        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            //Definimos la cadena de conexión
            String servidor = txtServidor.Text;
            String db = txtBaseDatos.Text;
            String user = txtUsuario.Text;
            String pwd = txtPassword.Text;

            String str = "Server=" + servidor + ";Database=" + db + ";";

            //La cadena de conexion cambia en función del estado de Checkbox
            if (chkAutenticacion.Checked)
            {
                str += "Integrated Security=true";
            }
            else
            {
                str += "User Id=" + user + "; Password=" + pwd + ";";
            }

            //Abrir una conexión con el servidor, usando la cadena de conexión
            try
            {
                conn = new SqlConnection(str);
                conn.Open();
                MessageBox.Show("Conectado satisfactoriamente");
                btnDesconectar.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con el servidor: \n" + ex.ToString());
            }

        }

        private void btnEstado_Click(object sender, EventArgs e)
        {
            //Intentamos obtener el estado de la conexión, y en caso esté abierta,
            //recuperamos información de la misma
            try
            {
                if (conn.State == ConnectionState.Open)
                {
                    MessageBox.Show("Estado del servidor: "+ conn.State +
                        "\nVersión del servidor: "+ conn.ServerVersion +
                        "\nBase de datos: "+ conn.Database);
                }
                else
                {
                    MessageBox.Show("Estado del servidor: " + conn.State);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Imposible determinar el estado del ssevidor: \n" +
                    ex.ToString());
            }
        }

        private void btnDesconectar_Click(object sender, EventArgs e)
        {
            //Para cerrar la conexión verificamos que no esté cerrada
            try
            {
                if (conn.State != ConnectionState.Closed)
                {
                    conn.Close();
                    MessageBox.Show("Conexión cerrada satisfactoriamente");
                }
                else
                {
                    MessageBox.Show("La conexión ya está cerrada");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ocurrió un error al cerrar la conexión: \n" +
                    ex.ToString());
            }
        }

        private void chkAutenticacion_CheckedChanged(object sender, EventArgs e)
        {
            if (chkAutenticacion.Checked)
            {
                txtUsuario.Enabled = false;
                txtPassword.Enabled = true;
            }
            else
            {
                txtUsuario.Enabled = true;
                txtPassword.Enabled = true;
            }
        }

        private void btnPersonas_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona(conn);
            persona.Show();
        }

        private void btnCursos_Click(object sender, EventArgs e)
        {
            Cursos curso = new Cursos(conn);
            curso.Show();
        }
    }
}
