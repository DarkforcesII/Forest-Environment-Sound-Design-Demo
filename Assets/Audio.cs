using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    [Tooltip("This is where you can place your own music into the scene.")]
    public AudioClip musicClip;
    [Tooltip("This is where you can place your footstep sfx into the scene. " +
        "You can change the amount of clips by changing the size number")]
    public AudioClip[] footSteps;
    [Tooltip("This is where you can place your jump sfx into the scene. " +
        "You can change the amount of clips by changing the size number")]
    public AudioClip[] jumpClips;
    [Tooltip("This is where you can place your land sfx into the scene. " +
        "You can change the amount of clips by changing the size number")]
    public AudioClip[] landClips;
    public AudioSource musicSource;
    public AudioSource footStepSource;
    public AudioSource jumpSource;
    public AudioSource landSource;

    private void Start()
    {
        musicSource.clip = musicClip;
        musicSource.loop = true;
        musicSource.Play();
    }

    public void PlayFootSteps()
    {
        footStepSource.PlayOneShot(footSteps[Random.Range(0, footSteps.Length)]);
    }

    public void PlayJumpClips()
    {
        jumpSource.PlayOneShot(jumpClips[Random.Range(0, jumpClips.Length)]);
    }

    public void PlayLandClips()
    {
        landSource.PlayOneShot(landClips[Random.Range(0, landClips.Length)]);
        footStepSource.PlayOneShot(footSteps[Random.Range(0, footSteps.Length)]);
    }
}
