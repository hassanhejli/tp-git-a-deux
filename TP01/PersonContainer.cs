using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP01
{
    public class PersonContainer : IPersonContainer
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
        public List<string> SortByFirstName(List<string> _prenoms)
        {
            _prenoms.Sort();
            return _prenoms;
        }

        List<Person> IPersonContainer.SortByLastName(List<string> noms)
        {
            throw new NotImplementedException();
        }

        List<Person> IPersonContainer.SortByFirstName(List<string> prenoms)
        {
            throw new NotImplementedException();
        }
    }
}
