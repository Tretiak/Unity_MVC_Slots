using System.Collections.Generic;
using UnityEngine;

namespace DefaultNamespace
{
    public abstract class View : MonoBehaviour
    {
        public abstract void DisplaySpinResult(List<int> state);
        public abstract void DisplayWinText(bool isActive);
    }
}