using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MultiThreading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Process has started");
            MovieBooking moviebooking = new MovieBooking();
            Thread movietask1 = new Thread(moviebooking.BookTicket);
            Thread movietask2 = new Thread(moviebooking.PrintTicket);
            Thread movietask3 = new Thread(moviebooking.CancelTicket);

            movietask1.Start();
            movietask2.Start();
            movietask3.Start();
            Console.WriteLine("Process is completed");
            Console.Read();

        }
        public class MovieBooking
        {
            public void BookTicket()
            {
                Console.WriteLine("Book Ticket");
            }

            public void PrintTicket()
            {
                Console.WriteLine("Print Ticket");
            }
            public void CancelTicket()
            {
                Console.WriteLine("Cancel Ticket");
            }
        } 
    }
}
