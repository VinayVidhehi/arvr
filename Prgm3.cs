using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class chanrun : MonoBehaviour

{
    Animator anim;
    void Start()
    {
        anim = GetComponent<Animator>();
    }
    public void therun()
    {
        anim.SetTrigger("run");
    }
}