using UnityEngine;
using System.Collections;

public class Interacter : MonoBehaviour
{
	[SerializeField] GameObject owner;
    [SerializeField] LayerMask interactLayer;
    [SerializeField] CircleCollider2D interactCollider;
    [SerializeField] KeyCode interactKey;

    void Update()
    {
        if (Input.GetKeyDown(interactKey))
        {
			Vector3 interactCenter = interactCollider.center + (Vector2)transform.position; 
            Collider2D overlap = Physics2D.OverlapCircle(interactCenter, interactCollider.radius, interactLayer);
            if (overlap)
            {
                overlap.BroadcastMessage("Interact", owner);
            }
        }
    }
}
