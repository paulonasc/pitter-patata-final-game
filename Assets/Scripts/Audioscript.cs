using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Audioscript : MonoBehaviour
{  
    public AudioSource audioSource;
    public AudioClip collect;
    public AudioClip die;
    public static bool collected;
    public static bool dead;

    //public AudioClip stageStart;
    //public AudioClip gameOver;
    //public AudioClip stageClear;
    //public AudioClip intro;
    //ublic AudioClip littleTime;


    void Start()
    {
        audioSource = GetComponent<AudioSource>();
        
    }
    void Update(){
        if (collected){
            Collect();
            collected = false;
        }
        if (dead){
            Die();
            dead = false;
        }
    }
    void Collect(){
        audioSource.clip = collect;
        audioSource.Play();
    }
    void Die(){
        audioSource.clip = die;
        audioSource.Play();
    }
   
    
}
