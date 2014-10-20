using UnityEngine;
using System.Collections;

public class DialogManager : MonoSingleton<DialogManager>
{
	public void ShowDialog(Character speaker, string dialog)
	{
		Debug.Log(speaker.name + ": " + dialog);
	}
}
