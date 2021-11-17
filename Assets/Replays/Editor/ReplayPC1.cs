using System;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class ReplayPC1 : ReplayBase {
private List<Action> Execute() {
var r = new List<Action>();
r.Add(delegate{
Add(0xF9AC, GameObject.Find("/CUBEPETR"));
Get(0xF9AC).SetLocalPose(0f,0.421f,-2.528f,0f,0f,0f,1f);
Add(0xF9B6, GameObject.Find("/Main Camera"));
Get(0xF9B6).SetLocalPose(0.76f,2.04f,-10f,0f,0f,0f,1f);
Add(0xF9DC, GameObject.Find("/BracerRight/HandPivot/HandRemasteredNew"));
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 0f);
Add(0xF9F6, GameObject.Find("/BracerLeft"));
Get(0xF9F6).SetLocalPose(0.124f,0f,0f,0f,0f,-1f,0f);
Add(0xFA0E, GameObject.Find("/BracerLeft/HandPivot/HandRemasteredNew"));
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 0f);
Add(0xFA26, GameObject.Find("/BracerRight"));
Get(0xFA26).SetLocalPose(0f,0f,0f,0f,0f,0f,1f);
});
return r;
}
private List<Action> Execute0() {
var r = new List<Action>();
r.Add(delegate{
Get(0xF9AC).SetLocalPose(0f,0.418275f,-2.528f,0f,0f,0f,1f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 0f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 0f);
});
r.Add(delegate{
Get(0xF9AC).SetLocalPose(0f,0.412825f,-2.528f,0f,0f,0f,1f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 0f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 0f);
});
r.Add(delegate{
Get(0xF9AC).SetLocalPose(0f,0.40465f,-2.528f,0f,0f,0f,1f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 0.02f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 0.02f);
});
r.Add(delegate{
Get(0xF9AC).SetLocalPose(0f,0.39375f,-2.528f,0f,0f,0f,1f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 0.02f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 0.02f);
});
r.Add(delegate{
Get(0xF9AC).SetLocalPose(0f,0.380125f,-2.528f,0f,0f,0f,1f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 0.02f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 0.02f);
});
r.Add(delegate{
Get(0xF9AC).SetLocalPose(0f,0.363775f,-2.528f,0f,0f,0f,1f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 0.02f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 0.02f);
});
r.Add(delegate{
Get(0xF9AC).SetLocalPose(0f,0.3447f,-2.528f,0f,0f,0f,1f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 0.02f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 0.02f);
});
r.Add(delegate{
Get(0xF9AC).SetLocalPose(0f,0.3229f,-2.528f,0f,0f,0f,1f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 0.02f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 0.02f);
});
r.Add(delegate{
Get(0xF9AC).SetLocalPose(0f,0.298375f,-2.528f,0f,0f,0f,1f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 0.02f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 0.02f);
});
r.Add(delegate{
Get(0xF9AC).SetLocalPose(0f,0.271125f,-2.528f,0f,0f,0f,1f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 0.02f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 0.02f);
});
r.Add(delegate{
Get(0xF9AC).SetLocalPose(0f,0.24115f,-2.528f,0f,0f,0f,1f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 0.02f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 0.02f);
});
r.Add(delegate{
Get(0xF9AC).SetLocalPose(0f,0.20845f,-2.528f,0f,0f,0f,1f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 0.02f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 0.02f);
});
r.Add(delegate{
Get(0xF9AC).SetLocalPose(0f,0.173025f,-2.528f,0f,0f,0f,1f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 0.02f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 0.02f);
});
r.Add(delegate{
Get(0xF9AC).SetLocalPose(0f,0.134875f,-2.528f,0f,0f,0f,1f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 0.02f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 0.02f);
});
r.Add(delegate{
Get(0xF9AC).SetLocalPose(0f,0.09400003f,-2.528f,0f,0f,0f,1f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 0.02f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 0.02f);
});
r.Add(delegate{
Get(0xF9AC).SetLocalPose(0f,0.05040004f,-2.528f,0f,0f,0f,1f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 0.02f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 0.02f);
});
r.Add(delegate{
Get(0xF9AC).SetLocalPose(0f,0.004075039f,-2.528f,0f,0f,0f,1f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 0.02f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 0.02f);
});
r.Add(delegate{
Get(0xF9AC).SetLocalPose(1.202322E-07f,-0.002384948f,-2.528f,9.378643E-08f,1.358775E-07f,5.553623E-07f,1f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 0.02f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 0.02f);
});
r.Add(delegate{
Get(0xF9AC).SetLocalPose(3.769669E-07f,-0.003676876f,-2.528f,-7.863243E-08f,1.209727E-07f,2.711097E-07f,1f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 0.02f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 0.02f);
});
r.Add(delegate{
Get(0xF9AC).SetLocalPose(5.453992E-07f,-0.003935271f,-2.528f,-6.017438E-08f,1.710417E-07f,6.103971E-08f,1f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 0.02f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 0.02f);
});
r.Add(delegate{
Get(0xF9AC).SetLocalPose(5.727096E-07f,-0.003986937f,-2.528f,3.158966E-08f,1.071677E-07f,-6.837702E-09f,1f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 0.02f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 0.02f);
});
r.Add(delegate{
Get(0xF9AC).SetLocalPose(5.720619E-07f,-0.003997285f,-2.528f,-2.477538E-09f,1.703889E-07f,1.818979E-08f,1f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 0.02f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 0.02f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44986f,1.36525f,0.7856669f,-0.710376f,0.009543792f,0.02434898f,0.7033364f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 0.3533334f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 0.3533334f);
Get(0xFA26).SetLocalPose(1.38629f,1.287578f,0.8662474f,0.5776434f,-0.4771037f,0.354063f,-0.5597674f);
});
r.Add(delegate{
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 0.3533334f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 0.3533334f);
});
r.Add(delegate{
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 0.3533334f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 0.3533334f);
});
r.Add(delegate{
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 0.3533334f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 0.3533334f);
});
r.Add(delegate{
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 0.3533334f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 0.3533334f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449853f,1.365048f,0.785998f,-0.7103857f,0.009549794f,0.02431612f,0.7033277f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 0.4479781f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 0.4479781f);
Get(0xFA26).SetLocalPose(1.38598f,1.287132f,0.8652349f,0.5773572f,-0.4769576f,0.3544437f,-0.5599462f);
});
r.Add(delegate{
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 0.4479781f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 0.4479781f);
});
r.Add(delegate{
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 0.4479781f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 0.4479781f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449797f,1.365083f,0.7859729f,-0.7103848f,0.009552709f,0.02432362f,0.7033282f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 0.4866474f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 0.4866474f);
Get(0xFA26).SetLocalPose(1.387291f,1.287441f,0.86428f,0.5775566f,-0.4769412f,0.3542944f,-0.559849f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449661f,1.365106f,0.7859837f,-0.710375f,0.009584668f,0.02434208f,0.7033371f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 0.5091358f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 0.5091358f);
Get(0xFA26).SetLocalPose(1.387979f,1.287081f,0.8643281f,0.577536f,-0.4771035f,0.3545977f,-0.5595399f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449654f,1.365232f,0.7860373f,-0.7103804f,0.009577896f,0.02432601f,0.7033322f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 0.5306529f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 0.5306529f);
Get(0xFA26).SetLocalPose(1.388267f,1.286083f,0.8639991f,0.5774408f,-0.4772563f,0.3547007f,-0.5594425f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449705f,1.36503f,0.7860332f,-0.710365f,0.009588632f,0.02434259f,0.7033471f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 0.5400088f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 0.5400088f);
Get(0xFA26).SetLocalPose(1.388508f,1.285475f,0.86375f,0.5773922f,-0.4772739f,0.3545933f,-0.5595457f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44962f,1.364975f,0.7858618f,-0.7103666f,0.009599495f,0.02433462f,0.7033456f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 0.5620127f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 0.5620127f);
Get(0xFA26).SetLocalPose(1.388421f,1.286612f,0.8639641f,0.5773046f,-0.4773158f,0.3545544f,-0.5596251f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449611f,1.365029f,0.7857388f,-0.7103805f,0.009599743f,0.02433175f,0.7033318f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 0.5823483f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 0.5823483f);
Get(0xFA26).SetLocalPose(1.388474f,1.286939f,0.8637975f,0.5774592f,-0.4771922f,0.3547054f,-0.5594752f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449692f,1.365043f,0.7856512f,-0.7103847f,0.00959029f,0.02433009f,0.7033275f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 0.5991482f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 0.5991482f);
Get(0xFA26).SetLocalPose(1.388415f,1.286094f,0.8639997f,0.5776361f,-0.4771974f,0.354939f,-0.5591399f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449718f,1.364911f,0.7856708f,-0.7103972f,0.009622036f,0.0243163f,0.703315f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 0.6109155f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 0.6109155f);
Get(0xFA26).SetLocalPose(1.388366f,1.285696f,0.8640652f,0.5776736f,-0.4772233f,0.355067f,-0.5589979f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449627f,1.365002f,0.7855933f,-0.7103835f,0.009620048f,0.02432834f,0.7033285f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 0.6332573f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 0.6332573f);
Get(0xFA26).SetLocalPose(1.388244f,1.285665f,0.8631306f,0.5775172f,-0.4774035f,0.3554848f,-0.55874f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449581f,1.364989f,0.7855861f,-0.7103837f,0.009601023f,0.02435683f,0.7033276f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 0.6434363f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 0.6434363f);
Get(0xFA26).SetLocalPose(1.388451f,1.285354f,0.8632601f,0.5774049f,-0.4774077f,0.355568f,-0.5587996f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449538f,1.365094f,0.7858791f,-0.710377f,0.009624806f,0.02437019f,0.7033334f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 0.6638249f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 0.6638249f);
Get(0xFA26).SetLocalPose(1.388164f,1.286203f,0.8621951f,0.5773496f,-0.4773082f,0.3555647f,-0.5589437f);
});
r.Add(delegate{
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 0.6638249f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 0.6638249f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44956f,1.365143f,0.7859365f,-0.7104045f,0.009606442f,0.02431705f,0.7033078f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 0.6845883f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 0.6845883f);
Get(0xFA26).SetLocalPose(1.388903f,1.285585f,0.8613504f,0.5778211f,-0.4768229f,0.3550062f,-0.5592257f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449642f,1.365084f,0.7859525f,-0.7104096f,0.009641472f,0.0242922f,0.703303f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 0.7142722f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 0.7142722f);
Get(0xFA26).SetLocalPose(1.388814f,1.286327f,0.8596682f,0.578125f,-0.4764977f,0.354785f,-0.5593292f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449485f,1.36507f,0.786011f,-0.710395f,0.009639151f,0.02427712f,0.7033184f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 0.7250371f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 0.7250371f);
Get(0xFA26).SetLocalPose(1.388393f,1.286144f,0.8588933f,0.5784668f,-0.4762967f,0.3546339f,-0.5592428f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449436f,1.364914f,0.7858791f,-0.710398f,0.009630376f,0.02428915f,0.7033151f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 0.7375134f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 0.7375134f);
Get(0xFA26).SetLocalPose(1.388089f,1.285796f,0.857323f,0.5786869f,-0.4763072f,0.3547648f,-0.5589229f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449308f,1.36504f,0.7856929f,-0.710387f,0.009608001f,0.02429612f,0.7033263f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 0.7659419f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 0.7659419f);
Get(0xFA26).SetLocalPose(1.387574f,1.28566f,0.8547043f,0.5789315f,-0.4765752f,0.3550797f,-0.558241f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449281f,1.36493f,0.7856257f,-0.7103755f,0.009618595f,0.02431952f,0.7033369f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 0.7819099f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 0.7819099f);
Get(0xFA26).SetLocalPose(1.38682f,1.284962f,0.8534715f,0.579199f,-0.4766206f,0.3548408f,-0.5580764f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449299f,1.364992f,0.7856985f,-0.7103557f,0.009635879f,0.0243232f,0.7033566f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 0.7927185f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 0.7927185f);
Get(0xFA26).SetLocalPose(1.386721f,1.284963f,0.8523197f,0.5794797f,-0.4764964f,0.3543736f,-0.558188f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449543f,1.365055f,0.7856475f,-0.7103655f,0.009605537f,0.02433488f,0.7033466f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 0.8134567f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 0.8134567f);
Get(0xFA26).SetLocalPose(1.386448f,1.284449f,0.8512049f,0.5799949f,-0.4762021f,0.3536872f,-0.5583394f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449634f,1.365045f,0.7856399f,-0.7103812f,0.009602029f,0.02434428f,0.7033306f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 0.8242047f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 0.8242047f);
Get(0xFA26).SetLocalPose(1.386359f,1.283997f,0.8498915f,0.5808183f,-0.4756561f,0.3529564f,-0.5584113f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449549f,1.364814f,0.785547f,-0.7103683f,0.00963754f,0.02428827f,0.703345f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 0.8469309f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 0.8469309f);
Get(0xFA26).SetLocalPose(1.386293f,1.284002f,0.8462906f,0.5820534f,-0.4745277f,0.352147f,-0.5585963f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449587f,1.364848f,0.7856887f,-0.710376f,0.009643354f,0.02432934f,0.7033357f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 0.8611398f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 0.8611398f);
Get(0xFA26).SetLocalPose(1.386421f,1.284275f,0.844619f,0.5823535f,-0.4740817f,0.3522254f,-0.5586128f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449558f,1.364842f,0.7856526f,-0.7103632f,0.009608745f,0.02434688f,0.7033485f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 0.8770897f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 0.8770897f);
Get(0xFA26).SetLocalPose(1.386181f,1.284249f,0.843423f,0.5824394f,-0.4738634f,0.3524552f,-0.5585635f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44955f,1.364887f,0.7856934f,-0.7103525f,0.009590027f,0.0243393f,0.7033598f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 0.8894944f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 0.8894944f);
Get(0xFA26).SetLocalPose(1.385686f,1.283884f,0.8417059f,0.5824316f,-0.4737207f,0.3530512f,-0.5583162f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449712f,1.364868f,0.7857925f,-0.7103432f,0.009593919f,0.02435927f,0.7033685f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 0.9138799f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 0.9138799f);
Get(0xFA26).SetLocalPose(1.38527f,1.283312f,0.8392203f,0.5821937f,-0.4736891f,0.3538324f,-0.5580965f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44964f,1.365191f,0.7857901f,-0.7103329f,0.009629168f,0.02436004f,0.7033784f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 0.9259949f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 0.9259949f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449699f,1.365319f,0.7855207f,-0.7103466f,0.009601146f,0.02437346f,0.7033644f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 0.9493906f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 0.9493906f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449775f,1.365159f,0.7854059f,-0.7103492f,0.009573313f,0.02439513f,0.7033615f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 0.9604865f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 0.9604865f);
Get(0xFA26).SetLocalPose(1.385134f,1.283227f,0.8384889f,0.5821573f,-0.4736872f,0.3540377f,-0.558006f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449751f,1.365143f,0.7854109f,-0.7103329f,0.009608762f,0.02440654f,0.703377f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 0.9829711f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 0.9829711f);
Get(0xFA26).SetLocalPose(1.385571f,1.281931f,0.8365892f,0.5819876f,-0.4737652f,0.3546047f,-0.5577567f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449817f,1.36525f,0.785538f,-0.7103521f,0.009581574f,0.02439777f,0.7033584f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 0.9956967f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 0.9956967f);
Get(0xFA26).SetLocalPose(1.385347f,1.282451f,0.8348165f,0.5819877f,-0.4739612f,0.3551638f,-0.5572341f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449797f,1.36525f,0.7854823f,-0.7103416f,0.009591515f,0.02440104f,0.7033687f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 1.013677f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 1.013677f);
Get(0xFA26).SetLocalPose(1.384198f,1.282523f,0.8314931f,0.5822005f,-0.4744664f,0.3559201f,-0.556098f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449886f,1.365158f,0.7854148f,-0.7103412f,0.009574169f,0.02441783f,0.7033687f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 1.030859f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 1.030859f);
Get(0xFA26).SetLocalPose(1.384015f,1.281919f,0.829845f,0.5823021f,-0.4746879f,0.3556995f,-0.5559438f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449959f,1.365127f,0.7853644f,-0.7103475f,0.009580947f,0.02443385f,0.7033616f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 1.048259f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 1.048259f);
Get(0xFA26).SetLocalPose(1.383536f,1.282139f,0.825303f,0.5829692f,-0.4744621f,0.3544833f,-0.5562142f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.450117f,1.365088f,0.78543f,-0.7103506f,0.009563001f,0.02442258f,0.7033592f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 1.063837f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 1.063837f);
Get(0xFA26).SetLocalPose(1.382847f,1.2819f,0.8221115f,0.5839776f,-0.4739166f,0.3540134f,-0.5559207f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.45014f,1.365094f,0.7853807f,-0.7103456f,0.009570013f,0.02442853f,0.703364f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 1.079883f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 1.079883f);
Get(0xFA26).SetLocalPose(1.382226f,1.281048f,0.8198352f,0.5842801f,-0.4742613f,0.3546319f,-0.5549137f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.450028f,1.365009f,0.7855287f,-0.7103866f,0.009550662f,0.02440919f,0.7033235f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 1.097276f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 1.097276f);
Get(0xFA26).SetLocalPose(1.382242f,1.279919f,0.8159056f,0.5834678f,-0.4767914f,0.3568335f,-0.5521821f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449987f,1.364981f,0.7856619f,-0.7103739f,0.009564345f,0.02440777f,0.7033362f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 1.113807f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 1.113807f);
Get(0xFA26).SetLocalPose(1.381671f,1.280249f,0.8127661f,0.5830552f,-0.4782747f,0.3571568f,-0.5511252f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.450094f,1.365057f,0.7856085f,-0.7103729f,0.009522907f,0.02439803f,0.7033381f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 1.129518f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 1.129518f);
Get(0xFA26).SetLocalPose(1.381301f,1.280491f,0.8108147f,0.583678f,-0.4783955f,0.3563333f,-0.5508942f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.45006f,1.36502f,0.7857508f,-0.7103625f,0.009547705f,0.02438545f,0.7033486f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 1.147299f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 1.147299f);
Get(0xFA26).SetLocalPose(1.381372f,1.280149f,0.8094847f,0.5853484f,-0.477603f,0.3548817f,-0.5507464f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.450104f,1.364954f,0.7856997f,-0.7103719f,0.009558925f,0.02436855f,0.7033397f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 1.16429f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 1.16429f);
Get(0xFA26).SetLocalPose(1.381196f,1.280092f,0.8076029f,0.5865079f,-0.4769973f,0.3542008f,-0.5504761f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449917f,1.365149f,0.7858156f,-0.7103812f,0.00954574f,0.02437999f,0.70333f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 1.181167f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 1.181167f);
Get(0xFA26).SetLocalPose(1.381619f,1.279151f,0.8061162f,0.5869453f,-0.4767275f,0.3541376f,-0.5502843f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449987f,1.365154f,0.7858757f,-0.7103633f,0.009586682f,0.02437266f,0.7033477f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 1.196892f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 1.196892f);
Get(0xFA26).SetLocalPose(1.381691f,1.278988f,0.8055412f,0.5868913f,-0.476791f,0.354293f,-0.5501868f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449955f,1.365141f,0.7859628f,-0.7103636f,0.009561445f,0.02438011f,0.7033477f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 1.213248f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 1.213248f);
Get(0xFA26).SetLocalPose(1.382125f,1.27834f,0.8039565f,0.5862406f,-0.4769881f,0.3546592f,-0.5504736f);
});
r.Add(delegate{
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 1.229384f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 1.229384f);
Get(0xFA26).SetLocalPose(1.381912f,1.278394f,0.803333f,0.5859653f,-0.4769954f,0.3545365f,-0.5508391f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449964f,1.365136f,0.785851f,-0.7103521f,0.009552474f,0.02437423f,0.7033595f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 1.245372f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 1.245372f);
Get(0xFA26).SetLocalPose(1.382408f,1.277742f,0.8032726f,0.5860325f,-0.4768069f,0.3542722f,-0.5511011f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449822f,1.365147f,0.7858108f,-0.7103727f,0.00955786f,0.02435515f,0.7033393f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 1.261702f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 1.261702f);
Get(0xFA26).SetLocalPose(1.38265f,1.277401f,0.8022667f,0.5864047f,-0.4763018f,0.3542046f,-0.5511854f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449742f,1.365202f,0.7856202f,-0.710364f,0.009546186f,0.02436583f,0.7033479f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 1.278376f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 1.278376f);
Get(0xFA26).SetLocalPose(1.382814f,1.277224f,0.8013882f,0.5866853f,-0.4760274f,0.3544068f,-0.5509938f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449605f,1.365237f,0.7855827f,-0.7103583f,0.009565163f,0.02433195f,0.7033545f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 1.293925f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 1.293925f);
Get(0xFA26).SetLocalPose(1.382746f,1.276967f,0.8006948f,0.5866502f,-0.4759007f,0.3546409f,-0.55099f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449615f,1.365116f,0.7855392f,-0.7103567f,0.009556262f,0.02436249f,0.7033553f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 1.31662f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 1.31662f);
Get(0xFA26).SetLocalPose(1.382721f,1.277765f,0.7995531f,0.5863959f,-0.4757816f,0.3550806f,-0.5510803f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449597f,1.365135f,0.7855127f,-0.7103481f,0.009575212f,0.02435955f,0.7033637f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 1.332578f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 1.332578f);
Get(0xFA26).SetLocalPose(1.382891f,1.277801f,0.7990607f,0.5863035f,-0.47577f,0.3552078f,-0.5511067f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449908f,1.365116f,0.7858123f,-0.7103605f,0.009554065f,0.02437449f,0.703351f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 1.34139f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 1.34139f);
Get(0xFA26).SetLocalPose(1.382842f,1.277614f,0.7980506f,0.5862948f,-0.4757079f,0.3552666f,-0.5511316f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.450025f,1.365033f,0.7858639f,-0.710372f,0.009519358f,0.0244069f,0.7033388f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 1.359724f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 1.359724f);
Get(0xFA26).SetLocalPose(1.383187f,1.277162f,0.7980406f,0.586588f,-0.4755239f,0.3551713f,-0.5510399f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.450041f,1.365027f,0.7858826f,-0.7103711f,0.009548398f,0.02436674f,0.7033407f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 1.376878f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 1.376878f);
Get(0xFA26).SetLocalPose(1.383697f,1.277073f,0.7966916f,0.5870034f,-0.475334f,0.3551316f,-0.5507869f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449947f,1.3652f,0.7859474f,-0.7103708f,0.009589641f,0.02432268f,0.7033418f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 1.394439f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 1.394439f);
Get(0xFA26).SetLocalPose(1.383458f,1.276627f,0.7961942f,0.5872982f,-0.4753203f,0.3553487f,-0.5503443f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449829f,1.365126f,0.7858346f,-0.7103658f,0.009598859f,0.02433825f,0.7033463f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 1.412023f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 1.412023f);
Get(0xFA26).SetLocalPose(1.383975f,1.275713f,0.7957217f,0.5874878f,-0.4754006f,0.3555041f,-0.5499721f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449782f,1.36515f,0.7858225f,-0.7103614f,0.00958126f,0.02433079f,0.7033512f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 1.428193f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 1.428193f);
Get(0xFA26).SetLocalPose(1.384178f,1.275699f,0.7952229f,0.5875835f,-0.4754171f,0.3555161f,-0.5498478f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449538f,1.3653f,0.7856425f,-0.7103612f,0.009618006f,0.02432423f,0.7033512f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 1.444561f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 1.444561f);
Get(0xFA26).SetLocalPose(1.384426f,1.275543f,0.7944211f,0.5877712f,-0.4751848f,0.3554557f,-0.549887f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449525f,1.365196f,0.7857799f,-0.7103785f,0.00961005f,0.02431973f,0.703334f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 1.462699f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 1.462699f);
Get(0xFA26).SetLocalPose(1.384445f,1.274384f,0.7940547f,0.5879692f,-0.4749994f,0.3556282f,-0.549724f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44946f,1.36504f,0.7856789f,-0.7103727f,0.009631266f,0.02430996f,0.7033398f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 1.480505f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 1.480505f);
Get(0xFA26).SetLocalPose(1.384276f,1.273818f,0.7935907f,0.5882071f,-0.4748157f,0.3559617f,-0.5494123f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449493f,1.36498f,0.78577f,-0.7103756f,0.009633826f,0.02432203f,0.7033365f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 1.498402f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 1.498402f);
Get(0xFA26).SetLocalPose(1.384161f,1.273987f,0.7932031f,0.5884815f,-0.4745685f,0.3562081f,-0.5491722f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449615f,1.365015f,0.7857028f,-0.7103615f,0.009593396f,0.02433882f,0.7033507f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 1.514342f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 1.514342f);
Get(0xFA26).SetLocalPose(1.384153f,1.274194f,0.7928361f,0.5886078f,-0.4743972f,0.3561013f,-0.5492541f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449668f,1.365087f,0.7857091f,-0.7103685f,0.009604199f,0.02437542f,0.7033423f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 1.530437f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 1.530437f);
Get(0xFA26).SetLocalPose(1.384013f,1.274281f,0.7921352f,0.5886207f,-0.4742862f,0.3559187f,-0.5494544f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449528f,1.365149f,0.7856598f,-0.7103621f,0.009615034f,0.02436551f,0.703349f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 1.547632f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 1.547632f);
Get(0xFA26).SetLocalPose(1.384615f,1.273765f,0.7919007f,0.5888056f,-0.4739226f,0.3557994f,-0.5496473f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449645f,1.36507f,0.7855794f,-0.7103539f,0.009588832f,0.02438181f,0.703357f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 1.565207f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 1.565207f);
Get(0xFA26).SetLocalPose(1.384926f,1.27336f,0.7918918f,0.5890495f,-0.4736427f,0.3558526f,-0.5495929f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449747f,1.365029f,0.7855296f,-0.7103695f,0.009593609f,0.02437801f,0.7033413f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 1.581765f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 1.581765f);
Get(0xFA26).SetLocalPose(1.385173f,1.273276f,0.7916545f,0.5892063f,-0.4734145f,0.3559566f,-0.5495539f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449829f,1.36497f,0.7854867f,-0.7103717f,0.009626267f,0.02438854f,0.7033382f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 1.598557f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 1.598557f);
Get(0xFA26).SetLocalPose(1.385139f,1.273206f,0.7916546f,0.5893931f,-0.473053f,0.3558821f,-0.5497132f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449783f,1.365093f,0.7855894f,-0.7103887f,0.00962826f,0.02437245f,0.7033216f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 1.61457f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 1.61457f);
Get(0xFA26).SetLocalPose(1.38541f,1.272552f,0.7922897f,0.5894397f,-0.4727984f,0.3555188f,-0.5501172f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449732f,1.365138f,0.7857606f,-0.7103808f,0.009621886f,0.02435368f,0.7033303f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 1.629881f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 1.629881f);
Get(0xFA26).SetLocalPose(1.385576f,1.272342f,0.792073f,0.5892564f,-0.4727627f,0.3552684f,-0.5505059f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449712f,1.365207f,0.7857963f,-0.7103888f,0.009614933f,0.02435707f,0.7033222f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 1.646663f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 1.646663f);
Get(0xFA26).SetLocalPose(1.385822f,1.272513f,0.7917938f,0.5890989f,-0.472762f,0.3552546f,-0.550684f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449693f,1.36509f,0.7859453f,-0.7103984f,0.00959498f,0.02434842f,0.7033131f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 1.664094f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 1.664094f);
Get(0xFA26).SetLocalPose(1.385641f,1.272232f,0.7916716f,0.5890384f,-0.4727378f,0.3553535f,-0.5507056f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449664f,1.36503f,0.7859532f,-0.7103845f,0.009591485f,0.02436353f,0.7033266f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 1.681253f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 1.681253f);
Get(0xFA26).SetLocalPose(1.385453f,1.272138f,0.7917546f,0.5891381f,-0.4726892f,0.3554935f,-0.5505503f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449563f,1.365084f,0.7859482f,-0.7103913f,0.009629362f,0.02435239f,0.7033197f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 1.698718f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 1.698718f);
Get(0xFA26).SetLocalPose(1.385661f,1.272048f,0.7915807f,0.5890638f,-0.4726988f,0.355666f,-0.5505101f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449625f,1.364976f,0.7858853f,-0.7103804f,0.009615248f,0.02433786f,0.7033314f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 1.71518f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 1.71518f);
Get(0xFA26).SetLocalPose(1.385557f,1.272554f,0.7914323f,0.5889743f,-0.4726336f,0.3557347f,-0.5506174f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449648f,1.364892f,0.7858666f,-0.7103816f,0.009601169f,0.02435439f,0.7033299f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 1.731708f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 1.731708f);
Get(0xFA26).SetLocalPose(1.38544f,1.272355f,0.7911597f,0.5888257f,-0.4725488f,0.3557002f,-0.5508715f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449608f,1.364988f,0.7858912f,-0.710394f,0.009602247f,0.02434049f,0.7033176f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 1.747957f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 1.747957f);
Get(0xFA26).SetLocalPose(1.385294f,1.271726f,0.7913188f,0.5887154f,-0.4725551f,0.3558406f,-0.5508932f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449699f,1.364889f,0.7859189f,-0.710399f,0.009578781f,0.02435993f,0.7033123f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 1.763764f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 1.763764f);
Get(0xFA26).SetLocalPose(1.384912f,1.272125f,0.7906464f,0.5883895f,-0.4727601f,0.3563022f,-0.5507671f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449571f,1.365005f,0.7858653f,-0.7103764f,0.009577512f,0.02434567f,0.7033356f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 1.780032f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 1.780032f);
Get(0xFA26).SetLocalPose(1.384694f,1.272424f,0.7906781f,0.5883178f,-0.4726414f,0.3565928f,-0.5507576f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449862f,1.365059f,0.7858903f,-0.7103835f,0.009543207f,0.02436367f,0.7033283f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 1.796297f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 1.796297f);
Get(0xFA26).SetLocalPose(1.383901f,1.273123f,0.7902731f,0.5885383f,-0.4721321f,0.3565898f,-0.5509607f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449974f,1.365125f,0.7860141f,-0.7103928f,0.009562877f,0.02433618f,0.7033195f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 1.81217f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 1.81217f);
Get(0xFA26).SetLocalPose(1.383969f,1.273072f,0.7906185f,0.5887832f,-0.4714472f,0.3565663f,-0.5513007f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449923f,1.365008f,0.7860219f,-0.7104074f,0.009560112f,0.02436059f,0.7033041f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 1.827879f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 1.827879f);
Get(0xFA26).SetLocalPose(1.383616f,1.273425f,0.7905387f,0.588324f,-0.4714863f,0.3573957f,-0.5512204f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44994f,1.365005f,0.7860146f,-0.7104059f,0.009562974f,0.02433877f,0.7033063f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 1.843414f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 1.843414f);
Get(0xFA26).SetLocalPose(1.383736f,1.273217f,0.7907984f,0.5878338f,-0.4717551f,0.3580529f,-0.5510868f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.4499f,1.365007f,0.7859513f,-0.7103804f,0.009572109f,0.02437784f,0.7033305f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 1.866641f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 1.866641f);
Get(0xFA26).SetLocalPose(1.382849f,1.272244f,0.7911204f,0.5871179f,-0.4724136f,0.3591535f,-0.5505695f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449919f,1.364942f,0.7859518f,-0.7103882f,0.009578078f,0.02436574f,0.7033229f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 1.882573f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 1.882573f);
Get(0xFA26).SetLocalPose(1.382918f,1.271864f,0.7910458f,0.587806f,-0.4723471f,0.3587191f,-0.5501754f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449979f,1.364901f,0.7859071f,-0.7103791f,0.009607837f,0.02435667f,0.7033321f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 1.897568f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 1.897568f);
Get(0xFA26).SetLocalPose(1.382657f,1.271474f,0.7908768f,0.588689f,-0.4721594f,0.3582143f,-0.5497211f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449739f,1.364972f,0.7858838f,-0.7104f,0.00959524f,0.02435395f,0.7033113f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 1.914079f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 1.914079f);
Get(0xFA26).SetLocalPose(1.382787f,1.270785f,0.7904977f,0.5894457f,-0.4723654f,0.3581621f,-0.5487664f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449724f,1.365164f,0.7859351f,-0.7104129f,0.009587551f,0.02435802f,0.7032982f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 1.930957f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 1.930957f);
Get(0xFA26).SetLocalPose(1.382985f,1.270272f,0.789537f,0.5896425f,-0.4731061f,0.3586765f,-0.5475798f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449646f,1.365229f,0.7858656f,-0.7103838f,0.009610982f,0.02432688f,0.7033282f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 1.94814f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 1.94814f);
Get(0xFA26).SetLocalPose(1.383044f,1.269992f,0.7893026f,0.5895444f,-0.4736326f,0.358954f,-0.5470482f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449508f,1.365147f,0.7857652f,-0.7103944f,0.009613802f,0.02434837f,0.7033169f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 1.964704f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 1.964704f);
Get(0xFA26).SetLocalPose(1.38296f,1.269172f,0.7887402f,0.5894831f,-0.4741181f,0.3590583f,-0.546625f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44959f,1.365056f,0.7857273f,-0.7103837f,0.009630373f,0.02434845f,0.7033275f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 1.982668f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 1.982668f);
Get(0xFA26).SetLocalPose(1.382197f,1.268972f,0.787212f,0.5904562f,-0.474893f,0.3568133f,-0.5463721f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449653f,1.364893f,0.7857894f,-0.7103785f,0.009619231f,0.02435382f,0.7033327f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 1.999819f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 1.999819f);
Get(0xFA26).SetLocalPose(1.383041f,1.268633f,0.7859235f,0.592657f,-0.4752564f,0.35412f,-0.5454246f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449643f,1.364852f,0.785723f,-0.7103808f,0.009598175f,0.02436088f,0.7033304f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 2.00787f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 2.00787f);
Get(0xFA26).SetLocalPose(1.383241f,1.268512f,0.7854934f,0.5932947f,-0.4756663f,0.3531094f,-0.5450291f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449644f,1.364859f,0.785692f,-0.710381f,0.009621934f,0.02435195f,0.7033302f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 2.026452f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 2.026452f);
Get(0xFA26).SetLocalPose(1.384186f,1.268325f,0.7852148f,0.5943553f,-0.4765337f,0.3515095f,-0.5441495f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449645f,1.365035f,0.7856859f,-0.7103773f,0.009605532f,0.02437382f,0.7033334f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 2.043708f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 2.043708f);
Get(0xFA26).SetLocalPose(1.384023f,1.268258f,0.7854369f,0.5951659f,-0.4770413f,0.350973f,-0.5431641f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449768f,1.364805f,0.7856578f,-0.710375f,0.009592103f,0.02439892f,0.703335f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 2.061398f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 2.061398f);
Get(0xFA26).SetLocalPose(1.384903f,1.267003f,0.7848408f,0.5961675f,-0.4777372f,0.350794f,-0.5415673f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449884f,1.364907f,0.7855518f,-0.7103631f,0.009612605f,0.02439649f,0.7033468f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 2.078747f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 2.078747f);
Get(0xFA26).SetLocalPose(1.385835f,1.266272f,0.7846816f,0.5963764f,-0.4785554f,0.3512739f,-0.5403023f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449893f,1.364944f,0.7856846f,-0.7103725f,0.009614787f,0.02440802f,0.7033368f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 2.095644f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 2.095644f);
Get(0xFA26).SetLocalPose(1.386026f,1.267588f,0.7836713f,0.5962157f,-0.4794068f,0.3514946f,-0.539581f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449889f,1.364975f,0.7856113f,-0.7103757f,0.009610092f,0.02439788f,0.7033341f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 2.113852f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 2.113852f);
Get(0xFA26).SetLocalPose(1.386974f,1.268282f,0.7831917f,0.5960081f,-0.4801376f,0.3505065f,-0.5398032f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449664f,1.365096f,0.7855746f,-0.7103767f,0.009618672f,0.02435709f,0.7033344f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 2.130373f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 2.130373f);
Get(0xFA26).SetLocalPose(1.388007f,1.268901f,0.7830538f,0.5959349f,-0.4805151f,0.3492464f,-0.5403646f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449596f,1.365097f,0.785644f,-0.7103639f,0.009635341f,0.0243759f,0.7033465f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 2.14705f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 2.14705f);
Get(0xFA26).SetLocalPose(1.388511f,1.269814f,0.7831147f,0.5960081f,-0.4806726f,0.3481601f,-0.5408446f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449532f,1.364898f,0.785563f,-0.7103623f,0.009656333f,0.02437223f,0.703348f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 2.164165f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 2.164165f);
Get(0xFA26).SetLocalPose(1.389092f,1.269966f,0.7827029f,0.5959694f,-0.4810897f,0.346631f,-0.541498f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449563f,1.364905f,0.7855607f,-0.7103619f,0.009602346f,0.02439411f,0.7033483f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 2.181437f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 2.181437f);
Get(0xFA26).SetLocalPose(1.389735f,1.270233f,0.7830706f,0.595711f,-0.4822438f,0.3460713f,-0.5411137f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449563f,1.364962f,0.7855275f,-0.7103504f,0.009606142f,0.02439447f,0.7033598f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 2.197958f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 2.197958f);
Get(0xFA26).SetLocalPose(1.390471f,1.26998f,0.7830487f,0.5954754f,-0.4832271f,0.3457743f,-0.5406856f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449622f,1.365057f,0.7856491f,-0.7103822f,0.009595255f,0.02438419f,0.7033282f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 2.21548f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 2.21548f);
Get(0xFA26).SetLocalPose(1.391051f,1.270661f,0.7831703f,0.5955623f,-0.4840974f,0.3449982f,-0.5403069f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449751f,1.365207f,0.7857636f,-0.7103749f,0.009579099f,0.02439466f,0.7033355f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 2.232652f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 2.232652f);
Get(0xFA26).SetLocalPose(1.391573f,1.271661f,0.7834954f,0.5958391f,-0.4846356f,0.3441079f,-0.5400869f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449893f,1.36509f,0.7858059f,-0.7103759f,0.009569497f,0.02440757f,0.7033341f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 2.249656f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 2.249656f);
Get(0xFA26).SetLocalPose(1.391836f,1.271583f,0.7837134f,0.5961139f,-0.4848979f,0.3434128f,-0.5399907f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449901f,1.365157f,0.785892f,-0.7103738f,0.009563181f,0.02442573f,0.7033358f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 2.266512f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 2.266512f);
Get(0xFA26).SetLocalPose(1.392381f,1.271743f,0.7841877f,0.5965298f,-0.485163f,0.3421793f,-0.5400763f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449872f,1.365086f,0.7858316f,-0.7103689f,0.009569211f,0.02440272f,0.7033414f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 2.282402f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 2.282402f);
Get(0xFA26).SetLocalPose(1.392754f,1.2724f,0.7842622f,0.5966882f,-0.4852429f,0.3413545f,-0.5403515f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449916f,1.364999f,0.7856693f,-0.7103675f,0.009565055f,0.02440086f,0.7033429f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 2.299603f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 2.299603f);
Get(0xFA26).SetLocalPose(1.393131f,1.272472f,0.7848969f,0.5968189f,-0.485155f,0.3407108f,-0.5406922f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449839f,1.365037f,0.7856064f,-0.71035f,0.009605368f,0.02438075f,0.7033607f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 2.30821f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 2.30821f);
Get(0xFA26).SetLocalPose(1.393384f,1.27285f,0.785065f,0.5970668f,-0.4847655f,0.3404256f,-0.5409474f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449673f,1.365107f,0.7856067f,-0.7103542f,0.009601485f,0.02437516f,0.7033567f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 2.326171f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 2.326171f);
Get(0xFA26).SetLocalPose(1.393586f,1.272454f,0.7862345f,0.5974457f,-0.4841042f,0.3405773f,-0.5410259f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449712f,1.365166f,0.7855929f,-0.7103621f,0.009588097f,0.02438929f,0.7033484f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 2.342584f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 2.342584f);
Get(0xFA26).SetLocalPose(1.393853f,1.27247f,0.786491f,0.5973312f,-0.4838518f,0.341103f,-0.5410467f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449861f,1.365167f,0.7855759f,-0.7103354f,0.009565843f,0.02442344f,0.7033745f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 2.359197f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 2.359197f);
Get(0xFA26).SetLocalPose(1.394052f,1.272626f,0.7870355f,0.5966625f,-0.4839457f,0.3418702f,-0.5412166f);
});
r.Add(delegate{
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 2.376908f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 2.376908f);
Get(0xFA26).SetLocalPose(1.394221f,1.272836f,0.7863516f,0.5953684f,-0.4844964f,0.3422916f,-0.5418821f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449774f,1.365263f,0.7856418f,-0.7103454f,0.00962191f,0.02437898f,0.7033652f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 2.393574f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 2.393574f);
Get(0xFA26).SetLocalPose(1.393958f,1.273714f,0.7863663f,0.5949491f,-0.4843768f,0.3415774f,-0.5428993f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449758f,1.365301f,0.7855749f,-0.7103658f,0.009629639f,0.02435721f,0.7033452f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 2.416594f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 2.416594f);
Get(0xFA26).SetLocalPose(1.394109f,1.273278f,0.7863717f,0.5958819f,-0.4833748f,0.3406555f,-0.5433483f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449624f,1.365177f,0.7854926f,-0.710387f,0.009666799f,0.02434252f,0.7033238f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 2.432787f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 2.432787f);
Get(0xFA26).SetLocalPose(1.393762f,1.272612f,0.7874655f,0.5967022f,-0.4827461f,0.3406236f,-0.543027f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449563f,1.365291f,0.7856126f,-0.7103886f,0.009631176f,0.02433742f,0.7033229f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 2.448797f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 2.448797f);
Get(0xFA26).SetLocalPose(1.393252f,1.271559f,0.7883502f,0.5970724f,-0.4824573f,0.3408286f,-0.542748f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44953f,1.365116f,0.7857005f,-0.7103863f,0.009604181f,0.02434054f,0.7033255f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 2.457662f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 2.457662f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449441f,1.364985f,0.785659f,-0.710338f,0.00955511f,0.02434494f,0.7033747f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 2.476568f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 2.476568f);
Get(0xFA26).SetLocalPose(1.392909f,1.270977f,0.7888159f,0.5971369f,-0.4825763f,0.3420016f,-0.5418326f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449375f,1.36487f,0.7856414f,-0.7102344f,0.009553648f,0.02443074f,0.7034764f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 2.493533f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 2.493533f);
Get(0xFA26).SetLocalPose(1.392347f,1.269878f,0.7892824f,0.5960624f,-0.4838454f,0.3449173f,-0.5400327f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449392f,1.364838f,0.7857478f,-0.7101596f,0.009465121f,0.02444243f,0.7035527f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 2.511657f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 2.511657f);
Get(0xFA26).SetLocalPose(1.391469f,1.269434f,0.7892585f,0.5954388f,-0.4846673f,0.3471064f,-0.5385792f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449302f,1.365048f,0.785801f,-0.7100449f,0.009508064f,0.02450921f,0.7036656f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 2.52895f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 2.52895f);
Get(0xFA26).SetLocalPose(1.391054f,1.270146f,0.7877201f,0.5955959f,-0.4847638f,0.3476019f,-0.5379986f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449277f,1.365162f,0.785768f,-0.7100023f,0.009509355f,0.0244322f,0.7037112f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 2.546624f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 2.546624f);
Get(0xFA26).SetLocalPose(1.39037f,1.269911f,0.7870304f,0.59636f,-0.4846254f,0.3467676f,-0.5378152f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449094f,1.365122f,0.7854446f,-0.7099265f,0.00961706f,0.0244225f,0.7037865f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 2.563463f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 2.563463f);
Get(0xFA26).SetLocalPose(1.389468f,1.270611f,0.7866117f,0.5966842f,-0.4846916f,0.3458508f,-0.5379863f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449072f,1.364867f,0.7851681f,-0.7099351f,0.009679521f,0.02436283f,0.7037791f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 2.579502f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 2.579502f);
Get(0xFA26).SetLocalPose(1.388358f,1.27113f,0.7866665f,0.5967363f,-0.4849803f,0.3450519f,-0.5381813f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449189f,1.364747f,0.7852028f,-0.7100229f,0.009737252f,0.0242649f,0.7036931f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 2.59594f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 2.59594f);
Get(0xFA26).SetLocalPose(1.387319f,1.271123f,0.7865154f,0.5966122f,-0.4854042f,0.345235f,-0.5378193f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449483f,1.364715f,0.7852251f,-0.7101839f,0.009809517f,0.02420165f,0.7035317f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 2.611364f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 2.611364f);
Get(0xFA26).SetLocalPose(1.386456f,1.27015f,0.7864488f,0.5965651f,-0.4858617f,0.3456449f,-0.5371948f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449507f,1.364703f,0.7850922f,-0.710299f,0.009868475f,0.02413236f,0.7034171f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 2.62753f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 2.62753f);
Get(0xFA26).SetLocalPose(1.385758f,1.270017f,0.7867556f,0.5965965f,-0.4861717f,0.3458465f,-0.5367493f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449579f,1.364829f,0.7850764f,-0.7103994f,0.009851689f,0.02415358f,0.7033152f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 2.643332f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 2.643332f);
Get(0xFA26).SetLocalPose(1.385053f,1.270473f,0.7863142f,0.5965677f,-0.4864285f,0.345937f,-0.5364905f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449444f,1.365084f,0.7848201f,-0.7104705f,0.009905155f,0.02420961f,0.7032408f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 2.660337f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 2.660337f);
Get(0xFA26).SetLocalPose(1.385079f,1.270251f,0.7861356f,0.5965638f,-0.4865907f,0.3459035f,-0.5363692f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44945f,1.365256f,0.784679f,-0.7104667f,0.009860763f,0.02419475f,0.7032457f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 2.678092f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 2.678092f);
Get(0xFA26).SetLocalPose(1.383412f,1.270908f,0.7858392f,0.59646f,-0.4872886f,0.3459217f,-0.535839f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449427f,1.365451f,0.7845488f,-0.7103784f,0.009802066f,0.02432061f,0.7033314f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 2.695348f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 2.695348f);
Get(0xFA26).SetLocalPose(1.382936f,1.270769f,0.7860484f,0.5964633f,-0.4874849f,0.3459741f,-0.5356231f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449358f,1.365338f,0.7846762f,-0.7103013f,0.009737417f,0.02430996f,0.7034104f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 2.713442f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 2.713442f);
Get(0xFA26).SetLocalPose(1.382956f,1.270319f,0.7862689f,0.5966145f,-0.4874035f,0.3459606f,-0.5355373f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449325f,1.365186f,0.7850958f,-0.7102154f,0.009737045f,0.02431542f,0.7034971f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 2.730845f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 2.730845f);
Get(0xFA26).SetLocalPose(1.382595f,1.270642f,0.7858673f,0.5967665f,-0.4871964f,0.3457179f,-0.5357131f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449355f,1.365209f,0.7854246f,-0.7101147f,0.009748296f,0.02435067f,0.7035974f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 2.747699f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 2.747699f);
Get(0xFA26).SetLocalPose(1.382466f,1.271201f,0.7856331f,0.5966282f,-0.4872023f,0.3457554f,-0.5358378f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449429f,1.365172f,0.7855874f,-0.7101215f,0.009710013f,0.02433439f,0.7035916f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 2.764904f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 2.764904f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44941f,1.365029f,0.7856882f,-0.7100766f,0.009736165f,0.02429877f,0.7036378f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 2.781708f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 2.781708f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449711f,1.364603f,0.7863984f,-0.71014f,0.009801128f,0.02422453f,0.7035754f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 2.798518f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 2.798518f);
Get(0xFA26).SetLocalPose(1.382329f,1.272855f,0.7853882f,0.5960887f,-0.48711f,0.3458104f,-0.5364861f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449517f,1.364638f,0.7863506f,-0.7102373f,0.009884302f,0.02418324f,0.7034775f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 2.815207f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 2.815207f);
Get(0xFA26).SetLocalPose(1.382298f,1.272299f,0.7860553f,0.5960417f,-0.4865948f,0.3453234f,-0.5373189f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449601f,1.36443f,0.7864548f,-0.7103197f,0.009937061f,0.02414224f,0.7033949f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 2.831486f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 2.831486f);
Get(0xFA26).SetLocalPose(1.381814f,1.272456f,0.786586f,0.5959382f,-0.4864071f,0.3454175f,-0.5375431f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449754f,1.364505f,0.7862194f,-0.7104387f,0.009960857f,0.0240651f,0.7032771f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 2.848392f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 2.848392f);
Get(0xFA26).SetLocalPose(1.381713f,1.27271f,0.7870836f,0.5955366f,-0.486495f,0.3457092f,-0.537721f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449825f,1.364543f,0.7860039f,-0.7105379f,0.01003664f,0.02406039f,0.7031759f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 2.865641f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 2.865641f);
Get(0xFA26).SetLocalPose(1.381614f,1.27291f,0.7870291f,0.5951588f,-0.4864761f,0.3459015f,-0.5380328f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449772f,1.364941f,0.7855097f,-0.7105731f,0.01005f,0.02402336f,0.7031415f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 2.88298f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 2.88298f);
Get(0xFA26).SetLocalPose(1.381707f,1.273026f,0.7871874f,0.5949143f,-0.4863418f,0.3460101f,-0.5383546f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449817f,1.364867f,0.7851974f,-0.7105821f,0.01004881f,0.0240623f,0.7031311f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 2.892138f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 2.892138f);
Get(0xFA26).SetLocalPose(1.381945f,1.27413f,0.7870392f,0.5946057f,-0.4862451f,0.346258f,-0.5386235f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449779f,1.364942f,0.7850644f,-0.710521f,0.01004481f,0.02410568f,0.7031913f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 2.916573f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 2.916573f);
Get(0xFA26).SetLocalPose(1.382788f,1.27442f,0.7878811f,0.5942334f,-0.4859249f,0.3467391f,-0.5390136f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449683f,1.364956f,0.7849947f,-0.7104919f,0.01003313f,0.02409702f,0.7032212f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 2.924707f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 2.924707f);
Get(0xFA26).SetLocalPose(1.383095f,1.274571f,0.7880893f,0.5940899f,-0.4858648f,0.3469257f,-0.5391059f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449672f,1.365f,0.7850104f,-0.7103854f,0.01001569f,0.02413868f,0.7033277f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 2.943243f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 2.943243f);
Get(0xFA26).SetLocalPose(1.383511f,1.274723f,0.7882134f,0.5937839f,-0.4858084f,0.3471803f,-0.53933f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449308f,1.365036f,0.785166f,-0.710264f,0.009989138f,0.02415834f,0.7034499f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 2.960985f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 2.960985f);
Get(0xFA26).SetLocalPose(1.384111f,1.274368f,0.7883051f,0.5932064f,-0.4857373f,0.3476735f,-0.5397116f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449322f,1.364858f,0.78537f,-0.7101604f,0.009979006f,0.02418859f,0.7035536f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 2.976269f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 2.976269f);
Get(0xFA26).SetLocalPose(1.384446f,1.274385f,0.7882221f,0.5929511f,-0.4856199f,0.3479538f,-0.5399171f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449266f,1.364754f,0.7858973f,-0.7100881f,0.009933359f,0.02427737f,0.7036241f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 2.999228f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 2.999228f);
Get(0xFA26).SetLocalPose(1.384496f,1.274751f,0.7878326f,0.5927131f,-0.4851941f,0.3481661f,-0.5404241f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449189f,1.364515f,0.7860967f,-0.7100946f,0.009941983f,0.02425964f,0.703618f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 3.006773f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 3.006773f);
Get(0xFA26).SetLocalPose(1.384685f,1.274763f,0.7878479f,0.5927334f,-0.4849836f,0.3481928f,-0.5405735f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449058f,1.364401f,0.7862378f,-0.7101458f,0.009985412f,0.02424743f,0.7035663f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 3.026389f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 3.026389f);
Get(0xFA26).SetLocalPose(1.385108f,1.275719f,0.7876554f,0.5924375f,-0.4848849f,0.3485861f,-0.5407331f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449147f,1.364595f,0.786033f,-0.7102684f,0.01005863f,0.02422222f,0.7034423f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 3.046493f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 3.046493f);
Get(0xFA26).SetLocalPose(1.385558f,1.275268f,0.7880223f,0.5920085f,-0.4848648f,0.3490179f,-0.5409424f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449117f,1.364549f,0.7857499f,-0.7103991f,0.01015516f,0.02413512f,0.7033119f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 3.063759f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 3.063759f);
Get(0xFA26).SetLocalPose(1.385686f,1.27561f,0.7878882f,0.5917205f,-0.4848194f,0.3493811f,-0.5410637f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449564f,1.364325f,0.7856155f,-0.7104803f,0.01032183f,0.02400202f,0.703232f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 3.080404f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 3.080404f);
Get(0xFA26).SetLocalPose(1.385879f,1.275629f,0.7879019f,0.591616f,-0.4847446f,0.3495803f,-0.5411164f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449725f,1.364355f,0.785309f,-0.7104908f,0.01045576f,0.02388924f,0.7032233f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 3.09746f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 3.09746f);
Get(0xFA26).SetLocalPose(1.385997f,1.275385f,0.7877467f,0.5915243f,-0.4846885f,0.3497511f,-0.5411565f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449952f,1.364515f,0.785148f,-0.7104196f,0.01057006f,0.02377975f,0.7032971f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 3.114784f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 3.114784f);
Get(0xFA26).SetLocalPose(1.386655f,1.274821f,0.7879267f,0.591411f,-0.4842786f,0.350365f,-0.5412502f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449964f,1.364268f,0.7851774f,-0.7103236f,0.0107534f,0.02367804f,0.7033948f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 3.132434f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 3.132434f);
Get(0xFA26).SetLocalPose(1.387262f,1.274986f,0.787929f,0.59127f,-0.4839587f,0.3510379f,-0.5412543f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.450054f,1.364274f,0.7852928f,-0.7102098f,0.01098635f,0.02373768f,0.703504f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 3.149836f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 3.149836f);
Get(0xFA26).SetLocalPose(1.387799f,1.274655f,0.7882028f,0.5909351f,-0.484072f,0.3515715f,-0.5411723f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.450091f,1.363973f,0.7851344f,-0.7101552f,0.01107592f,0.02382995f,0.7035546f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 3.158348f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 3.158348f);
Get(0xFA26).SetLocalPose(1.388036f,1.274069f,0.7883639f,0.5908216f,-0.4841079f,0.3517853f,-0.5411254f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449963f,1.363924f,0.7850729f,-0.7100908f,0.0111592f,0.02385222f,0.7036176f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 3.176013f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 3.176013f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449821f,1.363771f,0.7850288f,-0.7100059f,0.01112172f,0.02401804f,0.7036982f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 3.19302f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 3.19302f);
Get(0xFA26).SetLocalPose(1.388943f,1.273519f,0.7886436f,0.5906221f,-0.4841358f,0.3524455f,-0.5408885f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449709f,1.363782f,0.784856f,-0.709981f,0.01098135f,0.024165f,0.7037206f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 3.210065f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 3.210065f);
Get(0xFA26).SetLocalPose(1.389678f,1.272245f,0.7892436f,0.5907108f,-0.4839684f,0.3530726f,-0.5405322f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449226f,1.364109f,0.7846161f,-0.7100113f,0.01072466f,0.02429366f,0.7036895f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 3.227728f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 3.227728f);
Get(0xFA26).SetLocalPose(1.390169f,1.271226f,0.7890466f,0.5901268f,-0.4843441f,0.354122f,-0.5401471f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449081f,1.363988f,0.7844001f,-0.7101015f,0.01044072f,0.02444245f,0.7035975f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 3.245475f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 3.245475f);
Get(0xFA26).SetLocalPose(1.390294f,1.270724f,0.7889799f,0.5888407f,-0.4852498f,0.3555578f,-0.5397944f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448815f,1.364325f,0.784559f,-0.7102511f,0.01018498f,0.02477928f,0.7034385f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 3.262859f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 3.262859f);
Get(0xFA26).SetLocalPose(1.389736f,1.270639f,0.788434f,0.5878727f,-0.4859228f,0.3566101f,-0.5395498f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448734f,1.364645f,0.7847282f,-0.7104034f,0.009925957f,0.02491857f,0.7032834f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 3.280066f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 3.280066f);
Get(0xFA26).SetLocalPose(1.390071f,1.270684f,0.7877709f,0.5873281f,-0.4861476f,0.3571208f,-0.5396026f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.4482f,1.365149f,0.7846111f,-0.7105283f,0.00969085f,0.0251186f,0.7031534f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 3.297295f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 3.297295f);
Get(0xFA26).SetLocalPose(1.390281f,1.271027f,0.7871742f,0.5874426f,-0.4858395f,0.3569152f,-0.5398914f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.447974f,1.365347f,0.7843322f,-0.7106147f,0.009487367f,0.02527933f,0.7030632f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 3.314413f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 3.314413f);
Get(0xFA26).SetLocalPose(1.390486f,1.270723f,0.7866573f,0.5876507f,-0.4855318f,0.3564861f,-0.5402251f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.447695f,1.365236f,0.7839444f,-0.7106904f,0.009413849f,0.02543357f,0.7029821f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 3.332295f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 3.332295f);
Get(0xFA26).SetLocalPose(1.390587f,1.271278f,0.7861499f,0.5874811f,-0.4855452f,0.3564091f,-0.5404482f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44755f,1.365127f,0.7838286f,-0.710721f,0.009402325f,0.02544049f,0.702951f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 3.342202f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 3.342202f);
Get(0xFA26).SetLocalPose(1.390676f,1.271865f,0.7857383f,0.5872972f,-0.4856204f,0.3564953f,-0.5405238f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.447566f,1.364923f,0.7838063f,-0.7108121f,0.009414528f,0.02533411f,0.7028626f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 3.364f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 3.364f);
Get(0xFA26).SetLocalPose(1.390983f,1.272358f,0.7851501f,0.5869523f,-0.4856959f,0.356816f,-0.540619f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.447625f,1.364933f,0.7837941f,-0.7108319f,0.00946421f,0.02530673f,0.7028428f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 3.373554f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 3.373554f);
Get(0xFA26).SetLocalPose(1.391286f,1.272398f,0.7854991f,0.5868767f,-0.4856521f,0.3568846f,-0.5406951f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.447771f,1.364826f,0.7837966f,-0.7108525f,0.009687163f,0.02514626f,0.7028248f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 3.395029f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 3.395029f);
Get(0xFA26).SetLocalPose(1.391552f,1.273661f,0.7856765f,0.5868367f,-0.485368f,0.356962f,-0.5409424f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448062f,1.364902f,0.7839544f,-0.7108549f,0.009892087f,0.0250161f,0.7028241f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 3.414452f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 3.414452f);
Get(0xFA26).SetLocalPose(1.391962f,1.273871f,0.7850865f,0.5867163f,-0.4852288f,0.356916f,-0.5412282f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44823f,1.364989f,0.7838781f,-0.710869f,0.00993001f,0.02489437f,0.7028136f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 3.431957f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 3.431957f);
Get(0xFA26).SetLocalPose(1.392019f,1.274088f,0.7848068f,0.5866377f,-0.4851881f,0.3568471f,-0.5413953f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44839f,1.36493f,0.7836934f,-0.71088f,0.009941615f,0.02483575f,0.7028044f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 3.44108f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 3.44108f);
Get(0xFA26).SetLocalPose(1.391997f,1.274195f,0.7845974f,0.5866055f,-0.485083f,0.3566983f,-0.5416224f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44839f,1.364907f,0.7836617f,-0.710921f,0.009908706f,0.02486642f,0.7027623f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 3.456748f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 3.456748f);
Get(0xFA26).SetLocalPose(1.392217f,1.274484f,0.785113f,0.5868964f,-0.4847699f,0.356363f,-0.5418083f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448586f,1.365263f,0.7835786f,-0.7109633f,0.009710965f,0.02495272f,0.7027192f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 3.47888f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 3.47888f);
Get(0xFA26).SetLocalPose(1.392331f,1.274638f,0.7849755f,0.5870286f,-0.4845747f,0.3562227f,-0.5419319f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448594f,1.365314f,0.7836547f,-0.7109619f,0.009615248f,0.02505431f,0.7027184f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 3.494497f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 3.494497f);
Get(0xFA26).SetLocalPose(1.392002f,1.274057f,0.7852602f,0.587066f,-0.4843975f,0.3562052f,-0.5420613f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448081f,1.36502f,0.7836705f,-0.7109466f,0.009411928f,0.02520657f,0.7027311f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 3.511589f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 3.511589f);
Get(0xFA26).SetLocalPose(1.391625f,1.273657f,0.7858041f,0.5867079f,-0.4847138f,0.3567391f,-0.5418152f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.447765f,1.364871f,0.7837649f,-0.7108353f,0.009409244f,0.02538159f,0.7028375f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 3.528467f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 3.528467f);
Get(0xFA26).SetLocalPose(1.39191f,1.273135f,0.7854522f,0.5864087f,-0.4849984f,0.3571713f,-0.5415996f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.447399f,1.36466f,0.7836168f,-0.710659f,0.009526623f,0.02548803f,0.7030103f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 3.545306f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 3.545306f);
Get(0xFA26).SetLocalPose(1.391885f,1.272968f,0.7854575f,0.5862193f,-0.485116f,0.3574684f,-0.5415033f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.447407f,1.36445f,0.7835516f,-0.7105352f,0.009463162f,0.02526808f,0.7031441f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 3.562245f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 3.562245f);
Get(0xFA26).SetLocalPose(1.391825f,1.272876f,0.7854155f,0.5861514f,-0.4851315f,0.3576828f,-0.5414213f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.447432f,1.364359f,0.7834275f,-0.7104493f,0.009551513f,0.02513972f,0.7032344f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 3.577893f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 3.577893f);
Get(0xFA26).SetLocalPose(1.391659f,1.273427f,0.7851913f,0.5861682f,-0.4851055f,0.3578581f,-0.5413106f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.447815f,1.364431f,0.7832255f,-0.7104102f,0.009668979f,0.02508052f,0.7032745f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 3.594927f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 3.594927f);
Get(0xFA26).SetLocalPose(1.391683f,1.273527f,0.7847117f,0.5862338f,-0.4850037f,0.3579463f,-0.5412723f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.447958f,1.364717f,0.7830197f,-0.7104712f,0.009624327f,0.02488078f,0.7032205f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 3.613101f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 3.613101f);
Get(0xFA26).SetLocalPose(1.39219f,1.272606f,0.785216f,0.586258f,-0.4849097f,0.3583024f,-0.5410949f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.447968f,1.364779f,0.7828252f,-0.7105801f,0.009608988f,0.0248291f,0.7031125f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 3.630376f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 3.630376f);
Get(0xFA26).SetLocalPose(1.392132f,1.27213f,0.7854791f,0.5860729f,-0.4850052f,0.3588211f,-0.540866f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448314f,1.364974f,0.7829594f,-0.7107163f,0.009626687f,0.02486751f,0.7029732f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 3.646762f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 3.646762f);
Get(0xFA26).SetLocalPose(1.392448f,1.271457f,0.785815f,0.5859107f,-0.4850838f,0.3591511f,-0.5407521f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448161f,1.365113f,0.7828385f,-0.7108119f,0.009605168f,0.0249319f,0.7028747f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 3.664317f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 3.664317f);
Get(0xFA26).SetLocalPose(1.392447f,1.270736f,0.7859788f,0.5858281f,-0.4850722f,0.3594334f,-0.5406645f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44835f,1.365245f,0.7831099f,-0.7108837f,0.009446166f,0.02475127f,0.7028105f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 3.681669f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 3.681669f);
Get(0xFA26).SetLocalPose(1.39295f,1.270391f,0.7861419f,0.5859487f,-0.4848897f,0.3595685f,-0.5406076f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448358f,1.365252f,0.7831386f,-0.7109134f,0.00920905f,0.02459665f,0.7027891f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 3.69872f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 3.69872f);
Get(0xFA26).SetLocalPose(1.39342f,1.270391f,0.7861111f,0.586022f,-0.4848285f,0.3596185f,-0.5405499f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448826f,1.365017f,0.7829939f,-0.7109189f,0.00878901f,0.02433361f,0.7027979f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 3.716555f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 3.716555f);
Get(0xFA26).SetLocalPose(1.393481f,1.270141f,0.7861927f,0.5860083f,-0.4848199f,0.3597525f,-0.5404831f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448913f,1.365121f,0.7830226f,-0.7109336f,0.00861406f,0.02438094f,0.7027836f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 3.725049f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 3.725049f);
Get(0xFA26).SetLocalPose(1.393338f,1.270679f,0.7858206f,0.5859175f,-0.4848449f,0.3599313f,-0.5404402f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448905f,1.365068f,0.783036f,-0.7109017f,0.00865298f,0.0245578f,0.7028094f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 3.743997f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 3.743997f);
Get(0xFA26).SetLocalPose(1.393484f,1.270865f,0.7851384f,0.585746f,-0.4849043f,0.3602009f,-0.5403931f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448507f,1.36527f,0.7831007f,-0.7108792f,0.008814814f,0.02476445f,0.7028227f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 3.761837f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 3.761837f);
Get(0xFA26).SetLocalPose(1.393424f,1.271528f,0.7839979f,0.5854231f,-0.4849537f,0.3604194f,-0.5405532f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44806f,1.365365f,0.7832764f,-0.7108572f,0.008605016f,0.02457459f,0.7028543f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 3.778939f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 3.778939f);
Get(0xFA26).SetLocalPose(1.393615f,1.271839f,0.7837576f,0.5855458f,-0.4847519f,0.3604383f,-0.5405886f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448181f,1.365402f,0.7834408f,-0.7108314f,0.008480647f,0.02452775f,0.7028835f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 3.795504f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 3.795504f);
Get(0xFA26).SetLocalPose(1.393469f,1.272165f,0.7834972f,0.5855142f,-0.4847444f,0.3605421f,-0.5405602f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.447916f,1.365708f,0.7834622f,-0.7107917f,0.008316902f,0.02468334f,0.7029202f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 3.812704f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 3.812704f);
Get(0xFA26).SetLocalPose(1.393137f,1.272186f,0.783334f,0.5854322f,-0.4848156f,0.3606726f,-0.5404981f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.447483f,1.365544f,0.7833374f,-0.7107755f,0.008115434f,0.02473214f,0.7029372f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 3.828748f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 3.828748f);
Get(0xFA26).SetLocalPose(1.393303f,1.271686f,0.7833508f,0.5852957f,-0.4849221f,0.3606803f,-0.5405453f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44693f,1.365566f,0.7833359f,-0.7107459f,0.007885231f,0.0247703f,0.7029685f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 3.84516f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 3.84516f);
Get(0xFA26).SetLocalPose(1.392993f,1.271797f,0.783392f,0.5851318f,-0.485057f,0.3607338f,-0.5405661f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.446764f,1.365038f,0.7833985f,-0.7106779f,0.007777309f,0.02489449f,0.703034f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 3.862976f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 3.862976f);
Get(0xFA26).SetLocalPose(1.392142f,1.272066f,0.7825368f,0.5851145f,-0.4850394f,0.3604553f,-0.5407863f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.446872f,1.365135f,0.7837105f,-0.7105464f,0.007910607f,0.02494431f,0.7031636f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 3.880507f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 3.880507f);
Get(0xFA26).SetLocalPose(1.391728f,1.271431f,0.7826543f,0.5853223f,-0.484834f,0.3602725f,-0.5408674f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.447037f,1.365411f,0.7839192f,-0.710425f,0.008268961f,0.02487755f,0.7032846f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 3.896418f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 3.896418f);
Get(0xFA26).SetLocalPose(1.391467f,1.271142f,0.7824145f,0.5853431f,-0.4848975f,0.3604219f,-0.5406884f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.447299f,1.365105f,0.7841772f,-0.7103009f,0.00844164f,0.02452152f,0.7034204f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 3.911991f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 3.911991f);
Get(0xFA26).SetLocalPose(1.391791f,1.270868f,0.7823484f,0.5851798f,-0.4851529f,0.3606907f,-0.5404568f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44792f,1.365318f,0.7839987f,-0.710234f,0.008755825f,0.02425525f,0.7034932f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 3.92712f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 3.92712f);
Get(0xFA26).SetLocalPose(1.391711f,1.270749f,0.7823187f,0.5850822f,-0.4852648f,0.360814f,-0.5403796f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448502f,1.36496f,0.7841209f,-0.7101761f,0.009198289f,0.02395156f,0.7035565f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 3.942675f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 3.942675f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449588f,1.364686f,0.7839739f,-0.7100901f,0.009718955f,0.02325148f,0.7036598f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 3.965608f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 3.965608f);
Get(0xFA26).SetLocalPose(1.391485f,1.271431f,0.7821271f,0.5850064f,-0.4854028f,0.3608053f,-0.5403436f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449849f,1.364511f,0.7839969f,-0.7100483f,0.01011258f,0.02301834f,0.703704f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 3.982194f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 3.982194f);
Get(0xFA26).SetLocalPose(1.39131f,1.271553f,0.7825769f,0.5851137f,-0.4854439f,0.3607424f,-0.5402324f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449839f,1.364196f,0.7840969f,-0.7100281f,0.01020351f,0.02281725f,0.7037297f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 3.998956f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 3.998956f);
Get(0xFA26).SetLocalPose(1.391063f,1.271538f,0.7825872f,0.5851583f,-0.4855759f,0.3609449f,-0.5399302f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449364f,1.364225f,0.7841114f,-0.709973f,0.0102511f,0.02284564f,0.7037837f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 4.015925f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 4.015925f);
Get(0xFA26).SetLocalPose(1.391263f,1.271572f,0.7824617f,0.5852799f,-0.4855899f,0.3609033f,-0.5398135f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44882f,1.364093f,0.7841796f,-0.7099618f,0.01008228f,0.02305325f,0.7037907f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 4.033293f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 4.033293f);
Get(0xFA26).SetLocalPose(1.391382f,1.271446f,0.7822736f,0.5852014f,-0.4856972f,0.3609313f,-0.5397835f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448334f,1.364174f,0.7840534f,-0.7099584f,0.009887439f,0.02315415f,0.7037935f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 4.041916f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 4.041916f);
Get(0xFA26).SetLocalPose(1.391393f,1.271449f,0.7822677f,0.5852113f,-0.4857015f,0.3609517f,-0.5397551f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.447837f,1.363988f,0.7840718f,-0.7099816f,0.009549075f,0.0235558f,0.7037613f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 4.060262f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 4.060262f);
Get(0xFA26).SetLocalPose(1.391191f,1.271564f,0.7819089f,0.5851238f,-0.485831f,0.3611512f,-0.5395999f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.447753f,1.364165f,0.7841238f,-0.7100607f,0.009186394f,0.02387038f,0.7036759f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 4.076911f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 4.076911f);
Get(0xFA26).SetLocalPose(1.391195f,1.271556f,0.7818445f,0.5851305f,-0.4858179f,0.361159f,-0.5395994f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.447313f,1.364183f,0.7842683f,-0.7102053f,0.00876879f,0.02425355f,0.7035221f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 4.0994f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 4.0994f);
Get(0xFA26).SetLocalPose(1.391154f,1.271633f,0.7817893f,0.5852256f,-0.4856975f,0.3610118f,-0.5397031f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.447251f,1.365009f,0.7841691f,-0.7103267f,0.008592864f,0.02444489f,0.7033949f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 4.115222f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 4.115222f);
Get(0xFA26).SetLocalPose(1.390731f,1.27168f,0.7818272f,0.5852495f,-0.4856539f,0.3609335f,-0.5397688f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.446969f,1.364954f,0.7838316f,-0.7104629f,0.008473996f,0.02448279f,0.7032576f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 4.130977f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 4.130977f);
Get(0xFA26).SetLocalPose(1.390576f,1.271358f,0.7820289f,0.5850224f,-0.4858243f,0.3609602f,-0.5398438f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.446827f,1.365064f,0.7834428f,-0.7106184f,0.008562989f,0.0244801f,0.7030997f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 4.148096f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 4.148096f);
Get(0xFA26).SetLocalPose(1.390551f,1.271307f,0.7822527f,0.5849094f,-0.4859837f,0.3611948f,-0.5396658f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44684f,1.365171f,0.7831979f,-0.7107254f,0.008673984f,0.0243208f,0.7029955f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 4.165032f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 4.165032f);
Get(0xFA26).SetLocalPose(1.390826f,1.271469f,0.7825483f,0.5848696f,-0.4860942f,0.3613407f,-0.5395119f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.446897f,1.365323f,0.7829933f,-0.7107381f,0.008895522f,0.0241387f,0.7029863f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 4.181931f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 4.181931f);
Get(0xFA26).SetLocalPose(1.390848f,1.271481f,0.7825718f,0.5849876f,-0.4859925f,0.3612175f,-0.5395579f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.447883f,1.365129f,0.7831701f,-0.710688f,0.009088495f,0.02399643f,0.7030393f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 4.197687f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 4.197687f);
Get(0xFA26).SetLocalPose(1.390693f,1.271683f,0.7817641f,0.5851298f,-0.4858402f,0.3610416f,-0.5396587f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448534f,1.36496f,0.7835884f,-0.7105972f,0.009241083f,0.02380556f,0.7031356f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 4.213657f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 4.213657f);
Get(0xFA26).SetLocalPose(1.39071f,1.271702f,0.7817039f,0.5852131f,-0.485765f,0.36093f,-0.5397107f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449142f,1.364964f,0.7837766f,-0.7104366f,0.009418219f,0.0236525f,0.7033006f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 4.2291f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 4.2291f);
Get(0xFA26).SetLocalPose(1.390553f,1.271206f,0.7819273f,0.5852474f,-0.4857223f,0.3608793f,-0.5397457f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449468f,1.365286f,0.7837889f,-0.7102848f,0.00950997f,0.02357309f,0.7034554f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 4.244694f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 4.244694f);
Get(0xFA26).SetLocalPose(1.390705f,1.270876f,0.7820381f,0.5851443f,-0.4858093f,0.3609329f,-0.5397434f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449653f,1.365054f,0.7842478f,-0.7100654f,0.009557514f,0.02345076f,0.7036803f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 4.261436f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 4.261436f);
Get(0xFA26).SetLocalPose(1.390184f,1.270957f,0.7818682f,0.5850357f,-0.486043f,0.361231f,-0.5394512f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449707f,1.364933f,0.7845882f,-0.7098929f,0.00957617f,0.02342364f,0.7038549f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 4.278372f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 4.278372f);
Get(0xFA26).SetLocalPose(1.390143f,1.270888f,0.7818691f,0.5850798f,-0.4860538f,0.3612142f,-0.539405f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449609f,1.364693f,0.78514f,-0.7097706f,0.009515704f,0.02342611f,0.7039791f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 4.294894f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 4.294894f);
Get(0xFA26).SetLocalPose(1.390092f,1.270724f,0.7820657f,0.5851767f,-0.4860749f,0.3611784f,-0.5393047f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449357f,1.364553f,0.7851982f,-0.709727f,0.009447435f,0.02347354f,0.7040222f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 4.311574f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 4.311574f);
Get(0xFA26).SetLocalPose(1.389933f,1.270671f,0.7822533f,0.58517f,-0.4861729f,0.3611422f,-0.5392479f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448945f,1.364499f,0.7851551f,-0.7097555f,0.009347786f,0.02360503f,0.7039905f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 4.328922f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 4.328922f);
Get(0xFA26).SetLocalPose(1.38982f,1.27075f,0.7820948f,0.5851367f,-0.4862246f,0.3611236f,-0.53925f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448903f,1.364509f,0.785069f,-0.7098717f,0.009184525f,0.02369092f,0.7038726f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 4.34552f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 4.34552f);
Get(0xFA26).SetLocalPose(1.389609f,1.270668f,0.7818103f,0.5852668f,-0.4860696f,0.3610976f,-0.5392659f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448733f,1.364459f,0.7847903f,-0.7100762f,0.009100734f,0.02385727f,0.7036618f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 4.363088f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 4.363088f);
Get(0xFA26).SetLocalPose(1.389671f,1.270286f,0.7820865f,0.5854607f,-0.4859603f,0.3611232f,-0.5391368f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448647f,1.364381f,0.7845714f,-0.7102724f,0.00904419f,0.02392638f,0.7034621f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 4.379624f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 4.379624f);
Get(0xFA26).SetLocalPose(1.389763f,1.270335f,0.7819054f,0.5854461f,-0.4860137f,0.3611271f,-0.5391019f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448684f,1.36443f,0.7840825f,-0.7104534f,0.009003244f,0.02402237f,0.7032766f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 4.395388f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 4.395388f);
Get(0xFA26).SetLocalPose(1.389752f,1.270282f,0.7818979f,0.5854406f,-0.4860787f,0.3610971f,-0.5390693f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44888f,1.365088f,0.7838539f,-0.7106507f,0.008937215f,0.02410162f,0.7030753f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 4.411561f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 4.411561f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449048f,1.365227f,0.7835275f,-0.7107424f,0.008878449f,0.02412367f,0.7029827f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 4.428183f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 4.428183f);
Get(0xFA26).SetLocalPose(1.38992f,1.270497f,0.7816225f,0.5854197f,-0.4861228f,0.3610442f,-0.5390877f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448949f,1.365646f,0.7833211f,-0.7107764f,0.008864847f,0.02416336f,0.7029471f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 4.444803f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 4.444803f);
Get(0xFA26).SetLocalPose(1.389858f,1.270709f,0.7814335f,0.5854111f,-0.4861281f,0.3609983f,-0.539123f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449375f,1.365951f,0.7834383f,-0.7107317f,0.00882954f,0.02421614f,0.7029908f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 4.461088f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 4.461088f);
Get(0xFA26).SetLocalPose(1.389873f,1.270719f,0.7814066f,0.5854575f,-0.4861173f,0.3609256f,-0.539131f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449721f,1.365813f,0.783474f,-0.7106354f,0.008817864f,0.02420034f,0.7030888f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 4.47674f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 4.47674f);
Get(0xFA26).SetLocalPose(1.389553f,1.27062f,0.7812008f,0.5855639f,-0.4860379f,0.3608958f,-0.539107f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.450056f,1.365805f,0.7841458f,-0.7104399f,0.008865801f,0.02418217f,0.7032865f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 4.499669f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 4.499669f);
Get(0xFA26).SetLocalPose(1.389492f,1.270607f,0.7812923f,0.5856447f,-0.4859894f,0.3609762f,-0.5390092f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44997f,1.365764f,0.7844979f,-0.7102857f,0.008883979f,0.02409745f,0.7034449f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 4.516423f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 4.516423f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.450077f,1.365214f,0.7846914f,-0.7101326f,0.008982198f,0.02402617f,0.7036006f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 4.533274f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 4.533274f);
Get(0xFA26).SetLocalPose(1.389765f,1.270726f,0.7810211f,0.5856583f,-0.4859736f,0.3609885f,-0.5390004f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449948f,1.364989f,0.7846643f,-0.7100335f,0.009005405f,0.02394573f,0.7037031f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 4.541802f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 4.541802f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449881f,1.364779f,0.784633f,-0.7099254f,0.009120979f,0.02383363f,0.7038144f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 4.559988f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 4.559988f);
Get(0xFA26).SetLocalPose(1.389769f,1.270483f,0.7805915f,0.5856835f,-0.4859481f,0.3611489f,-0.5388885f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449898f,1.364568f,0.7848779f,-0.709849f,0.009217961f,0.02370309f,0.7038946f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 4.577307f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 4.577307f);
Get(0xFA26).SetLocalPose(1.390452f,1.270144f,0.7801269f,0.5855073f,-0.4860772f,0.3610758f,-0.5390125f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449691f,1.364466f,0.7847451f,-0.7098502f,0.009337776f,0.02360654f,0.7038952f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 4.593045f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 4.593045f);
Get(0xFA26).SetLocalPose(1.390892f,1.269297f,0.7804454f,0.5855311f,-0.4860318f,0.3609708f,-0.539098f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44945f,1.364242f,0.7845653f,-0.7099835f,0.009438886f,0.02350219f,0.7037627f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 4.616259f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 4.616259f);
Get(0xFA26).SetLocalPose(1.391131f,1.270024f,0.7800995f,0.58557f,-0.4860023f,0.3608628f,-0.5391546f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449384f,1.364168f,0.7844344f,-0.7100317f,0.009450058f,0.02349251f,0.7037143f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 4.62506f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 4.62506f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449103f,1.364337f,0.7845725f,-0.710179f,0.00943111f,0.02351027f,0.7035653f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 4.643307f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 4.643307f);
Get(0xFA26).SetLocalPose(1.390936f,1.270386f,0.7795045f,0.5857899f,-0.4858914f,0.3610341f,-0.5389009f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448917f,1.364434f,0.7845307f,-0.710335f,0.009361102f,0.02355176f,0.7034075f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 4.65959f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 4.65959f);
Get(0xFA26).SetLocalPose(1.391024f,1.270372f,0.7794075f,0.5858365f,-0.4858625f,0.3611586f,-0.5387929f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448817f,1.364851f,0.7845058f,-0.7104576f,0.009185463f,0.02373257f,0.7032799f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 4.682425f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 4.682425f);
Get(0xFA26).SetLocalPose(1.390531f,1.26889f,0.7791897f,0.5858845f,-0.4859241f,0.3611965f,-0.5386596f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448723f,1.364875f,0.7843723f,-0.7104872f,0.00908419f,0.02386156f,0.7032468f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 4.697298f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 4.697298f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.4488f,1.364922f,0.7845799f,-0.7104927f,0.008997877f,0.02393662f,0.7032398f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 4.713105f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 4.713105f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449016f,1.365048f,0.7845669f,-0.7104877f,0.008825733f,0.02407631f,0.7032424f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 4.728677f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 4.728677f);
Get(0xFA26).SetLocalPose(1.390708f,1.26807f,0.7791433f,0.5858539f,-0.4859312f,0.3611512f,-0.5387169f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449145f,1.365368f,0.7844638f,-0.7104463f,0.008750472f,0.02416373f,0.7032821f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 4.744689f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 4.744689f);
Get(0xFA26).SetLocalPose(1.390958f,1.26822f,0.7793393f,0.5860138f,-0.4858199f,0.3610978f,-0.5386792f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449059f,1.365459f,0.7845562f,-0.7104146f,0.008722495f,0.02419645f,0.7033134f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 4.760149f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 4.760149f);
Get(0xFA26).SetLocalPose(1.390919f,1.268309f,0.7793724f,0.58614f,-0.4857478f,0.361082f,-0.5386174f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449197f,1.365567f,0.7846689f,-0.7103502f,0.008736524f,0.02420852f,0.7033778f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 4.783008f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 4.783008f);
Get(0xFA26).SetLocalPose(1.390604f,1.267822f,0.779633f,0.5862899f,-0.4856235f,0.3610775f,-0.5385695f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449249f,1.365436f,0.7845311f,-0.7103118f,0.008837716f,0.02413698f,0.7034178f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 4.797869f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 4.797869f);
Get(0xFA26).SetLocalPose(1.390593f,1.267642f,0.7796128f,0.5863917f,-0.48553f,0.361087f,-0.5385366f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449526f,1.365206f,0.78447f,-0.7102892f,0.008920988f,0.02400499f,0.7034439f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 4.814108f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 4.814108f);
Get(0xFA26).SetLocalPose(1.390364f,1.267616f,0.7798446f,0.5864348f,-0.4855029f,0.3611288f,-0.5384858f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449728f,1.365159f,0.7844399f,-0.7102573f,0.009031087f,0.02393011f,0.7034774f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 4.830959f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 4.830959f);
Get(0xFA26).SetLocalPose(1.390324f,1.267467f,0.7798575f,0.5864487f,-0.4855134f,0.3611524f,-0.5384456f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449659f,1.364984f,0.784202f,-0.7102377f,0.009159184f,0.02378916f,0.7035003f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 4.847211f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 4.847211f);
Get(0xFA26).SetLocalPose(1.39022f,1.267384f,0.779965f,0.5864601f,-0.4855563f,0.3612146f,-0.5383529f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449686f,1.364953f,0.7842672f,-0.7101928f,0.009296493f,0.02365047f,0.7035486f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 4.863853f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 4.863853f);
Get(0xFA26).SetLocalPose(1.390159f,1.267204f,0.7799872f,0.5863597f,-0.4856798f,0.3612695f,-0.5383139f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449555f,1.365029f,0.7841527f,-0.7101694f,0.009365766f,0.02360528f,0.7035727f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 4.880059f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 4.880059f);
Get(0xFA26).SetLocalPose(1.390466f,1.267751f,0.780293f,0.5860224f,-0.4859977f,0.3614489f,-0.5382738f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449569f,1.365057f,0.7842981f,-0.7101752f,0.009415193f,0.02356008f,0.7035678f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 4.895139f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 4.895139f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449547f,1.365054f,0.7842555f,-0.7101269f,0.009365387f,0.02357688f,0.7036165f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 4.911268f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 4.911268f);
Get(0xFA26).SetLocalPose(1.390594f,1.268028f,0.7800208f,0.5859162f,-0.4860725f,0.3614875f,-0.538296f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449512f,1.36499f,0.7844535f,-0.7100909f,0.009355606f,0.02363633f,0.7036511f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 4.928295f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 4.928295f);
Get(0xFA26).SetLocalPose(1.390593f,1.268009f,0.7800402f,0.5859143f,-0.486053f,0.3614984f,-0.5383084f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449361f,1.365093f,0.7845312f,-0.7100978f,0.009274725f,0.02366981f,0.7036441f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 4.945883f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 4.945883f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449191f,1.36475f,0.7845498f,-0.7101209f,0.0091355f,0.02383781f,0.703617f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 4.96413f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 4.96413f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449197f,1.364658f,0.7844253f,-0.7101634f,0.00907553f,0.02389209f,0.7035729f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 4.980893f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 4.980893f);
Get(0xFA26).SetLocalPose(1.390912f,1.268477f,0.7801194f,0.5860261f,-0.4859952f,0.3614886f,-0.5382454f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448987f,1.364773f,0.7842352f,-0.7102115f,0.008996278f,0.02402493f,0.7035208f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 4.997296f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 4.997296f);
Get(0xFA26).SetLocalPose(1.390976f,1.268299f,0.7800408f,0.5862193f,-0.4858455f,0.3614807f,-0.5381755f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448939f,1.364944f,0.7840318f,-0.7102459f,0.008962626f,0.02402819f,0.7034864f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 5.01366f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 5.01366f);
Get(0xFA26).SetLocalPose(1.391265f,1.268304f,0.780342f,0.5863685f,-0.4858049f,0.3617409f,-0.5378746f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448958f,1.364917f,0.7839508f,-0.710314f,0.008935059f,0.02403628f,0.7034177f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 5.029771f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 5.029771f);
Get(0xFA26).SetLocalPose(1.391212f,1.268391f,0.7800242f,0.5859517f,-0.4862216f,0.3620259f,-0.5377606f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449104f,1.364906f,0.7838573f,-0.7103562f,0.008954194f,0.02406481f,0.7033738f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 5.046117f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 5.046117f);
Get(0xFA26).SetLocalPose(1.391484f,1.269133f,0.7788768f,0.5857285f,-0.4863648f,0.3618133f,-0.5380173f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449252f,1.364967f,0.7839175f,-0.7104044f,0.008990964f,0.02402033f,0.7033262f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 5.063559f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 5.063559f);
Get(0xFA26).SetLocalPose(1.392051f,1.268729f,0.7792408f,0.5865503f,-0.4854275f,0.3600234f,-0.5391679f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449273f,1.364932f,0.7839002f,-0.7103967f,0.00904249f,0.02396681f,0.7033352f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 5.081178f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 5.081178f);
Get(0xFA26).SetLocalPose(1.391595f,1.269767f,0.7801306f,0.5898437f,-0.4818502f,0.3546746f,-0.5423198f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449377f,1.364936f,0.7840654f,-0.7103736f,0.009092038f,0.02390991f,0.7033598f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 5.0987f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 5.0987f);
Get(0xFA26).SetLocalPose(1.391338f,1.273503f,0.7802351f,0.6028059f,-0.4692799f,0.3404982f,-0.5481445f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44952f,1.364844f,0.7841794f,-0.7103482f,0.009119771f,0.02388475f,0.7033859f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 5.115087f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 5.115087f);
Get(0xFA26).SetLocalPose(1.391676f,1.276067f,0.7800902f,0.612941f,-0.4591615f,0.3293423f,-0.5522751f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449579f,1.36485f,0.7841941f,-0.7102553f,0.009128259f,0.0238479f,0.703481f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 5.132004f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 5.132004f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449622f,1.364845f,0.7842667f,-0.7102188f,0.009147215f,0.02383088f,0.703518f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 5.141181f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 5.141181f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449575f,1.365174f,0.7843834f,-0.7101434f,0.009165929f,0.02378543f,0.7035955f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 5.159447f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 5.159447f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449508f,1.365156f,0.7843685f,-0.7100829f,0.009212065f,0.0237866f,0.703656f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 5.175903f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 5.175903f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449443f,1.365024f,0.7844836f,-0.7100465f,0.009241984f,0.02374509f,0.7036936f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 5.199261f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 5.199261f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44907f,1.364726f,0.7844449f,-0.7100257f,0.009275127f,0.02371163f,0.7037154f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 5.2153f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 5.2153f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449122f,1.364488f,0.784537f,-0.7100611f,0.009235445f,0.02375706f,0.7036787f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 5.23065f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 5.23065f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448959f,1.364503f,0.7846311f,-0.7101052f,0.0092474f,0.02373592f,0.7036347f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 5.246088f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 5.246088f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44878f,1.364509f,0.7846793f,-0.7101897f,0.009254682f,0.02372533f,0.7035497f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 5.262578f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 5.262578f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448639f,1.364685f,0.7843574f,-0.7102384f,0.009252897f,0.02373085f,0.7035004f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 5.277997f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 5.277997f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448641f,1.3649f,0.7841006f,-0.7102877f,0.009245439f,0.02377527f,0.7034492f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 5.294508f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 5.294508f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448537f,1.36492f,0.7839613f,-0.7103345f,0.009235687f,0.02379574f,0.7034013f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 5.310804f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 5.310804f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448601f,1.364887f,0.7839888f,-0.7103651f,0.009179766f,0.02383342f,0.7033699f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 5.326933f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 5.326933f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.4487f,1.364845f,0.7840014f,-0.7103526f,0.00911802f,0.02386238f,0.7033823f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 5.349063f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 5.349063f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448812f,1.364822f,0.7839899f,-0.7103239f,0.009066311f,0.02392351f,0.7034099f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 5.364692f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 5.364692f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449016f,1.364758f,0.7841948f,-0.710293f,0.009025086f,0.02393351f,0.7034413f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 5.380522f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 5.380522f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449348f,1.364726f,0.7844138f,-0.7102743f,0.009018836f,0.02393294f,0.7034603f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 5.395669f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 5.395669f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449479f,1.364777f,0.7844429f,-0.7102212f,0.009025904f,0.02390124f,0.7035148f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 5.411636f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 5.411636f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449463f,1.364913f,0.7844243f,-0.7101717f,0.009074275f,0.02387084f,0.7035652f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 5.428706f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 5.428706f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449516f,1.365026f,0.7844415f,-0.7101502f,0.009141942f,0.02380963f,0.7035881f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 5.446662f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 5.446662f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449521f,1.365157f,0.7844969f,-0.7101323f,0.009182539f,0.02378057f,0.7036066f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 5.464124f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 5.464124f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449315f,1.365115f,0.7841972f,-0.7101157f,0.009245713f,0.02376027f,0.7036233f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 5.481747f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 5.481747f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44935f,1.365133f,0.7840872f,-0.7101477f,0.009214543f,0.02374061f,0.7035921f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 5.499236f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 5.499236f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449387f,1.36514f,0.7840121f,-0.7101803f,0.009219415f,0.02374015f,0.7035591f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 5.51643f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 5.51643f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449325f,1.365265f,0.7839515f,-0.7101991f,0.009214915f,0.02374361f,0.70354f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 5.525145f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 5.525145f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449378f,1.365104f,0.7841706f,-0.7102333f,0.009186837f,0.02376546f,0.7035052f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 5.543271f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 5.543271f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449317f,1.365127f,0.7842054f,-0.7102469f,0.009146647f,0.02382761f,0.7034899f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 5.560794f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 5.560794f);
Get(0xFA26).SetLocalPose(-0.01582287f,1.663306f,0.01720051f,0.1211649f,-0.6102204f,0.7265608f,0.2916498f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449327f,1.364967f,0.7842476f,-0.7102775f,0.009090307f,0.02384328f,0.7034592f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 5.577396f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 5.577396f);
Get(0xFA26).SetLocalPose(-0.004120203f,1.67545f,0.004487498f,0.1172737f,-0.603816f,0.7328559f,0.2908184f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449271f,1.364946f,0.7842513f,-0.7102606f,0.009083267f,0.02386338f,0.7034756f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 5.594238f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 5.594238f);
Get(0xFA26).SetLocalPose(9.667643E-06f,1.680015f,2.509427E-06f,-0.6831887f,-0.1859768f,0.3598728f,0.6075832f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449147f,1.364945f,0.7843027f,-0.7102234f,0.00906845f,0.02389524f,0.7035123f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 5.609684f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 5.609684f);
Get(0xFA26).SetLocalPose(-1.289383E-05f,1.68f,3.265748E-05f,-0.6814166f,-0.1807769f,0.3628399f,0.6093754f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44936f,1.364761f,0.7843821f,-0.7102517f,0.009042259f,0.02393193f,0.7034828f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 5.62736f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 5.62736f);
Get(0xFA26).SetLocalPose(1.301212f,1.346206f,0.7808336f,-0.6784601f,-0.1772148f,0.3662337f,0.6116859f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449324f,1.364716f,0.7843513f,-0.7102155f,0.009028096f,0.02392724f,0.7035197f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 5.644573f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 5.644573f);
Get(0xFA26).SetLocalPose(1.300409f,1.345751f,0.7810721f,-0.677505f,-0.1751566f,0.3684019f,0.6120353f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449216f,1.364636f,0.7841568f,-0.7102123f,0.009102849f,0.02388767f,0.7035232f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 5.662069f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 5.662069f);
Get(0xFA26).SetLocalPose(1.299337f,1.345505f,0.7798712f,-0.6746386f,-0.1748799f,0.3755304f,0.6109475f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449177f,1.36471f,0.7840775f,-0.7101871f,0.009099697f,0.02385139f,0.70355f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 5.679717f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 5.679717f);
Get(0xFA26).SetLocalPose(1.298736f,1.345098f,0.7800223f,-0.6727334f,-0.1761918f,0.3770147f,0.6117566f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449221f,1.364883f,0.784349f,-0.7102285f,0.009144659f,0.02384275f,0.703508f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 5.696618f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 5.696618f);
Get(0xFA26).SetLocalPose(1.29884f,1.345134f,0.7801229f,-0.6718014f,-0.1750879f,0.3776149f,0.6127268f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449209f,1.365022f,0.7842292f,-0.7102041f,0.009178101f,0.02380259f,0.7035335f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 5.713852f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 5.713852f);
Get(0xFA26).SetLocalPose(1.299292f,1.34524f,0.7804512f,-0.6682162f,-0.1667245f,0.3800174f,0.6174762f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449225f,1.365137f,0.7841002f,-0.7101915f,0.009205709f,0.0237743f,0.7035469f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 5.73058f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 5.73058f);
Get(0xFA26).SetLocalPose(1.299418f,1.345257f,0.7812833f,-0.666393f,-0.1607252f,0.3806329f,0.6206499f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449173f,1.365135f,0.7841462f,-0.7101822f,0.009251117f,0.0237636f,0.7035559f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 5.746441f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 5.746441f);
Get(0xFA26).SetLocalPose(1.299432f,1.345281f,0.7813457f,-0.6662771f,-0.1600573f,0.3805324f,0.6210085f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449138f,1.365228f,0.784227f,-0.7102036f,0.00925389f,0.02377508f,0.7035339f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 5.76294f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 5.76294f);
Get(0xFA26).SetLocalPose(1.299598f,1.345186f,0.7816489f,-0.6657766f,-0.1586196f,0.3798616f,0.6223236f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449119f,1.365148f,0.7842562f,-0.7101918f,0.0092427f,0.02377659f,0.703546f);
Get(0xF9DC).GetComponent<Animator>().Play("New State", 0, 5.779842f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 5.779842f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449277f,1.365115f,0.7843288f,-0.710183f,0.00918819f,0.02381369f,0.7035543f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.03383077f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 5.799292f);
Get(0xFA26).SetLocalPose(1.299872f,1.345025f,0.7816991f,-0.6655238f,-0.1597201f,0.3777722f,0.623583f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449174f,1.365223f,0.7841565f,-0.7101912f,0.00913334f,0.02383684f,0.703546f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.08427969f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 5.815688f);
Get(0xFA26).SetLocalPose(1.300528f,1.34474f,0.7821224f,-0.6658056f,-0.1580142f,0.3758551f,0.6248739f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449257f,1.365258f,0.7841635f,-0.7101802f,0.00911851f,0.02388832f,0.7035555f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.1322295f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 5.831272f);
Get(0xFA26).SetLocalPose(1.300761f,1.344752f,0.7823858f,-0.6658289f,-0.1554397f,0.373936f,0.6266437f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449438f,1.365204f,0.7842279f,-0.7102005f,0.009090099f,0.02389669f,0.703535f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.1827778f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 5.8477f);
Get(0xFA26).SetLocalPose(1.30108f,1.344842f,0.7824867f,-0.6661012f,-0.1517021f,0.3724911f,0.6281291f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44949f,1.365028f,0.7840694f,-0.7102151f,0.009060281f,0.0239397f,0.7035193f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.2360061f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 5.864999f);
Get(0xFA26).SetLocalPose(1.301632f,1.345005f,0.7818381f,-0.667918f,-0.1488105f,0.3712519f,0.627625f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449374f,1.365038f,0.7840303f,-0.710201f,0.009087594f,0.02391717f,0.703534f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.2877677f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 5.881822f);
Get(0xFA26).SetLocalPose(1.301558f,1.344607f,0.7818642f,-0.6694075f,-0.1500481f,0.3698639f,0.6265619f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449478f,1.364957f,0.7840889f,-0.7102337f,0.009102914f,0.02390801f,0.703501f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.3398994f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 5.898764f);
Get(0xFA26).SetLocalPose(1.301616f,1.344531f,0.7815481f,-0.6697901f,-0.1507393f,0.3694538f,0.6262291f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449474f,1.365013f,0.7840513f,-0.7102335f,0.009112615f,0.02387741f,0.7035021f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.3917415f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 5.915613f);
Get(0xFA26).SetLocalPose(1.301741f,1.344848f,0.7811416f,-0.6696002f,-0.1508919f,0.3697816f,0.6262019f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449605f,1.364942f,0.7841312f,-0.7102482f,0.009107227f,0.02388106f,0.7034872f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.4390723f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 5.930995f);
Get(0xFA26).SetLocalPose(1.301734f,1.344757f,0.7809661f,-0.6697789f,-0.1505569f,0.370329f,0.6257678f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449486f,1.364977f,0.7841589f,-0.7102433f,0.009152718f,0.02384876f,0.7034926f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.4908031f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 5.947808f);
Get(0xFA26).SetLocalPose(1.30191f,1.344271f,0.7809635f,-0.6696882f,-0.1485058f,0.3716404f,0.6255776f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449324f,1.364823f,0.7841904f,-0.710228f,0.009146351f,0.02384792f,0.7035083f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.5436314f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 5.964977f);
Get(0xFA26).SetLocalPose(1.302055f,1.344128f,0.7810511f,-0.6702641f,-0.1483063f,0.3714626f,0.6251134f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449278f,1.364857f,0.7842093f,-0.7102079f,0.009174183f,0.02383093f,0.7035287f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.5950111f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 5.981676f);
Get(0xFA26).SetLocalPose(1.302353f,1.343585f,0.7810995f,-0.6717238f,-0.1484767f,0.3694468f,0.6247007f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449356f,1.365068f,0.7840292f,-0.7101652f,0.009188108f,0.02380253f,0.7035727f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.646284f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 5.99834f);
Get(0xFA26).SetLocalPose(1.302866f,1.343484f,0.7808468f,-0.672875f,-0.1480395f,0.3676285f,0.6246383f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449225f,1.365075f,0.7840191f,-0.71017f,0.009187736f,0.02379387f,0.7035682f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.6972563f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 6.014905f);
Get(0xFA26).SetLocalPose(1.303519f,1.343433f,0.7804899f,-0.6734135f,-0.1459399f,0.3667516f,0.6250673f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449062f,1.365129f,0.7840967f,-0.710132f,0.009167843f,0.02381878f,0.7036059f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.7231113f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 6.023308f);
Get(0xFA26).SetLocalPose(1.303845f,1.343196f,0.78054f,-0.6736956f,-0.1441573f,0.3661422f,0.6255341f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449113f,1.365122f,0.7840857f,-0.7101251f,0.009149559f,0.02382971f,0.7036127f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.7727243f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 6.039433f);
Get(0xFA26).SetLocalPose(1.304329f,1.342948f,0.7804841f,-0.6738616f,-0.1436761f,0.3658459f,0.6256394f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449202f,1.365229f,0.7841976f,-0.7101347f,0.009132498f,0.02385463f,0.7036024f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.8435092f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 6.062438f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449266f,1.365228f,0.7841682f,-0.710143f,0.00911557f,0.02387301f,0.7035937f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.8785929f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 6.07384f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.4492f,1.365158f,0.7842034f,-0.7101642f,0.009101723f,0.02388187f,0.703572f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.9498523f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 6.096999f);
Get(0xFA26).SetLocalPose(1.304432f,1.342869f,0.7804188f,-0.6740515f,-0.1434722f,0.3655573f,0.6256502f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449197f,1.365176f,0.7841942f,-0.7101596f,0.009093114f,0.02388716f,0.7035767f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.9808763f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 6.107082f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449225f,1.365165f,0.7840623f,-0.7101827f,0.009081265f,0.02389552f,0.7035532f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.06087f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 6.13308f);
Get(0xFA26).SetLocalPose(1.304873f,1.34329f,0.7804702f,-0.6743742f,-0.1432682f,0.3652092f,0.6255526f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449532f,1.365047f,0.7841675f,-0.7102414f,0.009060986f,0.02390892f,0.7034938f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.107162f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 6.148125f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449653f,1.365031f,0.7841896f,-0.7102637f,0.009080573f,0.02389019f,0.7034717f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.156785f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 6.164252f);
Get(0xFA26).SetLocalPose(1.305214f,1.342903f,0.7804608f,-0.6748871f,-0.1430009f,0.3647379f,0.6253355f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44957f,1.365007f,0.7843301f,-0.7102572f,0.009096222f,0.02387116f,0.7034787f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.20761f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 6.18077f);
Get(0xFA26).SetLocalPose(1.305661f,1.343025f,0.78025f,-0.6755104f,-0.1425191f,0.3639646f,0.6252231f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449593f,1.364909f,0.7844394f,-0.7102442f,0.009097442f,0.02386938f,0.7034918f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.256704f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 6.196726f);
Get(0xFA26).SetLocalPose(1.305978f,1.342985f,0.7799517f,-0.6755157f,-0.1413488f,0.3639758f,0.6254764f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449613f,1.365074f,0.7843497f,-0.7102123f,0.009115078f,0.02385068f,0.7035244f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.309383f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 6.213846f);
Get(0xFA26).SetLocalPose(1.306183f,1.34313f,0.7800761f,-0.6753937f,-0.1404283f,0.3649271f,0.6252611f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449441f,1.365099f,0.7843078f,-0.7101943f,0.009145675f,0.02382236f,0.7035431f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.362123f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 6.230987f);
Get(0xFA26).SetLocalPose(1.306414f,1.343803f,0.7797082f,-0.6756507f,-0.1402072f,0.364897f,0.6250507f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449426f,1.365265f,0.7842259f,-0.7101674f,0.009175402f,0.02380479f,0.7035705f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.415033f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 6.248182f);
Get(0xFA26).SetLocalPose(1.306724f,1.344259f,0.7795027f,-0.6758133f,-0.1395853f,0.3642643f,0.625383f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449219f,1.365093f,0.784248f,-0.7101626f,0.009171948f,0.02381578f,0.7035751f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.467092f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 6.265101f);
Get(0xFA26).SetLocalPose(1.306907f,1.344298f,0.7795879f,-0.6757215f,-0.1385703f,0.3639698f,0.6258792f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449207f,1.365136f,0.7842785f,-0.7101657f,0.009180884f,0.02381149f,0.703572f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.494672f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 6.274065f);
Get(0xFA26).SetLocalPose(1.306877f,1.34435f,0.779723f,-0.6754996f,-0.1381935f,0.3642578f,0.6260344f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449025f,1.36504f,0.7841372f,-0.7101828f,0.009191823f,0.02380107f,0.7035549f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.558001f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 6.294647f);
Get(0xFA26).SetLocalPose(1.306804f,1.344534f,0.7797181f,-0.6752099f,-0.1383358f,0.3649808f,0.6258945f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449014f,1.365031f,0.7841936f,-0.7102016f,0.009202413f,0.02380461f,0.7035356f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.610389f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 6.311673f);
Get(0xFA26).SetLocalPose(1.306936f,1.344549f,0.7794707f,-0.6748668f,-0.1394741f,0.3657662f,0.6255534f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448876f,1.36498f,0.7841045f,-0.7101946f,0.009177223f,0.02383283f,0.7035421f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.665106f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 6.329456f);
Get(0xFA26).SetLocalPose(1.306853f,1.344626f,0.7793903f,-0.6746405f,-0.1399481f,0.3661262f,0.6254809f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448899f,1.364977f,0.7840098f,-0.7102057f,0.009137115f,0.02387949f,0.7035298f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.71858f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 6.346836f);
Get(0xFA26).SetLocalPose(1.306795f,1.344729f,0.7794096f,-0.6739772f,-0.140797f,0.3670493f,0.6254646f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448912f,1.364882f,0.783987f,-0.7102028f,0.009150965f,0.02387292f,0.7035329f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.772017f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 6.364203f);
Get(0xFA26).SetLocalPose(1.306893f,1.344512f,0.7793925f,-0.673147f,-0.1422931f,0.3683511f,0.6252546f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448909f,1.365035f,0.7839221f,-0.7102031f,0.009168658f,0.02385838f,0.7035328f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.826988f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 6.382068f);
Get(0xFA26).SetLocalPose(1.306193f,1.344109f,0.7798859f,-0.6699371f,-0.1492336f,0.3736584f,0.6239336f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448781f,1.365159f,0.7838663f,-0.7101966f,0.009205244f,0.02382255f,0.70354f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.88096f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 6.399609f);
Get(0xFA26).SetLocalPose(1.304426f,1.343296f,0.7805414f,-0.6632679f,-0.1633637f,0.3843569f,0.6210136f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448906f,1.36518f,0.7838433f,-0.7101959f,0.009182796f,0.02384617f,0.7035403f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.907453f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 6.408219f);
Get(0xFA26).SetLocalPose(1.303585f,1.343192f,0.7807943f,-0.6595479f,-0.1707272f,0.3892867f,0.6199232f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448791f,1.365141f,0.783761f,-0.7101566f,0.009200667f,0.02383107f,0.7035801f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.963453f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 6.426419f);
Get(0xFA26).SetLocalPose(1.300956f,1.34285f,0.7813624f,-0.6498689f,-0.190487f,0.4024355f,0.6159796f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448835f,1.364906f,0.7837076f,-0.7101388f,0.009210574f,0.02382933f,0.7035981f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.01674f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 6.443737f);
Get(0xFA26).SetLocalPose(1.297623f,1.341877f,0.7818442f,-0.6388086f,-0.2136362f,0.4179414f,0.6095968f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448902f,1.36483f,0.7837458f,-0.7101338f,0.009203878f,0.0238278f,0.7036033f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.075333f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 6.46278f);
Get(0xFA26).SetLocalPose(1.29627f,1.341694f,0.7818614f,-0.6348554f,-0.2212808f,0.4230719f,0.6074567f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448934f,1.364964f,0.7837266f,-0.7101071f,0.009197009f,0.0238335f,0.7036301f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.105115f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 6.472459f);
Get(0xFA26).SetLocalPose(1.295449f,1.341366f,0.781996f,-0.6318346f,-0.2269874f,0.4270775f,0.6056952f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44909f,1.364972f,0.7838823f,-0.7101346f,0.00920906f,0.02383645f,0.703602f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.170178f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 6.493604f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449094f,1.365032f,0.7838389f,-0.7101252f,0.009202475f,0.02382785f,0.703612f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.231562f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 6.513554f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449288f,1.365112f,0.78391f,-0.71016f,0.009203804f,0.02380651f,0.7035776f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.292284f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 6.533289f);
Get(0xFA26).SetLocalPose(1.293429f,1.340551f,0.7822173f,-0.6256489f,-0.2383648f,0.4354632f,0.601762f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449334f,1.365051f,0.7839769f,-0.7101786f,0.0091805f,0.02386445f,0.7035572f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.322412f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 6.543081f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449489f,1.364926f,0.7841254f,-0.7102141f,0.009132866f,0.02386005f,0.7035221f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.380207f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 6.561864f);
Get(0xFA26).SetLocalPose(1.291316f,1.339396f,0.7828197f,-0.619161f,-0.2499582f,0.4443006f,0.5972919f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449505f,1.364943f,0.7840474f,-0.7102146f,0.009131677f,0.02385557f,0.7035218f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.43176f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 6.578618f);
Get(0xFA26).SetLocalPose(1.286476f,1.337287f,0.7837065f,-0.6037053f,-0.2757472f,0.4649255f,0.5859587f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449542f,1.36503f,0.7841831f,-0.7102355f,0.009114379f,0.02386748f,0.7035004f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.484921f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 6.595895f);
Get(0xFA26).SetLocalPose(1.281271f,1.333435f,0.7847634f,-0.5850331f,-0.3033213f,0.4899479f,0.5706869f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449419f,1.365058f,0.7842051f,-0.7102383f,0.009111241f,0.02387211f,0.7034975f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.541235f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 6.614197f);
Get(0xFA26).SetLocalPose(1.27759f,1.32922f,0.7847244f,-0.5614216f,-0.334219f,0.51845f,0.5516458f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44948f,1.365008f,0.7842539f,-0.7102405f,0.009084035f,0.02389132f,0.703495f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.594284f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 6.631438f);
Get(0xFA26).SetLocalPose(1.27357f,1.324426f,0.7853379f,-0.5390223f,-0.3608344f,0.5431876f,0.5331048f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449561f,1.36522f,0.7844428f,-0.7102404f,0.009075865f,0.02390828f,0.7034946f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.642991f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 6.647268f);
Get(0xFA26).SetLocalPose(1.268828f,1.318095f,0.7867581f,-0.5089818f,-0.3930872f,0.5720055f,0.5091462f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449464f,1.365291f,0.7844066f,-0.7102291f,0.009107699f,0.02387938f,0.7035066f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.691699f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 6.663098f);
Get(0xFA26).SetLocalPose(1.266936f,1.314974f,0.7881157f,-0.4936817f,-0.407618f,0.5854495f,0.4973679f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449467f,1.365279f,0.7844996f,-0.7102221f,0.009048169f,0.02386847f,0.7035148f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.744404f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 6.680227f);
Get(0xFA26).SetLocalPose(1.264398f,1.309547f,0.7892704f,-0.4695089f,-0.4276991f,0.6064641f,0.4783682f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449543f,1.365272f,0.784585f,-0.7102187f,0.009092035f,0.02391909f,0.7035159f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.795602f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 6.696867f);
Get(0xFA26).SetLocalPose(1.263476f,1.303795f,0.7907955f,-0.4422311f,-0.4470948f,0.6279068f,0.4585532f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449586f,1.365163f,0.7846808f,-0.7102393f,0.009110641f,0.02389342f,0.7034958f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.851487f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 6.715029f);
Get(0xFA26).SetLocalPose(1.262793f,1.302163f,0.7913871f,-0.4292143f,-0.4551877f,0.6382051f,0.4486352f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449776f,1.365024f,0.7847984f,-0.7102478f,0.009131836f,0.02387349f,0.7034876f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.902175f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 6.731503f);
Get(0xFA26).SetLocalPose(1.2631f,1.29974f,0.7920113f,-0.4180634f,-0.4615532f,0.6464747f,0.4407519f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449641f,1.365098f,0.7846851f,-0.7102203f,0.00914382f,0.02386686f,0.7035154f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.953413f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 6.748155f);
Get(0xFA26).SetLocalPose(1.263244f,1.298173f,0.7927914f,-0.4084148f,-0.4670818f,0.6528705f,0.4345022f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449682f,1.364956f,0.7846433f,-0.7102133f,0.009154772f,0.02388382f,0.7035218f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.003538f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 6.764446f);
Get(0xFA26).SetLocalPose(1.263466f,1.296606f,0.7925203f,-0.3998503f,-0.4718488f,0.6584443f,0.4288701f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449617f,1.364994f,0.7844626f,-0.710226f,0.009145115f,0.02385573f,0.70351f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.051096f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 6.779902f);
Get(0xFA26).SetLocalPose(1.263689f,1.296568f,0.7926567f,-0.3945178f,-0.4748809f,0.662034f,0.4249175f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449629f,1.365032f,0.7843959f,-0.7102376f,0.009124214f,0.0238355f,0.7034993f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.099574f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 6.795658f);
Get(0xFA26).SetLocalPose(1.264492f,1.297004f,0.7926025f,-0.3906999f,-0.4770951f,0.6645418f,0.4220404f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449616f,1.365049f,0.7842785f,-0.7102264f,0.00913615f,0.02387941f,0.7035089f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.149646f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 6.811931f);
Get(0xFA26).SetLocalPose(1.264771f,1.297606f,0.7926689f,-0.3874443f,-0.4791756f,0.666449f,0.4196707f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449584f,1.365086f,0.784252f,-0.7102317f,0.009085703f,0.02386123f,0.7035049f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.199646f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 6.828181f);
Get(0xFA26).SetLocalPose(1.265248f,1.297998f,0.792074f,-0.3851659f,-0.4808103f,0.6678044f,0.4177392f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449452f,1.365215f,0.7841275f,-0.710232f,0.009095804f,0.02387327f,0.703504f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.248512f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 6.844063f);
Get(0xFA26).SetLocalPose(1.265723f,1.298178f,0.7919096f,-0.3837493f,-0.4822364f,0.6685629f,0.4161831f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449446f,1.365234f,0.7842287f,-0.7102103f,0.009094367f,0.02389785f,0.7035251f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.296756f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 6.859742f);
Get(0xFA26).SetLocalPose(1.266875f,1.297487f,0.7912763f,-0.3832435f,-0.4826928f,0.6690334f,0.415363f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449469f,1.365263f,0.7842171f,-0.7102f,0.00906477f,0.02389998f,0.7035359f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.352225f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 6.87777f);
Get(0xFA26).SetLocalPose(1.267766f,1.297063f,0.790931f,-0.3831297f,-0.4823268f,0.6697881f,0.4146763f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.4494f,1.36513f,0.7842026f,-0.7101982f,0.009042063f,0.02388066f,0.7035386f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.406206f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 6.895313f);
Get(0xFA26).SetLocalPose(1.269253f,1.297944f,0.790306f,-0.3827714f,-0.482002f,0.6708634f,0.4136454f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449376f,1.36515f,0.7841726f,-0.7101829f,0.00906767f,0.02388604f,0.7035535f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.459505f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 6.912635f);
Get(0xFA26).SetLocalPose(1.269374f,1.297908f,0.7903445f,-0.382141f,-0.4817174f,0.6719913f,0.4127278f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449431f,1.365183f,0.784192f,-0.7101756f,0.009073345f,0.02389749f,0.7035604f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.511937f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 6.929676f);
Get(0xFA26).SetLocalPose(1.269343f,1.298872f,0.7896401f,-0.3811867f,-0.4817193f,0.6728783f,0.4121626f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449455f,1.365214f,0.7840974f,-0.7101734f,0.009138683f,0.02384849f,0.7035635f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.562312f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 6.946047f);
Get(0xFA26).SetLocalPose(1.268901f,1.299564f,0.7896171f,-0.3814442f,-0.4812844f,0.6728334f,0.4125057f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449495f,1.365198f,0.7841584f,-0.7102011f,0.009144569f,0.02385832f,0.7035351f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.615652f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 6.963383f);
Get(0xFA26).SetLocalPose(1.26875f,1.299922f,0.7895439f,-0.3827496f,-0.4805388f,0.6721627f,0.4132584f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449422f,1.365099f,0.784004f,-0.71019f,0.009140902f,0.02382925f,0.7035472f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.670745f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 6.981288f);
Get(0xFA26).SetLocalPose(1.269045f,1.300036f,0.7895423f,-0.384854f,-0.4787479f,0.6715255f,0.4144169f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449421f,1.365155f,0.7840939f,-0.7101923f,0.009167993f,0.02381502f,0.7035452f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.725084f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 6.998949f);
Get(0xFA26).SetLocalPose(1.269192f,1.299573f,0.7893818f,-0.3855544f,-0.4777753f,0.6716756f,0.4146452f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449229f,1.365067f,0.7840446f,-0.7101859f,0.009159657f,0.02381442f,0.7035517f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.777442f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 7.015965f);
Get(0xFA26).SetLocalPose(1.269f,1.298895f,0.790114f,-0.3859231f,-0.4768522f,0.6722183f,0.4144852f);
});
r.Add(delegate{
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.803814f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 7.024536f);
Get(0xFA26).SetLocalPose(1.268989f,1.298321f,0.7894695f,-0.3862549f,-0.476099f,0.6724058f,0.4147376f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449106f,1.365131f,0.784014f,-0.71017f,0.009159042f,0.02384233f,0.7035668f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.862117f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 7.043484f);
Get(0xFA26).SetLocalPose(1.269129f,1.29705f,0.789059f,-0.3874142f,-0.4744143f,0.6723066f,0.4157465f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449191f,1.365102f,0.7840541f,-0.7101712f,0.009171955f,0.02382471f,0.7035661f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.913635f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 7.060227f);
Get(0xFA26).SetLocalPose(1.268706f,1.296195f,0.7888545f,-0.3890874f,-0.4726059f,0.6718116f,0.4170418f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449101f,1.364943f,0.7840076f,-0.7101813f,0.009154974f,0.02384876f,0.7035553f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.964106f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 7.07663f);
Get(0xFA26).SetLocalPose(1.268875f,1.296793f,0.7887765f,-0.3910981f,-0.4707345f,0.6710039f,0.4185752f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449133f,1.364902f,0.7839765f,-0.7101796f,0.009146032f,0.02383967f,0.7035574f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.01576f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 7.093418f);
Get(0xFA26).SetLocalPose(1.269187f,1.296278f,0.7887654f,-0.3939466f,-0.4681526f,0.6696525f,0.4209571f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44903f,1.364919f,0.7839341f,-0.7101723f,0.009169292f,0.02383501f,0.7035646f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.06945f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 7.110868f);
Get(0xFA26).SetLocalPose(1.267511f,1.296357f,0.7898976f,-0.397584f,-0.4640123f,0.6689385f,0.4232505f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448954f,1.365063f,0.7838863f,-0.7101674f,0.009171631f,0.02385028f,0.703569f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.121f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 7.127621f);
Get(0xFA26).SetLocalPose(1.267457f,1.297239f,0.7890964f,-0.4027935f,-0.4584002f,0.6662993f,0.4285697f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448797f,1.365049f,0.7836917f,-0.7101586f,0.009179434f,0.02387343f,0.703577f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.173038f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 7.144534f);
Get(0xFA26).SetLocalPose(1.268445f,1.299503f,0.7888282f,-0.4145069f,-0.4467608f,0.658829f,0.4410592f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448867f,1.365062f,0.7837417f,-0.7101578f,0.009179156f,0.02385489f,0.7035784f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.227345f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 7.162183f);
Get(0xFA26).SetLocalPose(1.269385f,1.30222f,0.7892596f,-0.431878f,-0.431034f,0.6457327f,0.4590429f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448893f,1.365029f,0.7837371f,-0.7101766f,0.009191653f,0.02384737f,0.7035596f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.279674f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 7.17919f);
Get(0xFA26).SetLocalPose(1.269855f,1.303956f,0.7887061f,-0.4440647f,-0.4200153f,0.6362386f,0.4707378f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449065f,1.364989f,0.7837927f,-0.7101844f,0.00916927f,0.02384522f,0.703552f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.333332f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 7.196629f);
Get(0xFA26).SetLocalPose(1.271292f,1.306526f,0.7882165f,-0.463371f,-0.4006161f,0.6224785f,0.4871495f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449108f,1.364955f,0.7839107f,-0.7101735f,0.009158469f,0.02384341f,0.7035633f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.383085f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 7.212799f);
Get(0xFA26).SetLocalPose(1.271571f,1.312078f,0.787516f,-0.4910641f,-0.3678407f,0.6004286f,0.5128691f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449305f,1.36501f,0.7840443f,-0.7102106f,0.009149416f,0.02381842f,0.7035269f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.406827f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 7.220515f);
Get(0xFA26).SetLocalPose(1.273504f,1.316842f,0.7862421f,-0.5179561f,-0.333058f,0.5750518f,0.5386179f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449359f,1.365014f,0.7842051f,-0.7102047f,0.009153406f,0.02382476f,0.7035325f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.479743f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 7.244213f);
Get(0xFA26).SetLocalPose(1.278168f,1.322923f,0.7848729f,-0.5548016f,-0.2795008f,0.532712f,0.5747107f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449407f,1.365134f,0.7842994f,-0.710202f,0.00914648f,0.0238438f,0.7035346f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.534996f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 7.26217f);
Get(0xFA26).SetLocalPose(1.284267f,1.328261f,0.7833483f,-0.5861949f,-0.2267342f,0.4879273f,0.6057178f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449467f,1.365078f,0.7843546f,-0.7102001f,0.009104112f,0.02386016f,0.7035365f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.590504f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 7.28021f);
Get(0xFA26).SetLocalPose(1.294258f,1.334375f,0.7814831f,-0.6193582f,-0.1573368f,0.4248387f,0.641212f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449596f,1.365101f,0.7843851f,-0.7102031f,0.00912336f,0.02384834f,0.7035337f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.643494f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 7.297432f);
Get(0xFA26).SetLocalPose(1.302371f,1.337615f,0.7804952f,-0.6362827f,-0.1052367f,0.3756269f,0.665563f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449628f,1.365082f,0.7844135f,-0.7102107f,0.009106527f,0.02385311f,0.703526f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.694194f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 7.31391f);
Get(0xFA26).SetLocalPose(1.310968f,1.339771f,0.7793465f,-0.6475429f,-0.054621f,0.3259043f,0.6866522f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449659f,1.365257f,0.7845725f,-0.7102289f,0.009092268f,0.02386396f,0.7035074f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.747633f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 7.331277f);
Get(0xFA26).SetLocalPose(1.322126f,1.341115f,0.7779709f,-0.6552823f,0.002395542f,0.2651599f,0.7073116f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449622f,1.365282f,0.7845703f,-0.7102129f,0.009110883f,0.02387751f,0.703523f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.800047f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 7.348312f);
Get(0xFA26).SetLocalPose(1.338729f,1.339646f,0.776543f,-0.6572953f,0.08013367f,0.1743106f,0.7288054f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449486f,1.365119f,0.7844132f,-0.7102253f,0.009130742f,0.02386682f,0.7035105f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.852683f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 7.365418f);
Get(0xFA26).SetLocalPose(1.348196f,1.337045f,0.7759628f,-0.6547293f,0.1305504f,0.1120366f,0.7360258f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44946f,1.364928f,0.7843853f,-0.7102457f,0.009105755f,0.023856f,0.7034907f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.907067f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 7.383093f);
Get(0xFA26).SetLocalPose(1.359108f,1.332587f,0.7750062f,-0.6492823f,0.1834309f,0.04253483f,0.7368694f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449381f,1.364861f,0.7843214f,-0.7102543f,0.009089806f,0.02385781f,0.7034821f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.957988f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 7.399642f);
Get(0xFA26).SetLocalPose(1.367427f,1.327296f,0.7746556f,-0.6417186f,0.2227171f,-0.01574175f,0.7337211f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449293f,1.364998f,0.7843995f,-0.7102364f,0.009123971f,0.02384801f,0.7035001f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.984419f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 7.408233f);
Get(0xFA26).SetLocalPose(1.372623f,1.324046f,0.7742808f,-0.6360137f,0.2432202f,-0.04915217f,0.7306947f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449308f,1.365012f,0.7844054f,-0.7102329f,0.00914187f,0.02387233f,0.7035025f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.040655f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 7.426509f);
Get(0xFA26).SetLocalPose(1.37831f,1.318898f,0.7748272f,-0.6269851f,0.2725158f,-0.09664195f,0.7233846f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449479f,1.364919f,0.7844597f,-0.7102419f,0.009110596f,0.02388436f,0.7034935f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.091825f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 7.44314f);
Get(0xFA26).SetLocalPose(1.383339f,1.313568f,0.7746145f,-0.6201959f,0.2990453f,-0.1365703f,0.7122343f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449357f,1.365113f,0.7843415f,-0.7102262f,0.009156533f,0.02387263f,0.7035092f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.145248f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 7.460502f);
Get(0xFA26).SetLocalPose(1.387437f,1.308833f,0.7740763f,-0.6152596f,0.323836f,-0.1744614f,0.6972439f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449321f,1.365001f,0.7842405f,-0.7102171f,0.00913738f,0.02384759f,0.7035195f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.19482f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 7.476614f);
Get(0xFA26).SetLocalPose(1.390106f,1.304419f,0.7734028f,-0.6123832f,0.3416435f,-0.2031657f,0.6833668f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449234f,1.364966f,0.7842363f,-0.7102173f,0.009180672f,0.02386014f,0.7035182f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.248402f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 7.494028f);
Get(0xFA26).SetLocalPose(1.392361f,1.30049f,0.7732275f,-0.6073003f,0.358672f,-0.229395f,0.6707598f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449158f,1.365082f,0.7842503f,-0.7101992f,0.009171882f,0.02384919f,0.703537f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.303152f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 7.511821f);
Get(0xFA26).SetLocalPose(1.393791f,1.297626f,0.77312f,-0.6025386f,0.374491f,-0.2516503f,0.658313f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449064f,1.365134f,0.7842295f,-0.7101947f,0.009171519f,0.023853f,0.7035414f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.352022f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 7.527704f);
Get(0xFA26).SetLocalPose(1.394572f,1.295732f,0.7725032f,-0.6012564f,0.3834146f,-0.2641961f,0.6493724f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448977f,1.365104f,0.7840981f,-0.7102045f,0.009184411f,0.02383542f,0.703532f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.401995f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 7.543946f);
Get(0xFA26).SetLocalPose(1.394487f,1.293776f,0.7725697f,-0.6005792f,0.3920138f,-0.2772282f,0.6393546f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448961f,1.364973f,0.7840169f,-0.710175f,0.009219138f,0.02383596f,0.7035612f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.455067f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 7.561194f);
Get(0xFA26).SetLocalPose(1.395143f,1.291994f,0.7722114f,-0.598514f,0.400783f,-0.2914877f,0.6294355f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448964f,1.36505f,0.7839578f,-0.710172f,0.009182768f,0.02387292f,0.7035635f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.505002f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 7.577424f);
Get(0xFA26).SetLocalPose(1.395715f,1.290602f,0.7721103f,-0.5953341f,0.4083534f,-0.3039684f,0.6216335f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449044f,1.364934f,0.7839161f,-0.7101846f,0.009159187f,0.02382434f,0.7035527f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.560099f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 7.59533f);
Get(0xFA26).SetLocalPose(1.396375f,1.289356f,0.7723805f,-0.5907819f,0.4162871f,-0.3162794f,0.6145318f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448921f,1.365023f,0.7838115f,-0.7101814f,0.009184629f,0.02384885f,0.7035548f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.609869f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 7.611505f);
Get(0xFA26).SetLocalPose(1.396483f,1.288473f,0.772836f,-0.5869831f,0.4219808f,-0.3244801f,0.6099965f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448969f,1.365007f,0.7838273f,-0.7101742f,0.009162376f,0.02383901f,0.7035627f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.65987f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 7.627756f);
Get(0xFA26).SetLocalPose(1.396082f,1.28774f,0.7726387f,-0.5840845f,0.4266029f,-0.3307656f,0.6061761f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449092f,1.364948f,0.7839361f,-0.7101917f,0.009168028f,0.02386297f,0.7035441f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.711947f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 7.644681f);
Get(0xFA26).SetLocalPose(1.396425f,1.287112f,0.7720873f,-0.5818522f,0.4300992f,-0.3359883f,0.6029716f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449195f,1.364992f,0.7839548f,-0.7101847f,0.009150687f,0.02386481f,0.7035514f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.766057f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 7.662266f);
Get(0xFA26).SetLocalPose(1.396573f,1.286174f,0.7720886f,-0.5798395f,0.4335207f,-0.3421784f,0.5989658f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449175f,1.364963f,0.7838922f,-0.7102016f,0.009154156f,0.02386828f,0.7035341f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.813847f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 7.677798f);
Get(0xFA26).SetLocalPose(1.39655f,1.284513f,0.7717767f,-0.5787898f,0.4351428f,-0.3454649f,0.5969147f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449274f,1.364972f,0.7839694f,-0.71021f,0.00916156f,0.02387411f,0.7035254f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.863079f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 7.693799f);
Get(0xFA26).SetLocalPose(1.396882f,1.284051f,0.7716053f,-0.5770656f,0.4374654f,-0.3492921f,0.5946549f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449431f,1.364951f,0.7841215f,-0.7101946f,0.009172136f,0.02385904f,0.7035413f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.913218f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 7.710093f);
Get(0xFA26).SetLocalPose(1.39719f,1.282519f,0.7718988f,-0.5751057f,0.4393568f,-0.3522189f,0.5934315f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449161f,1.365059f,0.7841903f,-0.7101942f,0.009170508f,0.02386932f,0.7035413f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.96497f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 7.726913f);
Get(0xFA26).SetLocalPose(1.396902f,1.281046f,0.7721037f,-0.5731132f,0.4411548f,-0.35499f,0.5923731f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449161f,1.365012f,0.7841082f,-0.7101842f,0.009162382f,0.02385882f,0.7035518f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.016006f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 7.743499f);
Get(0xFA26).SetLocalPose(1.397209f,1.280144f,0.7721663f,-0.5719906f,0.4423429f,-0.3572452f,0.5912152f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449246f,1.36512f,0.7842184f,-0.710191f,0.009171115f,0.02385371f,0.7035452f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.067611f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 7.760271f);
Get(0xFA26).SetLocalPose(1.397715f,1.280203f,0.7723076f,-0.5718704f,0.4427505f,-0.3589233f,0.5900087f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449275f,1.365213f,0.7842653f,-0.7101725f,0.009177154f,0.0238414f,0.7035641f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.120479f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 7.777453f);
Get(0xFA26).SetLocalPose(1.397708f,1.279442f,0.7720957f,-0.5719209f,0.4433611f,-0.3608547f,0.5883208f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449176f,1.365234f,0.784157f,-0.7101672f,0.009151167f,0.02386751f,0.7035689f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.173832f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 7.794793f);
Get(0xFA26).SetLocalPose(1.397973f,1.27814f,0.7724697f,-0.5704677f,0.4450434f,-0.3634078f,0.5868883f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449356f,1.365155f,0.7841604f,-0.710199f,0.009096652f,0.02386812f,0.7035375f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.228562f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 7.812581f);
Get(0xFA26).SetLocalPose(1.397985f,1.278175f,0.7724541f,-0.5670219f,0.4482391f,-0.3677861f,0.5850652f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449474f,1.365346f,0.7840399f,-0.71021f,0.009120816f,0.02390616f,0.7035249f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.281493f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 7.829783f);
Get(0xFA26).SetLocalPose(1.398583f,1.277163f,0.7728503f,-0.5641232f,0.4505779f,-0.3711529f,0.5839436f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449584f,1.365284f,0.7839633f,-0.7101946f,0.009111854f,0.02389394f,0.703541f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.334932f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 7.84715f);
Get(0xFA26).SetLocalPose(1.39947f,1.276519f,0.7734497f,-0.5620863f,0.4523867f,-0.3743545f,0.5824636f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449663f,1.365272f,0.7840139f,-0.7101963f,0.009080119f,0.02389057f,0.7035396f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.388192f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 7.86446f);
Get(0xFA26).SetLocalPose(1.400271f,1.276479f,0.7742372f,-0.5600158f,0.4543148f,-0.3778639f,0.5806886f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449785f,1.365337f,0.7840494f,-0.7102024f,0.009074107f,0.02389038f,0.7035336f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.439972f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 7.881288f);
Get(0xFA26).SetLocalPose(1.400491f,1.276317f,0.7744815f,-0.5586817f,0.4556092f,-0.3802811f,0.5793802f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449753f,1.365387f,0.7839809f,-0.7101771f,0.009135533f,0.02387071f,0.703559f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.492378f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 7.89832f);
Get(0xFA26).SetLocalPose(1.400579f,1.274907f,0.775456f,-0.5552753f,0.4589265f,-0.385231f,0.5767608f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449722f,1.365357f,0.7841219f,-0.7101771f,0.009122765f,0.023901f,0.7035582f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.521103f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 7.907655f);
Get(0xFA26).SetLocalPose(1.400075f,1.273997f,0.7755946f,-0.5527744f,0.4614958f,-0.388507f,0.5749125f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449716f,1.365165f,0.7840759f,-0.7101711f,0.009125998f,0.0238878f,0.7035647f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.577286f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 7.925915f);
Get(0xFA26).SetLocalPose(1.400146f,1.273104f,0.775433f,-0.549432f,0.4652624f,-0.3931076f,0.5719457f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449481f,1.364981f,0.7840429f,-0.7101703f,0.009122605f,0.0238624f,0.7035663f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.629511f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 7.942888f);
Get(0xFA26).SetLocalPose(1.399598f,1.272432f,0.7757285f,-0.5468572f,0.4690559f,-0.3979163f,0.5679758f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449524f,1.365018f,0.784128f,-0.7101882f,0.009096416f,0.02386371f,0.7035487f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.683393f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 7.9604f);
Get(0xFA26).SetLocalPose(1.399352f,1.271174f,0.775678f,-0.5444773f,0.4737355f,-0.403548f,0.5623774f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449492f,1.364954f,0.7841768f,-0.7101843f,0.009141035f,0.02388126f,0.7035513f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.733158f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 7.976574f);
Get(0xFA26).SetLocalPose(1.3991f,1.270525f,0.7754552f,-0.5423665f,0.4781023f,-0.4091046f,0.5566779f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449403f,1.364882f,0.7842075f,-0.710197f,0.009145479f,0.02384683f,0.7035396f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.784525f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 7.993268f);
Get(0xFA26).SetLocalPose(1.39888f,1.269302f,0.7755043f,-0.5395797f,0.4821298f,-0.4151016f,0.5514484f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449217f,1.364935f,0.7841698f,-0.7101855f,0.009137573f,0.0238642f,0.7035507f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.839185f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 8.011033f);
Get(0xFA26).SetLocalPose(1.399114f,1.268367f,0.7752426f,-0.5372909f,0.4846403f,-0.4191186f,0.5484359f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449015f,1.365124f,0.7840427f,-0.7101858f,0.00913562f,0.02384937f,0.7035509f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.893719f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 8.028757f);
Get(0xFA26).SetLocalPose(1.399218f,1.267309f,0.7751646f,-0.5340133f,0.4869721f,-0.4225883f,0.546907f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449057f,1.365197f,0.7840475f,-0.7102098f,0.009136823f,0.02384224f,0.7035269f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.94735f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 8.046187f);
Get(0xFA26).SetLocalPose(1.3994f,1.266248f,0.77541f,-0.5302758f,0.4889965f,-0.4250805f,0.5468057f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448985f,1.365106f,0.784108f,-0.7102025f,0.009160674f,0.02384558f,0.7035339f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 7.000392f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 8.063426f);
Get(0xFA26).SetLocalPose(1.399197f,1.266304f,0.7761938f,-0.5260738f,0.4907417f,-0.4272664f,0.547597f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449006f,1.365076f,0.7841167f,-0.7101916f,0.009131733f,0.02383351f,0.7035457f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 7.053659f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 8.080738f);
Get(0xFA26).SetLocalPose(1.399527f,1.266412f,0.776413f,-0.5217867f,0.4918844f,-0.4289513f,0.5493536f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449012f,1.365171f,0.7842104f,-0.7102126f,0.009140419f,0.02383244f,0.7035245f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 7.103017f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 8.09678f);
Get(0xFA26).SetLocalPose(1.39987f,1.266325f,0.7771981f,-0.5186328f,0.4927246f,-0.4300916f,0.5506938f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449085f,1.365039f,0.7842447f,-0.7102072f,0.009176023f,0.02381783f,0.7035298f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 8.113753f);
Get(0xFA26).SetLocalPose(1.399937f,1.266731f,0.777459f,-0.5129794f,0.4932537f,-0.4317513f,0.5542055f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449103f,1.365151f,0.7842903f,-0.7102098f,0.009158324f,0.02381736f,0.7035275f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.05181108f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 8.130591f);
Get(0xFA26).SetLocalPose(1.399909f,1.266534f,0.7776398f,-0.508332f,0.4938207f,-0.4329302f,0.5570558f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44914f,1.364997f,0.7843655f,-0.7102123f,0.009191328f,0.02381032f,0.7035248f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.1030385f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 8.14724f);
Get(0xFA26).SetLocalPose(1.399901f,1.266833f,0.7784803f,-0.5043284f,0.4947447f,-0.433311f,0.5595732f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449037f,1.365026f,0.7842674f,-0.7101957f,0.009214294f,0.02381048f,0.7035413f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.1563692f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 8.164572f);
Get(0xFA26).SetLocalPose(1.400378f,1.266428f,0.7784032f,-0.5008218f,0.4957549f,-0.4333836f,0.561768f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448872f,1.364946f,0.784155f,-0.7102041f,0.009217291f,0.02382401f,0.7035323f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.2053397f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 8.180488f);
Get(0xFA26).SetLocalPose(1.400473f,1.265059f,0.778584f,-0.4978969f,0.4966883f,-0.4349662f,0.5623201f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448943f,1.364865f,0.7841838f,-0.7101946f,0.009202135f,0.02382478f,0.7035421f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.2553905f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 8.196754f);
Get(0xFA26).SetLocalPose(1.40119f,1.265111f,0.7784731f,-0.4953409f,0.4976172f,-0.4368718f,0.5622789f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44891f,1.364765f,0.7841394f,-0.7101857f,0.009196138f,0.02382577f,0.7035511f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.3019578f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 8.211887f);
Get(0xFA26).SetLocalPose(1.401587f,1.264587f,0.7788833f,-0.4938502f,0.497225f,-0.4384618f,0.5626993f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44884f,1.364785f,0.7840618f,-0.7101913f,0.009199275f,0.02382776f,0.7035453f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.3523966f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 8.22828f);
Get(0xFA26).SetLocalPose(1.402276f,1.264076f,0.7794164f,-0.4930232f,0.4973988f,-0.4408841f,0.5613768f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449021f,1.3648f,0.7840152f,-0.7101905f,0.009162097f,0.023837f,0.7035462f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.4026954f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 8.244627f);
Get(0xFA26).SetLocalPose(1.403427f,1.263516f,0.7799439f,-0.493587f,0.4972916f,-0.4429887f,0.5593156f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449013f,1.3648f,0.7838738f,-0.7101864f,0.009158012f,0.02386568f,0.7035495f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.4551406f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 8.261672f);
Get(0xFA26).SetLocalPose(1.403693f,1.262419f,0.7799129f,-0.4950859f,0.496894f,-0.4459977f,0.5559427f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449125f,1.364932f,0.7839575f,-0.7101865f,0.009164098f,0.02384543f,0.70355f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.5051246f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 8.277917f);
Get(0xFA26).SetLocalPose(1.404078f,1.261805f,0.7808339f,-0.4986416f,0.4963312f,-0.4488015f,0.5509892f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449126f,1.364924f,0.7839441f,-0.7101816f,0.009154757f,0.02383307f,0.7035556f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.5292609f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 8.285761f);
Get(0xFA26).SetLocalPose(1.404535f,1.261425f,0.7811096f,-0.5007343f,0.496186f,-0.4498562f,0.5483558f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449362f,1.364902f,0.7842216f,-0.7102221f,0.009113694f,0.02385717f,0.7035143f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.6111065f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 8.312361f);
Get(0xFA26).SetLocalPose(1.404359f,1.259853f,0.7814687f,-0.5094866f,0.4966843f,-0.4528814f,0.5372398f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449403f,1.364994f,0.7842935f,-0.7102118f,0.009110237f,0.02386282f,0.7035247f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.6641378f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 8.329596f);
Get(0xFA26).SetLocalPose(1.404187f,1.258542f,0.7811821f,-0.5157886f,0.4979835f,-0.4557797f,0.5274841f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449364f,1.365057f,0.7842871f,-0.7102097f,0.009151832f,0.02385163f,0.7035264f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.7179f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 8.347069f);
Get(0xFA26).SetLocalPose(1.403057f,1.255935f,0.7818149f,-0.5209491f,0.4991517f,-0.4580023f,0.5193202f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44932f,1.364946f,0.7843195f,-0.7102086f,0.009128633f,0.02385179f,0.7035279f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.7711639f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 8.36438f);
Get(0xFA26).SetLocalPose(1.402361f,1.253159f,0.7824217f,-0.5263482f,0.500473f,-0.4593219f,0.5113783f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449383f,1.364985f,0.7842386f,-0.7101986f,0.009147926f,0.02383698f,0.7035382f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.8271689f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 8.382582f);
Get(0xFA26).SetLocalPose(1.401885f,1.251622f,0.782117f,-0.5309505f,0.5010189f,-0.4596697f,0.5057424f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44945f,1.364869f,0.7841835f,-0.710208f,0.009152107f,0.02384271f,0.7035286f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.8519966f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 8.390651f);
Get(0xFA26).SetLocalPose(1.401863f,1.251112f,0.7822645f,-0.532961f,0.5006849f,-0.4592984f,0.5042937f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449404f,1.364952f,0.7841314f,-0.7102066f,0.009159007f,0.02381752f,0.7035307f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.906267f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 8.408289f);
Get(0xFA26).SetLocalPose(1.401818f,1.250273f,0.7824922f,-0.5369062f,0.4992757f,-0.4580196f,0.5026666f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44922f,1.364942f,0.7844046f,-0.7102137f,0.009170612f,0.02380706f,0.7035237f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.9600837f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 8.425779f);
Get(0xFA26).SetLocalPose(1.402323f,1.248586f,0.7821504f,-0.5421287f,0.4970042f,-0.4562598f,0.5009095f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449238f,1.364898f,0.7844275f,-0.7102177f,0.009140119f,0.02383252f,0.7035193f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.011615f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 8.442527f);
Get(0xFA26).SetLocalPose(1.402921f,1.247612f,0.7828875f,-0.5449879f,0.495625f,-0.4552616f,0.5000809f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449243f,1.36498f,0.7845604f,-0.7102506f,0.009120408f,0.02381619f,0.7034869f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.084105f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 8.466086f);
Get(0xFA26).SetLocalPose(1.402908f,1.246519f,0.7842638f,-0.5429465f,0.4963884f,-0.4560961f,0.5007834f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449366f,1.365037f,0.7846851f,-0.7102576f,0.00910892f,0.02382152f,0.7034797f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.10991f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 8.474473f);
Get(0xFA26).SetLocalPose(1.40309f,1.246186f,0.7845311f,-0.5417042f,0.4967493f,-0.4563285f,0.5015586f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449546f,1.365064f,0.7845747f,-0.7102387f,0.009129625f,0.02380399f,0.7034993f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.168465f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 8.493503f);
Get(0xFA26).SetLocalPose(1.402676f,1.244774f,0.7850203f,-0.5398924f,0.4960915f,-0.4563683f,0.5041206f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449527f,1.365076f,0.7844769f,-0.710244f,0.009120692f,0.0238177f,0.7034934f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.221742f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 8.510818f);
Get(0xFA26).SetLocalPose(1.403162f,1.243525f,0.7848588f,-0.5397881f,0.4947664f,-0.4557204f,0.5061164f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449405f,1.365098f,0.784389f,-0.7102263f,0.009147153f,0.02383043f,0.7035106f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.274042f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 8.527815f);
Get(0xFA26).SetLocalPose(1.40393f,1.242172f,0.7843949f,-0.5403722f,0.4930468f,-0.454957f,0.5078552f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449298f,1.365108f,0.7843725f,-0.7102156f,0.00914426f,0.02382318f,0.7035216f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.326968f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 8.545016f);
Get(0xFA26).SetLocalPose(1.403901f,1.241764f,0.7845934f,-0.5404559f,0.4924111f,-0.4548186f,0.5085064f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449327f,1.365062f,0.7844169f,-0.7102345f,0.009127015f,0.02383139f,0.7035026f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.380255f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 8.562334f);
Get(0xFA26).SetLocalPose(1.403623f,1.242161f,0.7849175f,-0.5394576f,0.4929027f,-0.4554224f,0.5085498f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449316f,1.365019f,0.7844329f,-0.7102407f,0.009146803f,0.02384295f,0.7034956f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.433953f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 8.579785f);
Get(0xFA26).SetLocalPose(1.403794f,1.241104f,0.7850105f,-0.5382114f,0.4935062f,-0.456237f,0.5085548f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449421f,1.365021f,0.7844748f,-0.7102419f,0.009145498f,0.0238368f,0.7034947f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.488699f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 8.597578f);
Get(0xFA26).SetLocalPose(1.404182f,1.24051f,0.7845684f,-0.5381297f,0.4933217f,-0.4562773f,0.5087841f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449392f,1.365014f,0.7842904f,-0.7102355f,0.00909315f,0.02386592f,0.7035008f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.542615f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 8.615101f);
Get(0xFA26).SetLocalPose(1.404898f,1.239793f,0.7846885f,-0.5388684f,0.4926067f,-0.4555735f,0.5093254f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449347f,1.365082f,0.7841905f,-0.7102174f,0.009142855f,0.02383742f,0.7035194f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.596176f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 8.632508f);
Get(0xFA26).SetLocalPose(1.40462f,1.23962f,0.7845488f,-0.5395231f,0.4923705f,-0.4551661f,0.509225f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449321f,1.365081f,0.7840614f,-0.7102134f,0.009129293f,0.02384098f,0.7035235f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.622612f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 8.6411f);
Get(0xFA26).SetLocalPose(1.404643f,1.239474f,0.7844774f,-0.5397138f,0.4925462f,-0.4551133f,0.5089f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449193f,1.365008f,0.7842171f,-0.7102098f,0.009134192f,0.02382582f,0.7035276f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.6778f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 8.659037f);
Get(0xFA26).SetLocalPose(1.403758f,1.239004f,0.7849605f,-0.5394003f,0.4934733f,-0.4552522f,0.5082095f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449205f,1.36496f,0.7841157f,-0.7101833f,0.009146833f,0.02383837f,0.7035537f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.731104f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 8.67636f);
Get(0xFA26).SetLocalPose(1.403393f,1.238527f,0.7846046f,-0.5389482f,0.4941477f,-0.4552827f,0.5080065f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449223f,1.365034f,0.7841694f,-0.710192f,0.009140277f,0.02385012f,0.7035446f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.784053f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 8.693568f);
Get(0xFA26).SetLocalPose(1.403641f,1.2386f,0.7849738f,-0.5386704f,0.4943192f,-0.4549384f,0.5084426f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449213f,1.365036f,0.7842037f,-0.7102039f,0.009146974f,0.02385715f,0.7035323f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.833652f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 8.709687f);
Get(0xFA26).SetLocalPose(1.40372f,1.239766f,0.7852479f,-0.53861f,0.4941647f,-0.4547185f,0.5088533f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449207f,1.364947f,0.7841603f,-0.7102005f,0.009143358f,0.02386192f,0.7035356f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.884528f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 8.726222f);
Get(0xFA26).SetLocalPose(1.403704f,1.24024f,0.7857224f,-0.5386367f,0.4942069f,-0.4544882f,0.5089898f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449227f,1.364878f,0.784109f,-0.7102002f,0.009125071f,0.02384434f,0.7035367f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.937587f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 8.743466f);
Get(0xFA26).SetLocalPose(1.403674f,1.241497f,0.7859761f,-0.5388529f,0.4945196f,-0.4543704f,0.5085622f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449237f,1.364951f,0.7842072f,-0.7101914f,0.009178899f,0.02383102f,0.7035453f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.985788f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 8.759131f);
Get(0xFA26).SetLocalPose(1.403693f,1.242058f,0.7858177f,-0.5389382f,0.4947482f,-0.454361f,0.5082578f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449217f,1.365075f,0.7842406f,-0.7101912f,0.00916963f,0.02382198f,0.7035459f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.039183f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 8.776484f);
Get(0xFA26).SetLocalPose(1.403166f,1.242891f,0.785754f,-0.5385228f,0.4951632f,-0.4543157f,0.5083345f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449136f,1.364985f,0.7841089f,-0.7101812f,0.009181628f,0.02384667f,0.7035551f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.092549f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 8.793828f);
Get(0xFA26).SetLocalPose(1.402787f,1.243919f,0.7858848f,-0.5382662f,0.4953014f,-0.4542036f,0.5085716f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449039f,1.364991f,0.7840298f,-0.7101939f,0.009162528f,0.02384834f,0.7035425f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.141777f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 8.809828f);
Get(0xFA26).SetLocalPose(1.40249f,1.243641f,0.7859823f,-0.538251f,0.4954193f,-0.4538522f,0.5087866f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449024f,1.364905f,0.7840767f,-0.7101977f,0.00918632f,0.0238599f,0.7035379f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.195545f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 8.827303f);
Get(0xFA26).SetLocalPose(1.402533f,1.243322f,0.7862287f,-0.5382202f,0.4957247f,-0.4535015f,0.5088344f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449131f,1.365068f,0.7839924f,-0.7101872f,0.009164651f,0.02387374f,0.7035483f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.2475f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 8.844189f);
Get(0xFA26).SetLocalPose(1.402368f,1.243424f,0.7859804f,-0.5379024f,0.4964809f,-0.4529643f,0.5089117f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449182f,1.365008f,0.7840638f,-0.7102041f,0.009198068f,0.02385197f,0.7035316f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.29986f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 8.861206f);
Get(0xFA26).SetLocalPose(1.402135f,1.243517f,0.7854357f,-0.5371531f,0.497683f,-0.4526823f,0.5087798f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449283f,1.364905f,0.7842255f,-0.71022f,0.009189651f,0.02384225f,0.7035159f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.350495f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 8.877663f);
Get(0xFA26).SetLocalPose(1.402445f,1.244541f,0.7850825f,-0.5364918f,0.4985468f,-0.4525082f,0.5087868f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449258f,1.364837f,0.7842831f,-0.7102453f,0.009139735f,0.02383312f,0.7034913f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.402269f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 8.894489f);
Get(0xFA26).SetLocalPose(1.402392f,1.246455f,0.7844853f,-0.5362806f,0.4988648f,-0.4518636f,0.5092704f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449219f,1.364866f,0.7844008f,-0.7102292f,0.009136622f,0.0238484f,0.7035072f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.452674f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 8.910872f);
Get(0xFA26).SetLocalPose(1.402172f,1.247297f,0.7840129f,-0.5364007f,0.4990121f,-0.4509933f,0.5097709f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44918f,1.364853f,0.7843666f,-0.7102038f,0.009171026f,0.02382713f,0.7035331f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.501091f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 8.926607f);
Get(0xFA26).SetLocalPose(1.402063f,1.248315f,0.7844027f,-0.5366663f,0.4993135f,-0.4500285f,0.5100486f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449176f,1.364741f,0.78436f,-0.7102215f,0.009183025f,0.02381922f,0.7035153f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.550735f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 8.94274f);
Get(0xFA26).SetLocalPose(1.401502f,1.249516f,0.7843887f,-0.5364578f,0.5001118f,-0.4492021f,0.5102144f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449125f,1.364829f,0.7843944f,-0.710227f,0.009152557f,0.02381493f,0.7035103f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.601929f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 8.959379f);
Get(0xFA26).SetLocalPose(1.401052f,1.249838f,0.7844429f,-0.5358895f,0.5010609f,-0.4483513f,0.5106285f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449197f,1.364749f,0.7842905f,-0.7102241f,0.009174177f,0.02380742f,0.7035132f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.672118f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 8.982191f);
Get(0xFA26).SetLocalPose(1.400096f,1.251461f,0.7845255f,-0.5347803f,0.5023891f,-0.4466158f,0.5120054f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449125f,1.364729f,0.7843117f,-0.7102302f,0.009157772f,0.02381908f,0.7035069f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.720309f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 8.997853f);
Get(0xFA26).SetLocalPose(1.400147f,1.252202f,0.7850181f,-0.5339155f,0.5030804f,-0.4455526f,0.5131543f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449034f,1.364728f,0.7842299f,-0.7102231f,0.009178048f,0.02380481f,0.7035143f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.768627f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 9.013556f);
Get(0xFA26).SetLocalPose(1.399921f,1.252755f,0.7847704f,-0.5333837f,0.5033834f,-0.4448462f,0.5140223f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449044f,1.364798f,0.7843459f,-0.710234f,0.009206379f,0.02381691f,0.7035024f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.821468f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 9.030729f);
Get(0xFA26).SetLocalPose(1.399167f,1.253735f,0.7847718f,-0.5327736f,0.5038121f,-0.4431506f,0.5156968f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448979f,1.364879f,0.7843489f,-0.7102486f,0.009195626f,0.0237837f,0.7034889f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.875575f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 9.048314f);
Get(0xFA26).SetLocalPose(1.398433f,1.253801f,0.7851836f,-0.5326207f,0.5042223f,-0.4420958f,0.5163589f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449022f,1.364846f,0.7843771f,-0.7102532f,0.009172843f,0.02379712f,0.7034842f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.926574f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 9.064889f);
Get(0xFA26).SetLocalPose(1.398029f,1.253405f,0.7852826f,-0.5319278f,0.5050418f,-0.4411173f,0.5171083f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449149f,1.364918f,0.7844458f,-0.7102531f,0.009164146f,0.02380792f,0.7034841f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.976921f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 9.081252f);
Get(0xFA26).SetLocalPose(1.397878f,1.254045f,0.7848684f,-0.5304961f,0.506255f,-0.4401107f,0.5182495f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449213f,1.36507f,0.7846013f,-0.710242f,0.009146374f,0.0238564f,0.7034938f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.026405f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 9.097334f);
Get(0xFA26).SetLocalPose(1.397851f,1.253701f,0.7854108f,-0.529376f,0.5071206f,-0.4389619f,0.5195212f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449216f,1.36512f,0.7845742f,-0.7102408f,0.009153082f,0.02385687f,0.7034949f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.075299f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 9.113224f);
Get(0xFA26).SetLocalPose(1.39756f,1.25375f,0.7854071f,-0.5289166f,0.5075515f,-0.4378372f,0.5205165f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449246f,1.365007f,0.7844357f,-0.7102377f,0.009135673f,0.0238468f,0.7034987f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.125979f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 9.129696f);
Get(0xFA26).SetLocalPose(1.397312f,1.254218f,0.7861782f,-0.5291744f,0.5077834f,-0.4364183f,0.5212194f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449267f,1.365021f,0.7844141f,-0.7102415f,0.009120737f,0.02384059f,0.7034952f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.175381f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 9.145751f);
Get(0xFA26).SetLocalPose(1.396759f,1.253093f,0.7858369f,-0.5297526f,0.5080124f,-0.4350661f,0.5215394f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449475f,1.36502f,0.7844548f,-0.7102363f,0.009089475f,0.0238581f,0.7035003f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.224467f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 9.161704f);
Get(0xFA26).SetLocalPose(1.396034f,1.25329f,0.7860614f,-0.5297785f,0.5084912f,-0.4342979f,0.5216866f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.4495f,1.365061f,0.784364f,-0.7102205f,0.009111701f,0.02386967f,0.7035156f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.273558f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 9.177658f);
Get(0xFA26).SetLocalPose(1.395486f,1.254033f,0.7859065f,-0.5295287f,0.5090056f,-0.4338677f,0.5217966f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449526f,1.365129f,0.7841644f,-0.7102035f,0.009118201f,0.0238448f,0.7035335f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.322281f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 9.193493f);
Get(0xFA26).SetLocalPose(1.395253f,1.254738f,0.7856439f,-0.5294982f,0.5094247f,-0.4335405f,0.5216904f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449522f,1.365115f,0.7842541f,-0.7102233f,0.00911065f,0.02385045f,0.7035134f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.371931f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 9.209629f);
Get(0xFA26).SetLocalPose(1.394855f,1.254269f,0.7856141f,-0.5297686f,0.5096116f,-0.4332409f,0.5214822f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44946f,1.365187f,0.7841837f,-0.7102255f,0.009126194f,0.02384234f,0.7035112f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.421902f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 9.225869f);
Get(0xFA26).SetLocalPose(1.394905f,1.254332f,0.7855933f,-0.5305393f,0.5095781f,-0.4327655f,0.521126f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449512f,1.365126f,0.7842844f,-0.7102113f,0.009151621f,0.02382231f,0.703526f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.473669f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 9.242693f);
Get(0xFA26).SetLocalPose(1.394626f,1.253968f,0.7854724f,-0.5314888f,0.5095153f,-0.431927f,0.5209155f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449388f,1.365089f,0.7842324f,-0.7102053f,0.009163178f,0.02380874f,0.7035322f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.523305f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 9.258824f);
Get(0xFA26).SetLocalPose(1.394514f,1.253842f,0.7850072f,-0.5320336f,0.5093634f,-0.4313353f,0.5209982f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449491f,1.364832f,0.7842898f,-0.7102154f,0.009141393f,0.02384033f,0.7035214f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.595876f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 9.28241f);
Get(0xFA26).SetLocalPose(1.394836f,1.253584f,0.7856732f,-0.5325346f,0.5093488f,-0.4304984f,0.5211927f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44941f,1.364848f,0.7842661f,-0.7102038f,0.009111156f,0.02381211f,0.7035344f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.620989f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 9.290571f);
Get(0xFA26).SetLocalPose(1.394529f,1.253498f,0.7863134f,-0.532637f,0.5093614f,-0.4302034f,0.5213193f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44925f,1.36494f,0.7842162f,-0.7101972f,0.009119276f,0.02383769f,0.7035401f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.677018f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 9.308781f);
Get(0xFA26).SetLocalPose(1.394315f,1.252957f,0.7863412f,-0.5330327f,0.5090813f,-0.429607f,0.5216802f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449162f,1.364983f,0.7841114f,-0.7101919f,0.009112452f,0.02382228f,0.703546f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.732027f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 9.326658f);
Get(0xFA26).SetLocalPose(1.394393f,1.252017f,0.7874606f,-0.5337755f,0.508544f,-0.4288197f,0.5220925f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449136f,1.364864f,0.7841085f,-0.7101728f,0.009134329f,0.02384333f,0.7035642f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.787163f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 9.344578f);
Get(0xFA26).SetLocalPose(1.394693f,1.251855f,0.7873096f,-0.5339778f,0.5085143f,-0.4284711f,0.5222006f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449326f,1.364977f,0.784007f,-0.710166f,0.00916102f,0.02384608f,0.7035707f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.840157f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 9.361801f);
Get(0xFA26).SetLocalPose(1.394542f,1.252253f,0.7868953f,-0.5338455f,0.5087198f,-0.4284095f,0.5221864f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449188f,1.364875f,0.7840521f,-0.7101671f,0.009166962f,0.02385753f,0.7035692f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.892223f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 9.378723f);
Get(0xFA26).SetLocalPose(1.394397f,1.251934f,0.7868139f,-0.533673f,0.5088839f,-0.4283964f,0.5222134f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449283f,1.364921f,0.7840015f,-0.7101691f,0.009156099f,0.02386735f,0.703567f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.949837f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 9.397448f);
Get(0xFA26).SetLocalPose(1.394451f,1.253256f,0.7865533f,-0.5334111f,0.5090659f,-0.4282815f,0.5223978f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449136f,1.364934f,0.7839537f,-0.7101456f,0.009179992f,0.02386716f,0.7035904f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.00114f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 9.414121f);
Get(0xFA26).SetLocalPose(1.394447f,1.252395f,0.7868121f,-0.5333671f,0.5091341f,-0.4280066f,0.5226016f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449059f,1.365002f,0.7839172f,-0.7101631f,0.009174182f,0.02385001f,0.7035734f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.053707f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 9.431204f);
Get(0xFA26).SetLocalPose(1.394589f,1.252134f,0.7867991f,-0.5331809f,0.5093775f,-0.4278107f,0.5227147f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448989f,1.365095f,0.7838919f,-0.7101647f,0.009199493f,0.02382345f,0.7035724f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.107676f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 9.448744f);
Get(0xFA26).SetLocalPose(1.3944f,1.253642f,0.786312f,-0.5330074f,0.5095572f,-0.4276847f,0.5228196f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449044f,1.364901f,0.7839954f,-0.7101548f,0.009211618f,0.02387084f,0.7035805f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.162179f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 9.466457f);
Get(0xFA26).SetLocalPose(1.394166f,1.254559f,0.7861155f,-0.5327129f,0.5098643f,-0.4278188f,0.5227107f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449028f,1.364899f,0.7839896f,-0.7101659f,0.009227215f,0.02381559f,0.703571f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.186971f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 9.474515f);
Get(0xFA26).SetLocalPose(1.394125f,1.254078f,0.7863571f,-0.532615f,0.5099912f,-0.4278794f,0.522637f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448853f,1.365025f,0.7837224f,-0.7101499f,0.009224497f,0.02383664f,0.7035865f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.245112f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 9.493411f);
Get(0xFA26).SetLocalPose(1.394064f,1.253961f,0.7868344f,-0.5324778f,0.5102369f,-0.4279584f,0.5224723f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448849f,1.365136f,0.7836555f,-0.7101711f,0.009205787f,0.02380818f,0.7035663f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.299363f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 9.511043f);
Get(0xFA26).SetLocalPose(1.394122f,1.254185f,0.786973f,-0.5324236f,0.5104925f,-0.4279848f,0.5222564f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448921f,1.36492f,0.78373f,-0.7101762f,0.009189538f,0.02381695f,0.703561f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.351909f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 9.52812f);
Get(0xFA26).SetLocalPose(1.393924f,1.255206f,0.786533f,-0.5323014f,0.5107929f,-0.4281493f,0.5219523f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448985f,1.364959f,0.7837563f,-0.7101916f,0.009171295f,0.02382943f,0.7035453f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.406479f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 9.545856f);
Get(0xFA26).SetLocalPose(1.393718f,1.255185f,0.786202f,-0.5321359f,0.5110211f,-0.4281989f,0.5218568f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44912f,1.364983f,0.7841149f,-0.7101989f,0.009140437f,0.02384836f,0.7035378f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.465516f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 9.565042f);
Get(0xFA26).SetLocalPose(1.393695f,1.255413f,0.7863503f,-0.5321476f,0.5111607f,-0.4281354f,0.5217603f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449078f,1.365034f,0.7841721f,-0.7101975f,0.009159831f,0.02386459f,0.7035383f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.493074f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 9.573998f);
Get(0xFA26).SetLocalPose(1.393795f,1.255651f,0.7864947f,-0.5320758f,0.5112987f,-0.4281246f,0.5217072f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449223f,1.364959f,0.7841814f,-0.7101983f,0.009158911f,0.02389685f,0.7035365f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.561954f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 9.596384f);
Get(0xFA26).SetLocalPose(1.393637f,1.255994f,0.786418f,-0.5318787f,0.5115975f,-0.4281366f,0.5216054f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44935f,1.364915f,0.7842366f,-0.7102245f,0.009126496f,0.02389035f,0.7035106f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.590751f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 9.605743f);
Get(0xFA26).SetLocalPose(1.393752f,1.256071f,0.7868605f,-0.53193f,0.5116045f,-0.4280468f,0.5216197f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449355f,1.364925f,0.7843398f,-0.710227f,0.009128559f,0.02389487f,0.7035079f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.658901f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 9.627892f);
Get(0xFA26).SetLocalPose(1.393145f,1.256499f,0.7869059f,-0.5320386f,0.5114711f,-0.4278848f,0.5217729f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449368f,1.365076f,0.7842569f,-0.7102038f,0.009157821f,0.02386934f,0.7035317f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.721321f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 9.648179f);
Get(0xFA26).SetLocalPose(1.392956f,1.256638f,0.786883f,-0.5319824f,0.5115622f,-0.4277598f,0.5218434f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449276f,1.365054f,0.7841803f,-0.7102038f,0.009154234f,0.02388064f,0.7035315f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.750249f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 9.65758f);
Get(0xFA26).SetLocalPose(1.392845f,1.256952f,0.786697f,-0.5318193f,0.5117595f,-0.4278197f,0.521767f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449384f,1.364998f,0.7841035f,-0.7102031f,0.009135371f,0.02385746f,0.7035333f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.820083f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 9.680277f);
Get(0xFA26).SetLocalPose(1.392827f,1.256933f,0.7865587f,-0.5319011f,0.5118957f,-0.4277075f,0.521642f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449286f,1.365178f,0.7841469f,-0.710195f,0.009172429f,0.02386432f,0.7035407f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.88045f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 9.699896f);
Get(0xFA26).SetLocalPose(1.392674f,1.256936f,0.7864552f,-0.5325859f,0.5115854f,-0.4271775f,0.5216818f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449342f,1.365158f,0.7841886f,-0.7102086f,0.009146557f,0.02385009f,0.7035278f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.907085f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 9.708552f);
Get(0xFA26).SetLocalPose(1.392638f,1.256432f,0.7865413f,-0.5329169f,0.5113481f,-0.4269202f,0.5217872f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449482f,1.365118f,0.7842405f,-0.7102032f,0.009147433f,0.0238655f,0.7035327f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.969712f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 9.728906f);
Get(0xFA26).SetLocalPose(1.391608f,1.257177f,0.7862935f,-0.5330492f,0.511197f,-0.4269405f,0.5217835f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449495f,1.365023f,0.7842548f,-0.7102222f,0.009162891f,0.02386658f,0.7035133f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.028281f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 9.74794f);
Get(0xFA26).SetLocalPose(1.391141f,1.257154f,0.7862936f,-0.5324015f,0.5115313f,-0.4273731f,0.5217631f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449572f,1.364997f,0.784362f,-0.7102423f,0.009150757f,0.02385172f,0.7034938f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.055708f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 9.756854f);
Get(0xFA26).SetLocalPose(1.391046f,1.257331f,0.7863536f,-0.5318975f,0.5119247f,-0.4277195f,0.5216074f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449443f,1.364865f,0.7843703f,-0.7102627f,0.009105541f,0.02383009f,0.7034744f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.118977f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 9.777416f);
Get(0xFA26).SetLocalPose(1.391705f,1.257394f,0.7866576f,-0.531365f,0.5124583f,-0.4280427f,0.521361f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449444f,1.364846f,0.784408f,-0.7102328f,0.009139171f,0.02386589f,0.7035029f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.182446f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 9.798044f);
Get(0xFA26).SetLocalPose(1.392049f,1.257046f,0.786846f,-0.5314299f,0.5124865f,-0.4280601f,0.5212528f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449306f,1.364929f,0.7842911f,-0.7102083f,0.00916783f,0.02385286f,0.7035277f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.212157f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 9.8077f);
Get(0xFA26).SetLocalPose(1.392346f,1.257134f,0.7869917f,-0.5317493f,0.5122406f,-0.4278551f,0.5213372f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449306f,1.36493f,0.7844086f,-0.7102311f,0.009144507f,0.02384641f,0.7035052f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.275367f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 9.828244f);
Get(0xFA26).SetLocalPose(1.39235f,1.257885f,0.7870705f,-0.5320424f,0.5119951f,-0.4277075f,0.5214003f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449245f,1.364982f,0.7843839f,-0.7102215f,0.00915201f,0.02385461f,0.7035146f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.33506f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 9.847645f);
Get(0xFA26).SetLocalPose(1.392886f,1.25764f,0.7866651f,-0.5318202f,0.5120289f,-0.4279046f,0.521432f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449255f,1.365033f,0.784384f,-0.7102314f,0.009175058f,0.02382145f,0.7035053f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.363485f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 9.856883f);
Get(0xFA26).SetLocalPose(1.393073f,1.257958f,0.7865164f,-0.5312241f,0.5123099f,-0.4283468f,0.5214006f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449005f,1.365065f,0.7842584f,-0.710225f,0.009193063f,0.02379932f,0.7035123f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.425744f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 9.877117f);
Get(0xFA26).SetLocalPose(1.393891f,1.2581f,0.7865117f,-0.5306637f,0.5124674f,-0.4286523f,0.5215655f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44916f,1.364845f,0.7843093f,-0.7102378f,0.009206204f,0.02379779f,0.7034993f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.483858f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 9.896004f);
Get(0xFA26).SetLocalPose(1.393816f,1.258301f,0.7861397f,-0.5306557f,0.5122284f,-0.4286581f,0.5218035f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449088f,1.364931f,0.7842599f,-0.7102321f,0.009185719f,0.02382248f,0.7035045f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.542272f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 9.914988f);
Get(0xFA26).SetLocalPose(1.393886f,1.258357f,0.786101f,-0.5307105f,0.5120853f,-0.428643f,0.5219007f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449226f,1.365026f,0.7842054f,-0.7102123f,0.009154442f,0.02382655f,0.7035248f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.569561f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 9.923857f);
Get(0xFA26).SetLocalPose(1.394225f,1.258738f,0.7857888f,-0.5307385f,0.5120004f,-0.428679f,0.5219259f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449221f,1.365002f,0.78422f,-0.7102119f,0.009133235f,0.02385097f,0.7035246f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.633749f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 9.944718f);
Get(0xFA26).SetLocalPose(1.394705f,1.258928f,0.7853025f,-0.5301355f,0.5122163f,-0.4293573f,0.5217694f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449394f,1.365132f,0.7843068f,-0.7102047f,0.00913899f,0.02384118f,0.7035322f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.696251f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 9.965031f);
Get(0xFA26).SetLocalPose(1.395062f,1.258464f,0.784499f,-0.5290747f,0.5129351f,-0.4302016f,0.5214443f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449326f,1.365175f,0.7842478f,-0.7102026f,0.009140167f,0.02385563f,0.7035338f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.724473f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 9.974203f);
Get(0xFA26).SetLocalPose(1.39546f,1.258662f,0.7842162f,-0.5290172f,0.5129515f,-0.4304472f,0.521284f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449267f,1.365135f,0.7841973f,-0.7101985f,0.009147353f,0.02384764f,0.7035381f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.787934f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 9.994828f);
Get(0xFA26).SetLocalPose(1.395738f,1.258825f,0.7838232f,-0.5288612f,0.5129244f,-0.4309331f,0.5210673f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449226f,1.365101f,0.7842473f,-0.7102145f,0.009186625f,0.02384885f,0.7035214f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.846004f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 10.0137f);
Get(0xFA26).SetLocalPose(1.396235f,1.258393f,0.7838898f,-0.5283759f,0.5130538f,-0.4317811f,0.5207302f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449208f,1.364965f,0.7841348f,-0.7102145f,0.009165843f,0.02381862f,0.7035227f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.902414f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 10.03203f);
Get(0xFA26).SetLocalPose(1.396088f,1.258909f,0.7839633f,-0.5279519f,0.5132157f,-0.43218f,0.5206696f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449279f,1.36496f,0.7843024f,-0.7102361f,0.009163493f,0.02386264f,0.7034993f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.931441f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 10.04147f);
Get(0xFA26).SetLocalPose(1.395895f,1.258646f,0.7839999f,-0.5276062f,0.5133487f,-0.4323801f,0.520723f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449425f,1.364803f,0.784332f,-0.7102188f,0.009123934f,0.02386682f,0.7035171f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.993962f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 10.06179f);
Get(0xFA26).SetLocalPose(1.396118f,1.258342f,0.7835172f,-0.5270092f,0.5135893f,-0.4327138f,0.520813f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449377f,1.36485f,0.7842752f,-0.7102231f,0.009117732f,0.02387081f,0.7035128f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.050785f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 10.08026f);
Get(0xFA26).SetLocalPose(1.396489f,1.258931f,0.7836664f,-0.5266972f,0.5137779f,-0.4330274f,0.5206819f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449445f,1.36491f,0.7843196f,-0.7102112f,0.009114966f,0.0238691f,0.7035249f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.106977f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 10.09852f);
Get(0xFA26).SetLocalPose(1.396767f,1.258816f,0.783669f,-0.526804f,0.5137178f,-0.4333278f,0.5203832f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449451f,1.364974f,0.7842323f,-0.7102082f,0.009107748f,0.02387354f,0.7035279f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.134844f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 10.10758f);
Get(0xFA26).SetLocalPose(1.396829f,1.258792f,0.7835614f,-0.5268158f,0.5136881f,-0.4336716f,0.5201141f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449359f,1.36518f,0.784121f,-0.7101753f,0.009134712f,0.02388712f,0.7035604f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.194553f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 10.12698f);
Get(0xFA26).SetLocalPose(1.396672f,1.258904f,0.7837248f,-0.5269275f,0.5136854f,-0.4339586f,0.5197641f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449599f,1.365216f,0.7841585f,-0.7101804f,0.009116368f,0.02390213f,0.7035549f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.250218f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 10.14507f);
Get(0xFA26).SetLocalPose(1.397356f,1.259586f,0.7835835f,-0.5270105f,0.5136884f,-0.4340681f,0.5195854f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449539f,1.36522f,0.7841195f,-0.7101694f,0.009132293f,0.0238694f,0.7035668f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.306153f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 10.16325f);
Get(0xFA26).SetLocalPose(1.397539f,1.25969f,0.7830828f,-0.5269257f,0.5137367f,-0.4342114f,0.519504f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44957f,1.365216f,0.7840723f,-0.7101888f,0.009162396f,0.0238481f,0.7035476f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.366555f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 10.18288f);
Get(0xFA26).SetLocalPose(1.397501f,1.259344f,0.7827996f,-0.5264781f,0.513921f,-0.4347568f,0.5193192f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449656f,1.36517f,0.7841144f,-0.7102053f,0.009163686f,0.02385035f,0.7035308f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.392357f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 10.19127f);
Get(0xFA26).SetLocalPose(1.397289f,1.258911f,0.7822316f,-0.526397f,0.5138227f,-0.4350424f,0.5192596f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449518f,1.365073f,0.7841278f,-0.71021f,0.009104574f,0.02386246f,0.7035265f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.455248f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 10.21171f);
Get(0xFA26).SetLocalPose(1.397011f,1.259051f,0.7822843f,-0.5266851f,0.5135456f,-0.4352844f,0.5190388f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449547f,1.365063f,0.784193f,-0.7102193f,0.009085999f,0.02386782f,0.7035172f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.514145f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 10.23085f);
Get(0xFA26).SetLocalPose(1.397164f,1.259185f,0.7826279f,-0.5270593f,0.51337f,-0.4354889f,0.518661f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44952f,1.365123f,0.7842372f,-0.7102275f,0.009100997f,0.02386034f,0.703509f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.540841f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 10.23952f);
Get(0xFA26).SetLocalPose(1.397175f,1.259183f,0.7825809f,-0.5270341f,0.5134267f,-0.435535f,0.5185917f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449749f,1.365064f,0.7844095f,-0.7102469f,0.009042033f,0.0238678f,0.7034898f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.60321f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 10.2598f);
Get(0xFA26).SetLocalPose(1.396777f,1.257795f,0.7828771f,-0.5268975f,0.5138278f,-0.4357293f,0.5181699f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449628f,1.365051f,0.7844015f,-0.7102194f,0.009068596f,0.02386102f,0.7035176f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.661619f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 10.27878f);
Get(0xFA26).SetLocalPose(1.396551f,1.257768f,0.7830413f,-0.5269733f,0.5138617f,-0.4357385f,0.5180516f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449628f,1.364992f,0.7844036f,-0.7102203f,0.009100022f,0.0238601f,0.7035162f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.717626f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 10.29698f);
Get(0xFA26).SetLocalPose(1.396084f,1.257184f,0.7828525f,-0.5272688f,0.5136327f,-0.4357644f,0.5179561f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449637f,1.36495f,0.7844526f,-0.7102311f,0.009064042f,0.02386245f,0.7035057f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.775547f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 10.3158f);
Get(0xFA26).SetLocalPose(1.395981f,1.255922f,0.7827893f,-0.5275018f,0.5134319f,-0.4358181f,0.5178727f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449575f,1.364985f,0.7843935f,-0.7102271f,0.00907864f,0.02385644f,0.7035098f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.801777f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 10.32433f);
Get(0xFA26).SetLocalPose(1.395808f,1.255602f,0.7827945f,-0.5275759f,0.5134879f,-0.4358082f,0.5177501f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449608f,1.365035f,0.7843818f,-0.71022f,0.009074795f,0.02386143f,0.7035168f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.861595f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 10.34377f);
Get(0xFA26).SetLocalPose(1.396196f,1.255668f,0.7826619f,-0.5277113f,0.5136557f,-0.435756f,0.5174896f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449588f,1.365193f,0.784467f,-0.7102294f,0.009088006f,0.02388123f,0.7035064f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.917881f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 10.36206f);
Get(0xFA26).SetLocalPose(1.396189f,1.254775f,0.7824789f,-0.5278931f,0.5139236f,-0.4357276f,0.5170617f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449573f,1.365202f,0.7844802f,-0.7102481f,0.00907395f,0.02386978f,0.7034882f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.973818f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 10.38024f);
Get(0xFA26).SetLocalPose(1.396193f,1.254778f,0.7825556f,-0.5281468f,0.5138945f,-0.4358866f,0.5166975f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449497f,1.36517f,0.7844427f,-0.7102076f,0.009092015f,0.02386562f,0.703529f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 7.033013f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 10.39948f);
Get(0xFA26).SetLocalPose(1.396426f,1.254963f,0.7827606f,-0.5285596f,0.5136687f,-0.4358641f,0.5165189f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449375f,1.365263f,0.7843779f,-0.710224f,0.009112992f,0.02383779f,0.7035131f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 7.060369f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 10.40837f);
Get(0xFA26).SetLocalPose(1.396391f,1.25516f,0.7824504f,-0.5287185f,0.513621f,-0.435863f,0.5164047f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449288f,1.365138f,0.7842711f,-0.7102081f,0.009150165f,0.02385526f,0.703528f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 7.120478f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 10.42791f);
Get(0xFA26).SetLocalPose(1.396211f,1.255268f,0.7828273f,-0.5288218f,0.5137672f,-0.4358323f,0.5161793f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449198f,1.365101f,0.7842724f,-0.7102097f,0.009127143f,0.02385064f,0.703527f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 7.178419f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 10.44674f);
Get(0xFA26).SetLocalPose(1.396484f,1.255576f,0.7822829f,-0.528918f,0.5139695f,-0.4358141f,0.5158946f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449202f,1.365089f,0.784133f,-0.7101989f,0.009141958f,0.02385359f,0.7035375f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 7.206966f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 10.45602f);
Get(0xFA26).SetLocalPose(1.396607f,1.255453f,0.7818897f,-0.5288507f,0.5140773f,-0.4357936f,0.5158734f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449261f,1.365087f,0.7841001f,-0.7102145f,0.009113703f,0.02385317f,0.7035221f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 7.269631f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 10.47638f);
Get(0xFA26).SetLocalPose(1.396551f,1.255839f,0.7823138f,-0.5289518f,0.513974f,-0.4357334f,0.5159236f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449305f,1.365053f,0.7840065f,-0.7102031f,0.009144939f,0.02386808f,0.7035328f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 7.326168f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 10.49476f);
Get(0xFA26).SetLocalPose(1.396956f,1.255932f,0.7818991f,-0.5291615f,0.5137081f,-0.4356585f,0.5160367f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44925f,1.365099f,0.7840474f,-0.7102084f,0.009143041f,0.0238767f,0.7035272f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 7.383535f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 10.5134f);
Get(0xFA26).SetLocalPose(1.397258f,1.255603f,0.7814878f,-0.5292681f,0.5135787f,-0.4355686f,0.516132f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449292f,1.365002f,0.7839687f,-0.7102011f,0.009154767f,0.0238654f,0.7035347f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 7.439075f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 10.53145f);
Get(0xFA26).SetLocalPose(1.397003f,1.256086f,0.7813534f,-0.529235f,0.5136455f,-0.4355436f,0.5161206f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449303f,1.364992f,0.7840412f,-0.7101891f,0.009119708f,0.02386618f,0.7035473f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 7.46575f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 10.54012f);
Get(0xFA26).SetLocalPose(1.39704f,1.256208f,0.7812005f,-0.5292174f,0.5137079f,-0.435533f,0.5160855f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449344f,1.364948f,0.7841557f,-0.7101868f,0.00912297f,0.0238643f,0.7035496f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 7.516868f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 10.55673f);
Get(0xFA26).SetLocalPose(1.397374f,1.256202f,0.7818311f,-0.5294164f,0.5136454f,-0.4352646f,0.51617f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449266f,1.365077f,0.7840781f,-0.7101833f,0.009166975f,0.02385f,0.703553f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 7.596507f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 10.58262f);
Get(0xFA26).SetLocalPose(1.397708f,1.255692f,0.7816247f,-0.5296878f,0.5133964f,-0.4350745f,0.5162994f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449279f,1.365082f,0.7840914f,-0.7101932f,0.009152195f,0.02384221f,0.7035435f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 7.622024f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 10.59091f);
Get(0xFA26).SetLocalPose(1.397325f,1.255415f,0.7818543f,-0.5298619f,0.513325f,-0.4350117f,0.5162448f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449171f,1.365087f,0.7840703f,-0.7101861f,0.009175749f,0.02385282f,0.70355f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 7.685239f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 10.61145f);
Get(0xFA26).SetLocalPose(1.397027f,1.255398f,0.7818597f,-0.5299115f,0.5133969f,-0.4351191f,0.5160319f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449269f,1.365055f,0.7840291f,-0.7101824f,0.009176346f,0.02383214f,0.7035544f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 7.741313f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 10.62968f);
Get(0xFA26).SetLocalPose(1.397341f,1.255656f,0.7812561f,-0.5298876f,0.5135044f,-0.4352764f,0.5158169f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449188f,1.36496f,0.7840513f,-0.7101831f,0.009144419f,0.02385327f,0.7035535f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 7.797301f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 10.64787f);
Get(0xFA26).SetLocalPose(1.397601f,1.255892f,0.7813086f,-0.5300044f,0.5134347f,-0.4352657f,0.515775f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449197f,1.365003f,0.784175f,-0.7101825f,0.009163721f,0.02386029f,0.7035536f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 7.851974f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 10.66564f);
Get(0xFA26).SetLocalPose(1.397025f,1.255586f,0.7810051f,-0.5300803f,0.5133506f,-0.4352477f,0.515796f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449307f,1.364923f,0.7841192f,-0.71018f,0.009137904f,0.02386214f,0.7035563f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 7.876961f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 10.67376f);
Get(0xFA26).SetLocalPose(1.396715f,1.255805f,0.7805993f,-0.5302431f,0.5131539f,-0.4352458f,0.515826f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449459f,1.364884f,0.7840856f,-0.710205f,0.009112895f,0.02388675f,0.7035306f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 7.936441f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 10.69309f);
Get(0xFA26).SetLocalPose(1.396963f,1.254936f,0.7799495f,-0.5301923f,0.5130259f,-0.4352599f,0.5159937f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44941f,1.364966f,0.7840749f,-0.7101855f,0.009126597f,0.02387865f,0.7035505f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 7.992011f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 10.71115f);
Get(0xFA26).SetLocalPose(1.396491f,1.255353f,0.7803723f,-0.5300821f,0.5131083f,-0.4354016f,0.5159053f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449554f,1.365209f,0.7839994f,-0.7101601f,0.00909454f,0.02391197f,0.7035753f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.047348f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 10.72914f);
Get(0xFA26).SetLocalPose(1.396444f,1.255965f,0.7803398f,-0.5299478f,0.5132167f,-0.4355676f,0.5157953f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449606f,1.365135f,0.7839968f,-0.7101519f,0.009107704f,0.02388976f,0.7035842f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.102392f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 10.74703f);
Get(0xFA26).SetLocalPose(1.396566f,1.256168f,0.7802774f,-0.5302931f,0.5128978f,-0.4355045f,0.5158109f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449528f,1.365247f,0.7838529f,-0.7101532f,0.009132013f,0.02388027f,0.7035828f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.158056f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 10.76512f);
Get(0xFA26).SetLocalPose(1.396733f,1.255433f,0.7804617f,-0.5310388f,0.5122566f,-0.434957f,0.5161428f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449436f,1.365282f,0.7838848f,-0.7101629f,0.009131181f,0.02388364f,0.703573f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.21312f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 10.78302f);
Get(0xFA26).SetLocalPose(1.396699f,1.255261f,0.7802719f,-0.5312903f,0.5120098f,-0.434451f,0.5165548f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449323f,1.365244f,0.7837823f,-0.7101601f,0.009148511f,0.02385111f,0.7035766f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.238305f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 10.7912f);
Get(0xFA26).SetLocalPose(1.396774f,1.255272f,0.7802068f,-0.5313458f,0.5119649f,-0.4342559f,0.5167064f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449208f,1.365157f,0.7836723f,-0.7101479f,0.009171036f,0.02386739f,0.7035882f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.296846f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 10.81023f);
Get(0xFA26).SetLocalPose(1.396859f,1.255641f,0.7799649f,-0.5316985f,0.5117262f,-0.4335599f,0.5171642f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44927f,1.365197f,0.7837335f,-0.7101708f,0.009182348f,0.02383335f,0.7035661f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.352749f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 10.82839f);
Get(0xFA26).SetLocalPose(1.396586f,1.255991f,0.7794385f,-0.5330944f,0.5105363f,-0.4312701f,0.5188151f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449258f,1.365139f,0.7838441f,-0.7101784f,0.009185945f,0.02383764f,0.7035581f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.407632f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 10.84623f);
Get(0xFA26).SetLocalPose(1.396631f,1.256125f,0.7793722f,-0.5335566f,0.5101322f,-0.4305638f,0.5193239f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449203f,1.364928f,0.7839438f,-0.710196f,0.009180052f,0.02384042f,0.7035404f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.462037f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 10.86391f);
Get(0xFA26).SetLocalPose(1.396604f,1.256642f,0.7791492f,-0.5347264f,0.509082f,-0.4287744f,0.5206302f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449019f,1.365048f,0.7839522f,-0.7102063f,0.009164549f,0.02383246f,0.7035304f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.516358f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 10.88157f);
Get(0xFA26).SetLocalPose(1.396628f,1.25744f,0.7787468f,-0.5381231f,0.5061954f,-0.4241221f,0.5237464f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448858f,1.365009f,0.7840672f,-0.710197f,0.009177162f,0.02382263f,0.70354f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.570924f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 10.8993f);
Get(0xFA26).SetLocalPose(1.396614f,1.258998f,0.7781016f,-0.547435f,0.4984238f,-0.413195f,0.5302439f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448848f,1.365126f,0.7840481f,-0.7101887f,0.009198321f,0.02382783f,0.7035479f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.596528f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 10.90762f);
Get(0xFA26).SetLocalPose(1.396382f,1.261119f,0.7776008f,-0.5560136f,0.4909169f,-0.4034671f,0.5357834f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448901f,1.365081f,0.7839635f,-0.7101629f,0.009201538f,0.02384247f,0.7035735f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.655159f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 10.92668f);
Get(0xFA26).SetLocalPose(1.396541f,1.263675f,0.7775003f,-0.5692375f,0.4780657f,-0.3877892f,0.5450152f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448946f,1.365016f,0.7838964f,-0.7101718f,0.009199895f,0.02381417f,0.7035654f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.711241f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 10.9449f);
Get(0xFA26).SetLocalPose(1.396361f,1.267658f,0.7765878f,-0.5852734f,0.4608417f,-0.3664448f,0.5574929f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448877f,1.365041f,0.7838323f,-0.7101603f,0.009198937f,0.0238122f,0.7035771f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.766538f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 10.96287f);
Get(0xFA26).SetLocalPose(1.395873f,1.272557f,0.7756989f,-0.6011091f,0.4429011f,-0.3429876f,0.5699703f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449014f,1.364985f,0.7839825f,-0.7101851f,0.00914596f,0.02381046f,0.7035529f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.820292f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 10.98034f);
Get(0xFA26).SetLocalPose(1.395329f,1.276728f,0.7749027f,-0.6163974f,0.4245068f,-0.3176473f,0.5821927f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449064f,1.365009f,0.7840203f,-0.7101803f,0.009153494f,0.02382866f,0.703557f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.876413f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 10.99858f);
Get(0xFA26).SetLocalPose(1.39538f,1.280999f,0.7737264f,-0.6323943f,0.4032177f,-0.2870853f,0.5958817f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449062f,1.365002f,0.7839972f,-0.7101728f,0.009171454f,0.02381167f,0.7035649f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.931114f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 11.01636f);
Get(0xFA26).SetLocalPose(1.394983f,1.28411f,0.7735836f,-0.6409683f,0.3904819f,-0.2692971f,0.6034589f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449034f,1.364937f,0.7839968f,-0.7101622f,0.009174717f,0.02380735f,0.7035757f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.957275f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 11.02486f);
Get(0xFA26).SetLocalPose(1.394712f,1.285556f,0.7733437f,-0.6457613f,0.3830857f,-0.2591888f,0.6075021f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449017f,1.364946f,0.7839181f,-0.7101705f,0.009202966f,0.02379846f,0.7035673f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 9.01611f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 11.04399f);
Get(0xFA26).SetLocalPose(1.394447f,1.288028f,0.7728539f,-0.655336f,0.3684818f,-0.2397622f,0.6142231f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449038f,1.365059f,0.7839032f,-0.7101803f,0.009215127f,0.02377929f,0.7035578f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 9.071559f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 11.06201f);
Get(0xFA26).SetLocalPose(1.393618f,1.291637f,0.7718393f,-0.6672609f,0.3491485f,-0.2151702f,0.6217396f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448991f,1.364859f,0.7839113f,-0.7101932f,0.009185483f,0.02380494f,0.7035444f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 9.127641f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 11.08023f);
Get(0xFA26).SetLocalPose(1.392488f,1.296483f,0.7715894f,-0.6806012f,0.3244401f,-0.1816148f,0.6312976f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449008f,1.364926f,0.7839554f,-0.7101979f,0.00918458f,0.02383084f,0.7035388f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 9.182489f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 11.09806f);
Get(0xFA26).SetLocalPose(1.390518f,1.299667f,0.7711973f,-0.6885396f,0.3069647f,-0.1553935f,0.6383877f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449013f,1.36484f,0.7839381f,-0.7101944f,0.009154271f,0.0238167f,0.7035431f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 9.238106f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 11.11613f);
Get(0xFA26).SetLocalPose(1.388367f,1.303486f,0.7709149f,-0.6971264f,0.2864429f,-0.1255471f,0.6451381f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449033f,1.364986f,0.7840672f,-0.7102183f,0.00918396f,0.02380827f,0.7035189f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 9.262826f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 11.12417f);
Get(0xFA26).SetLocalPose(1.387711f,1.305115f,0.770656f,-0.7011268f,0.2774185f,-0.1136331f,0.6469527f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448943f,1.364962f,0.7840313f,-0.7102025f,0.009190743f,0.02381037f,0.7035348f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 9.320615f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 11.14295f);
Get(0xFA26).SetLocalPose(1.385924f,1.308457f,0.7699962f,-0.7110678f,0.2546835f,-0.08527333f,0.6498057f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44911f,1.364831f,0.7839997f,-0.7101864f,0.009178148f,0.02381922f,0.7035509f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 9.375838f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 11.1609f);
Get(0xFA26).SetLocalPose(1.383665f,1.310797f,0.7693906f,-0.7191859f,0.2342409f,-0.06119858f,0.6512738f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449101f,1.36489f,0.7840965f,-0.7101908f,0.009201605f,0.02381655f,0.7035461f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 9.432824f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 11.17942f);
Get(0xFA26).SetLocalPose(1.379411f,1.315273f,0.7689373f,-0.7295904f,0.1979303f,-0.01826394f,0.6543608f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449147f,1.364902f,0.784117f,-0.710188f,0.009157256f,0.02384171f,0.7035487f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 9.489948f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 11.19798f);
Get(0xFA26).SetLocalPose(1.375644f,1.3183f,0.7689406f,-0.7347469f,0.1708452f,0.01576047f,0.6562855f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449182f,1.364932f,0.7840954f,-0.7101843f,0.009107955f,0.02385319f,0.7035527f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 9.546964f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 11.21651f);
Get(0xFA26).SetLocalPose(1.369889f,1.321716f,0.7686424f,-0.737608f,0.1386749f,0.05916204f,0.658182f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449289f,1.364986f,0.7840776f,-0.7101972f,0.009100464f,0.02385559f,0.7035397f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 9.572605f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 11.22485f);
Get(0xFA26).SetLocalPose(1.367007f,1.322939f,0.7686943f,-0.7381406f,0.1257064f,0.07636674f,0.6584182f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449327f,1.365074f,0.7840603f,-0.7101821f,0.009121615f,0.02388461f,0.7035536f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 9.631939f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 11.24413f);
Get(0xFA26).SetLocalPose(1.361052f,1.325129f,0.7687264f,-0.7388568f,0.0930357f,0.117375f,0.657007f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449394f,1.365146f,0.7840245f,-0.7101833f,0.009101219f,0.02386877f,0.7035532f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 9.688588f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 11.26254f);
Get(0xFA26).SetLocalPose(1.357875f,1.326036f,0.7687641f,-0.7386676f,0.07385106f,0.140153f,0.6551895f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449289f,1.365297f,0.783945f,-0.7101696f,0.009156791f,0.02383386f,0.7035676f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 9.745978f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 11.2812f);
Get(0xFA26).SetLocalPose(1.350904f,1.327217f,0.7689523f,-0.7357363f,0.03558263f,0.1848185f,0.6505906f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449281f,1.365223f,0.7839177f,-0.7101862f,0.00909724f,0.02383542f,0.7035515f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 9.773485f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 11.29014f);
Get(0xFA26).SetLocalPose(1.347059f,1.327436f,0.7693567f,-0.7324797f,0.01578753f,0.2082651f,0.6479583f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44931f,1.365142f,0.7839763f,-0.7101705f,0.009098188f,0.02385387f,0.7035667f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 9.8341f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 11.30984f);
Get(0xFA26).SetLocalPose(1.341892f,1.327424f,0.7696313f,-0.7259533f,-0.007548151f,0.2397259f,0.6445667f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449295f,1.365239f,0.7839127f,-0.7101767f,0.009128381f,0.02385201f,0.7035602f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 9.894428f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 11.32944f);
Get(0xFA26).SetLocalPose(1.33662f,1.327222f,0.770757f,-0.7158493f,-0.02796599f,0.2732542f,0.6419579f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449358f,1.365143f,0.7839657f,-0.710175f,0.009121529f,0.02385166f,0.703562f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 9.952893f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 11.34844f);
Get(0xFA26).SetLocalPose(1.332337f,1.326763f,0.7716054f,-0.7059283f,-0.04557452f,0.3002248f,0.6398854f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449444f,1.365079f,0.7839327f,-0.7101669f,0.009128796f,0.02386946f,0.7035695f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 9.978422f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 11.35674f);
Get(0xFA26).SetLocalPose(1.330437f,1.326544f,0.7721011f,-0.7017755f,-0.05349228f,0.311076f,0.6386561f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44945f,1.365118f,0.7840749f,-0.7101936f,0.009084291f,0.02386886f,0.7035431f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 10.03755f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 11.37596f);
Get(0xFA26).SetLocalPose(1.326924f,1.325865f,0.7724952f,-0.6938117f,-0.07154727f,0.3334217f,0.6342999f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449414f,1.365269f,0.7840905f,-0.710196f,0.009129815f,0.02386389f,0.7035402f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 10.096f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 11.39495f);
Get(0xFA26).SetLocalPose(1.322872f,1.324339f,0.772889f,-0.6855282f,-0.08951499f,0.3554161f,0.629061f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449328f,1.365167f,0.7839949f,-0.7101768f,0.009136063f,0.02386867f,0.7035594f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 10.15242f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 11.41329f);
Get(0xFA26).SetLocalPose(1.319079f,1.322762f,0.7742187f,-0.6757631f,-0.1068127f,0.3773422f,0.6241381f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449365f,1.365263f,0.7839213f,-0.7101751f,0.009103538f,0.02387287f,0.7035613f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 10.21185f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 11.4326f);
Get(0xFA26).SetLocalPose(1.31564f,1.321943f,0.774529f,-0.6673605f,-0.121415f,0.3935615f,0.6204818f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449532f,1.36525f,0.7840899f,-0.7101836f,0.009103672f,0.02387796f,0.7035526f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 10.23803f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 11.44111f);
Get(0xFA26).SetLocalPose(1.313876f,1.321208f,0.7750185f,-0.6627498f,-0.130005f,0.40199f,0.6182762f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449561f,1.365299f,0.784107f,-0.7101941f,0.009128102f,0.02388157f,0.7035416f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 10.30066f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 11.46147f);
Get(0xFA26).SetLocalPose(1.310859f,1.31991f,0.7761047f,-0.6542462f,-0.1464414f,0.4148869f,0.6151306f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449656f,1.365219f,0.7841465f,-0.710225f,0.009112344f,0.0238668f,0.7035111f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 10.35761f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 11.47997f);
Get(0xFA26).SetLocalPose(1.309589f,1.319444f,0.7769018f,-0.6485478f,-0.152222f,0.4223602f,0.6146756f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449534f,1.365175f,0.7840846f,-0.7102131f,0.009117715f,0.02386832f,0.703523f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 10.41411f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 11.49834f);
Get(0xFA26).SetLocalPose(1.308533f,1.318609f,0.7781532f,-0.6407354f,-0.1544174f,0.432808f,0.6150534f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449469f,1.364958f,0.7841482f,-0.7102103f,0.009143911f,0.02383437f,0.7035267f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 10.46912f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 11.51622f);
Get(0xFA26).SetLocalPose(1.307512f,1.317984f,0.7791558f,-0.635445f,-0.1592325f,0.4403071f,0.6139906f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449383f,1.364999f,0.7840567f,-0.7102038f,0.009143115f,0.02385531f,0.7035325f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 10.49414f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 11.52435f);
Get(0xFA26).SetLocalPose(1.306747f,1.317387f,0.7795708f,-0.6331584f,-0.1643663f,0.4437508f,0.612519f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44916f,1.364834f,0.7840849f,-0.7101941f,0.009166873f,0.02384477f,0.7035424f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 10.55315f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 11.54353f);
Get(0xFA26).SetLocalPose(1.305502f,1.316969f,0.7796135f,-0.6295395f,-0.1746209f,0.4489315f,0.6096295f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449077f,1.36486f,0.7841045f,-0.7101979f,0.009157281f,0.0238502f,0.7035384f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.02987261f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 11.56204f);
Get(0xFA26).SetLocalPose(1.304781f,1.316518f,0.7799578f,-0.6262359f,-0.1807594f,0.4529451f,0.6082724f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449225f,1.364922f,0.784157f,-0.7101939f,0.009128901f,0.02389454f,0.7035413f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.08409477f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 11.57966f);
Get(0xFA26).SetLocalPose(1.30493f,1.317148f,0.780198f,-0.6251253f,-0.1804839f,0.4546976f,0.6081892f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449267f,1.364996f,0.7841077f,-0.7101901f,0.009120158f,0.0238791f,0.7035458f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.1382022f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 11.59725f);
Get(0xFA26).SetLocalPose(1.305096f,1.317057f,0.7799467f,-0.6255858f,-0.1795717f,0.4543304f,0.60826f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449448f,1.364941f,0.7841851f,-0.7102083f,0.009081371f,0.02386855f,0.7035283f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.1941215f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 11.61542f);
Get(0xFA26).SetLocalPose(1.3057f,1.316748f,0.779851f,-0.6267831f,-0.1820821f,0.4538499f,0.6066378f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449439f,1.364926f,0.7841741f,-0.7102081f,0.009061359f,0.02389992f,0.7035277f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.2190382f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 11.62352f);
Get(0xFA26).SetLocalPose(1.305728f,1.316559f,0.780065f,-0.6268901f,-0.1835844f,0.4537753f,0.6061301f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449592f,1.365125f,0.7842265f,-0.7102073f,0.009099121f,0.02389265f,0.7035283f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.2800578f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 11.64335f);
Get(0xFA26).SetLocalPose(1.305959f,1.315909f,0.7800092f,-0.6275442f,-0.186965f,0.4535904f,0.6045562f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449681f,1.365117f,0.7843251f,-0.7102107f,0.009082384f,0.02388852f,0.7035252f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.3360096f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 11.66153f);
Get(0xFA26).SetLocalPose(1.306395f,1.314974f,0.7804335f,-0.6277696f,-0.1868398f,0.4534599f,0.6044587f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449627f,1.365182f,0.7842706f,-0.7101997f,0.009103204f,0.02387284f,0.7035366f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.3926797f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 11.67995f);
Get(0xFA26).SetLocalPose(1.306688f,1.314756f,0.7804577f,-0.6285961f,-0.1852223f,0.4526873f,0.6046767f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449611f,1.365099f,0.7842618f,-0.7102048f,0.009105403f,0.02388634f,0.7035308f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.4466043f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 11.69747f);
Get(0xFA26).SetLocalPose(1.30696f,1.315034f,0.7804993f,-0.6299023f,-0.1851666f,0.4513178f,0.6043581f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449611f,1.36512f,0.7842523f,-0.7102116f,0.009096792f,0.02388602f,0.7035242f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.5028613f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 11.71576f);
Get(0xFA26).SetLocalPose(1.307432f,1.314684f,0.780688f,-0.6311131f,-0.1864732f,0.4500965f,0.6036035f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449466f,1.365183f,0.784238f,-0.7102128f,0.009115275f,0.02389028f,0.7035226f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.556328f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 11.73313f);
Get(0xFA26).SetLocalPose(1.30781f,1.314415f,0.7807991f,-0.6315747f,-0.187307f,0.4494282f,0.6033604f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449485f,1.365172f,0.7842957f,-0.7101888f,0.009114154f,0.02389497f,0.7035466f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.5818098f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 11.74142f);
Get(0xFA26).SetLocalPose(1.308078f,1.314211f,0.7808664f,-0.6314672f,-0.187397f,0.4495623f,0.6033452f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44933f,1.365203f,0.7841941f,-0.7101858f,0.009136569f,0.02387279f,0.7035502f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.6428452f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 11.76125f);
Get(0xFA26).SetLocalPose(1.308066f,1.314612f,0.7807727f,-0.6314803f,-0.1869224f,0.4496875f,0.6033853f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449418f,1.365078f,0.7841839f,-0.7101849f,0.00915651f,0.0238521f,0.7035516f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.6990889f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 11.77953f);
Get(0xFA26).SetLocalPose(1.308227f,1.31478f,0.7808284f,-0.6317624f,-0.1865958f,0.4495453f,0.6032971f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449406f,1.365059f,0.7840894f,-0.7102069f,0.009112886f,0.02387501f,0.7035292f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.7551178f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 11.79774f);
Get(0xFA26).SetLocalPose(1.308231f,1.314781f,0.7810751f,-0.6318145f,-0.1872049f,0.4495018f,0.6030862f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449288f,1.365151f,0.7841227f,-0.7102073f,0.009174821f,0.02384557f,0.7035289f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.8123781f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 11.81635f);
Get(0xFA26).SetLocalPose(1.308577f,1.314706f,0.781416f,-0.6322656f,-0.1877148f,0.4484413f,0.6032444f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449257f,1.365157f,0.7840987f,-0.7102212f,0.00914592f,0.02383159f,0.7035157f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.8381153f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 11.82471f);
Get(0xFA26).SetLocalPose(1.308454f,1.314886f,0.7813727f,-0.6325523f,-0.1878146f,0.4478373f,0.6033615f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449179f,1.365098f,0.7841234f,-0.7102042f,0.009163384f,0.02386516f,0.7035315f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.897356f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 11.84397f);
Get(0xFA26).SetLocalPose(1.30855f,1.315334f,0.7814264f,-0.6331159f,-0.1872953f,0.4468834f,0.603639f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448976f,1.365016f,0.7838867f,-0.710169f,0.009190269f,0.02385293f,0.7035671f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.9531403f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 11.8621f);
Get(0xFA26).SetLocalPose(1.30848f,1.315722f,0.7814896f,-0.6331835f,-0.1867205f,0.4467058f,0.6038776f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448965f,1.364976f,0.7838249f,-0.7101799f,0.009169729f,0.02385429f,0.7035563f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.008813f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 11.88019f);
Get(0xFA26).SetLocalPose(1.308468f,1.315905f,0.7814326f,-0.6332886f,-0.1861189f,0.4463671f,0.6042034f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449003f,1.3649f,0.7837421f,-0.7101784f,0.009157255f,0.02384922f,0.7035581f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.067389f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 11.89923f);
Get(0xFA26).SetLocalPose(1.308507f,1.316036f,0.7811162f,-0.6335927f,-0.18572f,0.4455036f,0.6046445f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449037f,1.364956f,0.7837691f,-0.7101902f,0.009154735f,0.0238355f,0.7035467f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.093822f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 11.90782f);
Get(0xFA26).SetLocalPose(1.308562f,1.315563f,0.7809572f,-0.6336119f,-0.1859364f,0.4454623f,0.6045884f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449085f,1.364934f,0.7837976f,-0.7101771f,0.009173123f,0.0238376f,0.7035596f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.151876f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 11.92669f);
Get(0xFA26).SetLocalPose(1.308306f,1.315149f,0.7809715f,-0.6336026f,-0.186372f,0.4454769f,0.6044531f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449133f,1.364964f,0.7839674f,-0.710185f,0.009163071f,0.0238359f,0.7035518f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.207281f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 11.94469f);
Get(0xFA26).SetLocalPose(1.308273f,1.314801f,0.7810876f,-0.6336333f,-0.1862219f,0.4454484f,0.6044882f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449279f,1.36481f,0.7840872f,-0.7101972f,0.009124517f,0.02385878f,0.7035393f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.264063f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 11.96315f);
Get(0xFA26).SetLocalPose(1.307867f,1.314802f,0.7810498f,-0.6336661f,-0.1854435f,0.4455652f,0.604607f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449368f,1.36496f,0.7840907f,-0.7101846f,0.009142873f,0.02385354f,0.7035519f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.323011f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 11.98231f);
Get(0xFA26).SetLocalPose(1.307878f,1.315172f,0.7810031f,-0.6336096f,-0.1842865f,0.4457272f,0.6049005f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449299f,1.365088f,0.7840152f,-0.7101932f,0.009112204f,0.02384558f,0.703544f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.349065f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 11.99077f);
Get(0xFA26).SetLocalPose(1.307927f,1.315367f,0.7809905f,-0.6336564f,-0.1835448f,0.4455328f,0.6052203f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449349f,1.365058f,0.7841462f,-0.7101899f,0.009125386f,0.02386267f,0.7035465f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.409163f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 12.01031f);
Get(0xFA26).SetLocalPose(1.30795f,1.315016f,0.7820064f,-0.6339668f,-0.1828939f,0.4447802f,0.6056455f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449356f,1.365055f,0.7841546f,-0.7101926f,0.009144089f,0.02384482f,0.7035441f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.466536f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 12.02895f);
Get(0xFA26).SetLocalPose(1.308144f,1.315193f,0.7820732f,-0.6341692f,-0.1823652f,0.4440246f,0.6061474f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449291f,1.36512f,0.7839683f,-0.7101803f,0.009155137f,0.02386971f,0.7035556f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.523104f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 12.04734f);
Get(0xFA26).SetLocalPose(1.308053f,1.315886f,0.7820868f,-0.6339484f,-0.1822939f,0.4443295f,0.6061763f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449288f,1.365144f,0.7839167f,-0.710165f,0.009173654f,0.02387006f,0.7035707f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.580589f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 12.06602f);
Get(0xFA26).SetLocalPose(1.307967f,1.316308f,0.7821926f,-0.6335905f,-0.1821849f,0.4449431f,0.6061332f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449376f,1.365171f,0.7840207f,-0.7101943f,0.009143405f,0.02386251f,0.7035418f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.606433f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 12.07442f);
Get(0xFA26).SetLocalPose(1.307905f,1.316317f,0.7823582f,-0.633532f,-0.1820979f,0.4450125f,0.6061695f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449273f,1.36505f,0.7839201f,-0.7101735f,0.009179277f,0.02385435f,0.7035627f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.668345f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 12.09454f);
Get(0xFA26).SetLocalPose(1.307656f,1.316244f,0.7828102f,-0.6335788f,-0.1817453f,0.4450117f,0.606227f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449301f,1.365028f,0.7840688f,-0.7101864f,0.009117899f,0.02387871f,0.7035495f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.726248f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 12.11336f);
Get(0xFA26).SetLocalPose(1.307667f,1.316741f,0.7826566f,-0.6338942f,-0.1807301f,0.4444189f,0.6066355f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449307f,1.365168f,0.7841333f,-0.7101908f,0.009135973f,0.02387649f,0.703545f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.785936f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 12.13276f);
Get(0xFA26).SetLocalPose(1.307432f,1.316832f,0.782954f,-0.6338757f,-0.1800256f,0.4437544f,0.6073503f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449304f,1.36518f,0.7841379f,-0.7101861f,0.009158957f,0.02389175f,0.7035489f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.811897f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 12.14119f);
Get(0xFA26).SetLocalPose(1.307375f,1.316916f,0.7830033f,-0.6337638f,-0.1800448f,0.4437649f,0.6074538f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44928f,1.365242f,0.7841375f,-0.7101864f,0.009152856f,0.02389947f,0.7035484f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.872815f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 12.16099f);
Get(0xFA26).SetLocalPose(1.30747f,1.31743f,0.7831393f,-0.633226f,-0.1801852f,0.4443171f,0.6075693f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449296f,1.365165f,0.7841229f,-0.7101924f,0.009128268f,0.02387512f,0.7035436f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.928887f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 12.17921f);
Get(0xFA26).SetLocalPose(1.307403f,1.317743f,0.7833019f,-0.6330396f,-0.1798509f,0.4445183f,0.6077154f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449414f,1.365008f,0.7841274f,-0.7101934f,0.009139416f,0.02386588f,0.7035426f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.98407f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 12.19715f);
Get(0xFA26).SetLocalPose(1.307667f,1.318054f,0.7832236f,-0.6329884f,-0.1797595f,0.444623f,0.6077193f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449526f,1.364909f,0.7841797f,-0.7102057f,0.009090186f,0.02388808f,0.7035302f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.039807f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 12.21526f);
Get(0xFA26).SetLocalPose(1.307882f,1.318041f,0.7834338f,-0.633323f,-0.1793617f,0.4441316f,0.6078474f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449375f,1.365093f,0.7841243f,-0.7101979f,0.009098982f,0.0238937f,0.7035378f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.093945f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 12.23286f);
Get(0xFA26).SetLocalPose(1.307921f,1.318324f,0.7834395f,-0.633558f,-0.1792431f,0.4434354f,0.6081458f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449379f,1.365219f,0.784062f,-0.7102069f,0.00909899f,0.02388377f,0.703529f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.119382f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 12.24112f);
Get(0xFA26).SetLocalPose(1.307816f,1.318636f,0.7831685f,-0.6335801f,-0.1793587f,0.4431695f,0.6082826f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449482f,1.36527f,0.7841542f,-0.7102004f,0.009115766f,0.02386644f,0.703536f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.178427f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 12.26031f);
Get(0xFA26).SetLocalPose(1.308015f,1.318542f,0.7830585f,-0.6335021f,-0.1794272f,0.4431119f,0.6083854f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449414f,1.365266f,0.7841042f,-0.710202f,0.009142455f,0.02386071f,0.7035341f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.233039f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 12.27806f);
Get(0xFA26).SetLocalPose(1.307992f,1.318342f,0.7829057f,-0.6333266f,-0.179352f,0.4432613f,0.6084815f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449534f,1.365173f,0.7841505f,-0.7101833f,0.009121568f,0.02388026f,0.7035526f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.288231f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 12.296f);
Get(0xFA26).SetLocalPose(1.307944f,1.318218f,0.7830215f,-0.6334085f,-0.1790477f,0.4432155f,0.6085193f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449345f,1.365178f,0.7841663f,-0.7101901f,0.009145692f,0.02386761f,0.7035459f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.343513f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 12.31397f);
Get(0xFA26).SetLocalPose(1.308298f,1.318471f,0.7828717f,-0.6337727f,-0.1787734f,0.4427516f,0.6085584f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449185f,1.365218f,0.7841458f,-0.7101949f,0.00917138f,0.02384152f,0.7035416f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.400249f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 12.33241f);
Get(0xFA26).SetLocalPose(1.308542f,1.318479f,0.782687f,-0.6339442f,-0.1789696f,0.4426837f,0.6083714f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449233f,1.365177f,0.784229f,-0.7101857f,0.009173599f,0.02385939f,0.7035502f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.425062f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 12.34047f);
Get(0xFA26).SetLocalPose(1.308356f,1.318542f,0.7828008f,-0.6338391f,-0.1792549f,0.4429506f,0.6082026f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449204f,1.365121f,0.7841177f,-0.7101999f,0.009148508f,0.02381839f,0.7035377f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.483011f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 12.3593f);
Get(0xFA26).SetLocalPose(1.308468f,1.318593f,0.7825623f,-0.6333137f,-0.1799717f,0.4436192f,0.6080509f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449132f,1.365065f,0.7840876f,-0.7101766f,0.009152705f,0.02385158f,0.7035599f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.537723f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 12.37709f);
Get(0xFA26).SetLocalPose(1.307709f,1.318461f,0.782923f,-0.6325166f,-0.1813357f,0.4449549f,0.6074993f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449321f,1.365177f,0.7841238f,-0.7101881f,0.009126396f,0.02386352f,0.7035483f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.592231f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 12.3948f);
Get(0xFA26).SetLocalPose(1.30732f,1.318369f,0.7830539f,-0.6307864f,-0.1846914f,0.4480828f,0.6059863f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449353f,1.365262f,0.7841237f,-0.7101957f,0.009128105f,0.0238365f,0.7035415f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.646702f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 12.4125f);
Get(0xFA26).SetLocalPose(1.306113f,1.318072f,0.7827666f,-0.6277612f,-0.190581f,0.4535061f,0.6032637f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449456f,1.365291f,0.7840706f,-0.7101918f,0.009112984f,0.02385296f,0.7035451f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.702003f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 12.43048f);
Get(0xFA26).SetLocalPose(1.304655f,1.317478f,0.7831302f,-0.6241841f,-0.1976578f,0.4603485f,0.5995039f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449389f,1.365129f,0.7840012f,-0.7101798f,0.009105173f,0.02384958f,0.7035574f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.7581f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 12.44871f);
Get(0xFA26).SetLocalPose(1.303689f,1.316425f,0.7836964f,-0.6206764f,-0.2042163f,0.466882f,0.595884f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449432f,1.365074f,0.7840536f,-0.7101803f,0.009109017f,0.02383939f,0.7035572f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.812046f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 12.46624f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449373f,1.365061f,0.7839744f,-0.7101887f,0.009106991f,0.02383765f,0.7035488f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.836982f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 12.47435f);
Get(0xFA26).SetLocalPose(1.303277f,1.316664f,0.7837466f,-0.6193253f,-0.2066188f,0.4692769f,0.5945789f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449291f,1.365106f,0.784002f,-0.7101828f,0.009126532f,0.02383881f,0.7035545f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.897555f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 12.49403f);
Get(0xFA26).SetLocalPose(1.301801f,1.316274f,0.7837389f,-0.6143568f,-0.2151029f,0.477932f,0.5898114f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449399f,1.365059f,0.7839578f,-0.7101715f,0.009100926f,0.02386119f,0.7035654f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.954512f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 12.51254f);
Get(0xFA26).SetLocalPose(1.301171f,1.315988f,0.7838035f,-0.6120995f,-0.2188997f,0.4817638f,0.58764f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44943f,1.365122f,0.7839285f,-0.7101945f,0.009097876f,0.0238174f,0.7035437f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.983835f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 12.52207f);
Get(0xFA26).SetLocalPose(1.299315f,1.314966f,0.7845145f,-0.6062652f,-0.2288168f,0.4911852f,0.5820847f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449449f,1.365179f,0.7839958f,-0.7101996f,0.009084095f,0.02383989f,0.703538f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.048906f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 12.54322f);
Get(0xFA26).SetLocalPose(1.295101f,1.312556f,0.7849304f,-0.5921908f,-0.2515753f,0.5128928f,0.5682964f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449319f,1.365282f,0.7840201f,-0.7101846f,0.009128008f,0.02384281f,0.7035525f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.106943f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 12.56208f);
Get(0xFA26).SetLocalPose(1.290263f,1.309029f,0.7861224f,-0.5703635f,-0.2822309f,0.544179f,0.5467181f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449217f,1.36516f,0.7841278f,-0.710171f,0.009124462f,0.02384357f,0.7035663f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.163789f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 12.58056f);
Get(0xFA26).SetLocalPose(1.286074f,1.304891f,0.7871961f,-0.5470584f,-0.3111118f,0.5742461f,0.5236201f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449382f,1.365175f,0.7841816f,-0.7101793f,0.009112844f,0.0238374f,0.7035583f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.22087f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 12.59911f);
Get(0xFA26).SetLocalPose(1.284565f,1.301971f,0.7871849f,-0.5367191f,-0.3228136f,0.5862157f,0.5138823f);
});
r.Add(delegate{
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.248816f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 12.60819f);
Get(0xFA26).SetLocalPose(1.282284f,1.299314f,0.7869643f,-0.5269011f,-0.3329906f,0.5969597f,0.5051057f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449429f,1.364986f,0.7841006f,-0.7101778f,0.009084299f,0.02387288f,0.703559f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.309876f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 12.62803f);
Get(0xFA26).SetLocalPose(1.27796f,1.294956f,0.789719f,-0.5004365f,-0.3569093f,0.6242227f,0.4822086f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44946f,1.364909f,0.7841078f,-0.7101878f,0.009125381f,0.02390519f,0.7035472f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.367185f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 12.64666f);
Get(0xFA26).SetLocalPose(1.276845f,1.292052f,0.7900814f,-0.4902029f,-0.3647619f,0.6348845f,0.4728336f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44956f,1.365012f,0.7842751f,-0.7102117f,0.00909983f,0.02388311f,0.7035241f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.42628f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 12.66587f);
Get(0xFA26).SetLocalPose(1.274538f,1.289588f,0.7900165f,-0.4774067f,-0.3743394f,0.6470361f,0.4618411f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449545f,1.365093f,0.7842621f,-0.7102199f,0.009118525f,0.0238592f,0.7035164f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.452682f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 12.67445f);
Get(0xFA26).SetLocalPose(1.273943f,1.287412f,0.7905337f,-0.4692754f,-0.3801722f,0.6543162f,0.4551044f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449459f,1.36507f,0.7843044f,-0.7102357f,0.009116535f,0.0238825f,0.7034997f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.512117f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 12.69376f);
Get(0xFA26).SetLocalPose(1.273316f,1.285347f,0.7918243f,-0.4585665f,-0.3871262f,0.6637775f,0.4463738f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449647f,1.365001f,0.7843791f,-0.7102482f,0.009138641f,0.02387929f,0.7034869f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.570884f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 12.71286f);
Get(0xFA26).SetLocalPose(1.273367f,1.284572f,0.7921553f,-0.4547067f,-0.3895772f,0.6671008f,0.4432244f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449615f,1.36505f,0.7843551f,-0.7102224f,0.009123244f,0.02385576f,0.703514f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.599393f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 12.72213f);
Get(0xFA26).SetLocalPose(1.273085f,1.283709f,0.7924537f,-0.4509721f,-0.3918165f,0.6702929f,0.4402403f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449699f,1.365246f,0.7845692f,-0.7102386f,0.00910288f,0.02388684f,0.7034968f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.669418f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 12.74489f);
Get(0xFA26).SetLocalPose(1.272876f,1.282203f,0.7934093f,-0.4429562f,-0.3964288f,0.6770942f,0.4337943f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449637f,1.36525f,0.7844541f,-0.7102099f,0.009106828f,0.02389937f,0.7035254f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.732404f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 12.76536f);
Get(0xFA26).SetLocalPose(1.273352f,1.279117f,0.7943945f,-0.4281233f,-0.4046038f,0.6900767f,0.4204763f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449466f,1.365291f,0.7843059f,-0.7101761f,0.009108799f,0.02386959f,0.7035605f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.762822f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 12.77524f);
Get(0xFA26).SetLocalPose(1.274674f,1.278246f,0.7955006f,-0.422177f,-0.4072809f,0.6955007f,0.4149308f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449305f,1.365226f,0.7840906f,-0.7101648f,0.00912165f,0.02387947f,0.7035714f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.838348f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 12.79979f);
Get(0xFA26).SetLocalPose(1.275713f,1.276519f,0.7958286f,-0.4172625f,-0.4090995f,0.6999568f,0.4105974f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449198f,1.365146f,0.7839725f,-0.7101768f,0.009147345f,0.02385495f,0.7035598f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.866279f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 12.80887f);
Get(0xFA26).SetLocalPose(1.276758f,1.275239f,0.7957429f,-0.4148457f,-0.4099093f,0.702254f,0.4083097f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449277f,1.365081f,0.7840541f,-0.7101939f,0.009164682f,0.02387423f,0.7035416f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.93458f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 12.83106f);
Get(0xFA26).SetLocalPose(1.278429f,1.273531f,0.7951068f,-0.4124787f,-0.4106271f,0.7044646f,0.4061728f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449203f,1.365095f,0.7839168f,-0.7101834f,0.00918267f,0.02384898f,0.7035527f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.990491f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 12.84923f);
Get(0xFA26).SetLocalPose(1.279633f,1.273417f,0.7945397f,-0.4125741f,-0.4109753f,0.704251f,0.4060942f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.4492f,1.364939f,0.7838808f,-0.7101893f,0.009156381f,0.02388445f,0.7035459f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.015967f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 12.85751f);
Get(0xFA26).SetLocalPose(1.28038f,1.273445f,0.7942135f,-0.4125466f,-0.4111397f,0.7042148f,0.4060186f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449234f,1.365128f,0.7838972f,-0.7101812f,0.00916612f,0.02385054f,0.7035553f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.095181f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 12.88326f);
Get(0xFA26).SetLocalPose(1.282637f,1.273296f,0.794315f,-0.4121693f,-0.4109313f,0.7050592f,0.4051463f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449025f,1.364996f,0.7839534f,-0.7101797f,0.009177784f,0.0238473f,0.7035567f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.141335f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 12.89826f);
Get(0xFA26).SetLocalPose(1.282719f,1.273239f,0.794306f,-0.4121787f,-0.4108342f,0.7051529f,0.4050723f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448988f,1.364982f,0.7839382f,-0.7101775f,0.009179195f,0.02384359f,0.7035589f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.170515f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 12.90774f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448919f,1.364935f,0.7839004f,-0.7101746f,0.009182535f,0.02386843f,0.7035611f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.230836f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 12.92735f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449039f,1.365034f,0.7840816f,-0.7101899f,0.009105826f,0.02387586f,0.7035463f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.28731f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 12.9457f);
Get(0xFA26).SetLocalPose(1.283635f,1.273681f,0.7940661f,-0.4135892f,-0.4085891f,0.7055272f,0.4052533f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449055f,1.365163f,0.7841246f,-0.7101874f,0.009165971f,0.02384751f,0.703549f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.347079f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 12.96513f);
Get(0xFA26).SetLocalPose(1.285145f,1.273148f,0.7940242f,-0.4159898f,-0.4068618f,0.7042125f,0.4068179f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.4491f,1.365132f,0.7841069f,-0.710202f,0.009166508f,0.0238439f,0.7035344f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.372597f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 12.97342f);
Get(0xFA26).SetLocalPose(1.285588f,1.274464f,0.7949758f,-0.4169445f,-0.4060371f,0.7038367f,0.4073144f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449207f,1.364998f,0.7841616f,-0.7101974f,0.009151692f,0.02384656f,0.7035391f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.433792f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 12.99331f);
Get(0xFA26).SetLocalPose(1.285183f,1.274213f,0.7946163f,-0.418135f,-0.4044922f,0.7032303f,0.4086763f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449164f,1.365116f,0.784132f,-0.7101908f,0.009150698f,0.02383664f,0.7035462f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.490828f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 13.01184f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449156f,1.365016f,0.7842578f,-0.7102135f,0.009161139f,0.02382275f,0.7035235f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.551947f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 13.03171f);
Get(0xFA26).SetLocalPose(1.285191f,1.274375f,0.7945585f,-0.4187984f,-0.4037235f,0.7027913f,0.4095116f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449186f,1.365031f,0.7842568f,-0.710218f,0.009165966f,0.02381795f,0.7035192f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.578808f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 13.04044f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449308f,1.364816f,0.7842682f,-0.7102154f,0.00917286f,0.02381938f,0.7035215f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.640467f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 13.06048f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449403f,1.364896f,0.7843063f,-0.7102315f,0.009137233f,0.02381965f,0.7035057f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.696155f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 13.07858f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449283f,1.364833f,0.7841267f,-0.7102076f,0.00914199f,0.0238247f,0.7035298f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.752032f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 13.09674f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449387f,1.36483f,0.7841772f,-0.7101899f,0.009132357f,0.02383076f,0.7035475f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.809701f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 13.11548f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449353f,1.364828f,0.7842426f,-0.7102092f,0.009127479f,0.02385174f,0.7035273f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.836061f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 13.12404f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449311f,1.365024f,0.784223f,-0.7102016f,0.009109297f,0.02385023f,0.7035354f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.89681f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 13.14379f);
Get(0xFA26).SetLocalPose(1.284644f,1.27435f,0.7939444f,-0.4196967f,-0.4026408f,0.7022111f,0.4106515f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449322f,1.365073f,0.7841774f,-0.7102191f,0.009128673f,0.02383834f,0.7035179f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.954827f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 13.16264f);
Get(0xFA26).SetLocalPose(1.284106f,1.273165f,0.7937163f,-0.4245764f,-0.397764f,0.6994706f,0.4150415f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449452f,1.365038f,0.7841986f,-0.7102089f,0.009117639f,0.0238047f,0.7035294f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.013725f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 13.18179f);
Get(0xFA26).SetLocalPose(1.282943f,1.274389f,0.7921252f,-0.4328822f,-0.3895439f,0.6922549f,0.4262061f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44948f,1.365135f,0.7843213f,-0.7101923f,0.009145974f,0.02386119f,0.7035439f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.067989f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 13.19942f);
Get(0xFA26).SetLocalPose(1.28311f,1.276724f,0.7933127f,-0.4403338f,-0.3820844f,0.6851111f,0.4367384f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449491f,1.365158f,0.7843413f,-0.7101893f,0.009125249f,0.02385144f,0.7035475f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.094207f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 13.20794f);
Get(0xFA26).SetLocalPose(1.283545f,1.278128f,0.793384f,-0.4433157f,-0.3789357f,0.6823896f,0.4407079f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449361f,1.365117f,0.7843518f,-0.7102253f,0.009137761f,0.02384591f,0.7035112f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.15346f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 13.2272f);
Get(0xFA26).SetLocalPose(1.28352f,1.278846f,0.7933013f,-0.4460535f,-0.3759843f,0.6799129f,0.4442866f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44934f,1.365135f,0.7842964f,-0.7102034f,0.009124094f,0.023853f,0.7035332f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.207825f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 13.24487f);
Get(0xFA26).SetLocalPose(1.284119f,1.279805f,0.7930958f,-0.4503238f,-0.3714952f,0.6759906f,0.4497072f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449338f,1.365104f,0.7842687f,-0.7102023f,0.00913556f,0.02383659f,0.7035347f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.262058f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 13.26249f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449306f,1.365169f,0.7841257f,-0.7102008f,0.009131158f,0.02381916f,0.7035369f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.318583f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 13.28086f);
Get(0xFA26).SetLocalPose(1.283938f,1.2804f,0.792594f,-0.4536224f,-0.3680392f,0.6726606f,0.4542044f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449449f,1.365098f,0.7842978f,-0.7102278f,0.009105461f,0.02385323f,0.7035088f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.374049f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 13.29889f);
Get(0xFA26).SetLocalPose(1.283266f,1.284441f,0.790868f,-0.4701813f,-0.3509596f,0.6552331f,0.475843f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449408f,1.36502f,0.7843363f,-0.7102146f,0.009137688f,0.0238307f,0.7035224f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.399931f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 13.3073f);
Get(0xFA26).SetLocalPose(1.28345f,1.285401f,0.7905834f,-0.4737681f,-0.3472874f,0.6513935f,0.4802309f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449338f,1.365059f,0.7842904f,-0.7102221f,0.009156299f,0.02379536f,0.7035158f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.4598f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 13.32676f);
Get(0xFA26).SetLocalPose(1.283741f,1.288934f,0.7906772f,-0.4866927f,-0.3351581f,0.6377845f,0.4939941f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449107f,1.365f,0.7842163f,-0.7102196f,0.00918531f,0.02380883f,0.7035176f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.515907f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 13.34499f);
Get(0xFA26).SetLocalPose(1.283313f,1.292947f,0.7889811f,-0.5070809f,-0.3132574f,0.6200256f,0.5102031f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449182f,1.365022f,0.7843871f,-0.7102438f,0.009176853f,0.02379794f,0.7034936f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.571094f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 13.36293f);
Get(0xFA26).SetLocalPose(1.285383f,1.299525f,0.7873372f,-0.5396078f,-0.274177f,0.5858325f,0.5389348f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449093f,1.364923f,0.7843522f,-0.7102275f,0.009149341f,0.02382389f,0.7035096f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.627224f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 13.38117f);
Get(0xFA26).SetLocalPose(1.287318f,1.304909f,0.7858292f,-0.5543689f,-0.2550961f,0.5622137f,0.5581372f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449101f,1.364871f,0.7843487f,-0.7102242f,0.00917086f,0.023827f,0.7035125f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.683556f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 13.39948f);
Get(0xFA26).SetLocalPose(1.287424f,1.310413f,0.7854954f,-0.5692512f,-0.2326952f,0.5405156f,0.5741506f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449141f,1.364894f,0.7842979f,-0.7102255f,0.009151553f,0.02382878f,0.7035114f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.708693f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 13.40765f);
Get(0xFA26).SetLocalPose(1.288209f,1.31179f,0.7851251f,-0.5738739f,-0.2251411f,0.5342164f,0.5784401f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449094f,1.364873f,0.7842232f,-0.7102079f,0.009123795f,0.02386445f,0.7035283f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.766338f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 13.42638f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449206f,1.364914f,0.7842587f,-0.7102065f,0.009105759f,0.02388851f,0.7035291f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.821897f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 13.44444f);
Get(0xFA26).SetLocalPose(1.293905f,1.320184f,0.7823877f,-0.6062355f,-0.1697833f,0.4832243f,0.6083965f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449319f,1.36486f,0.7843015f,-0.7102225f,0.009109392f,0.02388743f,0.7035129f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.876467f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 13.46218f);
Get(0xFA26).SetLocalPose(1.300089f,1.325997f,0.7802455f,-0.6227117f,-0.1381953f,0.4420612f,0.6306458f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449713f,1.364867f,0.7844608f,-0.7102492f,0.009092776f,0.02388884f,0.7034862f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.931752f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 13.48014f);
Get(0xFA26).SetLocalPose(1.305747f,1.331198f,0.7785551f,-0.6359252f,-0.1056786f,0.4088159f,0.6459882f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449641f,1.365087f,0.7843727f,-0.7102321f,0.009145584f,0.02387126f,0.7035034f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.990539f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 13.49925f);
Get(0xFA26).SetLocalPose(1.313026f,1.335286f,0.7764778f,-0.653463f,-0.05069781f,0.3576221f,0.6652234f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449556f,1.365203f,0.7844053f,-0.7102371f,0.009158163f,0.02386895f,0.7034982f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.01728f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 13.50794f);
Get(0xFA26).SetLocalPose(1.321062f,1.338345f,0.7748888f,-0.6636525f,-0.004551797f,0.3073683f,0.68196f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449274f,1.365254f,0.7843174f,-0.7102209f,0.009180118f,0.02389032f,0.7035136f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.075321f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 13.5268f);
Get(0xFA26).SetLocalPose(1.328143f,1.339475f,0.7738706f,-0.6689143f,0.03175799f,0.2620509f,0.6948917f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449261f,1.365111f,0.7843138f,-0.7102282f,0.009181205f,0.02389129f,0.7035061f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.131902f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 13.54519f);
Get(0xFA26).SetLocalPose(1.339985f,1.340397f,0.7725192f,-0.6724752f,0.08405863f,0.1989688f,0.7079002f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449103f,1.365018f,0.7842553f,-0.7102073f,0.009211477f,0.02383889f,0.7035286f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.186403f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 13.5629f);
Get(0xFA26).SetLocalPose(1.348244f,1.33938f,0.7722002f,-0.6710121f,0.1311095f,0.1489016f,0.7144099f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449062f,1.364973f,0.7841899f,-0.7102185f,0.009246556f,0.02382079f,0.7035174f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.242041f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 13.58099f);
Get(0xFA26).SetLocalPose(1.360227f,1.33405f,0.7706642f,-0.6714973f,0.1914803f,0.07027186f,0.7123824f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448991f,1.364934f,0.7840973f,-0.7102055f,0.009226623f,0.02384008f,0.7035302f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.296775f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 13.59877f);
Get(0xFA26).SetLocalPose(1.365445f,1.330476f,0.7701071f,-0.6698568f,0.2172883f,0.03264663f,0.7092333f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448894f,1.364953f,0.7840804f,-0.7102067f,0.009204951f,0.02381078f,0.7035302f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.321888f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 13.60694f);
Get(0xFA26).SetLocalPose(1.368122f,1.328647f,0.7703249f,-0.6660333f,0.234272f,0.009808786f,0.7081102f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448781f,1.365002f,0.7839922f,-0.7101917f,0.009201521f,0.02381389f,0.7035453f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.380419f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 13.62596f);
Get(0xFA26).SetLocalPose(1.372942f,1.324435f,0.7711231f,-0.6545712f,0.2663126f,-0.03117389f,0.7068539f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448734f,1.364842f,0.7840222f,-0.7102004f,0.00920047f,0.02385672f,0.7035351f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.434855f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 13.64365f);
Get(0xFA26).SetLocalPose(1.37629f,1.320994f,0.771191f,-0.646887f,0.2869767f,-0.05794309f,0.7041479f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448796f,1.364679f,0.7839452f,-0.7101824f,0.009178055f,0.0238425f,0.703554f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.489168f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 13.6613f);
Get(0xFA26).SetLocalPose(1.378358f,1.317406f,0.7708762f,-0.6428299f,0.3047087f,-0.08212824f,0.6979809f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448747f,1.364759f,0.7839219f,-0.7101806f,0.009175856f,0.02387017f,0.7035549f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.543166f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 13.67885f);
Get(0xFA26).SetLocalPose(1.379818f,1.31389f,0.7701731f,-0.6422652f,0.3183137f,-0.1009908f,0.6899078f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449049f,1.364877f,0.7839667f,-0.7101844f,0.009158295f,0.02386034f,0.7035517f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.600374f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 13.69745f);
Get(0xFA26).SetLocalPose(1.38142f,1.309514f,0.7697691f,-0.6396452f,0.3373029f,-0.1275476f,0.6788317f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449179f,1.364911f,0.7839118f,-0.7101974f,0.009168335f,0.02385466f,0.7035386f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.656048f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 13.71554f);
Get(0xFA26).SetLocalPose(1.383206f,1.305952f,0.76951f,-0.633199f,0.3529106f,-0.1495391f,0.672422f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449211f,1.364966f,0.7839509f,-0.7102003f,0.00912533f,0.02384003f,0.7035368f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.681423f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 13.72379f);
Get(0xFA26).SetLocalPose(1.384227f,1.303604f,0.7696481f,-0.6278253f,0.3631337f,-0.1644081f,0.6685353f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449311f,1.365045f,0.784067f,-0.7102058f,0.00911605f,0.02386001f,0.7035307f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.74194f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 13.74345f);
Get(0xFA26).SetLocalPose(1.385134f,1.300862f,0.769762f,-0.6223897f,0.3728532f,-0.1798346f,0.6642824f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449608f,1.365085f,0.7842627f,-0.7102235f,0.00908753f,0.02387843f,0.7035125f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.798028f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 13.76168f);
Get(0xFA26).SetLocalPose(1.38594f,1.298255f,0.7698199f,-0.6190338f,0.3810436f,-0.1928536f,0.6590983f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449683f,1.365099f,0.7844027f,-0.7102234f,0.009097425f,0.02387819f,0.7035125f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.855087f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 13.78023f);
Get(0xFA26).SetLocalPose(1.38641f,1.296333f,0.7697336f,-0.6169196f,0.3885681f,-0.2020165f,0.6539223f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449827f,1.365157f,0.784435f,-0.7102248f,0.009053501f,0.02387552f,0.7035118f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.910775f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 13.79833f);
Get(0xFA26).SetLocalPose(1.387131f,1.29557f,0.7694615f,-0.6135152f,0.3955277f,-0.2104965f,0.6502678f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449803f,1.365131f,0.7845204f,-0.7102255f,0.009077242f,0.02386746f,0.703511f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.965737f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 13.81619f);
Get(0xFA26).SetLocalPose(1.387484f,1.293806f,0.76963f,-0.6087961f,0.4028253f,-0.220395f,0.6469352f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449694f,1.365151f,0.7844704f,-0.7102255f,0.009079688f,0.02386682f,0.7035111f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.99141f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 13.82453f);
Get(0xFA26).SetLocalPose(1.387448f,1.293141f,0.7695996f,-0.6073813f,0.4049622f,-0.2237889f,0.6457648f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449605f,1.365268f,0.7844135f,-0.7102086f,0.009123181f,0.02386639f,0.7035276f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 7.052604f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 13.84442f);
Get(0xFA26).SetLocalPose(1.387362f,1.291894f,0.7695683f,-0.6050481f,0.4081455f,-0.2307087f,0.643512f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449466f,1.365169f,0.7843707f,-0.7101988f,0.009126808f,0.0238483f,0.7035379f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 7.110268f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 13.86316f);
Get(0xFA26).SetLocalPose(1.387456f,1.290915f,0.7695957f,-0.6036943f,0.4099065f,-0.2348997f,0.6421465f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449508f,1.365138f,0.7843161f,-0.7102128f,0.009099627f,0.0238782f,0.7035232f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 7.168333f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 13.88203f);
Get(0xFA26).SetLocalPose(1.388103f,1.289419f,0.7697794f,-0.6016709f,0.4122791f,-0.2379835f,0.6413907f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449482f,1.365095f,0.7841909f,-0.7101994f,0.009110061f,0.02387463f,0.7035367f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 7.194038f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 13.89038f);
Get(0xFA26).SetLocalPose(1.388506f,1.288973f,0.7695525f,-0.5998858f,0.4142135f,-0.240071f,0.6410383f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44948f,1.365194f,0.7842458f,-0.7101994f,0.009098721f,0.02386061f,0.7035373f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 7.254674f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 13.91009f);
Get(0xFA26).SetLocalPose(1.388879f,1.288539f,0.769648f,-0.5973088f,0.416719f,-0.2433023f,0.6406025f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449506f,1.365181f,0.7842461f,-0.7101821f,0.00911916f,0.02387461f,0.703554f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 7.309933f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 13.92805f);
Get(0xFA26).SetLocalPose(1.38942f,1.288993f,0.7694256f,-0.5951182f,0.4186894f,-0.2465484f,0.6401151f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449303f,1.365131f,0.7841736f,-0.710187f,0.009135531f,0.02384871f,0.7035498f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 7.366504f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 13.94644f);
Get(0xFA26).SetLocalPose(1.389775f,1.289084f,0.7695616f,-0.5932267f,0.4201612f,-0.2497678f,0.6396585f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449236f,1.365207f,0.7841355f,-0.7101763f,0.009127093f,0.02383823f,0.7035609f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 7.424714f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 13.96536f);
Get(0xFA26).SetLocalPose(1.389914f,1.289697f,0.769448f,-0.592541f,0.4205911f,-0.2509803f,0.6395368f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449215f,1.365206f,0.7840827f,-0.7101801f,0.009156524f,0.02384084f,0.7035567f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 7.45172f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 13.97413f);
Get(0xFA26).SetLocalPose(1.389776f,1.289495f,0.7693031f,-0.5922535f,0.4207113f,-0.2511783f,0.6396462f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449129f,1.365003f,0.7841392f,-0.7101914f,0.009177986f,0.0238343f,0.7035453f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 7.51146f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 13.99355f);
Get(0xFA26).SetLocalPose(1.389954f,1.288912f,0.7696411f,-0.5907437f,0.4217856f,-0.2528186f,0.6396887f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449146f,1.36496f,0.7842466f,-0.710215f,0.009155618f,0.02384536f,0.7035214f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 7.565999f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 14.01127f);
Get(0xFA26).SetLocalPose(1.390208f,1.288819f,0.7698415f,-0.5887139f,0.4235592f,-0.2556223f,0.6392736f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44918f,1.365026f,0.7840618f,-0.7101874f,0.009187447f,0.0238523f,0.7035486f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 7.622295f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 14.02957f);
Get(0xFA26).SetLocalPose(1.39056f,1.288621f,0.7699685f,-0.5876264f,0.4243869f,-0.2577387f,0.6388754f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449083f,1.364881f,0.783982f,-0.7101802f,0.00915011f,0.02384525f,0.7035566f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 7.677883f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 14.04764f);
Get(0xFA26).SetLocalPose(1.390764f,1.288484f,0.7696f,-0.5879067f,0.4240818f,-0.2590906f,0.6382731f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449053f,1.364934f,0.7838359f,-0.7101908f,0.00914814f,0.02387557f,0.7035449f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 7.733852f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 14.06583f);
Get(0xFA26).SetLocalPose(1.390968f,1.288193f,0.7701175f,-0.5873417f,0.424693f,-0.2605852f,0.6377782f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449032f,1.364923f,0.7838052f,-0.7101705f,0.009141051f,0.02385444f,0.7035661f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 7.758645f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 14.07388f);
Get(0xFA26).SetLocalPose(1.391078f,1.287705f,0.7701226f,-0.58597f,0.4258712f,-0.2622791f,0.6375598f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449188f,1.364886f,0.7840901f,-0.7101955f,0.009137814f,0.02384873f,0.7035412f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 7.819874f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 14.09378f);
Get(0xFA26).SetLocalPose(1.391301f,1.287144f,0.7702789f,-0.58285f,0.428584f,-0.2662493f,0.636956f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44926f,1.364875f,0.7840439f,-0.7101901f,0.009137252f,0.02388892f,0.7035453f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 7.874346f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 14.11149f);
Get(0xFA26).SetLocalPose(1.391779f,1.286172f,0.7705629f,-0.5793199f,0.4315503f,-0.2715434f,0.6359379f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449287f,1.365143f,0.7841733f,-0.7101787f,0.009140199f,0.02388004f,0.703557f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 7.929551f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 14.12943f);
Get(0xFA26).SetLocalPose(1.392246f,1.285487f,0.7706949f,-0.577664f,0.4328803f,-0.2752659f,0.6349392f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449349f,1.365035f,0.784098f,-0.7101849f,0.009131142f,0.02389626f,0.7035503f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 7.986692f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 14.148f);
Get(0xFA26).SetLocalPose(1.392058f,1.284444f,0.770506f,-0.576346f,0.4343127f,-0.2792518f,0.6334163f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449365f,1.365172f,0.7841251f,-0.7101915f,0.009170267f,0.02388297f,0.7035436f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 8.042482f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 14.16613f);
Get(0xFA26).SetLocalPose(1.391847f,1.283913f,0.770641f,-0.5746526f,0.4363391f,-0.2828055f,0.631984f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449434f,1.365019f,0.7840948f,-0.7101786f,0.009169184f,0.02387204f,0.703557f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 8.06707f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 14.17412f);
Get(0xFA26).SetLocalPose(1.391991f,1.283458f,0.7707145f,-0.5733139f,0.4376364f,-0.2849373f,0.631345f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449381f,1.365052f,0.7841216f,-0.7102024f,0.009158663f,0.02387189f,0.7035332f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 8.125911f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 14.19325f);
Get(0xFA26).SetLocalPose(1.392061f,1.28258f,0.7708158f,-0.5695544f,0.4406798f,-0.2899481f,0.6303486f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449257f,1.364889f,0.7840021f,-0.7102094f,0.009149952f,0.02385855f,0.7035266f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 8.181491f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 14.21131f);
Get(0xFA26).SetLocalPose(1.392608f,1.281099f,0.771161f,-0.5644866f,0.4447848f,-0.2968028f,0.6288319f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449189f,1.364934f,0.783878f,-0.7101894f,0.009202806f,0.02383494f,0.703547f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 8.23687f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 14.22931f);
Get(0xFA26).SetLocalPose(1.393199f,1.279793f,0.7713267f,-0.5580122f,0.4499792f,-0.3067807f,0.6261203f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449054f,1.365002f,0.7838935f,-0.7101899f,0.009152865f,0.02384587f,0.7035467f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 8.294147f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 14.24792f);
Get(0xFA26).SetLocalPose(1.393373f,1.278427f,0.7716571f,-0.5538283f,0.453346f,-0.3143275f,0.6236585f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449055f,1.365013f,0.783982f,-0.7101924f,0.00917448f,0.02385128f,0.7035437f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 8.32046f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 14.25647f);
Get(0xFA26).SetLocalPose(1.393746f,1.278357f,0.7715235f,-0.5509545f,0.4557323f,-0.3194696f,0.6218492f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449047f,1.365097f,0.7839866f,-0.7101799f,0.009159465f,0.02383909f,0.703557f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 8.381707f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 14.27638f);
Get(0xFA26).SetLocalPose(1.393772f,1.277106f,0.7712823f,-0.5457692f,0.4596789f,-0.3271849f,0.6195009f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449099f,1.364985f,0.7839438f,-0.7101752f,0.009183438f,0.02388846f,0.7035597f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 8.435637f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 14.29391f);
Get(0xFA26).SetLocalPose(1.394178f,1.276215f,0.7713952f,-0.5395058f,0.4642837f,-0.3359004f,0.6168833f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44914f,1.364937f,0.7838857f,-0.7101902f,0.009134195f,0.02388315f,0.7035454f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 8.489495f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 14.31141f);
Get(0xFA26).SetLocalPose(1.39473f,1.274195f,0.7719076f,-0.529415f,0.4714891f,-0.3503876f,0.6120837f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449322f,1.364933f,0.7840539f,-0.7101931f,0.009133513f,0.02387583f,0.7035427f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 8.547785f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 14.33035f);
Get(0xFA26).SetLocalPose(1.395243f,1.271099f,0.7726212f,-0.5182447f,0.4790393f,-0.3669912f,0.6060208f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449275f,1.365063f,0.7839664f,-0.7101778f,0.009128399f,0.02387609f,0.7035582f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 8.60309f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 14.34833f);
Get(0xFA26).SetLocalPose(1.39538f,1.269239f,0.7728932f,-0.5098293f,0.4843833f,-0.3792445f,0.6013489f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449295f,1.365028f,0.7839772f,-0.7101928f,0.009122926f,0.02387556f,0.7035432f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 8.629532f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 14.35692f);
Get(0xFA26).SetLocalPose(1.395728f,1.268453f,0.7727487f,-0.5044224f,0.4877295f,-0.3862692f,0.598727f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449227f,1.365126f,0.7839729f,-0.7101844f,0.009141983f,0.02386979f,0.7035516f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 8.689911f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 14.37655f);
Get(0xFA26).SetLocalPose(1.396382f,1.266583f,0.7729617f,-0.4916713f,0.4954788f,-0.400813f,0.5933878f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449237f,1.365174f,0.783898f,-0.710179f,0.009127663f,0.02387203f,0.7035571f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 8.745398f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 14.39458f);
Get(0xFA26).SetLocalPose(1.396346f,1.263866f,0.7734052f,-0.4811552f,0.5020323f,-0.4130483f,0.5880853f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449419f,1.365155f,0.7840891f,-0.7101873f,0.009114924f,0.02388245f,0.7035486f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 8.799302f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 14.4121f);
Get(0xFA26).SetLocalPose(1.396252f,1.261663f,0.7735603f,-0.470904f,0.5080695f,-0.426172f,0.5818008f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449608f,1.365135f,0.7843636f,-0.7102248f,0.00909185f,0.02387051f,0.7035115f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 8.859258f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 14.43158f);
Get(0xFA26).SetLocalPose(1.396077f,1.259452f,0.7746431f,-0.4614331f,0.51369f,-0.4387128f,0.5750941f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449645f,1.365232f,0.7845162f,-0.7102307f,0.009098677f,0.02386885f,0.7035054f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 8.885571f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 14.44014f);
Get(0xFA26).SetLocalPose(1.39636f,1.259558f,0.7757087f,-0.4572816f,0.5163523f,-0.4442105f,0.5717963f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449651f,1.365309f,0.78447f,-0.7102163f,0.009091673f,0.02387742f,0.7035198f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 8.944726f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 14.45936f);
Get(0xFA26).SetLocalPose(1.396588f,1.258128f,0.7762629f,-0.4497745f,0.5213557f,-0.4533788f,0.5659848f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44952f,1.365299f,0.7844747f,-0.7102139f,0.009140608f,0.02386579f,0.703522f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 9.001958f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 14.47796f);
Get(0xFA26).SetLocalPose(1.397023f,1.257142f,0.7761517f,-0.4417452f,0.5262062f,-0.4614369f,0.5612881f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449322f,1.365173f,0.7843073f,-0.7102122f,0.009148554f,0.02384664f,0.7035243f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 9.061713f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 14.49738f);
Get(0xFA26).SetLocalPose(1.397244f,1.256528f,0.7769257f,-0.4339139f,0.5300936f,-0.4688086f,0.5576182f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449317f,1.365068f,0.7843005f,-0.7101993f,0.009159842f,0.02385878f,0.7035367f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 9.118017f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 14.51568f);
Get(0xFA26).SetLocalPose(1.397712f,1.256612f,0.7775703f,-0.4281456f,0.5324273f,-0.4748158f,0.5547636f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449367f,1.364967f,0.784297f,-0.7102017f,0.009134768f,0.02383277f,0.7035356f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 9.143203f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 14.52386f);
Get(0xFA26).SetLocalPose(1.398274f,1.25632f,0.777769f,-0.425258f,0.5334259f,-0.4785795f,0.5527877f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449439f,1.364944f,0.7843924f,-0.7102304f,0.009131148f,0.02385227f,0.7035059f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 9.204214f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 14.54369f);
Get(0xFA26).SetLocalPose(1.398869f,1.256033f,0.7779095f,-0.4219261f,0.5341338f,-0.4841695f,0.5497813f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449332f,1.364864f,0.7843493f,-0.7102554f,0.009112108f,0.02385136f,0.7034809f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 9.261085f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 14.56218f);
Get(0xFA26).SetLocalPose(1.399466f,1.255112f,0.7783678f,-0.4190726f,0.5344383f,-0.4898568f,0.5466207f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449284f,1.364969f,0.7843384f,-0.7102518f,0.009133322f,0.0238436f,0.7034845f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 9.318645f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 14.58088f);
Get(0xFA26).SetLocalPose(1.4002f,1.253858f,0.7788603f,-0.4154677f,0.5360082f,-0.4945231f,0.5436255f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449044f,1.36491f,0.7842563f,-0.7102248f,0.009143037f,0.02380658f,0.703513f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 9.375738f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 14.59944f);
Get(0xFA26).SetLocalPose(1.401732f,1.252817f,0.780176f,-0.4097299f,0.5388483f,-0.5014572f,0.5387992f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449109f,1.364943f,0.7842684f,-0.7102321f,0.009173157f,0.02380381f,0.7035053f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 9.402297f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 14.60807f);
Get(0xFA26).SetLocalPose(1.401787f,1.251817f,0.780369f,-0.4078652f,0.5395363f,-0.5043262f,0.5368441f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44889f,1.36501f,0.7842512f,-0.7102159f,0.009197065f,0.02382038f,0.7035208f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 9.4628f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 14.62773f);
Get(0xFA26).SetLocalPose(1.402765f,1.250781f,0.7807594f,-0.4064016f,0.5394926f,-0.5081701f,0.5343677f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449042f,1.364744f,0.7842559f,-0.7102134f,0.009168985f,0.02385368f,0.7035226f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 9.519686f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 14.64622f);
Get(0xFA26).SetLocalPose(1.402696f,1.249812f,0.7812831f,-0.4059203f,0.5382969f,-0.5121216f,0.5321624f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449283f,1.364849f,0.7842537f,-0.7102106f,0.009119615f,0.02386269f,0.7035257f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 9.578916f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 14.66547f);
Get(0xFA26).SetLocalPose(1.403932f,1.24844f,0.7817374f,-0.4053044f,0.5374146f,-0.514845f,0.5308942f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449386f,1.364908f,0.7842434f,-0.7102224f,0.009108283f,0.02386291f,0.7035139f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 9.607473f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 14.67475f);
Get(0xFA26).SetLocalPose(1.40471f,1.247433f,0.7824761f,-0.4047928f,0.5373146f,-0.5160313f,0.5302336f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449499f,1.365022f,0.7841974f,-0.7102283f,0.009095021f,0.02390388f,0.7035068f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 9.681973f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 14.69897f);
Get(0xFA26).SetLocalPose(1.405045f,1.246894f,0.7835546f,-0.4030873f,0.5376619f,-0.5183483f,0.5289193f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449522f,1.36503f,0.7842588f,-0.7102507f,0.009110815f,0.02390023f,0.7034839f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 9.709593f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 14.70794f);
Get(0xFA26).SetLocalPose(1.405739f,1.247154f,0.7840782f,-0.4021204f,0.5377881f,-0.5201456f,0.5277611f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449577f,1.36493f,0.7843025f,-0.7102389f,0.009114628f,0.02385841f,0.7034973f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 9.770951f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 14.72788f);
Get(0xFA26).SetLocalPose(1.407165f,1.246506f,0.7846171f,-0.4018246f,0.5373052f,-0.5221585f,0.5264891f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449548f,1.364988f,0.7843297f,-0.7102444f,0.009118362f,0.02387383f,0.7034912f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 9.826759f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 14.74602f);
Get(0xFA26).SetLocalPose(1.407688f,1.245202f,0.7846265f,-0.4021116f,0.5365525f,-0.5237554f,0.5254503f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449549f,1.365058f,0.7843493f,-0.7102544f,0.009107111f,0.02387445f,0.7034813f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 9.885304f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 14.76505f);
Get(0xFA26).SetLocalPose(1.408415f,1.244502f,0.7846095f,-0.4030151f,0.5353797f,-0.5249563f,0.5247555f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449567f,1.364991f,0.7843435f,-0.7102411f,0.009088445f,0.02387676f,0.7034948f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 9.940922f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 14.78312f);
Get(0xFA26).SetLocalPose(1.408644f,1.245262f,0.7847984f,-0.4030989f,0.5352213f,-0.5251042f,0.5247048f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449579f,1.36498f,0.7844436f,-0.7102221f,0.009070845f,0.02387851f,0.7035141f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 9.967029f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 14.79161f);
Get(0xFA26).SetLocalPose(1.409836f,1.245035f,0.7848701f,-0.4026527f,0.5350173f,-0.5254425f,0.5249167f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449594f,1.365124f,0.7844407f,-0.710237f,0.009082397f,0.02386754f,0.7034994f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 10.0265f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 14.81094f);
Get(0xFA26).SetLocalPose(1.411523f,1.2446f,0.7857277f,-0.4017536f,0.5347912f,-0.5263843f,0.5248924f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449638f,1.365091f,0.7843835f,-0.7102285f,0.00910036f,0.02386195f,0.7035078f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 10.08282f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 14.82924f);
Get(0xFA26).SetLocalPose(1.411502f,1.243141f,0.786067f,-0.4011083f,0.5343068f,-0.5272512f,0.5250093f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44953f,1.365207f,0.7844537f,-0.7102354f,0.009114408f,0.02386515f,0.7035007f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 10.14047f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 14.84798f);
Get(0xFA26).SetLocalPose(1.412213f,1.242677f,0.7864515f,-0.4012648f,0.5334421f,-0.5275264f,0.5254923f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449516f,1.365246f,0.7844547f,-0.7102357f,0.009100911f,0.02386133f,0.7035006f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 10.16645f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 14.85642f);
Get(0xFA26).SetLocalPose(1.411505f,1.242368f,0.7863399f,-0.4014679f,0.5324135f,-0.5272114f,0.5266949f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449547f,1.365193f,0.7844299f,-0.7102368f,0.009107881f,0.02387196f,0.7034991f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 10.22846f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 14.87658f);
Get(0xFA26).SetLocalPose(1.411948f,1.241331f,0.7868345f,-0.4004742f,0.5314679f,-0.5263759f,0.5292361f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449573f,1.365113f,0.7843106f,-0.7102316f,0.009086793f,0.02387414f,0.7035045f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 10.28627f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 14.89536f);
Get(0xFA26).SetLocalPose(1.412268f,1.240132f,0.7872136f,-0.3974203f,0.5299903f,-0.5249459f,0.5344149f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449532f,1.365146f,0.7843034f,-0.7102167f,0.009124294f,0.02386991f,0.7035193f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 10.34364f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 14.91401f);
Get(0xFA26).SetLocalPose(1.411466f,1.239942f,0.7868165f,-0.3950692f,0.5267758f,-0.5238119f,0.5404153f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449461f,1.365076f,0.7844542f,-0.710205f,0.009093489f,0.02388588f,0.7035309f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 14.93243f);
Get(0xFA26).SetLocalPose(1.412184f,1.239991f,0.7867055f,-0.393829f,0.5242844f,-0.5233397f,0.5441877f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449387f,1.365034f,0.7844173f,-0.7102109f,0.009097906f,0.02385135f,0.703526f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.02696923f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 14.9412f);
Get(0xFA26).SetLocalPose(1.412417f,1.239658f,0.786838f,-0.392276f,0.5233149f,-0.5239062f,0.5456953f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449465f,1.365056f,0.7843661f,-0.710221f,0.009123088f,0.02385661f,0.7035154f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.08912677f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 14.9614f);
Get(0xFA26).SetLocalPose(1.412983f,1.24055f,0.7868642f,-0.3892284f,0.5225704f,-0.5227267f,0.5497075f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449559f,1.365197f,0.7843071f,-0.7102169f,0.009142259f,0.02384296f,0.7035196f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.1461686f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 14.97994f);
Get(0xFA26).SetLocalPose(1.412724f,1.240487f,0.7880466f,-0.3828039f,0.5215985f,-0.522853f,0.5549963f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449518f,1.36511f,0.784277f,-0.7102215f,0.009145684f,0.02383645f,0.7035152f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.2006754f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 14.99765f);
Get(0xFA26).SetLocalPose(1.412744f,1.240666f,0.7883338f,-0.3813008f,0.5206661f,-0.5236153f,0.5561866f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449395f,1.365131f,0.7842016f,-0.7102065f,0.009136515f,0.02385347f,0.7035299f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.2566308f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 15.01584f);
Get(0xFA26).SetLocalPose(1.41203f,1.240581f,0.7894155f,-0.3834644f,0.5201163f,-0.52622f,0.5527448f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449249f,1.365089f,0.7841958f,-0.7102058f,0.009156218f,0.0238339f,0.703531f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.2804951f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 15.0236f);
Get(0xFA26).SetLocalPose(1.411693f,1.240587f,0.7891703f,-0.3846797f,0.520677f,-0.5279969f,0.5496693f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449156f,1.365093f,0.7842101f,-0.7102126f,0.00917706f,0.02382094f,0.7035243f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.3401532f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 15.04298f);
Get(0xFA26).SetLocalPose(1.410812f,1.240421f,0.7884113f,-0.389265f,0.5238149f,-0.5325637f,0.5389496f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449096f,1.365075f,0.7841973f,-0.7102153f,0.009161019f,0.02381776f,0.703522f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.3946265f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 15.06069f);
Get(0xFA26).SetLocalPose(1.410522f,1.238779f,0.7890474f,-0.3932749f,0.5277496f,-0.5373314f,0.5273426f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448927f,1.365034f,0.7841511f,-0.7101992f,0.009182638f,0.02382953f,0.7035375f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.4495274f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 15.07853f);
Get(0xFA26).SetLocalPose(1.408536f,1.237151f,0.7882957f,-0.397853f,0.5338835f,-0.5427506f,0.5119601f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448961f,1.365146f,0.7841859f,-0.710184f,0.009170516f,0.02385413f,0.7035522f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.5063176f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 15.09699f);
Get(0xFA26).SetLocalPose(1.406684f,1.233416f,0.7881936f,-0.4055246f,0.5391304f,-0.5463078f,0.4964232f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449005f,1.365137f,0.7841595f,-0.7102027f,0.009153483f,0.02384683f,0.7035337f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.5623139f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 15.11519f);
Get(0xFA26).SetLocalPose(1.405803f,1.232254f,0.7886147f,-0.4163919f,0.540354f,-0.546747f,0.4854926f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449054f,1.365072f,0.7841536f,-0.7101911f,0.009165047f,0.02382772f,0.7035459f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.6172994f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 15.13306f);
Get(0xFA26).SetLocalPose(1.404705f,1.231825f,0.7883385f,-0.4260464f,0.5403957f,-0.5470017f,0.4767035f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449073f,1.364878f,0.7841195f,-0.7102059f,0.00914009f,0.02383181f,0.7035313f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.6421686f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 15.14114f);
Get(0xFA26).SetLocalPose(1.404671f,1.231464f,0.7882665f,-0.4291457f,0.5400804f,-0.5468869f,0.4744069f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449145f,1.364863f,0.784212f,-0.7102013f,0.009136702f,0.02385719f,0.703535f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.7030295f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 15.16092f);
Get(0xFA26).SetLocalPose(1.404287f,1.231657f,0.788286f,-0.4333928f,0.5397695f,-0.5471616f,0.4705675f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449269f,1.364824f,0.7842215f,-0.7102067f,0.009108153f,0.02386515f,0.7035296f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.7588664f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 15.17907f);
Get(0xFA26).SetLocalPose(1.404492f,1.229959f,0.7890857f,-0.4353137f,0.539714f,-0.5489458f,0.4667647f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449245f,1.365049f,0.7841299f,-0.7101988f,0.009117601f,0.02384518f,0.7035382f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.8153846f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 15.19744f);
Get(0xFA26).SetLocalPose(1.404818f,1.229188f,0.789755f,-0.4377947f,0.5388726f,-0.5511001f,0.4628617f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449338f,1.365167f,0.7841212f,-0.710206f,0.009105202f,0.02384557f,0.7035311f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.8722671f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 15.21592f);
Get(0xFA26).SetLocalPose(1.404562f,1.229705f,0.7890716f,-0.4412958f,0.537749f,-0.5520575f,0.4596919f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449323f,1.365101f,0.7841748f,-0.7101969f,0.009152454f,0.02383887f,0.70354f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.8970932f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 15.22399f);
Get(0xFA26).SetLocalPose(1.404888f,1.228905f,0.7885305f,-0.4431797f,0.5371235f,-0.552124f,0.4585296f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44927f,1.365056f,0.7840493f,-0.710181f,0.009152894f,0.0238285f,0.7035563f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.9459563f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 15.23987f);
Get(0xFA26).SetLocalPose(1.40528f,1.228263f,0.7879091f,-0.4473051f,0.5355049f,-0.5520037f,0.4565573f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449283f,1.365052f,0.7840251f,-0.7101846f,0.009146465f,0.02384668f,0.7035521f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.025783f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 15.26582f);
Get(0xFA26).SetLocalPose(1.405634f,1.227504f,0.7881512f,-0.4503865f,0.5345583f,-0.5520325f,0.4545983f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449295f,1.365054f,0.7840235f,-0.7101628f,0.009161396f,0.02385844f,0.7035735f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.050426f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 15.27382f);
Get(0xFA26).SetLocalPose(1.405001f,1.227001f,0.7881564f,-0.4500924f,0.5345628f,-0.5525827f,0.4542157f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449278f,1.365002f,0.7840637f,-0.7101768f,0.009130905f,0.02383439f,0.7035606f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.111224f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 15.29358f);
Get(0xFA26).SetLocalPose(1.405325f,1.226915f,0.7884158f,-0.4488604f,0.5344995f,-0.5532398f,0.4547091f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449278f,1.364959f,0.7840546f,-0.7101625f,0.00913931f,0.02384046f,0.7035748f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.166657f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 15.3116f);
Get(0xFA26).SetLocalPose(1.406566f,1.227759f,0.7890341f,-0.4479194f,0.5343115f,-0.553323f,0.4557556f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44926f,1.365015f,0.7840723f,-0.7101665f,0.009135748f,0.02387593f,0.7035696f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.223673f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 15.33013f);
Get(0xFA26).SetLocalPose(1.40665f,1.227036f,0.7886418f,-0.4478455f,0.533841f,-0.5530728f,0.4566824f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449341f,1.36501f,0.7840115f,-0.7101957f,0.009098769f,0.0238709f,0.7035407f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.278796f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 15.34805f);
Get(0xFA26).SetLocalPose(1.406763f,1.226851f,0.789184f,-0.4482353f,0.5334339f,-0.5532956f,0.4565058f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449285f,1.365045f,0.7842177f,-0.7102285f,0.009126251f,0.02386259f,0.7035075f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.33517f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 15.36637f);
Get(0xFA26).SetLocalPose(1.406081f,1.226763f,0.7892361f,-0.4481862f,0.5335083f,-0.5538948f,0.4557396f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449318f,1.365033f,0.7841934f,-0.7102355f,0.009112593f,0.0238486f,0.7035012f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.360564f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 15.37462f);
Get(0xFA26).SetLocalPose(1.406437f,1.226733f,0.7892595f,-0.4481104f,0.5336298f,-0.554057f,0.4554747f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449442f,1.36505f,0.7844058f,-0.7102357f,0.009123476f,0.02387461f,0.7034999f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.419963f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 15.39392f);
Get(0xFA26).SetLocalPose(1.406093f,1.226768f,0.7891242f,-0.4476063f,0.5340403f,-0.5543525f,0.4551297f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44944f,1.365163f,0.7843164f,-0.7102343f,0.009116095f,0.02389261f,0.7035008f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.473557f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 15.41134f);
Get(0xFA26).SetLocalPose(1.406304f,1.226691f,0.7886958f,-0.4475607f,0.5340803f,-0.5542532f,0.4552484f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449404f,1.365112f,0.7842945f,-0.7102393f,0.009122062f,0.0238688f,0.7034965f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.531631f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 15.43022f);
Get(0xFA26).SetLocalPose(1.406683f,1.227277f,0.7882915f,-0.4481919f,0.5335932f,-0.5538794f,0.4556533f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449399f,1.364982f,0.784344f,-0.7102505f,0.00911751f,0.0238323f,0.7034864f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.58675f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 15.44813f);
Get(0xFA26).SetLocalPose(1.407394f,1.226313f,0.7882881f,-0.4484751f,0.5333299f,-0.5537585f,0.4558298f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449347f,1.365085f,0.7843307f,-0.710242f,0.009141717f,0.02383335f,0.7034947f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.642708f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 15.46632f);
Get(0xFA26).SetLocalPose(1.40788f,1.22646f,0.7885126f,-0.4477561f,0.5337867f,-0.5541256f,0.455556f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449332f,1.364995f,0.7843451f,-0.7102258f,0.009150329f,0.02382791f,0.7035111f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.667384f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 15.47433f);
Get(0xFA26).SetLocalPose(1.407457f,1.227495f,0.7887961f,-0.4472131f,0.5340208f,-0.5543908f,0.4554922f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449245f,1.365271f,0.7842163f,-0.7102085f,0.009173459f,0.02383256f,0.7035282f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.725843f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 15.49333f);
Get(0xFA26).SetLocalPose(1.408136f,1.227045f,0.7892966f,-0.4469444f,0.5340288f,-0.5545099f,0.4556015f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449202f,1.365355f,0.7842541f,-0.7102111f,0.009158296f,0.02387118f,0.7035244f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.781184f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 15.51132f);
Get(0xFA26).SetLocalPose(1.408143f,1.226392f,0.7892121f,-0.4470927f,0.5338043f,-0.5544758f,0.4557606f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449321f,1.365162f,0.7841873f,-0.7101863f,0.009167671f,0.02384277f,0.7035502f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.839882f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 15.5304f);
Get(0xFA26).SetLocalPose(1.408628f,1.225936f,0.78917f,-0.4478109f,0.5333614f,-0.5542336f,0.4558687f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44935f,1.365002f,0.7842245f,-0.7102161f,0.009116495f,0.0238822f,0.7035195f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.895854f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 15.54859f);
Get(0xFA26).SetLocalPose(1.408438f,1.225972f,0.7895459f,-0.448245f,0.5333097f,-0.5539448f,0.4558536f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449389f,1.364906f,0.7842011f,-0.7101982f,0.009164133f,0.02387334f,0.7035373f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.950959f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 15.5665f);
Get(0xFA26).SetLocalPose(1.408082f,1.226412f,0.7901285f,-0.4477928f,0.5336886f,-0.5539875f,0.4558024f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449405f,1.364889f,0.7842559f,-0.7102122f,0.009138403f,0.02389338f,0.7035228f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.976648f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 15.57485f);
Get(0xFA26).SetLocalPose(1.40857f,1.226406f,0.7900384f,-0.4473806f,0.5339382f,-0.5539809f,0.455923f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449414f,1.365017f,0.7842465f,-0.7102166f,0.009083388f,0.023887f,0.7035192f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.034636f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 15.59369f);
Get(0xFA26).SetLocalPose(1.40916f,1.226146f,0.7901989f,-0.4471961f,0.5340015f,-0.5538114f,0.4562357f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449468f,1.36487f,0.7843413f,-0.710223f,0.009116895f,0.02390996f,0.7035116f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.089142f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 15.61141f);
Get(0xFA26).SetLocalPose(1.408817f,1.225548f,0.7902332f,-0.4474708f,0.5340286f,-0.553663f,0.4561147f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449677f,1.364991f,0.7841928f,-0.7102115f,0.00911291f,0.02389038f,0.703524f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.145761f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 15.62981f);
Get(0xFA26).SetLocalPose(1.408599f,1.226154f,0.7903439f,-0.4476984f,0.5341296f,-0.553739f,0.4556807f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449646f,1.364995f,0.7842737f,-0.710211f,0.009120787f,0.02388469f,0.7035245f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.200644f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 15.64764f);
Get(0xFA26).SetLocalPose(1.409079f,1.226951f,0.7905505f,-0.4478917f,0.5341413f,-0.553665f,0.4555669f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449482f,1.365021f,0.7842264f,-0.7102031f,0.009129399f,0.02388662f,0.7035323f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.256094f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 15.66567f);
Get(0xFA26).SetLocalPose(1.409078f,1.226717f,0.7897995f,-0.4472517f,0.5345727f,-0.553694f,0.4556544f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449473f,1.364998f,0.7842909f,-0.7102038f,0.00912373f,0.02389107f,0.7035316f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.281274f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 15.67385f);
Get(0xFA26).SetLocalPose(1.409017f,1.226731f,0.7897968f,-0.4468339f,0.5347543f,-0.5537794f,0.4557474f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449399f,1.364963f,0.7841865f,-0.7102096f,0.009139267f,0.02387135f,0.7035261f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.341557f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 15.69344f);
Get(0xFA26).SetLocalPose(1.409103f,1.22596f,0.7896081f,-0.446489f,0.5347582f,-0.5539358f,0.4558907f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.4494f,1.36518f,0.7842262f,-0.7102052f,0.009114472f,0.02388203f,0.7035306f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.395508f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 15.71098f);
Get(0xFA26).SetLocalPose(1.409376f,1.225525f,0.7893047f,-0.4466169f,0.5348437f,-0.5540171f,0.4555663f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449184f,1.365175f,0.7841491f,-0.7101926f,0.009145753f,0.02386124f,0.7035435f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.451969f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 15.72933f);
Get(0xFA26).SetLocalPose(1.409307f,1.2247f,0.7899485f,-0.4470719f,0.5351411f,-0.5539434f,0.4548598f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449246f,1.36518f,0.7841616f,-0.7101962f,0.009134091f,0.02387904f,0.7035394f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.507631f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 15.74742f);
Get(0xFA26).SetLocalPose(1.409094f,1.225014f,0.7895637f,-0.447424f,0.5356838f,-0.5535257f,0.454383f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449097f,1.365289f,0.7840168f,-0.7101863f,0.009142481f,0.02384886f,0.7035504f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.562845f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 15.76536f);
Get(0xFA26).SetLocalPose(1.409391f,1.225335f,0.7896305f,-0.4474291f,0.5360187f,-0.5534319f,0.4540972f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449193f,1.365087f,0.7841142f,-0.7102001f,0.009129045f,0.02388003f,0.7035356f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.588192f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 15.7736f);
Get(0xFA26).SetLocalPose(1.409493f,1.225802f,0.7896932f,-0.4473896f,0.5360959f,-0.5534428f,0.4540318f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449054f,1.36513f,0.7839798f,-0.7102054f,0.009139895f,0.02384084f,0.7035313f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.648641f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 15.79325f);
Get(0xFA26).SetLocalPose(1.409796f,1.226806f,0.789658f,-0.447185f,0.5362311f,-0.5534994f,0.4540046f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448987f,1.365111f,0.7840294f,-0.7101769f,0.00914517f,0.02386196f,0.7035593f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.704875f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 15.81152f);
Get(0xFA26).SetLocalPose(1.409868f,1.227747f,0.7896577f,-0.4473181f,0.5360244f,-0.553406f,0.4542314f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449029f,1.365158f,0.7841116f,-0.7101984f,0.009139641f,0.0238441f,0.7035384f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.760666f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 15.82965f);
Get(0xFA26).SetLocalPose(1.410178f,1.228635f,0.7898356f,-0.4477349f,0.535848f,-0.5531342f,0.4543599f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449132f,1.365085f,0.784054f,-0.7101653f,0.00914914f,0.02385898f,0.7035712f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.817555f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 15.84814f);
Get(0xFA26).SetLocalPose(1.408817f,1.228981f,0.7899314f,-0.4476866f,0.5359536f,-0.5530944f,0.4543314f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449239f,1.365003f,0.7839237f,-0.710165f,0.009150377f,0.02384069f,0.703572f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.847316f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 15.85781f);
Get(0xFA26).SetLocalPose(1.408776f,1.228224f,0.7903081f,-0.4476509f,0.5360562f,-0.5530672f,0.4542786f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449349f,1.364985f,0.7839461f,-0.7101643f,0.009114454f,0.02387847f,0.7035719f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.911747f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 15.87875f);
Get(0xFA26).SetLocalPose(1.408228f,1.228973f,0.7903014f,-0.4478261f,0.5362472f,-0.5529367f,0.4540394f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449484f,1.365069f,0.783999f,-0.710182f,0.009129583f,0.02388233f,0.7035538f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.940368f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 15.88806f);
Get(0xFA26).SetLocalPose(1.407367f,1.228704f,0.7904036f,-0.4479635f,0.5363315f,-0.5528387f,0.4539236f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449416f,1.36502f,0.7840104f,-0.7101759f,0.009102033f,0.02389625f,0.7035598f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.011548f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 15.91119f);
Get(0xFA26).SetLocalPose(1.406584f,1.228299f,0.7907535f,-0.4484423f,0.5364401f,-0.5526728f,0.4535244f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449472f,1.365252f,0.7840342f,-0.7101825f,0.009099925f,0.02389571f,0.7035531f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.073504f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 15.93133f);
Get(0xFA26).SetLocalPose(1.406366f,1.229142f,0.7908267f,-0.4484368f,0.5365408f,-0.5526484f,0.4534403f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44958f,1.365152f,0.7840205f,-0.7101831f,0.009085467f,0.02389181f,0.7035529f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.101628f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 15.94047f);
Get(0xFA26).SetLocalPose(1.406133f,1.228573f,0.790635f,-0.4481618f,0.536679f,-0.5526752f,0.4535162f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449579f,1.365268f,0.7840686f,-0.7101821f,0.009091742f,0.02388164f,0.7035542f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.173925f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 15.96396f);
Get(0xFA26).SetLocalPose(1.406294f,1.229015f,0.7912648f,-0.4480897f,0.5370207f,-0.5524464f,0.4534616f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449666f,1.365269f,0.7840635f,-0.7101716f,0.00910417f,0.02388171f,0.7035645f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.229664f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 15.98208f);
Get(0xFA26).SetLocalPose(1.405864f,1.227919f,0.7913012f,-0.4484598f,0.5371327f,-0.5521485f,0.4533259f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449599f,1.365228f,0.7840086f,-0.7101691f,0.009120681f,0.02386315f,0.7035675f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.255044f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 15.99033f);
Get(0xFA26).SetLocalPose(1.405794f,1.227835f,0.7913604f,-0.4486292f,0.5371276f,-0.5520741f,0.453255f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449549f,1.365211f,0.7839435f,-0.7101651f,0.009122657f,0.0238999f,0.7035703f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.314225f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 16.00956f);
Get(0xFA26).SetLocalPose(1.406615f,1.228427f,0.7916251f,-0.4492509f,0.5369539f,-0.5518712f,0.453092f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449513f,1.365111f,0.7840479f,-0.7101768f,0.009093979f,0.0239074f,0.7035586f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.370359f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 16.0278f);
Get(0xFA26).SetLocalPose(1.406739f,1.228481f,0.7916054f,-0.4496316f,0.5368454f,-0.5516985f,0.4530531f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449383f,1.365047f,0.7840505f,-0.7101759f,0.009123012f,0.0238882f,0.7035599f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.428767f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 16.04678f);
Get(0xFA26).SetLocalPose(1.406391f,1.229084f,0.7915621f,-0.4494071f,0.537025f,-0.5516593f,0.4531109f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44942f,1.365101f,0.7840005f,-0.7101868f,0.009128201f,0.02387607f,0.7035491f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.485393f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 16.06519f);
Get(0xFA26).SetLocalPose(1.406566f,1.229449f,0.7912982f,-0.4493046f,0.5371175f,-0.5514834f,0.4533169f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449496f,1.365018f,0.7841793f,-0.7101875f,0.009125736f,0.0238909f,0.703548f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.512241f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 16.07391f);
Get(0xFA26).SetLocalPose(1.406519f,1.228783f,0.7912317f,-0.4494633f,0.5370804f,-0.5512871f,0.4534425f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449493f,1.36509f,0.7842829f,-0.710186f,0.009123307f,0.02388704f,0.7035497f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.572669f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 16.09355f);
Get(0xFA26).SetLocalPose(1.406512f,1.228731f,0.7914896f,-0.4500245f,0.5371108f,-0.5508537f,0.4533765f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449445f,1.365253f,0.7841733f,-0.7101645f,0.009092177f,0.02386392f,0.7035725f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.629052f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 16.11188f);
Get(0xFA26).SetLocalPose(1.406962f,1.228846f,0.7913328f,-0.4502374f,0.5373617f,-0.5508606f,0.452859f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449373f,1.36522f,0.7841288f,-0.7101864f,0.009118482f,0.02388928f,0.7035493f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.686039f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 16.1304f);
Get(0xFA26).SetLocalPose(1.407084f,1.229214f,0.7913963f,-0.4502215f,0.5376028f,-0.550987f,0.4524348f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449431f,1.365329f,0.784043f,-0.7101773f,0.009087486f,0.02390324f,0.7035583f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.742754f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 16.14883f);
Get(0xFA26).SetLocalPose(1.407283f,1.229697f,0.7914185f,-0.4501876f,0.5376287f,-0.5510642f,0.4523437f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449361f,1.365147f,0.7839836f,-0.7101871f,0.009082299f,0.02389707f,0.7035487f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.769373f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 16.15748f);
Get(0xFA26).SetLocalPose(1.407444f,1.229591f,0.79137f,-0.4502524f,0.5375089f,-0.5509988f,0.4525012f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449479f,1.365138f,0.7840035f,-0.71018f,0.009107011f,0.02388058f,0.7035561f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.832749f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 16.17808f);
Get(0xFA26).SetLocalPose(1.407495f,1.229717f,0.7910399f,-0.4503727f,0.5372385f,-0.550771f,0.4529797f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449441f,1.365098f,0.7839914f,-0.7101864f,0.00907982f,0.02389019f,0.7035497f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.889825f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 16.19663f);
Get(0xFA26).SetLocalPose(1.40704f,1.230022f,0.7903665f,-0.4504412f,0.5373701f,-0.5504551f,0.4531394f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449372f,1.365122f,0.7840207f,-0.7101702f,0.009131558f,0.02387463f,0.703566f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.946166f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 16.21494f);
Get(0xFA26).SetLocalPose(1.407082f,1.229563f,0.790374f,-0.4505059f,0.5373995f,-0.5503685f,0.4531454f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449273f,1.365044f,0.7840414f,-0.7101794f,0.009123248f,0.02385721f,0.7035573f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.972571f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 16.22352f);
Get(0xFA26).SetLocalPose(1.407146f,1.229547f,0.7903286f,-0.4505349f,0.5373235f,-0.5504347f,0.4531262f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449332f,1.365093f,0.7840631f,-0.7101745f,0.009125196f,0.02391561f,0.7035602f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.0323f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 16.24293f);
Get(0xFA26).SetLocalPose(1.407923f,1.230305f,0.7906145f,-0.4506565f,0.5371056f,-0.5506362f,0.453019f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44935f,1.365193f,0.7841085f,-0.7101856f,0.009116594f,0.02391056f,0.7035493f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.088556f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 16.26121f);
Get(0xFA26).SetLocalPose(1.407848f,1.230192f,0.7905374f,-0.4507198f,0.5369774f,-0.5507254f,0.4529996f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449486f,1.365026f,0.7842648f,-0.7102169f,0.009073494f,0.02390487f,0.7035185f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.146211f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 16.27995f);
Get(0xFA26).SetLocalPose(1.407345f,1.22962f,0.7902299f,-0.4510018f,0.5367197f,-0.5504701f,0.4533343f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449463f,1.365212f,0.7842895f,-0.7102022f,0.00910581f,0.02389563f,0.7035333f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.203729f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 16.29864f);
Get(0xFA26).SetLocalPose(1.408072f,1.22885f,0.7900321f,-0.4512516f,0.5363756f,-0.5501702f,0.4538569f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449491f,1.365239f,0.7842934f,-0.7101955f,0.009101409f,0.02387894f,0.7035406f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.229478f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 16.30701f);
Get(0xFA26).SetLocalPose(1.40843f,1.228663f,0.7900646f,-0.4511937f,0.5363064f,-0.5501776f,0.4539871f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.4495f,1.36508f,0.7843353f,-0.710207f,0.00911534f,0.02388032f,0.7035287f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.290892f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 16.32697f);
Get(0xFA26).SetLocalPose(1.408525f,1.22845f,0.7897671f,-0.4514858f,0.5362058f,-0.5500229f,0.454003f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449627f,1.364963f,0.7842712f,-0.7101952f,0.009118096f,0.02388947f,0.7035403f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.346848f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 16.34516f);
Get(0xFA26).SetLocalPose(1.408331f,1.228739f,0.7897832f,-0.4522037f,0.5360587f,-0.5496674f,0.4538928f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449336f,1.365079f,0.7841516f,-0.7102087f,0.009142004f,0.02388408f,0.7035266f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.404535f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 16.3639f);
Get(0xFA26).SetLocalPose(1.408101f,1.228403f,0.7897509f,-0.4528274f,0.5358803f,-0.5494029f,0.4538019f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449389f,1.365174f,0.7842849f,-0.7102203f,0.0091168f,0.02388787f,0.7035151f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.459546f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 16.38178f);
Get(0xFA26).SetLocalPose(1.407547f,1.22867f,0.7901353f,-0.4530567f,0.5357655f,-0.5492223f,0.4539272f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449355f,1.365351f,0.7842199f,-0.7102093f,0.00914752f,0.02388988f,0.7035258f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.515342f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 16.39992f);
Get(0xFA26).SetLocalPose(1.407484f,1.228766f,0.7903084f,-0.4530025f,0.5355332f,-0.5488977f,0.4546474f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449377f,1.365347f,0.7841945f,-0.7101981f,0.009116802f,0.02387756f,0.7035378f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.539706f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 16.40784f);
Get(0xFA26).SetLocalPose(1.407223f,1.229307f,0.7905595f,-0.4530146f,0.5354148f,-0.5487053f,0.455007f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449257f,1.365292f,0.7842151f,-0.7101924f,0.00911862f,0.02387884f,0.7035435f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.600466f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 16.42758f);
Get(0xFA26).SetLocalPose(1.406884f,1.228611f,0.7901059f,-0.4533215f,0.5350758f,-0.5482949f,0.4555944f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449507f,1.365181f,0.7841977f,-0.710207f,0.009088736f,0.02388706f,0.7035288f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.65748f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 16.44611f);
Get(0xFA26).SetLocalPose(1.406742f,1.229146f,0.7902381f,-0.4535651f,0.5347162f,-0.5482801f,0.4557921f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449505f,1.365088f,0.784238f,-0.7101957f,0.009112289f,0.02389646f,0.7035396f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.712069f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 16.46385f);
Get(0xFA26).SetLocalPose(1.405949f,1.229422f,0.7899709f,-0.4535935f,0.5344537f,-0.548398f,0.4559297f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449438f,1.365077f,0.7841013f,-0.7101921f,0.009135472f,0.02389568f,0.703543f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.767643f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 16.48191f);
Get(0xFA26).SetLocalPose(1.405836f,1.230229f,0.7895092f,-0.4538371f,0.5342093f,-0.5483111f,0.4560782f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449383f,1.364996f,0.7839743f,-0.7101805f,0.009140541f,0.02388677f,0.703555f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.823144f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 16.49995f);
Get(0xFA26).SetLocalPose(1.405536f,1.230878f,0.7894076f,-0.4538573f,0.5340952f,-0.5483354f,0.4561625f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449419f,1.365018f,0.7839906f,-0.7101955f,0.009126863f,0.02390185f,0.7035395f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.848086f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 16.50806f);
Get(0xFA26).SetLocalPose(1.405512f,1.230686f,0.7891321f,-0.45387f,0.5340459f,-0.5483297f,0.4562144f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449389f,1.364923f,0.7839508f,-0.7102057f,0.009095366f,0.02388957f,0.70353f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.90748f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 16.52736f);
Get(0xFA26).SetLocalPose(1.405558f,1.229887f,0.7886558f,-0.4540842f,0.5337071f,-0.548205f,0.4565476f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449486f,1.364932f,0.7840619f,-0.7101961f,0.009105119f,0.02389961f,0.7035393f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.963647f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 16.54562f);
Get(0xFA26).SetLocalPose(1.406061f,1.230015f,0.7890955f,-0.4543597f,0.5334853f,-0.5479912f,0.4567891f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449392f,1.365074f,0.7839909f,-0.7101636f,0.009132027f,0.02390546f,0.7035715f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.020003f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 16.56393f);
Get(0xFA26).SetLocalPose(1.406338f,1.23043f,0.7887335f,-0.4543056f,0.5335f,-0.5480299f,0.4567795f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449464f,1.36515f,0.7840499f,-0.7101822f,0.00910576f,0.02392614f,0.7035524f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.077136f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 16.5825f);
Get(0xFA26).SetLocalPose(1.406545f,1.230402f,0.7888688f,-0.4544778f,0.53339f,-0.5480325f,0.4567334f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44942f,1.365235f,0.7840574f,-0.7101804f,0.009121271f,0.0239134f,0.7035545f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.130898f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 16.59997f);
Get(0xFA26).SetLocalPose(1.406463f,1.230871f,0.7889114f,-0.4546948f,0.5333169f,-0.5478202f,0.4568576f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449372f,1.365299f,0.783949f,-0.7101721f,0.009126563f,0.02391255f,0.7035627f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.157618f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 16.60866f);
Get(0xFA26).SetLocalPose(1.4063f,1.23085f,0.7887033f,-0.4547883f,0.5332369f,-0.5477372f,0.4569575f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449383f,1.365364f,0.7839588f,-0.7101653f,0.009085991f,0.0239033f,0.7035705f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.215631f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 16.62751f);
Get(0xFA26).SetLocalPose(1.406902f,1.229649f,0.7891934f,-0.4549581f,0.5330347f,-0.547738f,0.4570233f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449455f,1.365357f,0.7840067f,-0.7101699f,0.009086344f,0.02391935f,0.7035653f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.27227f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 16.64592f);
Get(0xFA26).SetLocalPose(1.407388f,1.229221f,0.7895303f,-0.4549048f,0.5329003f,-0.5478789f,0.4570642f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449445f,1.365327f,0.7839701f,-0.7101599f,0.009090118f,0.02391857f,0.7035754f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.327096f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 16.66374f);
Get(0xFA26).SetLocalPose(1.407531f,1.229858f,0.7893125f,-0.4548418f,0.5329461f,-0.5477805f,0.4571915f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449466f,1.365326f,0.7839146f,-0.710155f,0.009139917f,0.02388748f,0.7035807f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.383424f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 16.68204f);
Get(0xFA26).SetLocalPose(1.407539f,1.230235f,0.7890863f,-0.4551619f,0.53278f,-0.5473993f,0.4575229f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449352f,1.365258f,0.7839941f,-0.7101695f,0.009142876f,0.0238815f,0.7035663f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.438504f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 16.69995f);
Get(0xFA26).SetLocalPose(1.407642f,1.230482f,0.788932f,-0.4551732f,0.5326229f,-0.5474237f,0.4576654f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44931f,1.365207f,0.783994f,-0.710173f,0.009093569f,0.02390596f,0.7035625f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.464373f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 16.70835f);
Get(0xFA26).SetLocalPose(1.408123f,1.229791f,0.7892787f,-0.4549713f,0.5325535f,-0.5476211f,0.4577106f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449379f,1.365167f,0.783894f,-0.7101677f,0.009154527f,0.02389718f,0.7035674f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.523584f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 16.7276f);
Get(0xFA26).SetLocalPose(1.407721f,1.230447f,0.788834f,-0.4548082f,0.5326101f,-0.5477945f,0.4575995f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449454f,1.364985f,0.783918f,-0.7101892f,0.009137352f,0.02389915f,0.7035459f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.57961f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 16.74581f);
Get(0xFA26).SetLocalPose(1.40781f,1.229867f,0.7885106f,-0.4551504f,0.5326572f,-0.5475898f,0.4574493f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449396f,1.365075f,0.7839586f,-0.7101932f,0.009133809f,0.02389235f,0.7035421f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.637774f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 16.76471f);
Get(0xFA26).SetLocalPose(1.408074f,1.229073f,0.7892988f,-0.4562144f,0.532157f,-0.5470013f,0.4576755f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449393f,1.365043f,0.7840185f,-0.7102055f,0.009114165f,0.02388357f,0.7035302f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.663553f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 16.77309f);
Get(0xFA26).SetLocalPose(1.407296f,1.228645f,0.7890874f,-0.4566194f,0.531894f,-0.5467458f,0.4578829f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449334f,1.365006f,0.7840142f,-0.7101883f,0.009107069f,0.02390324f,0.703547f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.72434f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 16.79284f);
Get(0xFA26).SetLocalPose(1.406583f,1.228065f,0.789126f,-0.4569697f,0.531525f,-0.5464504f,0.4583141f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449316f,1.365046f,0.7840862f,-0.7101666f,0.009107592f,0.0238866f,0.7035695f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.77942f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 16.81075f);
Get(0xFA26).SetLocalPose(1.406235f,1.226922f,0.788904f,-0.4570197f,0.5313205f,-0.5463706f,0.4585964f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449355f,1.365165f,0.7840366f,-0.7101511f,0.009125518f,0.0238754f,0.7035853f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.836908f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 16.82943f);
Get(0xFA26).SetLocalPose(1.406291f,1.226545f,0.7888078f,-0.4568873f,0.5312591f,-0.5464913f,0.4586556f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449258f,1.365177f,0.7839389f,-0.710178f,0.009107166f,0.02384274f,0.7035594f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.89202f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 16.84734f);
Get(0xFA26).SetLocalPose(1.405939f,1.225723f,0.789017f,-0.4575413f,0.5309576f,-0.5462781f,0.458607f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449132f,1.365069f,0.7839659f,-0.7101634f,0.009158294f,0.0238486f,0.7035733f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.947734f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 16.86545f);
Get(0xFA26).SetLocalPose(1.406019f,1.226149f,0.7889447f,-0.4582229f,0.5306441f,-0.5460622f,0.4585463f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44925f,1.364949f,0.7839724f,-0.7101826f,0.009126032f,0.02386758f,0.7035536f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.002644f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 16.88329f);
Get(0xFA26).SetLocalPose(1.406517f,1.225802f,0.7891454f,-0.4582987f,0.5305988f,-0.5460668f,0.4585176f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449168f,1.365001f,0.7839429f,-0.7101688f,0.009122884f,0.02386355f,0.7035678f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.028072f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 16.89156f);
Get(0xFA26).SetLocalPose(1.406804f,1.227358f,0.7890012f,-0.4582601f,0.5305271f,-0.546226f,0.4584495f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449472f,1.365076f,0.7840242f,-0.7101776f,0.009088413f,0.02386421f,0.7035593f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.088164f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 16.91109f);
Get(0xFA26).SetLocalPose(1.407118f,1.227903f,0.7887425f,-0.4584547f,0.5302791f,-0.5462095f,0.4585614f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449383f,1.365167f,0.7840029f,-0.7101712f,0.009152036f,0.02383959f,0.7035658f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.144599f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 16.92943f);
Get(0xFA26).SetLocalPose(1.406149f,1.228908f,0.788148f,-0.4586546f,0.5300207f,-0.546028f,0.4588763f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449353f,1.365273f,0.7840257f,-0.7101781f,0.00913913f,0.02388181f,0.7035576f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.200323f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 16.94754f);
Get(0xFA26).SetLocalPose(1.40631f,1.228876f,0.7881967f,-0.4593165f,0.5296609f,-0.5456632f,0.4590637f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44936f,1.365322f,0.7839483f,-0.7101634f,0.009115897f,0.02388612f,0.7035727f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.255143f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 16.96535f);
Get(0xFA26).SetLocalPose(1.405553f,1.229064f,0.7881457f,-0.4602616f,0.5294122f,-0.5450794f,0.4590975f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449322f,1.365222f,0.7839295f,-0.7101676f,0.009107513f,0.02390873f,0.7035677f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.280306f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 16.97353f);
Get(0xFA26).SetLocalPose(1.406246f,1.229726f,0.7879738f,-0.4602967f,0.5295233f,-0.5450916f,0.4589197f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44927f,1.36535f,0.783986f,-0.7101657f,0.009127695f,0.02388868f,0.7035699f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.340188f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 16.993f);
Get(0xFA26).SetLocalPose(1.406003f,1.229795f,0.7883711f,-0.4600425f,0.5298237f,-0.5453147f,0.4585626f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449385f,1.365289f,0.7839175f,-0.7101799f,0.009105661f,0.02391533f,0.7035551f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.39446f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 17.01064f);
Get(0xFA26).SetLocalPose(1.405516f,1.229403f,0.7883213f,-0.4602208f,0.529755f,-0.5453374f,0.4584361f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449489f,1.365243f,0.7839288f,-0.7101821f,0.009111051f,0.02389769f,0.7035534f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.452319f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 17.02944f);
Get(0xFA26).SetLocalPose(1.405317f,1.229385f,0.7880517f,-0.4606904f,0.5294355f,-0.5449768f,0.4587622f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449473f,1.365197f,0.7839436f,-0.7101888f,0.009141951f,0.02387634f,0.7035469f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.509985f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 17.04818f);
Get(0xFA26).SetLocalPose(1.405006f,1.229804f,0.7879061f,-0.460707f,0.5293094f,-0.5447894f,0.4591134f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44944f,1.365143f,0.7840527f,-0.710192f,0.009124773f,0.02388806f,0.7035435f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.565289f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 17.06615f);
Get(0xFA26).SetLocalPose(1.403227f,1.229948f,0.7879832f,-0.4608232f,0.5294313f,-0.5445052f,0.4591933f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449456f,1.36514f,0.7840313f,-0.7102016f,0.009141027f,0.02390923f,0.7035329f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.590137f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 17.07423f);
Get(0xFA26).SetLocalPose(1.403145f,1.230215f,0.7879075f,-0.4610572f,0.5294424f,-0.5442069f,0.4592994f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449279f,1.36504f,0.7840425f,-0.7102032f,0.009155085f,0.02389215f,0.7035317f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.652775f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 17.09459f);
Get(0xFA26).SetLocalPose(1.402546f,1.230667f,0.7871241f,-0.4613198f,0.5297897f,-0.5435542f,0.4594079f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449328f,1.365075f,0.7841135f,-0.7102134f,0.009130117f,0.02389466f,0.7035217f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.711815f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 17.11378f);
Get(0xFA26).SetLocalPose(1.401885f,1.230901f,0.7868964f,-0.4613704f,0.5302767f,-0.5433936f,0.4589851f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449323f,1.364959f,0.7842079f,-0.710202f,0.00914357f,0.02388434f,0.7035332f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.767563f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 17.1319f);
Get(0xFA26).SetLocalPose(1.401243f,1.231344f,0.7861277f,-0.4612891f,0.5305391f,-0.5434446f,0.4587033f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449212f,1.364972f,0.7841375f,-0.7101978f,0.009174154f,0.02387786f,0.7035373f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.793601f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 17.14036f);
Get(0xFA26).SetLocalPose(1.400968f,1.231839f,0.7861576f,-0.4613566f,0.530648f,-0.5432804f,0.458704f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449081f,1.364937f,0.7841754f,-0.7101946f,0.009157261f,0.02387894f,0.7035407f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.853515f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 17.15983f);
Get(0xFA26).SetLocalPose(1.4006f,1.230776f,0.7860374f,-0.4616575f,0.5306231f,-0.5427911f,0.4590091f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448977f,1.365077f,0.7841008f,-0.7102081f,0.009182047f,0.02387641f,0.7035269f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.908081f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 17.17756f);
Get(0xFA26).SetLocalPose(1.400697f,1.230315f,0.7861083f,-0.4624259f,0.5303103f,-0.5420219f,0.4595058f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448921f,1.365114f,0.78408f,-0.7101954f,0.009151032f,0.02385889f,0.7035408f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.962528f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 17.19526f);
Get(0xFA26).SetLocalPose(1.401215f,1.230238f,0.7862119f,-0.463139f,0.530139f,-0.5412833f,0.4598559f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448995f,1.365076f,0.7840098f,-0.7102022f,0.009156199f,0.02385773f,0.7035339f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 7.020446f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 17.21408f);
Get(0xFA26).SetLocalPose(1.400944f,1.229666f,0.7866094f,-0.4635423f,0.5301458f,-0.5407363f,0.4600852f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448913f,1.365015f,0.7839309f,-0.7101868f,0.009158387f,0.02383757f,0.70355f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 7.076883f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 17.23242f);
Get(0xFA26).SetLocalPose(1.400917f,1.229671f,0.7875735f,-0.4643266f,0.5301243f,-0.5400807f,0.4600889f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449018f,1.365008f,0.7840743f,-0.7101826f,0.009185236f,0.02386708f,0.703553f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 7.101897f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 17.24055f);
Get(0xFA26).SetLocalPose(1.401357f,1.229393f,0.7880911f,-0.4647524f,0.5300503f,-0.5397754f,0.4601027f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449174f,1.365174f,0.7842194f,-0.7102003f,0.00916727f,0.02386253f,0.7035355f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 7.164039f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 17.26075f);
Get(0xFA26).SetLocalPose(1.401123f,1.229302f,0.7884492f,-0.4650573f,0.5300047f,-0.5393916f,0.4602973f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449204f,1.365266f,0.7842863f,-0.7101952f,0.00915456f,0.02386157f,0.7035408f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 7.221986f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 17.27958f);
Get(0xFA26).SetLocalPose(1.402044f,1.229991f,0.7884914f,-0.4657385f,0.5296097f,-0.5387555f,0.4608078f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44932f,1.365215f,0.7842472f,-0.7102038f,0.00914245f,0.02385459f,0.7035325f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 7.277306f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 17.29756f);
Get(0xFA26).SetLocalPose(1.402831f,1.231119f,0.788237f,-0.4666097f,0.5293168f,-0.5379782f,0.4611711f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449442f,1.365099f,0.7842515f,-0.7101939f,0.009157774f,0.02386715f,0.7035419f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 7.333104f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 17.31569f);
Get(0xFA26).SetLocalPose(1.402984f,1.233429f,0.7885193f,-0.4675258f,0.5289999f,-0.5373536f,0.4613349f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449456f,1.365097f,0.7842316f,-0.7102038f,0.00914457f,0.02386137f,0.7035323f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 7.358155f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 17.32383f);
Get(0xFA26).SetLocalPose(1.40232f,1.233734f,0.7882465f,-0.4677064f,0.528924f,-0.5373548f,0.4612374f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449533f,1.364966f,0.7844624f,-0.7102383f,0.009097159f,0.02388407f,0.7034972f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 7.418581f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 17.34347f);
Get(0xFA26).SetLocalPose(1.402267f,1.233605f,0.7879674f,-0.4678394f,0.5288879f,-0.5376432f,0.4608077f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449622f,1.364988f,0.7843679f,-0.7102304f,0.009101698f,0.0238903f,0.703505f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 7.476003f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 17.36213f);
Get(0xFA26).SetLocalPose(1.401581f,1.233486f,0.7875278f,-0.4674568f,0.529068f,-0.5381466f,0.4604016f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449454f,1.365015f,0.7842944f,-0.7102249f,0.009140332f,0.02386875f,0.7035108f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 7.533345f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 17.38077f);
Get(0xFA26).SetLocalPose(1.400787f,1.233946f,0.7875195f,-0.4671837f,0.5292331f,-0.538361f,0.4602382f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449442f,1.365053f,0.7842671f,-0.7102304f,0.009128848f,0.02387574f,0.7035052f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 7.589533f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 17.39903f);
Get(0xFA26).SetLocalPose(1.400816f,1.234125f,0.7873406f,-0.4674949f,0.5291501f,-0.538049f,0.4603825f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449549f,1.365092f,0.7843253f,-0.7102479f,0.009094983f,0.02387187f,0.7034881f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 7.616021f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 17.40764f);
Get(0xFA26).SetLocalPose(1.400799f,1.234572f,0.7870935f,-0.4678463f,0.5289394f,-0.5378937f,0.4604492f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449523f,1.365082f,0.7842864f,-0.710257f,0.00909235f,0.02387476f,0.7034788f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 7.674307f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 17.42658f);
Get(0xFA26).SetLocalPose(1.400503f,1.234077f,0.7869059f,-0.4682685f,0.5286459f,-0.5379182f,0.4603284f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449693f,1.365115f,0.7844427f,-0.7102568f,0.009078049f,0.02390285f,0.7034782f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 7.731172f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 17.44506f);
Get(0xFA26).SetLocalPose(1.400081f,1.231628f,0.787506f,-0.4686238f,0.5285177f,-0.5379466f,0.4600808f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449518f,1.365152f,0.7846437f,-0.7102407f,0.00910282f,0.02387127f,0.7034953f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 7.793287f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 17.46525f);
Get(0xFA26).SetLocalPose(1.400239f,1.231399f,0.7869805f,-0.4686903f,0.5285102f,-0.5380679f,0.4598798f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449537f,1.365143f,0.7846171f,-0.7102338f,0.009127762f,0.02385056f,0.7035025f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 7.829184f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 17.47692f);
Get(0xFA26).SetLocalPose(1.400642f,1.230893f,0.7872464f,-0.4685147f,0.528591f,-0.5379888f,0.4600584f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449616f,1.36516f,0.7845716f,-0.7102297f,0.009131632f,0.0238418f,0.7035069f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 7.891463f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 17.49716f);
Get(0xFA26).SetLocalPose(1.400937f,1.231477f,0.7876982f,-0.4681425f,0.5287485f,-0.5379774f,0.4602696f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449449f,1.364918f,0.7844813f,-0.7102298f,0.009106413f,0.02387293f,0.7035062f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 7.947345f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 17.51532f);
Get(0xFA26).SetLocalPose(1.400992f,1.232061f,0.7877709f,-0.4679919f,0.5288507f,-0.5380797f,0.4601857f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449307f,1.364889f,0.7844024f,-0.710234f,0.009108681f,0.02386976f,0.7035019f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.001595f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 17.53295f);
Get(0xFA26).SetLocalPose(1.401125f,1.232817f,0.7876557f,-0.4681375f,0.5288091f,-0.5381859f,0.4599612f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44941f,1.364865f,0.784384f,-0.7102503f,0.009067383f,0.02388291f,0.7034855f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.027802f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 17.54147f);
Get(0xFA26).SetLocalPose(1.401506f,1.232848f,0.7877033f,-0.4683763f,0.5288667f,-0.538098f,0.4597546f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449573f,1.365018f,0.7844013f,-0.7102357f,0.009073351f,0.02387881f,0.7035004f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.090597f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 17.56188f);
Get(0xFA26).SetLocalPose(1.401794f,1.232858f,0.7878926f,-0.468523f,0.5290401f,-0.5380217f,0.4594948f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44963f,1.364984f,0.7843087f,-0.7102175f,0.009066292f,0.02389834f,0.7035182f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.148815f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 17.5808f);
Get(0xFA26).SetLocalPose(1.40183f,1.232492f,0.7879745f,-0.4682438f,0.5292395f,-0.538017f,0.4595554f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449471f,1.365179f,0.7843112f,-0.7101967f,0.009110838f,0.02388741f,0.7035389f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.207531f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 17.59988f);
Get(0xFA26).SetLocalPose(1.402028f,1.232609f,0.788457f,-0.4681661f,0.529257f,-0.5379725f,0.4596663f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449605f,1.365173f,0.7843414f,-0.7102243f,0.009046813f,0.02388311f,0.7035121f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.233402f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 17.60829f);
Get(0xFA26).SetLocalPose(1.402078f,1.232707f,0.7884807f,-0.4681785f,0.5292434f,-0.537886f,0.4597706f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449494f,1.365077f,0.7842337f,-0.7102038f,0.009110821f,0.02387793f,0.7035321f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.264048f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 17.61825f);
Get(0xFA26).SetLocalPose(1.402373f,1.233477f,0.7885355f,-0.4683389f,0.5292048f,-0.5377105f,0.459857f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449456f,1.365062f,0.7841974f,-0.7102019f,0.009111549f,0.02388083f,0.703534f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.313932f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 17.63446f);
Get(0xFA26).SetLocalPose(1.402166f,1.234083f,0.7883273f,-0.4685756f,0.5291589f,-0.537549f,0.4598574f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449496f,1.365231f,0.7840599f,-0.7101809f,0.00910785f,0.02389318f,0.7035547f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.392743f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 17.66008f);
Get(0xFA26).SetLocalPose(1.402027f,1.233661f,0.7891175f,-0.4686539f,0.529414f,-0.5373443f,0.4597232f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449515f,1.365389f,0.784022f,-0.7101762f,0.009160005f,0.02389409f,0.7035588f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.449448f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 17.67851f);
Get(0xFA26).SetLocalPose(1.401749f,1.234262f,0.7888985f,-0.4683865f,0.5297022f,-0.5373103f,0.4597034f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449464f,1.365328f,0.7839625f,-0.7101611f,0.009122546f,0.02390906f,0.703574f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.506452f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 17.69703f);
Get(0xFA26).SetLocalPose(1.400695f,1.234452f,0.7882614f,-0.4683709f,0.5298123f,-0.5372186f,0.4596997f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449222f,1.36517f,0.7838558f,-0.7101586f,0.009141422f,0.02387543f,0.7035774f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.564378f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 17.71586f);
Get(0xFA26).SetLocalPose(1.400524f,1.234918f,0.7879062f,-0.4683805f,0.5298363f,-0.5372733f,0.4595984f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449217f,1.365192f,0.7838346f,-0.7101671f,0.009125403f,0.02388717f,0.7035688f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.589991f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 17.72418f);
Get(0xFA26).SetLocalPose(1.400096f,1.234784f,0.7874641f,-0.4683573f,0.5298172f,-0.5373455f,0.4595596f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449258f,1.365207f,0.7840821f,-0.7101714f,0.00915982f,0.02386742f,0.7035645f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.648975f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 17.74335f);
Get(0xFA26).SetLocalPose(1.39997f,1.23543f,0.7874349f,-0.4683519f,0.5298607f,-0.5373267f,0.459537f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449174f,1.365208f,0.7838261f,-0.7101693f,0.009158839f,0.02387165f,0.7035667f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.708958f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 17.76285f);
Get(0xFA26).SetLocalPose(1.399751f,1.234895f,0.787508f,-0.4683581f,0.529864f,-0.5371249f,0.4597628f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.4492f,1.365147f,0.7837479f,-0.7101637f,0.009163931f,0.0238575f,0.7035727f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.763979f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 17.78073f);
Get(0xFA26).SetLocalPose(1.399038f,1.234249f,0.7877513f,-0.4682786f,0.5299329f,-0.5371921f,0.4596858f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449241f,1.365043f,0.7837645f,-0.7101786f,0.009110798f,0.02387729f,0.7035576f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.819697f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 17.79884f);
Get(0xFA26).SetLocalPose(1.398802f,1.233137f,0.7875334f,-0.4682144f,0.5299982f,-0.537298f,0.4595521f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449291f,1.364908f,0.7837118f,-0.7101566f,0.009120206f,0.02387437f,0.7035798f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.846774f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 17.80764f);
Get(0xFA26).SetLocalPose(1.398741f,1.232853f,0.7876226f,-0.46834f,0.5299922f,-0.5372592f,0.4594763f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449344f,1.365066f,0.7839966f,-0.71018f,0.009147284f,0.02383833f,0.703557f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.909476f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 17.82802f);
Get(0xFA26).SetLocalPose(1.39879f,1.233785f,0.7877823f,-0.4685873f,0.5299187f,-0.5370609f,0.4595407f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449172f,1.36506f,0.7839729f,-0.7101661f,0.00915524f,0.02387632f,0.7035697f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.964952f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 17.84605f);
Get(0xFA26).SetLocalPose(1.398864f,1.235321f,0.7876279f,-0.4685096f,0.5298854f,-0.5371509f,0.4595533f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44896f,1.365195f,0.7839939f,-0.7101649f,0.009157098f,0.02383842f,0.7035722f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 9.019333f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 17.86372f);
Get(0xFA26).SetLocalPose(1.399087f,1.236026f,0.7873474f,-0.4683723f,0.5296849f,-0.5373322f,0.4597123f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449098f,1.365172f,0.7840499f,-0.7101806f,0.009152886f,0.02385116f,0.7035559f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 9.075158f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 17.88186f);
Get(0xFA26).SetLocalPose(1.399055f,1.235108f,0.7869526f,-0.468396f,0.5293983f,-0.5373815f,0.4599605f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449344f,1.365344f,0.7842461f,-0.710209f,0.009128907f,0.02386325f,0.7035272f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 9.130019f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 17.89969f);
Get(0xFA26).SetLocalPose(1.398827f,1.235315f,0.7866089f,-0.4683727f,0.5293586f,-0.537424f,0.4599805f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44927f,1.36519f,0.7841923f,-0.7102062f,0.009141678f,0.02386831f,0.7035297f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 9.155448f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 17.90796f);
Get(0xFA26).SetLocalPose(1.39866f,1.2335f,0.7867939f,-0.4683364f,0.5294352f,-0.5374424f,0.4599077f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449397f,1.365124f,0.7843274f,-0.7102239f,0.009120422f,0.02384148f,0.703513f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 9.213335f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 17.92677f);
Get(0xFA26).SetLocalPose(1.399161f,1.233915f,0.7865765f,-0.4683275f,0.529496f,-0.5375628f,0.4597059f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449389f,1.365134f,0.7842744f,-0.7102043f,0.009102859f,0.02387114f,0.703532f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 9.269722f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 17.94509f);
Get(0xFA26).SetLocalPose(1.399602f,1.234856f,0.7871408f,-0.4684856f,0.5294406f,-0.5376847f,0.4594661f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449349f,1.365188f,0.784204f,-0.7102022f,0.009114407f,0.02386383f,0.7035342f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 9.327706f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 17.96394f);
Get(0xFA26).SetLocalPose(1.40001f,1.234398f,0.788267f,-0.4687898f,0.5291211f,-0.5377182f,0.4594847f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449383f,1.365024f,0.7842969f,-0.710198f,0.009094793f,0.02389048f,0.7035378f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 9.383984f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 17.98223f);
Get(0xFA26).SetLocalPose(1.400696f,1.234154f,0.7883738f,-0.4687164f,0.5289218f,-0.5379357f,0.4595345f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449416f,1.365086f,0.7842482f,-0.7102006f,0.009117968f,0.02388007f,0.7035353f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 9.410957f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 17.991f);
Get(0xFA26).SetLocalPose(1.400926f,1.233233f,0.7882743f,-0.4686233f,0.5288477f,-0.5380464f,0.4595851f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44946f,1.365103f,0.784236f,-0.7102069f,0.009094574f,0.02385367f,0.7035301f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 9.469182f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 18.00992f);
Get(0xFA26).SetLocalPose(1.401235f,1.232528f,0.7879286f,-0.4685657f,0.5287696f,-0.5381033f,0.4596671f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449268f,1.365133f,0.7840818f,-0.7101834f,0.00915469f,0.02386393f,0.7035526f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 9.525127f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 18.0281f);
Get(0xFA26).SetLocalPose(1.400914f,1.230934f,0.7881866f,-0.4686935f,0.5285903f,-0.5380948f,0.459753f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44932f,1.365159f,0.7839609f,-0.7101799f,0.009128047f,0.02388982f,0.7035557f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 9.579597f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 18.0458f);
Get(0xFA26).SetLocalPose(1.401552f,1.23089f,0.7882496f,-0.4688706f,0.5284525f,-0.538287f,0.4595056f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449251f,1.365063f,0.7840026f,-0.7101967f,0.009149458f,0.02385876f,0.7035394f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 9.634286f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 18.06358f);
Get(0xFA26).SetLocalPose(1.401499f,1.230982f,0.7879577f,-0.4688326f,0.5284641f,-0.5385566f,0.4592151f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449311f,1.365035f,0.7841171f,-0.7101821f,0.00915029f,0.02387721f,0.7035536f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 9.692385f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 18.08246f);
Get(0xFA26).SetLocalPose(1.401283f,1.23059f,0.7869145f,-0.4685989f,0.5285814f,-0.5386643f,0.4591922f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44941f,1.365117f,0.7840394f,-0.7101855f,0.009133306f,0.0238464f,0.7035514f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 9.71798f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 18.09078f);
Get(0xFA26).SetLocalPose(1.401204f,1.230475f,0.7867478f,-0.468512f,0.5285378f,-0.5386476f,0.4593507f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449335f,1.365165f,0.7840897f,-0.7101846f,0.009136366f,0.02388109f,0.7035511f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 9.778007f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 18.11029f);
Get(0xFA26).SetLocalPose(1.400874f,1.230469f,0.7864946f,-0.4686253f,0.5283457f,-0.5385481f,0.4595728f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449214f,1.365208f,0.7839727f,-0.7101717f,0.009163162f,0.02387024f,0.7035642f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 9.836261f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 18.12922f);
Get(0xFA26).SetLocalPose(1.401366f,1.231121f,0.7860704f,-0.46851f,0.5283315f,-0.5386978f,0.4595314f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44914f,1.365144f,0.7839944f,-0.7101558f,0.009178231f,0.02386095f,0.7035804f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 9.893091f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 18.14769f);
Get(0xFA26).SetLocalPose(1.401577f,1.23179f,0.7864215f,-0.4685056f,0.5283245f,-0.5389228f,0.4592798f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449057f,1.365054f,0.7839646f,-0.7101604f,0.009188712f,0.02385879f,0.7035755f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 9.949015f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 18.16586f);
Get(0xFA26).SetLocalPose(1.401446f,1.231467f,0.7864848f,-0.4686734f,0.5283955f,-0.5388151f,0.4591533f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449124f,1.365049f,0.7840688f,-0.710183f,0.009158337f,0.0238587f,0.7035532f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 9.97408f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 18.17401f);
Get(0xFA26).SetLocalPose(1.401888f,1.232112f,0.7865559f,-0.4687032f,0.5285047f,-0.5388075f,0.4590062f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449159f,1.365088f,0.7840253f,-0.7101973f,0.009134045f,0.02387285f,0.7035387f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 10.03184f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 18.19278f);
Get(0xFA26).SetLocalPose(1.402002f,1.232107f,0.7863925f,-0.468431f,0.5286857f,-0.538923f,0.4589399f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44934f,1.364953f,0.7841774f,-0.7102119f,0.009102564f,0.02388308f,0.7035239f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 10.08889f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 18.21132f);
Get(0xFA26).SetLocalPose(1.401906f,1.232733f,0.7859045f,-0.4681785f,0.5288732f,-0.5391077f,0.4587647f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449383f,1.364885f,0.784047f,-0.710203f,0.00911185f,0.02388631f,0.7035327f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 10.14304f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 18.22892f);
Get(0xFA26).SetLocalPose(1.401619f,1.232812f,0.7856489f,-0.4682846f,0.5287597f,-0.5390685f,0.4588332f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449489f,1.365028f,0.7842405f,-0.7102298f,0.009069928f,0.02390582f,0.7035055f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 10.19789f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 18.24675f);
Get(0xFA26).SetLocalPose(1.401718f,1.23129f,0.7859143f,-0.4686523f,0.5285079f,-0.53882f,0.4590397f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449632f,1.364955f,0.7843223f,-0.7102315f,0.009053276f,0.02389276f,0.7035044f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 10.25345f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 18.2648f);
Get(0xFA26).SetLocalPose(1.401433f,1.230824f,0.7856144f,-0.4687179f,0.5284929f,-0.5387814f,0.4590353f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449736f,1.365135f,0.7843045f,-0.7102158f,0.00904448f,0.02387243f,0.703521f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 10.30806f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 18.28255f);
Get(0xFA26).SetLocalPose(1.401583f,1.230515f,0.7855019f,-0.468754f,0.5286162f,-0.5387944f,0.4588411f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44974f,1.365254f,0.7843988f,-0.7102304f,0.009066876f,0.02388707f,0.7035055f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 10.33315f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 18.29071f);
Get(0xFA26).SetLocalPose(1.401747f,1.230689f,0.7856512f,-0.46875f,0.5286326f,-0.5387811f,0.458842f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449762f,1.365228f,0.7843655f,-0.7102444f,0.009047753f,0.023878f,0.703492f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 10.39229f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 18.30993f);
Get(0xFA26).SetLocalPose(1.40219f,1.231532f,0.7859298f,-0.4687546f,0.5286272f,-0.5386586f,0.4589874f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449855f,1.365245f,0.7845007f,-0.710239f,0.009032706f,0.02388122f,0.7034975f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 10.44816f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 18.32808f);
Get(0xFA26).SetLocalPose(1.40169f,1.232255f,0.7853338f,-0.4686516f,0.5286694f,-0.5385751f,0.459142f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44992f,1.365259f,0.7847037f,-0.7102361f,0.009045468f,0.02388504f,0.7035002f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 10.50281f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 18.34585f);
Get(0xFA26).SetLocalPose(1.401667f,1.232159f,0.7851541f,-0.4685664f,0.5286674f,-0.5384627f,0.4593627f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449897f,1.36524f,0.7845593f,-0.710222f,0.009055506f,0.02392476f,0.7035129f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 10.55843f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 18.36393f);
Get(0xFA26).SetLocalPose(1.40141f,1.23289f,0.7847879f,-0.4685381f,0.5286158f,-0.5383751f,0.4595537f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449777f,1.36522f,0.7844738f,-0.7102098f,0.009067653f,0.02391258f,0.7035255f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 10.61365f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 18.38187f);
Get(0xFA26).SetLocalPose(1.401517f,1.232482f,0.784594f,-0.4685812f,0.528622f,-0.5382802f,0.4596137f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449795f,1.36516f,0.7843058f,-0.7102078f,0.009059215f,0.02392008f,0.7035273f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 10.66934f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 18.39997f);
Get(0xFA26).SetLocalPose(1.401209f,1.232853f,0.7842017f,-0.4684437f,0.5288074f,-0.5381559f,0.4596863f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449833f,1.365168f,0.7843002f,-0.710206f,0.009085961f,0.0238975f,0.7035295f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 10.69423f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 18.40806f);
Get(0xFA26).SetLocalPose(1.401285f,1.233094f,0.7842674f,-0.4683911f,0.5289389f,-0.5380455f,0.459718f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449652f,1.365169f,0.7841511f,-0.710214f,0.009100127f,0.02387854f,0.703522f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 10.75244f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 18.42698f);
Get(0xFA26).SetLocalPose(1.401198f,1.233513f,0.7847102f,-0.468495f,0.5290067f,-0.5379475f,0.4596487f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449671f,1.365222f,0.784202f,-0.7102233f,0.00909275f,0.02388384f,0.7035124f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 10.80946f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 18.44551f);
Get(0xFA26).SetLocalPose(1.401359f,1.23307f,0.7844086f,-0.4685602f,0.5289051f,-0.538011f,0.4596247f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449578f,1.365177f,0.7842762f,-0.7102075f,0.009125999f,0.02388855f,0.7035279f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 10.86643f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 18.46402f);
Get(0xFA26).SetLocalPose(1.401243f,1.233146f,0.784323f,-0.4686371f,0.528735f,-0.538088f,0.4596518f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449378f,1.365151f,0.7842519f,-0.7102086f,0.009120568f,0.02387605f,0.7035273f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 10.92461f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 18.48293f);
Get(0xFA26).SetLocalPose(1.40108f,1.232869f,0.7843057f,-0.4687032f,0.5286508f,-0.5380145f,0.4597676f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449353f,1.365155f,0.7842429f,-0.7102102f,0.009123635f,0.02389053f,0.7035251f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 10.94945f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 18.491f);
Get(0xFA26).SetLocalPose(1.401386f,1.232637f,0.7841663f,-0.4685944f,0.5286222f,-0.5380237f,0.4599005f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44953f,1.36506f,0.7843874f,-0.7102299f,0.009086773f,0.02388976f,0.7035057f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 11.009f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 18.51036f);
Get(0xFA26).SetLocalPose(1.402295f,1.232535f,0.7847388f,-0.4682297f,0.5288266f,-0.5380829f,0.4599676f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44955f,1.365034f,0.7843437f,-0.710212f,0.009096066f,0.02389374f,0.7035235f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 11.06432f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 18.52834f);
Get(0xFA26).SetLocalPose(1.402592f,1.232502f,0.7845957f,-0.4681316f,0.529035f,-0.5381612f,0.4597362f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449524f,1.364992f,0.7843158f,-0.7102214f,0.009103967f,0.02388464f,0.7035143f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 11.1226f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 18.54728f);
Get(0xFA26).SetLocalPose(1.402486f,1.233385f,0.784756f,-0.4686583f,0.5288751f,-0.5380308f,0.459536f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44955f,1.36494f,0.7844467f,-0.7102222f,0.009092168f,0.02388564f,0.7035136f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 11.18006f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 18.56595f);
Get(0xFA26).SetLocalPose(1.402502f,1.233622f,0.7844722f,-0.4692254f,0.5286174f,-0.5379012f,0.4594055f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449501f,1.36504f,0.7844271f,-0.7102284f,0.009082777f,0.02389815f,0.703507f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 11.20508f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 18.57409f);
Get(0xFA26).SetLocalPose(1.402589f,1.233033f,0.7843704f,-0.4693524f,0.5284863f,-0.537958f,0.4593603f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449381f,1.365012f,0.7843645f,-0.7102202f,0.009134104f,0.0238719f,0.7035155f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 11.26582f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 18.59382f);
Get(0xFA26).SetLocalPose(1.402288f,1.233053f,0.7844319f,-0.469372f,0.5283405f,-0.5380096f,0.4594475f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449431f,1.365085f,0.7843533f,-0.7102158f,0.00916814f,0.02387931f,0.7035192f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 11.32355f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 18.61259f);
Get(0xFA26).SetLocalPose(1.40234f,1.232375f,0.7847981f,-0.4698401f,0.5277714f,-0.5373603f,0.460382f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449117f,1.365058f,0.7842289f,-0.7102214f,0.009161787f,0.02385162f,0.7035146f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 11.38021f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 18.631f);
Get(0xFA26).SetLocalPose(1.402481f,1.231677f,0.7851065f,-0.4709997f,0.5270584f,-0.5362797f,0.461273f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449075f,1.365024f,0.784093f,-0.7102036f,0.009165707f,0.02385368f,0.7035324f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 11.43594f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 18.64911f);
Get(0xFA26).SetLocalPose(1.402427f,1.231938f,0.7853081f,-0.473026f,0.5259492f,-0.534824f,0.462155f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449038f,1.364992f,0.7841085f,-0.7102084f,0.009147824f,0.02385008f,0.703528f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 11.46136f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 18.65737f);
Get(0xFA26).SetLocalPose(1.403049f,1.232563f,0.7856782f,-0.4746725f,0.5249277f,-0.5335903f,0.4630534f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448986f,1.364808f,0.7840149f,-0.7101981f,0.009156884f,0.02384162f,0.7035385f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 11.52105f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 18.67677f);
Get(0xFA26).SetLocalPose(1.40348f,1.234188f,0.7862778f,-0.4788415f,0.5222237f,-0.5298241f,0.4661327f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449095f,1.364847f,0.7840657f,-0.7102037f,0.00914663f,0.02386104f,0.7035323f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 11.5796f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 18.6958f);
Get(0xFA26).SetLocalPose(1.40386f,1.236485f,0.7853075f,-0.4856516f,0.5177785f,-0.5233013f,0.4713849f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44925f,1.364864f,0.7841321f,-0.7101951f,0.009121157f,0.02384343f,0.703542f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 11.63924f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 18.71519f);
Get(0xFA26).SetLocalPose(1.405637f,1.238684f,0.7856213f,-0.498292f,0.5093807f,-0.5111747f,0.4805589f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449302f,1.364927f,0.784146f,-0.7101969f,0.009142542f,0.02384684f,0.7035398f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 11.66489f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 18.72352f);
Get(0xFA26).SetLocalPose(1.406401f,1.240263f,0.7855579f,-0.5044855f,0.5052493f,-0.5052307f,0.4847262f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449305f,1.365004f,0.7841735f,-0.7101963f,0.009148003f,0.02386118f,0.7035398f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 11.72556f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 18.74324f);
Get(0xFA26).SetLocalPose(1.408352f,1.243761f,0.7849982f,-0.5230149f,0.4921599f,-0.4871967f,0.4968636f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449395f,1.365067f,0.7840136f,-0.7102059f,0.009107735f,0.02385316f,0.703531f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 11.78266f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 18.7618f);
Get(0xFA26).SetLocalPose(1.409282f,1.248817f,0.7840065f,-0.5440083f,0.4752637f,-0.4660939f,0.510819f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449533f,1.365077f,0.7840871f,-0.7101936f,0.009123516f,0.02388858f,0.7035419f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 11.83718f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 18.77952f);
Get(0xFA26).SetLocalPose(1.410292f,1.253652f,0.7832288f,-0.5621256f,0.4585701f,-0.4461602f,0.5240892f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449381f,1.365164f,0.7840485f,-0.7101806f,0.009156683f,0.02384861f,0.703556f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 11.89333f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 18.79777f);
Get(0xFA26).SetLocalPose(1.410475f,1.260498f,0.7816494f,-0.5837575f,0.4349823f,-0.4179295f,0.5434634f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449339f,1.365144f,0.7840192f,-0.710182f,0.00913176f,0.02386141f,0.7035545f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 11.94898f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 18.81585f);
Get(0xFA26).SetLocalPose(1.411183f,1.266639f,0.7805797f,-0.5991815f,0.4151392f,-0.3943757f,0.5595611f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449378f,1.365047f,0.7840555f,-0.710178f,0.009122459f,0.02387601f,0.7035582f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 11.97359f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 18.82385f);
Get(0xFA26).SetLocalPose(1.410936f,1.270121f,0.7800149f,-0.6095563f,0.4004815f,-0.3770339f,0.5708776f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449461f,1.365008f,0.7841247f,-0.7101852f,0.009143028f,0.02386438f,0.703551f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 12.03276f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 18.84308f);
Get(0xFA26).SetLocalPose(1.411223f,1.272391f,0.7795161f,-0.6179427f,0.3880301f,-0.3624368f,0.5798439f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449521f,1.365032f,0.7842169f,-0.7102154f,0.009109017f,0.0238839f,0.7035202f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 12.08813f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 18.86107f);
Get(0xFA26).SetLocalPose(1.411412f,1.279778f,0.7786966f,-0.6385209f,0.3550339f,-0.3240089f,0.6010494f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449401f,1.365075f,0.7842296f,-0.7101926f,0.009127229f,0.0238916f,0.7035427f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 12.14326f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 18.87899f);
Get(0xFA26).SetLocalPose(1.411274f,1.286482f,0.7780959f,-0.6557121f,0.3245568f,-0.2887269f,0.6175285f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449328f,1.365093f,0.784113f,-0.7101787f,0.009146064f,0.02388061f,0.7035569f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 12.19792f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 18.89676f);
Get(0xFA26).SetLocalPose(1.410136f,1.29167f,0.7775632f,-0.6713442f,0.2938695f,-0.2532069f,0.6315252f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449341f,1.365005f,0.7840982f,-0.7101685f,0.009151267f,0.02389787f,0.7035666f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 12.25342f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 18.9148f);
Get(0xFA26).SetLocalPose(1.408143f,1.298214f,0.7776105f,-0.6874263f,0.2554064f,-0.2097878f,0.6466851f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449269f,1.364996f,0.7839893f,-0.7101813f,0.009163902f,0.02386958f,0.7035545f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 12.3096f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 18.93306f);
Get(0xFA26).SetLocalPose(1.405676f,1.303626f,0.7775047f,-0.6977987f,0.2220281f,-0.1738984f,0.6584374f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449207f,1.365097f,0.7839031f,-0.7101637f,0.00914627f,0.02389946f,0.7035714f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 12.33554f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 18.94149f);
Get(0xFA26).SetLocalPose(1.404947f,1.306166f,0.777418f,-0.7017144f,0.2070435f,-0.1579912f,0.6631507f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449224f,1.365178f,0.7838439f,-0.7101787f,0.009141113f,0.02388507f,0.7035568f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 12.39795f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 18.96177f);
Get(0xFA26).SetLocalPose(1.401375f,1.312054f,0.7777511f,-0.7105373f,0.1662342f,-0.1146619f,0.6740592f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449294f,1.365088f,0.7839278f,-0.7101686f,0.009115118f,0.02387877f,0.7035676f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 12.45645f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 18.98078f);
Get(0xFA26).SetLocalPose(1.395968f,1.31802f,0.7776677f,-0.7187666f,0.1182756f,-0.06403973f,0.6821176f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449421f,1.365248f,0.7840443f,-0.7101837f,0.009098282f,0.02389232f,0.703552f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 12.48375f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 18.98965f);
Get(0xFA26).SetLocalPose(1.393853f,1.321134f,0.7774366f,-0.7218644f,0.09740174f,-0.04174735f,0.6838728f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449403f,1.365248f,0.7840384f,-0.7101726f,0.009120662f,0.02389078f,0.7035631f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 12.55295f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 19.01214f);
Get(0xFA26).SetLocalPose(1.387399f,1.326649f,0.7768012f,-0.7271019f,0.04661217f,0.01258448f,0.6848299f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449464f,1.365247f,0.7840884f,-0.7101791f,0.009155708f,0.02387323f,0.7035568f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 12.61512f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 19.03235f);
Get(0xFA26).SetLocalPose(1.38043f,1.330099f,0.7765491f,-0.728747f,0.002167929f,0.0589214f,0.68224f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449317f,1.365194f,0.7840816f,-0.710179f,0.009176921f,0.02383415f,0.7035578f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 12.64165f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 19.04097f);
Get(0xFA26).SetLocalPose(1.3793f,1.330594f,0.7766268f,-0.7287411f,-0.006646832f,0.06792845f,0.6813795f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449147f,1.365157f,0.7840771f,-0.7101884f,0.009158378f,0.0238655f,0.7035474f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 12.72024f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 19.06651f);
Get(0xFA26).SetLocalPose(1.370243f,1.333781f,0.7763095f,-0.7262208f,-0.06121895f,0.1242376f,0.6733651f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449088f,1.365117f,0.7841167f,-0.7102067f,0.00917693f,0.02384737f,0.7035294f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 12.7482f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 19.0756f);
Get(0xFA26).SetLocalPose(1.365617f,1.334938f,0.7761824f,-0.7234288f,-0.08705887f,0.1522747f,0.6677454f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449129f,1.365012f,0.7840675f,-0.7101541f,0.009205167f,0.02383376f,0.7035826f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 12.82233f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 19.09969f);
Get(0xFA26).SetLocalPose(1.356024f,1.334995f,0.77563f,-0.7148187f,-0.1351524f,0.2087462f,0.6536002f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449075f,1.364992f,0.7839665f,-0.7101617f,0.009197915f,0.02383161f,0.7035751f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 12.84818f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 19.10809f);
Get(0xFA26).SetLocalPose(1.353023f,1.334947f,0.7750922f,-0.7112944f,-0.149046f,0.2259778f,0.6486754f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.4492f,1.364851f,0.7839896f,-0.7101867f,0.009182727f,0.02384339f,0.7035497f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 12.91015f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 19.12823f);
Get(0xFA26).SetLocalPose(1.347172f,1.333909f,0.7748199f,-0.7049152f,-0.1734675f,0.2554416f,0.6385555f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449018f,1.364965f,0.7838598f,-0.710151f,0.009201806f,0.02384217f,0.7035855f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 12.96515f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 19.14611f);
Get(0xFA26).SetLocalPose(1.344939f,1.333116f,0.7745416f,-0.7019637f,-0.1856942f,0.2694441f,0.6325856f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449076f,1.364918f,0.7838733f,-0.7101818f,0.009163735f,0.02386624f,0.703554f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 13.02227f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 19.16467f);
Get(0xFA26).SetLocalPose(1.340476f,1.330744f,0.773456f,-0.6963243f,-0.2129799f,0.298049f,0.6172024f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448983f,1.365106f,0.7839827f,-0.7101884f,0.009162115f,0.02386988f,0.7035472f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 13.07912f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 19.18315f);
Get(0xFA26).SetLocalPose(1.337291f,1.328539f,0.7728676f,-0.6928598f,-0.2311836f,0.3170358f,0.6049693f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449095f,1.365069f,0.7840796f,-0.7102024f,0.009171209f,0.02385009f,0.7035337f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 13.10539f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 19.19169f);
Get(0xFA26).SetLocalPose(1.336476f,1.327622f,0.7726606f,-0.6918987f,-0.2354459f,0.3222784f,0.6016461f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449199f,1.364983f,0.7841325f,-0.7101979f,0.009127595f,0.0238531f,0.7035387f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 13.16652f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 19.21155f);
Get(0xFA26).SetLocalPose(1.334276f,1.326002f,0.7725284f,-0.6898292f,-0.2431877f,0.3324175f,0.5953941f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449405f,1.364905f,0.7843179f,-0.71022f,0.009139458f,0.0238799f,0.7035154f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 13.22199f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 19.22958f);
Get(0xFA26).SetLocalPose(1.333383f,1.323903f,0.7727678f,-0.6877918f,-0.2494877f,0.3402422f,0.5907061f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449474f,1.36493f,0.7842932f,-0.7102227f,0.009144079f,0.02385648f,0.7035134f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 13.27638f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 19.24726f);
Get(0xFA26).SetLocalPose(1.332294f,1.322029f,0.7727525f,-0.6865481f,-0.2544551f,0.3459123f,0.5867274f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449282f,1.364837f,0.7843078f,-0.7102392f,0.009090393f,0.02387222f,0.7034968f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 13.33342f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 19.26579f);
Get(0xFA26).SetLocalPose(1.331631f,1.321609f,0.7727952f,-0.686281f,-0.2566033f,0.348691f,0.584455f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449265f,1.36501f,0.7843691f,-0.7102168f,0.009125324f,0.02391981f,0.7035174f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 13.35886f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 19.27407f);
Get(0xFA26).SetLocalPose(1.331414f,1.321382f,0.7728843f,-0.6863201f,-0.2571289f,0.3496664f,0.5835948f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449309f,1.365054f,0.7842166f,-0.710222f,0.009139867f,0.02385032f,0.7035143f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 13.41957f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 19.2938f);
Get(0xFA26).SetLocalPose(1.33119f,1.320938f,0.7728774f,-0.6864722f,-0.257376f,0.3504029f,0.5828647f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449387f,1.365126f,0.7844235f,-0.7102256f,0.009135409f,0.02389815f,0.7035092f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 13.47647f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 19.31229f);
Get(0xFA26).SetLocalPose(1.331014f,1.320217f,0.7728857f,-0.6869369f,-0.2573433f,0.3514158f,0.5817209f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449337f,1.36515f,0.784314f,-0.7102168f,0.009150865f,0.02387143f,0.7035187f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 13.53453f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 19.33116f);
Get(0xFA26).SetLocalPose(1.330579f,1.319688f,0.772687f,-0.6871149f,-0.257385f,0.3524746f,0.580851f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449387f,1.365004f,0.7843181f,-0.7102135f,0.009131867f,0.02386096f,0.7035227f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 13.59163f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 19.34971f);
Get(0xFA26).SetLocalPose(1.330241f,1.31864f,0.7726853f,-0.6869101f,-0.2579107f,0.354459f,0.5796512f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449404f,1.365006f,0.7843227f,-0.7102085f,0.009116381f,0.02386186f,0.7035279f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 13.61789f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 19.35825f);
Get(0xFA26).SetLocalPose(1.330137f,1.318278f,0.7727177f,-0.68694f,-0.2579319f,0.3549322f,0.5793167f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449581f,1.365081f,0.7843735f,-0.7102293f,0.009092883f,0.02386765f,0.7035069f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 13.67972f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 19.37834f);
Get(0xFA26).SetLocalPose(1.330096f,1.318302f,0.772778f,-0.6871912f,-0.2572923f,0.3553062f,0.5790738f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449544f,1.365012f,0.7841957f,-0.7102134f,0.009126041f,0.0238767f,0.7035223f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 13.74054f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 19.39811f);
Get(0xFA26).SetLocalPose(1.330045f,1.318501f,0.7728584f,-0.6874004f,-0.2567847f,0.3552316f,0.5790966f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449511f,1.364946f,0.784197f,-0.7102145f,0.00911558f,0.02386965f,0.7035215f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 13.79606f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 19.41615f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449567f,1.365065f,0.7843483f,-0.7102523f,0.009105691f,0.02387347f,0.7034833f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 13.82244f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 19.42473f);
Get(0xFA26).SetLocalPose(1.330078f,1.318356f,0.7728397f,-0.6876787f,-0.2562033f,0.3549703f,0.579184f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44954f,1.365192f,0.7844275f,-0.7102248f,0.009102096f,0.02390675f,0.70351f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 13.88068f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 19.44366f);
Get(0xFA26).SetLocalPose(1.330132f,1.31804f,0.7729691f,-0.6880499f,-0.2556606f,0.3546355f,0.5791879f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449516f,1.365185f,0.7843723f,-0.7102098f,0.00912622f,0.02387026f,0.7035262f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 13.93637f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 19.46176f);
Get(0xFA26).SetLocalPose(1.330007f,1.318064f,0.7731579f,-0.6883998f,-0.2559365f,0.355022f,0.5784131f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449475f,1.3651f,0.7842718f,-0.7102055f,0.009169539f,0.02390061f,0.7035289f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 13.99459f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 19.48068f);
Get(0xFA26).SetLocalPose(1.329063f,1.31733f,0.7730006f,-0.6878498f,-0.2592252f,0.3586428f,0.5753612f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449323f,1.365122f,0.7841396f,-0.7102118f,0.009167229f,0.02388571f,0.703523f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 14.04973f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 19.4986f);
Get(0xFA26).SetLocalPose(1.328416f,1.316096f,0.7736222f,-0.6876131f,-0.2596855f,0.360524f,0.5742597f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449142f,1.365141f,0.7841479f,-0.7101983f,0.009178449f,0.02386826f,0.7035372f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 14.07566f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 19.50702f);
Get(0xFA26).SetLocalPose(1.328274f,1.315523f,0.7738531f,-0.6881172f,-0.2587386f,0.3594306f,0.5747685f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449222f,1.365096f,0.784155f,-0.7102083f,0.009115499f,0.02391941f,0.7035261f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 14.13342f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 19.52579f);
Get(0xFA26).SetLocalPose(1.327843f,1.314769f,0.7740524f,-0.6880544f,-0.2599083f,0.3599921f,0.5739639f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449227f,1.365087f,0.7842136f,-0.7102058f,0.009099142f,0.02390769f,0.7035292f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 14.1907f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 19.54441f);
Get(0xFA26).SetLocalPose(1.326386f,1.314204f,0.7739938f,-0.6869401f,-0.2629049f,0.3634738f,0.5717352f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44921f,1.36503f,0.7842038f,-0.7102071f,0.009125678f,0.02389668f,0.703528f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 14.24493f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 19.56204f);
Get(0xFA26).SetLocalPose(1.325888f,1.314102f,0.7740946f,-0.6859786f,-0.2637086f,0.3657021f,0.5710983f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449183f,1.365118f,0.7842796f,-0.7101949f,0.009153171f,0.02387437f,0.7035407f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 14.3023f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 19.58068f);
Get(0xFA26).SetLocalPose(1.324452f,1.31434f,0.7742975f,-0.6846619f,-0.2624185f,0.3693037f,0.5709549f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449168f,1.365076f,0.7841651f,-0.7101815f,0.009133946f,0.02384112f,0.7035556f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 14.35799f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 19.59878f);
Get(0xFA26).SetLocalPose(1.323655f,1.31394f,0.774509f,-0.6834044f,-0.2604496f,0.373064f,0.5709183f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449172f,1.365049f,0.7842107f,-0.7101903f,0.009136135f,0.02384078f,0.7035468f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 14.38331f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 19.60701f);
Get(0xFA26).SetLocalPose(1.322853f,1.313232f,0.7743158f,-0.6822647f,-0.2596735f,0.3768948f,0.5701183f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449321f,1.365025f,0.7841989f,-0.7102062f,0.009115713f,0.02387217f,0.7035298f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 14.44252f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 19.62626f);
Get(0xFA26).SetLocalPose(1.321023f,1.312554f,0.7742691f,-0.680621f,-0.2592064f,0.3829795f,0.5682375f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449318f,1.365024f,0.7841585f,-0.7102109f,0.009105832f,0.02388369f,0.7035248f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 14.49866f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 19.6445f);
Get(0xFA26).SetLocalPose(1.319939f,1.312474f,0.7739217f,-0.679753f,-0.2598564f,0.3865279f,0.5665746f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449321f,1.365136f,0.7842607f,-0.710213f,0.00912688f,0.02385985f,0.7035232f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 14.5554f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 19.66294f);
Get(0xFA26).SetLocalPose(1.318832f,1.311808f,0.7732901f,-0.6780109f,-0.2624576f,0.3919178f,0.5637532f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449476f,1.365196f,0.7843688f,-0.7101984f,0.009155331f,0.02388736f,0.7035367f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 14.61003f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 19.68069f);
Get(0xFA26).SetLocalPose(1.318235f,1.31156f,0.7731795f,-0.6765346f,-0.2605848f,0.3958799f,0.5636272f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44951f,1.365266f,0.7842824f,-0.7102056f,0.009167882f,0.02385956f,0.7035303f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 14.66678f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 19.69914f);
Get(0xFA26).SetLocalPose(1.31792f,1.311244f,0.7735537f,-0.6749756f,-0.2538413f,0.4004922f,0.5653128f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449404f,1.365246f,0.7842871f,-0.7102116f,0.009139377f,0.0238735f,0.7035241f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 14.69216f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 19.70739f);
Get(0xFA26).SetLocalPose(1.318091f,1.310844f,0.7734919f,-0.6738909f,-0.2483582f,0.403386f,0.5669823f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449379f,1.365144f,0.7842031f,-0.7101946f,0.009169149f,0.02385456f,0.7035414f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 14.75124f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 19.72659f);
Get(0xFA26).SetLocalPose(1.317832f,1.310379f,0.7737358f,-0.6717994f,-0.240476f,0.4094191f,0.5685357f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449237f,1.365121f,0.7841424f,-0.7101907f,0.009144497f,0.02387998f,0.7035448f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 14.8075f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 19.74487f);
Get(0xFA26).SetLocalPose(1.317519f,1.310501f,0.7735425f,-0.6672802f,-0.2398216f,0.4154776f,0.5697378f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449172f,1.365067f,0.7840846f,-0.7101806f,0.009142092f,0.0238772f,0.7035552f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 14.86249f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 19.76275f);
Get(0xFA26).SetLocalPose(1.316879f,1.309767f,0.774252f,-0.6627749f,-0.2400785f,0.4190177f,0.5722901f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449033f,1.365113f,0.7838743f,-0.7101657f,0.009160107f,0.02386026f,0.7035705f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.03012338f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 19.78066f);
Get(0xFA26).SetLocalPose(1.315732f,1.309252f,0.7755333f,-0.6569857f,-0.2392057f,0.4234449f,0.5760598f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44916f,1.365037f,0.7838824f,-0.7101741f,0.009164524f,0.0238543f,0.7035622f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.08465078f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 19.79838f);
Get(0xFA26).SetLocalPose(1.315364f,1.30789f,0.775836f,-0.6571192f,-0.2329224f,0.4271708f,0.5757314f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449111f,1.365044f,0.7839376f,-0.7101766f,0.009185202f,0.02389397f,0.7035581f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.1408572f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 19.81665f);
Get(0xFA26).SetLocalPose(1.31541f,1.3076f,0.7754598f,-0.659816f,-0.2287596f,0.4273867f,0.5741537f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449109f,1.365048f,0.7839011f,-0.7101745f,0.009164054f,0.02386587f,0.7035614f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.1667582f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 19.82507f);
Get(0xFA26).SetLocalPose(1.315618f,1.307355f,0.7754836f,-0.6615148f,-0.2274121f,0.427661f,0.5725277f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448985f,1.365079f,0.7838624f,-0.7101667f,0.009191378f,0.02385573f,0.7035694f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.2272047f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 19.84471f);
Get(0xFA26).SetLocalPose(1.315559f,1.306702f,0.7752117f,-0.6642593f,-0.227662f,0.4286726f,0.56848f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449121f,1.365012f,0.7837592f,-0.7101561f,0.009155941f,0.023892f,0.7035792f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.2817468f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 19.86244f);
Get(0xFA26).SetLocalPose(1.31522f,1.30606f,0.774882f,-0.6649132f,-0.2290004f,0.4289269f,0.5669842f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449222f,1.365007f,0.7838404f,-0.7101657f,0.009171381f,0.02387666f,0.7035698f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.3371465f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 19.88044f);
Get(0xFA26).SetLocalPose(1.315188f,1.305898f,0.7749094f,-0.6644263f,-0.2288971f,0.4293246f,0.5672956f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449298f,1.364981f,0.7839174f,-0.7101741f,0.00914589f,0.02387642f,0.7035617f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.3708579f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 19.8914f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449371f,1.364877f,0.7840302f,-0.7101997f,0.009152133f,0.02386654f,0.7035361f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.4051127f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 19.90253f);
Get(0xFA26).SetLocalPose(1.31543f,1.305303f,0.7753392f,-0.6639087f,-0.2294529f,0.4295725f,0.5674893f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449419f,1.364736f,0.7840719f,-0.7101833f,0.009115839f,0.02390166f,0.7035519f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.4516619f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 19.91766f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449373f,1.364814f,0.7840762f,-0.7101863f,0.009104892f,0.02389681f,0.7035491f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.5034444f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 19.93449f);
Get(0xFA26).SetLocalPose(1.315273f,1.304807f,0.7758597f,-0.6624634f,-0.2271204f,0.4303907f,0.5694932f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44943f,1.365079f,0.7841212f,-0.7102057f,0.009114076f,0.02388634f,0.7035299f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.5871816f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 19.9617f);
Get(0xFA26).SetLocalPose(1.315951f,1.304318f,0.7755065f,-0.6677037f,-0.2209282f,0.4260128f,0.5691007f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449575f,1.365041f,0.7840891f,-0.7102095f,0.009097211f,0.02388022f,0.7035264f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.6295499f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 19.97547f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449473f,1.365047f,0.7842144f,-0.7102128f,0.009084616f,0.02388848f,0.7035231f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.6813819f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 19.99232f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449495f,1.365185f,0.7842351f,-0.7102062f,0.009086952f,0.02390484f,0.7035291f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.7303238f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 20.00822f);
Get(0xFA26).SetLocalPose(1.316149f,1.30401f,0.7754747f,-0.6674504f,-0.2219891f,0.4269504f,0.5682818f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449441f,1.365244f,0.7842515f,-0.7101982f,0.00910053f,0.0238961f,0.7035373f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.7669945f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 20.02014f);
Get(0xFA26).SetLocalPose(1.316572f,1.304044f,0.7757168f,-0.6670487f,-0.2217354f,0.4274538f,0.5684741f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449421f,1.365317f,0.7841778f,-0.710192f,0.009108179f,0.0238988f,0.7035434f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.8128004f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 20.03503f);
Get(0xFA26).SetLocalPose(1.317003f,1.304527f,0.7756056f,-0.6676296f,-0.2197317f,0.426486f,0.5692965f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449355f,1.365352f,0.7842633f,-0.7102094f,0.009120495f,0.02386784f,0.7035267f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.8689303f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 20.05327f);
Get(0xFA26).SetLocalPose(1.317363f,1.305018f,0.7753858f,-0.6685574f,-0.2177822f,0.4248781f,0.5701584f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44921f,1.365131f,0.7841293f,-0.7102016f,0.009153359f,0.02385942f,0.7035344f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.9178364f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 20.06916f);
Get(0xFA26).SetLocalPose(1.317232f,1.304546f,0.7754179f,-0.6690381f,-0.2180966f,0.4240619f,0.570082f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449175f,1.365198f,0.7841795f,-0.7102049f,0.00914757f,0.02386693f,0.7035308f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.9732863f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 20.08718f);
Get(0xFA26).SetLocalPose(1.317514f,1.305273f,0.7753024f,-0.6691305f,-0.2186186f,0.4238307f,0.5699455f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44932f,1.365252f,0.7842568f,-0.7102087f,0.009144846f,0.02384631f,0.7035279f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.030002f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 20.10562f);
Get(0xFA26).SetLocalPose(1.317148f,1.305202f,0.7758415f,-0.6685671f,-0.2163757f,0.4245822f,0.5709025f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44948f,1.365108f,0.7842018f,-0.710227f,0.009138393f,0.02385139f,0.7035093f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.088096f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 20.1245f);
Get(0xFA26).SetLocalPose(1.316996f,1.30521f,0.7757401f,-0.6685753f,-0.2156596f,0.4245388f,0.571196f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449269f,1.365048f,0.7841684f,-0.7102301f,0.00915216f,0.02383376f,0.7035065f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.151243f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 20.14502f);
Get(0xFA26).SetLocalPose(1.317085f,1.305506f,0.7755815f,-0.6679838f,-0.2149855f,0.4243251f,0.5722998f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449325f,1.364857f,0.7842383f,-0.7102389f,0.009129641f,0.02386186f,0.703497f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.210353f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 20.16423f);
Get(0xFA26).SetLocalPose(1.316356f,1.306237f,0.7758974f,-0.6671853f,-0.2155578f,0.4251666f,0.5723916f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449408f,1.36486f,0.7842747f,-0.7102514f,0.009148791f,0.02384492f,0.7034847f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.266691f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 20.18254f);
Get(0xFA26).SetLocalPose(1.315927f,1.306651f,0.7758178f,-0.66685f,-0.2152763f,0.425692f,0.5724977f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449336f,1.364888f,0.7843152f,-0.7102548f,0.009095193f,0.02384034f,0.7034821f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.292607f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 20.19096f);
Get(0xFA26).SetLocalPose(1.315826f,1.30687f,0.7758407f,-0.6667981f,-0.2148945f,0.4257421f,0.5726642f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449353f,1.364952f,0.7844646f,-0.7102627f,0.00911952f,0.02383094f,0.7034741f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.356003f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 20.21157f);
Get(0xFA26).SetLocalPose(1.315905f,1.306791f,0.7756897f,-0.6667984f,-0.2148023f,0.4257255f,0.572711f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449311f,1.36495f,0.7846643f,-0.7102751f,0.009137322f,0.02381676f,0.7034619f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.413849f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 20.23037f);
Get(0xFA26).SetLocalPose(1.316009f,1.306731f,0.7756864f,-0.6668327f,-0.2142482f,0.4255799f,0.5729865f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449219f,1.364925f,0.7845456f,-0.7102407f,0.009137983f,0.02380763f,0.7034969f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.470652f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 20.24883f);
Get(0xFA26).SetLocalPose(1.315981f,1.306709f,0.7757874f,-0.6666511f,-0.2141558f,0.4255278f,0.573271f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449203f,1.364912f,0.7845642f,-0.7102539f,0.009142485f,0.02378413f,0.7034844f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.496592f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 20.25726f);
Get(0xFA26).SetLocalPose(1.316054f,1.307006f,0.7754853f,-0.6664849f,-0.2142397f,0.4255834f,0.5733918f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449233f,1.364899f,0.7846546f,-0.7102542f,0.009135005f,0.02380038f,0.7034836f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.558503f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 20.27738f);
Get(0xFA26).SetLocalPose(1.316058f,1.307533f,0.775314f,-0.6661367f,-0.2144397f,0.4256745f,0.5736539f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449223f,1.364922f,0.7845658f,-0.7102359f,0.009142521f,0.02380007f,0.7035019f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.615692f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 20.29597f);
Get(0xFA26).SetLocalPose(1.315821f,1.307969f,0.7755991f,-0.6658657f,-0.2145616f,0.4256792f,0.5739195f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44928f,1.364833f,0.7845684f,-0.7102417f,0.009139844f,0.02381716f,0.7034956f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.672286f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 20.31436f);
Get(0xFA26).SetLocalPose(1.315938f,1.308277f,0.7757718f,-0.6663326f,-0.2138394f,0.4250931f,0.5740815f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449356f,1.364908f,0.7845466f,-0.7102218f,0.009163383f,0.0238443f,0.7035145f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.727872f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 20.33243f);
Get(0xFA26).SetLocalPose(1.315732f,1.308621f,0.7761625f,-0.66577f,-0.2143421f,0.4255968f,0.5741735f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44936f,1.364897f,0.7845844f,-0.7102244f,0.009165796f,0.0238333f,0.7035121f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.753802f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 20.34085f);
Get(0xFA26).SetLocalPose(1.315638f,1.308798f,0.7759193f,-0.6654655f,-0.2145947f,0.4258593f,0.5742375f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449012f,1.365068f,0.7843741f,-0.7102066f,0.00918926f,0.02382445f,0.7035301f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.815428f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 20.36088f);
Get(0xFA26).SetLocalPose(1.315282f,1.308674f,0.7759798f,-0.6649936f,-0.2151407f,0.4263049f,0.5742492f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448969f,1.365141f,0.7843876f,-0.7102075f,0.009178688f,0.02385389f,0.7035283f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.872548f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 20.37945f);
Get(0xFA26).SetLocalPose(1.314992f,1.309079f,0.7760505f,-0.6650193f,-0.2152566f,0.4262776f,0.5741962f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448957f,1.365143f,0.7841901f,-0.7102034f,0.009191897f,0.02386261f,0.703532f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.930453f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 20.39827f);
Get(0xFA26).SetLocalPose(1.31483f,1.308579f,0.7763423f,-0.6651787f,-0.214996f,0.426078f,0.5742576f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449017f,1.365127f,0.7840673f,-0.7101901f,0.009176539f,0.02386018f,0.7035457f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.986782f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 20.41657f);
Get(0xFA26).SetLocalPose(1.314751f,1.308175f,0.7770054f,-0.6649953f,-0.2152236f,0.4262815f,0.5742336f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449034f,1.365162f,0.7840731f,-0.710183f,0.009164569f,0.02386474f,0.7035529f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.012154f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 20.42482f);
Get(0xFA26).SetLocalPose(1.31453f,1.308162f,0.7771043f,-0.6647424f,-0.215493f,0.426616f,0.574177f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449008f,1.365158f,0.7839648f,-0.7101912f,0.009176377f,0.02384627f,0.7035451f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.074233f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 20.44499f);
Get(0xFA26).SetLocalPose(1.314436f,1.308151f,0.7772855f,-0.664349f,-0.2159456f,0.4271226f,0.5740856f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449023f,1.365204f,0.7839781f,-0.7101907f,0.009187398f,0.02386338f,0.703545f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.130959f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 20.46343f);
Get(0xFA26).SetLocalPose(1.313856f,1.307895f,0.7775549f,-0.6621732f,-0.2191487f,0.4300067f,0.5732319f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449067f,1.364985f,0.7840599f,-0.7101869f,0.0091863f,0.02385975f,0.7035488f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.18795f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 20.48195f);
Get(0xFA26).SetLocalPose(1.313199f,1.307268f,0.7779532f,-0.6594559f,-0.2230904f,0.4336272f,0.5721154f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449115f,1.365038f,0.7839708f,-0.7101835f,0.009181238f,0.0238481f,0.7035527f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.213835f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 20.49037f);
Get(0xFA26).SetLocalPose(1.312703f,1.307351f,0.7779723f,-0.6585829f,-0.2241893f,0.4347898f,0.5718091f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449171f,1.364972f,0.7839233f,-0.710181f,0.009157427f,0.02387222f,0.7035548f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.276277f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 20.51066f);
Get(0xFA26).SetLocalPose(1.311835f,1.306886f,0.778064f,-0.6544544f,-0.2297388f,0.4400638f,0.5703099f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449223f,1.36496f,0.7839305f,-0.710179f,0.009144709f,0.02388731f,0.7035565f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.33252f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 20.52894f);
Get(0xFA26).SetLocalPose(1.311125f,1.305804f,0.7785927f,-0.6489288f,-0.2377485f,0.44648f,0.5683509f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449187f,1.364933f,0.784023f,-0.7101742f,0.009139528f,0.02386793f,0.703562f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.389438f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 20.54744f);
Get(0xFA26).SetLocalPose(1.309955f,1.305217f,0.7792794f,-0.6438959f,-0.2447299f,0.452306f,0.5665022f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.4492f,1.364938f,0.783833f,-0.710169f,0.009134673f,0.02385554f,0.7035677f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.444959f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 20.56548f);
Get(0xFA26).SetLocalPose(1.308017f,1.304478f,0.7799849f,-0.634689f,-0.2572691f,0.4627611f,0.5628807f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449387f,1.364938f,0.7839346f,-0.7101963f,0.009150359f,0.02387471f,0.7035393f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.472204f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 20.57434f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449313f,1.365019f,0.7839395f,-0.7101887f,0.009152926f,0.02385632f,0.7035475f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.5181f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 20.58925f);
Get(0xFA26).SetLocalPose(1.306631f,1.303465f,0.7805624f,-0.6251597f,-0.2699485f,0.4737417f,0.5584551f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449285f,1.365074f,0.783904f,-0.7101681f,0.009154628f,0.02386074f,0.7035682f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.565586f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 20.60468f);
Get(0xFA26).SetLocalPose(1.305924f,1.302938f,0.7812189f,-0.6198993f,-0.2768174f,0.4798652f,0.5557216f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449033f,1.3651f,0.7838179f,-0.7101594f,0.009194805f,0.0238225f,0.7035778f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.649997f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 20.63212f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448966f,1.365015f,0.7836608f,-0.7101559f,0.009202997f,0.02382727f,0.703581f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.677214f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 20.64096f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448994f,1.365037f,0.7838638f,-0.7101935f,0.009169065f,0.02382409f,0.7035437f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.741906f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 20.66199f);
Get(0xFA26).SetLocalPose(1.300877f,1.299042f,0.7826304f,-0.5892261f,-0.3134091f,0.5133602f,0.5394893f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449105f,1.365105f,0.7840749f,-0.7101934f,0.009174714f,0.02383027f,0.7035435f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.802784f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 20.68177f);
Get(0xFA26).SetLocalPose(1.296302f,1.296028f,0.7847632f,-0.5613083f,-0.3422755f,0.5428291f,0.522606f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449164f,1.36502f,0.7842081f,-0.7101997f,0.0091855f,0.02380346f,0.7035378f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.829713f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 20.69052f);
Get(0xFA26).SetLocalPose(1.293619f,1.292496f,0.78628f,-0.5402237f,-0.3617366f,0.5638667f,0.5092734f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449069f,1.365059f,0.7842237f,-0.7101955f,0.009171832f,0.02382104f,0.7035416f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.894024f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 20.71143f);
Get(0xFA26).SetLocalPose(1.288075f,1.287095f,0.7884476f,-0.5051229f,-0.3895093f,0.5968689f,0.4867041f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449082f,1.365056f,0.7842399f,-0.7102011f,0.009219774f,0.02381388f,0.7035357f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.951298f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 20.73004f);
Get(0xFA26).SetLocalPose(1.286158f,1.283574f,0.789479f,-0.4859657f,-0.4023437f,0.614512f,0.473637f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44903f,1.364909f,0.7841271f,-0.7101995f,0.009186614f,0.02382709f,0.7035372f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.009558f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 20.74897f);
Get(0xFA26).SetLocalPose(1.285176f,1.280932f,0.7904664f,-0.4742893f,-0.4090954f,0.6253189f,0.4654751f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448963f,1.364945f,0.784005f,-0.7101964f,0.009180289f,0.02383316f,0.7035403f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.034955f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 20.75723f);
Get(0xFA26).SetLocalPose(1.284371f,1.279543f,0.7909416f,-0.468181f,-0.4122846f,0.6309086f,0.4612833f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44897f,1.364981f,0.7839909f,-0.7102014f,0.009144799f,0.02385699f,0.7035349f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.097444f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 20.77754f);
Get(0xFA26).SetLocalPose(1.282635f,1.275493f,0.7931738f,-0.4409893f,-0.4246396f,0.6548878f,0.4430933f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449102f,1.36489f,0.7841596f,-0.7102269f,0.009167785f,0.02383401f,0.7035096f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.155145f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 20.79629f);
Get(0xFA26).SetLocalPose(1.282632f,1.271432f,0.7951795f,-0.4217286f,-0.4317435f,0.6721161f,0.4289551f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449181f,1.36499f,0.784254f,-0.7102197f,0.009198329f,0.02383265f,0.7035165f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.213289f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 20.81519f);
Get(0xFA26).SetLocalPose(1.282483f,1.270846f,0.7954456f,-0.4192765f,-0.4324507f,0.6743797f,0.4270898f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449193f,1.364997f,0.7842523f,-0.7102072f,0.009217348f,0.02385621f,0.7035281f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.238812f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 20.82348f);
Get(0xFA26).SetLocalPose(1.282271f,1.269134f,0.7958026f,-0.4134563f,-0.4335374f,0.680005f,0.4227203f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449064f,1.365031f,0.7841719f,-0.7102076f,0.009233155f,0.02383634f,0.7035282f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.300997f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 20.84369f);
Get(0xFA26).SetLocalPose(1.284454f,1.266025f,0.7970719f,-0.3983646f,-0.4340077f,0.6954105f,0.4115182f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449014f,1.364895f,0.7841572f,-0.7102076f,0.009217299f,0.02385776f,0.7035276f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.358027f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 20.86222f);
Get(0xFA26).SetLocalPose(1.284755f,1.263985f,0.7981811f,-0.3925325f,-0.433717f,0.7017093f,0.4067087f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448926f,1.36499f,0.784061f,-0.7101893f,0.009221951f,0.02382829f,0.703547f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.414656f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 20.88063f);
Get(0xFA26).SetLocalPose(1.284904f,1.263943f,0.7983298f,-0.3910926f,-0.4333336f,0.7035524f,0.405318f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448761f,1.364871f,0.7841007f,-0.7101917f,0.00923363f,0.02380875f,0.7035452f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.472296f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 20.89936f);
Get(0xFA26).SetLocalPose(1.286554f,1.262263f,0.7981843f,-0.3888708f,-0.4307138f,0.7079164f,0.4026407f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448732f,1.36494f,0.7840887f,-0.7101858f,0.009261103f,0.02380337f,0.7035509f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.498409f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 20.90785f);
Get(0xFA26).SetLocalPose(1.286697f,1.261814f,0.798348f,-0.3883128f,-0.4298873f,0.70903f,0.4021026f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448611f,1.364906f,0.7840153f,-0.7101759f,0.009257643f,0.02382603f,0.7035602f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.559053f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 20.92756f);
Get(0xFA26).SetLocalPose(1.288318f,1.260787f,0.7986138f,-0.3862556f,-0.4289089f,0.7118466f,0.4001478f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448777f,1.36477f,0.78403f,-0.7102f,0.009222539f,0.02380505f,0.703537f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.614921f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 20.94571f);
Get(0xFA26).SetLocalPose(1.289142f,1.260294f,0.7979667f,-0.3847305f,-0.4285037f,0.7137226f,0.3987068f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448833f,1.364793f,0.7840194f,-0.7102148f,0.00919708f,0.02379546f,0.7035227f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.671099f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 20.96397f);
Get(0xFA26).SetLocalPose(1.290767f,1.260059f,0.7969415f,-0.3861672f,-0.426222f,0.713887f,0.3994685f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44892f,1.364857f,0.7841923f,-0.7102173f,0.009185201f,0.02381129f,0.7035198f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.726847f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 20.98209f);
Get(0xFA26).SetLocalPose(1.291187f,1.260193f,0.7968939f,-0.3871958f,-0.4252664f,0.7136822f,0.399857f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448887f,1.364837f,0.7841582f,-0.71022f,0.009153032f,0.02383742f,0.7035166f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.752766f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 20.99051f);
Get(0xFA26).SetLocalPose(1.290878f,1.260714f,0.7972544f,-0.3872764f,-0.4251955f,0.7136975f,0.3998272f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449029f,1.364912f,0.7842077f,-0.7102264f,0.00915662f,0.02383359f,0.7035103f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.815744f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 21.01098f);
Get(0xFA26).SetLocalPose(1.290716f,1.261173f,0.7972084f,-0.3870697f,-0.4252098f,0.714123f,0.3992519f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449357f,1.365058f,0.7842973f,-0.7102258f,0.009111897f,0.02383883f,0.7035113f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.872916f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 21.02956f);
Get(0xFA26).SetLocalPose(1.291013f,1.260502f,0.79694f,-0.3873814f,-0.4246254f,0.7140285f,0.39974f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449478f,1.365175f,0.784321f,-0.7102173f,0.009127968f,0.02385015f,0.7035193f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.929638f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 21.048f);
Get(0xFA26).SetLocalPose(1.290519f,1.261088f,0.7971854f,-0.3889021f,-0.4239429f,0.712725f,0.401311f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449555f,1.36518f,0.784252f,-0.7102107f,0.009115003f,0.02385819f,0.7035257f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.986864f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 21.0666f);
Get(0xFA26).SetLocalPose(1.290128f,1.262538f,0.797079f,-0.391416f,-0.4233561f,0.7107915f,0.4029126f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449454f,1.365252f,0.7842938f,-0.7102191f,0.009116902f,0.02382361f,0.7035184f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.013849f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 21.07537f);
Get(0xFA26).SetLocalPose(1.289779f,1.262811f,0.797191f,-0.3917529f,-0.4233724f,0.7102656f,0.403495f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449517f,1.365147f,0.7843505f,-0.7102271f,0.009085781f,0.02381745f,0.7035109f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.075235f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 21.09532f);
Get(0xFA26).SetLocalPose(1.289732f,1.263065f,0.7970636f,-0.3938516f,-0.4220121f,0.7084965f,0.4059798f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449552f,1.365115f,0.7845459f,-0.7102241f,0.009113285f,0.02385366f,0.7035125f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.132325f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 21.11387f);
Get(0xFA26).SetLocalPose(1.289522f,1.263407f,0.7965888f,-0.3977584f,-0.4196631f,0.704921f,0.4108011f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44951f,1.365036f,0.7844794f,-0.7101989f,0.009084814f,0.0238626f,0.7035378f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.189179f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 21.13235f);
Get(0xFA26).SetLocalPose(1.288602f,1.265196f,0.7963974f,-0.400584f,-0.4183114f,0.7020543f,0.4143282f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449414f,1.36496f,0.784467f,-0.7102206f,0.009072186f,0.02387216f,0.7035159f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.216067f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 21.14108f);
Get(0xFA26).SetLocalPose(1.28838f,1.266041f,0.7961209f,-0.4023986f,-0.4175793f,0.7000859f,0.4166326f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449514f,1.364951f,0.7843764f,-0.7102233f,0.009080893f,0.02385546f,0.7035136f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.276737f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 21.1608f);
Get(0xFA26).SetLocalPose(1.288134f,1.266121f,0.7963548f,-0.4026514f,-0.4175068f,0.6997391f,0.4170433f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449634f,1.364928f,0.7843928f,-0.7102264f,0.009071689f,0.02388956f,0.7035094f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.332672f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 21.17898f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449656f,1.365009f,0.784522f,-0.7102314f,0.009099504f,0.02389733f,0.7035038f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.387961f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 21.19695f);
Get(0xFA26).SetLocalPose(1.28798f,1.266518f,0.7961952f,-0.4041771f,-0.4170579f,0.6979911f,0.4189416f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449574f,1.3652f,0.7845557f,-0.7102315f,0.009084586f,0.02389413f,0.7035039f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.444378f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 21.21528f);
Get(0xFA26).SetLocalPose(1.288333f,1.268457f,0.7956941f,-0.4114411f,-0.4133104f,0.6909158f,0.4272309f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449725f,1.365184f,0.7845829f,-0.7102252f,0.009083396f,0.02389721f,0.7035102f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.49971f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 21.23327f);
Get(0xFA26).SetLocalPose(1.287692f,1.275733f,0.7944514f,-0.43959f,-0.3934359f,0.6632466f,0.4605137f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44975f,1.365291f,0.7844448f,-0.7102059f,0.009076181f,0.02390174f,0.7035296f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.524982f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 21.24148f);
Get(0xFA26).SetLocalPose(1.288056f,1.279686f,0.7932712f,-0.4514575f,-0.3874592f,0.6486344f,0.4746946f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449674f,1.365292f,0.784244f,-0.7102016f,0.009088382f,0.02390241f,0.7035338f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.583961f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 21.26065f);
Get(0xFA26).SetLocalPose(1.288435f,1.283696f,0.7913364f,-0.4647356f,-0.3803573f,0.6338274f,0.4874545f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449596f,1.365195f,0.7840986f,-0.7101952f,0.009084859f,0.02386928f,0.7035414f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.638036f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 21.27822f);
Get(0xFA26).SetLocalPose(1.288519f,1.288738f,0.790773f,-0.4797205f,-0.3671024f,0.6179004f,0.5032924f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449685f,1.365109f,0.7842383f,-0.7102143f,0.009095266f,0.02389351f,0.7035213f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.692738f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 21.296f);
Get(0xFA26).SetLocalPose(1.289254f,1.292075f,0.7887787f,-0.4957279f,-0.3514492f,0.6016473f,0.5184187f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449633f,1.365101f,0.7842368f,-0.710206f,0.009092215f,0.02389302f,0.7035297f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.747192f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 21.3137f);
Get(0xFA26).SetLocalPose(1.294138f,1.301507f,0.7863141f,-0.5414079f,-0.3046061f,0.5506958f,0.5575184f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449569f,1.364996f,0.7842982f,-0.710213f,0.009070291f,0.02389257f,0.7035228f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.802325f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 21.33162f);
Get(0xFA26).SetLocalPose(1.297682f,1.307799f,0.7857246f,-0.5734363f,-0.2679344f,0.5046806f,0.5870941f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449637f,1.365f,0.7843237f,-0.7102103f,0.009042069f,0.02389895f,0.7035258f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.858026f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 21.34972f);
Get(0xFA26).SetLocalPose(1.303384f,1.312661f,0.7848235f,-0.5921054f,-0.2450002f,0.4702745f,0.606818f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449634f,1.365013f,0.7842159f,-0.7102106f,0.009037809f,0.02390155f,0.7035254f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.883869f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 21.35812f);
Get(0xFA26).SetLocalPose(1.306581f,1.315091f,0.7840526f,-0.6010281f,-0.2336887f,0.4527324f,0.6157825f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449671f,1.365196f,0.7841909f,-0.7101923f,0.009051249f,0.02387998f,0.7035445f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.942612f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 21.37721f);
Get(0xFA26).SetLocalPose(1.312342f,1.319952f,0.7824138f,-0.6200507f,-0.2063582f,0.4181738f,0.630939f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449587f,1.365175f,0.7841008f,-0.7101834f,0.009060021f,0.02385716f,0.7035541f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.996858f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 21.39484f);
Get(0xFA26).SetLocalPose(1.317571f,1.323032f,0.7807701f,-0.6371352f,-0.1802144f,0.3876542f,0.6413313f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449617f,1.36521f,0.7841961f,-0.7101905f,0.009059151f,0.02388441f,0.7035459f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.051334f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 21.41255f);
Get(0xFA26).SetLocalPose(1.327308f,1.326365f,0.7784867f,-0.6646386f,-0.132648f,0.3291641f,0.6575037f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449564f,1.365254f,0.7843679f,-0.7102183f,0.009088183f,0.02387202f,0.703518f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.105228f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 21.43006f);
Get(0xFA26).SetLocalPose(1.336956f,1.329153f,0.7772239f,-0.6819079f,-0.08701432f,0.2707041f,0.6739061f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449563f,1.365258f,0.78447f,-0.7102463f,0.009042582f,0.0238525f,0.7034909f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.161017f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 21.44819f);
Get(0xFA26).SetLocalPose(1.350016f,1.33061f,0.7765728f,-0.6932174f,-0.02737428f,0.1925196f,0.6940004f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449568f,1.365284f,0.7844702f,-0.7102246f,0.009088928f,0.02384811f,0.7035125f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.186254f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 21.45639f);
Get(0xFA26).SetLocalPose(1.355593f,1.330668f,0.7765496f,-0.6947755f,-0.003403506f,0.1619139f,0.7007563f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449533f,1.365181f,0.7846515f,-0.7102338f,0.009090998f,0.0238444f,0.7035032f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.248589f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 21.47665f);
Get(0xFA26).SetLocalPose(1.369609f,1.328743f,0.7767075f,-0.6928035f,0.0584904f,0.08524921f,0.7136769f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449473f,1.365222f,0.7845859f,-0.7102255f,0.009098953f,0.02386515f,0.7035109f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.306478f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 21.49547f);
Get(0xFA26).SetLocalPose(1.378771f,1.324792f,0.7774334f,-0.6881608f,0.1043112f,0.02525301f,0.7175766f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449404f,1.36525f,0.7845038f,-0.7102292f,0.009128694f,0.02384745f,0.7035074f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.362505f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 21.51367f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449279f,1.36516f,0.7844386f,-0.7102423f,0.009112014f,0.02383328f,0.7034948f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.416239f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 21.53114f);
Get(0xFA26).SetLocalPose(1.384193f,1.32243f,0.7774124f,-0.6857511f,0.1260189f,-0.004564013f,0.7168291f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449115f,1.364966f,0.7843475f,-0.7102248f,0.009147289f,0.0238394f,0.7035118f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.470754f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 21.54885f);
Get(0xFA26).SetLocalPose(1.391161f,1.318253f,0.7774623f,-0.6827019f,0.1572988f,-0.04922061f,0.7118655f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449117f,1.364871f,0.7843945f,-0.7102196f,0.009199347f,0.02384458f,0.7035161f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.495755f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 21.55698f);
Get(0xFA26).SetLocalPose(1.397134f,1.313161f,0.777562f,-0.6787412f,0.187436f,-0.09280945f,0.7039636f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449131f,1.364897f,0.7843657f,-0.7102182f,0.009153464f,0.02382657f,0.7035188f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.557627f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 21.57709f);
Get(0xFA26).SetLocalPose(1.407084f,1.302435f,0.7784671f,-0.6633435f,0.2390976f,-0.1725596f,0.6877725f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449157f,1.364762f,0.7844275f,-0.7102144f,0.009164616f,0.02383689f,0.7035221f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.614294f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 21.5955f);
Get(0xFA26).SetLocalPose(1.412594f,1.290265f,0.7798072f,-0.6436079f,0.2843432f,-0.2403803f,0.6686816f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44902f,1.364757f,0.7843189f,-0.7102087f,0.009190926f,0.02383199f,0.7035277f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.669773f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 21.61353f);
Get(0xFA26).SetLocalPose(1.413374f,1.284325f,0.7793514f,-0.6413922f,0.3035488f,-0.2638218f,0.6533546f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449101f,1.364941f,0.7843782f,-0.7102123f,0.009171369f,0.02382778f,0.7035245f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.725878f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 21.63177f);
Get(0xFA26).SetLocalPose(1.412935f,1.28039f,0.7795529f,-0.640501f,0.3141985f,-0.2770428f,0.6436499f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448985f,1.364835f,0.7842883f,-0.7102116f,0.009180749f,0.02384348f,0.7035246f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.780817f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 21.64962f);
Get(0xFA26).SetLocalPose(1.413024f,1.276874f,0.7797262f,-0.6355905f,0.3243383f,-0.2909065f,0.6373404f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449037f,1.364855f,0.7841145f,-0.7102131f,0.009162715f,0.02385134f,0.7035229f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.807205f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 21.6582f);
Get(0xFA26).SetLocalPose(1.413301f,1.275426f,0.7798461f,-0.6326665f,0.3289062f,-0.2975999f,0.6348134f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448997f,1.364792f,0.7840031f,-0.7102063f,0.009131031f,0.02386412f,0.7035298f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.867832f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 21.6779f);
Get(0xFA26).SetLocalPose(1.412576f,1.273111f,0.7807434f,-0.6293247f,0.3346958f,-0.3059493f,0.6311293f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449004f,1.364906f,0.7839516f,-0.7101941f,0.009150147f,0.02386891f,0.7035416f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.92401f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 21.69616f);
Get(0xFA26).SetLocalPose(1.412102f,1.272211f,0.7805829f,-0.6291698f,0.3370807f,-0.3089417f,0.6285515f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44896f,1.365011f,0.7839332f,-0.7102056f,0.009167467f,0.02382149f,0.7035316f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.981769f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 21.71493f);
Get(0xFA26).SetLocalPose(1.411722f,1.271447f,0.7800645f,-0.6298227f,0.3381663f,-0.3091015f,0.6272346f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448956f,1.365152f,0.7839977f,-0.710205f,0.009150962f,0.02382555f,0.7035322f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.036928f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 21.73285f);
Get(0xFA26).SetLocalPose(1.411771f,1.271683f,0.7799557f,-0.6290792f,0.3400885f,-0.3091796f,0.6269029f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449014f,1.365021f,0.7840471f,-0.7101927f,0.009123945f,0.02384078f,0.7035444f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.062216f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 21.74107f);
Get(0xFA26).SetLocalPose(1.4117f,1.272327f,0.7796195f,-0.6280457f,0.3414909f,-0.3099205f,0.626811f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44934f,1.364944f,0.7843504f,-0.710212f,0.009118507f,0.0238529f,0.7035246f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.122273f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 21.76059f);
Get(0xFA26).SetLocalPose(1.411458f,1.272415f,0.7795526f,-0.6258152f,0.3440146f,-0.3123148f,0.6264733f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449446f,1.365024f,0.7843227f,-0.7102027f,0.009127051f,0.02384298f,0.7035342f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.177508f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 21.77854f);
Get(0xFA26).SetLocalPose(1.411558f,1.27217f,0.779603f,-0.6245402f,0.3453946f,-0.3145971f,0.6258442f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449498f,1.364985f,0.784434f,-0.710209f,0.009159892f,0.02383709f,0.7035277f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.231119f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 21.79597f);
Get(0xFA26).SetLocalPose(1.411541f,1.271661f,0.7794695f,-0.6247297f,0.3455444f,-0.3150551f,0.6253417f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449457f,1.365063f,0.7843576f,-0.7102146f,0.009133844f,0.0238293f,0.7035226f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.286618f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 21.814f);
Get(0xFA26).SetLocalPose(1.411236f,1.272155f,0.7792529f,-0.6249885f,0.3454994f,-0.3145993f,0.6253375f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449565f,1.365086f,0.7844137f,-0.7102327f,0.00913585f,0.02384282f,0.7035038f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.341444f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 21.83182f);
Get(0xFA26).SetLocalPose(1.410844f,1.272513f,0.7791879f,-0.6244075f,0.3459091f,-0.3141893f,0.6258972f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449618f,1.365095f,0.7844484f,-0.7102216f,0.009072641f,0.02386557f,0.7035151f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.396209f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 21.84962f);
Get(0xFA26).SetLocalPose(1.41065f,1.273314f,0.7792576f,-0.6238571f,0.3464766f,-0.3134586f,0.6264983f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449703f,1.36517f,0.7845564f,-0.710238f,0.009064481f,0.0238948f,0.7034976f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.420827f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 21.85762f);
Get(0xFA26).SetLocalPose(1.410451f,1.273568f,0.7791443f,-0.6237854f,0.3465382f,-0.3132604f,0.6266348f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449705f,1.365252f,0.7845181f,-0.7102385f,0.009069693f,0.02389165f,0.7034972f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.480965f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 21.87716f);
Get(0xFA26).SetLocalPose(1.410133f,1.273535f,0.7792083f,-0.623835f,0.3464732f,-0.3129684f,0.6267671f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449641f,1.365407f,0.7846434f,-0.7102304f,0.009086796f,0.02390218f,0.7035048f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.536561f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 21.89523f);
Get(0xFA26).SetLocalPose(1.409666f,1.273643f,0.7789689f,-0.6239212f,0.3465182f,-0.3126837f,0.6267986f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449683f,1.365406f,0.7847411f,-0.7102332f,0.009079251f,0.02389273f,0.7035024f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.591344f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 21.91304f);
Get(0xFA26).SetLocalPose(1.409468f,1.273785f,0.7787343f,-0.6236522f,0.3470423f,-0.3126259f,0.6268052f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449574f,1.365248f,0.7844319f,-0.7102101f,0.009106886f,0.02386343f,0.7035264f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.64639f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 21.93093f);
Get(0xFA26).SetLocalPose(1.408855f,1.274042f,0.7785292f,-0.6235574f,0.3472522f,-0.3121925f,0.6269991f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449502f,1.365114f,0.784432f,-0.7102133f,0.009114858f,0.02384183f,0.7035238f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.701978f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 21.949f);
Get(0xFA26).SetLocalPose(1.408272f,1.274192f,0.7786386f,-0.6240501f,0.3469523f,-0.3111538f,0.6271913f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449334f,1.365124f,0.7842556f,-0.7101952f,0.009186862f,0.02384342f,0.7035409f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.729179f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 21.95784f);
Get(0xFA26).SetLocalPose(1.408267f,1.27406f,0.7786438f,-0.6243156f,0.3467772f,-0.310737f,0.6272305f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449082f,1.364931f,0.784175f,-0.7101995f,0.009168649f,0.0238655f,0.7035362f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.78851f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 21.97712f);
Get(0xFA26).SetLocalPose(1.407612f,1.274878f,0.7783834f,-0.6250671f,0.3461359f,-0.3097816f,0.6273089f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449249f,1.364798f,0.7842294f,-0.7102063f,0.009140119f,0.02385955f,0.7035299f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.844657f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 21.99537f);
Get(0xFA26).SetLocalPose(1.407226f,1.274989f,0.7785797f,-0.6250893f,0.3460656f,-0.3099814f,0.6272269f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449188f,1.364907f,0.7842059f,-0.7101957f,0.009143521f,0.0238428f,0.7035411f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.900602f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 22.01355f);
Get(0xFA26).SetLocalPose(1.407064f,1.27478f,0.7786375f,-0.6248922f,0.346286f,-0.3104447f,0.6270725f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449164f,1.364912f,0.7842084f,-0.7102094f,0.009145285f,0.02384385f,0.7035272f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.955508f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 22.03139f);
Get(0xFA26).SetLocalPose(1.406712f,1.275113f,0.778468f,-0.6246256f,0.34673f,-0.3107705f,0.6269314f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449222f,1.365045f,0.7841572f,-0.7102051f,0.009145266f,0.02387445f,0.7035306f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 7.011491f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 22.04959f);
Get(0xFA26).SetLocalPose(1.406226f,1.275273f,0.7785355f,-0.6248072f,0.3468368f,-0.3101867f,0.6269804f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449202f,1.365045f,0.7841246f,-0.710205f,0.009135569f,0.02385798f,0.7035313f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 7.037299f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 22.05798f);
Get(0xFA26).SetLocalPose(1.406062f,1.275477f,0.7785003f,-0.6249898f,0.3468872f,-0.3097021f,0.6270101f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449311f,1.364959f,0.7841312f,-0.7101958f,0.009136409f,0.02387446f,0.70354f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 7.098781f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 22.07796f);
Get(0xFA26).SetLocalPose(1.406132f,1.275164f,0.7785993f,-0.6251984f,0.3467813f,-0.3092772f,0.6270705f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449409f,1.36496f,0.7841147f,-0.7101969f,0.009110614f,0.02388927f,0.7035388f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 7.15391f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 22.09587f);
Get(0xFA26).SetLocalPose(1.406073f,1.275203f,0.7785996f,-0.6251686f,0.3467858f,-0.3091919f,0.6271396f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449516f,1.365037f,0.7841583f,-0.7102174f,0.009101215f,0.02388588f,0.7035183f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 7.2105f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 22.11427f);
Get(0xFA26).SetLocalPose(1.406858f,1.274774f,0.7788686f,-0.6225064f,0.3490919f,-0.3119536f,0.6271408f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449587f,1.365074f,0.7842742f,-0.7102233f,0.009100557f,0.02388144f,0.7035124f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 7.236691f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 22.12278f);
Get(0xFA26).SetLocalPose(1.407075f,1.274506f,0.7787791f,-0.6214767f,0.3501003f,-0.3133898f,0.6268839f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449642f,1.365095f,0.7843299f,-0.7102259f,0.009105423f,0.02388958f,0.7035094f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 7.302609f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 22.1442f);
Get(0xFA26).SetLocalPose(1.407591f,1.274562f,0.7788419f,-0.6159908f,0.3554378f,-0.3210351f,0.6254246f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449644f,1.365231f,0.7844884f,-0.7102669f,0.009098416f,0.02387097f,0.7034688f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 7.363972f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 22.16414f);
Get(0xFA26).SetLocalPose(1.408556f,1.274054f,0.7791927f,-0.6113561f,0.3599554f,-0.3273534f,0.6241118f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449576f,1.365127f,0.7844967f,-0.7102808f,0.009051914f,0.02387579f,0.7034553f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 7.391493f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 22.17309f);
Get(0xFA26).SetLocalPose(1.408697f,1.274219f,0.7795776f,-0.6074272f,0.3637618f,-0.3326533f,0.6229377f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449486f,1.36523f,0.7846737f,-0.7102682f,0.009081471f,0.02387946f,0.7034674f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 7.457289f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 22.19447f);
Get(0xFA26).SetLocalPose(1.409183f,1.274089f,0.7798225f,-0.5985402f,0.3715434f,-0.3444766f,0.6205168f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449524f,1.365221f,0.7847045f,-0.7102674f,0.009083156f,0.0238624f,0.7034689f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 7.521167f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 22.21523f);
Get(0xFA26).SetLocalPose(1.409722f,1.273392f,0.7801739f,-0.5899235f,0.3786725f,-0.3558652f,0.6180271f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449517f,1.365147f,0.7846304f,-0.7102535f,0.009096809f,0.02388673f,0.7034819f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 7.549958f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 22.22459f);
Get(0xFA26).SetLocalPose(1.410115f,1.27261f,0.7807931f,-0.5817285f,0.3853431f,-0.3665685f,0.6154106f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449427f,1.365145f,0.7846312f,-0.7102531f,0.009119601f,0.02386095f,0.7034829f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 7.619076f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 22.24705f);
Get(0xFA26).SetLocalPose(1.411164f,1.270398f,0.7809517f,-0.5672256f,0.3969908f,-0.3853988f,0.6100174f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44941f,1.365192f,0.784664f,-0.7102618f,0.009130768f,0.02385314f,0.7034741f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 7.674024f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 22.26491f);
Get(0xFA26).SetLocalPose(1.411333f,1.268064f,0.7809169f,-0.5561608f,0.4053319f,-0.3999491f,0.6053362f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449469f,1.365178f,0.7846604f,-0.7102553f,0.009159245f,0.02386774f,0.7034799f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 7.699237f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 22.2731f);
Get(0xFA26).SetLocalPose(1.411978f,1.26721f,0.7811657f,-0.549415f,0.4101713f,-0.408881f,0.6022617f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449379f,1.364949f,0.7845862f,-0.7102468f,0.009109431f,0.0238738f,0.7034889f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 7.762593f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 22.29369f);
Get(0xFA26).SetLocalPose(1.412837f,1.266219f,0.7818193f,-0.5352385f,0.4203467f,-0.4267175f,0.5956011f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449487f,1.364966f,0.7846014f,-0.7102318f,0.009134482f,0.02386504f,0.7035041f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 7.819985f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 22.31235f);
Get(0xFA26).SetLocalPose(1.413646f,1.262991f,0.7833276f,-0.5194224f,0.4311548f,-0.4446605f,0.5887131f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449361f,1.365043f,0.7843562f,-0.7102354f,0.009113941f,0.02388094f,0.7035001f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 7.878989f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 22.33152f);
Get(0xFA26).SetLocalPose(1.414681f,1.259434f,0.7846097f,-0.4986073f,0.4452015f,-0.4675833f,0.578405f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449413f,1.365005f,0.7843686f,-0.7102419f,0.00910514f,0.02387067f,0.7034941f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 7.905156f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 22.34003f);
Get(0xFA26).SetLocalPose(1.415332f,1.257815f,0.7854099f,-0.4901671f,0.450776f,-0.4771197f,0.5734929f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44952f,1.364953f,0.7843308f,-0.7102529f,0.009062676f,0.0238937f,0.7034826f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 7.966826f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 22.36007f);
Get(0xFA26).SetLocalPose(1.416186f,1.253879f,0.7863469f,-0.4700289f,0.4636532f,-0.499923f,0.5605136f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449483f,1.365093f,0.7842129f,-0.7102236f,0.009091783f,0.02388823f,0.7035121f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 8.022848f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 22.37828f);
Get(0xFA26).SetLocalPose(1.416719f,1.250573f,0.7873923f,-0.4549152f,0.4730471f,-0.5167309f,0.5497889f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449581f,1.365203f,0.7842565f,-0.7102212f,0.009092505f,0.02388312f,0.7035147f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 8.078374f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 22.39632f);
Get(0xFA26).SetLocalPose(1.416789f,1.247515f,0.7884044f,-0.4370994f,0.4835851f,-0.5355866f,0.5368767f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449634f,1.365317f,0.7842844f,-0.7102226f,0.009065162f,0.02386401f,0.7035142f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 8.137259f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 22.41546f);
Get(0xFA26).SetLocalPose(1.417238f,1.24513f,0.7893183f,-0.423367f,0.490738f,-0.550067f,0.5266526f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449698f,1.365388f,0.7842853f,-0.7102205f,0.009076403f,0.02387836f,0.7035158f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 8.163589f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 22.42402f);
Get(0xFA26).SetLocalPose(1.417366f,1.243092f,0.7895417f,-0.4144019f,0.4949475f,-0.5600429f,0.5192783f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449618f,1.365348f,0.784382f,-0.7102141f,0.009080651f,0.02386742f,0.7035225f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 8.226344f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 22.44441f);
Get(0xFA26).SetLocalPose(1.417729f,1.243854f,0.7896971f,-0.4063138f,0.498946f,-0.5690736f,0.5119739f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449475f,1.365295f,0.7844256f,-0.7102095f,0.009119548f,0.02385033f,0.7035273f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 8.282267f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 22.46259f);
Get(0xFA26).SetLocalPose(1.41827f,1.244223f,0.7899626f,-0.4009845f,0.5010287f,-0.5745534f,0.5080061f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449566f,1.365176f,0.7844084f,-0.7102183f,0.009133382f,0.02388086f,0.7035171f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 8.342646f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 22.48221f);
Get(0xFA26).SetLocalPose(1.418113f,1.244868f,0.7901645f,-0.3944736f,0.503326f,-0.580688f,0.5038403f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449494f,1.365077f,0.7842928f,-0.7102009f,0.009115219f,0.02387911f,0.703535f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 8.369242f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 22.49085f);
Get(0xFA26).SetLocalPose(1.418441f,1.24477f,0.7908822f,-0.3909772f,0.5046571f,-0.5843965f,0.500938f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449385f,1.365138f,0.784172f,-0.7102111f,0.009131947f,0.02388301f,0.7035243f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 8.430994f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 22.51092f);
Get(0xFA26).SetLocalPose(1.42004f,1.24394f,0.7921766f,-0.3854314f,0.5062777f,-0.5920565f,0.4945652f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449541f,1.365119f,0.784343f,-0.7102175f,0.009088984f,0.02390647f,0.7035176f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 8.487596f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 22.52932f);
Get(0xFA26).SetLocalPose(1.420823f,1.242936f,0.7923949f,-0.3830402f,0.5063124f,-0.597162f,0.4902301f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449673f,1.365072f,0.7843261f,-0.7102189f,0.009114489f,0.0239183f,0.7035154f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 8.545462f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 22.54812f);
Get(0xFA26).SetLocalPose(1.422847f,1.242783f,0.7930105f,-0.383405f,0.5056856f,-0.5976973f,0.4899394f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449625f,1.365067f,0.7843017f,-0.7102348f,0.009059233f,0.02391228f,0.7035004f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 8.591105f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 22.56296f);
Get(0xFA26).SetLocalPose(1.424186f,1.24309f,0.7927157f,-0.3840935f,0.5044654f,-0.5966004f,0.4919907f);
});
r.Add(delegate{
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 8.591105f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 22.56296f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449388f,1.365198f,0.7840132f,-0.7101744f,0.009095905f,0.02390397f,0.7035611f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 8.689957f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 22.59508f);
Get(0xFA26).SetLocalPose(1.426038f,1.242379f,0.7922842f,-0.3830679f,0.5035419f,-0.5961942f,0.4942237f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449399f,1.365138f,0.7839534f,-0.710193f,0.009109907f,0.02388141f,0.7035429f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 8.748071f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 22.61397f);
Get(0xFA26).SetLocalPose(1.427244f,1.242832f,0.7927086f,-0.3828151f,0.5035248f,-0.5970745f,0.4933735f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449361f,1.365158f,0.7840497f,-0.710181f,0.009114653f,0.02388069f,0.703555f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 8.805273f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 22.63256f);
Get(0xFA26).SetLocalPose(1.427927f,1.241668f,0.7923982f,-0.384716f,0.5027618f,-0.5971043f,0.4926364f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449342f,1.365307f,0.7840183f,-0.7101766f,0.009139857f,0.02387537f,0.7035593f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 8.830436f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 22.64074f);
Get(0xFA26).SetLocalPose(1.428441f,1.241045f,0.7926537f,-0.3858236f,0.5022674f,-0.5967448f,0.4927101f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449239f,1.365389f,0.7841234f,-0.7101887f,0.009104836f,0.02387393f,0.7035475f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 8.888587f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 22.65964f);
Get(0xFA26).SetLocalPose(1.429972f,1.241269f,0.7929774f,-0.3878281f,0.5011758f,-0.5957457f,0.4934565f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449394f,1.365169f,0.7841037f,-0.7101928f,0.009099057f,0.02389994f,0.7035426f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 8.944312f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 22.67775f);
Get(0xFA26).SetLocalPose(1.430265f,1.240741f,0.7936007f,-0.388491f,0.5006657f,-0.5949654f,0.4943935f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449373f,1.365121f,0.7840331f,-0.7102008f,0.009115543f,0.02386143f,0.7035357f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 9.000504f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 22.69601f);
Get(0xFA26).SetLocalPose(1.430642f,1.239819f,0.793399f,-0.3892446f,0.5001848f,-0.5941187f,0.4953048f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449314f,1.365227f,0.7840754f,-0.7101943f,0.009115362f,0.02387839f,0.7035416f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 9.055698f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 22.71395f);
Get(0xFA26).SetLocalPose(1.431632f,1.237104f,0.7938634f,-0.3911314f,0.4992092f,-0.5931474f,0.4959663f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449265f,1.365389f,0.7841312f,-0.7101928f,0.009086556f,0.02387179f,0.7035437f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 9.111441f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 22.73207f);
Get(0xFA26).SetLocalPose(1.432174f,1.236962f,0.7931689f,-0.3927438f,0.4986111f,-0.5925944f,0.4959548f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449292f,1.365296f,0.7841014f,-0.7101854f,0.009101701f,0.02388526f,0.7035506f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 9.135984f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 22.74004f);
Get(0xFA26).SetLocalPose(1.432253f,1.23626f,0.793145f,-0.3939571f,0.4982009f,-0.5921322f,0.4959568f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449472f,1.365193f,0.784178f,-0.7101876f,0.009104812f,0.02389822f,0.7035479f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 9.196424f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 22.75969f);
Get(0xFA26).SetLocalPose(1.432487f,1.237838f,0.7922379f,-0.395146f,0.4978896f,-0.5916476f,0.495902f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449444f,1.365222f,0.7840482f,-0.7101895f,0.009108539f,0.02389695f,0.703546f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 9.251594f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 22.77761f);
Get(0xFA26).SetLocalPose(1.43181f,1.239643f,0.7928191f,-0.3946981f,0.4979564f,-0.5911803f,0.4967481f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449437f,1.365311f,0.7840266f,-0.7101747f,0.009131725f,0.0238684f,0.7035615f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 9.306029f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 22.79531f);
Get(0xFA26).SetLocalPose(1.432142f,1.239954f,0.7927789f,-0.3929832f,0.4979704f,-0.5904078f,0.4990074f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449376f,1.365362f,0.783935f,-0.7101637f,0.009140384f,0.0238952f,0.7035717f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 9.361798f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 22.81343f);
Get(0xFA26).SetLocalPose(1.431319f,1.239313f,0.7927711f,-0.3917492f,0.497622f,-0.5884634f,0.502609f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449485f,1.365331f,0.7840716f,-0.7101684f,0.009104555f,0.02392003f,0.7035666f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 9.418097f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 22.83173f);
Get(0xFA26).SetLocalPose(1.431979f,1.238433f,0.7938176f,-0.3935085f,0.4946961f,-0.5843026f,0.5089376f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449484f,1.365188f,0.784049f,-0.7101858f,0.00908225f,0.02393059f,0.7035488f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 9.445134f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 22.84052f);
Get(0xFA26).SetLocalPose(1.43266f,1.23947f,0.7939214f,-0.3956845f,0.4922545f,-0.5809953f,0.5133848f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449449f,1.365252f,0.7840548f,-0.7101876f,0.009068525f,0.02392127f,0.7035476f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 9.505025f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 22.85998f);
Get(0xFA26).SetLocalPose(1.431656f,1.240435f,0.7930225f,-0.3985289f,0.4878923f,-0.5751883f,0.5218183f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449483f,1.36517f,0.7841255f,-0.710182f,0.009109771f,0.02389086f,0.7035537f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 22.87757f);
Get(0xFA26).SetLocalPose(1.431524f,1.2412f,0.7927076f,-0.3963618f,0.4850946f,-0.5718166f,0.5297229f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449456f,1.36521f,0.7840669f,-0.710198f,0.00910323f,0.02388957f,0.7035376f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.05408923f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 22.89515f);
Get(0xFA26).SetLocalPose(1.429581f,1.240495f,0.793202f,-0.3934308f,0.4849786f,-0.5703883f,0.5335403f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449647f,1.365088f,0.7841206f,-0.7101995f,0.009124111f,0.02388658f,0.703536f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.1096972f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 22.91322f);
Get(0xFA26).SetLocalPose(1.428549f,1.240058f,0.7926946f,-0.3936183f,0.4857771f,-0.5700458f,0.5330414f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44961f,1.365168f,0.7841317f,-0.7102028f,0.009063172f,0.02392002f,0.7035323f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.1666474f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 22.93173f);
Get(0xFA26).SetLocalPose(1.427489f,1.239494f,0.7924127f,-0.3948157f,0.4875092f,-0.5725405f,0.5278758f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449517f,1.365262f,0.7841737f,-0.7102054f,0.009079258f,0.02389898f,0.7035303f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.1926077f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 22.94016f);
Get(0xFA26).SetLocalPose(1.427008f,1.239519f,0.7934265f,-0.3949991f,0.488828f,-0.5747734f,0.5240788f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449608f,1.365027f,0.7841907f,-0.7102011f,0.009083815f,0.02391148f,0.7035341f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.2527526f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 22.95971f);
Get(0xFA26).SetLocalPose(1.424749f,1.237978f,0.7931487f,-0.3939712f,0.4934672f,-0.5790303f,0.5157526f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449436f,1.365206f,0.7841682f,-0.7102029f,0.009104174f,0.02387968f,0.703533f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.3092135f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 22.97806f);
Get(0xFA26).SetLocalPose(1.423912f,1.235718f,0.7924801f,-0.3935964f,0.497807f,-0.5834646f,0.5067931f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449391f,1.365232f,0.7841162f,-0.7101881f,0.009126904f,0.0238905f,0.7035474f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.3660246f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 22.99652f);
Get(0xFA26).SetLocalPose(1.422843f,1.234315f,0.7920336f,-0.395308f,0.5037869f,-0.5852733f,0.4973788f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449319f,1.365201f,0.784077f,-0.7101625f,0.00913974f,0.02388427f,0.7035732f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.4226391f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 23.01493f);
Get(0xFA26).SetLocalPose(1.420095f,1.23242f,0.791426f,-0.4008313f,0.5084377f,-0.5863947f,0.4867923f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449321f,1.365147f,0.7842586f,-0.7101864f,0.009114545f,0.02389088f,0.7035491f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.4779012f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 23.03288f);
Get(0xFA26).SetLocalPose(1.419275f,1.231187f,0.7911777f,-0.4083312f,0.5102969f,-0.5856595f,0.479443f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449402f,1.36518f,0.7843184f,-0.7102003f,0.009131246f,0.02385996f,0.7035361f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.5028591f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 23.041f);
Get(0xFA26).SetLocalPose(1.419733f,1.230825f,0.7911345f,-0.4116004f,0.5115142f,-0.5857708f,0.4751957f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449457f,1.364954f,0.7842558f,-0.7102159f,0.009089302f,0.02387505f,0.7035204f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.5636905f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 23.06077f);
Get(0xFA26).SetLocalPose(1.418482f,1.229734f,0.7908797f,-0.4160008f,0.5132133f,-0.5862286f,0.468926f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449413f,1.365065f,0.784297f,-0.7102193f,0.009076017f,0.02386022f,0.7035175f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.6194551f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 23.07889f);
Get(0xFA26).SetLocalPose(1.41869f,1.229101f,0.7915401f,-0.4191929f,0.5134326f,-0.5867162f,0.4652188f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449503f,1.365116f,0.7845417f,-0.7102379f,0.00907042f,0.02389124f,0.7034977f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.6746441f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 23.09683f);
Get(0xFA26).SetLocalPose(1.417604f,1.228684f,0.7918641f,-0.4211902f,0.5134971f,-0.5886773f,0.4608454f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449473f,1.365202f,0.7845834f,-0.7102324f,0.009095605f,0.02383661f,0.7035049f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.7296647f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 23.11471f);
Get(0xFA26).SetLocalPose(1.41676f,1.228665f,0.7907367f,-0.4234422f,0.5132228f,-0.5901228f,0.4572245f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44926f,1.365056f,0.7843287f,-0.7102107f,0.009116558f,0.02388893f,0.7035247f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.7840477f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 23.13238f);
Get(0xFA26).SetLocalPose(1.416217f,1.228851f,0.7913003f,-0.4271058f,0.5121605f,-0.5902161f,0.4548815f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449298f,1.365083f,0.7843189f,-0.7102162f,0.009126785f,0.02387084f,0.7035197f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.809845f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 23.14077f);
Get(0xFA26).SetLocalPose(1.415745f,1.228079f,0.7910366f,-0.4296446f,0.5110844f,-0.5902697f,0.4536297f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449239f,1.36516f,0.7843341f,-0.7102044f,0.009138388f,0.02385586f,0.703532f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.8714779f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 23.1608f);
Get(0xFA26).SetLocalPose(1.416788f,1.227119f,0.7908282f,-0.4324485f,0.5096611f,-0.5907198f,0.4519779f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449244f,1.36515f,0.7842354f,-0.7101964f,0.009136106f,0.02388402f,0.7035391f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.9276471f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 23.17905f);
Get(0xFA26).SetLocalPose(1.418121f,1.226929f,0.7922196f,-0.43258f,0.5093185f,-0.5913532f,0.4514095f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449209f,1.365092f,0.7842199f,-0.7101941f,0.00912213f,0.02387908f,0.7035418f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.9833459f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 23.19715f);
Get(0xFA26).SetLocalPose(1.418886f,1.227343f,0.7917793f,-0.4314865f,0.5092849f,-0.5919509f,0.4517107f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449201f,1.365145f,0.7841747f,-0.7102035f,0.00912577f,0.02387607f,0.7035323f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.037058f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 23.21461f);
Get(0xFA26).SetLocalPose(1.418684f,1.22733f,0.7915202f,-0.4310128f,0.5091918f,-0.5923031f,0.4518062f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449201f,1.36524f,0.7842175f,-0.7101917f,0.00911797f,0.02385912f,0.7035448f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.091828f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 23.23241f);
Get(0xFA26).SetLocalPose(1.420166f,1.227077f,0.791163f,-0.4316946f,0.5089073f,-0.5924078f,0.4513384f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449219f,1.365165f,0.784215f,-0.7101989f,0.009101869f,0.02385302f,0.7035379f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.11749f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 23.24075f);
Get(0xFA26).SetLocalPose(1.420458f,1.227128f,0.7910578f,-0.4320067f,0.50877f,-0.5925308f,0.4510328f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449251f,1.365038f,0.7842516f,-0.7101971f,0.00910941f,0.02386241f,0.7035394f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.178294f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 23.26051f);
Get(0xFA26).SetLocalPose(1.421238f,1.22673f,0.7922238f,-0.4317842f,0.5084709f,-0.5929332f,0.4510544f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449343f,1.364977f,0.7841556f,-0.7101898f,0.009142755f,0.02388672f,0.7035456f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.233609f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 23.27849f);
Get(0xFA26).SetLocalPose(1.421278f,1.226183f,0.7922245f,-0.4306418f,0.5083305f,-0.5933336f,0.4517777f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44934f,1.364924f,0.784171f,-0.7101985f,0.009121509f,0.02387629f,0.7035374f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.289555f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 23.29667f);
Get(0xFA26).SetLocalPose(1.421521f,1.22611f,0.7923153f,-0.429583f,0.5084592f,-0.5934952f,0.4524281f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449306f,1.364947f,0.7843281f,-0.7102082f,0.009156829f,0.02388534f,0.7035269f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.345752f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 23.31494f);
Get(0xFA26).SetLocalPose(1.421467f,1.225508f,0.7922615f,-0.4294864f,0.5083858f,-0.5933994f,0.4527277f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449285f,1.365016f,0.7842404f,-0.7101962f,0.009184374f,0.02390173f,0.7035381f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.400988f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 23.33289f);
Get(0xFA26).SetLocalPose(1.421867f,1.225625f,0.7920942f,-0.4305514f,0.5080222f,-0.5931718f,0.4524225f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449324f,1.365023f,0.7842535f,-0.7101992f,0.009151403f,0.02386981f,0.7035365f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.425964f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 23.34101f);
Get(0xFA26).SetLocalPose(1.421395f,1.226295f,0.792111f,-0.4307868f,0.5080296f,-0.593109f,0.4522727f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449244f,1.364974f,0.7842932f,-0.7102162f,0.009149577f,0.02387565f,0.7035192f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.485781f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 23.36045f);
Get(0xFA26).SetLocalPose(1.422174f,1.226658f,0.7921107f,-0.4305776f,0.508499f,-0.593185f,0.4518443f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449237f,1.365091f,0.7842265f,-0.7102359f,0.009126631f,0.02386009f,0.7035002f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.540186f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 23.37813f);
Get(0xFA26).SetLocalPose(1.422499f,1.227606f,0.7920868f,-0.4302014f,0.5088558f,-0.5934068f,0.4515097f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449244f,1.364899f,0.7843011f,-0.7102397f,0.009108592f,0.02387025f,0.7034962f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.595164f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 23.396f);
Get(0xFA26).SetLocalPose(1.423377f,1.226952f,0.7921058f,-0.430187f,0.5087989f,-0.5933025f,0.4517246f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449277f,1.364695f,0.7843586f,-0.7102267f,0.009085231f,0.02387373f,0.7035095f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.649605f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 23.41369f);
Get(0xFA26).SetLocalPose(1.424301f,1.22752f,0.791708f,-0.4301273f,0.5088464f,-0.5931044f,0.4519878f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449559f,1.364891f,0.7843144f,-0.7102298f,0.009097159f,0.02388324f,0.7035059f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.705811f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 23.43196f);
Get(0xFA26).SetLocalPose(1.423826f,1.227158f,0.7907895f,-0.4303039f,0.509144f,-0.5928665f,0.4517967f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449615f,1.365128f,0.7844792f,-0.7102345f,0.009094771f,0.02390652f,0.7035003f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.733381f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 23.44092f);
Get(0xFA26).SetLocalPose(1.423625f,1.227741f,0.7908043f,-0.4302732f,0.5093321f,-0.5928891f,0.4515842f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449639f,1.365315f,0.7844836f,-0.7102349f,0.009088568f,0.02389457f,0.7035004f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.793135f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 23.46034f);
Get(0xFA26).SetLocalPose(1.423735f,1.228153f,0.7905567f,-0.4303039f,0.5095999f,-0.5930508f,0.4510402f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449776f,1.365299f,0.7846107f,-0.7102444f,0.009072769f,0.02386788f,0.703492f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.849268f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 23.47858f);
Get(0xFA26).SetLocalPose(1.423411f,1.22646f,0.7902245f,-0.4304985f,0.5096315f,-0.5930982f,0.4507564f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449778f,1.365272f,0.784492f,-0.7102363f,0.009048738f,0.02386638f,0.7035005f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.903086f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 23.49607f);
Get(0xFA26).SetLocalPose(1.422485f,1.225937f,0.7897069f,-0.4304115f,0.5095876f,-0.5930979f,0.4508893f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449763f,1.365262f,0.7845302f,-0.7102219f,0.009075596f,0.02387499f,0.7035144f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.957764f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 23.51384f);
Get(0xFA26).SetLocalPose(1.421694f,1.225441f,0.7900791f,-0.4306248f,0.509464f,-0.5929779f,0.4509834f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449778f,1.365258f,0.7845252f,-0.7102319f,0.009049105f,0.023895f,0.703504f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.012191f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 23.53153f);
Get(0xFA26).SetLocalPose(1.421941f,1.224856f,0.7903953f,-0.4314163f,0.509186f,-0.5927727f,0.4508106f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449879f,1.365298f,0.7845584f,-0.7102371f,0.009032099f,0.02388863f,0.7034992f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.067235f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 23.54942f);
Get(0xFA26).SetLocalPose(1.420998f,1.225624f,0.7912086f,-0.4322633f,0.5092259f,-0.5924531f,0.450374f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449882f,1.365329f,0.7844947f,-0.7102352f,0.009043907f,0.0238779f,0.7035013f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.094917f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 23.55842f);
Get(0xFA26).SetLocalPose(1.420958f,1.225785f,0.7908977f,-0.4324057f,0.5095014f,-0.5923989f,0.4499968f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449616f,1.365361f,0.7843621f,-0.710232f,0.009047265f,0.02387543f,0.7035047f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.155116f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 23.57798f);
Get(0xFA26).SetLocalPose(1.42072f,1.226574f,0.7915462f,-0.4327908f,0.5098449f,-0.5923704f,0.4492746f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449706f,1.365333f,0.7844f,-0.7102189f,0.009063043f,0.0238995f,0.7035168f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.210848f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 23.59609f);
Get(0xFA26).SetLocalPose(1.420727f,1.225905f,0.7918419f,-0.4332744f,0.5098106f,-0.5922136f,0.4490541f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449652f,1.365201f,0.7843441f,-0.710229f,0.009062293f,0.02386077f,0.7035079f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.266204f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 23.61409f);
Get(0xFA26).SetLocalPose(1.420516f,1.225759f,0.7922345f,-0.4333363f,0.509699f,-0.5921296f,0.4492317f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449592f,1.365102f,0.7842622f,-0.7102006f,0.009082277f,0.02390659f,0.7035348f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.322265f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 23.63231f);
Get(0xFA26).SetLocalPose(1.420938f,1.225631f,0.792335f,-0.4335638f,0.5097018f,-0.5918598f,0.4493646f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449639f,1.365085f,0.7842621f,-0.7102145f,0.009087864f,0.02387724f,0.7035217f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.348076f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 23.64069f);
Get(0xFA26).SetLocalPose(1.421462f,1.225155f,0.7922822f,-0.4341296f,0.5095719f,-0.5914741f,0.4494735f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449526f,1.36499f,0.7843352f,-0.7101972f,0.009088316f,0.02387677f,0.7035392f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.408441f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 23.66031f);
Get(0xFA26).SetLocalPose(1.421013f,1.225077f,0.7923055f,-0.4348696f,0.5094057f,-0.5910551f,0.4494978f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449588f,1.365022f,0.784371f,-0.7102003f,0.009070062f,0.02389009f,0.7035358f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.466029f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 23.67903f);
Get(0xFA26).SetLocalPose(1.421233f,1.224541f,0.7922507f,-0.4355797f,0.5093061f,-0.5906789f,0.4494174f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449595f,1.365064f,0.7844115f,-0.7101921f,0.009070598f,0.02391678f,0.7035431f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.521343f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 23.69701f);
Get(0xFA26).SetLocalPose(1.420528f,1.224461f,0.7925908f,-0.4357779f,0.5096908f,-0.5904409f,0.4491019f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.4494f,1.36503f,0.7842137f,-0.710188f,0.009104372f,0.02387233f,0.7035484f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.575584f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 23.71463f);
Get(0xFA26).SetLocalPose(1.420635f,1.226026f,0.7924919f,-0.4358647f,0.5099126f,-0.5903916f,0.4488305f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44947f,1.36506f,0.784126f,-0.7101935f,0.009119594f,0.02389733f,0.7035419f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.632248f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 23.73305f);
Get(0xFA26).SetLocalPose(1.420773f,1.226571f,0.7926943f,-0.436211f,0.5097362f,-0.5903175f,0.4487921f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449519f,1.36528f,0.7842318f,-0.7102097f,0.009117742f,0.02390977f,0.7035251f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.658762f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 23.74167f);
Get(0xFA26).SetLocalPose(1.421164f,1.226655f,0.7926056f,-0.4363075f,0.5096654f,-0.590269f,0.4488425f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449558f,1.365192f,0.7842058f,-0.7102171f,0.009107705f,0.02389645f,0.7035182f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.720271f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 23.76166f);
Get(0xFA26).SetLocalPose(1.421169f,1.226874f,0.7925956f,-0.4365506f,0.5095636f,-0.590012f,0.4490595f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449513f,1.3651f,0.7841382f,-0.7102113f,0.00909736f,0.02389186f,0.7035243f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.774506f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 23.77928f);
Get(0xFA26).SetLocalPose(1.42097f,1.226714f,0.7923179f,-0.4367621f,0.5096234f,-0.5895661f,0.4493715f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449534f,1.365114f,0.7840645f,-0.7101941f,0.009092467f,0.0239007f,0.7035414f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.830459f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 23.79747f);
Get(0xFA26).SetLocalPose(1.420666f,1.227084f,0.7917521f,-0.4367293f,0.5099528f,-0.5891566f,0.4495667f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449558f,1.36512f,0.78416f,-0.7102151f,0.009096215f,0.02392863f,0.7035192f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.887172f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 23.8159f);
Get(0xFA26).SetLocalPose(1.420776f,1.227101f,0.7914867f,-0.4367524f,0.5102172f,-0.5889319f,0.4495385f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449492f,1.36521f,0.7840996f,-0.7101988f,0.009093706f,0.02388471f,0.7035372f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.912192f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 23.82403f);
Get(0xFA26).SetLocalPose(1.421021f,1.226785f,0.7910378f,-0.4370032f,0.5101742f,-0.5887531f,0.449578f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449446f,1.36526f,0.7840797f,-0.7102f,0.0090765f,0.02388389f,0.7035363f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.970679f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 23.84304f);
Get(0xFA26).SetLocalPose(1.420352f,1.227001f,0.7905071f,-0.4373762f,0.5102872f,-0.5884488f,0.4494855f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44928f,1.365318f,0.7841479f,-0.7101798f,0.00910708f,0.02390856f,0.7035554f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.025979f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 23.86101f);
Get(0xFA26).SetLocalPose(1.420242f,1.22762f,0.7904536f,-0.4373691f,0.510578f,-0.588316f,0.4493357f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449394f,1.365248f,0.7841858f,-0.7101893f,0.009114767f,0.02391732f,0.7035453f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.080906f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 23.87886f);
Get(0xFA26).SetLocalPose(1.419573f,1.226501f,0.790331f,-0.437193f,0.5106863f,-0.5883322f,0.4493629f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449401f,1.365197f,0.784133f,-0.7102055f,0.009080322f,0.02389259f,0.7035303f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.135971f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 23.89676f);
Get(0xFA26).SetLocalPose(1.419758f,1.227228f,0.7902218f,-0.4371983f,0.5105183f,-0.588285f,0.4496105f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449391f,1.365255f,0.7839783f,-0.7101671f,0.009107643f,0.02392903f,0.7035675f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.193019f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 23.9153f);
Get(0xFA26).SetLocalPose(1.419836f,1.227334f,0.7901611f,-0.4374381f,0.5104497f,-0.5880218f,0.4497992f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449415f,1.365143f,0.7840776f,-0.7101765f,0.009095442f,0.02392041f,0.7035585f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.217767f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 23.92334f);
Get(0xFA26).SetLocalPose(1.420042f,1.227186f,0.790783f,-0.4376966f,0.5104352f,-0.5878552f,0.4497821f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449618f,1.365153f,0.784151f,-0.7101947f,0.009096501f,0.02392286f,0.7035399f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.278881f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 23.94321f);
Get(0xFA26).SetLocalPose(1.419897f,1.226167f,0.7912551f,-0.4380973f,0.5103326f,-0.5874894f,0.4499862f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44965f,1.365187f,0.7841767f,-0.7102038f,0.009109303f,0.02392396f,0.7035307f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.33248f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 23.96063f);
Get(0xFA26).SetLocalPose(1.419732f,1.227223f,0.7915461f,-0.4379635f,0.51045f,-0.5875608f,0.4498903f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449554f,1.365128f,0.7840208f,-0.7101935f,0.009110493f,0.02391407f,0.7035413f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.390698f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 23.97955f);
Get(0xFA26).SetLocalPose(1.4196f,1.227458f,0.7917941f,-0.4379918f,0.5104045f,-0.5876923f,0.4497425f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449493f,1.365213f,0.7841532f,-0.7101913f,0.009131239f,0.02389823f,0.7035438f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.44651f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 23.99769f);
Get(0xFA26).SetLocalPose(1.419091f,1.227344f,0.7919145f,-0.4379408f,0.5103551f,-0.5877565f,0.4497643f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449297f,1.365339f,0.7841535f,-0.7101861f,0.009177599f,0.02385753f,0.7035499f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.502315f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 24.01583f);
Get(0xFA26).SetLocalPose(1.419078f,1.227999f,0.7920267f,-0.4379547f,0.5103112f,-0.587751f,0.4498077f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449124f,1.365204f,0.7840731f,-0.7101926f,0.009191658f,0.02387085f,0.7035426f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.527737f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 24.02409f);
Get(0xFA26).SetLocalPose(1.418867f,1.228591f,0.7923343f,-0.4380306f,0.5102919f,-0.5877401f,0.44977f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449085f,1.365059f,0.7841573f,-0.7101921f,0.009168148f,0.02390288f,0.7035423f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.58875f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 24.04392f);
Get(0xFA26).SetLocalPose(1.41848f,1.228868f,0.7925885f,-0.4381999f,0.5102873f,-0.58767f,0.4497019f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449064f,1.365109f,0.7841249f,-0.7101954f,0.009144811f,0.02387979f,0.7035401f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.644526f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 24.06204f);
Get(0xFA26).SetLocalPose(1.417945f,1.228198f,0.7932761f,-0.4383585f,0.5102909f,-0.5875923f,0.4496448f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449089f,1.365209f,0.7841414f,-0.7101986f,0.009146406f,0.02390369f,0.703536f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.698706f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 24.07965f);
Get(0xFA26).SetLocalPose(1.418347f,1.228765f,0.7937815f,-0.4384279f,0.5102181f,-0.5875698f,0.4496891f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44909f,1.365049f,0.7841675f,-0.7102049f,0.009102086f,0.02388026f,0.703531f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.753629f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 24.0975f);
Get(0xFA26).SetLocalPose(1.418204f,1.228118f,0.7934056f,-0.4383406f,0.510219f,-0.5874746f,0.4498975f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449183f,1.36504f,0.7841549f,-0.710217f,0.00911499f,0.02385472f,0.7035196f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.809528f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 24.11567f);
Get(0xFA26).SetLocalPose(1.418247f,1.228336f,0.7934624f,-0.438302f,0.5103427f,-0.5872335f,0.4501094f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449183f,1.365037f,0.7841308f,-0.7102066f,0.009136066f,0.0238709f,0.7035292f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.835445f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 24.12409f);
Get(0xFA26).SetLocalPose(1.418112f,1.228155f,0.7938544f,-0.438354f,0.5104259f,-0.5871105f,0.450125f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449304f,1.364967f,0.7842315f,-0.7102105f,0.009139192f,0.02385341f,0.7035258f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.895696f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 24.14367f);
Get(0xFA26).SetLocalPose(1.417794f,1.228866f,0.7931091f,-0.4385569f,0.5104231f,-0.5869408f,0.4501518f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449239f,1.364995f,0.7842491f,-0.7102138f,0.009153909f,0.02383997f,0.7035228f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.950347f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 24.16144f);
Get(0xFA26).SetLocalPose(1.417177f,1.228828f,0.7932034f,-0.4388851f,0.5103493f,-0.5869346f,0.4499236f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449139f,1.364827f,0.7841998f,-0.7102298f,0.009166346f,0.02382985f,0.7035068f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.005264f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 24.17929f);
Get(0xFA26).SetLocalPose(1.416698f,1.228204f,0.792209f,-0.4387849f,0.5104415f,-0.5869663f,0.4498754f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449146f,1.364921f,0.7843319f,-0.7102404f,0.009154568f,0.02381979f,0.7034965f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.05969f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 24.19697f);
Get(0xFA26).SetLocalPose(1.416216f,1.227842f,0.7916961f,-0.4386568f,0.5104513f,-0.5869344f,0.4500308f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449233f,1.364962f,0.7843493f,-0.710209f,0.009134841f,0.02385634f,0.7035274f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.113774f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 24.21455f);
Get(0xFA26).SetLocalPose(1.415801f,1.227724f,0.7917944f,-0.4389392f,0.5103011f,-0.5864674f,0.4505344f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449268f,1.364949f,0.7843884f,-0.7101984f,0.009129276f,0.02387079f,0.7035376f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.170822f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 24.23309f);
Get(0xFA26).SetLocalPose(1.4148f,1.22729f,0.7921834f,-0.4391351f,0.5102954f,-0.5860482f,0.4508953f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449292f,1.364995f,0.7843858f,-0.7102131f,0.009135579f,0.02388248f,0.7035223f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.198128f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 24.24197f);
Get(0xFA26).SetLocalPose(1.41515f,1.227267f,0.7930697f,-0.4393307f,0.510281f,-0.585888f,0.4509292f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449482f,1.364997f,0.7844494f,-0.7102195f,0.009117477f,0.02386699f,0.7035166f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.256963f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 24.26109f);
Get(0xFA26).SetLocalPose(1.415391f,1.226414f,0.7937694f,-0.4396506f,0.5103372f,-0.5857608f,0.4507191f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.4496f,1.365086f,0.7844638f,-0.710214f,0.009076716f,0.02389578f,0.7035217f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.31149f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 24.27881f);
Get(0xFA26).SetLocalPose(1.415404f,1.225609f,0.7931083f,-0.4397528f,0.5105413f,-0.5855632f,0.4506448f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449599f,1.364974f,0.7844297f,-0.7102357f,0.00907999f,0.02388503f,0.7035002f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.365178f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 24.29626f);
Get(0xFA26).SetLocalPose(1.415587f,1.22613f,0.7935377f,-0.4398009f,0.5107065f,-0.5853707f,0.4506609f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449605f,1.365046f,0.7843789f,-0.7102167f,0.009089837f,0.02389625f,0.7035188f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.419191f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 24.31381f);
Get(0xFA26).SetLocalPose(1.414588f,1.225698f,0.7936496f,-0.4402623f,0.5104297f,-0.5849016f,0.4511327f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449579f,1.36525f,0.7845489f,-0.7102424f,0.009100777f,0.02385761f,0.703494f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.473416f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 24.33143f);
Get(0xFA26).SetLocalPose(1.41484f,1.226148f,0.7941834f,-0.4406843f,0.5102041f,-0.5846459f,0.4513073f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449502f,1.365343f,0.7845031f,-0.7102379f,0.009118165f,0.0238815f,0.7034975f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.528557f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 24.34936f);
Get(0xFA26).SetLocalPose(1.415135f,1.22675f,0.7943756f,-0.4409077f,0.5103255f,-0.5843104f,0.4513865f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449515f,1.365106f,0.7844727f,-0.7102391f,0.009113739f,0.02388727f,0.7034962f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.555853f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 24.35823f);
Get(0xFA26).SetLocalPose(1.415528f,1.226928f,0.7942852f,-0.4410692f,0.5104603f,-0.5839629f,0.451526f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449488f,1.365105f,0.7845477f,-0.7102261f,0.00912781f,0.02387767f,0.7035094f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.616231f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 24.37785f);
Get(0xFA26).SetLocalPose(1.416072f,1.227315f,0.7943947f,-0.4416671f,0.5104525f,-0.5829931f,0.452203f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449466f,1.365179f,0.7844993f,-0.7102121f,0.009133672f,0.02389279f,0.703523f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.670437f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 24.39547f);
Get(0xFA26).SetLocalPose(1.415797f,1.228876f,0.7948272f,-0.4423793f,0.5104083f,-0.5819346f,0.4529195f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449454f,1.365156f,0.7845178f,-0.7102343f,0.009135113f,0.02386661f,0.7035013f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.724405f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 24.41301f);
Get(0xFA26).SetLocalPose(1.41513f,1.228454f,0.7942989f,-0.4425387f,0.5106028f,-0.5814074f,0.4532215f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449402f,1.364998f,0.784406f,-0.7102302f,0.009096043f,0.0238568f,0.7035064f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.777739f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 24.43034f);
Get(0xFA26).SetLocalPose(1.414806f,1.229257f,0.7939031f,-0.442676f,0.5109723f,-0.5808136f,0.4534324f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449405f,1.364959f,0.7844334f,-0.7102253f,0.009117404f,0.02385933f,0.7035109f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.832664f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 24.44819f);
Get(0xFA26).SetLocalPose(1.41405f,1.229306f,0.7926495f,-0.4427261f,0.5112884f,-0.579878f,0.4542238f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449316f,1.364891f,0.7843181f,-0.7102132f,0.009118578f,0.02386742f,0.7035229f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.886889f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 24.46581f);
Get(0xFA26).SetLocalPose(1.414435f,1.229421f,0.7920334f,-0.4436383f,0.5108461f,-0.5785633f,0.4555062f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449442f,1.364913f,0.7843477f,-0.710234f,0.00911007f,0.02386404f,0.7035021f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.911328f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 24.47376f);
Get(0xFA26).SetLocalPose(1.414116f,1.230046f,0.7916389f,-0.445023f,0.5101674f,-0.5770696f,0.4568091f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449372f,1.364941f,0.7843296f,-0.7102337f,0.00911916f,0.02385358f,0.7035027f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.971032f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 24.49316f);
Get(0xFA26).SetLocalPose(1.41319f,1.231096f,0.7915494f,-0.4484434f,0.5084366f,-0.5734621f,0.459926f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449443f,1.364857f,0.7842677f,-0.7102264f,0.009097144f,0.02389845f,0.7035088f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.026732f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 24.51126f);
Get(0xFA26).SetLocalPose(1.413019f,1.232787f,0.7916772f,-0.4532974f,0.5056866f,-0.568772f,0.4640056f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449409f,1.364916f,0.7842617f,-0.7102248f,0.009109682f,0.02389002f,0.7035106f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.08212f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 24.52926f);
Get(0xFA26).SetLocalPose(1.41305f,1.233089f,0.7924311f,-0.4586713f,0.5022889f,-0.5638684f,0.4683791f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449342f,1.365132f,0.7844901f,-0.710243f,0.009123027f,0.02387492f,0.7034925f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.137577f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 24.54729f);
Get(0xFA26).SetLocalPose(1.412563f,1.233296f,0.792708f,-0.4690012f,0.4953753f,-0.5548871f,0.476174f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449456f,1.365124f,0.7844713f,-0.7102404f,0.009078204f,0.02387626f,0.7034957f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.193466f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 24.56545f);
Get(0xFA26).SetLocalPose(1.412749f,1.235625f,0.7921511f,-0.4861284f,0.4838256f,-0.541131f,0.4865896f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449472f,1.365094f,0.7843609f,-0.7102302f,0.00909752f,0.02388106f,0.7035055f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.220689f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 24.5743f);
Get(0xFA26).SetLocalPose(1.413134f,1.238666f,0.7913996f,-0.5043448f,0.4708259f,-0.5256834f,0.4976106f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449324f,1.365104f,0.7843451f,-0.7102169f,0.009118945f,0.0238882f,0.7035184f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.281249f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 24.59398f);
Get(0xFA26).SetLocalPose(1.413975f,1.245173f,0.7900304f,-0.5451474f,0.4382918f,-0.4866066f,0.5233819f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449308f,1.36512f,0.7842041f,-0.7102157f,0.009165831f,0.02386398f,0.7035198f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.337471f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 24.61225f);
Get(0xFA26).SetLocalPose(1.413737f,1.252421f,0.7884183f,-0.5814404f,0.4043643f,-0.4453099f,0.5478281f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44931f,1.365226f,0.7841762f,-0.7102126f,0.009146808f,0.02387042f,0.703523f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.393974f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 24.63062f);
Get(0xFA26).SetLocalPose(1.412568f,1.26241f,0.7858947f,-0.6224961f,0.3587584f,-0.390189f,0.5757983f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449284f,1.365182f,0.7841867f,-0.7102091f,0.009167773f,0.02387387f,0.7035262f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.449383f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 24.64862f);
Get(0xFA26).SetLocalPose(1.410738f,1.267322f,0.7839395f,-0.6434118f,0.3316712f,-0.3580792f,0.5897413f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449079f,1.365226f,0.7841238f,-0.710196f,0.009174777f,0.02384556f,0.7035404f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.474973f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 24.65694f);
Get(0xFA26).SetLocalPose(1.410938f,1.270122f,0.7834713f,-0.6553317f,0.3149313f,-0.3386295f,0.5972344f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449201f,1.36506f,0.7840677f,-0.7101697f,0.009180289f,0.02386378f,0.7035661f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.536873f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 24.67706f);
Get(0xFA26).SetLocalPose(1.409644f,1.275136f,0.7825054f,-0.67756f,0.2806176f,-0.2998139f,0.6101458f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449135f,1.364991f,0.7841223f,-0.7102041f,0.009170354f,0.02385777f,0.7035318f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.59363f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 24.6955f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44926f,1.365023f,0.7841644f,-0.7102057f,0.009178827f,0.02384514f,0.7035306f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.649266f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 24.71358f);
Get(0xFA26).SetLocalPose(1.405306f,1.28339f,0.7811711f,-0.7143973f,0.2151636f,-0.2298255f,0.6249171f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449301f,1.364923f,0.7841836f,-0.7102023f,0.009138899f,0.02388326f,0.7035331f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.705379f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 24.73182f);
Get(0xFA26).SetLocalPose(1.401987f,1.288827f,0.7803884f,-0.7366851f,0.1674711f,-0.1819379f,0.6294023f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449309f,1.364925f,0.7841053f,-0.7102119f,0.009139523f,0.02389321f,0.703523f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.760421f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 24.74971f);
Get(0xFA26).SetLocalPose(1.396931f,1.294012f,0.7791763f,-0.7562045f,0.1162349f,-0.1315933f,0.6303391f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449386f,1.364895f,0.784175f,-0.7102393f,0.009123757f,0.02388251f,0.7034959f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.786969f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 24.75834f);
Get(0xFA26).SetLocalPose(1.391813f,1.299197f,0.7782673f,-0.7710854f,0.06454847f,-0.08066297f,0.6282948f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449332f,1.364895f,0.7843754f,-0.7102323f,0.009165206f,0.02385448f,0.7035035f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.846066f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 24.77755f);
Get(0xFA26).SetLocalPose(1.382448f,1.305909f,0.7766495f,-0.7838688f,-0.01338891f,-0.002486665f,0.6207772f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449387f,1.364822f,0.7844678f,-0.7102581f,0.009162526f,0.02386848f,0.703477f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.902626f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 24.79593f);
Get(0xFA26).SetLocalPose(1.369591f,1.3109f,0.7750709f,-0.7827423f,-0.09660709f,0.08493643f,0.6089067f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449508f,1.364998f,0.7846776f,-0.7102567f,0.009144562f,0.02389123f,0.7034779f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.958192f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 24.81399f);
Get(0xFA26).SetLocalPose(1.355512f,1.311734f,0.7740685f,-0.7726457f,-0.1823614f,0.1664759f,0.5848493f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449566f,1.365103f,0.7846184f,-0.7102425f,0.009117851f,0.02389029f,0.7034926f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.013359f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 24.83192f);
Get(0xFA26).SetLocalPose(1.346831f,1.309763f,0.7725632f,-0.7593894f,-0.2493511f,0.2235745f,0.5578228f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44968f,1.365038f,0.7846761f,-0.7102674f,0.009076895f,0.02387352f,0.7034686f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.068646f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 24.84989f);
Get(0xFA26).SetLocalPose(1.341566f,1.307715f,0.7728948f,-0.7474173f,-0.2828316f,0.2567383f,0.5435615f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449595f,1.364985f,0.7845144f,-0.7102626f,0.009082528f,0.02386368f,0.7034737f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.094954f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 24.85844f);
Get(0xFA26).SetLocalPose(1.340479f,1.306452f,0.7733354f,-0.744035f,-0.2885887f,0.2648525f,0.5412779f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449442f,1.365111f,0.7844245f,-0.7102288f,0.009075289f,0.02387114f,0.7035076f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.153769f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 24.87755f);
Get(0xFA26).SetLocalPose(1.340637f,1.305113f,0.7738518f,-0.7415593f,-0.29254f,0.2712486f,0.5393832f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449552f,1.36504f,0.7843835f,-0.7102249f,0.009060472f,0.02386902f,0.7035118f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.209046f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 24.89552f);
Get(0xFA26).SetLocalPose(1.340312f,1.304046f,0.7740973f,-0.7417801f,-0.2927285f,0.271796f,0.5387014f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449629f,1.365091f,0.7844534f,-0.710223f,0.009076941f,0.02387238f,0.7035134f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.264568f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 24.91356f);
Get(0xFA26).SetLocalPose(1.341073f,1.303101f,0.7739528f,-0.7434347f,-0.2927028f,0.2701513f,0.5372599f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449512f,1.365187f,0.7843713f,-0.7102107f,0.00906871f,0.02385433f,0.7035266f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.29297f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 24.92279f);
Get(0xFA26).SetLocalPose(1.341343f,1.301986f,0.7739534f,-0.7447576f,-0.2931519f,0.2695342f,0.5354899f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449375f,1.365324f,0.7844017f,-0.7102203f,0.009095835f,0.02386712f,0.7035161f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.357171f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 24.94366f);
Get(0xFA26).SetLocalPose(1.341321f,1.300864f,0.7741513f,-0.7459944f,-0.2932985f,0.2692828f,0.5338119f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449384f,1.365198f,0.7844757f,-0.7102053f,0.009101863f,0.02387255f,0.7035309f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.414197f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 24.96219f);
Get(0xFA26).SetLocalPose(1.341401f,1.299342f,0.7744075f,-0.7476578f,-0.2910907f,0.2680442f,0.5333163f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449421f,1.36516f,0.7843486f,-0.7101959f,0.009103107f,0.02386654f,0.7035407f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.470155f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 24.98038f);
Get(0xFA26).SetLocalPose(1.341324f,1.297903f,0.7745961f,-0.7496108f,-0.2868553f,0.264964f,0.5344079f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449477f,1.365065f,0.7843386f,-0.7101905f,0.009086044f,0.02386601f,0.7035463f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.525962f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 24.99851f);
Get(0xFA26).SetLocalPose(1.341377f,1.294911f,0.7751213f,-0.754896f,-0.275054f,0.255035f,0.5379911f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449427f,1.365095f,0.7842038f,-0.7101927f,0.009099412f,0.02387341f,0.7035437f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.550107f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 25.00636f);
Get(0xFA26).SetLocalPose(1.342061f,1.292339f,0.7758988f,-0.7597209f,-0.2641591f,0.2449338f,0.5413426f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449349f,1.365224f,0.7841116f,-0.7101986f,0.009113368f,0.02383449f,0.7035388f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.597826f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 25.02187f);
Get(0xFA26).SetLocalPose(1.342542f,1.289739f,0.7762262f,-0.7644541f,-0.254125f,0.2350794f,0.5438457f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449364f,1.365169f,0.7840934f,-0.7101964f,0.009118916f,0.02386f,0.7035401f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.676444f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 25.04742f);
Get(0xFA26).SetLocalPose(1.343463f,1.282248f,0.7779331f,-0.7743698f,-0.2323654f,0.2137544f,0.5483309f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449476f,1.364967f,0.7840231f,-0.7101778f,0.009123133f,0.0238793f,0.7035581f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.73237f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 25.0656f);
Get(0xFA26).SetLocalPose(1.345215f,1.273604f,0.7796263f,-0.7839456f,-0.2079297f,0.1898975f,0.5532933f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449427f,1.364893f,0.7840483f,-0.710207f,0.009115601f,0.02384965f,0.7035298f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.758808f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 25.07419f);
Get(0xFA26).SetLocalPose(1.345527f,1.269134f,0.7805889f,-0.7879331f,-0.1969246f,0.1794096f,0.5551525f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449443f,1.364954f,0.784058f,-0.7102008f,0.009111513f,0.02386932f,0.7035354f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.817861f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 25.09338f);
Get(0xFA26).SetLocalPose(1.346823f,1.257592f,0.7833465f,-0.7971451f,-0.1678902f,0.1538399f,0.5592012f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449266f,1.365175f,0.7842082f,-0.7102022f,0.009124009f,0.02385081f,0.7035346f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.873605f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 25.1115f);
Get(0xFA26).SetLocalPose(1.347798f,1.241704f,0.7875767f,-0.8071376f,-0.1382938f,0.1290561f,0.5592391f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449334f,1.365136f,0.7840954f,-0.7101951f,0.009097542f,0.02388054f,0.703541f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.92737f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 25.12897f);
Get(0xFA26).SetLocalPose(1.347301f,1.226649f,0.7916011f,-0.8158069f,-0.1172116f,0.112265f,0.5550829f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449326f,1.365168f,0.7841499f,-0.7101877f,0.0090983f,0.02386347f,0.7035491f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.983171f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 25.14711f);
Get(0xFA26).SetLocalPose(1.345864f,1.210544f,0.7965137f,-0.824403f,-0.09330096f,0.09546344f,0.5500375f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449398f,1.365237f,0.784139f,-0.7101874f,0.009131419f,0.02387273f,0.7035487f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 7.039448f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 25.1654f);
Get(0xFA26).SetLocalPose(1.344835f,1.191406f,0.8028855f,-0.8326576f,-0.06545099f,0.07750021f,0.5444183f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449309f,1.365239f,0.7839849f,-0.7101903f,0.009141036f,0.0238692f,0.7035457f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 7.066151f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 25.17407f);
Get(0xFA26).SetLocalPose(1.344344f,1.172404f,0.8093396f,-0.8399151f,-0.03934067f,0.05998851f,0.5379556f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449196f,1.365321f,0.7839313f,-0.710183f,0.009153779f,0.02385304f,0.7035534f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 7.126689f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 25.19375f);
Get(0xFA26).SetLocalPose(1.34283f,1.146541f,0.8199931f,-0.8491121f,-0.009289312f,0.03475426f,0.5269862f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449184f,1.365088f,0.784009f,-0.7101906f,0.009173162f,0.02386714f,0.703545f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 7.182186f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 25.21178f);
Get(0xFA26).SetLocalPose(1.341955f,1.120945f,0.8311705f,-0.8571162f,0.01144494f,0.01272394f,0.5148388f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449328f,1.365037f,0.7840291f,-0.7101921f,0.009159493f,0.02384588f,0.7035444f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 7.236761f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 25.22952f);
Get(0xFA26).SetLocalPose(1.339888f,1.087861f,0.8474081f,-0.8687304f,0.03386576f,-0.01462371f,0.4939096f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.4495f,1.364848f,0.7841689f,-0.710196f,0.009127567f,0.02386815f,0.7035401f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 7.29379f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 25.24806f);
Get(0xFA26).SetLocalPose(1.337574f,1.055787f,0.8644592f,-0.8808458f,0.05315106f,-0.03831159f,0.4688475f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449467f,1.364963f,0.7842773f,-0.7101864f,0.009147996f,0.02386606f,0.7035496f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 7.321661f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 25.25711f);
Get(0xFA26).SetLocalPose(1.335801f,1.036386f,0.8757488f,-0.8880296f,0.06451894f,-0.0526435f,0.452183f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449469f,1.364994f,0.7842315f,-0.7102089f,0.009118124f,0.02384914f,0.7035279f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 7.384473f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 25.27753f);
Get(0xFA26).SetLocalPose(1.333017f,1.000444f,0.8983629f,-0.9016203f,0.08708022f,-0.08314839f,0.4154325f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449437f,1.365113f,0.7843139f,-0.7102186f,0.009115898f,0.02386426f,0.7035177f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 7.448946f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 25.29848f);
Get(0xFA26).SetLocalPose(1.330184f,0.9687549f,0.9208204f,-0.9134017f,0.1039437f,-0.1089215f,0.3781919f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449483f,1.365106f,0.7844024f,-0.7102135f,0.009116143f,0.02386746f,0.7035226f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 7.47915f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 25.3083f);
Get(0xFA26).SetLocalPose(1.326342f,0.9396725f,0.9436899f,-0.9238154f,0.114566f,-0.1282042f,0.3420576f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449428f,1.365156f,0.7844551f,-0.7102033f,0.009149551f,0.02385787f,0.7035329f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 7.550866f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 25.33161f);
Get(0xFA26).SetLocalPose(1.320037f,0.8979044f,0.9809784f,-0.9394016f,0.1258909f,-0.1483627f,0.2822495f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449378f,1.365018f,0.7843896f,-0.7102082f,0.009131425f,0.02386181f,0.7035279f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 7.57956f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 25.34093f);
Get(0xFA26).SetLocalPose(1.316154f,0.876352f,1.003262f,-0.94723f,0.1315936f,-0.1561476f,0.2470959f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449379f,1.364961f,0.7844349f,-0.7102169f,0.009121244f,0.02386213f,0.7035193f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 7.644687f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 25.3621f);
Get(0xFA26).SetLocalPose(1.31421f,0.8659181f,1.014972f,-0.9507996f,0.1346389f,-0.1599585f,0.2286169f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449393f,1.365066f,0.7844259f,-0.7102282f,0.009131961f,0.02384876f,0.7035082f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 7.700937f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 25.38038f);
Get(0xFA26).SetLocalPose(1.301311f,0.8148119f,1.081915f,-0.9636462f,0.1537518f,-0.1795062f,0.1245954f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449335f,1.365008f,0.784514f,-0.7102212f,0.009126273f,0.02388581f,0.7035141f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 7.757978f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 25.39892f);
Get(0xFA26).SetLocalPose(1.292841f,0.7913498f,1.12166f,-0.9673683f,0.1640105f,-0.1812976f,0.06656101f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449394f,1.364985f,0.7844245f,-0.710219f,0.009131127f,0.02390054f,0.7035158f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 7.78492f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 25.40768f);
Get(0xFA26).SetLocalPose(1.290995f,0.7867792f,1.130551f,-0.9679236f,0.1660419f,-0.1806716f,0.05396036f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.4494f,1.365042f,0.7842347f,-0.7102143f,0.00912956f,0.02389636f,0.7035207f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 7.847191f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 25.42791f);
Get(0xFA26).SetLocalPose(1.281181f,0.7643949f,1.185247f,-0.9690387f,0.1744988f,-0.1736714f,-0.01877393f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449371f,1.365165f,0.7840637f,-0.7102106f,0.009142236f,0.02389502f,0.7035244f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 7.910038f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 25.44834f);
Get(0xFA26).SetLocalPose(1.274497f,0.7509977f,1.234123f,-0.9653002f,0.1766668f,-0.1743508f,-0.08115563f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449344f,1.365168f,0.7840279f,-0.7102004f,0.009132565f,0.02390265f,0.7035344f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 7.939007f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 25.45775f);
Get(0xFA26).SetLocalPose(1.272634f,0.7466881f,1.261189f,-0.9610906f,0.174866f,-0.1813667f,-0.1132821f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449139f,1.365168f,0.7838823f,-0.7101911f,0.009136795f,0.0238986f,0.7035439f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.00158f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 25.47809f);
Get(0xFA26).SetLocalPose(1.271751f,0.7425364f,1.293722f,-0.9533314f,0.1691336f,-0.1987261f,-0.1518587f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449381f,1.365227f,0.7839243f,-0.7102082f,0.009112176f,0.02387558f,0.7035278f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.059553f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 25.49693f);
Get(0xFA26).SetLocalPose(1.272195f,0.7429647f,1.329778f,-0.9446685f,0.1531694f,-0.2121368f,-0.1978348f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449352f,1.365185f,0.7839198f,-0.710215f,0.00911874f,0.02387935f,0.7035207f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.118288f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 25.51602f);
Get(0xFA26).SetLocalPose(1.271682f,0.7448812f,1.357134f,-0.9396731f,0.1343278f,-0.2091024f,-0.2350464f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449487f,1.364989f,0.7840538f,-0.7102069f,0.009096821f,0.02389607f,0.7035285f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.145585f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 25.52489f);
Get(0xFA26).SetLocalPose(1.269426f,0.7471834f,1.37179f,-0.9407125f,0.1172508f,-0.1723298f,-0.2676093f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449489f,1.365178f,0.7842932f,-0.7101992f,0.009122279f,0.02386373f,0.7035371f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.205499f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 25.54436f);
Get(0xFA26).SetLocalPose(1.263753f,0.7489326f,1.386688f,-0.9457596f,0.1021596f,-0.09158722f,-0.2944723f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449316f,1.365195f,0.7842785f,-0.7101844f,0.009132879f,0.02384371f,0.7035527f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.262566f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 25.56291f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449132f,1.365102f,0.7841789f,-0.7101873f,0.009143849f,0.02384392f,0.7035494f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.317922f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 25.5809f);
Get(0xFA26).SetLocalPose(1.254468f,0.7513008f,1.406527f,-0.9439105f,0.07998294f,0.02043423f,-0.3197158f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449199f,1.365143f,0.7841885f,-0.7101714f,0.009185528f,0.02386926f,0.7035642f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.374772f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 25.59937f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449197f,1.365131f,0.7841376f,-0.7101786f,0.009155531f,0.02387522f,0.7035572f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.401162f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 25.60795f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449296f,1.365006f,0.7840008f,-0.7101794f,0.009135611f,0.02388981f,0.7035561f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.462901f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 25.62802f);
Get(0xFA26).SetLocalPose(1.252521f,0.7510787f,1.414525f,-0.9443796f,0.0695802f,0.04690591f,-0.3179713f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449361f,1.36492f,0.7839731f,-0.7101554f,0.009161237f,0.02389432f,0.7035797f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.518088f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 25.64595f);
Get(0xFA26).SetLocalPose(1.251538f,0.751342f,1.415618f,-0.9453029f,0.06829561f,0.04940718f,-0.3151145f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449302f,1.36502f,0.783996f,-0.7101473f,0.009150309f,0.0238916f,0.7035882f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.573802f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 25.66406f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449262f,1.365089f,0.783832f,-0.7101506f,0.009169022f,0.02390968f,0.703584f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.629165f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 25.68205f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449238f,1.365049f,0.7837799f,-0.7101534f,0.009157842f,0.02387963f,0.7035823f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.655497f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 25.69061f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449091f,1.36534f,0.7838862f,-0.710154f,0.009170848f,0.02386946f,0.7035819f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.714776f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 25.70988f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449116f,1.365266f,0.7837154f,-0.7101582f,0.009142807f,0.02386482f,0.7035782f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.771868f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 25.72843f);
Get(0xFA26).SetLocalPose(1.251658f,0.7459474f,1.416689f,-0.9536662f,0.07191978f,0.0328771f,-0.2902887f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44924f,1.365312f,0.7836515f,-0.71014f,0.009142384f,0.02386481f,0.7035966f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.826794f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 25.74628f);
Get(0xFA26).SetLocalPose(1.24796f,0.7477934f,1.405749f,-0.9656296f,0.09728043f,-0.04691296f,-0.2364217f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449342f,1.365102f,0.7837495f,-0.7101668f,0.009146783f,0.02388621f,0.7035687f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.882431f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 25.76437f);
Get(0xFA26).SetLocalPose(1.245456f,0.7483843f,1.388735f,-0.9635724f,0.1241622f,-0.1546412f,-0.179438f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449257f,1.365063f,0.7836758f,-0.7101681f,0.009133602f,0.02386273f,0.7035684f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.937732f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 25.78234f);
Get(0xFA26).SetLocalPose(1.242331f,0.7479038f,1.3698f,-0.9486606f,0.1429994f,-0.2484655f,-0.1336383f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449186f,1.365156f,0.7837999f,-0.7101715f,0.009146328f,0.02389504f,0.7035637f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.963713f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 25.79078f);
Get(0xFA26).SetLocalPose(1.241759f,0.7420186f,1.357639f,-0.938269f,0.1517017f,-0.2898898f,-0.1122584f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449417f,1.365095f,0.7840835f,-0.7101774f,0.009094334f,0.02386967f,0.7035593f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 9.023521f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 25.81022f);
Get(0xFA26).SetLocalPose(1.238065f,0.7345915f,1.330397f,-0.9323341f,0.1635306f,-0.3102387f,-0.08810761f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44943f,1.365144f,0.7841457f,-0.710186f,0.009132252f,0.02389457f,0.7035493f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 9.0816f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 25.8291f);
Get(0xFA26).SetLocalPose(1.233477f,0.7289916f,1.294813f,-0.9406831f,0.1741576f,-0.2833434f,-0.06708847f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449522f,1.365066f,0.7840578f,-0.7102267f,0.009098534f,0.02389598f,0.7035086f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 9.136278f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 25.84687f);
Get(0xFA26).SetLocalPose(1.231292f,0.7245815f,1.267478f,-0.9500492f,0.1795962f,-0.2502736f,-0.05014862f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449407f,1.365075f,0.7841604f,-0.7102183f,0.009133934f,0.02387823f,0.7035171f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 9.193295f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 25.8654f);
Get(0xFA26).SetLocalPose(1.228768f,0.72276f,1.246844f,-0.9567866f,0.1827148f,-0.2235899f,-0.03438519f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449385f,1.365137f,0.7841282f,-0.7102094f,0.009129609f,0.02386888f,0.7035266f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 9.220486f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 25.87423f);
Get(0xFA26).SetLocalPose(1.229066f,0.7233461f,1.237685f,-0.9594987f,0.1837337f,-0.2119099f,-0.02642933f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449572f,1.36514f,0.7843075f,-0.7102067f,0.00906535f,0.02389404f,0.7035292f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 9.278828f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 25.89319f);
Get(0xFA26).SetLocalPose(1.229257f,0.72688f,1.214868f,-0.9650905f,0.1857826f,-0.1845812f,-0.003867697f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449614f,1.365153f,0.7842346f,-0.7102035f,0.009065151f,0.02388498f,0.7035328f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 9.333133f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 25.91084f);
Get(0xFA26).SetLocalPose(1.232079f,0.7307979f,1.195368f,-0.9682427f,0.1869656f,-0.1651416f,0.01668056f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449565f,1.365187f,0.7841481f,-0.7101957f,0.009076886f,0.02388961f,0.7035403f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 9.389031f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 25.92901f);
Get(0xFA26).SetLocalPose(1.23626f,0.7353445f,1.172148f,-0.9705031f,0.1879845f,-0.1441534f,0.04478288f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449558f,1.365289f,0.784206f,-0.7101936f,0.009088007f,0.02389347f,0.7035422f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 9.443688f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 25.94677f);
Get(0xFA26).SetLocalPose(1.240361f,0.7415816f,1.154844f,-0.9710264f,0.1886901f,-0.1299478f,0.0679524f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449432f,1.365267f,0.7841839f,-0.7101998f,0.009121771f,0.02386823f,0.7035364f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 9.498834f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 25.96469f);
Get(0xFA26).SetLocalPose(1.245263f,0.7485756f,1.134357f,-0.9704372f,0.1893959f,-0.1163956f,0.09398366f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449425f,1.365167f,0.7841574f,-0.7101937f,0.009101012f,0.02388186f,0.7035424f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 9.524247f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 25.97295f);
Get(0xFA26).SetLocalPose(1.248341f,0.7513973f,1.124248f,-0.9696848f,0.1896868f,-0.1098481f,0.1079987f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449506f,1.365252f,0.7840193f,-0.7101774f,0.009099636f,0.02386299f,0.7035595f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 9.587002f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 25.99335f);
Get(0xFA26).SetLocalPose(1.255789f,0.7594289f,1.106235f,-0.9675497f,0.1900321f,-0.09891403f,0.1339829f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449664f,1.365258f,0.7840622f,-0.7101709f,0.009108695f,0.02390033f,0.7035645f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 9.642708f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 26.01145f);
Get(0xFA26).SetLocalPose(1.262775f,0.7655135f,1.090836f,-0.9654634f,0.1899386f,-0.09218602f,0.1526615f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449594f,1.365198f,0.7840479f,-0.710173f,0.009106029f,0.02387229f,0.7035636f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 9.6967f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 26.029f);
Get(0xFA26).SetLocalPose(1.271085f,0.7725567f,1.076913f,-0.9630086f,0.1894659f,-0.0871367f,0.1706587f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449469f,1.36517f,0.7839198f,-0.7101645f,0.009136478f,0.02387409f,0.7035716f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 9.751131f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 26.04669f);
Get(0xFA26).SetLocalPose(1.280423f,0.7803225f,1.062351f,-0.9604037f,0.18831f,-0.08468004f,0.1870653f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449332f,1.364989f,0.7838961f,-0.7101764f,0.009132407f,0.02386176f,0.7035601f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 9.807742f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 26.06509f);
Get(0xFA26).SetLocalPose(1.289693f,0.7873343f,1.05231f,-0.9585302f,0.1867546f,-0.08503658f,0.1977662f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449334f,1.36494f,0.7838026f,-0.7101764f,0.009154671f,0.02384177f,0.7035605f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 9.863141f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 26.08309f);
Get(0xFA26).SetLocalPose(1.301728f,0.794404f,1.042569f,-0.9564511f,0.183992f,-0.08862655f,0.208551f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449201f,1.364981f,0.7837375f,-0.7101614f,0.009179981f,0.02381368f,0.7035763f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 9.889362f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 26.09162f);
Get(0xFA26).SetLocalPose(1.306545f,0.7967572f,1.0392f,-0.9556375f,0.1827258f,-0.09114817f,0.2122745f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448986f,1.364938f,0.7838095f,-0.710155f,0.009203002f,0.02381676f,0.7035823f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 9.948481f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 26.11083f);
Get(0xFA26).SetLocalPose(1.318422f,0.8019357f,1.032301f,-0.9536182f,0.1802166f,-0.09887953f,0.2199028f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448918f,1.364897f,0.7836899f,-0.7101502f,0.009204516f,0.02381463f,0.7035872f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 10.00452f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 26.12904f);
Get(0xFA26).SetLocalPose(1.330436f,0.8059535f,1.028f,-0.9512721f,0.1783374f,-0.10875f,0.2268277f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448857f,1.364914f,0.7836865f,-0.7101433f,0.009200766f,0.02382852f,0.7035937f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 10.06218f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 26.14778f);
Get(0xFA26).SetLocalPose(1.34271f,0.8095378f,1.02457f,-0.9486372f,0.1769467f,-0.1199688f,0.2332055f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448906f,1.364837f,0.7837923f,-0.710156f,0.009183739f,0.02382306f,0.7035813f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 10.1188f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 26.16618f);
Get(0xFA26).SetLocalPose(1.356179f,0.8127884f,1.022617f,-0.9457707f,0.1761294f,-0.1322123f,0.2387808f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448828f,1.364853f,0.7838494f,-0.7101651f,0.009199223f,0.0238192f,0.703572f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 10.14522f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 26.17477f);
Get(0xFA26).SetLocalPose(1.363422f,0.8143716f,1.021977f,-0.9440798f,0.175946f,-0.139253f,0.2415887f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448942f,1.365057f,0.7839416f,-0.7101643f,0.009192777f,0.02381689f,0.703573f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 10.20468f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 26.1941f);
Get(0xFA26).SetLocalPose(1.378093f,0.816927f,1.022227f,-0.9406379f,0.1760529f,-0.1533487f,0.2463534f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448971f,1.365098f,0.7840954f,-0.7101743f,0.009199311f,0.02384896f,0.7035617f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 10.25981f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 26.21201f);
Get(0xFA26).SetLocalPose(1.390399f,0.8184181f,1.023716f,-0.9378339f,0.176606f,-0.1645705f,0.2493881f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.448993f,1.365031f,0.7840713f,-0.710174f,0.009212801f,0.02385406f,0.7035618f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 10.31718f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 26.23066f);
Get(0xFA26).SetLocalPose(1.404894f,0.8198788f,1.027245f,-0.9343671f,0.1777899f,-0.1784414f,0.2520068f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449034f,1.365035f,0.7840801f,-0.710181f,0.009132762f,0.02385757f,0.7035556f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 10.37283f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 26.24874f);
Get(0xFA26).SetLocalPose(1.416466f,0.8204233f,1.030374f,-0.931726f,0.1788513f,-0.1894615f,0.2529885f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449097f,1.364972f,0.7840089f,-0.7101969f,0.009143731f,0.0238584f,0.7035394f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 10.3994f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 26.25738f);
Get(0xFA26).SetLocalPose(1.425614f,0.8198138f,1.033279f,-0.9298161f,0.1797485f,-0.1977589f,0.2530296f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449225f,1.365025f,0.7841431f,-0.7102166f,0.009141766f,0.02386521f,0.7035193f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 10.4597f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 26.27698f);
Get(0xFA26).SetLocalPose(1.436939f,0.8187915f,1.038318f,-0.9273436f,0.1810793f,-0.2089718f,0.2521406f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449349f,1.365042f,0.7842359f,-0.7102001f,0.009136697f,0.02388209f,0.7035354f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 10.51579f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 26.29521f);
Get(0xFA26).SetLocalPose(1.448226f,0.8170374f,1.044416f,-0.9249067f,0.1826088f,-0.220485f,0.2501762f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449377f,1.365048f,0.7842498f,-0.710198f,0.009106881f,0.02390033f,0.7035373f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 10.57284f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 26.31375f);
Get(0xFA26).SetLocalPose(1.459856f,0.8155048f,1.051987f,-0.9225087f,0.1844446f,-0.2321692f,0.247094f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449308f,1.365114f,0.7841522f,-0.7101836f,0.009136216f,0.02388713f,0.7035519f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 10.62943f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 26.33214f);
Get(0xFA26).SetLocalPose(1.470965f,0.8137623f,1.05993f,-0.920108f,0.1867955f,-0.2438322f,0.2430117f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449401f,1.365041f,0.7841604f,-0.7101968f,0.009109578f,0.02388604f,0.703539f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 10.65711f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 26.34114f);
Get(0xFA26).SetLocalPose(1.484027f,0.8108585f,1.069278f,-0.9174376f,0.1899465f,-0.2564245f,0.2376449f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449592f,1.365056f,0.7840799f,-0.7102098f,0.009072486f,0.02390828f,0.7035256f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 10.71828f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 26.36102f);
Get(0xFA26).SetLocalPose(1.499564f,0.8070022f,1.082279f,-0.914658f,0.1942684f,-0.2693703f,0.2304348f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449502f,1.365007f,0.7840011f,-0.7101936f,0.009067786f,0.02389589f,0.7035424f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 10.77818f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 26.38048f);
Get(0xFA26).SetLocalPose(1.513913f,0.8031098f,1.095694f,-0.9121531f,0.1988647f,-0.2812704f,0.2220731f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449643f,1.36509f,0.7841309f,-0.7102005f,0.009044881f,0.0239113f,0.7035352f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 10.80974f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 26.39074f);
Get(0xFA26).SetLocalPose(1.521481f,0.8010928f,1.102757f,-0.911103f,0.2010472f,-0.2866128f,0.2175415f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449758f,1.36542f,0.7842863f,-0.7101895f,0.009039097f,0.02389885f,0.7035468f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 10.88005f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 26.41359f);
Get(0xFA26).SetLocalPose(1.538097f,0.7974328f,1.119452f,-0.9095485f,0.2057079f,-0.2964182f,0.2062575f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449728f,1.365363f,0.7842503f,-0.7101906f,0.009067476f,0.02392147f,0.7035446f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 10.91011f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 26.42336f);
Get(0xFA26).SetLocalPose(1.545829f,0.7953506f,1.127749f,-0.9092734f,0.2074965f,-0.3001481f,0.2001955f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449812f,1.365344f,0.7843071f,-0.7102011f,0.009102352f,0.02390854f,0.7035339f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 10.97873f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 26.44566f);
Get(0xFA26).SetLocalPose(1.563383f,0.7895127f,1.146371f,-0.9102923f,0.2104757f,-0.3052811f,0.1840416f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449679f,1.365396f,0.7842476f,-0.7101965f,0.009121231f,0.02386559f,0.7035398f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 11.00736f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 26.45497f);
Get(0xFA26).SetLocalPose(1.573895f,0.7873418f,1.157646f,-0.9115813f,0.211307f,-0.3074567f,0.1727402f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449673f,1.365222f,0.7841296f,-0.7101927f,0.009125772f,0.0238688f,0.7035434f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 11.07879f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 26.47818f);
Get(0xFA26).SetLocalPose(1.590502f,0.782192f,1.176182f,-0.9144078f,0.2101104f,-0.3119329f,0.1496986f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449585f,1.365103f,0.7841762f,-0.7101985f,0.009111153f,0.0238935f,0.703537f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 11.12172f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 26.49213f);
Get(0xFA26).SetLocalPose(1.604051f,0.7794319f,1.191659f,-0.9179572f,0.2055963f,-0.3144877f,0.12721f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449556f,1.365138f,0.7840657f,-0.7101921f,0.009112576f,0.02387359f,0.7035441f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 11.19582f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 26.51621f);
Get(0xFA26).SetLocalPose(1.620974f,0.7760193f,1.211754f,-0.9220072f,0.1968661f,-0.3186875f,0.09790178f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.4494f,1.365141f,0.7840875f,-0.710196f,0.009124877f,0.02387904f,0.7035397f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 11.23108f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 26.52767f);
Get(0xFA26).SetLocalPose(1.639154f,0.7742243f,1.232651f,-0.9232758f,0.1869423f,-0.3289371f,0.06644316f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449389f,1.365079f,0.7840511f,-0.7101901f,0.00909169f,0.02387131f,0.7035465f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 11.29555f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 26.54863f);
Get(0xFA26).SetLocalPose(1.659428f,0.7725691f,1.257192f,-0.919978f,0.1752557f,-0.3491283f,0.03217747f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449311f,1.364971f,0.7840186f,-0.7101709f,0.009103691f,0.02384788f,0.7035665f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 11.32693f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 26.55882f);
Get(0xFA26).SetLocalPose(1.671174f,0.7722988f,1.269949f,-0.9163401f,0.1684924f,-0.3628682f,0.01605581f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449555f,1.364833f,0.7842633f,-0.7102072f,0.009069575f,0.02389826f,0.7035286f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 11.39163f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 26.57985f);
Get(0xFA26).SetLocalPose(1.694232f,0.7729028f,1.295227f,-0.9035228f,0.1561279f,-0.3990472f,-0.005660003f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449677f,1.364932f,0.7842016f,-0.7102025f,0.009081969f,0.02388291f,0.7035336f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 11.44885f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 26.59845f);
Get(0xFA26).SetLocalPose(1.710877f,0.7747888f,1.307385f,-0.8808002f,0.1570121f,-0.4466373f,-0.007305237f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449609f,1.364938f,0.7841578f,-0.7101859f,0.009056888f,0.02389424f,0.7035503f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 11.47844f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 26.60806f);
Get(0xFA26).SetLocalPose(1.718238f,0.7784829f,1.310537f,-0.8692889f,0.165039f,-0.4657377f,0.01369273f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449641f,1.365003f,0.7841587f,-0.7101946f,0.009044901f,0.02391941f,0.7035409f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 11.54387f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 26.62933f);
Get(0xFA26).SetLocalPose(1.735308f,0.7867321f,1.31033f,-0.8545825f,0.2000255f,-0.4751098f,0.0628419f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449695f,1.365145f,0.7840682f,-0.710194f,0.009054674f,0.02390762f,0.7035418f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 11.60644f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 26.64966f);
Get(0xFA26).SetLocalPose(1.761125f,0.7969663f,1.304579f,-0.8599041f,0.1949874f,-0.4608475f,0.100819f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449695f,1.365239f,0.7840801f,-0.7101895f,0.009069142f,0.02392092f,0.7035457f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 11.6326f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 26.65817f);
Get(0xFA26).SetLocalPose(1.770945f,0.801607f,1.301358f,-0.8629279f,0.1869034f,-0.4577822f,0.1042022f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449825f,1.365156f,0.7841409f,-0.7101648f,0.009093599f,0.0239185f,0.7035703f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 11.7003f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 26.68017f);
Get(0xFA26).SetLocalPose(1.787203f,0.8083948f,1.295119f,-0.8673511f,0.1679748f,-0.4569121f,0.103528f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449786f,1.365272f,0.7841321f,-0.710175f,0.009068117f,0.02391505f,0.7035605f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 11.75761f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 26.6988f);
Get(0xFA26).SetLocalPose(1.802111f,0.8138917f,1.290211f,-0.8689625f,0.1465658f,-0.4626884f,0.0966556f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449812f,1.365295f,0.7841279f,-0.7101867f,0.009068955f,0.02392435f,0.7035484f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 11.78705f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 26.70836f);
Get(0xFA26).SetLocalPose(1.805484f,0.8150138f,1.289171f,-0.8686599f,0.1423835f,-0.4648063f,0.09545664f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449921f,1.365285f,0.7843112f,-0.7101849f,0.009076497f,0.02395802f,0.703549f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 11.85152f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 26.72932f);
Get(0xFA26).SetLocalPose(1.811963f,0.8171948f,1.286808f,-0.8673956f,0.136288f,-0.4693272f,0.09371553f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449721f,1.365348f,0.784272f,-0.7101945f,0.009086474f,0.02390625f,0.7035409f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 11.91166f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 26.74886f);
Get(0xFA26).SetLocalPose(1.844826f,0.8298903f,1.278072f,-0.8572014f,0.1168958f,-0.4914308f,0.1001847f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44969f,1.365218f,0.784274f,-0.710204f,0.009055487f,0.02389616f,0.703532f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 11.93928f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 26.75784f);
Get(0xFA26).SetLocalPose(1.85542f,0.8325052f,1.273863f,-0.8538966f,0.1141146f,-0.4962927f,0.1073873f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449737f,1.365203f,0.784251f,-0.7101936f,0.009057338f,0.02389764f,0.7035426f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 12.00633f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 26.77963f);
Get(0xFA26).SetLocalPose(1.8728f,0.8384538f,1.268497f,-0.847535f,0.1134607f,-0.502903f,0.1260937f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449578f,1.365252f,0.7841305f,-0.7101662f,0.009100329f,0.02391361f,0.7035691f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 12.06459f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 26.79856f);
Get(0xFA26).SetLocalPose(1.888541f,0.8431863f,1.263063f,-0.8407038f,0.1154202f,-0.50748f,0.1495307f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449629f,1.365232f,0.7842146f,-0.7101942f,0.009089546f,0.02389876f,0.7035413f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 12.0933f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 26.80789f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44952f,1.365157f,0.7842195f,-0.7101943f,0.009112217f,0.02388769f,0.7035413f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 12.15471f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 26.82785f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449522f,1.365171f,0.7842004f,-0.7102085f,0.009111417f,0.02387809f,0.7035275f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 12.2136f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 26.84699f);
Get(0xFA26).SetLocalPose(1.895608f,0.8447524f,1.260743f,-0.8380328f,0.1161382f,-0.5086206f,0.1597435f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449472f,1.365056f,0.7842986f,-0.7102165f,0.009104727f,0.02390802f,0.7035184f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 12.2671f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 26.86438f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449464f,1.365055f,0.784285f,-0.7101987f,0.009120313f,0.02389855f,0.7035364f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 12.32223f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 26.8823f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449392f,1.365065f,0.7843055f,-0.7101933f,0.009087927f,0.02390422f,0.7035422f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 12.34814f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 26.89072f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449521f,1.365145f,0.7844183f,-0.7102091f,0.009104006f,0.02389868f,0.7035261f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 12.40784f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 26.91012f);
Get(0xFA26).SetLocalPose(1.905239f,0.8461812f,1.258349f,-0.8343747f,0.1165718f,-0.5095297f,0.1749551f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449612f,1.365092f,0.7843971f,-0.7102191f,0.009121969f,0.02389117f,0.7035161f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 12.46287f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 26.928f);
Get(0xFA26).SetLocalPose(1.929654f,0.8495919f,1.25219f,-0.8281596f,0.1167798f,-0.5071967f,0.2080041f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449599f,1.365116f,0.7843032f,-0.7102175f,0.009102029f,0.02387596f,0.7035185f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 12.52087f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 26.94685f);
Get(0xFA26).SetLocalPose(1.95348f,0.8493969f,1.246502f,-0.8273864f,0.1187133f,-0.4981513f,0.2306173f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449414f,1.365085f,0.7842732f,-0.7102275f,0.009106667f,0.02388263f,0.7035081f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 12.57779f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 26.96535f);
Get(0xFA26).SetLocalPose(1.980406f,0.8461286f,1.242297f,-0.8317698f,0.1217781f,-0.4874327f,0.2360903f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449327f,1.365025f,0.7842366f,-0.7102186f,0.009102194f,0.02387498f,0.7035174f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 12.60491f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 26.97417f);
Get(0xFA26).SetLocalPose(1.995531f,0.8429118f,1.242472f,-0.8337328f,0.1247361f,-0.4863867f,0.2296918f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44937f,1.365068f,0.7844262f,-0.7102278f,0.009102836f,0.02384889f,0.703509f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 12.66583f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 26.99397f);
Get(0xFA26).SetLocalPose(2.017835f,0.8350078f,1.246004f,-0.8306226f,0.1298244f,-0.4975351f,0.2137068f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449337f,1.365169f,0.7844091f,-0.7102055f,0.009136031f,0.02385354f,0.703531f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 12.72098f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 27.01189f);
Get(0xFA26).SetLocalPose(2.026986f,0.8305812f,1.248797f,-0.826147f,0.1321041f,-0.5076289f,0.2057731f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44941f,1.365157f,0.7844225f,-0.7102044f,0.009139624f,0.02386419f,0.7035317f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 12.7816f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 27.03159f);
Get(0xFA26).SetLocalPose(2.047689f,0.8201643f,1.258705f,-0.8105778f,0.1372626f,-0.5369354f,0.1892698f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449456f,1.365151f,0.7843443f,-0.7102156f,0.009109741f,0.02386091f,0.7035208f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 12.80864f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 27.04038f);
Get(0xFA26).SetLocalPose(2.05319f,0.8170997f,1.261483f,-0.8051635f,0.1386174f,-0.5462006f,0.184829f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449476f,1.365011f,0.7843128f,-0.7102009f,0.009112899f,0.02383711f,0.7035365f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 12.86931f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 27.0601f);
Get(0xFA26).SetLocalPose(2.074062f,0.8037456f,1.275333f,-0.7801014f,0.1431341f,-0.585422f,0.1680347f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449404f,1.365016f,0.7842451f,-0.7101873f,0.009103692f,0.02386049f,0.7035496f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 12.92466f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 27.07809f);
Get(0xFA26).SetLocalPose(2.08965f,0.7954706f,1.287062f,-0.7588239f,0.1457816f,-0.6151943f,0.1564292f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449446f,1.365088f,0.7841355f,-0.7101851f,0.009113017f,0.02386574f,0.7035514f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 12.98377f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 27.0973f);
Get(0xFA26).SetLocalPose(2.105181f,0.7877964f,1.297357f,-0.7389228f,0.1472697f,-0.6410428f,0.1461811f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449349f,1.365149f,0.7840998f,-0.7101836f,0.009111999f,0.02386338f,0.7035531f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 13.04236f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 27.11634f);
Get(0xFA26).SetLocalPose(2.119337f,0.7801755f,1.306949f,-0.7226357f,0.1475702f,-0.6611832f,0.1373225f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449355f,1.365088f,0.7841254f,-0.7101874f,0.009126151f,0.02385862f,0.7035491f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 13.0694f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 27.12513f);
Get(0xFA26).SetLocalPose(2.121612f,0.7776284f,1.308787f,-0.7196131f,0.1475146f,-0.6648599f,0.1354912f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449204f,1.365057f,0.7840111f,-0.7101715f,0.00914239f,0.02385743f,0.7035651f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 13.13514f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 27.1465f);
Get(0xFA26).SetLocalPose(2.127428f,0.774674f,1.312286f,-0.7139911f,0.147278f,-0.6716618f,0.1318951f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44925f,1.365075f,0.7840259f,-0.7101732f,0.009176902f,0.0238607f,0.7035627f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 13.19464f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 27.16583f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449172f,1.365079f,0.7840104f,-0.7101547f,0.009210589f,0.02384557f,0.7035815f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 13.22299f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 27.17505f);
});
r.Add(delegate{
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 13.28862f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 27.19637f);
});
r.Add(delegate{
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 13.31641f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 27.20541f);
});
r.Add(delegate{
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 13.38442f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 27.22751f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449044f,1.36505f,0.7839122f,-0.7101611f,0.009210027f,0.02386501f,0.7035744f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 13.44507f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 27.24722f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449072f,1.364923f,0.7837823f,-0.7101822f,0.009164288f,0.02388042f,0.7035531f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 13.50417f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 27.26643f);
Get(0xFA26).SetLocalPose(2.146185f,0.7637604f,1.322243f,-0.7006366f,0.1447973f,-0.6881102f,0.1210228f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449099f,1.364978f,0.7838918f,-0.7101827f,0.009164204f,0.02387469f,0.7035528f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 13.53079f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 27.27508f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449209f,1.364955f,0.7841534f,-0.7101954f,0.009166065f,0.02390879f,0.7035388f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 13.58945f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 27.29414f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449213f,1.364966f,0.7841198f,-0.7102077f,0.009118484f,0.02388404f,0.7035279f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 13.64615f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 27.31257f);
Get(0xFA26).SetLocalPose(2.15953f,0.7578405f,1.327826f,-0.6953354f,0.1417877f,-0.6951717f,0.1146349f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449351f,1.365156f,0.7844269f,-0.7101893f,0.009133133f,0.02389493f,0.7035459f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 13.70451f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 27.33154f);
Get(0xFA26).SetLocalPose(2.188234f,0.7495285f,1.339429f,-0.6961076f,0.1344523f,-0.6979039f,0.1014245f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449584f,1.365185f,0.7842343f,-0.7101844f,0.009127392f,0.02388355f,0.7035514f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 13.75846f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 27.34907f);
Get(0xFA26).SetLocalPose(2.210242f,0.7429036f,1.342263f,-0.7204402f,0.1275645f,-0.6761934f,0.0863466f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449536f,1.365148f,0.7842517f,-0.7102125f,0.009107266f,0.02390152f,0.7035226f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 13.78561f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 27.35789f);
Get(0xFA26).SetLocalPose(2.227763f,0.7416556f,1.343236f,-0.7486308f,0.1201136f,-0.6480534f,0.07177369f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449522f,1.365157f,0.7842454f,-0.7102038f,0.009163619f,0.02388468f,0.7035313f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 13.84765f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 27.37806f);
Get(0xFA26).SetLocalPose(2.271643f,0.7462912f,1.339426f,-0.8123111f,0.08976437f,-0.57481f,0.04106865f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449605f,1.364946f,0.7842481f,-0.7102641f,0.009213571f,0.02390173f,0.7034691f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 13.90608f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 27.39705f);
Get(0xFA26).SetLocalPose(2.315306f,0.758229f,1.337039f,-0.8250692f,0.06733131f,-0.5595471f,0.04042812f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449361f,1.364981f,0.7840272f,-0.7103648f,0.009220844f,0.02386682f,0.7033685f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 13.96259f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 27.41541f);
Get(0xFA26).SetLocalPose(2.349365f,0.7659162f,1.334157f,-0.7943082f,0.07315134f,-0.5971521f,0.08445556f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.44934f,1.364974f,0.7839055f,-0.7104192f,0.009230848f,0.02389936f,0.7033123f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 13.99104f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 27.42466f);
Get(0xFA26).SetLocalPose(2.367059f,0.7723141f,1.332715f,-0.7658669f,0.08137195f,-0.6262896f,0.1207796f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449312f,1.365305f,0.7836368f,-0.710551f,0.009187736f,0.0239475f,0.7031782f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 14.05585f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 27.44572f);
Get(0xFA26).SetLocalPose(2.395641f,0.7788664f,1.329635f,-0.7205959f,0.08980779f,-0.667607f,0.1642466f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449498f,1.365593f,0.7833281f,-0.7106897f,0.009060983f,0.02400522f,0.7030377f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 14.11494f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 27.46493f);
Get(0xFA26).SetLocalPose(2.419067f,0.7830006f,1.324891f,-0.6949903f,0.09309102f,-0.6878181f,0.1876935f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449416f,1.365641f,0.7832305f,-0.7107286f,0.009036401f,0.02406448f,0.7029965f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 14.14227f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 27.47381f);
Get(0xFA26).SetLocalPose(2.425969f,0.7851457f,1.322968f,-0.6926722f,0.0920743f,-0.6892082f,0.1916239f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449505f,1.365647f,0.7833298f,-0.7107548f,0.008938149f,0.02418071f,0.7029673f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 14.20522f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 27.49427f);
Get(0xFA26).SetLocalPose(2.440649f,0.7874233f,1.317421f,-0.6979704f,0.08740729f,-0.6833305f,0.195593f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449682f,1.365683f,0.7834675f,-0.7107177f,0.008811019f,0.02427335f,0.7030033f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 14.26645f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 27.51417f);
Get(0xFA26).SetLocalPose(2.453587f,0.791912f,1.31172f,-0.7123064f,0.08139434f,-0.6692961f,0.1950318f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.449707f,1.365851f,0.7836069f,-0.7106616f,0.008806081f,0.0243173f,0.7030585f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 14.29344f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 27.52294f);
Get(0xFA26).SetLocalPose(2.46209f,0.7945816f,1.3076f,-0.7244697f,0.07652272f,-0.6570195f,0.1939418f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.450042f,1.365797f,0.7837379f,-0.7105121f,0.008819935f,0.02429529f,0.7032102f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 14.35013f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 27.54136f);
Get(0xFA26).SetLocalPose(2.470547f,0.7991612f,1.303129f,-0.7406287f,0.07051606f,-0.6399612f,0.1922143f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.450289f,1.365937f,0.7837118f,-0.7103676f,0.008916638f,0.02425682f,0.7033564f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 14.40697f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 27.55984f);
Get(0xFA26).SetLocalPose(2.484008f,0.8059863f,1.294736f,-0.7706819f,0.06008364f,-0.6052674f,0.1899759f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.450421f,1.365714f,0.7840355f,-0.7102828f,0.008996401f,0.02411639f,0.7034458f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 14.45684f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 27.57605f);
Get(0xFA26).SetLocalPose(2.490449f,0.8108179f,1.28957f,-0.7909041f,0.05353687f,-0.5793411f,0.1896533f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.450232f,1.365357f,0.7840592f,-0.7102078f,0.009132568f,0.02397982f,0.7035244f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 14.52263f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 27.59743f);
Get(0xFA26).SetLocalPose(2.500858f,0.8170536f,1.281664f,-0.8168869f,0.04464537f,-0.5420461f,0.1920644f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.450144f,1.36534f,0.7839932f,-0.7101712f,0.009274581f,0.02382007f,0.7035648f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 14.57802f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 27.61543f);
Get(0xFA26).SetLocalPose(2.508286f,0.8214889f,1.276691f,-0.8332247f,0.03886956f,-0.5157595f,0.1954939f);
});
r.Add(delegate{
Get(0xF9B6).SetLocalPose(2.45011f,1.365267f,0.7839941f,-0.710176f,0.009276647f,0.02375641f,0.7035621f);
Get(0xF9DC).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 14.60475f);
Get(0xFA0E).GetComponent<Animator>().Play("New State", 0, 27.62412f);
Get(0xFA26).SetLocalPose(2.509514f,0.8243579f,1.275111f,-0.8408154f,0.03636802f,-0.5026982f,0.1974878f);
});
return r;
}
public override List<Action> SuperExecute() {
     List<Action> actions = new List<Action>();
     actions = actions.Concat(Execute()).ToList();
     actions = actions.Concat(Execute0()).ToList();
     return actions;
}
}

