using System;
using AddressBookData;

namespace AddressBookData
{
    public class Program
    {
        public static void Main(string[] args)
        {
            AddressBook addressBook = new AddressBook();
            addressBook.CreateTableUsingLinq();

        }
    }
}