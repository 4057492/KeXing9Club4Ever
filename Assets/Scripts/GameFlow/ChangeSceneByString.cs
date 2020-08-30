using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using Custom.Log;

public class ChangeSceneByString : MonoBehaviour
{
    //public string SourceSceneName;
    public string destinationSceneName;
    public void ChangingScene()
    {
        Debugger.Log("Changing to : {0} ", destinationSceneName);
        SceneManager.LoadScene(destinationSceneName);
    } 
    public void ChangingSceneByName(string dSceneName)
    {
        Debugger.Log("Changing to : {0} ", dSceneName);
        SceneManager.LoadScene(dSceneName);
    }
}
