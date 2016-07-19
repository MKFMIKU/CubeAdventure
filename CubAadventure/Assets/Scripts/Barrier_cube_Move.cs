using UnityEngine;
using System.Collections;

public class Barrier_cube_Move : MonoBehaviour
{
   
      float timer = 0; //插值计数器
      bool min = true   ;  
      bool max = false  ;
      public float  speed = 1;
    public float fromPositionX;
    public float toPositionX;
    public float fromPositionY;
    public float toPositionY;
    public float fromPositionZ;
    public float toPositionZ;
      void Start()
      {
        //transform.position = new Vector3(8.17f, 0.54f, -4.7f);//初始化小方块位置
        transform.position = new Vector3(fromPositionX, fromPositionY, fromPositionZ);
    }
      void  Update()
      {
        
        AutoMove();
      }
      void AutoMove()
      {
        


       
        
       //物体从一个点自动移动到另外一个点
        transform.position = new Vector3(Mathf.Lerp(fromPositionX, toPositionX, timer), Mathf.Lerp(fromPositionY, toPositionY, timer), Mathf.Lerp(fromPositionZ, toPositionZ, timer));

        if (timer <=0)
        {

            min = true;//如果Timer<0 就向右移动
        }
        if (timer > 1)
        {
            max = true;//如果Timer>0 就向左移动
        }

        if (min)
        {
            timer += Time.deltaTime*speed;
            if ( timer > 1) //判断是否到达左边
            { min = false; }

        }
        if (max)
        {
            timer -= Time.deltaTime *speed ;
            if (timer < 0)//判断是否到达右边
            { max = false; }
        }



       
    }
}