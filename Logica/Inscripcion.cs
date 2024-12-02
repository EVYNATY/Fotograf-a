using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{

    public enum Categoria
    {
        Default,
        Naturaleza,
        Retrato,
        Urbano
    }

    public enum Nivel
    {
        Default,
        Aficionado,
        Profesional
    }
    public class Inscripcion
    {
        private string _nombre;
        private string _email;
        private DateTime _fechaInscripcion;
        private Categoria _categoria;
        private Nivel _nivel;
        private decimal monto;


        public string Nombre { get => _nombre; set => _nombre = value; }
        public string Email { get => _email; set => _email = value; }
        public DateTime FechaInscripcion { get => _fechaInscripcion; set => _fechaInscripcion = value; }
        public Categoria Categoria { get => _categoria; set => _categoria = value; }
        public Nivel Nivel { get => _nivel; set => _nivel = value; }
        public  decimal Monto { get => monto; set => monto= value; }


        public Inscripcion()
        {
            Nivel = Nivel.Default;
            Categoria = Categoria.Default;
        }

        public Inscripcion(string nombre, string email, Categoria categoria, Nivel nivel)
        {


            Nombre = nombre;
            Email = email;
            Categoria = Categoria.Default;
            Nivel = Nivel.Default;

        }

        public Inscripcion(string nombre, string email)
        {

            Nombre = nombre;
            Email = email;
            Categoria = Categoria.Default;
            Nivel = Nivel.Default;
        }

        public override string ToString()
        {
            return Nombre + " " + Email;
        }




    }


}
