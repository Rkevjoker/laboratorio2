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
    public partial class FrmVIsta : Form
    {
        public FrmVIsta()
        {
            InitializeComponent();
        }

        private void FrmVIsta_Load(object sender, EventArgs e)
        {
            NClsPersonas clsPersona = new NClsPersonas();
            var ok = clsPersona.FinalList();

            foreach (var Interar in ok)
            {
                dataGridView1.Rows.Add(Interar.nombrePersona, Interar.edadPersona, Interar.descripcionPersona);
            }
        }
    }
}
