using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hit : MonoBehaviour
{
    public GameObject death;



    void OnMouseDown()
    {
        /*
        AudioSource hitting = GetComponent<AudioSource>();
        hitting.Play();
        */
        Instantiate(death, this.transform.position, Quaternion.identity);
        Destroy(gameObject);
    }


}
