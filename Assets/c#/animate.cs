using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animate : MonoBehaviour {

    public Animator Obj_Ani;
    public bool IsRun=true;
    // Start is called before the first frame update
    void Start()
    {
        Obj_Ani = this.GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
       
    }
    public void ani_action()
    {
        if (IsRun) 
        { 
            Obj_Ani.SetInteger("animation", 2);
            IsRun = false;
        }
        else
        {
            Obj_Ani.SetInteger("animation", 0);
            IsRun = true;
        }
    }
}
