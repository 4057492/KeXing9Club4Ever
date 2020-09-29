using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

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

    public void OnCollisionEnter(Collision collision)
    {
        if(collision.gameObject.name == "LiseningRoomRight")
            SceneManager.LoadScene("bedroom");
        else if(collision.gameObject.name == "BedroomCubeLeft")
            SceneManager.LoadScene(0);
       else if(collision.gameObject.name == "BedroomCubeRight")
            SceneManager.LoadScene(2);
        else if(collision.gameObject.name == "EgineRoomCube")
            SceneManager.LoadScene(2);
        else if(collision.gameObject.name == "CentralRoomCubeRight")
            SceneManager.LoadScene("engine-room");
        else if(collision.gameObject.name == "CentralRoomCubeLeft")
            SceneManager.LoadScene("bedroom");

    }
}
