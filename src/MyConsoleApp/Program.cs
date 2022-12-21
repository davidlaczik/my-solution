using System.Security.AccessControl;
using System.Collections.Generic;
using System.Linq;
// See https://aka.ms/new-console-template for more information
Console.WriteLine("MyConsoleApp");


var p = new Person()
{
    Id = new Guid()
};

var col = new List<int>();
var col2 = new List<int>();

var j = col.Join(col2, o => )

class Person
{
    public Guid Id { get; set; }
}