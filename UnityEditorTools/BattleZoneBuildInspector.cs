using UnityEngine;
using UnityEditor;
using System.Collections;
using System.Collections.Generic;

//[CanEditMultipleObjects]
//[CustomPreviewAttribute(typeof(BattleZoneBuild))]
public class BattleZoneBuildInspector : Editor
{
    //#region stage
    //SerializedProperty normalStage;
    //SerializedProperty diffStage;
    //SerializedProperty hellStage;
    //#endregion

    //SerializedProperty normalZone1;
    //SerializedProperty normalZone2;
    //SerializedProperty normalZone3;

    //SerializedProperty diffZone1;
    //SerializedProperty diffZone2;
    //SerializedProperty diffZone3;

    //SerializedProperty hellZone1;
    //SerializedProperty hellZone2;
    //SerializedProperty hellZone3;



    //SerializedProperty zoneDiff;
    //SerializedProperty zonePrefix;
    //SerializedProperty zoneIndex;
    //SerializedProperty stageTypeArrayStr;


    //private SerializedObject mBattleZoneBuildOS;
    //private BattleZoneBuild mBattleZoneBuild;
    //void OnEnable()
    //{
    //    normalStage = serializedObject.FindProperty("normalStage");
    //    diffStage = serializedObject.FindProperty("diffStage");
    //    hellStage = serializedObject.FindProperty("hellStage");

    //    normalZone1 = serializedObject.FindProperty("normalZone1");
    //    normalZone2 = serializedObject.FindProperty("normalZone2");
    //    normalZone3 = serializedObject.FindProperty("normalZone3");

    //    diffZone1 = serializedObject.FindProperty("diffZone1");
    //    diffZone2 = serializedObject.FindProperty("diffZone2");
    //    diffZone3 = serializedObject.FindProperty("diffZone3");

    //    hellZone1 = serializedObject.FindProperty("hellZone1");
    //    hellZone2 = serializedObject.FindProperty("hellZone2");
    //    hellZone3 = serializedObject.FindProperty("hellZone3");

    //    zoneDiff = serializedObject.FindProperty("zoneDiff");
    //    zonePrefix = serializedObject.FindProperty("zonePrefix");
    //    zoneIndex = serializedObject.FindProperty("zoneIndex");
    //    stageTypeArrayStr = serializedObject.FindProperty("stageTypeArrayStr");
    //}
    public override void OnInspectorGUI()
    {
        //serializedObject.Update();
        //DrawStageBox();
        //DrawNormalZoneBox();
        //DrawDiffZoneBox();
        //DrawHellZoneBox();
        //DrawInput();
        string str= "1";
        EditorGUILayout.LabelField("|", str);
        Debug.Log(1);
    }

    //private void DrawStageBox()
    //{
    //    GUILayout.Label("Stage Prefabs");
    //    EditorGUILayout.BeginVertical("Box");
    //    EditorGUILayout.PropertyField(normalStage, new GUIContent("normalStage"));
    //    serializedObject.ApplyModifiedProperties();
    //    EditorGUILayout.PropertyField(diffStage, new GUIContent("diffStage"));
    //    serializedObject.ApplyModifiedProperties();
    //    EditorGUILayout.PropertyField(hellStage, new GUIContent("hellStage"));
    //    serializedObject.ApplyModifiedProperties();
    //    EditorGUILayout.EndVertical();
    //}
    //private void DrawNormalZoneBox()
    //{
    //    GUILayout.Label("Normal Prefabs");
    //    EditorGUILayout.BeginVertical("Box");
    //    EditorGUILayout.PropertyField(normalZone1, new GUIContent("normalZone1"));
    //    serializedObject.ApplyModifiedProperties();
    //    EditorGUILayout.PropertyField(normalZone2, new GUIContent("normalZone2"));
    //    serializedObject.ApplyModifiedProperties();
    //    EditorGUILayout.PropertyField(normalZone3, new GUIContent("normalZone3"));
    //    serializedObject.ApplyModifiedProperties();
    //    EditorGUILayout.EndVertical();
    //}
    //private void DrawDiffZoneBox()
    //{
    //    GUILayout.Label("Diff Prefabs");
    //    EditorGUILayout.BeginVertical("Box");
    //    EditorGUILayout.PropertyField(diffZone1, new GUIContent("diffZone1"));
    //    serializedObject.ApplyModifiedProperties();
    //    EditorGUILayout.PropertyField(diffZone2, new GUIContent("diffZone2"));
    //    serializedObject.ApplyModifiedProperties();
    //    EditorGUILayout.PropertyField(diffZone3, new GUIContent("diffZone3"));
    //    serializedObject.ApplyModifiedProperties();
    //    EditorGUILayout.EndVertical();
    //}
    //private void DrawHellZoneBox()
    //{
    //    GUILayout.Label("Hell Prefabs");
    //    EditorGUILayout.BeginVertical("Box");
    //    EditorGUILayout.PropertyField(hellZone1, new GUIContent("Hell Zone1"));
    //    serializedObject.ApplyModifiedProperties();
    //    EditorGUILayout.PropertyField(hellZone2, new GUIContent("Hell Zone2"));
    //    serializedObject.ApplyModifiedProperties();
    //    EditorGUILayout.PropertyField(hellZone3, new GUIContent("Hell Zone3"));
    //    serializedObject.ApplyModifiedProperties();
    //    EditorGUILayout.EndVertical();
    //}


    //private void DrawInput()
    //{
    //    GUILayout.Label("Input");
    //    EditorGUILayout.BeginVertical("Box");
    //    EditorGUILayout.PropertyField(zoneDiff, new GUIContent("Zone Difficulty"));
    //    serializedObject.ApplyModifiedProperties();
    //    EditorGUILayout.PropertyField(zonePrefix, new GUIContent("Zone Prefix"));
    //    serializedObject.ApplyModifiedProperties();
    //    EditorGUILayout.PropertyField(zoneIndex, new GUIContent("Zone Index"));
    //    serializedObject.ApplyModifiedProperties();
    //    EditorGUILayout.PropertyField(stageTypeArrayStr, new GUIContent("Stage Array"));
    //    serializedObject.ApplyModifiedProperties();
    //    EditorGUILayout.EndVertical();
    //}
}
