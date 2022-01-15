using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaladControl : MonoBehaviour
{
   
   //bool variables to contol wich slot is being used
   public static bool picked1Player1,picked2Player1,picked3Player1,chopVeg,secondVegetable,thirdVegetable;
   //bool variables to contol wich vegetable player picked
   public static int  slot,vegetableIndex,vegectable1,vegectable2,vegectable3,chopVegSlot,vegetablesCounter,chopcount;
   public Sprite a,b,c,d,e,f,empty;
   public Image image1,image2;
   public  static float timeChop;
   public GameObject timerUI,PlateCheffTable;
   public Slider playerOneTimerChopUI;
   public GameObject [] SaladMix; 
   public Sprite [] spritesIndex;

   void Start(){
   picked1Player1=true;
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
   slot=0;
   }
    
    void Update(){
    //if no vegetable selected, then plate has to be empty and disabled for iterration
    if(slot==0){
    PlateCheffTable.GetComponent<BoxCollider> ().enabled = false;
    }else{
    //if is vegetable selected, then plate has to be ready and enabled for iterration
    PlateCheffTable.GetComponent<BoxCollider> ().enabled = true; 
    }

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
    if(picked1Player1==true && slot==1){
    vegectable1=vegetableIndex;
    image1.GetComponent<Image> ().sprite = spritesIndex[vegetableIndex];
    vegetableIndex=0;
    Debug.Log("slot1 active"+picked1Player1);
    picked1Player1=false;
    picked2Player1=true;
    }

     if(picked2Player1==true && slot==2){
    vegectable2=vegetableIndex;
    image2.GetComponent<Image> ().sprite = spritesIndex[vegetableIndex];
    vegetableIndex=0;
    Debug.Log("slot2 active"+picked1Player1);
    picked1Player1=false;
    picked2Player1=false;
    picked3Player1=true;
    }

    if(picked3Player1==true && slot==3){
    vegectable3=vegetableIndex;
    image1.GetComponent<Image> ().sprite = spritesIndex[vegetableIndex];
    vegetableIndex=0;
    Debug.Log("slot3 active"+picked1Player1);
    picked1Player1=false;
    picked2Player1=false;
    picked3Player1=false;
    }
    }

  void OnTriggerStay(Collider col){
  //verify if slot one is empty to take one vegetable
  if(picked1Player1==true && slot==0 && Input.GetKeyUp("e")){
  //verify name of the vegetable to take
   if(col.gameObject.tag == "a" && vegectable1==0){
   vegetableIndex=1;
   picked1Player1=true;
   slot=1;
   Debug.Log("take one active");
  }
   if(col.gameObject.tag == "b" &&  vegectable1==0){
  //verify name of the vegetable to take
  vegetableIndex=2;
  picked1Player1=true;
  slot=1;
   Debug.Log("take one active");
  }
   if(col.gameObject.tag == "c" &&  vegectable1==0){
  //verify name of the vegetable to take
  vegetableIndex=3;
  picked1Player1=true;
  slot=1;
   Debug.Log("take one active");
  }
  if(col.gameObject.tag == "d"  &&  vegectable1==0){
  //verify name of the vegetable to take
  vegetableIndex=4;
  picked1Player1=true;
  slot=1;
   Debug.Log("take one active");
  }
   if(col.gameObject.tag == "e"  &&  vegectable1==0){
  //verify name of the vegetable to take
   vegetableIndex=5;
   picked1Player1=true;
   slot=1;
    Debug.Log("take one active");
  }
   if(col.gameObject.tag == "f"  &&  vegectable1==0){
  //verify name of the vegetable to take
  vegetableIndex=6;
  picked1Player1=true;
  slot=1;
   Debug.Log("take one active");
  }
  }

//======================================================
 //verify if slot one is empty to take one vegetable
  if(picked2Player1==true && slot==1 && Input.GetKeyUp("e")){
    
  //verify name of the vegetable to take
  if(col.gameObject.tag == "a"  &&  vegectable2==0){
  vegetableIndex=1;
  picked2Player1=true;
  slot=2;
   Debug.Log("take two active");
  }
   if(col.gameObject.tag == "b" &&  vegectable2==0){
  //verify name of the vegetable to take
  vegetableIndex=2;
   picked2Player1=true;
  slot=2;
   Debug.Log("take two active");
  }
   if(col.gameObject.tag == "c" &&  vegectable2==0){
  //verify name of the vegetable to take
  vegetableIndex=3;
   picked2Player1=true;
  slot=2;
   Debug.Log("take two active");
  }
  if(col.gameObject.tag == "d" &&  vegectable2==0){
  //verify name of the vegetable to take
  vegetableIndex=4;
  picked2Player1=true;
  slot=2;
   Debug.Log("take two active");
  }
   if(col.gameObject.tag == "e" &&  vegectable2==0){
  //verify name of the vegetable to take
  vegetableIndex=5;
   picked2Player1=true;
  slot=2;
   Debug.Log("take two active");
  }
   if(col.gameObject.tag == "f" &&  vegectable2==0){
  //verify name of the vegetable to take
  vegetableIndex=6;
  picked2Player1=true;
  slot=2;
  Debug.Log("take two active");
  }
  }


  //======================================================
 //verify if slot one is empty to take one vegetable
  if(picked3Player1==true && slot==2 && Input.GetKeyUp("e")){ 
  //verify name of the vegetable to take
  if(col.gameObject.tag == "a"){
  vegetableIndex=1;
  picked3Player1=true;
  slot=3;
  Debug.Log("take tree active");
  }
   if(col.gameObject.tag == "b"){
  //verify name of the vegetable to take
  vegetableIndex=2;
  picked3Player1=true;
  slot=3;
  Debug.Log("take tree active");
  }
   if(col.gameObject.tag == "c"){
  //verify name of the vegetable to take
  vegetableIndex=3;
   picked3Player1=true;
  slot=3;
  Debug.Log("take tree active");
  }
  if(col.gameObject.tag == "d"){
  //verify name of the vegetable to take
  vegetableIndex=4;
  picked3Player1=true;
  slot=3;
  Debug.Log("take tree active");
  }
   if(col.gameObject.tag == "e"){
  //verify name of the vegetable to take
  vegetableIndex=5;
   picked3Player1=true;
  slot=3;
  Debug.Log("take tree active");
  }
   if(col.gameObject.tag == "f"){
  //verify name of the vegetable to take
  vegetableIndex=6;
  picked3Player1=true;
  slot=3;
  Debug.Log("take tree active");
  }
  }


 //if player stay in the table and press e will disable the moviments for while and will start chopveg
  if(chopVeg==false){
  if (col.gameObject.tag == "table1" && Input.GetKeyDown("e") &&  SaladControl.vegectable1!=0 &&  SaladControl.vegectable2!=0){
  if(vegetablesCounter==2){
  thirdVegetable=true;
  }
  chopVegSlot=chopVegSlot+1;
  chopVeg=true;
  }
  }
  }
 
  
 
  }


