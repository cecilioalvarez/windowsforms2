using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsForms001
{
    class PersonaRepositoryMemoria : IPersonaRepository
    {
        public IList<Persona> BuscarTodos()
        {
            IList<Persona> lista = new List<Persona>();
            lista.Add(new Persona("juan", 20));
            lista.Add(new Persona("david", 30));
            lista.Add(new Persona("ana", 40));

            return lista;

        }
    }
}
