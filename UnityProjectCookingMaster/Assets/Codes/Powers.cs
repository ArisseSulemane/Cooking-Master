using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powers : MonoBehaviour
{
   
  
    public bool speed,score,time;

   

    void OnTriggerStay(Collider col){
     //speed
     if(col.gameObject.tag == "Player1" && speed==true){ 
    PlayerOne.velocityTimer=10;
    gameObject.SetActive(false);
    }
    //score
    if(col.gameObject.tag == "Player1" && score==true){
    PlayerOne.Score=PlayerOne.Score+20;
    gameObject.SetActive(false);
    }
    //time
    if(col.gameObject.tag == "Player1" && time==true){
    TImerForThePlayers.timePlayerOne=TImerForThePlayers.timePlayerOne+20;
    gameObject.SetActive(false);
    }    
    }

}
