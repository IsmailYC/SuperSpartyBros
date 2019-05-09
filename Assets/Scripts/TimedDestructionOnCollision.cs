using UnityEngine;
using System.Collections;

public class TimedDestructionOnCollision : MonoBehaviour {

	public float time;
	public GameObject target;

	void OnCollisionEnter2D(Collision2D coll)
	{
		if(coll.gameObject.tag.Equals(target.tag))
			Destroy (gameObject, time);
	}
}
