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

        public void AddReservation(Reservation reservation)
        {
            expressoDbContext.Reservations.Add(reservation);
            expressoDbContext.SaveChanges(true);
        }
    }
}
