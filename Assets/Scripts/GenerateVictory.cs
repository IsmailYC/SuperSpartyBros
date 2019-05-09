using UnityEngine;
using System.Collections;

public class GenerateVictory : MonoBehaviour {

	public GameObject[] targets;
	public GameObject victory;
	// Use this for initialization
	bool generated;
	void Start () {
		generated = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (!generated) {
			if (checkTargets ()) {
				GameObject spawnedObject = Instantiate (victory, transform.position, transform.rotation) as GameObject;
				spawnedObject.transform.parent = gameObject.transform;
			}
		}
	}

	bool checkTargets()
	{
		for (int i = 0; i < targets.Length; i++) {
			if (targets [i].layer != LayerMask.NameToLayer ("StunnedEnemy"))
				return false;
		}
		return true;
	}
}
