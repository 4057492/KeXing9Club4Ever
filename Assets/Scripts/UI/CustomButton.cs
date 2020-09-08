using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using System;
using UnityEngine.Serialization;

[AddComponentMenu("UI/CustomButton", 0)]
public class CustomButton : Button, IPointerDownHandler, IPointerUpHandler
{
    [Serializable]
    public class ButtonPointerUpEvent : UnityEvent {}

    
    [FormerlySerializedAs("onPointerUp")]
    [SerializeField]
    private ButtonPointerUpEvent m_OnPointerUp = new ButtonPointerUpEvent();

    [Serializable]
    public class ButtonPointerDownEvent : UnityEvent {}

    
    [FormerlySerializedAs("onPointerDown")]
    [SerializeField]
    private ButtonPointerDownEvent m_OnPointerDown = new ButtonPointerDownEvent();

    protected CustomButton()
    {}
    
    public ButtonPointerUpEvent onPointerUp
    {
        get { return m_OnPointerUp; }
        set { m_OnPointerUp = value; }
    }
    public ButtonPointerDownEvent onPointerDown
    {
        get { return m_OnPointerDown; }
        set { m_OnPointerDown = value; }
    }

    private void PointerUp()
    {
        if (!IsActive() || !IsInteractable())
            return;

        UISystemProfilerApi.AddMarker("Button.onPointerUp", this);
        m_OnPointerUp.Invoke();
    }

    private void PointerDown()
    {
        if (!IsActive() || !IsInteractable())
            return;

        UISystemProfilerApi.AddMarker("Button.onPointerDown", this);
        m_OnPointerDown.Invoke();
    }
    public virtual void OnPointerUp(PointerEventData eventData)
    {
        if (eventData.button != PointerEventData.InputButton.Left)
            return;

        PointerUp();
    }
    public virtual void OnPointerDown(PointerEventData eventData)
    {
        if (eventData.button != PointerEventData.InputButton.Left)
            return;

        PointerDown();
    }

}
