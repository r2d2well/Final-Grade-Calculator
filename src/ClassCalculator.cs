using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

public class ClassCalculator
{
    private string Name;
    private ArrayList Catagory;
    private ArrayList Percent;

    public ClassCalculator (string Name)
    {
        this.Name = Name;
        Catagory = new ArrayList();
        Percent = new ArrayList();
        //Takes in a string to set the Name varable to and intilizes Catagory and Percent ArrayLists
    }
    public ClassCalculator (string Name, string[] Catagorys, double[] Percents)
    {
        this.Name = Name;
        Catagory = new ArrayList(Catagorys);
        Percent = new ArrayList(Percents);
        //Overloaded constructor that takes in a array of string and double to initilize ArrayLists with
    }

    public void AddCatagory(string Name, double Percent)
    {
        Catagory.Add(Name);
        this.Percent.Add(Percent);
        //Takes in a string and percent and adds it to the ArrayLists
    }

    public string GetName()
    {
        return Name;
    }

    public int GetCount()
    {
        return Catagory.Count;
    }

    public string GetCatagory(int index)
    {
        return (string) Catagory [index];
    }

    public double GetPercent(int index)
    {
        return (double) Percent [index];
    }
}
