using PhoneBookApp.Models;

namespace PhoneBookApp.Services;

public class PhoneBookService
{
    public List<PhoneBook> phoneBooks = new List<PhoneBook>();

    //crud
    public bool CreatePhoneBook(PhoneBook phoneBook)
    {
        foreach (PhoneBook phone in phoneBooks)
        {
            if (phoneBook.phoneNumber == phone.phoneNumber)
            {
                return false;
            }
        }
        phoneBooks.Add(phoneBook);
        return true;
    }
    public List<PhoneBook> GetAllPhoneBooks()
    {
        return phoneBooks;
    }
}

