using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour {


    //Inspector Variables
    public float playerSpeed = .75f;
    public bool CanMove;
    Animator Animator;
   
   void Start ()
    {
        CanMove = true; // Player Movement 
        playerSpeed = .75f;
    }

    public void Update()
    {
        if (CanMove == true)
        {
            if (Input.GetKey("up"))//Press up arrow key to move forward on the Y AXIS
            {
                transform.Translate(0, playerSpeed * Time.deltaTime, 0);
            }
            if (Input.GetKey("down"))//Press up arrow key to move forward on the Y AXIS
            {
                transform.Translate(0, -playerSpeed * Time.deltaTime, 0);
            }
            if (Input.GetKey("left"))//Press up arrow key to move forward on the Y AXIS
            {
                transform.Translate(-playerSpeed * Time.deltaTime, 0, 0);
            }
            if (Input.GetKey("right"))//Press up arrow key to move forward on the Y AXIS
            {
                transform.Translate(playerSpeed * Time.deltaTime, 0, 0);
            }
        }
    }
}