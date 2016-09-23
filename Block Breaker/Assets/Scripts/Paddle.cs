using UnityEngine;
using System.Collections;

public class Paddle : MonoBehaviour {
    
    // Update is called once per frame
    void Update () {
        float mousePosX = (Input.mousePosition.x / Screen.width) * 16;
        float paddlePosX = Mathf.Clamp(mousePosX, 0.5f, 15.5f);
        Vector3 paddlePos = new Vector3(paddlePosX, 1.15f, 0f);
        this.transform.position = paddlePos;
    }
}
