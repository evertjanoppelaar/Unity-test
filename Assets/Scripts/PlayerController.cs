using UnityEngine;
using System.Collections;

public class PlayerController : MonoBehaviour {

	public float speed = 3f;

	public Color basiskleurStart;

	public Color basiskleurVariant;

	private bool gaatVooruit = true;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (gaatVooruit == true) {	
			transform.Translate (Vector3.forward * Time.deltaTime * speed);
		} 
		else {
			transform.Translate (Vector3.back * Time.deltaTime * speed);
		}
	}

	void OnCollisionEnter(Collision other) {
		if (other.gameObject.tag == "GrensObject") {
			Material gebotstMateriaal = other.gameObject.GetComponent<MeshRenderer> ().material;

			if (gaatVooruit == true) {
				gaatVooruit = false;
			} else {
				gaatVooruit = false;
			}

			if (gebotstMateriaal.color == basiskleurStart) {
				gebotstMateriaal.color = basiskleurVariant;
			} else {
				gebotstMateriaal.color = basiskleurStart;
			}
		}
	}
}
