using UnityEngine;

public class ObstacleScript : MonoBehaviour
{
    public ObstacleGenerator OGenerator;
    public bool isPlaying = true;

    // Update is called once per frame
    void Update()
    {
        if (isPlaying)
        { 
        transform.Translate(Vector2.left * OGenerator.currentSpeed * Time.deltaTime);
        }
        else
        {
            Destroy(this.gameObject);
        }

    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.CompareTag("nLine"))
        {
            OGenerator.ObstacleGap();
        }

        if (collision.gameObject.CompareTag("Finish"))
        {
            Destroy(this.gameObject);
        }
    }
}
