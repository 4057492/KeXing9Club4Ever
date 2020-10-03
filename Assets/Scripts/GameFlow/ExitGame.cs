using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Custom.Log;

public class ExitGame : MonoBehaviour
{
    public void ExitingGame()
    {
        Debugger.Log("Exiting game.");
        Application.Quit();
    }
}
