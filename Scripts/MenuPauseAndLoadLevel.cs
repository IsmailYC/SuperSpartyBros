using UnityEngine;
using System.Collections;

public class MenuPauseAndLoadLevel : MonoBehaviour {

	public string levelToLoad;
	public float delay = 2f;

    void Awake()
    {
#if UNITY_STANDALONE || UNITY_WEBGL
        Camera.main.orthographicSize = 5f * 1.777251f / Camera.main.aspect;
#else
        Camera.main.aspect= 16f/9f;
#endif
    }

    // use invoke to wait for a delay then call LoadLevel
    void Update () {
		Invoke("LoadLevel",delay);
	}

	// load the specified level
	void LoadLevel() {
		Application.LoadLevel(levelToLoad);
	}
}
