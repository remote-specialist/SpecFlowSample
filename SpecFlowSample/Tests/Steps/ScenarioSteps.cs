namespace Tests.Steps
{
    using System;
    using System.IO;
    using System.Linq;

    using ScenarioData;

    using TechTalk.SpecFlow;

    [Binding]
    public abstract class ScenarioSteps
    {
        protected ScenarioSteps(ScenarioContext scenarioContext, FeatureContext featureContext)
        {
            FeatureContext = featureContext;
            ScenarioContext = scenarioContext;
            ScenarioData = new ScenarioData(scenarioContext);
        }

        public FeatureContext FeatureContext { get; }

        public ScenarioContext ScenarioContext { get; }

        public ScenarioData ScenarioData { get; }

        public string TagJsonDataSourcePath => "jsonDataSourcePath";

        public string TagJsonDataSourceUpdate => "jsonDataSourceUpdate";

        public string JsonDataSourcePath
        {
            get
            {
                var tags = ScenarioContext.ScenarioInfo.Tags;
                var jsonDataSourcePathTag = tags.Single(i => i.StartsWith(TagJsonDataSourcePath));
                var jsonDataSourceRelativePath = jsonDataSourcePathTag.Split(':')[1];
                var jsonDataSourcePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, jsonDataSourceRelativePath);

                return jsonDataSourcePath;
            }
        }
    }
}