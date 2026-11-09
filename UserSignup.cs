using System;

public class UserSignup
{
    public string Username { get; set; }
    public string Email { get; set; }
    public string Password { get; set; }

    public void Register()
    {
       Console.WriteLine("User registration successful");
    } 
}  