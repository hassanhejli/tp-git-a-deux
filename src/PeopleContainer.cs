
using System;
using System.Collections.Generic;

public class PersonContainer{

        public List<Person> personnes;

        public PersonContainer(List<Person> _personnes)
        {
            this.personnes= _personnes;
        }

        public List<string> SortByLastName(List<string> _nom)
        {
            _nom.Sort();
            return _nom;
        }

        public List<String> SortByFirstName(List<String> _prenoms)
        {
            _prenoms.Sort();
            return _prenoms;
        }

}