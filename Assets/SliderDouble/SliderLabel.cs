#region Includes
using UnityEngine;
using UnityEngine.UI;
#endregion

namespace TS.Examples.SliderDouble
{
    public class SliderLabel : MonoBehaviour
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
            _label = GetComponent<Text>();

            if (_label == null)
            {
#if UNITY_EDITOR || DEVELOPMENT_BUILD
                Debug.LogError("Missing Text Component");
#endif
            }
        }
    }
}