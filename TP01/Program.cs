﻿using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace TP01
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //Liste de personnes, de noms et de prénoms
            List<Person> listePersonnes = new List<Person>();
            List<String> triNoms = new List<String>();
            List<String> triPrenoms = new List<String>();


            //Instanciation de trois objets Person et ajout de ces trois objets à la liste de personnes
            listePersonnes.Add(new Person("Crochet", "Florent"));
            listePersonnes.Add(new Person("Gibier", "Aurelien"));
            listePersonnes.Add(new Person("Maurice", "Anthony"));

            //Ajout des personnes deja présentes dans la liste de personne aux listes de tri
            for (int i = 0; i < listePersonnes.Count; i++)
            {
                triNoms.Add(listePersonnes[i].getNom());
                triPrenoms.Add(listePersonnes[i].getPrenom());
            }

            //Début du Do/While qui permet la gestion de l'ajout de personnes par l'utilisateur
            //La condition du while est une saisie clavier
            do
            {

                //Variables visants à récuperer less noms et prénoms saisis au clavier
                string nom;
                string prenom;

                //Saisie du nom d'un personne
                Console.WriteLine("Saisir le nom");
                nom = Console.ReadLine().Trim();


                //Saisie du prénom d'une personne
                Console.WriteLine("Saisir le prénom");
                prenom = Console.ReadLine().Trim();

                //Création d'une personne avec le nom et le prénom saisis
                Person myPerson = new Person(nom, prenom);

                //Booleen visant à tester si une personne est présente dans la liste
                bool testPersonne = false;

                //Test pour toute la liste de personnes si la nouvelle personne est présente dedans
                for (int i = 0; i < listePersonnes.Count && !testPersonne; i++)
                {
                    //On compare(grace à la méthode de la classe Person) la personne de la liste à l'indice i avec la personne créée plus haut
                    if (listePersonnes[i].comparer(myPerson))
                    {
                        testPersonne = true;
                    }
                }

                //Si la personne n'est pas présente, on l'ajoute
                if (testPersonne == false)
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
                for (int i = 0; i < triNoms.Count; i++)
                {
                    Console.WriteLine(triNoms[i]);
                }

                //On afiche les prénoms
                Console.WriteLine("Prenoms par ordre alphabétique:");
                for (int i = 0; i < triPrenoms.Count; i++)
                {
                    Console.WriteLine(triPrenoms[i]);
                }

                //On demande à l'utilisateur s'il veut réjouter une personne
                Console.WriteLine("Voulez vous ajouter une autre personne? o pour oui, n'import quelle autre touche pour quitter.");

            } while (Console.ReadLine().Equals("o"));//Si o , on repasse dans la boucle, sinon on quitte

            //Demande à l"utilisateur s'il veut récupérer la liste de personnes dans un fichier JSON
            Console.WriteLine("Voulez vous enregistrer vos données au format JSON ? o pour oui, autre pour quitter.");

            //Si l'utilisateur le choisit nous créons une chaine de caractère récupérant la liste de personne
            // et nous créons un fichier json qui récupère cette chaine
            if (Console.ReadLine().Equals("o"))
            {
                string json = JsonSerializer.Serialize(listePersonnes);
                File.WriteAllText(@"C:\Users\fcrochet\Documents\GitHub\tp-git-a-deux-hassanaurel\TP01\personnes.json", json);
            }
        }
    }
}