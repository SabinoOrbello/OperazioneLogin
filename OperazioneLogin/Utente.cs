using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperazioneLogin
{
    // Classe statica Utente che gestisce l'autenticazione e l'accesso
    public static class Utente
    {
        private static string username;
        private static string password;
        private static DateTime? dataLogin; // Data e ora dell'ultimo login
        private static List<DateTime> storicoAccessi = new List<DateTime>(); // storico degli accessi


        // metodo per effettuare il login
        public static void Login()
        {
            Console.Write("Inserisci username: ");
            string inputUsername = Console.ReadLine();

            Console.Write("Inserisci password: ");
            string inputPassword = Console.ReadLine();

            Console.Write("Conferma password: ");
            string confermaPassword = Console.ReadLine();

            // Controlla se l'input è valido ed effettua il login
            if(!string.IsNullOrEmpty(inputUsername) && inputPassword == confermaPassword)
            {
                username = inputPassword;
                password = inputPassword;
                dataLogin = DateTime.Now;
                storicoAccessi.Add(dataLogin.Value);

                Console.WriteLine("Login effettuato con successo!");
            }
            else
            {
                Console.WriteLine("Errore durante il login. Assicurati di aver inserito correttamente username e password");
            }
                
        }

        // metodo per effettuare il logout
        public static void Logout()
        {
            if(IsUtenteAutenticato())
            {
                username = null;
                password = null;
                dataLogin = null;

                Console.WriteLine("Logout effettuato con successo");
            }
            else
            {
                Console.WriteLine("Messun utente autenticato. Impossibile effettuare il logout");
            }
        }

        // metodo per verificare l'ora e la data dell'ultimo login
        public static void VerificaOraDataLogin()
        {
            if(IsUtenteAutenticato())
            {
                Console.WriteLine($"Ultimo accesso effettuato il: {dataLogin}");
            }
            else
            {
                Console.WriteLine("Nessun utente autenticato. Impossibile verificare l'ora e la data di login");
            }
        }


        // metodo per mostrare la lista degli accessi
        public  static void ListaAccessi()
        {
            if(storicoAccessi.Count > 0)
            {
                Console.WriteLine("Storico accessi: ");
                foreach (var accesso in storicoAccessi)
                {
                    Console.WriteLine(accesso);
                }
            }
            else
            {
                Console.WriteLine("Nessun accesso registrato");
            }
        }


        // metodo privato per verificare se un utente è autenticato
        public static bool IsUtenteAutenticato()
        {
            return !string.IsNullOrEmpty(username) && !string.IsNullOrEmpty(password);
        }
    }
}
