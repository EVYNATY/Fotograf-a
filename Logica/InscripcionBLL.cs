using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logica
{
    public class InscripcionBLL : IInscripcionBLL
    {
        private static List<Inscripcion> inscripciones = new List<Inscripcion>();

        public void Agregar(Inscripcion ip)
        {
            // Calcular el monto y asignar a la inscripción
            ip.Monto = CalcularMonto(ip.Categoria, ip.Nivel, ip.FechaInscripcion);
            inscripciones.Add(ip);
        }

        public List<Inscripcion> Listar()
        {
            return inscripciones;
        }

        public List<Inscripcion> Listar(Categoria categoria)
        {
            return inscripciones.FindAll(ip => ip.Categoria == categoria);
        }

        public List<Inscripcion> Listar(Nivel nivel)
        {
            return inscripciones.FindAll(ip => ip.Nivel == nivel);
        }

        //Metodo para calcular el monto
        public decimal CalcularMonto(Categoria categoria, Nivel nivel, DateTime fechaInscripcion)
        {
            decimal montoBase = 0;

            // Switch para elegir la categoria
            switch (categoria)
            {
                case Categoria.Naturaleza:
                    montoBase = nivel == Nivel.Profesional ? 15000 : 8000;
                    break;
                case Categoria.Retrato:
                    montoBase = nivel == Nivel.Profesional ? 12000 : 7000;
                    break;
                case Categoria.Urbano:
                    montoBase = nivel == Nivel.Profesional ? 18000 : 10000;
                    break;
            }

            // Calcular descuento del 5%
            if (fechaInscripcion < new DateTime(DateTime.Now.Year, 10, 30))
            {
                montoBase *= 0.95m; 
            }

            return montoBase;
        }
    }
}
