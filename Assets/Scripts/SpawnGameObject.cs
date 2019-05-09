using UnityEngine;
using System.Collections;

public class SpawnGameObject : MonoBehaviour {
    // public variables
	public float startTime;
    public float secondsBetweenSpawning;
    public GameObject[] spawnObjects; // what prefabs to spawn

    private float remainingTime;

    // Use this for initialization
    void Start()
    {
        // determine when to spawn the next object
		remainingTime = startTime;
    }

    // Update is called once per frame
    void Update()
    {
		remainingTime = remainingTime - Time.deltaTime;
		if (remainingTime < 0) {
			// Spawn the game object through function below
			makeThingToSpawn ();

			// determine the next time to spawn the object
			remainingTime = secondsBetweenSpawning;
		}
    }

    void makeThingToSpawn()
    {

        // determine which object to spawn
        int objectToSpawn = Random.Range(0, spawnObjects.Length);

        
		if (spawnObjects [objectToSpawn] != null) {
			// actually spawn the game object
			GameObject spawnedObject = Instantiate (spawnObjects [objectToSpawn], transform.position, transform.rotation) as GameObject;

			// make the parent the spawner so hierarchy doesn't get super messy
			spawnedObject.transform.parent = gameObject.transform;
		}
    }
}
