using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public interface IInscripcionBLL
    {
        void Agregar(Inscripcion ip);

        List<Inscripcion> Listar();

        List<Inscripcion> Listar(Categoria categoria);

        List<Inscripcion> Listar(Nivel nivel);


    }
}
