namespace Day9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            AddressBook addressBook = new AddressBook();

            // Adding contacts
            Contact contact1 = new Contact("raina", "dhoni", "raina.dhoni@example.com", "1234567890");
            Contact contact2 = new Contact("sachin", "pandya", "sachin.pandya@example.com", "9876543210");
            addressBook.AddContact(contact1);
            addressBook.AddContact(contact2);

            // Displaying contacts
            addressBook.DisplayContacts();

            // Removing a contact
            addressBook.RemoveContact(contact1);

            // Displaying contacts after removal
            addressBook.DisplayContacts();
        }
    }
}