using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

namespace Evstr.GUI
{
    public class UIPlayButton : UIBaseButton
    {
        [SerializeField] private Text _lastScoreText;
        private int _score;

        private void Start()
        {
            _score = PlayerPrefs.GetInt("Last Score");
            _lastScoreText.text = _score.ToString();
        }

        public override void OnClick()
        {
            SceneManager.LoadScene(1);
            Time.timeScale = 1;
        }
    }
}
