using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Function : MonoBehaviour
{
    //功能界面按钮
    public Button button1, button2, button3, buttonHelp, close;
    public GameObject function,function1,function2, function3,function_Help, main;
    public GameObject arCamera;

    // Start is called before the first frame update
    private void Start()
    {
        button1.onClick.AddListener(Fun1);//汉字听写界面
        button2.onClick.AddListener(Fun2);//识字界面
        button3.onClick.AddListener(Fun4);//看视频
        buttonHelp.onClick.AddListener(Fun_Help);
        close.onClick.AddListener(Fun3);//回到扫描页面
    }
    //汉字听写界面打开
    public void Fun1()
    {
        function1.SetActive(true);
        function.SetActive(false);
        this.gameObject.SetActive(true);

    }
    //识字界面打开
    public void Fun2()
    {
        function2.SetActive(true);
        function.SetActive(false);
        this.gameObject.SetActive(true);
    }
    //关闭
    public void Fun3()
    {
        main.SetActive(true);
        arCamera.SetActive(true);
        function2.SetActive(false);
        function.SetActive(false);
        this.gameObject.SetActive(false);
    }
    //打开视频
    public void Fun4()
    {
        function3.SetActive(true);
        function.SetActive(false);
        this.gameObject.SetActive(true);
    }

    public void Fun_Help()
    {
        function_Help.SetActive(true);
        function.SetActive(false);
        this.gameObject.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}



