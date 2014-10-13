using UnityEngine;
using System.Collections;

[RequireComponent(typeof(Rigidbody2D))]
public class MovementController : MonoBehaviour 
{
    [SerializeField] float Movespeed = 1;

    public Vector2 InputDirection { get; set; }

    public void MovementUpdate()
    {
        ProcessInput();
    }

    void ProcessInput()
    {
        rigidbody2D.velocity = InputDirection * Movespeed;
    }
}
