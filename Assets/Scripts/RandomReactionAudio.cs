using System.Collections.Generic;
using UnityEngine;

public class RandomReactionAudio : MonoBehaviour
{
    [SerializeField] List<AudioClip> winClips;
    [SerializeField] List<AudioClip> loseClips;
    [SerializeField] List<AudioSource> sources;

    private void Start()
    {
        ScoreKeeper.Instance.PlayerWin += PlayRandomAudio;
    }

    public void PlayRandomAudio(bool playerwin)
    {
        AudioClip audioclip;

        if(playerwin)
            audioclip = winClips[Random.Range(0, winClips.Count)];
        else
            audioclip = loseClips[Random.Range(0, loseClips.Count)];

        int randomSource = Random.Range(0, sources.Count);

        if(audioclip)
            sources[randomSource].PlayOneShot(audioclip);
    }

    private void OnDisable() =>
        ScoreKeeper.Instance.PlayerWin -= PlayRandomAudio;
}