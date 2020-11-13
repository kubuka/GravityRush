using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SwitchGravity : MonoBehaviour
{
    private Rigidbody2D switchGravityDirection;
    private bool switchPlayerRotation;
    Animator anim;
    int animatorInt = 1;


    // Start is called before the first frame update
    void Start()
    {
        switchGravityDirection = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        anim.SetInteger("Gravity", animatorInt);
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) )
        {
            switchGravityDirection.gravityScale *= -1;
            Rotation();
            animatorInt *= -1;
            anim.SetInteger("Gravity", animatorInt);
        }
    }

    void Rotation()
    {
        if(switchPlayerRotation == false)
        {
            transform.eulerAngles = new Vector3(0, 180, 180f);
        }
        else
        {
            transform.eulerAngles = Vector3.zero;
        }

        switchPlayerRotation = !switchPlayerRotation;
    }
}
