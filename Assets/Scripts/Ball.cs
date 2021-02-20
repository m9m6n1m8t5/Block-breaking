using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ball : MonoBehaviour
{
    Rigidbody2D rigid;
    public GameController gc;

    // Start is called before the first frame update
    void Start()
    {
        rigid = this.GetComponent<Rigidbody2D>();
        rigid.velocity = new Vector2(1, 2);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        // 反射の調整（各成分を0にさせない）
        if(Mathf.Abs(rigid.velocity.x) < 1)
        {
            if(rigid.velocity.x >= 0)
            {
                rigid.velocity = new Vector2(2f, rigid.velocity.y);
            }
            else
            {
                rigid.velocity = new Vector2(-2f, rigid.velocity.y);
            }
        }
        if (Mathf.Abs(rigid.velocity.y) < 1)
        {
            if(rigid.velocity.y >= 0)
            {
                rigid.velocity = new Vector2(rigid.velocity.x, 2f);
            }
            else
            {
                rigid.velocity = new Vector2(rigid.velocity.x, -2f);
            }
        }

        // Bottomと衝突した時
        if (collision.collider.name=="Bottom")
        {
            gc.GameOver();
        }
    }
}
