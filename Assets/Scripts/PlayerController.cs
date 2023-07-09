using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D rb;
    public float torquePower = 1f;
  
    // Start is called before the first frame update
    void Start()
    {
      rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
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
}
