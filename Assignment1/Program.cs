using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1
{
    internal class Program
    {
        static void Main(string[] args)

        {
            Console.WriteLine("Hello World My name is Amara!!!!!!"  );
            Console.ReadLine();
            String location = "";
            DateTime time = DateTime.Now;


            Console.WriteLine(location == null ? "location is null" : location);
            Console.WriteLine(time == null ? "time is null" : time.ToString());
            Console.ReadLine();

            var AmaraDetails = new UserDetails();
            AmaraDetails.FirstName = "Amara";
            AmaraDetails.LastName = "Okolo";
            AmaraDetails.PhoneNumber = 08037785881;
            AmaraDetails.EmailAddress = "Amaraokolo@gmail.com";
            AmaraDetails.Age = 21;

            List  < string> ListOfNames = new List<string>();
            ListOfNames.Add("Amara");
            


        }



            


    
    }
       
        
       

    
}
