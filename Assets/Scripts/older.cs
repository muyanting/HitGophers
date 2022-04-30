using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class older : MonoBehaviour
{
    int scoreValue = -10;
    public static int hittedOlder = 0;
    void Start()
    {
        hittedOlder += 1;
        Debug.Log("older is here,you click older "+hittedOlder+" times");
        Destroy(this.gameObject, 0.3f);
        Score.score += scoreValue;
    }
}
