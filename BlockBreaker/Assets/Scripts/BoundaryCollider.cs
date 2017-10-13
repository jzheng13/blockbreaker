using UnityEngine;
using System.Collections;

public class BoundaryCollider : MonoBehaviour {

    private LevelManager levelManager;

    void Start() {
        levelManager = FindObjectOfType<LevelManager>();
    }

    void OnTriggerEnter2D (Collider2D collider) {
        levelManager.LoadLevel("Lose");
    }

}
