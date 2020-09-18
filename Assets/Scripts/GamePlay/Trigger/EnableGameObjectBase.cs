using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnableGameObjectBase : MonoBehaviour
{
    public GameObject target;

    public void SetTarget(bool ifActive)
    {
        if(target)
        {
            target.SetActive(ifActive);
        }
    }

}
