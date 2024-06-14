using Microsoft.VisualStudio.TestPlatform.TestHost;
using Contacts_Manager;
using Xunit;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Contacts_ManagerTest
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {

        }

        //Testing add
        [Fact]
        public void Add_Test() {

            //Arrange
            string Name = "Reem";
            string Number = "0987654321";

            //Act
            string result= Contacts_Manager.Program.AddContact(Name, Number);

            //ASSERT
            Assert.Equal($"Contact {Name} added successfully :)", result);

        }

        //Testing remove
        [Fact]
        public void Remove_Test() {

            //Arrange
            string add_result = Contacts_Manager.Program.AddContact("reem", "0987654321");

            //Act
            string result_remove= Contacts_Manager.Program.RemoveContact("reem");
            string result_remove_notexist = Contacts_Manager.Program.RemoveContact("haya");

            //Assert
            Assert.Equal("Contact removed successfully :|", result_remove);

            //Assert 2
            Assert.Equal("Contact does not exist :/", result_remove_notexist);
        }

        //Testing adding duplicate
        [Fact]
        public void reject_add() {

            //Arrange
            string add_result = Contacts_Manager.Program.AddContact("reem", "0987654321");


            //Act
            string add_result1 = Contacts_Manager.Program.AddContact("reem", "0987654321");

            //Assert
            Assert.Equal("Contact already exist!", add_result1);
        }

        //Testing view all

        [Fact]

        public void view_all() {

            // Arrange
            Contacts_Manager.Program.AddContact("reem", "0987654321");
            Contacts_Manager.Program.AddContact("hayooy", "1234567890");
            Contacts_Manager.Program.AddContact("antonyo", "2345678901");
            Contacts_Manager.Program.AddContact("jawad", "3456789012");

            // Act
            var view = Contacts_Manager.Program.ViewAllContacts();

            // Assert
            Assert.Contains(Tuple.Create("reem", "0987654321"), view);
            Assert.Contains(Tuple.Create("hayooy", "1234567890"), view);
            Assert.Contains(Tuple.Create("antonyo", "2345678901"), view);
            Assert.Contains(Tuple.Create("jawad", "3456789012"), view);
        }


    }
}