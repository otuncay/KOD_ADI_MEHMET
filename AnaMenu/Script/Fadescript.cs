using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Fadescript : MonoBehaviour
{
    public Image whiteFade;
    void Start()
    {
        whiteFade.canvasRenderer.SetAlpha(1.0f);
        fadeOut();
    }

  
    void fadeOut()
    {
        whiteFade.CrossFadeAlpha(0, 3, false);
    }
}
