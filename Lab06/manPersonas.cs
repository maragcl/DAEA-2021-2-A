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

namespace Lab06
{
    public partial class manPersonas : Form
    {
        SqlConnection con;
        DataSet ds = new DataSet();
        DataTable tablePerson = new DataTable();

        //Conexión a SQL SERVER
        String servidor = "LAPTOP-AOPQJ586\\SQLEXPRESS";
        String db = "School";
        public manPersonas()
        {
            InitializeComponent();
        }

        private void manPersonas_Load(object sender, EventArgs e)
        {
            //  txtPersonID.Enabled = false;

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
                //con.Open();
                String sql = "select * from Person";
                SqlCommand cmd = new SqlCommand(sql, con);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.SelectCommand = cmd;

                //Llenamos el dataset con una tabla llamada Person
                adapter.Fill(ds, "Person");

                //Asignamos esa tabla del dataset a un objeto Table
                //para trabajar directamente con él
                tablePerson = ds.Tables["Person"];
                dgvListado.DataSource = "";
                dgvListado.Refresh();
                dgvListado.DataSource = tablePerson;
                dgvListado.Refresh();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al hacer la consulta: \n" + ex.ToString());
            }
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            //con.Open();
            SqlCommand cmd = new SqlCommand("InsertPerson", con);
           
            cmd.Parameters.Add("@LastName", SqlDbType.VarChar, 50, "LastName");
            cmd.Parameters.Add("@FirstName", SqlDbType.VarChar, 50, "FirstName");
            cmd.Parameters.Add("@HireDate", SqlDbType.Date).SourceColumn = "HireDate";
            cmd.Parameters.Add("@EnrollmentDate", SqlDbType.Date).SourceColumn = "EnrollmentDate";

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.InsertCommand = cmd;
            adapter.InsertCommand.CommandType = CommandType.StoredProcedure;

            //Creamos una nueva fila la cual insertaremos en la DB
            //esta fila debe tener la estructura correspondiente
            DataRow fila = tablePerson.NewRow();
            fila["LastName"] = txtFirstName.Text;
            fila["FirstName"] = txtLastName.Text;
            fila["HireDate"] = txtHireDate.Text;
            fila["EnrollmentDate"] = txtEnrollmentDate.Text;

            //Una ves tenemos la fila, la agregamos a la tabla Person de dataset
            tablePerson.Rows.Add(fila);

            //Actualizamos el dataset con la tabla Person
            adapter.Update(tablePerson);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            //con.Open();
            SqlCommand cmd = new SqlCommand("UpdatePerson", con);

            cmd.Parameters.Add("@PersonID", SqlDbType.VarChar).SourceColumn = "PersonID";
            cmd.Parameters.Add("@LastName", SqlDbType.VarChar, 50, "LastName");
            cmd.Parameters.Add("@FirstName", SqlDbType.VarChar, 50, "FirstName");
            cmd.Parameters.Add("@HireDate", SqlDbType.Date).SourceColumn = "HireDate";
            cmd.Parameters.Add("@EnrollmentDate", SqlDbType.Date).SourceColumn = "EnrollmentDate";

            SqlDataAdapter adapter = new SqlDataAdapter();
            adapter.UpdateCommand = cmd;
            adapter.UpdateCommand.CommandType = CommandType.StoredProcedure;

            //Creamos un array de DataRow el cual almacenará la fila que coincida
            //con el resultado de la búsqueda de PersonID
            //A cada campo de la fila, le asignamos el valor modificado
            DataRow[] fila = tablePerson.Select("PersonID = '" + txtPersonID.Text + "'");
            fila[0]["LastName"] = txtFirstName.Text;
            fila[0]["FirstName"] = txtLastName.Text;
            fila[0]["HireDate"] = txtHireDate.Text;
            fila[0]["EnrollmentDate"] = txtEnrollmentDate.Text;

            //Actualizamos el dataset con la tabla modificada
            adapter.Update(tablePerson);
        }

        private void dgvListado_SelectionChanged(object sender, EventArgs e)
        {
            if (dgvListado.SelectedRows.Count > 0)
            {
                txtPersonID.Text = dgvListado.SelectedRows[0].Cells[0].Value.ToString();
                txtLastName.Text = dgvListado.SelectedRows[0].Cells[1].Value.ToString();
                txtFirstName.Text = dgvListado.SelectedRows[0].Cells[2].Value.ToString();
                String hireDate = dgvListado.SelectedRows[0].Cells[3].Value.ToString();
                if (String.IsNullOrEmpty(hireDate))
                {
                    txtHireDate.Checked = false;
                }
                else
                {
                    txtHireDate.Text = hireDate;
                }

                String enrollmentDate  = dgvListado.SelectedRows[0].Cells[4].Value.ToString();
                if (String.IsNullOrEmpty(enrollmentDate))
                {
                    txtEnrollmentDate.Checked = false;
                }
                else
                {
                    txtEnrollmentDate.Text = enrollmentDate;
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {           
            txtFirstName.Text = "";
            txtLastName.Text = "";
            txtHireDate.Value = DateTime.Now;
            txtEnrollmentDate.Value = DateTime.Now;
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("DeletePerson", con);
                cmd.Parameters.Add("@PersonID", SqlDbType.NChar).SourceColumn = "PersonID";
                //cmd.Parameters.AddWithValue("@PersonID", txtPersonID.Text);

                SqlDataAdapter adapter = new SqlDataAdapter();
                adapter.DeleteCommand = cmd;
                adapter.DeleteCommand.CommandType = CommandType.StoredProcedure;

                //Buscamos la fila a eliminar
                DataRow[] fila = tablePerson.Select("PersonID = '" + txtPersonID.Text + "'");

                //Eliminamos de la tabla la fila especificada
                tablePerson.Rows.Remove(fila[0]);
                //Actualizamos el dataset con la tabla modificada
                adapter.Update(tablePerson);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar: \n" + ex.ToString());
            }
           
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnOrdenarPorApelido_Click(object sender, EventArgs e)
        {
            DataView dv = new DataView(tablePerson);
            dv.Sort = "LastName asc";
            dgvListado.DataSource = dv;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            //Usamos LINQ para definir el radio button seleccionado
            var checkedButton = pTipoBusqueda.Controls.OfType<RadioButton>()
                                      .FirstOrDefault(r => r.Checked);

            DataView dv = new DataView(tablePerson);
            //Encontramos el radio button seleccionado
            switch (checkedButton.Text)
            {
                
                case "Código":                    
                    dv.RowFilter = "PersonID = '" + txtPersonID.Text + "'";
                    dgvListado.DataSource = dv;
                    break;
                case "Nombre":
                    dv.RowFilter = "FirstName = '" + txtFirstName.Text + "'";
                    dgvListado.DataSource = dv;
                    break;
                case "Apellido":
                    dv.RowFilter = "LastName = '" + txtLastName.Text + "'";
                    dgvListado.DataSource = dv;
                    break;
                case "Contrato":
                    dv.RowFilter = "HireDate = '" + txtHireDate.Value + "'";
                    dgvListado.DataSource = dv;
                    break;
                case "Inscripción":
                    dv.RowFilter = "EnrollmentDate = '" + txtEnrollmentDate.Value + "'";
                    dgvListado.DataSource = dv;
                    break;
                default: 
                    dv.RowFilter = "PersonID = '" + txtPersonID.Text + "'";
                    dgvListado.DataSource = dv;
                    break;
            }
        }
    }
}
