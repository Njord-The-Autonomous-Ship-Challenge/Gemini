Shader "Hidden/LinearizeDepth"
{
    SubShader
    {
        Pass
        {
            ZTest Always ZWrite Off Cull Off
            HLSLPROGRAM
            #pragma vertex vert
            #pragma fragment frag

            float _Near, _Far;

            struct v2f
            {
                float2 uv : TEXCOORD0;
                float4 vertex : SV_POSITION;
            };

            v2f vert(uint id : SV_VertexID)
            {
                v2f o;
                o.uv = float2((id << 1) & 2, id & 2);
                o.vertex = float4(o.uv * 2 - 1, 0, 1);
                return o;
            }

            Texture2D<float> _CameraDepthTexture;
            SamplerState s;

            float frag(v2f i) : SV_Target
            {
                float d = _CameraDepthTexture.Sample(s, i.uv);
                float N = _Near, F = _Far;
                return (2.0 * N * F) / (F + N - d * (F - N));
            }
            ENDHLSL
        }
    }
}
