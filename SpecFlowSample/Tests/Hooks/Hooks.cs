namespace Tests.Hooks
{
    using System;
    using System.IO;
    using System.Linq;

    using TechTalk.SpecFlow;
    using Tests.Steps;

    [Binding]
    public class Hooks : ScenarioSteps
    {
        public Hooks(ScenarioContext scenarioContext, FeatureContext featureContext)
            : base(scenarioContext, featureContext)
        {
        }

        [BeforeScenario("jsonDataSource")]
        public void BeforeScenario()
        {
            var tags = ScenarioContext.ScenarioInfo.Tags;
            var jsonDataSourcePathTag = tags.Single(i => i.StartsWith(TagJsonDataSourcePath));
            var jsonDataSourceRelativePath = jsonDataSourcePathTag.Split(':')[1];
            var jsonDataSourcePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, jsonDataSourceRelativePath);
            var jsonRaw = File.ReadAllText(jsonDataSourcePath);
            ScenarioData.JsonDataSource = jsonRaw;
        }
    }
}