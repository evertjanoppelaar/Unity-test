using UnityEngine;
using System.Collections;

public class AppelBoom : MonoBehaviour {
	
	// Hier komen variabelen
	public GameObject applePrefab;
	public float speed = 10f;
	public float leftAndRightEdge = 20f;
	public float chanceToChangeDirections = 0.1f;
	public float secondsBetweenAppleDrops = 1f;
	
	// Use this for initialization
	void Start () {
		InvokeRepeating("LaatAppelVallen", 2f, secondsBetweenAppleDrops);
	}
	
	void LaatAppelVallen() {
		GameObject apple = Instantiate(applePrefab) as GameObject;
		apple.transform.position = transform.position;
	}
	
	// Update is called once per frame
	void Update () {
		// Basisbeweging
		Vector3 pos = transform.position;
		pos.x += speed * Time.deltaTime;
		transform.position = pos;
		
		//omkeren aan de rand
		if (pos.x < -leftAndRightEdge) {
			speed = Mathf.Abs(speed); //naar rechts bewegen
		}
		else if (pos.x > leftAndRightEdge) {
			speed = -Mathf.Abs(speed); //naar links bewegen
		}
	}
	
	void FixedUpdate() {
		if (Random.value < chanceToChangeDirections) {
			speed *= -1;
		}
	}
}
