using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chuken : MonoBehaviour
{
    public Animator ani;

    private void Start()
    {
        ani = GetComponent<Animator>();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.E))
        {
            ani.SetTrigger("吃飯觸發器");
        }
        /*
        if (Input.GetKey(KeyCode.R))
        {
            ani.SetBool("跑步開關",true);
        }
        if (Input.GetKeyUp(KeyCode.R))
        {
            ani.SetBool("跑步開關",false);
        }
        */

        ani.SetBool("跑步開關", Input.GetKey(KeyCode.R));
    }


}
