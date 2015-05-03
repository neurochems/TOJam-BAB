using UnityEngine;
using System.Collections;

public class EndCheck : MonoBehaviour {

	private CharacterController cc;

	void Start () {

		cc = GameObject.Find ("Character").GetComponent<CharacterController> ();

	}

	void Update () {
	
		if (cc.staff == true && cc.crystal == true && cc.pyramid == true && cc.cube == true && cc.scroll == true)
			gameObject.SetActive(true);

	}
}
