using UnityEngine;
using System.Collections;

[RequireComponent(typeof(MovementController))]
public class PlayerMovementController : MonoBehaviour
{
    private MovementController movementController;

    void Start()
    {
        movementController = GetComponent<MovementController>();
    }

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        movementController.InputDirection = new Vector2(horizontal, vertical); 
        movementController.MovementUpdate();
    }
}
