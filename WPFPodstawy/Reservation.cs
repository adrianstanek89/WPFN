using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFPodstawy
{
    public class Reservation
    {
        public delegate void ReservationDelegate(object sender, EventArgs eventArgs);
        public event ReservationDelegate ReservationDone;

        public void Reserve(string name, string movie)
        {
            ReservationEventArgs reservationEventArgs = new ReservationEventArgs(name, movie);
            RaiseReservationEvent(reservationEventArgs);
            
        }

        private void RaiseReservationEvent(EventArgs eventArgs)
        {
            if(ReservationDone != null)
            {
                this.ReservationDone(this, eventArgs);
            }
        }


    }
}
