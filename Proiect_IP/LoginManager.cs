/**************************************************************************
 *                                                                        *
 *  File:        Admin.cs                                                 *
 *  Copyright:   (c) 2023, Avdei Elena, Craiu Diana-Mihaela,              *
 *                         Ciubotaru Mara-Elena, Loghin Bianca            *
 *  E-mail:      elena.avdei@student.tuiasi.ro                            *
 *               diana-mihaela.craiu@student.tuiasi.ro                    *
 *               mara-elena.ciubotaru@student.tuiasi.ro                   *
 *               bianca.loghin@student.tuiasi.ro                          *
 *  Description: Aplicatie despre gestionarea unei biblioteci             *
 *                                                                        *
 *  This code and information is provided "as is" without warranty of     *
 *  any kind, either expressed or implied, including but not limited      *
 *  to the implied warranties of merchantability or fitness for a         *
 *  particular purpose. You are free to use this source code in your      *
 *  applications as long as the original copyright notice is included.    *
 *                                                                        *
 **************************************************************************/

using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proiect_IP
{
    /// <summary>
    /// Clasa pentru gestionarea operațiunilor de autentificare și înregistrare a utilizatorilor.
    /// </summary>
    public class LoginManager
    {
        private List<User> _users;                //stocheaza lista utilizatorilor
        private const string Path = "Secure\\";   //calea catre fisierul ce contine informatiile utilizatorului
        private User _currentUser;                //reprezinta utilizatorul logat in prezent

        /// <summary>
        /// Structură ce definește un utilizator.
        /// </summary>
        public struct User
        {
            public readonly string Name;          //User name
            public readonly string PassHash;      //Hashed password
            public readonly int AccessLevel;      //Nivelurile de acces (admin, bibliotecar)

            public User(string name, string passHash, int accessLevel)
            {
                Name = name;
                PassHash = passHash;
                AccessLevel = accessLevel;
            }
        }

        /// <summary>
        /// Returnează nivelul de acces curent al utilizatorului logat.
        /// </summary>
        /// <returns></returns>
        public int CurrentAccessLevel()
        {
            //returneaza nivelul de acces curent al utilizatorului logat
            return _currentUser.AccessLevel;
        }

        /// <summary>
        /// Constructorul public al clasei.
        /// </summary>
        public LoginManager()
        {
            try
            {
                _users = new List<User>();                                     //initializeaza lista de utilizatori
                StreamReader sr = new StreamReader(Path + "utilizatori.txt");  //Se citesc informatiile utilizatorului din fisier
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] toks = line.Split('\t');

                    //Crearea unui obiect de tip Utilizator
                    User user = new User(toks[0], toks[1], Convert.ToInt32(toks[2]));

                    //Adauga utilizatorul in lista
                    _users.Add(user);
                }
                sr.Close();
            }
            catch (Exception exc)
            {
                MessageBox.Show(exc.Message);
            }
        }

        /// <summary>
        /// Operația de autentificare.
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool Login(string username, string password)
        {
            int i = 0;
            while (i < _users.Count)
            {
                if (username == _users[i].Name && _users[i].PassHash == Cryptography.HashString(password))
                {
                    //seteaza utilizatorul curent ca logat
                    _currentUser = _users[i];
                    return true;
                }
                i++;
            }
            return false;
        }

        /// <summary>
        /// Adaugă un utilizator nou.
        /// </summary>
        /// <param name="user"></param>
        /// <param name="pass"></param>
        /// <param name="level"></param>
        public void AddUser(string user, string pass, int level)
        {
            bool userExists = false;
            foreach (User usr in _users)
            {
                //Verifica daca utilizatorul exista
                if (usr.Name == user)
                {
                    userExists = true;
                    break;
                }
            }
            if (userExists)
            {
                MessageBox.Show($"Utilizatorul cu numele {user} exista deja!");
                return;
            }

            //Crearea unui obiect de tip Utilizator
            User utilizator = new User(user, Cryptography.HashString(pass), level);

            //Adaugarea unui utilizator in lista
            _users.Add(utilizator);

            //Salveaza lista actualizata in fisier
            SaveUsers();

            MessageBox.Show($"Utilizatorul {user} a fost adaugat!");
        }

        /// <summary>
        /// Salvează lista de utilizatori în fișier.
        /// </summary>
        private void SaveUsers()
        {
            StreamWriter streamWriter = new StreamWriter(Path + "utilizatori.txt");
            foreach (User user in _users)
            {
                //Scrierea informatiilor in fisier
                streamWriter.WriteLine($"{user.Name}\t{user.PassHash}\t{user.AccessLevel}");
            }
            streamWriter.Close();
        }
    }
}
