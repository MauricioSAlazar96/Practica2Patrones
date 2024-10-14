using Patron.Flyweight.Model;

namespace Patron.Flyweight.Helper
{
    public class TextEditor
    {
        private List<(Character, int, int)> _document = new List<(Character, int, int)>();
        private CharacterFactory _factory;

        public TextEditor(CharacterFactory factory)
        {
            _factory = factory;
        }

        public void AddCharacter(char symbol, string fontFamily, int fontSize, int positionX, int positionY)
        {
            var character = _factory.GetCharacter(symbol, fontFamily, fontSize);
            _document.Add((character, positionX, positionY));
        }

        public void DisplayDocuments()
        {
            foreach (var (character, x, y) in _document)
            {
                character.Display(x, y);
            }
        }
    }
}
