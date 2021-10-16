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
    public partial class Cursos : Form
    {
        SqlConnection conn;
        public Cursos(SqlConnection conn)
        {
            this.conn = conn;
            InitializeComponent();
        }

        private void Cursos_Load(object sender, EventArgs e)
        {

        }

        private void btnListar_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                String sql = "select * from Course";
                SqlCommand cmd = new SqlCommand(sql, conn);
                SqlDataReader reader = cmd.ExecuteReader();

                DataTable dt = new DataTable();
                dt.Load(reader);
                dgvListadoCursos.DataSource = dt;
                dgvListadoCursos.Refresh();
            }
            else
            {
                MessageBox.Show("La conexión está cerrada");
            }
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (conn.State == ConnectionState.Open)
            {
                String FirstName = txtTitle.Text;
                SqlCommand cmd = new SqlCommand();
                cmd.CommandText = "BuscarCursoNombre";
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Connection = conn;

                SqlParameter param = new SqlParameter();
                param.ParameterName = "@Title";
                param.SqlDbType = SqlDbType.NVarChar;
                param.Value = FirstName;

                cmd.Parameters.Add(param);

                SqlDataReader reader = cmd.ExecuteReader();
                DataTable dt = new DataTable();
                dt.Load(reader);
                dgvListadoCursos.DataSource = dt;
                dgvListadoCursos.Refresh();
            }
            else
            {
                MessageBox.Show("La conexión está cerrada");
            }
        }
    }
}
