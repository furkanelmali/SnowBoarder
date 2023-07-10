using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    
    SurfaceEffector2D surfaceEffector2D;
    
    public float torquePower = 1f;
    public float boost = 30f;

    public float  basespeed = 20f;

    bool canMove = true;
    // Start is called before the first frame update
    void Start()
    {
      rb = GetComponent<Rigidbody2D>();
      surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
      bool canMove = true;
    }

    // Update is called once per frame
    void Update()
    {
        if(canMove)
        {
            Rotating();
            SpeedChanger();     
        }
        
    }

    void Rotating()
    {
            if(Input.GetKey(KeyCode.LeftArrow))
        {
            rb.AddTorque(torquePower * Time.deltaTime);
        }
            else if(Input.GetKey(KeyCode.RightArrow))
        {
            rb.AddTorque(-torquePower * Time.deltaTime);
        }
    }

    void SpeedChanger()
    {
          if(Input.GetKey(KeyCode.Space))
        {
           surfaceEffector2D.speed = boost;
        }
            else 
        {
           surfaceEffector2D.speed = basespeed;
        }
    }

    public void disableControl()
    {
        canMove = false;
    }
}
