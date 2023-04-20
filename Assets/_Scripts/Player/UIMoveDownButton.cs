using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Evstr.Player
{
    public class UIMoveDownButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
    {
        [SerializeField] private GameObject _player;

        private float _speed = 5.0f;
        private bool _buttonPressed;

        public void OnPointerDown(PointerEventData eventData)
        {
            _buttonPressed = true;
            StartCoroutine(MoveDown());
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            _buttonPressed = false;
            StopCoroutine(MoveDown());
        }

        private IEnumerator MoveDown()
        {
            while (_buttonPressed && _player.transform.position.y > -3.9f)
            {
                _player.transform.Translate(Vector2.down * _speed * Time.deltaTime);
                yield return null;
            }
        }
    }
}