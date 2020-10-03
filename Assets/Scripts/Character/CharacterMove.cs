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
       /* if(collision.gameObject.name == "LiseningRoomRight")
        {
            SceneManager.LoadScene("bedroom");
            Scene scene = SceneManager.GetActiveScene ();
            
        }
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
        else if(collision.gameObject.name == "BedroomsCubeLeft")
            SceneManager.LoadScene(1);*/
        if(collision.gameObject.name == "BedroomCub1")
        {
            GameObject name4 = GameObject.Find("character");
            name4.transform.Translate(30,0,0);

        }
        else if (collision.gameObject.name == "BedroomCub2")
        {
            GameObject name = GameObject.Find("character");
            name.transform.Translate(-30,0,0);
        }

        else if (collision.gameObject.name == "BedroomCub3")
        {
            GameObject name = GameObject.Find("character");
            name.transform.Translate(30,0,0);
        }
        else if (collision.gameObject.name == "BedroomCub4")
        {
            GameObject name = GameObject.Find("character");
            name.transform.Translate(-30,0,0);
        }
        else if (collision.gameObject.name == "BedroomCub5")
        {
            GameObject name = GameObject.Find("character");
            name.transform.Translate(30,0,0);
        }
        else if (collision.gameObject.name == "BedroomCub6")
        {
            GameObject name = GameObject.Find("character");
            name.transform.Translate(-30,0,0);
        }
        else if (collision.gameObject.name == "BedroomCub9")
        {
            GameObject obj = GameObject.Find("Button");
            obj.SetActive(false);
            GameObject obj1 = GameObject.Find("Button1");
            obj1.SetActive(false);
            GameObject name = GameObject.Find("character");
            name.transform.Translate(-180,0,0);
        }
    }
}
