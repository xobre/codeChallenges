using System;
using System.Collections;
using System.Collections.Generic;

public class Robot
{
    public string alphabet = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
    public static List<string> NamesInUse = new List<string>();
    Random rnd;
    String FactName;
    public Robot()
    {
        rnd = new Random();
        FactName = NewName();
    }
    public string NewName()
    {
        string temp = alphabet[rnd.Next(0, 25)].ToString() + alphabet[rnd.Next(0, 25)].ToString() + rnd.Next(0, 9).ToString() + rnd.Next(0, 9).ToString() + rnd.Next(0, 9).ToString();
        if (NamesInUse.Contains(temp))
        {
            temp = NewName();
        }
        NamesInUse.Add(temp);
        return temp;
    }
    public string Name
    {

        get
        {
            return FactName;
        }
    }

    public void Reset()
    {
        NamesInUse.Remove(FactName);
        FactName = NewName();
    }
}