using System;
using Excecoes.Entities;
using Excecoes.Entities.Exceptions;

namespace Excecoes
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.Write("Room number: ");
                int roomNumber = int.Parse(Console.ReadLine());
                Console.Write("Check-in date (dd/MM/yyyy): ");
                DateTime checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                DateTime checkOut = DateTime.Parse(Console.ReadLine());

                Reservation resev = new Reservation(roomNumber, checkIn, checkOut);
                Console.WriteLine("Reservation: " + resev);

                Console.WriteLine();
                Console.WriteLine("Enter the data do update reservation: ");
                Console.Write("Check-in date (dd/MM/yyyy): ");
                checkIn = DateTime.Parse(Console.ReadLine());
                Console.Write("Check-out date (dd/MM/yyyy): ");
                checkOut = DateTime.Parse(Console.ReadLine());

                resev.UpdateDates(checkIn, checkOut);
                Console.WriteLine("Reservation: " + resev);
            }
            catch (DomainException e)
            {
                Console.WriteLine("Erro in reservation: " + e.Message);
            }
            catch(FormatException e)
            {
                Console.WriteLine("Format error: " + e.Message);
            }
            catch(Exception e)
            {
                Console.WriteLine("Unexpected error: " + e.Message);
            }
        }
    }
}
