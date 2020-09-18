using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SetMultiGameobjecsActive : MonoBehaviour
{
    public GameObject[] targets;
    
    public void SetTargetsActive(bool ifActive)
    {
        if (targets.Length == 0)
        {
            return;
        }
        foreach(GameObject target in targets)
        {
            target.SetActive(ifActive);
        }
    }
}
