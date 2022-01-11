using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class TImerForThePlayers : MonoBehaviour
{

    //variable of time 
    static float timePlayerOne,timePlayerTwo;
    static int timePlayerOne1,timePlayerTwo1;
    //variable of IU element;
    public Text timePlayerOneUI,timePlayerTwoUI;
    void Start(){
    //initializing time of player one
    timePlayerOne=150; 
    timePlayerTwo=150; 
    }
    void Update()
    {
    //decreasing time for the player1;
     timePlayerOne = timePlayerOne - 1 * Mathf.RoundToInt(Time.deltaTime);
      //converting float decimal to in show in UI
     timePlayerOne1=(int)timePlayerOne;  
     timePlayerOneUI.text="Time: "+ timePlayerOne1 +"S";
     //-------------------------------------------------
      //decreasing time for the player2;
     timePlayerTwo = timePlayerOne  -= Time.deltaTime;
     //converting float decimal to in show in UI
     timePlayerTwo1=(int)timePlayerTwo;   
     timePlayerTwoUI.text="Time: "+ timePlayerTwo1 +"S";
    }
}
