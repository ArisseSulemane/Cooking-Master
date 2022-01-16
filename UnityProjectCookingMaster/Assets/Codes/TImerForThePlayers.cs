using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class TImerForThePlayers : MonoBehaviour
{

    //variable of time 
    public static float timePlayerOne,timePlayerTwo;
    public static int timePlayerOne1,timePlayerTwo1;
    //variable of IU element;
    public Text timePlayerOneUI,timePlayerTwoUI,winner, loser;
    public GameObject uIendGame;


    void Start(){
    //initializing time of player one
    timePlayerOne=150; 
    timePlayerTwo=150; 
    }

    public void ResetGame(){
        SceneManager.LoadScene("Level");
    }



    void Update()
    {
    //decreasing time for the player1;
    if(timePlayerOne>0){
     timePlayerOne = timePlayerOne - 1 * Mathf.RoundToInt(Time.deltaTime);
      //converting float decimal to in show in UI
    }
    
     timePlayerOne1=(int)timePlayerOne;  
     timePlayerOneUI.text="Time: "+ timePlayerOne1 +"S";
     //-------------------------------------------------
     if(timePlayerTwo>0){
        //decreasing time for the player2;
     timePlayerTwo = timePlayerOne  -= Time.deltaTime;
     }
   
     //converting float decimal to in show in UI
     timePlayerTwo1=(int)timePlayerTwo;   
     timePlayerTwoUI.text="Time: "+ timePlayerTwo1 +"S";
     if(timePlayerOne<=0 && timePlayerTwo<=0){
     Time.timeScale=0;
     uIendGame.SetActive(true);
     if(PlayerOne.Score>PlayerTwo.Score){
     winner.text="Winner "+PlayerOne.Score +" Player 1";
     loser.text="Loser "+PlayerTwo.Score+" Player 2";  
     }else{
     winner.text="Winner "+PlayerTwo.Score +" Player 2";;
     loser.text="Loser "+PlayerOne.Score +" Player 2";;  
     }

    if(PlayerOne.Score==PlayerTwo.Score){
     winner.text="Score "+PlayerOne.Score +" Player 2";;
     loser.text="Score "+PlayerTwo.Score +" Player 2";;  
     }
           
     }
     }
    }

