using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task__Day_4
{
    internal class Program
    {
                   public static string Password { get; private set; }
            public class container
            {
                public int transferid { get; set; }
                public string from { get; set; }
                public string to { get; set; }

    }
              static void Main(string[] args)
              {

       
                Console.WriteLine("----REGSTRATION----");
                Console.WriteLine("Enter FirstName:-");
                string fname = Console.ReadLine();
                Console.WriteLine("Enter Last Name:- ");
                string lname = Console.ReadLine();
                Console.WriteLine("Enter Password: ");
                string pass = Console.ReadLine();
                Console.WriteLine("----LOGIN----");
                Console.WriteLine("Hello " + fname + " " + lname); Console.WriteLine("Enter password:-");
                string password = Console.ReadLine(); if (pass.Equals(password))
                {
                Console.WriteLine("---Welcome To Advent e-model---");
                }
                else
                {
                Console.WriteLine("Please Enter Valid Password");
                } var container = new List<container>()
                {
                new container(){transferid=1,from="USA",to="UK"},
                new container(){transferid=2,from="UK",to="USA"},
                new container(){transferid=3,from="INDIA",to="USA"},
                new container(){transferid=4,from="USA",to="INDIA"},
                new container(){transferid=5,from="UK",to="INDIA"}
                }; //using Id Find from and to
                Console.WriteLine("Enter Id : ");
                string sid= Console.ReadLine();
                int iid=Convert.ToInt32(sid);
                foreach (var c in container)
                {
                if(iid == c.transferid)
                {
                Console.WriteLine(c.from+" to "+c.to);
                } }
                Console.WriteLine("Enter the port number ");
                string portno = Console.ReadLine();
                Console.WriteLine("Enter the port Name ");
                string portname = Console.ReadLine();
                Console.WriteLine("Enter the Quentity of the Container ");
                string con = Console.ReadLine();
                Console.WriteLine("Enter the Frome Date ");
                string fromedate = Console.ReadLine();
                Console.WriteLine("Enter To Date ");
                string todate = Console.ReadLine();
                Console.WriteLine("Enter Container Height ");
                string height = Console.ReadLine();
                Console.WriteLine("Enter Container Weight ");
                string weight = Console.ReadLine();
                Console.WriteLine("Enter Container Destination ");
                string dest = Console.ReadLine();
                Console.WriteLine("First name= " + fname + "\n" + "Last Name= " + lname + "\n" + "Port number= " + portno + "\n" + "Port Nmae= " + portname + "\n" + "Frome Date= " + fromedate + "\n" + "To date= " + todate + "\n" + "Container Height= " + height + "\n" + "Container Weight= " + weight + "\n" + "Destation= " + dest); }


        }
    }
}
