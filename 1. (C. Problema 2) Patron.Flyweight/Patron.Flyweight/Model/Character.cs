

namespace Patron.Flyweight.Model
{
    public class Character
    {
        public char Symbol { get; private set; }
        public string FontFamily { get; private set; }
        public int FontSize { get; private set; }

        public Character(char symbol, string fontFamily, int fontSize)
        {
            this.Symbol = symbol;
            this.FontFamily = fontFamily;
            this.FontSize = fontSize;
        }

        public void Display(int positionX, int positionY)
        {
            Console.WriteLine($"Carácter: {Symbol}, Fuente: {FontFamily}, Tamaño: {FontSize}, Posición: ({positionX}, {positionY})");
        }
    }
}
