// Upgrade NOTE: replaced 'mul(UNITY_MATRIX_MVP,*)' with 'UnityObjectToClipPos(*)'

Shader "VideoScreen" {

 Properties {
     _MainTex ("Base (RGB) Trans (A)", 2D) = "white" {}
	 _Transparency ("Mult ", Range (0, 1)) = 0.5
	 //_InvertVertical ("InvertVertical", bool) = false
	 [MaterialToggle] _InvertVertical("InvertVertical", float) = 0

	 _Width ("Width", Range (0, 1)) = 1
 }
 

 SubShader {
     Tags {"Queue"="Transparent" "IgnoreProjector"="True" "RenderType"="Transparent"}
     LOD 100
     
     ZWrite Off
	 ZTest Off
	 Cull Off

     Blend SrcAlpha OneMinusSrcAlpha 
     
     Pass {  
         CGPROGRAM
             #pragma vertex vert
             #pragma fragment frag

             #include "UnityCG.cginc"
 
             struct appdata_t {
                 float4 vertex : POSITION;
                 float2 texcoord : TEXCOORD0;
             };
 
             struct v2f {
                 float4 vertex : SV_POSITION;
                 half2 texcoord : TEXCOORD0;
             };
 
             sampler2D _MainTex;
             float4 _MainTex_ST;
			 float _Transparency;
			 float _InvertVertical;
			 float _Width;
             
             v2f vert (appdata_t v)
             {	
                v2f o;

				o.vertex = v.vertex;
				o.vertex.x *= 2;
				o.vertex.y *=4;


				o.vertex.x *= _Width;

				if(_InvertVertical > .5){
					o.vertex.y -=2;
					o.vertex.y *=-1;
				}

				o.vertex.xy += float2(0,-1);

                o.texcoord = TRANSFORM_TEX(v.texcoord, _MainTex); //+ float2(0,-0.5)
				o.texcoord.xy *= float2(1,2);
				o.texcoord.xy += float2(0,-1);



                return o;
             }
             
             fixed4 frag (v2f i) : SV_Target
             {
                 fixed4 col = tex2D(_MainTex, i.texcoord);

				 col.a = _Transparency;
				 return col;
             }
         ENDCG
     }
 }
 
 }
