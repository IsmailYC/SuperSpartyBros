using UnityEngine;
using System.Collections;

public class GoToward : MonoBehaviour {

	public  Transform velocity;
	// Use this for initialization
	void Start () {
		GetComponent<Rigidbody2D> ().velocity = velocity.localPosition;
	}
}
