using System;
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
    // getter and setter
    public int getNumber() { return this.number; }
    public int gettypeDice() { return this.typeDice; }
    public int getmodificator() { return this.modificator; }

    public void setNumber(int number) { this.number = number;}

    public void settypeDice(int typeDice) { this.typeDice = typeDice;}

    public void setModificator(int modificator) { this.modificator = modificator;}  
    // function to roll a dice
    public int roll() {
        int res=0;
        for (int i=0;i<this.number; i++)
        {
            res += UnityEngine.Random.Range(1,this.typeDice);
        }
        res += this.modificator;
        return res;
    }
    //function to add two dice roll
    public int addRoll(DiceRolls roll)
    {
        int res=0;
        res += this.roll();
        res += roll.roll();
        return res;
    }
    // function to substract two dice roll
    public int minusRoll(DiceRolls roll)
    {
        int res=0;
        res += this.roll();
        if((res-roll.roll())<1)
        {
            res = 1;
        }
        else
        {
            res -= roll.roll();
        }
        return res;
    }
    // divide a roll by 2 
    public int divideDiceRoll()
    {
        double res=0;
        res += this.roll();
        res = Math.Ceiling(res/2);
        return Convert.ToInt32(res);
    }
}
