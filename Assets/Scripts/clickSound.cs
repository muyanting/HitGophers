using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class clickSound : MonoBehaviour
{
    // Start is called before the first frame update
    private void OnMouseDown()
    {
        AudioSource hitting = GetComponent<AudioSource>();
        hitting.Play();
    }
}
