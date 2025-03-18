using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class GameController : MonoBehaviour
{
    public static GameController instance;
    public static int score=0;
    public Text display;
    public GameObject button;
    int maxScore=4;
    
    
    void Start()
    {
        if (SceneManager.GetActiveScene().name=="Level2"){
            score=0;
            maxScore=6;
            display.text="Score:"+score;
        }
        if (instance==null){
            instance=this;
        }
        button.SetActive(false);
    }
    public void updateScore(){
        score++;
        display.text="Score:"+score;
    }
    void Update(){
        if (score==maxScore){
            Debug.Log("you have won!");
            button.SetActive(true);
            display.text = "You won!";
        }
    }
    public void nextLevel(){
        SceneManager.LoadScene("Level2");
    }
    
}