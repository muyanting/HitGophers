using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class hat : MonoBehaviour
{
    int scoreValue = 3;
    void Start()
    {
        Destroy(this.gameObject, 0.3f);
        Score.score += scoreValue;
    }
}
