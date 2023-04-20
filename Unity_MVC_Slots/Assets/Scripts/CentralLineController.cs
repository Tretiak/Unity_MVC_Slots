namespace DefaultNamespace
{
    public class CentralLineController : Controller
    {
        public CentralLineController(View view, Model model) : base(view, model)
        {
        }
        protected override void AnalyzeResult()
        {
            var state = _model.States;
            bool isWin = state[3] == state[4] && state[3] == state[5];
            _view.DisplayWinText(isWin);
        }
    }
}