using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class CountTime1 : MonoBehaviour {

    public GameObject TimeOverSprite;
    public float timer = 60; //游戏时间
    private  float usetime = 0;//游戏已用时间
    
   
    public  UILabel label_Secod ; 
    public UILabel label_Level;
    


    // Use this for initialization
    void Start () {
        Time.timeScale = 1;
        // GameObject TS = GameObject.Find("TimeOverSprite");

        // GameObject TS = TS.transform.Find("TimeOverSprite").gameObject;
        TimeOverSprite.SetActive(false );

    }
	
	// Update is called once per frame
	void Update () {
        this.GetComponent<UILabel>().text = "" + (int)(timer * 100) / 100.0;//输出游戏剩余时间
        timer -= Time.deltaTime;

        usetime = Time.time;
        label_Secod.text = "Complete Second:" + (int)(usetime  * 100) / 100.0;
        label_Level.text = "Complete Level:" + Application.loadedLevelName.Substring(6,1);
      
        //print("Time.deltaTime:" + Time.deltaTime);
        if (timer <= 0) //游戏时间结束
        {     
            timer = 0;
            Time.timeScale = 0; //时间停止 游戏停止
            TimeOverSprite.SetActive(true);
        }
	}
    

   
}
