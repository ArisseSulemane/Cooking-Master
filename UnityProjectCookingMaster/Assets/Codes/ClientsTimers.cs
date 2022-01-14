using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class ClientsTimers : MonoBehaviour
{

    public float timer1,timer2,timer3,timer4,timer5;
    public int client;
    public Slider slider1,slider2,slider3,slider4,slider5;
    public GameObject [] Clients,ClientsTimeBar;
    public static bool satisfied1,satisfied2,satisfied3,satisfied4,satisfied5;
    public List<int> numbersToChooseFrom = new List<int>(new int[]{1,2,3,4,5});

    void Start(){
    client = numbersToChooseFrom[Random.Range(0, numbersToChooseFrom.Count)];
    satisfied1=false;
    satisfied2=false;
    satisfied3=false;
    satisfied4=false;
    satisfied5=false;
    }

    void Update()
    {
    //remove client 1 from list
    if(SaladGive1.GiveSaladClit1==true && SaladGive1.saladCombination==SaladGive1.clientCombination1.ToString()){
    numbersToChooseFrom.Remove(1);
    client = numbersToChooseFrom[Random.Range(0, numbersToChooseFrom.Count)];
    Debug.Log("new client is active");
    SaladGive1.GiveSaladClit1=false;
    //reset all status of SaladControl
     SaladControl.picked1Player1=true;
     SaladControl.picked2Player1=false;
     SaladControl.picked3Player1=false;
     SaladControl.thirdVegetable=false;
     SaladControl.vegectable1=0;
     SaladControl.vegectable2=0;
     SaladControl.vegectable3=0;
     SaladControl.timeChop=0;
     SaladControl.chopVegSlot=0;
     SaladControl.chopcount=0;
     SaladControl.vegetablesCounter=0;
    }
      //remove client 2 from list
    if(SaladGive1.GiveSaladClit2==true && SaladGive1.saladCombination==SaladGive1.clientCombination2.ToString()){
    numbersToChooseFrom.Remove(2);
    client = numbersToChooseFrom[Random.Range(0, numbersToChooseFrom.Count)];
     Debug.Log("new client is active");
     SaladGive1.GiveSaladClit2=false;
      //reset all status of SaladControl
     SaladControl.picked1Player1=true;
     SaladControl.picked2Player1=false;
     SaladControl.picked3Player1=false;
     SaladControl.thirdVegetable=false;
     SaladControl.vegectable1=0;
     SaladControl.vegectable2=0;
     SaladControl.vegectable3=0;
     SaladControl.timeChop=0;
     SaladControl.chopVegSlot=0;
     SaladControl.chopcount=0;
     SaladControl.vegetablesCounter=0;
    }
      //remove client 1 from list
     if(SaladGive1.GiveSaladClit3==true && SaladGive1.saladCombination==SaladGive1.clientCombination3.ToString()){
     numbersToChooseFrom.Remove(3);
     client = numbersToChooseFrom[Random.Range(0, numbersToChooseFrom.Count)];
     Debug.Log("new client is active");
     SaladGive1.GiveSaladClit3=false;
      //reset all status of SaladControl
     SaladControl.picked1Player1=true;
     SaladControl.picked2Player1=false;
     SaladControl.picked3Player1=false;
     SaladControl.thirdVegetable=false;
     SaladControl.vegectable1=0;
     SaladControl.vegectable2=0;
     SaladControl.vegectable3=0;
     SaladControl.timeChop=0;
     SaladControl.chopVegSlot=0;
     SaladControl.chopcount=0;
     SaladControl.vegetablesCounter=0;
    }
      //remove client 1 from list
    if(SaladGive1.GiveSaladClit4==true && SaladGive1.saladCombination==SaladGive1.clientCombination4.ToString()){
     numbersToChooseFrom.Remove(4);
     client = numbersToChooseFrom[Random.Range(0, numbersToChooseFrom.Count)];
     Debug.Log("new client is active");
     SaladGive1.GiveSaladClit4=false;
      //reset all status of SaladControl
     SaladControl.picked1Player1=true;
     SaladControl.picked2Player1=false;
     SaladControl.picked3Player1=false;
     SaladControl.thirdVegetable=false;
     SaladControl.vegectable1=0;
     SaladControl.vegectable2=0;
     SaladControl.vegectable3=0;
     SaladControl.timeChop=0;
     SaladControl.chopVegSlot=0;
     SaladControl.chopcount=0;
     SaladControl.vegetablesCounter=0;
    }
      //remove client 1 from list
     if(SaladGive1.GiveSaladClit5==true && SaladGive1.saladCombination==SaladGive1.clientCombination5.ToString()){
     numbersToChooseFrom.Remove(5);
     client = numbersToChooseFrom[Random.Range(0, numbersToChooseFrom.Count)];
     Debug.Log("new client is active");
     SaladGive1.GiveSaladClit5=false;
      //reset all status of SaladControl
     SaladControl.picked1Player1=true;
     SaladControl.picked2Player1=false;
     SaladControl.picked3Player1=false;
     SaladControl.thirdVegetable=false;
     SaladControl.vegectable1=0;
     SaladControl.vegectable2=0;
     SaladControl.vegectable3=0;
     SaladControl.timeChop=0;
     SaladControl.chopVegSlot=0;
     SaladControl.chopcount=0;
     SaladControl.vegetablesCounter=0;
     SaladControl.thirdVegetable=false;
    }
    
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
    ClientsTimeBar[0].SetActive(false);
    numbersToChooseFrom.Remove(1);
    client = numbersToChooseFrom[Random.Range(0, numbersToChooseFrom.Count)];
    Debug.Log("Client Is Gone");
    timer1=0;
    }

    if(satisfied2==false && timer2>=50){
    if(PlayerOne.Score>0){
    PlayerOne.Score=PlayerOne.Score-10;
    }
    Clients[1].SetActive(false);
    ClientsTimeBar[1].SetActive(false);
    numbersToChooseFrom.Remove(2);
    client = numbersToChooseFrom[Random.Range(0, numbersToChooseFrom.Count)];
    Debug.Log("Client Is Gone");
    timer2=0;
    }

    if(satisfied3==false && timer3>=50){
    if(PlayerOne.Score>0){
    PlayerOne.Score=PlayerOne.Score-10;
    }
    Clients[2].SetActive(false);
    ClientsTimeBar[2].SetActive(false);
    numbersToChooseFrom.Remove(3);
    client = numbersToChooseFrom[Random.Range(0, numbersToChooseFrom.Count)];
    Debug.Log("Client Is Gone");
    timer3=0;
    }

    if(satisfied4==false && timer4>=50){
    if(PlayerOne.Score>0){
    PlayerOne.Score=PlayerOne.Score-10;
    }
    Clients[3].SetActive(false);
    ClientsTimeBar[3].SetActive(false);
    numbersToChooseFrom.Remove(4);
    client = numbersToChooseFrom[Random.Range(0, numbersToChooseFrom.Count)];
    Debug.Log("Client Is Gone");
    timer4=0;
    }
    
    if(satisfied5==false && timer5>=50){
    if(PlayerOne.Score>0){
    PlayerOne.Score=PlayerOne.Score-10;
    }
    Clients[4].SetActive(false);
    ClientsTimeBar[4].SetActive(false);
    numbersToChooseFrom.Remove(5);
    client = numbersToChooseFrom[Random.Range(0, numbersToChooseFrom.Count)];
    Debug.Log("Client Is Gone");
    timer5=0;
    }

    }


}
