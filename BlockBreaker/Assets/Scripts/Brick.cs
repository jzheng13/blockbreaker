using UnityEngine;
using System.Collections;

public class Brick : MonoBehaviour {

    public Sprite[] hitSprites;
    public static int breakableCount = 0;
    public AudioClip crack;

    private LevelManager levelManager;
    private int maxHits;
    private int timesHit;
    private bool isBreakable;

    void Start () {
        isBreakable = this.tag == "Breakable";
        if (isBreakable) {
            breakableCount++;
        }
        levelManager = FindObjectOfType<LevelManager>();
        timesHit = 0;
        maxHits = hitSprites.Length + 1;
    }

    void OnCollisionEnter2D (Collision2D collision) {
        AudioSource.PlayClipAtPoint(crack, transform.position);
        if (isBreakable)
            HandleHits();
    }

    void HandleHits () {
        timesHit++;
        if (timesHit >= maxHits) {
            breakableCount--;
            levelManager.BrickDestroyed();
            Destroy(gameObject);
        } else {
            LoadSprites();
        }
    }

    void LoadSprites() {
        int spriteIndex = timesHit - 1;
        GetComponent<SpriteRenderer>().sprite = hitSprites[spriteIndex]; 
    }
}
