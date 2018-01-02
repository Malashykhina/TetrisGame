using System.Collections;
using UnityEngine;

public class Spawner : MonoBehaviour {
	// Groups
	public AudioClip click;
	public AudioClip drop;
	public GameObject[] groups;
	private AudioSource audioSource;
	// Use this for initialization
	void Start () {
		// Spawn initial Group
		spawnNext();
		audioSource=GetComponent<AudioSource>();

	}
	
	// Update is called once per frame
	void Update () {
	}
	public void spawnNext() {
		// Random Index

		int i = Random.Range(0, groups.Length);

		// Spawn Group at current Position
		Instantiate(groups[i],
			transform.position,
			Quaternion.identity);
	}

	public void playClickAudio(){
		audioSource.PlayOneShot(click);
	}
	public void playDropAudio(){
		audioSource.PlayOneShot(drop);
	}
}
