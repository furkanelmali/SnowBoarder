using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Crash : MonoBehaviour
{
    public float delay = 1f;
    public ParticleSystem CrashParticle;
    public AudioSource audioSource;

    PlayerController pc;

     void Start()
    {
        audioSource = GetComponent<AudioSource>();
        pc = FindObjectOfType<PlayerController>();
    }
    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.tag == "Ground")
        {
            pc.disableControl();
            audioSource.Play();
            CrashParticle.Play();
            Invoke("ReloadScene",delay);
        }
    }

    void ReloadScene()
    {
        SceneManager.LoadScene(0);  
    }

}
