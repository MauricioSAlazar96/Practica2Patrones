
using Patron.Flyweight.Helper;

CharacterFactory characterFactory = new CharacterFactory();

TextEditor editor = new TextEditor(characterFactory);

for (int i = 0; i < 10000; i++)
{
    editor.AddCharacter('A', "Comic sans", 12, i, 10);
}

editor.AddCharacter('B', "Comic sans", 12, 1001, 10);
editor.AddCharacter('C', "Comic sans", 12, 1002, 10);
editor.AddCharacter('D', "Comic sans", 12, 1003, 10);
editor.AddCharacter('E', "Arial", 12, 1004, 10);

editor.DisplayDocuments();

Console.WriteLine($"Se crearon la siguiente cantidad de objetos: {characterFactory.TotalCharactersCreated()}");
