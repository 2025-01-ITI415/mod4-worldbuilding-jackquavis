using UnityEngine;
using UnityEngine.UI;

public class EndScreenDisplay : MonoBehaviour
{
    public Text coinText;
    public Text timeText;

    void Start()
    {
        int coins = PlayerPrefs.GetInt("CoinsCollected", 0);
        float time = PlayerPrefs.GetFloat("CompletionTime", 0f);

        coinText.text = "Coins: " + coins;
        timeText.text = "Time: " + time.ToString("F2") + "s";
    }
}
