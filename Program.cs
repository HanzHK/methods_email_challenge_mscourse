/*
 * Your challenge is to create a method that will display the email address of internal and external employees. 
 * The method should include an optional parameter for the domain name of external employees.
 * - email domain: "contoso.com" for internal, hayworth.com for external
 * - username:  first two characters of their first name, followed by their full last name
*/

using System;

internal class Program
{
    static void Main(string[] args)
    {
        Email email = new Email();
        email.DisplayCorporate();
        email.DisplayExtertnal();
    }
}
internal class Email
{
    public void DisplayCorporate()
    { 
            string[,] corporate =
        {
            {"Robert", "Bavin"}, {"Simon", "Bright"},
            {"Kim", "Sinclair"}, {"Aashrita", "Kamath"},
            {"Sarah", "Delucchi"}, {"Sinan", "Ali"}
        };

for (int i = 0; i<corporate.GetLength(0); i++)
{
    DisplayEmail(firstName:  corporate[i, 0], lastName: corporate[i, 1]);
}

}
    public void DisplayExtertnal()
    {
            string[,] external =
            {
            {"Vinnie", "Ashton"}, {"Cody", "Dysart"},
            {"Shay", "Lawrence"}, {"Daren", "Valdes"}
        };
            string externalDomain = "hayworth.com";
    
            for (int i = 0; i < external.GetLength(0); i++)
            {
                DisplayEmail(firstName: external[i, 0], lastName: external[i, 1], domain: externalDomain);
            }
}

    

      public void DisplayEmail(string firstName, string lastName, string domain = "contoso.com")
    {
        string email = firstName.Substring(0, 2) + lastName;
        email = email.ToLower();
        // Now email username is created, need to add domain and print it
        Console.WriteLine($"{email}@{domain}");
    }

}
