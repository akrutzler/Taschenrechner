using System;
using TechTalk.SpecFlow;

namespace Taschenrechner
{
    [Binding]
    public class SpecFlowFeature1Steps
    {
        [Given(@"the number is (.*)")]
        public void GivenTheNumberIs(Decimal p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"the sinus function is used")]
        public void WhenTheSinusFunctionIsUsed()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result should be (.*)")]
        public void ThenTheResultShouldBe(int p0)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
