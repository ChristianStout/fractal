// See https://aka.ms/new-console-template for more information
using fractal.src;
using fractal.src.ast;
using fractal.src.visitors;

Console.WriteLine("Hello, World! And me");

var x = new SomeTest();
Console.WriteLine("Parser successfully genreated");

x.TestCSLY("1 + 3 - 4;");

var parser = GetFractal.GetParser();

RootNode output = (RootNode)parser.Parse("1 + 2 - 3;").Result;

output.Accept(new PrintTreeVisitor());
