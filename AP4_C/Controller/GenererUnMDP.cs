using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AP4_C.Controller
{
    internal class GenererUnMDP
    {    
            private static readonly Random Random = new Random();
            private const string Chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
            private const string SpecialChars = "!@#$%^&*()_+-=[]{}|;:,.<>?";

            public static string GenerateRandomPassword(int length = 12, bool includeSpecialChars = true)
            {
                // Combinaison de caractères possibles
                var validChars = includeSpecialChars ? Chars + SpecialChars : Chars;

                // Génération du mot de passe
                var password = new string(Enumerable.Repeat(validChars, length)
                    .Select(s => s[Random.Next(s.Length)]).ToArray());

                return password;
            }
        }
    }

