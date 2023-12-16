using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChallengeApp.models
{
    public class Person
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }


       // Constructor que acepta parámetros para inicializar las propiedades
            public Person(int id, string name, string lastName, DateTime dateOfBirth)
        {
            Id = id;
            Name = name;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
        }

        // Método ToString() para obtener una representación de cadena de la persona
        public override string ToString()
        {
            return $"ID: {Id}, Name: {Name}, Last Name: {LastName}, Date of Birth: {DateOfBirth.ToShortDateString()}";
        }
    }
}
