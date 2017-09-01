using System;
using System.Collections.Generic;

namespace QuizTimeSolution
{
    class TrueFalseQuestion : MultipleChoiceQuestion
    {
        public TrueFalseQuestion(string text, Boolean answer)
            : base(text)
        {
            choices = new List<string>();
            choices.Add("False");
            choices.Add("True");

            if (answer)
            {
                correctChoices.Add(1);
            }
            else
            {
                correctChoices.Add(0);
            }
        }
    }
}
