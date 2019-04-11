using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StrategyExample
{
    public class Man
    {
        private IIntroduceStrategy IntroduceStrategy { get; set; }

        public void Work()
        {
            IntroduceStrategy = new WorkStrategy();
        }

        public void Home()
        {
            IntroduceStrategy = new HomeStrategy();
        }

        public string IntroduceYourself()
        {
            return IntroduceStrategy.IntroduceYourself();
        }
    }
}