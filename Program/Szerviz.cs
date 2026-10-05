using System;
using System.Collections.Generic;
using System.Text;

namespace Program
{
    public class Szerviz
    {
        private List<Jarmu> jarmuvek = new List<Jarmu>();

        public void JarmuFelvetele(Jarmu jarmu)
        {
            jarmuvek.Add(jarmu);
            Console.WriteLine("A jármű megérkezett a szervizbe.");
        }

        public void InformaciokListazasa()
        {
            foreach (var item in jarmuvek)
            {
                item.InformaciotAd();
            }
        }

        public void CsoportosSzerviz(int dij)
        {
            foreach (var item in jarmuvek)
            {
                if (item.SzervizSzukseges)
                {
                    item.Szervizel(dij);
                }
                else
                {
                    Console.WriteLine($"A {item.Rendszam} szervizelése jelenleg nem szükséges.");
                }
            }
        }
    }
}
