/// <summary>
/// Represents a factory for creating and managing character objects.
/// </summary>
/// <remarks>
/// In object-oriented programming, a factory is a design pattern that provides an interface for creating objects of a certain type. It encapsulates the object creation logic and allows the client code to create objects without knowing the specific implementation details. By using a factory, we can decouple the client code from the concrete classes, making it more flexible and maintainable.
/// </remarks>
public class CharacterFactory
{
  private Dictionary<char, ICharacter> _characters = new Dictionary<char, ICharacter>();

  /// <summary>
  /// Gets a character object based on the specified key.
  /// If the character object does not exist, it is created and added to the internal dictionary.
  /// </summary>
  /// <param name="key">The key representing the character.</param>
  /// <returns>The character object.</returns>
  public ICharacter GetCharacter(char key)
  {
    if (!_characters.ContainsKey(key))
    {
      _characters.Add(key, new Character(key));
    }
    return _characters[key];
  }
}