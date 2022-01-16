using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SaladGive2 : MonoBehaviour
{
   


    public static  int clientCombination1,clientCombination2,clientCombination3,clientCombination4,clientCombination5,plates;
    public GameObject clientPlate1,clientPlate2,clientPlate3,clientPlate4,clientPlate5,playerPlateMove,trashplate;
    public GameObject [] vegetablesInThePlate1;
    public GameObject [] vegetablesInThePlate2;
    public GameObject [] vegetablesInThePlate3;
    public GameObject [] vegetablesInThePlate4;
    public GameObject [] vegetablesInThePlate5;
    public GameObject [] vegetablesInMovePlate;
    public GameObject [] vegetablesInStaticPlate,TrashSaladVegetables;
    public GameObject [] ClientsTimersUi,ClientsAngry;
    public static string  saladCombination;
    public static bool reseted,GiveSaladClit1,GiveSaladClit2,GiveSaladClit3,GiveSaladClit4,GiveSaladClit5;
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
    plates=0;
    }
    void Update(){
    saladCombination=SaladControl1.vegectable1.ToString()+SaladControl1.vegectable2.ToString()+SaladControl1.vegectable3.ToString();
    //give salad1
    if(GiveSaladClit1==true && saladCombination==clientCombination1.ToString()){
    vegetablesInMovePlate[SaladControl1.vegectable1].SetActive(false);
    vegetablesInMovePlate[SaladControl1.vegectable2].SetActive(false);
    vegetablesInMovePlate[SaladControl1.vegectable3].SetActive(false);
    playerPlateMove.SetActive(false);
    //-------------------------------------------------------------
    if(SaladControl1.vegectable3==0){
    vegetablesInThePlate1[SaladControl1.vegectable1].SetActive(true);
    vegetablesInThePlate1[SaladControl1.vegectable2].SetActive(true);
    }
    else{
    vegetablesInThePlate1[SaladControl1.vegectable1].SetActive(true);
    vegetablesInThePlate1[SaladControl1.vegectable2].SetActive(true);
    vegetablesInThePlate1[SaladControl1.vegectable3].SetActive(true);
    }
    //-------------------------------------------------------------
    plates=0;
    ClientsTimers.satisfied1=true;
    PlayerTwo.Score=PlayerTwo.Score+10;
    //disable UI timer bar for client1
    ClientsTimersUi[0].SetActive(false);
    ClientsTimers.satisfied1=true;
    Debug.Log("Cliet Is Satisfied");
    ClientsTimers.clientWrondSalad2=2;
    ResetAll();
    }
     if(GiveSaladClit1==true && saladCombination!=clientCombination1.ToString()){
    vegetablesInMovePlate[SaladControl1.vegectable1].SetActive(false);
    vegetablesInMovePlate[SaladControl1.vegectable2].SetActive(false);
    vegetablesInMovePlate[SaladControl1.vegectable3].SetActive(false);
    playerPlateMove.SetActive(false);
    plates=0;
    if(PlayerTwo.Score>0){
    PlayerTwo.Score=PlayerTwo.Score-10;
    }
    //if client was give wrong salad we increase velocity of decrease bar timer
    ClientsTimers.timerVelocity1=6;
    ClientsTimers.clint1Angry=true;
    ClientsAngry[0].SetActive(true);
    Debug.Log("Cliet Is Angry wrong salad");
    ResetAll();
    }
    //give salad2
    if(GiveSaladClit2==true && saladCombination==clientCombination2.ToString()){
    vegetablesInMovePlate[SaladControl1.vegectable1].SetActive(false);
    vegetablesInMovePlate[SaladControl1.vegectable2].SetActive(false);
    vegetablesInMovePlate[SaladControl1.vegectable3].SetActive(false);
    playerPlateMove.SetActive(false);
    clientPlate2.SetActive(true);
    //-------------------------------------------------------------
    if(SaladControl1.vegectable3==0){
    vegetablesInThePlate2[SaladControl1.vegectable1].SetActive(true);
    vegetablesInThePlate2[SaladControl1.vegectable2].SetActive(true);
    }
    else{
    vegetablesInThePlate2[SaladControl1.vegectable1].SetActive(true);
    vegetablesInThePlate2[SaladControl1.vegectable2].SetActive(true);
    vegetablesInThePlate2[SaladControl1.vegectable3].SetActive(true);
    }
    //-------------------------------------------------------------
    plates=0;
    PlayerTwo.Score=PlayerTwo.Score+10;
    //disable UI timer bar for client2
    ClientsTimersUi[1].SetActive(false);
    Debug.Log("Cliet Is Satisfied");
    ClientsTimers.clientWrondSalad2=2;
    ClientsTimers.satisfied2=true;
    ResetAll();
    } if(GiveSaladClit2==true && saladCombination!=clientCombination2.ToString()){
    vegetablesInMovePlate[SaladControl1.vegectable1].SetActive(false);
    vegetablesInMovePlate[SaladControl1.vegectable2].SetActive(false);
    vegetablesInMovePlate[SaladControl1.vegectable3].SetActive(false);
    playerPlateMove.SetActive(false);
    plates=0;
    if(PlayerTwo.Score>0){
    PlayerTwo.Score=PlayerTwo.Score-10;
    }
    //if client was give wrong salad we increase velocity of decrease bar timer
    ClientsTimers.timerVelocity2=6;
    ClientsTimers.clint2Angry=true;
    ClientsAngry[1].SetActive(true);
    Debug.Log("Cliet Is Angry wrong salad");
      ResetAll();
    }
        //give salad3
    if(GiveSaladClit3==true && saladCombination==clientCombination3.ToString()){
    vegetablesInMovePlate[SaladControl1.vegectable1].SetActive(false);
    vegetablesInMovePlate[SaladControl1.vegectable2].SetActive(false);
    vegetablesInMovePlate[SaladControl1.vegectable3].SetActive(false);
    playerPlateMove.SetActive(false);
    clientPlate3.SetActive(true);
    //-------------------------------------------------------------
    if(SaladControl1.vegectable3==0){
    vegetablesInThePlate3[SaladControl1.vegectable1].SetActive(true);
    vegetablesInThePlate3[SaladControl1.vegectable2].SetActive(true);
    }
    else{
    vegetablesInThePlate3[SaladControl1.vegectable1].SetActive(true);
    vegetablesInThePlate3[SaladControl1.vegectable2].SetActive(true);
    vegetablesInThePlate3[SaladControl1.vegectable3].SetActive(true);
    }
    //-------------------------------------------------------------
    plates=0;
    PlayerTwo.Score=PlayerTwo.Score+10;
    //disable UI timer bar for client3
    ClientsTimersUi[2].SetActive(false);
    ClientsTimers.satisfied3=true;
    Debug.Log("Cliet Is Satisfied");
    ClientsTimers.clientWrondSalad2=2;
      ResetAll();
    } if(GiveSaladClit3==true && saladCombination!=clientCombination3.ToString()){
    vegetablesInMovePlate[SaladControl1.vegectable1].SetActive(false);
    vegetablesInMovePlate[SaladControl1.vegectable2].SetActive(false);
    vegetablesInMovePlate[SaladControl1.vegectable3].SetActive(false);
    playerPlateMove.SetActive(false);
    plates=0;
    if(PlayerTwo.Score>0){
    PlayerTwo.Score=PlayerTwo.Score-10;
    }
    //if client was give wrong salad we increase velocity of decrease bar timer
    ClientsTimers.timerVelocity3=6;
    ClientsTimers.clint3Angry=true;
    ClientsAngry[2].SetActive(true);
    Debug.Log("Cliet Is Angry wrong salad");
    ResetAll();
    }
    //give salad4
    if(GiveSaladClit4==true && saladCombination==clientCombination4.ToString()){
    vegetablesInMovePlate[SaladControl1.vegectable1].SetActive(false);
    vegetablesInMovePlate[SaladControl1.vegectable2].SetActive(false);
    vegetablesInMovePlate[SaladControl1.vegectable3].SetActive(false);
    playerPlateMove.SetActive(false);
    clientPlate4.SetActive(true);
    //-------------------------------------------------------------
    if(SaladControl1.vegectable3==0){
    vegetablesInThePlate4[SaladControl1.vegectable1].SetActive(true);
    vegetablesInThePlate4[SaladControl1.vegectable2].SetActive(true);
    }
    else{
    vegetablesInThePlate4[SaladControl1.vegectable1].SetActive(true);
    vegetablesInThePlate4[SaladControl1.vegectable2].SetActive(true);
    vegetablesInThePlate4[SaladControl1.vegectable3].SetActive(true);
    }
    //-------------------------------------------------------------
    plates=0;
    ClientsTimers.satisfied4=true;
    PlayerTwo.Score=PlayerTwo.Score+10;
    //disable UI timer bar for client4
    ClientsTimersUi[3].SetActive(false);
    Debug.Log("Cliet Is Satisfied");
    ClientsTimers.clientWrondSalad2=2;
    ResetAll();
    } if(GiveSaladClit4==true && saladCombination!=clientCombination4.ToString()){
    vegetablesInMovePlate[SaladControl1.vegectable1].SetActive(false);
    vegetablesInMovePlate[SaladControl1.vegectable2].SetActive(false);
    vegetablesInMovePlate[SaladControl1.vegectable3].SetActive(false);
    playerPlateMove.SetActive(false);
    if(PlayerTwo.Score>0){
    PlayerTwo.Score=PlayerTwo.Score-10;
    }
    //if client was give wrong salad we increase velocity of decrease bar timer
    ClientsTimers.timerVelocity4=3;
    ClientsTimers.clint4Angry=true;
    ClientsAngry[3].SetActive(true);
    Debug.Log("Cliet Is Angry wrong salad");
    ResetAll();
    }
        //give salad5
    if(GiveSaladClit5==true && saladCombination==clientCombination5.ToString()){
    vegetablesInMovePlate[SaladControl1.vegectable1].SetActive(false);
    vegetablesInMovePlate[SaladControl1.vegectable2].SetActive(false);
    vegetablesInMovePlate[SaladControl1.vegectable3].SetActive(false);
    playerPlateMove.SetActive(false);
    clientPlate5.SetActive(true);
    //-------------------------------------------------------------
    if(SaladControl1.vegectable3==0){
    vegetablesInThePlate5[SaladControl1.vegectable1].SetActive(true);
    vegetablesInThePlate5[SaladControl1.vegectable2].SetActive(true);
    }
    else{
    vegetablesInThePlate5[SaladControl1.vegectable1].SetActive(true);
    vegetablesInThePlate5[SaladControl1.vegectable2].SetActive(true);
    vegetablesInThePlate5[SaladControl1.vegectable3].SetActive(true);
    }
    //-------------------------------------------------------------
    plates=0;
    ClientsTimers.satisfied5=true;
    PlayerTwo.Score=PlayerTwo.Score+10;
    //disable UI timer bar for client5
    ClientsTimersUi[4].SetActive(false);
    ClientsTimers.clientWrondSalad2=2;
    Debug.Log("Cliet Is Satisfied");
      ResetAll();
    } if(GiveSaladClit1==true && saladCombination!=clientCombination5.ToString()){
    vegetablesInMovePlate[SaladControl1.vegectable1].SetActive(false);
    vegetablesInMovePlate[SaladControl1.vegectable2].SetActive(false);
    vegetablesInMovePlate[SaladControl1.vegectable3].SetActive(false);
    playerPlateMove.SetActive(false);
    plates=0;
    if(PlayerTwo.Score>0){
    PlayerTwo.Score=PlayerTwo.Score-10;
    }
    //if client was give wrong salad we increase velocity of decrease bar timer
    ClientsTimers.timerVelocity5=6;
    ClientsTimers.clint5Angry=true;
    ClientsAngry[4].SetActive(true);
    Debug.Log("Cliet Is Angry wrong salad");
    ResetAll(); 
    }
    }



    void OnTriggerStay(Collider col){
    //take plate to client
    if(col.gameObject.tag == "plate2" && Input.GetKeyDown("delete") && plates==1){
    playerPlateMove.SetActive(true);
    //hide all vegetable in chef plate
    vegetablesInStaticPlate[SaladControl1.vegectable1].SetActive(false);
    vegetablesInStaticPlate[SaladControl1.vegectable2].SetActive(false);
    vegetablesInStaticPlate[SaladControl1.vegectable3].SetActive(false);
    //shhow all vegetables in new plate to take to client
    if(SaladControl1.vegectable3==0){
    vegetablesInMovePlate[SaladControl1.vegectable1].SetActive(true);
    vegetablesInMovePlate[SaladControl1.vegectable2].SetActive(true);
    }else{
    vegetablesInMovePlate[SaladControl1.vegectable1].SetActive(true);
    vegetablesInMovePlate[SaladControl1.vegectable2].SetActive(true);
    vegetablesInMovePlate[SaladControl1.vegectable3].SetActive(true);
    }
    Debug.Log("you take plate");
    }
    //Trash  Salad
    //take plate to client
    if(col.gameObject.tag == "plate2" && Input.GetKeyDown("end") && plates==1){
    playerPlateMove.SetActive(false); 
    trashplate.SetActive(true);
    if(PlayerTwo.Score>0){
    PlayerTwo.Score=PlayerTwo.Score-10;
    Debug.Log("Your Score Was Decreased");
    }
    //hide all vegetable in chef plate
    TrashSaladVegetables[SaladControl1.vegectable1].SetActive(false);
    TrashSaladVegetables[SaladControl1.vegectable2].SetActive(false);
    TrashSaladVegetables[SaladControl1.vegectable3].SetActive(false);
    //shhow all vegetables in new plate to take to client
    if(SaladControl1.vegectable3==0){
    TrashSaladVegetables[SaladControl1.vegectable1].SetActive(true);
    TrashSaladVegetables[SaladControl1.vegectable2].SetActive(true);
    }else{
    TrashSaladVegetables[SaladControl1.vegectable1].SetActive(true);
    TrashSaladVegetables[SaladControl1.vegectable2].SetActive(true);
    TrashSaladVegetables[SaladControl1.vegectable3].SetActive(true);
    }
    //disable plate and vegetables on cooker table
    if(SaladControl1.vegectable3==0){
    vegetablesInStaticPlate[SaladControl1.vegectable1].SetActive(false);
    vegetablesInStaticPlate[SaladControl1.vegectable2].SetActive(false);
    }else{
    vegetablesInStaticPlate[SaladControl1.vegectable1].SetActive(false);
    vegetablesInStaticPlate[SaladControl1.vegectable2].SetActive(false);
    vegetablesInStaticPlate[SaladControl1.vegectable3].SetActive(false);
    }
    //disable plate and vegetables on player ands
     if(SaladControl1.vegectable3==0){
    vegetablesInMovePlate[SaladControl1.vegectable1].SetActive(false);
    vegetablesInMovePlate[SaladControl1.vegectable2].SetActive(false);
    }else{
    vegetablesInMovePlate[SaladControl1.vegectable1].SetActive(false);
    vegetablesInMovePlate[SaladControl1.vegectable2].SetActive(false);
    vegetablesInMovePlate[SaladControl1.vegectable3].SetActive(false);
    }

    ResetAll();
    Debug.Log("you take plate");
    }




    //client 1 give food
    if(col.gameObject.tag == "client1" && Input.GetKeyDown("delete") && plates==1 && SaladControl1.vegectable1!=0){
    GiveSaladClit1=true;
    ClientsTimers.clientWrondSalad5=2; 
    }
    //client 2 give food
    if(col.gameObject.tag == "client2" && Input.GetKeyDown("delete") && plates==1 && SaladControl1.vegectable1!=0){
    GiveSaladClit2=true;
    ClientsTimers.clientWrondSalad5=2;
    }
    //client 3 give food
    if(col.gameObject.tag == "client3" && Input.GetKeyDown("delete") && plates==1 && SaladControl1.vegectable1!=0){
    GiveSaladClit3=true;
    ClientsTimers.clientWrondSalad5=2;
    }

    //client 4 give food
    if(col.gameObject.tag == "client4" && Input.GetKeyDown("delete") && plates==1 && SaladControl1.vegectable1!=0){
    GiveSaladClit4=true;
    ClientsTimers.clientWrondSalad5=2;
    }
    //client 5 give food
    if(col.gameObject.tag == "client5" && Input.GetKeyDown("delete") && plates==1 && SaladControl1.vegectable1!=0){
     GiveSaladClit5=true;
     ClientsTimers.clientWrondSalad5=2;
    }


    }



  public static void ResetAll(){
  //reset all status of SaladControl1
   SaladControl1.picked1Player2=true;
   SaladControl1.picked2Player2=false;
   SaladControl1.picked3Player2=false;
   SaladControl1.thirdVegetable=false;
   SaladControl1.thirdVegetable=false;
   SaladControl1.secondVegetable=false;
   SaladControl1.vegectable1=0;
   SaladControl1.vegectable2=0;
   SaladControl1.vegectable3=0;
   SaladControl1.timeChop=0;
   SaladControl1.chopVegSlot=0;
   SaladControl1.chopcount=0;
   SaladControl1.vegetablesCounter=0;
   SaladControl1.vegetableIndex=0;
   SaladControl1.slot=0;
   SaladControl1.vegetableIndex=0;
   GiveSaladClit1=false;
   GiveSaladClit2=false;
   GiveSaladClit3=false;
   GiveSaladClit4=false;
   GiveSaladClit5=false;
   plates=0;
   Debug.Log("picked1"+SaladControl1.picked1Player2);
   Debug.Log("picked2"+SaladControl1.picked2Player2);
   Debug.Log("pickd3"+SaladControl1.picked3Player2);
   Debug.Log("slot"+SaladControl1.slot);
   reseted=false;
  
   
  }
   
   
}
