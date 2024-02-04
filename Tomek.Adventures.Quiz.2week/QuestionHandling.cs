using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tomek.Adventures.Quiz._2week_
{
    public class QuestionHandling
    {
        public List<Question> AllQuestions { get; } = new List<Question>(); //Lista dla wszystkich pytań

        public QuestionHandling() //w konstruktorze dodawane są pojedyncze pytania do listy pytań
        {
            AllQuestions.Add(new Question(0, "Z ilu części składa się powyższa powieść Alfreda Szklarskiego?"));
            AllQuestions.Add(new Question(1, "Jaki tytuł nosi ostatnia część o przygodach Tomka?"));
            AllQuestions.Add(new Question(2, "Tomek przed pierwszą przygodą mieszka w: "));
            AllQuestions.Add(new Question(3, "Na kim mści się Tomek pod koniec roku szkolnego?"));
            AllQuestions.Add(new Question(4, "Ulubiony przedmiot Tomka to: "));
            AllQuestions.Add(new Question(5, "Jak ma na imię ciocia Tomka?"));
        }
    }
}
