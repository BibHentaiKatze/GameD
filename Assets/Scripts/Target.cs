
using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Target : MonoBehaviour
{
    
    NewBehaviourScript player = NewBehaviourScript.Instance;
    
    
    Vector3 fireballReset = new Vector3(0f,40f,0f);
    

    
    void OnCollisionEnter2D(Collision2D col)
    {
        if (col.gameObject.CompareTag("Fireball"))
        {
            Vector3 hallo = new Vector3(Random.value*16-7,Random.value*6-3,0f); 
            
            gameObject.transform.position = hallo;
            
            UI.score = UI.score+20;
            WizardStats.experiencePoints = WizardStats.experiencePoints+120f;

           
            
            
            
        }
    }
   
}
