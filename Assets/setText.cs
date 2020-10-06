using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class setText : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
 public void SetButtonText()
    {
        GameObject obj = GameObject.Find("interact");
        obj.GetComponent<Text>().enabled = true;
        Text text = obj.transform.Find("Text").GetComponent<Text>();
        //text.text = "休息";
        //GameObject obj1 = obj.transform.Find("Notebook").gameObject;
        //GameObject obj2 = obj1.transform.Find("NotebookController").gameObject;
        //GameObject obj3 = obj2.transform.Find("Page (1)").gameObject;
        //GameObject obj4 = obj3.transform.Find("TextYCinfo").gameObject;
        //obj4.SetActive(true);
       
       // obj.GetComponent<Text>().enabled = false;
        //obj.SetActive(true);
    }
}
