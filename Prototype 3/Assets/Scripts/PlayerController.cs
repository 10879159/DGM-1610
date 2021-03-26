using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float jumpForce = 10f;
    public float gravityModifier;
    public bool isOnGround = true;
    public bool gameOver = false;
    public ParticleSystem explosionParticle;
    public ParticleSystem dirtParticle;
    public AudioClip jumpSound;
    public AudioClip crashSound;

    private Rigidbody PlayerRB;
    private Animator playerAnim;
    private Vector3 airDeath;
    private AudioSource playerAudio;

    // Start is called before the first frame update
    void Start()
    {
	PlayerRB = GetComponent<Rigidbody>();
	Physics.gravity *= gravityModifier;
	playerAnim = GetComponent<Animator>();
	airDeath = new Vector3(10, 1, 0);
	playerAudio = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isOnGround && !gameOver) {
		dirtParticle.Stop();
		playerAudio.PlayOneShot(jumpSound, 1.0f);
		PlayerRB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
		isOnGround = false;
		playerAnim.SetTrigger("Jump_trig");
	} else if (gameOver) {
		dirtParticle.Stop();
	}
    }

    private void OnCollisionEnter(Collision collision)
    {
	if (collision.gameObject.CompareTag("Ground")) {
		isOnGround = true;
		dirtParticle.Play();
	} else if (collision.gameObject.CompareTag("Obstacle")) {
		dirtParticle.Stop();
		explosionParticle.Play();
		playerAudio.PlayOneShot(crashSound, 1.0f);
		gameOver = true;
		playerAnim.SetBool("Death_b", true);
		if (isOnGround) {
			playerAnim.SetInteger("DeathType_int", 1);
		} else {
			playerAnim.SetInteger("DeathType_int", 2);
			PlayerRB.AddForce(airDeath * 200, ForceMode.Impulse);
		}
		Debug.Log("Game Over!");
	}
    }
}
