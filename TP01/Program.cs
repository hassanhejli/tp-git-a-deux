using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Runtime.CompilerServices;
using System.Text.Json;
using System.Text.Json.Serialization;

namespace TP01
{
    public interface IPeopleContainer
    {
        public List<string> SortByLastName(List<string> _noms);
        public List<string> SortByFirstName(List<string> _prenoms);
    }

    internal class Program
    {
        public static string afficheSaisie(string typeSaisie)
        {
            string saisie;
            //Saisie du nom d'un personne
            Console.WriteLine("Saisir le "+typeSaisie);
            saisie = Console.ReadLine();
            return saisie;
        }

        //On affiche les noms
        public static void affichage(List<string> triList)
        {
            Console.WriteLine("Noms par ordre alphabétique:");
            for (int i = 0; i < triList.Count; i++)
            {
                Console.WriteLine(triList[i]);
            }
        }

        //On rempli le JSON
        public static void remplissageJSON(List<Person> listePersonnes)
        {
            string json = JsonSerializer.Serialize(listePersonnes);
            File.WriteAllText(@".\personnes.json", json);
        }

        //Enlever une personne de la liste de personnes
        public static void supprimerPersonne(List<Person> listePersonnes,Person suppr,List<string> removeNom, List<string> removePrenom)
        {
            for(int i=0; i < listePersonnes.Count; i++)
            {
                if (suppr.comparer(listePersonnes[i], listePersonnes))
                {
                    listePersonnes.Remove(listePersonnes.Find(p => p.nom == suppr.nom && p.prenom == suppr.prenom));
                    removePrenom.Remove(suppr.prenom);
                    removeNom.Remove(suppr.nom);
                    break;
                }
            }              
        }

        //Ajout des personnes deja présentes dans la liste de personne aux listes de tri
        static void ajout(List<Person> listePersonnes, List<string> triNoms, List<string> triPrenoms)
        {
            for (int i = 0; i < listePersonnes.Count; i++)
            {
                triNoms.Add(listePersonnes[i].nom);
                triPrenoms.Add(listePersonnes[i].prenom);
            }
        }
        static void Main(string[] args)
        {
            //Liste de personnes, de noms et de prénoms
            List<Person> listePersonnes = new List<Person>();
            List<string> triNoms = new List<string>();
            List<string> triPrenoms = new List<string>();

            //Instanciation de trois objets Person et ajout de ces trois objets à la liste de personnes
            listePersonnes.Add(new Person("Crochet", "Florent"));
            listePersonnes.Add(new Person("Gibier", "Aurelien"));
            listePersonnes.Add(new Person("Maurice", "Anthony"));

            //Ajout des personnes deja présentes dans la liste de personne aux listes de tri
            ajout(listePersonnes, triNoms, triPrenoms);

            //Début du Do/While qui permet la gestion de l'ajout de personnes par l'utilisateur
            //La condition du while est une saisie clavier
            do
            {
                //Création d'une personne avec le nom et le prénom saisis
                Person myPerson = new Person(afficheSaisie("nom"),afficheSaisie("prenom"));

                //On remplit et test si la personne est déja présente,et la supprime à la demande de l'utilisateur
                bool testRemplissage = myPerson.remplissage(listePersonnes,triNoms,triPrenoms,myPerson);
                if(testRemplissage == false)
                {
                    Console.WriteLine("La personne existe déja.");
                    Console.WriteLine("Voulez vous la supprimer de la liste de personnes? o pour oui,n'importe quelle touche pour non");
                    if(Console.ReadLine().ToUpper().Equals("O"))
                    {
                        supprimerPersonne(listePersonnes, myPerson,triNoms,triPrenoms);
                    }
                }

                //On instancie la classe PeopleContainer en lui donnant en attribut la liste de personnes
                PeopleContainer myPersonContainer = new PeopleContainer(listePersonnes);

                //On s'en sert pour trier les noms ou prénoms grace à ses méthode de classes
                Console.WriteLine("Tri par nom ou prénoms? n ou p ou n'importe quelle touche pour quitter");
                string saisie = Console.ReadLine().ToUpper();
                if (saisie.Equals("N"))
                {
                    myPersonContainer.SortByLastName(triNoms);
                    //On affiche les noms
                    affichage(triNoms);
                }
                else if (saisie.Equals("P"))
                {
                    myPersonContainer.SortByFirstName(triPrenoms);
                    //On afiche les prénoms
                    affichage(triPrenoms);
                }

                //On demande à l'utilisateur s'il veut réjouter une personne
                Console.WriteLine("Voulez vous ajouter une autre personne? o pour oui, n'importe quelle autre touche pour quitter.");

            } while (Console.ReadLine().ToUpper().Equals("O"));//Si o , on repasse dans la boucle, sinon on quitte

            //Demande à l"utilisateur s'il veut récupérer la liste de personnes dans un fichier JSON
            Console.WriteLine("Voulez vous enregistrer vos données au format JSON ? o pour oui, autre pour quitter.");

            //Si l'utilisateur le choisit nous créons une chaine de caractère récupérant la liste de personne
            // et nous créons un fichier json qui récupère cette chaine
            if (Console.ReadLine().ToUpper().Equals("O"))
            {
                remplissageJSON(listePersonnes);
            }
        }
    }
}