using UnityEngine;
using System.Collections;



public class PlayerMove : MonoBehaviour
{
    public int speed = 2;
    public GameObject PassPanel;
    public  Export export;
    private Rigidbody player;
    public float playerReturnPositionX;
    public float playerReturnPositionY;
    public float playerReturnPositionZ;

    void Start()
    {
        player = GetComponent<Rigidbody>();
        PassPanel.SetActive(false);
    }
    void OnEnable()
    {
        EasyJoystick.On_JoystickMove += OnJoystickMove;
        EasyJoystick.On_JoystickMoveEnd += OnJoystickMoveEnd;
    }
    //当摇杆不可用时移除事件  
    void OnDisable()
    {
        EasyJoystick.On_JoystickMove -= OnJoystickMove;
        EasyJoystick.On_JoystickMoveEnd -= OnJoystickMoveEnd;
    }

    //当摇杆销毁时移除事件  
    void OnDestroy()
    {
        EasyJoystick.On_JoystickMove -= OnJoystickMove;
        EasyJoystick.On_JoystickMoveEnd -= OnJoystickMoveEnd;
    }
    //移动摇杆结束  
    void OnJoystickMoveEnd(MovingJoystick move)
    {

    }


    //移动摇杆中  
    void OnJoystickMove(MovingJoystick move)
    {
        if (move.joystickName != "PlayerJoystick")
        {
            return;
        }

       
        float PositionX = move.joystickAxis.x;       //   获取摇杆偏移摇杆中心的x坐标
        float PositionY = move.joystickAxis.y;      //    获取摇杆偏移摇杆中心的y坐标

        if (PositionY != 0 || PositionX != 0)
        {                //  设置控制角色或物体方块的朝向（当前坐标+摇杆偏移量）
            transform.LookAt(new Vector3(transform.position.x + PositionX, transform.position.y, transform.position.z + PositionY));
            //  移动角色或物体的位置（按其所朝向的位置移动）
            //transform.Translate(Vector3.forward * Time.deltaTime * speed);
            player.velocity= new Vector3(PositionX * speed, 0, PositionY * speed);//控制移动

        }
    }
    //碰撞检测


   

    public void OnTriggerEnter(Collider collider)
    {

        if (collider.tag == "Dangrous")
        {
            // Destroy(this.gameObject);
            transform.position = new Vector3(playerReturnPositionX, playerReturnPositionY, playerReturnPositionZ);

        }

       
        if (collider.tag == "Food")
        {
            Export._instance.Eat();
            Destroy(collider.gameObject);//销毁被撞物体
        }

        if (collider.tag == "Export")//找到出口
        {
           //过关 游戏时间停止
            PassPanel.SetActive(true);
            Time.timeScale = 0;

         
        }
    }


    public void Win()
    {

    }
}