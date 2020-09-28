using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwitchSceneControl : MonoBehaviour {
    public string roomName;

    private void OnTriggerEnter(Collider roomEdge)
    {
        Debug.Log("OnTriggerEnter " + roomName);
        if (roomEdge.CompareTag("Player"))
            SceneManager.LoadScene(roomName);
    }
}
