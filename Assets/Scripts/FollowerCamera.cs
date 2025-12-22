using UnityEngine;

public class FollowerCamera : MonoBehaviour
{
    [SerializeField] private Transform _target;
    
    private Camera _mainCamera;
    
    // Start is called before the first frame update
    void Start()
    {
        _mainCamera = Camera.main;
    }

    private void LateUpdate()
    {
        if (_target != null)
        {
            transform.position = new Vector3(_target.position.x, _target.position.y, transform.position.z);
        }
    }
}
