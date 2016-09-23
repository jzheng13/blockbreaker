using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

    public Paddle paddle;

    private Vector3 p2bVector;
    private bool gameStarted;

    // Use this for initialization
    void Start () {
        p2bVector = this.transform.position - paddle.transform.position;
    }
    
    // Update is called once per frame
    void Update () {
        if (!gameStarted) { 

            // Lock ball position
            this.transform.position = paddle.transform.position + p2bVector;

            // Launch ball
            if (Input.GetMouseButtonDown(0)) {
                float xVel = Random.Range(-2f, 2f);
                this.GetComponent<Rigidbody2D>().velocity 
                    = new Vector2(xVel, 10);
                gameStarted = true;
            }

        }
    }
}
