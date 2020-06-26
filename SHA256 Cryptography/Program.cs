using System;
using System.Security.Cryptography;
using System.Text;

namespace SHA256_Cryptography
{
    class Program
    {
        static void Main(string[] args)
        {
            // Default value 
            string plainText = "rajanmistry@gmail.com";
            Console.WriteLine("Default Text: {0}", plainText);
            string hashedData = ComputeSha256Hash(plainText);
            Console.WriteLine("Default Text Hash Value: {0}", hashedData);

            // Create dynamic hash value based on user input
            Console.WriteLine("Enter your hash value:");
            string userInput = Console.ReadLine();
            Console.WriteLine("Your new hash value is: " + ComputeSha256Hash(userInput));
            Console.ReadLine();
        }

        static string ComputeSha256Hash(string plainText)
        {
            // Create a SHA256   
            using (SHA256 sha256Hash = SHA256.Create())
            {
                // ComputeHash - returns byte array  
                byte[] bytes = sha256Hash.ComputeHash(Encoding.UTF8.GetBytes(plainText));
                // Convert byte array to a string   
                StringBuilder builder = new StringBuilder();
                for (int i = 0; i < bytes.Length; i++)
                {
                    builder.Append(bytes[i].ToString("x2"));
                }
                return builder.ToString();
            }
        }

    }
}
