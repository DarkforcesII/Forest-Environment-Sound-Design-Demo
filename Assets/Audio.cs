using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Audio : MonoBehaviour
{
    public AudioClip[] footSteps;
    private AudioSource sfxSource;
    bool hasPlayed = false;

    // Start is called before the first frame update
    void Start()
    {
        sfxSource = GetComponent<AudioSource>();
    }

    public void PlayFootSteps()
    {
        sfxSource.PlayOneShot(footSteps[Random.Range(0, footSteps.Length)]);
    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.tag == "Terrain")
        {
            if (hasPlayed != true)
            {
                PlayFootSteps();
                print("it works");
                hasPlayed = true;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
