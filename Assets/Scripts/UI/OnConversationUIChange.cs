using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DialogueEditor;
using UnityEngine.SceneManagement;

public class OnConversationUIChange : MonoBehaviour
{
    public CharacterControl characterControl;
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
        if(characterControl)
        {
            characterControl.Freeze();
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
        if(characterControl)
        {
            characterControl.Defreeze();
        }
    }

}
