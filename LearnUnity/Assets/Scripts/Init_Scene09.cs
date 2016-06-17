using UnityEngine;
using System.Collections;

public class Init_Scene09 : MonoBehaviour
{

	private Quaternion[] rotationValues;

	// Use this for initialization
	void Start ()
	{
		rotationValues = new Quaternion[55];

		for (var i = 0; i < rotationValues.Length; i++) {
			GameObject cylinder = GameObject.CreatePrimitive (PrimitiveType.Cylinder);
			cylinder.transform.localScale = new Vector3 (0.3f, 3, 0.3f);
			cylinder.transform.position = new Vector3 (0, 3, 0);


			//rotationValues [i] = Random.rotation;
			rotationValues [i] = Random.rotationUniform;
			cylinder.transform.rotation = rotationValues[i];
			cylinder.GetComponent<MeshRenderer>().material.color = new Color(Random.value, Random.value, Random.value);
		}
	}
	
	// Update is called once per frame
	void Update ()
	{
	
	}

	void OnGUI(){
		GUILayout.TextArea("随机生成圆柱体，并旋转角度");
	}
}
