using laboratori2.Data;
using laboratori2.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laboratori2.Repository
{
    class RClsPersona : IPersonas
    {
        public void guardar(persona persona)
        {
            using (almacendepersonasEntities conexionBd = new almacendepersonasEntities())
            {
                try
                {
                    persona person = new persona();
                    person.nombrePersona = persona.nombrePersona;
                    person.edadPersona = persona.edadPersona;
                    person.descripcionPersona = persona.descripcionPersona;

                    conexionBd.persona.Add(person);
                    conexionBd.SaveChanges();

                    MessageBox.Show("Guardado con exito");

                }

                catch (Exception ex)

                {

                    MessageBox.Show("se ha producido un error al guardar" + ex.ToString());

                }

            }
        }

        public List<persona> listardatos()
        {
            using (almacendepersonasEntities conexionBd = new almacendepersonasEntities())
            {
                List<persona> ListOfData = conexionBd.persona.ToList();

                return ListOfData;
            }
        }
    }
}