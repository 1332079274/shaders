using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScreenEffectScript : PostEffectsBase {

	// Use this for initialization
	void Start () {
        Check();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    void OnRenderImage(RenderTexture src, RenderTexture des)
    {
        if (effect_enable)
        {
            Graphics.Blit(src, des, material);
        }
        else
        {
            Graphics.Blit(src, des);
        }

    }
}
