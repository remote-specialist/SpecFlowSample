namespace Tests.ScenarioData
{
    using Application;
    using Application.Requests;
    using Application.Responses;

    using TechTalk.SpecFlow;

    public class ScenarioData
    {
        private readonly ScenarioContext _context;

        public ScenarioData(ScenarioContext context)
        {
            _context = context;
        }

        public ApplicationService ApplicationService
        {
            get =>
                _context.ContainsKey(nameof(ApplicationService))
                    ? _context.Get<ApplicationService>(nameof(ApplicationService))
                    : null;

            set => _context.Set(value, nameof(ApplicationService));
        }

        public FooRequest FooRequest
        {
            get => _context.ContainsKey(nameof(FooRequest)) ? _context.Get<FooRequest>(nameof(FooRequest)) : null;
            set => _context.Set(value, nameof(FooRequest));
        }

        public BarRequest BarRequest
        {
            get => _context.ContainsKey(nameof(BarRequest)) ? _context.Get<BarRequest>(nameof(BarRequest)) : null;
            set => _context.Set(value, nameof(BarRequest));
        }

        public FooResponse FooResponse
        {
            get => _context.ContainsKey(nameof(FooResponse)) ? _context.Get<FooResponse>(nameof(FooResponse)) : null;
            set => _context.Set(value, nameof(FooResponse));
        }

        public BarResponse BarResponse
        {
            get => _context.ContainsKey(nameof(BarResponse)) ? _context.Get<BarResponse>(nameof(BarResponse)) : null;
            set => _context.Set(value, nameof(BarResponse));
        }

        public string JsonDataSource
        {
            get => _context.ContainsKey(nameof(JsonDataSource)) ? _context.Get<string>(nameof(JsonDataSource)) : null;
            set => _context.Set(value, nameof(JsonDataSource));
        }
    }
}