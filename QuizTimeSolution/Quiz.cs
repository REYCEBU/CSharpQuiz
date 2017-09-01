using System;
using System.Collections.Generic;
using System.Text;

namespace QuizTimeSolution
{
    class Quiz
    {
        private List<Question> questions = new List<Question>();
        public int TotalPoints { get; private set; }
        public int Score { get; private set; }
        private String name;

        public Quiz(String name)
        {
            this.name = name;
        }

        public void addQuestion(Question q)
        {
            TotalPoints += q.Points;
            questions.Add(q);
        }

        public void takeQuiz()
        {
            Console.WriteLine(name);
            Console.WriteLine("=================");
            foreach (Question question in questions)
            {
                Score += question.runQuestion();
            }
        }
    }
}
