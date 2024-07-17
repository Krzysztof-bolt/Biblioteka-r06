namespace BibliotekaWspolna;

    public class Osoba : object, IComparable<Osoba?>
    {
        //właściowści
        public string? Nazwisko {  get; set; }
        public DateTime DataUrodzenia { get; set; }

    public int CompareTo(Osoba? other)
    {
        int pozycja;
        if ((this is not null) && (other is not null))
        {
            if ((Nazwisko is not null) && (other.Nazwisko is not null))
            {
            //jezeli wartosci obu nazwisk nie sa rowne null,
            //to uzyj metody CompareTo z typu string
            pozycja = Nazwisko.CompareTo(other.Nazwisko);
            }
            else if ((Nazwisko is not null) && (other.Nazwisko is null))
            {
                pozycja = -1; //ta osoba jest przed inna osoba
            }
            else if((Nazwisko is null) && (other.Nazwisko is not null))
            {
                pozycja = 1; //ta osoba jest za inna osoba
            }
            else
            {
                pozycja = 0; //obie osoby znajduja sie na tej samej pozycji
            }

        }
        else if ((this is not null) && (other is null))
        {
            pozycja = -1; //ta osoba znajduje sie przed inna osoba
        }
        else if((this is null) && (other is not null))
        {
            pozycja = 1; //ta osoba znajduje sie za inna osoba
        }
        else
        {
            pozycja = 0; //obie osoby znajduja sie na tej samej pozycji
        }
        return pozycja;
    }

    //metody
    public void WypiszWKonsoli()
        {
            WriteLine($"{Nazwisko},dzien urodzenia {DataUrodzenia:dddd}.");
        }
    
    }
