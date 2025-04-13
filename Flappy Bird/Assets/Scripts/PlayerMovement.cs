using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    [SerializeField] private float jumpSpeed = 3f;
    [SerializeField] private GameObject deathScreen;
    [SerializeField] private AudioSource dieSFX;
    [SerializeField] private AudioSource pointSFX;
    [SerializeField] private AudioSource flySFX;
    private Rigidbody2D rb2d;

    void Start()
    {
        Time.timeScale = 1f;
        rb2d = GetComponent<Rigidbody2D>();
        deathScreen.SetActive(false);

    }


    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            rb2d.linearVelocity = Vector2.up * jumpSpeed;
            flySFX.Play();
            FindFirstObjectByType<GameManager>().StartGameWithSpace(deathScreen.activeSelf);
        }


        if (Input.GetKeyDown(KeyCode.P))
        {

            GetComponent<CircleCollider2D>().enabled = !GetComponent<CircleCollider2D>().enabled;
        }

    }

    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Scoring")
        {
            FindFirstObjectByType<GameManager>().IncreaseScore();
            pointSFX.Play();

        }
    }

    void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag == "Obstacle")
        {
            Time.timeScale = 0f;
            deathScreen.SetActive(true);
            dieSFX.Play();
        }
    }

}
