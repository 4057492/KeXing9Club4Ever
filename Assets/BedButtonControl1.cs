using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class BedButtonControl1 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        GameObject obj = GameObject.Find("Button21");
        obj.GetComponent<Button>().enabled = false;
        obj.GetComponent<Image>().color = Color.clear;
        GameObject obj1 = GameObject.Find("Button22");
        obj1.GetComponent<Button>().enabled = false;
        obj1.GetComponent<Image>().color = Color.clear;
    }

    // Update is called once per frame
    public void SetButtonStatusActive()
    {
          GameObject obj = GameObject.Find("Button21");
        obj.GetComponent<Button>().enabled = true;
        obj.GetComponent<Image>().color = Color.white;
       // Text text = obj.transform.GetComponent<Text>();
       // text.color = Color.clear;
       // obj.SetActive(true);
       // obj1.SetActive(true);
        Text text = obj.transform.Find("Text").GetComponent<Text>();
        text.text = "休息";
        GameObject obj1 = GameObject.Find("Button22");
        obj1.GetComponent<Button>().enabled = true;
        obj1.GetComponent<Image>().color = Color.white;
        Text text1 = obj1.transform.Find("Text").GetComponent<Text>();
        text1.text = "不休息";
    }
}
