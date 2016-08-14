using UnityEngine;
using System.Collections;

public class Move : MonoBehaviour {

	public GameObject Cube;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey ("d"))
			Cube.transform.Translate(Vector2.right);

		if (Input.GetKey ("a"))
			Cube.transform.Translate(Vector2.left);
	
		if (Input.GetKey ("w"))
			Cube.transform.Translate(Vector2.up);

		if (Input.GetKey ("s"))
			Cube.transform.Translate(Vector2.down);
	}
}
