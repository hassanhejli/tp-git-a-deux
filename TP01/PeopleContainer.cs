using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP01
{
    public class PeopleContainer : IPeopleContainer
    {
        private List<Person> personnes;


        //Constructeur avec paramètres
        public PeopleContainer(List<Person> _personnes)
        {
            this.personnes = _personnes;
        }


        //Tri par ordre alphabétique des noms
        public List<string> SortByLastName(List<string> triNoms)
        {  
            triNoms.Sort();
            return triNoms;
            throw new NotImplementedException();
        }

        //Tri par ordre alphabétique des prénoms
        public List<string> SortByFirstName(List<string> triPrenoms)
        {
            triPrenoms.Sort();
            return triPrenoms;
            throw new NotImplementedException();
        }
    }
}
