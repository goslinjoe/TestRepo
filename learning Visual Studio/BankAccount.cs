using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class BankAccount
{
    // INSTANCE VARIABLES... (each instance of this "BankAccount" class will have its own "name")
    private string name;  // variable names begin with lowercase;
                          // PRIVATE keeps access to this variable "internal only" (good for information hiding),
                          // outside instances of this class can only affect the value of "name" if one of the methods here has that capability

    public void SetName(string accountName)  // methods begin with uppercase; "VOID" indicates that this method WILL NOT RETURN any value
    {
        name = accountName;  // assigns the parameter value from "accountName" (a local variable available only to this method) into the class's INSTANCE VARIABLE: "name"
    }

    public string GetName()  // PUBLIC methods can be called from outside instances of this class
    {
        return name;  // here's how this public method can SEND BACK OUT the class's private instance variable: "name"
    }
}
