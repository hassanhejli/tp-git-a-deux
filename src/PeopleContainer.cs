
using System;
using System.Collections.Generic;

public class PersonContainer
    {
        public List<Person> personnes;


        //Constructeur avec paramètres
        public PersonContainer(List<Person> _personnes)
        {
            this.personnes = _personnes;
        }


        //Methode qui tri les noms par ordre alphabétique
        public List<string> SortByLastName(List<string> _nom)
        {
            _nom.Sort();
            return _nom;
        }

        //Methode qui tri les prénoms par ordre alphabétique
        public List<String> SortByFirstName(List<String> _prenoms)
        {
            _prenoms.Sort();
            return _prenoms;
        }


    }