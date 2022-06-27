using AddressBookData;

namespace AddressBookTest
{
    public class Tests
    {
        AddressBook address = new AddressBook();

        [SetUp]
        public void Setup()
        {
            address = new AddressBook();
        }

        [Test]
        public void GivenDataTable_InsertData_InDataTable()
        {
            int expected = 2;
            int actual = address.AddDataInDatatable();
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void GivenDataTable_UpdateData_InDataTable()
        {
            int expected = 0;
            int actual = address.EditInDataTable("Hemant", "Firstname");
            Assert.AreEqual(actual, expected);
        }

        [Test]
        public void GivenDataTable_DeleteData_InDataTable()
        {
            int expected = 1;
            int actual = address.DeleteDataInDataTable("Mohan");
            Assert.AreEqual(actual, expected);
        }
        [Test]
        public void GivenDataTable_Retrieve_The_Data_Person_Belonging_City_Or_State()
        {
            string expected = "Mohan sahu";
            string actual = address.RetrieveBasedOnCityorState("Bhilai", "CG");
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void GivenRetrieveCount_BasedOnCityandState_returnString()
        {
            string expected = "1 1 ";
            string actual = address.RetrieveCountBasedOnCityorState();
            Assert.AreEqual(expected, actual);


        }
        [Test]
        public void GivenSortQuery_BasedOnCityandState_returnString()
        {
            string expected = "Mohan";
            string actual = address.SortBasedOnNameInDataTable("Bemetara");
            Assert.AreEqual(expected, actual);
        }
    }
}