using UnityEngine;
using System.Collections;

public class Init_Scene04 : MonoBehaviour
{

	// シリアライズフィールド
	// 可序列化
	[SerializeField]
	GameObject gameObject1;

	// インスペクターに非表示にする
	// 在属性编辑框中进行隐藏
	[HideInInspector]
	public GameObject gameObject2;

	void Awake ()
	{
		Debug.Log ("Init_Scene04.Awake");

	}

	// Use this for initialization
	void Start ()
	{
		Debug.Log ("Init_Scene04.Start");
	
	}
	
	// Update is called once per frame
	void Update ()
	{	
		Debug.Log ("Init_Scene04.Update");
	}

	void FixedUpdate ()
	{
		Debug.Log ("Init_Scene04.FixedUpdate");

	}

	void LateUpdate ()
	{
		Debug.Log ("Init_Scene04.LateUpdate");
	}

	void OnGUI ()
	{
		GUILayout.TextArea ("ライフサイクル・生命周期", 200);
	}
}
