// See https://aka.ms/new-console-template for more information
using fractal.src;
using fractal.src.ast;
using fractal.src.visitors;

Console.WriteLine("Hello, World! And me");

var x = new SomeTest();
Console.WriteLine("Parser successfully genreated");

// var fractal_file = "1 +  2 - 3; 4 * 5   + 6;";
string fractal_file = File.ReadAllText("default.fractal");

Console.WriteLine($"file: {fractal_file}");

// x.TestCSLY(fractal_file);

var parser = GetFractal.GetParser();

RootNode output = (RootNode)parser.Parse(fractal_file).Result;
var tree = parser.Parse(fractal_file).SyntaxTree;


// var graphviz = new GraphVizEBNFSyntaxTreeVisitor<FractalToken>();
// var root = graphviz.VisitTree(tree);
// string graph = graphviz.Graph.Compile();
// File.Delete("c:\\temp\\tree.dot");
// File.AppendAllText("c:\\temp\\tree.dot", graph);


output.Accept(new PrintTreeVisitor());
