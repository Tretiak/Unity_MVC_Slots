using UnityEngine;
using UnityEngine.UI;

namespace DefaultNamespace
{
    public class BootTestScript : MonoBehaviour
    {
        [SerializeField] private SlotMachine3DView _3dView;
        [SerializeField] private SlotMachineUIView _uiView;
        [SerializeField] private Button _spinButton;

        [SerializeField] private bool is3D;
        [SerializeField] private bool is3LineLogic;
  
        private void Awake()
        {
            View viewPrefab = InitView();
            var view = Instantiate(viewPrefab);
            Model model = new UnlimitedSpinsModel(view);
            Controller controller = InitController(view, model);
            InitSpinButton(controller);
        }

        private void InitSpinButton(Controller controller) => _spinButton.onClick.AddListener((() => { controller.Spin(); }));

        private View InitView() => is3D ? _3dView : _uiView;

        private Controller InitController(View view, Model model) => is3LineLogic ? new CentralLineController(view, model) : new AllLinesController(view,model);
    }
}