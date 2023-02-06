#if UNITY_EDITOR
using System;
using System.Collections;
using System.Collections.Generic;
using Unity.Mathematics;
using UnityEditor;
using UnityEngine;

public class tester : MonoBehaviour
{
    public float3 source;
}

[CustomEditor(typeof(tester))]
public class testerE : Editor
{
    private tester tt;
    private void Awake()
    {
        tt = target as tester;
    }

    private float a = 0;
    public override void OnInspectorGUI()
    {
        base.OnInspectorGUI();
        if (GUILayout.Button("nise"))
        {
            a = noise.cnoise(tt.source);
        }
        GUILayout.Label(a.ToString());
        
    }
}
#endif