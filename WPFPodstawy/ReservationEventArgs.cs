using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFPodstawy
{
    public class ReservationEventArgs : EventArgs
    {
        public string ReservationId { get; private set; }
        public string Name { get; private set;  }
        public string Movie { get; private set; }

        public ReservationEventArgs(string name, string movie)
        {            
            this.ReservationId = Guid.NewGuid().ToString();
            this.Name = name;
            this.Movie = movie;
        }

    }
}
