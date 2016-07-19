using UnityEngine;
using System.Collections;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {
  

 
  
   
  
    // Use this for initialization
    void Start()
    {
        
    
       // export = GameObject.FindGameObjectWithTag("Export").GetComponent<Export>();
    }

    // Update is called once per frame
   


    public void End()
    {
        // Player.GetComponent<PlayerMove>().Win();
    }

  
	public void OnStartGame(string  scenename)
	{
        SceneManager.LoadScene(scenename);
        //Application.LoadLevel(scenename);
	}
    public void OnQuit()
    {

        Application.Quit();
        if (Application.platform == RuntimePlatform.Android && (Input.GetKeyDown(KeyCode.Home))
           || Application.platform == RuntimePlatform.Android && (Input.GetKeyDown(KeyCode.Home)))
        {
            Application.Quit();
        }
    }
    public void GoTOGame()
    {
        OnStartGame("Level_1");
    }
   

}
