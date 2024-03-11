using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerController : MonoBehaviour
{
    private Rigidbody2D body;
    private MainInput controls;
    public Transform gunTransform;

    void Awake()
    {
        controls = new MainInput();
        body = GetComponent<Rigidbody2D>();
    }

    void OnEnable()
    {
        controls.Enable();
    }

    void OnDisable()
    {
        controls.Disable();
    }

    void FixedUpdate()
    {
        Move();
    }

    void Update()
    {
        Shoot();
    }
    
    private void Move()
    {
        Vector2 moveInput = controls.Player.Move.ReadValue<Vector2>();
        Vector2 movement = moveInput * 5 * Time.fixedDeltaTime;
        body.MovePosition(body.position + movement);
    }

    private void Shoot()
    {
        if (controls.Player.Shoot.triggered)
        {
            GameObject ammo = AmmoPoolManager.Instance.GetAmmo();
            ammo.transform.position = gunTransform.position;
        }
    }
}
