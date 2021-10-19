using laboratori2.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laboratori2.Service
{
    interface IPersonas
    {
        void guardar(persona persona);
        List<persona> listardatos();
    }
}
