public class Person{
    public string nom { get; set; }
    public string prenom { get; set; }

    //Constructeur avec paramètres
    public Person(string _nom,string _prenom)
    {
        this.nom=_nom;
        this.prenom=_prenom;
    }


    //Fonction de comparaison de deux personnes
    public bool comparer(Person other)
    {
        if(other.prenom.ToUpper().Equals(this.prenom.ToUpper()) && other.nom.ToUpper().Equals(this.nom.ToUpper()))
        {
            return true;
        }
        return false;
    } 

}