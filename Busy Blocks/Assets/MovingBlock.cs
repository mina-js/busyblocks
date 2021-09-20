using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingBlock : MonoBehaviour
{
    [SerializeField] float speed;
    [SerializeField] float borderLeft;
    [SerializeField] float resetPoint;
    private float startingYPosition;
    public static int Score;
    public static int HighScore;

    // Start is called before the first frame update
    void Start()
    {
        startingYPosition = transform.position.y;
        Score = 0;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += Vector3.left * speed * Time.deltaTime;

        if(transform.position.x <= borderLeft)
        {
            float newY = startingYPosition + UnityEngine.Random.Range(-1f, 1f);
            transform.position = new Vector3(resetPoint, newY, 0);
            Score++;
            if (Score > HighScore) HighScore = Score;
        }
    }
}
