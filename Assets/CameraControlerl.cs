using UnityEngine;

public class CameraControl : MonoBehaviour
{
    public float minZoom = 30.0f;
    public float maxZoom = 100.0f;
    public float zoomSpeed = 0.01f;

    private Camera mainCamera;
    private float lastZoomDistance;

    void Start()
    {
        mainCamera = Camera.main;
    }

    void Update()
    {
        if (Input.touchCount == 2)
        {
            Touch touchZero = Input.GetTouch(0);
            Touch touchOne = Input.GetTouch(1);

            if (touchZero.phase == TouchPhase.Began || touchOne.phase == TouchPhase.Began)
            {
                lastZoomDistance = Vector2.Distance(touchZero.position, touchOne.position);
            }
            else if (touchZero.phase == TouchPhase.Moved || touchOne.phase == TouchPhase.Moved)
            {
                float currentZoomDistance = Vector2.Distance(touchZero.position, touchOne.position);
                float difference = currentZoomDistance - lastZoomDistance;
                lastZoomDistance = currentZoomDistance;

                ZoomCamera(difference * zoomSpeed);
            }
        }
    }

    private void ZoomCamera(float increment)
    {
        mainCamera.fieldOfView = Mathf.Clamp(mainCamera.fieldOfView - increment, minZoom, maxZoom);
    }
}
