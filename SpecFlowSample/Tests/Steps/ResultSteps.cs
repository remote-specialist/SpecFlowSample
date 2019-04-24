namespace Tests.Steps
{
    using System.IO;
    using System.Linq;

    using Application.Responses;
    using FluentAssertions;
    using Newtonsoft.Json;
    using TechTalk.SpecFlow;

    [Binding]
    public class ResultSteps : ScenarioSteps
    {
        public ResultSteps(ScenarioContext scenarioContext, FeatureContext featureContext)
            : base(scenarioContext, featureContext)
        {
        }

        [Then(@"Bar functionality should complete successfully")]
        public void ThenBarFunctionalityShouldCompleteSuccessfully()
        {
            var request = ScenarioData.BarRequest;
            var response = ScenarioData.BarResponse;

            response.BarResponseValue.Should().Be($"Bar{request.BarRequestValue}");
        }

        [Then(@"Foo functionality should complete successfully")]
        public void ThenFooFunctionalityShouldCompleteSuccessfully()
        {
            var actual = ScenarioData.FooResponse;

            if (IsJsonDataSourceUpdateMode())
            {
                UpdateJsonDataSource(actual);
                return;
            }

            var expected = JsonConvert.DeserializeObject<FooResponse>(ScenarioData.JsonDataSource);
            actual.FooResponseValue.Should().Be(expected.FooResponseValue);
        }

        private bool IsJsonDataSourceUpdateMode()
        {
            return ScenarioContext.ScenarioInfo.Tags.Contains(TagJsonDataSourceUpdate)
                   || FeatureContext.FeatureInfo.Tags.Contains(TagJsonDataSourceUpdate);
        }

        private void UpdateJsonDataSource(object actual)
        {
            File.WriteAllText(JsonDataSourcePath, JsonConvert.SerializeObject(actual));
        }
    }
}