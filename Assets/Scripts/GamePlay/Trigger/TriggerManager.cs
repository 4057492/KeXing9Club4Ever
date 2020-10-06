using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;
using UnityEngine.Serialization;
using DialogueEditor;

public class TriggerManager : MonoBehaviour,IInteractable
{
    [Serializable]
    public class TriggerEnterEvent : UnityEvent {}

    
    [FormerlySerializedAs("onTriggerEnter")]
    [SerializeField]
    private TriggerEnterEvent m_OnTriggerEnter = new TriggerEnterEvent();

    public TriggerEnterEvent onEnter
    {
        get { return m_OnTriggerEnter; }
        set { m_OnTriggerEnter = value; }
    }

    [Serializable]
    public class TriggerExitEvent : UnityEvent {}

    
    [FormerlySerializedAs("onTriggerExit")]
    [SerializeField]
    private TriggerExitEvent m_OnTriggerExit = new TriggerExitEvent();

    public TriggerExitEvent onExit
    {
        get { return m_OnTriggerExit; }
        set { m_OnTriggerExit = value; }
    }
    
    [Serializable]
    public class TriggerInteractEvent : UnityEvent {}

    
    [FormerlySerializedAs("onTriggerInteract")]
    [SerializeField]
    private TriggerInteractEvent m_OnTriggerInteract = new TriggerInteractEvent();

    public TriggerInteractEvent onInteract
    {
        get { return m_OnTriggerInteract; }
        set { m_OnTriggerInteract = value; }
    }

    void OnTriggerEnter( Collider other )
    {
        m_OnTriggerEnter.Invoke();
    }

    void OnTriggerExit( Collider other )
    {
        m_OnTriggerExit.Invoke();
    }

    public void InteractInvoke()
    {
        m_OnTriggerInteract.Invoke();
    }
    public void InteractUnable()
    {
        m_OnTriggerExit.Invoke();
    }

    public void LinkInteractButton(bool ifLink)
    {
        if(ifLink)
        {
            InteractButton.SetInteractTarget(gameObject);
            InteractButton.SetInteractButton(true);
        }
        else
        {
            InteractButton.SetInteractTarget(null);
            InteractButton.SetInteractButton(false);
        }
    }

    // public void TriggerNextDialogue()
    // {
    //     GameObject npc = gameObject;
    //     GameObject conversationObj = npc.transform.Find("Conversation4").gameObject;
    //     if (conversationObj != null)
    //     {
    //         conversationObj.SetActive(true);
    //         Debug.Log(conversationObj.name);

    //         // NPCConversation conversationComponent = conversationObj.GetComponent<NPCConversation>();
    //         // ConversationManager.StartConversation(conversationComponent);
    //     }
    // }

}
