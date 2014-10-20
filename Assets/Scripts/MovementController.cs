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
		if (Game.Instance.Mode != GameMode.Running)
		{
			rigidbody2D.velocity = Vector2.zero;
			return;
		}

        rigidbody2D.velocity = InputDirection * Movespeed;
    }
}
