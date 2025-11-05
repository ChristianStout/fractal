using sly.parser.generator;
using sly.parser;
using fractal.src.ast;

namespace fractal.src
{
    public class GetFractal
    {

        public static Parser<FractalToken, Node> GetParser()
        {

            var parserInstance = new FractalParser();
            var builder = new ParserBuilder<FractalToken, Node>();
            var Parser = builder.BuildParser(parserInstance, ParserType.LL_RECURSIVE_DESCENT, "expression").Result;

            return Parser;
        }

    }

    public class SomeTest
    {
        public void TestCSLY(string expression)
        {
            var Parser = GetFractal.GetParser();
            var r = Parser.Parse(expression);

            if (!r.IsError)
            {
                Console.WriteLine($"result of <{expression}>  is {r.Result}");
                Console.WriteLine($"resulting ast = {r.SyntaxTree.ToJson()}");
                // outputs : result of <42 + 42>  is 84"
            }
            else
            {
                if (r.Errors != null && r.Errors.Any())
                {
                    // display errors
                    r.Errors.ForEach(error => Console.WriteLine(error.ErrorMessage));
                }
            }
        }
    }
}
