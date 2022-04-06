using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    public GameObject obstacle;

    public float minSpeed;
    public float maxSpeed;
    public float currentSpeed;
    public float SpeedX;

    
    void Awake()
    {
        currentSpeed = minSpeed;
        generateObstacle();
    }

    public void ObstacleGap()
    {
        float randomwaittime = Random.Range(0.1f, 1.2f);
        Invoke("generateObstacle", randomwaittime);
    }

    void generateObstacle()
    {
        GameObject ObstIns = Instantiate(obstacle, transform.position, transform.rotation);

        ObstIns.GetComponent<ObstacleScript>().OGenerator = this;
    }

    // Update is called once per frame
    void Update()
    {
        if(currentSpeed < maxSpeed)
        {
            currentSpeed += SpeedX; 
        }
     
    }
}
