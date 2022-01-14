using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaladControl : MonoBehaviour
{
   
   //bool variables to contol wich slot is being used
   public static bool aux,picked1Player1,picked2Player1,picked3Player1,chopVeg,secondVegetable,thirdVegetable;
   //bool variables to contol wich vegetable player picked
   public static int  vegetableIndex,vegectable1,vegectable2,vegectable3,chopVegSlot,vegetablesCounter,chopcount;
   public Sprite a,b,c,d,e,f,empty;
   public Image image1,image2;
   public  static float timeChop;
   public GameObject timerUI;
   public Slider playerOneTimerChopUI;
   public GameObject [] SaladMix; 
   public Sprite [] spritesIndex;

   void Start(){
   picked1Player1=false;
   picked2Player1=false;
   picked3Player1=false;
   thirdVegetable=false;
   thirdVegetable=false;
   secondVegetable=false;
   vegectable1=0;
   vegectable2=0;
   vegectable3=0;
   timeChop=0;
   chopVegSlot=0;
   chopcount=0;
   vegetablesCounter=0;
   vegetableIndex=0;
   aux=false;
   }
    
    void Update(){
    //the timerUI will appear now
    if(timeChop<=5 && chopVeg==true){
    timeChop=timeChop+1*Time.deltaTime;
    timerUI.SetActive(true);
    //move slide bar to show UI progress of the chop
    playerOneTimerChopUI.value=timeChop;
    //disable move script for the player not move around
    gameObject.GetComponent<PlayerOne>().enabled = false;
    }
    //if timer be iqual 0 increse more 5 time
    if(timeChop>=5){
    //enable true to player move again
    //reset timer to 0
    playerOneTimerChopUI.value=0;
    //hide UI info timer
    timerUI.SetActive(false); 
    //Enable again player moviment   
    gameObject.GetComponent<PlayerOne>().enabled = true;
    chopVeg=false; 
    if(chopVegSlot==1){
    image1.GetComponent<Image> ().sprite = empty;
    chopcount=chopcount+1;
    timeChop=0;
    }else{
    image2.GetComponent<Image> ().sprite = empty;
    chopcount=chopcount+1;
    timeChop=0;
    chopVegSlot=0;
    }
    //enable salad in the plate
    if(chopcount==1){
    SaladMix[vegectable1].SetActive(true);
    }
     if(chopcount==2){
    SaladMix[vegectable1].SetActive(true);
    SaladMix[vegectable2].SetActive(true);
    }
     if(chopcount==3){
    SaladMix[vegectable1].SetActive(true);
    SaladMix[vegectable2].SetActive(true);
    SaladMix[vegectable3].SetActive(true);
    }
    }

    //put new vegetable in UI
    if(picked1Player1==true && aux==false){
    vegectable1=vegetableIndex;
    image1.GetComponent<Image> ().sprite = spritesIndex[vegetableIndex];
    vegetableIndex=0;
    picked1Player1=false;
    aux=true;
    picked2Player1=false;
    }
     if(picked2Player1==true && aux==false){
    vegectable2=vegetableIndex;
    image2.GetComponent<Image> ().sprite = spritesIndex[vegetableIndex];
    vegetableIndex=0;
    picked2Player1=false;
    aux=true;
    picked3Player1=true;
    }

    if(picked3Player1==true){
    vegectable3=vegetableIndex;
    image1.GetComponent<Image> ().sprite = spritesIndex[vegetableIndex];
    vegetableIndex=0;
    picked3Player1=false;
    }
    }

  void OnTriggerStay(Collider col){
  //verify if slot one is empty to take one vegetable
  if(picked1Player1=true  && Input.GetKeyDown("e")){
  //verify name of the vegetable to take
  if(col.gameObject.tag == "a"){
  vegetableIndex=1;
  picked1Player1=true;
  aux=false;
  }

   if(col.gameObject.tag == "b"){
  //verify name of the vegetable to take
  vegetableIndex=2;
  picked1Player1=true;
  aux=false;
  }
   if(col.gameObject.tag == "c"){
  //verify name of the vegetable to take
  vegetableIndex=3;
  picked1Player1=true;
  aux=false;
  }
  if(col.gameObject.tag == "d"){
  //verify name of the vegetable to take
  vegetableIndex=4;
  picked1Player1=true;
  aux=false;
  }
   if(col.gameObject.tag == "e"){
  //verify name of the vegetable to take
   vegetableIndex=5;
   picked1Player1=true;
   aux=false;
  }
   if(col.gameObject.tag == "f"){
  //verify name of the vegetable to take
  vegetableIndex=6;
  picked1Player1=true;
  aux=false;
  }

 //verify if slot one is empty to take one vegetable
  if(picked2Player1==true && Input.GetKeyDown("e")){
  //verify name of the vegetable to take
  if(col.gameObject.tag == "a"){
  vegetableIndex=1;
  picked2Player1=true;
  aux=false;
  }

   if(col.gameObject.tag == "b"){
  //verify name of the vegetable to take
  picked2Player1=true;
  vegetableIndex=2;
  aux=false;
  }
   if(col.gameObject.tag == "c"){
  //verify name of the vegetable to take
  picked2Player1=true;
  vegetableIndex=3;
  aux=false;
  }
  if(col.gameObject.tag == "d"){
  //verify name of the vegetable to take
  picked2Player1=true;
  vegetableIndex=4;
  aux=false;
  }
   if(col.gameObject.tag == "e"){
  //verify name of the vegetable to take
  picked2Player1=true;
  vegetableIndex=5;
  aux=false;
  }
   if(col.gameObject.tag == "f"){
  //verify name of the vegetable to take
  picked2Player1=true;
  vegetableIndex=6;
  aux=false;
  }
  }


 //if player stay in the table and press e will disable the moviments for while and will start chopveg
  if(chopVeg==false){
  if (col.gameObject.tag == "table1" && Input.GetKeyDown("e")){
  if(vegetablesCounter==2){
  thirdVegetable=true;
  }
  chopVegSlot=chopVegSlot+1;
  chopVeg=true;
  }
  }
  }
 
  
 
  }
}

