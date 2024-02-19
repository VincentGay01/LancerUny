using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MechWeapon 
{
   private string name;
   private  int range;
   private string typeDamage;
   private  DiceRolls damage;
   private  int blast;
   private  string compendium;
    //don't forget to add tag

    public MechWeapon()
    {
        this.name = string.Empty;
        this.range = 0;
        this.typeDamage = string.Empty;
        this.damage = new DiceRolls();
        this.blast = 0;
        this.compendium = string.Empty;

    }

    public MechWeapon(string name, int range, string typeDamage, DiceRolls damage, int blast, string compendium)
    {
        this.name = name;
        this.range = range;
        this.typeDamage = typeDamage;
        this.damage = damage;
        this.blast = blast;
        this.compendium = compendium;
    }
    // getter and setter 
    public string getName() { return name; }
    public int getRange() { return range; } 
    public string getTypeDamage() { return typeDamage;}
    public DiceRolls getDamage() {  return damage;}
    public int getBlast() {  return blast;}
    public string getCompendium() {  return compendium;}

    public void setName(string name) { this.name = name;}
    public void setRange(int range) { this.range = range; }
    public void setTypeDamage(string typeDamage) {  this.typeDamage = typeDamage;}
    public void setDamage(DiceRolls damage) { this.damage = damage; }
    public void setBlast(int blast) { this.blast = blast; }
    public void setCompendium(string text) { this.compendium= text;}

}
