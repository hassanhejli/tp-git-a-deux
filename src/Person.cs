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
        public bool comparer(Person other)
        {
            if (other.prenom.ToUpper().Equals(this.prenom.ToUpper()) && other.nom.ToUpper().Equals(this.nom.ToUpper()))
            {
                return true;
            }
            return false;
        }

        public void remplissage(List<Person> listePersonnes, List<String> noms, List<String> prenoms,Person myPerson)
        {
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
                noms.Add(myPerson.nom);
                prenoms.Add(myPerson.prenom);
            }
        }         

    }