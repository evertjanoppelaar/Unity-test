using UnityEngine;
using System.Collections;

public class Appel : MonoBehaviour {

	public static float bottomY = -20f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < bottomY) {
			Destroy(this.gameObject);
			AppelVanger apScript = Camera.main.GetComponent<AppelVanger>();
			apScript.AppelVernietigd();
		}
	}
}
