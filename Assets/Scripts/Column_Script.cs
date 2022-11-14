using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Column_Script : MonoBehaviour
{
	public float speed = 4f;
	void Update()
	{
		transform.Translate(Vector2.left * speed * Time.deltaTime);
	}
}
