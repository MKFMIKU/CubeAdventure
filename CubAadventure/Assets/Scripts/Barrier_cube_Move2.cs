using UnityEngine;
using System.Collections;

public class Barrier_cube_Move2 : MonoBehaviour
{
    float timer = 0;
    bool min = true;
    bool max = false;
    public float  speed = 1;


    void Start()
    {
        transform.position = new Vector3(-3.5f, 0.5f, 1.25f);

    }
    void Update()
    {
        AutoMove();
      //  Debug.Log("ok");

    }
    void AutoMove()
    {
        transform.position = new Vector3(Mathf.Lerp(-3.5f, -9f, timer), Mathf.Lerp(0.5f, 0.5f, timer), Mathf.Lerp(1.225f, 1.225f, timer));
        if (timer <= 0)
        {

            min = true;//如果Timer<0 就向右移动
        }
        if (timer > 1)
        {
            max = true;//如果Timer>0 就向左移动
        }

        if (min)
        {
            timer += Time.deltaTime ;
            if (timer > 1) //判断是否到达左边
            { min = false; }

        }
        if (max)
        {
            timer -= Time.deltaTime*speed;
            if (timer < 0)//判断是否到达右边
            { max = false; }
        }

    }

}

