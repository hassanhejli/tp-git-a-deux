# TP 01

## Les classes

### La classe Person

<p>Contient:<br><br>
Deux propriétés: nom visant à stocker le nom d'une personne et prénom visant à stocker le prénom d'une personne.<br><br>
Un constructeur avec paramètres(nom,prénom) permettant d'instancier des objets.<br><br>
Une méthode comparer permettant de comaparer le nom et le prénom de deux personnes grace à une personne passée en paramètres,qui est comparée à une autre.
True si identique, False sinon.<br><br>
Une méthode remplissage qui prends 4 paramètres en entrée: une liste de personne, une liste de noms, une liste de prénoms et une personne.
La personne est ajoutée à la liste de personnes si (grâce à la méthode comparer) elle n'est pas présente dans la liste.Et dans ce cas, son nom et son prénom sont ajoutés aux deux listes.</p>

### La classe PeopleContainer

<p>Contient:<br><br>
Un attribut: liste de personne visant à stocker toutes les personnes que l'on doit y ajouter<br><br>
Un constructeur avec paramètre(liste de personnes) permttant d'instanicer des objets.<br><br>
Une méthode de tri par ordre alphabétique pour les prénoms(SortByFirstName) prenant en paramètre d'entrée une list de chaînes de caractères visant à récupérer les prénoms des personnes.<br><br>
Une méthode de tri par ordre alphabétique pour les noms(SortByLastName) prenant en paramètre d'entrée une list de chaînes de caractères visant à récupérer les nom des personnes.<br><br></p>

### La classe Program

<p>Contient:<br><br>
Une méthode (returnSaisie)permettant la demande d'un nom ou d'un prénom à l'utilisateur qui sera récupéré par Readline et retourné par la fonction.<br><br>
Une méthode d'affichage(affichage) des valeurs d'une liste permttant l'affichage des noms ou des prénoms des listes correspondantes.<br><br>
Une méthode de remplissage du fichier JSON(remplissageJSON) qui écrit dans une fichier JSON tous les couples noms/prénoms de la liste donnée en paramètre d'entrée.<br><br>
Une méthode d'ajout (ajout) qui permet d'ajouter les noms et prénoms des personnes a leur liste respective récupérés dans la liste de personnes données en paramètres.
Les liste données en paramètres d'éntrée sont récupérés à chaque utilisation de la fonction puisqu'elle ont potentiellement changé, et doivent être actualisées.<br><br><br></p>

### En ce qui concerne le main:

<p>Nous définisons les listes visant à etre traitées.<br>
Nous créons trois objets Person.<br>
Nous les ajoutons grâce à la methode ajout aux listes de prénoms/noms.<br>
Nous entrons dans une boucle do/while, instancions une personne avec pour paramètres la fonction returnSaisie utilisée pour le nom et le prénom.<br>
Nous ajoutons la personne si elle n'est pas déja présente, dans la liste de personnes, puis dans les listes de prénoms et noms.<br>
Nous instancions un objet PeopleContainer avec la liste de personnes<br>
Nous demandons à l'utilisateur s'il veut trier par nom ou pas prénoms,puis selon le cas nous trions la liste correspondante puis affichons la liste triée.<br>
Nous demandons àl'utilisateur s'il veut ajouter une personne à la liste de personnes:<br>
Si oui nous passons/repassons dans le while,<br>
Si non, nous sortons du while.<br>
Enfin nous demandons à l'utilsateur s'il veut stocker les personnes dans une fichier JSON.Et nous appelons la methode remplissageJSON si oui.Sinon nous quittons le programme.













