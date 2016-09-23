using UnityEngine;
using System.Collections;

public class Ball : MonoBehaviour {

    private Paddle paddle;
    private Vector3 p2bVector;
    private bool gameStarted;

    // Use this for initialization
    void Start () {
        paddle = FindObjectOfType<Paddle>();
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
                GetComponent<Rigidbody2D>().velocity = new Vector2(xVel, 10);
                gameStarted = true;
            }

        }
    }

    void OnCollisionEnter2D(Collision2D collision) {
        Vector2 tweak = new Vector2(Random.Range(-0.2f, 0.2f)
            , Random.Range(-0.0f, 0.2f));
        GetComponent<Rigidbody2D>().velocity += tweak;
        if (gameStarted)
            GetComponent<AudioSource>().Play();
    }
}
