using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;

public class OnConversationUIChange : MonoBehaviour
{
    public CharacterMove characterMove;
    public SetMultiGameobjecsActive MainHUBControl;
    public SetMultiGameobjecsActive NotebookHUBControl;
    // Start is called before the first frame update
    void OnEnable()
    {
        ConversationManager.OnConversationStarted += OnConversationStart;
        ConversationManager.OnConversationEnded += OnConversationEnd;
    }
    void OnDisable()
    {
        ConversationManager.OnConversationStarted -= OnConversationStart;
        ConversationManager.OnConversationEnded -= OnConversationEnd;
    }

    void OnConversationStart()
    {
        if(MainHUBControl)
        {
            MainHUBControl.SetTargetsActive(false);
        }
        if(characterMove)
        {
            characterMove.StopMove();
        }
        if(NotebookHUBControl)
        {
            NotebookHUBControl.SetTargetsActive(false);
        }
    }

    void OnConversationEnd()
    {
        if (MainHUBControl)
        {
            MainHUBControl.SetTargetsActive(true);
        }
    }

}
