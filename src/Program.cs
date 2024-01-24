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


        //Variables visants à récuperer less noms et prénoms saisis au clavier
        string nom;
        string prenom;


        //Liste de personnes, de noms et de prénoms
        List<Person> listePersonnes= new List<Person>();
        List<String> triNoms = new List<String>();
        List<String> triPrenoms = new List<String>();

        do{

        //Saisie du nom d'un personne
        Console.WriteLine("Saisir le nom");
        nom = Console.ReadLine();


        //Saisie du prénom d'une personne
        Console.WriteLine("Saisir le prénom");
        prenom = Console.ReadLine();

        //Création d'une personne avec le nom et le prénom saisis
        Person myPerson = new Person(nom,prenom);       

        //Booleen visant à tester si une personne est présente dans la liste
        bool testPersonne = false;

        //Test pour toute la liste de personnes si la nouvelle personne est présente dedans
        for(int i=0;i < listePersonnes.Count;i++)
        {
            //On compare(grace à la méthode de la classe Person) la personne de la liste à l'indice i avec la personne créée plus haut
            if(listePersonnes[i].comparer(myPerson))
            {
                testPersonne=true;
            }
            else
            {
                testPersonne = false;
            }
        }

        //Si la personne n'est pas présente, on l'ajoute
        if(testPersonne == false)
        {
            listePersonnes.Add(myPerson);
            triNoms.Add(myPerson.getNom());
            triPrenoms.Add(myPerson.getPrenom());
        }
        //Sinon on dit qu'elle est déja présente sans l'ajouter
        else
        {
            Console.WriteLine("La personne est déja présente dans la liste.");
        }

        //On instancie la classe PeopleContainer en lui donnant en attribut la liste de personnes
        PersonContainer myPersonContainer = new PersonContainer(listePersonnes);

        //On s'en sert pour trier les noms et prénoms grace à ses méthode de classes
        myPersonContainer.SortByLastName(triNoms);
        myPersonContainer.SortByFirstName(triPrenoms);

        //On affiche les noms
        Console.WriteLine("Noms par ordre alphabétique:");
        for(int i =0; i < triNoms.Count;i++)
        {
            Console.WriteLine(triNoms[i]);
        }

        //On afiche les prénoms
        Console.WriteLine("Prenoms par ordre alphabétique:");
        for(int i =0; i < triPrenoms.Count;i++)
        {
            Console.WriteLine(triPrenoms[i]);
        }

        //On demande à l'utilisateur s'il veut réjouter une personne
        Console.WriteLine("Voulez vous ajouter une autre personne? o pour oui, n'import quelle autre touche pour quitter.");

        }while(Console.ReadLine().Equals("o"));//Si o , on repasse dans la boucle, sinon on quitte

    }
}


