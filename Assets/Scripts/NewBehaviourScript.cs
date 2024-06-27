using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : MonoBehaviour
{
    public static NewBehaviourScript Instance;
    
    public float speed = 5f;
    public GameObject Firaball;
    public GameObject Target;


    public int health = 100;
    public int mana = 50;
    
    public static WizardStats stats;
    

    void Awake()
    {
       
        if (Instance == null)
        {
            Instance = this;
        }
        else if (Instance != this)
        {
            Destroy(gameObject);
        }
    }

    public void spwanFireUndTarget()
    {
        if (Firaball != null && Target != null)
        {
            GameObject newObjectFireball = Instantiate(Firaball, new Vector3(0, 0, 0), Quaternion.identity);
            GameObject newObjectTarget = Instantiate(Target, new Vector3(0, 4, 0), Quaternion.identity);

            newObjectTarget.SetActive(true);
            
        }
        else
        {
            Debug.LogError("Firaball or Target prefab is not assigned in the Inspector.");
        }
    }

    void Start()
    {

        if (stats == null)
        {
            stats = new WizardStats();
        }
        health = stats.maxHealth;
        mana =  stats.maxMana;
        Instance = this;
        
      spwanFireUndTarget();
    }

    void Update()
    {
        float horizontal = 0;
        float vertical = 0;

        if (Input.GetKey(KeyCode.W))
        {
            vertical = 1;
        }
        if (Input.GetKey(KeyCode.S))
        {
            vertical = -1;
        }
        if (Input.GetKey(KeyCode.A))
        {
            horizontal = -1;
        }
        if (Input.GetKey(KeyCode.D))
        {
            horizontal = 1;
        }

        Vector2 movement = new Vector2(horizontal, vertical);

        if (movement.sqrMagnitude > 1)
        {
            movement = movement.normalized;
        }

        transform.Translate(movement * (speed * Time.deltaTime));
        
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject newObjectFireball2 =Instantiate(Firaball,transform.position,Quaternion.identity);
            newObjectFireball2.SetActive(true);

        }
    }
}