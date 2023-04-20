using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Evstr.Score
{
    public class ScoreIncrease : MonoBehaviour
    {
        [SerializeField] private Text _scoreText;
        public static int score;

        private void Start()
        {
            score = 0;
        }

        public void IncreaseScore()
        {
            score++;
        }

        private void Update()
        {
            _scoreText.text = score.ToString();
        }
    }
}
