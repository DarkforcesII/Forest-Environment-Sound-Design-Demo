using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioClip[] footSteps;
    public AudioClip[] jumpClips;
    public AudioClip[] landClips;
    public AudioSource footStepSource;
    public AudioSource jumpSource;
    public AudioSource landSource;

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
