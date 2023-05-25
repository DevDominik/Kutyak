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
            this.kutyaId = int.Parse(adatok[0]);
            this.fajtaId = int.Parse(adatok[1]);
            this.nevId = int.Parse(adatok[2]);
            this.eletkor = int.Parse(adatok[3]);
            this.utolsoEllenorzes = adatok[4];
        }
    }
}
