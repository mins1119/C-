using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.Scripting;
using Microsoft.Scripting.Hosting;
using IronPython.Hosting;

namespace WithPython
{
    class MainApp
    {
        static void Main(string[] args)
        {
            ScriptEngine engine = Python.CreateEngine();
            ScriptScope scope = engine.CreateScope();
            scope.SetVariable("n", "Alice");
            scope.SetVariable("s", "Alice in wonderland");

            ScriptSource source = engine.CreateScriptSourceFromString(
                @"
class NameCard : 
    name = ''
    story = ''

    def _init_(self,name,story) :
        self.name = name
        self.story = story

    def printNameCard(self) : 
        print self.name + ',' + self.story

NameCard(n, s)
");

            dynamic result = source.Execute(scope);

            result.printNameCard();
            Console.WriteLine($"{result.name}, {result.story}");
        }
    }
}
