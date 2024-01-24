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
        
        List<Person> test = new List<Person>();
        List<String> triNoms = new List<String>();
        List<String> triPrenoms = new List<String>();

        do{
        
        Console.WriteLine("Saisir le nom");
        nom = Console.ReadLine();

        Console.WriteLine("Saisir le prénom");
        prenom = Console.ReadLine();

<<<<<<< HEAD
        Person myPerson = new Person(nom,prenom);       
=======
        Console.WriteLine("Le nom est " + nom + " le prenom est " + prenom);
        Person myPerson = new Person(nom,prenom);
        

        Console.WriteLine("Le nom est " + myPerson.getNom() + " le prenom est " + myPerson.getPrenom());
>>>>>>> fb0fe94786ec6c60dbb57be8f63d3de0953a148c

        test.Add(myPerson);
        PersonContainer myPersonContainer = new PersonContainer(test);

        triNoms.Add(myPerson.getNom());
        triPrenoms.Add(myPerson.getPrenom());

        myPersonContainer.SortByLastName(triNoms);
        myPersonContainer.SortByFirstName(triPrenoms);

        Console.WriteLine("Noms par ordre alphabétique:");

        for(int i =0; i < triNoms.Count;i++)
        {
            Console.WriteLine(triNoms[i]);
        }

        Console.WriteLine("Prenoms par ordre alphabétique:");

        for(int i =0; i < triPrenoms.Count;i++)
        {
            Console.WriteLine(triPrenoms[i]);
        }

        Console.WriteLine("Voulez vous ajouter une autre personne? o pour oui, q pour quitter.");

        }while(Console.ReadLine().Equals("o"));

    }
}


