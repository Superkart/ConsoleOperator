using UnityEngine;

public class TestLearningInputMap : MonoBehaviour
{

    [SerializeField] private LearningInput input;
    [SerializeField] private float sensitivity = 0.01f;

    private void Update()
    {
        Vector2 look = input.mouseLook;
        transform.position += new Vector3(look.x, look.y, 0f) * sensitivity;
    }
}
