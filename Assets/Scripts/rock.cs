using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class rock : MonoBehaviour
{
    int scoreValue = 2;
    void Start()
    {
        Destroy(this.gameObject, 0.3f);
        Score.score += scoreValue;
    }
}

