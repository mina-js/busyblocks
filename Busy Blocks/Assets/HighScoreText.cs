using UnityEngine;
using TMPro;

public class HighScoreText : MonoBehaviour
{
    void Update()
    {
        GetComponent<TMP_Text>().SetText(MovingBlock.HighScore.ToString());
    }
}