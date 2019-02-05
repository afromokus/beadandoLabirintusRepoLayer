using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KirschJanosMarkSajatRepoLayer.Repository
{
    class Account
    {

        int az;
        string felhNev;
        string jelszo;
        string emailCim;
        string jog;
        int szint;
        int regio_az;

        public Account(int az, string felhNev, string jelszo, string emailCim, string jog, int szint, int regio_az)
        {
            this.az = az;
            this.felhNev = felhNev;
            this.jelszo = jelszo;
            this.emailCim = emailCim;
            this.jog = jog;
            this.szint = szint;
            this.regio_az = regio_az;
        }

        public int Az { get => az; set => az = value; }
        public string FelhNev { get => felhNev; set => felhNev = value; }
        public string Jelszo { get => jelszo; set => jelszo = value; }
        public string EmailCim { get => emailCim; set => emailCim = value; }
        public string Jog { get => jog; set => jog = value; }
        public int Szint { get => szint; set => szint = value; }
        public int Regio_az { get => regio_az; set => regio_az = value; }

        public override string ToString()
        {
            return az + " " + felhNev + " " + jelszo + " " + emailCim + " " + jog + " " + szint + " " + regio_az;
        }
    }
}
