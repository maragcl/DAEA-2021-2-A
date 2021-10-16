using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;

namespace Presentacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            clsNegPerson np = new clsNegPerson();
            dt = np.GetAll();

            dgvDatos.DataSource = dt;
            dgvDatos.Refresh();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String Busqueda = txtBuscar.Text;

            DataTable dt = new DataTable();
            clsNegPerson np = new clsNegPerson();
            dt = np.Search(Busqueda);
            dgvDatos.DataSource = dt;
            dgvDatos.Refresh();
        }
    }
}
