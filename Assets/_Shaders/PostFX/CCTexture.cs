using UnityEngine;
using System.Collections;

[System.Serializable]
public class CCTexture{

	public Texture texture;
	public Vector4 scaleTranslate = new Vector4(1,1,0,0);
	public Vector4 scaleTranslatePerSecond = Vector4.zero;

	void OnInspectorGUI () {
		Debug.Log("2237049");
	}

	// Update is called once per frame
	public void Update (){
		scaleTranslate += scaleTranslatePerSecond*Time.deltaTime;
	}
}

