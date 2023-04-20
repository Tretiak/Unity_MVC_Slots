using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace DefaultNamespace
{
    public abstract class Controller
    {
        protected View _view;
        protected Model _model;

        public Controller(View view, Model model)
        {
            _view = view;
            _model = model;
        }
        
        public void Spin()
        {
            var tempState = GenerateRandom();
            _model.SetState(tempState);
            AnalyzeResult();
        }

        private List<int> GenerateRandom()
        {
            List<int> tempState = new int[_model.States.Count].ToList();
            for (int i = 0; i < _model.States.Count; i++)
            {
                tempState[i] = Random.Range(0, 6);
            }

            return tempState;
        }

        protected abstract void AnalyzeResult();
    }
}