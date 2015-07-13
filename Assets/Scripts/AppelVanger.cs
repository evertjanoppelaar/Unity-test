﻿using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class AppelVanger : MonoBehaviour {

	public GameObject basketPrefab;
	public int numBaskets = 3;
	public float basketBottomY = -14f;
	public float basketSpacing = 2f;
	public List<GameObject> basketList;

	// Use this for initialization
	void Start () {
		basketList = new List<GameObject>();
		// Baskets neerzetten
		for (int i=0; i<numBaskets; i++) {
			GameObject tBasketGO = Instantiate(basketPrefab) as GameObject;
			Vector3 pos = Vector3.zero;
			pos.y = basketBottomY + (basketSpacing * i);
			tBasketGO.transform.position = pos;
			basketList.Add(tBasketGO);
		}
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	
	public void AppelVernietigd() {
		GameObject[] tAppleArray = GameObject.FindGameObjectsWithTag("Appel");
		foreach (GameObject tGO in tAppleArray) {
			Destroy (tGO);
		}
		int basketIndex = basketList.Count-1;
		GameObject tBasketGO = basketList[basketIndex];
		basketList.RemoveAt(basketIndex);
		Destroy(tBasketGO);
		if (basketList.Count == 0) {
			Application.LoadLevel("TestScene");
		}
	}
}