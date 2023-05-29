using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutyak
{
    public class Kutya
    {
        int kutyaId, fajtaId, nevId;
        double eletkor;
        string utolsoEllenorzes;
        public Kutya(string initAdatok)
        {
            string[] adatok = initAdatok.Split(';');
            this.kutyaId = int.Parse(adatok[0]);
            this.fajtaId = int.Parse(adatok[1]);
            this.nevId = int.Parse(adatok[2]);
            this.eletkor = double.Parse(adatok[3]);
            this.utolsoEllenorzes = adatok[4];
        }

        public int KutyaId { get => kutyaId; }
        public int FajtaId { get => fajtaId; }
        public int NevId { get => nevId; }
        public double Eletkor { get => eletkor; }
        public string UtolsoEllenorzes { get => utolsoEllenorzes; }

    }
}
