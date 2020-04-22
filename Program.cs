using Newtonsoft.Json;
using ConsoleDump;

namespace dotnet_core_playground
{
    class Program
    {
        static void Main(string[] args)
        {
            "Hello World!".Dump();
            
            new []{1,2,3}.Dump();

            JsonConvert.SerializeObject(new {
                Id = 42,
                Message = "test" 
            }).Dump();
        }
    }
}
