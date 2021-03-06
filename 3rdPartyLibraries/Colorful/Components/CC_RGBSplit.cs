using UnityEngine;

[ExecuteInEditMode]
[AddComponentMenu("Colorful/RGB Split")]
public class CC_RGBSplit : CC_Base
{
	public float amount = 0f;
	public float angle = 0f;

	void OnRenderImage(RenderTexture source, RenderTexture destination)
	{
		material.SetFloat("_rgbShiftAmount", amount * 0.001f);
		material.SetFloat("_rgbShiftAngleCos", Mathf.Cos(angle));
		material.SetFloat("_rgbShiftAngleSin", Mathf.Sin(angle));
		Graphics.Blit(source, destination, material);
	}
}
