using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerOne : MonoBehaviour
{
   
    // player variable tranform to move around the level	
    public Transform playerOne;
    //velocity player moves variable
    public float playerVelocity;
   
    void Start(){
        
    }
void Update(){
//all the keys to move around the player in scene with limits 
if(Input.GetKey("w") && playerOne.position.z < -0.3)
{
//calling method up to move player to up sides of the scene
 Up();
}
if(Input.GetKey("s") && playerOne.position.z > -29)
{
//calling method down to move player to down sides of the scene
 Down();
}

if(Input.GetKey("a") && playerOne.position.x > -26.5)
{
//calling method left to move player to left sides of the scene
 Left();
}
if(Input.GetKey("d") && playerOne.position.x < 26.5)
{
//calling method right to move player to right sides of the scene
 Right();

}

}

//all methods to transform the player up,down,left and right
public void Up(){
playerOne.position = transform.position + new Vector3(0,0,playerVelocity*Time.deltaTime);
}
public void Down(){
playerOne.position = transform.position + new Vector3(0,0,-playerVelocity*Time.deltaTime);
}
public void Left(){
playerOne.position = transform.position + new Vector3(-playerVelocity*Time.deltaTime,0,0);
}
public void Right(){
playerOne.position = transform.position + new Vector3(playerVelocity*Time.deltaTime,0,0);
}




}
