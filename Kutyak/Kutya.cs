using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutyak
{
    public class Kutya
    {
        int kutyaId, fajtaId, nevId, eletkor;
        string utolsoEllenorzes;
        public Kutya(string initAdatok)
        {
            string[] adatok = initAdatok.Split(';');
            this.kutyaId = int.Parse(adatok[0]) - 1;
            this.fajtaId = int.Parse(adatok[1]) - 1;
            this.nevId = int.Parse(adatok[2]) - 1;
            this.eletkor = int.Parse(adatok[3]);
            this.utolsoEllenorzes = adatok[4];
        }

        public int KutyaId { get => kutyaId; }
        public int FajtaId { get => fajtaId; }
        public int NevId { get => nevId; }
        public int Eletkor { get => eletkor; }
        public string UtolsoEllenorzes { get => utolsoEllenorzes; }

    }
}
