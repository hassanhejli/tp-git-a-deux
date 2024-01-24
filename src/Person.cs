public class Person{
    private string nom;
    private string prenom;

    public Person(string _nom,string _prenom)
    {
        this.nom=_nom;
        this.prenom=_prenom;
    }

    public string getNom()
    {
        return this.nom;
    }

    public string getPrenom()
    {
        return this.prenom;
    }

    public bool comparer(Person other)
    {
        if(other.prenom.Equals(this.prenom) && other.nom.Equals(this.nom))
        {
            return true;
        }
        return false;
    } 

}