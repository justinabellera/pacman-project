using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelAudio : MonoBehaviour
{
    public AudioClip ClipOne; // Intro
    public AudioClip ClipTwo; // Ghosts (Normal State)
    public AudioSource Intro;
    public AudioSource GhostsNormalState;

    // Start is called before the first frame update
    void Start()
    {
        StartAudio();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void StartAudio()
    {
        Intro.clip = ClipOne;
        Intro.Play();
        if (SceneManager.GetActiveScene() == SceneManager.GetSceneByName("SampleScene"))
        {
            Invoke("PlayNextTrack", Intro.clip.length);
        }
    }

    void PlayNextTrack()
    {
        Intro.Stop();
        GhostsNormalState.clip = ClipTwo;
        GhostsNormalState.Play();
    }
}