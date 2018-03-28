using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Audio;
#if UNITY_EDITOR
using UnityEditor;
#endif

public class PauseController : MonoBehaviour {

    public AudioMixerSnapshot paused;
    public AudioMixerSnapshot unpaused;

    private Canvas canvas;

	// Use this for initialization
	void Start () {
        canvas = GetComponent<Canvas>();
	}

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            // PAUSE THE GAME
            Pause();
        }
    }

    public void Pause()
    {
        canvas.enabled = !canvas.enabled; // Toggle
        Time.timeScale = Time.timeScale == 0 ? 1 : 0; // Toggle
        ChangeSound();
    }

    void ChangeSound()
    {
        if(Time.timeScale == 0)
        {
            // PAUSED
            paused.TransitionTo(0.01f);
        } 
        else
        {
            // NOT PAUSED
            unpaused.TransitionTo(0.01f);
        }
    }

    public void Quit()
    {
#if UNITY_EDITOR
        EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
    }
}
