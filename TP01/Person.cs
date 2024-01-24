using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP01
{
    public class Person
    {
        private string nom;
        private string prenom;

        //Constructeur avec paramètres
        public Person(string _nom, string _prenom)
        {
            this.nom = _nom;
            this.prenom = _prenom;
        }

        //Getter du nom
        public string getNom()
        {
            return this.nom;
        }

        //Getter du prénom
        public string getPrenom()
        {
            return this.prenom;
        }

        //Fonction de comparaison de deux personnes
        public bool comparer(Person other)
        {
            if (other.prenom.ToUpper().Equals(this.prenom.ToUpper()) && other.nom.ToUpper().Equals(this.nom.ToUpper()))
            {
                return true;
            }
            return false;
        }


    }
}
