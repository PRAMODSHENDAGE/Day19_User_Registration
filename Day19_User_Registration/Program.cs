// See https://aka.ms/new-console-template for more information

using Day19_User_Registration;

//Console.WriteLine("Welcome to the Program Of User Registration");

UserName username = new UserName();

Console.WriteLine(username.ValidateFirstName("Pramod"));

Console.WriteLine(username.ValidateLastName("Shendage"));

Console.WriteLine(username.ValidateEmail("abc+100@gmail.com"));

Console.WriteLine(username.ValidatePhoneNumber("+91 9919819801"));

Console.WriteLine(username.ValidatePassword("zxcvbnmas"));

Console.WriteLine(username.ValidatePassword2("Zmcnhdas"));

Console.WriteLine(username.ValidatePassword3("1Zmxnchasd"));

Console.WriteLine(username.ValidatePassword4("Z1xxccxv@"));
