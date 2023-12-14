/// <summary>
/// Represents a character in a text.
/// This interface is part of the Flyweight design pattern.
/// </summary>
public interface ICharacter
{
  /// <summary>
  /// Displays the character with the specified formatting.
  /// </summary>
  /// <param name="formatting">The formatting to apply to the character.</param>
  void Display(string formatting);
}