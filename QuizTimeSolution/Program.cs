using System;
using System.Collections.Generic;

namespace QuizTimeSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            Quiz quiz = new Quiz("Java Quiz");

            Question q1 = new TrueFalseQuestion("Java is the same as Javascript", false);
            quiz.addQuestion(q1);

            List<string> q2choices = new List<string>();
            q2choices.Add("Capital (or Pascal) Case");
            q2choices.Add("Camel Case");
            q2choices.Add("All lowercase");
            Question q2 = new MultipleChoiceQuestion("In Java, instance variable naming conventions use:", q2choices, 1);
            quiz.addQuestion(q2);

            List<string> q3choices = new List<string>();
            q3choices.Add("All variables must have a declared type");
            q3choices.Add("Java was invented by Lewis and Clark as a way to pass time during their expedition");
            q3choices.Add("The word Java has 4 letters");
            List<int> q3CorrectChoices = new List<int>();
            q3CorrectChoices.Add(0);
            q3CorrectChoices.Add(2);
            Question q3 = new CheckboxQuestion("Which of the following statements are true of Java", q3choices, q3CorrectChoices);
            quiz.addQuestion(q3);

            quiz.takeQuiz();
            Console.WriteLine("Score: " + quiz.Score + " / " + quiz.TotalPoints);
            Console.ReadLine();
        }
    }
}
