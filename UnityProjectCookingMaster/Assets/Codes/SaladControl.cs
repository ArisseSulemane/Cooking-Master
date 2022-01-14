using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaladControl : MonoBehaviour
{
   
   //bool variables to contol wich slot is being used
   public static bool picked1Player1,picked2Player1,picked3Player1,chopVeg,thirdVegetable;
   //bool variables to contol wich vegetable player picked
   public static int  vegectable1,vegectable2,vegectable3,chopVegSlot,vegetablesCounter,chopcount;
   public Sprite a,b,c,d,e,f,empty;
   public Image image1,image2;
   public  static float timeChop;
   public GameObject timerUI;
   public Slider playerOneTimerChopUI;
   public GameObject [] SaladMix; 

   void Start(){
   picked1Player1=true;
   picked2Player1=false;
   picked3Player1=false;
   thirdVegetable=false;
   thirdVegetable=false;
   vegectable1=0;
   vegectable2=0;
   vegectable3=0;
   timeChop=0;
   chopVegSlot=0;
   chopcount=0;
   vegetablesCounter=0;
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
    }

  void OnTriggerStay(Collider col){
  //verify if slot one is empty to take one vegetable
  if(thirdVegetable==false && picked1Player1==true && picked2Player1==false && picked3Player1==false  && Input.GetKeyUp("e")){
 //verify name of the vegetable to take
  if (col.gameObject.tag == "a"){
  vegectable1=1;
  image1.GetComponent<Image> ().sprite = a;
  }
  if (col.gameObject.tag == "b"){
  vegectable1=2;
  image1.GetComponent<Image> ().sprite = b;
  }

  if (col.gameObject.tag == "c"){
  vegectable1=3;
  image1.GetComponent<Image> ().sprite = c;
  }

 if (col.gameObject.tag == "d"){
  vegectable1=4;
  image1.GetComponent<Image> ().sprite = d;
  }

  if (col.gameObject.tag == "e"){
  vegectable1=5;
  image1.GetComponent<Image> ().sprite = e;
  }

  if (col.gameObject.tag == "f"){
  vegectable1=6;
  image1.GetComponent<Image> ().sprite = f;
  }
  Debug.Log("slot 1 active");
  vegetablesCounter=1;
  picked2Player1=true;
  picked3Player1=false;
  picked1Player1=false;
  }

  //verify name of the vegetable to take
  if(thirdVegetable==false && picked2Player1==true && picked1Player1==false && picked3Player1==false  && Input.GetKeyDown("e")){
  //if player pick vegetable f will change the UI icon and give value vegetable2
  if (col.gameObject.tag == "a"){
  vegectable2=1;
  image2.GetComponent<Image> ().sprite = a;
  }
  
  if (col.gameObject.tag == "b"){
  vegectable2=2;
  image2.GetComponent<Image> ().sprite = b;
  }

  if (col.gameObject.tag == "c"){
  vegectable2=3;
  image2.GetComponent<Image> ().sprite = c;
  }

 if (col.gameObject.tag == "d"){
  vegectable2=4;
  image2.GetComponent<Image> ().sprite = d;
  }

  if (col.gameObject.tag == "e"){
  vegectable2=5;
  image2.GetComponent<Image> ().sprite = e;
  }
  //if player pick vegetable f will change the UI icon and give value vegetable2
  if (col.gameObject.tag == "f"){
  vegectable2=6;
  image2.GetComponent<Image> ().sprite = f;
  }
  Debug.Log("slot 2 active");
  vegetablesCounter=2;
  picked3Player1=true;
  picked1Player1=false;
  picked2Player1=false;
  }
//verify if slot one is empty to take one vegetable
  if(thirdVegetable==true &&  Input.GetKeyDown("e")){
 //verify name of the vegetable to take
  if (col.gameObject.tag == "a"){
  vegectable3=1;
  image1.GetComponent<Image> ().sprite = a;
  picked3Player1=true;
  Debug.Log("slot 3 active");
  }
  if (col.gameObject.tag == "b"){
  vegectable3=2;
  image1.GetComponent<Image> ().sprite = b;
  picked3Player1=true;
  Debug.Log("slot 3 active");
  }
  if (col.gameObject.tag == "c"){
  vegectable3=3;
  image1.GetComponent<Image> ().sprite = c;
  picked3Player1=true;
  Debug.Log("slot 3 active");
  }
  if (col.gameObject.tag == "d"){
  vegectable3=4;
  image1.GetComponent<Image> ().sprite = d;
  picked3Player1=true;
  Debug.Log("slot 3 active");
  }

  if (col.gameObject.tag == "e"){
  vegectable3=5;
  image1.GetComponent<Image> ().sprite = e;
  picked3Player1=true;
  Debug.Log("slot 3 active");
  }

  if (col.gameObject.tag == "f"){
  vegectable3=6;
  image1.GetComponent<Image> ().sprite = f;
  picked3Player1=true;
  Debug.Log("slot 3 active");
  }
  vegetablesCounter=3;
  picked1Player1=false;
  picked2Player1=false;
  picked3Player1=true;
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

