namespace Application
{
    using Application.Requests;
    using Application.Responses;

    public class ApplicationService
    {
        public FooResponse Foo(FooRequest request)
        {
            return new FooResponse { FooResponseValue = $"Foo{request.FooRequestValue}" };
        }

        public BarResponse Bar(BarRequest request)
        {
            return new BarResponse { BarResponseValue = $"Bar{request.BarRequestValue}" };
        }
    }
}