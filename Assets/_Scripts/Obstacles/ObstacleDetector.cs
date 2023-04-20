using System.Collections;
using System.Collections.Generic;
using UnityEngine;

namespace Evstr.Obstacles
{
    public class ObstacleDetector : MonoBehaviour
    {
        [SerializeField] private GameObject _gameOverPanel;
        private void OnTriggerEnter2D(Collider2D collision)
        {
            if (collision.gameObject.CompareTag("Obstacle"))
            {
                _gameOverPanel.SetActive(true);
                Time.timeScale = 0;
            }
        }
    }
}
