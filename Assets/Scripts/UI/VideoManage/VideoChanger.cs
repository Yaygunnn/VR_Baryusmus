using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;

public class VideoChanger : MonoBehaviour
{
    [SerializeField] VideoClip[] PuzzleStartVideos;
    [SerializeField] VideoClip SuccessVideo;
    [SerializeField] VideoPlayer videoPlayer;
    [SerializeField] GameObject VideoCanvas;
    
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyUp(KeyCode.Space))
        {
            StartHackVideo();
            Debug.Log("Space");
        }

        if (Input.GetKeyUp(KeyCode.A))
        {
            StartSuccessVideo();
            Debug.Log("A");
        }
    }

    public void StartHackVideo()
    {
        Debug.Log("StartHackVideo");
        GetRandomVideo();
        videoPlayer.Play();

        OpenCanvasLate();

        float VideoCloseTime = Random.Range(0.6f, 0.8f);
        Invoke("StopVideo", VideoCloseTime);
    }
    
    public void StartSuccessVideo()
    {
        GetSuccessVideo();
        videoPlayer.Play();
        OpenCanvasLate();

        float VideoCloseTime = Random.Range(1.2f, 1.3f);
        Invoke("StopVideo", VideoCloseTime);

    }
    private void GetRandomVideo()
    {
        videoPlayer.clip = PuzzleStartVideos[Random.Range(0,PuzzleStartVideos.Length)];

    }

    private void OpenCanvasLate()
    {
        Invoke("OpenCanvas", 0.05f);
    }
    private void OpenCanvas()
    {
        //VideoCanvas.SetActive(true);
    }
    private void GetSuccessVideo()
    {
        videoPlayer.clip = SuccessVideo;

    }

    public void StopVideo()
    {
        videoPlayer.Stop();
        VideoCanvas.SetActive(false);
        
    }
}
