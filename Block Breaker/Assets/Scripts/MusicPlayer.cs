using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {

    private static MusicPlayer instance;

    // Keeps music playing
    void Awake () {
        if (instance) {
            Destroy(gameObject);
        } else {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
	}

    void Start() {

    }
	
	// Disable music on toggle
	void Update () {
	
	}
}
