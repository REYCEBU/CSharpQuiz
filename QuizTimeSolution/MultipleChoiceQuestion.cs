using System;
using System.Collections.Generic;

namespace QuizTimeSolution
{
    class MultipleChoiceQuestion : CheckboxQuestion
    {
        public MultipleChoiceQuestion(string text,
                                  List<string> choices, int correctChoice)
            : base(text)
        {
            this.choices = choices;
            this.correctChoices.Add(correctChoice);
            this.AnswerPrompt = "Enter the correct answer:\n";
        }

        protected MultipleChoiceQuestion(String text)
            : base(text)
        {
            this.AnswerPrompt = "Enter the correct answer:\n";
        }
    }
}
