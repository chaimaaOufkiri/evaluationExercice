using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace evaluationExercice
{
    class Program
    {
        class evaluation
        {
            public DateTime datedebut;
            public DateTime datefin;
        }
        class question
        {
            public float nbr;
        }

        class proposition
        {
            public string choix1;
            public string choix2;
            public string choix3;
        }
        class reponse
        {
            public string choix;
        }

        class degredeDertitude
        {
            public double degre;

            public void verificationduDegre()
            {

            }
        }
        class reponseFausse
        {

        }
        class reponseVraie
        {

        }
        class noteperdue
        {
            public double n;
            public void PerdreNote()
            {

            }
        }
        class notegagne
        {
            public double v;
            public void ajoutdeNote()
            {

            }
        }
        class noteTotale
        {
            public double note;
            public double calculdunote()
            {
                return note;
            }
        }
        static void Main(string[] args)
        {
        }
    }
}
