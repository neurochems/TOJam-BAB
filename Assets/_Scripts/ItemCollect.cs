using UnityEngine;
using System.Collections;

public class ItemCollect : MonoBehaviour {

	private Light headLight;						//head light component

	private const float PULSE_RANGE = 8f;			//range of glow
	private const float PULSE_SPEED = 5f;			//speed of glow
	private const float PULSE_MIN = 1f;				//minimum glow

	private CharacterController counter;

	private string itemTag;
	

	void Start() {

		headLight = GameObject.Find ("Head Light").GetComponent<Light>();

		counter = GameObject.Find ("Character").GetComponent<CharacterController> ();

		itemTag = GameObject.Find ("Item").tag;

		if (itemTag == "Pyramid" && counter.pyramid == true)
			gameObject.SetActive(false);
		else if (itemTag == "Staff" && counter.staff == true)
			gameObject.SetActive(false);
		else if (itemTag == "Crystal" && counter.crystal == true)
			gameObject.SetActive(false);
		else if (itemTag == "Cube" && counter.cube == true)
			gameObject.SetActive(false);
		else if (itemTag == "Scroll" && counter.scroll == true)
			gameObject.SetActive(false);

	}


	void OnMouseDown () {							//on mouse click
			
			headLight.GetComponent<HeadGlow>().isGlowing = true;						//make head light glow a bit
	
			if (itemTag == "Pyramid")
				counter.pyramid = true;
			else if (itemTag == "Staff")
				counter.staff = true;
			else if (itemTag == "Crystal")
				counter.crystal = true;
			else if (itemTag == "Cube")
				counter.cube = true;
			else if (itemTag == "Scroll")
				counter.scroll = true;

			gameObject.SetActive(false);			//deactivate item

			//StartCoroutine("AudioClip");
	}
	

//		IEnumerator AudioClip() {



//		}

}