using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ClientsTimers : MonoBehaviour
{

    public float timer1,timer2,timer3,timer4,timer5;
    public int client;
    public Slider slider1,slider2,slider3,slider4,slider5;
    public GameObject [] Clients;
    public static bool satisfied1,satisfied2,satisfied3,satisfied4,satisfied5;

    void Start(){
    client = Random.Range (0,6);
    satisfied1=false;
    satisfied2=false;
    satisfied3=false;
    satisfied4=false;
    satisfied5=false;
    }

    void Update()
    {
    if(client==1)
    {
    timer1=timer1+1*Time.deltaTime;
    slider1.value=timer1;
    }
    if(client==2)
    {
    timer2=timer2+1*Time.deltaTime;
    slider2.value=timer2;
    }
    if(client==3)
    {
    timer3=timer3+1*Time.deltaTime;
    slider3.value=timer3;
    }
    if(client==4)
    {
    timer4=timer4+1*Time.deltaTime;
    slider4.value=timer4;
    }
     if(client==5)
    {
    timer5=timer5+1*Time.deltaTime;
    slider5.value=timer5;
    }
    //disable clients and penalize players
    if(satisfied1==false && timer1>=50){
    if(PlayerOne.Score>0){
    PlayerOne.Score=PlayerOne.Score-10;
    }
    Clients[0].SetActive(false);
    Debug.Log("Client Is Gone");
    }

    if(satisfied2==false && timer2>=50){
    if(PlayerOne.Score>0){
    PlayerOne.Score=PlayerOne.Score-10;
    }
    Clients[1].SetActive(false);
    Debug.Log("Client Is Gone");
    }

    if(satisfied3==false && timer3>=50){
    if(PlayerOne.Score>0){
    PlayerOne.Score=PlayerOne.Score-10;
    }
    Clients[2].SetActive(false);
    Debug.Log("Client Is Gone");
    }

    if(satisfied4==false && timer4>=50){
    if(PlayerOne.Score>0){
    PlayerOne.Score=PlayerOne.Score-10;
    }
    Clients[3].SetActive(false);
    Debug.Log("Client Is Gone");
    }
    
    if(satisfied5==false && timer5>=50){
    if(PlayerOne.Score>0){
    PlayerOne.Score=PlayerOne.Score-10;
    }
    Clients[4].SetActive(false);
    Debug.Log("Client Is Gone");
    }

    }


}
