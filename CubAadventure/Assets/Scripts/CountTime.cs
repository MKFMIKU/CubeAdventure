using UnityEngine;
using System.Collections;

public class CountTime : MonoBehaviour {


    public int totalSeconds =10;
    private int leaveSeconds;
    private bool onCountDown = false;
    private string countDownTitle = "Start";
    private bool isShowTip = false;


    void Awake()
    {
        leaveSeconds = totalSeconds;
      
    }


    void OnGUI()
    {
        if (isShowTip)
        {
            GUI.Label(new Rect(1000,1000, 200, 80), "Time Is Over! ");
        }
            GUI.Label(new Rect(50, 50, 50, 50), leaveSeconds.ToString());// 倒计时秒数 //  

        /*
        if (GUI.Button(new Rect(150, 50, 80, 30), countDownTitle))
        {
            if (countDownTitle == "Start")
            {
                countDownTitle = "Pause";
                onCountDown = true;
                StartCoroutine(DoCountDown());
            }
            else
            {
                countDownTitle = "Start";
                onCountDown = false;
                StopAllCoroutines();
            }
        }*/
    }
    // Use this for initialization  
    void Start()
    {
        StartCoroutine(DoCountDown());
        
    }

    // Update is called once per frame  
    void Update()
    {
        if (leaveSeconds <=0)
        {
            isShowTip = true;
            Time.timeScale = 0;
           
        }
    }


    IEnumerator DoCountDown()
    {
        while (leaveSeconds > 0)
        {
            yield return new WaitForSeconds(1.00f);
            leaveSeconds--;
        }
    }
    
}
