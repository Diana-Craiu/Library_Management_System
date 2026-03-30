using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using Proiect_IP;

namespace TestProiect
{
    [TestClass]
    public class ProiectIPUnitTest
    {
        private DatabaseFacade databaseFacade;
        private Bibliot bibliot;
        private Admin admin;

        [TestInitialize]
        public void Initialize()
        {
            databaseFacade = DatabaseFacade.GetInstance;
            bibliot = new Bibliot();
            admin = new Admin();
        }

        [TestMethod]
        public void TestAddBook()
        {
            //parametrii
            double isbn = 1234567890;
            string titlu = "Titlu";
            string autor = "Autor";
            string editura = "Editura";
            string gen = "Gen";
            string status = "Imprumutat";
            double nr_ex = 5;

            // Functie
            try
            {
                admin.AddBook(titlu, autor, isbn, editura, gen, status, nr_ex);
            }
            catch (Exception ex)
            {
                // An exception occurred while adding the book
                Assert.Fail($"Error adding book: {ex.Message}");
            }
            // Assert
            // Check if the book was added successfully
            // You can write additional code to verify the database state or use assertions
        }

        [TestMethod]
        public void TestUpdateUserNrImprumutat()
        {
            // Arrange
            double userId = 258852;
            double nrImprumutat = 5;

            // Act
            bibliot.UpdateUserNrImprumutat(userId, nrImprumutat);

            // Assert
            int updatedNrImprumutat = bibliot.GetUserNr_imprumutat(userId);
            Assert.AreEqual(nrImprumutat, updatedNrImprumutat, "User's number of borrowed books was not updated correctly.");
            // Check if the user's number of borrowed books was updated successfully
            // You can write additional code to verify the database state or use assertions
        }

        [TestMethod]
        public void TestDeleteBook()
        {
            // Arrange
            double isbn = 1234567890;

            // Act
            admin.DeleteBook(isbn);

            // Assert
            Assert.ThrowsException<Exception>(() => admin.DeleteBook(isbn), "No exception was thrown when deleting a non-existent book.");
            // You can add assertions here to check if the book was successfully deleted from the database
        }

        [TestMethod]
        public void TestUpdateBookStatus()
        {
            // Arrange
            double isbn = 3236;
            string status = "Sala de lectura";

            // Act
            admin.UpdateBookStatus(isbn, status);

            // Assert
            string updatedStatus = bibliot.GetBookStatus(isbn);
            Assert.AreEqual(status.Trim(), updatedStatus.Trim(), "The book status was not updated correctly in the database.");

            // You can add assertions here to check if the book status was successfully updated in the database
        }

        [TestMethod]
        public void TestUpdateBookNrExemplare()
        {
            // Arrange
            double isbn = 3236;
            double nr_ex = 10;

            // Act
            admin.UpdateBookNrExemplare(isbn, nr_ex);

            // Assert
            int updatedNr = bibliot.GetBookNr_exemplare(isbn);
            Assert.AreEqual(nr_ex, updatedNr, "The number was not updated correctly in the database.");
            // You can add assertions here to check if the number of book copies was successfully updated in the database
        }
        [TestMethod]
        public void TestUpdateUserStatus()
        {
            // Arrange
            double id = 123456;
            string blocat = "DA";

            // Act
            admin.UpdateUserStatus(id, blocat);

            // Assert
            string updatedStatus = databaseFacade.GetUserStatus(id);
            Assert.AreEqual(blocat.Trim(), updatedStatus.Trim(), "The user status was not updated correctly in the database.");
            // You can add assertions here to check if the user status was successfully updated in the database
        }
        [TestMethod]
        public void TestUpdateUserPenalizari()
        {
            // Arrange
            double id = 123456;
            int penalizari = 4;

            // Act
            admin.UpdateUserPenalizari(id, penalizari);

            // Assert
            int updatedPenalizari = databaseFacade.GetUserPenalizari(id);
            Assert.AreEqual(penalizari, updatedPenalizari, "The user penalizations were not updated correctly in the database.");
            // You can add assertions here to check if the user penalizations were successfully updated in the database
        }

        [TestMethod]
        public void TestAddUser()
        {
            // Arrange
            double id = 18975;
            string nume = "Ungureanu";
            string prenume = "Andreea";
            double telefon = 732569742;
            int nrCartiImprumutate = 0;
            int penalizari = 0;
            string blocat = "NU";

            // Act
           
            try
            {
                admin.AddUser(id, nume, prenume, telefon, nrCartiImprumutate, penalizari, blocat);
            }
            catch (Exception ex)
            {
                // An exception occurred while adding the book
                Assert.Fail($"Error adding user: {ex.Message}");
            }
            // Assert
            // You can add assertions here to check if the user was successfully added to the database
        }


        [TestMethod]
        public void TestDeleteUser()
        {
            // Arrange
            double id = 18975;

            // Act
            admin.DeleteUser(id);
            Assert.ThrowsException<Exception>(() => admin.DeleteUser(id), "No exception was thrown when deleting a non-existent user.");
            // Assert
            // You can add assertions here to check if the user was successfully deleted from the database
        }

        [TestMethod]
        public void TestGetUserPenalizari()
        {
            // Arrange
            double userId = 652256; // Replace with a valid user ID from your database

            // Act
            int penalizari = databaseFacade.GetUserPenalizari(userId);

            // Assert
            Assert.AreEqual(5, penalizari, "Numarul de penalizari nu este cel asteptat!");
        }

        [TestMethod]
        public void TestGetUserStatus()
        {
            // Arrange
            double userId = 258852; // Replace with a valid user ID from your database

            // Act
            string status = databaseFacade.GetUserStatus(userId);

            // Assert
            //Assert.AreEqual("NU", status, "Rezultat nu este cel asteptat!");
            Assert.IsTrue(status.Trim().Equals("NU", StringComparison.OrdinalIgnoreCase), "Statusul nu este cel asteptat!");
        }
        [TestMethod]
        public void TestGetBookStatus()
        {
            // Arrange
            double isbn = 8975; // Replace with a valid ISBN from your database

            // Act
            string status = databaseFacade.GetBookStatus(isbn);

            // Assert
            //Assert.AreEqual("Imprumutat", status, "Statusul nu este cel asteptat!");
            Assert.IsTrue(status.Trim().Equals("Imprumutat", StringComparison.OrdinalIgnoreCase), "Statusul nu este cel asteptat!");
        }

        [TestMethod]
        public void TestGetUserNr_imprumutat()
        {
            // Arrange
            double userId = 789456; // Replace with a valid user ID from your database

            // Act
            int nr_imprumutat = databaseFacade.GetUserNr_imprumutat(userId);

            // Assert
            Assert.AreEqual(5, nr_imprumutat, "Rezultatele nu coincid!");
        }
        [TestMethod]
        public void TestAddBook_InvalidStatus()
        {
            // Arrange
            // Set up parameters for the book
            //parametrii
            double isbn = 987654321;
            string titlu = "Titlu Invalid";
            string autor = "Autor";
            string editura = "Editura";
            string gen = "Gen";
            string status = "Invalid";
            double nr_ex = 10;

            // Act & Assert
            // The test should fail because an invalid status value is provided
            Assert.ThrowsException<Exception>(() => admin.AddBook(titlu, autor, isbn, editura, gen, status, nr_ex));
        }
        [TestMethod]
        public void TestUpdateUserNrImprumutat_InvalidUserId()
        {
            // Arrange
            double userId = -1; // Provide an invalid user ID

            // Act & Assert
            // The test should fail because an invalid user ID is provided
            Assert.ThrowsException<Exception>(() => bibliot.UpdateUserNrImprumutat(userId, 5));
        }

        [TestMethod]
        public void TestDeleteBook_NonexistentISBN()
        {
            // Arrange
            double isbn = 5555555555; // Provide a non-existent ISBN

            // Act & Assert
            // The test should fail because the book with the given ISBN does not exist
            Assert.ThrowsException<Exception>(() => admin.DeleteBook(isbn), "No exception was thrown when deleting a non-existent book.");
        }

        [TestMethod]
        public void TestUpdateBookStatus_InvalidISBN()
        {
            // Arrange
            double isbn = -1; // Provide an invalid ISBN
            string status = "Sala de lectura";

            // Act & Assert
            // The test should fail because an invalid ISBN is provided
            Assert.ThrowsException<Exception>(() => admin.UpdateBookStatus(isbn, status));
        }

        [TestMethod]
        public void TestUpdateBookNrExemplare_NegativeQuantity()
        {
            // Arrange
            double isbn = 8975;
            double quantity = -10; // Provide a negative quantity value

            // Act & Assert
            // The test should fail because a negative quantity value is provided
            Assert.ThrowsException<Exception>(() => admin.UpdateBookNrExemplare(isbn, quantity));
        }
        [TestMethod]
        public void TestUpdateUserStatus_InvalidUserId()
        {
            // Arrange
            double userId = 0; // Provide an invalid user ID
            string status = "NU";

            // Act & Assert
            // The test should fail because an invalid user ID is provided
            Assert.ThrowsException<Exception>(() => admin.UpdateUserStatus(userId, status));
        }

        [TestMethod]
        public void TestUpdateUserPenalizari_NegativePenalizations()
        {
            // Arrange
            double userId = 789456;
            int penalizari = -3; // Provide a negative penalizations value

            // Act & Assert
            // The test should fail because a negative penalizations value is provided
            Assert.ThrowsException<Exception>(() => admin.UpdateUserPenalizari(userId, penalizari));
        }

        [TestCleanup]
        public void Cleanup()
        {
            // Close the database connection after each test
            databaseFacade.CloseConnection();
        }

    }
}
