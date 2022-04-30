using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pipe : MonoBehaviour
{
    int scoreValue = 5;
    void Start()
    {
        Destroy(this.gameObject, 0.3f);
        Score.score += scoreValue;
    }
}
