using UnityEngine;
using Unity.Robotics.ROSTCPConnector;
using RosMessageTypes.Sensor;
using System.Collections.Generic;
using Unity.Collections;  // Ensure this is included for NativeArray handling

public class DepthPublisher : MonoBehaviour
{
    public string topic = "optical/Front/depth";
    Camera cam;
    RenderTexture rt;
    Material linearizeMat;
    Texture2D readTex;
    ROSConnection ros;

    void Start()
    {
        cam = GetComponent<Camera>();
        cam.depthTextureMode = DepthTextureMode.Depth;  // Enable depth texture mode
        rt = new RenderTexture(cam.pixelWidth, cam.pixelHeight, 0, RenderTextureFormat.RFloat);
        linearizeMat = new Material(Shader.Find("Hidden/LinearizeDepth"));
        readTex = new Texture2D(cam.pixelWidth, cam.pixelHeight, TextureFormat.RFloat, false);
        ros = ROSConnection.instance;
    }

    void OnRenderImage(RenderTexture src, RenderTexture dest)
    {
        linearizeMat.SetFloat("_Near", cam.nearClipPlane);
        linearizeMat.SetFloat("_Far", cam.farClipPlane);
        Graphics.Blit(src, rt, linearizeMat);
        Graphics.Blit(src, dest); // Blit to screen as well
    }

    void LateUpdate()
    {
        RenderTexture.active = rt;
        readTex.ReadPixels(new Rect(0, 0, rt.width, rt.height), 0, 0);
        readTex.Apply();

        // Convert NativeArray to regular array
        NativeArray<float> data = readTex.GetRawTextureData<float>();
        float[] dataArray = data.ToArray();  // Convert to regular array

        // Construct the ROS message without a timestamp
        var msg = new ImageMsg
        {
            header = new RosMessageTypes.Std.HeaderMsg
            {
                frame_id = "camera_optical_frame"  // Only set the frame_id (no timestamp needed)
            },
            height = (uint)readTex.height,
            width = (uint)readTex.width,
            encoding = "32FC1",
            is_bigendian = 0,
            step = (uint)(readTex.width * sizeof(float)),
            data = new byte[System.Buffer.ByteLength(dataArray)] // Use byte[] directly
        };

        // Copy data from float[] to byte[]
        System.Buffer.BlockCopy(dataArray, 0, msg.data, 0, msg.data.Length);

        // Send the message using SendMessage() instead of Publish()
        ros.SendMessage(topic, msg);  // Send the message to ROS
    }
}
