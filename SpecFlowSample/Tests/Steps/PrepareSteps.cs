namespace Tests.Steps
{
    using Application;

    using TechTalk.SpecFlow;

    [Binding]
    public class PrepareSteps : ScenarioSteps
    {
        public PrepareSteps(ScenarioContext scenarioContext, FeatureContext featureContext)
            : base(scenarioContext, featureContext)
        {
        }

        [Given(@"user has access to the Application Service")]
        public void GivenUserHasAccessToTheApplicationService()
        {
            ScenarioData.ApplicationService = new ApplicationService();
        }
    }
}