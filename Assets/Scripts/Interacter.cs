using UnityEngine;
using System.Collections;

public class Interacter : MonoBehaviour
{
    [SerializeField] private LayerMask interactLayer;
    [SerializeField] private CircleCollider2D interactCollider;
    [SerializeField] private KeyCode interactKey;

    void Update()
    {
        if (Input.GetKeyDown(interactKey))
        {
            print("wut");
            Collider2D overlap = Physics2D.OverlapCircle(interactCollider.center, interactCollider.radius, interactLayer);
            if (overlap)
            {
                overlap.BroadcastMessage("Interact");
            }
        }
    }
}
