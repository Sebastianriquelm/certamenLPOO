using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace OtecLibrary
{
    public class ASIGNATURA
    {
        private int cod_asignatura1;
        private int cod_asignatura2;
        private int cod_asignatura3;
        private string Nom_asignatura1;
        private string Nom_asignatura2;
        private string Nom_asignatura3;
        private string[] arraylist = {"POO", "bd", "ingles","xd" };

        public ASIGNATURA()
        {

        }

        public ASIGNATURA(int cod_asignatura1, int cod_asignatura2, int cod_asignatura3, string nom_asignatura1, string nom_asignatura2, string nom_asignatura3)
        {
            this.Cod_asignatura1 = cod_asignatura1;
            this.Cod_asignatura2 = cod_asignatura2;
            this.Cod_asignatura3 = cod_asignatura3;
            Nom_asignatura11 = nom_asignatura1;
            Nom_asignatura21 = nom_asignatura2;
            Nom_asignatura31 = nom_asignatura3;
        }

        public int Cod_asignatura1 { get => cod_asignatura1; set => cod_asignatura1 = value; }
        public int Cod_asignatura2 { get => cod_asignatura2; set => cod_asignatura2 = value; }
        public int Cod_asignatura3 { get => cod_asignatura3; set => cod_asignatura3 = value; }
        public string Nom_asignatura11 { get => Nom_asignatura1; set => Nom_asignatura1 = value; }
        public string Nom_asignatura21 { get => Nom_asignatura2; set => Nom_asignatura2 = value; }
        public string Nom_asignatura31 { get => Nom_asignatura3; set => Nom_asignatura3 = value; }
        public string[] Arraylist { get => arraylist; set => arraylist = value; }
    }


}
