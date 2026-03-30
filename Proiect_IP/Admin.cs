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
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect_IP
{
    /// <summary>
    /// Clasa pentru gestionarea operațiunilor specifice administratorului.
    /// </summary>
    public class Admin
    {
        private DatabaseFacade _dataBase;

        /// <summary>
        /// Constructorul public al clasei
        /// </summary>
        public Admin()
        {
            //Initializaeaza o instanta a clasei DatabaseFacade
            _dataBase = DatabaseFacade.GetInstance;
        }

        /// <summary>
        /// Adaugă o carte în baza de date.
        /// </summary>
        /// <param name="titlu"></param>
        /// <param name="autor"></param>
        /// <param name="isbn"></param>
        /// <param name="editura"></param>
        /// <param name="gen"></param>
        /// <param name="status"></param>
        /// <param name="nr_ex"></param>
        public void AddBook(string titlu, string autor, double isbn, string editura, string gen, string status, double nr_ex)
        {
            //Apeleaza functia AddBook din clasa DatabaseFacade pentru a adauga o carte in baza de date
            _dataBase.AddBook(titlu, autor, isbn, editura, gen, status, nr_ex);

            //Inchide conexiunea cu baza de date
            _dataBase.CloseConnection();
        }

        /// <summary>
        /// Șterge o carte din baza de date.
        /// </summary>
        /// <param name="isbn"></param>
        public void DeleteBook(double isbn)
        {
            //Apeleaza functia DeleteBook din clasa DatabaseFacade pentru a sterge o carte in baza de date
            _dataBase.DeleteBook(isbn);

            _dataBase.CloseConnection();
        }

        /// <summary>
        /// Actualizează statusul unei cărți în baza de date.
        /// </summary>
        /// <param name="isbn"></param>
        /// <param name="status"></param>
        public void UpdateBookStatus(double isbn, string status)
        {
            //Apeleaza functia UpdateBookStatus din clasa DatabaseFacade pentru a actualiza status-ul unei carti in baza de date
            _dataBase.UpdateBookStatus(isbn, status);

            _dataBase.CloseConnection();
        }

        /// <summary>
        /// Actualizează numărul de exemplare al unei cărți în baza de date.
        /// </summary>
        /// <param name="isbn"></param>
        /// <param name="nr_ex"></param>
        public void UpdateBookNrExemplare(double isbn, double nr_ex)
        {
            //Apeleaza functia UpdateBookNrExemplare din clasa DatabaseFacade pentru a actualiza numarul de exemplare ale unei carti in baza de date
            _dataBase.UpdateBookNrExemplare(isbn, nr_ex);

            _dataBase.CloseConnection();
        }

        /// <summary>
        /// Actualizează statusul unui utilizator în baza de date.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="blocat"></param>
        public void UpdateUserStatus(double id, string blocat)
        {
            //Apeleaza functia UpdateUserStatus din clasa DatabaseFacade pentru a actualiza status-ul utilizatorului in baza de date
            _dataBase.UpdateUserStatus(id, blocat);

            _dataBase.CloseConnection();
        }

        /// <summary>
        /// Actualizează numărul de penalizări al unui utilizator în baza de date.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="penalizari"></param>
        public void UpdateUserPenalizari(double id, int penalizari)
        {
            //Apeleaza functia UpdateUserPenalizari din clasa DatabaseFacade pentru a actualiza numarul de penalizari ale utilizatorului in baza de date
            _dataBase.UpdateUserPenalizari(id, penalizari);

            _dataBase.CloseConnection();
        }

        /// <summary>
        /// Adaugă un utilizator în baza de date.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nume"></param>
        /// <param name="prenume"></param>
        /// <param name="telefon"></param>
        /// <param name="nrCartiImprumutate"></param>
        /// <param name="penalizari"></param>
        /// <param name="blocat"></param>
        public void AddUser(double id, string nume, string prenume, double telefon, int nrCartiImprumutate, int penalizari, string blocat)
        {
            //Apeleaza functia AddUser din clasa DatabaseFacade pentru a adauga un utilizator in baza de date
            _dataBase.AddUser(id, nume, prenume, telefon, nrCartiImprumutate, penalizari, blocat);

            _dataBase.CloseConnection();
        }

        /// <summary>
        /// Șterge un utilizator din baza de date.
        /// </summary>
        /// <param name="id"></param>
        public void DeleteUser(double id)
        {
            //Apeleaza functia DeleteUser din clasa DatabaseFacade pentru a sterge un utilizator in baza de date
            _dataBase.DeleteUser(id);
            _dataBase.CloseConnection();
        }

        /// <summary>
        /// Obține numărul de penalizări al unui utilizator din baza de date.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int GetUserPenalizari(double id)
        {
            //Apeleaza functia GetUserPenalizari din clasa DatabaseFacade pentru a prelua numarul de penalizari de la un utilizator din baza de date
            int penalizari = _dataBase.GetUserPenalizari(id);

            //Returneaza numarul de penalizari
            return penalizari;
        }

    }
}
