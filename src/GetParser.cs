using sly.parser.generator;
using sly.parser;
using fractal.src.ast;
using sly.buildresult;

namespace fractal.src
{
    public class GetFractal
    {

        public static Parser<FractalToken, Node> GetParser()
        {

            var parserInstance = new FractalParser();
            var builder = new ParserBuilder<FractalToken, Node>();
            var built = builder.BuildParser(parserInstance, ParserType.EBNF_LL_RECURSIVE_DESCENT, "root");

            foreach(InitializationError error in built.Errors)
            {
                Console.WriteLine($"ERROR OCCURED: {error.Message}");
            }

            var Parser = built.Result;
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
