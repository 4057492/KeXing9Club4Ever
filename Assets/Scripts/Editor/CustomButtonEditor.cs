using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;
using System;


[CustomEditor(typeof(CustomButton))]
public class CustomButtonEditor : Editor
{
    SerializedProperty m_OnPointerUp;
    SerializedProperty m_OnPointerDown;
    void OnEnable()
    {
        m_OnPointerUp = serializedObject.FindProperty("m_OnPointerUp");
        m_OnPointerDown = serializedObject.FindProperty("m_OnPointerDown");
    }

/*    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        
        EditorGUILayout.Space();

        serializedObject.Update();
        EditorGUILayout.PropertyField(m_OnPointerUp);
        EditorGUILayout.PropertyField(m_OnPointerDown);
        serializedObject.ApplyModifiedProperties();
    }*/
}
