// See https://aka.ms/new-console-template for more information
using sly.parser.generator;
using sly;
using sly.lexer;
using sly.parser;

Console.WriteLine("Hello, World! And me");

var x = new fractal.src.SomeTest();
Console.WriteLine("Parser successfully genreated");

x.TestCSLY("1 + 3 - 4");
