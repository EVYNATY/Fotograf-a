using Logica;
using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        InscripcionBLL ipbLL = new InscripcionBLL();



        Inscripcion p1 = new Inscripcion("Maria Gonzalez", "maria@gmail.com");
        Inscripcion p2 = new Inscripcion("Juan Perez", "jp@gmail.com");
        Inscripcion p3 = new Inscripcion("Violeta Rojas", "viro@gamail.com");

        p1.Categoria = Categoria.Retrato;

        ipbLL.Agregar(p1);
        ipbLL.Agregar(p2);


       

        foreach (Inscripcion ip in ipbLL.Listar())
        {
            Console.WriteLine(ip);
        }
        Console.ReadLine();

    }

}