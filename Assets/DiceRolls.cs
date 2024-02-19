using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceRolls 
{
    public int number;
    public int typeDice;
    public int modificator;

    //rajouter les tags

    public DiceRolls() { 
        this.number = 0;
        this.typeDice = 0;
        this.modificator = 0;
    }  

    public DiceRolls(int number,int typeDice)
    {
        this.number = number;
        this.typeDice = typeDice;
    }

    public DiceRolls(int number, int typeDice, int modificator) : this(number, typeDice)
    {
        this.modificator = modificator;
    }

    public int getNumber() { return this.number; }
    public int gettypeDice() { return this.typeDice; }

}
