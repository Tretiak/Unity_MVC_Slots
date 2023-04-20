using System.Collections.Generic;
using System.Linq;
using UnityEditor;

namespace DefaultNamespace
{
    public abstract class Model
    {
        protected const int NumberOfSlots = 9;
        protected View _view;
        protected List<int> _states;
        protected int _spinsCount;
        public abstract bool HaveSpins();
        public int SpinsCount => _spinsCount;
        public List<int> States => _states;

        public Model(View view)
        {
            _view = view;
            _states = new int[NumberOfSlots].ToList();
        }

        public void SetState(List<int> newStates)
        {
            _states = newStates;
            _view.DisplaySpinResult(_states);
        }
    }
}