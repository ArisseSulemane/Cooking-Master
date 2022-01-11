using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerTwo : MonoBehaviour
{
   
    // player variable tranform to move around the level	
    public Transform playerTwo;
    //velocity player moves variable
    public float playerVelocity;


void Update(){
//all the keys to move around the player in scene with limits 
if(Input.GetKey("up") && playerTwo.position.z < -0.3)
{
//calling method up to move player to up sides of the scene
 Up();
}
if(Input.GetKey("down") && playerTwo.position.z > -29)
{
//calling method down to move player to down sides of the scene
 Down();
}

if(Input.GetKey("left") && playerTwo.position.x > -26.5)
{
//calling method left to move player to left sides of the scene
 Left();
}
if(Input.GetKey("right") && playerTwo.position.x < 26.5)
{
//calling method right to move player to right sides of the scene
 Right();
}
}

//all methods to transform the player up,down,left and right
public void Up(){
playerTwo.position = transform.position + new Vector3(0,0,playerVelocity*Time.deltaTime);
}
public void Down(){
playerTwo.position = transform.position + new Vector3(0,0,-playerVelocity*Time.deltaTime);
}
public void Left(){
playerTwo.position = transform.position + new Vector3(-playerVelocity*Time.deltaTime,0,0);
}
public void Right(){
playerTwo.position = transform.position + new Vector3(playerVelocity*Time.deltaTime,0,0);
}




}
