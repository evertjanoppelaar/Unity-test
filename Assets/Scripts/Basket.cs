using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class Basket : MonoBehaviour {
	Text scoreText;

	// Use this for initialization
	void Start () {
		GameObject scoreGO = GameObject.Find("ScoreTeller");
		scoreText = scoreGO.GetComponent<Text>();
		scoreText.text = "0";
	}
	
	// Update is called once per frame
	void Update () {
		//Huidige schermpositie van de muis
		Vector3 mousePos2D = Input.mousePosition;
		
		//Diepte moet gelijk zijn aan cameradiepte
		mousePos2D.z = Camera.main.transform.position.z;
		
		//Converteer het punt van 2D schermruimte naar 3D game world space
		Vector3 mousePos3D = Camera.main.ScreenToWorldPoint(mousePos2D);
		
		//Beweeg de x-positie van de basket mee met de muis
		Vector3 pos = this.transform.position;
		pos.x = mousePos3D.x;
		this.transform.position = pos;
	}
	
	void OnCollisionEnter(Collision coll) {
		GameObject meeGebotst = coll.gameObject;
		if (meeGebotst.tag == "Appel") {
			Destroy(meeGebotst);
			int score = int.Parse(scoreText.text);
			score += 100;
			scoreText.text = score.ToString();
		}
	}
}
