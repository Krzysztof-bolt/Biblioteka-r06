namespace BibliotekaWspolna;

    public class Osoba : object 
    {
        //właściowści
        public string? Nazwisko {  get; set; }
        public DateTime DataUrodzenia { get; set; }

        //metody
        public void WypiszWKonsoli()
        {
            WriteLine($"{Nazwisko},dzien urodzenia {DataUrodzenia:dddd}.");
        }
    }
