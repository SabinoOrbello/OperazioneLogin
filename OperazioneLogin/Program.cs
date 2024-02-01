using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OperazioneLogin
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int scelta;
            do
            {
                // menù operazioni

                Console.WriteLine("===============OPERAZIONI==============");
                Console.WriteLine("Scegli l'operazione da effettuare:");
                Console.WriteLine("1.: Login");
                Console.WriteLine("2.: Logout");
                Console.WriteLine("3.: Verifica ora e data di login");
                Console.WriteLine("4.: Lista degli accessi");
                Console.WriteLine("5.: Esci");
                Console.WriteLine("========================================");

                // Legge l'input dell'utente e gestisce la scelta

                if (int.TryParse(Console.ReadLine(), out scelta))
                {
                    switch (scelta)
                    {
                        case 1:
                            Utente.Login();
                            break;
                        case 2:
                            Utente.Logout();
                            break;
                        case 3:
                            Utente.VerificaOraDataLogin();
                            break;
                        case 4:
                            Utente.ListaAccessi();
                            break;
                        case 5:
                            Console.WriteLine("Arrivederci trimone");
                            break;
                        default:
                            Console.WriteLine("Scelta non valida. Riprova");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("Inserisci un numero valido");
                }
            } while (scelta != 5); // ripeti finchè l'utente non sceglie di uscire

            Console.ReadLine();
        }
    }
}
