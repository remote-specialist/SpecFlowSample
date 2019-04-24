namespace Tests.Transforms
{
    using Application.Requests;
    using TechTalk.SpecFlow;
    using TechTalk.SpecFlow.Assist;

    [Binding]
    public class PowerWebTransforms
    {
        [StepArgumentTransformation]
        public FooRequest FooRequestTransform(Table table)
        {
            return table.CreateInstance<FooRequest>();
        }
    }
}
