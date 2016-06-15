using UnityEngine;
using System.Collections;

public class ScreenCursor : MonoBehaviour
{

	// For GUI
	public Texture CursorTexture;

	// Use this for initialization
	void Start ()
	{
		Cursor.visible = false;
	}
	
	// Update is called once per frame
	void Update ()
	{
		
	}

	void OnGUI ()
	{
		GUILayout.TextArea("Screen.width:" + Screen.width.ToString() + ", Screen.height:" + Screen.height.ToString());
		GUILayout.TextArea(Input.mousePosition.ToString());

		float left = Input.mousePosition.x - CursorTexture.width / 2;
		float top = Screen.height - Input.mousePosition.y - CursorTexture.height / 2;
		GUI.DrawTexture (new Rect (
			left, 
			top, 
			CursorTexture.width, 
			CursorTexture.height), CursorTexture);
	}
}
