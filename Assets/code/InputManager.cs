using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    [SerializeField] Firingbehavior firingbehavior;
    [SerializeField] RigidbodyMovement2D playermovement;

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F))
        {
            firingbehavior.FireProjectile();
            
        }
        if (Input.GetKeyDown(KeyCode.Space))
        {
            playermovement.jump();
        }

        float xaxis = Input.GetAxis("horizontal");
        playermovement.Move(xaxis);
    }
}
