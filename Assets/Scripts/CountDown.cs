using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class CountDown : MonoBehaviour
{
    public GameObject countDown;
    public float realtime = 60;
    private bool timeStop = true;
 
    void Update()
    {
        CountDownTime();
    }

    void CountDownTime()
    {
        if (timeStop)
        {
            realtime -= Time.deltaTime;
            if (realtime > 0)
            {
                countDown.GetComponent<Text>().text = string.Format("{0}s", (int)realtime);
            }
            else
            {
                timeStop = false;
            }
        }
    }
}
