using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExerciceEvaluation;

class Program
{
    class Etudiant
    {
        private char nom;
        private char prenom;
        private int Numeroetudiant;
    }
    class Evaluation
    {
        private int datedebut;
        private int datefin;
    }
    class Question
    {
        private float nbr;
    }
    class Qsm : Question
    {
        private int nbquestion;
    }
    class QuestionOvert : Question
    {
        private int NBQUESTION;
    }
    class Alternation
    {
        private string choix1;
        private string choix2;
        private string choix3;
    }
    class SeulChoix : Alternation
    {

    }
    class MultiChoix : Alternation
    {

    }
    class reponse
    {
        private char choix;
        public char Verifreponse()
        {
            return choix;
        }
    }

    class degredeCertitude
    {
        private int degre;

        public int verifiDegre()
        {
            return degre;
        }
    }
    class Passur
    {

    }
    class TresSur
    {

    }
    class Sur
    {

    }
    class noteperdue
    {
        private float note;
        public void PerduNote()
        {

        }
    }
    class notegagne
    {
        private float note;
        public void ajouteNote()
        {

        }
    }
    class noteFinal
    {
        public float note;
        public float calculdunote()
        {
            return note;
        }
    }
    static void Main(string[] args)
    {
    }
}