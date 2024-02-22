using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class listMechWeapon 
{
    public Dictionary<string,MechWeapon> listmechweapon;


    public listMechWeapon ()
    {
        listmechweapon.Add("Anti-Materiel_Rifle",new MechWeapon("Anti-Materiel Rifle",20,0,"Kinetic",new DiceRolls(2,6),0,"WIP"));
        listmechweapon.Add("Assault_Rifle", new MechWeapon("Assault Rifle", 10,0, "Kinetic", new DiceRolls(1, 6), 0, "WIP"));
        listmechweapon.Add("Charged_Blade", new MechWeapon("Charged blade", 0,1, "Energy", new DiceRolls(1,3,3), 0, "WIP"));
        listmechweapon.Add("Cylone_Pulse_Rifle", new MechWeapon("Cyclone pulse rifle", 15,0, "Kinetic", new DiceRolls(3, 6,3), 0, "WIP"));
        listmechweapon.Add("Heavy_Charged_Blade", new MechWeapon("heavy charged blade",0, 1, "Energy", new DiceRolls(1, 6,3), 0, "WIP"));
        listmechweapon.Add("Heavy_Machine_Gun", new MechWeapon("Heavy Machine gun",8,0, "Kinetic", new DiceRolls(2, 6,4), 0, "WIP"));
        listmechweapon.Add("Heavy_Melee_Weapon", new MechWeapon("Heavy Melee weapon ", 0,1, "Kinetic", new DiceRolls(2, 6,1), 0, "WIP"));
        listmechweapon.Add("Howitzer", new MechWeapon("Howitzer", 20,0, "Explosive", new DiceRolls(2, 6), 2, "WIP"));
        listmechweapon.Add("Hurricane_Cluster_Projector", new MechWeapon("Hurricane cluster projector", 10,0, "Explosive", new DiceRolls(1, 6,6),2, "WIP"));
        listmechweapon.Add("Missile_Rack", new MechWeapon("Missile Rack",10,0, "Explosive", new DiceRolls(1,3,1 ), 1, "WIP"));
        listmechweapon.Add("Mortar", new MechWeapon("Mortar", 15,0, "Explosive", new DiceRolls(1, 6,1), 1, "WIP"));
        listmechweapon.Add("Nexus(Hunter-killer)", new MechWeapon("Nexus (Hunter-Killer)",10,0, "Kinetic", new DiceRolls(1, 6), 0, "WIP"));
        listmechweapon.Add("Nexus(light)", new MechWeapon("Nexus(light)", 10,0, "Kinetic", new DiceRolls(1,3),0, "WIP"));
        listmechweapon.Add("Pistol", new MechWeapon("Pistol",5,3, "kinetic", new DiceRolls(1,3),0, "WIP"));
        listmechweapon.Add("Rocket-Propelled_Grenade", new MechWeapon("Rocket-Propelled Grenade",10,0, "Explosive", new DiceRolls(1, 6,1),2, "WIP"));
        listmechweapon.Add("Segment_knife", new MechWeapon("Segment_knife",0,1, "Energy", new DiceRolls(1,3,1), 0, "WIP"));
        listmechweapon.Add("Shotgun", new MechWeapon("Shotgun", 5, 3, "kinetic", new DiceRolls(1,6), 0, "WIP"));
        listmechweapon.Add("Tactical_knife", new MechWeapon("Tactical knife",0,1, "kinetic", new DiceRolls(1, 3,1), 0, "WIP"));
        listmechweapon.Add("Tactical_Melee_Weapon", new MechWeapon("Tactical Melee Weapon",0,1, "kinetic", new DiceRolls(1,6,2), 0, "WIP"));
        listmechweapon.Add("Tempest_Charged_Blade", new MechWeapon("Tempest Charged Blade",0,2, "Energy", new DiceRolls(3,6,4), 0, "WIP"));
        listmechweapon.Add("Thermal_Lance", new MechWeapon("Thermal Lance",10,10, "Energy", new DiceRolls(1,6,3), 0, "WIP"));
        listmechweapon.Add("Thermal_Pistol", new MechWeapon("thermal_Pistol", 5,5, "Energy", new DiceRolls(1,1,1), 0, "WIP"));
        listmechweapon.Add("Thermal_Rifle", new MechWeapon("Thermal_Rifle", 5, 0, "Energy", new DiceRolls(1, 3,2), 0, "WIP"));
        listmechweapon.Add("Assault_cannon", new MechWeapon("Assault_cannon",8,0, "Kinetic", new DiceRolls(1,6,2), 0, "WIP"));
        listmechweapon.Add("Blackspot_Targeting_laser", new MechWeapon("Blackspot Targeting Laser",15,0, "Energy", new DiceRolls(1, 3,1), 0, "WIP"));
        listmechweapon.Add("Bolt_Thrower", new MechWeapon("Bolt_Thrower",8,0, "Explosive", new DiceRolls(1, 6), 0, "WIP"));
        listmechweapon.Add("Bristlecrown_Flechette_Launcher", new MechWeapon("Bristlecrown_Flechette_Launcher",1,1, "kinetic", new DiceRolls(1,1),1, "WIP"));
        listmechweapon.Add("Catalytic_Hammer", new MechWeapon("Catalytic Hammer",0,1, "kinetic", new DiceRolls(1, 3,5), 0, "WIP"));
        listmechweapon.Add("Chain_Axe", new MechWeapon("Chain Axe",0,1, "kinetic", new DiceRolls(1,6), 0, "WIP"));
        listmechweapon.Add("Combat_Drill", new MechWeapon("Combat Drill",0,1,"kinetic,Energy", new DiceRolls(3,6), 0, "WIP"));
        listmechweapon.Add("Concussion_Missiles", new MechWeapon("Concussion Missiles", 5, 0, "Explosive", new DiceRolls(1,3), 0, "WIP"));
        listmechweapon.Add("Cutter_MKII_Plasma_Torch", new MechWeapon("Cutter MKII Plasma Torch", 0,1, "Energy", new DiceRolls(1),1,1,0, "WIP"));
    }
}
