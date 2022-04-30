using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class getEndScore : MonoBehaviour
{
    public Text endText;
    void Update()
    {
        endText.text = "Your score is " + Score.score.ToString();
        CancelInvoke();
    }
}
