using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{
    // Start is called before the first frame update

    float time = 0f;
    public Text timeText;
    private bool runTimer = false;
    private bool finished = false;
    
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (runTimer && !finished)
        {
            time += Time.deltaTime;
        }
        // Add a function here
        printTimer(time);
    }

    public void StartTimer()
    {
        runTimer = true;
    }

    public void StopTimer()
    {
        runTimer = false;
        finished = true;
    }

    public void printTimer(float time)
    {
        float sec = time % 60;
        float min = (time / 60) % 60;
        float h = time / 3600;
        timeText.text = $"{h,0:00}:{min,0:00}.{sec,0:00}";
    }
}
