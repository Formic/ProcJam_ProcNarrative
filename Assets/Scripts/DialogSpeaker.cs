using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CircleCollider2D))]
public class DialogSpeaker : MonoBehaviour
{
	[SerializeField] Character ownerCharacter;
    [SerializeField] string dialog;

    void Interact(GameObject sender)
    {
		Character senderCharacter = sender.GetComponent<Character>();

		if (senderCharacter)
		{
			DialogManager.Instance.ShowDialog(ownerCharacter, dialog);
		}
    }
}
