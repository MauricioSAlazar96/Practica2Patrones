using Patron.Flyweight.Model;

namespace Patron.Flyweight.Helper
{
    public class CharacterFactory
    {
        private Dictionary<string, Character> _characters = new Dictionary<string, Character>();

        public Character GetCharacter(char symbol, string fontFamily, int fontSize)
        {
            string key = $"{symbol}_{fontFamily}_{fontSize}";

            if (!_characters.ContainsKey(key))
            {
                _characters[key] = new Character(symbol, fontFamily, fontSize);
            }

            return _characters[key];
        }

        public int TotalCharactersCreated()
        {
            return _characters.Count;
        }

    }
}
