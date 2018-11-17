using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csClient
{
    public class Client
    {
        private int numeroClient;
        private string nomClient;
        private string prenomClient;
        private string cidt;
        private string adresseClient;


        private  string codePostaleClient;
        private string villeClient;
        private string telephoneClient;


        public Client()
        {
            numeroClient = 0;
            nomClient = "";
            cidt = "";
            prenomClient = "";
            adresseClient = "";
        }


        public Client(int numCli, string nomCli, string prenomCli)
        {
            numeroClient = numCli;
            nomClient = nomCli;
            prenomClient = prenomCli;
        }

        public Client(int numCli, string nomCli, string prenomCli, string cidtCli, string adresseCli)
        {
            numeroClient = numCli;
            nomClient = nomCli;
            prenomClient = prenomCli;
            cidt = cidtCli;
            adresseClient = adresseCli;
        }

            // set 
        public void setnumClient(int numeroCli)
        {
            numeroClient = numeroCli;
        }
        public void setnomClient(string nomCli)
        {
            nomClient = nomCli;
        }
        public void setprenomClient(string prenomCli)
        {
            prenomClient = prenomCli;
        }

        public void setcidt(string cidtCli)
        {
            cidt = cidtCli;
        }




        public void setadresseClient(string adresseCli)
        {
            adresseClient = adresseCli;
        }

        public  void setcodePostaleClient(string codePostaleCli)
        {
            codePostaleClient = codePostaleCli;
        }


        public void setvilleClient(string villeCli)
        {
            villeClient = villeCli;
        }

        public void settelephoneClient(string telephoneCli)
        {
            telephoneClient = telephoneCli;
        }



        // get

        public int getnumeroClient()
        {
            return numeroClient;
        }

        public string getnomClient()
        {
            return nomClient;
        }
        public string getprenomClient()
        {
            return prenomClient;
        }

        public string getcidt()
        {
            return cidt;
        }


        public string getadresseClient()
        {
            return adresseClient;
        }

        public string getcodePostaleClient()
        {
            return codePostaleClient;
        }

        public string getvilleClient()
        {
            return villeClient;
        }
        public string gettelephoneClient()
        {
            return telephoneClient;
        }


        // propriété : (exemple)       // equivalent au get et set // autre maniere existe
        /*
        public string VilleClient
        {
            get
            {
                return villeClient
            }
            set
            {
                villeClient = value;
            }
        }


         public string TelephoneClient
                {
                    get
                    {
                        return telephoneClient
                    }
                    set
                    {
                        telephoneClient = value;
                    }
                }
        */



    }

}
