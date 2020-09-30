using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BedButtonControl : MonoBehaviour
{
    // Start is called before the first frame update
    public void Start()
    {
       //GameObject obj = GameObject.Find("Button");
        //this.GetComponent<Button>().enabled = false;
        //this.GetComponent<Image>().color = Color.gray;
        
        //obj1.SetActive(false);
        GameObject obj = GameObject.Find("Button");
        obj.GetComponent<Button>().enabled = false;
        obj.GetComponent<Image>().color = Color.clear;
        GameObject obj1 = GameObject.Find("Button1");
        obj1.GetComponent<Button>().enabled = false;
        obj1.GetComponent<Image>().color = Color.clear;
        //Text text = obj.GetComponent<Text>();
        //text.color = Color.clear;
    }

    public void SetButtonStatusActive()
    {
        //Debugger.Log("Changing to : {0} ", destinationSceneName);
        //GameObject obj2 = GameObject.Find("Button");
        //obj2.SetActive(false);
        //GameObject obj3 = GameObject.Find("Button1");
        //obj3.SetActive(false);
        //this.GetComponent<Button>().enabled = true;
        //this.GetComponent<Image>().color = Color.gray;
        //this.GetComponent<Button>().enabled = false;
        GameObject obj = GameObject.Find("Button");
        obj.GetComponent<Button>().enabled = true;
        obj.GetComponent<Image>().color = Color.white;
       // Text text = obj.transform.GetComponent<Text>();
       // text.color = Color.clear;
       // obj.SetActive(true);
       // obj1.SetActive(true);
        Text text = obj.transform.Find("Text").GetComponent<Text>();
        text.text = "休息";
        GameObject obj1 = GameObject.Find("Button1");
        obj1.GetComponent<Button>().enabled = true;
        obj1.GetComponent<Image>().color = Color.white;
        Text text1 = obj1.transform.Find("Text").GetComponent<Text>();
        text1.text = "不休息";
    } 
    public void SetButtonDisactive()
    {
        //Debugger.Log("Changing to : {0} ", destinationSceneName);
        //GameObject obj2 = GameObject.Find("Button");
        //obj2.SetActive(false);
        //GameObject obj3 = GameObject.Find("Button1");
        //obj3.SetActive(false);
        //this.GetComponent<Button>().enabled = true;
        //this.GetComponent<Image>().color = Color.gray;
        GameObject obj = GameObject.Find("Button");
        obj.GetComponent<Button>().enabled = false;
        //this.GetComponent<Image>().color = Color.gray;
        /*GameObject obj = GameObject.Find("Button");
        obj.SetActive(false);
        GameObject obj1 = GameObject.Find("Button1");
        obj1.SetActive(false);*/
    } 
}
