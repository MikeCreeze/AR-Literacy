using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SetMusic : MonoBehaviour
{
    //滑动条
    private  Dropdown dropdownItem;
    //滑动条名字
    List<string> tempNames;
    //音效存储
    public AudioClip[] audioClips;
    //音效组件
    public AudioSource audioSource;
    //滑动条
    private Slider slider;
    //开启
    private Toggle toggle;
    //返回按钮
    private Button button;
    //主界面
    public GameObject main;
    void Awake()
    {
        //寻找该物体的子物体含有DropDown组件的物体
        dropdownItem = this.GetComponentInChildren<Dropdown>();
        //初始化
        tempNames = new List<string>();
        //寻找该物体的子物体含有Slider组件的物体
        slider = this.GetComponentInChildren<Slider>();
        slider.value = audioSource.volume;
        //寻找该物体的子物体含有Toggle组件的物体
        toggle = this.GetComponentInChildren<Toggle>();
        toggle.isOn = true;
        //寻找该物体的子物体含有Button组件的物体
        button = this.GetComponentInChildren<Button>();
    }
    private void Update()
    {
        //设置音量大小
        audioSource.volume = slider.value;
        //如果toggle是勾着的，音频打开，否则音频关闭
        if (toggle.isOn == true)
            audioSource.mute = false;
        else audioSource.mute = true;
    }
    void Start()
    {
        //命名
        AddNames();
        //把命名的名字赋予滑动条
        UpdateDropdownView(tempNames);
        //启用事件
        dropdownItem.onValueChanged.AddListener(ConsoleResult);
        button.onClick.AddListener(BackMain);

    }
    /// <summary>
    /// 设置滑动条
    /// </summary>
    /// <param name="showNames"></param>
    private void UpdateDropdownView(List<string> showNames)
    {
        //把options清空
        dropdownItem.options.Clear();
        //option
        Dropdown.OptionData tempData;
        for (int i = 0; i < showNames.Count; i++)
        {
            //初始化option个数
            tempData = new Dropdown.OptionData();
            //设置option的名字
            tempData.text = showNames[i];
            //把设置的option的名字传进来
            dropdownItem.options.Add(tempData);
        }
        //默认显示第一个设置的名字
        dropdownItem.captionText.text = showNames[0];
    }
    /// <summary>
    /// 命名
    /// </summary>
    private void AddNames()
    {
        string s1 = "music01";
        string s2 = "music02";

        tempNames.Add(s1);
        tempNames.Add(s2);
 

    }
    /// <summary>
    /// 选择不同滑动条
    /// </summary>
    /// <param name="value"></param>
    public void ConsoleResult(int value)
    {
        //设置值为dropdown的value
        value = dropdownItem.value;
        switch (value)
        {
            //如果option的值为0，背景音乐为第一个设置的音频
            case 0:
                audioSource.clip = audioClips[0];
                audioSource.Play();
                break;
            //如果option的值为1，背景音乐为第二个音频
            case 1:
                audioSource.clip = audioClips[1];
                audioSource.Play();
                break;
        }
    }
    //返回主界面
    public void BackMain()
    {
        main.SetActive(true);
        this.gameObject.SetActive(false);
    }
}
