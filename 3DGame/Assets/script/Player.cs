﻿using UnityEngine;
using Invector.vCharacterController;

public class Player : MonoBehaviour
{
    private float hp = 100;
    private Animator ani;

    private void Awake()
    {
        ani = GetComponent<Animator>();
    }



    public void Damage()
    {
        hp -= 35;
        ani.SetTrigger("受傷觸發");
        if (hp <= 0)
        {
            Dead();
        }
    }

    private void Dead() 
    {
        ani.SetTrigger("死亡觸發");

        vThirdPersonController vt = GetComponent<vThirdPersonController>();
        vt.lockMovement = true;
        vt.lockRotation = true;
    }

}
