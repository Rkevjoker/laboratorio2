using laboratori2.Data;
using laboratori2.Negocio;
using laboratori2.Vistas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laboratori2
{
    public partial class FrmSave : Form
    {
        public FrmSave()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            persona pers = new persona();
            pers.nombrePersona = Name.Text;
            pers.edadPersona = int.Parse(age.Text);
            pers.descripcionPersona = description.Text;

            NClsPersonas cls = new NClsPersonas();
            cls.SaveAdults(pers);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmView Frm = new FrmView();
            Frm.Show();
        }
    }
}
