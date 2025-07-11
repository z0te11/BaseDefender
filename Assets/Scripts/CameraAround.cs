using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraAround : MonoBehaviour
{
	public Transform target;
	public Vector3 offset;
	public float sensitivity = 3; // чувствительность мышки
	public float limit = 80; // ограничение вращения по Y
	public float zoom = 0.25f; // чувствительность при увеличении, колесиком мышки
	public float zoomMax = 10; // макс. увеличение
	public float zoomMin = 3; // мин. увеличение
	[SerializeField] private bool isFolllow = false;
	private float X, Y;
	

	void Start () 
	{
		limit = Mathf.Abs(limit);
		if(limit > 90) limit = 90;
		offset = new Vector3(offset.x, offset.y, -Mathf.Abs(zoomMax));
		transform.position = target.position + offset;
	}

	void Update ()
	{
		if (isFolllow){
			if(Input.GetAxis("Mouse ScrollWheel") > 0) offset.z += zoom;
			else if(Input.GetAxis("Mouse ScrollWheel") < 0) offset.z -= zoom;
			offset.z = Mathf.Clamp(offset.z, -Mathf.Abs(zoomMax), -Mathf.Abs(zoomMin));
			if (Input.GetKey(KeyCode.Mouse0))
			{
				X = transform.localEulerAngles.y + Input.GetAxis("Mouse X") * sensitivity;
				Y += Input.GetAxis("Mouse Y") * sensitivity;
			}
			else
			{
				X = transform.localEulerAngles.y + Input.GetAxis("Horizontal");
				Y += Input.GetAxis("Vertical");
			}
			Y = Mathf.Clamp (Y, -limit, limit);
			transform.localEulerAngles = new Vector3(-Y, X, 0);
			transform.position = transform.localRotation * offset + target.position;
		}
	}

	private void StartCameraFollow()
	{
		isFolllow = true;
	}

	private void OnEnable()
	{
		GameController.isGameStart += StartCameraFollow;
	}

	private void OnDisable()
	{
		GameController.isGameStart -= StartCameraFollow;
	}
}
