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


    // AUTO-IMPLEMENTED PROPERTY:
    // this is a quick way, in one line, of creating (implicitly) a priavte instance variable "name2" (lowercase) with an associated Accessor PROPERTY "Name2" (uppercase)
    // used when get & set don't need to do much more than return & assign values straight-through, unaltered
    // ===========================================
    public string Name2 { get; set; }


    // * pick up again, next time, on Chapter 4.8

    public void SetName(string accountName)  // methods begin with uppercase; "VOID" indicates that this method WILL NOT RETURN any value
    {
        name = accountName;  // assigns the parameter value from "accountName" (a local variable available only to this method) into the class's INSTANCE VARIABLE: "name"
    }

    public string GetName()  // PUBLIC methods can be called from outside instances of this class
    {
        return name;  // here's how this public method can SEND BACK OUT the class's private instance variable: "name"
    }

    // PROPERTIES (using get & set accessors, to control private internal instance variables of this class):
    // ===========================================
    public string Name  // UPPERCASE version of the lowercase instance variable that this will access/control
    {
        get
        {
            return name;
        }
        set
        {
            name = value;  // "value" is implicitly set up, and represents the value COMING IN -- for assignment -- when an outside instance of this class tries to update the value of ".Name"
        }
    }
}
