using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameStart : MonoBehaviour
{

    bool isFirst = false;
    public void PressStart()
    {
        Debug.Log("pushed!");
        if (!isFirst)
        {
            SceneManager.LoadScene("Main Scene");
            isFirst = true;
        }
    }
}
