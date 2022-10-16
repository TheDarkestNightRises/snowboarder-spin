using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float torqueAmmount = 8f;
    [SerializeField] float bootSpeed = 31f;
    [SerializeField] float baseSpeed = 25f;
    bool canMove = true;

    private Rigidbody2D rb2d;
    SurfaceEffector2D surfaceEffector2D;  
   
    void Awake()
    {
       rb2d = GetComponent<Rigidbody2D>();
        surfaceEffector2D = FindObjectOfType<SurfaceEffector2D>();
    }

    void Update()
    {
        if (canMove) 
        {
            ProcessRotation();
            ResponseToBoost();
        }
    }

    public void DisableControls()
    {
        canMove = false;
    }

    private void ResponseToBoost()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            surfaceEffector2D.speed = bootSpeed;           
        }
        else
        {
            surfaceEffector2D.speed = baseSpeed;
        }
    }

    private void ProcessRotation()
    {
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            rb2d.AddTorque(torqueAmmount);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            rb2d.AddTorque(-torqueAmmount);
        }
    }
}
