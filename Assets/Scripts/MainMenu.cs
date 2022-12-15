using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class MainMenu : MonoBehaviour
{
    int current = 1;
    int total = 0;
    
    // Start is called before the first frame update
    public void PlayGame(){

        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + current);
        SceneManager.LoadScene("NewMap");
    }

    public void Credit(){

        //SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + current);
        SceneManager.LoadScene("Credits");
    }

     public void Tutorial(){

        Debug.Log("Quit Game");
        SceneManager.LoadScene("Tutorial");
    }

    // public Update(){
    //     prev = SceneManager.GetActiveScene().buildIndex;

    // }

    public void NextLevel(){
        current++;
        total++;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + current);
    }

    public void QuitGame(){
        current=0;
        total=0;
        Debug.Log("Quit Game");
        Application.Quit();
    }

    public void ResetGame(){
        current=0;
        total=0;
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}
