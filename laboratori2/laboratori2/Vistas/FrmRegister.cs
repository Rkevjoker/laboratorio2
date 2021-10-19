using laboratori2.Data;
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
    public partial class FrmRegister : Form
    {
        public FrmRegister()
        {
            InitializeComponent();
        }

        private void save_Click(object sender, EventArgs e)
        {
            persona person = new persona();
            person.nombrePersona = textBox1.Text;
            person.edadPersona = int.Parse(textBox2.Text);
            person.descripcionPersona = textBox3.Text;

            NClsPersonas clsPersona = new NClsPersonas();
            clsPersona.SaveAdults(person);
        }

        private void register_Click(object sender, EventArgs e)
        {
            FrmRegister formulario = new FrmRegister();
            formulario.Show();
        }
    }
}
