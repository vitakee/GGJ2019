using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buddy : MonoBehaviour
{
	AudioSource audioSource;
	public AudioClip finishSound;
	public AudioClip painSound;
    // Start is called before the first frame update
    void Start()
    {
		audioSource = gameObject.GetComponent<AudioSource>();
    }

    public void DestroyBuddy()
	{
		audioSource.PlayOneShot(finishSound);
	}

	private void OnCollisionEnter(Collision collision)
	{
		audioSource.PlayOneShot(painSound, 0.5f);
	}
}
