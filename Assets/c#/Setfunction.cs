using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Setfunction : MonoBehaviour
{
    //返回按钮
    public  Button close1, close2;
    //主界面
    public GameObject function,function1,function2;
    // Start is called before the first frame update
   
    // Start is called before the first frame update
    private void Start()
    {
        close1.onClick.AddListener(Fun1);//汉字听写界面
        close2.onClick.AddListener(Fun2);//识字界面
    }
    //汉字听写界面关闭
    public void Fun1()
    {
        function.SetActive(true);
        function1.SetActive(false);
        this.gameObject.SetActive(true);

    }
    //识字界面关闭
    public void Fun2()
    {
        function.SetActive(true);
        function2.SetActive(false);
        this.gameObject.SetActive(true);
    }
    // Update is called once per frame
    void Update()
    {

    }

}



