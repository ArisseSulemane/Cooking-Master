using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ClientsTimers : MonoBehaviour
{

    public static float timer1,timer2,timer3,timer4,timer5,timerVelocity1,timerVelocity2,timerVelocity3,timerVelocity4,timerVelocity5;
    public static int client,clientWrondSalad1,clientWrondSalad2,clientWrondSalad3,clientWrondSalad4,clientWrondSalad5;
    public Slider slider1,slider2,slider3,slider4,slider5;
    public GameObject [] Clients,ClientsTimeBar,powersUp,clientCollisor;
    public static bool satisfied1,satisfied2,satisfied3,satisfied4,satisfied5,clint1Angry,clint2Angry,clint3Angry,clint4Angry,clint5Angry;
    public List<int> numbersToChooseFrom = new List<int>(new int[]{1,2,3,4,5,6});
    public Text [] angryTextIndicator;
  

    void Start(){
    client = numbersToChooseFrom[Random.Range(0, numbersToChooseFrom.Count)];
    satisfied1=false;
    satisfied2=false;
    satisfied3=false;  
    satisfied4=false;
    satisfied5=false;
    clint1Angry=false;
    clint2Angry=false;
    clint3Angry=false;
    clint4Angry=false;
    clint5Angry=false;
    timerVelocity1=1;
    timerVelocity2=1;
    timerVelocity3=1;
    timerVelocity4=1;
    timerVelocity5=1;
    clientWrondSalad1=0;
    clientWrondSalad2=0;
    clientWrondSalad3=0;
    clientWrondSalad4=0;
    clientWrondSalad5=0;
    } 

    void Update()
    {
    //remove client 1 from list
    if(SaladGive1.GiveSaladClit1==true && SaladGive1.saladCombination==SaladGive1.clientCombination1.ToString() || SaladGive2.GiveSaladClit1==true && SaladGive2.saladCombination==SaladGive2.clientCombination1.ToString()){
    numbersToChooseFrom.Remove(1);
    client = numbersToChooseFrom[Random.Range(0, numbersToChooseFrom.Count)];
    Debug.Log("new client is active");
    SaladGive1.GiveSaladClit1=false;
    SaladGive2.GiveSaladClit1=false;
    }
    
    //remove client 2 from list
    if(SaladGive1.GiveSaladClit2==true && SaladGive1.saladCombination==SaladGive1.clientCombination2.ToString() || SaladGive2.GiveSaladClit2==true && SaladGive2.saladCombination==SaladGive2.clientCombination2.ToString()){
     numbersToChooseFrom.Remove(2);
     client = numbersToChooseFrom[Random.Range(0, numbersToChooseFrom.Count)];
     Debug.Log("new client is active");
     SaladGive1.GiveSaladClit2=false;
     SaladGive2.GiveSaladClit2=false;
    }

    //remove client 3 from list
     if(SaladGive1.GiveSaladClit3==true && SaladGive1.saladCombination==SaladGive1.clientCombination3.ToString() || SaladGive2.GiveSaladClit3==true && SaladGive2.saladCombination==SaladGive2.clientCombination3.ToString()){
     numbersToChooseFrom.Remove(3);
     client = numbersToChooseFrom[Random.Range(0, numbersToChooseFrom.Count)];
     Debug.Log("new client is active");
     SaladGive1.GiveSaladClit3=false;
     SaladGive2.GiveSaladClit3=false;
    }
    
    //remove client 4 from list
    if(SaladGive1.GiveSaladClit4==true && SaladGive1.saladCombination==SaladGive1.clientCombination4.ToString() || SaladGive2.GiveSaladClit4==true && SaladGive2.saladCombination==SaladGive2.clientCombination4.ToString()){
     numbersToChooseFrom.Remove(4);
     client = numbersToChooseFrom[Random.Range(0, numbersToChooseFrom.Count)];
     Debug.Log("new client is active");
     SaladGive1.GiveSaladClit4=false;
     SaladGive2.GiveSaladClit4=false;
    }
    
    //remove client 5 from list
     if(SaladGive1.GiveSaladClit5==true && SaladGive1.saladCombination==SaladGive1.clientCombination5.ToString() || SaladGive2.GiveSaladClit5==true && SaladGive2.saladCombination==SaladGive2.clientCombination5.ToString()){
     numbersToChooseFrom.Remove(5);
     client = numbersToChooseFrom[Random.Range(0, numbersToChooseFrom.Count)];
     Debug.Log("new client is active");
     SaladGive1.GiveSaladClit5=false;
     SaladGive2.GiveSaladClit5=false;
    }
    
    if(client==1)
    {
    timer1=timer1+timerVelocity1*Time.deltaTime;
    slider1.value=timer1;
    clientCollisor[0].GetComponent<BoxCollider> ().enabled=true;
    }
    if(client==2)
    {
    timer2=timer2+timerVelocity2*Time.deltaTime;
    slider2.value=timer2;
    clientCollisor[1].GetComponent<BoxCollider> ().enabled=true;
    }
    if(client==3)
    {
    timer3=timer3+timerVelocity3*Time.deltaTime;
    slider3.value=timer3;
    clientCollisor[2].GetComponent<BoxCollider> ().enabled=true;
    }
    if(client==4)
    {
    timer4=timer4+timerVelocity4*Time.deltaTime;
    slider4.value=timer4;
    clientCollisor[3].GetComponent<BoxCollider> ().enabled=true;
    }
     if(client==5)
    {
    timer5=timer5+timerVelocity5*Time.deltaTime;
    slider5.value=timer5;
    clientCollisor[4].GetComponent<BoxCollider> ().enabled=true;
    }
    //disable clients and penalize players
  /////////////////////////1/////////////////////////////////////////////
    if(satisfied1==false && timer1>=100){
    if(PlayerOne.Score>0){
    PlayerOne.Score=PlayerOne.Score-10;
    }
     if(PlayerTwo.Score>0){
    PlayerTwo.Score=PlayerTwo.Score-10;
    }
    Clients[0].SetActive(false);
    ClientsTimeBar[0].SetActive(false);
    numbersToChooseFrom.Remove(1);
    client = numbersToChooseFrom[Random.Range(0, numbersToChooseFrom.Count)];
    Debug.Log("Client Is Gone");
    angryTextIndicator[0].text="CLIENT IS GONE";
    timer1=0;
    }
    //if client is angry and was failed second time
    if(satisfied1==false && timer1>=100 && clint1Angry==true){
    //decrease  double value on score
    if(PlayerOne.Score>0 && clientWrondSalad1==1){
    PlayerOne.Score=PlayerOne.Score-20;
    }
    if(PlayerTwo.Score>0 && clientWrondSalad5==2){
    PlayerTwo.Score=PlayerTwo.Score-20;
    }
    Clients[0].SetActive(false);
    ClientsTimeBar[0].SetActive(false);
    numbersToChooseFrom.Remove(1);
    client = numbersToChooseFrom[Random.Range(0, numbersToChooseFrom.Count)];
    Debug.Log("Client Is Gone");
    angryTextIndicator[0].text="CLIENT IS GONE";
    timer1=0;
    }
    
///////////////////////2////////////////////////////////
    if(satisfied2==false && timer2>=100){
    if(PlayerOne.Score>0){
    PlayerOne.Score=PlayerOne.Score-10;
    }
     if(PlayerTwo.Score>0){
    PlayerTwo.Score=PlayerTwo.Score-10;
    }
    Clients[1].SetActive(false);
    ClientsTimeBar[1].SetActive(false);
    numbersToChooseFrom.Remove(2);
    client = numbersToChooseFrom[Random.Range(0, numbersToChooseFrom.Count)];
    Debug.Log("Client Is Gone");
    angryTextIndicator[1].text="CLIENT IS GONE";
    timer2=0;
    }
    if(satisfied2==false && timer2>=100 && clint2Angry==true){
     //decrease  double value on score
    if(PlayerOne.Score>0 && clientWrondSalad1==1){
    PlayerOne.Score=PlayerOne.Score-20;
    }
    if(PlayerTwo.Score>0 && clientWrondSalad5==2){
    PlayerTwo.Score=PlayerTwo.Score-20;
    }
    Clients[1].SetActive(false);
    ClientsTimeBar[1].SetActive(false);
    numbersToChooseFrom.Remove(2);
    client = numbersToChooseFrom[Random.Range(0, numbersToChooseFrom.Count)];
    Debug.Log("Client Is Gone");
    angryTextIndicator[1].text="CLIENT IS GONE";
    timer2=0;
    }
//////////////////3//////////////////////////////////////////////
    if(satisfied3==false && timer3>=100){
    if(PlayerOne.Score>0){
    PlayerOne.Score=PlayerOne.Score-10;
    }
     if(PlayerTwo.Score>0){
    PlayerTwo.Score=PlayerTwo.Score-10;
    }
    Clients[2].SetActive(false);
    ClientsTimeBar[2].SetActive(false);
    numbersToChooseFrom.Remove(3);
    client = numbersToChooseFrom[Random.Range(0, numbersToChooseFrom.Count)];
    Debug.Log("Client Is Gone");
    angryTextIndicator[2].text="CLIENT IS GONE";
    timer3=0;
    }

  if(satisfied3==false && timer3>=100 && clint3Angry==true){
    if(PlayerOne.Score>0 && clientWrondSalad2==1){
    PlayerOne.Score=PlayerOne.Score-20;
    }
    if(PlayerTwo.Score>0 && clientWrondSalad5==2){
    PlayerTwo.Score=PlayerTwo.Score-20;
    }
    Clients[2].SetActive(false);
    ClientsTimeBar[2].SetActive(false);
    numbersToChooseFrom.Remove(3);
    client = numbersToChooseFrom[Random.Range(0, numbersToChooseFrom.Count)];
    Debug.Log("Client Is Gone");
    angryTextIndicator[2].text="CLIENT IS GONE";
    timer3=0;
    }
///////////////////////4/////////////////////////////////////////////////////////////////////
    if(satisfied4==false && timer4>=100){
    if(PlayerOne.Score>0 && clientWrondSalad3==1){
    PlayerOne.Score=PlayerOne.Score-20;
    }
     if(PlayerTwo.Score>0){
    PlayerTwo.Score=PlayerTwo.Score-10;
    }
    if(PlayerOne.Score>0 && clientWrondSalad3==2){
    PlayerOne.Score=PlayerOne.Score-20;
    }
    Clients[3].SetActive(false);
    ClientsTimeBar[3].SetActive(false);
    numbersToChooseFrom.Remove(4);
    client = numbersToChooseFrom[Random.Range(0, numbersToChooseFrom.Count)];
    Debug.Log("Client Is Gone");
    angryTextIndicator[3].text="CLIENT IS GONE";
    timer4=0;
    }

    if(satisfied4==false && timer4>=100 && clint4Angry==true){
     if(PlayerOne.Score>0 && clientWrondSalad4==1){
    PlayerOne.Score=PlayerOne.Score-20;
    }
   if(PlayerTwo.Score>0 && clientWrondSalad5==2){
    PlayerTwo.Score=PlayerTwo.Score-20;
    }
    Clients[3].SetActive(false);
    ClientsTimeBar[3].SetActive(false);
    numbersToChooseFrom.Remove(4);
    client = numbersToChooseFrom[Random.Range(0, numbersToChooseFrom.Count)];
    Debug.Log("Client Is Gone");
    angryTextIndicator[3].text="CLIENT IS GONE";
    timer4=0;
    }
  //////////////////////5////////////////////////////////////////////////////////////////  
    if(satisfied5==false && timer5>=100){
    if(PlayerOne.Score>0){
    PlayerOne.Score=PlayerOne.Score-10;
    }
     if(PlayerTwo.Score>0){
    PlayerTwo.Score=PlayerTwo.Score-10;
    }
    Clients[4].SetActive(false);
    ClientsTimeBar[4].SetActive(false);
    numbersToChooseFrom.Remove(5);
    client = numbersToChooseFrom[Random.Range(0, numbersToChooseFrom.Count)];
    Debug.Log("Client Is Gone");
    angryTextIndicator[4].text="CLIENT IS GONE";
    timer5=0;
    }

    if(satisfied5==false && timer5>=100 && clint5Angry==true){
    if(PlayerOne.Score>0 && clientWrondSalad5==1){
    PlayerOne.Score=PlayerOne.Score-20;
    }
    if(PlayerTwo.Score>0 && clientWrondSalad5==2){
    PlayerTwo.Score=PlayerTwo.Score-20;
    }
    Clients[4].SetActive(false);
    ClientsTimeBar[4].SetActive(false);
    numbersToChooseFrom.Remove(5);
    client = numbersToChooseFrom[Random.Range(0, numbersToChooseFrom.Count)];
    Debug.Log("Client Is Gone");
    angryTextIndicator[4].text="CLIENT IS GONE";
    timer5=0;
    }



    // SATISFIED CLIENTS
    if(satisfied1==true && timer1<=100){
         //enable powers on scene
      if(satisfied1==true && timer1<=70 && clientWrondSalad1==1){
      powersUp[0].SetActive(true);
      powersUp[1].SetActive(true);
      powersUp[2].SetActive(true);
      }
       if(satisfied1==true && timer1<=70 && clientWrondSalad1==2){
      powersUp[3].SetActive(true);
      powersUp[4].SetActive(true);
      powersUp[5].SetActive(true);
      }
    ClientsTimeBar[0].SetActive(false);
    numbersToChooseFrom.Remove(1);
    client = numbersToChooseFrom[Random.Range(0, numbersToChooseFrom.Count)];
    timer1=0;
    SaladGive1.ResetAll();
    satisfied1=false;
    }
    if(satisfied2==true && timer2<=100){
         //enable powers on scene
      if(satisfied2==true && timer2<=70 && clientWrondSalad2==1){
      powersUp[0].SetActive(true);
      powersUp[1].SetActive(true);
      powersUp[2].SetActive(true);
      }
      
      if(satisfied2==true && timer2<=70 && clientWrondSalad2==2){
      powersUp[3].SetActive(true);
      powersUp[4].SetActive(true);
      powersUp[5].SetActive(true);
      }

    ClientsTimeBar[1].SetActive(false);
    numbersToChooseFrom.Remove(2);
    client = numbersToChooseFrom[Random.Range(0, numbersToChooseFrom.Count)];
    timer2=0;
    SaladGive1.ResetAll();
    satisfied2=false;
    }
    if(satisfied3==true && timer3<=100){
         //enable powers on scene
      if(satisfied3==true && timer3<=70 && clientWrondSalad3==1){
      powersUp[0].SetActive(true);
      powersUp[1].SetActive(true);
      powersUp[2].SetActive(true);
      }
       if(satisfied3==true && timer3<=70 && clientWrondSalad3==2){
      powersUp[3].SetActive(true);
      powersUp[4].SetActive(true);
      powersUp[5].SetActive(true);
      }

    ClientsTimeBar[2].SetActive(false);
    numbersToChooseFrom.Remove(3);
    client = numbersToChooseFrom[Random.Range(0, numbersToChooseFrom.Count)];
    timer3=0;
    SaladGive1.ResetAll();
    satisfied3=false;
    }
    if(satisfied4==true && timer4<=100){
         //enable powers on scene
      if(satisfied4==true && timer4<=70  && clientWrondSalad4==1){
      powersUp[0].SetActive(true);
      powersUp[1].SetActive(true);
      powersUp[2].SetActive(true);
      }
        if(satisfied4==true && timer4<=70 && clientWrondSalad4==2){
      powersUp[3].SetActive(true);
      powersUp[4].SetActive(true);
      powersUp[5].SetActive(true);
      }
    ClientsTimeBar[3].SetActive(false);
    numbersToChooseFrom.Remove(4);
    client = numbersToChooseFrom[Random.Range(0, numbersToChooseFrom.Count)];
    timer4=0;
    SaladGive1.ResetAll();
    satisfied4=false;
    }
    if(satisfied5==true && timer5<=100){
         //enable powers on scene
      if(satisfied5==true && timer5<=70 && clientWrondSalad5==1){
      powersUp[0].SetActive(true);
      powersUp[1].SetActive(true);
      powersUp[2].SetActive(true);
      }
        if(satisfied5==true && timer5<=70 && clientWrondSalad5==2){
      powersUp[3].SetActive(true);
      powersUp[4].SetActive(true);
      powersUp[5].SetActive(true);
      }
    ClientsTimeBar[4].SetActive(false);
    numbersToChooseFrom.Remove(5);
    client = numbersToChooseFrom[Random.Range(0, numbersToChooseFrom.Count)];
    timer5=0;
    SaladGive1.ResetAll();
    satisfied5=false;
    }


   
    }


}
