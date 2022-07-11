using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Main : MonoBehaviour
{
    //主界面按钮
    public Button begin, esc, music;
    //各个界面
    public GameObject arCamera, setmusic;
    private void Start()
    {
        //启用事件
        begin.onClick.AddListener(Fun1);//识别物体
        music.onClick.AddListener(Fun2);//音乐设置
        esc.onClick.AddListener(Click);//退出
    }
    //游戏界面打开
    public void Fun1()
    {
        arCamera.SetActive(true);
        this.gameObject.SetActive(false);
        
    }
    //音乐界面打开
    public void Fun2()
    {
        setmusic.SetActive(true);
        this.gameObject.SetActive(false);
    }

    //关闭程序
    public void Click()
    {
#if UNITY_EDITOR
        UnityEditor.EditorApplication.isPlaying = false;//编辑状态下退出        
#else
        Application.Quit();//打包编译后退出        
#endif
    }


}


