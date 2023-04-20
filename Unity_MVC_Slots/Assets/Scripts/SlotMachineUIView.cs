using System;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class SlotMachineUIView : View
    {
        [SerializeField] private List<Image> _slotValues;
        [SerializeField] private List<Sprite> _imagesByIds;
        [SerializeField] private TextMeshProUGUI _youWinText;

        
        public override void DisplaySpinResult(List<int> values)
        {
            for (int i = 0; i < values.Count; i++)
            {
                _slotValues[i].sprite = GetImageById(values[i]);
            }
        }
        public override void DisplayWinText(bool isActive)
        {
            _youWinText.gameObject.SetActive(isActive);
        }
        private Sprite GetImageById(int id)
        {
            return _imagesByIds[id];
        }
    }
}