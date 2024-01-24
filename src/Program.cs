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

        List<Person> listePersonnes= new List<Person>();
        List<String> triNoms = new List<String>();
        List<String> triPrenoms = new List<String>();

        do{
        
        Console.WriteLine("Saisir le nom");
        nom = Console.ReadLine();

        Console.WriteLine("Saisir le prénom");
        prenom = Console.ReadLine();

        Person myPerson = new Person(nom,prenom);       

        bool testPersonne = false;

        for(int i=0;i < listePersonnes.Count;i++)
        {
            if(listePersonnes[i].comparer(myPerson))
            {
                testPersonne=true;
            }
            else
            {
                testPersonne = false;
            }
        }
        if(testPersonne == false)
        {
            listePersonnes.Add(myPerson);
            triNoms.Add(myPerson.getNom());
            triPrenoms.Add(myPerson.getPrenom());
        }
        else
        {
            Console.WriteLine("La personne est déja présente dans la liste.");
        }

        PersonContainer myPersonContainer = new PersonContainer(listePersonnes);

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


