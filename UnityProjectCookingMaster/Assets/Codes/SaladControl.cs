﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaladControl : MonoBehaviour
{
   

   public bool picked1Player1,picked2Player1;
   public int  vegectable1,vegectable2,vegectable3;
   public Sprite a,b,c,d,e,f;
   public Image image1,image2;


   void Start(){
   picked1Player1=false;
   picked2Player1=true;
   vegectable1=0;
   vegectable2=0;
   vegectable3=0;
  
   }
    void Update(){
    if(picked1Player1==true){
    picked2Player1=false;
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
  
  if(picked2Player1==false){
       //verify name of the vegetable to take
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

  if (col.gameObject.tag == "f" && Input.GetKeyDown("e")){
  vegectable2=6;
  image2.GetComponent<Image> ().sprite = f;
  }
  }
 








  }
  


}