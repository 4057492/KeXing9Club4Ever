using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterTele : MonoBehaviour
{
    public void Tele(Transform target)
    {
        if(target)
        {
            Vector3 temp = target.position;
            temp.z = transform.position.z;
            transform.position = temp;
        }
    }
}
