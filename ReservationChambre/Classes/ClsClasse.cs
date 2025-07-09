using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationChambre.Classes
{
    internal class ClsClasse
    {
        int id;
        string designationClasse;
        double prix;

        public int Id { get => id; set => id = value; }
        public string DesignationClasse { get => designationClasse; set => designationClasse = value; }
        public double Prix { get => prix; set => prix = value; }
    }
}
