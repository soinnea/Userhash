using System;
using System.Collections.Generic;
using System.IO;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Serialization;

public class UserManager
{
    public List<User> Users = new List<User>();
    string file = "users.xml";

    public void Load()
    {
        if (!File.Exists(file))
            return;

        XmlSerializer ser = new XmlSerializer(typeof(List<User>),
            new Type[] { typeof(AdminUser) });

        using (FileStream fs = new FileStream(file, FileMode.Open))
        {
            Users = (List<User>)ser.Deserialize(fs);
        }
    }

    public void Save()
    {
        XmlSerializer ser = new XmlSerializer(typeof(List<User>),
            new Type[] { typeof(AdminUser) });

        using (FileStream fs = new FileStream(file, FileMode.Create))
        {
            ser.Serialize(fs, Users);
        }
    }

    public User Login(string username, string password)
    {
        string hash = Hash(password);

        foreach (var u in Users)
        {
            if (u.Username == username && u.PasswordHash == hash)
                return u;
        }

        return null;
    }

    public static string Hash(string text)
    {
        SHA256 sha = SHA256.Create();
        byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes(text));

        StringBuilder sb = new StringBuilder();

        foreach (byte b in data)
            sb.Append(b.ToString("x2"));

        return sb.ToString();
    }
}