using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;
using UnityEngine.Serialization;

public class ConditionTrigger : MonoBehaviour
{
    public bool[] conditions;

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

    public void SetCondition(int index)
    {
        if(index >= 0 && index < conditions.Length)
        {
            conditions[index] = true;
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
