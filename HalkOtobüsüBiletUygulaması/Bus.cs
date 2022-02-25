using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalkOtobüsüBiletUygulaması
{
     class Bus
    {
        int totalNumberofSeats;
        int emptySeat;
        string busCode;
        double balance;
       
        const double fullTicket = 5.48;
        const double studentTicket = 2.66;

        public Bus(string _busCode, int _totalNumberofSeats)
        {
            totalNumberofSeats = _totalNumberofSeats;
            busCode = _busCode;
            emptySeat = _totalNumberofSeats;
            balance = 0;
        }
         
        public void passengersAdd(bool ticketFull)
        {
            emptySeat--;
            if (ticketFull==true)
            {
                balance += fullTicket;

            }
            else
            {
                balance += studentTicket;
            }

             
        }
      public void takeOutPassengerfrombus()
        {
            emptySeat++;
        }
        public int viewEmptySeat()
        {
            return emptySeat;
        }
        public double viewBalance()
        {
            return balance;
        }
    }
}
