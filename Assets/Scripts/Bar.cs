using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bar : MonoBehaviour
{
    public GameObject RightWall;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKey("right"))
        {
            transform.position += new Vector3(0.2f, 0, 0);
        }
        if (Input.GetKey("left"))
        {
            transform.position += new Vector3(-0.2f, 0, 0);
        }

        float p_wall = RightWall.transform.position.x - transform.parent.position.x;
        float p_bar = this.transform.position.x - transform.parent.position.x;

        float w_wall = RightWall.GetComponent<SpriteRenderer>().bounds.size.x;
        float w_bar = this.GetComponent<SpriteRenderer>().bounds.size.x;
        float w_min = (w_bar + w_wall) / 2;

        // Wallより外側
        if (p_wall-Mathf.Abs(p_bar) < w_min)
        {
            transform.position = new Vector3((p_wall-w_min)*Mathf.Sign(p_bar), transform.position.y, 0) + transform.parent.position;
        }


    }
}
