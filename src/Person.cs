public class Person{
    private string nom;
    private string prenom;

    //Constructeur avec paramètres
    public Person(string _nom,string _prenom)
    {
        this.nom=_nom;
        this.prenom=_prenom;
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
        if(other.prenom.Equals(this.prenom) && other.nom.Equals(this.nom))
        {
            return true;
        }
        return false;
    } 

}