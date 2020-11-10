using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kutyak
{
    class Kutya
    {
        private int id;
        private int fajtaid;
        private int nev_id;
        private int eletkor;
        private string vizsgalat;

        public Kutya(int i, int f, int n, int e, string v)
        {
            this.id = i;
            this.fajtaid = f;
            this.nev_id = n;
            this.eletkor = e;
            this.vizsgalat = v;
        }

    }
}
