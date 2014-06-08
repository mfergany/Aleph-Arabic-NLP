using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aleph_Arabic_NLP
{
    class Words_Class
    {
        private string _sentence;
    
        public string Sentense
        {
            get
            {
                return _sentence;
            }
            set
            {
                _sentence = value;
            }
        }
    
        public string First_word()
        {

            string se = Sentense;

            se.Trim();

            se = se.Substring(0,se.IndexOf(" "));
            return se;



        }

        public string Second_word()
        {

            string se = Sentense;

            se.Trim();

            string firstword = First_word();

            int indexofsecondword = firstword.Length + 1;



            se = se.Substring(indexofsecondword, se.IndexOf(" "));
            return se;


        }

        public string Thered_word()
        {
            throw new System.NotImplementedException();
        }
    }
}
