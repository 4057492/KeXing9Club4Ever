using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameObjectSaveAndLoad : MonoBehaviour
{
    // Start is called before the first frame update
    public GameObject[] saveGameObjectList;
    public bool[] ifActiveList;
    public TxtIOManager iOManager;
    private int savedScene;
    private bool ifLoad = false;
    void Start()
    {
        ifLoad = false;
    }
    void Update() 
    {
        if(!ifLoad)
        {
            Load();
            ifLoad = true;
        }
    }
    public void Load()
    {
        savedScene = TxtIOManager.Instance.GetSavedSceneIndex();
        if (gameObject.scene.buildIndex == savedScene)
        {
            ifActiveList = TxtIOManager.Instance.GetSavedConditions();
            transform.parent.position = TxtIOManager.Instance.GetSavedPosition();
            ApplyActive();
        }
    }
    private void ApplyActive()
    {
        if (saveGameObjectList == null)
        { 
            return; 
        }
        if (ifActiveList == null)
        { 
            return; 
        }
        for (int i = 0; i < saveGameObjectList.Length; i++)
        {
            if (ifActiveList.Length > i)
            {
                saveGameObjectList[i].SetActive(ifActiveList[i]);
            }
            else
            {
                saveGameObjectList[i].SetActive(false);
            }
        }
    }

    public void FillIfActiveList()
    {
        if (saveGameObjectList == null)
        { 
            return; 
        }
        List<bool> temp = new List<bool>();
        for (int i = 0; i < saveGameObjectList.Length;i++)
        {
            temp.Add(saveGameObjectList[i].activeInHierarchy);
        }
        ifActiveList = temp.ToArray();
    }

    public void SaveGame()
    {
        FillIfActiveList();
        if(iOManager == null)
            return;
        iOManager.conditions = ifActiveList;
        iOManager.sceneIndex = gameObject.scene.buildIndex;
        iOManager.pos = transform.parent.position;
        iOManager.SaveFiles();
    }
    void OnGUI() 
    {
        FillIfActiveList();
        if (GUI.Button(new Rect(20, 40, 200, 200), "save text"))
        {
            SaveGame();
        }
        if (GUI.Button(new Rect(20, 250, 200, 200), "read text"))
        {
            Load();
        }
        if (ifActiveList == null)
        { 
            for (int i = 0; i < ifActiveList.Length; i++)
            {
                ifActiveList[i] = GUI.Toggle(new Rect(240, 40 + i * 30, 100, 20), ifActiveList[i], i.ToString() + " : ");
            }
        }
        GUI.TextArea(new Rect(300, 40, 500, 50), transform.parent.position.ToString());
        GUI.TextArea(new Rect(300, 100, 500, 50), gameObject.scene.buildIndex.ToString());
    }
}
