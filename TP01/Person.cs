using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TP01;

namespace TP01
{
    public class Person
    {
        public string nom {get;set;}
        public string prenom {get; set;}

        //Constructeur avec paramètres
        public Person(string _nom, string _prenom)
        {
            this.nom = _nom;
            this.prenom = _prenom;
        }

        //Fonction de comparaison de deux personnes
        public bool comparer(Person other,List<Person> listePersonnes)
        {

            for (int i = 0; i < listePersonnes.Count; i++)
            {
                if (listePersonnes[i].prenom.ToUpper().Equals(this.prenom.ToUpper()) && other.nom.ToUpper().Equals(this.nom.ToUpper()))
                {
                    return true;
                    break;
                }
            }
            return false;
        }

        public bool remplissage(List<Person> listePersonnes, List<String> noms, List<String> prenoms,Person myPerson)
        {
            bool rempli = false;
            //Si la personne n'est pas présente, on l'ajoute

            if (this.comparer(myPerson,listePersonnes) == false)
            {
                listePersonnes.Add(myPerson);
                noms.Add(myPerson.nom);
                prenoms.Add(myPerson.prenom);
                rempli = true;
            }
            else
            {
                rempli = false;
            }
            return rempli;
        }         

    }
}
