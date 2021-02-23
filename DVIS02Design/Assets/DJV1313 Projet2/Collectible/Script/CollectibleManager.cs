using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class CollectibleManager : MonoBehaviour {

	Text counterText;
	int collectibleTotal;

	// Use this for initialization
	void Start () {
		counterText = GetComponent<Text>();
		CollectibleScript[] collectibles = FindObjectsOfType(typeof(CollectibleScript)) as CollectibleScript[];

		collectibleTotal = collectibles.Length;

		counterText.text = "0 / "+collectibleTotal;
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		CollectibleScript[] collectibles = FindObjectsOfType(typeof(CollectibleScript)) as CollectibleScript[];
		counterText.text = collectibleTotal-collectibles.Length+" / "+collectibleTotal;
	}
}