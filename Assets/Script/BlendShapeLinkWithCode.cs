using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BlendShapeLinkWithCode : MonoBehaviour {

	[SerializeField] SkinnedMeshRenderer skinnedMeshRenderer;
	[SerializeField] GUISkin skin;

	void OnGUI()
	{
		float horizontalSliderPos0 = skinnedMeshRenderer.GetBlendShapeWeight(0);
		float horizontalSliderPos1 = skinnedMeshRenderer.GetBlendShapeWeight(1);
		float horizontalSliderPos2 = skinnedMeshRenderer.GetBlendShapeWeight(2);
		float horizontalSliderPos3 = skinnedMeshRenderer.GetBlendShapeWeight(3);
		GUI.skin = skin;

		GUILayout.Label ("frown");
		horizontalSliderPos0 = GUILayout.HorizontalSlider (horizontalSliderPos0, 0, 100f );
		skinnedMeshRenderer.SetBlendShapeWeight(0, horizontalSliderPos0);
		GUILayout.Label ("sneer");
		horizontalSliderPos1 = GUILayout.HorizontalSlider (horizontalSliderPos1, 0, 100f );
		skinnedMeshRenderer.SetBlendShapeWeight(1, horizontalSliderPos1);
		GUILayout.Label ("R_bottomBlink");
		horizontalSliderPos2 = GUILayout.HorizontalSlider (horizontalSliderPos2, 0, 100f );
		skinnedMeshRenderer.SetBlendShapeWeight(2, horizontalSliderPos2);
		GUILayout.Label ("L_bottomBlink");
		horizontalSliderPos3 = GUILayout.HorizontalSlider (horizontalSliderPos3, 0, 100f );
		skinnedMeshRenderer.SetBlendShapeWeight(3, horizontalSliderPos3);
//		skinnedMeshRenderer.SetBlendShapeWeight(0, horizontalSliderPos0);

//		horizontalSliderPos2 = GUI.HorizontalSlider(new Rect(25, 75, 100, 30), horizontalSliderPos2, 0.0F, 100.0F);
//		skinnedMeshRenderer.SetBlendShapeWeight(1, horizontalSliderPos2);
//
//		horizontalSliderPos3 = GUI.HorizontalSlider(new Rect(25, 125, 100, 30), horizontalSliderPos3, 0.0F, 100.0F);
//		skinnedMeshRenderer.SetBlendShapeWeight(2, horizontalSliderPos3);
	}
}
