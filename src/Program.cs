// See https://aka.ms/new-console-template for more information
using fractal.src;
using fractal.src.ast;
using fractal.src.visitors;
using sly.parser.generator;
using sly.parser;
using System.IO;

Console.WriteLine("Hello, World! And me");



var x = new SomeTest();
// Console.WriteLine("Parser successfully genreated");

var file = File.ReadAllText("default.fractal");

x.TestCSLY(file);

// Console.WriteLine($"{parser.Result}");


// var parser = GetFractal.GetParser();

// // RootNode output = (RootNode)parser.Parse("1 + 2 - 3; 1;").Result;

// // output.Accept(new PrintTreeVisitor());
// var parserInstance = new TestParser();
// var builder = new ParserBuilder<TestToken, int>();
// var Parser = builder.BuildParser(parserInstance, ParserType.EBNF_LL_RECURSIVE_DESCENT, "root").Result;
// // var Parser = builder.BuildParser(parserInstance, ParserType.LL_RECURSIVE_DESCENT, "root").Result;

// var result = Parser.Parse("1");

// Console.WriteLine($"result: {result}");

// // return Parser;