using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class die : MonoBehaviour
{
    int scoreValue = 10;
    private void Start()
    {
        Destroy(this.gameObject, 0.3f);
        Score.score += scoreValue;
    }
 
}
