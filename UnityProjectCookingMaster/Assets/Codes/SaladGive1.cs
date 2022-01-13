using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaladGive1 : MonoBehaviour
{
   


    public int clientCombination1,clientCombination2,clientCombination3,clientCombination4,clientCombination5,plates;
    public GameObject clientPlate1,clientPlate2,clientPlate3,clientPlate4,clientPlate5,playerPlateMove;
    public GameObject [] vegetablesInThePlate1;
    public GameObject [] vegetablesInThePlate2;
    public GameObject [] vegetablesInThePlate3;
    public GameObject [] vegetablesInThePlate4;
    public GameObject [] vegetablesInThePlate5;
    public GameObject [] vegetablesInMovePlate;
    public GameObject [] vegetablesInStaticPlate;
    public string  saladCombination;
    public bool GiveSaladClit1,GiveSaladClit2,GiveSaladClit3,GiveSaladClit4,GiveSaladClit5;
    void Start()
    {
    GiveSaladClit1=false;
    GiveSaladClit2=false;
    GiveSaladClit3=false;
    GiveSaladClit4=false;
    GiveSaladClit5=false;
    clientCombination1=134;
    clientCombination2=256;
    clientCombination3=350;
    clientCombination4=146;
    clientCombination5=316;
    plates=1;
    }
    void Update(){
    saladCombination=SaladControl.vegectable1.ToString()+SaladControl.vegectable2.ToString()+SaladControl.vegectable3.ToString();
    //give salad1
    if(GiveSaladClit1==true && saladCombination==clientCombination1.ToString()){
    vegetablesInMovePlate[SaladControl.vegectable1].SetActive(false);
    vegetablesInMovePlate[SaladControl.vegectable2].SetActive(false);
    vegetablesInMovePlate[SaladControl.vegectable3].SetActive(false);
    playerPlateMove.SetActive(false);
    clientPlate1.SetActive(true);
    //-------------------------------------------------------------
    if(SaladControl.vegectable3==0){
    vegetablesInThePlate1[SaladControl.vegectable1].SetActive(true);
    vegetablesInThePlate1[SaladControl.vegectable2].SetActive(true);
    }
    else{
    vegetablesInThePlate1[SaladControl.vegectable1].SetActive(true);
    vegetablesInThePlate1[SaladControl.vegectable2].SetActive(true);
    vegetablesInThePlate1[SaladControl.vegectable3].SetActive(true);
    }
    //-------------------------------------------------------------
    plates=0;
    PlayerOne.Score=PlayerOne.Score+10;
    Debug.Log("Cliet Is Satisfied");
    GiveSaladClit1=false;
    }
     if(GiveSaladClit1==true && saladCombination!=clientCombination1.ToString()){
    vegetablesInMovePlate[SaladControl.vegectable1].SetActive(false);
    vegetablesInMovePlate[SaladControl.vegectable2].SetActive(false);
    vegetablesInMovePlate[SaladControl.vegectable3].SetActive(false);
    playerPlateMove.SetActive(false);
    clientPlate1.SetActive(true);
    if(SaladControl.vegectable3==0)
    {
    vegetablesInThePlate1[SaladControl.vegectable1].SetActive(true);
    vegetablesInThePlate1[SaladControl.vegectable2].SetActive(true);
    }
    else
    {
    vegetablesInThePlate1[SaladControl.vegectable1].SetActive(true);
    vegetablesInThePlate1[SaladControl.vegectable2].SetActive(true);
    vegetablesInThePlate1[SaladControl.vegectable3].SetActive(true);
    }
    plates=0;
    if(PlayerOne.Score>0){
    PlayerOne.Score=PlayerOne.Score-10;
    }
    Debug.Log("Cliet Is Angry wrong salad"); 
    GiveSaladClit1=false; 
    }
    //give salad2
    if(GiveSaladClit2==true && saladCombination==clientCombination2.ToString()){
    vegetablesInMovePlate[SaladControl.vegectable1].SetActive(false);
    vegetablesInMovePlate[SaladControl.vegectable2].SetActive(false);
    vegetablesInMovePlate[SaladControl.vegectable3].SetActive(false);
    playerPlateMove.SetActive(false);
    clientPlate2.SetActive(true);
    //-------------------------------------------------------------
    if(SaladControl.vegectable3==0){
    vegetablesInThePlate2[SaladControl.vegectable1].SetActive(true);
    vegetablesInThePlate2[SaladControl.vegectable2].SetActive(true);
    }
    else{
    vegetablesInThePlate2[SaladControl.vegectable1].SetActive(true);
    vegetablesInThePlate2[SaladControl.vegectable2].SetActive(true);
    vegetablesInThePlate2[SaladControl.vegectable3].SetActive(true);
    }
    //-------------------------------------------------------------
    plates=0;
    PlayerOne.Score=PlayerOne.Score+10;
    Debug.Log("Cliet Is Satisfied");
    GiveSaladClit2=false;
    } if(GiveSaladClit1==true && saladCombination!=clientCombination2.ToString()){
    vegetablesInMovePlate[SaladControl.vegectable1].SetActive(false);
    vegetablesInMovePlate[SaladControl.vegectable2].SetActive(false);
    vegetablesInMovePlate[SaladControl.vegectable3].SetActive(false);
    playerPlateMove.SetActive(false);
    clientPlate2.SetActive(true);
    if(SaladControl.vegectable3==0)
    {
    vegetablesInThePlate2[SaladControl.vegectable1].SetActive(true);
    vegetablesInThePlate2[SaladControl.vegectable2].SetActive(true);
    }
    else
    {
    vegetablesInThePlate2[SaladControl.vegectable1].SetActive(true);
    vegetablesInThePlate2[SaladControl.vegectable2].SetActive(true);
    vegetablesInThePlate2[SaladControl.vegectable3].SetActive(true);
    }
    plates=0;
    if(PlayerOne.Score>0){
    PlayerOne.Score=PlayerOne.Score-10;
    }
    Debug.Log("Cliet Is Angry wrong salad"); 
    GiveSaladClit2=false; 
    }
        //give salad3
    if(GiveSaladClit3==true && saladCombination==clientCombination3.ToString()){
    vegetablesInMovePlate[SaladControl.vegectable1].SetActive(false);
    vegetablesInMovePlate[SaladControl.vegectable2].SetActive(false);
    vegetablesInMovePlate[SaladControl.vegectable3].SetActive(false);
    playerPlateMove.SetActive(false);
    clientPlate2.SetActive(true);
    //-------------------------------------------------------------
    if(SaladControl.vegectable3==0){
    vegetablesInThePlate3[SaladControl.vegectable1].SetActive(true);
    vegetablesInThePlate3[SaladControl.vegectable2].SetActive(true);
    }
    else{
    vegetablesInThePlate3[SaladControl.vegectable1].SetActive(true);
    vegetablesInThePlate3[SaladControl.vegectable2].SetActive(true);
    vegetablesInThePlate3[SaladControl.vegectable3].SetActive(true);
    }
    //-------------------------------------------------------------
    plates=0;
    PlayerOne.Score=PlayerOne.Score+10;
    Debug.Log("Cliet Is Satisfied");
    GiveSaladClit3=false;
    } if(GiveSaladClit1==true && saladCombination!=clientCombination3.ToString()){
    vegetablesInMovePlate[SaladControl.vegectable1].SetActive(false);
    vegetablesInMovePlate[SaladControl.vegectable2].SetActive(false);
    vegetablesInMovePlate[SaladControl.vegectable3].SetActive(false);
    playerPlateMove.SetActive(false);
    clientPlate3.SetActive(true);
    if(SaladControl.vegectable3==0)
    {
    vegetablesInThePlate3[SaladControl.vegectable1].SetActive(true);
    vegetablesInThePlate3[SaladControl.vegectable2].SetActive(true);
    }
    else
    {
    vegetablesInThePlate3[SaladControl.vegectable1].SetActive(true);
    vegetablesInThePlate3[SaladControl.vegectable2].SetActive(true);
    vegetablesInThePlate3[SaladControl.vegectable3].SetActive(true);
    }
    plates=0;
    if(PlayerOne.Score>0){
    PlayerOne.Score=PlayerOne.Score-10;
    }
    Debug.Log("Cliet Is Angry wrong salad"); 
    GiveSaladClit3=false; 
    }
    //give salad4
    if(GiveSaladClit4==true && saladCombination==clientCombination4.ToString()){
    vegetablesInMovePlate[SaladControl.vegectable1].SetActive(false);
    vegetablesInMovePlate[SaladControl.vegectable2].SetActive(false);
    vegetablesInMovePlate[SaladControl.vegectable3].SetActive(false);
    playerPlateMove.SetActive(false);
    clientPlate4.SetActive(true);
    //-------------------------------------------------------------
    if(SaladControl.vegectable3==0){
    vegetablesInThePlate4[SaladControl.vegectable1].SetActive(true);
    vegetablesInThePlate4[SaladControl.vegectable2].SetActive(true);
    }
    else{
    vegetablesInThePlate4[SaladControl.vegectable1].SetActive(true);
    vegetablesInThePlate4[SaladControl.vegectable2].SetActive(true);
    vegetablesInThePlate4[SaladControl.vegectable3].SetActive(true);
    }
    //-------------------------------------------------------------
    plates=0;
    PlayerOne.Score=PlayerOne.Score+10;
    Debug.Log("Cliet Is Satisfied");
    GiveSaladClit4=false;
    } if(GiveSaladClit1==true && saladCombination!=clientCombination4.ToString()){
    vegetablesInMovePlate[SaladControl.vegectable1].SetActive(false);
    vegetablesInMovePlate[SaladControl.vegectable2].SetActive(false);
    vegetablesInMovePlate[SaladControl.vegectable3].SetActive(false);
    playerPlateMove.SetActive(false);
    clientPlate4.SetActive(true);
    if(SaladControl.vegectable3==0)
    {
    vegetablesInThePlate4[SaladControl.vegectable1].SetActive(true);
    vegetablesInThePlate4[SaladControl.vegectable2].SetActive(true);
    }
    else
    {
    vegetablesInThePlate4[SaladControl.vegectable1].SetActive(true);
    vegetablesInThePlate4[SaladControl.vegectable2].SetActive(true);
    vegetablesInThePlate4[SaladControl.vegectable3].SetActive(true);
    }
    plates=0;
    if(PlayerOne.Score>0){
    PlayerOne.Score=PlayerOne.Score-10;
    }
    Debug.Log("Cliet Is Angry wrong salad"); 
    GiveSaladClit4=false; 
    }
        //give salad5
    if(GiveSaladClit5==true && saladCombination==clientCombination5.ToString()){
    vegetablesInMovePlate[SaladControl.vegectable1].SetActive(false);
    vegetablesInMovePlate[SaladControl.vegectable2].SetActive(false);
    vegetablesInMovePlate[SaladControl.vegectable3].SetActive(false);
    playerPlateMove.SetActive(false);
    clientPlate5.SetActive(true);
    //-------------------------------------------------------------
    if(SaladControl.vegectable3==0){
    vegetablesInThePlate5[SaladControl.vegectable1].SetActive(true);
    vegetablesInThePlate5[SaladControl.vegectable2].SetActive(true);
    }
    else{
    vegetablesInThePlate5[SaladControl.vegectable1].SetActive(true);
    vegetablesInThePlate5[SaladControl.vegectable2].SetActive(true);
    vegetablesInThePlate5[SaladControl.vegectable3].SetActive(true);
    }
    //-------------------------------------------------------------
    plates=0;
    PlayerOne.Score=PlayerOne.Score+10;
    Debug.Log("Cliet Is Satisfied");
    GiveSaladClit5=false;
    } if(GiveSaladClit1==true && saladCombination!=clientCombination5.ToString()){
    vegetablesInMovePlate[SaladControl.vegectable1].SetActive(false);
    vegetablesInMovePlate[SaladControl.vegectable2].SetActive(false);
    vegetablesInMovePlate[SaladControl.vegectable3].SetActive(false);
    playerPlateMove.SetActive(false);
    clientPlate5.SetActive(true);
    if(SaladControl.vegectable3==0)
    {
    vegetablesInThePlate5[SaladControl.vegectable1].SetActive(true);
    vegetablesInThePlate5[SaladControl.vegectable2].SetActive(true);
    }
    else
    {
    vegetablesInThePlate5[SaladControl.vegectable1].SetActive(true);
    vegetablesInThePlate5[SaladControl.vegectable2].SetActive(true);
    vegetablesInThePlate5[SaladControl.vegectable3].SetActive(true);
    }
    plates=0;
    if(PlayerOne.Score>0){
    PlayerOne.Score=PlayerOne.Score-10;
    }
    Debug.Log("Cliet Is Angry wrong salad"); 
    GiveSaladClit5=false; 
    }

    }

    void OnTriggerStay(Collider col){
    //take plate to client
    if(col.gameObject.tag == "plate1" && Input.GetKeyDown("e")){
    playerPlateMove.SetActive(true);
    //hide all vegetable in chef plate
    vegetablesInStaticPlate[SaladControl.vegectable1].SetActive(false);
    vegetablesInStaticPlate[SaladControl.vegectable2].SetActive(false);
    vegetablesInStaticPlate[SaladControl.vegectable3].SetActive(false);
    //shhow all vegetables in new plate to take to client
    if(SaladControl.vegectable3==0){
    vegetablesInMovePlate[SaladControl.vegectable1].SetActive(true);
    vegetablesInMovePlate[SaladControl.vegectable2].SetActive(true);
    }else{
    vegetablesInMovePlate[SaladControl.vegectable1].SetActive(true);
    vegetablesInMovePlate[SaladControl.vegectable2].SetActive(true);
    vegetablesInMovePlate[SaladControl.vegectable3].SetActive(true);
    }
    Debug.Log("you take plate");
    }

    //client 1 give food
    if(col.gameObject.tag == "client1" && Input.GetKeyDown("e") && plates==1){
    GiveSaladClit1=true; 
    }
    //client 2 give food
    if(col.gameObject.tag == "client2" && Input.GetKeyDown("e") && plates==1){
    GiveSaladClit2=true; 
    }
    //client 3 give food
    if(col.gameObject.tag == "client3" && Input.GetKeyDown("e") && plates==1){
    GiveSaladClit3=true;
    }

    //client 4 give food
    if(col.gameObject.tag == "client4" && Input.GetKeyDown("e") && plates==1){
    GiveSaladClit4=true;
    }
    //client 5 give food
    if(col.gameObject.tag == "client5" && Input.GetKeyDown("e") && plates==1){
    GiveSaladClit5=true;
    }


    }

   
   
}
