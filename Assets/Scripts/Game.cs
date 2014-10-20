using UnityEngine;
using System.Collections;

public enum GameMode
{
	Running,
	Paused,
	Dialog,
}

public class Game : MonoSingleton<Game> 
{
	public GameMode Mode { get; set; }

	protected override void Awake()
	{
		base.Awake();

		Mode = GameMode.Running;
	}
}
