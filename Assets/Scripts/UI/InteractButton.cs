﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using System;
using UnityEngine.Serialization;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class InteractButton : MonoBehaviour
{
    public static InteractButton Instance { get; private set; }

    public IInteractable InteractTarget = null;
    private Button button;

    void Awake()
    {
        if (Instance != null && Instance != this)
        {
            GameObject.Destroy(this.gameObject);
        }
        Instance = this;
    }

    void Start()
    {
        button = GetComponent<Button>();
        button.interactable = false;
    }

    void OnDestroy()
    {
        Instance = null;
    }

    static public void SetInteractTarget(GameObject target)
    {
        if(target == null)
        {
            Instance.InteractTarget = null;
            return;
        }
        IInteractable temp = target.GetComponent(typeof(IInteractable)) as IInteractable;
        if(temp == null)
        {
            return;
        }
        if(Instance.InteractTarget != null)
        {
            Instance.InteractTarget.InteractUnable();
        }
        Instance.InteractTarget = temp;
    }

    static public void SetInteractButton(bool ifInteractable)
    {
        Instance.button.interactable = ifInteractable;
    }

    public void InteractInvoke()
    {
        if(InteractTarget != null)
        {
            InteractTarget.InteractInvoke();
        }
    }

    public void Operate(GameObject obj)
    {
        string name = obj.name;
        Debug.Log("Operate with " + name);
        if (name == "bedroom_switch_scene_trigger")
            SceneManager.LoadScene("listen-room");
    }
}
