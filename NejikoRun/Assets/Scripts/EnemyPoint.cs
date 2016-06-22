using UnityEngine;
using System.Collections;

public class EnemyPoint : MonoBehaviour
{
	public GameObject prefab;

	// Use this for initialization
	void Start ()
	{
		GameObject go = Instantiate (prefab, Vector3.zero, Quaternion.identity) as GameObject;

		go.transform.SetParent (transform, false);
	}

	void OnDrawGizmos ()
	{
		Vector3 offset = new Vector3 (0, 0.5f, 0);

		Gizmos.color = new Color (1, 0, 0, 0.5f);
		Gizmos.DrawSphere (transform.position + offset, 0.5f);

		if (prefab != null)
			Gizmos.DrawIcon (transform.position + offset, prefab.name, true);
	}

}
