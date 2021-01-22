#region Includes
using System;
using UnityEngine;
#endregion

namespace TS.Examples.SliderDouble
{
    public class Example : MonoBehaviour
    {
        #region Variables

        [Header("References")]
        [SerializeField] private SliderDouble _slider;

        #endregion

        private void Start()
        {
            _slider.Setup(10, 50, 25, 40);
            _slider.ValueChanged.AddListener(SliderDouble_ValueChanged);
        }

        private void SliderDouble_ValueChanged(float arg0, float arg1)
        {
            Debug.Log("Value Changed, min: " + arg0 + ", max: " + arg1);
        }
    }
}