using UnityEngine;
using UnityEngine.UI;


public class PlayerScript : MonoBehaviour
{
    public float Force;
    float score;

    [SerializeField]
    bool isGrounded = false;
    bool isPlaying = true;

    Rigidbody2D Rbody;

    public Text ScrTxt;
    public GameObject gameoverscreen;
    //public GameObject return_button;
    public GameObject instruction;

    private void Awake()
    {
        Rbody = GetComponent<Rigidbody2D>();
        score = 0;
    }


    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            if(isGrounded== true)
            {
                Rbody.AddForce(Vector2.up * Force);
                isGrounded = false;
            }
            instruction.SetActive(false);

        }

        if (isPlaying)
        {
            score += Time.deltaTime * 4;
            ScrTxt.text = "SCORE: " + score.ToString("F");
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.CompareTag("ground"))
        {
            if(isGrounded == false)
            {
                isGrounded = true;
            }
        }

        if (collision.gameObject.CompareTag("obstacle"))
        {
            ObstacleScript obstacleScript = GameObject.FindObjectOfType<ObstacleScript>();
            obstacleScript.isPlaying = false;
            isPlaying = false;
            //Time.timeScale = 0;
            gameoverscreen.SetActive(true);
            //return_button.SetActive(true);
        }
    }

}
