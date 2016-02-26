using Confingo.BusinessLayer;
using StructureMap;

namespace Confingo.BulkCodeGenerator
{
    internal class Bootstrapper
    {
        public static IContainer Bootstrap()
        {
            var container = new Container();

            container.Configure(x => x.Scan(scanner =>
            {
                scanner.AssemblyContainingType<BulkCodeGeneratorApp>();
                scanner.AssemblyContainingType<UniqueCodeGenerator>();
                scanner.WithDefaultConventions();
            }));

            return container;
        }
    }
}