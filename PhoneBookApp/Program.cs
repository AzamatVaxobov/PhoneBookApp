﻿using PhoneBookApp.Models;
using PhoneBookApp.Services;
using System;
using System.Collections.Generic;
namespace PhoneBookApp;

internal class Program
{
    static void Main(string[] args)
    {
        StartProgramm();

    }

    static void StartProgramm()
    {
        PhoneBookService phoneBookService = new PhoneBookService();
        
        PhoneBook phoneBook;
        while (true)
        {
            Console.Clear();
            string choice;
            Console.WriteLine("1. Create PhoneBook ");
            Console.WriteLine("2. Read PhoneBook ");
            Console.WriteLine("3. Update PhoneBook ");
            Console.WriteLine("4. Delete PhoneBook ");
            Console.Write("Enter : ");
            choice = Console.ReadLine();

            Console.Clear();
            if (choice == "1")
            {
                phoneBook = new PhoneBook();
                Console.Write("Enter name : ");
                phoneBook.Name = Console.ReadLine();
                Console.Write("Enter phone number : ");
                phoneBook.PhoneNumber = Console.ReadLine();

                bool response = phoneBookService.CreatePhoneBook(phoneBook);
                if (response) Console.WriteLine("Added");
                else Console.WriteLine("Already exist");
            }
            if (choice == "2")
            {
                List<PhoneBook> all = phoneBookService.GetAllPhoneBooks();
                foreach (PhoneBook phone in all)
                {
                    Console.WriteLine($"Name : {phone.Name}, number : {phone.PhoneNumber}  ");
                }
            }
            if (choice == "3")
            {
                phoneBook = new PhoneBook();
                Console.Write("Enter new name : ");
                phoneBook.Name = Console.ReadLine();
                Console.Write("Enter phone number : ");
                phoneBook.PhoneNumber = Console.ReadLine();

                bool response = phoneBookService.UpdatePhoneBook(phoneBook);
                if (response) Console.WriteLine("Updated");
                else Console.WriteLine("There is no to update");
            }
            if (choice == "4")
            {
                string phoneNumber;
                Console.Write("Enter phone number : ");
                phoneNumber = Console.ReadLine();

                bool response = phoneBookService.DeletePhoneBook(phoneNumber);
                if (response) Console.WriteLine("Deleted");
                else Console.WriteLine("There is no to delete");
            }
            string option;
            Console.Write("Do you want to continue   Y/N :");
            option = Console.ReadLine();
            string[] options = { "Yes", "Y", "yes", "YES", "y" };
            bool check = options.Any(o => o == option);
            if (!check) break;
        }
    }



}


