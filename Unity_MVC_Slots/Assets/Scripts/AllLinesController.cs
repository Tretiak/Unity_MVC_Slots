namespace DefaultNamespace
{
    public class AllLinesController : Controller
    {
        public AllLinesController(View view, Model model) : base(view, model)
        {
        }
        protected override void AnalyzeResult()
        {
            var state = _model.States;
            bool isWin =
                state[0] == state[1] && state[0] == state[2] || // Top line
                state[3] == state[4] && state[3] == state[5] || // Middle line
                state[6] == state[7] && state[6] == state[8];   // Bottom line
        
            _view.DisplayWinText(isWin);
        }
    }
}