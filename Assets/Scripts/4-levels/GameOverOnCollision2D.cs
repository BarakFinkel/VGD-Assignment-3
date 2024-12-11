using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameOverOnCollision2D : MonoBehaviour
{
    [Tooltip("Every object tagged with this tag will damage the player on collision.")]
    [SerializeField]
    List<string> collidingTags;

    [SerializeField]
    string gameOverScene = "Level-game-over";

    [SerializeField]
    float delay = 0.2f;

    HealthPoints hp;
    InputMover playerMover;
    Collider2D playerCollider;
    Rigidbody2D playerRB;
    Animator animator;

    void Start()
    {
        hp = GetComponent<HealthPoints>(); 
        playerMover = GetComponent<InputMover>();
        playerCollider = GetComponent<Collider2D>();
        playerRB = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    private void OnCollisionEnter2D(Collision2D other)
    {
        if (collidingTags.Contains(other.gameObject.tag)) 
        {
            hp.Hit();
        }

        if (hp.GetHP() == 0)
        {
            Debug.Log("Game over!");

            playerMover.enabled = false;
            playerCollider.enabled = false;
            playerRB.simulated = false;
            animator.Play("Death");

            Invoke(nameof(GameOver), delay);
        }
    }

    private void GameOver()
    {
        SceneManager.LoadScene(gameOverScene);
        Destroy(gameObject);
    }

    private void Update()
    {
        /* Just to show the enabled checkbox in Editor */
    }
}