using System;
using System.Collections.Generic;

interface IPersonContainer
{
    List<Person> SortByLastName();
    List<Person> SortByFirstName();
}

class Program {
        public static void Main (string[] args) {

        // See https://aka.ms/new-console-template for more information
        Console.WriteLine("Hello, World!");

        string nom;
        string prenom;

        Console.WriteLine("Saisir le nom");
        nom = Console.ReadLine();

        Console.WriteLine("Saisir le prénom");
        prenom = Console.ReadLine();

        Console.WriteLine("Le nom est " + nom + " le prenom est " + prenom);

        Person myPerson = new Person(nom,prenom);
        

        Console.WriteLine("Le nom est " + myPerson.nom + " le prenom est " + myPerson.prenom);

        List<Person> test = new List<Person>() { myPerson };
        PersonContainer myPersonContainer = new PersonContainer(test);

    }
}


