using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class WinTrigger : MonoBehaviour
{
    public Transform player;
    private Timer TimerCMP;
    private Text textTimer;
    
    
    // Start is called before the first frame update
    void Start()
    {
        TimerCMP = player.GetComponent<Timer>();
        textTimer = TimerCMP.timeText;
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Player")
        {
            Win();
        }
    }

    public void Win()
    {
        textTimer.color = Color.green;
        textTimer.fontSize = 90;

        TimerCMP.StopTimer();
    }
}
