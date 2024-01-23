
using System;
using System.Collections.Generic;

public class PersonContainer{

        public List<Person> personnes;

        public PersonContainer(List<Person> _personnes)
        {
            this.personnes= _personnes;
        }

        public List<Person> SortByLastName(List<Person> _personnes)
        {
            _personnes.Sort((x,y) => string.Compare(x.nom,y.nom));
            return _personnes;
        }

        public List<Person> SortByFirstName(List<Person> _personnes)
        {
            _personnes.Sort((x,y) => string.Compare(x.prenom,y.prenom));
            return _personnes;
        }

}