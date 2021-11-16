//
// 1. Add a Quad in Unity
// 2. Parent the quad under camera, to prevent frustum culling.
// 3. Attach this shader.
//
Shader "Quad/Fullscreen"
{
	Properties
	{
		_Tint ("Tint", Color) = (1, 1, 1, 1)
	}

	SubShader
	{
		Cull Off ZWrite Off ZTest Off

		Pass
		{
			CGPROGRAM
			#pragma vertex vert
			#pragma fragment frag

			#include "UnityCG.cginc"

			float4 _Tint;

			struct appdata
			{
				float4 vertex : POSITION;
			};

			struct v2f
			{
				float4 vertex : SV_POSITION;
			};

			v2f vert(appdata v)
			{
				v2f o;
				o.vertex = v.vertex;
				o.vertex.x *= 2;
				o.vertex.y *= 4;
				o.vertex.xy += float2(0,-1);
				return o;
			}

			fixed4 frag(v2f i) : SV_Target
			{
				return _Tint;
			}
			ENDCG
		}
	}
}