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

namespace Lab05
{
    public partial class Form1 : Form
    {
        SqlConnection con;
        String servidor = "LAPTOP-AOPQJ586\\SQLEXPRESS";
        String db = "School";
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            String str = "Server=" + servidor + ";Database=" + db + ";Integrated Security=true";

            try
            {
                con = new SqlConnection(str);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al conectar con el servidor: \n" + ex.ToString());
            }
        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            try
            {
                con.Open();
                String sql = "select * from Person";
                SqlCommand cmd = new SqlCommand(sql, con);
                SqlDataReader reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);

                dgvListado.DataSource = dt;
                dgvListado.Refresh();
                con.Close();               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al hacer la consulta: \n" + ex.ToString());
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            con.Open();
            String sp = "InsertPerson";
            SqlCommand cmd = new SqlCommand(sp, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
            cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
            cmd.Parameters.AddWithValue("@HireDate", txtHireDate.Value);
            cmd.Parameters.AddWithValue("@EnrollmentDate", txtEnrollmentDate.Value);

            int codigo = Convert.ToInt32(cmd.ExecuteScalar());
            MessageBox.Show("Se ha registrado nueva persona con el código: " + codigo);
            con.Close();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            con.Open();
            String sp = "UpdatePerson";
            SqlCommand cmd = new SqlCommand(sp, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PersonID", txtPersonID.Text);
            cmd.Parameters.AddWithValue("@FirstName", txtFirstName.Text);
            cmd.Parameters.AddWithValue("@LastName", txtLastName.Text);
            cmd.Parameters.AddWithValue("@HireDate", txtHireDate.Value);
            cmd.Parameters.AddWithValue("@EnrollmentDate", txtEnrollmentDate.Value);

            int resultado = cmd.ExecuteNonQuery();
            if (resultado > 0)
            {
                MessageBox.Show("Se ha modificado el registro correctamente");
            }      
            con.Close();
        }

        private void dgvListado_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvListado.SelectedRows.Count > 0)
            {
                txtPersonID.Text = dgvListado.SelectedRows[0].Cells[0].Value.ToString();
                txtFirstName.Text = dgvListado.SelectedRows[0].Cells[1].Value.ToString();
                txtLastName.Text = dgvListado.SelectedRows[0].Cells[2].Value.ToString();
                txtHireDate.Text = dgvListado.SelectedRows[0].Cells[3].Value.ToString();
                txtEnrollmentDate.Text = dgvListado.SelectedRows[0].Cells[4].Value.ToString();
            }
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            con.Open();
            String sp = "DeletePerson";
            SqlCommand cmd = new SqlCommand(sp, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@PersonID", txtPersonID.Text);
            try
            {
                int resultado = cmd.ExecuteNonQuery();

                if (resultado > 0)
                {
                    MessageBox.Show("Se ha eliminado el registro correctamente");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }            
            con.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            
            con.Open();
            //Usamos LINQ para definir el radio button seleccionado
            var checkedButton = pTipoBusqueda.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);
            String Busqueda = "";
            
            //Encontramos el radio button seleccionado
            switch (checkedButton.Text)
            {
                case "Código":
                    Busqueda = txtPersonID.Text;
                    break;
                case "Nombre":
                    Busqueda = txtFirstName.Text;
                    break;
                case "Apellido":
                    Busqueda = txtLastName.Text;
                    break;
                default:
                    Busqueda = txtPersonID.Text;
                    break;
            }

            //Realizamos la búsqueda
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = "BuscarGeneral";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Connection = con;

            SqlParameter param = new SqlParameter();
            param.ParameterName = "@Busqueda";
            param.SqlDbType = SqlDbType.NVarChar;
            param.Value = Busqueda;

            cmd.Parameters.Add(param);

            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            dgvListado.DataSource = dt;
            dgvListado.Refresh();
            con.Close();
        }
    }
}
