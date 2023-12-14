/// <summary>
/// Represents a concrete implementation of the ICharacter interface which is part of the Flyweight design pattern.
/// </summary>
public class Character : ICharacter
{
  private char _symbol;

  /// <summary>
  /// Initializes a new instance of the Character class with the specified character symbol.
  /// </summary>
  /// <param name="character">The character symbol.</param>
  public Character(char character)
  {
    _symbol = character;
  }

  /// <summary>
  /// Displays the character symbol along with the specified formatting.
  /// </summary>
  /// <param name="formatting">The formatting to be applied.</param>
  public void Display(string formatting)
  {
    Console.WriteLine($"{_symbol} ({formatting})");
  }
}
