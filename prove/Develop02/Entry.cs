using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Develop02
{
    public class Entry
    {
        public string _prompt;

        public string _date;

        public string _answer;


        public string Displaystring()
        {
            string _entry = @$"> Date: {_date} - Prompt: {_prompt} - Answer: {_answer}";
            Console.WriteLine();
            return _entry;
        }
    }
}