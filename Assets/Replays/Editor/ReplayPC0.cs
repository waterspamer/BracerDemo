using System;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class ReplayPC0 : ReplayBase {
private List<Action> Execute() {
var r = new List<Action>();
r.Add(delegate{
Add(0xDCA4, GameObject.Find("/CUBEPETR"));
Get(0xDCA4).SetLocalPose(0f,0.421f,-2.528f,0f,0f,0f,1f);
Add(0xDCAE, GameObject.Find("/Main Camera"));
Get(0xDCAE).SetLocalPose(0.76f,2.04f,-10f,0f,0f,0f,1f);
Add(0xDCD4, GameObject.Find("/BracerRight/HandPivot/HandRemasteredNew"));
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 0f);
Add(0xDCEE, GameObject.Find("/BracerLeft"));
Get(0xDCEE).SetLocalPose(0.124f,0f,0f,0f,0f,-1f,0f);
Add(0xDD06, GameObject.Find("/BracerLeft/HandPivot/HandRemasteredNew"));
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 0f);
Add(0xDD1E, GameObject.Find("/BracerRight"));
Get(0xDD1E).SetLocalPose(0f,0f,0f,0f,0f,0f,1f);
});
return r;
}
private List<Action> Execute0() {
var r = new List<Action>();
r.Add(delegate{
Get(0xDCA4).SetLocalPose(0f,0.418275f,-2.528f,0f,0f,0f,1f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 0f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 0f);
});
r.Add(delegate{
Get(0xDCA4).SetLocalPose(0f,0.412825f,-2.528f,0f,0f,0f,1f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 0f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 0f);
});
r.Add(delegate{
Get(0xDCA4).SetLocalPose(0f,0.40465f,-2.528f,0f,0f,0f,1f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 0.02f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 0.02f);
});
r.Add(delegate{
Get(0xDCA4).SetLocalPose(0f,0.39375f,-2.528f,0f,0f,0f,1f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 0.02f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 0.02f);
});
r.Add(delegate{
Get(0xDCA4).SetLocalPose(0f,0.380125f,-2.528f,0f,0f,0f,1f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 0.02f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 0.02f);
});
r.Add(delegate{
Get(0xDCA4).SetLocalPose(0f,0.363775f,-2.528f,0f,0f,0f,1f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 0.02f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 0.02f);
});
r.Add(delegate{
Get(0xDCA4).SetLocalPose(0f,0.3447f,-2.528f,0f,0f,0f,1f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 0.02f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 0.02f);
});
r.Add(delegate{
Get(0xDCA4).SetLocalPose(0f,0.3229f,-2.528f,0f,0f,0f,1f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 0.02f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 0.02f);
});
r.Add(delegate{
Get(0xDCA4).SetLocalPose(0f,0.298375f,-2.528f,0f,0f,0f,1f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 0.02f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 0.02f);
});
r.Add(delegate{
Get(0xDCA4).SetLocalPose(0f,0.271125f,-2.528f,0f,0f,0f,1f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 0.02f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 0.02f);
});
r.Add(delegate{
Get(0xDCA4).SetLocalPose(0f,0.24115f,-2.528f,0f,0f,0f,1f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 0.02f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 0.02f);
});
r.Add(delegate{
Get(0xDCA4).SetLocalPose(0f,0.20845f,-2.528f,0f,0f,0f,1f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 0.02f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 0.02f);
});
r.Add(delegate{
Get(0xDCA4).SetLocalPose(0f,0.173025f,-2.528f,0f,0f,0f,1f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 0.02f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 0.02f);
});
r.Add(delegate{
Get(0xDCA4).SetLocalPose(0f,0.134875f,-2.528f,0f,0f,0f,1f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 0.02f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 0.02f);
});
r.Add(delegate{
Get(0xDCA4).SetLocalPose(0f,0.09400003f,-2.528f,0f,0f,0f,1f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 0.02f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 0.02f);
});
r.Add(delegate{
Get(0xDCA4).SetLocalPose(0f,0.05040004f,-2.528f,0f,0f,0f,1f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 0.02f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 0.02f);
});
r.Add(delegate{
Get(0xDCA4).SetLocalPose(0f,0.004075039f,-2.528f,0f,0f,0f,1f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 0.02f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 0.02f);
});
r.Add(delegate{
Get(0xDCA4).SetLocalPose(1.202322E-07f,-0.002384948f,-2.528f,9.378643E-08f,1.358775E-07f,5.553623E-07f,1f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 0.02f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 0.02f);
});
r.Add(delegate{
Get(0xDCA4).SetLocalPose(3.769669E-07f,-0.003676876f,-2.528f,-7.863243E-08f,1.209727E-07f,2.711097E-07f,1f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 0.02f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 0.02f);
});
r.Add(delegate{
Get(0xDCA4).SetLocalPose(5.453992E-07f,-0.003935271f,-2.528f,-6.017438E-08f,1.710417E-07f,6.103971E-08f,1f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 0.02f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 0.02f);
});
r.Add(delegate{
Get(0xDCA4).SetLocalPose(5.727096E-07f,-0.003986937f,-2.528f,3.158966E-08f,1.071677E-07f,-6.837702E-09f,1f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 0.02f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 0.02f);
});
r.Add(delegate{
Get(0xDCA4).SetLocalPose(5.720619E-07f,-0.003997285f,-2.528f,-2.477538E-09f,1.703889E-07f,1.818979E-08f,1f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 0.02f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 0.02f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.4482f,1.364996f,0.7848732f,-0.7100314f,0.01435413f,0.0288402f,0.7034327f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 0.3533334f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 0.3533334f);
Get(0xDD1E).SetLocalPose(1.473756f,1.236408f,0.8646146f,0.3048916f,-0.5860789f,0.3083715f,-0.6844411f);
});
r.Add(delegate{
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 0.3533334f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 0.3533334f);
});
r.Add(delegate{
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 0.3533334f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 0.3533334f);
});
r.Add(delegate{
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 0.3533334f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 0.3533334f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448375f,1.364881f,0.785014f,-0.710026f,0.01433992f,0.02884794f,0.7034382f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 0.4267522f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 0.4267522f);
Get(0xDD1E).SetLocalPose(1.470209f,1.234847f,0.8545045f,0.4087209f,-0.573777f,0.337558f,-0.6243251f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448276f,1.365006f,0.7848995f,-0.7100167f,0.01435124f,0.02883748f,0.7034478f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 0.4485232f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 0.4485232f);
Get(0xDD1E).SetLocalPose(1.469386f,1.230835f,0.850826f,0.4596205f,-0.5685875f,0.3408187f,-0.5910159f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44823f,1.365108f,0.7847774f,-0.7100104f,0.01438873f,0.02885646f,0.7034526f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 0.4591235f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 0.4591235f);
Get(0xDD1E).SetLocalPose(1.468008f,1.230676f,0.8491716f,0.4789971f,-0.5642279f,0.340346f,-0.5799771f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448117f,1.364973f,0.7846622f,-0.7100083f,0.01436914f,0.02881535f,0.7034568f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 0.4757031f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 0.4757031f);
Get(0xDD1E).SetLocalPose(1.466456f,1.229444f,0.8467373f,0.5166783f,-0.5535973f,0.3360378f,-0.5600466f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44799f,1.365022f,0.7845954f,-0.7099986f,0.01440592f,0.02882136f,0.7034656f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 0.4965373f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 0.4965373f);
Get(0xDD1E).SetLocalPose(1.463292f,1.228886f,0.8459784f,0.5529474f,-0.5397019f,0.3312798f,-0.5415024f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447869f,1.365043f,0.7845704f,-0.7099963f,0.01440595f,0.02881813f,0.703468f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 0.5146966f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 0.5146966f);
Get(0xDD1E).SetLocalPose(1.461205f,1.228305f,0.8456774f,0.5767887f,-0.5291915f,0.3345359f,-0.5247446f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447931f,1.365043f,0.784629f,-0.7099891f,0.01441169f,0.02882807f,0.7034748f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 0.5252064f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 0.5252064f);
Get(0xDD1E).SetLocalPose(1.461462f,1.226323f,0.8452023f,0.5838466f,-0.5263096f,0.3402191f,-0.5161127f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447751f,1.365079f,0.7845509f,-0.7099898f,0.01446487f,0.02880001f,0.7034742f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 0.5466482f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 0.5466482f);
Get(0xDD1E).SetLocalPose(1.460852f,1.222161f,0.8458553f,0.5906677f,-0.5255398f,0.3547194f,-0.499093f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447745f,1.365052f,0.784641f,-0.7099954f,0.01441745f,0.0288183f,0.7034687f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 0.5567909f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 0.5567909f);
Get(0xDD1E).SetLocalPose(1.460684f,1.221099f,0.8463382f,0.5913816f,-0.5262243f,0.360293f,-0.4935027f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447854f,1.36468f,0.7847587f,-0.7100009f,0.01441605f,0.02880456f,0.7034639f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 0.5785484f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 0.5785484f);
Get(0xDD1E).SetLocalPose(1.459927f,1.220651f,0.8460744f,0.5946703f,-0.5242174f,0.3671517f,-0.4865831f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447802f,1.36484f,0.784564f,-0.7099977f,0.01438041f,0.02885777f,0.7034656f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 0.5883425f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 0.5883425f);
Get(0xDD1E).SetLocalPose(1.459909f,1.220862f,0.8461028f,0.5979356f,-0.5218894f,0.3680841f,-0.4843746f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447743f,1.364802f,0.7845006f,-0.7099943f,0.01442038f,0.02884529f,0.7034686f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 0.6071631f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 0.6071631f);
Get(0xDD1E).SetLocalPose(1.459773f,1.222089f,0.8447862f,0.6061617f,-0.5168215f,0.3682588f,-0.4794258f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447853f,1.364811f,0.7846686f,-0.7099881f,0.01440437f,0.02884502f,0.7034754f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 0.6286048f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 0.6286048f);
Get(0xDD1E).SetLocalPose(1.459175f,1.223255f,0.844382f,0.6133816f,-0.5125753f,0.3692977f,-0.4739714f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448032f,1.364914f,0.7847669f,-0.7099998f,0.01442687f,0.02886238f,0.7034624f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 0.6491573f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 0.6491573f);
Get(0xDD1E).SetLocalPose(1.459228f,1.224089f,0.8441886f,0.6168393f,-0.510977f,0.3732139f,-0.468106f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448105f,1.36493f,0.7848295f,-0.7100024f,0.01441103f,0.02886593f,0.7034598f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 0.6657342f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 0.6657342f);
Get(0xDD1E).SetLocalPose(1.458718f,1.224157f,0.8431895f,0.6143151f,-0.5125094f,0.378179f,-0.4657594f);
});
r.Add(delegate{
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 0.6657342f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 0.6657342f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448158f,1.3649f,0.7847194f,-0.7100084f,0.01439965f,0.02884294f,0.703455f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 0.6891116f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 0.6891116f);
Get(0xDD1E).SetLocalPose(1.458898f,1.225302f,0.8429999f,0.6097326f,-0.5140861f,0.3839495f,-0.4653219f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448046f,1.364923f,0.7846212f,-0.7099975f,0.01443403f,0.02881818f,0.7034662f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 0.7137115f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 0.7137115f);
Get(0xDD1E).SetLocalPose(1.459111f,1.226319f,0.843802f,0.6076283f,-0.5136317f,0.3876656f,-0.4654951f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447872f,1.364992f,0.7845911f,-0.7099927f,0.01445591f,0.02880997f,0.7034709f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 0.7242817f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 0.7242817f);
Get(0xDD1E).SetLocalPose(1.459644f,1.227433f,0.8439254f,0.6077853f,-0.5131178f,0.3885107f,-0.4651521f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447902f,1.364843f,0.7846f,-0.7099959f,0.01445996f,0.02881708f,0.7034674f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 0.7448776f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 0.7448776f);
Get(0xDD1E).SetLocalPose(1.461001f,1.228025f,0.8438486f,0.6089904f,-0.511976f,0.3890825f,-0.4643556f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447793f,1.364876f,0.7846619f,-0.7100062f,0.01443258f,0.02883229f,0.7034569f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 0.7659643f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 0.7659643f);
Get(0xDD1E).SetLocalPose(1.461717f,1.228883f,0.8430195f,0.6086149f,-0.5116686f,0.3892688f,-0.46503f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447794f,1.365022f,0.7846837f,-0.7099931f,0.01443439f,0.0288109f,0.703471f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 0.7762564f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 0.7762564f);
Get(0xDD1E).SetLocalPose(1.461669f,1.229371f,0.8428417f,0.6075426f,-0.5120916f,0.3896103f,-0.4656802f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447869f,1.365024f,0.7847341f,-0.7099843f,0.01440963f,0.02881632f,0.7034801f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 0.7955394f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 0.7955394f);
Get(0xDD1E).SetLocalPose(1.463265f,1.230144f,0.8430443f,0.6058307f,-0.5124112f,0.3903983f,-0.4668974f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44801f,1.365f,0.7846727f,-0.7100016f,0.01442044f,0.0288308f,0.7034619f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 0.8066654f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 0.8066654f);
Get(0xDD1E).SetLocalPose(1.46408f,1.230149f,0.8426682f,0.6046811f,-0.5120757f,0.3911372f,-0.4681356f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447945f,1.365136f,0.7846795f,-0.7099972f,0.01438906f,0.02886708f,0.7034655f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 0.8286417f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 0.8286417f);
Get(0xDD1E).SetLocalPose(1.465344f,1.23098f,0.8424566f,0.6033702f,-0.511151f,0.3924997f,-0.4696947f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448054f,1.364947f,0.7847676f,-0.7100306f,0.0143535f,0.02881972f,0.7034344f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 0.8476922f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 0.8476922f);
Get(0xDD1E).SetLocalPose(1.46738f,1.230825f,0.8421299f,0.6029018f,-0.5108236f,0.3930599f,-0.4701837f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448042f,1.364941f,0.7847359f,-0.7100288f,0.01436473f,0.02884791f,0.7034348f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 0.858323f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 0.858323f);
Get(0xDD1E).SetLocalPose(1.467373f,1.231137f,0.8421068f,0.6025369f,-0.5110723f,0.3932188f,-0.4702482f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448066f,1.364946f,0.7849255f,-0.7100344f,0.01435693f,0.02880978f,0.7034309f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 0.8692757f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 0.8692757f);
Get(0xDD1E).SetLocalPose(1.467706f,1.231337f,0.8419562f,0.6019758f,-0.5113515f,0.3934272f,-0.4704889f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448006f,1.365082f,0.7848551f,-0.7100423f,0.01435994f,0.02880239f,0.7034232f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 0.8898579f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 0.8898579f);
Get(0xDD1E).SetLocalPose(1.468314f,1.231134f,0.8417276f,0.6005707f,-0.5116011f,0.3942866f,-0.4712933f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448203f,1.364927f,0.7849917f,-0.7100292f,0.01435214f,0.02880264f,0.7034366f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 0.911254f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 0.911254f);
Get(0xDD1E).SetLocalPose(1.46941f,1.231651f,0.8416505f,0.6000364f,-0.510866f,0.3946344f,-0.4724785f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448344f,1.364837f,0.7850329f,-0.7100304f,0.01434241f,0.02884129f,0.703434f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 0.9311536f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 0.9311536f);
Get(0xDD1E).SetLocalPose(1.469571f,1.232755f,0.8412825f,0.6003537f,-0.5102931f,0.3943075f,-0.4729673f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44827f,1.365004f,0.7851005f,-0.7100546f,0.01436806f,0.02883109f,0.7034094f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 0.9410195f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 0.9410195f);
Get(0xDD1E).SetLocalPose(1.469797f,1.232752f,0.8412411f,0.6008298f,-0.5100151f,0.3940299f,-0.472894f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448209f,1.365095f,0.7851238f,-0.7100444f,0.01437182f,0.02882069f,0.7034201f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 0.9640686f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 0.9640686f);
Get(0xDD1E).SetLocalPose(1.470362f,1.23324f,0.8414373f,0.6017355f,-0.5096399f,0.3933634f,-0.4727016f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448211f,1.364867f,0.7851968f,-0.7100466f,0.01434589f,0.02883869f,0.7034177f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 0.9747088f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 0.9747088f);
Get(0xDD1E).SetLocalPose(1.470461f,1.233338f,0.8414065f,0.6019528f,-0.5095192f,0.3930838f,-0.4727877f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448047f,1.365047f,0.7850196f,-0.7100377f,0.01439145f,0.02882026f,0.7034265f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 0.9946685f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 0.9946685f);
Get(0xDD1E).SetLocalPose(1.470659f,1.232599f,0.8409803f,0.6021549f,-0.5092326f,0.3925279f,-0.4733006f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448064f,1.365121f,0.7850178f,-0.7100272f,0.01439809f,0.0288169f,0.7034371f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 1.007738f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 1.007738f);
Get(0xDD1E).SetLocalPose(1.470911f,1.233061f,0.840809f,0.6021358f,-0.5089312f,0.3922754f,-0.4738582f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448059f,1.365044f,0.7850071f,-0.7100343f,0.01436008f,0.0288203f,0.7034306f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 1.032938f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 1.032938f);
Get(0xDD1E).SetLocalPose(1.471753f,1.234481f,0.8402218f,0.6016735f,-0.5083741f,0.3917817f,-0.4754492f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44811f,1.365002f,0.7851376f,-0.7100544f,0.01438815f,0.02880429f,0.7034103f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 1.048191f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 1.048191f);
Get(0xDD1E).SetLocalPose(1.471854f,1.234968f,0.8408517f,0.6012704f,-0.5082966f,0.3913297f,-0.4764133f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447988f,1.364824f,0.7851721f,-0.7100686f,0.01440643f,0.02877203f,0.7033969f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 1.064786f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 1.064786f);
Get(0xDD1E).SetLocalPose(1.471671f,1.234638f,0.840883f,0.6011778f,-0.5081592f,0.3906363f,-0.4772451f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447809f,1.364847f,0.7850326f,-0.7100465f,0.01442246f,0.02880044f,0.7034178f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 1.081285f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 1.081285f);
Get(0xDD1E).SetLocalPose(1.471611f,1.23464f,0.8413299f,0.6014509f,-0.5078157f,0.3897785f,-0.4779673f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447808f,1.364852f,0.7850044f,-0.710069f,0.0144274f,0.02880742f,0.7033947f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 1.098514f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 1.098514f);
Get(0xDD1E).SetLocalPose(1.471442f,1.234715f,0.8413756f,0.6016575f,-0.5074538f,0.3889605f,-0.4787575f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447852f,1.364828f,0.7848594f,-0.7100317f,0.01440308f,0.02882146f,0.7034322f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 1.114795f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 1.114795f);
Get(0xDD1E).SetLocalPose(1.471085f,1.234706f,0.8413532f,0.6015213f,-0.5073488f,0.3882555f,-0.4796114f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447893f,1.364841f,0.7849072f,-0.7100315f,0.01442182f,0.02883511f,0.7034315f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 1.131945f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 1.131945f);
Get(0xDD1E).SetLocalPose(1.47055f,1.234948f,0.8404975f,0.6003579f,-0.5080734f,0.3877207f,-0.4807333f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447943f,1.364838f,0.7849924f,-0.7100499f,0.01440257f,0.02883225f,0.7034134f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 1.148221f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 1.148221f);
Get(0xDD1E).SetLocalPose(1.470285f,1.23536f,0.8402048f,0.599493f,-0.5087408f,0.3872551f,-0.4814815f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447846f,1.365138f,0.784951f,-0.7100253f,0.01442217f,0.02882756f,0.703438f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 1.165746f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 1.165746f);
Get(0xDD1E).SetLocalPose(1.469955f,1.235375f,0.8400016f,0.5990885f,-0.5088467f,0.3869468f,-0.4821206f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447834f,1.365161f,0.7849435f,-0.710031f,0.01437702f,0.02884498f,0.7034325f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 1.174035f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 1.174035f);
Get(0xDD1E).SetLocalPose(1.469636f,1.235418f,0.8398585f,0.5990595f,-0.5088035f,0.3867332f,-0.4823735f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448144f,1.365102f,0.7850613f,-0.710015f,0.01436686f,0.02887601f,0.7034476f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 1.192513f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 1.192513f);
Get(0xDD1E).SetLocalPose(1.46954f,1.235534f,0.8395345f,0.5996819f,-0.508333f,0.3861605f,-0.4825549f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44803f,1.365117f,0.7847261f,-0.7100119f,0.01439669f,0.02887528f,0.7034501f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 1.210812f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 1.210812f);
Get(0xDD1E).SetLocalPose(1.469259f,1.235781f,0.8394027f,0.6002678f,-0.5080304f,0.3854773f,-0.4826915f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448121f,1.365167f,0.7846584f,-0.7099925f,0.01440766f,0.02888456f,0.7034691f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 1.226856f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 1.226856f);
Get(0xDD1E).SetLocalPose(1.468637f,1.235702f,0.8394397f,0.6001731f,-0.5083304f,0.3853939f,-0.48256f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44808f,1.364977f,0.784644f,-0.7099925f,0.01441339f,0.02888561f,0.703469f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 1.244027f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 1.244027f);
Get(0xDD1E).SetLocalPose(1.468166f,1.234916f,0.839f,0.5993279f,-0.509087f,0.3855654f,-0.4826759f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447985f,1.364918f,0.7846888f,-0.7099993f,0.01442005f,0.02887842f,0.7034623f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 1.26188f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 1.26188f);
Get(0xDD1E).SetLocalPose(1.467902f,1.235229f,0.8391877f,0.5978466f,-0.5099421f,0.3858637f,-0.4833713f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447859f,1.364958f,0.7844628f,-0.7099774f,0.0144188f,0.02883409f,0.7034862f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 1.278746f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 1.278746f);
Get(0xDD1E).SetLocalPose(1.467618f,1.235045f,0.8394511f,0.5966018f,-0.5105119f,0.3861538f,-0.4840756f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447931f,1.364871f,0.7844236f,-0.7099748f,0.0144165f,0.02887769f,0.7034871f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 1.296028f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 1.296028f);
Get(0xDD1E).SetLocalPose(1.467414f,1.234868f,0.8394856f,0.5959446f,-0.5108311f,0.3859788f,-0.4846875f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447888f,1.364908f,0.7843444f,-0.709959f,0.01441033f,0.02884978f,0.7035044f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 1.311845f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 1.311845f);
Get(0xDD1E).SetLocalPose(1.467246f,1.235199f,0.8393397f,0.5960113f,-0.5108846f,0.385265f,-0.4851169f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44778f,1.364865f,0.7842779f,-0.7099711f,0.01444069f,0.02884232f,0.7034917f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 1.32863f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 1.32863f);
Get(0xDD1E).SetLocalPose(1.467493f,1.235161f,0.8390271f,0.5966164f,-0.5106305f,0.3844554f,-0.4852828f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447874f,1.364972f,0.7842417f,-0.709988f,0.01439056f,0.02885504f,0.7034752f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 1.344215f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 1.344215f);
Get(0xDD1E).SetLocalPose(1.466969f,1.235469f,0.8386425f,0.5968335f,-0.5106736f,0.3839289f,-0.4853873f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448002f,1.364839f,0.7843322f,-0.7099906f,0.01440019f,0.02885773f,0.7034724f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 1.362243f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 1.362243f);
Get(0xDD1E).SetLocalPose(1.466216f,1.235492f,0.8388296f,0.5966036f,-0.5109069f,0.3836823f,-0.4856195f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448041f,1.364949f,0.784448f,-0.7100158f,0.01436725f,0.02885388f,0.7034477f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 1.380405f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 1.380405f);
Get(0xDD1E).SetLocalPose(1.465864f,1.235792f,0.8393565f,0.5961492f,-0.5111142f,0.3836728f,-0.4859667f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448024f,1.365034f,0.7845228f,-0.7100129f,0.0143651f,0.02885505f,0.7034507f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 1.389943f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 1.389943f);
Get(0xDD1E).SetLocalPose(1.4662f,1.236418f,0.8395947f,0.5957583f,-0.5113004f,0.3837461f,-0.4861922f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448058f,1.364966f,0.7847352f,-0.7100115f,0.01437576f,0.02886681f,0.7034513f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 1.411502f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 1.411502f);
Get(0xDD1E).SetLocalPose(1.466629f,1.237125f,0.8395817f,0.5954391f,-0.5113921f,0.3839592f,-0.4863186f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448131f,1.36493f,0.7846744f,-0.7099974f,0.01439635f,0.02887327f,0.7034649f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 1.431984f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 1.431984f);
Get(0xDD1E).SetLocalPose(1.466618f,1.237576f,0.8394964f,0.5952352f,-0.5115106f,0.384203f,-0.486251f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44819f,1.364921f,0.7846183f,-0.709991f,0.01436946f,0.02887227f,0.7034719f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 1.441417f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 1.441417f);
Get(0xDD1E).SetLocalPose(1.466471f,1.238555f,0.8395604f,0.5950559f,-0.5119191f,0.3844284f,-0.4858622f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448255f,1.364829f,0.784843f,-0.7100069f,0.0144003f,0.02884313f,0.7034565f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 1.463201f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 1.463201f);
Get(0xDD1E).SetLocalPose(1.466153f,1.238381f,0.8394107f,0.5948609f,-0.5126889f,0.3849577f,-0.4848692f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448207f,1.364921f,0.7849283f,-0.7100382f,0.01436678f,0.02884903f,0.7034253f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 1.471443f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 1.471443f);
Get(0xDD1E).SetLocalPose(1.466078f,1.237757f,0.8396416f,0.5946928f,-0.5130948f,0.3853438f,-0.4843393f);
});
r.Add(delegate{
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 1.471443f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 1.471443f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448031f,1.364957f,0.7850568f,-0.7100185f,0.0143914f,0.02883695f,0.7034453f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 1.503548f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 1.503548f);
Get(0xDD1E).SetLocalPose(1.465637f,1.236631f,0.8392199f,0.5943221f,-0.513533f,0.3868068f,-0.4831621f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447904f,1.36495f,0.7849326f,-0.7100169f,0.01444846f,0.02880232f,0.703447f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 1.525792f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 1.525792f);
Get(0xDD1E).SetLocalPose(1.465531f,1.236396f,0.8396158f,0.5941914f,-0.5137575f,0.387547f,-0.4824905f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447853f,1.364771f,0.7848423f,-0.7100242f,0.01443622f,0.02879234f,0.7034403f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 1.542917f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 1.542917f);
Get(0xDD1E).SetLocalPose(1.465373f,1.235917f,0.8397864f,0.5939247f,-0.5142122f,0.3876855f,-0.4822232f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447784f,1.364785f,0.7847081f,-0.7100106f,0.0144392f,0.02879263f,0.703454f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 1.561738f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 1.561738f);
Get(0xDD1E).SetLocalPose(1.465302f,1.235346f,0.8400486f,0.5933653f,-0.5149428f,0.3879875f,-0.4818894f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447911f,1.364745f,0.7848431f,-0.7100111f,0.0143999f,0.02881458f,0.7034534f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 1.581156f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 1.581156f);
Get(0xDD1E).SetLocalPose(1.464617f,1.235059f,0.8404777f,0.5932524f,-0.5152836f,0.3886055f,-0.4811654f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447903f,1.36473f,0.7848424f,-0.710004f,0.01443862f,0.02881513f,0.7034597f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 1.589886f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 1.589886f);
Get(0xDD1E).SetLocalPose(1.464538f,1.235109f,0.8406783f,0.5932592f,-0.515357f,0.3888103f,-0.480913f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447989f,1.364961f,0.785035f,-0.7100319f,0.01441826f,0.02882787f,0.7034315f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 1.608953f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 1.608953f);
Get(0xDD1E).SetLocalPose(1.464225f,1.234506f,0.8412369f,0.5933732f,-0.5154253f,0.3895727f,-0.4800813f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447916f,1.365188f,0.7848456f,-0.7100203f,0.01441502f,0.02882412f,0.7034434f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 1.62615f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 1.62615f);
Get(0xDD1E).SetLocalPose(1.465576f,1.233733f,0.8416448f,0.593403f,-0.5155478f,0.3899625f,-0.4795964f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447885f,1.365074f,0.7848613f,-0.710017f,0.01441342f,0.02882776f,0.7034467f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 1.6439f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 1.6439f);
Get(0xDD1E).SetLocalPose(1.465671f,1.233314f,0.8414776f,0.5932192f,-0.5157866f,0.3903029f,-0.47929f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447845f,1.365125f,0.7848761f,-0.7100222f,0.01440184f,0.02885637f,0.7034405f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 1.662447f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 1.662447f);
Get(0xDD1E).SetLocalPose(1.466464f,1.23389f,0.8421349f,0.5930545f,-0.5159543f,0.3905135f,-0.4791416f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447968f,1.365126f,0.7849199f,-0.710013f,0.01442149f,0.02886407f,0.703449f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 1.678543f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 1.678543f);
Get(0xDD1E).SetLocalPose(1.466394f,1.233674f,0.8425208f,0.5929934f,-0.5161161f,0.390705f,-0.4788869f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448061f,1.36514f,0.7848164f,-0.7099993f,0.01439646f,0.02884161f,0.7034644f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 1.697067f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 1.697067f);
Get(0xDD1E).SetLocalPose(1.466229f,1.233543f,0.8425577f,0.5930999f,-0.5162058f,0.3908997f,-0.4784993f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447886f,1.365314f,0.7846382f,-0.70998f,0.01441697f,0.02886318f,0.7034826f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 1.713729f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 1.713729f);
Get(0xDD1E).SetLocalPose(1.466463f,1.233814f,0.8423721f,0.5931746f,-0.5163735f,0.391142f,-0.4780276f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447781f,1.365257f,0.784634f,-0.7099655f,0.01440176f,0.02887143f,0.7034971f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 1.731849f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 1.731849f);
Get(0xDD1E).SetLocalPose(1.466218f,1.233977f,0.84191f,0.593092f,-0.5166337f,0.3912364f,-0.4777716f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447838f,1.365121f,0.7844284f,-0.709954f,0.01441301f,0.02887641f,0.7035082f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 1.740643f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 1.740643f);
Get(0xDD1E).SetLocalPose(1.466403f,1.234055f,0.8420602f,0.5929808f,-0.5168083f,0.3912298f,-0.477726f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447932f,1.365048f,0.7843617f,-0.7099764f,0.01439481f,0.02886048f,0.7034867f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 1.761196f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 1.761196f);
Get(0xDD1E).SetLocalPose(1.466617f,1.234582f,0.8416805f,0.5924575f,-0.5173296f,0.3913822f,-0.4776863f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447889f,1.365076f,0.7843197f,-0.7099803f,0.01437605f,0.02887367f,0.7034826f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 1.780692f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 1.780692f);
Get(0xDD1E).SetLocalPose(1.466494f,1.235074f,0.8415266f,0.5919796f,-0.5177155f,0.3917314f,-0.4775745f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448037f,1.365023f,0.7844261f,-0.7099921f,0.0143615f,0.02887341f,0.703471f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 1.799289f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 1.799289f);
Get(0xDD1E).SetLocalPose(1.465763f,1.234421f,0.8421234f,0.5916563f,-0.518086f,0.3921201f,-0.4772542f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448063f,1.36496f,0.7845423f,-0.7099943f,0.01436377f,0.028851f,0.7034696f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 1.808952f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 1.808952f);
Get(0xDD1E).SetLocalPose(1.465468f,1.234588f,0.8422427f,0.5916068f,-0.5182688f,0.3921607f,-0.4770837f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44819f,1.364919f,0.7846481f,-0.7099847f,0.0143793f,0.02888225f,0.7034777f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 1.828484f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 1.828484f);
Get(0xDD1E).SetLocalPose(1.464994f,1.234246f,0.8426337f,0.5913202f,-0.5187503f,0.3922408f,-0.47685f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448368f,1.364936f,0.7847337f,-0.7099919f,0.01438849f,0.02887753f,0.7034705f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 1.846989f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 1.846989f);
Get(0xDD1E).SetLocalPose(1.464541f,1.234717f,0.8426459f,0.5908307f,-0.5193207f,0.3923506f,-0.4767453f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448407f,1.364895f,0.7847487f,-0.7099882f,0.01439692f,0.02889475f,0.7034733f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 1.863655f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 1.863655f);
Get(0xDD1E).SetLocalPose(1.464261f,1.234892f,0.8424868f,0.590524f,-0.5196052f,0.3924226f,-0.4767562f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448359f,1.364892f,0.784587f,-0.7100035f,0.0143685f,0.02886944f,0.7034595f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 1.880365f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 1.880365f);
Get(0xDD1E).SetLocalPose(1.4645f,1.236142f,0.8428091f,0.5904022f,-0.5197233f,0.392401f,-0.4767961f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448397f,1.365049f,0.7846092f,-0.7100018f,0.01434186f,0.02889805f,0.7034606f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 1.89718f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 1.89718f);
Get(0xDD1E).SetLocalPose(1.464027f,1.237179f,0.8429193f,0.5903174f,-0.5199232f,0.3924674f,-0.4766285f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448406f,1.365076f,0.7846965f,-0.710007f,0.01432415f,0.02886829f,0.703457f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 1.913353f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 1.913353f);
Get(0xDD1E).SetLocalPose(1.464082f,1.237508f,0.8429734f,0.5899822f,-0.520328f,0.39293f,-0.4762203f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448494f,1.364876f,0.7848922f,-0.7100192f,0.01430612f,0.02889282f,0.7034439f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 1.930018f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 1.930018f);
Get(0xDD1E).SetLocalPose(1.464308f,1.237521f,0.843444f,0.5894091f,-0.5210072f,0.393488f,-0.4757264f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448338f,1.364984f,0.7847709f,-0.7100318f,0.01430422f,0.02888916f,0.7034314f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 1.946497f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 1.946497f);
Get(0xDD1E).SetLocalPose(1.464583f,1.237044f,0.8435234f,0.5890965f,-0.5214448f,0.3939102f,-0.4752847f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448285f,1.36505f,0.7847144f,-0.7100249f,0.01431788f,0.02886479f,0.7034391f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 1.963653f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 1.963653f);
Get(0xDD1E).SetLocalPose(1.465725f,1.236029f,0.8441249f,0.5892017f,-0.5215291f,0.3942266f,-0.4747992f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448221f,1.365072f,0.7847121f,-0.7100073f,0.0143341f,0.02885788f,0.7034569f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 1.980821f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 1.980821f);
Get(0xDD1E).SetLocalPose(1.465417f,1.236361f,0.8443024f,0.5890468f,-0.5217563f,0.3947158f,-0.4743351f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448251f,1.36515f,0.7848263f,-0.7100133f,0.01433233f,0.02884673f,0.7034513f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 1.997508f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 1.997508f);
Get(0xDD1E).SetLocalPose(1.465632f,1.236359f,0.8442577f,0.5886001f,-0.5221447f,0.395464f,-0.4738387f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448261f,1.365145f,0.7849627f,-0.7100035f,0.01441945f,0.02886928f,0.7034585f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 2.014566f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 2.014566f);
Get(0xDD1E).SetLocalPose(1.465532f,1.235897f,0.8440015f,0.5878153f,-0.5227245f,0.3962786f,-0.4734929f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448118f,1.365152f,0.7849067f,-0.7100055f,0.01440435f,0.02884744f,0.7034576f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 2.031714f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 2.031714f);
Get(0xDD1E).SetLocalPose(1.466156f,1.235698f,0.8441259f,0.5867209f,-0.523541f,0.3974109f,-0.4729989f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447961f,1.365194f,0.7847921f,-0.7100047f,0.01440324f,0.02881857f,0.7034596f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 2.049569f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 2.049569f);
Get(0xDD1E).SetLocalPose(1.466184f,1.236019f,0.844196f,0.5853972f,-0.524568f,0.3989573f,-0.4721988f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447905f,1.365189f,0.7846457f,-0.7100089f,0.01441366f,0.02883148f,0.7034546f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 2.057461f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 2.057461f);
Get(0xDD1E).SetLocalPose(1.466271f,1.236358f,0.8440376f,0.5849245f,-0.5249829f,0.3996223f,-0.4717608f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447901f,1.365192f,0.7847182f,-0.7100015f,0.01442323f,0.02886089f,0.7034608f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 2.076012f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 2.076012f);
Get(0xDD1E).SetLocalPose(1.466253f,1.236821f,0.8439345f,0.5841652f,-0.5259428f,0.4014467f,-0.4700806f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447711f,1.365243f,0.7846963f,-0.7100005f,0.0143923f,0.02884889f,0.7034628f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 2.094116f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 2.094116f);
Get(0xDD1E).SetLocalPose(1.465935f,1.236368f,0.8439185f,0.5834807f,-0.5273798f,0.4039718f,-0.4671485f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447943f,1.364984f,0.784874f,-0.7100109f,0.01438399f,0.02885342f,0.7034523f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 2.11157f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 2.11157f);
Get(0xDD1E).SetLocalPose(1.465305f,1.235725f,0.844165f,0.5815051f,-0.5309251f,0.4092675f,-0.4609453f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447822f,1.364882f,0.7848281f,-0.7100054f,0.0144165f,0.02881816f,0.7034586f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 2.129206f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 2.129206f);
Get(0xDD1E).SetLocalPose(1.464644f,1.235581f,0.8443873f,0.5797436f,-0.5339459f,0.4140381f,-0.4553808f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448027f,1.364759f,0.7849396f,-0.7099984f,0.01440572f,0.02885963f,0.7034642f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 2.147505f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 2.147505f);
Get(0xDD1E).SetLocalPose(1.464677f,1.235303f,0.8440913f,0.5796222f,-0.5356481f,0.4163343f,-0.4514253f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448f,1.364754f,0.7848232f,-0.7100237f,0.01439571f,0.02885005f,0.7034393f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 2.165241f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 2.165241f);
Get(0xDD1E).SetLocalPose(1.464767f,1.2349f,0.8437178f,0.5797001f,-0.5363339f,0.4163552f,-0.450491f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44804f,1.364813f,0.7847586f,-0.7100065f,0.01438921f,0.02886076f,0.7034563f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 2.173861f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 2.173861f);
Get(0xDD1E).SetLocalPose(1.464731f,1.234988f,0.8437303f,0.579931f,-0.5363009f,0.4159811f,-0.4505787f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448027f,1.364882f,0.7848303f,-0.7100115f,0.01440323f,0.02883855f,0.7034519f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 2.192865f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 2.192865f);
Get(0xDD1E).SetLocalPose(1.465014f,1.23554f,0.8436928f,0.5806272f,-0.5360598f,0.41494f,-0.4509287f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447979f,1.364871f,0.7847453f,-0.7100021f,0.01443407f,0.0288337f,0.703461f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 2.211111f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 2.211111f);
Get(0xDD1E).SetLocalPose(1.464981f,1.235685f,0.843987f,0.5813764f,-0.5357392f,0.4143288f,-0.4509065f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447743f,1.364867f,0.7845466f,-0.710016f,0.01447077f,0.02880845f,0.7034472f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 2.229219f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 2.229219f);
Get(0xDD1E).SetLocalPose(1.4652f,1.236716f,0.8441346f,0.5816672f,-0.5355348f,0.4143126f,-0.4507892f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447697f,1.364931f,0.7845001f,-0.7100146f,0.01444215f,0.02881673f,0.7034489f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 2.24779f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 2.24779f);
Get(0xDD1E).SetLocalPose(1.464905f,1.236315f,0.8441148f,0.5818323f,-0.5353472f,0.4144344f,-0.4506871f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447424f,1.364859f,0.7845003f,-0.7099995f,0.01446802f,0.02880535f,0.7034641f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 2.2568f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 2.2568f);
Get(0xDD1E).SetLocalPose(1.464484f,1.236517f,0.8441974f,0.5819263f,-0.5352388f,0.4143717f,-0.450752f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447522f,1.364895f,0.7843845f,-0.7099975f,0.01447091f,0.02883164f,0.703465f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 2.276845f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 2.276845f);
Get(0xDD1E).SetLocalPose(1.46451f,1.235868f,0.8445714f,0.581683f,-0.5352721f,0.4140528f,-0.4513193f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447665f,1.364953f,0.784476f,-0.7100014f,0.01442392f,0.02885259f,0.7034611f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 2.295349f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 2.295349f);
Get(0xDD1E).SetLocalPose(1.464481f,1.235415f,0.8445124f,0.5809171f,-0.5355552f,0.4139265f,-0.4520851f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447675f,1.36504f,0.7845362f,-0.7099842f,0.01447103f,0.02882296f,0.7034787f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 2.313638f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 2.313638f);
Get(0xDD1E).SetLocalPose(1.464923f,1.235686f,0.8444501f,0.5799843f,-0.5356763f,0.413655f,-0.4533859f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447599f,1.364979f,0.7845091f,-0.7099796f,0.01450282f,0.02881787f,0.7034829f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 2.331709f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 2.331709f);
Get(0xDD1E).SetLocalPose(1.465457f,1.2349f,0.8443766f,0.5800973f,-0.5353115f,0.4132887f,-0.4540059f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447529f,1.365045f,0.784445f,-0.7099826f,0.01447963f,0.0288102f,0.7034807f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 2.340801f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 2.340801f);
Get(0xDD1E).SetLocalPose(1.465791f,1.234274f,0.8446267f,0.5804688f,-0.5349679f,0.4131729f,-0.4540414f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447722f,1.364975f,0.7845792f,-0.7099886f,0.01443319f,0.02885387f,0.7034738f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 2.360159f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 2.360159f);
Get(0xDD1E).SetLocalPose(1.465958f,1.234602f,0.8445817f,0.5809876f,-0.5345697f,0.4132636f,-0.4537641f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447777f,1.364846f,0.7845293f,-0.7099805f,0.01444258f,0.02885711f,0.7034817f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 2.378461f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 2.378461f);
Get(0xDD1E).SetLocalPose(1.466019f,1.234087f,0.8448845f,0.5811789f,-0.5345566f,0.4134588f,-0.4533566f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447803f,1.364834f,0.7843295f,-0.709987f,0.01442982f,0.02885848f,0.7034752f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 2.397128f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 2.397128f);
Get(0xDD1E).SetLocalPose(1.465586f,1.234908f,0.8446881f,0.5804935f,-0.5350404f,0.4140025f,-0.4531678f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447775f,1.364935f,0.7843489f,-0.709993f,0.014432f,0.02885363f,0.7034694f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 2.416198f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 2.416198f);
Get(0xDD1E).SetLocalPose(1.465767f,1.234688f,0.8448464f,0.5797347f,-0.5353623f,0.4145935f,-0.4532187f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447775f,1.364946f,0.7843753f,-0.7099967f,0.0144355f,0.02884339f,0.7034661f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 2.424668f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 2.424668f);
Get(0xDD1E).SetLocalPose(1.46549f,1.23488f,0.8449329f,0.5795852f,-0.5353421f,0.4148997f,-0.4531535f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447921f,1.365002f,0.7846449f,-0.7099878f,0.01442694f,0.02885124f,0.7034749f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 2.444207f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 2.444207f);
Get(0xDD1E).SetLocalPose(1.4654f,1.234764f,0.8449852f,0.5797688f,-0.5351287f,0.4150473f,-0.4530355f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44802f,1.365018f,0.7846649f,-0.7100006f,0.01440747f,0.02887014f,0.7034615f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 2.46273f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 2.46273f);
Get(0xDD1E).SetLocalPose(1.465522f,1.234266f,0.8452325f,0.5803041f,-0.5347816f,0.4150433f,-0.4527636f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447874f,1.364968f,0.7844261f,-0.7099952f,0.01440036f,0.02885652f,0.7034677f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 2.482548f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 2.482548f);
Get(0xDD1E).SetLocalPose(1.465113f,1.234718f,0.8450215f,0.5802343f,-0.5349088f,0.4152568f,-0.452507f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448055f,1.364962f,0.7846184f,-0.7099925f,0.0143888f,0.02885942f,0.7034705f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 2.491062f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 2.491062f);
Get(0xDD1E).SetLocalPose(1.464821f,1.234976f,0.8450743f,0.5799968f,-0.5350435f,0.4154398f,-0.4524842f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448139f,1.364958f,0.7847383f,-0.7099927f,0.01440443f,0.02887825f,0.7034692f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 2.510759f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 2.510759f);
Get(0xDD1E).SetLocalPose(1.465106f,1.234607f,0.8450826f,0.5797622f,-0.5350035f,0.41566f,-0.4526299f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448157f,1.364994f,0.7848383f,-0.7100246f,0.01439501f,0.02888421f,0.703437f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 2.52957f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 2.52957f);
Get(0xDD1E).SetLocalPose(1.465825f,1.234392f,0.8451775f,0.5797164f,-0.5348911f,0.4160211f,-0.4524896f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448185f,1.36505f,0.784849f,-0.7100176f,0.01439795f,0.0289007f,0.7034433f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 2.547732f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 2.547732f);
Get(0xDD1E).SetLocalPose(1.465985f,1.234665f,0.8449556f,0.5795781f,-0.5348708f,0.4166465f,-0.4521152f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448152f,1.365081f,0.7850326f,-0.7100489f,0.014401f,0.02887917f,0.7034126f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 2.566093f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 2.566093f);
Get(0xDD1E).SetLocalPose(1.466064f,1.234486f,0.8443307f,0.5792847f,-0.53501f,0.4169258f,-0.4520692f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44809f,1.365142f,0.7849554f,-0.7100422f,0.01440665f,0.02889011f,0.7034187f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 2.57486f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 2.57486f);
Get(0xDD1E).SetLocalPose(1.465892f,1.234957f,0.8442212f,0.5789228f,-0.5352201f,0.4169889f,-0.4522257f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448148f,1.365037f,0.7848246f,-0.7100269f,0.01439896f,0.02889486f,0.7034341f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 2.594113f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 2.594113f);
Get(0xDD1E).SetLocalPose(1.466208f,1.23438f,0.8441055f,0.5784183f,-0.5354466f,0.4170525f,-0.4525443f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44809f,1.365117f,0.7847906f,-0.7100405f,0.01436646f,0.02884065f,0.7034234f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 2.612095f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 2.612095f);
Get(0xDD1E).SetLocalPose(1.466745f,1.234124f,0.8444862f,0.5784582f,-0.535291f,0.417213f,-0.4525295f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448106f,1.365018f,0.7849901f,-0.7100397f,0.01437057f,0.02885661f,0.7034234f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 2.630364f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 2.630364f);
Get(0xDD1E).SetLocalPose(1.467105f,1.234018f,0.8445578f,0.5785528f,-0.5351544f,0.4176078f,-0.4522057f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448045f,1.364971f,0.784921f,-0.710027f,0.01442143f,0.02884319f,0.7034357f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 2.649248f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 2.649248f);
Get(0xDD1E).SetLocalPose(1.466854f,1.234704f,0.8443354f,0.5787227f,-0.5350801f,0.4180015f,-0.4517123f);
});
r.Add(delegate{
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 2.657714f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 2.657714f);
Get(0xDD1E).SetLocalPose(1.46656f,1.235217f,0.8441939f,0.5787351f,-0.5351037f,0.4181097f,-0.4515685f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447762f,1.365189f,0.7845793f,-0.7100023f,0.0144159f,0.02882389f,0.7034615f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 2.67799f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 2.67799f);
Get(0xDD1E).SetLocalPose(1.4664f,1.235516f,0.8435469f,0.5784993f,-0.5352978f,0.4182321f,-0.4515271f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447624f,1.365187f,0.7845763f,-0.7100079f,0.01442787f,0.02881997f,0.7034559f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 2.69634f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 2.69634f);
Get(0xDD1E).SetLocalPose(1.466035f,1.23528f,0.8429487f,0.5778865f,-0.5355581f,0.4182619f,-0.4519755f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447628f,1.364996f,0.7845996f,-0.7099972f,0.01443199f,0.02885688f,0.703465f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 2.715001f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 2.715001f);
Get(0xDD1E).SetLocalPose(1.465865f,1.235219f,0.8426715f,0.5773735f,-0.5356491f,0.4181888f,-0.4525905f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447541f,1.364917f,0.7847255f,-0.7100132f,0.0144266f,0.02882048f,0.7034504f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 2.723691f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 2.723691f);
Get(0xDD1E).SetLocalPose(1.465807f,1.235793f,0.8432355f,0.5773719f,-0.5355614f,0.4180986f,-0.4527795f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447432f,1.364867f,0.7847112f,-0.709997f,0.01443851f,0.02880869f,0.703467f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 2.743227f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 2.743227f);
Get(0xDD1E).SetLocalPose(1.466394f,1.235403f,0.8432456f,0.5777039f,-0.5352098f,0.4178583f,-0.4529936f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447475f,1.36484f,0.7847024f,-0.7099766f,0.01444445f,0.02883006f,0.7034867f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 2.76128f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 2.76128f);
Get(0xDD1E).SetLocalPose(1.466969f,1.235377f,0.8432601f,0.5779217f,-0.5350198f,0.4179989f,-0.4528104f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447548f,1.36484f,0.7847185f,-0.709984f,0.01445009f,0.02878943f,0.7034807f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 2.78001f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 2.78001f);
Get(0xDD1E).SetLocalPose(1.46749f,1.234992f,0.8431796f,0.5774074f,-0.5353025f,0.4185366f,-0.4526357f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.4479f,1.364596f,0.7846986f,-0.7100323f,0.01438396f,0.02884635f,0.703431f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 2.797866f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 2.797866f);
Get(0xDD1E).SetLocalPose(1.467324f,1.235405f,0.8430555f,0.5769285f,-0.5354999f,0.4189434f,-0.4526365f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447896f,1.364888f,0.7847559f,-0.7100217f,0.01441371f,0.02884676f,0.703441f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 2.816606f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 2.816606f);
Get(0xDD1E).SetLocalPose(1.467488f,1.235503f,0.8430454f,0.5766526f,-0.5354483f,0.4190315f,-0.4529675f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447903f,1.364887f,0.784736f,-0.7100235f,0.01437983f,0.02883692f,0.7034403f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 2.8249f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 2.8249f);
Get(0xDD1E).SetLocalPose(1.46755f,1.235498f,0.8429765f,0.5765659f,-0.5353836f,0.4190639f,-0.4531243f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448097f,1.364951f,0.7848287f,-0.7100318f,0.01437841f,0.02884081f,0.7034318f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 2.844286f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 2.844286f);
Get(0xDD1E).SetLocalPose(1.467673f,1.235397f,0.8425366f,0.5764694f,-0.5353651f,0.4191454f,-0.4531938f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448136f,1.364908f,0.7847572f,-0.7100211f,0.01436712f,0.02884964f,0.7034425f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 2.862837f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 2.862837f);
Get(0xDD1E).SetLocalPose(1.467285f,1.235362f,0.8429065f,0.5762537f,-0.5354691f,0.4195015f,-0.4530156f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448432f,1.364974f,0.7848654f,-0.7100298f,0.01436073f,0.02886532f,0.7034332f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 2.880893f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 2.880893f);
Get(0xDD1E).SetLocalPose(1.467338f,1.234496f,0.842909f,0.5760315f,-0.5356026f,0.4199706f,-0.4527054f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448434f,1.365077f,0.7847728f,-0.7100168f,0.01436647f,0.02887869f,0.7034457f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 2.898883f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 2.898883f);
Get(0xDD1E).SetLocalPose(1.467315f,1.234954f,0.8425685f,0.57592f,-0.5356224f,0.4202459f,-0.4525686f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448328f,1.365026f,0.7848187f,-0.7100359f,0.01435942f,0.02887228f,0.7034269f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 2.906888f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 2.906888f);
Get(0xDD1E).SetLocalPose(1.46741f,1.234934f,0.8425093f,0.5758248f,-0.5356067f,0.4203312f,-0.452629f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448267f,1.365032f,0.7849563f,-0.7100485f,0.01433936f,0.02887352f,0.7034145f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 2.926391f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 2.926391f);
Get(0xDD1E).SetLocalPose(1.467216f,1.23501f,0.8420247f,0.5754372f,-0.5356328f,0.4204904f,-0.4529429f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448277f,1.365073f,0.7850101f,-0.7100318f,0.01432227f,0.02887282f,0.7034317f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 2.944235f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 2.944235f);
Get(0xDD1E).SetLocalPose(1.467289f,1.235835f,0.842052f,0.5750968f,-0.5357412f,0.4206511f,-0.4530979f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448174f,1.365146f,0.7850905f,-0.7100545f,0.01432272f,0.02888604f,0.7034082f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 2.96252f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 2.96252f);
Get(0xDD1E).SetLocalPose(1.467185f,1.235677f,0.8421177f,0.5749006f,-0.5358903f,0.4205879f,-0.4532292f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448126f,1.365211f,0.7850767f,-0.710032f,0.01434453f,0.02886558f,0.7034314f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 2.980704f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 2.980704f);
Get(0xDD1E).SetLocalPose(1.46749f,1.235808f,0.8427751f,0.5753301f,-0.5355608f,0.4202568f,-0.4533809f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448088f,1.365256f,0.7850929f,-0.7100489f,0.01436307f,0.02886772f,0.7034138f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 2.998963f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 2.998963f);
Get(0xDD1E).SetLocalPose(1.467383f,1.235589f,0.8427071f,0.5759557f,-0.5349567f,0.4198457f,-0.4536806f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448218f,1.36512f,0.7851056f,-0.7100368f,0.01436078f,0.02886412f,0.7034262f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 3.007522f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 3.007522f);
Get(0xDD1E).SetLocalPose(1.467156f,1.23553f,0.8421563f,0.5761378f,-0.5346524f,0.4197094f,-0.453934f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448046f,1.365111f,0.7849213f,-0.71003f,0.0143528f,0.02885813f,0.7034335f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 3.026484f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 3.026484f);
Get(0xDD1E).SetLocalPose(1.46735f,1.236682f,0.8422329f,0.5761393f,-0.5344022f,0.4193619f,-0.4545475f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448067f,1.365019f,0.784779f,-0.7100189f,0.01435904f,0.02885207f,0.7034448f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 3.04477f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 3.04477f);
Get(0xDD1E).SetLocalPose(1.467774f,1.238129f,0.8426504f,0.5758049f,-0.5342023f,0.418752f,-0.4557669f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448175f,1.36477f,0.7848476f,-0.7100417f,0.01434915f,0.0288542f,0.703422f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 3.06223f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 3.06223f);
Get(0xDD1E).SetLocalPose(1.468162f,1.238871f,0.8429826f,0.5755369f,-0.5338203f,0.4183383f,-0.4569312f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44821f,1.364796f,0.7848492f,-0.7100344f,0.01436876f,0.02884901f,0.7034292f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 3.07957f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 3.07957f);
Get(0xDD1E).SetLocalPose(1.468585f,1.23865f,0.8433747f,0.5755938f,-0.5333051f,0.4181896f,-0.457597f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448308f,1.365043f,0.7849488f,-0.7100412f,0.01436896f,0.02885654f,0.703422f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 3.097629f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 3.097629f);
Get(0xDD1E).SetLocalPose(1.468787f,1.238988f,0.842872f,0.5756926f,-0.5326225f,0.418463f,-0.4580177f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448359f,1.365168f,0.7849214f,-0.7100391f,0.01435695f,0.02886101f,0.7034242f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 3.115947f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 3.115947f);
Get(0xDD1E).SetLocalPose(1.468552f,1.238998f,0.8424025f,0.575573f,-0.5324167f,0.4185146f,-0.4583597f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448244f,1.365279f,0.7848516f,-0.7100408f,0.01432449f,0.02886115f,0.703423f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 3.124048f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 3.124048f);
Get(0xDD1E).SetLocalPose(1.46787f,1.23934f,0.8427707f,0.5754709f,-0.5324701f,0.4184407f,-0.4584934f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448205f,1.365181f,0.7850022f,-0.7100261f,0.01434921f,0.02885852f,0.7034375f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 3.143634f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 3.143634f);
Get(0xDD1E).SetLocalPose(1.467229f,1.239655f,0.8427069f,0.5751624f,-0.5326403f,0.4182725f,-0.4588362f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448321f,1.365042f,0.7850451f,-0.7100268f,0.01432016f,0.0288472f,0.7034379f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 3.161532f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 3.161532f);
Get(0xDD1E).SetLocalPose(1.465543f,1.239299f,0.8426906f,0.575074f,-0.5327381f,0.4179577f,-0.4591202f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448315f,1.36499f,0.7849703f,-0.710015f,0.0143428f,0.02884744f,0.7034493f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 3.179236f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 3.179236f);
Get(0xDD1E).SetLocalPose(1.464542f,1.238719f,0.8425708f,0.5753117f,-0.532733f,0.4173593f,-0.4593727f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448405f,1.364955f,0.7850042f,-0.7100345f,0.01429146f,0.02887931f,0.7034293f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 3.197558f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 3.197558f);
Get(0xDD1E).SetLocalPose(1.463459f,1.238964f,0.8427042f,0.5756346f,-0.5328618f,0.4169718f,-0.4591706f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448579f,1.364943f,0.7850574f,-0.7100453f,0.01431759f,0.02886125f,0.7034187f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 3.215482f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 3.215482f);
Get(0xDD1E).SetLocalPose(1.462608f,1.238962f,0.8420337f,0.5759616f,-0.5331438f,0.4164284f,-0.4589263f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448595f,1.364954f,0.785143f,-0.7100495f,0.01431059f,0.02888204f,0.7034137f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 3.233272f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 3.233272f);
Get(0xDD1E).SetLocalPose(1.461686f,1.239116f,0.8413826f,0.5761652f,-0.5337111f,0.4157691f,-0.458609f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448575f,1.364941f,0.7852012f,-0.710046f,0.01431602f,0.02886097f,0.703418f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 3.241939f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 3.241939f);
Get(0xDD1E).SetLocalPose(1.461362f,1.238761f,0.8408635f,0.57622f,-0.53416f,0.4152338f,-0.4585025f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448452f,1.364961f,0.7852623f,-0.7100564f,0.0143431f,0.02886911f,0.7034066f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 3.260879f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 3.260879f);
Get(0xDD1E).SetLocalPose(1.460389f,1.238697f,0.8406371f,0.5763988f,-0.5346611f,0.4145595f,-0.458304f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448455f,1.364899f,0.7853037f,-0.7100524f,0.01435298f,0.0288852f,0.7034099f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 3.278982f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 3.278982f);
Get(0xDD1E).SetLocalPose(1.45901f,1.238452f,0.8405699f,0.5770056f,-0.5349767f,0.4135526f,-0.4580817f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448297f,1.364912f,0.7852502f,-0.7100601f,0.01435825f,0.02883917f,0.7034038f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 3.296524f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 3.296524f);
Get(0xDD1E).SetLocalPose(1.458055f,1.239344f,0.8404521f,0.5778987f,-0.5350983f,0.4126119f,-0.4576619f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448183f,1.365034f,0.7850289f,-0.7100331f,0.01436086f,0.02883744f,0.703431f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 3.31411f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 3.31411f);
Get(0xDD1E).SetLocalPose(1.457517f,1.239852f,0.8399376f,0.5784566f,-0.5354435f,0.4119656f,-0.4571353f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448082f,1.365043f,0.7849709f,-0.7100226f,0.01436446f,0.02886086f,0.7034406f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 3.331753f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 3.331753f);
Get(0xDD1E).SetLocalPose(1.457531f,1.240461f,0.8398096f,0.5785221f,-0.5361605f,0.4114288f,-0.4566951f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448079f,1.365081f,0.7848769f,-0.7100466f,0.01436839f,0.02881698f,0.7034182f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 3.349559f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 3.349559f);
Get(0xDD1E).SetLocalPose(1.456729f,1.240943f,0.8389466f,0.5785115f,-0.5367939f,0.4108456f,-0.4564894f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448081f,1.365045f,0.7848781f,-0.710053f,0.01436827f,0.02884423f,0.7034106f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 3.357569f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 3.357569f);
Get(0xDD1E).SetLocalPose(1.456279f,1.241434f,0.8390149f,0.5787339f,-0.5370631f,0.4103375f,-0.456348f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448218f,1.364862f,0.7849413f,-0.7100698f,0.01434973f,0.0288535f,0.7033935f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 3.377383f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 3.377383f);
Get(0xDD1E).SetLocalPose(1.454737f,1.241644f,0.8393349f,0.5791078f,-0.5374115f,0.4096788f,-0.4560553f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448372f,1.364933f,0.7851561f,-0.7100804f,0.01430732f,0.02885331f,0.7033837f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 3.395172f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 3.395172f);
Get(0xDD1E).SetLocalPose(1.453202f,1.242287f,0.8392752f,0.5796572f,-0.5378028f,0.4090375f,-0.4554713f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448372f,1.364931f,0.7851676f,-0.7100919f,0.01429235f,0.0288355f,0.7033732f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 3.412798f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 3.412798f);
Get(0xDD1E).SetLocalPose(1.452492f,1.241536f,0.8389375f,0.5800443f,-0.5382441f,0.4086097f,-0.4548407f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448441f,1.364962f,0.7851143f,-0.7100701f,0.01428638f,0.02886374f,0.7033942f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 3.42123f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 3.42123f);
Get(0xDD1E).SetLocalPose(1.451957f,1.241712f,0.8387511f,0.5801787f,-0.5386414f,0.4084037f,-0.4543837f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448344f,1.365033f,0.7852615f,-0.7100582f,0.01431495f,0.02882632f,0.7034071f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 3.437393f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 3.437393f);
Get(0xDD1E).SetLocalPose(1.450734f,1.242048f,0.8391526f,0.5802102f,-0.5396504f,0.4080221f,-0.4534882f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44843f,1.365017f,0.7853397f,-0.7100719f,0.01432319f,0.02884826f,0.7033921f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 3.462259f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 3.462259f);
Get(0xDD1E).SetLocalPose(1.44966f,1.241339f,0.8389668f,0.5800877f,-0.5404059f,0.4076045f,-0.4531206f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448394f,1.365134f,0.7853327f,-0.7100567f,0.01429868f,0.02886755f,0.7034072f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 3.480505f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 3.480505f);
Get(0xDD1E).SetLocalPose(1.448668f,1.240558f,0.8387442f,0.5800685f,-0.5407882f,0.4070134f,-0.4532204f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448432f,1.36507f,0.7852663f,-0.7100442f,0.01432974f,0.02885279f,0.7034199f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 3.498709f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 3.498709f);
Get(0xDD1E).SetLocalPose(1.447385f,1.241804f,0.8380559f,0.5803497f,-0.5409903f,0.4064576f,-0.453118f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448468f,1.364949f,0.7852253f,-0.7100421f,0.01434009f,0.02885826f,0.7034215f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 3.507048f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 3.507048f);
Get(0xDD1E).SetLocalPose(1.446937f,1.242075f,0.8375968f,0.5806218f,-0.5410982f,0.4060983f,-0.4529627f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448361f,1.364823f,0.7851384f,-0.7100344f,0.01438758f,0.02885507f,0.7034285f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 3.52646f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 3.52646f);
Get(0xDD1E).SetLocalPose(1.445912f,1.242765f,0.8373104f,0.5808985f,-0.5414233f,0.405785f,-0.4525002f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448299f,1.364891f,0.7850329f,-0.710035f,0.01431898f,0.02881584f,0.7034309f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 3.544419f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 3.544419f);
Get(0xDD1E).SetLocalPose(1.445559f,1.242785f,0.8368946f,0.580623f,-0.5423074f,0.4055135f,-0.4520382f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448118f,1.364977f,0.7848346f,-0.7100322f,0.0143305f,0.02884052f,0.7034325f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 3.562664f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 3.562664f);
Get(0xDD1E).SetLocalPose(1.444757f,1.243129f,0.836351f,0.580164f,-0.5432213f,0.4053119f,-0.4517109f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448114f,1.365155f,0.7848294f,-0.7100365f,0.01430953f,0.02883461f,0.7034288f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 3.580152f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 3.580152f);
Get(0xDD1E).SetLocalPose(1.444273f,1.243535f,0.8357409f,0.5803294f,-0.5435008f,0.4049472f,-0.4514892f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448403f,1.365214f,0.7850345f,-0.7100489f,0.01430168f,0.02885285f,0.7034157f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 3.598084f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 3.598084f);
Get(0xDD1E).SetLocalPose(1.443625f,1.24355f,0.8352561f,0.5806053f,-0.5437939f,0.4045389f,-0.4511476f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448492f,1.365271f,0.7851368f,-0.7100639f,0.01428976f,0.02886564f,0.7034003f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 3.616105f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 3.616105f);
Get(0xDD1E).SetLocalPose(1.442979f,1.244113f,0.8348273f,0.5805933f,-0.5442548f,0.4044914f,-0.4506495f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448594f,1.365138f,0.7851388f,-0.7100544f,0.01424313f,0.02889192f,0.7034097f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 3.624498f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 3.624498f);
Get(0xDD1E).SetLocalPose(1.44275f,1.243854f,0.8348323f,0.5804176f,-0.5445674f,0.4046153f,-0.4503868f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448678f,1.365172f,0.785165f,-0.7100612f,0.01423166f,0.0288864f,0.7034033f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 3.643685f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 3.643685f);
Get(0xDD1E).SetLocalPose(1.442223f,1.244371f,0.8346681f,0.5798684f,-0.5452032f,0.4048968f,-0.450072f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448573f,1.365233f,0.7850462f,-0.710036f,0.01428976f,0.0288841f,0.7034276f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 3.661772f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 3.661772f);
Get(0xDD1E).SetLocalPose(1.44167f,1.245025f,0.8344444f,0.5794446f,-0.5456004f,0.4048557f,-0.4501733f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448487f,1.365232f,0.785026f,-0.7100352f,0.01427097f,0.02889621f,0.7034283f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 3.679417f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 3.679417f);
Get(0xDD1E).SetLocalPose(1.442345f,1.246449f,0.8343862f,0.5790603f,-0.5458574f,0.4045013f,-0.4506746f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448646f,1.365239f,0.7850361f,-0.7100458f,0.01424306f,0.02885731f,0.7034198f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 3.697476f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 3.697476f);
Get(0xDD1E).SetLocalPose(1.441996f,1.247379f,0.834553f,0.5789402f,-0.5459043f,0.4039567f,-0.4512603f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448667f,1.365272f,0.7849625f,-0.7100108f,0.01427632f,0.02888328f,0.7034534f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 3.715995f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 3.715995f);
Get(0xDD1E).SetLocalPose(1.441675f,1.248276f,0.8343567f,0.5787377f,-0.5460329f,0.4033076f,-0.4519445f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448596f,1.365249f,0.7849486f,-0.710018f,0.01427719f,0.02885192f,0.7034474f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 3.724305f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 3.724305f);
Get(0xDD1E).SetLocalPose(1.441664f,1.248599f,0.8344393f,0.5785232f,-0.5462f,0.4031805f,-0.4521306f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448732f,1.365048f,0.78514f,-0.7100352f,0.01430739f,0.02884312f,0.7034298f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 3.743698f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 3.743698f);
Get(0xDD1E).SetLocalPose(1.442084f,1.249449f,0.8344632f,0.5780947f,-0.5465423f,0.4030521f,-0.4523793f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448728f,1.365004f,0.7850199f,-0.7100083f,0.01430617f,0.02886252f,0.7034562f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 3.761732f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 3.761732f);
Get(0xDD1E).SetLocalPose(1.441684f,1.249416f,0.8341401f,0.5775936f,-0.5468167f,0.4027005f,-0.4530005f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448566f,1.364965f,0.7850331f,-0.7100139f,0.01429905f,0.0288554f,0.7034509f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 3.779525f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 3.779525f);
Get(0xDD1E).SetLocalPose(1.441432f,1.250425f,0.8339331f,0.5772989f,-0.5470622f,0.4021364f,-0.4535804f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448465f,1.365161f,0.7851592f,-0.7100397f,0.01431214f,0.02885094f,0.7034249f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 3.798885f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 3.798885f);
Get(0xDD1E).SetLocalPose(1.441646f,1.25141f,0.8336648f,0.5769656f,-0.5474003f,0.4014519f,-0.4542026f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448386f,1.36509f,0.7850659f,-0.7100368f,0.01431642f,0.02885677f,0.7034274f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 3.807097f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 3.807097f);
Get(0xDD1E).SetLocalPose(1.441803f,1.252239f,0.8334551f,0.5768179f,-0.547574f,0.4012603f,-0.4543501f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448303f,1.365144f,0.7849077f,-0.7100105f,0.01432385f,0.02886331f,0.7034536f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 3.826613f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 3.826613f);
Get(0xDD1E).SetLocalPose(1.441949f,1.253094f,0.8330387f,0.5765435f,-0.5476866f,0.4011853f,-0.4546289f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448225f,1.365096f,0.7848352f,-0.7100233f,0.01433246f,0.02882892f,0.7034419f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 3.844669f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 3.844669f);
Get(0xDD1E).SetLocalPose(1.44148f,1.253912f,0.8323163f,0.5761814f,-0.5478926f,0.4013028f,-0.454736f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448137f,1.365034f,0.7848223f,-0.7100181f,0.01434382f,0.02882265f,0.7034471f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 3.863258f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 3.863258f);
Get(0xDD1E).SetLocalPose(1.441488f,1.254702f,0.8315274f,0.5757304f,-0.5481175f,0.4011389f,-0.4551806f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448133f,1.36507f,0.7848311f,-0.7099947f,0.01433072f,0.02887782f,0.7034687f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 3.880633f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 3.880633f);
Get(0xDD1E).SetLocalPose(1.441501f,1.255073f,0.8311126f,0.5753917f,-0.5482471f,0.4006353f,-0.4558957f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448216f,1.364911f,0.7848897f,-0.7100221f,0.01434968f,0.02884785f,0.7034419f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 3.898694f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 3.898694f);
Get(0xDD1E).SetLocalPose(1.442035f,1.255188f,0.8303459f,0.5749831f,-0.5482911f,0.4000317f,-0.4568872f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448201f,1.36489f,0.7848855f,-0.710009f,0.0143388f,0.02883743f,0.7034558f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 3.907037f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 3.907037f);
Get(0xDD1E).SetLocalPose(1.441858f,1.255598f,0.8306584f,0.574891f,-0.5483158f,0.3999436f,-0.4570505f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44822f,1.364965f,0.7849696f,-0.7100244f,0.01433538f,0.02883704f,0.7034405f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 3.926013f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 3.926013f);
Get(0xDD1E).SetLocalPose(1.441693f,1.254968f,0.8309975f,0.5749483f,-0.5482072f,0.3998867f,-0.4571587f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448146f,1.365002f,0.7848036f,-0.7100199f,0.01432673f,0.02882504f,0.7034456f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 3.943873f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 3.943873f);
Get(0xDD1E).SetLocalPose(1.441713f,1.254217f,0.8311597f,0.5751581f,-0.5481036f,0.3999002f,-0.4570072f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44819f,1.364843f,0.7848936f,-0.7100203f,0.01434786f,0.02885176f,0.7034436f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 3.961998f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 3.961998f);
Get(0xDD1E).SetLocalPose(1.441295f,1.253925f,0.8310429f,0.5754293f,-0.5480618f,0.3997937f,-0.4568089f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448107f,1.364929f,0.7848763f,-0.7100133f,0.01436911f,0.02881554f,0.7034517f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 3.979909f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 3.979909f);
Get(0xDD1E).SetLocalPose(1.440786f,1.253668f,0.8311981f,0.5756236f,-0.548113f,0.399385f,-0.4568602f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448014f,1.365084f,0.7847429f,-0.7100143f,0.01438264f,0.02880984f,0.7034507f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 3.99856f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 3.99856f);
Get(0xDD1E).SetLocalPose(1.440623f,1.253238f,0.8311809f,0.5757393f,-0.5481111f,0.3990437f,-0.4570151f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447997f,1.365183f,0.7846702f,-0.7100037f,0.01442505f,0.02881381f,0.7034603f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 4.016228f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 4.016228f);
Get(0xDD1E).SetLocalPose(1.44065f,1.253704f,0.8304524f,0.5760004f,-0.5479286f,0.3989865f,-0.4569546f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447934f,1.365178f,0.7846814f,-0.7100167f,0.01440229f,0.02881382f,0.7034477f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 4.024354f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 4.024354f);
Get(0xDD1E).SetLocalPose(1.440818f,1.25381f,0.8304978f,0.5763335f,-0.5477818f,0.3990031f,-0.4566963f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447948f,1.365153f,0.7847467f,-0.7100167f,0.01437449f,0.02881667f,0.7034482f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 4.043533f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 4.043533f);
Get(0xDD1E).SetLocalPose(1.441236f,1.253542f,0.8303158f,0.5766968f,-0.547669f,0.3991239f,-0.4562669f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447829f,1.365197f,0.7846825f,-0.7100011f,0.01437587f,0.02884125f,0.703463f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 4.062038f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 4.062038f);
Get(0xDD1E).SetLocalPose(1.441438f,1.254978f,0.8304651f,0.576977f,-0.547823f,0.3995431f,-0.4553601f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44795f,1.364883f,0.7848573f,-0.7099926f,0.01439606f,0.02883537f,0.7034714f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 4.081057f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 4.081057f);
Get(0xDD1E).SetLocalPose(1.440904f,1.254431f,0.8306557f,0.5767197f,-0.5483171f,0.4001163f,-0.4545875f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447854f,1.364929f,0.7848238f,-0.7100284f,0.01438906f,0.02883945f,0.7034351f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 4.099648f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 4.099648f);
Get(0xDD1E).SetLocalPose(1.440166f,1.254047f,0.8307368f,0.5763502f,-0.5487612f,0.4005979f,-0.4540958f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447788f,1.364923f,0.7846369f,-0.7100081f,0.01439373f,0.02882905f,0.7034558f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 4.107905f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 4.107905f);
Get(0xDD1E).SetLocalPose(1.439889f,1.253582f,0.8303448f,0.5764291f,-0.5487726f,0.4005031f,-0.4540655f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447688f,1.364954f,0.784765f,-0.7100143f,0.01441085f,0.02884423f,0.7034487f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 4.126573f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 4.126573f);
Get(0xDD1E).SetLocalPose(1.439421f,1.253503f,0.830347f,0.5769038f,-0.5485883f,0.4001452f,-0.4540009f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447766f,1.364957f,0.7847908f,-0.7100157f,0.01439707f,0.02884855f,0.7034475f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 4.144364f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 4.144364f);
Get(0xDD1E).SetLocalPose(1.438839f,1.253121f,0.8307505f,0.5776723f,-0.5482594f,0.3996935f,-0.4538189f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447888f,1.364743f,0.7847887f,-0.7100488f,0.0143837f,0.028827f,0.7034152f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 4.162252f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 4.162252f);
Get(0xDD1E).SetLocalPose(1.438846f,1.25274f,0.8311369f,0.5780432f,-0.5481967f,0.3995735f,-0.4535278f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447966f,1.364758f,0.784663f,-0.71005f,0.01438801f,0.0288306f,0.7034138f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 4.180389f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 4.180389f);
Get(0xDD1E).SetLocalPose(1.43832f,1.25218f,0.8318869f,0.5783901f,-0.5481299f,0.3998256f,-0.4529438f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448165f,1.364635f,0.7849491f,-0.710064f,0.01434566f,0.02880535f,0.7034015f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 4.198501f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 4.198501f);
Get(0xDD1E).SetLocalPose(1.438203f,1.252544f,0.8325489f,0.5786006f,-0.5482536f,0.3998268f,-0.452524f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448216f,1.364467f,0.7850442f,-0.7100907f,0.01437601f,0.02879153f,0.7033746f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 4.21638f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 4.21638f);
Get(0xDD1E).SetLocalPose(1.437516f,1.251458f,0.8330721f,0.5788205f,-0.5483131f,0.3996828f,-0.4522977f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448301f,1.364531f,0.7851713f,-0.7100582f,0.01437512f,0.02883094f,0.7034057f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 4.224535f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 4.224535f);
Get(0xDD1E).SetLocalPose(1.437206f,1.250963f,0.8334776f,0.5789495f,-0.548321f,0.3995129f,-0.4522733f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448327f,1.36461f,0.7852139f,-0.7100762f,0.01432939f,0.02879033f,0.7033901f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 4.24393f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 4.24393f);
Get(0xDD1E).SetLocalPose(1.436985f,1.251121f,0.8338037f,0.5792633f,-0.5482551f,0.3992997f,-0.4521395f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448182f,1.364811f,0.7853303f,-0.7100472f,0.01433461f,0.02881095f,0.7034184f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 4.261649f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 4.261649f);
Get(0xDD1E).SetLocalPose(1.436545f,1.250367f,0.8343646f,0.5795293f,-0.5482316f,0.3992782f,-0.451846f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448064f,1.365001f,0.7851689f,-0.710015f,0.0143412f,0.02881794f,0.7034505f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 4.279591f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 4.279591f);
Get(0xDD1E).SetLocalPose(1.436228f,1.24968f,0.8353736f,0.5796847f,-0.5482015f,0.3993321f,-0.4516354f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448026f,1.365199f,0.7849735f,-0.7100191f,0.01432832f,0.028838f,0.7034459f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 4.297985f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 4.297985f);
Get(0xDD1E).SetLocalPose(1.436102f,1.249668f,0.835835f,0.5799158f,-0.5480553f,0.3991517f,-0.4516757f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448177f,1.365138f,0.7850236f,-0.7100329f,0.01431881f,0.02883508f,0.7034323f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 4.316086f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 4.316086f);
Get(0xDD1E).SetLocalPose(1.435622f,1.249692f,0.8358918f,0.5800595f,-0.5480093f,0.3989356f,-0.4517379f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44816f,1.365202f,0.784912f,-0.7100224f,0.01432372f,0.02882458f,0.7034431f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 4.324242f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 4.324242f);
Get(0xDD1E).SetLocalPose(1.435128f,1.249857f,0.8362597f,0.5801063f,-0.5480024f,0.3989214f,-0.4516989f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448222f,1.365209f,0.7850548f,-0.7100476f,0.01433333f,0.02881631f,0.7034178f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 4.343186f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 4.343186f);
Get(0xDD1E).SetLocalPose(1.434932f,1.249214f,0.8367494f,0.5803466f,-0.5478833f,0.3987824f,-0.4516574f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448259f,1.365203f,0.7851464f,-0.7100347f,0.01435144f,0.02879743f,0.7034313f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 4.361444f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 4.361444f);
Get(0xDD1E).SetLocalPose(1.434394f,1.248712f,0.8368758f,0.5807825f,-0.5476317f,0.3985673f,-0.451592f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448113f,1.365143f,0.7851737f,-0.7100652f,0.01435955f,0.02878959f,0.7034006f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 4.381165f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 4.381165f);
Get(0xDD1E).SetLocalPose(1.434443f,1.248074f,0.8371107f,0.5810862f,-0.5474938f,0.3983715f,-0.4515414f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448301f,1.364931f,0.7851793f,-0.7100526f,0.01433861f,0.02882276f,0.7034124f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 4.399107f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 4.399107f);
Get(0xDD1E).SetLocalPose(1.434647f,1.248028f,0.8367211f,0.5811397f,-0.5475011f,0.3980228f,-0.451771f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448218f,1.364909f,0.7850876f,-0.7100462f,0.01433095f,0.02876967f,0.7034212f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 4.407081f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 4.407081f);
Get(0xDD1E).SetLocalPose(1.434217f,1.24841f,0.836466f,0.5811926f,-0.547507f,0.3978254f,-0.4518696f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448153f,1.365005f,0.7850004f,-0.7100218f,0.01435368f,0.0287534f,0.703446f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 4.42598f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 4.42598f);
Get(0xDD1E).SetLocalPose(1.434271f,1.24845f,0.8367656f,0.5814076f,-0.5474876f,0.3974109f,-0.4519814f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447998f,1.36502f,0.7849833f,-0.7100254f,0.01437366f,0.02875409f,0.7034421f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 4.443941f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 4.443941f);
Get(0xDD1E).SetLocalPose(1.434526f,1.248273f,0.8367985f,0.5815933f,-0.5474371f,0.3970295f,-0.4521386f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447994f,1.364853f,0.7848875f,-0.710001f,0.01434949f,0.02879008f,0.7034656f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 4.462122f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 4.462122f);
Get(0xDD1E).SetLocalPose(1.43446f,1.24879f,0.8372558f,0.5817479f,-0.547488f,0.3968234f,-0.4520591f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447971f,1.364794f,0.7848072f,-0.7100013f,0.01434068f,0.02882303f,0.7034642f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 4.480433f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 4.480433f);
Get(0xDD1E).SetLocalPose(1.433741f,1.249084f,0.8368139f,0.5818798f,-0.5475289f,0.3965592f,-0.4520718f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447965f,1.364816f,0.7848998f,-0.7100058f,0.01434496f,0.02884067f,0.7034588f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 4.489466f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 4.489466f);
Get(0xDD1E).SetLocalPose(1.433308f,1.249222f,0.8369603f,0.5819297f,-0.5475773f,0.3963374f,-0.4521433f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447984f,1.364957f,0.7848073f,-0.7100008f,0.01435133f,0.02884387f,0.7034636f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 4.51318f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 4.51318f);
Get(0xDD1E).SetLocalPose(1.432755f,1.249271f,0.836854f,0.5819557f,-0.5477256f,0.3960729f,-0.452162f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44785f,1.365055f,0.7846187f,-0.7099781f,0.01436026f,0.02884397f,0.7034863f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 4.522553f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 4.522553f);
Get(0xDD1E).SetLocalPose(1.432685f,1.249648f,0.8369592f,0.581985f,-0.5477911f,0.3959329f,-0.4521677f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447937f,1.364951f,0.7845789f,-0.7099919f,0.01437612f,0.02882831f,0.7034727f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 4.544477f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 4.544477f);
Get(0xDD1E).SetLocalPose(1.432902f,1.250388f,0.8373771f,0.5821294f,-0.5477855f,0.3955457f,-0.4523275f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447805f,1.365042f,0.7844718f,-0.7099887f,0.01440266f,0.0288043f,0.7034764f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 4.564391f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 4.564391f);
Get(0xDD1E).SetLocalPose(1.432993f,1.250355f,0.8373392f,0.5823659f,-0.5477263f,0.3951877f,-0.4524076f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447774f,1.365028f,0.7844548f,-0.7099863f,0.01439249f,0.0287819f,0.7034799f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 4.573322f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 4.573322f);
Get(0xDD1E).SetLocalPose(1.432794f,1.2504f,0.8375031f,0.5823678f,-0.5478332f,0.3950821f,-0.4523679f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447825f,1.364781f,0.7846922f,-0.7100167f,0.01436694f,0.02878118f,0.7034497f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 4.59616f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 4.59616f);
Get(0xDD1E).SetLocalPose(1.43233f,1.250238f,0.8374736f,0.5824218f,-0.5480928f,0.3948732f,-0.4521663f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447839f,1.364811f,0.7847474f,-0.7100307f,0.01434881f,0.02881682f,0.7034345f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 4.615349f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 4.615349f);
Get(0xDD1E).SetLocalPose(1.431783f,1.250634f,0.837563f,0.5824142f,-0.548398f,0.3948501f,-0.4518261f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447961f,1.364704f,0.7849393f,-0.7100362f,0.01433001f,0.02879472f,0.7034302f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 4.623847f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 4.623847f);
Get(0xDD1E).SetLocalPose(1.431546f,1.249898f,0.837909f,0.582381f,-0.548601f,0.3948717f,-0.4516034f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448218f,1.364809f,0.7851046f,-0.710039f,0.01430441f,0.02881601f,0.7034271f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 4.643372f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 4.643372f);
Get(0xDD1E).SetLocalPose(1.431683f,1.249598f,0.8382348f,0.5824769f,-0.5487337f,0.3947986f,-0.4513824f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448296f,1.364814f,0.785151f,-0.7100351f,0.01431235f,0.02884648f,0.7034296f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 4.66157f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 4.66157f);
Get(0xDD1E).SetLocalPose(1.431516f,1.249684f,0.8391864f,0.5827915f,-0.5488608f,0.3944985f,-0.4510841f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448228f,1.364961f,0.7851041f,-0.7100697f,0.01431425f,0.02884406f,0.7033948f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 4.680082f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 4.680082f);
Get(0xDD1E).SetLocalPose(1.431276f,1.249514f,0.8397042f,0.5829576f,-0.5490935f,0.3942682f,-0.4507876f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448196f,1.364997f,0.7849291f,-0.7100852f,0.01429453f,0.0288924f,0.7033775f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 4.698807f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 4.698807f);
Get(0xDD1E).SetLocalPose(1.430701f,1.248861f,0.8397358f,0.5828747f,-0.5494408f,0.3941991f,-0.450532f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448099f,1.365003f,0.7849037f,-0.7100894f,0.01428865f,0.0288766f,0.703374f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 4.707096f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 4.707096f);
Get(0xDD1E).SetLocalPose(1.430846f,1.248782f,0.8397859f,0.5828155f,-0.5496711f,0.3942175f,-0.4503116f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448039f,1.36489f,0.7848557f,-0.7101122f,0.01426654f,0.02890219f,0.7033505f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 4.726875f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 4.726875f);
Get(0xDD1E).SetLocalPose(1.430654f,1.248355f,0.8403521f,0.5828214f,-0.5499808f,0.3944035f,-0.4497624f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447924f,1.364828f,0.7846668f,-0.7101363f,0.0143031f,0.02896278f,0.7033228f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 4.745611f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 4.745611f);
Get(0xDD1E).SetLocalPose(1.430016f,1.247605f,0.8405627f,0.582962f,-0.5501815f,0.3944786f,-0.4492686f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448043f,1.364848f,0.7845487f,-0.7101613f,0.0144005f,0.028921f,0.7032974f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 4.764395f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 4.764395f);
Get(0xDD1E).SetLocalPose(1.429693f,1.247106f,0.840866f,0.5832963f,-0.5502079f,0.3943107f,-0.4489498f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448369f,1.364767f,0.7846215f,-0.710162f,0.01457259f,0.02880818f,0.7032978f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 4.78307f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 4.78307f);
Get(0xDD1E).SetLocalPose(1.42877f,1.246735f,0.8409868f,0.5831701f,-0.550496f,0.3944064f,-0.4486761f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448581f,1.364692f,0.7847793f,-0.7101758f,0.01463009f,0.02871035f,0.7032867f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 4.791784f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 4.791784f);
Get(0xDD1E).SetLocalPose(1.428641f,1.246851f,0.8406996f,0.5829654f,-0.5507165f,0.3944235f,-0.4486567f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448718f,1.36466f,0.7847903f,-0.7101721f,0.01466886f,0.02846072f,0.7032998f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 4.811789f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 4.811789f);
Get(0xDD1E).SetLocalPose(1.428509f,1.246797f,0.8411589f,0.5828139f,-0.5508818f,0.3944155f,-0.4486576f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448861f,1.364604f,0.7847744f,-0.7101951f,0.01470027f,0.0285378f,0.7032727f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 4.830989f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 4.830989f);
Get(0xDD1E).SetLocalPose(1.428119f,1.247306f,0.8411985f,0.583158f,-0.550659f,0.3941316f,-0.4487335f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448419f,1.364447f,0.7844836f,-0.7102833f,0.01452663f,0.02872434f,0.7031796f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 4.849162f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 4.849162f);
Get(0xDD1E).SetLocalPose(1.428053f,1.247658f,0.8410038f,0.5834876f,-0.5504683f,0.3940466f,-0.4486136f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448226f,1.364382f,0.7844046f,-0.7103481f,0.01437251f,0.02879025f,0.7031147f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 4.85751f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 4.85751f);
Get(0xDD1E).SetLocalPose(1.427879f,1.246808f,0.8411294f,0.5835101f,-0.5504873f,0.3940631f,-0.4485465f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44777f,1.364237f,0.78418f,-0.7105217f,0.01394393f,0.02904437f,0.7029374f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 4.87769f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 4.87769f);
Get(0xDD1E).SetLocalPose(1.427915f,1.247317f,0.8408853f,0.5832796f,-0.5507233f,0.3943003f,-0.4483481f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447693f,1.364235f,0.7841443f,-0.7106458f,0.013493f,0.0293998f,0.702806f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 4.896175f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 4.896175f);
Get(0xDD1E).SetLocalPose(1.427911f,1.247363f,0.8411711f,0.5829509f,-0.5509742f,0.3945186f,-0.4482754f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447391f,1.364625f,0.7839729f,-0.710685f,0.01316188f,0.02979989f,0.7027557f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 4.915134f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 4.915134f);
Get(0xDD1E).SetLocalPose(1.427946f,1.248115f,0.8415434f,0.5830541f,-0.5509682f,0.3943488f,-0.4482978f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447276f,1.364565f,0.7842752f,-0.7106699f,0.01302285f,0.02993035f,0.7027681f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 4.923602f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 4.923602f);
Get(0xDD1E).SetLocalPose(1.427937f,1.248587f,0.8417318f,0.5831765f,-0.5508647f,0.3942396f,-0.448362f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.446856f,1.364838f,0.7842204f,-0.7105771f,0.0129873f,0.02996209f,0.7028612f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 4.943545f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 4.943545f);
Get(0xDD1E).SetLocalPose(1.427936f,1.248331f,0.841929f,0.5834107f,-0.5506383f,0.3941339f,-0.4484284f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447321f,1.364918f,0.7846512f,-0.710338f,0.01322914f,0.02974532f,0.7031077f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 4.96293f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 4.96293f);
Get(0xDD1E).SetLocalPose(1.427379f,1.24745f,0.8422375f,0.583438f,-0.5506055f,0.3942284f,-0.44835f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447722f,1.364866f,0.7845354f,-0.7101724f,0.01357238f,0.02937871f,0.7032836f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 4.981929f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 4.981929f);
Get(0xDD1E).SetLocalPose(1.427395f,1.247628f,0.8423851f,0.583434f,-0.5506348f,0.3942716f,-0.448281f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447863f,1.364727f,0.7845545f,-0.7101173f,0.01375719f,0.02923371f,0.7033417f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 4.990366f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 4.990366f);
Get(0xDD1E).SetLocalPose(1.427131f,1.247805f,0.8422867f,0.5833843f,-0.5506862f,0.39428f,-0.4482753f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448406f,1.36487f,0.7844752f,-0.7100559f,0.01429294f,0.02893475f,0.7034053f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 5.010261f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 5.010261f);
Get(0xDD1E).SetLocalPose(1.426569f,1.247881f,0.8420896f,0.5832595f,-0.5508137f,0.3943514f,-0.4482183f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448518f,1.36481f,0.7844482f,-0.7101304f,0.01460528f,0.02854078f,0.7033398f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 5.028329f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 5.028329f);
Get(0xDD1E).SetLocalPose(1.426797f,1.247989f,0.8421379f,0.5832586f,-0.5508052f,0.3944698f,-0.4481257f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448642f,1.364656f,0.7840868f,-0.7102739f,0.01481155f,0.02836816f,0.7031977f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 5.046517f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 5.046517f);
Get(0xDD1E).SetLocalPose(1.427144f,1.247372f,0.8426037f,0.5834629f,-0.5506861f,0.3945636f,-0.4479234f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448502f,1.364463f,0.7837906f,-0.7104531f,0.01501648f,0.02841428f,0.7030104f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 5.06506f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 5.06506f);
Get(0xDD1E).SetLocalPose(1.426984f,1.246688f,0.8425477f,0.5837036f,-0.5505281f,0.3945132f,-0.4478486f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44827f,1.364405f,0.783585f,-0.7106171f,0.01484612f,0.02831079f,0.7028524f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 5.082974f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 5.082974f);
Get(0xDD1E).SetLocalPose(1.426973f,1.247107f,0.8424851f,0.5836585f,-0.5505808f,0.3945847f,-0.4477794f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447994f,1.364301f,0.7835045f,-0.7106938f,0.01474958f,0.02843329f,0.702772f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 5.091231f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 5.091231f);
Get(0xDD1E).SetLocalPose(1.426839f,1.247029f,0.8424682f,0.5835602f,-0.5506454f,0.394676f,-0.4477477f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447635f,1.364121f,0.7834114f,-0.7107269f,0.01467381f,0.02869862f,0.7027293f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 5.10995f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 5.10995f);
Get(0xDD1E).SetLocalPose(1.426867f,1.246254f,0.8424947f,0.5834381f,-0.5507534f,0.3947259f,-0.44773f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447295f,1.363906f,0.7834965f,-0.7106559f,0.01436504f,0.0289072f,0.702799f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 5.127828f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 5.127828f);
Get(0xDD1E).SetLocalPose(1.426886f,1.246838f,0.8424894f,0.5835316f,-0.5506741f,0.3948589f,-0.4475883f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447193f,1.363984f,0.7835259f,-0.7104974f,0.01416993f,0.02918038f,0.7029518f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 5.14563f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 5.14563f);
Get(0xDD1E).SetLocalPose(1.42688f,1.246863f,0.8425693f,0.5837669f,-0.5504998f,0.3948987f,-0.4474608f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447327f,1.363965f,0.7838578f,-0.7102845f,0.01390225f,0.02932107f,0.7031664f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 5.163495f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 5.163495f);
Get(0xDD1E).SetLocalPose(1.42701f,1.246477f,0.8431908f,0.5839646f,-0.5503794f,0.3948598f,-0.4473854f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447585f,1.364198f,0.7838104f,-0.7102121f,0.01371898f,0.02941897f,0.703239f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 5.181721f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 5.181721f);
Get(0xDD1E).SetLocalPose(1.42733f,1.245415f,0.8432063f,0.5838857f,-0.5503796f,0.3949868f,-0.447376f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447527f,1.364461f,0.7836928f,-0.7101941f,0.01363761f,0.02954035f,0.7032537f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 5.199203f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 5.199203f);
Get(0xDD1E).SetLocalPose(1.427706f,1.245415f,0.8433726f,0.5836557f,-0.5505048f,0.3951483f,-0.4473795f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447299f,1.36436f,0.7835126f,-0.7102027f,0.01358858f,0.02953698f,0.7032462f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 5.207775f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 5.207775f);
Get(0xDD1E).SetLocalPose(1.427777f,1.245337f,0.8437444f,0.5835531f,-0.5505487f,0.3952443f,-0.4473745f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447311f,1.364402f,0.7833692f,-0.7102627f,0.01365152f,0.02954532f,0.7031839f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 5.227209f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 5.227209f);
Get(0xDD1E).SetLocalPose(1.427734f,1.245388f,0.8439246f,0.5835766f,-0.5504962f,0.3952065f,-0.4474418f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.446932f,1.36434f,0.7832078f,-0.7103342f,0.01388988f,0.02947548f,0.70311f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 5.245258f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 5.245258f);
Get(0xDD1E).SetLocalPose(1.427786f,1.245555f,0.8438989f,0.5836987f,-0.5503431f,0.3951433f,-0.4475268f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447502f,1.364394f,0.782977f,-0.7104342f,0.01410239f,0.02911878f,0.7030196f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 5.263224f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 5.263224f);
Get(0xDD1E).SetLocalPose(1.427907f,1.245661f,0.8437876f,0.5837669f,-0.5501908f,0.3952529f,-0.4475281f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447919f,1.364373f,0.7833568f,-0.7105078f,0.0144146f,0.02894079f,0.7029461f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 5.281447f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 5.281447f);
Get(0xDD1E).SetLocalPose(1.428046f,1.244694f,0.8437098f,0.5836824f,-0.5501529f,0.3954189f,-0.4475382f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448179f,1.364255f,0.7833604f,-0.7105626f,0.01460373f,0.02858917f,0.7029012f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 5.299858f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 5.299858f);
Get(0xDD1E).SetLocalPose(1.428185f,1.245891f,0.8434923f,0.58364f,-0.5501933f,0.3954954f,-0.4474764f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44839f,1.364248f,0.7834936f,-0.7105936f,0.01466068f,0.02852395f,0.7028714f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 5.308033f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 5.308033f);
Get(0xDD1E).SetLocalPose(1.428293f,1.245996f,0.8434185f,0.5835966f,-0.5501636f,0.3955348f,-0.4475346f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448448f,1.36425f,0.7835493f,-0.7106043f,0.01481888f,0.02854696f,0.7028564f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 5.32696f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 5.32696f);
Get(0xDD1E).SetLocalPose(1.428702f,1.244968f,0.8434574f,0.5835629f,-0.5500573f,0.3955235f,-0.4477192f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448245f,1.364235f,0.7835088f,-0.71056f,0.01473216f,0.02852421f,0.7029039f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 5.344766f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 5.344766f);
Get(0xDD1E).SetLocalPose(1.42889f,1.245275f,0.8429416f,0.5835422f,-0.5498931f,0.3956011f,-0.4478793f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448037f,1.364095f,0.7835488f,-0.7105204f,0.01473692f,0.02872059f,0.7029358f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 5.362251f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 5.362251f);
Get(0xDD1E).SetLocalPose(1.429132f,1.245489f,0.8432144f,0.5835485f,-0.549755f,0.3955409f,-0.4480937f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447955f,1.363999f,0.783801f,-0.7104396f,0.01448698f,0.0288569f,0.7030171f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 5.380077f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 5.380077f);
Get(0xDD1E).SetLocalPose(1.429246f,1.24491f,0.8434516f,0.583391f,-0.5496672f,0.3954109f,-0.4485211f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447878f,1.364109f,0.7838917f,-0.7103848f,0.0144033f,0.02894684f,0.7030705f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 5.398558f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 5.398558f);
Get(0xDD1E).SetLocalPose(1.429231f,1.245578f,0.8434274f,0.5832912f,-0.5495988f,0.3953525f,-0.4487861f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447826f,1.364109f,0.7839524f,-0.7103173f,0.01432314f,0.02911329f,0.7031335f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 5.416313f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 5.416313f);
Get(0xDD1E).SetLocalPose(1.429262f,1.245674f,0.843258f,0.5832546f,-0.5495415f,0.3953922f,-0.4488689f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447737f,1.364292f,0.7838916f,-0.710322f,0.01421968f,0.02908398f,0.703132f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 5.425088f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 5.425088f);
Get(0xDD1E).SetLocalPose(1.429217f,1.245774f,0.8432937f,0.5832368f,-0.5494817f,0.3954812f,-0.4488869f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447639f,1.364347f,0.7837452f,-0.7103639f,0.01422573f,0.029112f,0.7030884f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 5.444094f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 5.444094f);
Get(0xDD1E).SetLocalPose(1.428598f,1.24587f,0.8425928f,0.5832449f,-0.5493766f,0.3956564f,-0.4488505f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447835f,1.364591f,0.7835236f,-0.7104596f,0.01423702f,0.02917987f,0.7029886f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 5.461902f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 5.461902f);
Get(0xDD1E).SetLocalPose(1.428391f,1.245539f,0.842489f,0.583165f,-0.5493879f,0.395864f,-0.4487574f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448063f,1.364504f,0.7833896f,-0.71052f,0.01422423f,0.02909969f,0.7029312f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 5.479576f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 5.479576f);
Get(0xDD1E).SetLocalPose(1.428411f,1.246055f,0.8422617f,0.5831391f,-0.5493125f,0.3958463f,-0.4488991f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448442f,1.364415f,0.7834002f,-0.7105632f,0.0144328f,0.02910948f,0.7028829f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 5.497441f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 5.497441f);
Get(0xDD1E).SetLocalPose(1.428391f,1.246395f,0.841984f,0.5831361f,-0.5492514f,0.3956166f,-0.4491799f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448554f,1.364405f,0.7834012f,-0.7106242f,0.01458003f,0.0289536f,0.7028246f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 5.515925f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 5.515925f);
Get(0xDD1E).SetLocalPose(1.428382f,1.245961f,0.841722f,0.5831242f,-0.5491297f,0.3955056f,-0.4494419f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448616f,1.364341f,0.7834812f,-0.7106613f,0.01461301f,0.0289035f,0.7027885f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 5.523866f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 5.523866f);
Get(0xDD1E).SetLocalPose(1.428418f,1.245955f,0.8416737f,0.5831451f,-0.5490616f,0.3955591f,-0.4494511f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448766f,1.364269f,0.7833292f,-0.7107865f,0.01468532f,0.02891977f,0.7026598f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 5.542418f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 5.542418f);
Get(0xDD1E).SetLocalPose(1.428662f,1.245793f,0.8414348f,0.5831234f,-0.5488986f,0.3958832f,-0.4493927f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448938f,1.364593f,0.7832661f,-0.7108738f,0.01465452f,0.02893668f,0.7025712f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 5.560332f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 5.560332f);
Get(0xDD1E).SetLocalPose(1.428895f,1.245028f,0.8415455f,0.5832306f,-0.5487688f,0.3960025f,-0.4493074f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448825f,1.364733f,0.7831206f,-0.710972f,0.0145538f,0.02910159f,0.7024673f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 5.578372f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 5.578372f);
Get(0xDD1E).SetLocalPose(1.428956f,1.244704f,0.8419997f,0.5833285f,-0.5485582f,0.395951f,-0.4494824f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448871f,1.364723f,0.7830414f,-0.710991f,0.01449266f,0.02927606f,0.702442f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 5.596275f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 5.596275f);
Get(0xDD1E).SetLocalPose(1.429145f,1.244683f,0.8421597f,0.5834111f,-0.5483919f,0.395946f,-0.4495828f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448629f,1.364883f,0.7830195f,-0.7109202f,0.01451936f,0.02952008f,0.7025028f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 5.614704f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 5.614704f);
Get(0xDD1E).SetLocalPose(1.429613f,1.244708f,0.8423781f,0.5833572f,-0.5484133f,0.3959785f,-0.4495979f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448653f,1.364985f,0.7830262f,-0.710843f,0.01498396f,0.03013793f,0.702545f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 5.632047f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 5.632047f);
Get(0xDD1E).SetLocalPose(1.429767f,1.244701f,0.8422452f,0.5832223f,-0.5485184f,0.3960819f,-0.4495536f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448823f,1.364973f,0.7829097f,-0.7108002f,0.01533355f,0.0305031f,0.7025651f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 5.640223f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 5.640223f);
Get(0xDD1E).SetLocalPose(1.429796f,1.244738f,0.8424867f,0.5832705f,-0.5485336f,0.3960969f,-0.4494593f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44904f,1.364973f,0.782827f,-0.7107274f,0.01602f,0.03113879f,0.7025954f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 5.659858f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 5.659858f);
Get(0xDD1E).SetLocalPose(1.429813f,1.244077f,0.8426149f,0.5835018f,-0.5484288f,0.3960273f,-0.4493484f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448496f,1.365353f,0.7820309f,-0.7106239f,0.01685993f,0.0318208f,0.70265f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 5.678085f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 5.678085f);
Get(0xDD1E).SetLocalPose(1.429782f,1.243858f,0.8428925f,0.5837214f,-0.548403f,0.3961057f,-0.4490254f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448533f,1.365581f,0.7817466f,-0.710619f,0.01779363f,0.03265984f,0.7025933f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 5.696012f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 5.696012f);
Get(0xDD1E).SetLocalPose(1.43021f,1.243778f,0.8430749f,0.5838299f,-0.5484625f,0.3962284f,-0.4487033f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448502f,1.36494f,0.7811255f,-0.7106398f,0.01863649f,0.03343445f,0.702514f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 5.713889f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 5.713889f);
Get(0xDD1E).SetLocalPose(1.429882f,1.243701f,0.8435714f,0.5837859f,-0.5486915f,0.3964365f,-0.4482967f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448682f,1.365182f,0.7811005f,-0.7106829f,0.01985789f,0.03468038f,0.7023765f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 5.733178f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 5.733178f);
Get(0xDD1E).SetLocalPose(1.430027f,1.243423f,0.8439757f,0.5837476f,-0.5488808f,0.396481f,-0.4480753f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448691f,1.365172f,0.7812356f,-0.7106825f,0.02052671f,0.0352878f,0.7023275f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 5.74183f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 5.74183f);
Get(0xDD1E).SetLocalPose(1.430202f,1.243574f,0.8438451f,0.5837433f,-0.5489253f,0.3964155f,-0.4480843f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.449106f,1.365344f,0.7815312f,-0.7106742f,0.02156228f,0.03616191f,0.7022604f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 5.761001f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 5.761001f);
Get(0xDD1E).SetLocalPose(1.430521f,1.243911f,0.8435906f,0.5838609f,-0.5488704f,0.3961472f,-0.4482357f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.449425f,1.365165f,0.7817738f,-0.7105528f,0.02243166f,0.0367954f,0.7023231f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 5.779356f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 5.779356f);
Get(0xDD1E).SetLocalPose(1.430886f,1.243838f,0.84317f,0.5839513f,-0.5487638f,0.3960278f,-0.448354f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.449418f,1.364547f,0.7819407f,-0.7103795f,0.02308309f,0.03726843f,0.7024523f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 5.798495f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 5.798495f);
Get(0xDD1E).SetLocalPose(1.431167f,1.244196f,0.8434426f,0.5840309f,-0.5486964f,0.3960913f,-0.4482766f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.449564f,1.364193f,0.7821898f,-0.7101876f,0.02342777f,0.03772633f,0.7026105f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 5.816327f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 5.816327f);
Get(0xDD1E).SetLocalPose(1.430951f,1.244237f,0.8438791f,0.5839314f,-0.5487773f,0.3962586f,-0.4481594f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.449383f,1.364297f,0.7828112f,-0.7101158f,0.02351002f,0.03784947f,0.7026736f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 5.824241f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 5.824241f);
Get(0xDD1E).SetLocalPose(1.430715f,1.244083f,0.84413f,0.5837163f,-0.5488983f,0.3963998f,-0.4481665f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.449144f,1.364542f,0.783239f,-0.7099779f,0.02341816f,0.03799521f,0.7028083f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 5.843431f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 5.843431f);
Get(0xDD1E).SetLocalPose(1.430691f,1.244014f,0.8444998f,0.5836319f,-0.548937f,0.3964069f,-0.4482228f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448937f,1.364687f,0.7837082f,-0.7097696f,0.02315238f,0.03797714f,0.7030284f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 5.861171f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 5.861171f);
Get(0xDD1E).SetLocalPose(1.43101f,1.243569f,0.8438982f,0.5837322f,-0.5488348f,0.3963106f,-0.4483024f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448665f,1.364696f,0.7837429f,-0.7095537f,0.02312637f,0.03804616f,0.7032434f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 5.879116f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 5.879116f);
Get(0xDD1E).SetLocalPose(1.431199f,1.243449f,0.8441848f,0.5839413f,-0.5486469f,0.3961727f,-0.4483821f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448404f,1.364589f,0.7839777f,-0.7092738f,0.02311255f,0.03796346f,0.7035307f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 5.897668f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 5.897668f);
Get(0xDD1E).SetLocalPose(1.431194f,1.243697f,0.8441161f,0.5837812f,-0.5487509f,0.3961381f,-0.4484936f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447979f,1.36481f,0.7838462f,-0.7090295f,0.02319275f,0.03780103f,0.7037829f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 5.915733f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 5.915733f);
Get(0xDD1E).SetLocalPose(1.431318f,1.24378f,0.8442228f,0.5833713f,-0.5490081f,0.3962376f,-0.4486244f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448007f,1.36484f,0.7839299f,-0.7089334f,0.02329602f,0.03775143f,0.7038791f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 5.923826f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 5.923826f);
Get(0xDD1E).SetLocalPose(1.430943f,1.243311f,0.8440881f,0.5832158f,-0.5491053f,0.3962523f,-0.4486946f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447916f,1.364563f,0.7840376f,-0.7087683f,0.02350389f,0.03754435f,0.7040493f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 5.942561f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 5.942561f);
Get(0xDD1E).SetLocalPose(1.430552f,1.243883f,0.8437734f,0.5831975f,-0.5490715f,0.3962199f,-0.4487882f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448318f,1.364414f,0.7842298f,-0.7087749f,0.02359069f,0.03739694f,0.7040477f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 5.960472f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 5.960472f);
Get(0xDD1E).SetLocalPose(1.430128f,1.24399f,0.843749f,0.583302f,-0.54893f,0.3961442f,-0.4488924f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44862f,1.364002f,0.7841021f,-0.7088552f,0.02372319f,0.03732342f,0.7039664f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 5.978317f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 5.978317f);
Get(0xDD1E).SetLocalPose(1.429873f,1.244352f,0.843695f,0.583196f,-0.5489196f,0.3962075f,-0.4489871f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.449048f,1.363966f,0.7840063f,-0.7089719f,0.02370051f,0.03727451f,0.7038522f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 5.9963f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 5.9963f);
Get(0xDD1E).SetLocalPose(1.429836f,1.244269f,0.8437955f,0.582966f,-0.5490758f,0.3962443f,-0.4490622f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.449307f,1.364502f,0.7839772f,-0.7091721f,0.02368457f,0.03732704f,0.7036481f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 6.015271f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 6.015271f);
Get(0xDD1E).SetLocalPose(1.429739f,1.24397f,0.8437076f,0.5827838f,-0.5491759f,0.3962818f,-0.4491432f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.449191f,1.364647f,0.7838159f,-0.7093236f,0.02354107f,0.03739866f,0.7034965f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 6.032991f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 6.032991f);
Get(0xDD1E).SetLocalPose(1.429292f,1.245091f,0.8436698f,0.5826265f,-0.5493037f,0.396345f,-0.4491355f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.449009f,1.364866f,0.7836544f,-0.7093561f,0.02345906f,0.03746353f,0.7034629f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 6.041286f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 6.041286f);
Get(0xDD1E).SetLocalPose(1.429036f,1.24543f,0.8436282f,0.5827255f,-0.5492062f,0.3963276f,-0.4491414f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448882f,1.364682f,0.78382f,-0.7094601f,0.02319686f,0.03770666f,0.7033538f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 6.064544f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 6.064544f);
Get(0xDD1E).SetLocalPose(1.429317f,1.245138f,0.8433291f,0.5828032f,-0.5491037f,0.3963004f,-0.4491898f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448606f,1.364849f,0.7838674f,-0.7094491f,0.02308257f,0.03783607f,0.7033618f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 6.074849f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 6.074849f);
Get(0xDD1E).SetLocalPose(1.429254f,1.245245f,0.8431212f,0.5825062f,-0.5492331f,0.3964034f,-0.4493262f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448281f,1.364957f,0.7837933f,-0.7094625f,0.0229494f,0.03794734f,0.7033466f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 6.08857f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 6.08857f);
Get(0xDD1E).SetLocalPose(1.42928f,1.245579f,0.8434924f,0.5822178f,-0.5494427f,0.3964733f,-0.4493819f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447513f,1.364889f,0.7838786f,-0.70946f,0.02274839f,0.03817111f,0.7033435f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 6.115221f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 6.115221f);
Get(0xDD1E).SetLocalPose(1.429489f,1.246084f,0.8435607f,0.5821829f,-0.5495492f,0.3963509f,-0.4494049f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447306f,1.364709f,0.783888f,-0.7094977f,0.02265925f,0.0382022f,0.7033066f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 6.12716f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 6.12716f);
Get(0xDD1E).SetLocalPose(1.429481f,1.246534f,0.8438169f,0.5822492f,-0.5494778f,0.3963049f,-0.4494467f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447314f,1.364659f,0.7839381f,-0.7094852f,0.02266554f,0.03824889f,0.7033165f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 6.140553f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 6.140553f);
Get(0xDD1E).SetLocalPose(1.429728f,1.246679f,0.8439196f,0.5823312f,-0.5494127f,0.3962866f,-0.4494363f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447666f,1.364631f,0.783869f,-0.7095187f,0.02267111f,0.03827541f,0.703281f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 6.15373f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 6.15373f);
Get(0xDD1E).SetLocalPose(1.429649f,1.246321f,0.843879f,0.5823229f,-0.5494277f,0.3962755f,-0.4494385f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447658f,1.364786f,0.7837848f,-0.7095771f,0.02268998f,0.03818546f,0.7032264f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 6.166934f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 6.166934f);
Get(0xDD1E).SetLocalPose(1.429818f,1.246343f,0.8439314f,0.5823793f,-0.5493809f,0.3962452f,-0.4494493f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447775f,1.364826f,0.7834955f,-0.7095839f,0.0228772f,0.03808967f,0.7032188f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 6.194616f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 6.194616f);
Get(0xDD1E).SetLocalPose(1.429871f,1.2463f,0.8444243f,0.5821455f,-0.5496115f,0.3964437f,-0.4492954f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447842f,1.364796f,0.7834044f,-0.7095793f,0.02297231f,0.03796994f,0.7032267f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 6.21261f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 6.21261f);
Get(0xDD1E).SetLocalPose(1.4293f,1.245808f,0.8446965f,0.5820335f,-0.5497175f,0.396457f,-0.4492989f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447813f,1.36467f,0.7834957f,-0.7095435f,0.02309692f,0.03782653f,0.7032666f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 6.230765f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 6.230765f);
Get(0xDD1E).SetLocalPose(1.429623f,1.245755f,0.8445551f,0.5822839f,-0.5495453f,0.3963219f,-0.4493045f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447747f,1.364483f,0.7835706f,-0.709482f,0.02317218f,0.03772476f,0.7033316f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 6.248575f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 6.248575f);
Get(0xDD1E).SetLocalPose(1.429109f,1.24546f,0.8440322f,0.5824762f,-0.5494511f,0.3962349f,-0.449247f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448063f,1.364766f,0.7835044f,-0.7094126f,0.02304285f,0.03764525f,0.7034101f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 6.266364f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 6.266364f);
Get(0xDD1E).SetLocalPose(1.429287f,1.244712f,0.8443677f,0.5823915f,-0.5496219f,0.3964543f,-0.4489544f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448377f,1.364638f,0.7836589f,-0.7093815f,0.0229395f,0.03763236f,0.7034456f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 6.274275f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 6.274275f);
Get(0xDD1E).SetLocalPose(1.428943f,1.244759f,0.8445489f,0.5823606f,-0.5497124f,0.3965744f,-0.4487775f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448409f,1.364765f,0.7836658f,-0.7091911f,0.02283719f,0.03768042f,0.7036381f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 6.293928f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 6.293928f);
Get(0xDD1E).SetLocalPose(1.42774f,1.244478f,0.8447576f,0.5823815f,-0.5498362f,0.3968971f,-0.4483131f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448354f,1.365048f,0.7839276f,-0.7090582f,0.02281097f,0.03770756f,0.7037715f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 6.31154f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 6.31154f);
Get(0xDD1E).SetLocalPose(1.427675f,1.244435f,0.8445231f,0.5825467f,-0.549823f,0.396995f,-0.4480278f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448094f,1.364851f,0.7840796f,-0.7089431f,0.02276794f,0.03776169f,0.703886f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 6.329375f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 6.329375f);
Get(0xDD1E).SetLocalPose(1.427371f,1.244545f,0.8447394f,0.5825672f,-0.5498813f,0.3970847f,-0.4478502f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447992f,1.364221f,0.7844915f,-0.7089419f,0.0227384f,0.03774086f,0.7038893f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 6.347751f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 6.347751f);
Get(0xDD1E).SetLocalPose(1.427212f,1.244837f,0.8447708f,0.5825936f,-0.5498605f,0.3970642f,-0.4478596f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448008f,1.364167f,0.7845457f,-0.7089441f,0.0228236f,0.03769819f,0.7038866f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 6.365526f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 6.365526f);
Get(0xDD1E).SetLocalPose(1.427529f,1.244853f,0.8447016f,0.5826066f,-0.5498391f,0.3970453f,-0.4478858f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448054f,1.364166f,0.7844953f,-0.7089621f,0.02282979f,0.03761294f,0.7038727f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 6.373757f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 6.373757f);
Get(0xDD1E).SetLocalPose(1.427534f,1.244866f,0.8447002f,0.5826631f,-0.5497645f,0.3970484f,-0.447901f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448016f,1.364239f,0.7843961f,-0.7090433f,0.02281429f,0.03743817f,0.7038009f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 6.393085f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 6.393085f);
Get(0xDD1E).SetLocalPose(1.4275f,1.243642f,0.845187f,0.5827495f,-0.5497139f,0.3970816f,-0.4478213f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448407f,1.364434f,0.7845227f,-0.7091982f,0.02269743f,0.03727064f,0.7036574f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 6.411418f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 6.411418f);
Get(0xDD1E).SetLocalPose(1.427311f,1.244387f,0.845419f,0.5828436f,-0.5496781f,0.3971099f,-0.4477176f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448066f,1.364253f,0.7844181f,-0.7093121f,0.02244004f,0.03706663f,0.7035615f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 6.430069f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 6.430069f);
Get(0xDD1E).SetLocalPose(1.427207f,1.243888f,0.8454121f,0.5830164f,-0.5495333f,0.3970072f,-0.4477616f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448194f,1.364561f,0.7842291f,-0.7094425f,0.02220191f,0.03702617f,0.7034398f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 6.448296f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 6.448296f);
Get(0xDD1E).SetLocalPose(1.427938f,1.242204f,0.8454403f,0.5831942f,-0.5493085f,0.3966981f,-0.4480797f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448231f,1.364713f,0.7839533f,-0.7095254f,0.021951f,0.03696758f,0.7033671f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 6.466338f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 6.466338f);
Get(0xDD1E).SetLocalPose(1.427674f,1.242166f,0.8460924f,0.5832471f,-0.549238f,0.3964728f,-0.4482965f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44828f,1.364831f,0.7838034f,-0.7095974f,0.02168123f,0.03686492f,0.7033082f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 6.474417f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 6.474417f);
Get(0xDD1E).SetLocalPose(1.427535f,1.242799f,0.8463835f,0.5832835f,-0.5491955f,0.3963858f,-0.4483782f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448275f,1.36516f,0.7837909f,-0.709657f,0.02107898f,0.03662184f,0.7032791f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 6.492768f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 6.492768f);
Get(0xDD1E).SetLocalPose(1.427619f,1.24226f,0.8464305f,0.5834708f,-0.5490272f,0.3961988f,-0.4485059f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448101f,1.365345f,0.7838326f,-0.7097325f,0.02029995f,0.03617338f,0.7032492f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 6.511605f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 6.511605f);
Get(0xDD1E).SetLocalPose(1.427483f,1.242651f,0.8465859f,0.5837597f,-0.5489001f,0.396184f,-0.4482984f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447739f,1.365512f,0.7833866f,-0.7097139f,0.01954754f,0.03570445f,0.7033131f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 6.529229f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 6.529229f);
Get(0xDD1E).SetLocalPose(1.427768f,1.242789f,0.8469222f,0.5837975f,-0.5489656f,0.3963125f,-0.4480556f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447644f,1.365453f,0.7832409f,-0.7097359f,0.01909633f,0.03542139f,0.7033177f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 6.547078f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 6.547078f);
Get(0xDD1E).SetLocalPose(1.428063f,1.243087f,0.8471633f,0.5838155f,-0.5490527f,0.3963594f,-0.4478838f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447456f,1.364973f,0.7830935f,-0.7097552f,0.01863843f,0.03502532f,0.7033302f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 6.564977f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 6.564977f);
Get(0xDD1E).SetLocalPose(1.42808f,1.243086f,0.8472535f,0.5838597f,-0.5491107f,0.3961736f,-0.4479195f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447668f,1.364836f,0.7832031f,-0.7097705f,0.01797907f,0.03438559f,0.7033635f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 6.583111f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 6.583111f);
Get(0xDD1E).SetLocalPose(1.428257f,1.242434f,0.8476229f,0.5840358f,-0.5490314f,0.3959945f,-0.4479454f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447969f,1.364783f,0.7833408f,-0.7097624f,0.01751376f,0.03399602f,0.7034025f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 6.59121f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 6.59121f);
Get(0xDD1E).SetLocalPose(1.428477f,1.242705f,0.847608f,0.5841299f,-0.5489995f,0.3959449f,-0.4479057f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447954f,1.364872f,0.7835331f,-0.7097718f,0.01677356f,0.03318416f,0.7034497f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 6.612148f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 6.612148f);
Get(0xDD1E).SetLocalPose(1.428375f,1.24263f,0.8479567f,0.584466f,-0.5487759f,0.3958852f,-0.447794f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447976f,1.364907f,0.7835381f,-0.7098237f,0.0159753f,0.0323279f,0.7034559f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 6.630322f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 6.630322f);
Get(0xDD1E).SetLocalPose(1.427829f,1.243113f,0.847792f,0.584636f,-0.5487408f,0.3959315f,-0.4475742f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447912f,1.364705f,0.7835487f,-0.7098938f,0.01555432f,0.03176766f,0.7034201f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 6.648079f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 6.648079f);
Get(0xDD1E).SetLocalPose(1.427812f,1.243852f,0.8477647f,0.5845587f,-0.5488324f,0.3960275f,-0.4474779f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448f,1.364488f,0.7835523f,-0.709907f,0.01531197f,0.03129954f,0.703433f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 6.665807f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 6.665807f);
Get(0xDD1E).SetLocalPose(1.428211f,1.242968f,0.8486261f,0.5845011f,-0.5489348f,0.3960305f,-0.4474247f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447836f,1.364314f,0.7833284f,-0.709895f,0.01520391f,0.03102661f,0.7034596f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 6.67388f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 6.67388f);
Get(0xDD1E).SetLocalPose(1.428251f,1.243052f,0.8486411f,0.5845588f,-0.5489058f,0.3959677f,-0.4474405f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44742f,1.364048f,0.7833266f,-0.7098678f,0.01483715f,0.030382f,0.703523f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 6.692921f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 6.692921f);
Get(0xDD1E).SetLocalPose(1.428653f,1.242626f,0.8492629f,0.5847966f,-0.5487997f,0.3958389f,-0.447374f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.446826f,1.364189f,0.7832184f,-0.7098877f,0.0142556f,0.02967381f,0.7035452f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 6.711266f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 6.711266f);
Get(0xDD1E).SetLocalPose(1.428604f,1.242499f,0.8493136f,0.5850249f,-0.5486479f,0.3958256f,-0.4472736f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.446556f,1.364517f,0.7832375f,-0.7099459f,0.01383585f,0.02916933f,0.7035158f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 6.728899f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 6.728899f);
Get(0xDD1E).SetLocalPose(1.428009f,1.241949f,0.8495221f,0.5851705f,-0.5485848f,0.3957275f,-0.4472471f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.446894f,1.364635f,0.7834428f,-0.7099955f,0.01333316f,0.028798f,0.7034908f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 6.748063f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 6.748063f);
Get(0xDD1E).SetLocalPose(1.427652f,1.241974f,0.8492212f,0.5850243f,-0.5486241f,0.3957745f,-0.4473485f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.446874f,1.364767f,0.7834684f,-0.7100356f,0.01307065f,0.02862761f,0.7034623f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 6.765643f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 6.765643f);
Get(0xDD1E).SetLocalPose(1.427553f,1.242163f,0.8491735f,0.5849725f,-0.5486177f,0.3958151f,-0.4473884f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.446903f,1.364905f,0.7835259f,-0.7100297f,0.01302489f,0.02866548f,0.7034674f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 6.773988f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 6.773988f);
Get(0xDD1E).SetLocalPose(1.427543f,1.24265f,0.8491181f,0.5850146f,-0.5485604f,0.3958257f,-0.4473942f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.446873f,1.365018f,0.7836341f,-0.7099977f,0.01319624f,0.0287737f,0.7034922f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 6.793004f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 6.793004f);
Get(0xDD1E).SetLocalPose(1.427362f,1.242322f,0.8490403f,0.5850407f,-0.5484904f,0.3958094f,-0.4474602f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447093f,1.365105f,0.7836425f,-0.7099612f,0.01328585f,0.02866819f,0.7035316f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 6.811306f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 6.811306f);
Get(0xDD1E).SetLocalPose(1.426911f,1.242146f,0.8490036f,0.5850016f,-0.5484385f,0.3958496f,-0.4475392f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447157f,1.364977f,0.7837113f,-0.7099106f,0.01344441f,0.02856509f,0.7035838f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 6.829279f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 6.829279f);
Get(0xDD1E).SetLocalPose(1.426983f,1.242059f,0.8489193f,0.5849448f,-0.5484259f,0.3958298f,-0.4476466f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44731f,1.364897f,0.7837782f,-0.7098811f,0.01363873f,0.02850881f,0.7036121f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 6.847487f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 6.847487f);
Get(0xDD1E).SetLocalPose(1.427398f,1.242105f,0.849072f,0.5847866f,-0.5485086f,0.3956139f,-0.4479425f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447404f,1.364679f,0.7835041f,-0.7098519f,0.01382382f,0.02835038f,0.7036444f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 6.86568f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 6.86568f);
Get(0xDD1E).SetLocalPose(1.427735f,1.241965f,0.8492453f,0.5845965f,-0.5485849f,0.3956121f,-0.448099f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44749f,1.364677f,0.7834692f,-0.7098509f,0.01390021f,0.02827354f,0.703647f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 6.874366f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 6.874366f);
Get(0xDD1E).SetLocalPose(1.428025f,1.242165f,0.8491898f,0.5846042f,-0.5485343f,0.3956318f,-0.4481335f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447895f,1.364629f,0.7837311f,-0.7098534f,0.01405767f,0.02822208f,0.7036436f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 6.893864f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 6.893864f);
Get(0xDD1E).SetLocalPose(1.428562f,1.242134f,0.849012f,0.5847247f,-0.5483827f,0.3956364f,-0.4481578f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448007f,1.364725f,0.7838783f,-0.709891f,0.01413327f,0.02814858f,0.703607f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 6.911733f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 6.911733f);
Get(0xDD1E).SetLocalPose(1.428718f,1.242356f,0.8487332f,0.5847309f,-0.5483274f,0.3957331f,-0.4481319f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447978f,1.364672f,0.7838985f,-0.7099033f,0.01414924f,0.02810992f,0.7035958f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 6.929698f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 6.929698f);
Get(0xDD1E).SetLocalPose(1.428902f,1.24276f,0.8485649f,0.5846655f,-0.5483014f,0.3957941f,-0.4481952f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448106f,1.364476f,0.7839887f,-0.7098983f,0.01415882f,0.02811877f,0.7036002f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 6.947568f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 6.947568f);
Get(0xDD1E).SetLocalPose(1.429358f,1.243229f,0.8486417f,0.5846884f,-0.5482347f,0.395724f,-0.4483088f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44807f,1.364392f,0.7841123f,-0.7098948f,0.01406562f,0.02816366f,0.7036038f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 6.965772f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 6.965772f);
Get(0xDD1E).SetLocalPose(1.429664f,1.243044f,0.8485295f,0.5845015f,-0.5483612f,0.395846f,-0.4482901f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448082f,1.364537f,0.7841622f,-0.7099065f,0.01400878f,0.02825543f,0.7035896f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 6.974017f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 6.974017f);
Get(0xDD1E).SetLocalPose(1.429823f,1.243042f,0.8485162f,0.5844411f,-0.5483877f,0.3960486f,-0.4481575f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448014f,1.364629f,0.7842484f,-0.7099094f,0.01385275f,0.02836196f,0.7035854f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 6.993098f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 6.993098f);
Get(0xDD1E).SetLocalPose(1.429467f,1.242654f,0.8489421f,0.5843855f,-0.5483881f,0.3965057f,-0.4478252f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447977f,1.36492f,0.7840762f,-0.7098975f,0.01376108f,0.0284422f,0.703596f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 7.011398f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 7.011398f);
Get(0xDD1E).SetLocalPose(1.429176f,1.242191f,0.8490068f,0.5845411f,-0.5482869f,0.3967457f,-0.4475332f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447982f,1.365035f,0.7840928f,-0.7099127f,0.0136757f,0.02854933f,0.7035779f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 7.029602f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 7.029602f);
Get(0xDD1E).SetLocalPose(1.429082f,1.242148f,0.8484417f,0.5846276f,-0.5481119f,0.3968202f,-0.4475686f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447928f,1.365077f,0.7840251f,-0.7099251f,0.01362802f,0.02859604f,0.7035645f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 7.038177f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 7.038177f);
Get(0xDD1E).SetLocalPose(1.429239f,1.241794f,0.8482213f,0.5845845f,-0.5480765f,0.3968347f,-0.4476555f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448148f,1.365174f,0.7837934f,-0.7099236f,0.01360118f,0.02865383f,0.7035642f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 7.059461f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 7.059461f);
Get(0xDD1E).SetLocalPose(1.429064f,1.241672f,0.8480523f,0.584255f,-0.5482289f,0.3972115f,-0.4475648f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448436f,1.365119f,0.7837309f,-0.7099569f,0.01363324f,0.02864265f,0.7035304f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 7.077406f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 7.077406f);
Get(0xDD1E).SetLocalPose(1.429737f,1.241509f,0.8475264f,0.5840145f,-0.5483251f,0.3974777f,-0.4475246f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448536f,1.364593f,0.7834526f,-0.7099866f,0.01366553f,0.02861603f,0.7035009f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 7.095457f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 7.095457f);
Get(0xDD1E).SetLocalPose(1.430307f,1.241518f,0.8470703f,0.5841705f,-0.5481874f,0.3974457f,-0.447518f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448809f,1.364604f,0.7833477f,-0.7100077f,0.0137146f,0.02851027f,0.7034829f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 7.113927f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 7.113927f);
Get(0xDD1E).SetLocalPose(1.431376f,1.241283f,0.8471141f,0.5844362f,-0.5478975f,0.397344f,-0.4476164f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448788f,1.364731f,0.7833972f,-0.709994f,0.01379536f,0.02847259f,0.7034966f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 7.131767f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 7.131767f);
Get(0xDD1E).SetLocalPose(1.431413f,1.240927f,0.8469642f,0.584438f,-0.5477593f,0.3974888f,-0.4476547f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448939f,1.364705f,0.7834925f,-0.7099746f,0.0138244f,0.02841868f,0.703518f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 7.149563f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 7.149563f);
Get(0xDD1E).SetLocalPose(1.431263f,1.241221f,0.8470061f,0.5840181f,-0.5479082f,0.3977813f,-0.4477605f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448918f,1.36486f,0.783587f,-0.7099567f,0.01388909f,0.02839985f,0.7035355f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 7.157896f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 7.157896f);
Get(0xDD1E).SetLocalPose(1.431432f,1.240764f,0.8469526f,0.5838497f,-0.5479387f,0.397821f,-0.4479076f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44877f,1.364969f,0.7837387f,-0.7099106f,0.01394102f,0.02835162f,0.7035828f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 7.177214f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 7.177214f);
Get(0xDD1E).SetLocalPose(1.432049f,1.240878f,0.8472557f,0.5838062f,-0.5478302f,0.3977867f,-0.4481275f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448733f,1.365119f,0.7838254f,-0.7098538f,0.0139563f,0.02831675f,0.7036412f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 7.195124f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 7.195124f);
Get(0xDD1E).SetLocalPose(1.432436f,1.241656f,0.8478358f,0.5838957f,-0.5476805f,0.3977836f,-0.4481966f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448574f,1.365324f,0.7839718f,-0.7097925f,0.01397193f,0.02832889f,0.7037023f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 7.2135f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 7.2135f);
Get(0xDD1E).SetLocalPose(1.433f,1.241734f,0.8481075f,0.5839743f,-0.5475267f,0.3978067f,-0.4482616f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448422f,1.365435f,0.7840451f,-0.7097569f,0.01392411f,0.02836021f,0.7037379f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 7.231444f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 7.231444f);
Get(0xDD1E).SetLocalPose(1.43305f,1.241812f,0.8477497f,0.5837426f,-0.5476092f,0.3980039f,-0.4482875f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448087f,1.365329f,0.7839538f,-0.7097526f,0.01388539f,0.02837229f,0.7037426f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 7.24997f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 7.24997f);
Get(0xDD1E).SetLocalPose(1.433485f,1.241437f,0.8478413f,0.5833942f,-0.5478001f,0.3982289f,-0.448308f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447945f,1.365232f,0.783893f,-0.7097857f,0.01375908f,0.02836154f,0.703712f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 7.258862f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 7.258862f);
Get(0xDD1E).SetLocalPose(1.43376f,1.241312f,0.848088f,0.5833119f,-0.5477876f,0.3982792f,-0.4483857f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447712f,1.365074f,0.7836902f,-0.7098123f,0.01373921f,0.02844822f,0.7036821f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 7.277752f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 7.277752f);
Get(0xDD1E).SetLocalPose(1.433659f,1.241519f,0.8480266f,0.583303f,-0.547725f,0.3982501f,-0.4484995f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447755f,1.364942f,0.7836583f,-0.7098914f,0.01361126f,0.02853187f,0.7036015f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 7.296244f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 7.296244f);
Get(0xDD1E).SetLocalPose(1.433335f,1.241702f,0.8479146f,0.5832288f,-0.5477762f,0.3981951f,-0.4485824f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447612f,1.364917f,0.7834831f,-0.7100007f,0.0135292f,0.02873167f,0.7034846f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 7.314668f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 7.314668f);
Get(0xDD1E).SetLocalPose(1.433369f,1.2418f,0.8476595f,0.5830026f,-0.5479878f,0.3983096f,-0.4485162f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447577f,1.364434f,0.7831979f,-0.7101175f,0.01349519f,0.02883088f,0.7033632f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 7.333199f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 7.333199f);
Get(0xDD1E).SetLocalPose(1.433267f,1.241823f,0.8478289f,0.5827536f,-0.5482274f,0.3984433f,-0.4484282f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447553f,1.364377f,0.7830952f,-0.7101579f,0.01346014f,0.02883387f,0.7033231f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 7.341584f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 7.341584f);
Get(0xDD1E).SetLocalPose(1.433155f,1.24179f,0.8478097f,0.5827178f,-0.5482426f,0.3984928f,-0.4484123f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447938f,1.364173f,0.7833424f,-0.7103165f,0.01344899f,0.02890482f,0.7031602f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 7.361058f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 7.361058f);
Get(0xDD1E).SetLocalPose(1.432973f,1.241638f,0.8478939f,0.5827222f,-0.5482019f,0.3985361f,-0.4484179f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448136f,1.364418f,0.7833324f,-0.7104274f,0.01348477f,0.02889229f,0.7030479f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 7.379107f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 7.379107f);
Get(0xDD1E).SetLocalPose(1.433124f,1.241964f,0.8478265f,0.5827355f,-0.5480869f,0.3985667f,-0.4485139f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448485f,1.364374f,0.7833053f,-0.7105063f,0.013462f,0.02884535f,0.7029706f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 7.396863f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 7.396863f);
Get(0xDD1E).SetLocalPose(1.433391f,1.241673f,0.8477199f,0.5825939f,-0.5480564f,0.3986935f,-0.4486224f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448609f,1.364594f,0.7831929f,-0.710542f,0.01356732f,0.02879705f,0.7029344f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 7.415104f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 7.415104f);
Get(0xDD1E).SetLocalPose(1.43383f,1.241836f,0.8478417f,0.582397f,-0.548168f,0.3987975f,-0.4486492f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.449011f,1.364627f,0.7836059f,-0.710549f,0.0136825f,0.02871432f,0.7029285f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 7.432963f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 7.432963f);
Get(0xDD1E).SetLocalPose(1.433938f,1.242251f,0.8477237f,0.5821885f,-0.548191f,0.3988324f,-0.4488608f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.449154f,1.364714f,0.7836714f,-0.7105129f,0.01370867f,0.02863306f,0.7029678f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 7.441238f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 7.441238f);
Get(0xDD1E).SetLocalPose(1.434265f,1.242627f,0.8477727f,0.5821248f,-0.5481676f,0.3988478f,-0.4489582f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.449334f,1.364773f,0.7840369f,-0.7103472f,0.01383527f,0.02849691f,0.7031383f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 7.462176f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 7.462176f);
Get(0xDD1E).SetLocalPose(1.434515f,1.243099f,0.848084f,0.5820949f,-0.5481187f,0.3989702f,-0.448948f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.449142f,1.364777f,0.7840573f,-0.7101545f,0.0138864f,0.02838741f,0.7033364f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 7.480926f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 7.480926f);
Get(0xDD1E).SetLocalPose(1.435123f,1.242676f,0.8485285f,0.5820503f,-0.548102f,0.399171f,-0.4488477f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.449016f,1.364922f,0.7842506f,-0.7099058f,0.01392212f,0.02833501f,0.7035887f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 7.498555f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 7.498555f);
Get(0xDD1E).SetLocalPose(1.43519f,1.242379f,0.8486145f,0.5819112f,-0.5481646f,0.3993439f,-0.4487978f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448861f,1.365213f,0.7843632f,-0.70967f,0.01393465f,0.02830995f,0.7038274f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 7.516531f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 7.516531f);
Get(0xDD1E).SetLocalPose(1.435478f,1.243053f,0.8490959f,0.5817202f,-0.5482291f,0.3994947f,-0.4488323f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44872f,1.365461f,0.7843628f,-0.7095878f,0.01395373f,0.02833576f,0.7039089f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 7.524742f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 7.524742f);
Get(0xDD1E).SetLocalPose(1.435252f,1.242684f,0.8489873f,0.5816808f,-0.548253f,0.3995086f,-0.4488419f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448492f,1.365548f,0.7842699f,-0.7094543f,0.0139575f,0.028297f,0.7040449f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 7.5432f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 7.5432f);
Get(0xDD1E).SetLocalPose(1.436148f,1.242795f,0.8495156f,0.5816966f,-0.5481357f,0.3995885f,-0.4488937f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448182f,1.365489f,0.7842815f,-0.7094633f,0.01395624f,0.02830528f,0.7040354f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 7.561318f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 7.561318f);
Get(0xDD1E).SetLocalPose(1.436869f,1.243092f,0.8498352f,0.5816531f,-0.5480556f,0.3997873f,-0.4488707f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447896f,1.365363f,0.7841433f,-0.7095972f,0.0138941f,0.02835856f,0.7038996f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 7.579035f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 7.579035f);
Get(0xDD1E).SetLocalPose(1.436898f,1.24296f,0.8496787f,0.5814267f,-0.5480781f,0.4001007f,-0.4488573f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447972f,1.365486f,0.7838348f,-0.7098411f,0.01385711f,0.02844587f,0.7036508f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 7.597591f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 7.597591f);
Get(0xDD1E).SetLocalPose(1.437131f,1.243443f,0.8495872f,0.5811146f,-0.5481738f,0.400473f,-0.4488125f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447914f,1.365531f,0.7835549f,-0.7100378f,0.0138463f,0.0284708f,0.7034516f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 7.616241f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 7.616241f);
Get(0xDD1E).SetLocalPose(1.437163f,1.243093f,0.8497246f,0.581028f,-0.5480668f,0.4006334f,-0.4489121f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448099f,1.36534f,0.7834963f,-0.7101663f,0.01384209f,0.02856228f,0.7033182f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 7.625044f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 7.625044f);
Get(0xDD1E).SetLocalPose(1.436911f,1.242971f,0.8497484f,0.5809736f,-0.5480236f,0.4007161f,-0.4489614f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44823f,1.364888f,0.7835141f,-0.7103265f,0.01382118f,0.02854847f,0.7031574f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 7.647301f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 7.647301f);
Get(0xDD1E).SetLocalPose(1.436776f,1.243184f,0.8497629f,0.5809402f,-0.5479249f,0.4009431f,-0.4489225f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448304f,1.364519f,0.7835801f,-0.7103909f,0.01381881f,0.02857609f,0.7030912f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 7.666504f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 7.666504f);
Get(0xDD1E).SetLocalPose(1.437197f,1.2434f,0.8498614f,0.5807783f,-0.5479406f,0.4011151f,-0.4489593f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44815f,1.36436f,0.7835635f,-0.7104195f,0.01383948f,0.02859049f,0.7030613f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 7.675325f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 7.675325f);
Get(0xDD1E).SetLocalPose(1.43703f,1.243363f,0.8500474f,0.5806317f,-0.5480028f,0.4012553f,-0.4489476f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44829f,1.364182f,0.7836716f,-0.7103736f,0.01379242f,0.02866457f,0.7031056f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 7.69616f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 7.69616f);
Get(0xDD1E).SetLocalPose(1.437211f,1.243406f,0.8500494f,0.5803995f,-0.5480978f,0.4014555f,-0.4489527f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448209f,1.36397f,0.783788f,-0.710288f,0.01374856f,0.02871153f,0.703191f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 7.715764f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 7.715764f);
Get(0xDD1E).SetLocalPose(1.437011f,1.243173f,0.8500036f,0.5801505f,-0.5481677f,0.4017448f,-0.4489307f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448325f,1.36384f,0.7838659f,-0.7102352f,0.01373632f,0.02871004f,0.7032447f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 7.724757f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 7.724757f);
Get(0xDD1E).SetLocalPose(1.436882f,1.243456f,0.8500036f,0.580021f,-0.5481655f,0.4018785f,-0.4489809f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448337f,1.363961f,0.7838789f,-0.7101575f,0.01370037f,0.02868548f,0.7033249f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 7.74511f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 7.74511f);
Get(0xDD1E).SetLocalPose(1.437052f,1.24301f,0.8497776f,0.5799187f,-0.5480841f,0.4020043f,-0.4490997f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44845f,1.364329f,0.7836462f,-0.7100976f,0.01376763f,0.02860758f,0.7033872f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 7.765128f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 7.765128f);
Get(0xDD1E).SetLocalPose(1.43734f,1.243233f,0.849562f,0.5798395f,-0.5480567f,0.4019723f,-0.4492643f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448548f,1.3643f,0.7836534f,-0.7101071f,0.01379478f,0.02854341f,0.7033797f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 7.77355f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 7.77355f);
Get(0xDD1E).SetLocalPose(1.437436f,1.243297f,0.849772f,0.5796769f,-0.5481733f,0.4020452f,-0.4492665f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448352f,1.364541f,0.7833667f,-0.7101344f,0.01381757f,0.02847495f,0.7033545f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 7.793027f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 7.793027f);
Get(0xDD1E).SetLocalPose(1.43775f,1.242991f,0.849777f,0.5794125f,-0.5483397f,0.4022594f,-0.4492128f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448385f,1.364928f,0.7832146f,-0.7101966f,0.01381883f,0.02845469f,0.7032924f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 7.811531f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 7.811531f);
Get(0xDD1E).SetLocalPose(1.437932f,1.242923f,0.8493891f,0.579282f,-0.5483552f,0.4023874f,-0.4492474f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448191f,1.365044f,0.7829925f,-0.710274f,0.01376125f,0.02847216f,0.7032146f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 7.829778f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 7.829778f);
Get(0xDD1E).SetLocalPose(1.438264f,1.243064f,0.8497769f,0.5793722f,-0.5482693f,0.4022447f,-0.4493639f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448071f,1.365284f,0.7830288f,-0.7103922f,0.01360248f,0.02860429f,0.7030931f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 7.848307f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 7.848307f);
Get(0xDD1E).SetLocalPose(1.438123f,1.243175f,0.8496995f,0.5792125f,-0.5483904f,0.4023092f,-0.4493643f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44818f,1.365132f,0.78306f,-0.7104454f,0.01350185f,0.02866128f,0.7030389f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 7.856961f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 7.856961f);
Get(0xDD1E).SetLocalPose(1.438487f,1.243228f,0.8495777f,0.5790281f,-0.5485513f,0.4023748f,-0.4493467f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447782f,1.364842f,0.7830496f,-0.7105511f,0.01326392f,0.02885469f,0.7029287f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 7.876922f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 7.876922f);
Get(0xDD1E).SetLocalPose(1.439101f,1.244191f,0.8496118f,0.5787477f,-0.5487801f,0.4024994f,-0.4493169f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447441f,1.365041f,0.7831151f,-0.7106237f,0.01302347f,0.02911289f,0.7028491f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 7.895866f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 7.895866f);
Get(0xDD1E).SetLocalPose(1.438856f,1.244474f,0.8495367f,0.5787376f,-0.5487674f,0.4025351f,-0.4493137f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447449f,1.365216f,0.7833039f,-0.7106686f,0.01274963f,0.02921257f,0.7028046f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 7.914637f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 7.914637f);
Get(0xDD1E).SetLocalPose(1.439288f,1.244546f,0.849672f,0.5790216f,-0.5486105f,0.4024124f,-0.449249f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447198f,1.365577f,0.783227f,-0.7106607f,0.01262973f,0.02933664f,0.7028096f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 7.933102f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 7.933102f);
Get(0xDD1E).SetLocalPose(1.439725f,1.244593f,0.8497773f,0.5791255f,-0.548582f,0.4024395f,-0.4491258f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447145f,1.365659f,0.7832835f,-0.7106505f,0.0125548f,0.02932959f,0.7028216f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 7.941433f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 7.941433f);
Get(0xDD1E).SetLocalPose(1.439955f,1.244191f,0.8497233f,0.5790724f,-0.5486234f,0.4024116f,-0.4491685f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.446964f,1.365274f,0.7831929f,-0.7106668f,0.01257543f,0.02934123f,0.7028043f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 7.960554f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 7.960554f);
Get(0xDD1E).SetLocalPose(1.440049f,1.244031f,0.8501015f,0.5790319f,-0.5486756f,0.4023422f,-0.4492192f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447095f,1.364921f,0.783312f,-0.7107074f,0.01259072f,0.02933597f,0.7027631f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 7.979932f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 7.979932f);
Get(0xDD1E).SetLocalPose(1.439963f,1.244647f,0.8500049f,0.5790072f,-0.5487553f,0.4022729f,-0.4492158f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447164f,1.36488f,0.7829615f,-0.7108102f,0.01264236f,0.02925108f,0.7026617f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 7.99958f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 7.99958f);
Get(0xDD1E).SetLocalPose(1.440265f,1.244916f,0.8499827f,0.5790147f,-0.5486763f,0.4023579f,-0.4492265f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447112f,1.364494f,0.7827201f,-0.710864f,0.01268402f,0.02922011f,0.7026079f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 8.00823f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 8.00823f);
Get(0xDD1E).SetLocalPose(1.440261f,1.244854f,0.8501464f,0.5790979f,-0.5486066f,0.4023954f,-0.4491709f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447255f,1.364144f,0.7822028f,-0.7109483f,0.01277688f,0.02911646f,0.702525f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 8.028518f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 8.028518f);
Get(0xDD1E).SetLocalPose(1.440491f,1.244255f,0.8504984f,0.5791074f,-0.5485299f,0.4024929f,-0.4491647f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447418f,1.364321f,0.7818781f,-0.7109663f,0.012719f,0.02909314f,0.7025089f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 8.047021f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 8.047021f);
Get(0xDD1E).SetLocalPose(1.440364f,1.244047f,0.8502731f,0.5790666f,-0.5484195f,0.4025601f,-0.4492921f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447539f,1.364543f,0.7818168f,-0.7109712f,0.01267896f,0.02907516f,0.7025055f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 8.065572f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 8.065572f);
Get(0xDD1E).SetLocalPose(1.440232f,1.243324f,0.850372f,0.5790667f,-0.5483528f,0.4024415f,-0.4494795f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447366f,1.364673f,0.7816396f,-0.7109568f,0.01265725f,0.02905343f,0.7025213f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 8.074165f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 8.074165f);
Get(0xDD1E).SetLocalPose(1.440241f,1.243563f,0.8501634f,0.5790345f,-0.5482841f,0.402435f,-0.4496106f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447253f,1.3647f,0.7816154f,-0.7109022f,0.01256808f,0.02906226f,0.7025778f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 8.093736f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 8.093736f);
Get(0xDD1E).SetLocalPose(1.439927f,1.244887f,0.8499989f,0.5790262f,-0.5482196f,0.4024778f,-0.4496618f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447177f,1.364759f,0.7816632f,-0.7108706f,0.01252649f,0.02915398f,0.7026067f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 8.112554f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 8.112554f);
Get(0xDD1E).SetLocalPose(1.440479f,1.244837f,0.8501279f,0.5789359f,-0.5482454f,0.4025793f,-0.4496555f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.446975f,1.3648f,0.7819186f,-0.7107621f,0.0125895f,0.02924694f,0.7027114f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 8.130682f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 8.130682f);
Get(0xDD1E).SetLocalPose(1.440555f,1.243937f,0.8502142f,0.5788347f,-0.5483276f,0.4027178f,-0.4495617f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.446968f,1.364752f,0.7821013f,-0.7106242f,0.0127098f,0.0292194f,0.7028499f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 8.148263f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 8.148263f);
Get(0xDD1E).SetLocalPose(1.440445f,1.243711f,0.8499845f,0.5787222f,-0.5484229f,0.4028195f,-0.4494991f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.446872f,1.364433f,0.7826668f,-0.7104778f,0.01286347f,0.02906171f,0.7030017f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 8.165723f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 8.165723f);
Get(0xDD1E).SetLocalPose(1.440894f,1.243917f,0.8500481f,0.5787626f,-0.548316f,0.4027066f,-0.4496786f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.446987f,1.364371f,0.7830087f,-0.7103653f,0.01297977f,0.02891753f,0.7031192f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 8.173739f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 8.173739f);
Get(0xDD1E).SetLocalPose(1.440894f,1.243477f,0.850216f,0.57886f,-0.5481843f,0.4025738f,-0.4498327f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447492f,1.364489f,0.7835392f,-0.7101699f,0.01317133f,0.02870956f,0.7033214f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 8.193423f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 8.193423f);
Get(0xDD1E).SetLocalPose(1.441083f,1.244432f,0.8500059f,0.5789422f,-0.5480351f,0.4024848f,-0.4499882f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447898f,1.36467f,0.7837647f,-0.7099894f,0.01343087f,0.0284734f,0.7035084f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 8.211392f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 8.211392f);
Get(0xDD1E).SetLocalPose(1.44151f,1.245211f,0.8497661f,0.5788407f,-0.5480517f,0.4026078f,-0.4499885f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448133f,1.364773f,0.7839266f,-0.709867f,0.01360612f,0.02834564f,0.7036335f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 8.229542f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 8.229542f);
Get(0xDD1E).SetLocalPose(1.44192f,1.245026f,0.8500493f,0.5786939f,-0.5481412f,0.4027568f,-0.4499353f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448276f,1.364771f,0.7838196f,-0.7097535f,0.01382574f,0.0282292f,0.7037486f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 8.248074f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 8.248074f);
Get(0xDD1E).SetLocalPose(1.441909f,1.24452f,0.85017f,0.5787379f,-0.5480445f,0.402735f,-0.4500157f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448442f,1.364992f,0.7839334f,-0.7096839f,0.01399352f,0.02809583f,0.7038208f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 8.265688f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 8.265688f);
Get(0xDD1E).SetLocalPose(1.441678f,1.244174f,0.8507488f,0.5789332f,-0.5478624f,0.4026974f,-0.45002f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448542f,1.365272f,0.7839811f,-0.7096704f,0.01402107f,0.02801695f,0.703837f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 8.273583f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 8.273583f);
Get(0xDD1E).SetLocalPose(1.441471f,1.244483f,0.8506858f,0.5790121f,-0.5477802f,0.4027016f,-0.4500149f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448539f,1.365257f,0.7839843f,-0.709701f,0.01409406f,0.02804011f,0.7038037f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 8.292408f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 8.292408f);
Get(0xDD1E).SetLocalPose(1.441901f,1.244365f,0.8505084f,0.5787781f,-0.5478299f,0.4029917f,-0.4499955f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448394f,1.365332f,0.7838539f,-0.7097213f,0.01406334f,0.02801669f,0.7037848f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 8.310294f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 8.310294f);
Get(0xDD1E).SetLocalPose(1.44172f,1.243796f,0.8510852f,0.5784533f,-0.5480374f,0.4033226f,-0.4498641f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448626f,1.365229f,0.7839246f,-0.7098221f,0.01396532f,0.02812106f,0.7036809f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 8.328233f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 8.328233f);
Get(0xDD1E).SetLocalPose(1.441782f,1.243967f,0.8509984f,0.578288f,-0.5480872f,0.4033998f,-0.4499466f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448448f,1.365169f,0.7838041f,-0.7098935f,0.01384796f,0.0282619f,0.7036056f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 8.346839f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 8.346839f);
Get(0xDD1E).SetLocalPose(1.441377f,1.244651f,0.8509626f,0.5784304f,-0.5478521f,0.4032078f,-0.450222f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448421f,1.365111f,0.7838022f,-0.7099824f,0.01368747f,0.02837044f,0.7035146f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 8.364762f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 8.364762f);
Get(0xDD1E).SetLocalPose(1.441222f,1.245355f,0.8505582f,0.578676f,-0.5475119f,0.4032121f,-0.4503164f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448632f,1.365231f,0.7839031f,-0.7100754f,0.01359305f,0.02855083f,0.7034154f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 8.382996f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 8.382996f);
Get(0xDD1E).SetLocalPose(1.44132f,1.244625f,0.8508196f,0.5786107f,-0.5473977f,0.4033842f,-0.4503851f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448541f,1.364987f,0.7838288f,-0.7100911f,0.01355456f,0.02859623f,0.7033983f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 8.391254f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 8.391254f);
Get(0xDD1E).SetLocalPose(1.441402f,1.244353f,0.8509653f,0.5785149f,-0.5474553f,0.4034825f,-0.45035f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448506f,1.364907f,0.7838888f,-0.7101516f,0.01344949f,0.02863464f,0.7033378f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 8.410722f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 8.410722f);
Get(0xDD1E).SetLocalPose(1.441833f,1.244258f,0.8506873f,0.5779495f,-0.5477278f,0.4038056f,-0.4504551f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448476f,1.364556f,0.7838085f,-0.7101864f,0.01340779f,0.02872369f,0.7032997f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 8.425621f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 8.425621f);
Get(0xDD1E).SetLocalPose(1.441779f,1.244439f,0.8502376f,0.5778402f,-0.5476306f,0.4038838f,-0.4506432f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448374f,1.364657f,0.7837649f,-0.710185f,0.01339526f,0.02873556f,0.7033009f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 8.440416f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 8.440416f);
Get(0xDD1E).SetLocalPose(1.441714f,1.244439f,0.8501452f,0.5779219f,-0.5474957f,0.4038672f,-0.4507173f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448163f,1.364592f,0.7835781f,-0.7101806f,0.01344266f,0.02868214f,0.7033066f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 8.460995f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 8.460995f);
Get(0xDD1E).SetLocalPose(1.442348f,1.243318f,0.8499026f,0.578146f,-0.5471584f,0.4038182f,-0.4508834f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448402f,1.364408f,0.7837067f,-0.7101572f,0.01349414f,0.02861654f,0.7033319f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 8.479744f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 8.479744f);
Get(0xDD1E).SetLocalPose(1.442575f,1.24399f,0.8499658f,0.578052f,-0.5470799f,0.4040296f,-0.4509097f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448359f,1.36441f,0.7835951f,-0.7101036f,0.01359576f,0.02853635f,0.7033873f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 8.498394f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 8.498394f);
Get(0xDD1E).SetLocalPose(1.442861f,1.244025f,0.85f,0.5777659f,-0.5470942f,0.4043643f,-0.4509591f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448482f,1.364295f,0.7835466f,-0.7100405f,0.01368835f,0.02848906f,0.7034512f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 8.507065f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 8.507065f);
Get(0xDD1E).SetLocalPose(1.4431f,1.243986f,0.8497897f,0.5776879f,-0.5470527f,0.404447f,-0.4510351f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448519f,1.364232f,0.7835513f,-0.70996f,0.01374522f,0.02839029f,0.7035353f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 8.527035f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 8.527035f);
Get(0xDD1E).SetLocalPose(1.443334f,1.244343f,0.8496761f,0.5778315f,-0.5467908f,0.404418f,-0.4511948f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448454f,1.36454f,0.7835776f,-0.7098766f,0.01383011f,0.02829166f,0.7036218f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 8.545743f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 8.545743f);
Get(0xDD1E).SetLocalPose(1.44351f,1.244118f,0.8496155f,0.5779961f,-0.546454f,0.4043289f,-0.4514717f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448473f,1.364925f,0.7837818f,-0.709802f,0.0139295f,0.02822012f,0.7036979f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 8.564526f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 8.564526f);
Get(0xDD1E).SetLocalPose(1.443801f,1.24407f,0.8497925f,0.5779574f,-0.5463092f,0.4045243f,-0.4515215f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448495f,1.365175f,0.7839028f,-0.7097703f,0.01395135f,0.02815251f,0.7037323f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 8.582574f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 8.582574f);
Get(0xDD1E).SetLocalPose(1.444088f,1.243674f,0.8499989f,0.5777318f,-0.5464171f,0.4047287f,-0.4514965f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448427f,1.365278f,0.7838863f,-0.7097341f,0.01392191f,0.02816419f,0.7037688f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 8.590698f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 8.590698f);
Get(0xDD1E).SetLocalPose(1.444378f,1.243438f,0.8495231f,0.5775232f,-0.5465091f,0.404837f,-0.451555f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448436f,1.365226f,0.7839637f,-0.7097629f,0.0139202f,0.02819272f,0.7037386f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 8.610599f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 8.610599f);
Get(0xDD1E).SetLocalPose(1.445027f,1.243338f,0.8489013f,0.5775136f,-0.5464388f,0.4048276f,-0.4516605f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44856f,1.365375f,0.7841204f,-0.7098001f,0.01385978f,0.02825091f,0.7037001f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 8.629416f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 8.629416f);
Get(0xDD1E).SetLocalPose(1.445308f,1.24344f,0.8484427f,0.5777436f,-0.5462079f,0.4047485f,-0.4517168f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448349f,1.365553f,0.7840345f,-0.7098678f,0.01376389f,0.02832996f,0.7036304f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 8.648162f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 8.648162f);
Get(0xDD1E).SetLocalPose(1.44547f,1.243514f,0.8482112f,0.5779434f,-0.546047f,0.4048717f,-0.4515452f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44837f,1.365507f,0.7839321f,-0.7098884f,0.01375732f,0.02837412f,0.7036079f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 8.656785f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 8.656785f);
Get(0xDD1E).SetLocalPose(1.445516f,1.242647f,0.8479783f,0.5779154f,-0.5460411f,0.4049009f,-0.451562f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448397f,1.365295f,0.7838383f,-0.7099777f,0.01368585f,0.0284511f,0.7035161f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 8.677262f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 8.677262f);
Get(0xDD1E).SetLocalPose(1.445502f,1.241605f,0.8475361f,0.5776647f,-0.5462022f,0.405029f,-0.451573f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44829f,1.365134f,0.7837147f,-0.7100379f,0.01362527f,0.02852208f,0.7034537f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 8.696378f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 8.696378f);
Get(0xDD1E).SetLocalPose(1.445744f,1.241625f,0.8471946f,0.5775957f,-0.5462799f,0.4051192f,-0.4514865f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44846f,1.364883f,0.7837839f,-0.7101039f,0.01359181f,0.02855663f,0.7033864f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 8.714727f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 8.714727f);
Get(0xDD1E).SetLocalPose(1.446395f,1.241822f,0.8468398f,0.5778513f,-0.5460908f,0.4050246f,-0.4514728f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448413f,1.364691f,0.7836143f,-0.7101179f,0.01358217f,0.0285624f,0.7033721f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 8.733218f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 8.733218f);
Get(0xDD1E).SetLocalPose(1.446349f,1.241979f,0.8468315f,0.5781324f,-0.5459093f,0.404952f,-0.4513977f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448593f,1.364413f,0.7836581f,-0.7101304f,0.01358693f,0.02860247f,0.7033578f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 8.741815f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 8.741815f);
Get(0xDD1E).SetLocalPose(1.445987f,1.241989f,0.8468511f,0.5782197f,-0.54589f,0.4049664f,-0.4512962f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448581f,1.364251f,0.7835225f,-0.7101336f,0.0135845f,0.02858933f,0.7033552f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 8.76145f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 8.76145f);
Get(0xDD1E).SetLocalPose(1.446334f,1.242239f,0.8466761f,0.5781112f,-0.5459706f,0.4051445f,-0.4511779f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448812f,1.364126f,0.7835471f,-0.7100677f,0.01360778f,0.02858424f,0.7034214f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 8.780062f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 8.780062f);
Get(0xDD1E).SetLocalPose(1.44646f,1.241746f,0.8467601f,0.5778841f,-0.5462024f,0.4052184f,-0.4511219f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448725f,1.364395f,0.7834754f,-0.7099812f,0.01364055f,0.02853068f,0.7035102f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 8.798399f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 8.798399f);
Get(0xDD1E).SetLocalPose(1.44644f,1.241441f,0.8469532f,0.5780075f,-0.5461441f,0.4049667f,-0.4512603f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448871f,1.364596f,0.7835123f,-0.7099132f,0.01372384f,0.02850515f,0.7035783f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 8.816323f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 8.816323f);
Get(0xDD1E).SetLocalPose(1.446608f,1.241439f,0.8470495f,0.5784047f,-0.5458501f,0.4046454f,-0.4513953f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448679f,1.364638f,0.7833411f,-0.7098562f,0.01375851f,0.02847178f,0.7036365f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 8.824493f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 8.824493f);
Get(0xDD1E).SetLocalPose(1.446418f,1.241371f,0.8464706f,0.5784616f,-0.5457619f,0.4046595f,-0.4514165f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448818f,1.364716f,0.7834676f,-0.7098059f,0.01376467f,0.02841862f,0.7036892f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 8.84352f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 8.84352f);
Get(0xDD1E).SetLocalPose(1.446379f,1.241595f,0.8456625f,0.5783386f,-0.5458421f,0.404677f,-0.4514615f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448571f,1.365091f,0.7834178f,-0.7097599f,0.0138292f,0.02832571f,0.7037382f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 8.862215f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 8.862215f);
Get(0xDD1E).SetLocalPose(1.446437f,1.241861f,0.8453157f,0.5781738f,-0.5460538f,0.404641f,-0.4514489f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448505f,1.365369f,0.7835521f,-0.7097411f,0.01385792f,0.02829432f,0.7037578f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 8.8794f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 8.8794f);
Get(0xDD1E).SetLocalPose(1.446443f,1.242445f,0.8450326f,0.5781168f,-0.5462191f,0.4044578f,-0.4514859f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448481f,1.365608f,0.7835982f,-0.7097631f,0.0138706f,0.02830972f,0.7037348f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 8.897116f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 8.897116f);
Get(0xDD1E).SetLocalPose(1.446525f,1.242036f,0.8448296f,0.5781592f,-0.5462508f,0.404238f,-0.4515903f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44849f,1.36574f,0.78354f,-0.7097778f,0.01386234f,0.02830208f,0.7037205f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 8.915859f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 8.915859f);
Get(0xDD1E).SetLocalPose(1.44646f,1.242454f,0.8449412f,0.5781978f,-0.5462375f,0.4042515f,-0.4515448f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448451f,1.365737f,0.7834699f,-0.7098212f,0.01385909f,0.02830644f,0.7036765f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 8.923973f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 8.923973f);
Get(0xDD1E).SetLocalPose(1.446049f,1.243274f,0.8448498f,0.5782275f,-0.546245f,0.4042989f,-0.4514551f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448528f,1.365605f,0.7837138f,-0.709904f,0.01382197f,0.02832157f,0.7035931f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 8.943449f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 8.943449f);
Get(0xDD1E).SetLocalPose(1.445583f,1.243124f,0.8448289f,0.5783193f,-0.5462824f,0.4043005f,-0.451291f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448425f,1.365593f,0.7836971f,-0.7099518f,0.0137899f,0.02836218f,0.7035438f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 8.961576f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 8.961576f);
Get(0xDD1E).SetLocalPose(1.445447f,1.243233f,0.8448386f,0.578201f,-0.5464976f,0.4042781f,-0.451202f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44841f,1.365262f,0.784007f,-0.7100012f,0.01374219f,0.02842854f,0.7034922f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 8.979653f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 8.979653f);
Get(0xDD1E).SetLocalPose(1.445262f,1.244033f,0.8446117f,0.5780452f,-0.5466956f,0.4042055f,-0.4512268f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448276f,1.36521f,0.7840493f,-0.7100409f,0.0136988f,0.02841412f,0.7034536f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 8.998023f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 8.998023f);
Get(0xDD1E).SetLocalPose(1.445334f,1.244352f,0.8443079f,0.5782167f,-0.5466144f,0.4039258f,-0.451356f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448069f,1.364912f,0.7839046f,-0.7100508f,0.01370839f,0.02845203f,0.7034419f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 9.016208f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 9.016208f);
Get(0xDD1E).SetLocalPose(1.444847f,1.244176f,0.8444319f,0.578298f,-0.5466786f,0.4039216f,-0.4511777f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448092f,1.364701f,0.7838355f,-0.7100586f,0.01367272f,0.02846006f,0.7034344f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 9.024069f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 9.024069f);
Get(0xDD1E).SetLocalPose(1.444476f,1.243277f,0.844609f,0.5782849f,-0.5467209f,0.4040271f,-0.4510488f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447997f,1.36441f,0.7837342f,-0.7100211f,0.01367681f,0.02848884f,0.703471f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 9.043269f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 9.043269f);
Get(0xDD1E).SetLocalPose(1.444142f,1.242793f,0.8444195f,0.5782778f,-0.5468325f,0.4042513f,-0.4507215f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448176f,1.364314f,0.7836698f,-0.7099971f,0.01364304f,0.02849779f,0.7034956f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 9.06085f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 9.06085f);
Get(0xDD1E).SetLocalPose(1.444374f,1.24252f,0.8441963f,0.578197f,-0.5470094f,0.4042752f,-0.4505891f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448432f,1.364212f,0.7838417f,-0.7099735f,0.01367025f,0.02848937f,0.7035192f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 9.079003f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 9.079003f);
Get(0xDD1E).SetLocalPose(1.444007f,1.242204f,0.8439771f,0.5779269f,-0.5472628f,0.404308f,-0.4505985f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448361f,1.364351f,0.7837002f,-0.7099134f,0.01376795f,0.0284354f,0.7035801f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 9.098818f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 9.098818f);
Get(0xDD1E).SetLocalPose(1.443837f,1.242355f,0.8443968f,0.5779752f,-0.5472411f,0.404277f,-0.4505908f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448369f,1.364426f,0.7836791f,-0.7099206f,0.01377252f,0.02842554f,0.7035732f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 9.107208f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 9.107208f);
Get(0xDD1E).SetLocalPose(1.443805f,1.242082f,0.8446551f,0.5781614f,-0.5471469f,0.4041969f,-0.4505381f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448426f,1.364496f,0.7836251f,-0.7098927f,0.01384806f,0.02834847f,0.703603f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 9.12698f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 9.12698f);
Get(0xDD1E).SetLocalPose(1.444064f,1.24232f,0.8449417f,0.5785102f,-0.5469702f,0.4040315f,-0.4504534f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448487f,1.364839f,0.7836198f,-0.7098637f,0.01389948f,0.02829296f,0.7036334f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 9.145067f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 9.145067f);
Get(0xDD1E).SetLocalPose(1.44339f,1.24189f,0.8441451f,0.5783206f,-0.5471786f,0.4042111f,-0.4502824f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448227f,1.364779f,0.7835618f,-0.7098445f,0.01393446f,0.02825159f,0.7036538f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 9.163194f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 9.163194f);
Get(0xDD1E).SetLocalPose(1.443387f,1.241707f,0.8444412f,0.578043f,-0.5474539f,0.4043635f,-0.4501673f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448313f,1.365075f,0.7837154f,-0.7098541f,0.01391062f,0.02824419f,0.7036448f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 9.181437f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 9.181437f);
Get(0xDD1E).SetLocalPose(1.443357f,1.242076f,0.8444936f,0.5779638f,-0.5475551f,0.404438f,-0.4500791f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448205f,1.365272f,0.7837512f,-0.7098476f,0.0138955f,0.02826619f,0.7036508f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 9.199204f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 9.199204f);
Get(0xDD1E).SetLocalPose(1.443398f,1.243053f,0.8445554f,0.5782527f,-0.5473374f,0.4043175f,-0.4500811f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448243f,1.365137f,0.783705f,-0.7098718f,0.01389161f,0.02826536f,0.7036265f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 9.207265f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 9.207265f);
Get(0xDD1E).SetLocalPose(1.443774f,1.242658f,0.8443573f,0.5783793f,-0.5472283f,0.4042263f,-0.4501331f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448245f,1.365249f,0.783731f,-0.7098803f,0.01383708f,0.0283026f,0.7036175f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 9.225889f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 9.225889f);
Get(0xDD1E).SetLocalPose(1.443803f,1.242739f,0.8441641f,0.5785008f,-0.5471664f,0.4041553f,-0.4501159f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448344f,1.365233f,0.7838893f,-0.7099142f,0.01379846f,0.02836771f,0.7035814f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 9.243913f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 9.243913f);
Get(0xDD1E).SetLocalPose(1.4436f,1.24294f,0.8442457f,0.5783542f,-0.5472683f,0.4042359f,-0.450108f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448284f,1.365206f,0.7839382f,-0.7099592f,0.01374606f,0.02840632f,0.7035355f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 9.262225f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 9.262225f);
Get(0xDD1E).SetLocalPose(1.443617f,1.243478f,0.8445436f,0.5780334f,-0.5475514f,0.4043719f,-0.4500535f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448214f,1.364988f,0.7838383f,-0.7099942f,0.01374512f,0.02841456f,0.7034999f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 9.279805f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 9.279805f);
Get(0xDD1E).SetLocalPose(1.444041f,1.243924f,0.8445069f,0.5779553f,-0.5476851f,0.4042729f,-0.4500802f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448382f,1.364813f,0.7839127f,-0.7100014f,0.01367448f,0.02847217f,0.7034916f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 9.297818f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 9.297818f);
Get(0xDD1E).SetLocalPose(1.4441f,1.244197f,0.8443519f,0.5782027f,-0.5475786f,0.4040641f,-0.4500795f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448386f,1.364886f,0.7840036f,-0.7100125f,0.01365134f,0.02847032f,0.7034808f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 9.316335f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 9.316335f);
Get(0xDD1E).SetLocalPose(1.443834f,1.244102f,0.8444992f,0.5784165f,-0.5474762f,0.4040568f,-0.4499359f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448571f,1.364664f,0.7839304f,-0.7100031f,0.01364804f,0.02848543f,0.7034899f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 9.324676f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 9.324676f);
Get(0xDD1E).SetLocalPose(1.443689f,1.243844f,0.844328f,0.578374f,-0.5475554f,0.4041528f,-0.4498079f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448606f,1.364631f,0.7839522f,-0.7099943f,0.01370881f,0.02845582f,0.7034988f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 9.343562f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 9.343562f);
Get(0xDD1E).SetLocalPose(1.443524f,1.243785f,0.8441571f,0.5781176f,-0.5478104f,0.4043013f,-0.4496936f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448655f,1.364597f,0.7839764f,-0.7099739f,0.01374771f,0.02840622f,0.7035206f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 9.360833f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 9.360833f);
Get(0xDD1E).SetLocalPose(1.443263f,1.243368f,0.8443741f,0.5780798f,-0.5479009f,0.4042009f,-0.4497221f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448482f,1.364816f,0.7840271f,-0.7099388f,0.01379919f,0.02838256f,0.703556f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 9.379218f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 9.379218f);
Get(0xDD1E).SetLocalPose(1.443191f,1.243287f,0.8446066f,0.5782478f,-0.5478194f,0.4040106f,-0.4497763f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448471f,1.365085f,0.7839141f,-0.709918f,0.01380988f,0.0283599f,0.7035776f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 9.396902f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 9.396902f);
Get(0xDD1E).SetLocalPose(1.443203f,1.243384f,0.8449296f,0.5784924f,-0.5476646f,0.4038996f,-0.4497502f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44837f,1.364967f,0.7837732f,-0.7098937f,0.01384021f,0.02834051f,0.7036024f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 9.415724f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 9.415724f);
Get(0xDD1E).SetLocalPose(1.443137f,1.242745f,0.8446777f,0.5784636f,-0.5476977f,0.4038607f,-0.4497818f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448292f,1.365011f,0.7837226f,-0.7098871f,0.01384887f,0.02834713f,0.7036086f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 9.423946f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 9.423946f);
Get(0xDD1E).SetLocalPose(1.442958f,1.24276f,0.8449636f,0.5783474f,-0.5478062f,0.4039277f,-0.4497389f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448374f,1.365255f,0.7838287f,-0.7098782f,0.01385123f,0.02834002f,0.7036178f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 9.442873f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 9.442873f);
Get(0xDD1E).SetLocalPose(1.442533f,1.242844f,0.8448012f,0.5781591f,-0.548004f,0.4039786f,-0.4496944f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448462f,1.365195f,0.7839129f,-0.7098677f,0.01383021f,0.02832438f,0.7036294f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 9.461651f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 9.461651f);
Get(0xDD1E).SetLocalPose(1.442725f,1.24285f,0.8445428f,0.5782201f,-0.5479451f,0.403854f,-0.4497995f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448498f,1.365218f,0.783806f,-0.7098702f,0.01379569f,0.02835432f,0.7036263f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 9.479749f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 9.479749f);
Get(0xDD1E).SetLocalPose(1.442666f,1.243451f,0.8443035f,0.5783047f,-0.5478072f,0.4039176f,-0.4498016f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448326f,1.365022f,0.7837761f,-0.7098963f,0.01379058f,0.02839933f,0.7035983f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 9.49789f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 9.49789f);
Get(0xDD1E).SetLocalPose(1.442701f,1.243452f,0.8442543f,0.5783988f,-0.5477014f,0.4040349f,-0.449704f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448398f,1.365092f,0.7838753f,-0.7099158f,0.01377219f,0.02840711f,0.7035788f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 9.516276f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 9.516276f);
Get(0xDD1E).SetLocalPose(1.442354f,1.243096f,0.8440733f,0.5783327f,-0.5476705f,0.4042331f,-0.4496488f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448361f,1.365127f,0.7838538f,-0.7099369f,0.01375041f,0.02841864f,0.7035575f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 9.524257f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 9.524257f);
Get(0xDD1E).SetLocalPose(1.442132f,1.243056f,0.8441254f,0.578288f,-0.5476937f,0.404207f,-0.4497015f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448328f,1.365039f,0.7838885f,-0.7099523f,0.01375624f,0.02842414f,0.7035416f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 9.543221f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 9.543221f);
Get(0xDD1E).SetLocalPose(1.442046f,1.242356f,0.8439357f,0.5783114f,-0.5476772f,0.4039633f,-0.4499102f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448398f,1.364904f,0.7838179f,-0.7099618f,0.01377016f,0.02842117f,0.7035317f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 9.561294f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 9.561294f);
Get(0xDD1E).SetLocalPose(1.441983f,1.242431f,0.8436828f,0.578235f,-0.5477067f,0.4039346f,-0.4499984f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448346f,1.364783f,0.7837375f,-0.7099749f,0.01378073f,0.02841555f,0.7035185f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 9.579276f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 9.579276f);
Get(0xDD1E).SetLocalPose(1.442677f,1.242586f,0.844119f,0.5782335f,-0.5476865f,0.4040071f,-0.4499598f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448349f,1.36481f,0.7836732f,-0.7099668f,0.01379282f,0.02840469f,0.7035269f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 9.597656f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 9.597656f);
Get(0xDD1E).SetLocalPose(1.44251f,1.242498f,0.8442523f,0.5782934f,-0.5476657f,0.4041352f,-0.4497931f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44834f,1.364784f,0.7837096f,-0.7099945f,0.01377697f,0.02842016f,0.7034987f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 9.615262f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 9.615262f);
Get(0xDD1E).SetLocalPose(1.442569f,1.242212f,0.8442557f,0.5784031f,-0.5476219f,0.4041587f,-0.4496841f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448412f,1.364781f,0.7837337f,-0.7099401f,0.0138161f,0.02840085f,0.7035536f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 9.632744f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 9.632744f);
Get(0xDD1E).SetLocalPose(1.44258f,1.242393f,0.8443183f,0.5783365f,-0.5476913f,0.4041312f,-0.4497102f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448284f,1.36479f,0.7836741f,-0.7099184f,0.0138405f,0.02838935f,0.7035754f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 9.640725f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 9.640725f);
Get(0xDD1E).SetLocalPose(1.442704f,1.242625f,0.844201f,0.5782149f,-0.5477902f,0.4040772f,-0.4497945f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44836f,1.364991f,0.7837868f,-0.7099171f,0.01383651f,0.02837503f,0.7035775f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 9.65972f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 9.65972f);
Get(0xDD1E).SetLocalPose(1.442854f,1.243374f,0.84424f,0.5782139f,-0.5477875f,0.4041046f,-0.4497745f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448347f,1.364954f,0.783917f,-0.7099033f,0.01384157f,0.02838179f,0.7035909f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 9.677381f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 9.677381f);
Get(0xDD1E).SetLocalPose(1.443232f,1.243255f,0.8444454f,0.5782548f,-0.5477605f,0.4041575f,-0.4497072f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448481f,1.364908f,0.7839463f,-0.709912f,0.01383137f,0.02837316f,0.7035828f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 9.695626f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 9.695626f);
Get(0xDD1E).SetLocalPose(1.442809f,1.242717f,0.8438739f,0.5782145f,-0.5477444f,0.4043339f,-0.4496202f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448382f,1.364948f,0.7839015f,-0.7099131f,0.01381277f,0.02837184f,0.703582f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 9.713711f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 9.713711f);
Get(0xDD1E).SetLocalPose(1.442973f,1.242592f,0.8437974f,0.578217f,-0.5477234f,0.4044222f,-0.4495629f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448401f,1.364899f,0.7838564f,-0.7099101f,0.01381637f,0.0283637f,0.7035853f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 9.7322f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 9.7322f);
Get(0xDD1E).SetLocalPose(1.442702f,1.242909f,0.8436018f,0.5781425f,-0.5477494f,0.4045083f,-0.4495499f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448503f,1.36493f,0.7839411f,-0.709932f,0.01383848f,0.02836741f,0.7035627f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 9.740193f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 9.740193f);
Get(0xDD1E).SetLocalPose(1.442736f,1.242929f,0.8435739f,0.5780911f,-0.5477748f,0.4045109f,-0.4495824f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448374f,1.365068f,0.7840737f,-0.7099568f,0.01381127f,0.02835285f,0.7035387f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 9.759569f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 9.759569f);
Get(0xDD1E).SetLocalPose(1.442833f,1.24347f,0.8438051f,0.5779097f,-0.5478598f,0.4045816f,-0.4496486f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448272f,1.365042f,0.7841828f,-0.7099942f,0.01379546f,0.02836567f,0.7035008f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 9.777733f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 9.777733f);
Get(0xDD1E).SetLocalPose(1.443239f,1.243503f,0.8443938f,0.5779652f,-0.5477632f,0.4045558f,-0.4497181f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448179f,1.364891f,0.7839732f,-0.7100181f,0.01377949f,0.02838022f,0.7034764f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 9.79756f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 9.79756f);
Get(0xDD1E).SetLocalPose(1.443359f,1.243767f,0.8443809f,0.5781327f,-0.5475338f,0.4045907f,-0.4497506f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448202f,1.364988f,0.7841368f,-0.710023f,0.01381532f,0.02836698f,0.7034713f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 9.816223f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 9.816223f);
Get(0xDD1E).SetLocalPose(1.44326f,1.242762f,0.8441269f,0.5781476f,-0.5474603f,0.4047075f,-0.449716f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448119f,1.3649f,0.7840155f,-0.7100187f,0.01379175f,0.02836279f,0.7034763f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 9.824918f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 9.824918f);
Get(0xDD1E).SetLocalPose(1.443505f,1.242278f,0.8440865f,0.5781096f,-0.5474808f,0.4047476f,-0.4497038f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448346f,1.364903f,0.7841173f,-0.7099872f,0.0137812f,0.02837786f,0.7035078f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 9.845185f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 9.845185f);
Get(0xDD1E).SetLocalPose(1.44347f,1.242386f,0.8436734f,0.5777995f,-0.5476564f,0.4047963f,-0.4498446f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448263f,1.364959f,0.7841656f,-0.7099696f,0.0137514f,0.02839004f,0.7035255f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 9.863773f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 9.863773f);
Get(0xDD1E).SetLocalPose(1.443901f,1.243026f,0.8439077f,0.5776854f,-0.5477833f,0.4046974f,-0.4499258f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448359f,1.365039f,0.7842696f,-0.7099518f,0.01379511f,0.0283883f,0.7035427f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 9.88263f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 9.88263f);
Get(0xDD1E).SetLocalPose(1.443941f,1.243398f,0.8439648f,0.5778575f,-0.5476378f,0.4047111f,-0.4498696f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448298f,1.364975f,0.7840832f,-0.7099394f,0.01381526f,0.02838202f,0.7035551f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 9.891163f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 9.891163f);
Get(0xDD1E).SetLocalPose(1.443943f,1.243451f,0.8438866f,0.5779442f,-0.5475444f,0.4047594f,-0.4498284f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448313f,1.364944f,0.7838988f,-0.7099124f,0.01383126f,0.02834787f,0.7035834f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 9.910629f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 9.910629f);
Get(0xDD1E).SetLocalPose(1.443959f,1.244029f,0.8438084f,0.5779398f,-0.5475581f,0.4049414f,-0.4496535f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448409f,1.364713f,0.7839478f,-0.7099246f,0.01383056f,0.02832587f,0.703572f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 9.930269f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 9.930269f);
Get(0xDD1E).SetLocalPose(1.443792f,1.243724f,0.8439701f,0.577629f,-0.5477579f,0.4052189f,-0.4495595f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448395f,1.364817f,0.7841211f,-0.7099448f,0.01384256f,0.02832767f,0.7035512f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 9.948665f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 9.948665f);
Get(0xDD1E).SetLocalPose(1.444224f,1.243198f,0.8443125f,0.5774925f,-0.54785f,0.4052064f,-0.449634f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448413f,1.364813f,0.7841096f,-0.7099334f,0.01385683f,0.02832928f,0.7035624f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 9.95677f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 9.95677f);
Get(0xDD1E).SetLocalPose(1.444129f,1.243232f,0.8443714f,0.5774024f,-0.5478826f,0.4052031f,-0.4497128f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448322f,1.364928f,0.7839374f,-0.7099456f,0.0138162f,0.02833759f,0.7035506f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 9.976232f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 9.976232f);
Get(0xDD1E).SetLocalPose(1.44427f,1.242864f,0.8444006f,0.5774786f,-0.5477716f,0.4051035f,-0.4498399f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448246f,1.365183f,0.7839922f,-0.7099624f,0.01382246f,0.0283405f,0.7035334f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 9.994983f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 9.994983f);
Get(0xDD1E).SetLocalPose(1.444676f,1.242854f,0.844286f,0.5775801f,-0.547699f,0.4051146f,-0.449788f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.4484f,1.365283f,0.7840578f,-0.70997f,0.01382043f,0.02834641f,0.7035255f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 10.01371f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 10.01371f);
Get(0xDD1E).SetLocalPose(1.44449f,1.242396f,0.8442776f,0.5775225f,-0.5477268f,0.4051328f,-0.4498116f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448408f,1.365276f,0.7841949f,-0.7099828f,0.01379562f,0.02835315f,0.7035128f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 10.03242f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 10.03242f);
Get(0xDD1E).SetLocalPose(1.444595f,1.242894f,0.8439695f,0.5774009f,-0.547839f,0.4052597f,-0.449717f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448356f,1.36497f,0.784148f,-0.709999f,0.01378461f,0.02839453f,0.703495f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 10.04066f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 10.04066f);
Get(0xDD1E).SetLocalPose(1.444813f,1.242164f,0.8439069f,0.5773954f,-0.5478205f,0.4052993f,-0.4497107f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448394f,1.364772f,0.784096f,-0.71f,0.01376614f,0.02836813f,0.7034954f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 10.06058f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 10.06058f);
Get(0xDD1E).SetLocalPose(1.445006f,1.241647f,0.8436058f,0.5775761f,-0.5476248f,0.4051091f,-0.4498883f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448459f,1.364884f,0.7842217f,-0.7099853f,0.01375472f,0.028395f,0.7035094f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 10.07949f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 10.07949f);
Get(0xDD1E).SetLocalPose(1.445813f,1.242461f,0.8432605f,0.5777349f,-0.5474519f,0.4049788f,-0.4500123f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448408f,1.364925f,0.7841498f,-0.7099586f,0.01375551f,0.02838668f,0.7035366f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 10.09792f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 10.09792f);
Get(0xDD1E).SetLocalPose(1.446042f,1.24298f,0.8433202f,0.5776616f,-0.5475537f,0.4053032f,-0.4496903f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448672f,1.36489f,0.7842183f,-0.7099622f,0.01373033f,0.02840745f,0.7035327f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 10.11666f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 10.11666f);
Get(0xDD1E).SetLocalPose(1.446267f,1.242159f,0.8431786f,0.5774847f,-0.5477575f,0.4057012f,-0.4493104f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448716f,1.364875f,0.7842342f,-0.709947f,0.0137447f,0.02839381f,0.7035482f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 10.12502f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 10.12502f);
Get(0xDD1E).SetLocalPose(1.445992f,1.242662f,0.8427652f,0.5773324f,-0.5479209f,0.4058607f,-0.4491627f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448611f,1.36486f,0.7839401f,-0.7099082f,0.01375537f,0.02840021f,0.703587f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 10.14512f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 10.14512f);
Get(0xDD1E).SetLocalPose(1.446296f,1.242498f,0.842435f,0.5774283f,-0.54786f,0.4059128f,-0.4490666f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448621f,1.365067f,0.783931f,-0.7098975f,0.01379074f,0.02839939f,0.7035972f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 10.16363f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 10.16363f);
Get(0xDD1E).SetLocalPose(1.446151f,1.242955f,0.8424978f,0.5775936f,-0.5477618f,0.4057586f,-0.4491133f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448537f,1.36523f,0.7838179f,-0.7098823f,0.01380444f,0.02837449f,0.7036132f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 10.1833f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 10.1833f);
Get(0xDD1E).SetLocalPose(1.446051f,1.24304f,0.8426307f,0.5775629f,-0.5478164f,0.4058419f,-0.4490109f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448542f,1.365106f,0.7838028f,-0.7099083f,0.01380373f,0.0283566f,0.7035877f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 10.19184f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 10.19184f);
Get(0xDD1E).SetLocalPose(1.446154f,1.242254f,0.8427513f,0.5775451f,-0.5478224f,0.4058333f,-0.4490342f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44857f,1.365172f,0.7837784f,-0.7099233f,0.01380793f,0.02833211f,0.7035735f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 10.21196f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 10.21196f);
Get(0xDD1E).SetLocalPose(1.446279f,1.242689f,0.8426264f,0.5774326f,-0.5478999f,0.4058233f,-0.4490932f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448439f,1.365238f,0.7840484f,-0.7099224f,0.01384417f,0.02834572f,0.7035732f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 10.23037f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 10.23037f);
Get(0xDD1E).SetLocalPose(1.446499f,1.243078f,0.8424867f,0.5773004f,-0.5479695f,0.4058264f,-0.4491755f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448304f,1.365059f,0.7838899f,-0.7099369f,0.01385865f,0.02832704f,0.7035589f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 10.24881f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 10.24881f);
Get(0xDD1E).SetLocalPose(1.446345f,1.243287f,0.8432482f,0.5772592f,-0.5479139f,0.4055618f,-0.4495351f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448284f,1.365075f,0.7838773f,-0.7099297f,0.0138539f,0.0283315f,0.7035662f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 10.25772f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 10.25772f);
Get(0xDD1E).SetLocalPose(1.446413f,1.242632f,0.8434728f,0.5772972f,-0.547857f,0.4053428f,-0.449753f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448132f,1.364848f,0.7837906f,-0.7099262f,0.01382283f,0.02836449f,0.7035689f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 10.27692f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 10.27692f);
Get(0xDD1E).SetLocalPose(1.446576f,1.243548f,0.8436338f,0.5772036f,-0.5478896f,0.4052388f,-0.4499273f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448166f,1.364673f,0.7837158f,-0.7099068f,0.01379062f,0.02838345f,0.7035884f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 10.29569f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 10.29569f);
Get(0xDD1E).SetLocalPose(1.446436f,1.245074f,0.844174f,0.5771126f,-0.5479814f,0.4050766f,-0.4500783f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448053f,1.364818f,0.7836342f,-0.7099062f,0.01382186f,0.02839631f,0.7035878f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 10.31411f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 10.31411f);
Get(0xDD1E).SetLocalPose(1.446393f,1.245697f,0.8441835f,0.5770777f,-0.5480629f,0.4046375f,-0.4504185f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447968f,1.364828f,0.7835902f,-0.7099012f,0.01382941f,0.02839614f,0.7035928f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 10.33169f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 10.33169f);
Get(0xDD1E).SetLocalPose(1.446412f,1.246939f,0.8442913f,0.576961f,-0.5483197f,0.4041865f,-0.4506605f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448071f,1.364903f,0.7835048f,-0.7099084f,0.0138211f,0.02841276f,0.703585f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 10.34945f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 10.34945f);
Get(0xDD1E).SetLocalPose(1.446323f,1.247539f,0.8443958f,0.5766748f,-0.5486332f,0.4038225f,-0.4509714f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448119f,1.364871f,0.7836192f,-0.709913f,0.01382008f,0.02840499f,0.7035806f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 10.35803f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 10.35803f);
Get(0xDD1E).SetLocalPose(1.446031f,1.247632f,0.8440274f,0.5763567f,-0.5489164f,0.4036887f,-0.4511532f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448219f,1.364796f,0.7835388f,-0.7099023f,0.01381763f,0.02839614f,0.7035919f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 10.3771f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 10.3771f);
Get(0xDD1E).SetLocalPose(1.445477f,1.248699f,0.8429128f,0.5758887f,-0.549385f,0.4033165f,-0.4515132f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448171f,1.364891f,0.7835157f,-0.7098836f,0.01382073f,0.02842767f,0.7036094f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 10.39527f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 10.39527f);
Get(0xDD1E).SetLocalPose(1.445419f,1.249374f,0.8428234f,0.5756344f,-0.5496072f,0.402834f,-0.4519975f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448365f,1.364845f,0.7834886f,-0.7098957f,0.01380099f,0.02839816f,0.7035987f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 10.41343f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 10.41343f);
Get(0xDD1E).SetLocalPose(1.444942f,1.251359f,0.8417611f,0.5751834f,-0.5499493f,0.4023895f,-0.4525512f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448493f,1.364915f,0.7836048f,-0.7098956f,0.01381225f,0.02840874f,0.7035983f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 10.43107f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 10.43107f);
Get(0xDD1E).SetLocalPose(1.444952f,1.252575f,0.8414084f,0.5746293f,-0.550349f,0.4018861f,-0.453216f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448502f,1.364847f,0.7835904f,-0.709905f,0.01380156f,0.02838286f,0.70359f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 10.44999f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 10.44999f);
Get(0xDD1E).SetLocalPose(1.445376f,1.25406f,0.8409408f,0.5738899f,-0.5508641f,0.4012323f,-0.4541055f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448574f,1.36491f,0.7836989f,-0.7099093f,0.01379596f,0.02839664f,0.7035853f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 10.458f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 10.458f);
Get(0xDD1E).SetLocalPose(1.44525f,1.254576f,0.8405063f,0.5734329f,-0.5512013f,0.4008612f,-0.4546012f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448565f,1.364819f,0.7837387f,-0.7099171f,0.0137834f,0.02840027f,0.7035774f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 10.47767f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 10.47767f);
Get(0xDD1E).SetLocalPose(1.445428f,1.256285f,0.8404678f,0.5727891f,-0.5516853f,0.4002396f,-0.4553726f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448658f,1.365119f,0.7841105f,-0.7099282f,0.01377934f,0.02839231f,0.7035667f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 10.49547f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 10.49547f);
Get(0xDD1E).SetLocalPose(1.444917f,1.259033f,0.8406552f,0.5721281f,-0.5521716f,0.3998181f,-0.4559842f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448451f,1.364897f,0.784142f,-0.7099615f,0.01379405f,0.02840343f,0.7035323f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 10.5141f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 10.5141f);
Get(0xDD1E).SetLocalPose(1.445346f,1.261838f,0.8406683f,0.5714327f,-0.552629f,0.3990052f,-0.4570128f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448505f,1.365023f,0.7842453f,-0.7099583f,0.01379669f,0.02837991f,0.7035364f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 10.53224f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 10.53224f);
Get(0xDD1E).SetLocalPose(1.445456f,1.262755f,0.8401284f,0.5707145f,-0.5531625f,0.3983248f,-0.4578577f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448514f,1.365054f,0.7841903f,-0.7099354f,0.01380149f,0.02842639f,0.7035576f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 10.54081f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 10.54081f);
Get(0xDD1E).SetLocalPose(1.445615f,1.263649f,0.8400313f,0.5702885f,-0.5534683f,0.3980329f,-0.4582724f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448425f,1.364909f,0.7840463f,-0.7099319f,0.01378605f,0.02840825f,0.7035621f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 10.55995f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 10.55995f);
Get(0xDD1E).SetLocalPose(1.444774f,1.267183f,0.8404677f,0.569459f,-0.5541392f,0.3978308f,-0.4586686f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448398f,1.364907f,0.7839527f,-0.7099391f,0.01376888f,0.0284134f,0.703555f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 10.57842f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 10.57842f);
Get(0xDD1E).SetLocalPose(1.444727f,1.268663f,0.8407907f,0.5686166f,-0.554829f,0.3975821f,-0.4590954f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44849f,1.364926f,0.7839991f,-0.7099596f,0.01379772f,0.02839214f,0.7035346f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 10.59629f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 10.59629f);
Get(0xDD1E).SetLocalPose(1.444834f,1.269702f,0.8406182f,0.5680645f,-0.5552997f,0.3971528f,-0.4595809f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44837f,1.364926f,0.7841261f,-0.709967f,0.01380906f,0.02839603f,0.7035268f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 10.61488f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 10.61488f);
Get(0xDD1E).SetLocalPose(1.445423f,1.269527f,0.8410458f,0.5676756f,-0.5556105f,0.3969248f,-0.4598828f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448219f,1.36516f,0.7840071f,-0.7099445f,0.01385291f,0.02837841f,0.7035493f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 10.63264f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 10.63264f);
Get(0xDD1E).SetLocalPose(1.445445f,1.270362f,0.8410041f,0.5671092f,-0.556035f,0.3967503f,-0.4602188f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448222f,1.365198f,0.7840089f,-0.7099445f,0.0138365f,0.02836191f,0.7035503f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 10.64057f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 10.64057f);
Get(0xDD1E).SetLocalPose(1.445333f,1.270197f,0.841043f,0.5667962f,-0.5562057f,0.3967005f,-0.4604411f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448363f,1.36514f,0.7840198f,-0.7099546f,0.01387694f,0.02835752f,0.7035395f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 10.65997f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 10.65997f);
Get(0xDD1E).SetLocalPose(1.44566f,1.270697f,0.841045f,0.5665059f,-0.5563607f,0.3965468f,-0.4607435f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448372f,1.364985f,0.7839382f,-0.7099479f,0.01384652f,0.02838749f,0.7035456f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 10.67819f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 10.67819f);
Get(0xDD1E).SetLocalPose(1.444993f,1.271431f,0.8405092f,0.5662307f,-0.5565613f,0.3965206f,-0.460862f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448279f,1.365139f,0.7839462f,-0.7099507f,0.0138346f,0.02835784f,0.7035442f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 10.69623f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 10.69623f);
Get(0xDD1E).SetLocalPose(1.445001f,1.272088f,0.8404741f,0.5659198f,-0.5568079f,0.3964888f,-0.4609732f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448216f,1.36488f,0.783837f,-0.7099265f,0.01385932f,0.02835516f,0.7035683f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 10.7108f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 10.7108f);
Get(0xDD1E).SetLocalPose(1.444931f,1.272334f,0.8401744f,0.5656883f,-0.556964f,0.3962224f,-0.461298f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448181f,1.364737f,0.7837438f,-0.7099322f,0.01385961f,0.02835918f,0.7035624f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 10.72528f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 10.72528f);
Get(0xDD1E).SetLocalPose(1.4451f,1.272523f,0.8402312f,0.5656182f,-0.5570364f,0.3961517f,-0.4613571f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44825f,1.364838f,0.7839286f,-0.7099542f,0.01386767f,0.02835874f,0.70354f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 10.74578f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 10.74578f);
Get(0xDD1E).SetLocalPose(1.446159f,1.273357f,0.8411269f,0.5655985f,-0.5571017f,0.3962515f,-0.4612167f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448243f,1.36483f,0.7838817f,-0.7099391f,0.01386756f,0.02838537f,0.7035542f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 10.76632f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 10.76632f);
Get(0xDD1E).SetLocalPose(1.446256f,1.273663f,0.8408664f,0.5653716f,-0.5572888f,0.3966592f,-0.4609182f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448226f,1.364814f,0.7838613f,-0.7099431f,0.01386404f,0.0283789f,0.7035505f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 10.77532f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 10.77532f);
Get(0xDD1E).SetLocalPose(1.446459f,1.273712f,0.8409228f,0.5653539f,-0.5573577f,0.3967054f,-0.4608168f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447951f,1.364737f,0.7836236f,-0.7099245f,0.01384949f,0.02838669f,0.7035692f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 10.79651f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 10.79651f);
Get(0xDD1E).SetLocalPose(1.447426f,1.274345f,0.8419583f,0.565348f,-0.5575241f,0.396622f,-0.4606947f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448132f,1.364732f,0.7836949f,-0.7099421f,0.01381404f,0.02841676f,0.7035509f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 10.81553f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 10.81553f);
Get(0xDD1E).SetLocalPose(1.447753f,1.274451f,0.8419818f,0.5652679f,-0.5576222f,0.396523f,-0.4607594f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448017f,1.364782f,0.783661f,-0.7099242f,0.01384959f,0.02838337f,0.7035697f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 10.82425f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 10.82425f);
Get(0xDD1E).SetLocalPose(1.448025f,1.274478f,0.8422872f,0.5652478f,-0.5576749f,0.3965484f,-0.4606984f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448037f,1.364905f,0.7837762f,-0.7099407f,0.01380751f,0.02838779f,0.7035537f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 10.84424f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 10.84424f);
Get(0xDD1E).SetLocalPose(1.447903f,1.274917f,0.8421712f,0.5651914f,-0.5577036f,0.396662f,-0.4606351f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448264f,1.364928f,0.7838462f,-0.7099476f,0.01381457f,0.02839032f,0.7035465f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 10.86377f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 10.86377f);
Get(0xDD1E).SetLocalPose(1.448254f,1.274405f,0.842168f,0.5652654f,-0.5576794f,0.3967824f,-0.46047f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448186f,1.364935f,0.7839426f,-0.7099429f,0.013813f,0.02839297f,0.7035511f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 10.88211f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 10.88211f);
Get(0xDD1E).SetLocalPose(1.448402f,1.274026f,0.8423368f,0.5653916f,-0.5577173f,0.3968601f,-0.4602019f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448163f,1.364994f,0.7839614f,-0.7099397f,0.01381476f,0.02839205f,0.7035544f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 10.89059f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 10.89059f);
Get(0xDD1E).SetLocalPose(1.448262f,1.274402f,0.8419902f,0.5652649f,-0.5577807f,0.3968873f,-0.4602574f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448285f,1.364816f,0.7840697f,-0.7099583f,0.01382047f,0.02839069f,0.7035355f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 10.91132f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 10.91132f);
Get(0xDD1E).SetLocalPose(1.447943f,1.274737f,0.8426561f,0.5650933f,-0.5578445f,0.3967389f,-0.4605187f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448396f,1.364978f,0.784146f,-0.7099303f,0.01382162f,0.02842345f,0.7035625f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 10.92978f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 10.92978f);
Get(0xDD1E).SetLocalPose(1.447888f,1.274596f,0.8424879f,0.5650436f,-0.5577133f,0.3966297f,-0.4608326f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448446f,1.365056f,0.7839683f,-0.7099365f,0.01384647f,0.02838543f,0.7035572f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 10.94848f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 10.94848f);
Get(0xDD1E).SetLocalPose(1.447693f,1.274698f,0.8430027f,0.5649273f,-0.557609f,0.3968695f,-0.4608949f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448358f,1.365148f,0.7840441f,-0.709927f,0.01386979f,0.02838442f,0.7035664f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 10.95683f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 10.95683f);
Get(0xDD1E).SetLocalPose(1.447743f,1.274736f,0.8429781f,0.5648663f,-0.5576043f,0.3969539f,-0.4609026f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448256f,1.365085f,0.7839047f,-0.7099177f,0.01388592f,0.02836224f,0.7035764f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 10.97639f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 10.97639f);
Get(0xDD1E).SetLocalPose(1.447809f,1.274698f,0.8435022f,0.5647849f,-0.5575529f,0.3969714f,-0.4610493f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448358f,1.365126f,0.7838891f,-0.7099383f,0.01387204f,0.02837513f,0.7035553f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 10.99536f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 10.99536f);
Get(0xDD1E).SetLocalPose(1.44815f,1.274801f,0.8437725f,0.5647761f,-0.5574571f,0.3968226f,-0.4613038f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448338f,1.36506f,0.7838835f,-0.7099435f,0.01384769f,0.02837322f,0.7035506f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 11.01375f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 11.01375f);
Get(0xDD1E).SetLocalPose(1.448415f,1.274388f,0.8440511f,0.5647756f,-0.5573943f,0.3966586f,-0.4615215f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448332f,1.365071f,0.7839378f,-0.7099494f,0.01381551f,0.0283899f,0.7035446f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 11.03223f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 11.03223f);
Get(0xDD1E).SetLocalPose(1.448712f,1.274546f,0.8438825f,0.5648175f,-0.5572828f,0.3966183f,-0.4616395f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448402f,1.365037f,0.7839409f,-0.7099431f,0.0138061f,0.02840978f,0.7035504f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 11.04117f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 11.04117f);
Get(0xDD1E).SetLocalPose(1.448982f,1.274288f,0.8435879f,0.5649266f,-0.5571809f,0.3965661f,-0.4616741f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448361f,1.365122f,0.7839358f,-0.709953f,0.01378508f,0.02840324f,0.7035411f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 11.06083f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 11.06083f);
Get(0xDD1E).SetLocalPose(1.44901f,1.274518f,0.843565f,0.5649591f,-0.5571437f,0.396753f,-0.4615184f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448404f,1.365023f,0.7839619f,-0.7099601f,0.01379859f,0.02837054f,0.703535f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 11.07903f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 11.07903f);
Get(0xDD1E).SetLocalPose(1.449219f,1.27453f,0.8441473f,0.5649318f,-0.5571874f,0.3969608f,-0.4613205f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448393f,1.365014f,0.7840219f,-0.7099717f,0.01375665f,0.02838348f,0.7035236f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 11.09722f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 11.09722f);
Get(0xDD1E).SetLocalPose(1.449111f,1.275112f,0.8442554f,0.5649266f,-0.5572914f,0.3970585f,-0.4611169f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448467f,1.364839f,0.784148f,-0.70998f,0.013775f,0.02838375f,0.7035149f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 11.115f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 11.115f);
Get(0xDD1E).SetLocalPose(1.449021f,1.274222f,0.8447981f,0.5650876f,-0.557232f,0.3970175f,-0.4610268f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448455f,1.364952f,0.7841381f,-0.7099721f,0.0137943f,0.02837525f,0.7035227f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 11.13297f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 11.13297f);
Get(0xDD1E).SetLocalPose(1.449f,1.274118f,0.844752f,0.5654086f,-0.5570322f,0.3969871f,-0.4609008f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44851f,1.364959f,0.7842095f,-0.709976f,0.01382374f,0.02838095f,0.7035181f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 11.14078f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 11.14078f);
Get(0xDD1E).SetLocalPose(1.449164f,1.273695f,0.8449937f,0.5655121f,-0.5570301f,0.3969812f,-0.4607814f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44853f,1.36494f,0.7840683f,-0.7099648f,0.01380747f,0.02836075f,0.7035305f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 11.15977f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 11.15977f);
Get(0xDD1E).SetLocalPose(1.449319f,1.273633f,0.8450635f,0.5654585f,-0.5571196f,0.3970135f,-0.4607112f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448284f,1.364863f,0.783794f,-0.7099211f,0.01380458f,0.02838083f,0.7035738f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 11.17815f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 11.17815f);
Get(0xDD1E).SetLocalPose(1.449116f,1.274072f,0.8451397f,0.5652564f,-0.5572565f,0.3971345f,-0.4606894f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448259f,1.36491f,0.7839246f,-0.7099323f,0.01380618f,0.02835738f,0.7035635f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 11.19564f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 11.19564f);
Get(0xDD1E).SetLocalPose(1.449427f,1.273681f,0.8449619f,0.5652562f,-0.5572218f,0.3972251f,-0.4606534f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448315f,1.365027f,0.7840497f,-0.7099159f,0.01382521f,0.02834901f,0.7035799f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 11.21322f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 11.21322f);
Get(0xDD1E).SetLocalPose(1.448716f,1.273757f,0.8445913f,0.5651709f,-0.5572454f,0.3974291f,-0.4605534f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448256f,1.365063f,0.784063f,-0.7099157f,0.01384336f,0.02833823f,0.7035802f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 11.23118f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 11.23118f);
Get(0xDD1E).SetLocalPose(1.448717f,1.273349f,0.8449028f,0.5652367f,-0.5571587f,0.3975161f,-0.4605026f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448372f,1.365134f,0.7841328f,-0.7099507f,0.01382413f,0.02836403f,0.7035441f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 11.24851f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 11.24851f);
Get(0xDD1E).SetLocalPose(1.448497f,1.272076f,0.8446279f,0.5652679f,-0.557077f,0.3975315f,-0.4605499f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448318f,1.365061f,0.7840465f,-0.7099494f,0.01381097f,0.02837041f,0.7035456f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 11.26649f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 11.26649f);
Get(0xDD1E).SetLocalPose(1.44824f,1.27268f,0.8448451f,0.5652388f,-0.5571217f,0.3976718f,-0.4604103f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448394f,1.365022f,0.7841759f,-0.7099451f,0.0137985f,0.02839893f,0.7035489f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 11.27456f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 11.27456f);
Get(0xDD1E).SetLocalPose(1.448018f,1.272701f,0.8444613f,0.5650911f,-0.5572101f,0.3977696f,-0.4604001f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448634f,1.364866f,0.7842465f,-0.709988f,0.01379395f,0.02839445f,0.703506f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 11.294f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 11.294f);
Get(0xDD1E).SetLocalPose(1.448099f,1.272818f,0.843599f,0.5648838f,-0.5572127f,0.3978642f,-0.4605697f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448612f,1.36487f,0.7843139f,-0.7099681f,0.01380248f,0.02836673f,0.7035269f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 11.31185f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 11.31185f);
Get(0xDD1E).SetLocalPose(1.448097f,1.273067f,0.8439161f,0.5650976f,-0.5569771f,0.3977276f,-0.4607103f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448323f,1.364851f,0.7840298f,-0.7099666f,0.01381879f,0.02836779f,0.7035282f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 11.33025f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 11.33025f);
Get(0xDD1E).SetLocalPose(1.447665f,1.272581f,0.8438699f,0.565151f,-0.5567879f,0.3976004f,-0.4609831f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448365f,1.364797f,0.7839629f,-0.7099692f,0.01380743f,0.02836435f,0.7035258f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 11.34842f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 11.34842f);
Get(0xDD1E).SetLocalPose(1.447436f,1.273006f,0.8437083f,0.5651027f,-0.5567699f,0.3976484f,-0.4610228f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448271f,1.364855f,0.7839381f,-0.7099442f,0.01381666f,0.02838053f,0.7035502f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 11.36639f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 11.36639f);
Get(0xDD1E).SetLocalPose(1.447623f,1.272256f,0.8437576f,0.5649747f,-0.5567817f,0.3977575f,-0.4610714f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448245f,1.364843f,0.7839165f,-0.7099458f,0.01382856f,0.02839566f,0.7035478f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 11.37467f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 11.37467f);
Get(0xDD1E).SetLocalPose(1.447419f,1.272719f,0.843764f,0.565001f,-0.5567769f,0.3978538f,-0.4609618f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448181f,1.364783f,0.7837708f,-0.7099338f,0.01381474f,0.02839103f,0.7035604f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 11.39393f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 11.39393f);
Get(0xDD1E).SetLocalPose(1.447512f,1.27306f,0.8437473f,0.5651524f,-0.5566711f,0.3979266f,-0.460841f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448131f,1.364942f,0.783692f,-0.7099173f,0.01384872f,0.02836483f,0.7035774f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 11.41238f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 11.41238f);
Get(0xDD1E).SetLocalPose(1.447901f,1.272355f,0.8434059f,0.5653924f,-0.5564263f,0.3977026f,-0.4610357f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448067f,1.365158f,0.7837141f,-0.7098919f,0.01385303f,0.02838152f,0.7036023f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 11.43054f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 11.43054f);
Get(0xDD1E).SetLocalPose(1.448072f,1.271859f,0.8427799f,0.5654827f,-0.5563971f,0.3973963f,-0.4612243f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448018f,1.365154f,0.7837069f,-0.7099018f,0.01386577f,0.02837342f,0.7035924f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 11.44829f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 11.44829f);
Get(0xDD1E).SetLocalPose(1.448317f,1.271934f,0.8421265f,0.5654961f,-0.5563865f,0.3972118f,-0.4613796f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448064f,1.365149f,0.7836803f,-0.709909f,0.01390621f,0.02838035f,0.703584f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 11.46592f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 11.46592f);
Get(0xDD1E).SetLocalPose(1.448737f,1.271318f,0.8420821f,0.565433f,-0.5563871f,0.3972726f,-0.4614037f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447907f,1.364897f,0.7835246f,-0.7099162f,0.01393035f,0.02836746f,0.7035767f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 11.47423f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 11.47423f);
Get(0xDD1E).SetLocalPose(1.448678f,1.271265f,0.8421158f,0.5653692f,-0.5564074f,0.3973357f,-0.461403f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447802f,1.364808f,0.7833266f,-0.7099105f,0.0139352f,0.02833291f,0.7035838f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 11.49395f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 11.49395f);
Get(0xDD1E).SetLocalPose(1.448626f,1.271273f,0.842267f,0.5653529f,-0.556415f,0.3971556f,-0.4615689f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448118f,1.364756f,0.7837006f,-0.7099827f,0.01389556f,0.02832602f,0.703512f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 11.51251f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 11.51251f);
Get(0xDD1E).SetLocalPose(1.448521f,1.271778f,0.8431894f,0.5655481f,-0.5562595f,0.3967414f,-0.4618733f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448231f,1.364899f,0.7836944f,-0.7099741f,0.01389126f,0.02832918f,0.7035207f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 11.5306f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 11.5306f);
Get(0xDD1E).SetLocalPose(1.448267f,1.27223f,0.8432567f,0.5656943f,-0.5562007f,0.3965692f,-0.4619131f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448451f,1.364887f,0.7838979f,-0.7099997f,0.01386762f,0.02832606f,0.7034954f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 11.54862f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 11.54862f);
Get(0xDD1E).SetLocalPose(1.447999f,1.272547f,0.8432868f,0.5654292f,-0.5564703f,0.3968014f,-0.4617136f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448432f,1.364953f,0.7839503f,-0.7099543f,0.01381614f,0.02831046f,0.7035429f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 11.56628f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 11.56628f);
Get(0xDD1E).SetLocalPose(1.447763f,1.273661f,0.842891f,0.5652047f,-0.5567132f,0.3970215f,-0.4615063f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448592f,1.365018f,0.7840433f,-0.7099534f,0.01380493f,0.0283862f,0.703541f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 11.57436f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 11.57436f);
Get(0xDD1E).SetLocalPose(1.447618f,1.273868f,0.8429251f,0.5652967f,-0.556722f,0.3969971f,-0.4614038f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448508f,1.365101f,0.7840325f,-0.7099221f,0.01375712f,0.0284149f,0.7035724f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 11.59427f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 11.59427f);
Get(0xDD1E).SetLocalPose(1.447474f,1.274901f,0.8431272f,0.5654728f,-0.5567867f,0.3968657f,-0.4612232f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448557f,1.365003f,0.7841213f,-0.7098916f,0.01371533f,0.02843415f,0.7036031f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 11.61259f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 11.61259f);
Get(0xDD1E).SetLocalPose(1.447299f,1.275258f,0.8434025f,0.5657053f,-0.5567223f,0.39654f,-0.4612959f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44834f,1.365181f,0.7840332f,-0.7098717f,0.01376489f,0.02842689f,0.7036225f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 11.63001f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 11.63001f);
Get(0xDD1E).SetLocalPose(1.447066f,1.275139f,0.8439865f,0.5658036f,-0.5567329f,0.3963475f,-0.461328f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448375f,1.365149f,0.7839139f,-0.7098575f,0.01373774f,0.02840166f,0.7036385f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 11.64748f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 11.64748f);
Get(0xDD1E).SetLocalPose(1.446991f,1.274804f,0.8439988f,0.565675f,-0.5568358f,0.3963886f,-0.4613261f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448368f,1.365086f,0.7838786f,-0.7098859f,0.01379703f,0.0283939f,0.7036089f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 11.66518f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 11.66518f);
Get(0xDD1E).SetLocalPose(1.447116f,1.27372f,0.8440395f,0.5656791f,-0.5568517f,0.3964893f,-0.4612154f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448436f,1.365164f,0.7839105f,-0.709914f,0.01379749f,0.02837633f,0.7035813f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 11.67339f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 11.67339f);
Get(0xDD1E).SetLocalPose(1.447071f,1.27318f,0.8438823f,0.5657049f,-0.5568261f,0.3965241f,-0.4611848f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448408f,1.365067f,0.7839506f,-0.7099298f,0.01382568f,0.02836066f,0.7035655f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 11.69284f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 11.69284f);
Get(0xDD1E).SetLocalPose(1.446895f,1.272706f,0.8443089f,0.5659132f,-0.5567198f,0.3963189f,-0.4612338f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448438f,1.365046f,0.78388f,-0.7099582f,0.01382772f,0.0283579f,0.7035368f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 11.71144f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 11.71144f);
Get(0xDD1E).SetLocalPose(1.446915f,1.272034f,0.8436635f,0.5661288f,-0.556615f,0.3958672f,-0.4614837f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448903f,1.365055f,0.7840557f,-0.7099894f,0.01381946f,0.02836034f,0.7035053f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 11.72964f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 11.72964f);
Get(0xDD1E).SetLocalPose(1.44696f,1.271393f,0.8435529f,0.5660515f,-0.5568262f,0.395681f,-0.4614834f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.449004f,1.364944f,0.7840405f,-0.7099882f,0.0137684f,0.02839591f,0.7035062f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 11.74801f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 11.74801f);
Get(0xDD1E).SetLocalPose(1.446917f,1.27287f,0.8438605f,0.5659526f,-0.5570292f,0.3957534f,-0.4612975f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448995f,1.364968f,0.7842302f,-0.7099935f,0.01373276f,0.02842773f,0.7035002f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 11.76582f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 11.76582f);
Get(0xDD1E).SetLocalPose(1.446908f,1.272715f,0.8439872f,0.5661196f,-0.5570126f,0.3957307f,-0.4611322f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448924f,1.364942f,0.7841273f,-0.709976f,0.01373206f,0.02840728f,0.7035188f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 11.77401f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 11.77401f);
Get(0xDD1E).SetLocalPose(1.446922f,1.27384f,0.8443131f,0.5662693f,-0.5569896f,0.3956608f,-0.4610362f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44895f,1.365024f,0.784187f,-0.7099367f,0.01373076f,0.02842146f,0.7035578f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 11.79299f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 11.79299f);
Get(0xDD1E).SetLocalPose(1.447216f,1.274484f,0.8446959f,0.5664687f,-0.5570004f,0.3953409f,-0.4610526f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448818f,1.365207f,0.7843381f,-0.7099311f,0.01373266f,0.02843689f,0.7035629f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 11.8123f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 11.8123f);
Get(0xDD1E).SetLocalPose(1.447275f,1.274846f,0.8452294f,0.5664356f,-0.5571111f,0.3952027f,-0.4610778f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44868f,1.36514f,0.7841733f,-0.709902f,0.01370348f,0.02846152f,0.7035918f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 11.83084f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 11.83084f);
Get(0xDD1E).SetLocalPose(1.447322f,1.274549f,0.8454087f,0.5663287f,-0.5572668f,0.395231f,-0.4609968f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448652f,1.365108f,0.7840944f,-0.7099343f,0.01367213f,0.02846337f,0.7035598f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 11.84855f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 11.84855f);
Get(0xDD1E).SetLocalPose(1.447044f,1.27437f,0.8456528f,0.5663543f,-0.5572695f,0.3952429f,-0.460952f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448644f,1.36515f,0.7839992f,-0.7099142f,0.01369232f,0.0284561f,0.7035798f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 11.8664f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 11.8664f);
Get(0xDD1E).SetLocalPose(1.447132f,1.274229f,0.8457192f,0.566539f,-0.5571139f,0.3950765f,-0.4610555f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448709f,1.365032f,0.7840497f,-0.7099365f,0.01372523f,0.02843549f,0.7035576f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 11.87479f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 11.87479f);
Get(0xDD1E).SetLocalPose(1.447121f,1.274291f,0.8457795f,0.5665545f,-0.5570853f,0.3950162f,-0.4611227f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448835f,1.365206f,0.784174f,-0.7099651f,0.01373403f,0.02844482f,0.7035282f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 11.89456f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 11.89456f);
Get(0xDD1E).SetLocalPose(1.44699f,1.274233f,0.8461986f,0.566407f,-0.5571959f,0.3948006f,-0.4613549f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448785f,1.365264f,0.7840375f,-0.7099807f,0.01376106f,0.02839954f,0.7035138f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 11.91231f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 11.91231f);
Get(0xDD1E).SetLocalPose(1.446625f,1.274114f,0.8459819f,0.5661789f,-0.5574079f,0.3947524f,-0.4614203f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448517f,1.365165f,0.7838624f,-0.7099869f,0.01382725f,0.02836996f,0.7035074f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 11.93055f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 11.93055f);
Get(0xDD1E).SetLocalPose(1.446226f,1.273912f,0.8459461f,0.5662196f,-0.55739f,0.394639f,-0.4614888f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448475f,1.365139f,0.7838567f,-0.7099739f,0.01384445f,0.02834326f,0.7035213f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 11.94848f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 11.94848f);
Get(0xDD1E).SetLocalPose(1.445972f,1.273725f,0.8458023f,0.5663736f,-0.5572798f,0.3945218f,-0.4615331f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448417f,1.365066f,0.7838534f,-0.7099534f,0.01386325f,0.02834089f,0.7035417f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 11.95669f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 11.95669f);
Get(0xDD1E).SetLocalPose(1.445759f,1.273593f,0.8459584f,0.5664592f,-0.5572329f,0.3945335f,-0.4614747f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448399f,1.365101f,0.7838932f,-0.7099428f,0.01382885f,0.02831684f,0.703554f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 11.97591f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 11.97591f);
Get(0xDD1E).SetLocalPose(1.445623f,1.273535f,0.8460318f,0.5662789f,-0.5574388f,0.3945473f,-0.4614355f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448179f,1.364802f,0.7838641f,-0.7099456f,0.0138135f,0.02834032f,0.7035506f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 11.99422f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 11.99422f);
Get(0xDD1E).SetLocalPose(1.445585f,1.273952f,0.846047f,0.5659302f,-0.5577365f,0.3944813f,-0.4615599f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448094f,1.364939f,0.7840122f,-0.7099069f,0.01379281f,0.02836661f,0.703589f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 12.01244f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 12.01244f);
Get(0xDD1E).SetLocalPose(1.445304f,1.274084f,0.8459577f,0.5658258f,-0.557767f,0.394437f,-0.4616889f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448357f,1.365074f,0.7841544f,-0.7099209f,0.01375734f,0.02837578f,0.7035751f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 12.03039f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 12.03039f);
Get(0xDD1E).SetLocalPose(1.44546f,1.274384f,0.8460345f,0.565888f,-0.557655f,0.3944748f,-0.4617156f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448238f,1.364962f,0.7840979f,-0.7098972f,0.01378514f,0.02838817f,0.703598f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 12.04855f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 12.04855f);
Get(0xDD1E).SetLocalPose(1.445432f,1.274851f,0.8457822f,0.5659316f,-0.5576356f,0.3944728f,-0.4616873f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448196f,1.364971f,0.7839465f,-0.7099037f,0.0137865f,0.02836705f,0.7035922f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 12.06664f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 12.06664f);
Get(0xDD1E).SetLocalPose(1.445792f,1.274804f,0.8459643f,0.5659624f,-0.5576349f,0.3942695f,-0.4618241f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448214f,1.365024f,0.7839587f,-0.7099065f,0.01380604f,0.02838882f,0.7035882f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 12.07497f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 12.07497f);
Get(0xDD1E).SetLocalPose(1.445534f,1.274743f,0.8462534f,0.5658745f,-0.557686f,0.3942674f,-0.461872f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448163f,1.364841f,0.7838092f,-0.7099156f,0.01381907f,0.02836823f,0.7035795f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 12.09408f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 12.09408f);
Get(0xDD1E).SetLocalPose(1.445584f,1.275118f,0.8463467f,0.5657356f,-0.5577412f,0.3942547f,-0.4619863f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448313f,1.364968f,0.7840423f,-0.7099438f,0.01379452f,0.02836921f,0.7035516f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 12.11183f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 12.11183f);
Get(0xDD1E).SetLocalPose(1.445634f,1.275013f,0.8463913f,0.565695f,-0.5577f,0.3942563f,-0.4620842f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448287f,1.364979f,0.7839273f,-0.7099558f,0.01385119f,0.02836179f,0.7035387f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 12.12961f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 12.12961f);
Get(0xDD1E).SetLocalPose(1.445599f,1.27485f,0.8470446f,0.5656996f,-0.557657f,0.3943452f,-0.4620548f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448165f,1.364943f,0.7838547f,-0.7099648f,0.01387529f,0.02832238f,0.7035306f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 12.1475f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 12.1475f);
Get(0xDD1E).SetLocalPose(1.445728f,1.274717f,0.8472449f,0.5656401f,-0.5577044f,0.3942641f,-0.4621395f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448221f,1.364853f,0.7838078f,-0.7099657f,0.01384908f,0.02834691f,0.7035292f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 12.16557f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 12.16557f);
Get(0xDD1E).SetLocalPose(1.446513f,1.275361f,0.8474422f,0.5655285f,-0.5577842f,0.3941716f,-0.4622587f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448253f,1.364868f,0.7837668f,-0.7099426f,0.01385353f,0.02834565f,0.7035526f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 12.17366f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 12.17366f);
Get(0xDD1E).SetLocalPose(1.44651f,1.275413f,0.8474994f,0.5655044f,-0.5577898f,0.3941594f,-0.4622918f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448277f,1.364881f,0.7838315f,-0.7099329f,0.01385128f,0.02835314f,0.7035621f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 12.19303f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 12.19303f);
Get(0xDD1E).SetLocalPose(1.446583f,1.275725f,0.8477058f,0.5655628f,-0.5577366f,0.3940057f,-0.4624156f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448534f,1.364893f,0.7840155f,-0.7099329f,0.01380591f,0.02840591f,0.7035608f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 12.21131f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 12.21131f);
Get(0xDD1E).SetLocalPose(1.446928f,1.276298f,0.8480818f,0.5656682f,-0.5576433f,0.3939147f,-0.4624767f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448525f,1.364888f,0.7839888f,-0.7099251f,0.01378072f,0.0284032f,0.7035693f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 12.23004f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 12.23004f);
Get(0xDD1E).SetLocalPose(1.447287f,1.276688f,0.8481306f,0.5657496f,-0.5575379f,0.393901f,-0.4625158f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44856f,1.364814f,0.7838718f,-0.7099132f,0.0137548f,0.02839323f,0.7035822f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 12.24793f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 12.24793f);
Get(0xDD1E).SetLocalPose(1.447698f,1.276155f,0.8481013f,0.5656787f,-0.5576167f,0.393921f,-0.4624905f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448474f,1.36482f,0.783749f,-0.7099094f,0.01374853f,0.02840432f,0.7035857f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 12.26594f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 12.26594f);
Get(0xDD1E).SetLocalPose(1.447669f,1.276417f,0.8480288f,0.565596f,-0.5577287f,0.3940724f,-0.4623277f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448428f,1.364977f,0.78395f,-0.7099032f,0.01379839f,0.02840439f,0.703591f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 12.27391f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 12.27391f);
Get(0xDD1E).SetLocalPose(1.447415f,1.276633f,0.847927f,0.5655167f,-0.5578158f,0.3941946f,-0.4622155f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448368f,1.364936f,0.7838204f,-0.7099098f,0.01379299f,0.02840085f,0.7035846f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 12.29429f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 12.29429f);
Get(0xDD1E).SetLocalPose(1.447198f,1.276482f,0.8480904f,0.5654251f,-0.5579392f,0.3943745f,-0.462025f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448351f,1.365053f,0.783718f,-0.7099036f,0.01381857f,0.02837422f,0.7035914f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 12.31215f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 12.31215f);
Get(0xDD1E).SetLocalPose(1.447235f,1.275977f,0.8483125f,0.5654252f,-0.5580522f,0.3944871f,-0.4617923f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448345f,1.364907f,0.7836618f,-0.7099407f,0.01380937f,0.02838381f,0.7035538f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 12.33023f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 12.33023f);
Get(0xDD1E).SetLocalPose(1.447402f,1.275497f,0.8488861f,0.5656244f,-0.5579252f,0.394549f,-0.461649f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44838f,1.364967f,0.7837692f,-0.7099372f,0.01381114f,0.02838094f,0.7035574f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 12.34823f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 12.34823f);
Get(0xDD1E).SetLocalPose(1.447572f,1.275397f,0.8491903f,0.5658166f,-0.557719f,0.3944589f,-0.4617395f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448476f,1.36502f,0.7837947f,-0.7099527f,0.01379275f,0.02838677f,0.7035419f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 12.36657f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 12.36657f);
Get(0xDD1E).SetLocalPose(1.447442f,1.274716f,0.849599f,0.5658861f,-0.5575108f,0.3943443f,-0.4620036f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448355f,1.364993f,0.7836398f,-0.7099386f,0.013816f,0.02840055f,0.7035552f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 12.37485f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 12.37485f);
Get(0xDD1E).SetLocalPose(1.447479f,1.275126f,0.8495646f,0.5657797f,-0.5575184f,0.3943625f,-0.4621091f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448358f,1.365f,0.7836316f,-0.7099203f,0.01381681f,0.02840738f,0.7035733f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 12.39437f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 12.39437f);
Get(0xDD1E).SetLocalPose(1.447321f,1.275527f,0.8497022f,0.5655022f,-0.5576669f,0.3945654f,-0.4620964f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448332f,1.365056f,0.7836086f,-0.7098946f,0.0137987f,0.02839771f,0.7035999f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 12.4124f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 12.4124f);
Get(0xDD1E).SetLocalPose(1.447063f,1.275107f,0.8495077f,0.565344f,-0.5577803f,0.3947485f,-0.4619967f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448343f,1.365073f,0.7836957f,-0.7099019f,0.01379621f,0.0283794f,0.7035934f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 12.43005f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 12.43005f);
Get(0xDD1E).SetLocalPose(1.446893f,1.275078f,0.8496467f,0.5655637f,-0.5576023f,0.3946503f,-0.4620265f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448291f,1.365118f,0.783715f,-0.7098989f,0.01384278f,0.02838017f,0.7035955f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 12.44794f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 12.44794f);
Get(0xDD1E).SetLocalPose(1.44723f,1.275264f,0.8495139f,0.5657802f,-0.5574223f,0.3943979f,-0.4621942f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448229f,1.365014f,0.783686f,-0.7098822f,0.01382858f,0.02838801f,0.7036123f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 12.46601f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 12.46601f);
Get(0xDD1E).SetLocalPose(1.447159f,1.275718f,0.8494716f,0.5656444f,-0.5574024f,0.3942547f,-0.4625065f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448053f,1.364971f,0.7836568f,-0.7098914f,0.01380785f,0.02836159f,0.7036045f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 12.47433f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 12.47433f);
Get(0xDD1E).SetLocalPose(1.447346f,1.275669f,0.8491762f,0.565446f,-0.5574684f,0.3941905f,-0.4627244f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448088f,1.364974f,0.7836705f,-0.7098887f,0.01383431f,0.02837813f,0.7036061f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 12.49381f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 12.49381f);
Get(0xDD1E).SetLocalPose(1.447245f,1.275618f,0.8490851f,0.5652336f,-0.557577f,0.3941493f,-0.462888f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448305f,1.364856f,0.7838263f,-0.7099039f,0.01380605f,0.02837867f,0.7035912f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 12.51192f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 12.51192f);
Get(0xDD1E).SetLocalPose(1.44711f,1.276061f,0.8483375f,0.5652115f,-0.5575822f,0.394081f,-0.4629667f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448448f,1.365033f,0.7840254f,-0.7099305f,0.01377439f,0.02835442f,0.7035658f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 12.52982f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 12.52982f);
Get(0xDD1E).SetLocalPose(1.446979f,1.276123f,0.84793f,0.5655152f,-0.5573696f,0.3939102f,-0.4629973f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44846f,1.365087f,0.7839563f,-0.7099376f,0.01381009f,0.02834978f,0.7035583f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 12.54753f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 12.54753f);
Get(0xDD1E).SetLocalPose(1.447138f,1.276269f,0.8478504f,0.5656658f,-0.5572569f,0.3938126f,-0.4630318f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448604f,1.364966f,0.7840219f,-0.7099544f,0.01377134f,0.0283587f,0.7035418f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 12.56492f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 12.56492f);
Get(0xDD1E).SetLocalPose(1.447137f,1.276612f,0.8477075f,0.5654535f,-0.5574126f,0.3939271f,-0.4630066f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448721f,1.364902f,0.7840213f,-0.7099558f,0.01378794f,0.02837161f,0.7035396f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 12.58306f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 12.58306f);
Get(0xDD1E).SetLocalPose(1.447532f,1.276766f,0.8477633f,0.5650442f,-0.5576383f,0.3940917f,-0.4630944f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448669f,1.365036f,0.7839018f,-0.7099318f,0.01378556f,0.02837284f,0.7035637f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 12.59118f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 12.59118f);
Get(0xDD1E).SetLocalPose(1.447559f,1.277259f,0.8477968f,0.5650057f,-0.5576484f,0.3940249f,-0.463186f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44857f,1.365023f,0.7838516f,-0.7099165f,0.01378719f,0.0283579f,0.7035797f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 12.61149f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 12.61149f);
Get(0xDD1E).SetLocalPose(1.447308f,1.277157f,0.8481333f,0.5651002f,-0.5575277f,0.3939096f,-0.4633141f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448466f,1.365043f,0.783834f,-0.7099151f,0.01380956f,0.02837086f,0.7035802f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 12.63008f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 12.63008f);
Get(0xDD1E).SetLocalPose(1.447069f,1.277143f,0.8484485f,0.5651786f,-0.5574237f,0.393778f,-0.4634555f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448409f,1.365188f,0.7838151f,-0.7098815f,0.01380065f,0.02835064f,0.7036151f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 12.64794f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 12.64794f);
Get(0xDD1E).SetLocalPose(1.44712f,1.276914f,0.8485866f,0.5650163f,-0.5574757f,0.3938189f,-0.4635559f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448101f,1.365007f,0.7836598f,-0.7098702f,0.01383584f,0.02837171f,0.703625f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 12.66655f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 12.66655f);
Get(0xDD1E).SetLocalPose(1.447212f,1.276376f,0.8486465f,0.5646009f,-0.5577101f,0.3939754f,-0.4636472f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44809f,1.364958f,0.7835731f,-0.7098747f,0.01382766f,0.02835622f,0.7036211f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 12.67471f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 12.67471f);
Get(0xDD1E).SetLocalPose(1.447371f,1.276577f,0.8488895f,0.5644624f,-0.5577957f,0.3940504f,-0.4636492f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448078f,1.364932f,0.7835138f,-0.7098656f,0.01381491f,0.02834817f,0.7036309f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 12.69396f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 12.69396f);
Get(0xDD1E).SetLocalPose(1.44764f,1.276955f,0.8493235f,0.5644276f,-0.5578186f,0.3941272f,-0.4635985f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448003f,1.364865f,0.7835838f,-0.7098731f,0.01384293f,0.02835406f,0.7036225f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 12.71192f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 12.71192f);
Get(0xDD1E).SetLocalPose(1.44795f,1.277384f,0.84962f,0.5645354f,-0.5577147f,0.3940771f,-0.4636348f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448096f,1.364837f,0.7836194f,-0.709878f,0.0138383f,0.02837532f,0.7036169f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 12.72975f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 12.72975f);
Get(0xDD1E).SetLocalPose(1.448124f,1.27829f,0.8499991f,0.5647182f,-0.5575358f,0.3940977f,-0.46361f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448017f,1.364697f,0.7834439f,-0.7098877f,0.01388989f,0.0283536f,0.7036068f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 12.74841f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 12.74841f);
Get(0xDD1E).SetLocalPose(1.447718f,1.277282f,0.850117f,0.5647071f,-0.5574809f,0.3941643f,-0.4636329f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448103f,1.364709f,0.7835051f,-0.7098954f,0.01385747f,0.0283655f,0.7035992f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 12.76644f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 12.76644f);
Get(0xDD1E).SetLocalPose(1.44742f,1.276755f,0.8503059f,0.564235f,-0.5577624f,0.3945538f,-0.4635378f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448022f,1.364768f,0.7834029f,-0.7098919f,0.01389081f,0.02830344f,0.7036046f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 12.77445f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 12.77445f);
Get(0xDD1E).SetLocalPose(1.447638f,1.27654f,0.8503038f,0.564047f,-0.5578741f,0.3947371f,-0.463476f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448071f,1.364673f,0.7834698f,-0.7099125f,0.01389298f,0.02831134f,0.7035835f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 12.79396f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 12.79396f);
Get(0xDD1E).SetLocalPose(1.447542f,1.277123f,0.8505116f,0.563944f,-0.5580325f,0.3949499f,-0.4632295f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44808f,1.364741f,0.7835242f,-0.7099289f,0.01386687f,0.02828772f,0.7035685f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 12.81244f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 12.81244f);
Get(0xDD1E).SetLocalPose(1.447206f,1.277193f,0.8507176f,0.5643033f,-0.557774f,0.3948425f,-0.4631948f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448012f,1.364849f,0.7836894f,-0.7099238f,0.01386004f,0.02830433f,0.703573f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 12.8303f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 12.8303f);
Get(0xDD1E).SetLocalPose(1.447195f,1.277239f,0.8508797f,0.564404f,-0.5576541f,0.39495f,-0.4631248f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447981f,1.364906f,0.7837402f,-0.7099223f,0.0138586f,0.02833237f,0.7035736f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 12.84794f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 12.84794f);
Get(0xDD1E).SetLocalPose(1.447227f,1.277073f,0.8510552f,0.5641402f,-0.5578494f,0.3952629f,-0.4629441f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448063f,1.364874f,0.7838978f,-0.7099109f,0.01380452f,0.02833897f,0.7035859f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 12.86551f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 12.86551f);
Get(0xDD1E).SetLocalPose(1.447629f,1.276579f,0.8513816f,0.5640373f,-0.5579301f,0.3954889f,-0.4627793f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44813f,1.365055f,0.7840156f,-0.7099177f,0.01381864f,0.02836481f,0.7035776f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 12.87349f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 12.87349f);
Get(0xDD1E).SetLocalPose(1.447598f,1.27649f,0.8513769f,0.5640654f,-0.5579333f,0.3955596f,-0.4626805f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448085f,1.364888f,0.7838744f,-0.709927f,0.01379204f,0.0283624f,0.7035688f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 12.89376f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 12.89376f);
Get(0xDD1E).SetLocalPose(1.448171f,1.276006f,0.8520858f,0.5642245f,-0.5578631f,0.3958156f,-0.4623522f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448014f,1.364874f,0.7838289f,-0.7099066f,0.01380655f,0.02834194f,0.70359f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 12.91162f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 12.91162f);
Get(0xDD1E).SetLocalPose(1.44825f,1.275374f,0.8522334f,0.5643058f,-0.5578114f,0.3960333f,-0.4621288f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448177f,1.364929f,0.7838577f,-0.7098981f,0.01382496f,0.02835368f,0.7035978f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 12.92926f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 12.92926f);
Get(0xDD1E).SetLocalPose(1.448427f,1.275087f,0.85263f,0.5643632f,-0.5578721f,0.3961696f,-0.4618686f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448316f,1.364828f,0.7838446f,-0.7099195f,0.0137959f,0.02832119f,0.703578f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 12.94757f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 12.94757f);
Get(0xDD1E).SetLocalPose(1.448484f,1.27463f,0.8527349f,0.5643288f,-0.5579743f,0.3961974f,-0.4617632f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448359f,1.364909f,0.783775f,-0.7099351f,0.01382663f,0.02830912f,0.7035621f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 12.96539f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 12.96539f);
Get(0xDD1E).SetLocalPose(1.448787f,1.275077f,0.8528389f,0.5642894f,-0.5580215f,0.3963588f,-0.4616159f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.4484f,1.364918f,0.7837731f,-0.7099151f,0.01381273f,0.02832654f,0.7035819f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 12.97356f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 12.97356f);
Get(0xDD1E).SetLocalPose(1.448739f,1.275293f,0.852953f,0.5643039f,-0.5579844f,0.3966099f,-0.4614273f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448518f,1.364959f,0.7838922f,-0.7099382f,0.01379965f,0.02833261f,0.7035586f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 12.99366f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 12.99366f);
Get(0xDD1E).SetLocalPose(1.448921f,1.274633f,0.8528149f,0.5643752f,-0.5579152f,0.3967576f,-0.4612969f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448489f,1.365013f,0.7838875f,-0.7099449f,0.01379625f,0.02835025f,0.7035512f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 13.002f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 13.002f);
Get(0xDD1E).SetLocalPose(1.44847f,1.274333f,0.8524527f,0.5643677f,-0.5578728f,0.3967678f,-0.4613487f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448393f,1.364827f,0.7838286f,-0.7099232f,0.01377178f,0.0284011f,0.7035715f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 13.03279f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 13.03279f);
Get(0xDD1E).SetLocalPose(1.448611f,1.274071f,0.8522676f,0.5641268f,-0.5580372f,0.3967996f,-0.461417f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448413f,1.364851f,0.7838534f,-0.7099205f,0.01373743f,0.02840634f,0.7035747f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 13.04082f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 13.04082f);
Get(0xDD1E).SetLocalPose(1.448751f,1.274096f,0.852522f,0.5639914f,-0.5581471f,0.3969008f,-0.4613624f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448627f,1.364836f,0.7839704f,-0.7099454f,0.01374583f,0.02843062f,0.7035484f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 13.06059f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 13.06059f);
Get(0xDD1E).SetLocalPose(1.448676f,1.274075f,0.8527681f,0.5639049f,-0.5582804f,0.3970983f,-0.4611369f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448737f,1.365025f,0.7840581f,-0.7099245f,0.01374218f,0.02842829f,0.7035697f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 13.07852f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 13.07852f);
Get(0xDD1E).SetLocalPose(1.448589f,1.27396f,0.8528697f,0.5641192f,-0.5581545f,0.3970724f,-0.4610494f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448526f,1.365059f,0.7840447f,-0.7099177f,0.01376348f,0.02841261f,0.7035767f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 13.09666f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 13.09666f);
Get(0xDD1E).SetLocalPose(1.448303f,1.273914f,0.8529323f,0.5642716f,-0.5580515f,0.397054f,-0.4610035f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448497f,1.365006f,0.7839539f,-0.7099217f,0.01377212f,0.02839678f,0.7035732f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 13.1148f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 13.1148f);
Get(0xDD1E).SetLocalPose(1.448305f,1.274189f,0.8529098f,0.5641793f,-0.5580582f,0.3970569f,-0.4611059f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448463f,1.364843f,0.7837967f,-0.7099335f,0.01381311f,0.02837944f,0.7035612f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 13.13291f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 13.13291f);
Get(0xDD1E).SetLocalPose(1.448059f,1.274685f,0.8522846f,0.5637661f,-0.5583268f,0.397076f,-0.4612697f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448476f,1.364843f,0.7837754f,-0.7099404f,0.01381139f,0.02839835f,0.7035535f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 13.14064f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 13.14064f);
Get(0xDD1E).SetLocalPose(1.448175f,1.274852f,0.8522537f,0.5635988f,-0.55841f,0.3970979f,-0.4613544f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448321f,1.365049f,0.7838002f,-0.7099367f,0.01384664f,0.02835199f,0.7035584f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 13.16009f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 13.16009f);
Get(0xDD1E).SetLocalPose(1.448413f,1.275513f,0.852457f,0.5636746f,-0.5583379f,0.3970347f,-0.4614036f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448372f,1.365196f,0.7840722f,-0.7099336f,0.01384114f,0.02834352f,0.7035619f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 13.17775f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 13.17775f);
Get(0xDD1E).SetLocalPose(1.449264f,1.276225f,0.853031f,0.5638906f,-0.5581629f,0.3969809f,-0.4613977f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448505f,1.365147f,0.7840629f,-0.7099326f,0.01382368f,0.02837818f,0.703562f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 13.1964f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 13.1964f);
Get(0xDD1E).SetLocalPose(1.449291f,1.275926f,0.8529623f,0.5638318f,-0.5581344f,0.3969973f,-0.4614899f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448557f,1.365124f,0.7840407f,-0.7099353f,0.01382274f,0.02838179f,0.703559f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 13.21476f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 13.21476f);
Get(0xDD1E).SetLocalPose(1.449216f,1.275679f,0.8528545f,0.5637268f,-0.5581628f,0.3969442f,-0.4616294f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448658f,1.36508f,0.7840607f,-0.7099377f,0.01376852f,0.02840141f,0.7035569f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 13.23285f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 13.23285f);
Get(0xDD1E).SetLocalPose(1.449721f,1.275856f,0.8528733f,0.5636587f,-0.5580974f,0.39672f,-0.4619843f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448439f,1.365038f,0.783749f,-0.7099335f,0.01378025f,0.02837948f,0.7035618f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 13.24108f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 13.24108f);
Get(0xDD1E).SetLocalPose(1.449793f,1.276005f,0.8528478f,0.563665f,-0.5580308f,0.3966289f,-0.4621351f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448403f,1.365011f,0.7837259f,-0.7099183f,0.01376374f,0.02840904f,0.7035763f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 13.26089f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 13.26089f);
Get(0xDD1E).SetLocalPose(1.4502f,1.276398f,0.8532425f,0.5636911f,-0.5580224f,0.3965232f,-0.4622043f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448322f,1.365012f,0.7836835f,-0.709885f,0.0137759f,0.02841329f,0.7036095f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 13.2789f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 13.2789f);
Get(0xDD1E).SetLocalPose(1.450472f,1.277012f,0.8532025f,0.5636736f,-0.5580733f,0.396499f,-0.4621849f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448399f,1.364806f,0.7837596f,-0.7099247f,0.01376202f,0.028418f,0.7035695f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 13.29682f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 13.29682f);
Get(0xDD1E).SetLocalPose(1.450419f,1.277108f,0.8531758f,0.563614f,-0.5581692f,0.3965078f,-0.4621342f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448441f,1.364768f,0.7837335f,-0.7099242f,0.01376206f,0.02843467f,0.7035694f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 13.31447f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 13.31447f);
Get(0xDD1E).SetLocalPose(1.45035f,1.276787f,0.8533359f,0.5635892f,-0.5582144f,0.3964276f,-0.4621787f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448493f,1.364874f,0.7837854f,-0.709923f,0.01374843f,0.02844928f,0.7035701f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 13.33257f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 13.33257f);
Get(0xDD1E).SetLocalPose(1.449988f,1.276777f,0.8538287f,0.563594f,-0.558194f,0.3964542f,-0.4621746f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448493f,1.364797f,0.7836798f,-0.7099202f,0.01376649f,0.02843144f,0.7035733f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 13.34087f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 13.34087f);
Get(0xDD1E).SetLocalPose(1.449703f,1.276946f,0.8538867f,0.5635817f,-0.5582147f,0.3964602f,-0.4621595f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448455f,1.364804f,0.7837f,-0.709926f,0.01380229f,0.02840472f,0.7035679f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 13.36037f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 13.36037f);
Get(0xDD1E).SetLocalPose(1.44939f,1.276594f,0.8539722f,0.5636032f,-0.5581799f,0.3965074f,-0.4621348f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448515f,1.364834f,0.7837136f,-0.7099299f,0.01383355f,0.02839415f,0.7035637f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 13.3783f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 13.3783f);
Get(0xDD1E).SetLocalPose(1.449075f,1.276134f,0.8541911f,0.563513f,-0.5582518f,0.3964644f,-0.4621948f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448464f,1.364781f,0.7837631f,-0.7099342f,0.01380085f,0.028374f,0.703561f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 13.39601f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 13.39601f);
Get(0xDD1E).SetLocalPose(1.448911f,1.275644f,0.8540582f,0.563453f,-0.5582928f,0.3964452f,-0.4622349f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448539f,1.364877f,0.7839451f,-0.7099171f,0.01379692f,0.02840881f,0.7035768f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 13.41385f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 13.41385f);
Get(0xDD1E).SetLocalPose(1.448754f,1.27502f,0.8540917f,0.5634715f,-0.5582905f,0.3965167f,-0.4621537f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448649f,1.365082f,0.7841077f,-0.7099417f,0.01377679f,0.02838288f,0.7035534f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 13.43157f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 13.43157f);
Get(0xDD1E).SetLocalPose(1.448858f,1.275602f,0.853621f,0.5634243f,-0.5583183f,0.3967685f,-0.4619617f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448586f,1.365024f,0.7840488f,-0.7099187f,0.01379767f,0.02839571f,0.7035757f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 13.44911f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 13.44911f);
Get(0xDD1E).SetLocalPose(1.449013f,1.275547f,0.8537373f,0.5635456f,-0.5582801f,0.3969099f,-0.4617383f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448537f,1.364874f,0.784062f,-0.709914f,0.01378573f,0.02836266f,0.7035821f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 13.45714f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 13.45714f);
Get(0xDD1E).SetLocalPose(1.448972f,1.275397f,0.8537363f,0.5636095f,-0.5582694f,0.3969547f,-0.4616346f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448438f,1.364874f,0.7840018f,-0.709908f,0.01375589f,0.02839131f,0.7035875f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 13.47701f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 13.47701f);
Get(0xDD1E).SetLocalPose(1.449494f,1.276022f,0.8534117f,0.5637401f,-0.5582692f,0.3971248f,-0.4613292f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448248f,1.365122f,0.7838398f,-0.7098927f,0.01379836f,0.02837572f,0.7036027f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 13.49507f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 13.49507f);
Get(0xDD1E).SetLocalPose(1.449376f,1.275992f,0.8532258f,0.5636973f,-0.5584022f,0.3974489f,-0.4609412f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448167f,1.365246f,0.7838441f,-0.7098956f,0.01381009f,0.02839277f,0.703599f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 13.5132f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 13.5132f);
Get(0xDD1E).SetLocalPose(1.449498f,1.274897f,0.8534998f,0.5636258f,-0.5585066f,0.3977895f,-0.460608f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448152f,1.36518f,0.7838278f,-0.7099253f,0.01385301f,0.02838087f,0.7035686f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 13.53167f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 13.53167f);
Get(0xDD1E).SetLocalPose(1.449294f,1.274858f,0.8538526f,0.5636332f,-0.5585117f,0.3980019f,-0.4604094f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448079f,1.365116f,0.7837641f,-0.7099337f,0.01382117f,0.02837033f,0.7035612f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 13.54032f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 13.54032f);
Get(0xDD1E).SetLocalPose(1.448829f,1.274235f,0.8535123f,0.5636749f,-0.5584754f,0.3981562f,-0.4602691f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448058f,1.364984f,0.7836128f,-0.7099115f,0.0138364f,0.0283573f,0.7035838f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 13.56002f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 13.56002f);
Get(0xDD1E).SetLocalPose(1.448174f,1.27331f,0.8531087f,0.5638475f,-0.5583738f,0.3983683f,-0.4599972f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448115f,1.365092f,0.7838042f,-0.7099248f,0.01384652f,0.02836196f,0.7035699f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 13.57783f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 13.57783f);
Get(0xDD1E).SetLocalPose(1.44767f,1.273073f,0.852768f,0.5638493f,-0.5583747f,0.3986017f,-0.4597917f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448231f,1.364979f,0.783903f,-0.7099209f,0.01379317f,0.02837686f,0.7035743f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 13.5954f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 13.5954f);
Get(0xDD1E).SetLocalPose(1.446903f,1.272227f,0.8528489f,0.5637186f,-0.5584862f,0.3987749f,-0.4596665f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448161f,1.364743f,0.783839f,-0.709923f,0.01382604f,0.02835518f,0.7035725f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 13.61302f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 13.61302f);
Get(0xDD1E).SetLocalPose(1.446601f,1.272261f,0.8526279f,0.5635955f,-0.558578f,0.3989735f,-0.4595334f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448255f,1.364874f,0.7838749f,-0.7099407f,0.01383919f,0.02834643f,0.7035546f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 13.63106f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 13.63106f);
Get(0xDD1E).SetLocalPose(1.446496f,1.272325f,0.8523199f,0.5636756f,-0.5584872f,0.3989797f,-0.4595402f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44824f,1.364881f,0.7837508f,-0.7099288f,0.01385216f,0.0283468f,0.7035664f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 13.64906f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 13.64906f);
Get(0xDD1E).SetLocalPose(1.446495f,1.272526f,0.852254f,0.5638654f,-0.5582973f,0.3989471f,-0.4595663f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448245f,1.364877f,0.7837347f,-0.7099137f,0.01386134f,0.02833783f,0.7035819f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 13.65706f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 13.65706f);
Get(0xDD1E).SetLocalPose(1.446585f,1.272551f,0.8517899f,0.5638959f,-0.5582058f,0.3989728f,-0.4596176f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448253f,1.364988f,0.7838356f,-0.7099018f,0.01386691f,0.02837493f,0.7035922f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 13.6769f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 13.6769f);
Get(0xDD1E).SetLocalPose(1.446775f,1.273539f,0.8519092f,0.5637984f,-0.5582517f,0.3991491f,-0.4595284f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448267f,1.365039f,0.7838929f,-0.7099196f,0.01382879f,0.02838157f,0.7035748f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 13.69523f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 13.69523f);
Get(0xDD1E).SetLocalPose(1.446776f,1.273284f,0.8516821f,0.5636933f,-0.5583041f,0.3993108f,-0.4594533f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448245f,1.365011f,0.7838084f,-0.7099311f,0.01380637f,0.02835947f,0.7035646f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 13.71331f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 13.71331f);
Get(0xDD1E).SetLocalPose(1.446982f,1.2734f,0.8511652f,0.5636877f,-0.5582801f,0.3992819f,-0.4595145f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448265f,1.365008f,0.7839515f,-0.7099449f,0.0138122f,0.02839775f,0.703549f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 13.73135f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 13.73135f);
Get(0xDD1E).SetLocalPose(1.447199f,1.273055f,0.8512541f,0.5638009f,-0.5581148f,0.399202f,-0.4596456f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448312f,1.364988f,0.7840539f,-0.7099237f,0.01380337f,0.02839923f,0.7035705f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 13.74915f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 13.74915f);
Get(0xDD1E).SetLocalPose(1.447354f,1.27247f,0.850546f,0.5639076f,-0.5578943f,0.3992449f,-0.4597453f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448404f,1.364959f,0.784034f,-0.7099341f,0.01381514f,0.02839218f,0.7035601f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 13.75766f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 13.75766f);
Get(0xDD1E).SetLocalPose(1.447142f,1.272475f,0.8502306f,0.5639085f,-0.5578176f,0.3993308f,-0.4597626f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448488f,1.365076f,0.7840894f,-0.7099612f,0.01379269f,0.02841222f,0.7035322f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 13.77647f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 13.77647f);
Get(0xDD1E).SetLocalPose(1.447218f,1.272762f,0.8496588f,0.5638372f,-0.557765f,0.3995095f,-0.4597587f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448543f,1.365025f,0.7841865f,-0.7099677f,0.01376551f,0.02840942f,0.7035263f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 13.79419f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 13.79419f);
Get(0xDD1E).SetLocalPose(1.44705f,1.272487f,0.8488797f,0.5637954f,-0.5577269f,0.3995942f,-0.4597824f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448458f,1.364991f,0.7839912f,-0.7099508f,0.01375865f,0.02838063f,0.7035447f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 13.81222f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 13.81222f);
Get(0xDD1E).SetLocalPose(1.446869f,1.271901f,0.8485199f,0.5637859f,-0.5576041f,0.3996856f,-0.4598638f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448527f,1.364949f,0.7840807f,-0.7099493f,0.01377878f,0.028411f,0.7035447f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 13.82956f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 13.82956f);
Get(0xDD1E).SetLocalPose(1.447225f,1.271651f,0.8486403f,0.5638665f,-0.5574588f,0.3997058f,-0.4599234f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448483f,1.364843f,0.7839361f,-0.7099369f,0.01380121f,0.0283988f,0.7035573f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 13.84746f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 13.84746f);
Get(0xDD1E).SetLocalPose(1.44671f,1.271429f,0.847967f,0.5638407f,-0.5573509f,0.3996222f,-0.4601584f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448307f,1.364892f,0.783887f,-0.7099212f,0.01380325f,0.028374f,0.703574f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 13.86539f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 13.86539f);
Get(0xDD1E).SetLocalPose(1.446756f,1.270979f,0.8473602f,0.5638198f,-0.5572268f,0.3997384f,-0.4602334f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448313f,1.364913f,0.7838661f,-0.7099242f,0.01382363f,0.02836145f,0.703571f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 13.87423f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 13.87423f);
Get(0xDD1E).SetLocalPose(1.446404f,1.271091f,0.8476853f,0.563812f,-0.557205f,0.3998426f,-0.460179f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448319f,1.364891f,0.7838568f,-0.7099141f,0.01383031f,0.02836947f,0.7035808f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 13.89643f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 13.89643f);
Get(0xDD1E).SetLocalPose(1.446259f,1.271379f,0.8474466f,0.5637911f,-0.5571795f,0.4001002f,-0.4600114f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448087f,1.364896f,0.7837757f,-0.7098923f,0.01381719f,0.02842397f,0.7036008f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 13.91653f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 13.91653f);
Get(0xDD1E).SetLocalPose(1.446835f,1.270987f,0.8469069f,0.5639278f,-0.5569389f,0.4001681f,-0.4600761f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448079f,1.364908f,0.7837358f,-0.7099008f,0.01381929f,0.02839245f,0.7035936f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 13.92535f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 13.92535f);
Get(0xDD1E).SetLocalPose(1.446927f,1.270857f,0.8466662f,0.5640045f,-0.556825f,0.4001856f,-0.4601048f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448109f,1.364886f,0.7836041f,-0.7099036f,0.01382219f,0.02837927f,0.7035912f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 13.94629f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 13.94629f);
Get(0xDD1E).SetLocalPose(1.447167f,1.270291f,0.8463868f,0.5641736f,-0.5566152f,0.4002939f,-0.4600571f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44815f,1.364946f,0.7835822f,-0.7099016f,0.01381963f,0.02838379f,0.703593f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 13.96606f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 13.96606f);
Get(0xDD1E).SetLocalPose(1.447723f,1.269891f,0.8463627f,0.5642557f,-0.5564774f,0.4006533f,-0.4598102f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448223f,1.364917f,0.7836958f,-0.7098995f,0.01381565f,0.02836994f,0.7035958f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 13.97481f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 13.97481f);
Get(0xDD1E).SetLocalPose(1.448491f,1.26957f,0.846265f,0.5642626f,-0.5564601f,0.4007134f,-0.4597705f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448516f,1.364959f,0.7840132f,-0.7099388f,0.01377144f,0.0283904f,0.7035563f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 13.99478f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 13.99478f);
Get(0xDD1E).SetLocalPose(1.449262f,1.269323f,0.8462397f,0.5641951f,-0.5564845f,0.4007047f,-0.4598312f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448408f,1.364959f,0.7837973f,-0.7099188f,0.01379985f,0.02835803f,0.7035772f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 14.01339f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 14.01339f);
Get(0xDD1E).SetLocalPose(1.449482f,1.270031f,0.8463977f,0.5642781f,-0.5563154f,0.4006468f,-0.4599844f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448625f,1.36493f,0.7840986f,-0.709956f,0.01379456f,0.02836112f,0.7035396f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 14.03155f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 14.03155f);
Get(0xDD1E).SetLocalPose(1.449573f,1.269811f,0.8461742f,0.5644356f,-0.5561047f,0.4005793f,-0.4601046f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448758f,1.364794f,0.7841925f,-0.7099538f,0.01374905f,0.02837582f,0.7035421f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 14.04982f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 14.04982f);
Get(0xDD1E).SetLocalPose(1.449737f,1.269191f,0.8462029f,0.5644071f,-0.5560726f,0.4006717f,-0.460098f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448762f,1.364872f,0.7841072f,-0.7099541f,0.01374748f,0.02839483f,0.703541f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 14.0579f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 14.0579f);
Get(0xDD1E).SetLocalPose(1.450048f,1.269138f,0.8462902f,0.5644009f,-0.5560534f,0.4007286f,-0.4600793f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448773f,1.364935f,0.7842299f,-0.7099496f,0.01373513f,0.0284005f,0.7035457f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 14.07729f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 14.07729f);
Get(0xDD1E).SetLocalPose(1.449748f,1.268814f,0.8459336f,0.5642522f,-0.5561585f,0.4008267f,-0.4600491f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448771f,1.36503f,0.7842051f,-0.7099413f,0.01375316f,0.02837653f,0.7035546f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 14.09541f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 14.09541f);
Get(0xDD1E).SetLocalPose(1.450118f,1.269149f,0.8457314f,0.5642032f,-0.5561229f,0.4009091f,-0.4600806f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448722f,1.36516f,0.7843325f,-0.7099372f,0.01374972f,0.02838323f,0.7035585f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 14.11328f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 14.11328f);
Get(0xDD1E).SetLocalPose(1.450044f,1.26974f,0.8455998f,0.5643018f,-0.555995f,0.4007352f,-0.4602655f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448526f,1.364969f,0.7838992f,-0.7099261f,0.01377236f,0.02837754f,0.7035696f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 14.13209f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 14.13209f);
Get(0xDD1E).SetLocalPose(1.450078f,1.269608f,0.8451793f,0.5644109f,-0.5558888f,0.4005515f,-0.46042f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448503f,1.364932f,0.7838812f,-0.7099047f,0.01376653f,0.02836259f,0.7035918f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 14.14987f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 14.14987f);
Get(0xDD1E).SetLocalPose(1.450256f,1.270039f,0.8450044f,0.5644699f,-0.5558896f,0.4002164f,-0.4606379f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448586f,1.36491f,0.7840028f,-0.7099297f,0.01377357f,0.02836356f,0.7035664f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 14.1583f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 14.1583f);
Get(0xDD1E).SetLocalPose(1.450541f,1.270941f,0.845076f,0.5644971f,-0.5559024f,0.3998985f,-0.4608653f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448468f,1.364967f,0.7842823f,-0.7099539f,0.01379116f,0.02836792f,0.7035415f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 14.1773f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 14.1773f);
Get(0xDD1E).SetLocalPose(1.450099f,1.27155f,0.8453278f,0.5645733f,-0.5557603f,0.3992685f,-0.4614892f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448451f,1.365061f,0.7841657f,-0.7099581f,0.01377958f,0.02839005f,0.7035366f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 14.19563f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 14.19563f);
Get(0xDD1E).SetLocalPose(1.449908f,1.27247f,0.8449039f,0.5651952f,-0.5548985f,0.3978785f,-0.4629632f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448271f,1.365132f,0.7842513f,-0.7099487f,0.01377072f,0.02838996f,0.7035463f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 14.21379f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 14.21379f);
Get(0xDD1E).SetLocalPose(1.449877f,1.273772f,0.8442773f,0.5666189f,-0.5519333f,0.395005f,-0.4672084f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448289f,1.365172f,0.7842409f,-0.7099543f,0.01376879f,0.02837799f,0.703541f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 14.23146f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 14.23146f);
Get(0xDD1E).SetLocalPose(1.450004f,1.275327f,0.8436793f,0.5721334f,-0.5439729f,0.386887f,-0.4765243f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448419f,1.36504f,0.7841234f,-0.709933f,0.01372322f,0.02839614f,0.7035627f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 14.24908f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 14.24908f);
Get(0xDD1E).SetLocalPose(1.450064f,1.277549f,0.8434753f,0.5803171f,-0.5344208f,0.3758496f,-0.4861724f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448594f,1.36513f,0.7841101f,-0.7099383f,0.01374437f,0.02841171f,0.7035564f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 14.25741f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 14.25741f);
Get(0xDD1E).SetLocalPose(1.45001f,1.279256f,0.8432022f,0.5866413f,-0.5273145f,0.3673397f,-0.4928012f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448706f,1.365052f,0.7840502f,-0.7099521f,0.01372413f,0.02842784f,0.7035422f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 14.27693f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 14.27693f);
Get(0xDD1E).SetLocalPose(1.450251f,1.283319f,0.8421623f,0.5996307f,-0.5126795f,0.3487642f,-0.5059312f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448752f,1.365047f,0.7841604f,-0.7099697f,0.01377204f,0.0284312f,0.7035234f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 14.29511f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 14.29511f);
Get(0xDD1E).SetLocalPose(1.450081f,1.286947f,0.8416386f,0.6106575f,-0.4994658f,0.3324863f,-0.516802f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448687f,1.365116f,0.7841726f,-0.709942f,0.01378805f,0.02842618f,0.7035512f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 14.31348f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 14.31348f);
Get(0xDD1E).SetLocalPose(1.449481f,1.290787f,0.8405502f,0.6258647f,-0.4795033f,0.3088107f,-0.5319831f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448778f,1.364981f,0.7842145f,-0.7099462f,0.01376458f,0.02840942f,0.7035481f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 14.33119f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 14.33119f);
Get(0xDD1E).SetLocalPose(1.448885f,1.294427f,0.8398546f,0.6381952f,-0.4612032f,0.2870959f,-0.5455039f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448802f,1.364908f,0.7842264f,-0.7099555f,0.01375683f,0.02839805f,0.7035394f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 14.34887f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 14.34887f);
Get(0xDD1E).SetLocalPose(1.448591f,1.297755f,0.8395578f,0.6485127f,-0.4442347f,0.2664076f,-0.5577757f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448724f,1.365f,0.7842306f,-0.7099615f,0.01376708f,0.02840514f,0.7035328f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 14.35729f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 14.35729f);
Get(0xDD1E).SetLocalPose(1.448201f,1.30099f,0.8388025f,0.656994f,-0.4289881f,0.2481387f,-0.5681157f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44874f,1.364992f,0.7843691f,-0.7099661f,0.01381738f,0.02840356f,0.7035272f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 14.37686f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 14.37686f);
Get(0xDD1E).SetLocalPose(1.448184f,1.306421f,0.8385504f,0.6698673f,-0.4039671f,0.2180353f,-0.5835658f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448379f,1.364894f,0.7841621f,-0.7099454f,0.01380926f,0.02839218f,0.7035487f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 14.39463f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 14.39463f);
Get(0xDD1E).SetLocalPose(1.447214f,1.310533f,0.8385551f,0.680882f,-0.3812028f,0.193455f,-0.5946926f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448372f,1.364998f,0.7841991f,-0.7099482f,0.01385147f,0.02839914f,0.7035448f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 14.41252f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 14.41252f);
Get(0xDD1E).SetLocalPose(1.446322f,1.316249f,0.8380221f,0.6956465f,-0.3468746f,0.1595707f,-0.6085157f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44825f,1.364883f,0.7839763f,-0.7099488f,0.01384702f,0.02838316f,0.7035449f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 14.43173f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 14.43173f);
Get(0xDD1E).SetLocalPose(1.444378f,1.320573f,0.8382738f,0.7080756f,-0.3134611f,0.1279677f,-0.6196737f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448314f,1.364803f,0.7839878f,-0.7099639f,0.01383558f,0.02840438f,0.7035291f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 14.44043f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 14.44043f);
Get(0xDD1E).SetLocalPose(1.443088f,1.323005f,0.8384737f,0.713949f,-0.2943414f,0.1110169f,-0.6255521f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448159f,1.364838f,0.7840153f,-0.7099532f,0.01388126f,0.02836551f,0.7035406f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 14.46019f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 14.46019f);
Get(0xDD1E).SetLocalPose(1.440664f,1.328476f,0.8392618f,0.7240196f,-0.2539134f,0.07789486f,-0.6365972f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448181f,1.364913f,0.7839535f,-0.7099649f,0.01384348f,0.02837352f,0.7035291f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 14.47826f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 14.47826f);
Get(0xDD1E).SetLocalPose(1.438629f,1.332127f,0.8396202f,0.7296361f,-0.2242913f,0.05551461f,-0.643617f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448142f,1.364927f,0.7838863f,-0.7099461f,0.01385355f,0.0283805f,0.7035475f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 14.49658f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 14.49658f);
Get(0xDD1E).SetLocalPose(1.435313f,1.336741f,0.8402184f,0.7358649f,-0.1827334f,0.02412986f,-0.6515591f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448061f,1.364863f,0.7837847f,-0.7099431f,0.01388622f,0.02838024f,0.70355f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 14.51511f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 14.51511f);
Get(0xDD1E).SetLocalPose(1.432188f,1.340898f,0.8408824f,0.7403865f,-0.142057f,-0.007042794f,-0.6569613f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448153f,1.364733f,0.7839171f,-0.7099699f,0.01384545f,0.02837702f,0.7035238f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 14.52315f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 14.52315f);
Get(0xDD1E).SetLocalPose(1.430583f,1.342295f,0.8411815f,0.7416664f,-0.1258072f,-0.01961437f,-0.6585734f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448004f,1.364792f,0.7838495f,-0.7099287f,0.01388844f,0.02836194f,0.7035652f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 14.54396f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 14.54396f);
Get(0xDD1E).SetLocalPose(1.428547f,1.344002f,0.8412933f,0.7428594f,-0.1057198f,-0.03502462f,-0.6601185f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448018f,1.364587f,0.7838128f,-0.7099426f,0.01385038f,0.0283644f,0.7035518f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 14.56397f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 14.56397f);
Get(0xDD1E).SetLocalPose(1.423651f,1.347214f,0.8421341f,0.7435728f,-0.05992748f,-0.06993639f,-0.6622817f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448025f,1.364655f,0.7838237f,-0.7099474f,0.01384615f,0.02836038f,0.7035473f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 14.57275f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 14.57275f);
Get(0xDD1E).SetLocalPose(1.420099f,1.348952f,0.8426655f,0.7421462f,-0.03233934f,-0.09133561f,-0.6631976f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447984f,1.364634f,0.7837758f,-0.7099314f,0.01386707f,0.02836099f,0.7035629f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 14.59398f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 14.59398f);
Get(0xDD1E).SetLocalPose(1.41656f,1.350283f,0.8431047f,0.7390705f,-0.003014635f,-0.1161232f,-0.6635369f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.4482f,1.364932f,0.7841646f,-0.7099444f,0.01385995f,0.02838995f,0.7035488f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 14.61246f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 14.61246f);
Get(0xDD1E).SetLocalPose(1.412524f,1.351278f,0.8435289f,0.7350178f,0.02079588f,-0.13789f,-0.6635531f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448037f,1.365003f,0.784145f,-0.709913f,0.01386194f,0.02835369f,0.703582f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 14.63063f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 14.63063f);
Get(0xDD1E).SetLocalPose(1.410249f,1.351168f,0.8441918f,0.7317707f,0.03873128f,-0.1541114f,-0.6627679f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448131f,1.365098f,0.7840875f,-0.7099255f,0.01383565f,0.02836939f,0.7035692f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 14.64942f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 14.64942f);
Get(0xDD1E).SetLocalPose(1.406896f,1.350896f,0.8445025f,0.728231f,0.06051553f,-0.1733743f,-0.6602718f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448104f,1.36506f,0.7839522f,-0.7099157f,0.01384925f,0.02833184f,0.7035803f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 14.65815f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 14.65815f);
Get(0xDD1E).SetLocalPose(1.404575f,1.35023f,0.8446823f,0.725803f,0.07425659f,-0.1861201f,-0.6580694f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448284f,1.365019f,0.7838052f,-0.7099342f,0.01386137f,0.0283262f,0.7035617f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 14.67806f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 14.67806f);
Get(0xDD1E).SetLocalPose(1.401149f,1.349427f,0.8450931f,0.7209574f,0.09313367f,-0.2060672f,-0.6550442f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448267f,1.364912f,0.7839884f,-0.7099481f,0.01383792f,0.02833926f,0.7035475f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 14.69632f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 14.69632f);
Get(0xDD1E).SetLocalPose(1.399252f,1.348738f,0.8455474f,0.7174492f,0.1021093f,-0.2170232f,-0.6540192f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448217f,1.364936f,0.7838858f,-0.7099289f,0.01384238f,0.02833495f,0.703567f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 14.71479f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 14.71479f);
Get(0xDD1E).SetLocalPose(1.396075f,1.347211f,0.8460902f,0.711328f,0.1153944f,-0.2354954f,-0.6521031f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44839f,1.364745f,0.7837757f,-0.7099333f,0.01379318f,0.02836105f,0.7035625f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 14.73319f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 14.73319f);
Get(0xDD1E).SetLocalPose(1.39333f,1.345763f,0.8466251f,0.7073013f,0.1255354f,-0.2492744f,-0.6494829f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448454f,1.364817f,0.7839906f,-0.7099603f,0.01378241f,0.02835846f,0.7035355f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 14.74201f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 14.74201f);
Get(0xDD1E).SetLocalPose(1.392251f,1.345066f,0.8467928f,0.7057407f,0.130239f,-0.255322f,-0.6479033f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448385f,1.364738f,0.7839004f,-0.7099543f,0.01379485f,0.02838407f,0.7035404f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 14.76219f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 14.76219f);
Get(0xDD1E).SetLocalPose(1.390136f,1.343817f,0.8464121f,0.7028508f,0.1400018f,-0.2674927f,-0.644087f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448279f,1.36469f,0.7838053f,-0.7099426f,0.0138113f,0.02837589f,0.7035521f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 14.78058f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 14.78058f);
Get(0xDD1E).SetLocalPose(1.387505f,1.341606f,0.8463182f,0.6995835f,0.1505935f,-0.2816661f,-0.6391938f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448146f,1.364683f,0.7838092f,-0.7099277f,0.01379f,0.02837131f,0.7035679f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 14.79848f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 14.79848f);
Get(0xDD1E).SetLocalPose(1.386823f,1.341159f,0.8461131f,0.6986392f,0.1533086f,-0.2855177f,-0.637871f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448054f,1.364819f,0.7837543f,-0.7099196f,0.01384343f,0.02835922f,0.7035754f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 14.81618f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 14.81618f);
Get(0xDD1E).SetLocalPose(1.386077f,1.340556f,0.8461285f,0.6978043f,0.1554891f,-0.2889775f,-0.6366981f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448021f,1.36482f,0.7837772f,-0.7099015f,0.0138475f,0.02836243f,0.7035935f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 14.82459f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 14.82459f);
Get(0xDD1E).SetLocalPose(1.384635f,1.338994f,0.8461581f,0.6961444f,0.1587749f,-0.2960206f,-0.6344647f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448136f,1.36483f,0.7837587f,-0.7099145f,0.01382231f,0.02835151f,0.7035812f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 14.84504f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 14.84504f);
Get(0xDD1E).SetLocalPose(1.383849f,1.337517f,0.8460917f,0.6948486f,0.1609053f,-0.3017448f,-0.6326492f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448198f,1.364792f,0.7836316f,-0.7098868f,0.01382085f,0.02836895f,0.7036086f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 14.86273f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 14.86273f);
Get(0xDD1E).SetLocalPose(1.383118f,1.33636f,0.8458846f,0.6938406f,0.1634361f,-0.3067108f,-0.6307158f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44825f,1.364884f,0.7836131f,-0.7098945f,0.01380204f,0.02834729f,0.703602f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 14.88045f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 14.88045f);
Get(0xDD1E).SetLocalPose(1.381483f,1.334757f,0.8454431f,0.6925465f,0.169109f,-0.3159442f,-0.6260676f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448264f,1.365006f,0.78377f,-0.7099042f,0.0138147f,0.02837114f,0.703591f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 14.89867f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 14.89867f);
Get(0xDD1E).SetLocalPose(1.380331f,1.332877f,0.8458171f,0.6909687f,0.173333f,-0.323644f,-0.6227139f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448189f,1.36504f,0.783718f,-0.7099042f,0.01383105f,0.02835701f,0.7035913f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 14.90777f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 14.90777f);
Get(0xDD1E).SetLocalPose(1.379648f,1.331691f,0.8462467f,0.6903432f,0.1737148f,-0.3260767f,-0.6220317f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44818f,1.364987f,0.7837304f,-0.709923f,0.01381802f,0.02835655f,0.7035726f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 14.92721f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 14.92721f);
Get(0xDD1E).SetLocalPose(1.378806f,1.330419f,0.8471828f,0.6898283f,0.1719349f,-0.3282171f,-0.6219717f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448167f,1.365085f,0.7837738f,-0.7099258f,0.01383708f,0.02835356f,0.7035695f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 14.94491f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 14.94491f);
Get(0xDD1E).SetLocalPose(1.378377f,1.330032f,0.8477443f,0.6898313f,0.1715818f,-0.3293715f,-0.6214555f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448099f,1.365012f,0.7837994f,-0.7099015f,0.01382048f,0.02835784f,0.7035942f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 14.96325f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 14.96325f);
Get(0xDD1E).SetLocalPose(1.378268f,1.329797f,0.8478019f,0.6898736f,0.171704f,-0.3298471f,-0.6211225f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448075f,1.364867f,0.783795f,-0.7098953f,0.01385971f,0.02832533f,0.7036011f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 14.98079f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 14.98079f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448148f,1.364737f,0.7838573f,-0.7099329f,0.01381016f,0.02832469f,0.703564f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 14.99855f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 14.99855f);
Get(0xDD1E).SetLocalPose(1.377806f,1.329758f,0.8480854f,0.6898686f,0.1724273f,-0.3310935f,-0.6202639f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448098f,1.364639f,0.7838402f,-0.7099314f,0.01381104f,0.02835551f,0.7035643f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 15.01614f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 15.01614f);
Get(0xDD1E).SetLocalPose(1.377677f,1.329585f,0.8481526f,0.6897379f,0.1730479f,-0.331831f,-0.6198421f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448068f,1.364596f,0.7838254f,-0.7099364f,0.01380862f,0.02833704f,0.70356f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 15.02436f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 15.02436f);
Get(0xDD1E).SetLocalPose(1.377384f,1.329366f,0.8483698f,0.6895431f,0.1739339f,-0.3327789f,-0.6193025f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448157f,1.364921f,0.7838771f,-0.7099202f,0.0137762f,0.028396f,0.7035747f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 15.04423f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 15.04423f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448308f,1.364977f,0.7839803f,-0.7099218f,0.01377221f,0.02835545f,0.7035747f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 15.06213f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 15.06213f);
Get(0xDD1E).SetLocalPose(1.377267f,1.329231f,0.8484382f,0.6893614f,0.1744387f,-0.3334321f,-0.6190114f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448428f,1.365061f,0.783974f,-0.7099209f,0.01377133f,0.02836047f,0.7035754f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 15.0799f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 15.0799f);
Get(0xDD1E).SetLocalPose(1.376907f,1.328832f,0.8486834f,0.6891594f,0.1747887f,-0.3342902f,-0.6186747f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448348f,1.364964f,0.7837619f,-0.7098836f,0.01380892f,0.0283531f,0.7036126f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 15.09701f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 15.09701f);
Get(0xDD1E).SetLocalPose(1.376802f,1.328703f,0.8487725f,0.6889643f,0.1748807f,-0.3348914f,-0.6185408f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448327f,1.364994f,0.7837715f,-0.7098988f,0.01381737f,0.02837505f,0.7035962f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 15.11517f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 15.11517f);
Get(0xDD1E).SetLocalPose(1.376757f,1.328406f,0.8487822f,0.6880138f,0.1733863f,-0.3366912f,-0.6190422f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448271f,1.365017f,0.7837385f,-0.7099231f,0.01382194f,0.02837264f,0.7035717f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 15.13311f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 15.13311f);
Get(0xDD1E).SetLocalPose(1.376385f,1.32831f,0.848764f,0.687335f,0.1742809f,-0.3381081f,-0.6187727f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44838f,1.36506f,0.7838623f,-0.7099233f,0.01380907f,0.02837181f,0.7035719f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 15.14155f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 15.14155f);
Get(0xDD1E).SetLocalPose(1.376481f,1.328618f,0.8485582f,0.6871718f,0.1750755f,-0.3388257f,-0.618337f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448306f,1.365075f,0.7838549f,-0.7098956f,0.01382524f,0.02839672f,0.7035984f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 15.16049f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 15.16049f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448467f,1.364927f,0.7838185f,-0.7099209f,0.01377824f,0.02838529f,0.7035744f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 15.17953f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 15.17953f);
Get(0xDD1E).SetLocalPose(1.376565f,1.328712f,0.8482437f,0.6869921f,0.1761214f,-0.3398362f,-0.6176848f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448445f,1.365015f,0.7839633f,-0.7099458f,0.0138083f,0.02837567f,0.703549f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 15.19719f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 15.19719f);
Get(0xDD1E).SetLocalPose(1.376547f,1.328693f,0.848243f,0.6869537f,0.1763069f,-0.3400619f,-0.6175504f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448427f,1.365192f,0.78413f,-0.7099444f,0.01380388f,0.02837968f,0.7035504f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 15.2151f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 15.2151f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448544f,1.365223f,0.784234f,-0.709965f,0.01379811f,0.02837819f,0.7035297f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 15.23238f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 15.23238f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448439f,1.365153f,0.7840943f,-0.7099321f,0.01379063f,0.02838416f,0.7035628f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 15.24996f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 15.24996f);
Get(0xDD1E).SetLocalPose(1.37678f,1.328765f,0.8478401f,0.6865044f,0.1771155f,-0.3417455f,-0.6168889f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448436f,1.365018f,0.7841224f,-0.7099397f,0.01380196f,0.02840983f,0.703554f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 15.25871f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 15.25871f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44849f,1.364969f,0.7841732f,-0.7099423f,0.01376115f,0.02841997f,0.7035517f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 15.27808f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 15.27808f);
Get(0xDD1E).SetLocalPose(1.37647f,1.328564f,0.847854f,0.685263f,0.1775731f,-0.3445888f,-0.6165558f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448458f,1.365149f,0.7840435f,-0.7099332f,0.01371839f,0.02844678f,0.7035605f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 15.29607f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 15.29607f);
Get(0xDD1E).SetLocalPose(1.375919f,1.328406f,0.8477949f,0.6827907f,0.1768398f,-0.349557f,-0.6167127f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448614f,1.365142f,0.7840255f,-0.7099637f,0.01373532f,0.02841815f,0.7035306f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 15.31389f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 15.31389f);
Get(0xDD1E).SetLocalPose(1.375183f,1.328274f,0.8477514f,0.6804599f,0.175918f,-0.3538265f,-0.6171176f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448738f,1.365126f,0.784066f,-0.7099668f,0.01374556f,0.02842159f,0.7035272f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 15.332f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 15.332f);
Get(0xDD1E).SetLocalPose(1.373865f,1.327412f,0.8478208f,0.6745363f,0.1772129f,-0.3645242f,-0.6170239f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448687f,1.365226f,0.7840366f,-0.7099494f,0.01378407f,0.02840807f,0.7035446f);
Get(0xDCD4).GetComponent<Animator>().Play("New State", 0, 15.34992f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 15.34992f);
Get(0xDD1E).SetLocalPose(1.372358f,1.326794f,0.8485159f,0.6702376f,0.1779426f,-0.3719399f,-0.6170727f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448593f,1.365172f,0.7839527f,-0.7099402f,0.01377877f,0.0283986f,0.7035543f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 15.36409f);
Get(0xDD1E).SetLocalPose(1.37052f,1.32626f,0.8491645f,0.6670559f,0.1805825f,-0.3786041f,-0.6156991f);
});
r.Add(delegate{
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 15.36409f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448611f,1.365151f,0.784129f,-0.7099383f,0.01379f,0.02842242f,0.703555f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.0939443f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 15.39463f);
Get(0xDD1E).SetLocalPose(1.368133f,1.32502f,0.8499897f,0.6611035f,0.1776939f,-0.3953379f,-0.6124336f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448638f,1.365174f,0.7841232f,-0.7099442f,0.01377061f,0.02841469f,0.7035497f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.1495505f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 15.4127f);
Get(0xDD1E).SetLocalPose(1.3661f,1.324022f,0.8512214f,0.655931f,0.1813064f,-0.4034103f,-0.611672f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448566f,1.365152f,0.7840536f,-0.709953f,0.01379248f,0.02842399f,0.7035401f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.206316f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 15.43115f);
Get(0xDD1E).SetLocalPose(1.364914f,1.323724f,0.8523496f,0.6529069f,0.1927075f,-0.3996065f,-0.6139145f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448503f,1.365036f,0.7841712f,-0.7099544f,0.01380522f,0.02840666f,0.7035391f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.2619628f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 15.44923f);
Get(0xDD1E).SetLocalPose(1.364741f,1.323031f,0.8540106f,0.6514052f,0.1961819f,-0.3898854f,-0.6206234f);
});
r.Add(delegate{
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.2875305f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 15.45754f);
Get(0xDD1E).SetLocalPose(1.364989f,1.32292f,0.8547187f,0.6502819f,0.1958623f,-0.387534f,-0.623369f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448419f,1.365108f,0.7841198f,-0.7099404f,0.01378783f,0.02839154f,0.7035542f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.3491101f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 15.47756f);
Get(0xDD1E).SetLocalPose(1.36509f,1.323025f,0.8549126f,0.6493577f,0.1971911f,-0.3861205f,-0.624789f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448482f,1.365099f,0.7841092f,-0.7099352f,0.01378122f,0.02841515f,0.7035586f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.4047704f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 15.49565f);
Get(0xDD1E).SetLocalPose(1.365344f,1.322682f,0.8556234f,0.6485521f,0.1991015f,-0.3859988f,-0.625095f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448689f,1.364926f,0.7840385f,-0.7099571f,0.01377369f,0.02840628f,0.7035371f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.460288f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 15.51369f);
Get(0xDD1E).SetLocalPose(1.365654f,1.32252f,0.8558555f,0.6489001f,0.1981174f,-0.3859095f,-0.6251017f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44866f,1.364963f,0.7839436f,-0.7099501f,0.0138195f,0.02838127f,0.7035443f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.5161474f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 15.53184f);
Get(0xDD1E).SetLocalPose(1.365946f,1.321571f,0.8561503f,0.64921f,0.1979356f,-0.3861938f,-0.6246617f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448451f,1.364978f,0.7839755f,-0.7099547f,0.01381164f,0.02838226f,0.7035396f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.5702003f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 15.54941f);
Get(0xDD1E).SetLocalPose(1.36616f,1.321397f,0.856455f,0.6491073f,0.1987403f,-0.3852667f,-0.6250853f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448482f,1.365014f,0.7840478f,-0.7099574f,0.01380305f,0.02838501f,0.7035371f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.597575f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 15.55831f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448427f,1.365011f,0.7842144f,-0.7099621f,0.01379872f,0.02836455f,0.7035333f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.6556212f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 15.57717f);
Get(0xDD1E).SetLocalPose(1.366335f,1.321449f,0.8565481f,0.6490991f,0.1991595f,-0.3841063f,-0.6256742f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448107f,1.364963f,0.7840552f,-0.7099209f,0.01387046f,0.02834294f,0.7035742f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.7111132f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 15.59521f);
Get(0xDD1E).SetLocalPose(1.366616f,1.321435f,0.8563666f,0.6493267f,0.1997728f,-0.3832416f,-0.6257728f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448003f,1.364892f,0.7840324f,-0.7099258f,0.01384358f,0.02833606f,0.7035701f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.766571f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 15.61323f);
Get(0xDD1E).SetLocalPose(1.367169f,1.321577f,0.8565412f,0.6495141f,0.1995591f,-0.3823152f,-0.626213f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447981f,1.364935f,0.7840068f,-0.7099284f,0.01384914f,0.02835951f,0.7035664f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.8228433f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 15.63152f);
Get(0xDD1E).SetLocalPose(1.367911f,1.322136f,0.8563388f,0.6496103f,0.1987389f,-0.3811907f,-0.6270589f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448002f,1.364854f,0.7839148f,-0.7099327f,0.01384857f,0.02835213f,0.7035623f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.8764393f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 15.64894f);
Get(0xDD1E).SetLocalPose(1.368639f,1.32275f,0.8560143f,0.6493926f,0.1987087f,-0.3800804f,-0.6279674f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448084f,1.36478f,0.7837996f,-0.7099277f,0.01386019f,0.02837617f,0.7035661f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.9030695f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 15.65759f);
Get(0xDD1E).SetLocalPose(1.369057f,1.322904f,0.856079f,0.6494927f,0.1984932f,-0.3788656f,-0.6286657f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448063f,1.364672f,0.7836961f,-0.7099241f,0.01384089f,0.02836683f,0.7035706f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.9617224f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 15.67665f);
Get(0xDD1E).SetLocalPose(1.369408f,1.322964f,0.8563429f,0.6498204f,0.1971316f,-0.3779493f,-0.6293067f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448061f,1.364753f,0.783706f,-0.7099043f,0.01383385f,0.02836855f,0.7035907f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.01766f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 15.69483f);
Get(0xDD1E).SetLocalPose(1.369825f,1.323311f,0.8563942f,0.6499215f,0.1956327f,-0.3776539f,-0.6298472f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448089f,1.364919f,0.7839711f,-0.7099311f,0.01383333f,0.02837415f,0.7035634f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.072564f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 15.71268f);
Get(0xDD1E).SetLocalPose(1.370044f,1.323635f,0.8568768f,0.649639f,0.1956219f,-0.3774933f,-0.6302381f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448286f,1.364985f,0.7840366f,-0.7099499f,0.01379855f,0.02837963f,0.7035449f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.127371f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 15.73049f);
Get(0xDD1E).SetLocalPose(1.369976f,1.324019f,0.857167f,0.6494057f,0.1957186f,-0.3776038f,-0.6303824f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448344f,1.364941f,0.7839958f,-0.7099531f,0.01375292f,0.02837347f,0.7035428f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.183743f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 15.74881f);
Get(0xDD1E).SetLocalPose(1.370365f,1.323929f,0.8574364f,0.649295f,0.1935054f,-0.3778554f,-0.6310285f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448313f,1.364951f,0.7838434f,-0.7099344f,0.01377711f,0.02839941f,0.7035602f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.210304f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 15.75744f);
Get(0xDD1E).SetLocalPose(1.370414f,1.324273f,0.8575509f,0.6489712f,0.19248f,-0.378297f,-0.6314106f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448456f,1.365005f,0.7840138f,-0.7099606f,0.01378098f,0.02837839f,0.7035345f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.271097f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 15.7772f);
Get(0xDD1E).SetLocalPose(1.370597f,1.324288f,0.8572884f,0.647981f,0.1919971f,-0.3796269f,-0.6317763f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448576f,1.364942f,0.7840738f,-0.7099577f,0.01380596f,0.02837338f,0.7035371f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.325783f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 15.79497f);
Get(0xDD1E).SetLocalPose(1.37071f,1.324286f,0.8577057f,0.6478741f,0.191167f,-0.3798327f,-0.6320139f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448421f,1.364992f,0.7839407f,-0.7099527f,0.013797f,0.0283936f,0.7035416f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.381444f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 15.81306f);
Get(0xDD1E).SetLocalPose(1.370818f,1.32454f,0.8580173f,0.6479681f,0.1896356f,-0.3793729f,-0.6326547f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448447f,1.365024f,0.7840334f,-0.7099459f,0.01380914f,0.0283667f,0.7035493f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.437454f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 15.83127f);
Get(0xDD1E).SetLocalPose(1.370864f,1.324556f,0.8581865f,0.6479846f,0.1885041f,-0.3793576f,-0.6329851f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448325f,1.364915f,0.7839186f,-0.7099391f,0.01378337f,0.0284005f,0.7035552f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.493759f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 15.84957f);
Get(0xDD1E).SetLocalPose(1.370903f,1.324703f,0.8582098f,0.6472325f,0.1890528f,-0.3802675f,-0.6330448f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448396f,1.364953f,0.7839962f,-0.7099314f,0.01377593f,0.02841767f,0.7035625f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.519877f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 15.85805f);
Get(0xDD1E).SetLocalPose(1.370532f,1.324908f,0.8584613f,0.646911f,0.1892967f,-0.3806052f,-0.6330978f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448573f,1.36499f,0.7840128f,-0.7099508f,0.01378425f,0.02839138f,0.7035437f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.577808f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 15.87688f);
Get(0xDD1E).SetLocalPose(1.370324f,1.324855f,0.8586695f,0.6465429f,0.1894439f,-0.3810827f,-0.6331424f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448446f,1.36504f,0.7839928f,-0.7099315f,0.01378796f,0.02841341f,0.7035623f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.632858f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 15.89477f);
Get(0xDD1E).SetLocalPose(1.370055f,1.324907f,0.8587538f,0.6460878f,0.1893701f,-0.3817253f,-0.6332419f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448462f,1.365063f,0.7839475f,-0.7099431f,0.01381737f,0.0283871f,0.7035511f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.687736f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 15.91261f);
Get(0xDD1E).SetLocalPose(1.369724f,1.32495f,0.8587646f,0.6455973f,0.1894514f,-0.3824718f,-0.6332675f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448404f,1.364926f,0.7840158f,-0.7099419f,0.01377806f,0.02838922f,0.703553f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.742361f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 15.93036f);
Get(0xDD1E).SetLocalPose(1.369439f,1.325083f,0.8585619f,0.644831f,0.1898573f,-0.3836073f,-0.6332398f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448449f,1.364911f,0.784006f,-0.7099328f,0.01377566f,0.02838228f,0.7035625f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.798802f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 15.94871f);
Get(0xDD1E).SetLocalPose(1.369199f,1.325062f,0.8586583f,0.6442035f,0.1903556f,-0.3844834f,-0.6331976f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448416f,1.364877f,0.7840245f,-0.7099471f,0.01378796f,0.0283611f,0.7035487f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.825682f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 15.95744f);
Get(0xDD1E).SetLocalPose(1.36907f,1.324937f,0.8589973f,0.6431702f,0.1912971f,-0.3858254f,-0.633148f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44845f,1.364888f,0.7840741f,-0.7099388f,0.01378515f,0.028365f,0.7035569f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.886248f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 15.97713f);
Get(0xDD1E).SetLocalPose(1.368632f,1.324646f,0.8592619f,0.6419096f,0.1927992f,-0.3875382f,-0.6329255f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.4484f,1.36497f,0.7839221f,-0.7099557f,0.01377057f,0.02836727f,0.7035401f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.941867f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 15.9952f);
Get(0xDD1E).SetLocalPose(1.367783f,1.324407f,0.8596013f,0.6392778f,0.1959588f,-0.3911239f,-0.6324131f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448435f,1.364932f,0.7840668f,-0.7099462f,0.01379382f,0.02839277f,0.7035481f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.996567f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 16.01298f);
Get(0xDD1E).SetLocalPose(1.367031f,1.324072f,0.8597531f,0.6369374f,0.198763f,-0.394259f,-0.6319523f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44857f,1.36484f,0.7841008f,-0.709947f,0.01376937f,0.02838205f,0.7035483f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.051999f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 16.03099f);
Get(0xDD1E).SetLocalPose(1.366131f,1.324181f,0.8598507f,0.6343906f,0.2022277f,-0.3975806f,-0.6313337f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44852f,1.364908f,0.7840682f,-0.7099167f,0.01378768f,0.02840792f,0.7035775f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.108942f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 16.0495f);
Get(0xDD1E).SetLocalPose(1.364711f,1.324472f,0.8602656f,0.629756f,0.2085135f,-0.4033483f,-0.6302696f);
});
r.Add(delegate{
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.135825f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 16.05824f);
Get(0xDD1E).SetLocalPose(1.363641f,1.324733f,0.8608127f,0.6261002f,0.2135517f,-0.4079465f,-0.6292647f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448315f,1.364947f,0.7840208f,-0.7099229f,0.01380885f,0.02838227f,0.7035719f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.195221f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 16.07754f);
Get(0xDD1E).SetLocalPose(1.36215f,1.324778f,0.8611915f,0.6212223f,0.2203352f,-0.4142092f,-0.6276671f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448406f,1.365005f,0.7840183f,-0.7099221f,0.01381156f,0.02839276f,0.7035722f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.251754f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 16.09591f);
Get(0xDD1E).SetLocalPose(1.360975f,1.324687f,0.8617153f,0.6167828f,0.2264234f,-0.4201258f,-0.6259439f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448313f,1.364858f,0.7836865f,-0.7099281f,0.01377482f,0.0283911f,0.7035669f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.307991f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 16.11419f);
Get(0xDD1E).SetLocalPose(1.358099f,1.32378f,0.8631134f,0.6061252f,0.2404324f,-0.4335027f,-0.6219968f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448498f,1.364951f,0.7837446f,-0.7099081f,0.01376874f,0.02841706f,0.7035861f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.363684f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 16.13229f);
Get(0xDD1E).SetLocalPose(1.35578f,1.323025f,0.8638257f,0.597534f,0.2524044f,-0.4439262f,-0.6182028f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448665f,1.365144f,0.7838918f,-0.7099348f,0.0137542f,0.02843061f,0.703559f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.388204f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 16.14026f);
Get(0xDD1E).SetLocalPose(1.354533f,1.322963f,0.8641639f,0.5922259f,0.2598668f,-0.4504266f,-0.6155109f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448513f,1.365265f,0.7837648f,-0.7099023f,0.01373931f,0.02844352f,0.7035915f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.449911f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 16.16032f);
Get(0xDD1E).SetLocalPose(1.351622f,1.32167f,0.864889f,0.5813351f,0.275054f,-0.4638868f,-0.6092651f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448655f,1.365264f,0.7838889f,-0.7099131f,0.01376404f,0.02842537f,0.7035808f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.503977f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 16.17789f);
Get(0xDD1E).SetLocalPose(1.34932f,1.320694f,0.8652844f,0.5732551f,0.2864241f,-0.4740314f,-0.6038494f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448765f,1.365159f,0.783829f,-0.7099404f,0.01375117f,0.02842932f,0.7035534f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.558232f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 16.19552f);
Get(0xDD1E).SetLocalPose(1.346649f,1.319859f,0.8652753f,0.5608023f,0.3035486f,-0.4894884f,-0.5947775f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448859f,1.365219f,0.7838904f,-0.7099569f,0.01377653f,0.02839835f,0.7035375f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.612808f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 16.21326f);
Get(0xDD1E).SetLocalPose(1.343981f,1.317062f,0.866556f,0.5461457f,0.3227074f,-0.5069156f,-0.5836278f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448641f,1.365308f,0.7838519f,-0.7099178f,0.01381094f,0.02839088f,0.7035766f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.668715f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 16.23143f);
Get(0xDD1E).SetLocalPose(1.340827f,1.314972f,0.8672704f,0.5331799f,0.3386061f,-0.5213018f,-0.573855f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448626f,1.365203f,0.7840008f,-0.7099338f,0.01377843f,0.02839138f,0.7035611f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.723132f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 16.24911f);
Get(0xDD1E).SetLocalPose(1.338261f,1.311798f,0.8680657f,0.516198f,0.3576575f,-0.5390437f,-0.5612955f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448492f,1.364975f,0.7838976f,-0.7099257f,0.01378539f,0.02836503f,0.7035702f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.747654f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 16.25708f);
Get(0xDD1E).SetLocalPose(1.33685f,1.310673f,0.8680457f,0.5089519f,0.3653072f,-0.5464543f,-0.5557933f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448369f,1.364815f,0.7837957f,-0.7099281f,0.0137918f,0.02839974f,0.7035663f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.807891f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 16.27666f);
Get(0xDD1E).SetLocalPose(1.334917f,1.307874f,0.8692738f,0.4933539f,0.3810614f,-0.5619279f,-0.5437198f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448239f,1.364808f,0.7837006f,-0.7099048f,0.01380477f,0.02840817f,0.7035891f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.864525f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 16.29506f);
Get(0xDD1E).SetLocalPose(1.332888f,1.304238f,0.8704521f,0.4783102f,0.3952987f,-0.576008f,-0.5321401f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448179f,1.364818f,0.7836924f,-0.7099147f,0.01378213f,0.02838542f,0.7035805f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.91837f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 16.31256f);
Get(0xDD1E).SetLocalPose(1.332388f,1.30075f,0.8709081f,0.4679495f,0.4047346f,-0.5851596f,-0.5242152f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448353f,1.364809f,0.7837771f,-0.7099244f,0.01380056f,0.02838044f,0.7035705f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.974523f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 16.33081f);
Get(0xDD1E).SetLocalPose(1.331464f,1.296775f,0.8724326f,0.451284f,0.4184509f,-0.5989612f,-0.5123351f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448287f,1.364789f,0.7837861f,-0.7099153f,0.01381446f,0.02838141f,0.7035794f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.029933f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 16.34882f);
Get(0xDD1E).SetLocalPose(1.329704f,1.294018f,0.8734777f,0.4365751f,0.4289719f,-0.6112559f,-0.5017484f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448437f,1.364944f,0.7838943f,-0.7099023f,0.013808f,0.02838454f,0.7035924f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.056267f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 16.35738f);
Get(0xDD1E).SetLocalPose(1.329302f,1.292298f,0.874095f,0.4296321f,0.4331454f,-0.6174946f,-0.4964894f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448385f,1.365005f,0.7839984f,-0.7099392f,0.01383541f,0.02839322f,0.7035545f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.118235f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 16.37752f);
Get(0xDD1E).SetLocalPose(1.328147f,1.288249f,0.8745269f,0.4190134f,0.4380656f,-0.6281261f,-0.4878361f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448287f,1.365003f,0.7839619f,-0.7099358f,0.01381803f,0.02838443f,0.7035586f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.173555f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 16.3955f);
Get(0xDD1E).SetLocalPose(1.32824f,1.284082f,0.8738858f,0.4117661f,0.4405639f,-0.6353579f,-0.4823616f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448205f,1.364921f,0.7839434f,-0.7099471f,0.01379155f,0.02841425f,0.7035465f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.227502f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 16.41303f);
Get(0xDD1E).SetLocalPose(1.327781f,1.280414f,0.8744237f,0.4027769f,0.4433541f,-0.6437274f,-0.4762594f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448222f,1.364942f,0.7838304f,-0.7099411f,0.01380984f,0.02837912f,0.7035536f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.283879f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 16.43135f);
Get(0xDD1E).SetLocalPose(1.328139f,1.277256f,0.8744931f,0.3935605f,0.4456629f,-0.6520553f,-0.4704452f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448219f,1.365092f,0.7838214f,-0.7099368f,0.01383752f,0.02838129f,0.7035573f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.338817f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 16.44921f);
Get(0xDD1E).SetLocalPose(1.328134f,1.274305f,0.8753012f,0.3862092f,0.4469641f,-0.6591308f,-0.4654161f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448249f,1.364941f,0.7837455f,-0.7099239f,0.01382918f,0.02838827f,0.7035702f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.364982f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 16.45771f);
Get(0xDD1E).SetLocalPose(1.328249f,1.27357f,0.8759153f,0.3832129f,0.4472566f,-0.6621898f,-0.4632646f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448282f,1.36497f,0.7837831f,-0.7099307f,0.01385894f,0.02837023f,0.7035635f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.42415f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 16.47694f);
Get(0xDD1E).SetLocalPose(1.329158f,1.271692f,0.8767831f,0.3784386f,0.4471161f,-0.6672311f,-0.4600805f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448308f,1.364916f,0.783868f,-0.709922f,0.01385516f,0.02838005f,0.7035719f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.479495f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 16.49493f);
Get(0xDD1E).SetLocalPose(1.330164f,1.26992f,0.8777621f,0.3747508f,0.447117f,-0.671078f,-0.457496f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448398f,1.364985f,0.7839344f,-0.7099229f,0.01383326f,0.02836417f,0.7035722f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.533708f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 16.51254f);
Get(0xDD1E).SetLocalPose(1.32997f,1.269088f,0.8786627f,0.3710186f,0.4473663f,-0.6749371f,-0.4546082f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448438f,1.364957f,0.784007f,-0.7099317f,0.01383361f,0.02838985f,0.7035622f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.590394f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 16.53097f);
Get(0xDD1E).SetLocalPose(1.330961f,1.268154f,0.8797295f,0.3671042f,0.447044f,-0.6794511f,-0.4513673f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448372f,1.364845f,0.7839948f,-0.7099455f,0.0138455f,0.02838987f,0.703548f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.615791f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 16.53922f);
Get(0xDD1E).SetLocalPose(1.33181f,1.266996f,0.8797781f,0.3658413f,0.4461276f,-0.6815374f,-0.4501522f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448298f,1.364843f,0.7838692f,-0.7099304f,0.0138413f,0.02837956f,0.7035637f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.680509f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 16.56026f);
Get(0xDD1E).SetLocalPose(1.3315f,1.266828f,0.8799289f,0.3638141f,0.44493f,-0.6844677f,-0.4485318f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448174f,1.364924f,0.7837568f,-0.7098888f,0.01385768f,0.0283787f,0.7036055f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.737693f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 16.57884f);
Get(0xDD1E).SetLocalPose(1.332201f,1.265863f,0.8806439f,0.3617744f,0.4436163f,-0.6874444f,-0.4469274f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448035f,1.364925f,0.7835591f,-0.7098912f,0.01386563f,0.0283731f,0.7036031f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.795968f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 16.59778f);
Get(0xDD1E).SetLocalPose(1.332924f,1.265082f,0.8812939f,0.360326f,0.4426363f,-0.6896775f,-0.4456268f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447889f,1.364851f,0.7833764f,-0.7098811f,0.01391149f,0.02834347f,0.7036136f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.853092f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 16.61634f);
Get(0xDD1E).SetLocalPose(1.333373f,1.264998f,0.8817056f,0.3598287f,0.4417566f,-0.6910896f,-0.444713f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447857f,1.364823f,0.7834371f,-0.7098769f,0.01390533f,0.02833737f,0.7036182f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.879982f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 16.62508f);
Get(0xDD1E).SetLocalPose(1.334264f,1.264271f,0.8816223f,0.3599176f,0.4413706f,-0.691526f,-0.4443459f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447926f,1.364704f,0.7834827f,-0.7098851f,0.01388247f,0.02836358f,0.7036093f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.939995f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 16.64459f);
Get(0xDD1E).SetLocalPose(1.335688f,1.263067f,0.8814515f,0.359882f,0.4407684f,-0.6923535f,-0.4436832f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447974f,1.364757f,0.7835463f,-0.7098954f,0.01387444f,0.02835495f,0.7035993f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.996928f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 16.66309f);
Get(0xDD1E).SetLocalPose(1.335739f,1.262229f,0.8815893f,0.3600836f,0.4396658f,-0.6931088f,-0.4434343f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44789f,1.364711f,0.7835758f,-0.7099038f,0.01385523f,0.02834513f,0.7035916f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.054325f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 16.68174f);
Get(0xDD1E).SetLocalPose(1.336383f,1.260423f,0.8822736f,0.3609181f,0.4382828f,-0.6934501f,-0.4435913f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44792f,1.36478f,0.7836055f,-0.7098932f,0.01386803f,0.02837187f,0.7036011f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.10902f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 16.69952f);
Get(0xDD1E).SetLocalPose(1.336282f,1.260081f,0.8825909f,0.3617706f,0.4375609f,-0.6932186f,-0.4439713f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44797f,1.364761f,0.7836005f,-0.7099169f,0.01384791f,0.0283794f,0.7035772f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.136986f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 16.70861f);
Get(0xDD1E).SetLocalPose(1.33601f,1.260346f,0.8828272f,0.3627226f,0.4370507f,-0.6927262f,-0.4444654f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448018f,1.364837f,0.7837116f,-0.7099021f,0.01387344f,0.02834588f,0.703593f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.196341f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 16.7279f);
Get(0xDD1E).SetLocalPose(1.336286f,1.260492f,0.8828601f,0.3636789f,0.4367723f,-0.6921334f,-0.4448808f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448211f,1.364701f,0.7837474f,-0.7099186f,0.01383644f,0.02836053f,0.7035764f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.253572f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 16.7465f);
Get(0xDD1E).SetLocalPose(1.336625f,1.26205f,0.8827205f,0.3642607f,0.4363689f,-0.6921276f,-0.4448097f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448147f,1.36476f,0.7837175f,-0.7099199f,0.01382787f,0.02834548f,0.7035759f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.30774f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 16.7641f);
Get(0xDD1E).SetLocalPose(1.336846f,1.262475f,0.8837512f,0.3645767f,0.4356776f,-0.6924603f,-0.4447108f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448076f,1.364895f,0.7837657f,-0.7099057f,0.01388585f,0.0283222f,0.7035901f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.36303f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 16.78207f);
Get(0xDD1E).SetLocalPose(1.336744f,1.263017f,0.8837525f,0.3651104f,0.4347712f,-0.6924072f,-0.4452423f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448072f,1.364918f,0.7837529f,-0.7099232f,0.01386671f,0.02833323f,0.7035723f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.388523f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 16.79036f);
Get(0xDD1E).SetLocalPose(1.336838f,1.263394f,0.8837608f,0.3661238f,0.4338202f,-0.6918848f,-0.446149f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447964f,1.364786f,0.7836816f,-0.7099032f,0.01385386f,0.02833157f,0.7035929f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.450883f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 16.81063f);
Get(0xDD1E).SetLocalPose(1.33676f,1.264442f,0.8839803f,0.3681745f,0.4323309f,-0.690738f,-0.4476813f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448028f,1.364906f,0.7836636f,-0.7098986f,0.01386097f,0.02833335f,0.7035973f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.507121f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 16.8289f);
Get(0xDD1E).SetLocalPose(1.337564f,1.264634f,0.8838145f,0.3687769f,0.4319165f,-0.6907387f,-0.4475845f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448145f,1.364913f,0.7838629f,-0.7099121f,0.01381627f,0.02836396f,0.7035832f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.561064f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 16.84643f);
Get(0xDD1E).SetLocalPose(1.337737f,1.264465f,0.8832635f,0.3689182f,0.4315407f,-0.6908078f,-0.4477239f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44828f,1.364895f,0.783909f,-0.7099234f,0.01379383f,0.02836475f,0.7035723f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.615575f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 16.86415f);
Get(0xDD1E).SetLocalPose(1.33855f,1.26348f,0.8829916f,0.3694021f,0.4308334f,-0.690618f,-0.4482985f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448219f,1.36491f,0.7838826f,-0.7099077f,0.01379892f,0.02834106f,0.7035891f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.672157f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 16.88254f);
Get(0xDD1E).SetLocalPose(1.338861f,1.263841f,0.8826755f,0.370362f,0.4298938f,-0.6900967f,-0.4492104f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448187f,1.364912f,0.7838949f,-0.7098964f,0.0138347f,0.02836015f,0.7035989f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.698437f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 16.89108f);
Get(0xDD1E).SetLocalPose(1.338826f,1.263825f,0.8826026f,0.3711286f,0.4292627f,-0.6896159f,-0.449919f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448149f,1.364912f,0.7838696f,-0.7098909f,0.01384409f,0.02836279f,0.7036042f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.755929f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 16.90976f);
Get(0xDD1E).SetLocalPose(1.338778f,1.263942f,0.8821912f,0.3729077f,0.4278969f,-0.6884134f,-0.4515874f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448053f,1.365121f,0.7838482f,-0.7099069f,0.0138463f,0.02836362f,0.703588f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.812215f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 16.92805f);
Get(0xDD1E).SetLocalPose(1.338096f,1.264339f,0.8827806f,0.3732592f,0.4276829f,-0.6880631f,-0.4520333f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448085f,1.365047f,0.7838091f,-0.7098906f,0.01382959f,0.02835668f,0.703605f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.86632f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 16.94564f);
Get(0xDD1E).SetLocalPose(1.337983f,1.264778f,0.8829408f,0.3738266f,0.4273248f,-0.6874453f,-0.4528423f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448168f,1.365079f,0.7838299f,-0.7099165f,0.0138484f,0.02836893f,0.703578f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.921187f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 16.96347f);
Get(0xDD1E).SetLocalPose(1.337063f,1.266557f,0.8832904f,0.3753974f,0.4264345f,-0.6861259f,-0.4543806f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448256f,1.364922f,0.7837713f,-0.7099082f,0.01383939f,0.02837612f,0.7035862f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.975922f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 16.98126f);
Get(0xDD1E).SetLocalPose(1.335822f,1.26807f,0.8830512f,0.3779434f,0.4250138f,-0.6841074f,-0.4566391f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448386f,1.364827f,0.7838233f,-0.7099189f,0.01384534f,0.02836795f,0.7035757f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.005736f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 16.99095f);
Get(0xDD1E).SetLocalPose(1.335763f,1.268028f,0.8828722f,0.3793007f,0.4243439f,-0.6829904f,-0.4578072f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448475f,1.364794f,0.7837927f,-0.7099233f,0.0138332f,0.02838901f,0.7035707f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.075907f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 17.01376f);
Get(0xDD1E).SetLocalPose(1.335649f,1.268042f,0.8825401f,0.381346f,0.4240408f,-0.680472f,-0.4601332f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448449f,1.364894f,0.7838526f,-0.7099352f,0.01383702f,0.02837133f,0.7035593f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.109435f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 17.02465f);
Get(0xDD1E).SetLocalPose(1.334809f,1.268584f,0.8825561f,0.3821068f,0.4239096f,-0.6794734f,-0.4610977f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448092f,1.364881f,0.7836086f,-0.7099174f,0.0138575f,0.02835197f,0.7035776f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.184794f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 17.04914f);
Get(0xDD1E).SetLocalPose(1.333578f,1.270015f,0.881768f,0.3863892f,0.4209963f,-0.6754395f,-0.4660977f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448108f,1.364873f,0.783715f,-0.7099149f,0.0138387f,0.02836803f,0.7035799f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.212881f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 17.05827f);
Get(0xDD1E).SetLocalPose(1.333043f,1.271726f,0.8808247f,0.3898397f,0.4185848f,-0.6721562f,-0.4701255f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448148f,1.364874f,0.7837315f,-0.7099174f,0.01386815f,0.02835471f,0.7035774f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.282281f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 17.08083f);
Get(0xDD1E).SetLocalPose(1.332293f,1.274294f,0.8790399f,0.3970501f,0.4135007f,-0.6651519f,-0.4784782f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448122f,1.364866f,0.7836871f,-0.7099196f,0.01384669f,0.02835928f,0.7035753f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.309942f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 17.08982f);
Get(0xDD1E).SetLocalPose(1.332176f,1.275845f,0.8787456f,0.4024179f,0.409967f,-0.6597238f,-0.4845115f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448149f,1.364804f,0.7836431f,-0.7099178f,0.01379761f,0.02838303f,0.7035772f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.373433f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 17.11045f);
Get(0xDD1E).SetLocalPose(1.332088f,1.278884f,0.8777457f,0.410508f,0.4048786f,-0.651566f,-0.4929688f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448047f,1.364849f,0.7836127f,-0.7099164f,0.01384167f,0.02837663f,0.7035781f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.428934f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 17.12849f);
Get(0xDD1E).SetLocalPose(1.332283f,1.281173f,0.876151f,0.4174967f,0.4002674f,-0.6441351f,-0.5005723f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448182f,1.364952f,0.7838141f,-0.7099177f,0.01384099f,0.02835642f,0.7035775f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.485239f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 17.14679f);
Get(0xDD1E).SetLocalPose(1.332849f,1.284647f,0.8755526f,0.4250727f,0.3948821f,-0.6360957f,-0.5086882f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448259f,1.36483f,0.7838084f,-0.7099239f,0.01380521f,0.0284005f,0.7035702f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.541302f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 17.16501f);
Get(0xDD1E).SetLocalPose(1.332382f,1.290777f,0.8751678f,0.440513f,0.381212f,-0.6204397f,-0.5250527f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448417f,1.364849f,0.7839971f,-0.7099496f,0.01379844f,0.02842299f,0.7035435f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.597234f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 17.18319f);
Get(0xDD1E).SetLocalPose(1.333451f,1.296515f,0.8742474f,0.459735f,0.3641396f,-0.6008343f,-0.5431798f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448471f,1.364911f,0.7840388f,-0.7099509f,0.01380619f,0.02841694f,0.7035423f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.62318f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 17.19162f);
Get(0xDD1E).SetLocalPose(1.334f,1.299828f,0.8723963f,0.4713252f,0.3550001f,-0.5880557f,-0.553189f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448565f,1.364948f,0.7839905f,-0.7099494f,0.01379223f,0.02842316f,0.7035437f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.68412f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 17.21143f);
Get(0xDD1E).SetLocalPose(1.335394f,1.301405f,0.8720922f,0.4775282f,0.3510079f,-0.5809812f,-0.5578721f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448532f,1.365028f,0.7840366f,-0.7099366f,0.01378436f,0.02844512f,0.703556f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.740611f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 17.22979f);
Get(0xDD1E).SetLocalPose(1.335733f,1.304273f,0.8721279f,0.4863749f,0.344659f,-0.5710428f,-0.5644112f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448482f,1.365083f,0.783915f,-0.7099362f,0.01379254f,0.02841698f,0.7035573f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.79825f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 17.24852f);
Get(0xDD1E).SetLocalPose(1.337527f,1.311233f,0.8703755f,0.5072166f,0.3217711f,-0.5455272f,-0.5844612f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448593f,1.365205f,0.7839866f,-0.7099408f,0.01379498f,0.02842413f,0.7035524f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.8266f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 17.25773f);
Get(0xDD1E).SetLocalPose(1.338611f,1.313123f,0.869858f,0.5132908f,0.3152811f,-0.5378798f,-0.5897591f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448369f,1.365319f,0.7841481f,-0.7099377f,0.0138209f,0.02841218f,0.7035555f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.887784f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 17.27762f);
Get(0xDD1E).SetLocalPose(1.342954f,1.320028f,0.8685685f,0.5384192f,0.2884147f,-0.5060548f,-0.6089585f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448504f,1.365313f,0.784227f,-0.7099389f,0.01381551f,0.02839798f,0.7035549f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.944977f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 17.29621f);
Get(0xDD1E).SetLocalPose(1.346508f,1.324181f,0.8671766f,0.5546787f,0.2695124f,-0.4830565f,-0.6215714f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448486f,1.36508f,0.7842655f,-0.7099491f,0.01381191f,0.02839173f,0.703545f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.001042f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 17.31443f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448328f,1.364948f,0.7841423f,-0.7099505f,0.01381495f,0.02841776f,0.7035424f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.057655f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 17.33283f);
Get(0xDD1E).SetLocalPose(1.350556f,1.327699f,0.8659071f,0.5674015f,0.2536181f,-0.4621017f,-0.6326101f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448459f,1.364872f,0.7840583f,-0.7099497f,0.01383287f,0.02841885f,0.7035428f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.085555f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 17.3419f);
Get(0xDD1E).SetLocalPose(1.354201f,1.331334f,0.8645165f,0.5793963f,0.2376578f,-0.4388334f,-0.6443943f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448475f,1.364979f,0.7840533f,-0.7099546f,0.01379245f,0.02840105f,0.7035394f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.147619f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 17.36207f);
Get(0xDD1E).SetLocalPose(1.360508f,1.335915f,0.8629156f,0.5962529f,0.2138128f,-0.4041224f,-0.6598876f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448452f,1.364977f,0.7840751f,-0.7099413f,0.01379583f,0.0284134f,0.7035524f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.204447f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 17.38054f);
Get(0xDD1E).SetLocalPose(1.370553f,1.341067f,0.8605886f,0.6223433f,0.1690205f,-0.3539588f,-0.6773729f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448369f,1.364914f,0.7839699f,-0.7099289f,0.01376496f,0.02840048f,0.703566f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.261909f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 17.39921f);
Get(0xDD1E).SetLocalPose(1.378548f,1.34356f,0.8588347f,0.6421664f,0.129675f,-0.3092556f,-0.6893241f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448391f,1.364834f,0.7838891f,-0.7099176f,0.0137851f,0.02839182f,0.7035772f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.289445f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 17.40816f);
Get(0xDD1E).SetLocalPose(1.382019f,1.344647f,0.8580117f,0.6484054f,0.1151118f,-0.291194f,-0.6939207f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44828f,1.364742f,0.7838442f,-0.7099057f,0.01381756f,0.02839121f,0.7035886f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.348398f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 17.42732f);
Get(0xDD1E).SetLocalPose(1.390707f,1.346237f,0.8563136f,0.6619822f,0.08233418f,-0.2465247f,-0.7030123f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448236f,1.364951f,0.7837226f,-0.7099066f,0.01382413f,0.02838182f,0.7035879f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.402633f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 17.44495f);
Get(0xDD1E).SetLocalPose(1.396582f,1.346119f,0.8554054f,0.6697057f,0.06258038f,-0.2200204f,-0.7065189f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448194f,1.36496f,0.7836528f,-0.7098966f,0.01380657f,0.02837524f,0.7035987f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.458457f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 17.46309f);
Get(0xDD1E).SetLocalPose(1.403343f,1.34587f,0.8545268f,0.6788177f,0.03488948f,-0.1873491f,-0.7091471f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448111f,1.364941f,0.7835456f,-0.7098888f,0.01384588f,0.0283528f,0.7036068f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.515784f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 17.48172f);
Get(0xDD1E).SetLocalPose(1.408347f,1.343909f,0.8536679f,0.6870892f,0.01157956f,-0.1587667f,-0.70892f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448053f,1.364872f,0.7835243f,-0.7098809f,0.01383528f,0.02833397f,0.7036157f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.571295f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 17.49976f);
Get(0xDD1E).SetLocalPose(1.413722f,1.341475f,0.852999f,0.6940171f,-0.008222564f,-0.1317427f,-0.7077546f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447918f,1.364813f,0.7834285f,-0.7098698f,0.01386887f,0.02835292f,0.7036254f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.59699f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 17.50811f);
Get(0xDD1E).SetLocalPose(1.415105f,1.340701f,0.8526251f,0.695691f,-0.01353864f,-0.1242623f,-0.7073822f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447958f,1.365005f,0.7835662f,-0.7098775f,0.01384957f,0.02833316f,0.7036188f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.65829f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 17.52803f);
Get(0xDD1E).SetLocalPose(1.418674f,1.338133f,0.852606f,0.6998125f,-0.03005972f,-0.1021687f,-0.706343f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44805f,1.365013f,0.7836662f,-0.7098941f,0.01384169f,0.02834712f,0.7036017f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.714166f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 17.54619f);
Get(0xDD1E).SetLocalPose(1.420923f,1.336168f,0.852454f,0.7022091f,-0.04065336f,-0.08919197f,-0.7051912f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448139f,1.365079f,0.7837358f,-0.7099082f,0.0138507f,0.02834538f,0.7035872f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.769192f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 17.56408f);
Get(0xDD1E).SetLocalPose(1.42368f,1.332927f,0.8519173f,0.706403f,-0.05654974f,-0.07087245f,-0.7019787f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448106f,1.364931f,0.7837157f,-0.7098955f,0.0138547f,0.02832352f,0.7036009f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.825034f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 17.58223f);
Get(0xDD1E).SetLocalPose(1.424767f,1.330789f,0.8518186f,0.7090737f,-0.06270766f,-0.06327993f,-0.6994842f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44812f,1.365047f,0.783896f,-0.7099187f,0.01385258f,0.02834837f,0.7035766f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.879115f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 17.5998f);
Get(0xDD1E).SetLocalPose(1.42474f,1.328519f,0.8517828f,0.7119721f,-0.06767321f,-0.05714807f,-0.6965991f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44808f,1.365062f,0.7838556f,-0.7099047f,0.01383295f,0.02837868f,0.7035899f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.905467f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 17.60837f);
Get(0xDD1E).SetLocalPose(1.4249f,1.328047f,0.851735f,0.7124292f,-0.06831579f,-0.05627318f,-0.6961401f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448043f,1.365095f,0.783851f,-0.7099158f,0.01384174f,0.02836573f,0.7035791f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.962728f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 17.62698f);
Get(0xDD1E).SetLocalPose(1.424816f,1.32551f,0.8518751f,0.7143157f,-0.07241737f,-0.05234613f,-0.6940957f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448213f,1.364913f,0.7839794f,-0.7099371f,0.01383635f,0.02837027f,0.7035574f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 7.018221f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 17.64501f);
Get(0xDD1E).SetLocalPose(1.425284f,1.323957f,0.8520771f,0.7151419f,-0.07713989f,-0.04840285f,-0.6930214f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448262f,1.364986f,0.7841196f,-0.7099487f,0.01381392f,0.02837402f,0.703546f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 7.073042f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 17.66283f);
Get(0xDD1E).SetLocalPose(1.425865f,1.322149f,0.8521639f,0.7160999f,-0.08189204f,-0.04427825f,-0.6917616f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448387f,1.36503f,0.7840819f,-0.7099323f,0.01384506f,0.02837095f,0.703562f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 7.127702f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 17.68059f);
Get(0xDD1E).SetLocalPose(1.426312f,1.320191f,0.8523881f,0.717318f,-0.08509659f,-0.04133499f,-0.6902934f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448125f,1.365027f,0.78411f,-0.7099306f,0.01388495f,0.02834947f,0.7035639f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 7.183342f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 17.69868f);
Get(0xDD1E).SetLocalPose(1.426579f,1.319158f,0.8524901f,0.7183055f,-0.08635864f,-0.03961202f,-0.6892099f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448077f,1.364866f,0.7838498f,-0.7099329f,0.01383426f,0.02836201f,0.703562f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 7.210306f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 17.70744f);
Get(0xDD1E).SetLocalPose(1.426895f,1.318811f,0.8526206f,0.7186109f,-0.08625901f,-0.03943139f,-0.6889144f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448056f,1.364744f,0.7837976f,-0.709925f,0.01382948f,0.02836063f,0.7035701f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 7.287418f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 17.7325f);
Get(0xDD1E).SetLocalPose(1.427027f,1.318285f,0.8527914f,0.7189307f,-0.08590628f,-0.03968818f,-0.68861f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448117f,1.364824f,0.7838411f,-0.7099261f,0.01381978f,0.02837828f,0.7035685f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 7.328325f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 17.7458f);
Get(0xDD1E).SetLocalPose(1.427077f,1.318057f,0.8528374f,0.7190782f,-0.08636036f,-0.03910289f,-0.6884325f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448154f,1.364789f,0.7837069f,-0.7099253f,0.01382469f,0.02838275f,0.7035691f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 7.385874f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 17.7645f);
Get(0xDD1E).SetLocalPose(1.427243f,1.317384f,0.8529319f,0.7193336f,-0.0866591f,-0.0384243f,-0.6881665f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448353f,1.364879f,0.783924f,-0.7099404f,0.01382256f,0.02838687f,0.7035536f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 7.440354f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 17.78221f);
Get(0xDD1E).SetLocalPose(1.427638f,1.317402f,0.8529329f,0.7194171f,-0.08666315f,-0.0378707f,-0.6881093f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448362f,1.365031f,0.7838791f,-0.7099383f,0.01382041f,0.02839276f,0.7035556f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 7.467299f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 17.79096f);
Get(0xDD1E).SetLocalPose(1.427832f,1.317536f,0.8528851f,0.7193522f,-0.0864343f,-0.03784587f,-0.6882073f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448339f,1.365111f,0.7837753f,-0.709925f,0.01381154f,0.02839083f,0.7035693f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 7.527823f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 17.81063f);
Get(0xDD1E).SetLocalPose(1.428024f,1.317805f,0.8527475f,0.7190474f,-0.08591492f,-0.03828889f,-0.6885663f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448565f,1.364995f,0.7838835f,-0.7099392f,0.01379153f,0.02838521f,0.7035556f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 7.582691f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 17.82847f);
Get(0xDD1E).SetLocalPose(1.428101f,1.318531f,0.8527122f,0.7186174f,-0.08598463f,-0.03849953f,-0.6889946f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448447f,1.364891f,0.7836991f,-0.7099203f,0.01379924f,0.02840105f,0.7035739f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 7.637477f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 17.84627f);
Get(0xDD1E).SetLocalPose(1.428464f,1.319395f,0.8526419f,0.7178504f,-0.08725195f,-0.03752269f,-0.6896883f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448454f,1.364913f,0.7837852f,-0.709902f,0.01381019f,0.02840295f,0.7035921f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 7.692739f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 17.86423f);
Get(0xDD1E).SetLocalPose(1.42868f,1.319679f,0.8523712f,0.717136f,-0.08942466f,-0.03525423f,-0.6902727f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448335f,1.36498f,0.7837273f,-0.7099037f,0.0138187f,0.02841452f,0.7035897f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 7.748671f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 17.88241f);
Get(0xDD1E).SetLocalPose(1.429238f,1.320481f,0.8521655f,0.7164333f,-0.09130628f,-0.03256109f,-0.6908881f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448395f,1.365016f,0.783866f,-0.709922f,0.01381411f,0.0283823f,0.7035726f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 7.77465f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 17.89085f);
Get(0xDD1E).SetLocalPose(1.429418f,1.320619f,0.8521726f,0.7163163f,-0.09141305f,-0.03197933f,-0.6910225f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448447f,1.365038f,0.7840768f,-0.7099296f,0.01382228f,0.02839339f,0.7035643f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 7.833649f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 17.91003f);
Get(0xDD1E).SetLocalPose(1.429497f,1.321136f,0.8519946f,0.7160686f,-0.09087907f,-0.03193438f,-0.6913515f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448265f,1.36485f,0.7837928f,-0.7099248f,0.01380165f,0.02840284f,0.7035693f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 7.887969f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 17.92768f);
Get(0xDD1E).SetLocalPose(1.42952f,1.321537f,0.8518959f,0.7156655f,-0.09082254f,-0.03189376f,-0.6917782f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448333f,1.364926f,0.7837963f,-0.7099161f,0.01380003f,0.02839903f,0.7035782f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 7.942765f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 17.94549f);
Get(0xDD1E).SetLocalPose(1.429627f,1.322027f,0.8518517f,0.7150797f,-0.09166693f,-0.03150078f,-0.6922904f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448278f,1.365024f,0.7838849f,-0.7099088f,0.01383997f,0.02839355f,0.703585f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 7.997769f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 17.96336f);
Get(0xDD1E).SetLocalPose(1.430346f,1.322434f,0.8516693f,0.7144091f,-0.09384755f,-0.02947424f,-0.6927796f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448347f,1.364979f,0.7837856f,-0.7099039f,0.01382628f,0.02841073f,0.7035895f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 8.053874f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 17.9816f);
Get(0xDD1E).SetLocalPose(1.430697f,1.32288f,0.8515779f,0.7137926f,-0.09648517f,-0.02660275f,-0.6931688f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448206f,1.365012f,0.7837594f,-0.7099072f,0.01384113f,0.02840509f,0.7035862f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 8.080523f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 17.99026f);
Get(0xDD1E).SetLocalPose(1.431129f,1.323021f,0.8514341f,0.7133929f,-0.09837794f,-0.02423901f,-0.693401f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44797f,1.365041f,0.7836173f,-0.7098886f,0.01385312f,0.02838391f,0.7036055f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 8.145902f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 18.01151f);
Get(0xDD1E).SetLocalPose(1.431596f,1.322987f,0.8513677f,0.7127885f,-0.1008714f,-0.02089835f,-0.6937729f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448117f,1.365031f,0.7837296f,-0.7099237f,0.01379886f,0.02842092f,0.7035697f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 8.205366f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 18.03083f);
Get(0xDD1E).SetLocalPose(1.431732f,1.323644f,0.8512551f,0.7121306f,-0.1025899f,-0.01882894f,-0.6942556f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448381f,1.365083f,0.7838236f,-0.7099321f,0.01378204f,0.02841782f,0.7035615f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 8.261497f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 18.04908f);
Get(0xDD1E).SetLocalPose(1.432031f,1.324339f,0.8510753f,0.7113805f,-0.1045416f,-0.01698872f,-0.6947807f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448496f,1.364973f,0.7837139f,-0.7099174f,0.01378645f,0.02838858f,0.7035776f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 8.315549f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 18.06664f);
Get(0xDD1E).SetLocalPose(1.432503f,1.324801f,0.8508381f,0.7103502f,-0.1074272f,-0.01480368f,-0.6954445f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448713f,1.364879f,0.7838467f,-0.7099196f,0.01378024f,0.02838686f,0.7035755f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 8.340844f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 18.07486f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448647f,1.364715f,0.7838413f,-0.709952f,0.01379229f,0.02837531f,0.7035431f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 8.398972f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 18.09376f);
Get(0xDD1E).SetLocalPose(1.432935f,1.324886f,0.8507497f,0.709584f,-0.1104157f,-0.0118016f,-0.6958158f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448647f,1.364751f,0.7839701f,-0.7099396f,0.01378681f,0.02839282f,0.703555f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 8.454745f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 18.11188f);
Get(0xDD1E).SetLocalPose(1.433368f,1.325207f,0.8504018f,0.7086897f,-0.1147095f,-0.006240851f,-0.6961046f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448816f,1.36498f,0.7841928f,-0.7099475f,0.0137727f,0.02842943f,0.7035458f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 8.508668f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 18.12941f);
Get(0xDD1E).SetLocalPose(1.434085f,1.325599f,0.8502556f,0.7077729f,-0.1189309f,-0.0004343719f,-0.6963568f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448622f,1.36511f,0.7840536f,-0.7099453f,0.01376854f,0.02837989f,0.7035502f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 8.565096f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 18.14775f);
Get(0xDD1E).SetLocalPose(1.435137f,1.325768f,0.8502184f,0.7063849f,-0.1246563f,0.006843821f,-0.6967313f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448437f,1.365114f,0.7842013f,-0.7099585f,0.01378758f,0.0284022f,0.7035356f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 8.620158f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 18.16564f);
Get(0xDD1E).SetLocalPose(1.435935f,1.325507f,0.8507035f,0.7053121f,-0.1293525f,0.01276857f,-0.6968786f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448314f,1.36502f,0.7841657f,-0.7099525f,0.0138077f,0.0284004f,0.7035413f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 8.646267f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 18.17413f);
Get(0xDD1E).SetLocalPose(1.43607f,1.325504f,0.8506908f,0.7051175f,-0.130309f,0.01396973f,-0.6968743f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448402f,1.365018f,0.7842063f,-0.7099599f,0.01381288f,0.02839514f,0.7035338f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 8.705401f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 18.19334f);
Get(0xDD1E).SetLocalPose(1.43724f,1.324956f,0.8510613f,0.7036917f,-0.1369869f,0.02236143f,-0.6968161f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448222f,1.364877f,0.7840353f,-0.7099417f,0.01380597f,0.02840315f,0.7035521f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 8.761162f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 18.21147f);
Get(0xDD1E).SetLocalPose(1.438058f,1.325082f,0.8511813f,0.702361f,-0.1429504f,0.02998418f,-0.6966744f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448224f,1.364911f,0.783977f,-0.7099473f,0.01381314f,0.028402f,0.7035463f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 8.815794f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 18.22922f);
Get(0xDD1E).SetLocalPose(1.438571f,1.324836f,0.851227f,0.7016218f,-0.1461719f,0.03432679f,-0.6965503f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448145f,1.364944f,0.7841214f,-0.7099473f,0.01383683f,0.0283739f,0.7035469f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 8.870617f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 18.24704f);
Get(0xDD1E).SetLocalPose(1.440182f,1.323616f,0.8514929f,0.6991037f,-0.156779f,0.04904567f,-0.6958942f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448112f,1.365028f,0.7841178f,-0.7099525f,0.01382619f,0.02836994f,0.7035421f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 8.927031f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 18.26538f);
Get(0xDD1E).SetLocalPose(1.441925f,1.321735f,0.8517359f,0.6958311f,-0.167748f,0.06414326f,-0.6953887f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448231f,1.364959f,0.784145f,-0.7099723f,0.01381253f,0.02833886f,0.7035237f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 8.953446f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 18.27396f);
Get(0xDD1E).SetLocalPose(1.442683f,1.320627f,0.8517858f,0.694051f,-0.1731443f,0.07117196f,-0.6951611f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448213f,1.364768f,0.7840878f,-0.7099695f,0.01383525f,0.0283537f,0.7035254f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 9.012542f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 18.29317f);
Get(0xDD1E).SetLocalPose(1.445094f,1.318698f,0.8521874f,0.6884287f,-0.189141f,0.09196866f,-0.6941422f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448164f,1.364694f,0.7840325f,-0.7099531f,0.01382888f,0.02834096f,0.7035426f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 9.069689f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 18.31174f);
Get(0xDD1E).SetLocalPose(1.448224f,1.315261f,0.8530108f,0.6817856f,-0.2070168f,0.1171403f,-0.6918024f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448105f,1.364883f,0.783969f,-0.7099319f,0.01383516f,0.02833913f,0.703564f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 9.125782f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 18.32997f);
Get(0xDD1E).SetLocalPose(1.45016f,1.312821f,0.85353f,0.6770812f,-0.2188239f,0.1350607f,-0.6895186f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448057f,1.364713f,0.7838888f,-0.7099124f,0.0138756f,0.02834054f,0.7035828f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 9.1812f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 18.34798f);
Get(0xDD1E).SetLocalPose(1.454522f,1.306359f,0.8546786f,0.663798f,-0.247238f,0.1775245f,-0.6831769f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447978f,1.364821f,0.7839341f,-0.7099162f,0.01383316f,0.0283493f,0.7035795f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 9.234944f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 18.36545f);
Get(0xDD1E).SetLocalPose(1.457376f,1.301819f,0.8556679f,0.6534958f,-0.2659171f,0.2054099f,-0.6782612f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447912f,1.364909f,0.7839385f,-0.7099271f,0.01383051f,0.02834016f,0.7035689f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 9.26054f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 18.37377f);
Get(0xDD1E).SetLocalPose(1.459095f,1.299041f,0.8564299f,0.6466523f,-0.2773854f,0.2227535f,-0.6747437f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448137f,1.364816f,0.7839066f,-0.7099338f,0.01382431f,0.02835307f,0.7035618f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 9.319797f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 18.39302f);
Get(0xDD1E).SetLocalPose(1.461614f,1.293849f,0.8575105f,0.6348941f,-0.2963035f,0.2526652f,-0.6672887f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.4481f,1.364775f,0.7838663f,-0.7099342f,0.01379136f,0.02834296f,0.7035624f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 9.375367f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 18.41108f);
Get(0xDD1E).SetLocalPose(1.463734f,1.288285f,0.8584706f,0.6245565f,-0.31199f,0.2794962f,-0.659146f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448135f,1.364953f,0.7838857f,-0.7099161f,0.0138095f,0.028361f,0.7035795f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 9.429266f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 18.4286f);
Get(0xDD1E).SetLocalPose(1.464691f,1.284207f,0.8590104f,0.6173324f,-0.3227134f,0.2980895f,-0.6526098f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448316f,1.364945f,0.7838749f,-0.709929f,0.01376169f,0.0283525f,0.7035677f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 9.484279f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 18.44648f);
Get(0xDD1E).SetLocalPose(1.466194f,1.278545f,0.8597967f,0.6075239f,-0.3370665f,0.3227655f,-0.6427468f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448424f,1.364888f,0.7839364f,-0.7099343f,0.01376209f,0.02834165f,0.7035629f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 9.53931f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 18.46437f);
Get(0xDD1E).SetLocalPose(1.466824f,1.274113f,0.8600771f,0.6002538f,-0.3474973f,0.3395112f,-0.6353528f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448503f,1.364987f,0.7840353f,-0.7099125f,0.01377291f,0.02833054f,0.7035851f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 9.594361f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 18.48226f);
Get(0xDD1E).SetLocalPose(1.467221f,1.270235f,0.8603031f,0.5931766f,-0.3575173f,0.3546651f,-0.6281207f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448338f,1.3652f,0.7839692f,-0.7099119f,0.01377297f,0.0283652f,0.7035843f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 9.621028f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 18.49092f);
Get(0xDD1E).SetLocalPose(1.467478f,1.267957f,0.860167f,0.5873953f,-0.3651725f,0.3672157f,-0.6219072f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448334f,1.365179f,0.7840227f,-0.7099172f,0.01378134f,0.02835047f,0.7035794f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 9.679434f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 18.5099f);
Get(0xDD1E).SetLocalPose(1.468513f,1.265218f,0.8593881f,0.5798136f,-0.3740308f,0.3828212f,-0.6143005f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448418f,1.365245f,0.7842479f,-0.7099282f,0.0138287f,0.02835218f,0.7035674f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 9.734872f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 18.52792f);
Get(0xDD1E).SetLocalPose(1.468527f,1.260112f,0.8604873f,0.5680871f,-0.3866092f,0.4055917f,-0.6027485f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448199f,1.36517f,0.7841094f,-0.7099136f,0.01385625f,0.02834993f,0.7035816f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 9.790482f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 18.54599f);
Get(0xDD1E).SetLocalPose(1.468181f,1.255995f,0.8612557f,0.5582168f,-0.3968666f,0.4229802f,-0.5932778f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448254f,1.365088f,0.7840498f,-0.7099068f,0.01382222f,0.0283786f,0.703588f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 9.846457f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 18.56419f);
Get(0xDD1E).SetLocalPose(1.468068f,1.250857f,0.8622366f,0.5451546f,-0.4098727f,0.4447131f,-0.5805524f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448214f,1.364969f,0.783878f,-0.7099124f,0.01380644f,0.02836406f,0.7035833f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 9.900864f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 18.58187f);
Get(0xDD1E).SetLocalPose(1.467907f,1.246267f,0.8629989f,0.5336564f,-0.4197188f,0.4626566f,-0.5700842f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448366f,1.364797f,0.7839198f,-0.7099264f,0.01378154f,0.02839743f,0.7035683f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 9.95652f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 18.59996f);
Get(0xDD1E).SetLocalPose(1.467484f,1.240508f,0.8642687f,0.520078f,-0.4304393f,0.4835213f,-0.5571787f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448359f,1.364804f,0.7838425f,-0.7099329f,0.01377355f,0.02839575f,0.7035619f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 9.982928f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 18.60854f);
Get(0xDD1E).SetLocalPose(1.468133f,1.237627f,0.8647304f,0.5136325f,-0.43546f,0.4936485f,-0.5503339f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448321f,1.364782f,0.7838111f,-0.7099238f,0.01377865f,0.02837796f,0.7035716f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 10.04159f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 18.6276f);
Get(0xDD1E).SetLocalPose(1.468305f,1.235328f,0.865163f,0.5073472f,-0.4404687f,0.503186f,-0.5434979f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448427f,1.364967f,0.7839398f,-0.7099312f,0.01381547f,0.02838925f,0.7035631f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 10.09612f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 18.64533f);
Get(0xDD1E).SetLocalPose(1.468449f,1.232895f,0.8664415f,0.4998011f,-0.446608f,0.5139487f,-0.5353475f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448481f,1.364945f,0.7839043f,-0.7099387f,0.01381415f,0.02838636f,0.7035556f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 10.15128f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 18.66325f);
Get(0xDD1E).SetLocalPose(1.469209f,1.230214f,0.8669489f,0.4921756f,-0.4519874f,0.5234448f,-0.5286551f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448339f,1.365054f,0.7840106f,-0.7099342f,0.01377913f,0.0283795f,0.7035611f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 10.2066f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 18.68123f);
Get(0xDD1E).SetLocalPose(1.469726f,1.227938f,0.8678299f,0.4845684f,-0.4570522f,0.5327655f,-0.5219747f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448254f,1.365073f,0.784003f,-0.7099423f,0.01377363f,0.02838611f,0.7035528f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 10.26105f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 18.69893f);
Get(0xDD1E).SetLocalPose(1.470121f,1.22558f,0.8685139f,0.4775164f,-0.4620894f,0.5423381f,-0.5141215f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448309f,1.365236f,0.7840902f,-0.7099377f,0.01377731f,0.02836507f,0.7035583f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 10.28742f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 18.7075f);
Get(0xDD1E).SetLocalPose(1.470102f,1.224831f,0.8685768f,0.4746821f,-0.4640664f,0.5467197f,-0.5103105f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448311f,1.364974f,0.7840014f,-0.7099469f,0.01379515f,0.02837017f,0.7035484f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 10.34682f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 18.7268f);
Get(0xDD1E).SetLocalPose(1.470283f,1.223747f,0.8690323f,0.4712632f,-0.4664795f,0.552464f,-0.5050657f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44828f,1.3649f,0.7840622f,-0.7099617f,0.01378044f,0.02835003f,0.7035345f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 10.40142f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 18.74455f);
Get(0xDD1E).SetLocalPose(1.469977f,1.223883f,0.8695039f,0.4681099f,-0.4683055f,0.5562753f,-0.5021165f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448197f,1.365023f,0.7841351f,-0.7099587f,0.01381001f,0.02838216f,0.7035357f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 10.45603f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 18.7623f);
Get(0xDD1E).SetLocalPose(1.469479f,1.22395f,0.8691052f,0.4653881f,-0.4700162f,0.5587193f,-0.5003314f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448248f,1.364985f,0.7841817f,-0.7099621f,0.01378992f,0.02833344f,0.7035346f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 10.51126f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 18.78025f);
Get(0xDD1E).SetLocalPose(1.469584f,1.224362f,0.8689182f,0.4630052f,-0.4715105f,0.5611734f,-0.4983858f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448456f,1.364929f,0.7843392f,-0.7099651f,0.01376043f,0.0283905f,0.7035299f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 10.56955f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 18.79919f);
Get(0xDD1E).SetLocalPose(1.470045f,1.22376f,0.8686831f,0.4618298f,-0.4725197f,0.5627779f,-0.4967086f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448481f,1.364921f,0.7843775f,-0.7099603f,0.01375275f,0.02838096f,0.7035353f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 10.59482f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 18.8074f);
Get(0xDD1E).SetLocalPose(1.470603f,1.223403f,0.8688779f,0.4614915f,-0.4728957f,0.5635001f,-0.4958457f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44859f,1.364857f,0.784383f,-0.7099798f,0.01374316f,0.0284004f,0.7035149f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 10.65371f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 18.82655f);
Get(0xDD1E).SetLocalPose(1.471356f,1.223614f,0.8688782f,0.4610981f,-0.4731645f,0.5640631f,-0.4953149f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448824f,1.364818f,0.7845834f,-0.7099882f,0.013742f,0.0283881f,0.703507f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 10.70802f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 18.84419f);
Get(0xDD1E).SetLocalPose(1.472053f,1.223408f,0.8693039f,0.4608409f,-0.4734534f,0.5641086f,-0.4952262f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448806f,1.36486f,0.7845759f,-0.710011f,0.01373557f,0.02840324f,0.7034835f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 10.76498f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 18.86271f);
Get(0xDD1E).SetLocalPose(1.472847f,1.223271f,0.8695096f,0.4601004f,-0.4738907f,0.5640905f,-0.4955172f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448826f,1.364802f,0.7845169f,-0.7100049f,0.0137585f,0.0283935f,0.7034895f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 10.82003f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 18.8806f);
Get(0xDD1E).SetLocalPose(1.473621f,1.223113f,0.8693068f,0.4591526f,-0.474533f,0.5644091f,-0.4954188f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448792f,1.365035f,0.7846084f,-0.7100108f,0.01372635f,0.02838597f,0.7034845f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 10.87546f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 18.89861f);
Get(0xDD1E).SetLocalPose(1.473923f,1.223564f,0.8693083f,0.4587947f,-0.4751708f,0.5643736f,-0.4951795f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448862f,1.365114f,0.7847092f,-0.7100123f,0.01372917f,0.02836533f,0.7034838f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 10.93001f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 18.91634f);
Get(0xDD1E).SetLocalPose(1.473294f,1.224022f,0.8688964f,0.4594132f,-0.4761617f,0.5632009f,-0.4949893f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448754f,1.365222f,0.7845517f,-0.709982f,0.01373614f,0.02836612f,0.7035142f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 10.95608f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 18.92481f);
Get(0xDD1E).SetLocalPose(1.473428f,1.22457f,0.8693547f,0.4603629f,-0.4772152f,0.5617827f,-0.4947039f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448759f,1.365008f,0.7845426f,-0.7100027f,0.01373612f,0.02836573f,0.7034934f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 11.01512f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 18.944f);
Get(0xDD1E).SetLocalPose(1.473169f,1.2247f,0.8690606f,0.4607735f,-0.4797779f,0.5594555f,-0.4944801f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448663f,1.364963f,0.7844445f,-0.7099777f,0.01373917f,0.02837306f,0.7035183f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 11.07049f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 18.962f);
Get(0xDD1E).SetLocalPose(1.472544f,1.223824f,0.8690507f,0.4592156f,-0.4828046f,0.5570862f,-0.4956569f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448699f,1.365036f,0.7844716f,-0.7099726f,0.01373238f,0.02839533f,0.7035227f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 11.12551f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 18.97988f);
Get(0xDD1E).SetLocalPose(1.472428f,1.224144f,0.8690413f,0.4552934f,-0.4836546f,0.5554326f,-0.5002808f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448545f,1.364982f,0.7843802f,-0.7099704f,0.01378712f,0.02839817f,0.7035236f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 11.18045f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 18.99774f);
Get(0xDD1E).SetLocalPose(1.472205f,1.224257f,0.8693871f,0.4522164f,-0.4824962f,0.5531957f,-0.5066283f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448294f,1.365055f,0.7841377f,-0.7099495f,0.01378651f,0.02836716f,0.703546f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 11.2364f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 19.01592f);
Get(0xDD1E).SetLocalPose(1.4724f,1.225506f,0.870173f,0.4486533f,-0.4795107f,0.5469671f,-0.5192367f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448281f,1.365068f,0.7841349f,-0.7099446f,0.0137921f,0.02836505f,0.7035511f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 11.26217f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 19.02429f);
Get(0xDD1E).SetLocalPose(1.472618f,1.226677f,0.8697639f,0.4479258f,-0.4779509f,0.5433088f,-0.5251105f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448209f,1.365057f,0.7840589f,-0.7099179f,0.01379252f,0.02838974f,0.703577f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 19.04429f);
Get(0xDD1E).SetLocalPose(1.472424f,1.227548f,0.8694282f,0.4448692f,-0.4778665f,0.5336872f,-0.5375062f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448283f,1.364901f,0.7839128f,-0.7099292f,0.01380992f,0.02838389f,0.7035654f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.05372277f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 19.06175f);
Get(0xDD1E).SetLocalPose(1.472273f,1.228156f,0.8691523f,0.4420775f,-0.4804332f,0.5294956f,-0.541651f);
});
r.Add(delegate{
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.108548f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 19.07957f);
Get(0xDD1E).SetLocalPose(1.471695f,1.227424f,0.8679286f,0.4368667f,-0.4847217f,0.5302353f,-0.5413344f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448375f,1.364807f,0.7840417f,-0.7099372f,0.01377429f,0.02839256f,0.7035577f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.1622185f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 19.09701f);
Get(0xDD1E).SetLocalPose(1.471762f,1.22702f,0.8678265f,0.4327362f,-0.4901556f,0.5317655f,-0.5382494f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.4485f,1.364728f,0.7838473f,-0.7099415f,0.01377467f,0.02837213f,0.7035542f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.2183006f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 19.11524f);
Get(0xDD1E).SetLocalPose(1.470197f,1.226131f,0.8661329f,0.4307536f,-0.4985422f,0.5357156f,-0.5281247f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448537f,1.364714f,0.7838488f,-0.7099177f,0.01376824f,0.02836039f,0.7035788f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.2719403f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 19.13267f);
Get(0xDD1E).SetLocalPose(1.468802f,1.223963f,0.8652388f,0.4333871f,-0.505751f,0.5397835f,-0.5148061f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448559f,1.364735f,0.7838064f,-0.7099221f,0.01378254f,0.0283764f,0.7035734f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.2989274f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 19.14144f);
Get(0xDD1E).SetLocalPose(1.466826f,1.223367f,0.8639863f,0.4374529f,-0.511454f,0.5410282f,-0.5043196f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448833f,1.364771f,0.7840662f,-0.709951f,0.01374572f,0.02841607f,0.7035434f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.359352f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 19.16108f);
Get(0xDD1E).SetLocalPose(1.465749f,1.22175f,0.8633364f,0.4418195f,-0.5215608f,0.5429187f,-0.4878617f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448829f,1.364818f,0.7841761f,-0.7099605f,0.01375502f,0.02838597f,0.7035348f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.4143901f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 19.17896f);
Get(0xDD1E).SetLocalPose(1.464165f,1.220469f,0.8626789f,0.444591f,-0.5272416f,0.5442982f,-0.4775926f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44875f,1.364685f,0.7840542f,-0.7099578f,0.01375825f,0.02840049f,0.7035369f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.4700369f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 19.19705f);
Get(0xDD1E).SetLocalPose(1.462899f,1.220945f,0.862111f,0.4487342f,-0.5302609f,0.5424398f,-0.4724618f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448632f,1.364776f,0.7840216f,-0.70995f,0.01373417f,0.02840505f,0.7035451f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.5255523f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 19.21509f);
Get(0xDD1E).SetLocalPose(1.461809f,1.221078f,0.8617738f,0.4529109f,-0.5316237f,0.5405972f,-0.4690445f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448745f,1.364969f,0.7840864f,-0.7099386f,0.01376047f,0.02839325f,0.7035565f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.5815954f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 19.2333f);
Get(0xDD1E).SetLocalPose(1.461283f,1.22131f,0.8619019f,0.4555848f,-0.5329136f,0.5401599f,-0.4654815f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448621f,1.364956f,0.7839478f,-0.7099353f,0.01373492f,0.02840167f,0.70356f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.6074129f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 19.2417f);
Get(0xDD1E).SetLocalPose(1.46105f,1.220943f,0.862088f,0.4561177f,-0.5337507f,0.5403711f,-0.4637521f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448634f,1.364958f,0.7839336f,-0.7099415f,0.0137633f,0.0283947f,0.7035535f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.6662676f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 19.26082f);
Get(0xDD1E).SetLocalPose(1.460024f,1.220688f,0.8620822f,0.4560895f,-0.5347422f,0.5409732f,-0.4619319f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448619f,1.365135f,0.783951f,-0.7099288f,0.01374733f,0.02838147f,0.7035671f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.7228763f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 19.27922f);
Get(0xDD1E).SetLocalPose(1.459884f,1.220826f,0.8617591f,0.4571312f,-0.5353272f,0.5410175f,-0.4601695f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448624f,1.365019f,0.7838897f,-0.7099133f,0.01374005f,0.02838604f,0.7035827f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.7770697f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 19.29683f);
Get(0xDD1E).SetLocalPose(1.460179f,1.220374f,0.862175f,0.458355f,-0.5356788f,0.5407032f,-0.4589105f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448445f,1.365116f,0.7838551f,-0.70991f,0.01374867f,0.02836497f,0.7035868f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.8319423f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 19.31467f);
Get(0xDD1E).SetLocalPose(1.460069f,1.221392f,0.8625396f,0.4585551f,-0.5362921f,0.5404527f,-0.4582891f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448469f,1.365203f,0.7839658f,-0.7099109f,0.01376442f,0.02838099f,0.7035848f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.8872248f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 19.33263f);
Get(0xDD1E).SetLocalPose(1.459298f,1.22114f,0.8616362f,0.457774f,-0.5370473f,0.5404634f,-0.458173f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448411f,1.365073f,0.7837812f,-0.7098926f,0.01379254f,0.02836547f,0.7036034f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.9400113f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 19.34979f);
Get(0xDD1E).SetLocalPose(1.459834f,1.220717f,0.8618135f,0.456841f,-0.5373787f,0.5407695f,-0.4583544f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448358f,1.365138f,0.7836344f,-0.7098832f,0.01378027f,0.02834816f,0.7036138f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.9683282f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 19.35899f);
Get(0xDD1E).SetLocalPose(1.4604f,1.221187f,0.8624099f,0.4567537f,-0.5371318f,0.5407975f,-0.4586977f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448085f,1.365151f,0.7834656f,-0.7098883f,0.01381374f,0.0283451f,0.7036082f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.026452f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 19.37788f);
Get(0xDD1E).SetLocalPose(1.461325f,1.221593f,0.8624113f,0.4573527f,-0.5363801f,0.540428f,-0.4594155f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448216f,1.365058f,0.7835044f,-0.7098862f,0.01382039f,0.02831443f,0.7036114f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.08116f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 19.39566f);
Get(0xDD1E).SetLocalPose(1.462162f,1.222027f,0.8627488f,0.4577891f,-0.535816f,0.5401387f,-0.4599791f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448177f,1.364797f,0.7834877f,-0.70986f,0.01384681f,0.02834977f,0.7036358f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.137135f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 19.41385f);
Get(0xDD1E).SetLocalPose(1.462802f,1.2208f,0.8623817f,0.4566102f,-0.5360407f,0.5405532f,-0.4604018f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44812f,1.364859f,0.7834832f,-0.7098625f,0.01385252f,0.02834713f,0.7036332f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.193564f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 19.43219f);
Get(0xDD1E).SetLocalPose(1.462283f,1.220325f,0.8627095f,0.4550959f,-0.5364831f,0.541284f,-0.4605273f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448051f,1.364805f,0.7835584f,-0.7098623f,0.01385155f,0.02833485f,0.703634f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.22149f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 19.44127f);
Get(0xDD1E).SetLocalPose(1.461638f,1.220011f,0.8627713f,0.4544523f,-0.5364611f,0.5416368f,-0.4607736f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448015f,1.364867f,0.7834874f,-0.7098961f,0.01383255f,0.0283237f,0.7036007f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.282384f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 19.46106f);
Get(0xDD1E).SetLocalPose(1.460771f,1.220836f,0.8631231f,0.4543929f,-0.5360088f,0.5418744f,-0.461079f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447917f,1.364759f,0.7835035f,-0.7098853f,0.01385337f,0.02832861f,0.703611f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.338652f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 19.47935f);
Get(0xDD1E).SetLocalPose(1.460444f,1.220978f,0.8629983f,0.4551001f,-0.535615f,0.541824f,-0.4608983f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447917f,1.364732f,0.7836246f,-0.7098726f,0.01387273f,0.02834293f,0.7036229f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.394206f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 19.4974f);
Get(0xDD1E).SetLocalPose(1.460196f,1.221042f,0.8629466f,0.4558169f,-0.5353943f,0.541674f,-0.4606228f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447898f,1.364718f,0.7836808f,-0.7098989f,0.01387653f,0.02832592f,0.703597f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.449982f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 19.51553f);
Get(0xDD1E).SetLocalPose(1.460086f,1.220584f,0.8635663f,0.4549477f,-0.5357892f,0.5417976f,-0.4608773f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44809f,1.364824f,0.7837383f,-0.7099033f,0.01386616f,0.02832492f,0.7035928f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.476839f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 19.52426f);
Get(0xDD1E).SetLocalPose(1.459969f,1.220361f,0.8637621f,0.4540889f,-0.5361345f,0.5418777f,-0.4612285f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447915f,1.364929f,0.7836291f,-0.7098956f,0.01384843f,0.02836606f,0.7035992f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.535469f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 19.54331f);
Get(0xDD1E).SetLocalPose(1.459825f,1.221075f,0.8637561f,0.4531361f,-0.5363812f,0.541954f,-0.4617886f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447915f,1.36481f,0.783524f,-0.7098927f,0.01381193f,0.02838713f,0.703602f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.589162f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 19.56076f);
Get(0xDD1E).SetLocalPose(1.459234f,1.220824f,0.8627753f,0.4532856f,-0.5360849f,0.5418063f,-0.4621591f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447986f,1.364806f,0.7834886f,-0.7098792f,0.01384946f,0.02836937f,0.7036157f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.646286f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 19.57933f);
Get(0xDD1E).SetLocalPose(1.45919f,1.220175f,0.8623561f,0.4541204f,-0.5357766f,0.5419058f,-0.4615802f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447963f,1.364784f,0.783505f,-0.7098525f,0.01386447f,0.02839042f,0.7036415f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.702368f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 19.59755f);
Get(0xDD1E).SetLocalPose(1.459305f,1.219685f,0.8623599f,0.4547291f,-0.5357524f,0.5421079f,-0.4607711f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448198f,1.364859f,0.7835498f,-0.7098682f,0.01383442f,0.02839975f,0.7036259f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.759044f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 19.61597f);
Get(0xDD1E).SetLocalPose(1.458227f,1.220014f,0.8614389f,0.4536257f,-0.5365737f,0.5426621f,-0.4602501f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448283f,1.364973f,0.7835531f,-0.7098934f,0.01380453f,0.02841657f,0.7036003f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.786622f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 19.62494f);
Get(0xDD1E).SetLocalPose(1.458773f,1.219898f,0.8615117f,0.4532796f,-0.5368297f,0.5425225f,-0.4604573f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448478f,1.364846f,0.7836165f,-0.7099084f,0.01377356f,0.02840215f,0.7035863f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.847025f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 19.64457f);
Get(0xDD1E).SetLocalPose(1.458995f,1.220703f,0.8619448f,0.4538457f,-0.5367079f,0.5419571f,-0.4607072f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44857f,1.364864f,0.7836536f,-0.7099048f,0.01377508f,0.02841304f,0.7035895f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.901403f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 19.66224f);
Get(0xDD1E).SetLocalPose(1.459048f,1.22177f,0.86216f,0.4543657f,-0.5365226f,0.5415831f,-0.4608504f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448603f,1.365028f,0.783811f,-0.7099159f,0.01379304f,0.02838469f,0.7035791f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.957524f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 19.68048f);
Get(0xDD1E).SetLocalPose(1.458727f,1.221508f,0.8618874f,0.4547162f,-0.5366554f,0.5414971f,-0.4604511f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448555f,1.365049f,0.7839193f,-0.7099239f,0.01379836f,0.02837233f,0.7035715f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.014609f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 19.69903f);
Get(0xDD1E).SetLocalPose(1.458278f,1.221483f,0.8615234f,0.4548709f,-0.5369779f,0.5416682f,-0.4597203f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448584f,1.365075f,0.7839212f,-0.7099257f,0.0138128f,0.02838088f,0.703569f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.040626f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 19.70749f);
Get(0xDD1E).SetLocalPose(1.458015f,1.221338f,0.8615675f,0.4546669f,-0.5372581f,0.5418403f,-0.4593918f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448381f,1.364995f,0.7839711f,-0.7099232f,0.0137932f,0.02836457f,0.7035726f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.098592f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 19.72632f);
Get(0xDD1E).SetLocalPose(1.458328f,1.220486f,0.8617507f,0.4544031f,-0.5373229f,0.5419818f,-0.4594101f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448275f,1.365039f,0.7839904f,-0.7099137f,0.01383971f,0.02837233f,0.7035809f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.153701f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 19.74423f);
Get(0xDD1E).SetLocalPose(1.458158f,1.220701f,0.8618746f,0.4540111f,-0.5372233f,0.5419289f,-0.4599764f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44817f,1.364923f,0.7839096f,-0.7099106f,0.01387434f,0.02834701f,0.7035844f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.207694f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 19.76178f);
Get(0xDD1E).SetLocalPose(1.459182f,1.220722f,0.8622928f,0.4537919f,-0.5368488f,0.5415605f,-0.4610625f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448149f,1.36472f,0.7838679f,-0.7099071f,0.01384807f,0.02836314f,0.7035878f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.265068f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 19.78043f);
Get(0xDD1E).SetLocalPose(1.459385f,1.22084f,0.8620712f,0.4537871f,-0.5366942f,0.5407279f,-0.4622228f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448159f,1.364855f,0.7839105f,-0.7099333f,0.01382373f,0.02835867f,0.703562f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.321528f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 19.79878f);
Get(0xDD1E).SetLocalPose(1.460683f,1.220516f,0.861702f,0.4538328f,-0.5371289f,0.5401018f,-0.4624049f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447992f,1.364956f,0.7838406f,-0.709925f,0.01384301f,0.02837445f,0.7035694f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.349f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 19.8077f);
Get(0xDD1E).SetLocalPose(1.460957f,1.221203f,0.862071f,0.4535735f,-0.5376475f,0.5401407f,-0.4620112f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448068f,1.36499f,0.7839742f,-0.7099368f,0.01382247f,0.02834782f,0.7035589f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.405951f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 19.82621f);
Get(0xDD1E).SetLocalPose(1.460942f,1.221759f,0.8623924f,0.4531632f,-0.5384574f,0.5403287f,-0.4612502f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448198f,1.364929f,0.7839557f,-0.7099469f,0.01380881f,0.02834274f,0.7035491f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.461345f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 19.84422f);
Get(0xDD1E).SetLocalPose(1.461273f,1.22128f,0.8625461f,0.4535018f,-0.5388531f,0.5400782f,-0.4607484f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448291f,1.364954f,0.7840243f,-0.7099444f,0.01376081f,0.02837031f,0.7035516f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.51619f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 19.86204f);
Get(0xDD1E).SetLocalPose(1.459874f,1.222714f,0.8621326f,0.4540895f,-0.5391966f,0.5398009f,-0.4600923f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448435f,1.364989f,0.7840536f,-0.7099301f,0.01380157f,0.02836929f,0.7035652f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.574083f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 19.88086f);
Get(0xDD1E).SetLocalPose(1.458503f,1.223685f,0.8617007f,0.4542084f,-0.5394164f,0.5396755f,-0.4598642f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448409f,1.364922f,0.7839555f,-0.7099406f,0.01378316f,0.02837504f,0.7035547f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.629207f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 19.89877f);
Get(0xDD1E).SetLocalPose(1.458522f,1.223606f,0.8611035f,0.4535096f,-0.5397062f,0.5398994f,-0.459951f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448459f,1.364994f,0.7839603f,-0.7099348f,0.01377861f,0.02839054f,0.70356f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.656118f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 19.90752f);
Get(0xDD1E).SetLocalPose(1.45832f,1.22405f,0.8611687f,0.4529609f,-0.5400571f,0.5400249f,-0.4599325f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448557f,1.364837f,0.7840137f,-0.7099497f,0.01379021f,0.02842024f,0.7035437f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.714341f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 19.92644f);
Get(0xDD1E).SetLocalPose(1.457199f,1.222853f,0.8615239f,0.4528697f,-0.5402643f,0.5399581f,-0.4598575f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448613f,1.36482f,0.7840402f,-0.709946f,0.01377315f,0.02841751f,0.7035477f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.769677f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 19.94442f);
Get(0xDD1E).SetLocalPose(1.457276f,1.222911f,0.8617607f,0.4533511f,-0.5404193f,0.5395746f,-0.4596511f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448611f,1.365011f,0.7840881f,-0.7099484f,0.01375682f,0.02841694f,0.7035457f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.82526f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 19.96249f);
Get(0xDD1E).SetLocalPose(1.457593f,1.222278f,0.8620598f,0.4540623f,-0.5405295f,0.5393049f,-0.4591357f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448433f,1.365086f,0.783851f,-0.7099082f,0.01380281f,0.02839882f,0.7035861f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.880706f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 19.98051f);
Get(0xDD1E).SetLocalPose(1.457594f,1.222929f,0.8621176f,0.454106f,-0.5405564f,0.5393454f,-0.4590132f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448529f,1.364869f,0.7838735f,-0.7099267f,0.01380591f,0.02838604f,0.7035679f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.936865f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 19.99876f);
Get(0xDD1E).SetLocalPose(1.456399f,1.224001f,0.8613839f,0.4533395f,-0.5407244f,0.5395874f,-0.4592884f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448537f,1.364857f,0.7838494f,-0.70993f,0.01379137f,0.02839007f,0.7035647f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.96397f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 20.00757f);
Get(0xDD1E).SetLocalPose(1.456677f,1.222787f,0.8614816f,0.4530202f,-0.5407991f,0.5396007f,-0.4594999f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448435f,1.364894f,0.7839236f,-0.7099419f,0.01379012f,0.02840382f,0.7035522f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.022965f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 20.02674f);
Get(0xDD1E).SetLocalPose(1.457035f,1.222535f,0.8613542f,0.452678f,-0.5410369f,0.5396939f,-0.4594478f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448308f,1.364885f,0.7838292f,-0.7099246f,0.01383192f,0.02838825f,0.7035694f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.078091f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 20.04466f);
Get(0xDD1E).SetLocalPose(1.457577f,1.22259f,0.8612829f,0.452955f,-0.5410609f,0.5395979f,-0.4592591f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448384f,1.364801f,0.7839006f,-0.7099429f,0.01381247f,0.02839846f,0.7035509f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.133459f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 20.06265f);
Get(0xDD1E).SetLocalPose(1.457858f,1.221804f,0.8617446f,0.4538736f,-0.54075f,0.5392764f,-0.4590961f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448308f,1.364856f,0.7838824f,-0.7099417f,0.01378958f,0.0283899f,0.7035529f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.188411f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 20.08051f);
Get(0xDD1E).SetLocalPose(1.458798f,1.222466f,0.8620117f,0.4545237f,-0.5405415f,0.5389588f,-0.4590715f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44833f,1.364907f,0.7838275f,-0.7099525f,0.01378842f,0.02838509f,0.7035422f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.244188f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 20.09864f);
Get(0xDD1E).SetLocalPose(1.458667f,1.223092f,0.8622841f,0.4543272f,-0.5406325f,0.5389349f,-0.4591867f);
});
r.Add(delegate{
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.244188f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 20.09864f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448449f,1.364967f,0.7840421f,-0.70992f,0.01379277f,0.02836356f,0.7035758f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.345377f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 20.13153f);
Get(0xDD1E).SetLocalPose(1.458416f,1.222215f,0.8628297f,0.4539309f,-0.5407143f,0.5390236f,-0.4593781f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448461f,1.364979f,0.784066f,-0.7099193f,0.01379285f,0.02836849f,0.7035763f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.372303f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 20.14028f);
Get(0xDD1E).SetLocalPose(1.458392f,1.221908f,0.8629194f,0.4538716f,-0.5407241f,0.5390631f,-0.459379f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448521f,1.364941f,0.7841285f,-0.709935f,0.01378456f,0.02838758f,0.7035599f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.435979f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 20.16097f);
Get(0xDD1E).SetLocalPose(1.458991f,1.22239f,0.8628254f,0.4538966f,-0.5406684f,0.5390733f,-0.4594079f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.4486f,1.365147f,0.7842797f,-0.7099422f,0.01378626f,0.02838535f,0.7035527f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.499131f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 20.1815f);
Get(0xDD1E).SetLocalPose(1.459401f,1.221794f,0.862995f,0.4547451f,-0.5402285f,0.5385607f,-0.4596873f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448399f,1.365003f,0.7841085f,-0.709926f,0.01381588f,0.0283804f,0.7035687f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.528379f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 20.191f);
Get(0xDD1E).SetLocalPose(1.458821f,1.221862f,0.863273f,0.4548687f,-0.5401853f,0.5384072f,-0.4597957f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448226f,1.364923f,0.7840526f,-0.7099198f,0.01383737f,0.02836416f,0.7035752f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.594108f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 20.21236f);
Get(0xDD1E).SetLocalPose(1.457788f,1.22378f,0.8629013f,0.4546577f,-0.5403486f,0.5385079f,-0.4596945f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448219f,1.365106f,0.7839805f,-0.7099029f,0.01386715f,0.02840222f,0.7035902f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.654476f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 20.23198f);
Get(0xDD1E).SetLocalPose(1.457707f,1.223449f,0.8631545f,0.4544857f,-0.5405462f,0.5388924f,-0.4591812f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448094f,1.364955f,0.7837945f,-0.7099141f,0.01385306f,0.02839816f,0.7035792f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.684338f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 20.24169f);
Get(0xDD1E).SetLocalPose(1.457997f,1.224295f,0.8631729f,0.4544531f,-0.540594f,0.5391448f,-0.4588611f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448232f,1.364827f,0.7838359f,-0.7099416f,0.01380445f,0.02840494f,0.7035521f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.743849f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 20.26103f);
Get(0xDD1E).SetLocalPose(1.457829f,1.22467f,0.8632186f,0.4547353f,-0.5404281f,0.5391917f,-0.4587217f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448294f,1.364954f,0.783812f,-0.7099117f,0.01379224f,0.02839823f,0.7035828f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.801347f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 20.27972f);
Get(0xDD1E).SetLocalPose(1.456847f,1.225156f,0.8624213f,0.4548579f,-0.5403566f,0.5390153f,-0.4588917f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448429f,1.365006f,0.7838331f,-0.7099229f,0.01381251f,0.02839397f,0.7035713f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.858461f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 20.29828f);
Get(0xDD1E).SetLocalPose(1.456835f,1.225498f,0.8621794f,0.4547117f,-0.5404839f,0.538797f,-0.4591429f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448577f,1.364901f,0.7838414f,-0.7099158f,0.01376699f,0.02841935f,0.7035784f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.888806f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 20.30814f);
Get(0xDD1E).SetLocalPose(1.456592f,1.224766f,0.8622941f,0.4546452f,-0.5404857f,0.5387698f,-0.4592385f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448625f,1.364851f,0.7839116f,-0.7099208f,0.01377659f,0.02842182f,0.703573f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.949832f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 20.32798f);
Get(0xDD1E).SetLocalPose(1.455917f,1.225033f,0.8627453f,0.4545738f,-0.540406f,0.5387551f,-0.4594202f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448527f,1.36495f,0.7838702f,-0.7099394f,0.01379065f,0.02843389f,0.7035535f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.007455f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 20.3467f);
Get(0xDD1E).SetLocalPose(1.45526f,1.225243f,0.862549f,0.4545842f,-0.540393f,0.5387185f,-0.4594683f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448548f,1.365055f,0.7839462f,-0.7099413f,0.01379512f,0.02839439f,0.703553f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.063329f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 20.36486f);
Get(0xDD1E).SetLocalPose(1.455354f,1.225115f,0.8628228f,0.4546254f,-0.5405021f,0.5385734f,-0.4594692f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448538f,1.365117f,0.7840198f,-0.7099515f,0.01376723f,0.02841132f,0.7035426f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.090528f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 20.3737f);
Get(0xDD1E).SetLocalPose(1.455562f,1.22488f,0.8631058f,0.4546257f,-0.54056f,0.5384486f,-0.4595471f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448577f,1.365127f,0.7839561f,-0.7099333f,0.01379253f,0.0284012f,0.7035609f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.15134f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 20.39347f);
Get(0xDD1E).SetLocalPose(1.455836f,1.223905f,0.863109f,0.4544722f,-0.5407264f,0.5382448f,-0.459742f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448233f,1.36515f,0.7839005f,-0.7099191f,0.01383146f,0.02838963f,0.7035749f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.207507f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 20.41172f);
Get(0xDD1E).SetLocalPose(1.455758f,1.223519f,0.8633901f,0.4540186f,-0.5409744f,0.5382984f,-0.4598355f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448378f,1.364989f,0.7839042f,-0.709919f,0.01384065f,0.02839027f,0.7035748f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.263947f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 20.43007f);
Get(0xDD1E).SetLocalPose(1.45518f,1.223817f,0.8636045f,0.4536036f,-0.5411224f,0.5383749f,-0.4599815f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448381f,1.364943f,0.7838135f,-0.7099275f,0.01383433f,0.02840616f,0.7035657f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.320701f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 20.44851f);
Get(0xDD1E).SetLocalPose(1.455048f,1.223639f,0.863634f,0.4537013f,-0.5411415f,0.5382109f,-0.4600546f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448533f,1.364834f,0.7838624f,-0.7099409f,0.01383547f,0.02838721f,0.703553f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.347776f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 20.45731f);
Get(0xDD1E).SetLocalPose(1.455357f,1.224464f,0.8637803f,0.4538484f,-0.541159f,0.538081f,-0.4600407f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448548f,1.364725f,0.7838312f,-0.7099559f,0.01379355f,0.02839854f,0.7035382f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.408513f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 20.47705f);
Get(0xDD1E).SetLocalPose(1.455528f,1.224377f,0.8629153f,0.454028f,-0.541174f,0.5380039f,-0.459936f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448417f,1.364865f,0.7838741f,-0.7099478f,0.01382994f,0.02837406f,0.7035466f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.448376f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 20.49f);
Get(0xDD1E).SetLocalPose(1.454813f,1.225f,0.8631954f,0.4542025f,-0.5413231f,0.5380301f,-0.4595575f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448334f,1.364941f,0.7837947f,-0.7099392f,0.01377582f,0.02839127f,0.7035556f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.503442f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 20.5079f);
Get(0xDD1E).SetLocalPose(1.454775f,1.225121f,0.8634272f,0.4541714f,-0.541558f,0.5379922f,-0.4593558f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44829f,1.365054f,0.7838458f,-0.7099307f,0.01375617f,0.02841313f,0.7035637f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.548432f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 20.52252f);
Get(0xDD1E).SetLocalPose(1.454527f,1.225438f,0.8634978f,0.4537385f,-0.5418851f,0.5381002f,-0.4592712f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448658f,1.36514f,0.7842431f,-0.7099412f,0.01374822f,0.02840832f,0.7035536f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.632444f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 20.54983f);
Get(0xDD1E).SetLocalPose(1.454629f,1.22582f,0.8637885f,0.4536818f,-0.5418525f,0.5383022f,-0.4591291f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448473f,1.365117f,0.7841357f,-0.7099321f,0.01378614f,0.0283573f,0.7035639f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.68231f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 20.56603f);
Get(0xDD1E).SetLocalPose(1.452993f,1.226014f,0.8635224f,0.453771f,-0.5419259f,0.5382919f,-0.4589663f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448443f,1.365171f,0.7841752f,-0.7099395f,0.01379895f,0.02835935f,0.7035562f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.734684f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 20.58306f);
Get(0xDD1E).SetLocalPose(1.452456f,1.226088f,0.8633198f,0.4539283f,-0.5420666f,0.5381062f,-0.4588622f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448558f,1.365156f,0.7841992f,-0.7099563f,0.01379794f,0.02839608f,0.7035378f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.776818f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 20.59675f);
Get(0xDD1E).SetLocalPose(1.452221f,1.226573f,0.8635162f,0.4541833f,-0.5421752f,0.5379688f,-0.4586427f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448572f,1.364874f,0.7841982f,-0.7099391f,0.01378303f,0.02841017f,0.7035549f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.81377f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 20.60876f);
Get(0xDD1E).SetLocalPose(1.452144f,1.226037f,0.8635203f,0.4543286f,-0.5424914f,0.5378241f,-0.4582945f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448606f,1.364878f,0.7842039f,-0.7099565f,0.01375893f,0.02842024f,0.7035374f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.864866f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 20.62536f);
Get(0xDD1E).SetLocalPose(1.452072f,1.226254f,0.8633345f,0.4542887f,-0.5429165f,0.5378489f,-0.4578014f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448609f,1.364847f,0.784122f,-0.7099443f,0.01377793f,0.02839227f,0.7035505f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.915317f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 20.64176f);
Get(0xDD1E).SetLocalPose(1.451854f,1.226432f,0.8632283f,0.4542538f,-0.5431327f,0.537784f,-0.4576556f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44854f,1.365089f,0.7841985f,-0.7099577f,0.01377852f,0.02840191f,0.7035365f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.965686f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 20.65813f);
Get(0xDD1E).SetLocalPose(1.451896f,1.22572f,0.8636159f,0.4546532f,-0.5429586f,0.5374313f,-0.4578801f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448544f,1.36507f,0.7841913f,-0.7099469f,0.01375306f,0.02840152f,0.703548f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.015784f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 20.67441f);
Get(0xDD1E).SetLocalPose(1.452062f,1.226653f,0.8633615f,0.4549178f,-0.5427178f,0.5372885f,-0.4580702f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448571f,1.365129f,0.7841439f,-0.709942f,0.01378604f,0.02838564f,0.7035528f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.060002f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 20.68878f);
Get(0xDD1E).SetLocalPose(1.45202f,1.22623f,0.8636785f,0.4549907f,-0.5426974f,0.5372655f,-0.4580489f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448527f,1.365085f,0.7841473f,-0.70995f,0.01375612f,0.02837347f,0.7035459f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.139364f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 20.71457f);
Get(0xDD1E).SetLocalPose(1.452442f,1.225856f,0.8638608f,0.4549692f,-0.5429533f,0.53708f,-0.4579845f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448589f,1.364915f,0.7840929f,-0.7099389f,0.01377748f,0.02839824f,0.7035557f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.173132f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 20.72555f);
Get(0xDD1E).SetLocalPose(1.452334f,1.226223f,0.8638995f,0.4550779f,-0.5431247f,0.5368127f,-0.4579868f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448585f,1.36498f,0.7839343f,-0.7099315f,0.01380387f,0.02837574f,0.7035635f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.23455f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 20.74551f);
Get(0xDD1E).SetLocalPose(1.451862f,1.227892f,0.8640299f,0.4552186f,-0.5432086f,0.536602f,-0.4579943f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44839f,1.365f,0.7838184f,-0.7099366f,0.013859f,0.02835323f,0.7035582f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.290797f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 20.76379f);
Get(0xDD1E).SetLocalPose(1.451519f,1.227788f,0.8640531f,0.4555788f,-0.5430201f,0.5362667f,-0.4582523f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448294f,1.365098f,0.7838737f,-0.7099261f,0.01382061f,0.02836527f,0.703569f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.349174f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 20.78276f);
Get(0xDD1E).SetLocalPose(1.451661f,1.228649f,0.8643833f,0.4558001f,-0.5428769f,0.5360129f,-0.4584988f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448267f,1.365116f,0.7839004f,-0.7099184f,0.01384182f,0.02839201f,0.7035754f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.375468f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 20.79131f);
Get(0xDD1E).SetLocalPose(1.451542f,1.228807f,0.8643793f,0.4557119f,-0.5429922f,0.5360081f,-0.4584555f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44823f,1.365069f,0.7838718f,-0.7099286f,0.01381909f,0.02841189f,0.7035646f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.435087f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 20.81068f);
Get(0xDD1E).SetLocalPose(1.450952f,1.2281f,0.864499f,0.4558255f,-0.5432332f,0.5357565f,-0.4583512f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448246f,1.365047f,0.7839735f,-0.7099353f,0.01383299f,0.028399f,0.7035581f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.492253f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 20.82926f);
Get(0xDD1E).SetLocalPose(1.451219f,1.227328f,0.8652755f,0.456298f,-0.5434662f,0.535332f,-0.4581007f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448378f,1.364922f,0.7837238f,-0.7099208f,0.0138294f,0.02838817f,0.7035733f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.549733f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 20.84795f);
Get(0xDD1E).SetLocalPose(1.451324f,1.226873f,0.8656222f,0.4568116f,-0.5435576f,0.535024f,-0.4578401f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448321f,1.364882f,0.7836418f,-0.7099202f,0.01383385f,0.02840294f,0.7035733f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.579494f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 20.85762f);
Get(0xDD1E).SetLocalPose(1.450911f,1.225414f,0.8661506f,0.4571564f,-0.5434502f,0.5349086f,-0.4577584f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448184f,1.364753f,0.7836145f,-0.7099194f,0.01385085f,0.0284048f,0.7035736f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.638957f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 20.87694f);
Get(0xDD1E).SetLocalPose(1.4506f,1.225899f,0.8662508f,0.45712f,-0.5434324f,0.534925f,-0.4577967f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448157f,1.364767f,0.7835193f,-0.709914f,0.0138133f,0.02839238f,0.7035804f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.694951f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 20.89514f);
Get(0xDD1E).SetLocalPose(1.450941f,1.226854f,0.8661777f,0.4568976f,-0.5434786f,0.5351224f,-0.4577331f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448219f,1.364681f,0.7835886f,-0.7099098f,0.01381768f,0.02840232f,0.7035841f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.752105f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 20.91372f);
Get(0xDD1E).SetLocalPose(1.450686f,1.227094f,0.8662277f,0.4567945f,-0.5435719f,0.5351566f,-0.4576854f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448192f,1.364734f,0.7834847f,-0.7099134f,0.01379673f,0.0283969f,0.7035811f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.809027f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 20.93222f);
Get(0xDD1E).SetLocalPose(1.450727f,1.226174f,0.8662421f,0.4568629f,-0.5437407f,0.5349001f,-0.4577164f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448435f,1.364999f,0.7837742f,-0.7099149f,0.01378279f,0.02839501f,0.70358f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.835176f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 20.94072f);
Get(0xDD1E).SetLocalPose(1.451095f,1.225901f,0.8663036f,0.4570104f,-0.5437903f,0.5347118f,-0.4577303f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44861f,1.364999f,0.7839688f,-0.7099338f,0.0137865f,0.02841102f,0.7035601f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.896013f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 20.96049f);
Get(0xDD1E).SetLocalPose(1.451093f,1.225542f,0.8663912f,0.4572321f,-0.5437886f,0.5345033f,-0.4577542f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448737f,1.365114f,0.7841015f,-0.7099201f,0.01375658f,0.02845012f,0.7035729f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.95269f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 20.97891f);
Get(0xDD1E).SetLocalPose(1.451764f,1.225911f,0.8668383f,0.4573705f,-0.5437614f,0.5344625f,-0.457696f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448719f,1.36514f,0.7841184f,-0.7099431f,0.0137834f,0.02841558f,0.7035506f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.010499f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 20.99769f);
Get(0xDD1E).SetLocalPose(1.451821f,1.225732f,0.8668457f,0.4574768f,-0.5437394f,0.5345045f,-0.4575668f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448611f,1.365131f,0.7840794f,-0.7099288f,0.01379232f,0.02841158f,0.7035651f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.068062f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 21.0164f);
Get(0xDD1E).SetLocalPose(1.452012f,1.226106f,0.8671899f,0.4575933f,-0.5437606f,0.5344052f,-0.4575412f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44857f,1.365139f,0.7841648f,-0.7099168f,0.01379047f,0.02842264f,0.7035767f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.095173f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 21.02521f);
Get(0xDD1E).SetLocalPose(1.452444f,1.226017f,0.8668312f,0.4576665f,-0.5437107f,0.5344248f,-0.4575044f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448412f,1.364964f,0.7839022f,-0.7099097f,0.01383444f,0.02839998f,0.703584f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.155868f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 21.04494f);
Get(0xDD1E).SetLocalPose(1.452754f,1.226513f,0.8666143f,0.4576989f,-0.5435901f,0.5346404f,-0.4573633f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448371f,1.364917f,0.7838378f,-0.709909f,0.01381463f,0.02839033f,0.7035854f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.212714f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 21.06341f);
Get(0xDD1E).SetLocalPose(1.453446f,1.226293f,0.8665336f,0.4575718f,-0.5434989f,0.5349433f,-0.4572446f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448351f,1.364734f,0.7838821f,-0.7099245f,0.01380484f,0.02838672f,0.7035702f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.268659f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 21.08159f);
Get(0xDD1E).SetLocalPose(1.452638f,1.227843f,0.8665035f,0.4573626f,-0.5435045f,0.5351045f,-0.4572587f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448357f,1.364706f,0.7838635f,-0.7099146f,0.01383178f,0.02839101f,0.7035794f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.294488f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 21.08999f);
Get(0xDD1E).SetLocalPose(1.452758f,1.228052f,0.8664841f,0.4574414f,-0.5434109f,0.5350707f,-0.4573307f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44818f,1.364656f,0.783721f,-0.7099108f,0.01385358f,0.02837078f,0.7035837f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.358322f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 21.11073f);
Get(0xDD1E).SetLocalPose(1.452896f,1.228754f,0.8660929f,0.4575086f,-0.5432495f,0.5350857f,-0.4574378f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448256f,1.364596f,0.7837609f,-0.7099312f,0.01382079f,0.02837197f,0.7035636f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.415834f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 21.12943f);
Get(0xDD1E).SetLocalPose(1.452777f,1.228192f,0.8658748f,0.4572663f,-0.5434312f,0.5352049f,-0.4573246f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448287f,1.364554f,0.7836576f,-0.7099321f,0.01381275f,0.02836381f,0.7035633f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.472628f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 21.14788f);
Get(0xDD1E).SetLocalPose(1.453089f,1.228999f,0.8653983f,0.4569705f,-0.5436994f,0.535421f,-0.4570484f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448296f,1.364746f,0.7836833f,-0.7099252f,0.01381965f,0.02840522f,0.7035684f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.528687f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 21.1661f);
Get(0xDD1E).SetLocalPose(1.453126f,1.227242f,0.8648988f,0.4569262f,-0.5437693f,0.5355396f,-0.4568708f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448187f,1.364759f,0.7836633f,-0.709936f,0.01382644f,0.02839227f,0.7035578f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.554901f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 21.17462f);
Get(0xDD1E).SetLocalPose(1.452912f,1.227263f,0.8647597f,0.4569894f,-0.543685f,0.5356601f,-0.4567665f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448272f,1.364777f,0.783795f,-0.7099337f,0.01383975f,0.02838363f,0.7035603f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.618977f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 21.19545f);
Get(0xDD1E).SetLocalPose(1.453033f,1.227749f,0.8646456f,0.4570355f,-0.5434697f,0.5359125f,-0.4566804f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448425f,1.364862f,0.7840787f,-0.7099327f,0.01384791f,0.0283725f,0.7035616f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.675901f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 21.21395f);
Get(0xDD1E).SetLocalPose(1.452503f,1.227938f,0.863769f,0.456504f,-0.5434719f,0.5363326f,-0.4567163f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448539f,1.365048f,0.7839669f,-0.7099312f,0.01382635f,0.02839112f,0.7035627f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.732112f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 21.23222f);
Get(0xDD1E).SetLocalPose(1.452278f,1.227702f,0.8633463f,0.4561693f,-0.5435085f,0.5366232f,-0.4566658f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448546f,1.364986f,0.783977f,-0.7099264f,0.01382374f,0.02837947f,0.7035682f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.759115f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 21.24099f);
Get(0xDD1E).SetLocalPose(1.452445f,1.227229f,0.8637289f,0.4563335f,-0.5433131f,0.5366765f,-0.4566717f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448354f,1.364936f,0.7839596f,-0.7099152f,0.01382878f,0.02839298f,0.7035788f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.820633f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 21.26099f);
Get(0xDD1E).SetLocalPose(1.452749f,1.227453f,0.8637822f,0.4565403f,-0.5431656f,0.5367472f,-0.4565574f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448293f,1.365018f,0.7839108f,-0.7099234f,0.01383037f,0.02837605f,0.7035711f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.87734f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 21.27942f);
Get(0xDD1E).SetLocalPose(1.452921f,1.227515f,0.8635597f,0.4563129f,-0.5432449f,0.5369999f,-0.4563931f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448176f,1.364907f,0.7838559f,-0.7098991f,0.01386094f,0.02832159f,0.7035973f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.935687f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 21.29838f);
Get(0xDD1E).SetLocalPose(1.452724f,1.227618f,0.8633355f,0.4560359f,-0.5432685f,0.5372897f,-0.4563009f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44809f,1.364892f,0.7838659f,-0.7098957f,0.01386775f,0.0283269f,0.7036003f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 6.961936f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 21.30691f);
Get(0xDD1E).SetLocalPose(1.453124f,1.227242f,0.8635729f,0.456038f,-0.5431722f,0.5374275f,-0.4562511f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448025f,1.364736f,0.7838285f,-0.7099158f,0.01383677f,0.02836017f,0.7035792f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 7.023409f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 21.32689f);
Get(0xDD1E).SetLocalPose(1.453175f,1.227512f,0.8641295f,0.4557488f,-0.5431634f,0.5375762f,-0.4563754f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447908f,1.364785f,0.7837469f,-0.7099149f,0.01385376f,0.02834594f,0.7035804f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 7.081573f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 21.34579f);
Get(0xDD1E).SetLocalPose(1.453616f,1.228528f,0.864479f,0.4555821f,-0.543146f,0.5375591f,-0.4565825f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448045f,1.364883f,0.7837115f,-0.709905f,0.01382123f,0.02837772f,0.7035899f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 7.13767f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 21.36402f);
Get(0xDD1E).SetLocalPose(1.453965f,1.2285f,0.864641f,0.4556671f,-0.5429875f,0.5374833f,-0.4567754f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44817f,1.365032f,0.7837786f,-0.7099197f,0.01382601f,0.02839044f,0.7035744f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 7.192759f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 21.38193f);
Get(0xDD1E).SetLocalPose(1.454206f,1.227937f,0.8646285f,0.4555891f,-0.5429766f,0.5374719f,-0.4568796f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448233f,1.364983f,0.7837794f,-0.7099126f,0.01382507f,0.02837429f,0.7035822f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 7.220114f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 21.39082f);
Get(0xDD1E).SetLocalPose(1.454142f,1.228373f,0.8646261f,0.4554119f,-0.5431091f,0.53755f,-0.456807f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448264f,1.365032f,0.7837082f,-0.7098832f,0.01384166f,0.02837161f,0.7036116f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 7.280517f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 21.41045f);
Get(0xDD1E).SetLocalPose(1.454186f,1.228117f,0.8641303f,0.455484f,-0.5430869f,0.5374995f,-0.4568209f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448328f,1.365013f,0.7837262f,-0.7099164f,0.01381175f,0.02836075f,0.7035793f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 7.335395f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 21.42829f);
Get(0xDD1E).SetLocalPose(1.453922f,1.228122f,0.8636521f,0.4553718f,-0.5431461f,0.5373583f,-0.4570285f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448384f,1.364962f,0.7838011f,-0.7099183f,0.01385786f,0.02836457f,0.7035762f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 7.3897f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 21.44593f);
Get(0xDD1E).SetLocalPose(1.453942f,1.228035f,0.8631574f,0.455523f,-0.5430436f,0.5371078f,-0.4572939f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448334f,1.364836f,0.783803f,-0.7099068f,0.01385536f,0.02837818f,0.7035874f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 7.443984f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 21.46358f);
Get(0xDD1E).SetLocalPose(1.453514f,1.227918f,0.8631957f,0.4554432f,-0.5430478f,0.537124f,-0.4573494f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448354f,1.364677f,0.7836907f,-0.709954f,0.01378426f,0.02837544f,0.7035412f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 7.498493f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 21.48129f);
Get(0xDD1E).SetLocalPose(1.454235f,1.228481f,0.8627365f,0.4549266f,-0.5431939f,0.5374519f,-0.4573048f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448349f,1.364532f,0.7837245f,-0.7099254f,0.01378937f,0.02837382f,0.7035701f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 7.554424f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 21.49947f);
Get(0xDD1E).SetLocalPose(1.453688f,1.228956f,0.862416f,0.4547487f,-0.5431949f,0.5374842f,-0.4574426f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448429f,1.364699f,0.7838029f,-0.7099317f,0.01380628f,0.0283871f,0.7035628f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 7.583582f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 21.50895f);
Get(0xDD1E).SetLocalPose(1.453298f,1.228953f,0.8623945f,0.454929f,-0.5430733f,0.5372937f,-0.4576315f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448292f,1.364825f,0.7837797f,-0.7098989f,0.01382828f,0.02838358f,0.7035956f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 7.641736f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 21.52785f);
Get(0xDD1E).SetLocalPose(1.453424f,1.228089f,0.8620215f,0.4552808f,-0.5429624f,0.5369384f,-0.45783f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448252f,1.365032f,0.783813f,-0.7099065f,0.01379774f,0.02837444f,0.7035889f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 7.698963f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 21.54645f);
Get(0xDD1E).SetLocalPose(1.452984f,1.227689f,0.8620421f,0.4550447f,-0.5432616f,0.5369359f,-0.4577127f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448293f,1.364989f,0.7839134f,-0.7099255f,0.01382726f,0.02839405f,0.7035683f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 7.757321f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 21.56541f);
Get(0xDD1E).SetLocalPose(1.453433f,1.227768f,0.8620071f,0.4549119f,-0.5434219f,0.5370719f,-0.4574949f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448236f,1.364905f,0.7836846f,-0.7099075f,0.01383436f,0.02838287f,0.7035869f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 7.811578f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 21.58304f);
Get(0xDD1E).SetLocalPose(1.453444f,1.228756f,0.8623154f,0.4549087f,-0.5433825f,0.5370269f,-0.4575978f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44819f,1.364969f,0.7837564f,-0.7099189f,0.01383211f,0.02839137f,0.7035751f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 7.836992f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 21.5913f);
Get(0xDD1E).SetLocalPose(1.453271f,1.229643f,0.8624322f,0.4548799f,-0.54343f,0.5369635f,-0.4576443f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448171f,1.364844f,0.783743f,-0.7099262f,0.01383847f,0.02835428f,0.7035689f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 7.897255f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 21.61089f);
Get(0xDD1E).SetLocalPose(1.454059f,1.229163f,0.8624559f,0.4550169f,-0.5434309f,0.5365853f,-0.4579505f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448252f,1.3649f,0.7837927f,-0.7099262f,0.01379414f,0.02837194f,0.7035692f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 7.952725f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 21.62892f);
Get(0xDD1E).SetLocalPose(1.453571f,1.229176f,0.8629419f,0.4549778f,-0.5436461f,0.5365488f,-0.4577769f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448221f,1.364964f,0.7837116f,-0.7098917f,0.01381355f,0.02839281f,0.7036028f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.006777f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 21.64648f);
Get(0xDD1E).SetLocalPose(1.453322f,1.228839f,0.862882f,0.4547634f,-0.5438545f,0.5367114f,-0.4575517f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448345f,1.364933f,0.7837164f,-0.7099041f,0.01379735f,0.02836789f,0.7035916f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.061421f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 21.66424f);
Get(0xDD1E).SetLocalPose(1.452748f,1.229362f,0.8621477f,0.4546987f,-0.5439682f,0.5368505f,-0.4573174f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448145f,1.364887f,0.7836171f,-0.7098985f,0.01383243f,0.02834453f,0.7035975f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.116583f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 21.68217f);
Get(0xDD1E).SetLocalPose(1.452679f,1.228893f,0.8621414f,0.4551563f,-0.5438964f,0.5366123f,-0.4572273f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448057f,1.3649f,0.7836875f,-0.7098965f,0.01378695f,0.02832688f,0.7036012f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.171274f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 21.69995f);
Get(0xDD1E).SetLocalPose(1.452344f,1.229342f,0.8621103f,0.4553398f,-0.543883f,0.5364741f,-0.4572225f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44807f,1.364764f,0.7836563f,-0.7098944f,0.01381443f,0.02836819f,0.7036011f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.197495f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 21.70847f);
Get(0xDD1E).SetLocalPose(1.45279f,1.229837f,0.8618002f,0.4553379f,-0.5439197f,0.536456f,-0.4572019f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448222f,1.364685f,0.7836332f,-0.7098916f,0.01379166f,0.02835177f,0.703605f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.256136f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 21.72753f);
Get(0xDD1E).SetLocalPose(1.453307f,1.230202f,0.8619881f,0.4551747f,-0.5439658f,0.5365276f,-0.4572259f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448327f,1.364686f,0.7836486f,-0.7098859f,0.01381656f,0.02834604f,0.7036105f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.313003f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 21.74601f);
Get(0xDD1E).SetLocalPose(1.452384f,1.231115f,0.8621224f,0.4548667f,-0.5441912f,0.5366863f,-0.4570777f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448471f,1.364695f,0.7837779f,-0.7099036f,0.0137869f,0.0283444f,0.7035933f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.36898f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 21.7642f);
Get(0xDD1E).SetLocalPose(1.452251f,1.230382f,0.861807f,0.4552175f,-0.5442047f,0.536377f,-0.4570757f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448434f,1.364615f,0.7837266f,-0.7098979f,0.01378592f,0.02834923f,0.7035988f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.425258f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 21.78249f);
Get(0xDD1E).SetLocalPose(1.451791f,1.230207f,0.8622996f,0.455698f,-0.5441492f,0.5362371f,-0.4568269f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44839f,1.364797f,0.7836911f,-0.7098802f,0.01376268f,0.02837556f,0.7036161f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.451036f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 21.79087f);
Get(0xDD1E).SetLocalPose(1.451938f,1.230442f,0.8618854f,0.455663f,-0.5441346f,0.5363266f,-0.4567741f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448337f,1.364892f,0.7836859f,-0.7098832f,0.01379431f,0.02837797f,0.7036124f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.509874f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 21.80999f);
Get(0xDD1E).SetLocalPose(1.451857f,1.230234f,0.8620775f,0.4554036f,-0.5441652f,0.5365227f,-0.456766f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448409f,1.364938f,0.7838141f,-0.7098963f,0.0138005f,0.02835819f,0.7035998f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.565289f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 21.828f);
Get(0xDD1E).SetLocalPose(1.451853f,1.229624f,0.8619564f,0.4551448f,-0.5442545f,0.5364912f,-0.4569546f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448428f,1.365008f,0.7838819f,-0.7098879f,0.01385893f,0.02836009f,0.703607f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.621332f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 21.84621f);
Get(0xDD1E).SetLocalPose(1.45169f,1.228823f,0.8619059f,0.4551238f,-0.5443341f,0.5364844f,-0.4568886f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448386f,1.364927f,0.7837222f,-0.7098789f,0.01379582f,0.02834575f,0.703618f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.676622f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 21.86418f);
Get(0xDD1E).SetLocalPose(1.451728f,1.229671f,0.8616261f,0.4555623f,-0.5442522f,0.536404f,-0.4566438f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44819f,1.36502f,0.7836632f,-0.7098807f,0.01381659f,0.02834334f,0.7036158f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.732522f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 21.88235f);
Get(0xDD1E).SetLocalPose(1.451625f,1.230536f,0.8616814f,0.4558509f,-0.5442913f,0.5363045f,-0.4564257f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448231f,1.364921f,0.7836555f,-0.709878f,0.01383777f,0.02835879f,0.7036175f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.759032f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 21.89097f);
Get(0xDD1E).SetLocalPose(1.451734f,1.231294f,0.8614386f,0.4558492f,-0.5443573f,0.5363784f,-0.4562619f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448263f,1.36475f,0.783568f,-0.7098899f,0.01378511f,0.02836837f,0.7036061f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.816306f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 21.90958f);
Get(0xDD1E).SetLocalPose(1.452476f,1.231398f,0.8618793f,0.4555611f,-0.5445873f,0.5366018f,-0.4560124f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448376f,1.364726f,0.7836739f,-0.7099169f,0.01376994f,0.02836313f,0.7035793f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.87116f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 21.92741f);
Get(0xDD1E).SetLocalPose(1.45261f,1.231721f,0.861634f,0.455155f,-0.5446855f,0.5368355f,-0.4560256f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44827f,1.364782f,0.7837106f,-0.7099099f,0.01381322f,0.0283634f,0.7035856f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.927658f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 21.94577f);
Get(0xDD1E).SetLocalPose(1.452533f,1.232046f,0.8613989f,0.4552301f,-0.5445116f,0.5367131f,-0.4563021f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.4483f,1.364782f,0.7838536f,-0.7099059f,0.01379402f,0.02837999f,0.7035894f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 8.981487f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 21.96327f);
Get(0xDD1E).SetLocalPose(1.45281f,1.232358f,0.8609276f,0.4557047f,-0.5443642f,0.5364425f,-0.4563227f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448273f,1.364936f,0.7839281f,-0.7099188f,0.01377191f,0.02839519f,0.7035762f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 9.037282f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 21.9814f);
Get(0xDD1E).SetLocalPose(1.452277f,1.231688f,0.8614861f,0.4560066f,-0.5443976f,0.5363907f,-0.4560421f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448283f,1.36505f,0.7841036f,-0.7099119f,0.01378744f,0.02838134f,0.7035834f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 9.091799f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 21.99912f);
Get(0xDD1E).SetLocalPose(1.452874f,1.230923f,0.8614846f,0.455774f,-0.5446284f,0.5367109f,-0.4556219f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448466f,1.365101f,0.7841772f,-0.7099248f,0.01378513f,0.0284013f,0.7035697f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 9.117664f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 22.00752f);
Get(0xDD1E).SetLocalPose(1.452939f,1.230928f,0.8614172f,0.455547f,-0.5446839f,0.5368963f,-0.4555643f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448562f,1.365088f,0.7841137f,-0.7099319f,0.01380069f,0.02837509f,0.7035632f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 9.176577f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 22.02667f);
Get(0xDD1E).SetLocalPose(1.45325f,1.231483f,0.8614174f,0.4556631f,-0.5444919f,0.5367718f,-0.4558243f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448641f,1.365085f,0.7839416f,-0.7099104f,0.01378733f,0.02835407f,0.703586f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 9.231996f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 22.04468f);
Get(0xDD1E).SetLocalPose(1.452683f,1.231163f,0.8612746f,0.4558828f,-0.5442324f,0.5363749f,-0.4563813f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448714f,1.364982f,0.7840713f,-0.7099349f,0.0137906f,0.02835551f,0.7035611f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 9.28707f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 22.06258f);
Get(0xDD1E).SetLocalPose(1.453136f,1.230111f,0.8609809f,0.4562368f,-0.5440843f,0.5359842f,-0.4566632f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448625f,1.364969f,0.7839894f,-0.7099509f,0.01377118f,0.02839179f,0.703544f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 9.34432f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 22.08119f);
Get(0xDD1E).SetLocalPose(1.453231f,1.230069f,0.8611211f,0.4563232f,-0.544072f,0.5360157f,-0.4565545f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44839f,1.364995f,0.7838854f,-0.7099267f,0.01380481f,0.02839168f,0.7035677f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 9.4f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 22.09928f);
Get(0xDD1E).SetLocalPose(1.452838f,1.229865f,0.8620405f,0.4561113f,-0.5441126f,0.536412f,-0.4562522f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448555f,1.364973f,0.7839572f,-0.7099311f,0.01379885f,0.02836792f,0.7035643f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 9.426399f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 22.10786f);
Get(0xDD1E).SetLocalPose(1.453144f,1.229939f,0.861751f,0.4561529f,-0.5439998f,0.5365011f,-0.4562405f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448437f,1.364847f,0.7839229f,-0.7099172f,0.01378209f,0.02840275f,0.7035772f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 9.486568f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 22.12742f);
Get(0xDD1E).SetLocalPose(1.453573f,1.229221f,0.8609174f,0.456374f,-0.5437027f,0.5364618f,-0.4564199f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448298f,1.364842f,0.7838231f,-0.7099271f,0.0138152f,0.02838942f,0.7035671f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 9.542529f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 22.14561f);
Get(0xDD1E).SetLocalPose(1.453305f,1.229112f,0.8608509f,0.45632f,-0.543575f,0.5364732f,-0.4566123f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448322f,1.364987f,0.7838011f,-0.7099156f,0.01378097f,0.02841702f,0.7035784f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 9.597902f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 22.1636f);
Get(0xDD1E).SetLocalPose(1.453073f,1.228911f,0.8603824f,0.4561312f,-0.5437243f,0.5363919f,-0.4567187f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448389f,1.365174f,0.7838709f,-0.7099072f,0.01380954f,0.02839197f,0.7035872f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 9.652909f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 22.18148f);
Get(0xDD1E).SetLocalPose(1.452999f,1.229112f,0.8599314f,0.4562859f,-0.5437712f,0.5361786f,-0.4567587f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44844f,1.365068f,0.7839572f,-0.7099085f,0.01377651f,0.02838612f,0.7035868f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 9.708302f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 22.19948f);
Get(0xDD1E).SetLocalPose(1.453775f,1.229585f,0.8594397f,0.4564348f,-0.5436416f,0.5361366f,-0.4568137f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448468f,1.364957f,0.7838867f,-0.7099251f,0.01377469f,0.02838779f,0.7035701f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 9.734275f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 22.20792f);
Get(0xDD1E).SetLocalPose(1.45361f,1.230089f,0.8591247f,0.45636f,-0.5436308f,0.5362141f,-0.45681f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448518f,1.364811f,0.7838852f,-0.7099317f,0.0137594f,0.02836755f,0.7035645f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 9.79097f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 22.22635f);
Get(0xDD1E).SetLocalPose(1.453956f,1.229605f,0.8586819f,0.4562536f,-0.5434726f,0.5363351f,-0.4569626f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.4484f,1.364871f,0.7838051f,-0.7098968f,0.01380966f,0.02837363f,0.7035985f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 9.847953f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 22.24487f);
Get(0xDD1E).SetLocalPose(1.453544f,1.229684f,0.8591976f,0.4562081f,-0.5434335f,0.5363144f,-0.4570788f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448412f,1.364842f,0.7837911f,-0.7099174f,0.0138022f,0.02835783f,0.7035786f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 9.904652f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 22.2633f);
Get(0xDD1E).SetLocalPose(1.453651f,1.230245f,0.8587683f,0.4561504f,-0.5432873f,0.5362579f,-0.4573763f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44841f,1.364753f,0.7837647f,-0.7099326f,0.01378997f,0.02836297f,0.7035632f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 9.959905f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 22.28125f);
Get(0xDD1E).SetLocalPose(1.453801f,1.230105f,0.8580292f,0.4562442f,-0.5430869f,0.5360447f,-0.4577707f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448373f,1.364722f,0.7837167f,-0.7099205f,0.01378426f,0.02838512f,0.7035746f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 10.01522f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 22.29923f);
Get(0xDD1E).SetLocalPose(1.453344f,1.229249f,0.8580852f,0.4566212f,-0.5428814f,0.5357271f,-0.4580103f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448237f,1.364757f,0.7836768f,-0.7099306f,0.0137682f,0.028369f,0.7035654f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 10.04244f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 22.30807f);
Get(0xDD1E).SetLocalPose(1.45304f,1.229466f,0.858198f,0.4568183f,-0.5428313f,0.5355847f,-0.4580398f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448198f,1.36467f,0.783608f,-0.7099044f,0.01379258f,0.02835419f,0.7035919f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 10.09971f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 22.32669f);
Get(0xDD1E).SetLocalPose(1.452537f,1.229638f,0.8576712f,0.4566105f,-0.5429436f,0.5357041f,-0.457974f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448215f,1.364688f,0.7835408f,-0.7098916f,0.01380979f,0.0283525f,0.7036046f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 10.15497f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 22.34465f);
Get(0xDD1E).SetLocalPose(1.452092f,1.229474f,0.8574386f,0.4564513f,-0.5429375f,0.5359717f,-0.4578269f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44816f,1.364801f,0.7836878f,-0.7098837f,0.01380844f,0.02835792f,0.7036123f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 10.20999f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 22.36253f);
Get(0xDD1E).SetLocalPose(1.451842f,1.229341f,0.8570566f,0.4565309f,-0.5429639f,0.5359071f,-0.4577917f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448273f,1.364854f,0.7836803f,-0.7098844f,0.01379335f,0.0283776f,0.7036112f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 10.26541f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 22.38054f);
Get(0xDD1E).SetLocalPose(1.451922f,1.230039f,0.8576931f,0.4569203f,-0.5428594f,0.5356267f,-0.4578555f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448059f,1.364943f,0.7835567f,-0.7098567f,0.01384852f,0.02834408f,0.7036393f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 10.32096f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 22.3986f);
Get(0xDD1E).SetLocalPose(1.452337f,1.229918f,0.8575561f,0.4570933f,-0.5429363f,0.535563f,-0.457666f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44803f,1.364945f,0.7835026f,-0.7098599f,0.01386413f,0.02833869f,0.7036361f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 10.37582f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 22.41642f);
Get(0xDD1E).SetLocalPose(1.452737f,1.228927f,0.8584639f,0.4571747f,-0.5429831f,0.535683f,-0.4573888f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44811f,1.364988f,0.7836295f,-0.7098646f,0.01386203f,0.02835207f,0.7036309f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 10.40186f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 22.42489f);
Get(0xDD1E).SetLocalPose(1.452212f,1.229131f,0.8581597f,0.4571296f,-0.5430928f,0.5357308f,-0.4572476f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448162f,1.364875f,0.7835629f,-0.7098827f,0.01383942f,0.02832667f,0.703614f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 10.46145f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 22.44426f);
Get(0xDD1E).SetLocalPose(1.451171f,1.230095f,0.8583049f,0.4573047f,-0.5431967f,0.5357246f,-0.4569561f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448026f,1.364835f,0.7834818f,-0.7098771f,0.01384821f,0.02835549f,0.7036184f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 10.51593f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 22.46196f);
Get(0xDD1E).SetLocalPose(1.450652f,1.231518f,0.8584847f,0.4574243f,-0.543339f,0.5357405f,-0.4566485f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448083f,1.364868f,0.7834664f,-0.7098884f,0.0138683f,0.02833358f,0.7036074f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 10.57076f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 22.47978f);
Get(0xDD1E).SetLocalPose(1.450871f,1.230652f,0.859773f,0.457644f,-0.5434515f,0.5356843f,-0.4563604f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447956f,1.364748f,0.7834036f,-0.7098885f,0.01386553f,0.0283204f,0.703608f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 10.62459f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 22.49728f);
Get(0xDD1E).SetLocalPose(1.450802f,1.230173f,0.8598975f,0.4578094f,-0.5437775f,0.5355785f,-0.4559301f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44793f,1.364842f,0.7835883f,-0.7099084f,0.01384483f,0.02832544f,0.7035881f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 10.68033f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 22.51539f);
Get(0xDD1E).SetLocalPose(1.450788f,1.229082f,0.8602065f,0.4579126f,-0.543862f,0.5358874f,-0.4553624f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447863f,1.364786f,0.7835299f,-0.7098922f,0.01385581f,0.02833625f,0.7036038f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 10.70691f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 22.52403f);
Get(0xDD1E).SetLocalPose(1.450766f,1.229065f,0.8602058f,0.4578901f,-0.5438851f,0.5359795f,-0.4552491f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447749f,1.364822f,0.783452f,-0.709888f,0.01388147f,0.02834347f,0.7036071f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 10.76478f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 22.54284f);
Get(0xDD1E).SetLocalPose(1.449809f,1.228994f,0.8605163f,0.457996f,-0.5439078f,0.5359811f,-0.4551135f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447759f,1.364846f,0.783486f,-0.7098779f,0.0138906f,0.02832942f,0.7036178f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 10.79091f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 22.55133f);
Get(0xDD1E).SetLocalPose(1.449528f,1.228937f,0.8607014f,0.458129f,-0.5439427f,0.5357209f,-0.4552443f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447941f,1.36472f,0.7836508f,-0.7099088f,0.01384939f,0.0283437f,0.7035869f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 10.885f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 22.58191f);
Get(0xDD1E).SetLocalPose(1.450156f,1.229264f,0.8602464f,0.4584517f,-0.544214f,0.5350792f,-0.4553497f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448135f,1.364781f,0.7836934f,-0.7098991f,0.01383809f,0.02836657f,0.7035959f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 10.91233f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 22.59079f);
Get(0xDD1E).SetLocalPose(1.450109f,1.229345f,0.8601641f,0.4583145f,-0.5444759f,0.5349922f,-0.4552771f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448189f,1.364815f,0.7838593f,-0.7099052f,0.01386448f,0.02838837f,0.7035884f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 10.97295f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 22.61049f);
Get(0xDD1E).SetLocalPose(1.449725f,1.229504f,0.8601314f,0.4584341f,-0.5447181f,0.5346531f,-0.4552654f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448215f,1.364976f,0.7839997f,-0.7099215f,0.01384468f,0.02837256f,0.7035729f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 11.02961f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 22.62891f);
Get(0xDD1E).SetLocalPose(1.448195f,1.229493f,0.8600373f,0.4593158f,-0.5445276f,0.5335732f,-0.4558708f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448188f,1.364879f,0.7839779f,-0.7099237f,0.01382308f,0.028404f,0.7035698f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 11.08444f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 22.64673f);
Get(0xDD1E).SetLocalPose(1.447197f,1.230632f,0.8594017f,0.4612515f,-0.5437436f,0.5314896f,-0.4572842f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448294f,1.364812f,0.7839149f,-0.7099197f,0.0138267f,0.02837971f,0.7035748f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 11.13851f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 22.6643f);
Get(0xDD1E).SetLocalPose(1.447571f,1.231172f,0.8590881f,0.4634777f,-0.5429422f,0.5289087f,-0.4589748f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448478f,1.364702f,0.78394f,-0.7099436f,0.0137887f,0.02841602f,0.7035499f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 11.19447f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 22.68249f);
Get(0xDD1E).SetLocalPose(1.447143f,1.231617f,0.8584331f,0.4666215f,-0.5418717f,0.524701f,-0.4618748f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448493f,1.36466f,0.783962f,-0.709943f,0.01379723f,0.02841628f,0.7035503f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 11.22049f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 22.69094f);
Get(0xDD1E).SetLocalPose(1.446983f,1.231549f,0.8580795f,0.4687541f,-0.5411082f,0.5217826f,-0.4639122f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448522f,1.364688f,0.7838564f,-0.7099339f,0.01381412f,0.02837902f,0.7035607f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 11.28089f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 22.71058f);
Get(0xDD1E).SetLocalPose(1.447805f,1.23152f,0.8574939f,0.4743767f,-0.539293f,0.5138696f,-0.469114f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448346f,1.365039f,0.7838783f,-0.7099152f,0.01383151f,0.02840556f,0.7035782f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 11.33511f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 22.72819f);
Get(0xDD1E).SetLocalPose(1.447207f,1.23187f,0.8571965f,0.4828538f,-0.5368095f,0.50112f,-0.4770394f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448431f,1.365079f,0.7837663f,-0.7099043f,0.01378497f,0.02839672f,0.7035905f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 11.39429f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 22.74743f);
Get(0xDD1E).SetLocalPose(1.447663f,1.23253f,0.8568307f,0.4925981f,-0.5323167f,0.4885117f,-0.485121f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448385f,1.364961f,0.7836874f,-0.7099002f,0.01376459f,0.02839615f,0.703595f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 11.44951f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 22.76537f);
Get(0xDD1E).SetLocalPose(1.446361f,1.231653f,0.8570145f,0.5051083f,-0.5252117f,0.4729942f,-0.4952724f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448422f,1.364952f,0.7836013f,-0.7098958f,0.01375836f,0.02842465f,0.7035984f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 11.50371f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 22.78299f);
Get(0xDD1E).SetLocalPose(1.446027f,1.230618f,0.8567706f,0.5152941f,-0.5182247f,0.4598747f,-0.504411f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448523f,1.365094f,0.7836729f,-0.7099093f,0.01378479f,0.02841687f,0.7035846f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 11.53013f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 22.79158f);
Get(0xDD1E).SetLocalPose(1.445253f,1.229818f,0.8574284f,0.5234559f,-0.5122227f,0.4488706f,-0.5119933f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448643f,1.365168f,0.7838539f,-0.7099201f,0.01377712f,0.02841694f,0.7035739f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 11.59049f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 22.81119f);
Get(0xDD1E).SetLocalPose(1.444717f,1.226595f,0.8579968f,0.5358548f,-0.5028527f,0.4323989f,-0.5225226f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448652f,1.365118f,0.7836613f,-0.7098956f,0.01379012f,0.02841821f,0.7035984f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 11.64596f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 22.82922f);
Get(0xDD1E).SetLocalPose(1.441942f,1.221455f,0.8606282f,0.5557787f,-0.4875976f,0.4097827f,-0.5342628f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448705f,1.36527f,0.7839667f,-0.7099093f,0.01376699f,0.02842711f,0.7035847f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 11.70146f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 22.84726f);
Get(0xDD1E).SetLocalPose(1.439494f,1.215336f,0.8631234f,0.5759331f,-0.471873f,0.3903461f,-0.5415412f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448783f,1.36529f,0.7840105f,-0.709917f,0.01377791f,0.02842112f,0.7035769f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 11.76112f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 22.86665f);
Get(0xDD1E).SetLocalPose(1.435851f,1.205336f,0.8681238f,0.6038597f,-0.4484466f,0.366515f,-0.5476459f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448683f,1.365235f,0.7838667f,-0.7099035f,0.01380678f,0.02841781f,0.70359f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 11.79039f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 22.87616f);
Get(0xDD1E).SetLocalPose(1.434218f,1.198822f,0.8706114f,0.6161291f,-0.4374408f,0.3570465f,-0.5491341f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448561f,1.365158f,0.7839516f,-0.7099205f,0.01380824f,0.02838613f,0.7035742f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 11.84944f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 22.89535f);
Get(0xDD1E).SetLocalPose(1.431441f,1.184714f,0.8772714f,0.638207f,-0.4167496f,0.3420571f,-0.5495531f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448352f,1.364923f,0.7837887f,-0.7099329f,0.01382834f,0.02837397f,0.7035618f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 11.90478f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 22.91333f);
Get(0xDD1E).SetLocalPose(1.430783f,1.17548f,0.8820038f,0.6509098f,-0.4044847f,0.3340161f,-0.5487639f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448242f,1.364786f,0.7839011f,-0.7099289f,0.0138608f,0.02834837f,0.7035661f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 11.96157f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 22.93179f);
Get(0xDD1E).SetLocalPose(1.428543f,1.154686f,0.8922238f,0.6782393f,-0.3776167f,0.3183787f,-0.5440884f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447999f,1.364829f,0.783861f,-0.7099218f,0.01386262f,0.02836796f,0.7035725f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 12.01712f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 22.94984f);
Get(0xDD1E).SetLocalPose(1.426626f,1.132923f,0.9040821f,0.7059801f,-0.3498928f,0.3046574f,-0.5351177f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447893f,1.364759f,0.7837867f,-0.7099006f,0.0138738f,0.02836544f,0.7035937f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 12.04409f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 22.95861f);
Get(0xDD1E).SetLocalPose(1.424953f,1.111672f,0.9157709f,0.7324035f,-0.3231875f,0.2931244f,-0.5226979f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447836f,1.364879f,0.7837813f,-0.7098932f,0.01387812f,0.02835391f,0.7036016f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 12.10515f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 22.97846f);
Get(0xDD1E).SetLocalPose(1.423146f,1.090395f,0.9273354f,0.7564269f,-0.2991287f,0.2841156f,-0.5075615f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447823f,1.364742f,0.7837033f,-0.7099025f,0.01386709f,0.02838485f,0.703591f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 12.16033f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 22.99639f);
Get(0xDD1E).SetLocalPose(1.421521f,1.06189f,0.9446223f,0.7880635f,-0.267952f,0.2738603f,-0.481828f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447994f,1.364599f,0.7836174f,-0.7099071f,0.01383879f,0.02836724f,0.7035878f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 12.21588f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 23.01444f);
Get(0xDD1E).SetLocalPose(1.420882f,1.024486f,0.9691113f,0.8255164f,-0.2313952f,0.2626202f,-0.4427298f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447978f,1.364559f,0.7835895f,-0.7098873f,0.01384584f,0.02838526f,0.7036069f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 12.24362f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 23.02346f);
Get(0xDD1E).SetLocalPose(1.420686f,1.003499f,0.9834183f,0.845253f,-0.2121837f,0.2560166f,-0.4183074f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448256f,1.364693f,0.7837713f,-0.7099162f,0.01384125f,0.02838253f,0.7035779f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 12.30644f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 23.04388f);
Get(0xDD1E).SetLocalPose(1.419658f,0.9754423f,1.003935f,0.8710091f,-0.1869786f,0.2463754f,-0.3816822f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448408f,1.364805f,0.7838251f,-0.7099263f,0.01379873f,0.02838016f,0.7035688f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 12.36179f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 23.06186f);
Get(0xDD1E).SetLocalPose(1.419685f,0.9388082f,1.034204f,0.901904f,-0.1539402f,0.2335285f,-0.3291445f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448404f,1.364737f,0.7838189f,-0.7099295f,0.01380701f,0.0283643f,0.703566f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 12.41872f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 23.08037f);
Get(0xDD1E).SetLocalPose(1.42001f,0.9103271f,1.059715f,0.9234341f,-0.1280483f,0.2256023f,-0.2828016f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448431f,1.364814f,0.7837558f,-0.7099364f,0.01381846f,0.02837618f,0.7035583f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 12.47618f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 23.09904f);
Get(0xDD1E).SetLocalPose(1.421746f,0.8778668f,1.093361f,0.9434804f,-0.1020475f,0.2225537f,-0.223385f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448352f,1.364876f,0.7838019f,-0.7099072f,0.01382468f,0.02835637f,0.7035884f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 12.50453f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 23.10825f);
Get(0xDD1E).SetLocalPose(1.423032f,0.8594351f,1.115129f,0.9516936f,-0.0898565f,0.2247177f,-0.1889631f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448319f,1.364975f,0.783794f,-0.7099099f,0.01381667f,0.02837425f,0.7035851f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 12.56538f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 23.12803f);
Get(0xDD1E).SetLocalPose(1.42558f,0.8366739f,1.14607f,0.9592189f,-0.07670832f,0.2291571f,-0.1466359f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448283f,1.364916f,0.7837517f,-0.7099037f,0.01381963f,0.02838723f,0.7035908f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 12.62216f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 23.14648f);
Get(0xDD1E).SetLocalPose(1.427837f,0.8194011f,1.171444f,0.9637808f,-0.06785495f,0.2310731f,-0.1145754f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448244f,1.364983f,0.7837219f,-0.7098942f,0.01383843f,0.02839831f,0.7035995f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 12.6797f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 23.16518f);
Get(0xDD1E).SetLocalPose(1.432968f,0.7928268f,1.219981f,0.9704848f,-0.05458314f,0.225876f,-0.06449859f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448281f,1.364936f,0.7837035f,-0.7098739f,0.01384442f,0.02840014f,0.7036199f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 12.70622f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 23.17381f);
Get(0xDD1E).SetLocalPose(1.434348f,0.7878342f,1.230763f,0.9718587f,-0.05142825f,0.2236017f,-0.0533684f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448142f,1.364824f,0.7832772f,-0.7098467f,0.01388768f,0.02838418f,0.7036471f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 12.76666f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 23.19345f);
Get(0xDD1E).SetLocalPose(1.441602f,0.7742721f,1.265959f,0.9757611f,-0.03690362f,0.2152326f,-0.01426047f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448208f,1.364856f,0.7832456f,-0.7098528f,0.0138814f,0.02837886f,0.7036413f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 12.82233f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 23.21154f);
Get(0xDD1E).SetLocalPose(1.449302f,0.7647532f,1.29755f,0.9771924f,-0.01784315f,0.2101776f,0.02453668f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448011f,1.364854f,0.7832299f,-0.7098492f,0.01386593f,0.02836592f,0.7036457f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 12.8779f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 23.2296f);
Get(0xDD1E).SetLocalPose(1.45909f,0.758632f,1.33009f,0.9774839f,0.0006353292f,0.2006428f,0.06532585f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448037f,1.364834f,0.7832781f,-0.7098693f,0.01386556f,0.02836072f,0.7036257f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 12.93569f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 23.24838f);
Get(0xDD1E).SetLocalPose(1.461081f,0.755381f,1.337603f,0.9792949f,0.02398678f,0.1729486f,0.1024453f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448005f,1.364864f,0.7833011f,-0.7098525f,0.01386355f,0.02837284f,0.7036422f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 12.96293f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 23.25723f);
Get(0xDD1E).SetLocalPose(1.447834f,0.7535133f,1.343286f,0.9926029f,0.03830684f,0.004799328f,0.1151045f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448009f,1.364962f,0.7834535f,-0.7098507f,0.01384223f,0.02840854f,0.7036428f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 13.02756f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 23.27824f);
Get(0xDD1E).SetLocalPose(1.436695f,0.7555742f,1.345455f,0.9923755f,0.01976182f,-0.06137358f,0.1050417f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448126f,1.364949f,0.7834581f,-0.709874f,0.01379764f,0.02841384f,0.7036201f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 13.086f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 23.29723f);
Get(0xDD1E).SetLocalPose(1.432845f,0.7583535f,1.347111f,0.9915921f,0.01276277f,-0.08170832f,0.0995292f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448339f,1.364915f,0.783644f,-0.7098888f,0.01380537f,0.02843237f,0.7036043f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 13.14346f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 23.3159f);
Get(0xDD1E).SetLocalPose(1.432838f,0.7608674f,1.347858f,0.9938775f,0.008116811f,-0.05971491f,0.09260579f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448461f,1.365019f,0.783732f,-0.7098855f,0.01383201f,0.02841518f,0.7036079f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 13.17422f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 23.3259f);
Get(0xDD1E).SetLocalPose(1.43485f,0.7612056f,1.348892f,0.9951332f,0.007694488f,-0.03698225f,0.09101159f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448457f,1.365038f,0.7836695f,-0.7098761f,0.01380638f,0.02837569f,0.7036194f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 13.24031f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 23.34738f);
Get(0xDD1E).SetLocalPose(1.438554f,0.7623833f,1.349505f,0.9959946f,0.006606149f,0.008443257f,0.08876841f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448586f,1.364996f,0.7838215f,-0.709893f,0.01380506f,0.0283912f,0.7036017f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 13.27014f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 23.35707f);
Get(0xDD1E).SetLocalPose(1.443876f,0.7650077f,1.349935f,0.9948349f,0.002233623f,0.05343059f,0.08627714f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448528f,1.36511f,0.783973f,-0.7098908f,0.01379184f,0.02840403f,0.7036037f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 13.33351f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 23.37767f);
Get(0xDD1E).SetLocalPose(1.448057f,0.767159f,1.349114f,0.9919848f,-0.003490214f,0.09439813f,0.08392294f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448576f,1.365108f,0.7839804f,-0.7098943f,0.01377179f,0.02841209f,0.7036002f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 13.39081f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 23.39629f);
Get(0xDD1E).SetLocalPose(1.451321f,0.7659252f,1.348693f,0.9888361f,-0.008133235f,0.1254321f,0.08002517f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448504f,1.365044f,0.7837939f,-0.7098935f,0.01379981f,0.02840547f,0.7036008f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 13.44691f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 23.41453f);
Get(0xDD1E).SetLocalPose(1.454161f,0.7667062f,1.345555f,0.9858489f,-0.01502901f,0.1507453f,0.07177782f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448621f,1.365059f,0.7839507f,-0.7099162f,0.01376797f,0.0284265f,0.7035776f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 13.50404f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 23.43309f);
Get(0xDD1E).SetLocalPose(1.455526f,0.7676965f,1.341705f,0.9832077f,-0.02731919f,0.1707779f,0.05823443f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448656f,1.365074f,0.7839508f,-0.7099202f,0.01376593f,0.02842535f,0.7035737f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 13.53177f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 23.44211f);
Get(0xDD1E).SetLocalPose(1.455698f,0.7685264f,1.34011f,0.9824444f,-0.03286353f,0.1761255f,0.05198841f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448824f,1.365022f,0.7840363f,-0.709951f,0.0137193f,0.02844466f,0.7035426f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 13.59056f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 23.46121f);
Get(0xDD1E).SetLocalPose(1.457196f,0.7706458f,1.335676f,0.9814113f,-0.04592424f,0.1825486f,0.03740274f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448825f,1.365069f,0.7840708f,-0.7099484f,0.01374056f,0.02844594f,0.7035449f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 13.64797f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 23.47987f);
Get(0xDD1E).SetLocalPose(1.457857f,0.7726007f,1.329401f,0.9813136f,-0.06090068f,0.1813248f,0.02088502f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448639f,1.365272f,0.7839888f,-0.7099277f,0.01377812f,0.02843587f,0.7035655f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 13.70815f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 23.49943f);
Get(0xDD1E).SetLocalPose(1.457388f,0.774151f,1.324166f,0.9816826f,-0.07431499f,0.1753015f,0.006787984f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448546f,1.365114f,0.7838824f,-0.7099221f,0.01378265f,0.02839393f,0.7035726f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 13.7359f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 23.50845f);
Get(0xDD1E).SetLocalPose(1.457759f,0.7746453f,1.319692f,0.9818116f,-0.08305607f,0.1707106f,-0.002399163f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448416f,1.365198f,0.7838805f,-0.7098937f,0.01381466f,0.02836383f,0.7036019f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 13.79799f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 23.52863f);
Get(0xDD1E).SetLocalPose(1.459695f,0.7759373f,1.313688f,0.9816264f,-0.09369738f,0.1656736f,-0.01351663f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448367f,1.365128f,0.7838904f,-0.7099146f,0.01381017f,0.0283324f,0.7035822f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 13.85659f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 23.54768f);
Get(0xDD1E).SetLocalPose(1.462643f,0.777452f,1.307706f,0.9806468f,-0.1057757f,0.1628684f,-0.02484638f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448165f,1.364895f,0.7838872f,-0.7099109f,0.01385906f,0.02832731f,0.7035851f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 13.91353f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 23.56618f);
Get(0xDD1E).SetLocalPose(1.466855f,0.7791066f,1.30312f,0.9791098f,-0.1145637f,0.1651484f,-0.03074412f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448156f,1.364726f,0.7838707f,-0.7099041f,0.01384645f,0.02832375f,0.7035924f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 13.94212f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 23.57547f);
Get(0xDD1E).SetLocalPose(1.469028f,0.7795756f,1.301367f,0.9780055f,-0.119245f,0.1678933f,-0.0331309f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44816f,1.364574f,0.7837908f,-0.7098989f,0.0138621f,0.02832639f,0.7035972f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 14.00213f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 23.59498f);
Get(0xDD1E).SetLocalPose(1.474359f,0.7802377f,1.298135f,0.9754335f,-0.1283443f,0.1751238f,-0.0372684f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448081f,1.364688f,0.7839801f,-0.7099125f,0.01381625f,0.02838891f,0.7035819f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 14.05929f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 23.61355f);
Get(0xDD1E).SetLocalPose(1.480486f,0.7813046f,1.295366f,0.9728402f,-0.1360074f,0.1827222f,-0.04118989f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448046f,1.364869f,0.7837617f,-0.7099068f,0.0138386f,0.02838494f,0.7035874f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 14.11714f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 23.63235f);
Get(0xDD1E).SetLocalPose(1.486999f,0.7822649f,1.294633f,0.9698125f,-0.1439922f,0.1914896f,-0.04540632f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447953f,1.364762f,0.7837544f,-0.7098942f,0.01384321f,0.02836965f,0.7036005f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 14.14416f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 23.64114f);
Get(0xDD1E).SetLocalPose(1.489789f,0.7822316f,1.295247f,0.9685345f,-0.1471327f,0.1951106f,-0.04716547f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447963f,1.364867f,0.7837244f,-0.7098887f,0.01383905f,0.02836249f,0.7036065f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 14.20309f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 23.66029f);
Get(0xDD1E).SetLocalPose(1.498142f,0.7825703f,1.297175f,0.9650877f,-0.154983f,0.2047866f,-0.05146452f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448043f,1.364868f,0.7836841f,-0.7099057f,0.01383166f,0.02838331f,0.7035887f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 14.25691f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 23.67778f);
Get(0xDD1E).SetLocalPose(1.505004f,0.782748f,1.298365f,0.9620489f,-0.1610657f,0.2133699f,-0.0547102f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448189f,1.364884f,0.7837213f,-0.7099264f,0.01383182f,0.02837396f,0.7035683f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 14.3112f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 23.69542f);
Get(0xDD1E).SetLocalPose(1.512192f,0.7815714f,1.299959f,0.9587752f,-0.1669083f,0.2227349f,-0.05727985f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448234f,1.364925f,0.783844f,-0.7099088f,0.01382976f,0.02836891f,0.7035862f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 14.36587f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 23.71319f);
Get(0xDD1E).SetLocalPose(1.522335f,0.78018f,1.302959f,0.9543034f,-0.1740471f,0.2356697f,-0.05892776f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448285f,1.364932f,0.7839521f,-0.709929f,0.01381739f,0.02836529f,0.7035661f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 14.42137f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 23.73123f);
Get(0xDD1E).SetLocalPose(1.530948f,0.7799941f,1.304899f,0.9504799f,-0.1798441f,0.246466f,-0.05914912f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448308f,1.364948f,0.7840305f,-0.7099105f,0.0138547f,0.02838532f,0.7035833f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 14.47734f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 23.74942f);
Get(0xDD1E).SetLocalPose(1.54194f,0.7794997f,1.308695f,0.945654f,-0.1871645f,0.2594665f,-0.05818342f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448348f,1.364863f,0.7839826f,-0.7099215f,0.01384489f,0.02835736f,0.7035735f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 14.50373f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 23.75799f);
Get(0xDD1E).SetLocalPose(1.546508f,0.778044f,1.310668f,0.9437116f,-0.1900462f,0.2645468f,-0.05749563f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448243f,1.364947f,0.7839824f,-0.7099192f,0.01387086f,0.02834675f,0.7035758f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 14.56228f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 23.77702f);
Get(0xDD1E).SetLocalPose(1.558969f,0.7752079f,1.314757f,0.938913f,-0.1970122f,0.2766405f,-0.05566468f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448162f,1.364715f,0.7837933f,-0.7099168f,0.0138605f,0.02836135f,0.7035778f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 14.61882f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 23.7954f);
Get(0xDD1E).SetLocalPose(1.567817f,0.7737576f,1.318094f,0.9355826f,-0.2018764f,0.2845928f,-0.05420417f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448122f,1.364723f,0.7837356f,-0.7099069f,0.0138705f,0.02834516f,0.7035882f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 14.67347f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 23.81316f);
Get(0xDD1E).SetLocalPose(1.582197f,0.7721179f,1.322496f,0.9308702f,-0.2085487f,0.2953178f,-0.05268378f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448015f,1.364708f,0.7836447f,-0.7099076f,0.01385701f,0.02838079f,0.7035865f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 14.72929f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 23.8313f);
Get(0xDD1E).SetLocalPose(1.59502f,0.7724133f,1.327235f,0.9266239f,-0.2136933f,0.3049778f,-0.05188273f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44806f,1.364827f,0.783761f,-0.7099083f,0.01382116f,0.02838214f,0.7035863f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 14.78499f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 23.8494f);
Get(0xDD1E).SetLocalPose(1.609057f,0.7712259f,1.331882f,0.922404f,-0.2172557f,0.315055f,-0.05207017f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448061f,1.364845f,0.7836697f,-0.709909f,0.01382145f,0.02838579f,0.7035854f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 14.81224f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 23.85826f);
Get(0xDD1E).SetLocalPose(1.619455f,0.7706893f,1.33501f,0.9195753f,-0.2188277f,0.3220684f,-0.05260893f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448159f,1.364783f,0.7835406f,-0.7099133f,0.01382288f,0.02838518f,0.7035812f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 14.8689f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 23.87668f);
Get(0xDD1E).SetLocalPose(1.632737f,0.7695721f,1.339059f,0.9156926f,-0.2208885f,0.3314567f,-0.053404f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448225f,1.364787f,0.7837372f,-0.7099093f,0.01383564f,0.02838526f,0.7035848f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 14.92443f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 23.89472f);
Get(0xDD1E).SetLocalPose(1.64806f,0.7680365f,1.34371f,0.9113703f,-0.2234415f,0.3413801f,-0.0542006f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448223f,1.364835f,0.783694f,-0.7099084f,0.01383998f,0.02838708f,0.7035856f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 14.97885f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 23.91241f);
Get(0xDD1E).SetLocalPose(1.662015f,0.7683032f,1.348662f,0.9075384f,-0.2262693f,0.3495047f,-0.05498125f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448233f,1.365024f,0.7836988f,-0.709897f,0.01381637f,0.02840478f,0.7035969f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 15.03432f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 23.93044f);
Get(0xDD1E).SetLocalPose(1.679365f,0.7686465f,1.352831f,0.9030991f,-0.2300503f,0.3581489f,-0.05672956f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44839f,1.365071f,0.7837906f,-0.7099049f,0.01380022f,0.02839558f,0.7035896f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 15.0913f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 23.94896f);
Get(0xDD1E).SetLocalPose(1.697038f,0.7721609f,1.357597f,0.8990456f,-0.2334107f,0.3657103f,-0.05909782f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448401f,1.365033f,0.7836723f,-0.7098852f,0.01378032f,0.02839733f,0.7036098f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 15.11752f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 23.95748f);
Get(0xDD1E).SetLocalPose(1.700506f,0.7726907f,1.358492f,0.8982905f,-0.2339837f,0.3670941f,-0.05973249f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448451f,1.365099f,0.7837585f,-0.7099004f,0.01380446f,0.02841678f,0.7035933f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 15.1765f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 23.97665f);
Get(0xDD1E).SetLocalPose(1.719853f,0.7771529f,1.36351f,0.8945425f,-0.2360497f,0.374226f,-0.06347784f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44854f,1.364923f,0.7838045f,-0.7099093f,0.01379938f,0.02840458f,0.7035848f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 15.2346f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 23.99553f);
Get(0xDD1E).SetLocalPose(1.736736f,0.78019f,1.366889f,0.8916164f,-0.2358674f,0.3807996f,-0.06617046f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448469f,1.365025f,0.7838624f,-0.7099255f,0.01379912f,0.02840591f,0.7035685f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 15.29116f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 24.01391f);
Get(0xDD1E).SetLocalPose(1.750606f,0.7837082f,1.369735f,0.8895641f,-0.2341364f,0.3864212f,-0.06733944f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448325f,1.36502f,0.7837968f,-0.7099226f,0.01377055f,0.02839265f,0.7035725f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 15.34773f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 24.0323f);
Get(0xDD1E).SetLocalPose(1.766373f,0.7882454f,1.372429f,0.8867458f,-0.2306592f,0.3948248f,-0.06776266f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448421f,1.364823f,0.783793f,-0.709911f,0.01377247f,0.02839215f,0.7035841f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 15.37436f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 24.04095f);
Get(0xDD1E).SetLocalPose(1.774639f,0.7903327f,1.3739f,0.8851488f,-0.2285605f,0.3995696f,-0.06794074f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448554f,1.36497f,0.7839823f,-0.7099316f,0.01379494f,0.02840197f,0.7035627f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 15.43569f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 24.06089f);
Get(0xDD1E).SetLocalPose(1.790177f,0.7939979f,1.375229f,0.8817416f,-0.2245102f,0.409153f,-0.06870772f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448559f,1.364882f,0.7839825f,-0.7099335f,0.01376569f,0.02839406f,0.7035615f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 15.49281f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 24.07945f);
Get(0xDD1E).SetLocalPose(1.801415f,0.795594f,1.376092f,0.8792376f,-0.2219189f,0.4156767f,-0.07004367f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448606f,1.365146f,0.7840691f,-0.7099345f,0.01379225f,0.02841152f,0.7035593f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 15.54884f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 24.09766f);
Get(0xDD1E).SetLocalPose(1.816007f,0.7973288f,1.375281f,0.8768329f,-0.2200167f,0.4214057f,-0.07193036f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448394f,1.365099f,0.7838317f,-0.7099142f,0.01378534f,0.0283928f,0.7035806f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 15.60638f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 24.11636f);
Get(0xDD1E).SetLocalPose(1.82954f,0.7972691f,1.37469f,0.8756661f,-0.2202534f,0.4234771f,-0.07324305f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448402f,1.36512f,0.783841f,-0.7099009f,0.01379326f,0.02840153f,0.7035936f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 15.63362f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 24.12521f);
Get(0xDD1E).SetLocalPose(1.835008f,0.7970715f,1.373891f,0.875538f,-0.2209198f,0.4233123f,-0.07371777f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44847f,1.365057f,0.783882f,-0.709929f,0.01375479f,0.02841593f,0.7035654f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 15.69293f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 24.14449f);
Get(0xDD1E).SetLocalPose(1.846391f,0.7963419f,1.372242f,0.8758693f,-0.2223676f,0.4217103f,-0.07460633f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448453f,1.365048f,0.7838251f,-0.7099166f,0.01377338f,0.02841935f,0.7035773f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 15.75277f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 24.16393f);
Get(0xDD1E).SetLocalPose(1.857954f,0.7959316f,1.369235f,0.8766776f,-0.2243863f,0.4187785f,-0.07557607f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448516f,1.36501f,0.7838269f,-0.709906f,0.01381012f,0.02839474f,0.7035883f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 15.78061f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 24.17298f);
Get(0xDD1E).SetLocalPose(1.86685f,0.7956444f,1.367017f,0.8774696f,-0.2257799f,0.4162287f,-0.07631739f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448411f,1.364947f,0.783785f,-0.7098968f,0.01380195f,0.02838308f,0.7035983f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 15.85055f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 24.19571f);
Get(0xDD1E).SetLocalPose(1.879931f,0.7947773f,1.363517f,0.8785318f,-0.2272999f,0.4129266f,-0.07751308f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448233f,1.364976f,0.7838299f,-0.7098985f,0.0138391f,0.02839053f,0.7035955f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 15.90547f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 24.21356f);
Get(0xDD1E).SetLocalPose(1.893587f,0.792723f,1.359836f,0.8793838f,-0.2281043f,0.410327f,-0.07927286f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448193f,1.364975f,0.7837064f,-0.7098992f,0.01383926f,0.02837147f,0.7035955f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 15.9616f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 24.2318f);
Get(0xDD1E).SetLocalPose(1.906124f,0.7910559f,1.3573f,0.8798134f,-0.2281991f,0.40907f,-0.08071727f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448264f,1.364878f,0.7838866f,-0.7099265f,0.01382751f,0.02837703f,0.703568f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 16.0171f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 24.24984f);
Get(0xDD1E).SetLocalPose(1.916804f,0.7898642f,1.355511f,0.8799403f,-0.2277733f,0.4089325f,-0.08123158f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448244f,1.36486f,0.7838735f,-0.7099186f,0.01381512f,0.02837847f,0.7035762f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 16.04421f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 24.25865f);
Get(0xDD1E).SetLocalPose(1.925244f,0.7893667f,1.354081f,0.8799759f,-0.2270494f,0.4092504f,-0.08127225f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448151f,1.36468f,0.7836549f,-0.7099157f,0.01384118f,0.02835709f,0.7035795f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 16.10427f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 24.27817f);
Get(0xDD1E).SetLocalPose(1.939699f,0.7882766f,1.352141f,0.8799773f,-0.2251695f,0.410388f,-0.08074871f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448139f,1.364706f,0.7835754f,-0.7098941f,0.01381329f,0.02837295f,0.7036012f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 16.16061f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 24.29648f);
Get(0xDD1E).SetLocalPose(1.95175f,0.7868373f,1.350729f,0.879996f,-0.2232965f,0.4115222f,-0.07997111f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448086f,1.364775f,0.7834899f,-0.7099005f,0.01382591f,0.02833699f,0.7035959f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 16.21773f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 24.31505f);
Get(0xDD1E).SetLocalPose(1.967698f,0.7831681f,1.347948f,0.880102f,-0.221019f,0.4127186f,-0.07895872f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447998f,1.364828f,0.7836463f,-0.7099108f,0.01384124f,0.02835887f,0.7035844f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 16.27325f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 24.33309f);
Get(0xDD1E).SetLocalPose(1.982263f,0.7801001f,1.345516f,0.8800271f,-0.2190064f,0.4141398f,-0.07795405f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447965f,1.364819f,0.783648f,-0.7099009f,0.01383117f,0.02836592f,0.7035942f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 16.29984f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 24.34173f);
Get(0xDD1E).SetLocalPose(1.990969f,0.7781923f,1.344301f,0.8798857f,-0.2178298f,0.4151808f,-0.0773063f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.447966f,1.364848f,0.7837037f,-0.7098857f,0.01383756f,0.02837439f,0.7036091f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 16.36208f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 24.36196f);
Get(0xDD1E).SetLocalPose(2.006766f,0.77509f,1.342075f,0.879608f,-0.2161043f,0.4169149f,-0.07596585f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448009f,1.3648f,0.7836925f,-0.7098891f,0.01381223f,0.02835128f,0.7036071f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 16.42092f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 24.38109f);
Get(0xDD1E).SetLocalPose(2.02394f,0.770373f,1.338328f,0.8791497f,-0.2143099f,0.4191143f,-0.07423126f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448287f,1.364936f,0.7839804f,-0.709906f,0.01383286f,0.02835359f,0.7035896f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 16.45402f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 24.39184f);
Get(0xDD1E).SetLocalPose(2.031611f,0.767862f,1.337243f,0.8788334f,-0.2133928f,0.4204295f,-0.07317419f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448408f,1.36501f,0.7840695f,-0.7099069f,0.0137765f,0.0283499f,0.70359f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 16.5218f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 24.41387f);
Get(0xDD1E).SetLocalPose(2.050668f,0.7619702f,1.334637f,0.8780447f,-0.2110095f,0.4237421f,-0.07039389f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448471f,1.364984f,0.7839899f,-0.7099143f,0.01376944f,0.02838566f,0.7035812f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 16.55399f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 24.42433f);
Get(0xDD1E).SetLocalPose(2.062834f,0.7589479f,1.33243f,0.8774491f,-0.209493f,0.4260334f,-0.06849276f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448358f,1.365137f,0.784018f,-0.7099289f,0.01380473f,0.02835834f,0.7035668f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 16.62382f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 24.44703f);
Get(0xDD1E).SetLocalPose(2.0814f,0.754752f,1.328523f,0.8762741f,-0.2073005f,0.429946f,-0.06570106f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448297f,1.365079f,0.783937f,-0.7099253f,0.01381872f,0.02837787f,0.7035694f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 16.65479f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 24.45709f);
Get(0xDD1E).SetLocalPose(2.094922f,0.7523423f,1.326039f,0.8752594f,-0.2056033f,0.4331082f,-0.0637611f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448369f,1.364951f,0.7838123f,-0.7099235f,0.01382716f,0.02836293f,0.7035716f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 16.73027f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 24.48162f);
Get(0xDD1E).SetLocalPose(2.116445f,0.7484689f,1.321213f,0.8733981f,-0.202361f,0.4387904f,-0.06073508f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448339f,1.365053f,0.7838637f,-0.7099286f,0.0137955f,0.02837939f,0.7035666f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 16.77553f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 24.49633f);
Get(0xDD1E).SetLocalPose(2.131824f,0.7461364f,1.318905f,0.8718163f,-0.2000089f,0.443279f,-0.05862273f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448341f,1.365044f,0.7839875f,-0.7099281f,0.01379019f,0.02836341f,0.7035677f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 16.81155f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 24.50804f);
Get(0xDD1E).SetLocalPose(2.145361f,0.7437282f,1.315923f,0.8698271f,-0.198658f,0.4479799f,-0.05700697f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448349f,1.365179f,0.7840108f,-0.7099126f,0.01381128f,0.02836966f,0.7035826f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 16.87359f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 24.5282f);
Get(0xDD1E).SetLocalPose(2.160362f,0.7430075f,1.312495f,0.8667737f,-0.1976426f,0.4544968f,-0.05543966f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448431f,1.36522f,0.784121f,-0.7099366f,0.01375895f,0.02839479f,0.7035584f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 16.92768f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 24.54578f);
Get(0xDD1E).SetLocalPose(2.182315f,0.7436547f,1.306696f,0.8612797f,-0.1966376f,0.4651909f,-0.05593002f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448604f,1.364906f,0.7840077f,-0.7099316f,0.01376133f,0.02841374f,0.7035627f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 16.98577f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 24.56466f);
Get(0xDD1E).SetLocalPose(2.206058f,0.7437043f,1.300515f,0.8551685f,-0.1950237f,0.4765129f,-0.05990127f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448652f,1.364929f,0.7840813f,-0.7099277f,0.01375634f,0.02840729f,0.703567f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 17.04092f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 24.58258f);
Get(0xDD1E).SetLocalPose(2.227544f,0.7451911f,1.294206f,0.8499835f,-0.1915598f,0.4862998f,-0.0659208f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448627f,1.365032f,0.7842305f,-0.7099459f,0.01377563f,0.0283916f,0.703549f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 17.06659f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 24.59093f);
Get(0xDD1E).SetLocalPose(2.237329f,0.7472203f,1.291606f,0.8479653f,-0.1893549f,0.4902047f,-0.06927401f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448552f,1.364973f,0.7841873f,-0.7099558f,0.01379754f,0.02838091f,0.7035389f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 17.12715f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 24.61061f);
Get(0xDD1E).SetLocalPose(2.261754f,0.751361f,1.282052f,0.8442093f,-0.1831357f,0.4974907f,-0.07921478f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448508f,1.365052f,0.7841395f,-0.7099476f,0.01381724f,0.02837873f,0.7035469f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 17.18444f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 24.62923f);
Get(0xDD1E).SetLocalPose(2.283496f,0.7561722f,1.273039f,0.8420851f,-0.176989f,0.5013499f,-0.09064198f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448479f,1.364946f,0.7840572f,-0.7099512f,0.01382156f,0.0283678f,0.7035437f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 17.2405f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 24.64745f);
Get(0xDD1E).SetLocalPose(2.306205f,0.7606336f,1.263407f,0.8412437f,-0.1709832f,0.5024401f,-0.1030905f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.4485f,1.36503f,0.7840698f,-0.7099504f,0.01382413f,0.02838407f,0.7035437f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 17.29574f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 24.6654f);
Get(0xDD1E).SetLocalPose(2.32822f,0.7656912f,1.253903f,0.8407419f,-0.1659188f,0.502341f,-0.115228f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448431f,1.364959f,0.7840688f,-0.7099516f,0.01382097f,0.02838648f,0.7035425f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 17.32542f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 24.67505f);
Get(0xDD1E).SetLocalPose(2.342263f,0.7692501f,1.24773f,0.8406129f,-0.1626117f,0.5016112f,-0.123748f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448393f,1.364937f,0.784046f,-0.7099398f,0.01381118f,0.02837582f,0.7035549f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 17.38412f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 24.69413f);
Get(0xDD1E).SetLocalPose(2.362931f,0.7742341f,1.237926f,0.8409967f,-0.1583146f,0.4991611f,-0.1360122f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448472f,1.364912f,0.7840946f,-0.7099413f,0.013807f,0.02840353f,0.7035525f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 17.44102f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 24.71262f);
Get(0xDD1E).SetLocalPose(2.385314f,0.779261f,1.225824f,0.8425021f,-0.1540165f,0.4944835f,-0.1481732f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448496f,1.364872f,0.7841091f,-0.7099529f,0.01381875f,0.0283932f,0.703541f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 17.49733f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 24.73092f);
Get(0xDD1E).SetLocalPose(2.409417f,0.7846f,1.214085f,0.8457108f,-0.1478112f,0.4870271f,-0.1604053f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448438f,1.364993f,0.7841506f,-0.709954f,0.01379664f,0.02839579f,0.7035401f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 17.55562f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 24.74987f);
Get(0xDD1E).SetLocalPose(2.436326f,0.7892978f,1.201674f,0.8500557f,-0.1395342f,0.4780351f,-0.1715171f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448426f,1.364965f,0.7841073f,-0.7099525f,0.0138164f,0.02842643f,0.7035401f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 17.58825f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 24.76047f);
Get(0xDD1E).SetLocalPose(2.451741f,0.7928913f,1.194628f,0.8529361f,-0.1337902f,0.4722562f,-0.177692f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448367f,1.364929f,0.7839029f,-0.7099389f,0.01380018f,0.02842236f,0.7035543f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 17.62293f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 24.77174f);
Get(0xDD1E).SetLocalPose(2.465658f,0.7950801f,1.187838f,0.8558782f,-0.1275668f,0.4662845f,-0.1837881f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448298f,1.364891f,0.7839044f,-0.7099295f,0.01381178f,0.02843747f,0.703563f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 17.69833f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 24.79625f);
Get(0xDD1E).SetLocalPose(2.493802f,0.8036034f,1.175945f,0.8613305f,-0.1148407f,0.4548897f,-0.1949276f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44842f,1.364949f,0.7840651f,-0.7099301f,0.01381347f,0.02841733f,0.703563f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 17.73555f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 24.80834f);
Get(0xDD1E).SetLocalPose(2.510197f,0.8075556f,1.169012f,0.8645217f,-0.1068313f,0.4476162f,-0.2020621f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448429f,1.365007f,0.7840368f,-0.7099293f,0.01382918f,0.02840967f,0.7035639f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 17.80847f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 24.83204f);
Get(0xDD1E).SetLocalPose(2.536356f,0.8125811f,1.157743f,0.8692025f,-0.09419058f,0.4355656f,-0.2142379f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448459f,1.365204f,0.7840638f,-0.7099195f,0.01381972f,0.02841868f,0.7035736f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 17.84038f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 24.84241f);
Get(0xDD1E).SetLocalPose(2.5514f,0.8169892f,1.151434f,0.8719462f,-0.08688774f,0.4276688f,-0.2219459f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448427f,1.365083f,0.7839664f,-0.7099095f,0.01384227f,0.02840217f,0.7035839f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 17.88245f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 24.85609f);
Get(0xDD1E).SetLocalPose(2.566437f,0.8193383f,1.145142f,0.8744197f,-0.08055083f,0.4199314f,-0.2292584f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448489f,1.365086f,0.7836296f,-0.7099077f,0.01382283f,0.02840221f,0.7035862f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 17.95174f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 24.87861f);
Get(0xDD1E).SetLocalPose(2.587412f,0.8251526f,1.137136f,0.8779306f,-0.07228689f,0.4082086f,-0.2395375f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448471f,1.365102f,0.7836217f,-0.7098892f,0.01382442f,0.02838938f,0.7036053f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 18.01388f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 24.8988f);
Get(0xDD1E).SetLocalPose(2.607916f,0.8299801f,1.130667f,0.881351f,-0.06579489f,0.3963649f,-0.2485688f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448379f,1.364906f,0.7835635f,-0.7098889f,0.01385491f,0.02838539f,0.7036051f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 18.06117f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 24.91417f);
Get(0xDD1E).SetLocalPose(2.624002f,0.8335305f,1.12698f,0.8842027f,-0.06151948f,0.3861966f,-0.2554468f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448316f,1.364809f,0.7834145f,-0.7098871f,0.01384015f,0.02840461f,0.7036064f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 18.10066f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 24.92701f);
Get(0xDD1E).SetLocalPose(2.634203f,0.835488f,1.124999f,0.8859626f,-0.05938764f,0.3798498f,-0.2593407f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448126f,1.364915f,0.7835015f,-0.7098914f,0.01385984f,0.02841489f,0.7036014f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 18.17122f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 24.94994f);
Get(0xDD1E).SetLocalPose(2.649442f,0.838186f,1.120438f,0.8883578f,-0.05698446f,0.3710233f,-0.2644146f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44822f,1.364846f,0.7835885f,-0.7098989f,0.01383715f,0.02838968f,0.7035951f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 18.19788f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 24.9586f);
Get(0xDD1E).SetLocalPose(2.65723f,0.8383502f,1.118971f,0.8893204f,-0.05626797f,0.3675267f,-0.2662091f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448223f,1.364914f,0.7836083f,-0.7099063f,0.0138407f,0.02839099f,0.7035876f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 18.26601f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 24.98075f);
Get(0xDD1E).SetLocalPose(2.672363f,0.8380063f,1.116605f,0.8910251f,-0.05617487f,0.361888f,-0.268246f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448128f,1.364878f,0.7837702f,-0.7099124f,0.01386716f,0.02837759f,0.7035815f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 18.2952f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 24.99023f);
Get(0xDD1E).SetLocalPose(2.680338f,0.836973f,1.115705f,0.891849f,-0.05724321f,0.3595959f,-0.2683644f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448158f,1.364901f,0.7838432f,-0.7099054f,0.01388293f,0.02837573f,0.7035882f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 18.33302f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 25.00252f);
Get(0xDD1E).SetLocalPose(2.687668f,0.8346703f,1.114826f,0.8926005f,-0.05948768f,0.3576937f,-0.2679197f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448179f,1.365084f,0.7840316f,-0.7099316f,0.01385084f,0.02837964f,0.7035624f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 18.38471f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 25.01932f);
Get(0xDD1E).SetLocalPose(2.699058f,0.8294781f,1.113903f,0.8940136f,-0.0655357f,0.3546399f,-0.2658481f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448498f,1.365087f,0.7841851f,-0.7099143f,0.01382492f,0.02842202f,0.7035786f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 18.46301f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 25.04477f);
Get(0xDD1E).SetLocalPose(2.709347f,0.8246456f,1.11435f,0.8958751f,-0.07403408f,0.3509815f,-0.2621809f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448491f,1.365155f,0.7841536f,-0.7099185f,0.01384512f,0.02841154f,0.7035744f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 18.52248f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 25.0641f);
Get(0xDD1E).SetLocalPose(2.718158f,0.8200405f,1.115578f,0.8980616f,-0.0834709f,0.3468562f,-0.2573107f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448361f,1.364893f,0.7838502f,-0.7099059f,0.01383085f,0.02840949f,0.7035875f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 18.58121f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 25.08319f);
Get(0xDD1E).SetLocalPose(2.725008f,0.8157009f,1.117128f,0.9004086f,-0.09285482f,0.3428755f,-0.2511547f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448388f,1.364956f,0.7838686f,-0.7099208f,0.01382483f,0.02838999f,0.7035733f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 18.60647f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 25.09139f);
Get(0xDD1E).SetLocalPose(2.729453f,0.81198f,1.118845f,0.9023749f,-0.1002999f,0.3399863f,-0.2450896f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448291f,1.364921f,0.7838156f,-0.7099201f,0.01383454f,0.02839211f,0.7035738f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 18.66732f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 25.11117f);
Get(0xDD1E).SetLocalPose(2.73539f,0.8059397f,1.123687f,0.9058668f,-0.1137284f,0.3353941f,-0.2323403f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.44837f,1.3649f,0.7837999f,-0.7099268f,0.01380797f,0.02836931f,0.7035685f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 18.72095f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 25.1286f);
Get(0xDD1E).SetLocalPose(2.73927f,0.8011215f,1.126803f,0.9085538f,-0.1258284f,0.3319765f,-0.2202019f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448402f,1.364898f,0.7838066f,-0.7099345f,0.01381547f,0.0283726f,0.7035605f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 18.77575f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 25.14641f);
Get(0xDD1E).SetLocalPose(2.743454f,0.7970021f,1.132124f,0.9114855f,-0.1420329f,0.3276016f,-0.204201f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448359f,1.364946f,0.7840542f,-0.7099445f,0.01381795f,0.02840545f,0.7035489f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 18.83379f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 25.16527f);
Get(0xDD1E).SetLocalPose(2.748206f,0.7969532f,1.139133f,0.9133083f,-0.1579133f,0.3239495f,-0.1897056f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448228f,1.365031f,0.7839871f,-0.709902f,0.01384551f,0.02840001f,0.7035914f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 18.86207f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 25.17446f);
Get(0xDD1E).SetLocalPose(2.75005f,0.7958365f,1.14358f,0.9139487f,-0.1681353f,0.3225232f,-0.1800201f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448198f,1.365076f,0.7838727f,-0.7099091f,0.01383085f,0.02836938f,0.7035857f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 18.92252f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 25.19411f);
Get(0xDD1E).SetLocalPose(2.753543f,0.7936815f,1.149734f,0.9142814f,-0.1790136f,0.322778f,-0.1669077f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448224f,1.365f,0.783715f,-0.7099109f,0.0138176f,0.02837613f,0.703584f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 18.97832f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 25.21225f);
Get(0xDD1E).SetLocalPose(2.758413f,0.7917149f,1.15946f,0.9134058f,-0.1896019f,0.3279806f,-0.1488948f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448274f,1.364981f,0.7836387f,-0.7099249f,0.01382038f,0.02838199f,0.7035696f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 19.01552f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 25.22434f);
Get(0xDD1E).SetLocalPose(2.76113f,0.7906649f,1.164179f,0.9125035f,-0.1931772f,0.3323838f,-0.139789f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448327f,1.364915f,0.7835616f,-0.7099275f,0.01379506f,0.02841258f,0.7035663f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 19.07538f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 25.24379f);
Get(0xDD1E).SetLocalPose(2.76695f,0.7908907f,1.17141f,0.9104148f,-0.1967487f,0.3408724f,-0.1274395f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448607f,1.36504f,0.7839172f,-0.709927f,0.01379928f,0.02840543f,0.703567f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 19.13222f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 25.26226f);
Get(0xDD1E).SetLocalPose(2.77249f,0.7921851f,1.178828f,0.9072526f,-0.2003268f,0.3501149f,-0.1190865f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448688f,1.36499f,0.7839789f,-0.7099428f,0.01378482f,0.02839676f,0.7035517f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 19.18524f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 25.2795f);
Get(0xDD1E).SetLocalPose(2.777584f,0.7939974f,1.183663f,0.904987f,-0.2040075f,0.3549477f,-0.1157219f);
});
r.Add(delegate{
Get(0xDCAE).SetLocalPose(2.448498f,1.364944f,0.7837852f,-0.709923f,0.01381583f,0.028397f,0.703571f);
Get(0xDCD4).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 19.24047f);
Get(0xDD06).GetComponent<Animator>().Play("New State", 0, 25.29745f);
Get(0xDD1E).SetLocalPose(2.782211f,0.7953653f,1.187633f,0.903641f,-0.2094304f,0.3556352f,-0.1144357f);
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

