using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
	public List<AudioClip> audioClips = new List<AudioClip>();
	private List<string> audioTags = new List<string>();
	private AudioSource audioSource;

	private void Awake()
	{
		audioSource = GetComponent<AudioSource>();
	}

	private void PlayThisClip(string _incomingClip)
	{
		foreach (AudioClip clip in audioClips)
		{
			if (clip.name == _incomingClip)
			{
				audioSource.PlayOneShot(clip);
			}
		}
	}

	private void OnEnable()
	{
		AccesInk.AudioTagEvent += PlayThisClip;
	}

	private void OnDisable()
	{
		AccesInk.AudioTagEvent -= PlayThisClip;
	}
}