using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneController : MonoBehaviour
{
	public void SceneLoader (int id)
	{
		SceneManager.LoadScene(id);
	}
}
