using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MusicPlayer : MonoBehaviour {

    private static MusicPlayer instance;

    public Image musicToggle;
    private AudioSource musicSrc;
    private bool musicOn = true;
    private Sprite onIcon; 
    private Sprite offIcon;

    // Keeps music playing
    void Awake () {
        if (instance) {
            Destroy(gameObject);
        } else {
            instance = this;
            DontDestroyOnLoad(gameObject);
        }
        onIcon = Resources.Load<Sprite>("musicOn 1");
        offIcon = Resources.Load<Sprite>("musicOff 1");
        musicSrc = gameObject.GetComponent<AudioSource>();
    }

    public void ToggleOnOff() {
        musicOn = !musicOn;
        if (musicOn) {
            musicToggle.GetComponent<Image>().sprite = onIcon;
            musicSrc.Play();
        } else {
            musicToggle.GetComponent<Image>().sprite = offIcon;
            musicSrc.Pause();
        }
    }

}
