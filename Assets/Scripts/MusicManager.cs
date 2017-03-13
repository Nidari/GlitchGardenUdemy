using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class MusicManager : MonoBehaviour {

    public AudioClip[] levelMusicChangeArray;
    private AudioSource audioSource;

	// Use this for initialization
	void Awake () {

        DontDestroyOnLoad(gameObject);
        Debug.Log("Dont destory on Load" + name);

	}
	
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }


	// Update is called once per frame
	void Update () {
	
	}

    void OnLevelWasLoaded(int level)
    {
        AudioClip thisLevelMusic = levelMusicChangeArray[level];
        Debug.Log("Playing clip" + thisLevelMusic);

        if (thisLevelMusic)
        {
            audioSource.clip = thisLevelMusic;
            audioSource.loop = true;
            audioSource.Play();
        }
    }


}
