using _04_02_ConfigClass;
using _04_02_ConfigClass.SCOPES;

Console.WriteLine("Environment Variables");

//var ambiente = Environment.GetEnvironmentVariable("AMBIENTE");

//Console.WriteLine($"Ambiente: {ambiente}");

//var config = new ConfigClass();

//Console.WriteLine(config.DbConnectionString);

var c1 = new ClassScopes("C1");
c1.Print();
ClassScopes.Status = "MODIFICADO";

var c2 = new ClassScopes("C2");
c2.Print();
c1.Print();

