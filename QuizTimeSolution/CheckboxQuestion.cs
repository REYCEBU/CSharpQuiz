using System;
using System.Linq;
using System.Collections.Generic;

namespace QuizTimeSolution
{
    class CheckboxQuestion : Question
    {

        protected List<string> choices;
        protected List<int> correctChoices;
        public string AnswerPrompt { get; set; } = "Enter all correct answers, separated by commas:";

        public CheckboxQuestion(string text, List<String> choices, List<int> correctChoices)
            : base(text)
        {
            this.choices = choices;
            this.correctChoices = correctChoices;
        }

        public CheckboxQuestion(string text)
            : base(text)
        {
            this.choices = new List<string>();
            this.correctChoices = new List<int>();
        }

        public override int runQuestion()
        {
            Console.WriteLine(this);

            string answerStr = Console.ReadLine();
            string[] answerStrs = answerStr.Split(',');
            List<int> userChoices = new List<int>();

            for (int i = 0; i < answerStrs.Length; i++)
            {
                userChoices.Add(int.Parse(answerStrs[i].Trim()));
            }

            userChoices.Sort();
            correctChoices.Sort();

            if (userChoices.SequenceEqual(correctChoices))
            {
                return Points;
            }

            return 0;
        }

        public override string ToString()
        {
            String questionStr = Text + "\n";
            for (int i = 0; i < choices.Count; i++)
            {
                questionStr += (i + " - " + choices[i] + "\n");
            }

            questionStr += AnswerPrompt;

            return questionStr;
        }
    }
}
