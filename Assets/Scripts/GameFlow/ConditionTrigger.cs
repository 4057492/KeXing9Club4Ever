using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;
using UnityEngine.Serialization;

public class ConditionTrigger : MonoBehaviour
{
    public bool[] conditions;
    public GameObject[] flags;

    [Serializable]
    public class ConditionEvent : UnityEvent {}

    
    [FormerlySerializedAs("onCondition")]
    [SerializeField]
    private ConditionEvent m_OnCondition = new ConditionEvent();

    public ConditionEvent onEnter
    {
        get { return m_OnCondition; }
        set { m_OnCondition = value; }
    }   

    private void Start() {
        for(int i = 0 ; i< conditions.Length ; i++)
        {
            conditions[i] = flags[i].activeInHierarchy;
        }
    }

    public void SetCondition(int index)
    {
        if(index >= 0 && index < conditions.Length)
        {
            conditions[index] = true;
            flags[index].SetActive(true);
        }
        CheckIfShouldTrigger();
    }

    void CheckIfShouldTrigger()
    {
        bool result = true;
        foreach(bool condition in conditions)
        {
            result = result & condition;
        }
        if(result)
        {
            m_OnCondition.Invoke();
        }
    }


}
