using UnityEngine;
using System.Collections;

public class Init_Scene03 : MonoBehaviour
{
	public Material CubeMaterial;
	public Material BulletMaterial;

	public GameObject BulletSoundEffect;

	// Use this for initialization
	void Start ()
	{
		Init ();
	}
	
	// Update is called once per frame
	void Update ()
	{
		Fire ();
	}

	void Init ()
	{
		for (int i = 0; i < 9; i++) {
			for (int j = 0; j < 9; j++) {
				GameObject cube = GameObject.CreatePrimitive (PrimitiveType.Cube);
				cube.transform.position = new Vector3 (i - 4, j + 0.5f, 4);
				cube.transform.localScale = new Vector3 (1, 1, 1);
				cube.GetComponent<MeshRenderer> ().material = CubeMaterial; //Resources.Load ("Materials/CubeYellow", typeof(Material)) as Material;
				cube.AddComponent<Rigidbody> ();
				cube.AddComponent<AutoDestroy> ();
			}
		}
	}

	void Fire ()
	{
		if (Input.GetMouseButtonDown (0)) {
			GameObject bullet = GameObject.CreatePrimitive (PrimitiveType.Sphere);
			bullet.transform.position = Camera.main.transform.position;
			bullet.AddComponent<Rigidbody> ();
			bullet.AddComponent<AutoDestroy>();
			bullet.GetComponent<MeshRenderer> ().material = BulletMaterial;

			Vector3 targetPos = Camera.main.ScreenToWorldPoint (new Vector3 (Input.mousePosition.x, Input.mousePosition.y, 10));

			bullet.GetComponent<Rigidbody> ().mass = 2;
			bullet.GetComponent<Rigidbody> ().AddForce ((targetPos - Camera.main.transform.position) * 10, ForceMode.Impulse);

			BulletSoundEffect.GetComponent<AudioSource>().Play();
		}
	}
}
