using System;

public class Account 
{
    private int accountId;
    private string username;
    private string password;
    private string type;

    public Account(int accountId, string username, string password, string type) 
    {
        setAccountId(accountId);
        setUsername(username);
        setPassword(password);
        setType(type);
    }

    public int getAccountId() {
        return accountId;
    }

    public void setAccountId(int accountId) {
        accountId > 0 ? this.accountId = accountId : throw new ArgumentException("Invalid account id");
    }

    public string getUsername() {
        return username;
    }

    public void setUsername(string username) {
        this.username = username;
    }

    public string getPassword()
    {
        return password;
    }

    public void setPassword(string password) 
    {
        this.password = password;
    }

    public string getType() {
        return type;
    }

    public void setType(string type) {
        if(type.ToLowerCase().equals("waiter"))
        {
            this.type = "WAITER";
        }
        else if (t.ToLowerCase().equals("manager"))
        {
            this.type = "MANAGER";
        }
        else
        {
            throw new ArgumentException("Invalid account type");
        }
    }
}