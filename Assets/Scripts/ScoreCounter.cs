using UnityEngine;
using UnityEngine.UI;

namespace Assets.Scripts
{
    public class ScoreCounter : MonoBehaviour
    {
        public Text score;
        public ScoreManager scoreManager;

        void Update()
        {
            score.text = "Score: " + PlayerPrefs.GetInt("CURRENT_SCORE");
        }
    }
}