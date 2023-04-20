using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

namespace Evstr.Score
{
    public class BestScore : MonoBehaviour
    {
        [SerializeField] private Text _bestScoreText;
        public static int _bestScore;

        private void Start()
        {
            _bestScore = PlayerPrefs.GetInt("Best Score");
            _bestScoreText.text = _bestScore.ToString();
        }

        private void Update()
        {
            if (_bestScore < ScoreIncrease.score)
            {
                _bestScore = ScoreIncrease.score;
            }
            _bestScoreText.text = _bestScore.ToString();
        }

        private void OnDisable()
        {
            PlayerPrefs.SetInt("Best Score", _bestScore);
        }
    }
}
