using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] float torqueAmmount = 8f;
    private Rigidbody2D rb2d;
   
    void Awake()
    {
       rb2d = GetComponent<Rigidbody2D>();
    }

    void Update()
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
