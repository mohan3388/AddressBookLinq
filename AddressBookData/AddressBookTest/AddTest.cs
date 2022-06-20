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
    }
}