using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonControl : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    public void ShowHideInfo()
    {
        GameObject obj = GameObject.Find("HUB");
       // obj.GetComponent<Text>().enabled = false;
        GameObject obj1 = obj.transform.Find("Notebook").gameObject;
        GameObject obj2 = obj1.transform.Find("NotebookController").gameObject;
        GameObject obj3 = obj2.transform.Find("Page1").gameObject;
        GameObject obj4 = obj3.transform.Find("TextYCinfo1").gameObject;
        obj4.SetActive(true);
       
       // obj.GetComponent<Text>().enabled = false;
        //obj.SetActive(true);
    }
    public void ShowHideInfo(string str)
    {
        GameObject obj = GameObject.Find("HUB");
       // obj.GetComponent<Text>().enabled = false;
        GameObject obj1 = obj.transform.Find("Notebook").gameObject;
        GameObject obj2 = obj1.transform.Find("NotebookController").gameObject;
        GameObject obj3 = obj2.transform.Find(str).gameObject;
        GameObject obj4 = obj3.transform.Find("TextYCinfo").gameObject;
        obj4.SetActive(true);
       
       // obj.GetComponent<Text>().enabled = false;
        //obj.SetActive(true);
    }
}
