using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour
{
	private AudioSource _source;

	private void Awake ()
	{
		_source = gameObject.AddComponent<AudioSource>();
	}

	public void PlaySoundOneShot(AudioClip clip)
	{
		_source.PlayOneShot(clip);
	}
}
