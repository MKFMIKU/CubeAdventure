using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement; //需加入scenemanager头文件才能使用Scenemanager

public class ButtonManager : MonoBehaviour {

    //public static ButtonManager _BM;
    public AudioSource Music;  //Music file
    private  float MusicVolume;  //Music volue
    public bool IsPause = false;

    void Start()
    {
       MusicVolume = 0.5f;// 设置默认游戏音量
      //  _BM = this;
    }

    public void OnMusic()  // Music Button
    {
        if (Music.isPlaying)//如果正在播放音乐
        {
            Music.Stop();//停在音乐
        }
        else
            Music.Play();//否则点击继续播放
    }

    public void OnRestart() //Reatert Button
    {
      
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);//重新加载当前场景
        IsPause = true;

    }
    public void OnQuitHomePage(string SceneName) //返回主页
    {

        SceneManager.LoadScene(SceneName); //加载主页场景
    }
    public  void OnReturnHomePage()//NGUI无法调用含参函数，故用此函数调用scenename
    {
        OnQuitHomePage("StartGame");

    }

    public void OnClickContinue()
    {
        SceneManager.LoadScene("Level_"+(int.Parse(Application.loadedLevelName.Substring(6, 1))+1));
      
    }

}
