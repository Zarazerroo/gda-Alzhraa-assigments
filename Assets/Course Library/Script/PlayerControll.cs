using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControll : MonoBehaviour
{
    private Rigidbody playerRB;
    private AudioSource playerAudio;
    public float jumpForce = 7f;
    public float gravityModifer = 1;
    public bool isGrounded = true;
    public bool gameOver = false;
    public ParticleSystem explosionParticles;
    public ParticleSystem dirtParticles;
    public AudioClip jumpSound;
    public AudioClip crashSound;


    // Start is called before the first frame update
    void Start()
    {
        playerRB = GetComponent<Rigidbody>();
        Physics.gravity = Physics.gravity * gravityModifer;
        playerAudio = GetComponent<AudioSource>();

    }
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            playerRB.AddForce(Vector3.up * jumpForce, ForceMode.Impulse);
            isGrounded = false;
            dirtParticles.Stop();
            playerAudio.PlayOneShot(jumpSound,1.0f);

        }
    }
    public void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
        {
            isGrounded = true;
            dirtParticles.Play();
        }
        else if (collision.gameObject.CompareTag("Obstcals"))
        {
            gameOver = true;
            explosionParticles.Play();
            Debug.Log("GameOver");
            dirtParticles.Stop();
            playerAudio.PlayOneShot(crashSound,1.0f);


        }

    }
}
