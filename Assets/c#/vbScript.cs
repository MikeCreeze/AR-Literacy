using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Vuforia;

public class vbScript : MonoBehaviour
{
   public Animator Obj_Ani;
   public VirtualButtonBehaviour vb;
    void Start()
    {
        vb.RegisterOnButtonPressed(OnButtonPressed);
        vb.RegisterOnButtonReleased(OnButtonReleased);
        Debug.Log("should start working here");
    }

    public void OnButtonPressed(VirtualButtonBehaviour vb)
    {
        Debug.Log("遮住");
        Obj_Ani.SetInteger("animation", 2);
    }

    public void OnButtonReleased(VirtualButtonBehaviour vb)
    {
        Debug.Log("离开");
        Obj_Ani.SetInteger("animation", 0);
    }
}
