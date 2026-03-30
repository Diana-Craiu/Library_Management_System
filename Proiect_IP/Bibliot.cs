/**************************************************************************
 *                                                                        *
 *  File:        Bibliot.cs                                                 *
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
    /// Clasa pentru gestionarea operațiunilor specifice bibliotecarului.
    /// </summary>
    public class Bibliot
    {
        private DatabaseFacade _dataBase;

        /// <summary>
        /// Constructorul public al clasei.
        /// </summary>
        public Bibliot()
        {
            //Initializeaza o instanta a clasei DatabaseFacade
            _dataBase = DatabaseFacade.GetInstance;
        }

        /// <summary>
        /// Actualizează numărul de cărți imprumutate de un utilizator în baza de date.
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nr_imprumutat"></param>
        public void UpdateUserNrImprumutat(double id, double nr_imprumutat)
        {
            //Apeleaza functia UpdateUserNrImprumutat din clasa DatabaseFacade pentru a actualiza numarul de carti imprumutate de un utilizator in baza de date
            _dataBase.UpdateUserNrImprumutat(id, nr_imprumutat);

            //Inchide conexiunea cu baza de date
            _dataBase.CloseConnection();
        }

        /// <summary>
        /// Actualizează numărul de exemplare al unei cărți în baza de date.
        /// </summary>
        /// <param name="isbn"></param>
        /// <param name="nr_ex"></param>
        public void UpdateBookNrExemplare(double isbn, double nr_ex)
        {
            //Apeleaza functia UpdateBookNrExemplare din clasa DatabaseFacade pentru a actualiza numarul de copii ale unei carti in baza de date
            _dataBase.UpdateBookNrExemplare(isbn, nr_ex);

            _dataBase.CloseConnection();
        }

        /// <summary>
        /// Obține statusul unui utilizator din baza de date.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public string GetUserStatus(double id)
        {
            //Apeleaza functia GetUserStatus din clasa DatabaseFacade pentru a prelua status-ul unui utilizator din baza de date
            string userStatus = _dataBase.GetUserStatus(id);

            //returneaza status-ul
            return userStatus;
        }

        /// <summary>
        /// Obține statusul unei cărți din baza de date.
        /// </summary>
        /// <param name="isbn"></param>
        /// <returns></returns>
        public string GetBookStatus(double isbn)
        {
            //Apeleaza functia GetBookStatus din clasa DatabaseFacade pentru a prelua status-ul unei carti din baza de date
            string bookStatus = _dataBase.GetBookStatus(isbn);

            return bookStatus;
        }

        /// <summary>
        /// Obține numărul de cărți imprumutate de un utilizator din baza de date.
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public int GetUserNr_imprumutat(double id)
        {
            //Apeleaza functia GetUserNr_imprumutat din clasa DatabaseFacade pentru a prelua numarul de carti imprumutate de un utilizator din baza de date
            int imprumutate = _dataBase.GetUserNr_imprumutat(id);

            return imprumutate;
        }

        /// <summary>
        /// Obține numărul de exemplare al unei cărți din baza de date.
        /// </summary>
        /// <param name="isbn"></param>
        /// <returns></returns>
        public int GetBookNr_exemplare(double isbn)
        {
            //Apeleaza functia GetBookNr_exemplare din clasa DatabaseFacade pentru a prelua numarul de copii ale unei carti din baza de date
            int exemplare = _dataBase.GetBookNr_exemplare(isbn);

            return exemplare;
        }
    }
}
