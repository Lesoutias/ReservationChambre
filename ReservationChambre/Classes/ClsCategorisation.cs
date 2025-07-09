using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationChambre.Classes
{
    internal class ClsCategorisation
    {
        int id;
        string designationCat;

        public int Id { get => id; set => id = value; }
        public string DesignationCat { get => designationCat; set => designationCat = value; }
    }
}
