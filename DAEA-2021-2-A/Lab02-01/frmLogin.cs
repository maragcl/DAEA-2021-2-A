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

namespace Lab02_01
{
    public partial class frmLogin : Form
    {
        SqlConnection conn;
        String servidor = "LAPTOP-AOPQJ586\\SQLEXPRESS";
        String db = "db_lab03";
        private string usuario;
        private string password;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            usuario = txtUsuario.Text;
            password = txtPassword.Text;

            String str = "Server=" + servidor + ";Database=" + db + ";Integrated Security=true";

            //Abrir una conexión con el servidor, usando la cadena de conexión
            try
            {
                conn = new SqlConnection(str);
                conn.Open();
                //MessageBox.Show("Conectado satisfactoriamente");

                //Utilizamos los parámetros y SqlDataReader para proteger(binding) los datos
                using (SqlCommand StrQuer = new SqlCommand(
                    "SELECT * FROM tbl_usuario WHERE usuario_nombre=@username AND usuario_password=@password", conn)
                    )
                {
                    StrQuer.Parameters.AddWithValue("@username", usuario);
                    StrQuer.Parameters.AddWithValue("@password", password);
                    SqlDataReader dr = StrQuer.ExecuteReader();
                    if (dr.HasRows)
                    {
                        PrincipalMDI principal = new PrincipalMDI();
                        principal.Show();
                        this.Hide();
                    }
                    else
                    {
                        MessageBox.Show("User doesn't exits");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con el servidor: \n" + ex.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}