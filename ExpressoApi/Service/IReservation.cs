using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExpressoApi.Models;

namespace ExpressoApi.Service
{
    public interface IReservation
    {
        IEnumerable<Reservation> GetReservations();
        Reservation GetReservation(int id);
        void Post(Reservation menu);
        void Put(Reservation menu);
        void Delete(int id);
    }
}
