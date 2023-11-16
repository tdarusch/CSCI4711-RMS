using System;

public class Account 
{
    private int accountId;
    private string username;
    private string password;
    private string type;

    public Account(int accId, string usn, string pwd, string t) 
    {
        setAccountId(accId);
        setUsername(usn);
        setPassword(pwd);
        setType(t);
    }

    public int getAccountId() {
        return accountId;
    }

    public void setAccountId(int id) {
        id > 0 ? accountId = id : throw new ArgumentException("Invalid account id");
    }

    public string getUsername() {
        return username;
    }

    public void setUsername(string usn) {
        username = usn;
    }

    public string getPassword()
    {
        return password;
    }

    public void setPassword(string pwd) 
    {
        password = pwd;
    }

    public string getType() {
        return type;
    }

    public void setType(string t) {
        if(t.ToLowerCase().equals("waiter"))
        {
            type = "WAITER";
        }
        else if (t.ToLowerCase().equals("manager"))
        {
            type = "MANAGER";
        }
        else
        {
            throw new ArgumentException("Invalid account type");
        }
    }
}