using System;
using System.Collections.Generic;
using System.Text;

namespace QuizTimeSolution
{
    abstract class Question
    {
        public int Points { get; set; } = 1;
        public string Text { get; set; }

        public Question(string Text)
        {
            this.Text = Text;
        }

        public Question(string Text, int Points)
            : this(Text)
        {
            this.Points = Points;
        }

        public abstract int runQuestion();
    }
}
