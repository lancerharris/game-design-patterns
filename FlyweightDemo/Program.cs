class Program {
  static void Main(string[] args) {
    var factory = new CharacterFactory();

    string document = "Hello, World!";
    string formatting = "Bold";

    foreach (char c in document)
    {
      var character = factory.GetCharacter(c);
      character.Display(formatting);
    }
  }
}