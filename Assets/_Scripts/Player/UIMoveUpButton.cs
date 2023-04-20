using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

namespace Evstr.Player
{
    public class UIMoveUpButton : MonoBehaviour, IPointerDownHandler, IPointerUpHandler
    {
        [SerializeField] private GameObject _player;

        private float _speed = 5.0f;
        private bool _buttonPressed;

        public void OnPointerDown(PointerEventData eventData)
        {
            _buttonPressed = true;
            StartCoroutine(MoveUp());
        }

        public void OnPointerUp(PointerEventData eventData)
        {
            _buttonPressed = false;
            StopCoroutine(MoveUp());
        }

        private IEnumerator MoveUp()
        {
            while (_buttonPressed && _player.transform.position.y < 4.0f)
            {
                _player.transform.Translate(Vector2.up * _speed * Time.deltaTime);
                yield return null;
            }
        }
    }
}
