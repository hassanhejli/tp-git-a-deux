public List SortByLastName(List _noms)
{
    _noms.Sort((x,y) => string.Compare(x.nom,y.nom));
    return _noms;
}

public List SortByFirstName(List _prenoms)
{
    _prenoms.Sort((x,y) => string.Compare(x.prenom,y.prenom));
    return _prenoms;
}