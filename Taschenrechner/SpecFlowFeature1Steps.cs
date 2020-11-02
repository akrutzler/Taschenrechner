using System;
using TechTalk.SpecFlow;
using Xunit;

namespace Taschenrechner
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        bool cos = false;
        bool tan = false;

        [Given(@"the number is (.*)")]
        public void GivenTheNumberIs(Double p0)
        {
            var expected = Math.PI;
            var actual = p0;
            Assert.Equal(expected, actual, 5);
        }
        
        [When(@"the sinus function is used")]
        public void WhenTheSinusFunctionIsUsed()
        {
            cos = false;
            tan = false;
        }

        [When(@"the cosinus function is used")]
        public void WhenTheCosinusFunctionIsUsed()
        {
            cos = true;
            tan = false;
        }

        [When(@"the tangens function is used")]
        public void WhenTheTangensFunctionIsUsed()
        {
            cos = false;
            tan = true;
        }

        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            var expected = 0;
            var actual = Math.Sin(p0);

            if (cos)
            {
                expected = -1;
                actual = Math.Cos(p0);
            }

            if (tan)
            {
                expected = 0;
                actual = Math.Tan(p0);
            }
            Assert.Equal(expected, actual, 5);
        }
    }
}
