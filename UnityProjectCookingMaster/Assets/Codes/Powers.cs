using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Powers : MonoBehaviour
{
   
    public static int PlayerPrevilege;
    public bool speed,score,time;
    

    void Start(){
    PlayerPrevilege=0;
    }

    void OnTriggerEnter(Collider col){
    //speed
    if(col.gameObject.tag == "Player1" && speed==true  && PlayerPrevilege==1){
    PlayerOne.velocityTimer=10;
    PlayerPrevilege=0;
    gameObject.SetActive(false);
    }
    //score
    if(col.gameObject.tag == "Player1" && score==true  && PlayerPrevilege==1){
    PlayerOne.Score=PlayerOne.Score+20;
    PlayerPrevilege=0;
    gameObject.SetActive(false);
    }
    //time
     if(col.gameObject.tag == "Player1" && time==true  && PlayerPrevilege==1){
    TImerForThePlayers.timePlayerOne=TImerForThePlayers.timePlayerOne+20;
    PlayerPrevilege=0;
    gameObject.SetActive(false);
    }
    }
  


}
