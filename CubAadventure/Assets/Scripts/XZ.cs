using UnityEngine;
using System.Collections;

public class TimeCount : MonoBehaviour {

    public float timer=30;//游戏时间
    public GameObject success;//获得完成界面



    public UIButton trueBtn;
    public UIButton falseBtn;
    //获得按钮对象

    public static TimeCount _instance;
    
    void Awake()
    {
        _instance = this;
    } 
    //单例模式
    void Start()
    {
        timer += 2*Time.deltaTime;//补个时间差

        if (!PlayerPrefs.HasKey("score_0"))
        {
            PlayerPrefs.SetInt("score_0", 0);
            PlayerPrefs.SetInt("score_1", 0);
            PlayerPrefs.SetInt("score_2", 0);
            PlayerPrefs.SetInt("score_3", 0);
            PlayerPrefs.SetInt("score_4", 0);
        }
    }


    // Update is called once per frame
    void Update () {

        
        this.GetComponent<UILabel>().text = "" + (int)(timer * 100) / 100.0;//统计游戏时间
        timer -= Time.deltaTime;
        

        if (timer <= 0)//游戏时间结束时
        {
            
           
            timer = 0;
            success.GetComponent<TweenPosition>().PlayForward();//弹出完成界面
            Time.timeScale = 0;//时间停止
            trueBtn.isEnabled = false;
            falseBtn.isEnabled = false;
            //按钮禁用
        }
	
	}
   
}
