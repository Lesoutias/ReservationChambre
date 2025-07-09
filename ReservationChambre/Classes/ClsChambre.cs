using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReservationChambre.Classes
{
    internal class ClsChambre
    {
        int id;
        int numChambre;
        string Contact;
        int refClasse;

        public int Id { get => id; set => id = value; }
        public int NumChambre { get => numChambre; set => numChambre = value; }
        public string Contact1 { get => Contact; set => Contact = value; }
        public int RefClasse { get => refClasse; set => refClasse = value; }
    }
}
