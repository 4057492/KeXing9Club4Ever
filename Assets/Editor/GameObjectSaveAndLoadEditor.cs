// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;
// using UnityEditor;

// [CustomEditor(typeof(GameObjectSaveAndLoad))]
// public class GameObjectSaveAndLoadEditor : Editor 
// {
//     GameObjectSaveAndLoad g;
//     void OnEnable()
//     {
//         g = target as GameObjectSaveAndLoad;
//     }
//     public override void OnInspectorGUI() 
//     {
//         base.OnInspectorGUI();
//         /*if(GUILayout.Button("Collect"))
//         {
//             CollectGameObject();
//         }*/
//         if(GUILayout.Button("Use Selection"))
//         {
//             if(Selection.gameObjects.Length > 0)
//             {
//                 g.saveGameObjectList = Selection.gameObjects;
//             }
//         }
//         /*if(GUILayout.Button("Fill Start Active"))
//         {
//             g.FillStart();
//         } 
//         if(GUILayout.Button("Set All Active"))
//         {
//             g.SetAllActive();
//         } */
//         /*if(GUILayout.Button("Test Save"))
//         {
//             g.SaveGame();
//         }
//         if(GUILayout.Button("Test Load"))
//         {
//             g.Load();
//         }*/
//     }
//     private void CollectGameObject()
//     {
//         g.saveGameObjectList = GameObject.FindGameObjectsWithTag("Save");
//     }
// }
