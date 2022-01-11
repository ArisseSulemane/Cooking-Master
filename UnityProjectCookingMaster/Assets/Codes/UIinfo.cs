using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIinfo : MonoBehaviour
{
   

   public GameObject uiInfoP1;
   public GameObject uiInfoP2;
   //UI info show to user
   void OnTriggerEnter(Collider col){
    //if the player one enter on this area game show info button to press to do the action
	if (col.gameObject.tag == "Player1"){
	uiInfoP1.SetActive(true);
	}
    if (col.gameObject.tag == "Player2"){
	uiInfoP2.SetActive(true);
	}
    }
    void OnTriggerExit(Collider col){
	if (col.gameObject.tag == "Player1") {
	uiInfoP1.SetActive(false);
	}
    if (col.gameObject.tag == "Player2") {
	uiInfoP2.SetActive(false);
	}
    }

   
}
