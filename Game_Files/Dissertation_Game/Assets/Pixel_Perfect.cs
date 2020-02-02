using UnityEngine;
using System.Collections;
public class Pixel_Perfect : MonoBehaviour
{
    public int pixelsPerUnit = 100;

    [Range(1, 6)]
    public int zoom = 1;

    private Camera _camera;
    protected new Camera camera { get { if (_camera == null) { _camera = GetComponent<Camera>(); } return _camera; } }

    protected virtual void Awake()
    {
        Calculate();
    }

    protected virtual void Update()
    {
        Calculate();
    }

    protected virtual void LateUpdate()
    {
        Calculate();
    }

    private void Calculate()
    {
        camera.orthographicSize = ((Screen.height / 2f) / (float)pixelsPerUnit) / (float)zoom;
    }
}