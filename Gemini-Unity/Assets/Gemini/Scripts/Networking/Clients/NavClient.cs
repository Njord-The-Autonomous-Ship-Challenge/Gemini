﻿using UnityEngine;
using Gemini.EMRS.Core;
using UnityEngine.Rendering;
using Navigation;
using Gemini.Core;
using Grpc.Core;
using System;


public class NavClient : Sensor
{

    private Navigation.Navigation.NavigationClient _navigationClient = new Navigation.Navigation.NavigationClient(_streamingChannel);

    private Vec3 _navPosition;
    private Navigation.Quaternion _navOrientation;
    private Vec3 _navLinearVelocity;
    private Vec3 _navAngularVelocity;

    private Vector3 _unityPosition;
    private UnityEngine.Quaternion _unityOrientation;
    private Vector3 _unityLinearVelocity;
    private Vector3 _unityAngularVelocity;

    private const float latOffset = 63.435166667f;
    private const float lonOffset = 10.3929167f;
    private const float R_N = 6397309.16f;
    private const float R_M = 6600589.00f;

    private Rigidbody _rigidBody;

    private void Awake()
    {
        SetupSensorCallbacks(new SensorCallback(NavUpdate, SensorCallbackOrder.Last)); 
    }

    private void Start()
    {
        _navPosition = new Vec3();
        _navOrientation = new Navigation.Quaternion();

        _navLinearVelocity = new Vec3();
        _navAngularVelocity = new Vec3();

        if (GetComponent<Rigidbody>() != null)
        {
            _rigidBody = GetComponent<Rigidbody>();
        }
    }

    void NavUpdate(ScriptableRenderContext context, Camera[] cameras)
    {
        _unityPosition = ConventionTransforms.PositionUnityToNED(gameObject.transform.position);

        _unityOrientation = UnityEngine.Quaternion.Euler(ConventionTransforms.EulerOrientationUnityToNED(gameObject.transform.rotation.eulerAngles));

        // Set Navigation Position and orientation to the same value as the Unity position and orientation
        // TODO: This should be done in a own function

        // Publishes local coordinates
        _navPosition.X = _unityPosition.x;
        _navPosition.Y = _unityPosition.y;
        //_navPosition.Z = _unityPosition.z;



        // Publishes latitude and longitude
        //_navPosition.X = _unityPosition.x * (float)Math.Atan2(1, R_M * Math.PI / 180f) + latOffset; // Latitude
        //_navPosition.Y = _unityPosition.y * (float)Math.Atan2(1, R_N * Math.PI / 180f * Math.Cos(latOffset * Math.PI / 180f)) + lonOffset; // Longitude
        _navPosition.Z = gameObject.transform.rotation.eulerAngles.y; // Heading

        _navOrientation.X = _unityOrientation.x;
        _navOrientation.Y = _unityOrientation.y;
        _navOrientation.Z = _unityOrientation.z;
        _navOrientation.W = _unityOrientation.w;

        if (_rigidBody != null)
        {

            _unityLinearVelocity = ConventionTransforms.VelocityUnityToNED(_rigidBody.velocity);
            _navLinearVelocity.X = _unityLinearVelocity.x;
            _navLinearVelocity.Y = _unityLinearVelocity.y;
            _navLinearVelocity.Z = _unityLinearVelocity.z;

            _unityAngularVelocity = ConventionTransforms.AngularVelocityUnityToNED(_rigidBody.angularVelocity); 
            _navAngularVelocity.X = _unityAngularVelocity.x;
            _navAngularVelocity.Y = _unityAngularVelocity.y;
            _navAngularVelocity.Z = _unityAngularVelocity.z;

        }
        else {
            _navLinearVelocity.X = 0.0f;
            _navLinearVelocity.Y = 0.0f;
            _navLinearVelocity.Z = 0.0f;

            _navAngularVelocity.X = 0.0f;
            _navAngularVelocity.Y = 0.0f;
            _navAngularVelocity.Z = 0.0f;
        }

        gate = true;
    }

    public override bool SendMessage()
    {
        bool success = false;

        connectionTime = Time.time;

        if (connectionTime < ConnectionTimeout || connected)
        {
            try
            {
                success = _navigationClient.SendNavigationMessage(
                    new NavigationRequest
                    {
                        TimeStamp = OSPtime,
                        Position = _navPosition,
                        Orientation = _navOrientation,
                        LinearVelocity = _navLinearVelocity,
                        AngularVelocity = _navAngularVelocity
                    }).Success;

                connected = success;
            } catch (RpcException e)
            {
                Debug.LogException(e);
            } 
        }

        return success;
    }

}
