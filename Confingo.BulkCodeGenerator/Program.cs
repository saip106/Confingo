namespace Confingo.BulkCodeGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = Bootstrapper.Bootstrap();
            var app = container.GetInstance<BulkCodeGeneratorApp>();
            app.Run();
        }
    }
}
