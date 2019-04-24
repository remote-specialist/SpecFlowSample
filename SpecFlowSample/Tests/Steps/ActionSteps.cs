namespace Tests.Steps
{
    using Application.Requests;

    using TechTalk.SpecFlow;
    using TechTalk.SpecFlow.Assist;

    [Binding]
    public class ActionSteps : ScenarioSteps
    {
        public ActionSteps(ScenarioContext scenarioContext, FeatureContext featureContext)
            : base(scenarioContext, featureContext)
        {
        }

        [When(@"user invokes Bar functionality")]
        public void WhenUserInvokesBarFunctionality(Table table)
        {
            var request = table.CreateInstance<BarRequest>();
            ScenarioData.BarRequest = request;
            ScenarioData.BarResponse = ScenarioData.ApplicationService.Bar(request);
        }

        [When(@"user invokes Foo functionality")]
        public void WhenUserInvokesFooFunctionality(FooRequest request)
        {
            ScenarioData.FooRequest = request;
            ScenarioData.FooResponse = ScenarioData.ApplicationService.Foo(request);
        }
    }
}