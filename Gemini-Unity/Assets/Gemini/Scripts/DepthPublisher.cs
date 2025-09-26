using UnityEngine;
using Unity.Robotics.ROSTCPConnector;
using RosMessageTypes.Sensor;
using System.Collections.Generic;

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
        cam.depthTextureMode = DepthTextureMode.Depth;
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
        Graphics.Blit(src, dest);
    }

    void LateUpdate()
    {
        RenderTexture.active = rt;
        readTex.ReadPixels(new Rect(0, 0, rt.width, rt.height), 0, 0);
        readTex.Apply();
        var data = readTex.GetRawTextureData<float>();
        var msg = new ImageMsg
        {
            header = new RosMessageTypes.Std.HeaderMsg { stamp = ROSConnection.instance.GetTime(), frame_id = "camera_optical_frame" },
            height = (uint)readTex.height,
            width = (uint)readTex.width,
            encoding = "32FC1",
            is_bigendian = 0,
            step = (uint)(readTex.width * sizeof(float)),
            data = new List<byte>(System.Buffer.ByteLength(data.Array))
        };
        ros.Publish(topic, msg);
    }
}
