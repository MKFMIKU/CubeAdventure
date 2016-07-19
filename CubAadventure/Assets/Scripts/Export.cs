using UnityEngine;
using System.Collections;

public class Export : MonoBehaviour
{
   // private Renderer rend;
   
   //[HideInInspector ]
    public   GameObject export;
    public static  Export _instance;
    public UILabel Label_FoodCount; //已吃食物UiLabel
    public  int EatCount = 4;  //初始四个食物

    void Start()
    {
         _instance = this;
       //  export = this.gameObject;
         export.SetActive(false);
     //   rend = GetComponent<Renderer>();
       // rend.enabled = false;//默认不显示出口
    }

    void Update()
    {
        

        if (EatCount==0)
        {
           // print("kk");
            // export.show(true);
            // End();
            export.SetActive(true);
        }
        // Label_FoodCount.text = (4 - EatCount) + " " + "/ 4"; //显示当前已吃食物
       Label_FoodCount = GameObject.FindGameObjectWithTag("EatCount").GetComponent<UILabel>();
        Label_FoodCount.text = (4 - EatCount) + " " + "/ 4";


    }

    public void Eat()
    {
        EatCount--;

    }
    /*
    public void show(bool flag)
    {
        if (flag == true)//显示
        {

           // rend.enabled = true;
        }
        else
        {
          //  rend.enabled = false;
        }
    }
    */
}
