using UnityEngine;
using System.Collections;

public class Character : MonoBehaviour
{
	[SerializeField] string name;

	public string Name { get { return name; } }
}
