public class PeopleContainer{

        List<Person> personnes = new list();

        public List SortByLastName(List _personnes)
        {
            _personnes.nom.Sort((x,y) => string.Compare(x.nom,y.nom));
            return _personnes;
        }

        public List SortByFirstName(List _personnes)
        {
            _personnes.prenom.Sort((x,y) => string.Compare(x.prenom,y.prenom));
            return _personnes;
        }

}