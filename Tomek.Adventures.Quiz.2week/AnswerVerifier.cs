using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tomek.Adventures.Quiz._2week_
{
    public class AnswerVerifier
    {
        private Dictionary<int, char> correctAnswers = new Dictionary<int, char>(); //numer pytania = int i poprawna odpowiedź = char 

        public AnswerVerifier()
        {
            correctAnswers.Add(0, 'b');
            correctAnswers.Add(1, 'a');
            correctAnswers.Add(2, 'c');
            correctAnswers.Add(3, 'a');
            correctAnswers.Add(4, 'c');
            correctAnswers.Add(5, 'a');
        }
        // Metoda zwraca punkty za odpowiedź użytkownika
        public bool GetPointsForAnswer(int questionNumber, char userChoice)
        {
            char correctAnswer;
            if (correctAnswers.TryGetValue(questionNumber, out correctAnswer)) // Sprawdź, czy istnieje poprawna odpowiedź dla danego pytania
            {
                return correctAnswer == userChoice;  
            }
            return false;  // Jeśli pytanie nie istnieje w słowniku, zwróć 0 punktów
        }
    }    
}
