using UnityEngine;
using System.Collections;
using System;

public abstract class MonoSingleton<T> : MonoBehaviour where T : MonoSingleton<T>
{
	public static T Instance
	{
		get
		{
			if (_instance != null)
				return _instance;

			Debug.LogException(new Exception(typeof(T).ToString() + " does not exist! This singleton does not create if DNE, so you must place on in the scene!"));
			return default(T);
		}
	}

	protected static T _instance;

	protected virtual void Awake()
	{
		if (_instance != null)
		{
			Debug.LogException(new Exception("Singleton duplicate found for " + gameObject.name));
		}

		_instance = (T) this;
	}
}
