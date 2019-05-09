using UnityEngine;
using System.Collections;

public class PlatformRotator : MonoBehaviour {

	public bool CCW;
	public float waitTime;
	public float rotateTime;
	public int rotationSpeed;

	bool rotating;
	float remainingTime;
	// Use this for initialization
	void Start () {
		rotating = false;
		remainingTime = waitTime;
	}
	
	// Update is called once per frame
	void Update () {
		if (remainingTime <= 0) {
			if (rotating) {
				rotating = false;
				remainingTime = waitTime;
			} else {
				rotating = true;
				remainingTime = rotateTime;
			}
		}
		remainingTime = remainingTime - Time.deltaTime;
		if (rotating) {
			transform.Rotate (0, 0, rotationSpeed * Time.deltaTime);
		} else {
			transform.rotation = Quaternion.identity;
		}
	}
}
