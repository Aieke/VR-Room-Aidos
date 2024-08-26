using UnityEngine;
using UnityEngine.Video;

public class PhoneVideoPlayer : MonoBehaviour
{
    private VideoPlayer videoPlayer;
    public VideoClip[] videoClips;
    private int currentClipIndex = 0;

    void Start()
    {
        videoPlayer = GetComponent<VideoPlayer>();
        if (videoClips.Length > 0)
            videoPlayer.clip = videoClips[currentClipIndex];
    }

    void Update()
    {
        if (Input.GetButtonDown("Fire1"))
        {
            if (videoPlayer.isPlaying)
                videoPlayer.Pause();
            else
                videoPlayer.Play();
        }
        if (Input.GetButtonDown("Fire2")) // Use another input to change the video
        {
            NextClip();
        }
    }

    void NextClip()
    {
        currentClipIndex = (currentClipIndex + 1) % videoClips.Length;
        videoPlayer.clip = videoClips[currentClipIndex];
        videoPlayer.Play();
    }
}
