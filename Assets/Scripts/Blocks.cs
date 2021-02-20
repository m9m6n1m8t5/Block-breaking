using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Blocks : MonoBehaviour
{
    public GameObject Block;
    public GameController gc;
    public int N = 35;
    public float range = 0.5f;

    // Start is called before the first frame update
    void Start()
    {
        makeBlocks();
    }

    // Update is called once per frame
    void Update()
    {
        if (this.transform.childCount == 0)
        {
            gc.GameClear();
        }
    }

    // pointからrange内のblockを破壊する
    public void destroyAround(Vector3 point)
    {
        var children = GetComponentInChildren<Transform>();
        foreach(Transform child in children)
        {
            if(Vector3.Distance(child.position, point) < range)
            {
                Debug.Log(child.position);
                Destroy(child.gameObject);
            }
        }
    }

    // 初期ブロックの配置
    void makeBlocks()
    {
        float gap = 0.5f;
        for (int i=-3; i<=3; i++)
        {
            for(int j=-2; j<=2; j++)
            {
                GameObject block = Instantiate(Block, new Vector3(gap*i + transform.position.x,gap*j + transform.position.y,0), Quaternion.identity, transform);
                block.GetComponent<Block>().blocks = this;
            }
        }
    }
}
