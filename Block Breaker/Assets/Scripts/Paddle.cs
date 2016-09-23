using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {

    private Ball ball;
    public bool auto = true;

    void Start () {
        ball = FindObjectOfType<Ball>();
    }

    
    // Update is called once per frame
    void Update () {
        if (auto) {
            AutoPlay();
        } else {
            ManualPlay();
        }
        
    }

    void ManualPlay() {
        float mousePosX = (Input.mousePosition.x / Screen.width) * 16;
        float paddlePosX = Mathf.Clamp(mousePosX, 1f, 15f);
        Vector3 paddlePos = new Vector3(paddlePosX, transform.position.y, 0f);
        this.transform.position = paddlePos;
    }

    void AutoPlay () {
        float ballPosX = Mathf.Clamp(ball.transform.position.x, 1f, 15f);
        Vector3 paddlePos = new Vector3(ballPosX, transform.position.y, 0f);
        this.transform.position = paddlePos;

    }
}
