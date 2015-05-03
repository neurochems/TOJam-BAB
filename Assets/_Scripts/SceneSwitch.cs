using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class SceneSwitch : MonoBehaviour {

	//private float alphaFadeValue = 0f;
	//private Color fader;

	private bool transition;
	private float inten = 0;
	public bool left = false;


	void Start() {

		transition = false;
		Camera.main.GetComponent<GlitchOffset> ().intensity = 0f;

	}

	void Update() {

		if (transition) {
			inten+=Time.deltaTime*.5f;
			Camera.main.GetComponent<GlitchOffset> ().intensity = inten;


		}
	}

	void OnTriggerEnter2D(Collider2D col)
	{
		// If the player hits the trigger...
		if(col.gameObject.tag == "Character")
		{
			inten = Time.deltaTime;
			if(left){
				Camera.main.GetComponent<GlitchOffset> ().xStrength = 1;
			}else{
				Camera.main.GetComponent<GlitchOffset> ().xStrength = -1;
			}
			// ... destroy the player.
			//Destroy (col.gameObject);
			// ... reload the level.
			//fader.CrossFadeAlpha(1, 2, false);

			StartCoroutine("LoadScene");


		}
	}
	
	IEnumerator LoadScene()
	{			
		//	alphaFadeValue += Mathf.Clamp01(Time.deltaTime / 5);
		transition = true;

		// ... pause briefly
		yield return new WaitForSeconds(2);

		// ... and then reload the level.
		Application.LoadLevel(Random.Range(0,6));
	}
	
}
