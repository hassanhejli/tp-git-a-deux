
interface IPersonContainer
{
    List<Person> SortByLastName();
    List<Person> SortByFirstName();
}
// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

string nom;
string prenom;

Console.WriteLine("Saisir le nom");
nom = Console.ReadLine();

Console.WriteLine("Saisir le prénom");
prenom = Console.ReadLine();

Console.WriteLine("Le nom est " + nom + " le prenom est " + prenom);

Person myPerson = new Person();
myPerson.nom = nom;
myPerson.prenom = prenom;

Console.WriteLine("Le nom est " + myPerson.nom + " le prenom est " + myPerson.prenom);

PersonContainer myPersonContainer = new PersonContainer();
myPersonContainer.personnes.add(myPerson);