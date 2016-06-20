using UnityEngine;
using System.Collections;

public class komaCube : MonoBehaviour
{

	public void hide (bool flg)
	{
		Debug.Log("komaCube.hide.flg:" + flg);
		this.gameObject.SetActive (flg);
	}
}
