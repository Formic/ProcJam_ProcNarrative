using UnityEngine;
using System.Collections;

[RequireComponent(typeof(CircleCollider2D))]
public class DialogSpeaker : MonoBehaviour
{
	[SerializeField] Character ownerCharacter;
    [SerializeField] string dialog;

    void Interact(GameObject sender)
    {
		if (Game.Instance.Mode != GameMode.Running)
			return;

		Character senderCharacter = sender.GetComponent<Character>();

		if (senderCharacter)
		{
			DialogManager.Instance.ShowDialog(ownerCharacter, dialog);
		}
    }
}
