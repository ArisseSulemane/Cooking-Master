using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaladControl : MonoBehaviour
{
   
   //bool variables to contol wich slot is being used
   public bool picked1Player1,picked2Player1,chopVeg;
   //bool variables to contol wich vegetable player picked
   public int  vegectable1,vegectable2,vegectable3;
   public Sprite a,b,c,d,e,f;
   public Image image1,image2;
   private float timeChop;
   public GameObject timerUI;
   public Slider playerOneTimerChopUI;


   void Start(){
   picked1Player1=false;
   picked2Player1=true;
   vegectable1=0;
   vegectable2=0;
   vegectable3=0;
   timeChop=0;
   }
    
    void Update(){
    //if slot 1 be used will open slot 2 to be used
    if(picked1Player1==true){
    picked2Player1=false;
    }
    //the timer will UI will appear now
    if(timeChop<5 && chopVeg==true){
    timeChop=timeChop+1*Time.deltaTime;
    timerUI.SetActive(true);
    playerOneTimerChopUI.value=timeChop;
    //disable move script for the player not move around
    gameObject.GetComponent<PlayerOne>().enabled = false;
    }else{
    //reset timer to 0
    playerOneTimerChopUI.value=0;
    //hide UI info timer
    timerUI.SetActive(false); 
    //Enable again player moviment   
    gameObject.GetComponent<PlayerOne>().enabled = true;
    }
    //if timer be iqual 0 increse more 5 time
    if(timeChop==5){
    timeChop=0;
    //enable true to player move again
    chopVeg=false;  
    }

    }

  void OnTriggerStay(Collider col){
  //verify if slot one is empty to take one vegetable
  if(picked1Player1==false){
 //verify name of the vegetable to take
  if (col.gameObject.tag == "a" && Input.GetKeyDown("e")){
  vegectable1=1;
  image1.GetComponent<Image> ().sprite = a;
  picked1Player1=true;
  }
  if (col.gameObject.tag == "b" && Input.GetKeyDown("e")){
  vegectable1=2;
  image1.GetComponent<Image> ().sprite = b;
  picked1Player1=true;
  }

  if (col.gameObject.tag == "c" && Input.GetKeyDown("e")){
  vegectable1=3;
  image1.GetComponent<Image> ().sprite = c;
  picked1Player1=true;
  }

 if (col.gameObject.tag == "d" && Input.GetKeyDown("e")){
  vegectable1=4;
  image1.GetComponent<Image> ().sprite = d;
  picked1Player1=true;
  }

  if (col.gameObject.tag == "e" && Input.GetKeyDown("e")){
  vegectable1=5;
  image1.GetComponent<Image> ().sprite = e;
  picked1Player1=true;
  }

  if (col.gameObject.tag == "f" && Input.GetKeyDown("e")){
  vegectable1=6;
  image1.GetComponent<Image> ().sprite = f;
  picked1Player1=true;
  }
  }
  //verify name of the vegetable to take
  if(picked2Player1==false){
//if player pick vegetable f will change the UI icon nad give value vegetable2
  if (col.gameObject.tag == "a" && Input.GetKeyDown("e")){
  vegectable2=1;
  image2.GetComponent<Image> ().sprite = a;
  }

  if (col.gameObject.tag == "b" && Input.GetKeyDown("e")){
  vegectable2=2;
  image2.GetComponent<Image> ().sprite = b;
  }

  if (col.gameObject.tag == "c" && Input.GetKeyDown("e")){
  vegectable2=3;
  image2.GetComponent<Image> ().sprite = c;
  }

 if (col.gameObject.tag == "d" && Input.GetKeyDown("e")){
  vegectable2=4;
  image2.GetComponent<Image> ().sprite = d;
  }

  if (col.gameObject.tag == "e" && Input.GetKeyDown("e")){
  vegectable2=5;
  image2.GetComponent<Image> ().sprite = e;
  }
  //if player pick vegetable f will change the UI icon nad give value vegetable2
  if (col.gameObject.tag == "f" && Input.GetKeyDown("e")){
  vegectable2=6;
  image2.GetComponent<Image> ().sprite = f;
  }

 //if player stay in the table and press e will disable the moviments for while and will start chopveg
  if (col.gameObject.tag == "table1" && Input.GetKeyDown("e")){
  chopVeg=true;
  }
  }
 
  }
}
