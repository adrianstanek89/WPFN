using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WPFPodstawy;

namespace ReservationEvent
{
    public class Program
    {
        static void Main(string[] args)
        {
            EventHanlderReservation eventHanlderReservation = new EventHanlderReservation();
            Reservation reservation = new Reservation();
            reservation.ReservationDone += eventHanlderReservation.LogTrans;

            reservation.Reserve("Loki", "Kozo wróć");
            Console.ReadKey();
        }
    }
}