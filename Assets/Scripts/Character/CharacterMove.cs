using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterMove : MonoBehaviour
{
    CharacterControl characterControl;
    void Start()
    {
        characterControl = GetComponent<CharacterControl>();
    }
    
    public void Move(bool isMoveLeft)
    {
        if(isMoveLeft)
        {
            characterControl.moveDir = -1;
        }
        else
        {
            characterControl.moveDir = 1;
        }
    }
    public void StopMove()
    {
        characterControl.moveDir = 0;
    }
}
