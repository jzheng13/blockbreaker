using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string lvl) {
        Brick.breakableCount = 0;
        SceneManager.LoadScene(lvl);
    }

    public void QuitRequest() {
        Application.Quit();
    }

    public void BrickDestroyed() {
        if (Brick.breakableCount <= 0) {
            Brick.breakableCount = 0;
            LoadNextLevel();
        }
    }

    private void LoadNextLevel() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}
