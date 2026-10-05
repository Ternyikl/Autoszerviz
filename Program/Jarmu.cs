using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class Jarmu
    {
        private string rendszam;
        private int kor;
        private int kilometerOra;
        private int uzemanyagSzint;

        public Jarmu(string rendszam, int kor, int kilometerOra, int uzemanyagSzint)
        {
            this.Rendszam = rendszam;
            this.Kor = kor;
            this.KilometerOra = kilometerOra;
            this.UzemanyagSzint = uzemanyagSzint;
        }

        public string Rendszam 
        { 
            get => rendszam;
            set => rendszam = (value is null || value == "") ? "ISMERETLEN" : value;
        }
        public int Kor 
        { 
            get => kor; 
            set{
                if(value <= 0)
                {
                    kor = 0;
                }
                else if(value >= 50)
                {
                    kor = 50;
                }
                else 
                { 
                    kor = value;
                }

            } 
        }
        public int KilometerOra 
        { 
            get => kilometerOra; 
            set => kilometerOra = (value < 0) ? 0 : value; 
        }
        public int UzemanyagSzint 
        { 
            get => uzemanyagSzint;
            set
            {
                if (value <= 0)
                {
                    uzemanyagSzint = 0;
                }
                else if (value >= 100)
                {
                    uzemanyagSzint = 100;
                }
                else
                {
                    uzemanyagSzint = value;
                }

            }
        }
        public bool SzervizSzukseges
        {
            get => KilometerOra >= 200000;
        }

        public virtual void InformaciotAd()
        {
            Console.WriteLine($"{Rendszam} - {Kor} éves jármű, {KilometerOra} km-rel.");
        }

        public virtual void Szervizel(int dij)
        {
            if (dij > 100000)
            {
                KilometerOra -= 10000;
            }
            UzemanyagSzint -= 10;
            Console.WriteLine("A jármű szervizelése megtörtént.");
        }
    }
}
