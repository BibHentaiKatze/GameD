using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fireball : MonoBehaviour
{
    public float speed = 2f;
    public float dTimer = 2f;
    public float vertical;
    public float hori;

    

    void Update()
    {
        if (Input.GetKey(KeyCode.Space))
        {
            vertical = 3;
            Destroy(gameObject, dTimer);
        }
        if (Input.GetKey(KeyCode.RightArrow))
        {
            hori = 3;

        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            hori = -3;

        }
        Vector2 movement = new Vector2(hori, vertical);
        
        transform.Translate(movement* (speed * Time.deltaTime));
        
    }

}


