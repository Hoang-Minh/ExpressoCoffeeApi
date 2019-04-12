using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ExpressoApi.Models;

namespace ExpressoApi.Service
{
    public interface IReservation
    {
        void AddReservation(Reservation reservation);
    }
}
