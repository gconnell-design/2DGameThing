using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour {

    public Animator animator;
    public bool UpBool;
    public bool DownBool;
    public bool LeftBool;
    public bool RightBool;

    void Start()
    {
        animator.SetBool("DownIdle", true);
    }
    void Update () {
        Vector3 movement = new Vector3(Input.GetAxis("Horizontal"), Input.GetAxis("Vertical"), 0.0f);
        
        if (Input.GetKey("up") && !DownBool)
        {
            animator.SetFloat("Vertical", 1);
            UpBool = true;
            animator.SetBool("DownIdle", false);
            animator.SetBool("RightIdle", false);
            animator.SetBool("LeftIdle", false);
            animator.SetBool("UpIdle", true);
        }
        else if (Input.GetKey("down")&& !UpBool)
        {
            animator.SetFloat("Vertical", -1);
            DownBool = true;
            animator.SetBool("RightIdle", false);
            animator.SetBool("LeftIdle", false);
            animator.SetBool("UpIdle", false);
            animator.SetBool("DownIdle", true);
        }
        else
        {
            animator.SetFloat("Vertical", 0);
            UpBool = false;
            DownBool = false;
        }

    

        if (Input.GetKey("left") && !RightBool)
        {
            animator.SetFloat("Horizontal", -1);
            LeftBool = true;
            animator.SetBool("DownIdle", false);
            animator.SetBool("RightIdle", false);
            animator.SetBool("UpIdle", false);
            animator.SetBool("LeftIdle", true);
        }
        else if (Input.GetKey("right") && !LeftBool)
        {
            animator.SetFloat("Horizontal", 1);
            RightBool = true;
            animator.SetBool("UpIdle", false);
            animator.SetBool("DownIdle", false);
            animator.SetBool("LeftIdle", false);
            animator.SetBool("RightIdle", true);
        }
        else
        {
            animator.SetFloat("Horizontal", 0);
            LeftBool = false;
            RightBool = false;
        }



        if (!Input.GetKey("up") && !Input.GetKey("down") && !Input.GetKey("left") && !Input.GetKey("right"))
        {
            animator.SetFloat("Magnitude", 0);
            movement = Vector3.zero;
        }
        else
        {
            animator.SetFloat("Magnitude", 1);
        }


        transform.position = transform.position + movement * Time.deltaTime;

        if (Input.GetKeyDown("space")) 
        {
            animator.SetTrigger("SwordSwing");
        }


	}
}
