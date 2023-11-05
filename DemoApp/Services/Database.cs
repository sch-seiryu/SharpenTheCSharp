// {demo} This is not a real database or service codes,
// this is a fake database, a way suggested by Avalonia UI tutorial.
// Reference:
//  https://docs.avaloniaui.net/tutorials/todo-list-app/creating-a-model-and-viewmodel#create-a-fake-database
using System.Collections.Generic;
using DemoApp.Models;

namespace DemoApp.Services
{
    public class Database
    {
        public IEnumerable<TextItem> GetItems() => new []
        {
            new TextItem { Title = "Sample Text #1", TextLiteral = "Hello world!"},
            new TextItem
            {
                Title = "Sample Text #2",
                TextLiteral = @"This
is a
verbatim
string.
It supports multiline string!

So, does this look good?"
            },
            new TextItem {
                Title = "Sample Text #3",
                TextLiteral = """
This
is a
raw
string
literals.

You

might have

tough

time


, don\'t you?
"""},
        };
    }
}