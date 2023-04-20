using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Evstr.Score;

namespace Evstr.Player
{
    public class ScoreDetector : MonoBehaviour
    {
        [SerializeField] private ScoreIncrease _scoreIncrease;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Score"))
            {
                _scoreIncrease.IncreaseScore();
            }
        }
    }
}
