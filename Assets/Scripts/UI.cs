using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class UI : MonoBehaviour
{
    public TextMeshPro healthText;
    public TextMeshPro manaText;
    public TextMeshPro scoreText;
    
    public static int score = 0;

    
    

    void Update()
    {
        NewBehaviourScript player = NewBehaviourScript.Instance;
        int health = (int)player.health;
        int mana = (int)player.mana;
        
        WizardStats playerstats = NewBehaviourScript.stats;
        
        int maxHealth = playerstats.maxHealth;
        int maxMana = playerstats.maxMana;
        int level = playerstats.level;
        
        scoreText.text = "Score: " + score;
        healthText.text ="Health: " + health + "/" + maxHealth;
        manaText.text ="Mana: " + mana + "/" + maxMana;
    }
}
