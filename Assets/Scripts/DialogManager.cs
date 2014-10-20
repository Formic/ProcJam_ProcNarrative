using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DialogManager : MonoSingleton<DialogManager>
{
	[SerializeField] KeyCode hideKey;
	[SerializeField] GameObject dialogUi;
	[SerializeField] Text text;

	protected override void Awake()
	{
		base.Awake();

		HideDialog();
	}

	public void ShowDialog(Character speaker, string dialog)
	{
		Game.Instance.Mode = GameMode.Dialog;
		text.text = speaker.name + ": " + dialog;
		dialogUi.SetActive(true);
		StartCoroutine(HideOnKeyPress());
	}

	IEnumerator HideOnKeyPress()
	{
		// skip this frame
		yield return null;

		while (!Input.GetKeyDown(hideKey))
		{
			yield return null;
		}

		HideDialog();
	}

	void HideDialog()
	{
		Game.Instance.Mode = GameMode.Running;
		dialogUi.SetActive(false);
	}
}
