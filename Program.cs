

/*Si vuole progettare un sistema per la gestione di una biblioteca. Gli utenti si possono registrare al sistema, fornendo:
cognome,
nome,
email,
password,
recapito telefonico,
Gli utenti registrati possono effettuare dei prestiti sui documenti che sono di vario tipo (libri, DVD). I documenti sono caratterizzati da:
un codice identificativo di tipo stringa (ISBN per i libri, numero seriale per i DVD),
titolo,
anno,
settore(storia, matematica, economia, …),
stato(In Prestito, Disponibile),
uno scaffale in cui è posizionato,
un autore (Nome, Cognome).
Per i libri si ha in aggiunta il numero di pagine, mentre per i dvd la durata.
L’utente deve poter eseguire delle ricerche per codice o per titolo e, eventualmente, effettuare dei prestiti registrando il periodo (Dal/Al) del prestito e il documento.
Deve essere possibile effettuare la ricerca dei prestiti dato nome e cognome di un utente.
*/

// biblioteca
//documenti
//utenti

Library ravennaLibrary = new Library();
ravennaLibrary.Title = "Ravenna";

Library.User davide = new Library.User("davide", "mucci", "davide@email.com", "asfijfnaosf", 3342512230);
Console.WriteLine(davide.lastName);

// Libreria
public class Library
{
    public string Title { get; set; }

    public class User
    {
        // Costruttore User
        public User(string firstName, string lastName, string email, string password, long phoneNumber)
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.email = email;
            this.password = password;
            this.phoneNumber = phoneNumber;
        }
        // Getters e Setters
        public string firstName { get; set; }
        public string lastName { get; set; }
        protected string email { get; }

        private string password;
        protected long phoneNumber { get; set; }

    }

}

// Utente estende libreria


// Documenti estende Utente

public class Document : User
{

    int isbn;
    string title;
    int year;
    string section;
    bool available;
    string position;
    string author;

    public Document(string firstName, string lastName, string email, string password, long phoneNumber, int isbn, string title, int year, string section, bool available, string position, string author) : base(firstName, lastName, email, password, phoneNumber)
    {
        this.isbn = isbn;
        this.title = title;
        this.year = year;
        this.section = section;
        this.available = available;
        this.position = position;
        this.author = author;


    }
}


