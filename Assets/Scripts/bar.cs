using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class bar : MonoBehaviour
{
    int scoreValue = 4;
    void Start()
    {
        Destroy(this.gameObject, 0.3f);
        Score.score += scoreValue;
    }
}
