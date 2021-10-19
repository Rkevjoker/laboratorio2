using laboratori2.Data;
using laboratori2.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laboratori2.Negocio
{
    class NClsPersonas : RClsPersona
    {
        public void SaveAdults(persona person)
        {

            if (person.edadPersona >= 18)

            {
                guardar(person);
            }
            else
                MessageBox.Show("No es mayor de edad");
        }


        public List<persona> FinalList()
        {
            List<persona> list = listardatos();
            return list;
        }

    }
}

