using System;

[Serializable]
public class User
{
    public string Username { get; set; }
    public string PasswordHash { get; set; }

    public virtual bool IsAdmin()
    {
        return false;
    }

    public override string ToString()
    {
        return Username;
    }
}