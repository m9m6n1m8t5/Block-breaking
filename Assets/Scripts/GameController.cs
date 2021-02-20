using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public Text Score;
    public Blocks Blocks;
    public GameObject Telop;
    public Text TelopText;
    public bool isClear = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Score.text = "SCORE:" + (Blocks.N - Blocks.transform.childCount);
    }

    public void GameOver()
    {
        if (!isClear)
        {
            TelopText.text = "GameOver";
            Telop.SetActive(true);
        }
    }

    public void GameClear()
    {
        TelopText.text = "Clear";
        Telop.SetActive(true);
    }

    public void Replay()
    {
        SceneManager.LoadScene("Title Scene");
    }

}
