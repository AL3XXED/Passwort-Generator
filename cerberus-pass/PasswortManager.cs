namespace cerberus_pass;

public class PasswortManager
{
    private List<PasswordEntry> vault;

    public PasswortManager()
    {
        vault = [];
    }

    public List<PasswordEntry> GetAll()
    {
        return vault;
    }

    public PasswordEntry CreateEntry(
        string titel,
            string login,
            string password,
            string website = "",
            string note = ""
    )
    {
        var newEntry = new PasswordEntry(
            titel,
            login,
            password,
            website,
            note)
    );
        vault.Add(newEntry);
        return newEntry;
    }


}
