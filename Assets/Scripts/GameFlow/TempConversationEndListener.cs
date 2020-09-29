using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;
using UnityEngine.Serialization;
using DialogueEditor;

public class TempConversationEndListener : MonoBehaviour
{
    [Serializable]
    public class ConversationOverEvent : UnityEvent {}

    
    [FormerlySerializedAs("onConversationOver")]
    [SerializeField]
    private ConversationOverEvent m_OnConversationOver = new ConversationOverEvent();
    public ConversationOverEvent onConversationOver
    {
        get { return m_OnConversationOver; }
        set { m_OnConversationOver = value; }
    }    
    
    public void SetFunctionToConversation()
    {
        ConversationManager.OnConversationEnded += OnConversationEnd;
    }

    void OnConversationEnd()
    {
        onConversationOver.Invoke();
        ConversationManager.OnConversationEnded -= OnConversationEnd;
        Destroy(gameObject);
    }
}
