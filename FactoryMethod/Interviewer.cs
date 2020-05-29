using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    interface IInterviewer
    {
        public void AskQuestions();
    }

    class Developer : IInterviewer
    {
        public void AskQuestions()
        {
            Console.WriteLine($"デザインパターンについて尋ねる");
        }
    }

    class CommunityExecutive : IInterviewer
    {
        public void AskQuestions()
        {
            Console.WriteLine($"コミュニティ育成について尋ねる");
        }
    }
}
