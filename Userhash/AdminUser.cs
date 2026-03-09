using System;

[Serializable]
public class AdminUser : User
{
    public override bool IsAdmin()
    {
        return true;
    }
}