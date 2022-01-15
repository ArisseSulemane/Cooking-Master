using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powers : MonoBehaviour
{
   
    public static string PlayerPrevilege;
    public bool speed,score,time;
    

    void Start(){
    PlayerPrevilege="";
    }

    void OnTriggerStay(Collider col){
    //speed
    if(col.gameObject.tag == "Player1" && speed==true){ 
    PlayerOne.velocityTimer=10;
    PlayerPrevilege="1";
    gameObject.SetActive(false);
    }
    //score
    if(col.gameObject.tag == "Player1" && score==true){
    PlayerOne.Score=PlayerOne.Score+20;
    PlayerPrevilege="1";
    gameObject.SetActive(false);
    }
    //time
    if(col.gameObject.tag == "Player1" && time==true){
    TImerForThePlayers.timePlayerOne=TImerForThePlayers.timePlayerOne+20;
    PlayerPrevilege="1";
    gameObject.SetActive(false);
    }
    
    }
  


}
