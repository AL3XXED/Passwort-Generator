namespace cerberus_pass;
// PascalCae = BegriffstrennungImmerErsterBuchstabeGroß
// =Properties, Funktionen / Methoden, Klassen, Namespaces, Enums
public class PasswordEntry
{
    public string Title { get; set; }
    public string Login { get; set; }
    public string Password { get; set; }
    public string Website { get; set; }
    public string Note { get; set; }

    public PasswordEntry(string titel, string login, string password, string website = "", string note = "")
    {
        Title = titel;
        Login = login;
        Password = password;
        Website = website;
        Note = note;
    }

    public override string ToString()
    {
        return $"{Title}\t{Website}\t{Login}";
    }
}
