using DG.Tweening;
using UnityEngine;

namespace Assets.Scripts.UI
{
    public class UIWindow : MonoBehaviour{

        public enum WindowType
        {
            None,
            Shop,
        }

        public WindowType Type;
        public RectTransform RectTransform;

        private float _lastPos;

        public virtual void OnOpen()
        {
            gameObject.SetActive(true);
            _lastPos = RectTransform.localPosition.x;
            RectTransform.DOAnchorPosX(-300, 1);
        }

        public virtual void OnClose()
        {
            RectTransform.DOLocalMoveX(_lastPos, 1).OnComplete(() => { gameObject.SetActive(false); });
        }
    }
}

