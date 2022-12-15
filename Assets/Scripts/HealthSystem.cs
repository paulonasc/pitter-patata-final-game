using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthSystem : MonoBehaviour
{

    public static int health;
    public static int max_health;

    public Image[] hearts = new Image[4];
    public Sprite redHeart;
    public Sprite BlackHeart;

    public EndGame EndGame;

    void Start()
    {
        health = 4;
        max_health = 4;
    }

    void Update()
    {
        for(int i = 0; i < hearts.Length; i ++)
        {
            if(i < health)
            {
                hearts[i].sprite = redHeart;
            }
            else
            {
                hearts[i].sprite = BlackHeart;
            }
            if(i < max_health)
            {
                hearts[i].enabled = true;
            }
            else
            {
                hearts[i].enabled = false;
            }
        }
        
        
    }

    public static void AddLife()
    {
        if(health < max_health)
        {
            ++health;
        }
    }
    public static void MinusLife()
    {
        if(health > 0)
        {   
            Audioscript.dead = true;
            --health;
            
            if (health == 0){
                EndGame.gameOver();
            }
        }
        
    }
}
