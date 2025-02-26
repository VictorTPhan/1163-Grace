using UnityEngine;
using UnityEngine.Video;

public class Monitor : MonoBehaviour
{
    private VideoPlayer videoPlayer;
    
    public RenderTexture renderTexture; // Assign in Inspector

    void Awake()
    {
        // Get the VideoPlayer component
        videoPlayer = GetComponent<VideoPlayer>();

        if (videoPlayer == null)
        {
            Debug.LogError("Monitor: No VideoPlayer component found on this GameObject.");
            return;
        }

        // Set the video output to a RenderTexture
        if (renderTexture != null)
        {
            videoPlayer.targetTexture = renderTexture;
        }
        else
        {
            Debug.LogError("Monitor: No RenderTexture assigned.");
        }
    }

    void Start()
    {
        // Play the video if assigned
        if (videoPlayer.clip != null)
        {
            videoPlayer.Play();
        }
        else
        {
            Debug.LogError("Monitor: No video clip assigned.");
        }
    }
}
