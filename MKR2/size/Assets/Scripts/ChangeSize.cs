using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChangeSize : MonoBehaviour
{
    public Animator anim;
    public bool size;
    void Start() {
        if (Input.GetKeyDown("space"))
        {
            anim.SetBool("size", true);
        }
    }

}
