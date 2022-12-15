using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class EndGame : MonoBehaviour
{
    
    public void NewGame(){
        SceneManager.LoadScene("NewMap");
    }

    public void StopGame(){

        Debug.Log("Quit Game");
        SceneManager.LoadScene("StartScene");
    }
    
    public static void gameOver(){
        SceneManager.LoadScene(3);
        //GameOver.Setup();
    }
    //public Text pointsText;
    //public static void Setup(){
        //gameObject.SetActive(true);
        //pointsText.score.Tostring() + " potatoes saved"
    //}
    public void Stage2()
    {
        SceneManager.LoadScene("Basement");
    }
    public void nextStage()
    {
        SceneManager.LoadScene("NewMap");
    }
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
