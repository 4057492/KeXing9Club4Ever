using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ChangeSceneByString : MonoBehaviour
{
    //public string SourceSceneName;
    public string destinationSceneName;
    public void ChangingScene()
    {
        SceneManager.LoadScene(destinationSceneName);
    } 
}
