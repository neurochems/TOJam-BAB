using UnityEngine;
using System.Collections;

public class HeadGlow : MonoBehaviour {

	public bool isGlowing;

	private const float PULSE_RANGE = 6f;
	private const float PULSE_SPEED = 1f;

	private const float PULSE_MIN = 1f;

	private bool max;							//max intessity flag

	
	void Update () {
	
		if (isGlowing) {

			gameObject.GetComponent<Light> ().intensity = PULSE_MIN + Mathf.PingPong(Time.time * PULSE_SPEED, PULSE_RANGE - PULSE_MIN);		//pingpong intensity

			if (gameObject.GetComponent<Light> ().intensity >= 5f)						//check for max intensity value
				max = true;																// flag true
						
			if (max && gameObject.GetComponent<Light>().intensity <= 1.5f) {			//if max and then gets to min
				isGlowing = false;														//stop glowing
				//gameObject.GetComponent<Light> ().intensity = 1f;
			}

		}
	}
}
