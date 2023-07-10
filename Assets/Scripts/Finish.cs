using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Finish : MonoBehaviour
{
    public float delay = 1f;
    public ParticleSystem FinishParticle;
    
    public AudioSource audioSource;
     

     void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }
  void OnTriggerEnter2D(Collider2D other)
  { 
      if(other.gameObject.tag == "Surfer")
      {
        audioSource.Play();
        FinishParticle.Play();
        Invoke("ReloadScene",delay);
      }
  }
   void ReloadScene()
    {
        SceneManager.LoadScene(0);  
    }
}
