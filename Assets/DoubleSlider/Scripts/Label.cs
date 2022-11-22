#region Includes
using UnityEngine;
using UnityEngine.UI;
#endregion

namespace TS.DoubleSlider
{
    public class Label : MonoBehaviour
    {
        #region Variables

        public string Text
        {
            get { return _label.text; }
            set { _label.text = value; }
        }

        private Text _label;

        #endregion

        private void Awake()
        {
            if (!TryGetComponent<Text>(out _label))
            {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
                Debug.LogError("Missing Text Component");
#endif
            }
        }
    }
}