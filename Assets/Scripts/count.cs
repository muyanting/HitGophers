using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class count : MonoBehaviour
{
    public Text TimeText;
    public float getTime = 20;
    public static float times;
    private int s;//定义一个秒
    // Start is called before the first frame update
    void Start()
    {
        times = getTime;
        older.hittedOlder = 0;
    }

    // Update is called once per frame
    void Update()
    {
        //计时器完成倒计时的功能
        times -= Time.deltaTime;
        s = (int)times % 60; //小数转整数 
        TimeText.text = s.ToString()+" s";
        if (times <= 0)
        {
            times = 0;
            SceneManager.LoadScene("End");

            //判定倒计时结束时该做什么
        }
    }
}
