using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PipeSpawner_Script : MonoBehaviour
{
	public GameObject pipePrefab;
	void Start()
	{
		StartCoroutine ("pipeSpawner");
	}
	IEnumerator pipeSpawner ()
	{
		while (true) 
		{
			yield return new WaitForSeconds(1.4f);
			float random = Random.Range (-3.25f, 5.45f);
			GameObject clone = Instantiate (pipePrefab, new Vector3 (12, random, 0), Quaternion.identity);
			Destroy (clone, 5);
		}
	}
}
