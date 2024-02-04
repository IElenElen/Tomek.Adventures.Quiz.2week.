﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tomek.Adventures.Quiz._2week_
{
    public class QuestionsSet
    {
        public List<Question> Questions { get; set; } = new List<Question>(); //Lista pytań

        public QuestionsSet()
        {
            QuestionHandling questionHandling = new QuestionHandling();
            Questions.AddRange(questionHandling.AllQuestions);
        }
    }
}
