using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ClientsTimers : MonoBehaviour
{

    public float timer1,timer2,timer3,timer4;
    public int client;
    public Slider slider1,slider2,slider3,slider4;	
    void Start(){
    client = Random.Range (1,5);  
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

    }


}
