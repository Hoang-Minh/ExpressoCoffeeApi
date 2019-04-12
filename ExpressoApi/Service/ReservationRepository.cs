using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExpressoApi.Models;

namespace ExpressoApi.Service
{
    public class ReservationRepository : IReservation
    {
        private ExpressoDbContext expressoDbContext;

        public ReservationRepository(ExpressoDbContext anExpressoDbContext)
        {
            expressoDbContext = anExpressoDbContext;
        }

        public IEnumerable<Reservation> GetReservations()
        {
            throw new NotImplementedException();
        }

        public Reservation GetReservation(int id)
        {
            throw new NotImplementedException();
        }

        public void Post(Reservation menu)
        {
            throw new NotImplementedException();
        }

        public void Put(Reservation menu)
        {
            throw new NotImplementedException();
        }

        public void Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
