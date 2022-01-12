using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaladGive1 : MonoBehaviour
{
   


    public int clientCombination1,clientCombination2,clientCombination3,clientCombination4,clientCombination5,plates;
    public GameObject clientPlate1,clientPlate2,clientPlate3,clientPlate4,clientPlate5;
    public GameObject [] vegetablesInThePlate1;
    public GameObject [] vegetablesInThePlate2;
    public GameObject [] vegetablesInThePlate3;
    public GameObject [] vegetablesInThePlate4;
    public GameObject [] vegetablesInThePlate5;
    public string  saladCombination;
    void Start()
    {
    clientCombination1=134;
    clientCombination2=256;
    clientCombination3=350;
    clientCombination4=146;
    clientCombination5=316;
    plates=1;
    }
    void Update(){
    saladCombination=SaladControl.vegectable1.ToString()+SaladControl.vegectable2.ToString()+SaladControl.vegectable3.ToString();
    }
    void OnTriggerStay(Collider col){
    //client 1 give food
    if(col.gameObject.tag == "client1" && Input.GetKeyDown("e") && plates==1){
    if(saladCombination==clientCombination1.ToString()){
    clientPlate1.SetActive(true);
    vegetablesInThePlate1[SaladControl.vegectable1].SetActive(true);
    vegetablesInThePlate1[SaladControl.vegectable2].SetActive(true);
    vegetablesInThePlate1[SaladControl.vegectable3].SetActive(true);
    plates=0;
    Debug.Log("Cliet Is Satisfied");
    }else{
    clientPlate1.SetActive(true);
    vegetablesInThePlate1[SaladControl.vegectable1].SetActive(true);
    vegetablesInThePlate1[SaladControl.vegectable2].SetActive(true);
    vegetablesInThePlate1[SaladControl.vegectable3].SetActive(true);
    plates=0;
    Debug.Log("Cliet Is Angry wrong salad");   
    }
    }
    //client 2 give food
    if(col.gameObject.tag == "client2" && Input.GetKeyDown("e") && plates==1){
    if(saladCombination==clientCombination2.ToString()){
    clientPlate1.SetActive(true);
    vegetablesInThePlate1[SaladControl.vegectable1].SetActive(true);
    vegetablesInThePlate1[SaladControl.vegectable2].SetActive(true);
    vegetablesInThePlate1[SaladControl.vegectable3].SetActive(true);
    plates=0;
    Debug.Log("Cliet Is Satisfied");
    }else{
    clientPlate1.SetActive(true);
    vegetablesInThePlate1[SaladControl.vegectable1].SetActive(true);
    vegetablesInThePlate1[SaladControl.vegectable2].SetActive(true);
    vegetablesInThePlate1[SaladControl.vegectable3].SetActive(true);
    plates=0;
    Debug.Log("Cliet Is Angry wrong salad");   
    }
    }
    //client 3 give food
    if(col.gameObject.tag == "client3" && Input.GetKeyDown("e") && plates==1){
    if(saladCombination==clientCombination3.ToString()){
    clientPlate1.SetActive(true);
    vegetablesInThePlate1[SaladControl.vegectable1].SetActive(true);
    vegetablesInThePlate1[SaladControl.vegectable2].SetActive(true);
    vegetablesInThePlate1[SaladControl.vegectable3].SetActive(true);
    plates=0;
    Debug.Log("Cliet Is Satisfied");
    }else{
    clientPlate1.SetActive(true);
    vegetablesInThePlate1[SaladControl.vegectable1].SetActive(true);
    vegetablesInThePlate1[SaladControl.vegectable2].SetActive(true);
    vegetablesInThePlate1[SaladControl.vegectable3].SetActive(true);
    plates=0;
    Debug.Log("Cliet Is Angry wrong salad");   
    }
    }
    //client 4 give food
    if(col.gameObject.tag == "client4" && Input.GetKeyDown("e") && plates==1){
    if(saladCombination==clientCombination4.ToString()){
    clientPlate1.SetActive(true);
    vegetablesInThePlate1[SaladControl.vegectable1].SetActive(true);
    vegetablesInThePlate1[SaladControl.vegectable2].SetActive(true);
    vegetablesInThePlate1[SaladControl.vegectable3].SetActive(true);
    plates=0;
    Debug.Log("Cliet Is Satisfied");
    }else{
    clientPlate1.SetActive(true);
    vegetablesInThePlate1[SaladControl.vegectable1].SetActive(true);
    vegetablesInThePlate1[SaladControl.vegectable2].SetActive(true);
    vegetablesInThePlate1[SaladControl.vegectable3].SetActive(true);
    plates=0;
    Debug.Log("Cliet Is Angry wrong salad");   
    }
    }
    //client 5 give food
    if(col.gameObject.tag == "client5" && Input.GetKeyDown("e") && plates==1){
    if(saladCombination==clientCombination5.ToString()){
    clientPlate1.SetActive(true);
    vegetablesInThePlate1[SaladControl.vegectable1].SetActive(true);
    vegetablesInThePlate1[SaladControl.vegectable2].SetActive(true);
    vegetablesInThePlate1[SaladControl.vegectable3].SetActive(true);
    plates=0;
    Debug.Log("Cliet Is Satisfied");
    }else{
    clientPlate1.SetActive(true);
    vegetablesInThePlate1[SaladControl.vegectable1].SetActive(true);
    vegetablesInThePlate1[SaladControl.vegectable2].SetActive(true);
    vegetablesInThePlate1[SaladControl.vegectable3].SetActive(true);
    plates=0;
    Debug.Log("Cliet Is Angry wrong salad");   
    }
    }


    }

   
}
