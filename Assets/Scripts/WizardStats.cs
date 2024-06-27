using System.IO.IsolatedStorage;
using UnityEngine;

public class WizardStats 
{
    
    public int health = 100;
    public int mana = 100;
    public int maxHealth = 100;
    public int maxMana = 100;
    public float Bewegunggeschwindigtkeit = 1f;
    public int castTime = 1;
    public int level = 1;
    public static float experiencePoints = 1; 

    

    public void resetStats()
    { 
        health = 100;
        mana = 100;
        maxHealth = 100;
        maxMana = 100;
        Bewegunggeschwindigtkeit = 1f;
        castTime = 1;
    }


    public void levelUp()
    {
        if (experiencePoints > 100f)
        {
            level = level+1;
            experiencePoints = 0;

        }
        
        
    } 
    


}

