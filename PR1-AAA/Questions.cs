using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR1_AAA
{
    internal class Questions
    {
        private string text;
        private string[] answers;
        private int rightAnswer;

        public void QuestionsM (string text, string[] answers, int right)
        {

        }

        public string getText() 
        { 
            return text; 
        }

        public string[] getAnswers()
        {
            return answers;
        }
        
        public bool inCorrect(int answer)
        {
            return false;
        }

    }
}
