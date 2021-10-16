using System;
using OtecLibrary;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace Otec
{
    class Program
    {
        static void Main(string[] args)
        {
            SEDE sede = new SEDE();
            sede.Id_sede = 231421;
            sede.Nom_sede1 = "Virginio Gomez";
            
            
            ADMINISTRADOR administrador = new ADMINISTRADOR();
            administrador.Nombre_admin = "Claudio Montoya";

            CURSOS curso = new CURSOS();
            curso.Nom_curso1 = "Ingeniería de Ejecución en Computación e Informática";

            ASIGNATURA lista1 = new ASIGNATURA();
            lista1.Arraylist.Count();

            CORDINADOR cordinador = new CORDINADOR();
            cordinador.Nom_cordinador = "Sebastian Riquelme";
         
            Console.WriteLine("Informacion de trabajador");
            Console.WriteLine("-------------------------");
            Console.WriteLine("Id Sede: " + sede.Id_sede + "\nNombre Sede: " + sede.Nom_sede1 + "\nNombre de Administrador: " + administrador.Nombre_admin + "" +"\nNombre Curso: " + curso.Nom_curso1 + "\nCantidad de Cursos: " + lista1.Arraylist.Count() + "\nNombre Coordinador:  "+ cordinador.Nom_cordinador);
            Console.ReadKey();
        }

            
        

        
    }
}
