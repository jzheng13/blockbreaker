using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour {

	public void LoadLevel(string lvl) {
        SceneManager.LoadScene(lvl);
    }

    public void QuitRequest() {
        Application.Quit();
    }
}
