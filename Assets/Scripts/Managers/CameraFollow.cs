using System;
using UnityEngine;

namespace Managers
{
    public class CameraFollow2D : MonoBehaviour
    { 
        private Transform _player;
        private Camera _camera;
        
        public void Initialize(GameObject player)
        {
            SetCamera();
            this._player = player.transform;
            //Set camera to be orthographic
            _camera.orthographic = true;
            //Set camera size
            _camera.orthographicSize = 5; // could be set via settings
            //Set camera position
            _camera.transform.position = new Vector3(0, 0, -10);
            //Set camera background color to black
            _camera.backgroundColor = Color.black;
            
        }
        private void SetCamera()
        {
            _camera = gameObject.AddComponent<Camera>();
        }

        private void LateUpdate()
        {
            Vector3 cameraPosition = _player.position;
            cameraPosition.z = -10;
            transform.position = cameraPosition;

        }
    }
}