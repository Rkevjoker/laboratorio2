using laboratori2.Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laboratori2.Vistas
{
    public partial class FrmView : Form
    {
        public FrmView()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FrmView_Load(object sender, EventArgs e)
        {
            NClsPersonas clsPersona = new NClsPersonas();
            var ok = clsPersona.FinalList();

            foreach (var iterar in ok)
            {
                dataGridView1.Rows.Add(iterar.nombrePersona, iterar.edadPersona, iterar.descripcionPersona);
            }
        }
    }
}
