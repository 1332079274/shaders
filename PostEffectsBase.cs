using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
[RequireComponent (typeof(Camera))]
public class PostEffectsBase : MonoBehaviour {

	public Shader shader;
	public Material material;

	protected bool effect_enable = false;

	protected void Check() {
		if (!SystemInfo.supportsImageEffects) {
			effect_enable = false;
			return;
		}

		if (!shader || !shader.isSupported || 
			!material || material.shader != shader) {
			effect_enable = false;
			return;
		}

		effect_enable = true;
	}

	// Use this for initialization
	void Start () {
		Check();
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
