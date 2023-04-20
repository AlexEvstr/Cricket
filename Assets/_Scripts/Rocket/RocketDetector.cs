using System.Collections;
using System.Collections.Generic;
using Evstr.Score;
using UnityEngine;

namespace Evstr.Rocket
{
    public class RocketDetector : MonoBehaviour
    {
        [SerializeField] private GameObject _plus10;

        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Enemy"))
            {
                collision.gameObject.SetActive(false);
                gameObject.SetActive(false);
                ScoreIncrease.score += 10;
                Instantiate(_plus10);
            }
        }
    }
}
