using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DiceRolls 
{
    private int number;
    private int typeDice;
    private int modificator;
    

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
    public int getmodificator() { return this.modificator; }

    public void setNumber(int number) { this.number = number;}

    public void settypeDice(int typeDice) { this.typeDice = typeDice;}

    public void setModificator(int modificator) { this.modificator = modificator;}  

    public int roll() {
        int res=0;
        for (int i=0;i<this.number; i++)
        {
            res +=Random.Range(1,this.typeDice);
        }
        res += this.modificator;
        return res;
    }
}
