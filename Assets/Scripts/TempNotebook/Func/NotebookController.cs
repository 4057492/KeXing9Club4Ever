using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class NotebookController : MonoBehaviour {
	public GameObject[] pages;
    public static int currentPage = 0;

    void Start () {
		pages = new GameObject[transform.childCount];
		for (int i = 0; i < transform.childCount; i++) {
			pages [i] = transform.GetChild(i).gameObject;
			pages [i].SetActive (false);
		}
		pages [NotebookController.currentPage].SetActive (true);

	}
	public void ChangePage(int page)
	{
        int tempPage = NotebookController.currentPage + page;
        if (tempPage >= 0 && tempPage <= (transform.childCount - 1))
        {
            pages[NotebookController.currentPage].SetActive(false);
            NotebookController.currentPage = tempPage;
            pages[NotebookController.currentPage].SetActive(true);
        }
    }

    public void ShowHideInfo()
    {
        GameObject obj = GameObject.Find("TextYCinfo");
        obj.SetActive(false);
    }
	
}
