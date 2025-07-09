using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationChambre.Classes
{
    internal class ClsReservation
    {
        int id;
        int refClient;
        int refChambre;
        string dateEntree;
        string dateSortie;

        public int Id { get => id; set => id = value; }
        public int RefClient { get => refClient; set => refClient = value; }
        public int RefChambre { get => refChambre; set => refChambre = value; }
        public string DateEntree { get => dateEntree; set => dateEntree = value; }
        public string DateSortie { get => dateSortie; set => dateSortie = value; }
    }
}
