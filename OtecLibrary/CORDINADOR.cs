using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OtecLibrary
{
    public class CORDINADOR
    {
        private string nom_cordinador;
        private CURSOS cod_curso = new CURSOS();
        private int telefono;

        
        public string Nom_cordinador { get => nom_cordinador; set => nom_cordinador = value; }
        public CURSOS Cod_curso { get => cod_curso; set => cod_curso = value; }
        public int Telefono { get => telefono; set => telefono = value; }

        public CORDINADOR(string nom_cordinador, CURSOS cod_curso, int telefono)
        {
            this.nom_cordinador = nom_cordinador;
            this.cod_curso = cod_curso;
            this.telefono = telefono;
        }

        
        public CORDINADOR()
        {
            
        }
    }
}
