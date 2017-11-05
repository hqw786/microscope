using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using DG.Tweening;
using UnityEngine;
using UnityEngine.UI;

class CooperationLogoView : View
{
    public CooperationLogoView ()
    {
        Manager.Instance.LoadScene(Define.SceneName_Logo2);
    }
    Text text;
    Image image;

    float time;
    float fadeTime = 2f;
    float normalTime = 5f;
    
    public bool isFadeIn;
    public bool isFadeOut;
    bool isFadeNormalDone;
    bool isFadeOutDone;

    public void Init()
    {
        text = GameObject.Find("/Canvas/Text").GetComponent<Text>();
        image = GameObject.Find("/Canvas/Image").GetComponent<Image>();
    }

    public void Run()
    {
        if(text != null && image != null)
        {
            if(!isFadeIn)
            {
                isFadeIn = true;
                FadeIn();
            }
            if(isFadeIn && !isFadeNormalDone)
            {
                time += Time.deltaTime;
                if(time >= fadeTime + normalTime)
                {
                    isFadeNormalDone = true;
                    time = 0f;
                }
            }
            if (isFadeNormalDone && !isFadeOut)
            {
                isFadeOut = true;
                FadeOut();
            }
            if(isFadeOut && !isFadeOutDone)
            {
                time += Time.deltaTime;
                if(time >= fadeTime)
                {
                    isFadeOutDone = true;
                    LoadNextScene();
                }
            }
        }
        else if(text == null && image == null)
        {
            Init();
            ColorAIs0();
        }
    }

    private void LoadNextScene()
    {
        Manager.Instance.SetStateMachineState(State.Menu);
    }

    public void ColorAIs0()
    {
        Color c = Color.white;
        c.a = 0f;
        text.color = c;
        image.color = c;
    }

    public void FadeIn()
    {
        text.DOFade(1f, fadeTime);
        image.DOFade(1f, fadeTime);
    }

    public void FadeOut()
    {
        text.DOFade(0f, fadeTime);
        image.DOFade(0f, fadeTime);
    }

    internal override void ExecuteRequest(string message, object args = null)
    {
        throw new NotImplementedException();
    }
}
