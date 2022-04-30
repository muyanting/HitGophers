using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Setting : MonoBehaviour
{
    //public GameObject gopher;
    
    private  GameObject go;
    public  GameObject[] gophers = new GameObject[6];
    private static int lastHole;
    public GameObject egg;



    // Start is called before the first frame update
    void Start()
    {
     
        
        InvokeRepeating("CreateGophers", 2.0f, 0.2f);
    }

    

    void CreateGophers()
    {
        //startImg.enabled = false;

        Vector3 p = Vector3.zero;

        int gopherId;

        int whichHole;
        whichHole = (int)Random.Range(1, 10);

        if (whichHole != lastHole)
        {
            gopherId = (int)Random.Range(1, 6);
            go = Instantiate(gophers[gopherId]);
            switch (whichHole)
            {
                case 1:
                    p = new Vector3(-1.71f, 1.78f, 0f);
                    break;
                case 2:
                    p = new Vector3(0f, 1.78f, 0f);
                    break;
                case 3:
                    p = new Vector3(1.68f, 1.78f, 0f);
                    break;
                case 4:
                    p = new Vector3(-1.99f, 0.58f, 0f);
                    break;
                case 5:
                    p = new Vector3(0f, 0.58f, 0f);
                    break;
                case 6:
                    p = new Vector3(1.86f, 0.58f, 0f);
                    break;
                case 7:
                    p = new Vector3(-2.17f, -0.79f, 0f);
                    break;
                case 8:
                    p = new Vector3(-0.03f, -0.79f, 0f);
                    break;
                case 9:
                    p = new Vector3(2.11f, -0.79f, 0f);
                    break;

            }
            go.transform.position = p;
            lastHole = whichHole;
            Destroy(go, 0.85f);
        }
        else
        {
            Debug.Log("repeated!!!");
            egg.transform.position = p;

            //Destroy(go,0.01f);
        }

    }

    private void Update()
    {
        //startImg.enabled = false;

        if (Score.score >= 60 && older.hittedOlder == 0 && count.times <= 10)
        {
            Debug.Log(">60!!!");
            egg.transform.position = new Vector3(0, 0, 0);
        }
    }
}
