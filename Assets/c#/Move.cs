using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Video;
using UnityEngine.UI;

public class Move : MonoBehaviour
{
   // public Text text_PlayOrPause;
    public Button button_PlayOrPause;
    private VideoPlayer videoPlayer;
    private RawImage rawImage;
    private int flag = 0;

    //private AudioSource audioSource;
    // Start is called before the first frame update
    void Start()
    {
        videoPlayer = this.GetComponent<VideoPlayer>();
        //audioSource = this.GetComponent<AudioSource>();
        rawImage = this.GetComponent<RawImage>();
        button_PlayOrPause.onClick.AddListener(PlayorPause);
    }

    void Update()
    {
        //判断视频播放情况，播放则按钮显示暂停，暂停就显示播放，并更新相关文本
        //没有视频则返回，不播放
        if (flag == 0)
        {
            if (videoPlayer.texture == null)
            {
                return;
            }
            //渲染视频到UGUI
            else
            {
                rawImage.texture = videoPlayer.texture;
                flag++;
            }
        }
    }
    void PlayorPause()
    {

        if (videoPlayer.isPlaying == true)
        {
            videoPlayer.Pause();

            //audioSource.Pause();
            // text_PlayOrPause.text = "播放";
        }
        else
        {
            videoPlayer.Play();
            //audioSource.Play();
           // text_PlayOrPause.text = "暂停";
        }
    }
}