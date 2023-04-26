using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomReactionAudio : MonoBehaviour
{
    [SerializeField] List<AudioClip> audioClips;
    [SerializeField] List<AudioSource> sources;

    float maxtime = 3f;
    float timer;

    private void Update()
    {
        timer += Time.deltaTime;
        if (timer >= maxtime)
        {
            PlayRandomAudio();
            timer = 0f;
        }
    }

    public void PlayRandomAudio()
    {
        int randomIndex = Random.Range(0, audioClips.Count);
        int randomSource = Random.Range(0, sources.Count);

        sources[randomSource].PlayOneShot(audioClips[randomIndex]);
    }
}