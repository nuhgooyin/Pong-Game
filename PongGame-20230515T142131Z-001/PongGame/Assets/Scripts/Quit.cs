using UnityEngine;
using System.Collections;

public class Quit : MonoBehaviour
{
	void OnMouseDown()
	{
		transform.localScale *= 1.1F;
	}

	void OnMouseUp()
	{
		Application.Quit();
	}
}