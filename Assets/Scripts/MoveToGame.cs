using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MoveToGame : MonoBehaviour
{
    public void OnClick()
    {
        SceneManager.LoadScene("GameV1_1");
    }
    
    public void StratUI()
    {
        SceneManager.LoadScene("StartUI");
    }
}
