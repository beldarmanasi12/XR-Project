
using UnityEngine;
using UnityEngine.UIElements;

public class animationStateController : MonoBehaviour
{
    public GameObject gameObject;
    
    public GameObject actorObject;
    private Animator animator;
    private Button runButton;
    private Button walkButton;
    private string WALK_COUNT = "walk_count";
    private string RUN_COUNT = "run_count";
    // Start is called before the first frame update
    void Start()
    {
        // Setup buttons
        var rootElement = GetComponent<UIDocument>().rootVisualElement;
        runButton = rootElement.Q<Button>("run-button");
        walkButton = rootElement.Q<Button>("walk-button");
        runButton.visible = false;
        walkButton.visible = false;
        // Actions on button pressed
        runButton.clicked += runPressed;
        walkButton.clicked += walkPressed;

        // Animator
        animator = gameObject.GetComponent<Animator>();
    }

    void runPressed() {
        animator.SetInteger(RUN_COUNT, 2);
    }
    
    void walkPressed() {
         animator.SetInteger(WALK_COUNT, 2);
    }

    void Update()
    {
        walkButton.visible = runButton.visible = actorObject.GetComponent<Renderer>().isVisible;
    }
    
}