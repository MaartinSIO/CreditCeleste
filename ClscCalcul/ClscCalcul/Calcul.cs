using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClscCalcul
{
    public class Calcul
    {
        private double taux;
        private double montant;
        private double duree;
        private double mensualite;

        public Calcul()
        { 

        }

        public Calcul(double tx, double mt, double dur)
        {
            taux = tx;
            montant = mt;
            duree = dur;
            
        }

        public double calcmensualite()
        {
            double temp;
            temp =Math.Pow(1+taux,-duree);
            mensualite = montant * (taux/1-temp);
            return (mensualite);
        }

        public double getmensualite()
        {
            return (mensualite);
        }
 
    }
}
