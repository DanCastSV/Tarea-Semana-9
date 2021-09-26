using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practica240921
{
    class Alumno
    {
        //Propiedades autoimplementadas
        //Datos de alumnos
        public string IdStudent { get; set; }
        public string NameStudent { get; set; }
        public string LastNameStudent { get; set; }
        public string AgeStudent { get; set; }

        //elegi autoimplemantadas para ahorrar lineas de codigo y sea mas facil de entender 

        // metodo constructor 

        public Alumno(string id,string name,string lastname,string age)
        {
            IdStudent = id;
             NameStudent = name;
             LastNameStudent = lastname;
            AgeStudent = age;
      
        }
        //Metodo de llamada 
        public string getinfoStudent()
        {
            return "El Id de el estudiante ingresado es: " + IdStudent + " Nombre: " + NameStudent + " Apellido: "
                + LastNameStudent + " Edad: " + AgeStudent;
        
        }

    }
}
