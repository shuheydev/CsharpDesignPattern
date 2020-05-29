using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    abstract class HiringManager
    {
        protected abstract IInterviewer MakeInterviewer();

        public void TakeInterview()
        {
            var interviewer = this.MakeInterviewer();
            interviewer.AskQuestions();
        }
    }

    class DevelopmentManager : HiringManager
    {
        protected override IInterviewer MakeInterviewer()
        {
            return new Developer();
        }
    }

    class MarketingManager : HiringManager
    {
        protected override IInterviewer MakeInterviewer()
        {
            return new CommunityExecutive();
        }
    }
}
