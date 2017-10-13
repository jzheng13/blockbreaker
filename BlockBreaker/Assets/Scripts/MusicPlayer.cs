using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class MusicPlayer : MonoBehaviour {

    private static MusicPlayer instance;

    private Image musicToggle;
    private AudioSource musicSrc;
    private bool musicOn = false;
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
        musicSrc = gameObject.GetComponent<AudioSource>();
        onIcon = Resources.Load<Sprite>("musicOn 1");
        offIcon = Resources.Load<Sprite>("musicOff 1");
    }

    void Start()
    {
        musicToggle = GameObject.Find("MusicToggle").GetComponent<Image>();
        if (!musicOn) { 
            musicSrc.Play();
            musicOn = true;
            musicToggle.GetComponent<Image>().sprite = onIcon;
        }       
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

    void OnDisable()
    {
        Debug.Log("Something's wrong here.");
    }

}
