using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomColor : MonoBehaviour
{
    public Color bgColor;
    Camera theCamera;
    // Start is called before the first frame update
    void Start()
    {
        theCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
        StartCoroutine(ChangeColor());        
    }

    IEnumerator ChangeColor()
    {
        while(true)
        {
            bgColor.r = Random.Range(0.0f,0.6f);
            bgColor.g = Random.Range(0.0f,0.6f);
            bgColor.b = Random.Range(0.0f,0.6f);
            bgColor.a = 1.0f;
            float timeChange = 0f;
            var currentColor = theCamera.backgroundColor;
            while (timeChange < 8.0)
            {
                theCamera.backgroundColor = Color.Lerp(currentColor, bgColor, timeChange);
                yield return null;
                timeChange += Time.deltaTime;
            }
        }
    }
}
