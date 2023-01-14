using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FpsCounter : MonoBehaviour
{
    public Text fpsText;
    public float deltatime;

    // Update is called once per frame
    void Update()
    {
        deltatime += (Time.deltaTime - deltatime) * 0.1f;
        float fps = 1.0f / deltatime;
        fpsText.text = Mathf.Ceil(fps).ToString(); 
    }
}
