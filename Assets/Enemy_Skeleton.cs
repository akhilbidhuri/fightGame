using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NewBehaviourScript : Entity
{
    [SerializeField] private float moveSpeed;
    protected override void Start()
    {
        base.Start();
    }

    protected override void Update()
    {
        base.Update();
        rb.velocity = new Vector2(moveSpeed * facingDirecction, 0);
        if (!isGrounded || isWallDetected)
            Flip();
    }
}
