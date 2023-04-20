using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class SlotMachine3DView : View
    {
        [SerializeField] private List<MeshRenderer> _slotValues;
        [SerializeField] private List<Material> _materials;
        [SerializeField] private TextMeshProUGUI _youWinText;
        [SerializeField] private List<Color> _colors;
        public override void DisplaySpinResult(List<int> values)
        {
            for (int i = 0; i < values.Count; i++)
            {
                _slotValues[i].material.color = GetColorById(values[i]);
            }
        }

        private Color GetColorById(int value)
        {
            return _colors[value];
        }

        public override void DisplayWinText(bool isActive)
        {
            _youWinText.gameObject.SetActive(isActive);
        }
        
    }
}