using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powers1 : MonoBehaviour
{
   
  
    public bool speed,score,time;

    void OnTriggerStay(Collider col){
     //speed
     if(col.gameObject.tag == "Player2" && speed==true){ 
    PlayerTwo.velocityTimer=10;
    gameObject.SetActive(false);
    }
    //score
    if(col.gameObject.tag == "Player2" && score==true){
    PlayerTwo.Score=PlayerTwo.Score+20;
    gameObject.SetActive(false);
    }
    //time
    if(col.gameObject.tag == "Player2" && time==true){
    TImerForThePlayers.timePlayerTwo=TImerForThePlayers.timePlayerTwo+20;
    gameObject.SetActive(false);
    }    
    }

}
