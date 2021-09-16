using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioController : MonoBehaviour
{
    [SerializeField]
    private AudioSource source;
    public AudioClip[] audioClips = new AudioClip[8];
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("musicPlay");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator musicPlay()
    {
        source.clip = audioClips[0];
        source.Play();
        yield return new WaitForSeconds(source.clip.length);
        source.clip = audioClips[1];
        source.Play();
    }

}
