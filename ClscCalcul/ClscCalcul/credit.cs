using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ClscCalcul
{
    public class credit
    {
        private double taux;
        private double montant;
        private double duree;
        private double mensualite;

        public credit()
        {

        }

        public credit(double tx, double mt, double dur)
        {
            taux = tx;
            montant = mt;
            duree = dur;

        }

        public double calcmensualite()
        {
            double temp;
            temp = Math.Pow(1 + taux, -duree);
            mensualite = montant * (taux / 1 - temp);
            return (mensualite);
        }

        public double getmensualite()
        {
            return (mensualite);
        }


        public void setCredit( double MntFinance ,int NbMensualites, double MntMensualites , double TxAnnuel)
        {
            montant = MntFinance;
            duree = NbMensualites;
            mensualite = MntMensualites;
            taux = TxAnnuel;
        }

        public string getCredit()
        {
            return taux +" "+ montant +" "+ duree +" "+ mensualite;
        }

        public double gettaux()
        {
            return taux;
        }
        public double getmontant()
        {
            return montant;
        }
        public double getduree()
        {
            return duree;
        }
    }
}
