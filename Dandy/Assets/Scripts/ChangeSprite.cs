using UnityEngine;
using System.Collections;

public class ChangeSprite : MonoBehaviour {

	public float threshold;
	public Sprite otherSprite;
	private Sprite mainSprite;

	// Use this for initialization
	void Start () {
		mainSprite = GetComponent<SpriteRenderer>().sprite;
	}
	
	// Update is called once per frame
	void Update () {
		if (transform.position.y < threshold) {
			GetComponent<SpriteRenderer>().sprite = otherSprite;
		}
		else {
			GetComponent<SpriteRenderer>().sprite = mainSprite;
		}
	}
}
