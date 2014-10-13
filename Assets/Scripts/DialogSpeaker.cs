using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CircleCollider2D))]
public class DialogSpeaker : MonoBehaviour
{
    [SerializeField] private string dialog;

    void Interact()
    {
        Debug.Log(dialog);
    }
}
