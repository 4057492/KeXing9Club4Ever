using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Custom.Log;

public class GameflowControl : MonoBehaviour
{
    public int destinationSceneName;
    public void ChangingScene()
    {
        //Debugger.Log("Changing to : {0} ", destinationSceneName);
        SceneManager.LoadScene(destinationSceneName);
    } 
    public static void ChangingSceneByName(string dSceneName)
    {
        //Debugger.Log("Changing to : {0} ", dSceneName);
        SceneManager.LoadScene(dSceneName);
    }
    public void ChangingSceneByIndex(int index)
    {
        SceneManager.LoadScene(index);
    }

    //切换到存档中的场景
    public void ReadSceneFileAndChange()
    {
        SceneManager.LoadScene(TxtIOManager.Instance.GetSavedSceneIndex());
    }

    //保存存档
    public void SaveFiles()
    {
        TxtIOManager.Instance.SaveFiles();
    }

    //读取存档 目前只把txtiomanager里的bool数组用存档覆盖了
    public void ReadFiles()
    {
        TxtIOManager.Instance.GetSavedConditions();
    }
}
