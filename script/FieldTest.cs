using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class FieldTest : MonoBehaviour
{
	public bool b_DispColorSetting = false;
	[HideInInspector] public Color ObjectColor = Color.red;
	
	void Start()
	{
		// this.GetComponent<Renderer>().sharedMaterial.SetColor("_Color", ObjectColor);
		this.GetComponent<Renderer>().material.SetColor("_Color", ObjectColor);
	}
}
