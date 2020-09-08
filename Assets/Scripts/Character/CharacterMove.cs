using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    public float speed = 0.025f;
    //public float acceleration = 0;
    //public float maxSpeed = 1;
    //private Rigidbody rigidbody;
    int moveDir = 0;
    // Start is called before the first frame update
    void Start()
    {
        //rigidbody = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
   void Update()
   {
       if(moveDir != 0)
       {
            transform.Translate(new Vector3(moveDir*speed,0,0),Space.Self);
       }

   }
    
    public void Move(bool isMoveLeft)
    {
        if(isMoveLeft)
        {
            moveDir = -1;
        }
        else
        {
            moveDir = 1;
        }
    }
    public void StopMove()
    {
        moveDir = 0;
    }
}
