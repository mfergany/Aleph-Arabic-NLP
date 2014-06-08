using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aleph_Arabic_NLP
{
     class Names
    {
        private string _Word;
        private string _Sentence;

        public string word
        {
            get
            {
                return _Word;
                
            }
            set
            {
                _Word = value;
            }
        }

       public string sentence
        {
            get
            {
                return _Sentence;
            }
            set
            {
                _Sentence = value;
            }
        }
    
        public bool IsName(string word)
        {

           string word2 = word;
          bool is_begin_by_aleph =   is_Begin_by_Eleph(word2);

          bool t = false;

            if (is_begin_by_aleph){

                t = true;

            }

            return t;

        }

        public bool IsMobtada(string word , string sentence)
        {

            Words_Class w = new Words_Class();
            w.Sentense = sentence;

            string first = w.First_word();

            
            bool fistname = false;

            bool ismobtada = false; ;

            if (word == first)
            {
                fistname = true;
            }


            if (fistname)
            {
                ismobtada = IsName(word);

            }

           

            return ismobtada;


        }


        public string get_mobtada(string sentence)
        {

            Words_Class w = new Words_Class();
            w.Sentense = sentence;
            string mobtada = "";

            string firstword = w.First_word();

            bool isname = IsName(firstword);
            //////////////

            if (isname)
            {
                mobtada = firstword;
            }

            return mobtada;



        }

        public string get_khabar()
        {

            return "";
        }



        private bool is_Begin_by_Eleph(string word)
        {

            string word2 = word;
            bool t;

            word2 = word2.Substring(0, 2);

            if (word2 == "ال")
            {
                t = true;
            }
            else
            {
                t = false;
            }

            return t;

        }
    }
}
