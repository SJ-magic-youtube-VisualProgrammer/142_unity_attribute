using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEditor;

[CustomEditor(typeof(FieldTest))]
public class FieldTestEditor : Editor
{
	public override void OnInspectorGUI()
	{
		base.OnInspectorGUI();
		
		FieldTest instance = target as FieldTest;
		
		if (instance.b_DispColorSetting){
			instance.ObjectColor = EditorGUILayout.ColorField("ObjectColor", instance.ObjectColor);
		}
	}
}
