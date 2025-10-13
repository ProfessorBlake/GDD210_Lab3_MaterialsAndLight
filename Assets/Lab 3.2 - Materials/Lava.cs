using UnityEngine;

public class Lava : MonoBehaviour
{
    public MeshRenderer Mesh;

	private void Start()
	{
		Mesh = GetComponent<MeshRenderer>();
	}

	private void Update()
	{
		Mesh.sharedMaterial.SetTextureOffset("_MainTex", new Vector2(0f, Mathf.Sin(Time.time * 0.1f)));
	}
}
