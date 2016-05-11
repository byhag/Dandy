using UnityEngine;
using System.Collections;

public class MoveImage : MonoBehaviour {

	private bool goLeft = true;
	public Vector3 leftBound;
	public Vector3 rightBound;
	public float speed = 1f;
	private float startTime;
	private float distance;

	// Use this for initialization
	void Start () {
		startTime = Time.time;
		distance = Vector3.Distance(leftBound, rightBound);
	}
	
	// Update is called once per frame
	void Update () {
		
		float distCovered = (Time.time - startTime) * speed;
		float fracOfDist = distCovered / distance;

		if (goLeft)
			transform.position = Vector3.Lerp(rightBound, leftBound, fracOfDist);
		else
			transform.position = Vector3.Lerp(leftBound, rightBound, fracOfDist);

		if (transform.position.x <= leftBound.x) {
			goLeft = false;
			startTime = Time.time;
		}
		else if (transform.position.x >= rightBound.x)  {
			goLeft = true;
			startTime = Time.time;
		}
			
	}
}
