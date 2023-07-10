using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trails : MonoBehaviour
{

    public ParticleSystem trails;
    void OnCollisionEnter2D(Collision2D other)
    {
        if(other.gameObject.tag == "Surfer")
            trails.Play();
    }

    void OnCollisionExit2D(Collision2D other)
    {
         if(other.gameObject.tag == "Surfer")
            trails.Stop();
    }
}
