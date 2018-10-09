using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(AudioSource))]
public class EnableNextScreen : MonoBehaviour {

    [SerializeField] GameObject canvas;
    AudioSource soundClip;
    [SerializeField] AudioClip sample;

	// Use this for initialization
	void Start () {

        soundClip = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
        
	}
    public void TransistionLevel()
    {
        canvas.gameObject.SetActive(true);
    }
    public void PlayAudio()
    {
        soundClip.PlayOneShot(sample);
    }
    
}
