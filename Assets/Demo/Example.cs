#region Includes
using System;

using TMPro;

using UnityEngine;
#endregion

namespace TS.DoubleSlider
{
    public class Example : MonoBehaviour
    {
        #region Variables

        [Header("References")]
        [SerializeField] private DoubleSlider _slider;
        [SerializeField] private TextMeshProUGUI _labelRange;

        #endregion

        private void Awake()
        {
            // Call to setup slider with min, max and initial values.
            //_slider.Setup(10, 50, 25, 40);

            _slider.OnValueChanged.AddListener(SliderDouble_ValueChanged);
        }

        private void SliderDouble_ValueChanged(float min, float max)
        {
            _labelRange.text = string.Format("{0}-{1}", Mathf.RoundToInt(min), Mathf.RoundToInt(max));
        }
    }
}