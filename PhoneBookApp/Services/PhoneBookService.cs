using PhoneBookApp.Models;

namespace PhoneBookApp.Services;

public class PhoneBookService
{
    private List<PhoneBook> phoneBooks = new List<PhoneBook>();

    //crud
    public bool CreatePhoneBook(PhoneBook phoneBook)
    {
        foreach (PhoneBook phone in phoneBooks)
        {
            if (phoneBook.PhoneNumber == phone.PhoneNumber)
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

    
        public bool UpdatePhoneBook(PhoneBook phoneBook)
    {
        bool response = false;
        foreach (PhoneBook phone in phoneBooks)
        {
            if (phoneBook.PhoneNumber == phone.PhoneNumber)
            {
                phone.Name = phoneBook.Name;
                response = true;
                break;
            }
        }

        return response;
    }

    public bool DeletePhoneBook(string phoneNumber)
    {
        bool response = false;
        foreach (PhoneBook phoneBook in phoneBooks)
        {
            if (phoneBook.PhoneNumber == phoneNumber)
            {
                phoneBooks.Remove(phoneBook);
                response = true;
                break;
            }
        }

        return response;
    }
}

