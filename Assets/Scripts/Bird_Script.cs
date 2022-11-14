using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Bird_Script : MonoBehaviour
{
	public float jump = 10;
	public Rigidbody2D body;
	public Animator animator;
	public AudioSource sound;
	public AudioClip wing;
	public AudioClip die;
	public AudioClip point;
	public float score = 0;
	public Text output;
	Collider2D col;
	void Start()
	{
		body = GetComponent <Rigidbody2D>();
		animator = GetComponent <Animator>();
		col = GetComponent <PolygonCollider2D>();
	}
	void Update()
	{
		 if (Input.touchCount > 0 || Input.GetKeyDown(KeyCode.Space))
		 {
		 	body.velocity = (Vector2.up * jump);
		 	animator.Play ("fly");
		 	animator.Play ("fall");
		 	sound.PlayOneShot (wing);
		 }
		 animator.Play ("fly");
	}
	void OnCollisionEnter2D(Collision2D other)
	{
		sound.PlayOneShot (die);
		body.gravityScale = 5;
		body.freezeRotation = false;
		Invoke ("Delay", 0.4f);
	}
	void OnTriggerExit2D(Collider2D other)
	{
		score += 1;
		output.text = $"{score}";
		sound.PlayOneShot(point);
	}
	public void Delay()
    {
        SceneManager.LoadScene(0);
    }
}
