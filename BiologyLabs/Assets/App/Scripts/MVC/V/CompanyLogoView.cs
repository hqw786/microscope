using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.Video;
using DG.Tweening;

internal class CompanyLogoView : View
{
    VideoPlayer video;
    RawImage rawImage;
    public CompanyLogoView()
    {
        //加载CompanyLogo场景
        Manager.Instance.LoadScene(Define.SceneName_Logo1);
    }

    public void AnimIsDone()
    {
        if(video == null)
        {
            video = GameObject.Find("/Canvas/Video Player").GetComponent<VideoPlayer>();
            rawImage = video.transform.parent.Find("RawImage").GetComponent<RawImage>();
            rawImage.DOFade(0f, 1.5f);
        }
        else 
        {
            if (!video.isPlaying)
            {
                Manager.Instance.print("VIDEO END");
                Manager.Instance.SetStateMachineState(State.Logo2);
            }
        }
    }
    internal override void ExecuteRequest(string message, object args = null)
    {
        
    }
}
