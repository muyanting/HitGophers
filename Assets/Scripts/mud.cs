using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mud : MonoBehaviour
{
    int scoreValue = 1;
    void Start()
    {
        Destroy(this.gameObject, 0.3f);
        Score.score += scoreValue;
    }
}

