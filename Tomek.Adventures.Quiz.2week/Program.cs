namespace Tomek.Adventures.Quiz._2week_
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Cześć. Fascynują Cię przygody Tomka z cyklu powieści autorstwa A. Szklarskiego? Jeśli tak :-), zapraszam do zabawy.");
            Console.WriteLine("Oto quiz. Tylko jedna odpowiedź jest poprawna: a, b lub c, nagrodzona 1 punktem.");
            //Console.WriteLine("Zapoznaj się z treścią kolejnych pytań i nie zwlekaj z odpowiedzią. Masz pół minuty, by wybrać poprawną odpowiedź.");

            // Inicjalizuję obiekty dla pytań, wyborów i weryfikacji odpowiedzi
            QuestionsSet questionsSet = new QuestionsSet();
            ChoicesCollection choicesCollection = new ChoicesCollection();
            AnswerVerifier answerVerifier = new AnswerVerifier();

            // Zmienna przechowująca łączną liczbę punktów uzyskanych przez użytkownika
            int totalPoints = 0;

            // Tworzę pętlę przechodzącą przez każde pytanie w zestawie
            for (int i = 0; i < questionsSet.Questions.Count; i++)
            {
                var question = questionsSet.Questions[i];
                var choices = choicesCollection.GetChoicesForQuestion(i);

                // Wyświetlanie pytania
                Console.WriteLine($"Pytanie {question.QuestionNumber + 1}: {question.QuestionContent}");

                // Wyświetlanie dostępnych wyborów w pętli
                foreach (var choice in choices)
                {
                    Console.WriteLine($"{choice.ChoiceLetter}: {choice.ChoiceContent}");
                }

                // Pobieranie wyboru od użytkownika
                char userChoice = GetUserChoice();

                // Następuje weryfikacja odpowiedzi i przyznawanie punktów
                int points = answerVerifier.GetPointsForAnswer(question.QuestionNumber, userChoice);
                totalPoints += points;

                // Wyświetlanie informacji o poprawności odpowiedzi
                if (points == 1)
                {
                    Console.WriteLine("Poprawna odpowiedź. Zdobywasz 1 punkt.");
                }
                else
                {
                    Console.WriteLine("Odpowiedź błędna. Brak punktu.");
                }

                if (i < questionsSet.Questions.Count - 1)
                {
                    Console.WriteLine($"Aktualna liczba punktów: {totalPoints}");
                    Console.WriteLine("Naciśnij Enter, aby przejść do kolejnego pytania.");
                    // Czekanie na gotowość użytkownika przed przejściem do następnego pytania (jeśli nie jest to ostatnie pytanie)
                    Console.ReadLine();
                }
            }
            Console.WriteLine($"Twój wynik końcowy: {totalPoints} pkt.");  // Wyświetlanie końcowego wyniku 
        }
        // Metoda do pobierania wyboru od użytkownika
        static char GetUserChoice()
        {
            char userChoice = char.ToLower(Console.ReadKey().KeyChar);
            Console.WriteLine();

            // Dodatkowa walidacja wyboru użytkownika
            while (userChoice != 'a' && userChoice != 'b' && userChoice != 'c')
            {
                Console.WriteLine("Nieprawidłowy wybór. Spróbuj ponownie.");
                Console.WriteLine();
                Console.Write("Twój wybór (wpisz a, b lub c): ");
                userChoice = char.ToLower(Console.ReadKey().KeyChar);
            }

            Console.WriteLine(); // Nowa linia po wprowadzeniu wyboru
            return userChoice;
        }
    }
}
