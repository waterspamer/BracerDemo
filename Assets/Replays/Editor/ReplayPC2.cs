using System;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class ReplayPC2 : ReplayBase {
private List<Action> Execute() {
var r = new List<Action>();
r.Add(delegate{
Add(0x6E38, GameObject.Find("/Main Camera"));
Get(0x6E38).SetLocalPose(0.76f,2.04f,-10f,0f,0f,0f,1f);
Add(0x6E66, GameObject.Find("/BracerRight/HandPivot/HandRemasteredNew"));
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0f);
Add(0x6E70, GameObject.Find("/AltTrackingXr"));
Get(0x6E70).SetLocalPose(0f,0f,0f,0f,0f,0f,1f);
Add(0x6E82, GameObject.Find("/BracerLeft"));
Get(0x6E82).SetLocalPose(0.4637f,0.2682f,0.2255f,0.2515312f,0.1271264f,-0.720364f,-0.6337562f);
Add(0x6E9E, GameObject.Find("/BracerLeft/HandPivot/HandRemasteredNew"));
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0f);
Add(0x6EC6, GameObject.Find("/BracerRight"));
Get(0x6EC6).SetLocalPose(0.505f,0.2564f,-0.0477f,0.1714998f,0.7059368f,0.6859936f,0.04066779f);
});
return r;
}
private List<Action> Execute0() {
var r = new List<Action>();
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0f);
Get(0x6E82).SetLocalPose(0.1126788f,1.116412f,-0.5266275f,0.6196892f,-0.5027698f,-0.2327198f,-0.555922f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.02f);
Get(0x6E70).SetLocalPose(0.01572876f,1.564315f,-0.5208267f,0.4436257f,-0.1874287f,-0.7732885f,0.4124217f);
Get(0x6E82).SetLocalPose(0.1135134f,1.117108f,-0.5262794f,0.620892f,-0.5011806f,-0.2318778f,-0.5563666f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.02f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.02f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.02f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.02f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.02f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.02f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.02f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.02f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.02f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.02f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.02f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.02f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.02f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.02f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.02f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.02f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.02f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.02f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.02f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.02f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.02f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.02f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.02f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.02f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.02f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.02f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.02f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.02f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.02f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.02f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.02f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095299f,1.309035f,0.1329797f,-0.7030719f,-0.01440615f,-0.009664149f,0.7109072f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.3533334f);
Get(0x6E70).SetLocalPose(0.07432026f,1.596771f,-0.5834146f,0.3388645f,-0.1739597f,-0.7698402f,0.5121084f);
Get(0x6E82).SetLocalPose(0.08132137f,1.170478f,-0.3917586f,0.4447387f,0.1299513f,-0.3713638f,-0.8046174f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.3533334f);
Get(0x6EC6).SetLocalPose(0.3552304f,1.16904f,-0.5992533f,-0.3752441f,-0.6851794f,-0.6241432f,0.0128994f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.3533334f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.3533334f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.3533334f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.3533334f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.3533334f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.3533334f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095356f,1.309683f,0.1330827f,-0.7030753f,-0.01442556f,-0.009666998f,0.7109033f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.4324698f);
Get(0x6E70).SetLocalPose(0.07747357f,1.600279f,-0.5842077f,0.3197494f,-0.1656823f,-0.7697522f,0.527059f);
Get(0x6E82).SetLocalPose(0.07434265f,1.176747f,-0.3855711f,0.4746748f,0.1111644f,-0.3593397f,-0.7957395f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.4324698f);
Get(0x6EC6).SetLocalPose(0.357572f,1.176111f,-0.5978667f,-0.3431926f,-0.699173f,-0.6243883f,0.05928854f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.4324698f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.4324698f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095083f,1.30946f,0.1327311f,-0.7030661f,-0.01444846f,-0.009669455f,0.710912f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.472728f);
Get(0x6E70).SetLocalPose(0.07872523f,1.602396f,-0.58362f,0.3088225f,-0.1625722f,-0.7690576f,0.5354897f);
Get(0x6E82).SetLocalPose(0.07176749f,1.179157f,-0.3820121f,0.4869391f,0.09577819f,-0.3580232f,-0.7909085f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.472728f);
Get(0x6EC6).SetLocalPose(0.3550884f,1.178539f,-0.5948271f,-0.3011858f,-0.7100727f,-0.6274641f,0.1066437f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095068f,1.309479f,0.1327148f,-0.7030594f,-0.01444058f,-0.009672551f,0.7109187f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.4845532f);
Get(0x6E70).SetLocalPose(0.07886645f,1.602618f,-0.5835781f,0.3075294f,-0.1623128f,-0.7689916f,0.5364068f);
Get(0x6E82).SetLocalPose(0.07152405f,1.179384f,-0.381155f,0.4894277f,0.09224257f,-0.3572714f,-0.7901323f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.4845532f);
Get(0x6EC6).SetLocalPose(0.3545059f,1.178868f,-0.5940972f,-0.2923393f,-0.7109237f,-0.6293344f,0.1142956f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095666f,1.309327f,0.1327046f,-0.7030699f,-0.01448392f,-0.009617649f,0.7109082f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.5060433f);
Get(0x6E70).SetLocalPose(0.07919635f,1.603647f,-0.5830402f,0.3027762f,-0.1618352f,-0.7688159f,0.539498f);
Get(0x6E82).SetLocalPose(0.07109097f,1.179836f,-0.379327f,0.4965673f,0.08611074f,-0.3531193f,-0.7882339f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.5060433f);
Get(0x6EC6).SetLocalPose(0.3529208f,1.179262f,-0.5916433f,-0.2748475f,-0.7102604f,-0.6352661f,0.1281642f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.5060433f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.5060433f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095755f,1.309716f,0.1329295f,-0.7030745f,-0.01447921f,-0.009601328f,0.7109039f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.5587915f);
Get(0x6E70).SetLocalPose(0.0790667f,1.605243f,-0.5818253f,0.2967771f,-0.1622794f,-0.7692304f,0.5421009f);
Get(0x6E82).SetLocalPose(0.07029425f,1.176948f,-0.3738461f,0.4897543f,0.08768982f,-0.3542751f,-0.7917958f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.5587915f);
Get(0x6EC6).SetLocalPose(0.3456624f,1.178998f,-0.5856735f,-0.2136906f,-0.710507f,-0.6464312f,0.1778844f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095456f,1.309602f,0.1327459f,-0.7030646f,-0.01444655f,-0.009631293f,0.7109141f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.5789669f);
Get(0x6E70).SetLocalPose(0.07855763f,1.605663f,-0.5808958f,0.2952611f,-0.1626862f,-0.7700531f,0.5416385f);
Get(0x6E82).SetLocalPose(0.06975199f,1.175292f,-0.3703997f,0.4619232f,0.1026065f,-0.3670205f,-0.8008714f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.5789669f);
Get(0x6EC6).SetLocalPose(0.342487f,1.177761f,-0.5832292f,-0.1840575f,-0.7093248f,-0.6509731f,0.1980284f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09529f,1.309644f,0.1327181f,-0.7030626f,-0.01445317f,-0.009661783f,0.7109154f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.5901213f);
Get(0x6E70).SetLocalPose(0.07820422f,1.60565f,-0.5807137f,0.2948875f,-0.1628439f,-0.7704565f,0.5412209f);
Get(0x6E82).SetLocalPose(0.06945107f,1.173834f,-0.3685302f,0.4403048f,0.1136474f,-0.3773515f,-0.8067352f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.5901213f);
Get(0x6EC6).SetLocalPose(0.3409115f,1.177255f,-0.5820854f,-0.1708234f,-0.7073281f,-0.6541488f,0.2063873f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095429f,1.309578f,0.1327692f,-0.703071f,-0.01448873f,-0.009663262f,0.7109064f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.6131157f);
Get(0x6E70).SetLocalPose(0.07784821f,1.605991f,-0.5801917f,0.2944883f,-0.1633184f,-0.7712094f,0.5402222f);
Get(0x6E82).SetLocalPose(0.06961627f,1.170354f,-0.3650762f,0.3988524f,0.1319796f,-0.3982058f,-0.8154326f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.6131157f);
Get(0x6EC6).SetLocalPose(0.3390269f,1.175147f,-0.5805464f,-0.1530679f,-0.7030853f,-0.6592099f,0.2183659f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095455f,1.309492f,0.132866f,-0.703069f,-0.01445765f,-0.009660759f,0.7109091f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.6225266f);
Get(0x6E70).SetLocalPose(0.07744898f,1.606043f,-0.5798002f,0.2943927f,-0.1636953f,-0.7714974f,0.5397485f);
Get(0x6E82).SetLocalPose(0.07004524f,1.168727f,-0.3632434f,0.3784897f,0.1383557f,-0.4087122f,-0.8188758f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.6225266f);
Get(0x6EC6).SetLocalPose(0.3372546f,1.173925f,-0.5792053f,-0.1387004f,-0.6997916f,-0.6625909f,0.2280951f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095289f,1.309869f,0.1329732f,-0.7030646f,-0.01450745f,-0.009655819f,0.7109125f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.6483833f);
Get(0x6E70).SetLocalPose(0.0757098f,1.605647f,-0.5783719f,0.2946626f,-0.1648633f,-0.7718776f,0.5387012f);
Get(0x6E82).SetLocalPose(0.07241441f,1.166149f,-0.3609398f,0.3414001f,0.1415145f,-0.4296351f,-0.8239135f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.6483833f);
Get(0x6EC6).SetLocalPose(0.3330469f,1.171461f,-0.5775114f,-0.1087597f,-0.6949403f,-0.6656315f,0.2493273f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095423f,1.309907f,0.1332482f,-0.7030802f,-0.01448313f,-0.009659937f,0.7108974f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.670837f);
Get(0x6E70).SetLocalPose(0.07491522f,1.605073f,-0.57766f,0.295139f,-0.1657814f,-0.771839f,0.5382138f);
Get(0x6E82).SetLocalPose(0.074674f,1.165973f,-0.3619159f,0.3442414f,0.1310069f,-0.4290236f,-0.8247872f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.670837f);
Get(0x6EC6).SetLocalPose(0.3302498f,1.169656f,-0.5763479f,-0.09058348f,-0.6927039f,-0.6660712f,0.2613526f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.670837f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.670837f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095291f,1.309485f,0.1329307f,-0.7030703f,-0.01449312f,-0.009617282f,0.7109076f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.7177663f);
Get(0x6E70).SetLocalPose(0.0722231f,1.606402f,-0.5757456f,0.2969047f,-0.1691066f,-0.770596f,0.5379893f);
Get(0x6E82).SetLocalPose(0.08410227f,1.170304f,-0.3702847f,0.4006064f,0.07544404f,-0.4036079f,-0.8190992f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.7177663f);
Get(0x6EC6).SetLocalPose(0.3258672f,1.16697f,-0.5752246f,-0.07152084f,-0.6886317f,-0.6680474f,0.272734f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095392f,1.309451f,0.1327982f,-0.7030734f,-0.01450831f,-0.009644428f,0.7109039f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.7378187f);
Get(0x6E70).SetLocalPose(0.07088342f,1.606679f,-0.5747995f,0.2981331f,-0.1709245f,-0.7695611f,0.5382168f);
Get(0x6E82).SetLocalPose(0.08981002f,1.174019f,-0.376058f,0.4397436f,0.03536769f,-0.3862529f,-0.8100515f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.7378187f);
Get(0x6EC6).SetLocalPose(0.3236023f,1.165059f,-0.5748566f,-0.06397547f,-0.6878391f,-0.6678162f,0.277139f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095516f,1.309642f,0.1328814f,-0.703064f,-0.01450128f,-0.00962208f,0.7109137f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.7495847f);
Get(0x6E70).SetLocalPose(0.06993531f,1.606454f,-0.5746167f,0.2987843f,-0.1718801f,-0.7689968f,0.5383579f);
Get(0x6E82).SetLocalPose(0.09425509f,1.176411f,-0.3815277f,0.4751502f,0.001949723f,-0.3685113f,-0.7990169f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.7495847f);
Get(0x6EC6).SetLocalPose(0.3221979f,1.164119f,-0.5746454f,-0.05828146f,-0.6877517f,-0.6669098f,0.2807707f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095411f,1.309475f,0.1328503f,-0.7030675f,-0.01448809f,-0.009643765f,0.7109101f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.7718756f);
Get(0x6E70).SetLocalPose(0.06830312f,1.606736f,-0.5737042f,0.3004672f,-0.1739713f,-0.7677798f,0.5384865f);
Get(0x6E82).SetLocalPose(0.1011738f,1.178267f,-0.3902206f,0.5316293f,-0.05160324f,-0.3367142f,-0.7754553f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.7718756f);
Get(0x6EC6).SetLocalPose(0.3202288f,1.162709f,-0.5741768f,-0.05272333f,-0.6880305f,-0.6655839f,0.2843105f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095719f,1.309505f,0.1329405f,-0.703069f,-0.01447203f,-0.009614501f,0.7109094f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.7951984f);
Get(0x6E70).SetLocalPose(0.0664564f,1.60697f,-0.5727035f,0.3031895f,-0.1767938f,-0.7661918f,0.5383032f);
Get(0x6E82).SetLocalPose(0.1087445f,1.179246f,-0.4012728f,0.5974514f,-0.1148742f,-0.2949405f,-0.7367944f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.7951984f);
Get(0x6EC6).SetLocalPose(0.3183733f,1.161417f,-0.573758f,-0.0502782f,-0.6884804f,-0.6650494f,0.2849145f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095844f,1.309529f,0.1330813f,-0.7030963f,-0.01451148f,-0.009603935f,0.7108817f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.8058782f);
Get(0x6E70).SetLocalPose(0.06542327f,1.607183f,-0.5723919f,0.3049713f,-0.1786823f,-0.7652181f,0.538058f);
Get(0x6E82).SetLocalPose(0.1131674f,1.178028f,-0.4081293f,0.6323636f,-0.1504357f,-0.2701032f,-0.7103026f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.8058782f);
Get(0x6EC6).SetLocalPose(0.3172296f,1.160726f,-0.5734501f,-0.04797693f,-0.6888117f,-0.6643106f,0.2862309f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095615f,1.309792f,0.1330742f,-0.7030547f,-0.01448011f,-0.009627778f,0.7109233f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.8271011f);
Get(0x6E70).SetLocalPose(0.06328827f,1.607934f,-0.5712896f,0.3078225f,-0.1819719f,-0.7638519f,0.5372726f);
Get(0x6E82).SetLocalPose(0.1209919f,1.173333f,-0.4210086f,0.6895836f,-0.2176641f,-0.2253729f,-0.6529195f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.8271011f);
Get(0x6EC6).SetLocalPose(0.3159106f,1.159055f,-0.5733794f,-0.04523474f,-0.6893378f,-0.6634167f,0.2874812f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095203f,1.309834f,0.1327069f,-0.7030535f,-0.01445051f,-0.00967754f,0.7109243f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.8589045f);
Get(0x6E70).SetLocalPose(0.06021193f,1.608879f,-0.5692869f,0.312009f,-0.1867696f,-0.7622658f,0.535461f);
Get(0x6E82).SetLocalPose(0.1310128f,1.163112f,-0.4355101f,0.7428809f,-0.3040201f,-0.1726478f,-0.57087f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.8589045f);
Get(0x6EC6).SetLocalPose(0.3134771f,1.156536f,-0.5730544f,-0.0390947f,-0.6918852f,-0.6601103f,0.2898637f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095074f,1.309863f,0.1327398f,-0.7030327f,-0.01445064f,-0.009644778f,0.7109454f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.8705751f);
Get(0x6E70).SetLocalPose(0.05918774f,1.609315f,-0.568372f,0.3133953f,-0.1884286f,-0.7618527f,0.5346574f);
Get(0x6E82).SetLocalPose(0.1333743f,1.159241f,-0.4395805f,0.7545179f,-0.3292057f,-0.1573396f,-0.5455005f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.8705751f);
Get(0x6EC6).SetLocalPose(0.3127849f,1.155682f,-0.5731064f,-0.03666193f,-0.6935186f,-0.6583751f,0.2902244f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095268f,1.30956f,0.1329191f,-0.7030507f,-0.01447629f,-0.009664513f,0.7109268f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.8958856f);
Get(0x6E70).SetLocalPose(0.05770442f,1.609853f,-0.5668885f,0.3156092f,-0.1912779f,-0.7613397f,0.5330719f);
Get(0x6E82).SetLocalPose(0.1382176f,1.15275f,-0.4464729f,0.7662301f,-0.3678121f,-0.138814f,-0.5082681f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.8958856f);
Get(0x6EC6).SetLocalPose(0.3113796f,1.154489f,-0.5733811f,-0.0324259f,-0.6958583f,-0.6556233f,0.2913551f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095137f,1.309395f,0.1332258f,-0.7030654f,-0.01445386f,-0.009685991f,0.7109123f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.9057396f);
Get(0x6E70).SetLocalPose(0.05730179f,1.609932f,-0.5665193f,0.3161385f,-0.1919511f,-0.7612797f,0.5326017f);
Get(0x6E82).SetLocalPose(0.1402961f,1.150365f,-0.448482f,0.7663853f,-0.3829288f,-0.1354367f,-0.4976707f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.9057396f);
Get(0x6EC6).SetLocalPose(0.3109249f,1.154161f,-0.5729957f,-0.03013719f,-0.6963426f,-0.6547599f,0.2923839f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095056f,1.309144f,0.1330159f,-0.7030777f,-0.01446458f,-0.00968538f,0.7108999f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.9391955f);
Get(0x6E70).SetLocalPose(0.05512173f,1.609894f,-0.5650107f,0.3190735f,-0.1948479f,-0.7614734f,0.5295135f);
Get(0x6E82).SetLocalPose(0.1449684f,1.146028f,-0.4523761f,0.7605168f,-0.4119734f,-0.1338765f,-0.4837037f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.9391955f);
Get(0x6EC6).SetLocalPose(0.3091964f,1.154134f,-0.5717688f,-0.02490845f,-0.695476f,-0.6554996f,0.2932796f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094947f,1.308965f,0.1329637f,-0.7030777f,-0.01443314f,-0.009722439f,0.7109001f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.9501883f);
Get(0x6E70).SetLocalPose(0.05468227f,1.609623f,-0.5643384f,0.3198205f,-0.1952819f,-0.7617014f,0.5285743f);
Get(0x6E82).SetLocalPose(0.1460298f,1.145529f,-0.4536455f,0.7597503f,-0.4183876f,-0.1327639f,-0.4796927f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.9501883f);
Get(0x6EC6).SetLocalPose(0.3087295f,1.154032f,-0.5715013f,-0.02304232f,-0.6950101f,-0.6560071f,0.2934019f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094919f,1.309047f,0.1327256f,-0.7030636f,-0.01444426f,-0.009723531f,0.7109138f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.9748604f);
Get(0x6E70).SetLocalPose(0.05422239f,1.608625f,-0.5634049f,0.3207984f,-0.1955755f,-0.7625294f,0.526676f);
Get(0x6E82).SetLocalPose(0.149186f,1.144758f,-0.4566567f,0.7602796f,-0.4323556f,-0.1296632f,-0.4671522f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.9748604f);
Get(0x6EC6).SetLocalPose(0.3077055f,1.153016f,-0.5709852f,-0.01972914f,-0.6947571f,-0.6557946f,0.294715f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.9748604f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.9748604f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095188f,1.3093f,0.1328598f,-0.7030641f,-0.01449929f,-0.009713707f,0.7109124f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.009167f);
Get(0x6E70).SetLocalPose(0.05376151f,1.607288f,-0.5618146f,0.3219714f,-0.1949348f,-0.7645504f,0.5232565f);
Get(0x6E82).SetLocalPose(0.151989f,1.144911f,-0.457043f,0.7628191f,-0.4439302f,-0.1275793f,-0.4525001f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.009167f);
Get(0x6EC6).SetLocalPose(0.3066205f,1.151929f,-0.570619f,-0.01581664f,-0.6941032f,-0.6552091f,0.2977777f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095523f,1.309717f,0.1329005f,-0.7030752f,-0.01447232f,-0.009691573f,0.7109022f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.039455f);
Get(0x6E70).SetLocalPose(0.05371182f,1.605809f,-0.5607652f,0.3228479f,-0.1938642f,-0.7663521f,0.5204714f);
Get(0x6E82).SetLocalPose(0.154603f,1.145813f,-0.4570872f,0.7620603f,-0.4479362f,-0.1290579f,-0.4494012f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.039455f);
Get(0x6EC6).SetLocalPose(0.306178f,1.152035f,-0.5708045f,-0.01418519f,-0.6929488f,-0.65581f,0.2992225f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095651f,1.30985f,0.1328382f,-0.703074f,-0.01448214f,-0.009673079f,0.7109034f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.057906f);
Get(0x6E70).SetLocalPose(0.05386262f,1.605269f,-0.5600109f,0.3232441f,-0.1932209f,-0.7673644f,0.518971f);
Get(0x6E82).SetLocalPose(0.1563123f,1.146148f,-0.4570638f,0.7615773f,-0.4498806f,-0.1302724f,-0.4479248f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.057906f);
Get(0x6EC6).SetLocalPose(0.3062256f,1.151603f,-0.5707487f,-0.01369057f,-0.6916013f,-0.6569533f,0.2998545f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095603f,1.30943f,0.1330697f,-0.7030834f,-0.01448138f,-0.009658997f,0.7108943f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.076391f);
Get(0x6E70).SetLocalPose(0.05394142f,1.605405f,-0.5592059f,0.3235856f,-0.1926039f,-0.7682686f,0.5176479f);
Get(0x6E82).SetLocalPose(0.1584401f,1.147188f,-0.4571189f,0.7621861f,-0.4519785f,-0.1305781f,-0.4446764f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.076391f);
Get(0x6EC6).SetLocalPose(0.3063358f,1.150987f,-0.5707191f,-0.01355417f,-0.6905332f,-0.6575302f,0.3010555f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09559f,1.309615f,0.1330688f,-0.7030734f,-0.01451792f,-0.009660465f,0.7109035f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.094428f);
Get(0x6E70).SetLocalPose(0.05402559f,1.605208f,-0.558494f,0.3239601f,-0.1920713f,-0.7691377f,0.5163192f);
Get(0x6E82).SetLocalPose(0.1600467f,1.147953f,-0.4573084f,0.7634025f,-0.4535964f,-0.1305854f,-0.4409246f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.094428f);
Get(0x6EC6).SetLocalPose(0.3064052f,1.15028f,-0.5709664f,-0.01356454f,-0.6896592f,-0.6579515f,0.3021361f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095946f,1.309397f,0.1330403f,-0.7030724f,-0.01450357f,-0.009625748f,0.7109052f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.112411f);
Get(0x6E70).SetLocalPose(0.05431785f,1.604677f,-0.5580437f,0.3241451f,-0.1917406f,-0.7696859f,0.5155087f);
Get(0x6E82).SetLocalPose(0.1609749f,1.148917f,-0.45765f,0.7642161f,-0.454334f,-0.1307336f,-0.4387062f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.112411f);
Get(0x6EC6).SetLocalPose(0.3066935f,1.149534f,-0.5711387f,-0.01356968f,-0.68835f,-0.6584076f,0.3041209f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095824f,1.309796f,0.133149f,-0.703076f,-0.01451382f,-0.009602046f,0.7109017f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.130977f);
Get(0x6E70).SetLocalPose(0.05434364f,1.604376f,-0.557602f,0.3242369f,-0.1916472f,-0.7701372f,0.5148111f);
Get(0x6E82).SetLocalPose(0.1623848f,1.149711f,-0.4579695f,0.7640635f,-0.4549791f,-0.131484f,-0.4380788f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.130977f);
Get(0x6EC6).SetLocalPose(0.3069521f,1.148933f,-0.5713763f,-0.01364667f,-0.6862788f,-0.6598843f,0.3055944f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.130977f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.130977f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095755f,1.309899f,0.1328709f,-0.7030627f,-0.01453469f,-0.0095814f,0.7109149f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.172559f);
Get(0x6E70).SetLocalPose(0.05485865f,1.605321f,-0.5573091f,0.3240781f,-0.1923723f,-0.770456f,0.5141631f);
Get(0x6E82).SetLocalPose(0.1653642f,1.150312f,-0.4593551f,0.7628415f,-0.4566379f,-0.1330892f,-0.4379978f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.172559f);
Get(0x6EC6).SetLocalPose(0.3071081f,1.147873f,-0.5727261f,-0.01407925f,-0.6818937f,-0.6632564f,0.3080807f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095712f,1.309906f,0.1330236f,-0.7030806f,-0.01451559f,-0.009578451f,0.7108976f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.19176f);
Get(0x6E70).SetLocalPose(0.0549668f,1.605099f,-0.5571675f,0.3236746f,-0.1929606f,-0.7706013f,0.5139792f);
Get(0x6E82).SetLocalPose(0.1663215f,1.150047f,-0.4599783f,0.7629319f,-0.4572347f,-0.1331875f,-0.437187f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.19176f);
Get(0x6EC6).SetLocalPose(0.3071345f,1.147102f,-0.5733889f,-0.01426009f,-0.6812084f,-0.6635408f,0.3089749f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095742f,1.30983f,0.1329288f,-0.7030665f,-0.01451027f,-0.009583744f,0.7109115f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.218774f);
Get(0x6E70).SetLocalPose(0.05523939f,1.605648f,-0.5569966f,0.3230062f,-0.1935554f,-0.7709653f,0.5136302f);
Get(0x6E82).SetLocalPose(0.1678261f,1.149399f,-0.4611983f,0.7625202f,-0.4598868f,-0.1322048f,-0.4354183f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.218774f);
Get(0x6EC6).SetLocalPose(0.3072843f,1.146328f,-0.5746545f,-0.01432235f,-0.6803197f,-0.6636369f,0.3107186f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095854f,1.309311f,0.1327188f,-0.7030748f,-0.01449485f,-0.009573262f,0.7109038f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.237505f);
Get(0x6E70).SetLocalPose(0.05525462f,1.60576f,-0.5570031f,0.3223391f,-0.1938148f,-0.7711859f,0.5136201f);
Get(0x6E82).SetLocalPose(0.1690474f,1.148531f,-0.4614721f,0.7618693f,-0.4618689f,-0.131097f,-0.434794f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.237505f);
Get(0x6EC6).SetLocalPose(0.307706f,1.146119f,-0.5756323f,-0.01369763f,-0.6788378f,-0.6645953f,0.3119372f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095908f,1.309525f,0.1328654f,-0.7030765f,-0.01449895f,-0.009603426f,0.7109016f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.25688f);
Get(0x6E70).SetLocalPose(0.05570886f,1.606587f,-0.5573708f,0.3215882f,-0.1937396f,-0.7712815f,0.5139756f);
Get(0x6E82).SetLocalPose(0.1702529f,1.147601f,-0.4615732f,0.7608803f,-0.4634488f,-0.1302584f,-0.4350965f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.25688f);
Get(0x6EC6).SetLocalPose(0.3081366f,1.145922f,-0.5764949f,-0.01278708f,-0.6773547f,-0.6653317f,0.3136255f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.096027f,1.309714f,0.132864f,-0.7030829f,-0.01454586f,-0.009558424f,0.7108949f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.276217f);
Get(0x6E70).SetLocalPose(0.05622257f,1.607049f,-0.5574819f,0.3204963f,-0.1933892f,-0.7712883f,0.5147788f);
Get(0x6E82).SetLocalPose(0.1711618f,1.146459f,-0.4612898f,0.7602835f,-0.4645426f,-0.1291131f,-0.4353149f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.276217f);
Get(0x6EC6).SetLocalPose(0.3093927f,1.146108f,-0.5773031f,-0.01329627f,-0.6767754f,-0.6653444f,0.3148258f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095886f,1.309752f,0.1328593f,-0.7030777f,-0.01455867f,-0.009562967f,0.7108998f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.284544f);
Get(0x6E70).SetLocalPose(0.05659752f,1.607443f,-0.5576972f,0.3195122f,-0.1929195f,-0.7712733f,0.5155885f);
Get(0x6E82).SetLocalPose(0.1717006f,1.145847f,-0.4612573f,0.7599745f,-0.4653377f,-0.1281275f,-0.4352966f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.284544f);
Get(0x6EC6).SetLocalPose(0.3102778f,1.145897f,-0.578018f,-0.01404721f,-0.676335f,-0.6653486f,0.3157292f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095837f,1.30987f,0.1329101f,-0.7030627f,-0.01455728f,-0.009568495f,0.7109146f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.318952f);
Get(0x6E70).SetLocalPose(0.05830199f,1.608399f,-0.5586427f,0.3144245f,-0.1897851f,-0.7712308f,0.5199249f);
Get(0x6E82).SetLocalPose(0.1731242f,1.145263f,-0.4607157f,0.7584059f,-0.4676266f,-0.1248211f,-0.4365382f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.318952f);
Get(0x6EC6).SetLocalPose(0.3139649f,1.146245f,-0.5791106f,-0.01579197f,-0.6736469f,-0.6652607f,0.3215256f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095818f,1.309531f,0.1329002f,-0.7030888f,-0.01451628f,-0.009603086f,0.710889f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.339777f);
Get(0x6E70).SetLocalPose(0.06001572f,1.608451f,-0.5587991f,0.3094123f,-0.1859226f,-0.771022f,0.5246158f);
Get(0x6E82).SetLocalPose(0.1738064f,1.144709f,-0.4602193f,0.7566572f,-0.4682013f,-0.1234353f,-0.4393417f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.339777f);
Get(0x6EC6).SetLocalPose(0.31838f,1.147191f,-0.5802175f,-0.02008522f,-0.671562f,-0.6650987f,0.3259523f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095466f,1.309659f,0.1328607f,-0.7030728f,-0.01450074f,-0.009608331f,0.7109051f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.359247f);
Get(0x6E70).SetLocalPose(0.0624557f,1.608792f,-0.5594096f,0.3036557f,-0.1807801f,-0.7706422f,0.5303041f);
Get(0x6E82).SetLocalPose(0.1742564f,1.144296f,-0.459401f,0.7558367f,-0.4676208f,-0.1209608f,-0.4420523f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.359247f);
Get(0x6EC6).SetLocalPose(0.3244766f,1.148757f,-0.5817082f,-0.02728673f,-0.6696424f,-0.6635727f,0.3324242f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095711f,1.309616f,0.1328997f,-0.7030761f,-0.01449131f,-0.009633497f,0.7109017f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.378576f);
Get(0x6E70).SetLocalPose(0.06574221f,1.608084f,-0.5605514f,0.2959703f,-0.1733446f,-0.7701631f,0.5377751f);
Get(0x6E82).SetLocalPose(0.1746301f,1.144168f,-0.4574351f,0.7563862f,-0.4664617f,-0.1171209f,-0.443369f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.378576f);
Get(0x6EC6).SetLocalPose(0.3337418f,1.151319f,-0.5837284f,-0.03954539f,-0.6666109f,-0.6615325f,0.3412343f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095618f,1.309463f,0.1327681f,-0.7030609f,-0.01448688f,-0.009638742f,0.7109168f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.397735f);
Get(0x6E70).SetLocalPose(0.06980868f,1.60808f,-0.5620207f,0.2871676f,-0.1642379f,-0.7698238f,0.5458316f);
Get(0x6E82).SetLocalPose(0.1751192f,1.144041f,-0.4549282f,0.756227f,-0.4653477f,-0.1133032f,-0.4457966f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.397735f);
Get(0x6EC6).SetLocalPose(0.3447304f,1.154887f,-0.5861372f,-0.05456279f,-0.6622335f,-0.6592569f,0.3519236f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095716f,1.309176f,0.1328695f,-0.7030935f,-0.01448435f,-0.009663062f,0.7108843f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.416529f);
Get(0x6E70).SetLocalPose(0.07357389f,1.609088f,-0.5633503f,0.2782739f,-0.1549224f,-0.7696632f,0.5533365f);
Get(0x6E82).SetLocalPose(0.1756956f,1.144659f,-0.4512044f,0.7557389f,-0.4633894f,-0.1097206f,-0.4495447f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.416529f);
Get(0x6EC6).SetLocalPose(0.359455f,1.159025f,-0.5900102f,-0.07538207f,-0.6555684f,-0.6559164f,0.3664988f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095568f,1.309585f,0.1328246f,-0.703099f,-0.01448883f,-0.00965328f,0.7108789f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.435843f);
Get(0x6E70).SetLocalPose(0.07743713f,1.609517f,-0.5649353f,0.2674286f,-0.1437845f,-0.7696669f,0.5616234f);
Get(0x6E82).SetLocalPose(0.1767059f,1.146737f,-0.4456441f,0.7574691f,-0.4560228f,-0.1080695f,-0.454538f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.435843f);
Get(0x6EC6).SetLocalPose(0.3751314f,1.163697f,-0.5958183f,-0.09748293f,-0.649994f,-0.6506181f,0.3803959f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.435843f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.435843f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095352f,1.309378f,0.1327328f,-0.7030711f,-0.01448542f,-0.00965825f,0.7109065f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.469392f);
Get(0x6E70).SetLocalPose(0.08508365f,1.610559f,-0.5689838f,0.2467521f,-0.1228498f,-0.77009f,0.5753111f);
Get(0x6E82).SetLocalPose(0.1764596f,1.154225f,-0.4328436f,0.7760492f,-0.4193755f,-0.107158f,-0.4586818f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.469392f);
Get(0x6EC6).SetLocalPose(0.4106374f,1.176907f,-0.6141509f,-0.1447018f,-0.6433516f,-0.6265639f,0.415425f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094913f,1.309409f,0.1327238f,-0.7030719f,-0.01442785f,-0.009708615f,0.7109062f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.493178f);
Get(0x6E70).SetLocalPose(0.08816811f,1.611519f,-0.5706917f,0.2374979f,-0.1136471f,-0.7703571f,0.5807143f);
Get(0x6E82).SetLocalPose(0.1758644f,1.160515f,-0.4250448f,0.7907034f,-0.3901024f,-0.1056411f,-0.459835f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.493178f);
Get(0x6EC6).SetLocalPose(0.427616f,1.184142f,-0.6248479f,-0.1709014f,-0.6419097f,-0.6066394f,0.4367302f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094924f,1.309282f,0.1329291f,-0.7030755f,-0.01439065f,-0.009739963f,0.7109029f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.512594f);
Get(0x6E70).SetLocalPose(0.09339368f,1.613293f,-0.5732843f,0.2227912f,-0.09938776f,-0.7706611f,0.5887f);
Get(0x6E82).SetLocalPose(0.1747343f,1.169649f,-0.4150792f,0.8019567f,-0.3573197f,-0.104535f,-0.4671836f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.512594f);
Get(0x6EC6).SetLocalPose(0.4424096f,1.191695f,-0.6366968f,-0.1961161f,-0.6419759f,-0.5831726f,0.4575098f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095077f,1.309333f,0.1328893f,-0.703078f,-0.01442309f,-0.009732672f,0.7108999f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.531628f);
Get(0x6E70).SetLocalPose(0.09672412f,1.615206f,-0.5756091f,0.2140022f,-0.09125113f,-0.7706173f,0.5933172f);
Get(0x6E82).SetLocalPose(0.1737599f,1.176855f,-0.4047129f,0.8049355f,-0.336975f,-0.1106263f,-0.4756981f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.531628f);
Get(0x6EC6).SetLocalPose(0.4564345f,1.199784f,-0.6497451f,-0.2187424f,-0.6445755f,-0.5564707f,0.4764605f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095079f,1.309558f,0.1330124f,-0.7030706f,-0.01439727f,-0.009728817f,0.7109078f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.551179f);
Get(0x6E70).SetLocalPose(0.1006887f,1.616435f,-0.5781518f,0.2020728f,-0.08117009f,-0.7701908f,0.5994866f);
Get(0x6E82).SetLocalPose(0.1721671f,1.183478f,-0.3964324f,0.8116788f,-0.3200377f,-0.1097149f,-0.4761471f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.551179f);
Get(0x6EC6).SetLocalPose(0.46839f,1.208528f,-0.6630714f,-0.2370168f,-0.6481709f,-0.5256073f,0.4974279f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095079f,1.30965f,0.1330133f,-0.7030649f,-0.0144079f,-0.009723613f,0.7109134f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.571151f);
Get(0x6E70).SetLocalPose(0.1038248f,1.617852f,-0.5808278f,0.1917766f,-0.07295098f,-0.7693651f,0.6049605f);
Get(0x6E82).SetLocalPose(0.1701315f,1.19119f,-0.38829f,0.8227468f,-0.2989156f,-0.1089327f,-0.4710319f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.571151f);
Get(0x6EC6).SetLocalPose(0.4803387f,1.219664f,-0.6808096f,-0.2570583f,-0.6548832f,-0.4784252f,0.5255078f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095048f,1.309879f,0.1330418f,-0.703061f,-0.01444375f,-0.009721178f,0.7109164f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.590978f);
Get(0x6E70).SetLocalPose(0.1057218f,1.618712f,-0.584021f,0.1822981f,-0.06551471f,-0.7682779f,0.610102f);
Get(0x6E82).SetLocalPose(0.1675871f,1.198636f,-0.3821543f,0.8252637f,-0.2905022f,-0.1169329f,-0.4699734f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.590978f);
Get(0x6EC6).SetLocalPose(0.4866246f,1.227169f,-0.6937607f,-0.2690302f,-0.6622482f,-0.4443606f,0.5399944f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.590978f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.590978f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095084f,1.309131f,0.1329484f,-0.7030799f,-0.0144226f,-0.009718575f,0.7108982f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.044844f);
Get(0x6E70).SetLocalPose(0.1092239f,1.621327f,-0.5894749f,0.1630326f,-0.0513997f,-0.7654014f,0.6204346f);
Get(0x6E82).SetLocalPose(0.1627974f,1.215084f,-0.365494f,0.7888851f,-0.2941154f,-0.1436554f,-0.5201151f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.044844f);
Get(0x6EC6).SetLocalPose(0.4960223f,1.244649f,-0.7255906f,-0.2704818f,-0.6886617f,-0.4124339f,0.5314913f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095362f,1.309232f,0.1328466f,-0.703069f,-0.01443732f,-0.009683825f,0.7109092f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.1056526f);
Get(0x6E70).SetLocalPose(0.1107525f,1.622323f,-0.5911689f,0.1556229f,-0.04637744f,-0.7642676f,0.62412f);
Get(0x6E82).SetLocalPose(0.1622719f,1.220578f,-0.3612616f,0.7855857f,-0.289751f,-0.1417228f,-0.5280285f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.1056526f);
Get(0x6EC6).SetLocalPose(0.4999669f,1.251014f,-0.7363651f,-0.2793976f,-0.6850229f,-0.4070287f,0.5357314f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095065f,1.309276f,0.1327671f,-0.7030642f,-0.0144258f,-0.009692574f,0.710914f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.1660015f);
Get(0x6E70).SetLocalPose(0.1118717f,1.623247f,-0.5925538f,0.1495858f,-0.04238269f,-0.7633487f,0.6269981f);
Get(0x6E82).SetLocalPose(0.1617271f,1.225009f,-0.3578585f,0.7894849f,-0.2830825f,-0.1365626f,-0.5271894f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.1660015f);
Get(0x6EC6).SetLocalPose(0.5021472f,1.254735f,-0.7438278f,-0.2839791f,-0.685102f,-0.4000032f,0.5385059f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095028f,1.309225f,0.132768f,-0.7031057f,-0.0143755f,-0.009688434f,0.710874f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.2258671f);
Get(0x6E70).SetLocalPose(0.1130035f,1.623913f,-0.5940301f,0.1440281f,-0.03848519f,-0.7623979f,0.6297018f);
Get(0x6E82).SetLocalPose(0.1616594f,1.228038f,-0.355481f,0.792656f,-0.2795474f,-0.1359451f,-0.5244699f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.2258671f);
Get(0x6EC6).SetLocalPose(0.5033836f,1.257994f,-0.7515973f,-0.2850063f,-0.6837806f,-0.3919525f,0.5455169f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095318f,1.309531f,0.1327199f,-0.7031361f,-0.01437781f,-0.009696793f,0.7108439f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.2866489f);
Get(0x6E70).SetLocalPose(0.1137587f,1.624628f,-0.59523f,0.1394079f,-0.03522f,-0.7616885f,0.6317876f);
Get(0x6E82).SetLocalPose(0.1618851f,1.231447f,-0.3524923f,0.7952402f,-0.2759093f,-0.1372438f,-0.5221412f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.2866489f);
Get(0x6EC6).SetLocalPose(0.5037741f,1.260765f,-0.7567415f,-0.2818093f,-0.6828814f,-0.3854544f,0.5528847f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094993f,1.309721f,0.1328599f,-0.7031498f,-0.01435693f,-0.009790269f,0.7108294f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.3484277f);
Get(0x6E70).SetLocalPose(0.1141219f,1.624673f,-0.5962167f,0.1355697f,-0.03268607f,-0.761182f,0.6333677f);
Get(0x6E82).SetLocalPose(0.161755f,1.233647f,-0.3508204f,0.7989687f,-0.2696291f,-0.1373841f,-0.5196872f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.3484277f);
Get(0x6EC6).SetLocalPose(0.5041406f,1.263047f,-0.7611935f,-0.2812749f,-0.6817466f,-0.3801993f,0.5581707f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094822f,1.30979f,0.1328129f,-0.7031314f,-0.01440185f,-0.009751984f,0.7108473f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.37808f);
Get(0x6E70).SetLocalPose(0.114283f,1.624783f,-0.5966839f,0.1338485f,-0.0316746f,-0.7609169f,0.6341031f);
Get(0x6E82).SetLocalPose(0.1617506f,1.235004f,-0.3501177f,0.802699f,-0.265133f,-0.1366372f,-0.516439f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.37808f);
Get(0x6EC6).SetLocalPose(0.5042448f,1.264112f,-0.7633332f,-0.2824319f,-0.681299f,-0.3775277f,0.5599436f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.37808f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.37808f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094536f,1.309763f,0.1329574f,-0.7028697f,-0.01461888f,-0.009670548f,0.7111027f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.5217083f);
Get(0x6E70).SetLocalPose(0.1147723f,1.626155f,-0.59929f,0.128044f,-0.028865f,-0.7601075f,0.6364027f);
Get(0x6E82).SetLocalPose(0.1621275f,1.239417f,-0.3485256f,0.8120928f,-0.2566387f,-0.1340975f,-0.506616f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.5217083f);
Get(0x6EC6).SetLocalPose(0.5031193f,1.267133f,-0.7708674f,-0.2840445f,-0.6792383f,-0.3630717f,0.5710805f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094559f,1.309574f,0.1326015f,-0.7028524f,-0.01442331f,-0.009683481f,0.7111236f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.5824366f);
Get(0x6E70).SetLocalPose(0.1149722f,1.626179f,-0.6001027f,0.1262133f,-0.02864721f,-0.7598898f,0.6370378f);
Get(0x6E82).SetLocalPose(0.1635916f,1.241191f,-0.3474946f,0.812811f,-0.2562284f,-0.1352424f,-0.5053661f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.5824366f);
Get(0x6EC6).SetLocalPose(0.5017207f,1.268257f,-0.7729816f,-0.2832259f,-0.679903f,-0.3576732f,0.5740949f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095047f,1.309408f,0.1324812f,-0.7030511f,-0.01425615f,-0.009791771f,0.710929f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.6429812f);
Get(0x6E70).SetLocalPose(0.1149506f,1.626535f,-0.6007788f,0.1251344f,-0.02862657f,-0.7598589f,0.6372883f);
Get(0x6E82).SetLocalPose(0.164776f,1.242473f,-0.3471271f,0.8147299f,-0.2546135f,-0.1367897f,-0.5026686f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.6429812f);
Get(0x6EC6).SetLocalPose(0.5002213f,1.269205f,-0.7750771f,-0.2827091f,-0.6807386f,-0.3517221f,0.5770288f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095063f,1.309421f,0.1326667f,-0.7032153f,-0.01428766f,-0.009820681f,0.7107656f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.7021999f);
Get(0x6E70).SetLocalPose(0.1147668f,1.627161f,-0.6013728f,0.1244458f,-0.02867638f,-0.759891f,0.6373827f);
Get(0x6E82).SetLocalPose(0.165789f,1.244544f,-0.3472882f,0.8175858f,-0.2519628f,-0.1385926f,-0.4988591f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.7021999f);
Get(0x6EC6).SetLocalPose(0.4990983f,1.270436f,-0.7758229f,-0.2819396f,-0.680664f,-0.3470208f,0.5803302f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095544f,1.308864f,0.1328378f,-0.7031185f,-0.014487f,-0.009679751f,0.7108592f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.7627122f);
Get(0x6E70).SetLocalPose(0.11428f,1.627902f,-0.6015798f,0.1236678f,-0.02899037f,-0.7599712f,0.6374243f);
Get(0x6E82).SetLocalPose(0.1673615f,1.246511f,-0.3474459f,0.8189105f,-0.2511656f,-0.1404627f,-0.4965599f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.7627122f);
Get(0x6EC6).SetLocalPose(0.4982855f,1.272001f,-0.7759873f,-0.279803f,-0.6808526f,-0.3431566f,0.5834327f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095522f,1.308522f,0.1326087f,-0.7030677f,-0.01448978f,-0.009572371f,0.7109109f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.8213131f);
Get(0x6E70).SetLocalPose(0.1139822f,1.628363f,-0.6018003f,0.1232631f,-0.02937144f,-0.7601228f,0.6373044f);
Get(0x6E82).SetLocalPose(0.1687681f,1.248467f,-0.347461f,0.8188956f,-0.2511893f,-0.1427386f,-0.4959232f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.8213131f);
Get(0x6EC6).SetLocalPose(0.4977364f,1.273254f,-0.7762996f,-0.278309f,-0.681578f,-0.341021f,0.5845514f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095601f,1.308847f,0.1325248f,-0.7031459f,-0.01447148f,-0.009618994f,0.7108333f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.8511922f);
Get(0x6E70).SetLocalPose(0.113615f,1.628358f,-0.6019882f,0.1229146f,-0.02974169f,-0.7603421f,0.6370929f);
Get(0x6E82).SetLocalPose(0.1693223f,1.249486f,-0.3473931f,0.8188275f,-0.2511759f,-0.1437636f,-0.4957463f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.8511922f);
Get(0x6EC6).SetLocalPose(0.49734f,1.273821f,-0.7763311f,-0.2781639f,-0.6823311f,-0.3393359f,0.5847224f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095034f,1.308935f,0.1328702f,-0.7031582f,-0.01439132f,-0.009772843f,0.7108206f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.9653261f);
Get(0x6E70).SetLocalPose(0.1128937f,1.628257f,-0.6029522f,0.1224161f,-0.03094223f,-0.7609763f,0.6363741f);
Get(0x6E82).SetLocalPose(0.1702246f,1.253739f,-0.3473998f,0.8207753f,-0.2494901f,-0.1459676f,-0.492723f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.9653261f);
Get(0x6EC6).SetLocalPose(0.4973187f,1.275805f,-0.7768202f,-0.2764505f,-0.6819353f,-0.3337987f,0.5891671f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094841f,1.309206f,0.1329849f,-0.7030471f,-0.01432362f,-0.009705476f,0.7109328f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.032691f);
Get(0x6E70).SetLocalPose(0.1124625f,1.627983f,-0.6032405f,0.1223653f,-0.03163235f,-0.7611968f,0.6360861f);
Get(0x6E82).SetLocalPose(0.1705764f,1.255971f,-0.3471876f,0.8223415f,-0.2481196f,-0.1466839f,-0.4905864f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.032691f);
Get(0x6EC6).SetLocalPose(0.4976012f,1.277416f,-0.7771078f,-0.2738093f,-0.6815022f,-0.3316447f,0.5921107f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094816f,1.309104f,0.1330252f,-0.7030078f,-0.01440603f,-0.009706585f,0.71097f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.090867f);
Get(0x6E70).SetLocalPose(0.1123186f,1.628108f,-0.6036465f,0.1224211f,-0.03245453f,-0.7613633f,0.6358347f);
Get(0x6E82).SetLocalPose(0.170499f,1.258032f,-0.3472334f,0.8235803f,-0.2473314f,-0.1470942f,-0.4887802f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.090867f);
Get(0x6EC6).SetLocalPose(0.4979768f,1.278929f,-0.7775911f,-0.2730804f,-0.6820076f,-0.3303948f,0.5925639f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095063f,1.309157f,0.1329891f,-0.7030209f,-0.01436567f,-0.009678422f,0.7109582f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.150577f);
Get(0x6E70).SetLocalPose(0.1117633f,1.628184f,-0.6041577f,0.1225478f,-0.033462f,-0.7614515f,0.6356522f);
Get(0x6E82).SetLocalPose(0.1704459f,1.259349f,-0.3468232f,0.8243786f,-0.2468018f,-0.1479803f,-0.4874327f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.150577f);
Get(0x6EC6).SetLocalPose(0.4983381f,1.281153f,-0.7784097f,-0.2727108f,-0.6835882f,-0.3285568f,0.5919345f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095419f,1.309392f,0.1329364f,-0.7030096f,-0.01430249f,-0.009654676f,0.710971f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.18905f);
Get(0x6E70).SetLocalPose(0.1114616f,1.628439f,-0.6046391f,0.1226655f,-0.03413754f,-0.7614722f,0.6355689f);
Get(0x6E82).SetLocalPose(0.1701667f,1.260606f,-0.346207f,0.8257204f,-0.2451791f,-0.1488142f,-0.4857235f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.18905f);
Get(0x6EC6).SetLocalPose(0.4984668f,1.282329f,-0.7787437f,-0.2723579f,-0.6842105f,-0.3272035f,0.5921277f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095191f,1.309573f,0.1330772f,-0.7028846f,-0.01410551f,-0.009646597f,0.7110987f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.278874f);
Get(0x6E70).SetLocalPose(0.1105526f,1.628736f,-0.6048923f,0.1228386f,-0.03559634f,-0.7613757f,0.6355712f);
Get(0x6E82).SetLocalPose(0.169337f,1.263648f,-0.3449981f,0.8286396f,-0.2420372f,-0.1485124f,-0.4824091f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.278874f);
Get(0x6EC6).SetLocalPose(0.4992025f,1.284941f,-0.7796116f,-0.2706505f,-0.6845821f,-0.3251074f,0.5936338f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095627f,1.309443f,0.1331522f,-0.7027988f,-0.01381628f,-0.009622551f,0.7111894f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.34154f);
Get(0x6E70).SetLocalPose(0.1099664f,1.629108f,-0.6048616f,0.1229423f,-0.03654994f,-0.7612426f,0.6356564f);
Get(0x6E82).SetLocalPose(0.1694762f,1.265994f,-0.3441547f,0.8304621f,-0.2403643f,-0.1470091f,-0.4805684f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.34154f);
Get(0x6EC6).SetLocalPose(0.5001225f,1.287207f,-0.7801111f,-0.2689484f,-0.6849337f,-0.3239829f,0.5946157f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.34154f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.34154f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095791f,1.309092f,0.1333831f,-0.7029399f,-0.01384647f,-0.009741686f,0.7110478f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.441394f);
Get(0x6E70).SetLocalPose(0.1093391f,1.629676f,-0.6049374f,0.1230455f,-0.0382661f,-0.7608811f,0.6359681f);
Get(0x6E82).SetLocalPose(0.1688282f,1.27051f,-0.3415753f,0.8317869f,-0.2378389f,-0.1461162f,-0.4798055f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.441394f);
Get(0x6EC6).SetLocalPose(0.5009392f,1.291662f,-0.7808953f,-0.2665871f,-0.6887705f,-0.3190873f,0.5938939f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095945f,1.309128f,0.1331888f,-0.7029805f,-0.01406672f,-0.00956652f,0.7110057f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.51103f);
Get(0x6E70).SetLocalPose(0.1089038f,1.629645f,-0.6048704f,0.1229375f,-0.03927455f,-0.7607284f,0.6361104f);
Get(0x6E82).SetLocalPose(0.1675755f,1.272625f,-0.3398593f,0.8336238f,-0.2345743f,-0.1455344f,-0.4783995f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.51103f);
Get(0x6EC6).SetLocalPose(0.5007988f,1.293497f,-0.7812821f,-0.2643566f,-0.6898869f,-0.3160798f,0.5952018f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095833f,1.309058f,0.1331313f,-0.7030123f,-0.01410774f,-0.009452019f,0.7109749f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.570579f);
Get(0x6E70).SetLocalPose(0.1084642f,1.62987f,-0.6049759f,0.122845f,-0.04018947f,-0.7606617f,0.6361508f);
Get(0x6E82).SetLocalPose(0.166376f,1.274599f,-0.3386102f,0.8356968f,-0.23119f,-0.1442838f,-0.4768064f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.570579f);
Get(0x6EC6).SetLocalPose(0.5000318f,1.296139f,-0.7814206f,-0.2618608f,-0.6914031f,-0.3115497f,0.5969318f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.096035f,1.308941f,0.1329778f,-0.7031066f,-0.01397189f,-0.009516866f,0.7108835f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.629767f);
Get(0x6E70).SetLocalPose(0.1081776f,1.629993f,-0.6053215f,0.1228876f,-0.04080992f,-0.7606284f,0.6361428f);
Get(0x6E82).SetLocalPose(0.1650232f,1.276746f,-0.3369366f,0.8374466f,-0.2278704f,-0.142862f,-0.4757614f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.629767f);
Get(0x6EC6).SetLocalPose(0.4998491f,1.298077f,-0.7815939f,-0.2609107f,-0.692561f,-0.3092059f,0.5972242f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095876f,1.309413f,0.1331943f,-0.7032436f,-0.01385978f,-0.009455717f,0.7107511f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.691556f);
Get(0x6E70).SetLocalPose(0.107674f,1.630068f,-0.6052547f,0.1230167f,-0.04198181f,-0.7606463f,0.6360202f);
Get(0x6E82).SetLocalPose(0.1631162f,1.27878f,-0.335207f,0.8385952f,-0.2249185f,-0.1416579f,-0.4755028f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.691556f);
Get(0x6EC6).SetLocalPose(0.5000135f,1.301295f,-0.7817004f,-0.2601414f,-0.6941553f,-0.3060738f,0.5973221f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095843f,1.309452f,0.1331629f,-0.7033259f,-0.01398133f,-0.009239172f,0.7106701f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.752452f);
Get(0x6E70).SetLocalPose(0.1073047f,1.630342f,-0.6049142f,0.1233616f,-0.0429271f,-0.7606567f,0.6358779f);
Get(0x6E82).SetLocalPose(0.1606738f,1.280329f,-0.3335313f,0.8397932f,-0.2223547f,-0.1398203f,-0.475138f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.752452f);
Get(0x6EC6).SetLocalPose(0.4996535f,1.303454f,-0.7817454f,-0.2602061f,-0.6958823f,-0.3032247f,0.5967372f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095951f,1.309514f,0.133237f,-0.7032541f,-0.01413337f,-0.009033289f,0.7107407f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.814229f);
Get(0x6E70).SetLocalPose(0.1068195f,1.630146f,-0.6047639f,0.1241648f,-0.04408159f,-0.7606357f,0.6356676f);
Get(0x6E82).SetLocalPose(0.1581534f,1.282653f,-0.3315422f,0.8413077f,-0.2179472f,-0.1381265f,-0.4749963f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.814229f);
Get(0x6EC6).SetLocalPose(0.4991498f,1.306319f,-0.7815124f,-0.2619918f,-0.6993853f,-0.2971267f,0.5949255f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.814229f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.814229f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095866f,1.309386f,0.1330706f,-0.7032f,-0.01378365f,-0.008969325f,0.710802f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.925784f);
Get(0x6E70).SetLocalPose(0.1056754f,1.630786f,-0.6042458f,0.1279302f,-0.04727563f,-0.7606218f,0.6347074f);
Get(0x6E82).SetLocalPose(0.1493815f,1.288662f,-0.3267249f,0.8465794f,-0.193164f,-0.1427305f,-0.4749936f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.925784f);
Get(0x6EC6).SetLocalPose(0.4980516f,1.310065f,-0.7815791f,-0.2757872f,-0.7095164f,-0.2740089f,0.5877474f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.096043f,1.309208f,0.1329309f,-0.703349f,-0.01391375f,-0.009027837f,0.7106512f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.995129f);
Get(0x6E70).SetLocalPose(0.1038435f,1.63117f,-0.6029299f,0.1319181f,-0.05056577f,-0.7603346f,0.633981f);
Get(0x6E82).SetLocalPose(0.1430793f,1.292106f,-0.3236448f,0.8535693f,-0.1629505f,-0.1489328f,-0.4718958f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.995129f);
Get(0x6EC6).SetLocalPose(0.497816f,1.31135f,-0.7801038f,-0.2870673f,-0.708398f,-0.2528213f,0.5931662f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095726f,1.309022f,0.1329867f,-0.7033887f,-0.01430671f,-0.008882727f,0.710606f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.056434f);
Get(0x6E70).SetLocalPose(0.101874f,1.63165f,-0.6018028f,0.1363696f,-0.05450789f,-0.7596298f,0.6335574f);
Get(0x6E82).SetLocalPose(0.1367999f,1.295454f,-0.3206412f,0.8649408f,-0.125129f,-0.1472546f,-0.4631805f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.056434f);
Get(0x6EC6).SetLocalPose(0.499045f,1.312648f,-0.7768356f,-0.3021848f,-0.697469f,-0.2490005f,0.6001835f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095411f,1.308969f,0.132944f,-0.7034339f,-0.01441596f,-0.008386976f,0.7105651f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.03322154f);
Get(0x6E70).SetLocalPose(0.09874036f,1.632621f,-0.6002703f,0.143099f,-0.06041435f,-0.758158f,0.6333004f);
Get(0x6E82).SetLocalPose(0.1316525f,1.29891f,-0.3172983f,0.8705359f,-0.09203812f,-0.1327106f,-0.4648486f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0f);
Get(0x6EC6).SetLocalPose(0.5014453f,1.313861f,-0.7704402f,-0.3156879f,-0.6836224f,-0.2766789f,0.5970348f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095265f,1.309003f,0.1329845f,-0.7034587f,-0.01426427f,-0.008503156f,0.7105421f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.09547477f);
Get(0x6E70).SetLocalPose(0.09413604f,1.633806f,-0.5978975f,0.1530045f,-0.06939358f,-0.7553797f,0.6333843f);
Get(0x6E82).SetLocalPose(0.1276638f,1.302577f,-0.3129435f,0.8624132f,-0.09472802f,-0.1203424f,-0.4824809f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.06225323f);
Get(0x6EC6).SetLocalPose(0.5043238f,1.313927f,-0.7633026f,-0.3235123f,-0.6741467f,-0.3233275f,0.5799357f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095278f,1.308889f,0.1330203f,-0.703324f,-0.01429775f,-0.008771923f,0.7106715f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.154388f);
Get(0x6E70).SetLocalPose(0.08926734f,1.633544f,-0.5956315f,0.1628475f,-0.07902161f,-0.7522963f,0.633472f);
Get(0x6E82).SetLocalPose(0.1255076f,1.302547f,-0.3084613f,0.8494112f,-0.1153024f,-0.1218301f,-0.5003633f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.1211665f);
Get(0x6EC6).SetLocalPose(0.5075838f,1.312795f,-0.7541776f,-0.3223712f,-0.6561853f,-0.3743787f,0.5703843f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095282f,1.308884f,0.1329705f,-0.7033464f,-0.01429423f,-0.008639839f,0.710651f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.2132483f);
Get(0x6E70).SetLocalPose(0.08336932f,1.635302f,-0.5920103f,0.1755729f,-0.09156289f,-0.7482835f,0.6331368f);
Get(0x6E82).SetLocalPose(0.1240831f,1.30274f,-0.3032455f,0.8338583f,-0.1434988f,-0.1086559f,-0.5218068f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.1800268f);
Get(0x6EC6).SetLocalPose(0.5086157f,1.310036f,-0.7464574f,-0.3207435f,-0.643935f,-0.4061961f,0.5634502f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.2132483f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.1800268f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09534f,1.308877f,0.133344f,-0.7031814f,-0.0143708f,-0.009331119f,0.710804f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.3488215f);
Get(0x6E70).SetLocalPose(0.06815097f,1.637021f,-0.583662f,0.2070975f,-0.1222684f,-0.7389893f,0.6293297f);
Get(0x6E82).SetLocalPose(0.1142024f,1.299405f,-0.2944053f,0.8174157f,-0.1786008f,-0.08397307f,-0.5411857f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.3156f);
Get(0x6EC6).SetLocalPose(0.5089337f,1.299919f,-0.7306206f,-0.3082162f,-0.6235281f,-0.4554606f,0.5556718f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095085f,1.30905f,0.1335298f,-0.7029813f,-0.01428877f,-0.009366285f,0.7110032f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.4066381f);
Get(0x6E70).SetLocalPose(0.06142215f,1.637376f,-0.5804657f,0.2206022f,-0.1351815f,-0.7347712f,0.6270343f);
Get(0x6E82).SetLocalPose(0.1092383f,1.29793f,-0.2908053f,0.8189354f,-0.1818502f,-0.07136331f,-0.5396135f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.3734166f);
Get(0x6EC6).SetLocalPose(0.5081164f,1.295513f,-0.7247771f,-0.3041962f,-0.6191433f,-0.4716717f,0.5492286f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09489f,1.309209f,0.1334795f,-0.7027984f,-0.01452294f,-0.00939878f,0.7111787f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.4690523f);
Get(0x6E70).SetLocalPose(0.05289172f,1.638518f,-0.5763132f,0.2383831f,-0.1523422f,-0.7286839f,0.6236867f);
Get(0x6E82).SetLocalPose(0.1041932f,1.296952f,-0.2872838f,0.8194129f,-0.1807413f,-0.06258396f,-0.5403501f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.4358308f);
Get(0x6EC6).SetLocalPose(0.5067199f,1.289353f,-0.7171204f,-0.3011914f,-0.6150458f,-0.494055f,0.5356418f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094869f,1.309424f,0.1334813f,-0.7030946f,-0.01447681f,-0.009655158f,0.7108834f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.5301852f);
Get(0x6E70).SetLocalPose(0.04225153f,1.639009f,-0.5714442f,0.2591271f,-0.1720966f,-0.7210133f,0.6191735f);
Get(0x6E82).SetLocalPose(0.09203346f,1.294071f,-0.2803696f,0.8169225f,-0.1765026f,-0.0537416f,-0.5464396f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.4969637f);
Get(0x6EC6).SetLocalPose(0.5042982f,1.281863f,-0.7094507f,-0.2991804f,-0.6110644f,-0.5118327f,0.5245177f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094617f,1.309573f,0.1332875f,-0.7034118f,-0.01427291f,-0.009839742f,0.7105712f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.5897062f);
Get(0x6E70).SetLocalPose(0.03105091f,1.640011f,-0.56599f,0.2805562f,-0.1925524f,-0.7127298f,0.6133744f);
Get(0x6E82).SetLocalPose(0.08378207f,1.291305f,-0.2751344f,0.80863f,-0.1729959f,-0.05347266f,-0.5597594f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.5564846f);
Get(0x6EC6).SetLocalPose(0.4999682f,1.272838f,-0.7018492f,-0.2928284f,-0.6077446f,-0.5252965f,0.5186151f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094875f,1.309559f,0.1339109f,-0.7031522f,-0.01433677f,-0.009855063f,0.7108266f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.6510117f);
Get(0x6E70).SetLocalPose(0.0207396f,1.641233f,-0.5615233f,0.2996856f,-0.2115906f,-0.7049292f,0.6070361f);
Get(0x6E82).SetLocalPose(0.07450853f,1.284979f,-0.2683457f,0.7942809f,-0.1686961f,-0.05457543f,-0.5811034f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.6177902f);
Get(0x6EC6).SetLocalPose(0.4944875f,1.263662f,-0.694891f,-0.2852004f,-0.606011f,-0.5361427f,0.5137727f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094653f,1.309394f,0.1341512f,-0.70307f,-0.01437134f,-0.009732852f,0.7109088f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.6774206f);
Get(0x6E70).SetLocalPose(0.01687289f,1.6423f,-0.5594148f,0.3070827f,-0.2192996f,-0.7016582f,0.6043871f);
Get(0x6E82).SetLocalPose(0.07100224f,1.282514f,-0.2661225f,0.7887737f,-0.1667421f,-0.05461124f,-0.5891101f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.6441991f);
Get(0x6EC6).SetLocalPose(0.4918919f,1.259745f,-0.6920438f,-0.2830857f,-0.6055542f,-0.5402938f,0.5111255f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094325f,1.309333f,0.1336489f,-0.7031209f,-0.01428693f,-0.00966551f,0.7108611f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.7820037f);
Get(0x6E70).SetLocalPose(-0.0006337691f,1.646039f,-0.5510285f,0.3390203f,-0.2527931f,-0.6856411f,0.5925009f);
Get(0x6E82).SetLocalPose(0.05628275f,1.268825f,-0.2593319f,0.7668093f,-0.1559962f,-0.05863475f,-0.6198635f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.7487822f);
Get(0x6EC6).SetLocalPose(0.4809596f,1.242399f,-0.6797395f,-0.2860774f,-0.6028552f,-0.5597188f,0.4913656f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094494f,1.309356f,0.1335422f,-0.703206f,-0.01439101f,-0.009898924f,0.7107716f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.8464748f);
Get(0x6E70).SetLocalPose(-0.009182832f,1.647688f,-0.5475923f,0.3547508f,-0.267693f,-0.6773842f,0.5862107f);
Get(0x6E82).SetLocalPose(0.04746762f,1.258893f,-0.2555866f,0.7490955f,-0.1481218f,-0.06004769f,-0.642892f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.8132532f);
Get(0x6EC6).SetLocalPose(0.473691f,1.23186f,-0.6722698f,-0.2893385f,-0.5997961f,-0.5721508f,0.4787185f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094743f,1.309488f,0.1334322f,-0.7032491f,-0.01427602f,-0.009741463f,0.7107335f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.9067698f);
Get(0x6E70).SetLocalPose(-0.01824677f,1.648548f,-0.5446122f,0.3721371f,-0.2827339f,-0.668704f,0.5782824f);
Get(0x6E82).SetLocalPose(0.04000478f,1.248507f,-0.2523155f,0.7301127f,-0.14305f,-0.05852512f,-0.6656178f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.8735483f);
Get(0x6EC6).SetLocalPose(0.4648981f,1.220088f,-0.6638002f,-0.2895918f,-0.5966188f,-0.5865678f,0.4648882f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094718f,1.308965f,0.1333516f,-0.7030183f,-0.01433085f,-0.009664899f,0.7109618f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.9667836f);
Get(0x6E70).SetLocalPose(-0.02620465f,1.648725f,-0.5425689f,0.3887945f,-0.2964272f,-0.6609275f,0.569337f);
Get(0x6E82).SetLocalPose(0.0328873f,1.236349f,-0.2487306f,0.7032431f,-0.1406837f,-0.06164056f,-0.6941597f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.9335621f);
Get(0x6EC6).SetLocalPose(0.4565169f,1.209025f,-0.6558406f,-0.2886824f,-0.5955949f,-0.5994908f,0.4500445f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094942f,1.308811f,0.1333215f,-0.702955f,-0.01437822f,-0.009684511f,0.7110231f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.028015f);
Get(0x6E70).SetLocalPose(-0.03413262f,1.648699f,-0.541477f,0.4044569f,-0.3086616f,-0.6544465f,0.5593233f);
Get(0x6E82).SetLocalPose(0.0265678f,1.224572f,-0.2455105f,0.6753814f,-0.1352627f,-0.07470243f,-0.721099f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.9947932f);
Get(0x6EC6).SetLocalPose(0.4484593f,1.197886f,-0.6475795f,-0.2912021f,-0.5958681f,-0.6125071f,0.4300903f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09516f,1.308647f,0.1331581f,-0.703223f,-0.01427098f,-0.009712196f,0.7107598f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.087748f);
Get(0x6E70).SetLocalPose(-0.04099632f,1.647898f,-0.5413784f,0.4191997f,-0.3190529f,-0.6492649f,0.5485726f);
Get(0x6E82).SetLocalPose(0.0206702f,1.213451f,-0.2419688f,0.6470165f,-0.1231682f,-0.09312366f,-0.7466775f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.054527f);
Get(0x6EC6).SetLocalPose(0.4404243f,1.185864f,-0.6377894f,-0.3007205f,-0.5957679f,-0.6280653f,0.4002023f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094844f,1.308684f,0.1329433f,-0.7032202f,-0.01435991f,-0.009832833f,0.710759f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.149585f);
Get(0x6E70).SetLocalPose(-0.0460148f,1.645515f,-0.542312f,0.4316757f,-0.3268228f,-0.6457174f,0.5384161f);
Get(0x6E82).SetLocalPose(0.01619701f,1.205178f,-0.2389539f,0.6261545f,-0.1107477f,-0.1055863f,-0.7645372f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.116363f);
Get(0x6EC6).SetLocalPose(0.4338861f,1.175096f,-0.6285454f,-0.309649f,-0.5954079f,-0.6420727f,0.370607f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.149585f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.116363f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094841f,1.308892f,0.1330787f,-0.7029906f,-0.01429485f,-0.009518621f,0.7109918f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.251037f);
Get(0x6E70).SetLocalPose(-0.05526826f,1.641076f,-0.5468726f,0.4557211f,-0.3384528f,-0.641664f,0.5157862f);
Get(0x6E82).SetLocalPose(0.00415402f,1.184978f,-0.2304773f,0.5776401f,-0.06275471f,-0.1381285f,-0.8020688f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.217816f);
Get(0x6EC6).SetLocalPose(0.420806f,1.153905f,-0.6087149f,-0.3210512f,-0.6014017f,-0.6555737f,0.3247541f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094922f,1.309111f,0.1329834f,-0.7031178f,-0.01435902f,-0.009732808f,0.7108618f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.324519f);
Get(0x6E70).SetLocalPose(-0.05893543f,1.637936f,-0.5513934f,0.4672731f,-0.3418984f,-0.6408061f,0.5041121f);
Get(0x6E82).SetLocalPose(0.0003338119f,1.179993f,-0.2281401f,0.5653158f,-0.03420721f,-0.1533622f,-0.8097703f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.291298f);
Get(0x6EC6).SetLocalPose(0.4144015f,1.143686f,-0.5957906f,-0.3356102f,-0.6073412f,-0.6575175f,0.2935529f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09499f,1.309532f,0.1328556f,-0.7031489f,-0.01435236f,-0.009763086f,0.7108307f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.386468f);
Get(0x6E70).SetLocalPose(-0.06233966f,1.634569f,-0.5568947f,0.477624f,-0.3441631f,-0.6400287f,0.4937514f);
Get(0x6E82).SetLocalPose(-0.003019655f,1.177902f,-0.2254563f,0.5631326f,-0.005779705f,-0.1605845f,-0.810593f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.353247f);
Get(0x6EC6).SetLocalPose(0.409592f,1.138341f,-0.5834895f,-0.3462431f,-0.6093711f,-0.6615719f,0.2666558f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095029f,1.309593f,0.1330451f,-0.7030687f,-0.01436989f,-0.009552235f,0.7109126f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.452137f);
Get(0x6E70).SetLocalPose(-0.06461856f,1.63181f,-0.5632843f,0.4869316f,-0.3461457f,-0.6387725f,0.4848202f);
Get(0x6E82).SetLocalPose(-0.004440847f,1.179046f,-0.2233566f,0.5671256f,0.01537185f,-0.1599739f,-0.8077999f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.418916f);
Get(0x6EC6).SetLocalPose(0.4017176f,1.134849f,-0.5666784f,-0.3498576f,-0.611899f,-0.6685995f,0.2369684f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094718f,1.309475f,0.1330895f,-0.7030107f,-0.01437236f,-0.009701616f,0.7109679f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.512627f);
Get(0x6E70).SetLocalPose(-0.0657649f,1.630271f,-0.5705336f,0.4936013f,-0.3482818f,-0.6370723f,0.4787447f);
Get(0x6E82).SetLocalPose(-0.005007382f,1.182517f,-0.22089f,0.5649298f,0.03633856f,-0.1707104f,-0.8064687f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.479405f);
Get(0x6EC6).SetLocalPose(0.3945409f,1.135926f,-0.5530097f,-0.3453856f,-0.6174439f,-0.6714329f,0.2205673f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094987f,1.309484f,0.132947f,-0.7030969f,-0.01430595f,-0.009666313f,0.7108845f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.577975f);
Get(0x6E70).SetLocalPose(-0.06641472f,1.62925f,-0.5770977f,0.4975488f,-0.3501761f,-0.635531f,0.4753129f);
Get(0x6E82).SetLocalPose(-0.005996916f,1.187323f,-0.218015f,0.549544f,0.06406645f,-0.200251f,-0.8085768f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.544753f);
Get(0x6EC6).SetLocalPose(0.3840451f,1.142317f,-0.534981f,-0.3363478f,-0.6308383f,-0.669449f,0.2018692f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094952f,1.309513f,0.133198f,-0.7031255f,-0.01433955f,-0.009681002f,0.7108554f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.642108f);
Get(0x6E70).SetLocalPose(-0.06618494f,1.627778f,-0.5866059f,0.5015035f,-0.352335f,-0.6336381f,0.4720775f);
Get(0x6E82).SetLocalPose(-0.006777919f,1.196949f,-0.2149934f,0.5287154f,0.0977079f,-0.2380949f,-0.8088412f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.608887f);
Get(0x6EC6).SetLocalPose(0.3733936f,1.152425f,-0.5177265f,-0.3246451f,-0.6462054f,-0.6662248f,0.1821229f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.642108f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.608887f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094812f,1.309566f,0.1331933f,-0.7030749f,-0.0143388f,-0.009595006f,0.7109065f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.745153f);
Get(0x6E70).SetLocalPose(-0.06412532f,1.627249f,-0.6031761f,0.5061462f,-0.356118f,-0.6303573f,0.4686638f);
Get(0x6E82).SetLocalPose(-0.003347581f,1.221328f,-0.2154672f,0.5324123f,0.124589f,-0.2728106f,-0.7915738f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.711932f);
Get(0x6EC6).SetLocalPose(0.3525603f,1.178549f,-0.4896313f,-0.2884031f,-0.6764875f,-0.6612108f,0.1482854f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094997f,1.309554f,0.1333034f,-0.7030729f,-0.01435768f,-0.009630268f,0.7109076f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.81659f);
Get(0x6E70).SetLocalPose(-0.06244253f,1.626026f,-0.6127481f,0.5077955f,-0.3585291f,-0.6282583f,0.4678592f);
Get(0x6E82).SetLocalPose(0.0004706649f,1.241981f,-0.2196226f,0.5508293f,0.1295809f,-0.2850912f,-0.77364f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.783368f);
Get(0x6EC6).SetLocalPose(0.3383223f,1.200242f,-0.4755121f,-0.2627924f,-0.6997739f,-0.6515237f,0.1295127f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095205f,1.309284f,0.133255f,-0.7031215f,-0.01441924f,-0.009698656f,0.7108573f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.879767f);
Get(0x6E70).SetLocalPose(-0.06034982f,1.625173f,-0.6222419f,0.5089878f,-0.3610535f,-0.625955f,0.4677095f);
Get(0x6E82).SetLocalPose(0.003786559f,1.267273f,-0.2266959f,0.574607f,0.1331512f,-0.298235f,-0.7504355f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.846546f);
Get(0x6EC6).SetLocalPose(0.3238932f,1.225144f,-0.4650532f,-0.2428049f,-0.7246262f,-0.6358888f,0.1077409f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095239f,1.309186f,0.1331819f,-0.7031483f,-0.0143281f,-0.009579358f,0.7108343f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.939254f);
Get(0x6E70).SetLocalPose(-0.05743863f,1.624891f,-0.631676f,0.5100664f,-0.3637013f,-0.623469f,0.4678034f);
Get(0x6E82).SetLocalPose(0.005718759f,1.287029f,-0.2327732f,0.5901792f,0.1367945f,-0.3149327f,-0.7306115f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.906033f);
Get(0x6EC6).SetLocalPose(0.3103487f,1.250448f,-0.4590963f,-0.2286977f,-0.747067f,-0.6187956f,0.08173266f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095312f,1.309353f,0.1331535f,-0.7029844f,-0.01438017f,-0.009607529f,0.710995f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.026294f);
Get(0x6E70).SetLocalPose(-0.05249194f,1.624784f,-0.6445289f,0.5108991f,-0.3677126f,-0.620479f,0.4677344f);
Get(0x6E82).SetLocalPose(0.008482164f,1.32006f,-0.2464403f,0.6051742f,0.1363621f,-0.355349f,-0.6992115f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.993072f);
Get(0x6EC6).SetLocalPose(0.2902694f,1.288098f,-0.4567669f,-0.2127364f,-0.7784674f,-0.5897374f,0.03068612f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095198f,1.309494f,0.1330942f,-0.7031021f,-0.01433857f,-0.009635927f,0.7108791f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.08363f);
Get(0x6E70).SetLocalPose(-0.04830674f,1.624404f,-0.6533898f,0.5112988f,-0.3705203f,-0.6185794f,0.467598f);
Get(0x6E82).SetLocalPose(0.01072872f,1.344605f,-0.2596765f,0.6121991f,0.1274887f,-0.3895797f,-0.6761559f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.050409f);
Get(0x6EC6).SetLocalPose(0.2766953f,1.314903f,-0.4595087f,-0.2033456f,-0.7993335f,-0.5653696f,-0.008584116f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09517f,1.309605f,0.1330397f,-0.7031269f,-0.01430657f,-0.009635953f,0.7108552f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.112033f);
Get(0x6E70).SetLocalPose(-0.04601353f,1.623888f,-0.6587039f,0.5114783f,-0.3720717f,-0.6175827f,0.4674873f);
Get(0x6E82).SetLocalPose(0.01150397f,1.353735f,-0.2654018f,0.6153674f,0.1236272f,-0.4027209f,-0.6662246f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.078812f);
Get(0x6EC6).SetLocalPose(0.2705396f,1.326977f,-0.4618421f,-0.1990301f,-0.8084433f,-0.5532684f,-0.02646886f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.112033f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.078812f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095234f,1.309705f,0.1329468f,-0.703071f,-0.01433998f,-0.009556269f,0.7109109f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.26268f);
Get(0x6E70).SetLocalPose(-0.0365394f,1.62311f,-0.6771106f,0.5116564f,-0.3756582f,-0.6164156f,0.465962f);
Get(0x6E82).SetLocalPose(0.01368115f,1.403116f,-0.3014565f,0.6523378f,0.103432f,-0.4541048f,-0.5979515f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.229459f);
Get(0x6EC6).SetLocalPose(0.2387563f,1.39031f,-0.4879257f,-0.1741649f,-0.8538205f,-0.473374f,-0.1287407f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095191f,1.309571f,0.132886f,-0.7030661f,-0.01431564f,-0.009648539f,0.7109149f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.324573f);
Get(0x6E70).SetLocalPose(-0.03296042f,1.622772f,-0.6846325f,0.5117517f,-0.3759781f,-0.6172316f,0.4645167f);
Get(0x6E82).SetLocalPose(0.01531616f,1.424653f,-0.3200439f,0.6634649f,0.08708181f,-0.477185f,-0.5696715f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0f);
Get(0x6EC6).SetLocalPose(0.2272575f,1.413134f,-0.5041104f,-0.1607559f,-0.8670206f,-0.4381486f,-0.1745235f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095162f,1.309086f,0.1327982f,-0.7030501f,-0.01434797f,-0.009654398f,0.71093f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.387211f);
Get(0x6E70).SetLocalPose(-0.03046639f,1.622758f,-0.6892617f,0.5112985f,-0.375987f,-0.6184465f,0.4633914f);
Get(0x6E82).SetLocalPose(0.01848039f,1.442773f,-0.3369645f,0.6688462f,0.06490191f,-0.4914938f,-0.5539554f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.06263846f);
Get(0x6EC6).SetLocalPose(0.2195709f,1.427885f,-0.5165802f,-0.1498184f,-0.8742266f,-0.4142607f,-0.2041335f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095294f,1.309163f,0.1328857f,-0.7030874f,-0.01435008f,-0.009543915f,0.7108946f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.448271f);
Get(0x6E70).SetLocalPose(-0.02744294f,1.623425f,-0.694765f,0.5094731f,-0.3758838f,-0.620984f,0.4620903f);
Get(0x6E82).SetLocalPose(0.02108759f,1.457205f,-0.3517955f,0.6745605f,0.04349039f,-0.5006707f,-0.5407454f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.1236982f);
Get(0x6EC6).SetLocalPose(0.2111281f,1.443576f,-0.5309355f,-0.1372388f,-0.8812397f,-0.389034f,-0.2307263f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095118f,1.308977f,0.1327339f,-0.7030528f,-0.01437484f,-0.009621194f,0.7109274f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.509204f);
Get(0x6E70).SetLocalPose(-0.02565937f,1.624538f,-0.6976129f,0.5079364f,-0.3756037f,-0.6224912f,0.461982f);
Get(0x6E82).SetLocalPose(0.02321506f,1.469331f,-0.3663758f,0.679534f,0.01902421f,-0.5092979f,-0.5277191f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.1846314f);
Get(0x6EC6).SetLocalPose(0.2054032f,1.453077f,-0.5420768f,-0.1274892f,-0.8861353f,-0.3715476f,-0.2458926f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09537f,1.309228f,0.132913f,-0.7030336f,-0.01438587f,-0.009632863f,0.7109459f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.569728f);
Get(0x6E70).SetLocalPose(-0.02384105f,1.626874f,-0.7006084f,0.5052814f,-0.3750829f,-0.62366f,0.4637369f);
Get(0x6E82).SetLocalPose(0.02534078f,1.478366f,-0.3786549f,0.6842679f,-0.002055729f,-0.5148163f,-0.5164663f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.2451551f);
Get(0x6EC6).SetLocalPose(0.2012872f,1.460766f,-0.5524894f,-0.1188231f,-0.890396f,-0.355956f,-0.2576267f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095328f,1.309136f,0.1327891f,-0.7030697f,-0.01434486f,-0.009575788f,0.7109118f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.597775f);
Get(0x6E70).SetLocalPose(-0.0229577f,1.627775f,-0.7014511f,0.5039843f,-0.3750373f,-0.6236395f,0.4652103f);
Get(0x6E82).SetLocalPose(0.02631799f,1.482768f,-0.385548f,0.6864738f,-0.01363316f,-0.5168247f,-0.5113318f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.2732022f);
Get(0x6EC6).SetLocalPose(0.1990055f,1.464582f,-0.5587292f,-0.1144183f,-0.892602f,-0.3468409f,-0.2643325f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095583f,1.309511f,0.1329051f,-0.7030795f,-0.01450003f,-0.009605791f,0.7108985f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.702159f);
Get(0x6E70).SetLocalPose(-0.02130233f,1.630385f,-0.7022862f,0.4983043f,-0.3759994f,-0.6214994f,0.4733454f);
Get(0x6E82).SetLocalPose(0.02931633f,1.494701f,-0.4055491f,0.6996326f,-0.04794767f,-0.5151612f,-0.492772f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0f);
Get(0x6EC6).SetLocalPose(0.1950374f,1.470744f,-0.5717548f,-0.111968f,-0.8958872f,-0.326459f,-0.2797748f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095676f,1.309662f,0.1329408f,-0.7030615f,-0.01446096f,-0.009590056f,0.7109174f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.736884f);
Get(0x6E70).SetLocalPose(-0.02081922f,1.630893f,-0.7020441f,0.4966659f,-0.3764772f,-0.6204204f,0.476095f);
Get(0x6E82).SetLocalPose(0.02986647f,1.496302f,-0.4109116f,0.7064064f,-0.05546879f,-0.5125411f,-0.4849897f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.03472462f);
Get(0x6EC6).SetLocalPose(0.1944436f,1.471937f,-0.5748897f,-0.1136757f,-0.8960501f,-0.321006f,-0.2848284f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095713f,1.309845f,0.1331162f,-0.7030677f,-0.01441741f,-0.009548078f,0.7109127f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.801667f);
Get(0x6E70).SetLocalPose(-0.02002241f,1.631433f,-0.7012542f,0.4939879f,-0.3773437f,-0.6185397f,0.4806209f);
Get(0x6E82).SetLocalPose(0.03028519f,1.499932f,-0.4189993f,0.7189964f,-0.06410278f,-0.5071255f,-0.4709127f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.09950831f);
Get(0x6EC6).SetLocalPose(0.193839f,1.471789f,-0.5781187f,-0.1169f,-0.8958568f,-0.3147589f,-0.2910359f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095164f,1.309576f,0.1330479f,-0.7030675f,-0.01443674f,-0.009664087f,0.7109109f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.861082f);
Get(0x6E70).SetLocalPose(-0.01985671f,1.63189f,-0.6990319f,0.4901117f,-0.3788561f,-0.616027f,0.4865895f);
Get(0x6E82).SetLocalPose(0.02979678f,1.501623f,-0.4252668f,0.7300885f,-0.06721346f,-0.5040257f,-0.4565207f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.1589231f);
Get(0x6EC6).SetLocalPose(0.193658f,1.470041f,-0.5799283f,-0.1212652f,-0.8957038f,-0.3102106f,-0.2945824f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094999f,1.309521f,0.1331581f,-0.7030804f,-0.01442904f,-0.009621141f,0.7108989f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.922197f);
Get(0x6E70).SetLocalPose(-0.01920611f,1.632547f,-0.6963272f,0.4865914f,-0.3802637f,-0.6140102f,0.4915483f);
Get(0x6E82).SetLocalPose(0.02887985f,1.500923f,-0.4283941f,0.7360837f,-0.06530901f,-0.5061423f,-0.4446747f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.2200378f);
Get(0x6EC6).SetLocalPose(0.194416f,1.467524f,-0.5798706f,-0.1257455f,-0.8957129f,-0.3079996f,-0.294996f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095204f,1.309578f,0.133056f,-0.7030774f,-0.01439311f,-0.00957517f,0.7109032f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.982023f);
Get(0x6E70).SetLocalPose(-0.01922997f,1.632901f,-0.6928535f,0.4830351f,-0.3817287f,-0.6122814f,0.4960563f);
Get(0x6E82).SetLocalPose(0.02839099f,1.500165f,-0.4289044f,0.736112f,-0.06137497f,-0.5127955f,-0.4375078f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.2798634f);
Get(0x6EC6).SetLocalPose(0.1945942f,1.464499f,-0.5780351f,-0.1300854f,-0.8955637f,-0.306982f,-0.2946278f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095211f,1.309566f,0.1330166f,-0.7030517f,-0.01442873f,-0.009679494f,0.7109265f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.046017f);
Get(0x6E70).SetLocalPose(-0.01892531f,1.632462f,-0.6890457f,0.4791061f,-0.3833424f,-0.611034f,0.5001435f);
Get(0x6E82).SetLocalPose(0.02794487f,1.498889f,-0.4277216f,0.734165f,-0.05362086f,-0.5209598f,-0.4321198f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.3438582f);
Get(0x6EC6).SetLocalPose(0.1959435f,1.460085f,-0.5742888f,-0.1374598f,-0.8953607f,-0.3054865f,-0.2934484f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095292f,1.30952f,0.133094f,-0.7030849f,-0.01441729f,-0.009633885f,0.7108945f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.073044f);
Get(0x6E70).SetLocalPose(-0.01879735f,1.63211f,-0.6866027f,0.4769578f,-0.3841936f,-0.6106658f,0.50199f);
Get(0x6E82).SetLocalPose(0.02750804f,1.498034f,-0.4261638f,0.7334627f,-0.05107282f,-0.5240172f,-0.4299186f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.3708853f);
Get(0x6EC6).SetLocalPose(0.1964238f,1.457932f,-0.5724075f,-0.1419281f,-0.8951446f,-0.3046821f,-0.2928161f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095089f,1.309573f,0.1331931f,-0.7030477f,-0.01442163f,-0.009579032f,0.710932f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.179049f);
Get(0x6E70).SetLocalPose(-0.01925722f,1.631986f,-0.6764171f,0.4680736f,-0.3875334f,-0.6100667f,0.5084718f);
Get(0x6E82).SetLocalPose(0.02643093f,1.496286f,-0.4188513f,0.7410847f,-0.04162631f,-0.5252587f,-0.4161299f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0f);
Get(0x6EC6).SetLocalPose(0.198045f,1.447894f,-0.56316f,-0.1637105f,-0.8932496f,-0.3030396f,-0.2889136f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095354f,1.309646f,0.1332842f,-0.7030529f,-0.01443802f,-0.009573461f,0.7109265f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.245292f);
Get(0x6E70).SetLocalPose(-0.02033221f,1.633051f,-0.6697671f,0.4621283f,-0.3897204f,-0.6098779f,0.5124495f);
Get(0x6E82).SetLocalPose(0.02724917f,1.49393f,-0.4136199f,0.7437561f,-0.03629762f,-0.5249323f,-0.4122564f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.06624369f);
Get(0x6EC6).SetLocalPose(0.1988148f,1.44189f,-0.5574981f,-0.1766772f,-0.8920946f,-0.3015195f,-0.2864239f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095534f,1.309357f,0.1332407f,-0.7031085f,-0.01439445f,-0.009591468f,0.7108722f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.304269f);
Get(0x6E70).SetLocalPose(-0.02133485f,1.633887f,-0.6624752f,0.456069f,-0.391936f,-0.6094066f,0.5167311f);
Get(0x6E82).SetLocalPose(0.02907817f,1.492144f,-0.4085022f,0.7443122f,-0.03517227f,-0.5244359f,-0.411982f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.1252206f);
Get(0x6EC6).SetLocalPose(0.1992417f,1.436999f,-0.5508552f,-0.189225f,-0.8899277f,-0.3019426f,-0.2846987f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09536f,1.30931f,0.1330643f,-0.7030416f,-0.01438482f,-0.009630078f,0.710938f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.363495f);
Get(0x6E70).SetLocalPose(-0.02287889f,1.635503f,-0.6553853f,0.4506625f,-0.3939483f,-0.6084451f,0.5210592f);
Get(0x6E82).SetLocalPose(0.03227419f,1.491099f,-0.4026086f,0.7491816f,-0.04295508f,-0.5183553f,-0.4101093f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.1844458f);
Get(0x6EC6).SetLocalPose(0.1991419f,1.433581f,-0.5436233f,-0.1974498f,-0.8871317f,-0.3053346f,-0.2842214f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095436f,1.309523f,0.1329487f,-0.7030505f,-0.01441763f,-0.009600157f,0.7109289f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.423899f);
Get(0x6E70).SetLocalPose(-0.02421613f,1.637238f,-0.6475794f,0.4455851f,-0.39579f,-0.6067418f,0.5259929f);
Get(0x6E82).SetLocalPose(0.0366393f,1.49017f,-0.3972737f,0.7676272f,-0.05786327f,-0.4965164f,-0.4010884f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.2448498f);
Get(0x6EC6).SetLocalPose(0.1989186f,1.431504f,-0.53639f,-0.197784f,-0.8848848f,-0.3124815f,-0.283224f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095222f,1.309428f,0.1328766f,-0.7031128f,-0.01436691f,-0.009586737f,0.7108686f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.484359f);
Get(0x6E70).SetLocalPose(-0.02561922f,1.639278f,-0.6407415f,0.4424141f,-0.3969177f,-0.6053346f,0.52943f);
Get(0x6E82).SetLocalPose(0.04270511f,1.488235f,-0.3930528f,0.7931178f,-0.07626146f,-0.4614724f,-0.3901174f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.3053098f);
Get(0x6EC6).SetLocalPose(0.1972558f,1.429159f,-0.52558f,-0.1854528f,-0.8846459f,-0.3261179f,-0.2768683f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095209f,1.309322f,0.132686f,-0.7030376f,-0.01439941f,-0.009625085f,0.7109419f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.544604f);
Get(0x6E70).SetLocalPose(-0.02717645f,1.643933f,-0.6304787f,0.4386054f,-0.3980485f,-0.6037384f,0.5335566f);
Get(0x6E82).SetLocalPose(0.04894842f,1.487614f,-0.3889475f,0.8112811f,-0.09960568f,-0.4299683f,-0.3834435f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.3655557f);
Get(0x6EC6).SetLocalPose(0.1955575f,1.428459f,-0.5176472f,-0.1683714f,-0.8883387f,-0.334403f,-0.2658573f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.544604f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.3655557f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09543f,1.309396f,0.1329125f,-0.7030853f,-0.01440903f,-0.009635067f,0.7108943f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.686473f);
Get(0x6E70).SetLocalPose(-0.02836815f,1.650822f,-0.6134475f,0.4351841f,-0.3980586f,-0.6025849f,0.537639f);
Get(0x6E82).SetLocalPose(0.05817814f,1.485184f,-0.3742953f,0.8182456f,-0.1593857f,-0.4065806f,-0.3738485f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.507424f);
Get(0x6EC6).SetLocalPose(0.1916787f,1.42804f,-0.4993835f,-0.1279642f,-0.900743f,-0.3463422f,-0.2287669f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095138f,1.30964f,0.1330552f,-0.7030635f,-0.01441337f,-0.00962801f,0.7109158f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.748741f);
Get(0x6E70).SetLocalPose(-0.02842296f,1.654545f,-0.6062046f,0.4344581f,-0.3974755f,-0.6028003f,0.5384156f);
Get(0x6E82).SetLocalPose(0.05890005f,1.485727f,-0.3660112f,0.8052307f,-0.1650075f,-0.4200253f,-0.384649f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.5696929f);
Get(0x6EC6).SetLocalPose(0.1922079f,1.428864f,-0.4927947f,-0.1256796f,-0.9003877f,-0.3490174f,-0.2273621f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095465f,1.309581f,0.1332143f,-0.7030905f,-0.01437595f,-0.009590539f,0.7108904f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.80911f);
Get(0x6E70).SetLocalPose(-0.02804934f,1.656559f,-0.6000552f,0.4340483f,-0.3966525f,-0.6036718f,0.5383765f);
Get(0x6E82).SetLocalPose(0.05735666f,1.487736f,-0.3582247f,0.7855699f,-0.1656126f,-0.4469879f,-0.3945304f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.6300612f);
Get(0x6EC6).SetLocalPose(0.1937585f,1.429026f,-0.4891809f,-0.1279376f,-0.8984298f,-0.3485237f,-0.2344938f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095269f,1.309201f,0.1332943f,-0.7031073f,-0.01439786f,-0.009647731f,0.7108726f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.03220892f);
Get(0x6E70).SetLocalPose(-0.02790194f,1.658888f,-0.5937284f,0.4339418f,-0.3956069f,-0.6050882f,0.5376411f);
Get(0x6E82).SetLocalPose(0.05589258f,1.490128f,-0.3485085f,0.7529595f,-0.1582246f,-0.490367f,-0.4093376f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.6892363f);
Get(0x6EC6).SetLocalPose(0.1985825f,1.430892f,-0.4828779f,-0.1363498f,-0.8901244f,-0.3459156f,-0.2634948f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095047f,1.30938f,0.1333216f,-0.7030968f,-0.0144006f,-0.009642378f,0.710883f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.09451784f);
Get(0x6E70).SetLocalPose(-0.02715334f,1.659934f,-0.5879678f,0.4340731f,-0.3941551f,-0.6069996f,0.5364457f);
Get(0x6E82).SetLocalPose(0.05609941f,1.491791f,-0.3399322f,0.7213643f,-0.1470661f,-0.5271454f,-0.4244088f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.7515452f);
Get(0x6EC6).SetLocalPose(0.202224f,1.433574f,-0.4780095f,-0.1452808f,-0.881223f,-0.3452365f,-0.2883598f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094934f,1.309327f,0.1334537f,-0.7030782f,-0.014398f,-0.009594453f,0.710902f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.1544868f);
Get(0x6E70).SetLocalPose(-0.02558222f,1.659087f,-0.5846047f,0.4346205f,-0.3922303f,-0.6094717f,0.5346071f);
Get(0x6E82).SetLocalPose(0.05698606f,1.49314f,-0.3333915f,0.6906208f,-0.1366763f,-0.5608925f,-0.4356171f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.8115141f);
Get(0x6EC6).SetLocalPose(0.2039376f,1.434255f,-0.4755782f,-0.1498286f,-0.8768447f,-0.3430167f,-0.3017188f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094779f,1.309396f,0.133398f,-0.7030795f,-0.01438606f,-0.009648909f,0.7109003f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.1843421f);
Get(0x6E70).SetLocalPose(-0.02485998f,1.658795f,-0.5825777f,0.4350969f,-0.3911337f,-0.6108974f,0.5333943f);
Get(0x6E82).SetLocalPose(0.05764318f,1.493322f,-0.3303556f,0.6746969f,-0.1307222f,-0.5785748f,-0.4392573f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.8413695f);
Get(0x6EC6).SetLocalPose(0.2047019f,1.435369f,-0.4748087f,-0.1499688f,-0.876011f,-0.3393974f,-0.3080966f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.1843421f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.8413695f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094969f,1.3097f,0.1330237f,-0.7030578f,-0.0143735f,-0.009607926f,0.7109225f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.327648f);
Get(0x6E70).SetLocalPose(-0.02107969f,1.652362f,-0.5788358f,0.4397805f,-0.3847892f,-0.6179625f,0.5259778f);
Get(0x6E82).SetLocalPose(0.06214772f,1.486662f,-0.3292192f,0.6289669f,-0.1094407f,-0.6302209f,-0.4418653f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.9846753f);
Get(0x6EC6).SetLocalPose(0.2060484f,1.436229f,-0.4764489f,-0.1532727f,-0.8770207f,-0.3162713f,-0.3275895f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094856f,1.309866f,0.1330457f,-0.7030698f,-0.01439001f,-0.009667002f,0.7109095f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.3890572f);
Get(0x6E70).SetLocalPose(-0.01977401f,1.649383f,-0.5788614f,0.441589f,-0.3826904f,-0.6203071f,0.523227f);
Get(0x6E82).SetLocalPose(0.06389131f,1.481668f,-0.3326302f,0.6074107f,-0.09831581f,-0.6545773f,-0.4392208f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.046085f);
Get(0x6EC6).SetLocalPose(0.2065884f,1.435188f,-0.4785433f,-0.1606609f,-0.8728623f,-0.3044709f,-0.3458281f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094942f,1.309849f,0.1329582f,-0.7030842f,-0.01437839f,-0.009639067f,0.710896f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.4504812f);
Get(0x6E70).SetLocalPose(-0.01829437f,1.645994f,-0.5800703f,0.4421079f,-0.3818315f,-0.6219717f,0.5214369f);
Get(0x6E82).SetLocalPose(0.06611083f,1.473925f,-0.3391439f,0.5879283f,-0.08785605f,-0.6762576f,-0.4350832f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.107509f);
Get(0x6EC6).SetLocalPose(0.2065068f,1.433964f,-0.4813982f,-0.1647647f,-0.8693361f,-0.2942779f,-0.3612588f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094974f,1.309376f,0.132908f,-0.7030513f,-0.01434144f,-0.009683472f,0.7109286f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.5127385f);
Get(0x6E70).SetLocalPose(-0.01633636f,1.640731f,-0.5828094f,0.441751f,-0.3818657f,-0.6234252f,0.5199767f);
Get(0x6E82).SetLocalPose(0.06699876f,1.467922f,-0.3470207f,0.569185f,-0.08071444f,-0.6974374f,-0.4278958f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.169766f);
Get(0x6EC6).SetLocalPose(0.2060432f,1.43198f,-0.4857785f,-0.1648791f,-0.8676112f,-0.2839245f,-0.3734338f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094749f,1.309066f,0.1328733f,-0.7030461f,-0.01432366f,-0.009737064f,0.7109333f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.5755277f);
Get(0x6E70).SetLocalPose(-0.01426182f,1.633821f,-0.5871013f,0.4407416f,-0.3825485f,-0.6249272f,0.5185262f);
Get(0x6E82).SetLocalPose(0.06752609f,1.461651f,-0.3566942f,0.5537927f,-0.07522308f,-0.7171744f,-0.4163126f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.232555f);
Get(0x6EC6).SetLocalPose(0.2051182f,1.429217f,-0.4928369f,-0.1621696f,-0.8687732f,-0.2711211f,-0.3813494f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094882f,1.309236f,0.1328429f,-0.7030764f,-0.01436009f,-0.009674121f,0.7109036f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.6370333f);
Get(0x6E70).SetLocalPose(-0.01230314f,1.627038f,-0.5923169f,0.4391528f,-0.3834546f,-0.6266099f,0.5171726f);
Get(0x6E82).SetLocalPose(0.06746849f,1.455995f,-0.3690955f,0.5413406f,-0.06987646f,-0.7352759f,-0.4017924f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.29406f);
Get(0x6EC6).SetLocalPose(0.2043221f,1.424261f,-0.5000693f,-0.1603967f,-0.8696235f,-0.261047f,-0.3871464f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094785f,1.309137f,0.1327184f,-0.7030597f,-0.01436856f,-0.009671438f,0.71092f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.6659114f);
Get(0x6E70).SetLocalPose(-0.01129258f,1.622752f,-0.5961412f,0.4378881f,-0.3840819f,-0.6277131f,0.5164413f);
Get(0x6E82).SetLocalPose(0.06670194f,1.454371f,-0.3749624f,0.5365427f,-0.06765367f,-0.7428529f,-0.3946068f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.322939f);
Get(0x6EC6).SetLocalPose(0.2040241f,1.422731f,-0.5033983f,-0.1599766f,-0.8695396f,-0.2573089f,-0.3900007f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.6659114f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.322939f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095181f,1.3096f,0.1332336f,-0.7030853f,-0.0143508f,-0.009698987f,0.7108946f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.8131293f);
Get(0x6E70).SetLocalPose(-0.007007794f,1.606809f,-0.6148999f,0.434269f,-0.3859643f,-0.6295316f,0.5158799f);
Get(0x6E82).SetLocalPose(0.06249173f,1.447855f,-0.4016654f,0.5154874f,-0.05529732f,-0.7747179f,-0.3619767f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.470156f);
Get(0x6EC6).SetLocalPose(0.2057284f,1.414861f,-0.5234293f,-0.1629151f,-0.8658119f,-0.2372651f,-0.4093088f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094973f,1.309335f,0.1331196f,-0.7030584f,-0.01436825f,-0.009705008f,0.7109208f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.8727303f);
Get(0x6E70).SetLocalPose(-0.004785949f,1.600442f,-0.6255896f,0.4334791f,-0.3866816f,-0.6293318f,0.5162507f);
Get(0x6E82).SetLocalPose(0.05979064f,1.448528f,-0.4117181f,0.5091292f,-0.04877827f,-0.7842941f,-0.3511281f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.529757f);
Get(0x6EC6).SetLocalPose(0.2078621f,1.413627f,-0.5353221f,-0.1643367f,-0.864668f,-0.2285847f,-0.416043f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094808f,1.309065f,0.1330896f,-0.7030534f,-0.0143572f,-0.009713599f,0.7109258f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.937713f);
Get(0x6E70).SetLocalPose(-0.002236109f,1.595497f,-0.6385089f,0.4332255f,-0.3871048f,-0.6291181f,0.5164068f);
Get(0x6E82).SetLocalPose(0.05872993f,1.453254f,-0.420989f,0.5012323f,-0.04311034f,-0.7934505f,-0.3425552f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.59474f);
Get(0x6EC6).SetLocalPose(0.2098178f,1.416446f,-0.5442638f,-0.1617228f,-0.8638608f,-0.2251022f,-0.4206176f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094844f,1.309137f,0.1330703f,-0.7030826f,-0.0143717f,-0.009693976f,0.7108968f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.001334f);
Get(0x6E70).SetLocalPose(0.0001533404f,1.59313f,-0.6510134f,0.4340414f,-0.3866594f,-0.629002f,0.5161966f);
Get(0x6E82).SetLocalPose(0.0583479f,1.461796f,-0.4283649f,0.4942774f,-0.03659154f,-0.8002711f,-0.3375162f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.658361f);
Get(0x6EC6).SetLocalPose(0.2132514f,1.422616f,-0.5533574f,-0.1570116f,-0.8635753f,-0.2240229f,-0.4235552f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094774f,1.309515f,0.1331626f,-0.703032f,-0.01441485f,-0.009703748f,0.7109459f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.063351f);
Get(0x6E70).SetLocalPose(0.003052122f,1.592941f,-0.6635787f,0.4365211f,-0.3850195f,-0.6287591f,0.5156271f);
Get(0x6E82).SetLocalPose(0.0600796f,1.47144f,-0.4334704f,0.4931075f,-0.03097425f,-0.8021257f,-0.3353803f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.720378f);
Get(0x6EC6).SetLocalPose(0.2170714f,1.430684f,-0.5613008f,-0.15346f,-0.8648477f,-0.2240517f,-0.4222434f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094836f,1.309616f,0.1331328f,-0.7030452f,-0.01439271f,-0.009661959f,0.7109339f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.124053f);
Get(0x6E70).SetLocalPose(0.006973531f,1.594937f,-0.6769122f,0.4388538f,-0.3833796f,-0.6297066f,0.5137091f);
Get(0x6E82).SetLocalPose(0.06117984f,1.48175f,-0.4366412f,0.4945333f,-0.02517028f,-0.801222f,-0.3359266f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.78108f);
Get(0x6EC6).SetLocalPose(0.2222546f,1.44232f,-0.5713977f,-0.1524539f,-0.8649903f,-0.2258461f,-0.4213588f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094945f,1.309411f,0.1331759f,-0.7030817f,-0.0143798f,-0.009671003f,0.7108979f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.153901f);
Get(0x6E70).SetLocalPose(0.009615138f,1.597963f,-0.684796f,0.4400148f,-0.3822417f,-0.630696f,0.5123484f);
Get(0x6E82).SetLocalPose(0.06219579f,1.488559f,-0.4378006f,0.4971458f,-0.01967555f,-0.7986509f,-0.3385496f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.810928f);
Get(0x6EC6).SetLocalPose(0.2251953f,1.447907f,-0.5756307f,-0.1525655f,-0.8637988f,-0.2276494f,-0.4227897f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09521f,1.309314f,0.1332813f,-0.7030624f,-0.01437688f,-0.009733224f,0.7109163f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.257922f);
Get(0x6E70).SetLocalPose(0.01804484f,1.614588f,-0.7060866f,0.440721f,-0.3795104f,-0.6338342f,0.5098933f);
Get(0x6E82).SetLocalPose(0.06592699f,1.502451f,-0.438085f,0.4992774f,0.002178226f,-0.7922442f,-0.3508084f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.914949f);
Get(0x6EC6).SetLocalPose(0.2341121f,1.470477f,-0.5910209f,-0.1518562f,-0.8642398f,-0.2358918f,-0.4175936f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095317f,1.309435f,0.1331824f,-0.7030585f,-0.01440672f,-0.009640347f,0.7109208f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.325383f);
Get(0x6E70).SetLocalPose(0.02240738f,1.625377f,-0.7153338f,0.4392946f,-0.3787948f,-0.6351617f,0.5100044f);
Get(0x6E82).SetLocalPose(0.06743895f,1.50659f,-0.4381132f,0.4962162f,0.009296769f,-0.7926365f,-0.3541335f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.98241f);
Get(0x6EC6).SetLocalPose(0.2387777f,1.483967f,-0.6011452f,-0.1498982f,-0.8709731f,-0.2400532f,-0.4016353f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095407f,1.309436f,0.1333375f,-0.703082f,-0.01442388f,-0.0096551f,0.7108968f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.384298f);
Get(0x6E70).SetLocalPose(0.02628259f,1.63548f,-0.7227731f,0.4366224f,-0.3788296f,-0.6361029f,0.511099f);
Get(0x6E82).SetLocalPose(0.07305858f,1.520798f,-0.4419635f,0.4855125f,0.02749015f,-0.7951412f,-0.3623153f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.041325f);
Get(0x6EC6).SetLocalPose(0.2424413f,1.495435f,-0.6097377f,-0.1484845f,-0.8750641f,-0.244917f,-0.3901678f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095392f,1.309642f,0.1332828f,-0.7030842f,-0.01445f,-0.009656767f,0.7108943f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.443978f);
Get(0x6E70).SetLocalPose(0.0336732f,1.654166f,-0.7370697f,0.4276641f,-0.3802537f,-0.6365795f,0.5169887f);
Get(0x6E82).SetLocalPose(0.08158298f,1.537064f,-0.4528637f,0.4844333f,0.03127935f,-0.7937121f,-0.3665612f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.101006f);
Get(0x6EC6).SetLocalPose(0.2478023f,1.506919f,-0.6195689f,-0.1483912f,-0.873499f,-0.2510461f,-0.3898145f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095482f,1.309599f,0.1333073f,-0.70308f,-0.01439707f,-0.009615029f,0.7109001f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.501822f);
Get(0x6E70).SetLocalPose(0.03872146f,1.66474f,-0.7471957f,0.4207054f,-0.3810082f,-0.6357019f,0.5231853f);
Get(0x6E82).SetLocalPose(0.08949268f,1.547983f,-0.4662926f,0.4871066f,0.02239271f,-0.7933826f,-0.3643759f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.158849f);
Get(0x6EC6).SetLocalPose(0.2510641f,1.51411f,-0.6279394f,-0.1484625f,-0.8727148f,-0.2532873f,-0.3900939f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095706f,1.309588f,0.1332811f,-0.7031125f,-0.01448181f,-0.009598264f,0.7108663f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.563891f);
Get(0x6E70).SetLocalPose(0.04239031f,1.670406f,-0.7566453f,0.4149724f,-0.3810941f,-0.6350642f,0.5284493f);
Get(0x6E82).SetLocalPose(0.09924764f,1.557772f,-0.483915f,0.4872994f,0.007251932f,-0.7948643f,-0.3614933f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.220918f);
Get(0x6EC6).SetLocalPose(0.2551821f,1.522205f,-0.6409502f,-0.1494967f,-0.8762608f,-0.2513497f,-0.3829375f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09571f,1.309576f,0.1332273f,-0.7031185f,-0.01448001f,-0.009586062f,0.7108607f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.621991f);
Get(0x6E70).SetLocalPose(0.0461044f,1.672994f,-0.7685879f,0.4099241f,-0.3798441f,-0.6354011f,0.532866f);
Get(0x6E82).SetLocalPose(0.1101299f,1.56423f,-0.5032447f,0.4823716f,-0.00857562f,-0.799511f,-0.3578077f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.279018f);
Get(0x6EC6).SetLocalPose(0.2581534f,1.52635f,-0.6529928f,-0.1521527f,-0.8789507f,-0.2477267f,-0.3780567f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.621991f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.279018f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095856f,1.309649f,0.1333042f,-0.7031167f,-0.01446819f,-0.009587939f,0.7108626f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.756812f);
Get(0x6E70).SetLocalPose(0.05092638f,1.660731f,-0.799606f,0.4073421f,-0.3701054f,-0.641513f,0.5343738f);
Get(0x6E82).SetLocalPose(0.1354542f,1.574197f,-0.5579474f,0.4749874f,-0.06512416f,-0.8071536f,-0.3444545f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.41384f);
Get(0x6EC6).SetLocalPose(0.2632457f,1.529338f,-0.689539f,-0.1564735f,-0.876352f,-0.2343403f,-0.3906505f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095836f,1.309673f,0.1335118f,-0.7031381f,-0.01447621f,-0.009568391f,0.7108416f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.819453f);
Get(0x6E70).SetLocalPose(0.05282239f,1.649511f,-0.8158812f,0.4072784f,-0.365088f,-0.6470357f,0.5312061f);
Get(0x6E82).SetLocalPose(0.1447418f,1.573495f,-0.5918756f,0.4814979f,-0.09740248f,-0.8034749f,-0.3363044f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.476481f);
Get(0x6EC6).SetLocalPose(0.2638298f,1.527831f,-0.7059168f,-0.1529838f,-0.8775034f,-0.2273822f,-0.3935494f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095679f,1.309646f,0.1333177f,-0.7031151f,-0.01446779f,-0.009556748f,0.7108647f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.878031f);
Get(0x6E70).SetLocalPose(0.05396936f,1.639458f,-0.8290466f,0.4066111f,-0.3616382f,-0.6523017f,0.5276247f);
Get(0x6E82).SetLocalPose(0.1504088f,1.569699f,-0.6224174f,0.4875838f,-0.1270875f,-0.8007663f,-0.3238583f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.535059f);
Get(0x6EC6).SetLocalPose(0.2637417f,1.522249f,-0.7268412f,-0.1483958f,-0.8810275f,-0.2167163f,-0.3934506f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095608f,1.309705f,0.1334596f,-0.7031213f,-0.01446615f,-0.009588309f,0.7108582f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.938369f);
Get(0x6E70).SetLocalPose(0.05562486f,1.622591f,-0.8495649f,0.4055543f,-0.3575377f,-0.6590236f,0.522858f);
Get(0x6E82).SetLocalPose(0.1524869f,1.565812f,-0.6503135f,0.4972038f,-0.1524742f,-0.795296f,-0.3115196f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.595396f);
Get(0x6EC6).SetLocalPose(0.2636217f,1.514781f,-0.7483121f,-0.1430416f,-0.8839471f,-0.2033321f,-0.3960212f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095585f,1.309529f,0.13328f,-0.7030936f,-0.01444263f,-0.009579631f,0.7108862f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.997102f);
Get(0x6E70).SetLocalPose(0.05662894f,1.608801f,-0.8649383f,0.405435f,-0.3557482f,-0.6612746f,0.5213269f);
Get(0x6E82).SetLocalPose(0.150137f,1.557257f,-0.681872f,0.5234731f,-0.1734913f,-0.7804064f,-0.2946906f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.65413f);
Get(0x6EC6).SetLocalPose(0.2639853f,1.507779f,-0.7694097f,-0.1383989f,-0.8832835f,-0.1890843f,-0.4060826f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09542f,1.309412f,0.133156f,-0.7030962f,-0.0144749f,-0.009562668f,0.7108831f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.055704f);
Get(0x6E70).SetLocalPose(0.05828866f,1.594748f,-0.8801593f,0.4063569f,-0.3544925f,-0.6627433f,0.5195965f);
Get(0x6E82).SetLocalPose(0.1472479f,1.549021f,-0.7035872f,0.537503f,-0.1861829f,-0.7714784f,-0.2850394f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.712731f);
Get(0x6EC6).SetLocalPose(0.2658969f,1.495728f,-0.7926095f,-0.1336282f,-0.8814899f,-0.1773574f,-0.4167296f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095295f,1.309334f,0.1330341f,-0.7030761f,-0.01445223f,-0.009614145f,0.7109028f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.085221f);
Get(0x6E70).SetLocalPose(0.0593899f,1.586027f,-0.8896068f,0.4074832f,-0.3538448f,-0.663484f,0.5182088f);
Get(0x6E82).SetLocalPose(0.1449185f,1.54217f,-0.718959f,0.5383244f,-0.1952079f,-0.7721083f,-0.2755895f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.742249f);
Get(0x6EC6).SetLocalPose(0.2672344f,1.487512f,-0.8037329f,-0.1305845f,-0.880153f,-0.1723709f,-0.4225715f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.085221f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.742249f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09574f,1.309616f,0.1329701f,-0.7030784f,-0.01451222f,-0.009561815f,0.7109f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.228927f);
Get(0x6E70).SetLocalPose(0.06731266f,1.556162f,-0.9226297f,0.4083747f,-0.3537259f,-0.6708443f,0.5080119f);
Get(0x6E82).SetLocalPose(0.1425003f,1.510044f,-0.7689155f,0.5445112f,-0.2163103f,-0.7638515f,-0.2706442f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.885954f);
Get(0x6EC6).SetLocalPose(0.2730935f,1.453765f,-0.851608f,-0.1410305f,-0.878274f,-0.1484667f,-0.4320912f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095429f,1.309932f,0.1331408f,-0.7030704f,-0.01442916f,-0.00956649f,0.7109095f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.313669f);
Get(0x6E70).SetLocalPose(0.07313558f,1.543175f,-0.9395256f,0.4102363f,-0.3490055f,-0.6828073f,0.4936351f);
Get(0x6E82).SetLocalPose(0.1461926f,1.493902f,-0.7938155f,0.5583332f,-0.2217374f,-0.7500871f,-0.2765247f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.970697f);
Get(0x6EC6).SetLocalPose(0.2775974f,1.436998f,-0.8696744f,-0.1532783f,-0.8757163f,-0.1408473f,-0.4356475f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095081f,1.309879f,0.1331264f,-0.7030731f,-0.01443598f,-0.009558407f,0.7109069f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.374204f);
Get(0x6E70).SetLocalPose(0.07703093f,1.539559f,-0.9485719f,0.4102994f,-0.3448492f,-0.6916238f,0.4841385f);
Get(0x6E82).SetLocalPose(0.1513668f,1.48506f,-0.8092083f,0.5723369f,-0.2235329f,-0.7362385f,-0.2835779f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.031231f);
Get(0x6EC6).SetLocalPose(0.2811053f,1.426498f,-0.8812762f,-0.1673838f,-0.8743591f,-0.1361478f,-0.4346754f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095076f,1.310025f,0.133148f,-0.7030613f,-0.01449793f,-0.009544971f,0.7109174f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.402308f);
Get(0x6E70).SetLocalPose(0.08013926f,1.539435f,-0.9535444f,0.4075258f,-0.3429777f,-0.6976547f,0.4791316f);
Get(0x6E82).SetLocalPose(0.1553641f,1.480858f,-0.8161075f,0.5819896f,-0.2246391f,-0.7263913f,-0.2884112f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.059335f);
Get(0x6EC6).SetLocalPose(0.2831814f,1.421967f,-0.8871378f,-0.1778268f,-0.8749657f,-0.1332544f,-0.4301814f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095438f,1.309767f,0.1330459f,-0.7030781f,-0.01440845f,-0.009560203f,0.7109024f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.497267f);
Get(0x6E70).SetLocalPose(0.08725565f,1.543598f,-0.9607648f,0.3910785f,-0.3409607f,-0.7106656f,0.4751397f);
Get(0x6E82).SetLocalPose(0.1662655f,1.477748f,-0.8267787f,0.5938646f,-0.2363527f,-0.7092794f,-0.2972964f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.154294f);
Get(0x6EC6).SetLocalPose(0.288219f,1.416785f,-0.8960971f,-0.2001885f,-0.8776277f,-0.1281547f,-0.4162578f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09555f,1.310014f,0.1331486f,-0.7030588f,-0.0144345f,-0.009590426f,0.7109206f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.556871f);
Get(0x6E70).SetLocalPose(0.09228525f,1.549623f,-0.9625197f,0.3769217f,-0.337971f,-0.7175677f,0.4783328f);
Get(0x6E82).SetLocalPose(0.1735544f,1.480174f,-0.8269583f,0.5890456f,-0.2413044f,-0.7079025f,-0.3060583f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.213898f);
Get(0x6EC6).SetLocalPose(0.2919042f,1.415753f,-0.8981355f,-0.2121764f,-0.8770921f,-0.1283636f,-0.4113558f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.556871f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.213898f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095856f,1.309514f,0.1330044f,-0.7030672f,-0.0144765f,-0.009527831f,0.7109122f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.656851f);
Get(0x6E70).SetLocalPose(0.09969851f,1.564166f,-0.9607292f,0.3548447f,-0.3254991f,-0.7276758f,0.4884912f);
Get(0x6E82).SetLocalPose(0.1896478f,1.492323f,-0.8154612f,0.556604f,-0.2382236f,-0.7219197f,-0.3350726f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.313879f);
Get(0x6EC6).SetLocalPose(0.3019648f,1.421958f,-0.8934094f,-0.238329f,-0.8696399f,-0.1325724f,-0.4115221f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095689f,1.30966f,0.1328584f,-0.7030567f,-0.01439556f,-0.009625723f,0.710923f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.714313f);
Get(0x6E70).SetLocalPose(0.1017535f,1.570954f,-0.957276f,0.3457942f,-0.3167286f,-0.7314955f,0.4949988f);
Get(0x6E82).SetLocalPose(0.1951308f,1.498845f,-0.8082938f,0.5432968f,-0.2370859f,-0.7281051f,-0.344212f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.37134f);
Get(0x6EC6).SetLocalPose(0.3047119f,1.42734f,-0.8893822f,-0.2477921f,-0.8708005f,-0.1304321f,-0.4040953f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095556f,1.310012f,0.1330304f,-0.7030268f,-0.01439531f,-0.009608011f,0.7109528f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.800339f);
Get(0x6E70).SetLocalPose(0.101817f,1.575684f,-0.9532524f,0.3408051f,-0.3100584f,-0.7328883f,0.5005901f);
Get(0x6E82).SetLocalPose(0.1982895f,1.506592f,-0.8002308f,0.537766f,-0.2356908f,-0.7303482f,-0.349069f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.457367f);
Get(0x6EC6).SetLocalPose(0.305683f,1.434666f,-0.8839783f,-0.2524388f,-0.8759787f,-0.1279008f,-0.3906114f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095639f,1.30997f,0.1330053f,-0.7030554f,-0.01447127f,-0.009529144f,0.710924f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.85948f);
Get(0x6E70).SetLocalPose(0.1006614f,1.578684f,-0.9477284f,0.3373697f,-0.3042521f,-0.7324755f,0.5070425f);
Get(0x6E82).SetLocalPose(0.1967474f,1.513699f,-0.7929854f,0.5363612f,-0.235337f,-0.733344f,-0.3451663f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.516508f);
Get(0x6EC6).SetLocalPose(0.3053331f,1.441897f,-0.8776413f,-0.2468914f,-0.8793857f,-0.1274493f,-0.3866291f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095495f,1.30982f,0.133011f,-0.7030743f,-0.01441747f,-0.009594337f,0.7109056f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.916672f);
Get(0x6E70).SetLocalPose(0.09876493f,1.578579f,-0.941629f,0.3354009f,-0.300741f,-0.730622f,0.5130816f);
Get(0x6E82).SetLocalPose(0.1931288f,1.517493f,-0.788259f,0.5371205f,-0.2348342f,-0.7370756f,-0.3362651f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.573699f);
Get(0x6EC6).SetLocalPose(0.3038871f,1.44744f,-0.8708973f,-0.234948f,-0.8809987f,-0.1295258f,-0.3896972f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095488f,1.309566f,0.1330461f,-0.7030841f,-0.01437272f,-0.009591155f,0.7108968f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.981368f);
Get(0x6E70).SetLocalPose(0.095626f,1.576549f,-0.9326325f,0.334505f,-0.2983646f,-0.727264f,0.5197809f);
Get(0x6E82).SetLocalPose(0.185354f,1.520225f,-0.7825412f,0.5417462f,-0.2301319f,-0.7420478f,-0.3208046f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.638395f);
Get(0x6EC6).SetLocalPose(0.2988605f,1.451851f,-0.8639681f,-0.2196641f,-0.8838185f,-0.1314724f,-0.3915707f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095162f,1.309538f,0.1329231f,-0.7030419f,-0.01439106f,-0.009562977f,0.7109386f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.043571f);
Get(0x6E70).SetLocalPose(0.0915701f,1.572748f,-0.9230503f,0.336265f,-0.2974148f,-0.7239549f,0.5237936f);
Get(0x6E82).SetLocalPose(0.1767096f,1.518451f,-0.7778079f,0.5522441f,-0.2206134f,-0.7446777f,-0.303004f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.700598f);
Get(0x6EC6).SetLocalPose(0.2920004f,1.453398f,-0.8590659f,-0.2067099f,-0.8879462f,-0.1322319f,-0.3890209f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.043571f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.700598f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095428f,1.309705f,0.1328318f,-0.7030678f,-0.01445126f,-0.009570415f,0.7109116f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.152747f);
Get(0x6E70).SetLocalPose(0.08043415f,1.558205f,-0.9021124f,0.3482278f,-0.2963246f,-0.7181542f,0.5245795f);
Get(0x6E82).SetLocalPose(0.1621014f,1.506005f,-0.7684193f,0.5759968f,-0.2094122f,-0.7401892f,-0.2765759f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.809774f);
Get(0x6EC6).SetLocalPose(0.2790466f,1.447125f,-0.8479717f,-0.1825947f,-0.8999329f,-0.140239f,-0.3702877f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095474f,1.309705f,0.1328625f,-0.7030683f,-0.01443336f,-0.009593895f,0.7109111f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.222722f);
Get(0x6E70).SetLocalPose(0.07309324f,1.54925f,-0.8894102f,0.3588794f,-0.2962385f,-0.7149499f,0.5218189f);
Get(0x6E82).SetLocalPose(0.1542094f,1.497554f,-0.7586794f,0.5782811f,-0.2054746f,-0.741501f,-0.2711965f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.879749f);
Get(0x6EC6).SetLocalPose(0.2718447f,1.440207f,-0.8396793f,-0.1700613f,-0.904541f,-0.1489387f,-0.3615273f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095057f,1.309218f,0.1327111f,-0.7030476f,-0.01439169f,-0.009626357f,0.710932f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.283498f);
Get(0x6E70).SetLocalPose(0.0653596f,1.541911f,-0.8765006f,0.3697198f,-0.297455f,-0.71213f,0.5173962f);
Get(0x6E82).SetLocalPose(0.1485848f,1.489375f,-0.7468333f,0.5721826f,-0.20278f,-0.7471018f,-0.2707881f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.940525f);
Get(0x6EC6).SetLocalPose(0.2676727f,1.432689f,-0.829798f,-0.1616366f,-0.905691f,-0.1575666f,-0.3588457f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095157f,1.30903f,0.1327435f,-0.7030682f,-0.0143712f,-0.009591305f,0.7109126f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.34429f);
Get(0x6E70).SetLocalPose(0.05685874f,1.535586f,-0.8613508f,0.3818022f,-0.3003636f,-0.71004f,0.5097568f);
Get(0x6E82).SetLocalPose(0.143974f,1.480488f,-0.7328002f,0.565527f,-0.2007218f,-0.751385f,-0.2744278f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.001317f);
Get(0x6EC6).SetLocalPose(0.2643656f,1.423517f,-0.818223f,-0.1592401f,-0.9070053f,-0.1677603f,-0.3519096f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095382f,1.309045f,0.1327731f,-0.7030733f,-0.01440297f,-0.009608455f,0.7109067f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.402811f);
Get(0x6E70).SetLocalPose(0.04744003f,1.53203f,-0.8431979f,0.3936358f,-0.305377f,-0.7085091f,0.4998107f);
Get(0x6E82).SetLocalPose(0.1403698f,1.474031f,-0.7204368f,0.5625679f,-0.1997818f,-0.7514728f,-0.2808795f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.059838f);
Get(0x6EC6).SetLocalPose(0.262648f,1.417573f,-0.8079252f,-0.1613169f,-0.9079431f,-0.1761029f,-0.3443894f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095265f,1.309407f,0.1331169f,-0.7030862f,-0.01440811f,-0.009641129f,0.7108934f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.464039f);
Get(0x6E70).SetLocalPose(0.03921212f,1.532386f,-0.8257137f,0.4026423f,-0.3109739f,-0.706569f,0.4918686f);
Get(0x6E82).SetLocalPose(0.1351766f,1.46903f,-0.7003121f,0.5641799f,-0.2029229f,-0.7464226f,-0.2887504f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.121066f);
Get(0x6EC6).SetLocalPose(0.2605206f,1.41228f,-0.7906485f,-0.1615764f,-0.9062511f,-0.1880453f,-0.3424047f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09494f,1.309555f,0.1331943f,-0.7030994f,-0.01437004f,-0.009630593f,0.7108812f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.524779f);
Get(0x6E70).SetLocalPose(0.03278724f,1.535398f,-0.8104635f,0.4099973f,-0.3159209f,-0.7038717f,0.4864779f);
Get(0x6E82).SetLocalPose(0.1299227f,1.46795f,-0.6831959f,0.5665759f,-0.2007571f,-0.7433449f,-0.2934735f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.181807f);
Get(0x6EC6).SetLocalPose(0.2587408f,1.410568f,-0.7743248f,-0.1595256f,-0.9041105f,-0.198076f,-0.3433683f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.524779f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.181807f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095212f,1.309644f,0.1331455f,-0.7030944f,-0.01444388f,-0.009608149f,0.710885f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.661221f);
Get(0x6E70).SetLocalPose(0.01970133f,1.55209f,-0.7749839f,0.4235246f,-0.3262345f,-0.6988567f,0.4751813f);
Get(0x6E82).SetLocalPose(0.1173462f,1.477437f,-0.6318775f,0.5405695f,-0.1790879f,-0.7608812f,-0.3110816f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.318249f);
Get(0x6EC6).SetLocalPose(0.2532121f,1.420481f,-0.7355562f,-0.1561959f,-0.9054242f,-0.2143901f,-0.3314316f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09525f,1.309579f,0.1330867f,-0.7030945f,-0.01440488f,-0.009606285f,0.7108857f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.724284f);
Get(0x6E70).SetLocalPose(0.01514652f,1.565158f,-0.7582062f,0.427507f,-0.331796f,-0.6958336f,0.4721917f);
Get(0x6E82).SetLocalPose(0.1105159f,1.486284f,-0.6065236f,0.5154097f,-0.166468f,-0.7794669f,-0.3147579f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.381312f);
Get(0x6EC6).SetLocalPose(0.2514729f,1.430035f,-0.7172914f,-0.1570595f,-0.9034152f,-0.2176187f,-0.3343883f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095508f,1.309538f,0.1332158f,-0.7030636f,-0.01443372f,-0.009631581f,0.7109153f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.785617f);
Get(0x6E70).SetLocalPose(0.01300666f,1.579398f,-0.7438759f,0.4275862f,-0.3370695f,-0.6938402f,0.4713173f);
Get(0x6E82).SetLocalPose(0.1025462f,1.496681f,-0.5869781f,0.5140213f,-0.1467779f,-0.7858659f,-0.3108908f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.442645f);
Get(0x6EC6).SetLocalPose(0.2496403f,1.442257f,-0.699121f,-0.1645297f,-0.8993848f,-0.2161346f,-0.3425243f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095519f,1.309551f,0.1332214f,-0.7030817f,-0.01443502f,-0.009581667f,0.7108981f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.844399f);
Get(0x6E70).SetLocalPose(0.01190013f,1.593072f,-0.7318509f,0.4245515f,-0.3415773f,-0.6937679f,0.4709214f);
Get(0x6E82).SetLocalPose(0.0970703f,1.505961f,-0.5756621f,0.5227636f,-0.1357847f,-0.7835281f,-0.3071883f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.501427f);
Get(0x6EC6).SetLocalPose(0.2471387f,1.453348f,-0.6851492f,-0.1705075f,-0.8968605f,-0.2139311f,-0.3475658f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095592f,1.309731f,0.1333591f,-0.7031088f,-0.01444037f,-0.009599717f,0.7108709f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.906166f);
Get(0x6E70).SetLocalPose(0.01215146f,1.60362f,-0.7233301f,0.420672f,-0.3444243f,-0.6948653f,0.4707113f);
Get(0x6E82).SetLocalPose(0.09404801f,1.512985f,-0.5684443f,0.5223597f,-0.1327694f,-0.7862468f,-0.3022064f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.563194f);
Get(0x6EC6).SetLocalPose(0.2439718f,1.463724f,-0.6747914f,-0.1721965f,-0.8958319f,-0.2135098f,-0.3496387f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095485f,1.309488f,0.1331023f,-0.7030657f,-0.01439653f,-0.009607105f,0.7109143f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.964569f);
Get(0x6E70).SetLocalPose(0.01351122f,1.624084f,-0.7092212f,0.4109832f,-0.3475548f,-0.698417f,0.4717121f);
Get(0x6E82).SetLocalPose(0.09249644f,1.523636f,-0.5603278f,0.5157901f,-0.1289702f,-0.7933359f,-0.296556f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.621598f);
Get(0x6EC6).SetLocalPose(0.2389453f,1.477701f,-0.6633562f,-0.1708657f,-0.8957479f,-0.2157902f,-0.3491065f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095479f,1.309529f,0.1330886f,-0.7030792f,-0.01441973f,-0.009608932f,0.7109004f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.99349f);
Get(0x6E70).SetLocalPose(0.01478784f,1.635086f,-0.7022666f,0.4050217f,-0.3480208f,-0.700116f,0.4740007f);
Get(0x6E82).SetLocalPose(0.09255349f,1.528232f,-0.5576486f,0.5158125f,-0.1281355f,-0.7943201f,-0.2942354f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.650518f);
Get(0x6EC6).SetLocalPose(0.2370327f,1.482767f,-0.6590529f,-0.1705257f,-0.8959869f,-0.2168475f,-0.3480026f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.99349f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.650518f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095113f,1.309324f,0.1329375f,-0.7030849f,-0.01439444f,-0.009673023f,0.7108945f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.137744f);
Get(0x6E70).SetLocalPose(0.02025253f,1.661076f,-0.6839908f,0.3846436f,-0.3460257f,-0.6993054f,0.493242f);
Get(0x6E82).SetLocalPose(0.1003651f,1.544592f,-0.5501187f,0.5317153f,-0.1442481f,-0.7821342f,-0.2910968f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.794772f);
Get(0x6EC6).SetLocalPose(0.2332976f,1.503602f,-0.6419089f,-0.1775436f,-0.8990268f,-0.2168325f,-0.3364711f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095157f,1.309451f,0.1329507f,-0.7030858f,-0.01437355f,-0.009646984f,0.7108944f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.197603f);
Get(0x6E70).SetLocalPose(0.02129502f,1.664375f,-0.6812491f,0.3807152f,-0.3455013f,-0.6981139f,0.4983191f);
Get(0x6E82).SetLocalPose(0.1072305f,1.54704f,-0.5489697f,0.5379505f,-0.1599627f,-0.7737201f,-0.2939021f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.854631f);
Get(0x6EC6).SetLocalPose(0.2345499f,1.508878f,-0.6377066f,-0.1790738f,-0.9034417f,-0.2113085f,-0.3272223f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09498f,1.309447f,0.1329225f,-0.7030784f,-0.01435703f,-0.009692851f,0.7109013f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.257059f);
Get(0x6E82).SetLocalPose(0.1161726f,1.548328f,-0.5436823f,0.5368502f,-0.1755337f,-0.7662328f,-0.3063772f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.914087f);
Get(0x6EC6).SetLocalPose(0.2385864f,1.511526f,-0.6343216f,-0.1824311f,-0.9121147f,-0.2066026f,-0.3034486f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094958f,1.30908f,0.1330097f,-0.7030739f,-0.01438509f,-0.009681077f,0.7109055f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.317341f);
Get(0x6E70).SetLocalPose(0.02415054f,1.6705f,-0.6722155f,0.3656318f,-0.3440638f,-0.6938121f,0.5162928f);
Get(0x6E82).SetLocalPose(0.1234519f,1.547022f,-0.5386284f,0.5328365f,-0.1849172f,-0.7614382f,-0.3195351f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.974369f);
Get(0x6EC6).SetLocalPose(0.2423837f,1.509737f,-0.6315692f,-0.1850737f,-0.9165046f,-0.2014585f,-0.2918589f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094836f,1.308828f,0.1330877f,-0.7030903f,-0.01435727f,-0.009675942f,0.7108898f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.404697f);
Get(0x6E70).SetLocalPose(0.0254791f,1.661216f,-0.6639794f,0.3433849f,-0.3438434f,-0.6913542f,0.534685f);
Get(0x6E82).SetLocalPose(0.1403184f,1.541314f,-0.527818f,0.5376262f,-0.1889995f,-0.742075f,-0.3529334f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.061726f);
Get(0x6EC6).SetLocalPose(0.2496812f,1.499432f,-0.625154f,-0.2052829f,-0.9252585f,-0.1839245f,-0.260629f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094675f,1.308726f,0.1330249f,-0.7030869f,-0.01435691f,-0.009704484f,0.7108929f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.465402f);
Get(0x6E70).SetLocalPose(0.0251835f,1.650425f,-0.6611529f,0.3333786f,-0.3448321f,-0.6905556f,0.541371f);
Get(0x6E82).SetLocalPose(0.1501439f,1.535881f,-0.5216834f,0.5521404f,-0.1852498f,-0.7203814f,-0.376662f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.12243f);
Get(0x6EC6).SetLocalPose(0.2545053f,1.487509f,-0.6216155f,-0.2236844f,-0.9297509f,-0.1701973f,-0.2378267f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.465402f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.12243f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095346f,1.308946f,0.1331694f,-0.7030742f,-0.01438092f,-0.00965721f,0.7109056f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.565732f);
Get(0x6E70).SetLocalPose(0.02396758f,1.626494f,-0.6566856f,0.3205763f,-0.3474905f,-0.6911885f,0.5465708f);
Get(0x6E82).SetLocalPose(0.1689833f,1.521373f,-0.5099378f,0.5858497f,-0.1770124f,-0.6747986f,-0.4124241f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.22276f);
Get(0x6EC6).SetLocalPose(0.264282f,1.458529f,-0.6112471f,-0.2503405f,-0.9272292f,-0.1509442f,-0.2340757f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095304f,1.3092f,0.1330776f,-0.7030852f,-0.01441732f,-0.009668207f,0.7108936f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.634382f);
Get(0x6E70).SetLocalPose(0.02345911f,1.614746f,-0.6537637f,0.315903f,-0.3490801f,-0.6924605f,0.546669f);
Get(0x6E82).SetLocalPose(0.1738209f,1.515591f,-0.5059654f,0.6099585f,-0.1740876f,-0.6560342f,-0.4089783f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.29141f);
Get(0x6EC6).SetLocalPose(0.2682035f,1.442139f,-0.6047939f,-0.2603084f,-0.9242843f,-0.1451838f,-0.2384528f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095471f,1.30955f,0.1331566f,-0.703086f,-0.01443634f,-0.009626471f,0.7108932f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.696578f);
Get(0x6E70).SetLocalPose(0.02420371f,1.603625f,-0.6484163f,0.3081474f,-0.3531845f,-0.6956071f,0.5444601f);
Get(0x6E82).SetLocalPose(0.174961f,1.512813f,-0.5051587f,0.6425709f,-0.1851133f,-0.6351903f,-0.3864829f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.03251415f);
Get(0x6EC6).SetLocalPose(0.2696817f,1.4281f,-0.5995414f,-0.2666168f,-0.9258301f,-0.1441818f,-0.225756f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095968f,1.309802f,0.1331415f,-0.7030576f,-0.014431f,-0.00962043f,0.7109213f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.757154f);
Get(0x6E70).SetLocalPose(0.0259739f,1.596708f,-0.6424574f,0.3025872f,-0.356437f,-0.6983731f,0.541912f);
Get(0x6E82).SetLocalPose(0.1715093f,1.515352f,-0.5066094f,0.6882121f,-0.2035972f,-0.6117881f,-0.3326073f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.09308985f);
Get(0x6EC6).SetLocalPose(0.2721086f,1.412902f,-0.5911986f,-0.2698569f,-0.928634f,-0.1474974f,-0.2075107f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095664f,1.30983f,0.1330396f,-0.703055f,-0.01445914f,-0.009564907f,0.7109241f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.815979f);
Get(0x6E70).SetLocalPose(0.02881983f,1.593267f,-0.63398f,0.3019081f,-0.3574061f,-0.7002856f,0.5391776f);
Get(0x6E82).SetLocalPose(0.165702f,1.522341f,-0.5061146f,0.7267429f,-0.2071067f,-0.5925561f,-0.2789782f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.1519151f);
Get(0x6EC6).SetLocalPose(0.2777116f,1.40116f,-0.581802f,-0.272754f,-0.9268677f,-0.156808f,-0.2047747f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095491f,1.309633f,0.1329111f,-0.7030696f,-0.01446421f,-0.00956358f,0.7109097f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.879252f);
Get(0x6E70).SetLocalPose(0.03303894f,1.594928f,-0.6242811f,0.3039368f,-0.3585503f,-0.7019725f,0.5350689f);
Get(0x6E82).SetLocalPose(0.1605638f,1.535208f,-0.4998899f,0.7491257f,-0.2060923f,-0.5888272f,-0.2227541f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.03366554f);
Get(0x6EC6).SetLocalPose(0.2857188f,1.390981f,-0.5696332f,-0.2836474f,-0.9210104f,-0.1675069f,-0.207907f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095335f,1.30956f,0.1331123f,-0.7030722f,-0.0144937f,-0.009611459f,0.7109058f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.940241f);
Get(0x6E70).SetLocalPose(0.03765308f,1.600083f,-0.6132365f,0.303585f,-0.3626423f,-0.7039371f,0.5299051f);
Get(0x6E82).SetLocalPose(0.1633438f,1.553692f,-0.4801667f,0.7544996f,-0.1969517f,-0.5986495f,-0.1831921f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.09465384f);
Get(0x6EC6).SetLocalPose(0.2955574f,1.381849f,-0.556506f,-0.3019295f,-0.9142262f,-0.1770874f,-0.2041305f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.940241f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.09465384f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095503f,1.309593f,0.1330466f,-0.7030473f,-0.01443272f,-0.009594881f,0.7109319f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.058815f);
Get(0x6E70).SetLocalPose(0.04361304f,1.607507f,-0.5896267f,0.2967345f,-0.3754403f,-0.6994649f,0.5307939f);
Get(0x6E82).SetLocalPose(0.2154537f,1.607947f,-0.397384f,0.8167644f,-0.225184f,-0.4801702f,-0.227211f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.2132277f);
Get(0x6EC6).SetLocalPose(0.3198291f,1.355176f,-0.5202023f,-0.340626f,-0.8996723f,-0.2187396f,-0.1634523f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09557f,1.309904f,0.1330019f,-0.7030408f,-0.01447975f,-0.009587184f,0.7109376f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.128697f);
Get(0x6E70).SetLocalPose(0.04477928f,1.604412f,-0.5732008f,0.2952787f,-0.3804715f,-0.6904959f,0.5396919f);
Get(0x6E82).SetLocalPose(0.2478743f,1.636503f,-0.3239911f,0.7950103f,-0.2218448f,-0.4553537f,-0.3337611f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.2831101f);
Get(0x6EC6).SetLocalPose(0.3354435f,1.333883f,-0.4966844f,-0.356456f,-0.8871307f,-0.2561418f,-0.1425819f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095542f,1.309756f,0.1329192f,-0.7030577f,-0.01445537f,-0.009545897f,0.7109218f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.187706f);
Get(0x6E70).SetLocalPose(0.04408712f,1.595625f,-0.5562829f,0.3007356f,-0.3821121f,-0.6836273f,0.5442446f);
Get(0x6E82).SetLocalPose(0.2661377f,1.653231f,-0.255922f,0.7104468f,-0.1899227f,-0.4823064f,-0.4759992f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.3421194f);
Get(0x6EC6).SetLocalPose(0.3485514f,1.309761f,-0.477273f,-0.3744633f,-0.8701599f,-0.2929389f,-0.1295603f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095611f,1.309765f,0.1328719f,-0.7030571f,-0.01443648f,-0.00956979f,0.7109225f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.247982f);
Get(0x6E70).SetLocalPose(0.0428398f,1.586452f,-0.5440165f,0.3091614f,-0.381374f,-0.6810549f,0.5432655f);
Get(0x6E82).SetLocalPose(0.2752558f,1.656629f,-0.1964728f,0.6114393f,-0.1484139f,-0.5186579f,-0.5788863f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.4023947f);
Get(0x6EC6).SetLocalPose(0.362206f,1.275352f,-0.4557859f,-0.3990888f,-0.8465636f,-0.3356365f,-0.1068005f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095564f,1.309436f,0.1327752f,-0.7030287f,-0.01444835f,-0.009585871f,0.71095f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.309213f);
Get(0x6E70).SetLocalPose(0.04040285f,1.572611f,-0.5268439f,0.323865f,-0.3792727f,-0.6782139f,0.5397125f);
Get(0x6E82).SetLocalPose(0.2728881f,1.658458f,-0.1904976f,0.6476977f,-0.1656114f,-0.4880092f,-0.5611662f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.4636258f);
Get(0x6EC6).SetLocalPose(0.3747367f,1.232399f,-0.4369791f,-0.421876f,-0.8211383f,-0.3780476f,-0.06951778f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.0956f,1.30949f,0.1326401f,-0.7030086f,-0.01446009f,-0.00954925f,0.7109702f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.370591f);
Get(0x6E70).SetLocalPose(0.0372667f,1.56011f,-0.5126947f,0.3359701f,-0.3783354f,-0.6740466f,0.5381891f);
Get(0x6E82).SetLocalPose(0.2702095f,1.651385f,-0.2140835f,0.7281339f,-0.2682672f,-0.417827f,-0.4725191f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.5250034f);
Get(0x6EC6).SetLocalPose(0.3856309f,1.185185f,-0.4233356f,-0.4386638f,-0.792232f,-0.4228222f,-0.03411773f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095526f,1.309537f,0.1328161f,-0.7030288f,-0.01441022f,-0.009604752f,0.7109506f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.434179f);
Get(0x6E70).SetLocalPose(0.03213152f,1.542622f,-0.4936385f,0.3484966f,-0.379263f,-0.6662148f,0.5393214f);
Get(0x6E82).SetLocalPose(0.2622298f,1.632448f,-0.2388413f,0.7407095f,-0.3524753f,-0.4131065f,-0.395542f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.5885913f);
Get(0x6EC6).SetLocalPose(0.3960893f,1.12766f,-0.4116767f,-0.4568943f,-0.7524943f,-0.4742874f,-0.007182369f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.434179f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.5885913f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095427f,1.309671f,0.1330213f,-0.7030417f,-0.01441992f,-0.009600276f,0.7109376f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.572113f);
Get(0x6E70).SetLocalPose(0.01730932f,1.505632f,-0.4480079f,0.3734835f,-0.3842088f,-0.6404278f,0.5502236f);
Get(0x6E82).SetLocalPose(0.2241156f,1.548318f,-0.280897f,0.7743096f,-0.4724863f,-0.3373846f,-0.2517401f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.7265255f);
Get(0x6EC6).SetLocalPose(0.4114274f,1.001612f,-0.4108804f,-0.486639f,-0.6613966f,-0.5677546f,0.05823955f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095533f,1.309632f,0.1329448f,-0.7030683f,-0.01444588f,-0.009576375f,0.7109112f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.631866f);
Get(0x6E70).SetLocalPose(0.01034061f,1.494611f,-0.4295305f,0.3821529f,-0.3861786f,-0.6317579f,0.552908f);
Get(0x6E82).SetLocalPose(0.2035917f,1.502034f,-0.2813637f,0.7882088f,-0.5003401f,-0.2887371f,-0.2121736f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.7862787f);
Get(0x6EC6).SetLocalPose(0.4164722f,0.93049f,-0.422327f,-0.5118493f,-0.5933703f,-0.6127044f,0.1025443f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095617f,1.309351f,0.1328963f,-0.7030756f,-0.01437725f,-0.009608695f,0.7109048f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.692748f);
Get(0x6E70).SetLocalPose(-0.001792129f,1.480579f,-0.4019551f,0.3971387f,-0.3882273f,-0.6219677f,0.5520115f);
Get(0x6E82).SetLocalPose(0.17392f,1.440581f,-0.2682571f,0.7822557f,-0.5387958f,-0.243467f,-0.1962117f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.8471612f);
Get(0x6EC6).SetLocalPose(0.4174167f,0.8722892f,-0.4373671f,-0.5339545f,-0.520212f,-0.6522917f,0.137068f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095725f,1.309242f,0.1330539f,-0.7030786f,-0.01444945f,-0.009566492f,0.7109011f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.752755f);
Get(0x6E70).SetLocalPose(-0.01540368f,1.469882f,-0.3753933f,0.4161904f,-0.3884121f,-0.6124732f,0.5484508f);
Get(0x6E82).SetLocalPose(0.1489138f,1.394258f,-0.2508745f,0.7649645f,-0.5705897f,-0.2129308f,-0.2095644f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.907168f);
Get(0x6EC6).SetLocalPose(0.4136209f,0.8115417f,-0.4604121f,-0.5473791f,-0.4182737f,-0.7052339f,0.1675365f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095428f,1.309252f,0.1329699f,-0.7030591f,-0.01443454f,-0.009589532f,0.7109203f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.813668f);
Get(0x6E70).SetLocalPose(-0.03031994f,1.461252f,-0.3466114f,0.4391647f,-0.3868431f,-0.5991501f,0.546357f);
Get(0x6E82).SetLocalPose(0.1059305f,1.327472f,-0.2219161f,0.7316806f,-0.6115222f,-0.1821045f,-0.2398376f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.9680812f);
Get(0x6EC6).SetLocalPose(0.4041638f,0.7595335f,-0.4904184f,-0.5408868f,-0.3221566f,-0.7529527f,0.1916218f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095031f,1.309491f,0.1328776f,-0.7030681f,-0.01435575f,-0.009598419f,0.7109128f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.03401169f);
Get(0x6E70).SetLocalPose(-0.04348127f,1.456775f,-0.3216964f,0.458179f,-0.3859311f,-0.5859175f,0.545738f);
Get(0x6E82).SetLocalPose(0.05220329f,1.264729f,-0.195517f,0.7144378f,-0.6253499f,-0.1564359f,-0.2721101f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.035062f);
Get(0x6EC6).SetLocalPose(0.3919831f,0.7267969f,-0.5211698f,-0.5303314f,-0.2393696f,-0.7793707f,0.2324482f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095207f,1.309431f,0.1329381f,-0.7030648f,-0.01436696f,-0.009635737f,0.7109154f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.06181108f);
Get(0x6E70).SetLocalPose(-0.05410216f,1.455956f,-0.3016437f,0.4710728f,-0.3870521f,-0.5755709f,0.5449765f);
Get(0x6E82).SetLocalPose(0.02355613f,1.237299f,-0.1853978f,0.711322f,-0.6208782f,-0.1478016f,-0.294425f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.062861f);
Get(0x6EC6).SetLocalPose(0.3839912f,0.711372f,-0.5425062f,-0.5264673f,-0.1769556f,-0.7889579f,0.2628009f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.06181108f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.062861f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095133f,1.309446f,0.1329702f,-0.7030522f,-0.01439819f,-0.009591276f,0.7109278f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.2015652f);
Get(0x6E70).SetLocalPose(-0.104466f,1.470469f,-0.2176186f,0.5069434f,-0.4092742f,-0.5295722f,0.543191f);
Get(0x6E82).SetLocalPose(-0.09695061f,1.151143f,-0.1649117f,0.6232218f,-0.5956358f,-0.150444f,-0.4839208f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.03675477f);
Get(0x6EC6).SetLocalPose(0.3656972f,0.7080655f,-0.5882993f,-0.5119071f,0.03847659f,-0.8072783f,0.2911573f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09519f,1.309009f,0.1328544f,-0.7030572f,-0.01438259f,-0.009660763f,0.7109222f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.2626905f);
Get(0x6E70).SetLocalPose(-0.1333243f,1.482058f,-0.1774334f,0.5249022f,-0.4235759f,-0.4985442f,0.5445317f);
Get(0x6E82).SetLocalPose(-0.143773f,1.131045f,-0.1610262f,0.5987166f,-0.534094f,-0.145057f,-0.5789997f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.09788001f);
Get(0x6EC6).SetLocalPose(0.3747702f,0.7371904f,-0.5654998f,-0.4638859f,0.04137441f,-0.8222314f,0.3271599f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095397f,1.309124f,0.132949f,-0.7030635f,-0.01434905f,-0.009629279f,0.7109171f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.3235495f);
Get(0x6E70).SetLocalPose(-0.1627845f,1.496824f,-0.1417269f,0.5371772f,-0.4395599f,-0.4747275f,0.5411669f);
Get(0x6E82).SetLocalPose(-0.1798253f,1.123386f,-0.1543183f,0.5999898f,-0.4262627f,-0.1236612f,-0.6655977f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.1587391f);
Get(0x6EC6).SetLocalPose(0.4101036f,0.7877511f,-0.5041394f,-0.4309821f,0.01789019f,-0.8215749f,0.3727588f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09537f,1.309444f,0.1332299f,-0.7030963f,-0.01444454f,-0.009607028f,0.710883f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.3848649f);
Get(0x6E70).SetLocalPose(-0.1929657f,1.514825f,-0.1098765f,0.5441214f,-0.4597573f,-0.4595972f,0.5304013f);
Get(0x6E82).SetLocalPose(-0.216971f,1.12188f,-0.1443918f,0.5941401f,-0.2719775f,-0.105121f,-0.7496502f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.2200545f);
Get(0x6EC6).SetLocalPose(0.4448419f,0.8307258f,-0.4386351f,-0.4031071f,-0.01692602f,-0.8179429f,0.410107f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095197f,1.309482f,0.133184f,-0.7030801f,-0.01446046f,-0.009640991f,0.7108983f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.4445606f);
Get(0x6E70).SetLocalPose(-0.2210746f,1.533576f,-0.0828803f,0.5462065f,-0.483007f,-0.4528436f,0.5131232f);
Get(0x6E82).SetLocalPose(-0.2495017f,1.124238f,-0.1341965f,0.5601366f,-0.1471139f,-0.09834323f,-0.8092794f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.2797502f);
Get(0x6EC6).SetLocalPose(0.494334f,0.8988428f,-0.3268996f,-0.3633747f,-0.09052027f,-0.8067815f,0.4570214f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094997f,1.309767f,0.1333015f,-0.7030675f,-0.01436191f,-0.009643003f,0.7109128f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.5042563f);
Get(0x6E70).SetLocalPose(-0.2442405f,1.550129f,-0.06337135f,0.5449356f,-0.5034705f,-0.4514613f,0.4957271f);
Get(0x6E82).SetLocalPose(-0.2704129f,1.132825f,-0.1267345f,0.5274969f,-0.09039015f,-0.1013913f,-0.8386278f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.3394459f);
Get(0x6EC6).SetLocalPose(0.5362764f,0.9882567f,-0.1812633f,-0.3317325f,-0.2087974f,-0.7858886f,0.4782638f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094904f,1.309666f,0.1333161f,-0.7030802f,-0.01436674f,-0.009671144f,0.7108997f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.5335649f);
Get(0x6E70).SetLocalPose(-0.2575628f,1.559017f,-0.0526204f,0.5452216f,-0.5144194f,-0.4495077f,0.4858487f);
Get(0x6E82).SetLocalPose(-0.277628f,1.138471f,-0.1231979f,0.5238945f,-0.08124275f,-0.09407271f,-0.8426651f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.3687545f);
Get(0x6EC6).SetLocalPose(0.5481082f,1.050951f,-0.08404274f,-0.3038124f,-0.2875263f,-0.7692826f,0.48294f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094908f,1.309286f,0.1329582f,-0.703078f,-0.01439243f,-0.009659141f,0.7109015f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0f);
Get(0x6E70).SetLocalPose(-0.2837079f,1.570314f,-0.02953061f,0.5656491f,-0.5231851f,-0.427737f,0.4726093f);
Get(0x6E82).SetLocalPose(-0.2919022f,1.165257f,-0.1042214f,0.545764f,-0.06149399f,-0.06998701f,-0.8327436f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.4728603f);
Get(0x6EC6).SetLocalPose(0.5038787f,1.261157f,0.2015351f,-0.177564f,-0.5052444f,-0.7098119f,0.4575656f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095039f,1.309385f,0.132997f,-0.7030893f,-0.01444283f,-0.009640414f,0.7108896f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.06723723f);
Get(0x6E70).SetLocalPose(-0.2877622f,1.57147f,-0.02237707f,0.5790244f,-0.5212947f,-0.4140477f,0.4706879f);
Get(0x6E82).SetLocalPose(-0.295035f,1.180649f,-0.08921786f,0.569842f,-0.04767142f,-0.06679474f,-0.8176467f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.5400975f);
Get(0x6EC6).SetLocalPose(0.4267106f,1.376764f,0.329986f,-0.09013116f,-0.6014529f,-0.6744167f,0.41868f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09548f,1.309585f,0.1332594f,-0.7030811f,-0.01443118f,-0.009652786f,0.7108977f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.1291477f);
Get(0x6E70).SetLocalPose(-0.2894574f,1.573918f,-0.009319881f,0.5976487f,-0.5203102f,-0.3937736f,0.4658709f);
Get(0x6E82).SetLocalPose(-0.293047f,1.197909f,-0.06890666f,0.600619f,-0.03468545f,-0.05818655f,-0.7966607f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.602008f);
Get(0x6EC6).SetLocalPose(0.3030454f,1.49556f,0.4351764f,0.006122322f,-0.6815383f,-0.6384596f,0.3575436f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09568f,1.309702f,0.1332955f,-0.7030792f,-0.01448356f,-0.00959585f,0.7108993f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.1906169f);
Get(0x6E70).SetLocalPose(-0.2869347f,1.577982f,0.0004377496f,0.6036876f,-0.5226046f,-0.3867764f,0.4613565f);
Get(0x6E82).SetLocalPose(-0.2875859f,1.21408f,-0.0493143f,0.6333225f,-0.03106749f,-0.04689592f,-0.7718408f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.6634772f);
Get(0x6EC6).SetLocalPose(0.1662969f,1.586343f,0.4923542f,0.0911964f,-0.752036f,-0.5882795f,0.2829353f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095745f,1.30932f,0.1333123f,-0.7031024f,-0.01450467f,-0.009607326f,0.7108758f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.2486855f);
Get(0x6E70).SetLocalPose(-0.2807938f,1.581775f,0.01113871f,0.6074089f,-0.5231324f,-0.38373f,0.4584084f);
Get(0x6E82).SetLocalPose(-0.281692f,1.229913f,-0.03044504f,0.6651021f,-0.04347031f,-0.04000711f,-0.7444119f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.7215459f);
Get(0x6EC6).SetLocalPose(0.0100763f,1.648266f,0.5071718f,0.1854638f,-0.8080849f,-0.5254225f,0.1911368f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095726f,1.309377f,0.1330739f,-0.7030749f,-0.01450521f,-0.009587181f,0.7109032f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.3097212f);
Get(0x6E70).SetLocalPose(-0.2729024f,1.58873f,0.02568785f,0.6065074f,-0.5209214f,-0.38698f,0.4593868f);
Get(0x6E82).SetLocalPose(-0.2720023f,1.248655f,-0.01056423f,0.7027213f,-0.07394534f,-0.03882141f,-0.7065464f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.7825816f);
Get(0x6EC6).SetLocalPose(-0.1369593f,1.676228f,0.4943573f,0.280424f,-0.8267047f,-0.4784073f,0.09512167f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095707f,1.309499f,0.1331372f,-0.7030698f,-0.01446311f,-0.009614148f,0.7109088f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.3719286f);
Get(0x6E70).SetLocalPose(-0.2666932f,1.595799f,0.03756255f,0.5981727f,-0.5204874f,-0.3966922f,0.4625123f);
Get(0x6E82).SetLocalPose(-0.2634161f,1.269652f,0.007834526f,0.7368843f,-0.1080814f,-0.04650878f,-0.6657003f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.844789f);
Get(0x6EC6).SetLocalPose(-0.2374677f,1.676746f,0.4664381f,0.3414822f,-0.8242054f,-0.451666f,0.008561128f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.3719286f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.844789f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095471f,1.309041f,0.1332808f,-0.703095f,-0.01444948f,-0.009665396f,0.7108835f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0f);
Get(0x6E70).SetLocalPose(-0.2558342f,1.615051f,0.06553563f,0.5670226f,-0.518827f,-0.4249942f,0.4782091f);
Get(0x6E82).SetLocalPose(-0.2545192f,1.317289f,0.03967197f,0.7780382f,-0.1304254f,-0.09833344f,-0.6066106f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.9668484f);
Get(0x6EC6).SetLocalPose(-0.4406961f,1.618877f,0.353897f,0.4505223f,-0.7391409f,-0.4078841f,-0.290398f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095307f,1.309263f,0.1332572f,-0.7031001f,-0.01442063f,-0.009647564f,0.7108791f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.03811815f);
Get(0x6E70).SetLocalPose(-0.2547544f,1.61781f,0.07033198f,0.5628552f,-0.5166998f,-0.428169f,0.4825833f);
Get(0x6E82).SetLocalPose(-0.2519809f,1.333918f,0.04812637f,0.7817637f,-0.1358118f,-0.1193357f,-0.5967912f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.004966f);
Get(0x6EC6).SetLocalPose(-0.4719684f,1.594921f,0.3232342f,0.4845919f,-0.7064787f,-0.3992919f,-0.3265343f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095124f,1.309582f,0.1333376f,-0.7030926f,-0.01447652f,-0.0096703f,0.7108853f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.1096535f);
Get(0x6E70).SetLocalPose(-0.2534303f,1.625448f,0.07830363f,0.556554f,-0.5125706f,-0.4336622f,0.4893427f);
Get(0x6E82).SetLocalPose(-0.2493646f,1.35551f,0.05438742f,0.7852916f,-0.1551504f,-0.1408501f,-0.5825862f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.076502f);
Get(0x6EC6).SetLocalPose(-0.5084679f,1.548398f,0.2710064f,0.5342736f,-0.6557483f,-0.3832152f,-0.3710689f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095451f,1.309664f,0.1333145f,-0.7030663f,-0.01447619f,-0.009641363f,0.7109116f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.1735166f);
Get(0x6E70).SetLocalPose(-0.2534083f,1.632211f,0.08366033f,0.551644f,-0.5119108f,-0.4387244f,0.4910776f);
Get(0x6E82).SetLocalPose(-0.2471638f,1.372605f,0.05517276f,0.7961276f,-0.1761034f,-0.1459807f,-0.5602306f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.140365f);
Get(0x6EC6).SetLocalPose(-0.5254434f,1.499385f,0.2256119f,0.5388786f,-0.610342f,-0.3782334f,-0.4404907f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095438f,1.309573f,0.1333398f,-0.7030885f,-0.01445533f,-0.009668102f,0.7108897f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.2358539f);
Get(0x6E70).SetLocalPose(-0.2536714f,1.638507f,0.08654893f,0.5457752f,-0.5145359f,-0.4438524f,0.4902828f);
Get(0x6E82).SetLocalPose(-0.2465625f,1.38805f,0.05453417f,0.8123984f,-0.1881352f,-0.1455687f,-0.5323756f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.202702f);
Get(0x6EC6).SetLocalPose(-0.5227599f,1.452845f,0.1977749f,0.5009587f,-0.571861f,-0.3904011f,-0.5192325f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095522f,1.309699f,0.1334337f,-0.7030908f,-0.01446493f,-0.009650407f,0.7108874f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.2955791f);
Get(0x6E70).SetLocalPose(-0.2546757f,1.644539f,0.08796973f,0.5391296f,-0.5199148f,-0.4475271f,0.4886179f);
Get(0x6E82).SetLocalPose(-0.2480882f,1.39654f,0.05402517f,0.8210374f,-0.1892892f,-0.1524217f,-0.5165606f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.262427f);
Get(0x6EC6).SetLocalPose(-0.5096709f,1.417855f,0.1893096f,0.461643f,-0.5533952f,-0.4078087f,-0.560653f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095431f,1.309841f,0.1333895f,-0.7030981f,-0.01447356f,-0.009634412f,0.7108804f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.3579978f);
Get(0x6E70).SetLocalPose(-0.2553726f,1.649485f,0.0877579f,0.5327656f,-0.5265074f,-0.4498523f,0.4863985f);
Get(0x6E82).SetLocalPose(-0.2508553f,1.405451f,0.05368057f,0.826144f,-0.1834839f,-0.1734567f,-0.5037187f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.324846f);
Get(0x6EC6).SetLocalPose(-0.4769711f,1.376099f,0.1912438f,0.3894554f,-0.5710574f,-0.432583f,-0.5788696f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.3579978f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.324846f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095424f,1.309502f,0.133269f,-0.7030939f,-0.01448095f,-0.0096196f,0.7108845f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.5032443f);
Get(0x6E70).SetLocalPose(-0.2514132f,1.659187f,0.08180795f,0.5247395f,-0.5349211f,-0.4540785f,0.4819965f);
Get(0x6E82).SetLocalPose(-0.2588654f,1.419051f,0.05809847f,0.8399164f,-0.1282912f,-0.2312612f,-0.4739199f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.470093f);
Get(0x6EC6).SetLocalPose(-0.3874145f,1.31334f,0.235753f,0.2281993f,-0.5969898f,-0.5121989f,-0.5737427f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095087f,1.309369f,0.1330785f,-0.7030723f,-0.01444456f,-0.009630529f,0.7109065f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.5626403f);
Get(0x6E70).SetLocalPose(-0.2475758f,1.661256f,0.07726831f,0.5194125f,-0.5374553f,-0.4571278f,0.4820651f);
Get(0x6E82).SetLocalPose(-0.2613922f,1.422397f,0.06217753f,0.8447667f,-0.09736412f,-0.2536386f,-0.4610388f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.529489f);
Get(0x6EC6).SetLocalPose(-0.3361209f,1.2966f,0.2656313f,0.1334715f,-0.6216556f,-0.5346895f,-0.5566298f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095228f,1.309467f,0.1331102f,-0.703079f,-0.01443186f,-0.00960894f,0.7109004f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.6230754f);
Get(0x6E70).SetLocalPose(-0.2433139f,1.661412f,0.07198034f,0.5130506f,-0.5401236f,-0.4582469f,0.4848252f);
Get(0x6E82).SetLocalPose(-0.2615094f,1.425299f,0.06985115f,0.8433653f,-0.06362836f,-0.2845779f,-0.4513334f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.589924f);
Get(0x6EC6).SetLocalPose(-0.2805505f,1.285996f,0.2885702f,0.02442609f,-0.6333777f,-0.5512267f,-0.5425727f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095296f,1.309506f,0.1331583f,-0.7030749f,-0.01446299f,-0.009627305f,0.7109036f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.682876f);
Get(0x6E70).SetLocalPose(-0.2363748f,1.660252f,0.06408405f,0.5046158f,-0.5434617f,-0.4578277f,0.4903122f);
Get(0x6E82).SetLocalPose(-0.2597615f,1.426828f,0.07873173f,0.8355272f,-0.0378219f,-0.3184766f,-0.446135f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.649724f);
Get(0x6EC6).SetLocalPose(-0.218045f,1.28758f,0.3042702f,-0.0728f,-0.6359255f,-0.5411697f,-0.5453755f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095558f,1.309536f,0.1331122f,-0.7030758f,-0.01444511f,-0.009604543f,0.7109033f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.03216646f);
Get(0x6E70).SetLocalPose(-0.229548f,1.658242f,0.05592749f,0.498271f,-0.5458589f,-0.4568358f,0.4950407f);
Get(0x6E82).SetLocalPose(-0.2548393f,1.428779f,0.08988892f,0.8238559f,-0.01078662f,-0.3576754f,-0.4395605f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.708793f);
Get(0x6EC6).SetLocalPose(-0.1766186f,1.299082f,0.3056512f,-0.106106f,-0.6596594f,-0.5075037f,-0.5440874f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095447f,1.30944f,0.1330159f,-0.7030572f,-0.01445616f,-0.009602352f,0.7109216f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.09377969f);
Get(0x6E70).SetLocalPose(-0.2212622f,1.653801f,0.04486785f,0.4926096f,-0.5474253f,-0.4553126f,0.5003518f);
Get(0x6E82).SetLocalPose(-0.247369f,1.428399f,0.09857164f,0.8228358f,0.01467897f,-0.3808361f,-0.4215326f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.770406f);
Get(0x6EC6).SetLocalPose(-0.1272444f,1.325493f,0.2968397f,-0.1173543f,-0.7070767f,-0.4515508f,-0.5313873f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095617f,1.309375f,0.133129f,-0.703056f,-0.01447207f,-0.009583397f,0.7109227f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.1209825f);
Get(0x6E70).SetLocalPose(-0.2167524f,1.65111f,0.0386907f,0.4903081f,-0.5473815f,-0.4549336f,0.5029979f);
Get(0x6E82).SetLocalPose(-0.2427972f,1.429467f,0.1024874f,0.8241441f,0.02624907f,-0.3909379f,-0.4089807f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.797608f);
Get(0x6EC6).SetLocalPose(-0.1236203f,1.328628f,0.2952835f,-0.1183022f,-0.7109396f,-0.4456766f,-0.5309821f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095779f,1.309574f,0.1333472f,-0.7030619f,-0.0144542f,-0.009555135f,0.7109175f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.224496f);
Get(0x6E70).SetLocalPose(-0.1993861f,1.637053f,0.01505375f,0.4852876f,-0.5414729f,-0.4573106f,0.5120255f);
Get(0x6E82).SetLocalPose(-0.2229538f,1.439463f,0.108268f,0.8156424f,0.04275249f,-0.4422763f,-0.3705283f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.901122f);
Get(0x6EC6).SetLocalPose(-0.04366022f,1.38417f,0.2532632f,-0.139143f,-0.7585351f,-0.3156511f,-0.5528365f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095695f,1.309838f,0.1333408f,-0.7030555f,-0.01448232f,-0.009544263f,0.7109235f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.2568929f);
Get(0x6E70).SetLocalPose(-0.1940103f,1.632971f,0.006944465f,0.484576f,-0.5383141f,-0.4589142f,0.5145888f);
Get(0x6E82).SetLocalPose(-0.2168268f,1.444697f,0.1080984f,0.80725f,0.0434972f,-0.4633969f,-0.3629307f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.933519f);
Get(0x6EC6).SetLocalPose(-0.03027256f,1.401247f,0.2365307f,-0.1341131f,-0.7661486f,-0.2830545f,-0.5611685f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095412f,1.309876f,0.1332051f,-0.7030686f,-0.01449137f,-0.009554714f,0.7109102f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.3207348f);
Get(0x6E70).SetLocalPose(-0.181993f,1.624232f,-0.01008403f,0.4836516f,-0.5314311f,-0.4627325f,0.5191732f);
Get(0x6E82).SetLocalPose(-0.2019925f,1.457182f,0.1018612f,0.792097f,0.04378978f,-0.4987914f,-0.3491019f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.997361f);
Get(0x6EC6).SetLocalPose(-0.001056787f,1.425466f,0.2045827f,-0.113734f,-0.7821272f,-0.2240681f,-0.5702063f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095319f,1.309626f,0.1329608f,-0.7030748f,-0.01444707f,-0.009583595f,0.7109045f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.3858391f);
Get(0x6E70).SetLocalPose(-0.1681278f,1.615723f,-0.02937756f,0.4838393f,-0.5237595f,-0.4666723f,0.5232519f);
Get(0x6E82).SetLocalPose(-0.1874372f,1.472218f,0.09203991f,0.7824367f,0.04184965f,-0.5269641f,-0.3291659f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.062465f);
Get(0x6EC6).SetLocalPose(0.02542811f,1.45022f,0.1663197f,-0.07899956f,-0.7984365f,-0.1657342f,-0.5734025f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095535f,1.309742f,0.1331148f,-0.7030789f,-0.01445494f,-0.009578582f,0.7109004f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.4718231f);
Get(0x6E70).SetLocalPose(-0.1502546f,1.610847f,-0.05359931f,0.4862389f,-0.5144526f,-0.4708126f,0.5265413f);
Get(0x6E82).SetLocalPose(-0.1656336f,1.499535f,0.07368289f,0.7700166f,0.01993884f,-0.566497f,-0.2928447f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.148449f);
Get(0x6EC6).SetLocalPose(0.05452675f,1.482789f,0.1188532f,-0.02799297f,-0.8114314f,-0.09564719f,-0.5758882f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095412f,1.30988f,0.1332327f,-0.7031053f,-0.01443885f,-0.009593682f,0.7108744f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.53334f);
Get(0x6E70).SetLocalPose(-0.1368556f,1.614248f,-0.06981973f,0.4868349f,-0.5092185f,-0.4758685f,0.5265336f);
Get(0x6E82).SetLocalPose(-0.1491898f,1.522447f,0.05868007f,0.7658721f,-0.01749893f,-0.5867552f,-0.2623965f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.209966f);
Get(0x6EC6).SetLocalPose(0.07476057f,1.50643f,0.08847006f,-0.003877106f,-0.8135054f,-0.0614442f,-0.5782894f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095511f,1.30984f,0.1331895f,-0.7031032f,-0.01445646f,-0.009572814f,0.7108765f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.5946403f);
Get(0x6E70).SetLocalPose(-0.1248549f,1.624346f,-0.08341549f,0.4834698f,-0.5069436f,-0.4822197f,0.5260508f);
Get(0x6E82).SetLocalPose(-0.1322514f,1.548471f,0.04504787f,0.7719924f,-0.05010993f,-0.5901605f,-0.2307104f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.271266f);
Get(0x6EC6).SetLocalPose(0.0917214f,1.529442f,0.06551628f,0.006187016f,-0.812156f,-0.0419503f,-0.5818974f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.5946403f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.271266f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095529f,1.309741f,0.1331567f,-0.703096f,-0.01439483f,-0.009571363f,0.7108849f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.6950323f);
Get(0x6E70).SetLocalPose(-0.1006173f,1.662529f,-0.107507f,0.468519f,-0.5036843f,-0.4941631f,0.5315965f);
Get(0x6E82).SetLocalPose(-0.1063186f,1.59839f,0.02660479f,0.7750545f,-0.07611962f,-0.5913601f,-0.2092599f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0f);
Get(0x6EC6).SetLocalPose(0.1212939f,1.573008f,0.02636348f,0.01787667f,-0.8100007f,-0.03478052f,-0.5851236f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095333f,1.309806f,0.1331589f,-0.7031033f,-0.0143829f,-0.009641876f,0.7108769f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.7663366f);
Get(0x6E70).SetLocalPose(-0.08919789f,1.684115f,-0.118877f,0.4584893f,-0.5022866f,-0.4999892f,0.5361966f);
Get(0x6E82).SetLocalPose(-0.0909492f,1.626886f,0.02150796f,0.7549182f,-0.09252989f,-0.6098987f,-0.2226212f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.07130431f);
Get(0x6EC6).SetLocalPose(0.1350447f,1.595927f,0.005337849f,0.02337961f,-0.8114527f,-0.04018148f,-0.5825662f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095064f,1.309212f,0.1330765f,-0.7031152f,-0.01439304f,-0.009676242f,0.7108645f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.8260825f);
Get(0x6E70).SetLocalPose(-0.07668937f,1.707812f,-0.1311705f,0.4450926f,-0.5007993f,-0.5076025f,0.541694f);
Get(0x6E82).SetLocalPose(-0.07722788f,1.649431f,0.01587057f,0.7287832f,-0.1288206f,-0.6388677f,-0.2100675f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.1310502f);
Get(0x6EC6).SetLocalPose(0.1473302f,1.614484f,-0.01422613f,0.02146213f,-0.8136336f,-0.04573223f,-0.5791789f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095159f,1.309353f,0.1332915f,-0.7031331f,-0.01438458f,-0.009669658f,0.710847f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.8860191f);
Get(0x6E70).SetLocalPose(-0.06631861f,1.727676f,-0.1423136f,0.4322849f,-0.4990611f,-0.5147028f,0.5469451f);
Get(0x6E82).SetLocalPose(-0.06304866f,1.668234f,0.006399023f,0.7206868f,-0.1332006f,-0.6523903f,-0.1930159f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.1909868f);
Get(0x6EC6).SetLocalPose(0.1574921f,1.6269f,-0.03210188f,0.01695315f,-0.8163106f,-0.0507915f,-0.5751261f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095269f,1.309405f,0.1334307f,-0.7031078f,-0.01442466f,-0.009663452f,0.7108712f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.9482335f);
Get(0x6E70).SetLocalPose(-0.05449753f,1.74702f,-0.1573129f,0.4181339f,-0.4959912f,-0.5226079f,0.5532068f);
Get(0x6E82).SetLocalPose(-0.04641191f,1.681816f,-0.006048076f,0.7286717f,-0.1140639f,-0.6461443f,-0.196277f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.2532012f);
Get(0x6EC6).SetLocalPose(0.1671508f,1.637229f,-0.05488471f,0.01039847f,-0.8144549f,-0.05914894f,-0.5771105f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095328f,1.309194f,0.133257f,-0.7030856f,-0.01439967f,-0.009639509f,0.7108942f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.005931f);
Get(0x6E70).SetLocalPose(-0.04431603f,1.756201f,-0.1718712f,0.4128626f,-0.4884157f,-0.5294916f,0.5573449f);
Get(0x6E82).SetLocalPose(-0.03211151f,1.689104f,-0.01623548f,0.7243689f,-0.1129367f,-0.6501629f,-0.199558f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.3108991f);
Get(0x6EC6).SetLocalPose(0.1730753f,1.64147f,-0.07388587f,0.004497483f,-0.8098581f,-0.06613012f,-0.5828692f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095675f,1.309415f,0.133232f,-0.7030919f,-0.01443201f,-0.009570636f,0.7108881f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.065919f);
Get(0x6E70).SetLocalPose(-0.035044f,1.758552f,-0.1878495f,0.4133969f,-0.4771892f,-0.5359862f,0.5604573f);
Get(0x6E82).SetLocalPose(-0.01683891f,1.692181f,-0.02720805f,0.7107779f,-0.1196311f,-0.6615747f,-0.2068865f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.3708871f);
Get(0x6EC6).SetLocalPose(0.1775369f,1.64112f,-0.09020881f,0.0005094136f,-0.808786f,-0.06934653f,-0.5840001f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.065919f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.3708871f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095142f,1.309343f,0.1331655f,-0.7030979f,-0.01442801f,-0.009590837f,0.7108821f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.200232f);
Get(0x6E70).SetLocalPose(-0.01492901f,1.75484f,-0.2249485f,0.4149929f,-0.4573817f,-0.5456126f,0.5664714f);
Get(0x6E82).SetLocalPose(0.01849416f,1.675047f,-0.07551924f,0.696676f,-0.1262733f,-0.6726806f,-0.2149383f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.5052f);
Get(0x6EC6).SetLocalPose(0.1878719f,1.62789f,-0.1396894f,-0.009668531f,-0.8244736f,-0.07258096f,-0.5611434f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09521f,1.309298f,0.1330271f,-0.7030834f,-0.014377f,-0.009612432f,0.7108971f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.261825f);
Get(0x6E70).SetLocalPose(-0.004892667f,1.746854f,-0.2459619f,0.4125383f,-0.4536442f,-0.5494318f,0.5675771f);
Get(0x6E82).SetLocalPose(0.03187867f,1.660577f,-0.09984253f,0.6957506f,-0.1287737f,-0.6720295f,-0.2184602f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.5667929f);
Get(0x6EC6).SetLocalPose(0.1937491f,1.617184f,-0.1598342f,-0.01917108f,-0.8234704f,-0.07527213f,-0.562017f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095076f,1.309579f,0.1332613f,-0.7030758f,-0.0143602f,-0.009638784f,0.7109046f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.322155f);
Get(0x6E70).SetLocalPose(0.003500628f,1.736784f,-0.2636785f,0.4106508f,-0.4521189f,-0.5519214f,0.5677475f);
Get(0x6E82).SetLocalPose(0.04425933f,1.644725f,-0.1219257f,0.6906034f,-0.1366118f,-0.674457f,-0.222513f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.6271225f);
Get(0x6EC6).SetLocalPose(0.199907f,1.604025f,-0.1786496f,-0.02925118f,-0.8174407f,-0.07746656f,-0.5700299f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095125f,1.309573f,0.1331393f,-0.703082f,-0.01439879f,-0.009611025f,0.710898f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.379517f);
Get(0x6E70).SetLocalPose(0.01252374f,1.723361f,-0.2818767f,0.4093363f,-0.4506313f,-0.5542591f,0.5676021f);
Get(0x6E82).SetLocalPose(0.05696248f,1.625632f,-0.1452499f,0.6875634f,-0.1468289f,-0.6741106f,-0.2264348f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.6844843f);
Get(0x6EC6).SetLocalPose(0.2028617f,1.589696f,-0.1971559f,-0.03147505f,-0.8166447f,-0.07766858f,-0.5710238f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095259f,1.309572f,0.1329195f,-0.7030743f,-0.014404f,-0.009555855f,0.7109063f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.438735f);
Get(0x6E70).SetLocalPose(0.02172254f,1.706019f,-0.301438f,0.408022f,-0.4489624f,-0.558119f,0.5660866f);
Get(0x6E82).SetLocalPose(0.0654827f,1.607255f,-0.1649863f,0.7007682f,-0.1439255f,-0.6619256f,-0.2237499f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.7437025f);
Get(0x6EC6).SetLocalPose(0.207379f,1.570876f,-0.2214289f,-0.02696989f,-0.8267712f,-0.07104701f,-0.5573817f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095435f,1.30972f,0.1328681f,-0.7030696f,-0.01436077f,-0.009619174f,0.710911f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.496526f);
Get(0x6E70).SetLocalPose(0.03073221f,1.688545f,-0.3191151f,0.4073374f,-0.4469504f,-0.5633822f,0.5629495f);
Get(0x6E82).SetLocalPose(0.07242116f,1.589203f,-0.1838977f,0.7050794f,-0.1402473f,-0.6583173f,-0.2231861f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.8014941f);
Get(0x6EC6).SetLocalPose(0.2147842f,1.551046f,-0.2439566f,-0.02633897f,-0.8361024f,-0.06570143f,-0.5439875f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095457f,1.309659f,0.1329044f,-0.7030603f,-0.01439787f,-0.009611622f,0.7109195f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.556718f);
Get(0x6E70).SetLocalPose(0.04167341f,1.668994f,-0.3387608f,0.4089092f,-0.4428742f,-0.570044f,0.5583059f);
Get(0x6E82).SetLocalPose(0.08036387f,1.56764f,-0.20525f,0.6927738f,-0.13622f,-0.6706505f,-0.2274565f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.8616855f);
Get(0x6EC6).SetLocalPose(0.2247183f,1.532464f,-0.261978f,-0.03453233f,-0.8309602f,-0.06657524f,-0.5512537f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.556718f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.8616855f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095216f,1.309349f,0.1328239f,-0.7030903f,-0.01442857f,-0.009605868f,0.7108893f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.694381f);
Get(0x6E70).SetLocalPose(0.06664961f,1.627496f,-0.3833318f,0.4213592f,-0.430668f,-0.582384f,0.54572f);
Get(0x6E82).SetLocalPose(0.1007942f,1.525735f,-0.2493001f,0.6883484f,-0.1265409f,-0.6690769f,-0.25f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.9993483f);
Get(0x6EC6).SetLocalPose(0.2429302f,1.49164f,-0.3033014f,-0.04691314f,-0.8257151f,-0.08055659f,-0.5563312f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095071f,1.309535f,0.1329473f,-0.70306f,-0.01441786f,-0.009608957f,0.7109194f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.755759f);
Get(0x6E70).SetLocalPose(0.07660741f,1.613729f,-0.4008415f,0.4287274f,-0.4258998f,-0.5859056f,0.5399231f);
Get(0x6E82).SetLocalPose(0.1140956f,1.507247f,-0.2752804f,0.698752f,-0.1286483f,-0.6543366f,-0.2589187f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.060726f);
Get(0x6EC6).SetLocalPose(0.2517147f,1.473281f,-0.3256496f,-0.0467664f,-0.8301095f,-0.08760899f,-0.5486854f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09517f,1.309442f,0.1330133f,-0.7030539f,-0.01445167f,-0.009603856f,0.7109249f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.819382f);
Get(0x6E70).SetLocalPose(0.08859123f,1.600386f,-0.4214893f,0.4372768f,-0.420424f,-0.5917062f,0.5309582f);
Get(0x6E82).SetLocalPose(0.1239691f,1.49534f,-0.2963291f,0.7074537f,-0.127118f,-0.6434663f,-0.2632517f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.12435f);
Get(0x6EC6).SetLocalPose(0.2621562f,1.45861f,-0.3441952f,-0.05340647f,-0.8275698f,-0.0971435f,-0.5503081f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095239f,1.309576f,0.1331894f,-0.7030855f,-0.01450777f,-0.009595108f,0.7108926f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.879741f);
Get(0x6E70).SetLocalPose(0.09848725f,1.591554f,-0.4378312f,0.4444054f,-0.4151081f,-0.5968643f,0.5233948f);
Get(0x6E82).SetLocalPose(0.1348286f,1.484555f,-0.3189854f,0.7152767f,-0.1250824f,-0.6338028f,-0.2665105f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.184709f);
Get(0x6EC6).SetLocalPose(0.27384f,1.447163f,-0.3609432f,-0.06527727f,-0.8186866f,-0.1080119f,-0.5602005f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095392f,1.309655f,0.1332974f,-0.7030898f,-0.01443054f,-0.009599028f,0.7108899f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.941417f);
Get(0x6E70).SetLocalPose(0.1101082f,1.585143f,-0.456963f,0.4553263f,-0.4069534f,-0.599501f,0.517364f);
Get(0x6E82).SetLocalPose(0.1462734f,1.475033f,-0.34146f,0.7263976f,-0.1194082f,-0.621283f,-0.2685063f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.246384f);
Get(0x6EC6).SetLocalPose(0.2850339f,1.438797f,-0.3758709f,-0.07534704f,-0.813046f,-0.1178873f,-0.5651386f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095309f,1.309691f,0.1332147f,-0.7030789f,-0.01446328f,-0.009620006f,0.7108997f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.000822f);
Get(0x6E70).SetLocalPose(0.1202981f,1.583324f,-0.4717916f,0.4648997f,-0.4006995f,-0.5978487f,0.5156405f);
Get(0x6E82).SetLocalPose(0.158146f,1.469174f,-0.3611951f,0.7397346f,-0.1053302f,-0.6053325f,-0.2743555f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.305789f);
Get(0x6EC6).SetLocalPose(0.296616f,1.434159f,-0.3937202f,-0.08256266f,-0.8133605f,-0.1305392f,-0.5608812f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095563f,1.309639f,0.13325f,-0.7030712f,-0.0144604f,-0.009596849f,0.7109076f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.030245f);
Get(0x6E70).SetLocalPose(0.1270087f,1.584222f,-0.4806332f,0.4694607f,-0.3982049f,-0.5968711f,0.5145721f);
Get(0x6E82).SetLocalPose(0.1645113f,1.467588f,-0.3701269f,0.744364f,-0.09704176f,-0.5982697f,-0.2803187f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.335212f);
Get(0x6EC6).SetLocalPose(0.3010839f,1.434062f,-0.4007128f,-0.08419619f,-0.8148285f,-0.1346724f,-0.5575203f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.030245f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.335212f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095666f,1.309666f,0.1328769f,-0.703074f,-0.01444035f,-0.009582942f,0.7109055f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.178678f);
Get(0x6E70).SetLocalPose(0.1543305f,1.604115f,-0.5126089f,0.475141f,-0.3927475f,-0.6060271f,0.5027144f);
Get(0x6E82).SetLocalPose(0.1951318f,1.472427f,-0.4001305f,0.7437887f,-0.06783097f,-0.5821886f,-0.3213005f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.483645f);
Get(0x6EC6).SetLocalPose(0.3284118f,1.442258f,-0.4354779f,-0.1089314f,-0.821701f,-0.1564347f,-0.5370938f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095747f,1.309556f,0.1329749f,-0.7030733f,-0.01446295f,-0.009582302f,0.7109057f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.240863f);
Get(0x6E70).SetLocalPose(0.1640829f,1.615373f,-0.5234942f,0.4759828f,-0.3889453f,-0.6133473f,0.4959508f);
Get(0x6E82).SetLocalPose(0.2082927f,1.477861f,-0.4102923f,0.7330288f,-0.06110779f,-0.5879164f,-0.3365841f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.54583f);
Get(0x6EC6).SetLocalPose(0.3414491f,1.450579f,-0.4476934f,-0.1243943f,-0.8226817f,-0.1642725f,-0.5298448f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095641f,1.309368f,0.1331781f,-0.7030845f,-0.01442008f,-0.009611184f,0.7108952f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.300648f);
Get(0x6E70).SetLocalPose(0.1744491f,1.629512f,-0.5349072f,0.4751356f,-0.3854633f,-0.6207547f,0.4902325f);
Get(0x6E82).SetLocalPose(0.2211931f,1.485945f,-0.4190318f,0.7237693f,-0.05175662f,-0.5920355f,-0.3506753f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.605616f);
Get(0x6EC6).SetLocalPose(0.3535264f,1.461238f,-0.4597754f,-0.1406092f,-0.824618f,-0.1722438f,-0.5201598f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09535f,1.309323f,0.1331967f,-0.7030803f,-0.01441227f,-0.009625227f,0.7108993f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.327832f);
Get(0x6E70).SetLocalPose(0.1833765f,1.642642f,-0.5444934f,0.4721057f,-0.3838267f,-0.6259328f,0.4878539f);
Get(0x6E82).SetLocalPose(0.229258f,1.493237f,-0.4235612f,0.7186207f,-0.04228994f,-0.5920053f,-0.3623887f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.632799f);
Get(0x6EC6).SetLocalPose(0.3608953f,1.467582f,-0.4673771f,-0.1522601f,-0.8262025f,-0.1784349f,-0.5122181f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095429f,1.309576f,0.1332817f,-0.7031003f,-0.01442177f,-0.009596022f,0.7108797f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.425855f);
Get(0x6E70).SetLocalPose(0.1973183f,1.664555f,-0.5589416f,0.4621718f,-0.3846438f,-0.6303255f,0.4910562f);
Get(0x6E82).SetLocalPose(0.2410255f,1.50396f,-0.4307231f,0.7106497f,-0.02653703f,-0.5907201f,-0.3812121f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.730823f);
Get(0x6EC6).SetLocalPose(0.3730989f,1.480003f,-0.4797458f,-0.1736934f,-0.8277705f,-0.189762f,-0.4986151f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095404f,1.3097f,0.1332919f,-0.7030917f,-0.01442787f,-0.009576572f,0.7108883f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.465949f);
Get(0x6E70).SetLocalPose(0.2044088f,1.675713f,-0.5666888f,0.4541854f,-0.3867252f,-0.6311679f,0.4957684f);
Get(0x6E82).SetLocalPose(0.24981f,1.511884f,-0.4356022f,0.7045802f,-0.01954796f,-0.5907328f,-0.3927077f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.770916f);
Get(0x6EC6).SetLocalPose(0.379266f,1.485811f,-0.485298f,-0.1851879f,-0.827419f,-0.194696f,-0.4931295f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095299f,1.309786f,0.1332138f,-0.7030846f,-0.0144265f,-0.009587271f,0.7108953f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.50968f);
Get(0x6E70).SetLocalPose(0.2094017f,1.683276f,-0.5722936f,0.4476857f,-0.3886285f,-0.6314585f,0.4998056f);
Get(0x6E82).SetLocalPose(0.2549131f,1.516576f,-0.438434f,0.7001776f,-0.01736868f,-0.591323f,-0.3997336f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.814648f);
Get(0x6EC6).SetLocalPose(0.3852251f,1.49052f,-0.4906472f,-0.197f,-0.8270186f,-0.1994974f,-0.48727f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.50968f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.814648f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094933f,1.309291f,0.1329932f,-0.7030885f,-0.01438549f,-0.009642579f,0.7108915f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.683256f);
Get(0x6E70).SetLocalPose(0.2337127f,1.706997f,-0.6122502f,0.4105314f,-0.400451f,-0.633459f,0.5194542f);
Get(0x6E82).SetLocalPose(0.2725906f,1.525118f,-0.438004f,0.6597276f,0.02212977f,-0.6017358f,-0.4496485f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.988224f);
Get(0x6EC6).SetLocalPose(0.4008918f,1.496489f,-0.5097887f,-0.2308382f,-0.8361509f,-0.2162337f,-0.4481167f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09516f,1.309652f,0.1330665f,-0.7030885f,-0.01437664f,-0.009611628f,0.7108921f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0f);
Get(0x6E70).SetLocalPose(0.2386495f,1.706328f,-0.6246971f,0.4030855f,-0.4019663f,-0.6355241f,0.5215882f);
Get(0x6E82).SetLocalPose(0.2777896f,1.522879f,-0.4369446f,0.6399637f,0.02980493f,-0.613018f,-0.4623495f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.02537f);
Get(0x6EC6).SetLocalPose(0.4032088f,1.49477f,-0.5144336f,-0.2360236f,-0.8413342f,-0.2141361f,-0.4365724f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095241f,1.309705f,0.1329423f,-0.7030704f,-0.01439722f,-0.009580226f,0.71091f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.06274123f);
Get(0x6E70).SetLocalPose(0.2438953f,1.702869f,-0.6396053f,0.3956299f,-0.4031539f,-0.638036f,0.5233106f);
Get(0x6E82).SetLocalPose(0.2836695f,1.51854f,-0.4351833f,0.6136808f,0.02855771f,-0.6293822f,-0.4758764f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.088112f);
Get(0x6EC6).SetLocalPose(0.4074611f,1.49011f,-0.5227783f,-0.2445254f,-0.8491314f,-0.2117953f,-0.4175237f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095391f,1.309709f,0.1330211f,-0.7030753f,-0.01441568f,-0.009596328f,0.7109045f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.1304372f);
Get(0x6E70).SetLocalPose(0.2492872f,1.695924f,-0.6577461f,0.3884369f,-0.4043326f,-0.6419324f,0.5230247f);
Get(0x6E82).SetLocalPose(0.2914229f,1.512128f,-0.4358998f,0.5980657f,0.01983123f,-0.6383349f,-0.4842032f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.155807f);
Get(0x6EC6).SetLocalPose(0.4113764f,1.4833f,-0.5320747f,-0.2473655f,-0.8546796f,-0.2121746f,-0.4041227f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095171f,1.309534f,0.1328295f,-0.7030749f,-0.01441583f,-0.009616594f,0.7109047f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.1914218f);
Get(0x6E70).SetLocalPose(0.2557305f,1.686277f,-0.6776957f,0.3813687f,-0.4063046f,-0.6468356f,0.5206518f);
Get(0x6E82).SetLocalPose(0.2994201f,1.503438f,-0.4407589f,0.6051373f,0.01866385f,-0.6297545f,-0.4866927f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.216792f);
Get(0x6EC6).SetLocalPose(0.4142486f,1.474766f,-0.542497f,-0.2444986f,-0.8576105f,-0.2141747f,-0.3985646f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095159f,1.309136f,0.1328225f,-0.7030745f,-0.0144587f,-0.009618561f,0.7109041f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.2541828f);
Get(0x6E70).SetLocalPose(0.2622536f,1.674474f,-0.69911f,0.3739256f,-0.4097598f,-0.650947f,0.518213f);
Get(0x6E82).SetLocalPose(0.3079981f,1.495302f,-0.4457411f,0.6195152f,0.02821704f,-0.6077574f,-0.4960198f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.279553f);
Get(0x6EC6).SetLocalPose(0.4166445f,1.464645f,-0.5536659f,-0.2412761f,-0.8635281f,-0.2119325f,-0.3888314f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.2541828f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.279553f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095262f,1.309099f,0.1329999f,-0.7030681f,-0.01442257f,-0.009651419f,0.7109107f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.036736f);
Get(0x6E70).SetLocalPose(0.2781563f,1.644109f,-0.7506903f,0.3576773f,-0.420357f,-0.6556092f,0.5153092f);
Get(0x6E82).SetLocalPose(0.3264252f,1.483239f,-0.4579234f,0.6173297f,0.04509506f,-0.6080974f,-0.4970795f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.416395f);
Get(0x6EC6).SetLocalPose(0.427128f,1.432873f,-0.5986082f,-0.2498726f,-0.8780261f,-0.1853608f,-0.3636965f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095454f,1.309019f,0.133249f,-0.7030561f,-0.01439612f,-0.009648968f,0.7109232f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.09575169f);
Get(0x6E70).SetLocalPose(0.2844029f,1.630694f,-0.7712863f,0.3527263f,-0.4235439f,-0.6569511f,0.5144026f);
Get(0x6E82).SetLocalPose(0.3323238f,1.488359f,-0.470072f,0.6089775f,0.04375163f,-0.625931f,-0.4852242f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.47541f);
Get(0x6EC6).SetLocalPose(0.4321445f,1.420722f,-0.6217992f,-0.2498036f,-0.8759547f,-0.1769339f,-0.3728215f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095601f,1.309169f,0.1332918f,-0.70305f,-0.01439615f,-0.009593116f,0.71093f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.1553652f);
Get(0x6E70).SetLocalPose(0.2912511f,1.615209f,-0.7938927f,0.348292f,-0.4259f,-0.6596802f,0.5119805f);
Get(0x6E82).SetLocalPose(0.3373689f,1.50091f,-0.4873439f,0.5990218f,0.02813265f,-0.6543927f,-0.4605993f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.535024f);
Get(0x6EC6).SetLocalPose(0.4363953f,1.409196f,-0.6478994f,-0.2469773f,-0.8742574f,-0.1662795f,-0.3834412f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09516f,1.309235f,0.1329878f,-0.7030755f,-0.01436637f,-0.009649094f,0.7109047f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.2132381f);
Get(0x6E70).SetLocalPose(0.297047f,1.602042f,-0.8128184f,0.346814f,-0.4259783f,-0.6644192f,0.5067639f);
Get(0x6E82).SetLocalPose(0.3427061f,1.519226f,-0.5163854f,0.6178477f,-0.01698231f,-0.6671773f,-0.4157529f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.592897f);
Get(0x6EC6).SetLocalPose(0.4397896f,1.39981f,-0.6728866f,-0.242407f,-0.8777935f,-0.1516301f,-0.3843512f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095302f,1.309475f,0.1329312f,-0.703055f,-0.01432926f,-0.00964332f,0.7109258f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.2725929f);
Get(0x6E70).SetLocalPose(0.3034195f,1.590173f,-0.8307664f,0.348047f,-0.4240228f,-0.6706725f,0.4992659f);
Get(0x6E82).SetLocalPose(0.3521813f,1.542455f,-0.564668f,0.667358f,-0.09652197f,-0.6451833f,-0.3592426f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.652252f);
Get(0x6EC6).SetLocalPose(0.4451206f,1.388833f,-0.7041556f,-0.237699f,-0.8849769f,-0.1350652f,-0.3769251f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094975f,1.309297f,0.1329102f,-0.7030802f,-0.01435507f,-0.0096355f,0.7109004f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.3319929f);
Get(0x6E70).SetLocalPose(0.3120083f,1.579214f,-0.8509492f,0.3523948f,-0.4205081f,-0.6781671f,0.4889582f);
Get(0x6E82).SetLocalPose(0.3644572f,1.556957f,-0.6236278f,0.7088451f,-0.1695969f,-0.6119846f,-0.3070023f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.711652f);
Get(0x6EC6).SetLocalPose(0.4533074f,1.378308f,-0.7358905f,-0.2331705f,-0.8845474f,-0.1206872f,-0.3855412f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094851f,1.309566f,0.1331997f,-0.7030795f,-0.01435922f,-0.009652948f,0.7109008f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.3939452f);
Get(0x6E70).SetLocalPose(0.3200537f,1.571874f,-0.8671495f,0.3567928f,-0.4184173f,-0.6828846f,0.480931f);
Get(0x6E82).SetLocalPose(0.3777484f,1.56197f,-0.6843463f,0.734101f,-0.2533203f,-0.5841166f,-0.2360772f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.773604f);
Get(0x6EC6).SetLocalPose(0.4631686f,1.370765f,-0.7646717f,-0.2324061f,-0.8805677f,-0.107346f,-0.3988294f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.3939452f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.773604f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094703f,1.309352f,0.1332345f,-0.7030603f,-0.01432246f,-0.009648525f,0.7109205f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.5319557f);
Get(0x6E70).SetLocalPose(0.3464208f,1.563513f,-0.9053535f,0.3548051f,-0.4195399f,-0.6983408f,0.4587155f);
Get(0x6E82).SetLocalPose(0.4078932f,1.555175f,-0.7829284f,0.7127025f,-0.3690159f,-0.5763023f,-0.1541367f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.911615f);
Get(0x6EC6).SetLocalPose(0.4870985f,1.367467f,-0.8168484f,-0.226298f,-0.8948956f,-0.08106175f,-0.3760056f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09475f,1.309236f,0.1330979f,-0.7030941f,-0.0143732f,-0.009605185f,0.7108867f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.5944816f);
Get(0x6E70).SetLocalPose(0.3605163f,1.569239f,-0.9199715f,0.3383451f,-0.4232142f,-0.7125844f,0.4456858f);
Get(0x6E82).SetLocalPose(0.4235667f,1.548132f,-0.8118629f,0.6845529f,-0.4034221f,-0.590097f,-0.1429104f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.974141f);
Get(0x6EC6).SetLocalPose(0.5029944f,1.369807f,-0.8387544f,-0.233552f,-0.8996833f,-0.06980489f,-0.3621474f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094822f,1.309113f,0.1329922f,-0.7030834f,-0.01430181f,-0.009684607f,0.7108976f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.656794f);
Get(0x6E70).SetLocalPose(0.3762176f,1.578578f,-0.9341825f,0.3106136f,-0.4256577f,-0.729635f,0.4358526f);
Get(0x6E82).SetLocalPose(0.436364f,1.542611f,-0.8273083f,0.673447f,-0.4132501f,-0.5959781f,-0.1431909f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.036453f);
Get(0x6EC6).SetLocalPose(0.51758f,1.372431f,-0.8542682f,-0.2476259f,-0.8988543f,-0.06478285f,-0.3557326f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094898f,1.308967f,0.1330135f,-0.7030673f,-0.01428988f,-0.009690681f,0.7109138f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.716273f);
Get(0x6E70).SetLocalPose(0.38746f,1.586494f,-0.9428852f,0.2889202f,-0.4241759f,-0.7390509f,0.4363528f);
Get(0x6E82).SetLocalPose(0.4498996f,1.538261f,-0.8370909f,0.6648976f,-0.4119598f,-0.6038359f,-0.1535664f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.095932f);
Get(0x6EC6).SetLocalPose(0.5289561f,1.37483f,-0.8677498f,-0.2594067f,-0.9006436f,-0.06108205f,-0.3432466f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09512f,1.308762f,0.1330217f,-0.703055f,-0.01432464f,-0.009652711f,0.7109258f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.7484345f);
Get(0x6E70).SetLocalPose(0.3955047f,1.592691f,-0.9488227f,0.2721363f,-0.4213682f,-0.743835f,0.4417015f);
Get(0x6E82).SetLocalPose(0.457281f,1.536861f,-0.8402444f,0.6534734f,-0.4106562f,-0.6146878f,-0.1627667f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.128093f);
Get(0x6EC6).SetLocalPose(0.5350575f,1.378855f,-0.8787824f,-0.2648083f,-0.9056029f,-0.05758675f,-0.3262572f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095208f,1.308986f,0.132923f,-0.7030716f,-0.01442589f,-0.009625199f,0.7109076f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.8164269f);
Get(0x6E70).SetLocalPose(0.4083089f,1.602114f,-0.9579158f,0.2434213f,-0.4139367f,-0.7475736f,0.4588422f);
Get(0x6E82).SetLocalPose(0.4664108f,1.535003f,-0.842693f,0.6293388f,-0.4050852f,-0.6391163f,-0.1771132f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.196086f);
Get(0x6EC6).SetLocalPose(0.5432945f,1.382189f,-0.8947374f,-0.2652327f,-0.9155111f,-0.05516629f,-0.2974015f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095179f,1.309085f,0.1328456f,-0.7030712f,-0.01433536f,-0.009684118f,0.710909f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.8780078f);
Get(0x6E70).SetLocalPose(0.4215164f,1.609185f,-0.9662145f,0.2089912f,-0.4025757f,-0.7470658f,0.4859508f);
Get(0x6E82).SetLocalPose(0.4721687f,1.531783f,-0.8473662f,0.6123272f,-0.3939936f,-0.661202f,-0.1806559f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.257667f);
Get(0x6EC6).SetLocalPose(0.5481881f,1.384194f,-0.9060753f,-0.2630555f,-0.9218209f,-0.05427491f,-0.2794681f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.8780078f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.257667f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094919f,1.309514f,0.132968f,-0.7030199f,-0.01437572f,-0.009630555f,0.7109597f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.018063f);
Get(0x6E70).SetLocalPose(0.4310086f,1.600831f,-0.9745005f,0.174618f,-0.36745f,-0.7484654f,0.5237257f);
Get(0x6E82).SetLocalPose(0.473354f,1.513249f,-0.8648965f,0.6061913f,-0.3753375f,-0.6835224f,-0.1563683f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.397722f);
Get(0x6EC6).SetLocalPose(0.5584773f,1.38177f,-0.9337602f,-0.2571086f,-0.9328393f,-0.04480885f,-0.2483916f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094764f,1.309344f,0.1330598f,-0.7030895f,-0.01434831f,-0.009716523f,0.7108902f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.079609f);
Get(0x6E70).SetLocalPose(0.4288321f,1.590108f,-0.975368f,0.1762969f,-0.3487638f,-0.7518405f,0.5310546f);
Get(0x6E82).SetLocalPose(0.472012f,1.505887f,-0.8693334f,0.6015691f,-0.3718409f,-0.6904615f,-0.1520257f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.459268f);
Get(0x6EC6).SetLocalPose(0.5582845f,1.376476f,-0.9425151f,-0.2542608f,-0.9364901f,-0.03921039f,-0.2383281f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094747f,1.309358f,0.1331121f,-0.7030876f,-0.01430168f,-0.009756088f,0.7108926f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.140295f);
Get(0x6E70).SetLocalPose(0.4237521f,1.578201f,-0.9752474f,0.1831492f,-0.3359359f,-0.7540081f,0.5339244f);
Get(0x6E82).SetLocalPose(0.4662281f,1.488521f,-0.8776193f,0.5995138f,-0.3607419f,-0.6998303f,-0.1438268f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.519954f);
Get(0x6EC6).SetLocalPose(0.5577691f,1.369128f,-0.9511588f,-0.2452711f,-0.9410236f,-0.03585449f,-0.2302847f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094864f,1.309345f,0.1332409f,-0.7030604f,-0.0143339f,-0.009690301f,0.7109197f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.20333f);
Get(0x6E70).SetLocalPose(0.4175193f,1.565699f,-0.9732712f,0.1907121f,-0.3292553f,-0.753719f,0.5358428f);
Get(0x6E82).SetLocalPose(0.4582542f,1.468338f,-0.8836008f,0.6024056f,-0.3454119f,-0.7062043f,-0.1381074f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.582989f);
Get(0x6EC6).SetLocalPose(0.5551242f,1.362254f,-0.9560972f,-0.2335088f,-0.9459509f,-0.03540264f,-0.2222547f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09475f,1.309188f,0.1333295f,-0.7030598f,-0.01434733f,-0.009673963f,0.7109203f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.265711f);
Get(0x6E70).SetLocalPose(0.4104663f,1.553272f,-0.9692959f,0.1985523f,-0.3268172f,-0.7510604f,0.5382154f);
Get(0x6E82).SetLocalPose(0.4518819f,1.4518f,-0.8857572f,0.6010814f,-0.335625f,-0.7115154f,-0.1407227f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.64537f);
Get(0x6EC6).SetLocalPose(0.5508863f,1.353271f,-0.9578195f,-0.2211864f,-0.9512479f,-0.03773092f,-0.211614f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094486f,1.309028f,0.1329642f,-0.7030788f,-0.01430806f,-0.00969944f,0.7109019f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.329029f);
Get(0x6E70).SetLocalPose(0.4016471f,1.540749f,-0.9629665f,0.2081364f,-0.3274924f,-0.7461119f,0.5410591f);
Get(0x6E82).SetLocalPose(0.4454941f,1.435648f,-0.8835662f,0.6088481f,-0.3222772f,-0.7097005f,-0.1475355f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.708688f);
Get(0x6EC6).SetLocalPose(0.5472988f,1.340831f,-0.9533656f,-0.213338f,-0.9549047f,-0.04332417f,-0.2019082f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09444f,1.309096f,0.132961f,-0.7031029f,-0.01429014f,-0.009721257f,0.7108781f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.358457f);
Get(0x6E70).SetLocalPose(0.3960012f,1.534278f,-0.9584486f,0.2134934f,-0.3288857f,-0.743118f,0.5422457f);
Get(0x6E82).SetLocalPose(0.4430459f,1.429108f,-0.8809823f,0.6125171f,-0.3172263f,-0.7077177f,-0.1527287f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.738115f);
Get(0x6EC6).SetLocalPose(0.5455853f,1.333416f,-0.9498451f,-0.2162225f,-0.9539822f,-0.04556501f,-0.202706f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.358457f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.738115f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09435f,1.309194f,0.1328638f,-0.7030503f,-0.01426615f,-0.009716709f,0.7109307f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.499717f);
Get(0x6E70).SetLocalPose(0.3728893f,1.515485f,-0.9355406f,0.2408433f,-0.3331752f,-0.7341272f,0.5404128f);
Get(0x6E82).SetLocalPose(0.4292357f,1.409404f,-0.856266f,0.6230939f,-0.2872047f,-0.7042515f,-0.1824759f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.879375f);
Get(0x6EC6).SetLocalPose(0.5392902f,1.310404f,-0.9298866f,-0.2204287f,-0.9476817f,-0.05868088f,-0.2233095f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094939f,1.308881f,0.1329757f,-0.703094f,-0.01431816f,-0.009691228f,0.7108867f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.564542f);
Get(0x6E70).SetLocalPose(0.359019f,1.510009f,-0.9197315f,0.2624578f,-0.3346423f,-0.7306309f,0.534143f);
Get(0x6E82).SetLocalPose(0.4186406f,1.404631f,-0.8367292f,0.6296546f,-0.2678468f,-0.7006127f,-0.202324f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.944201f);
Get(0x6EC6).SetLocalPose(0.5338309f,1.305009f,-0.9139299f,-0.216229f,-0.9470321f,-0.07000496f,-0.22688f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09483f,1.308647f,0.1329118f,-0.7030987f,-0.01432875f,-0.009722138f,0.7108815f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.623574f);
Get(0x6E70).SetLocalPose(0.3486995f,1.50985f,-0.9069303f,0.2786437f,-0.3361331f,-0.7279051f,0.5287026f);
Get(0x6E82).SetLocalPose(0.4087417f,1.403312f,-0.8198686f,0.6426188f,-0.2590872f,-0.6882347f,-0.2150533f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.003233f);
Get(0x6EC6).SetLocalPose(0.5256374f,1.311988f,-0.8944518f,-0.2186675f,-0.9438085f,-0.07348365f,-0.2366649f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094715f,1.308884f,0.1331075f,-0.7030856f,-0.0142888f,-0.009696062f,0.7108955f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.684855f);
Get(0x6E70).SetLocalPose(0.3358819f,1.514633f,-0.887824f,0.2975972f,-0.3400368f,-0.7237177f,0.5215779f);
Get(0x6E82).SetLocalPose(0.4007916f,1.40509f,-0.805971f,0.6599572f,-0.2563612f,-0.6712703f,-0.2193895f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.064514f);
Get(0x6EC6).SetLocalPose(0.5185428f,1.31867f,-0.8743375f,-0.2316868f,-0.9379439f,-0.06966453f,-0.2484543f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094697f,1.308743f,0.1330822f,-0.7030526f,-0.01431867f,-0.009692281f,0.7109275f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.745292f);
Get(0x6E70).SetLocalPose(0.3246028f,1.524416f,-0.8661791f,0.3110916f,-0.3462413f,-0.7189726f,0.5161565f);
Get(0x6E82).SetLocalPose(0.3904915f,1.409407f,-0.7848194f,0.69023f,-0.2513586f,-0.6422644f,-0.2188559f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.124951f);
Get(0x6EC6).SetLocalPose(0.5103005f,1.326381f,-0.8550314f,-0.2410168f,-0.9327841f,-0.06778134f,-0.2592882f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094813f,1.30864f,0.1329316f,-0.7030906f,-0.01432987f,-0.00967042f,0.7108901f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.806224f);
Get(0x6E70).SetLocalPose(0.3157893f,1.535637f,-0.8468716f,0.3185994f,-0.3519794f,-0.7150322f,0.5131607f);
Get(0x6E82).SetLocalPose(0.3820983f,1.417815f,-0.7616521f,0.7079933f,-0.2487256f,-0.6216455f,-0.2245839f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.185883f);
Get(0x6EC6).SetLocalPose(0.501321f,1.33877f,-0.8310889f,-0.2424236f,-0.9294863f,-0.07021325f,-0.268991f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094831f,1.308988f,0.1330373f,-0.7031041f,-0.01433418f,-0.009684376f,0.7108765f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.835588f);
Get(0x6E70).SetLocalPose(0.3101596f,1.543756f,-0.8332897f,0.3225651f,-0.3556605f,-0.712301f,0.5119421f);
Get(0x6E82).SetLocalPose(0.3770923f,1.425265f,-0.7461401f,0.7146078f,-0.2468058f,-0.6144709f,-0.2254956f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.215247f);
Get(0x6EC6).SetLocalPose(0.4973381f,1.347933f,-0.8167705f,-0.2401438f,-0.9292306f,-0.07232841f,-0.2713489f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094943f,1.309168f,0.1327755f,-0.7030545f,-0.01434637f,-0.009648602f,0.7109259f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.940197f);
Get(0x6E70).SetLocalPose(0.2940723f,1.567912f,-0.7937011f,0.3311791f,-0.3636431f,-0.7035216f,0.5129732f);
Get(0x6E82).SetLocalPose(0.36555f,1.447787f,-0.703007f,0.7202958f,-0.238899f,-0.607695f,-0.234111f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.319856f);
Get(0x6EC6).SetLocalPose(0.4782155f,1.374244f,-0.7723781f,-0.2276756f,-0.9319945f,-0.07832452f,-0.2709526f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094965f,1.309254f,0.1327412f,-0.703044f,-0.01440909f,-0.00959995f,0.7109356f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.007545f);
Get(0x6E70).SetLocalPose(0.2853444f,1.578791f,-0.7731594f,0.3363947f,-0.3654575f,-0.6983415f,0.5153627f);
Get(0x6E82).SetLocalPose(0.3579854f,1.465188f,-0.6704349f,0.7233226f,-0.2273662f,-0.606187f,-0.2400966f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.387204f);
Get(0x6EC6).SetLocalPose(0.4684111f,1.385371f,-0.7505747f,-0.2183744f,-0.9345759f,-0.08106517f,-0.2689033f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095297f,1.309503f,0.1327112f,-0.7030625f,-0.01441844f,-0.009603825f,0.7109171f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.070581f);
Get(0x6E70).SetLocalPose(0.2753284f,1.591152f,-0.7494367f,0.3453829f,-0.3653392f,-0.6928169f,0.5169553f);
Get(0x6E82).SetLocalPose(0.3523491f,1.480953f,-0.6422721f,0.7252167f,-0.2180743f,-0.6047395f,-0.246565f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.45024f);
Get(0x6EC6).SetLocalPose(0.4593584f,1.399151f,-0.7230084f,-0.1999375f,-0.9409596f,-0.08731704f,-0.2588356f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095486f,1.309737f,0.1327405f,-0.7030653f,-0.01441228f,-0.009599641f,0.7109144f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.13003f);
Get(0x6E70).SetLocalPose(0.2669737f,1.602206f,-0.72948f,0.3534359f,-0.3648328f,-0.6900142f,0.5156167f);
Get(0x6E82).SetLocalPose(0.3475708f,1.493605f,-0.6155869f,0.7254611f,-0.2138581f,-0.6024548f,-0.2549884f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.50969f);
Get(0x6EC6).SetLocalPose(0.4512426f,1.414822f,-0.7045623f,-0.1856754f,-0.9453841f,-0.09342811f,-0.251087f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095318f,1.309789f,0.1326926f,-0.7030716f,-0.01438668f,-0.00962278f,0.7109084f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.188929f);
Get(0x6E70).SetLocalPose(0.2596569f,1.612383f,-0.7122388f,0.3581094f,-0.3655793f,-0.6894011f,0.5126749f);
Get(0x6E82).SetLocalPose(0.3432292f,1.504717f,-0.5924869f,0.7267911f,-0.213039f,-0.5990896f,-0.2597705f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.568589f);
Get(0x6EC6).SetLocalPose(0.4428893f,1.428713f,-0.6818798f,-0.1749212f,-0.9489794f,-0.1003593f,-0.2424229f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095248f,1.309392f,0.1328128f,-0.7030485f,-0.01437788f,-0.009611883f,0.7109317f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.249751f);
Get(0x6E70).SetLocalPose(0.2534338f,1.622779f,-0.6946055f,0.361008f,-0.3671606f,-0.6893146f,0.5096192f);
Get(0x6E82).SetLocalPose(0.3387615f,1.51344f,-0.5735904f,0.7314211f,-0.2078657f,-0.5952442f,-0.2598063f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.629411f);
Get(0x6EC6).SetLocalPose(0.4381253f,1.438084f,-0.6608368f,-0.168995f,-0.9512779f,-0.1091317f,-0.2336696f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095324f,1.309164f,0.1328053f,-0.7030562f,-0.01439099f,-0.009622145f,0.7109237f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.308442f);
Get(0x6E70).SetLocalPose(0.2485871f,1.631158f,-0.6797048f,0.3624351f,-0.3684069f,-0.688891f,0.508278f);
Get(0x6E82).SetLocalPose(0.3342417f,1.518898f,-0.5564764f,0.7411019f,-0.1993239f,-0.5862057f,-0.2596168f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.688102f);
Get(0x6EC6).SetLocalPose(0.432845f,1.446708f,-0.6452221f,-0.1668508f,-0.9518715f,-0.1199257f,-0.2274187f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.308442f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.688102f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095106f,1.30892f,0.1327177f,-0.7030514f,-0.01436435f,-0.009634447f,0.7109287f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.40928f);
Get(0x6E70).SetLocalPose(0.2414939f,1.645911f,-0.6505086f,0.364024f,-0.3693328f,-0.6856888f,0.5107943f);
Get(0x6E82).SetLocalPose(0.3266559f,1.522272f,-0.5283383f,0.7584646f,-0.2002502f,-0.5657473f,-0.2540892f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.78894f);
Get(0x6EC6).SetLocalPose(0.4301192f,1.458514f,-0.6123284f,-0.1579224f,-0.9502076f,-0.1523822f,-0.2212369f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094885f,1.308954f,0.1326018f,-0.7030162f,-0.01430985f,-0.00967814f,0.710964f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.479617f);
Get(0x6E70).SetLocalPose(0.2381053f,1.650821f,-0.6334817f,0.3632989f,-0.3708229f,-0.6813138f,0.516058f);
Get(0x6E82).SetLocalPose(0.3236546f,1.518334f,-0.5179813f,0.766133f,-0.2074077f,-0.5559144f,-0.2469442f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.859277f);
Get(0x6EC6).SetLocalPose(0.431552f,1.459713f,-0.5964673f,-0.1530516f,-0.9495258f,-0.1608953f,-0.2215601f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094896f,1.308923f,0.132759f,-0.7030204f,-0.01431546f,-0.009679806f,0.7109598f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.540738f);
Get(0x6E70).SetLocalPose(0.2354728f,1.6508f,-0.6192487f,0.3619606f,-0.3728365f,-0.6752282f,0.5234924f);
Get(0x6E82).SetLocalPose(0.3186948f,1.511522f,-0.5077925f,0.7653152f,-0.2273874f,-0.5518056f,-0.2410357f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.920398f);
Get(0x6EC6).SetLocalPose(0.4320188f,1.458812f,-0.5826659f,-0.1475792f,-0.9485937f,-0.1684294f,-0.2236561f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094529f,1.309246f,0.1327385f,-0.7030491f,-0.0143423f,-0.009721888f,0.7109302f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.625502f);
Get(0x6E70).SetLocalPose(0.232065f,1.643694f,-0.6014956f,0.3616318f,-0.3744843f,-0.6672754f,0.5326608f);
Get(0x6E82).SetLocalPose(0.3147871f,1.495067f,-0.4988967f,0.7538702f,-0.2529951f,-0.5512185f,-0.2526487f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.005161f);
Get(0x6EC6).SetLocalPose(0.4325642f,1.450258f,-0.5673004f,-0.1358247f,-0.9483181f,-0.1789463f,-0.2241044f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094915f,1.309246f,0.1329512f,-0.703046f,-0.01433148f,-0.009702039f,0.7109338f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.686829f);
Get(0x6E70).SetLocalPose(0.2290027f,1.633876f,-0.5888615f,0.362461f,-0.375299f,-0.6638489f,0.535796f);
Get(0x6E82).SetLocalPose(0.3117426f,1.478498f,-0.4986824f,0.7574299f,-0.280607f,-0.5413587f,-0.233432f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.066488f);
Get(0x6EC6).SetLocalPose(0.4289368f,1.437712f,-0.5579085f,-0.1268708f,-0.9507762f,-0.1819262f,-0.2164053f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094881f,1.309526f,0.1330973f,-0.7030608f,-0.01438405f,-0.009673353f,0.7109185f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.746572f);
Get(0x6E70).SetLocalPose(0.2257142f,1.6216f,-0.5767439f,0.3647901f,-0.3756404f,-0.6624678f,0.5356855f);
Get(0x6E82).SetLocalPose(0.3088393f,1.462295f,-0.5008023f,0.7705461f,-0.3018f,-0.5158452f,-0.2215385f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.126231f);
Get(0x6EC6).SetLocalPose(0.4261864f,1.421805f,-0.5472396f,-0.1217856f,-0.9534857f,-0.1821133f,-0.2070459f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095071f,1.309648f,0.1331454f,-0.7030587f,-0.01442944f,-0.009634817f,0.7109202f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.77396f);
Get(0x6E70).SetLocalPose(0.2239997f,1.614888f,-0.5705932f,0.3663374f,-0.3755483f,-0.6622828f,0.5349223f);
Get(0x6E82).SetLocalPose(0.3064143f,1.449385f,-0.5027142f,0.7743034f,-0.3202513f,-0.5029715f,-0.2119268f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.153619f);
Get(0x6EC6).SetLocalPose(0.4253123f,1.414666f,-0.5418425f,-0.1205059f,-0.9539496f,-0.1826066f,-0.2052153f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.77396f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.153619f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095498f,1.309681f,0.1332095f,-0.7030701f,-0.01443172f,-0.009631642f,0.7109089f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.914871f);
Get(0x6E70).SetLocalPose(0.2152516f,1.585427f,-0.5412337f,0.3714578f,-0.3749959f,-0.663531f,0.5302111f);
Get(0x6E82).SetLocalPose(0.2907519f,1.400395f,-0.5049824f,0.7696263f,-0.3819229f,-0.4888364f,-0.1511592f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.29453f);
Get(0x6EC6).SetLocalPose(0.4187473f,1.377355f,-0.5160871f,-0.1164781f,-0.9544833f,-0.1856097f,-0.2023448f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095519f,1.309645f,0.133358f,-0.7030706f,-0.01446642f,-0.009600114f,0.7109081f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.974658f);
Get(0x6E70).SetLocalPose(0.2107785f,1.575113f,-0.5254388f,0.3723773f,-0.3761536f,-0.662672f,0.5298201f);
Get(0x6E82).SetLocalPose(0.282362f,1.38343f,-0.500456f,0.7829438f,-0.3969914f,-0.466855f,-0.1069733f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.354317f);
Get(0x6EC6).SetLocalPose(0.4139478f,1.362058f,-0.5038754f,-0.117617f,-0.9566619f,-0.1868303f,-0.1898916f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095455f,1.309647f,0.1332742f,-0.7030797f,-0.01447709f,-0.009585755f,0.7108991f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.033371f);
Get(0x6E70).SetLocalPose(0.2072071f,1.569732f,-0.5130304f,0.3726551f,-0.3772283f,-0.6609825f,0.53097f);
Get(0x6E82).SetLocalPose(0.2763396f,1.371651f,-0.4897945f,0.80134f,-0.4046903f,-0.4361325f,-0.06219688f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.41303f);
Get(0x6EC6).SetLocalPose(0.4105167f,1.350743f,-0.4925203f,-0.1246271f,-0.9556316f,-0.18857f,-0.1888851f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095088f,1.309733f,0.1332329f,-0.7030566f,-0.01440827f,-0.009632806f,0.7109227f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.118567f);
Get(0x6E70).SetLocalPose(0.1987154f,1.564205f,-0.4810649f,0.3786073f,-0.3758812f,-0.6538917f,0.5364658f);
Get(0x6E82).SetLocalPose(0.2766778f,1.373136f,-0.4272264f,0.8388384f,-0.398462f,-0.37064f,-0.0142907f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.498227f);
Get(0x6EC6).SetLocalPose(0.405951f,1.340767f,-0.4715806f,-0.1401336f,-0.9502954f,-0.1948115f,-0.1983674f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095253f,1.309668f,0.133261f,-0.7030717f,-0.01443061f,-0.009551451f,0.7109085f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.178334f);
Get(0x6E70).SetLocalPose(0.1930875f,1.567703f,-0.4591281f,0.384726f,-0.3743908f,-0.6500428f,0.5378307f);
Get(0x6E82).SetLocalPose(0.2920893f,1.394762f,-0.364346f,0.8659455f,-0.3835296f,-0.3186459f,-0.03883692f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.557994f);
Get(0x6EC6).SetLocalPose(0.4010976f,1.338271f,-0.455297f,-0.1446963f,-0.9472778f,-0.2049863f,-0.19927f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095194f,1.309767f,0.1330976f,-0.7030594f,-0.01444843f,-0.00955765f,0.7109201f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.24026f);
Get(0x6E70).SetLocalPose(0.1868151f,1.576683f,-0.4358975f,0.3870201f,-0.3757859f,-0.6502588f,0.5349429f);
Get(0x6E82).SetLocalPose(0.3205617f,1.425424f,-0.2782706f,0.9030809f,-0.3675632f,-0.209158f,-0.0747995f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.619919f);
Get(0x6EC6).SetLocalPose(0.3954459f,1.337345f,-0.4355579f,-0.145596f,-0.9442399f,-0.2229125f,-0.1937083f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.24026f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.619919f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09554f,1.309525f,0.1332003f,-0.7030719f,-0.01443684f,-0.009605452f,0.7109074f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.341323f);
Get(0x6E70).SetLocalPose(0.1749519f,1.596948f,-0.3952957f,0.3895579f,-0.3788881f,-0.6490016f,0.5324336f);
Get(0x6E82).SetLocalPose(0.3791167f,1.488841f,-0.07010661f,0.890508f,-0.3712867f,0.1384927f,-0.2235205f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.720983f);
Get(0x6EC6).SetLocalPose(0.3869382f,1.338202f,-0.3958085f,-0.1521894f,-0.9343851f,-0.260171f,-0.1899315f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095384f,1.309435f,0.1329557f,-0.7030729f,-0.01448935f,-0.009564226f,0.7109059f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.407909f);
Get(0x6E70).SetLocalPose(0.1666053f,1.608433f,-0.3706048f,0.3949924f,-0.3779471f,-0.6428779f,0.5365118f);
Get(0x6E82).SetLocalPose(0.384436f,1.528937f,0.07148332f,0.7604721f,-0.3942996f,0.3006383f,-0.4193171f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0f);
Get(0x6EC6).SetLocalPose(0.383976f,1.338732f,-0.3723233f,-0.1618628f,-0.9260072f,-0.2806881f,-0.1937148f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094982f,1.309491f,0.1328214f,-0.7030486f,-0.01440884f,-0.009604796f,0.7109309f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.465579f);
Get(0x6E70).SetLocalPose(0.1589441f,1.618192f,-0.3468428f,0.4042933f,-0.3749139f,-0.6347903f,0.5413204f);
Get(0x6E82).SetLocalPose(0.3568366f,1.558625f,0.1761283f,0.6081294f,-0.4051619f,0.3137825f,-0.6062698f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.05766954f);
Get(0x6EC6).SetLocalPose(0.3810385f,1.339147f,-0.3532064f,-0.1685735f,-0.9192499f,-0.2977208f,-0.1947434f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094849f,1.309354f,0.1326544f,-0.703036f,-0.01437053f,-0.00962728f,0.7109439f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.549814f);
Get(0x6E70).SetLocalPose(0.1498571f,1.629042f,-0.3144152f,0.419626f,-0.3698712f,-0.6269498f,0.5422576f);
Get(0x6E82).SetLocalPose(0.2997894f,1.580078f,0.2540124f,0.568388f,-0.2740619f,0.3644712f,-0.6848255f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0f);
Get(0x6EC6).SetLocalPose(0.3738104f,1.337494f,-0.31857f,-0.1720373f,-0.9090847f,-0.3358104f,-0.176634f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094871f,1.309329f,0.1326267f,-0.7030415f,-0.01439713f,-0.00962443f,0.710938f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.607384f);
Get(0x6E70).SetLocalPose(0.1447332f,1.634859f,-0.2945896f,0.427886f,-0.3674965f,-0.6247599f,0.5399398f);
Get(0x6E82).SetLocalPose(0.2847842f,1.582504f,0.2742734f,0.5785927f,-0.2498648f,0.4041434f,-0.6629226f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.05756985f);
Get(0x6EC6).SetLocalPose(0.3695312f,1.335067f,-0.3019337f,-0.1725358f,-0.9035849f,-0.3569513f,-0.1623315f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095233f,1.309067f,0.1325577f,-0.7030186f,-0.01435693f,-0.009636989f,0.7109613f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.666769f);
Get(0x6E70).SetLocalPose(0.1403535f,1.63806f,-0.2757852f,0.4352835f,-0.3653371f,-0.6226268f,0.5379525f);
Get(0x6E82).SetLocalPose(0.2935717f,1.583816f,0.2869311f,0.5903969f,-0.2690631f,0.3913491f,-0.6525967f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0f);
Get(0x6EC6).SetLocalPose(0.3647618f,1.330002f,-0.2812054f,-0.1798938f,-0.8956687f,-0.377306f,-0.1518427f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094907f,1.309316f,0.1327027f,-0.7030173f,-0.01434182f,-0.009653699f,0.7109627f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.728168f);
Get(0x6E70).SetLocalPose(0.1363409f,1.636781f,-0.255986f,0.443218f,-0.3628736f,-0.618944f,0.5373908f);
Get(0x6E82).SetLocalPose(0.3106045f,1.581775f,0.2873771f,0.6449136f,-0.2811533f,0.3260316f,-0.6314608f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.06139816f);
Get(0x6EC6).SetLocalPose(0.3626034f,1.321794f,-0.2655427f,-0.1950539f,-0.8885505f,-0.3866297f,-0.1514909f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.728168f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.06139816f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09487f,1.309322f,0.1326581f,-0.7030306f,-0.01436879f,-0.009678063f,0.7109486f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.824923f);
Get(0x6E70).SetLocalPose(0.1302326f,1.629984f,-0.2229642f,0.4498788f,-0.363447f,-0.6134492f,0.537769f);
Get(0x6E82).SetLocalPose(0.3336358f,1.560515f,0.2713857f,0.6996792f,-0.3279363f,0.253508f,-0.5819283f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.1581538f);
Get(0x6EC6).SetLocalPose(0.3587816f,1.301249f,-0.2427146f,-0.2191123f,-0.8805949f,-0.395914f,-0.1406933f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095233f,1.309442f,0.1327762f,-0.7030433f,-0.01439522f,-0.009638675f,0.7109361f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.918227f);
Get(0x6E70).SetLocalPose(0.124877f,1.617147f,-0.1957045f,0.4522215f,-0.3655712f,-0.6107845f,0.5373973f);
Get(0x6E82).SetLocalPose(0.3462905f,1.531127f,0.2433085f,0.7131402f,-0.4070167f,0.1579191f,-0.5484797f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.2514578f);
Get(0x6EC6).SetLocalPose(0.3544279f,1.275104f,-0.221659f,-0.2376982f,-0.8735569f,-0.4078049f,-0.1187139f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095692f,1.30917f,0.1328729f,-0.7030551f,-0.01442069f,-0.009603384f,0.7109244f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.981686f);
Get(0x6E70).SetLocalPose(0.121632f,1.604833f,-0.1794829f,0.4552676f,-0.3653599f,-0.6095729f,0.5363436f);
Get(0x6E82).SetLocalPose(0.3484809f,1.502023f,0.2106881f,0.7051191f,-0.4729704f,0.07058464f,-0.5235685f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.314916f);
Get(0x6EC6).SetLocalPose(0.3516656f,1.250418f,-0.2064887f,-0.2517467f,-0.8649411f,-0.4221357f,-0.1014993f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095609f,1.309477f,0.1330166f,-0.7030596f,-0.01447251f,-0.00957635f,0.7109191f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0f);
Get(0x6E70).SetLocalPose(0.117207f,1.58805f,-0.1612528f,0.4611729f,-0.3646383f,-0.6056583f,0.5362243f);
Get(0x6E82).SetLocalPose(0.3438705f,1.470139f,0.1735514f,0.6891237f,-0.5278125f,0.0005766889f,-0.49651f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.374983f);
Get(0x6EC6).SetLocalPose(0.3495058f,1.21995f,-0.1901841f,-0.2720626f,-0.8506765f,-0.4403036f,-0.09200159f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095496f,1.309462f,0.1330093f,-0.7030464f,-0.01441416f,-0.009603231f,0.7109331f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.06162431f);
Get(0x6E70).SetLocalPose(0.1132374f,1.571052f,-0.1461191f,0.4673161f,-0.3645537f,-0.5989169f,0.5385302f);
Get(0x6E82).SetLocalPose(0.3283878f,1.427606f,0.1295596f,0.659155f,-0.5827369f,-0.0676332f,-0.4704871f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.4366074f);
Get(0x6EC6).SetLocalPose(0.3478227f,1.185488f,-0.1751051f,-0.2960212f,-0.8321009f,-0.4602461f,-0.09029491f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095498f,1.30947f,0.1329676f,-0.7030604f,-0.01442784f,-0.009585527f,0.7109191f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.1194745f);
Get(0x6E70).SetLocalPose(0.1098964f,1.556866f,-0.1337715f,0.4711721f,-0.3656676f,-0.5935962f,0.5403033f);
Get(0x6E82).SetLocalPose(0.3052888f,1.385995f,0.09104481f,0.6074179f,-0.6509839f,-0.1311186f,-0.4359718f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.4944575f);
Get(0x6EC6).SetLocalPose(0.3458933f,1.145223f,-0.1596948f,-0.3221648f,-0.8079535f,-0.4865713f,-0.08166607f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095641f,1.309848f,0.1330465f,-0.7030792f,-0.01446602f,-0.009590766f,0.7108997f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.1792425f);
Get(0x6E70).SetLocalPose(0.1044743f,1.541459f,-0.1180238f,0.4735117f,-0.3688833f,-0.5900952f,0.539907f);
Get(0x6E82).SetLocalPose(0.2653745f,1.336648f,0.0477805f,0.5480415f,-0.7189001f,-0.1760079f,-0.3896852f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.5542256f);
Get(0x6EC6).SetLocalPose(0.3441787f,1.099414f,-0.1438315f,-0.3443483f,-0.7732221f,-0.5276277f,-0.07183868f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.1792425f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.5542256f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095588f,1.309862f,0.1329344f,-0.7030625f,-0.01444091f,-0.009522365f,0.7109177f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.2782686f);
Get(0x6E70).SetLocalPose(0.08848104f,1.524329f,-0.08698413f,0.4723368f,-0.3783499f,-0.5907179f,0.5336682f);
Get(0x6E82).SetLocalPose(0.1855099f,1.27145f,0.002107239f,0.5126851f,-0.7722105f,-0.173464f,-0.3327991f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.6532517f);
Get(0x6EC6).SetLocalPose(0.3470731f,1.007956f,-0.1252837f,-0.3838049f,-0.6933609f,-0.6068095f,-0.06104808f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09525f,1.309736f,0.1327714f,-0.703068f,-0.01446026f,-0.009534213f,0.7109117f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.3490621f);
Get(0x6E70).SetLocalPose(0.07281626f,1.519736f,-0.06262516f,0.4761125f,-0.3821656f,-0.5818059f,0.5373717f);
Get(0x6E82).SetLocalPose(0.1357264f,1.246357f,-0.005311598f,0.5051545f,-0.7664493f,-0.1917825f,-0.3472663f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.7240452f);
Get(0x6EC6).SetLocalPose(0.3577849f,0.9546021f,-0.1226618f,-0.4228123f,-0.6315091f,-0.6480601f,-0.04943929f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095447f,1.309673f,0.1327315f,-0.7030653f,-0.01445876f,-0.00955878f,0.7109141f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.4106984f);
Get(0x6E70).SetLocalPose(0.05498086f,1.520373f,-0.03673487f,0.4830605f,-0.3835618f,-0.5669094f,0.5460281f);
Get(0x6E82).SetLocalPose(0.09146552f,1.235337f,0.01019811f,0.469877f,-0.713759f,-0.2562739f,-0.4517604f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.7856815f);
Get(0x6EC6).SetLocalPose(0.3790169f,0.9110401f,-0.1253816f,-0.473648f,-0.5576574f,-0.6808899f,-0.03263371f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095086f,1.309446f,0.1329101f,-0.7030676f,-0.01442517f,-0.009571286f,0.7109123f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.4706941f);
Get(0x6E70).SetLocalPose(0.03451649f,1.524801f,-0.01084077f,0.4911001f,-0.3861825f,-0.5495638f,0.5546741f);
Get(0x6E82).SetLocalPose(0.05604712f,1.232518f,0.03661369f,0.4154843f,-0.6343153f,-0.3341753f,-0.5597712f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.8456772f);
Get(0x6EC6).SetLocalPose(0.4110964f,0.8840352f,-0.1284633f,-0.5187399f,-0.4789534f,-0.708171f,-0.002540463f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09515f,1.309258f,0.1328987f,-0.7030752f,-0.01442206f,-0.009615537f,0.7109043f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.5313846f);
Get(0x6E70).SetLocalPose(0.005041192f,1.535361f,0.02280567f,0.5064588f,-0.3957983f,-0.5208989f,0.5617005f);
Get(0x6E82).SetLocalPose(0.02628214f,1.232605f,0.05852564f,0.3981108f,-0.5641037f,-0.3697739f,-0.6217412f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.9063677f);
Get(0x6EC6).SetLocalPose(0.4497002f,0.8756927f,-0.1261282f,-0.5401374f,-0.4192171f,-0.7284878f,0.04259314f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095472f,1.309271f,0.1329398f,-0.7031016f,-0.01439646f,-0.009610636f,0.7108787f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.5915181f);
Get(0x6E70).SetLocalPose(-0.02064006f,1.546108f,0.04843993f,0.5203028f,-0.4071746f,-0.4981737f,0.5615307f);
Get(0x6E82).SetLocalPose(-0.03328824f,1.241458f,0.08281881f,0.4706256f,-0.4651009f,-0.3189214f,-0.6785882f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.9665012f);
Get(0x6EC6).SetLocalPose(0.5008719f,0.8826653f,-0.1100435f,-0.526293f,-0.3477201f,-0.7664264f,0.1212308f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095285f,1.309305f,0.133101f,-0.7030807f,-0.01435709f,-0.009623505f,0.7109f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.6532498f);
Get(0x6E70).SetLocalPose(-0.05577954f,1.562446f,0.08087108f,0.5381363f,-0.4239108f,-0.4717921f,0.5550867f);
Get(0x6E82).SetLocalPose(-0.07560989f,1.253914f,0.1000137f,0.5011669f,-0.3867725f,-0.27334f,-0.7242404f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.028233f);
Get(0x6EC6).SetLocalPose(0.5609184f,0.9148223f,-0.07287804f,-0.4568189f,-0.2788957f,-0.8204073f,0.2011607f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.6532498f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.028233f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095531f,1.30932f,0.1331324f,-0.7030893f,-0.01444086f,-0.009557988f,0.7108907f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.7896594f);
Get(0x6E70).SetLocalPose(-0.1355016f,1.596391f,0.1465781f,0.5685201f,-0.477416f,-0.4194391f,0.5224268f);
Get(0x6E82).SetLocalPose(-0.1703423f,1.276167f,0.1334084f,0.5120984f,-0.1407786f,-0.2974285f,-0.7933933f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.164642f);
Get(0x6EC6).SetLocalPose(0.6540082f,1.065678f,0.09471273f,-0.1971085f,-0.2177801f,-0.8527172f,0.4319647f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09545f,1.309241f,0.1332144f,-0.7030998f,-0.01438907f,-0.009616368f,0.7108806f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.848844f);
Get(0x6E70).SetLocalPose(-0.1655389f,1.602671f,0.1700778f,0.5784546f,-0.5024858f,-0.399015f,0.5036721f);
Get(0x6E82).SetLocalPose(-0.2068639f,1.278064f,0.1398788f,0.5267264f,-0.0588672f,-0.2705268f,-0.8036848f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.223827f);
Get(0x6EC6).SetLocalPose(0.6696604f,1.167912f,0.222298f,-0.2052846f,-0.2854158f,-0.8055687f,0.4769227f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094957f,1.309006f,0.1330789f,-0.7030812f,-0.01432602f,-0.009644184f,0.7108999f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.9100896f);
Get(0x6E70).SetLocalPose(-0.1872871f,1.603279f,0.1896584f,0.5896744f,-0.5179275f,-0.383547f,0.4867514f);
Get(0x6E82).SetLocalPose(-0.2349804f,1.275944f,0.1426116f,0.5491691f,0.002472311f,-0.2014375f,-0.8110673f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.285073f);
Get(0x6EC6).SetLocalPose(0.6459065f,1.278407f,0.374373f,-0.1975732f,-0.3909846f,-0.7693315f,0.4649999f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094622f,1.308762f,0.1329938f,-0.7030774f,-0.01437028f,-0.009631762f,0.7109029f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.9702486f);
Get(0x6E70).SetLocalPose(-0.2085247f,1.598742f,0.2128821f,0.6038635f,-0.5268441f,-0.3692389f,0.4705814f);
Get(0x6E82).SetLocalPose(-0.2556826f,1.270348f,0.1435493f,0.5678338f,0.04245735f,-0.1194721f,-0.8133194f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.345232f);
Get(0x6EC6).SetLocalPose(0.5844828f,1.376977f,0.5146124f,-0.1361631f,-0.4709661f,-0.7448708f,0.4525683f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09487f,1.309253f,0.1331835f,-0.7030964f,-0.01439584f,-0.009656212f,0.7108832f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.031361f);
Get(0x6E70).SetLocalPose(-0.2232775f,1.591287f,0.2341645f,0.6140471f,-0.5303302f,-0.3597326f,0.460748f);
Get(0x6E82).SetLocalPose(-0.27073f,1.261828f,0.1472927f,0.5731143f,0.09613732f,-0.0352734f,-0.813052f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.406344f);
Get(0x6EC6).SetLocalPose(0.4679737f,1.479039f,0.6663564f,-0.01115324f,-0.5346546f,-0.7164666f,0.4479907f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095096f,1.309388f,0.1332088f,-0.7030968f,-0.01436314f,-0.009659188f,0.7108836f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.093257f);
Get(0x6E70).SetLocalPose(-0.2328494f,1.581807f,0.2529203f,0.6208897f,-0.5330033f,-0.352414f,0.4541013f);
Get(0x6E82).SetLocalPose(-0.2820522f,1.249465f,0.1541087f,0.5709002f,0.151696f,0.02006308f,-0.8066342f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.46824f);
Get(0x6EC6).SetLocalPose(0.3153863f,1.561089f,0.775344f,0.1123339f,-0.5798398f,-0.6854456f,0.4258302f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095497f,1.30937f,0.133256f,-0.7030972f,-0.01439695f,-0.00964283f,0.7108827f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0f);
Get(0x6E70).SetLocalPose(-0.2380874f,1.574902f,0.2653542f,0.6252934f,-0.534236f,-0.3473659f,0.4504854f);
Get(0x6E82).SetLocalPose(-0.285014f,1.245109f,0.1578787f,0.5710114f,0.1658224f,0.03041059f,-0.8034452f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.497871f);
Get(0x6EC6).SetLocalPose(0.2265731f,1.594684f,0.8110263f,0.1603742f,-0.631506f,-0.6477007f,0.3949231f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095433f,1.309866f,0.1334913f,-0.7031146f,-0.01446872f,-0.009570798f,0.710865f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.1076031f);
Get(0x6E70).SetLocalPose(-0.2467526f,1.551043f,0.3007863f,0.6404238f,-0.5321406f,-0.3350296f,0.4409523f);
Get(0x6E82).SetLocalPose(-0.2946657f,1.22979f,0.1839898f,0.5851805f,0.220287f,0.04562782f,-0.7790735f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.605474f);
Get(0x6EC6).SetLocalPose(-0.06581184f,1.635354f,0.8281716f,0.2468997f,-0.8000623f,-0.5428501f,0.06522767f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095517f,1.309909f,0.1335324f,-0.7031156f,-0.0144275f,-0.009575329f,0.7108647f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.1423028f);
Get(0x6E70).SetLocalPose(-0.2476469f,1.544513f,0.3102594f,0.6445104f,-0.5306726f,-0.3336504f,0.4378017f);
Get(0x6E82).SetLocalPose(-0.2956889f,1.225888f,0.1946547f,0.5979822f,0.2301944f,0.04658899f,-0.7663272f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.640174f);
Get(0x6EC6).SetLocalPose(-0.1565834f,1.622713f,0.8142665f,0.2985799f,-0.7943618f,-0.5281964f,-0.02912096f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095467f,1.309743f,0.1334719f,-0.7031049f,-0.01435537f,-0.009627212f,0.7108761f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.2116009f);
Get(0x6E70).SetLocalPose(-0.2506515f,1.534035f,0.3294204f,0.6465171f,-0.5320578f,-0.3350513f,0.4320541f);
Get(0x6E82).SetLocalPose(-0.2961497f,1.219288f,0.2167548f,0.6256014f,0.2379974f,0.04432156f,-0.7416305f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.709472f);
Get(0x6EC6).SetLocalPose(-0.2979779f,1.582654f,0.7717451f,0.4037717f,-0.758763f,-0.4908247f,-0.1426127f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09548f,1.309573f,0.133497f,-0.7031075f,-0.01447764f,-0.009523345f,0.7108724f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.2738151f);
Get(0x6E70).SetLocalPose(-0.2535766f,1.525936f,0.350048f,0.6414484f,-0.5396829f,-0.3392086f,0.4268769f);
Get(0x6E82).SetLocalPose(-0.2973062f,1.214653f,0.2370187f,0.6531786f,0.2380832f,0.0339919f,-0.7179964f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.771686f);
Get(0x6EC6).SetLocalPose(-0.3990099f,1.532085f,0.7189857f,0.4438745f,-0.7238164f,-0.4567437f,-0.2654251f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095346f,1.309424f,0.133369f,-0.7030889f,-0.01441495f,-0.00958007f,0.7108913f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.3363163f);
Get(0x6E70).SetLocalPose(-0.2553431f,1.521338f,0.3683371f,0.635859f,-0.5479446f,-0.3398663f,0.4241828f);
Get(0x6E82).SetLocalPose(-0.297336f,1.211803f,0.2590626f,0.6900545f,0.2400199f,0.0216574f,-0.682456f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.834188f);
Get(0x6EC6).SetLocalPose(-0.4725832f,1.459858f,0.6469404f,0.4878522f,-0.6589441f,-0.4285064f,-0.3797043f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095305f,1.309346f,0.1331638f,-0.7031152f,-0.01437686f,-0.009612962f,0.7108657f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.3978246f);
Get(0x6E70).SetLocalPose(-0.2563581f,1.520195f,0.3832926f,0.6315727f,-0.5541244f,-0.3418833f,0.4209251f);
Get(0x6E82).SetLocalPose(-0.298244f,1.211886f,0.2830212f,0.7244108f,0.2487284f,0.004978909f,-0.642914f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.895696f);
Get(0x6EC6).SetLocalPose(-0.5106191f,1.399337f,0.5870209f,0.5234948f,-0.5907603f,-0.412653f,-0.4546131f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095335f,1.309436f,0.1331213f,-0.7030917f,-0.01434396f,-0.009655058f,0.710889f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.4577129f);
Get(0x6E70).SetLocalPose(-0.2568499f,1.52381f,0.3998005f,0.6288707f,-0.5574325f,-0.3493382f,0.4144316f);
Get(0x6E82).SetLocalPose(-0.2981644f,1.213654f,0.2974585f,0.7397665f,0.2570839f,-0.01013864f,-0.621732f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.955584f);
Get(0x6EC6).SetLocalPose(-0.5171032f,1.333106f,0.5306429f,0.5364799f,-0.5208036f,-0.40761f,-0.5242203f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095282f,1.309356f,0.1331786f,-0.7030853f,-0.01442479f,-0.00958311f,0.7108946f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0f);
Get(0x6E70).SetLocalPose(-0.2562744f,1.526927f,0.4060724f,0.628364f,-0.5574045f,-0.3544478f,0.4108841f);
Get(0x6E82).SetLocalPose(-0.2983013f,1.216122f,0.3112024f,0.7491827f,0.2638096f,-0.02775086f,-0.6069264f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.98565f);
Get(0x6EC6).SetLocalPose(-0.5153154f,1.304036f,0.5085061f,0.532777f,-0.4949913f,-0.4082899f,-0.5517533f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.98565f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095085f,1.309096f,0.132939f,-0.7030982f,-0.01438447f,-0.009660246f,0.7108817f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.1400197f);
Get(0x6E70).SetLocalPose(-0.246402f,1.547076f,0.4283122f,0.6235502f,-0.5577766f,-0.3776939f,0.3967589f);
Get(0x6E82).SetLocalPose(-0.2871097f,1.23476f,0.3569283f,0.7750812f,0.2417802f,-0.07263804f,-0.5792367f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.12567f);
Get(0x6EC6).SetLocalPose(-0.4605401f,1.202355f,0.4618493f,0.4796108f,-0.4406282f,-0.4365616f,-0.6206724f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095147f,1.309164f,0.1329648f,-0.7030994f,-0.0143648f,-0.009654541f,0.7108809f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.2087988f);
Get(0x6E70).SetLocalPose(-0.2382097f,1.557064f,0.4337116f,0.6224917f,-0.557972f,-0.3784012f,0.397472f);
Get(0x6E82).SetLocalPose(-0.2789017f,1.244786f,0.3664772f,0.7873058f,0.2380148f,-0.06214595f,-0.5653641f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.194449f);
Get(0x6EC6).SetLocalPose(-0.4251069f,1.176109f,0.4675304f,0.4317675f,-0.4158059f,-0.4789443f,-0.6413226f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094934f,1.309142f,0.1330439f,-0.7030806f,-0.01444705f,-0.009605635f,0.7108986f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.2967806f);
Get(0x6E70).SetLocalPose(-0.2193856f,1.573421f,0.4387327f,0.6193516f,-0.5596399f,-0.3747453f,0.4034511f);
Get(0x6E82).SetLocalPose(-0.2639251f,1.259742f,0.3784164f,0.7890718f,0.2584991f,-0.04394466f,-0.5555293f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.282431f);
Get(0x6EC6).SetLocalPose(-0.3685757f,1.160246f,0.4927826f,0.3560428f,-0.4173823f,-0.5209413f,-0.6539464f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095122f,1.309254f,0.1331662f,-0.7030991f,-0.01442628f,-0.009637709f,0.7108802f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.3551221f);
Get(0x6E70).SetLocalPose(-0.2117108f,1.578786f,0.4396943f,0.6170508f,-0.5612351f,-0.3737919f,0.4056394f);
Get(0x6E82).SetLocalPose(-0.2550853f,1.268652f,0.3862259f,0.7869394f,0.2655297f,-0.05137303f,-0.5546001f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.340772f);
Get(0x6EC6).SetLocalPose(-0.3378359f,1.158746f,0.5095741f,0.3247365f,-0.4403131f,-0.5289435f,-0.64876f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095199f,1.309634f,0.1332213f,-0.7030632f,-0.01439463f,-0.009670003f,0.7109159f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.4134071f);
Get(0x6E70).SetLocalPose(-0.1889765f,1.593538f,0.4416719f,0.6093781f,-0.5675458f,-0.3708505f,0.4111204f);
Get(0x6E82).SetLocalPose(-0.2427997f,1.279804f,0.3954877f,0.7883839f,0.2472468f,-0.08351259f,-0.5570867f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.399057f);
Get(0x6EC6).SetLocalPose(-0.2827165f,1.161339f,0.5458925f,0.2684748f,-0.4712904f,-0.544059f,-0.6401613f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095239f,1.309561f,0.1332174f,-0.7030733f,-0.01441498f,-0.009602309f,0.7109065f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0f);
Get(0x6E70).SetLocalPose(-0.169332f,1.601612f,0.4421599f,0.6020793f,-0.5739239f,-0.3683759f,0.4152242f);
Get(0x6E82).SetLocalPose(-0.2260128f,1.293049f,0.4055853f,0.7934948f,0.2252417f,-0.1197258f,-0.5525377f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.459252f);
Get(0x6EC6).SetLocalPose(-0.2363538f,1.166774f,0.5796434f,0.2189229f,-0.4897927f,-0.5562758f,-0.6346126f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.459252f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09513f,1.309594f,0.1330588f,-0.7030709f,-0.01443634f,-0.009604698f,0.7109084f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.1306062f);
Get(0x6E70).SetLocalPose(-0.1242861f,1.613402f,0.4404394f,0.5876045f,-0.5822415f,-0.3666244f,0.4257961f);
Get(0x6E82).SetLocalPose(-0.1914446f,1.312179f,0.4219026f,0.8024319f,0.2161247f,-0.1255098f,-0.541886f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.589859f);
Get(0x6EC6).SetLocalPose(-0.1365618f,1.209506f,0.645309f,0.143176f,-0.5520344f,-0.5300791f,-0.6275148f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095348f,1.309532f,0.1331311f,-0.7030754f,-0.01439491f,-0.009642049f,0.7109042f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.1890462f);
Get(0x6E70).SetLocalPose(-0.1046727f,1.61679f,0.4398478f,0.5817056f,-0.582895f,-0.3691664f,0.4307764f);
Get(0x6E82).SetLocalPose(-0.1734844f,1.320172f,0.4312404f,0.8115247f,0.1990281f,-0.1255731f,-0.5348336f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.648299f);
Get(0x6EC6).SetLocalPose(-0.09950228f,1.228223f,0.6650208f,0.1199681f,-0.5777128f,-0.51653f,-0.6205259f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095536f,1.309685f,0.1331254f,-0.7030495f,-0.01441787f,-0.009591686f,0.71093f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.2494397f);
Get(0x6E70).SetLocalPose(-0.0814371f,1.619146f,0.4401403f,0.574735f,-0.582124f,-0.3743617f,0.4366517f);
Get(0x6E82).SetLocalPose(-0.1553361f,1.328754f,0.440928f,0.8249856f,0.1767292f,-0.1261754f,-0.5217715f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.708692f);
Get(0x6EC6).SetLocalPose(-0.05820128f,1.2557f,0.6849943f,0.1066822f,-0.6056242f,-0.4771739f,-0.6278083f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095593f,1.309504f,0.1330551f,-0.7030647f,-0.01444626f,-0.009582632f,0.7109146f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.3113459f);
Get(0x6E70).SetLocalPose(-0.06329526f,1.621641f,0.4407824f,0.568998f,-0.5810446f,-0.3801516f,0.4405828f);
Get(0x6E82).SetLocalPose(-0.1369797f,1.337957f,0.4508067f,0.8442789f,0.1603658f,-0.112135f,-0.4989005f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.770598f);
Get(0x6EC6).SetLocalPose(-0.02134533f,1.285425f,0.6969008f,0.09635268f,-0.6373006f,-0.4312136f,-0.6313629f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095478f,1.309523f,0.1328298f,-0.7030546f,-0.01441107f,-0.009635519f,0.7109246f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.3716219f);
Get(0x6E70).SetLocalPose(-0.04602211f,1.62535f,0.442465f,0.5629396f,-0.5800049f,-0.3868474f,0.4438945f);
Get(0x6E82).SetLocalPose(-0.1230888f,1.34844f,0.457619f,0.8602295f,0.1536489f,-0.09956723f,-0.475903f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.830874f);
Get(0x6EC6).SetLocalPose(0.01399739f,1.312088f,0.7061032f,0.0861651f,-0.663825f,-0.3885163f,-0.6332197f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095355f,1.3092f,0.1326628f,-0.7030593f,-0.01433388f,-0.009628627f,0.7109217f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.4322889f);
Get(0x6E70).SetLocalPose(-0.02776468f,1.629863f,0.4456363f,0.5562805f,-0.5784159f,-0.3938034f,0.4482252f);
Get(0x6E82).SetLocalPose(-0.1090951f,1.36244f,0.4667635f,0.8714333f,0.1524944f,-0.1059946f,-0.4539986f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.891541f);
Get(0x6EC6).SetLocalPose(0.05241209f,1.345358f,0.7123848f,0.06895479f,-0.6863987f,-0.3423078f,-0.6379086f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095f,1.309086f,0.1327211f,-0.7030256f,-0.01435293f,-0.009636667f,0.7109545f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.4918163f);
Get(0x6E70).SetLocalPose(-0.01221169f,1.635331f,0.4494859f,0.5505602f,-0.5753255f,-0.3990116f,0.454614f);
Get(0x6E82).SetLocalPose(-0.0989029f,1.376277f,0.4757455f,0.8753491f,0.1475086f,-0.1371175f,-0.4395497f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.951069f);
Get(0x6EC6).SetLocalPose(0.08117161f,1.371593f,0.7125062f,0.05384815f,-0.6972728f,-0.3053197f,-0.6462902f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.4918163f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.951069f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095f,1.309095f,0.1328432f,-0.7030835f,-0.01432191f,-0.009654837f,0.7108975f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.5933733f);
Get(0x6E70).SetLocalPose(0.01465632f,1.652537f,0.4590105f,0.5416178f,-0.5663402f,-0.4113212f,0.4655361f);
Get(0x6E82).SetLocalPose(-0.07784469f,1.410017f,0.497832f,0.8700328f,0.1192907f,-0.2173819f,-0.4260961f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.052626f);
Get(0x6EC6).SetLocalPose(0.1342483f,1.42177f,0.7062773f,0.0336461f,-0.719518f,-0.2323063f,-0.6536021f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095162f,1.308943f,0.1328468f,-0.7030823f,-0.01431371f,-0.00968425f,0.7108986f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.6636416f);
Get(0x6E70).SetLocalPose(0.02571066f,1.663753f,0.4639798f,0.5374361f,-0.5615327f,-0.4205655f,0.4679403f);
Get(0x6E82).SetLocalPose(-0.06271033f,1.435657f,0.5124543f,0.8650409f,0.09963337f,-0.2570005f,-0.4191994f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.122894f);
Get(0x6EC6).SetLocalPose(0.1615827f,1.451404f,0.7004645f,0.01563098f,-0.7306501f,-0.1968035f,-0.6535859f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09497f,1.309224f,0.1329024f,-0.703052f,-0.014338f,-0.009659131f,0.7109283f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.7239447f);
Get(0x6E70).SetLocalPose(0.03628517f,1.67888f,0.4690831f,0.5328597f,-0.5557341f,-0.4307522f,0.4708213f);
Get(0x6E82).SetLocalPose(-0.05009605f,1.459355f,0.5240669f,0.8633332f,0.08440196f,-0.2828585f,-0.409296f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.183197f);
Get(0x6EC6).SetLocalPose(0.1811758f,1.4754f,0.6949211f,0.0003525668f,-0.7349089f,-0.1757088f,-0.6550078f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094822f,1.309228f,0.1329632f,-0.7030928f,-0.01440569f,-0.009643832f,0.7108868f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.8095173f);
Get(0x6E70).SetLocalPose(0.04998519f,1.704292f,0.4773366f,0.5234436f,-0.5479826f,-0.4435601f,0.4785147f);
Get(0x6E82).SetLocalPose(-0.0311652f,1.490239f,0.5387574f,0.8627894f,0.06415612f,-0.3057046f,-0.3975213f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.26877f);
Get(0x6EC6).SetLocalPose(0.2073705f,1.50859f,0.6848708f,-0.01088218f,-0.7406573f,-0.1507385f,-0.6546651f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094851f,1.308938f,0.1329554f,-0.7030855f,-0.01434731f,-0.009704177f,0.7108944f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.8705838f);
Get(0x6E70).SetLocalPose(0.05727218f,1.719472f,0.4824339f,0.515291f,-0.5445182f,-0.4500498f,0.4852116f);
Get(0x6E82).SetLocalPose(-0.01692181f,1.512999f,0.5493841f,0.8625372f,0.04374015f,-0.3198603f,-0.3896226f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0f);
Get(0x6EC6).SetLocalPose(0.2205162f,1.526317f,0.6778358f,-0.01188673f,-0.7477407f,-0.1378566f,-0.6494137f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094988f,1.309596f,0.1333535f,-0.7030724f,-0.01436967f,-0.009617984f,0.7109081f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.9300891f);
Get(0x6E70).SetLocalPose(0.06448802f,1.737025f,0.4884309f,0.5043232f,-0.5414634f,-0.4565499f,0.4940016f);
Get(0x6E82).SetLocalPose(-0.003780252f,1.534078f,0.5592532f,0.8621163f,0.0136276f,-0.3314068f,-0.3830656f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.05950523f);
Get(0x6EC6).SetLocalPose(0.2332667f,1.541083f,0.6700835f,-0.0122362f,-0.7555831f,-0.1267029f,-0.6425658f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095153f,1.309471f,0.1334404f,-0.7030709f,-0.01439819f,-0.009618334f,0.7109089f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.9579866f);
Get(0x6E70).SetLocalPose(0.06879959f,1.746622f,0.4920175f,0.4970737f,-0.539942f,-0.4601103f,0.4996789f);
Get(0x6E82).SetLocalPose(0.003093342f,1.544628f,0.5635656f,0.8621299f,-0.002739592f,-0.3358375f,-0.3793912f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.08740277f);
Get(0x6EC6).SetLocalPose(0.2402287f,1.550827f,0.6652606f,-0.01348024f,-0.7578188f,-0.1216932f,-0.6408742f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.9579866f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.08740277f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095174f,1.309546f,0.1333966f,-0.7030858f,-0.01440631f,-0.009636774f,0.7108938f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.098077f);
Get(0x6E70).SetLocalPose(0.08025801f,1.770687f,0.5034235f,0.4731123f,-0.5330956f,-0.4694701f,0.5211255f);
Get(0x6E82).SetLocalPose(0.02795523f,1.580083f,0.5814966f,0.8579295f,-0.05275423f,-0.3595949f,-0.3631328f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.2274936f);
Get(0x6EC6).SetLocalPose(0.2588356f,1.569337f,0.6536962f,-0.02458931f,-0.7565058f,-0.1097276f,-0.6442471f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095407f,1.309466f,0.1332262f,-0.7030802f,-0.01442237f,-0.009588908f,0.7108996f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.157922f);
Get(0x6E70).SetLocalPose(0.08507982f,1.774015f,0.5073551f,0.4659292f,-0.5274063f,-0.4737396f,0.5294558f);
Get(0x6E82).SetLocalPose(0.03643272f,1.588766f,0.5885746f,0.8478872f,-0.06780543f,-0.385531f,-0.3575689f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.2873385f);
Get(0x6EC6).SetLocalPose(0.2653427f,1.572105f,0.6482896f,-0.02862996f,-0.7573949f,-0.1035617f,-0.6440563f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095056f,1.309536f,0.1330731f,-0.7030463f,-0.01437588f,-0.009605766f,0.7109339f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.218819f);
Get(0x6E70).SetLocalPose(0.08888797f,1.772518f,0.5100913f,0.4603947f,-0.5218876f,-0.4800305f,0.5340793f);
Get(0x6E82).SetLocalPose(0.04583378f,1.592686f,0.594676f,0.8324105f,-0.08970491f,-0.4164633f,-0.3544069f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.3482354f);
Get(0x6EC6).SetLocalPose(0.2684313f,1.570863f,0.6427588f,-0.02884039f,-0.7604574f,-0.0978604f,-0.6413237f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095296f,1.309325f,0.1332093f,-0.7030518f,-0.01441506f,-0.009583278f,0.710928f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.280073f);
Get(0x6E70).SetLocalPose(0.09256522f,1.767742f,0.5126917f,0.4548399f,-0.5178003f,-0.4867126f,0.536763f);
Get(0x6E82).SetLocalPose(0.05501149f,1.591599f,0.5983689f,0.8174217f,-0.1150719f,-0.4434362f,-0.3492058f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.4094889f);
Get(0x6EC6).SetLocalPose(0.2704231f,1.566143f,0.6382359f,-0.02650634f,-0.7635134f,-0.09336202f,-0.6384578f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095498f,1.309292f,0.1328671f,-0.7030559f,-0.01441968f,-0.009605867f,0.7109236f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.343958f);
Get(0x6E70).SetLocalPose(0.09521406f,1.76013f,0.5144923f,0.4500627f,-0.5147886f,-0.4914682f,0.5393472f);
Get(0x6E82).SetLocalPose(0.06410513f,1.585455f,0.6008626f,0.8079265f,-0.1388505f,-0.4601051f,-0.3409968f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.4733741f);
Get(0x6EC6).SetLocalPose(0.2719294f,1.554842f,0.6341183f,-0.02303536f,-0.7653494f,-0.0892562f,-0.6369796f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095449f,1.309361f,0.1330092f,-0.703057f,-0.01438616f,-0.009626163f,0.7109229f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.402725f);
Get(0x6E70).SetLocalPose(0.09876655f,1.746668f,0.5163827f,0.4455801f,-0.5109573f,-0.4946669f,0.5437698f);
Get(0x6E82).SetLocalPose(0.07304721f,1.574486f,0.6029296f,0.8063806f,-0.1502178f,-0.4655204f,-0.332379f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.5321406f);
Get(0x6EC6).SetLocalPose(0.2724335f,1.545025f,0.6314918f,-0.02179808f,-0.7658548f,-0.08816503f,-0.6365675f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095497f,1.309376f,0.1329731f,-0.7030505f,-0.01439772f,-0.009611037f,0.7109293f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.432397f);
Get(0x6E70).SetLocalPose(0.1003543f,1.736571f,0.5170912f,0.4438007f,-0.5088527f,-0.495726f,0.5462285f);
Get(0x6E82).SetLocalPose(0.07726564f,1.566977f,0.6043826f,0.8057826f,-0.1519273f,-0.4672621f,-0.3306035f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.5618132f);
Get(0x6EC6).SetLocalPose(0.272733f,1.532248f,0.6295522f,-0.02076778f,-0.7670076f,-0.08730228f,-0.6353316f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094988f,1.309205f,0.1326076f,-0.7030213f,-0.01436929f,-0.009644954f,0.7109583f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.534505f);
Get(0x6E70).SetLocalPose(0.1045932f,1.705984f,0.5181956f,0.440536f,-0.5040148f,-0.4990791f,0.5502883f);
Get(0x6E82).SetLocalPose(0.09076502f,1.534155f,0.6082222f,0.7994282f,-0.1656848f,-0.4840955f,-0.3148248f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.6639215f);
Get(0x6EC6).SetLocalPose(0.2732027f,1.499645f,0.6247939f,-0.01298625f,-0.7707902f,-0.08626152f,-0.6310886f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095172f,1.309192f,0.1327224f,-0.7030512f,-0.01432194f,-0.009642334f,0.7109296f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.602774f);
Get(0x6E70).SetLocalPose(0.1083886f,1.681353f,0.5180529f,0.4393165f,-0.5005042f,-0.5020583f,0.5517554f);
Get(0x6E82).SetLocalPose(0.09957884f,1.510867f,0.6086987f,0.8037983f,-0.1646611f,-0.4896201f,-0.2950712f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.7321904f);
Get(0x6EC6).SetLocalPose(0.2729425f,1.473801f,0.6206487f,-0.005098822f,-0.7761945f,-0.08533236f,-0.6246716f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095212f,1.309012f,0.1326972f,-0.7030368f,-0.01432611f,-0.009650311f,0.7109436f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.664417f);
Get(0x6E70).SetLocalPose(0.1125384f,1.657387f,0.5168501f,0.4400132f,-0.4968814f,-0.5054516f,0.5513765f);
Get(0x6E82).SetLocalPose(0.110189f,1.487491f,0.6080686f,0.8137577f,-0.1540076f,-0.4823149f,-0.2853985f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.7938332f);
Get(0x6EC6).SetLocalPose(0.274276f,1.453305f,0.6170821f,-0.001796524f,-0.7819217f,-0.08590625f,-0.6174265f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095063f,1.309048f,0.1327564f,-0.7030275f,-0.0143584f,-0.009636998f,0.7109525f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.72881f);
Get(0x6E70).SetLocalPose(0.1175804f,1.632595f,0.5134497f,0.4424672f,-0.492262f,-0.5106531f,0.5487571f);
Get(0x6E82).SetLocalPose(0.1247626f,1.463323f,0.6070271f,0.8133793f,-0.1560833f,-0.4850947f,-0.280598f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.8582258f);
Get(0x6EC6).SetLocalPose(0.2771528f,1.428977f,0.6135564f,-0.004835773f,-0.7846198f,-0.09100078f,-0.6132431f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095241f,1.308842f,0.1326333f,-0.7030609f,-0.01438387f,-0.009607505f,0.7109193f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.792059f);
Get(0x6E70).SetLocalPose(0.1223485f,1.615099f,0.5095392f,0.4456591f,-0.4880086f,-0.5156419f,0.5452973f);
Get(0x6E82).SetLocalPose(0.137734f,1.44255f,0.6046396f,0.8078099f,-0.1564062f,-0.4944482f,-0.2801809f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.9214753f);
Get(0x6EC6).SetLocalPose(0.2830717f,1.409289f,0.6094422f,-0.01771877f,-0.7849697f,-0.094012f,-0.6121032f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095025f,1.308807f,0.1327799f,-0.7030814f,-0.01437144f,-0.009647937f,0.7108986f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.85391f);
Get(0x6E70).SetLocalPose(0.129246f,1.597988f,0.503434f,0.4511333f,-0.4818239f,-0.5202541f,0.5419043f);
Get(0x6E82).SetLocalPose(0.1469258f,1.42588f,0.5984467f,0.8131304f,-0.1444305f,-0.4923228f,-0.2749129f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.9833264f);
Get(0x6EC6).SetLocalPose(0.2939477f,1.395511f,0.6013449f,-0.03029925f,-0.7925584f,-0.09670562f,-0.6013162f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095068f,1.308816f,0.1328621f,-0.7030675f,-0.01434545f,-0.009638363f,0.7109132f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.914215f);
Get(0x6E70).SetLocalPose(0.1376077f,1.583082f,0.4950687f,0.4580271f,-0.4740763f,-0.5241398f,0.5392034f);
Get(0x6E82).SetLocalPose(0.1551687f,1.414014f,0.5901074f,0.8100774f,-0.1398508f,-0.5011386f,-0.270327f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.043631f);
Get(0x6EC6).SetLocalPose(0.3071049f,1.384848f,0.5905846f,-0.03774467f,-0.793959f,-0.1008384f,-0.5983612f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.914215f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.043631f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095139f,1.309082f,0.1329218f,-0.7030653f,-0.01438654f,-0.009627858f,0.7109146f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.015762f);
Get(0x6E70).SetLocalPose(0.1529618f,1.571365f,0.4775065f,0.4656098f,-0.4633888f,-0.5321252f,0.5341547f);
Get(0x6E82).SetLocalPose(0.1715703f,1.404132f,0.5668087f,0.8064187f,-0.1244698f,-0.5109137f,-0.2704873f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.145178f);
Get(0x6EC6).SetLocalPose(0.3306288f,1.377823f,0.5641743f,-0.03868335f,-0.8050821f,-0.1047836f,-0.582552f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095285f,1.309233f,0.1328323f,-0.703065f,-0.0143982f,-0.009627578f,0.7109147f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.08717f);
Get(0x6E70).SetLocalPose(0.1642386f,1.570859f,0.463696f,0.4691284f,-0.456765f,-0.5382943f,0.530588f);
Get(0x6E82).SetLocalPose(0.1808104f,1.404532f,0.5521854f,0.8081063f,-0.1202924f,-0.5094633f,-0.2700764f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.216586f);
Get(0x6EC6).SetLocalPose(0.3441007f,1.38191f,0.5451562f,-0.0321725f,-0.8131502f,-0.1135747f,-0.5699584f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095256f,1.309608f,0.1329414f,-0.7030615f,-0.01440604f,-0.009623f,0.7109181f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.1463f);
Get(0x6E70).SetLocalPose(0.1736184f,1.575015f,0.4491479f,0.4723905f,-0.4505993f,-0.5431488f,0.5280122f);
Get(0x6E82).SetLocalPose(0.1929453f,1.409147f,0.5339912f,0.8128683f,-0.1166073f,-0.502573f,-0.2703115f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.275716f);
Get(0x6EC6).SetLocalPose(0.3539816f,1.389487f,0.527503f,-0.02176429f,-0.8170771f,-0.1260412f,-0.5621611f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095319f,1.309718f,0.1328918f,-0.7030322f,-0.01440255f,-0.009575443f,0.7109478f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.207657f);
Get(0x6E70).SetLocalPose(0.1838586f,1.583799f,0.4344903f,0.4750978f,-0.444496f,-0.5480814f,0.525654f);
Get(0x6E82).SetLocalPose(0.2068688f,1.417794f,0.5146782f,0.8177538f,-0.1170315f,-0.4937848f,-0.2715861f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.337073f);
Get(0x6EC6).SetLocalPose(0.3635054f,1.400859f,0.5089619f,-0.01229786f,-0.8211617f,-0.1358419f,-0.5541564f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095253f,1.309546f,0.1327682f,-0.7030455f,-0.01438461f,-0.009576908f,0.7109349f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.26987f);
Get(0x6E70).SetLocalPose(0.1931484f,1.594792f,0.4207773f,0.476103f,-0.4393437f,-0.5535505f,0.5233402f);
Get(0x6E82).SetLocalPose(0.2235504f,1.42986f,0.4954363f,0.8228952f,-0.1253849f,-0.4797823f,-0.2773646f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.399286f);
Get(0x6EC6).SetLocalPose(0.3719856f,1.413214f,0.4919418f,-0.00490485f,-0.8273604f,-0.145024f,-0.5426037f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095023f,1.309532f,0.1328628f,-0.7030576f,-0.01436376f,-0.009597496f,0.7109231f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.32816f);
Get(0x6E70).SetLocalPose(0.203789f,1.610438f,0.4049651f,0.4749948f,-0.4342195f,-0.5607107f,0.5209962f);
Get(0x6E82).SetLocalPose(0.2383533f,1.44218f,0.480278f,0.8275407f,-0.1373706f,-0.4636071f,-0.2852615f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.457576f);
Get(0x6EC6).SetLocalPose(0.3801892f,1.426683f,0.4758971f,0.0007777668f,-0.8346251f,-0.1560896f,-0.528239f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095215f,1.309453f,0.1328069f,-0.7030445f,-0.01438866f,-0.00957978f,0.7109358f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.388586f);
Get(0x6E70).SetLocalPose(0.213489f,1.627053f,0.3899274f,0.4714297f,-0.4296993f,-0.5685207f,0.5195159f);
Get(0x6E82).SetLocalPose(0.2542335f,1.454664f,0.4640565f,0.8304693f,-0.1531123f,-0.4465123f,-0.295811f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.518002f);
Get(0x6EC6).SetLocalPose(0.3885131f,1.442508f,0.45948f,0.00341088f,-0.8410215f,-0.1705762f,-0.5133957f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.388586f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.518002f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095276f,1.30923f,0.1328077f,-0.7030551f,-0.01436919f,-0.009609532f,0.7109253f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.520679f);
Get(0x6E70).SetLocalPose(0.2341703f,1.665943f,0.3584228f,0.4586926f,-0.4183025f,-0.5862966f,0.5204618f);
Get(0x6E82).SetLocalPose(0.276694f,1.481122f,0.4376384f,0.8361791f,-0.1349019f,-0.4418776f,-0.2955507f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.650095f);
Get(0x6EC6).SetLocalPose(0.4057254f,1.471883f,0.4312134f,-0.01890988f,-0.8584688f,-0.2006588f,-0.4716032f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095354f,1.309119f,0.1327795f,-0.7030643f,-0.01442218f,-0.00956862f,0.7109156f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.580211f);
Get(0x6E70).SetLocalPose(0.2438999f,1.683342f,0.3430633f,0.4507965f,-0.4122214f,-0.5934094f,0.5241386f);
Get(0x6E82).SetLocalPose(0.286131f,1.493564f,0.4289506f,0.8366275f,-0.1228205f,-0.4382439f,-0.3048147f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.709627f);
Get(0x6EC6).SetLocalPose(0.4176343f,1.484403f,0.4184689f,-0.04537847f,-0.8595297f,-0.2257725f,-0.4562632f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095298f,1.309067f,0.1329046f,-0.7030776f,-0.01437288f,-0.009598697f,0.7109031f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.03379908f);
Get(0x6E70).SetLocalPose(0.252496f,1.697109f,0.3289789f,0.4418615f,-0.4081444f,-0.5974217f,0.5303432f);
Get(0x6E82).SetLocalPose(0.2949508f,1.502353f,0.4236534f,0.8254873f,-0.122303f,-0.446761f,-0.3225173f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.7689f);
Get(0x6EC6).SetLocalPose(0.4275256f,1.49309f,0.408741f,-0.06433018f,-0.8568555f,-0.2517014f,-0.4453166f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095261f,1.308939f,0.1327123f,-0.703066f,-0.01437217f,-0.009620579f,0.7109143f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.09411662f);
Get(0x6E70).SetLocalPose(0.2615357f,1.708204f,0.3124182f,0.4300548f,-0.4054122f,-0.5988757f,0.540409f);
Get(0x6E82).SetLocalPose(0.3026155f,1.507742f,0.4207096f,0.8117156f,-0.1214487f,-0.4591832f,-0.3398803f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.829218f);
Get(0x6EC6).SetLocalPose(0.4355775f,1.499977f,0.3977037f,-0.08140047f,-0.8549969f,-0.2775596f,-0.4304822f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095207f,1.309038f,0.1328413f,-0.7030668f,-0.01434494f,-0.009626338f,0.710914f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.1541145f);
Get(0x6E70).SetLocalPose(0.2701759f,1.713305f,0.2944824f,0.4199372f,-0.4019967f,-0.5991321f,0.5505381f);
Get(0x6E82).SetLocalPose(0.3098175f,1.511425f,0.4196003f,0.7976355f,-0.112924f,-0.470063f,-0.3606473f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.889216f);
Get(0x6EC6).SetLocalPose(0.4434671f,1.500516f,0.3888871f,-0.08890491f,-0.8525165f,-0.3006214f,-0.4182563f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095025f,1.309197f,0.1330021f,-0.7030751f,-0.01436457f,-0.009612297f,0.7109056f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.2155625f);
Get(0x6E70).SetLocalPose(0.2774044f,1.712564f,0.2746091f,0.4149709f,-0.3960598f,-0.6016201f,0.5558678f);
Get(0x6E82).SetLocalPose(0.3182749f,1.511593f,0.4179905f,0.7772287f,-0.09923027f,-0.4841385f,-0.3894599f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.950664f);
Get(0x6EC6).SetLocalPose(0.4529096f,1.497931f,0.3767132f,-0.09815262f,-0.8543422f,-0.3118777f,-0.4039775f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095133f,1.309451f,0.1331756f,-0.703101f,-0.0143886f,-0.009615569f,0.7108794f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.2755825f);
Get(0x6E70).SetLocalPose(0.2846581f,1.707931f,0.2535652f,0.4117271f,-0.3902699f,-0.607628f,0.5558403f);
Get(0x6E82).SetLocalPose(0.3265408f,1.510283f,0.4159751f,0.7432662f,-0.08880933f,-0.5083323f,-0.4257541f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.010684f);
Get(0x6EC6).SetLocalPose(0.4607238f,1.494416f,0.3663255f,-0.1099011f,-0.8600127f,-0.3156857f,-0.3855419f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.2755825f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.010684f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095119f,1.309144f,0.1330274f,-0.7030626f,-0.01435976f,-0.009667064f,0.7109174f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.4107963f);
Get(0x6E70).SetLocalPose(0.2986577f,1.688474f,0.2036997f,0.4000881f,-0.383479f,-0.6256427f,0.5490398f);
Get(0x6E82).SetLocalPose(0.3463147f,1.490883f,0.4098357f,0.6588238f,-0.08054388f,-0.5685232f,-0.4860508f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.145898f);
Get(0x6EC6).SetLocalPose(0.4773945f,1.474928f,0.3444186f,-0.1451285f,-0.8602365f,-0.3311275f,-0.3595631f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095313f,1.309019f,0.1331985f,-0.7030693f,-0.0143777f,-0.009633163f,0.7109108f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.4726141f);
Get(0x6E70).SetLocalPose(0.3048632f,1.674644f,0.1803591f,0.3955855f,-0.3814956f,-0.6307922f,0.5477905f);
Get(0x6E82).SetLocalPose(0.3547697f,1.475022f,0.4059284f,0.612636f,-0.06882376f,-0.6035441f,-0.5056431f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.207716f);
Get(0x6EC6).SetLocalPose(0.4852178f,1.462645f,0.3336923f,-0.161027f,-0.8548402f,-0.3295112f,-0.367071f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095169f,1.308946f,0.1331992f,-0.7030802f,-0.01436469f,-0.009642239f,0.7109f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.5304354f);
Get(0x6E70).SetLocalPose(0.3103874f,1.661387f,0.1593456f,0.3927987f,-0.380118f,-0.6339884f,0.5470634f);
Get(0x6E82).SetLocalPose(0.3605136f,1.461893f,0.4010644f,0.5791841f,-0.0586278f,-0.6304125f,-0.5135064f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.265537f);
Get(0x6EC6).SetLocalPose(0.4912865f,1.451656f,0.3212668f,-0.1810998f,-0.8578921f,-0.3155917f,-0.362803f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095063f,1.309073f,0.1329612f,-0.7030695f,-0.01438378f,-0.009639991f,0.7109104f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.5915917f);
Get(0x6E70).SetLocalPose(0.3170055f,1.646172f,0.1370016f,0.3902651f,-0.3795193f,-0.6372861f,0.5454583f);
Get(0x6E82).SetLocalPose(0.3664893f,1.449301f,0.3922911f,0.5568193f,-0.04888512f,-0.6538336f,-0.5099648f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.326693f);
Get(0x6EC6).SetLocalPose(0.4952934f,1.439064f,0.3037842f,-0.2042678f,-0.860415f,-0.3052971f,-0.3532058f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094858f,1.309153f,0.1327234f,-0.7030332f,-0.01434333f,-0.009653648f,0.7109469f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.03323477f);
Get(0x6E70).SetLocalPose(0.3233869f,1.632091f,0.1161856f,0.3891862f,-0.379086f,-0.6403803f,0.5429006f);
Get(0x6E82).SetLocalPose(0.3702906f,1.439551f,0.3790262f,0.5383582f,-0.03507557f,-0.6742287f,-0.504337f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.387465f);
Get(0x6EC6).SetLocalPose(0.4986654f,1.431538f,0.2878917f,-0.2144479f,-0.8557022f,-0.3026807f,-0.3607912f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095096f,1.309004f,0.1328306f,-0.7030705f,-0.01434176f,-0.009675128f,0.7109097f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.09212831f);
Get(0x6E70).SetLocalPose(0.3317788f,1.614826f,0.09112365f,0.3902928f,-0.3780276f,-0.6448997f,0.5374674f);
Get(0x6E82).SetLocalPose(0.3719051f,1.432907f,0.3639222f,0.5138202f,-0.01787327f,-0.6973893f,-0.499317f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.446359f);
Get(0x6EC6).SetLocalPose(0.50353f,1.42438f,0.2663321f,-0.2236722f,-0.8478283f,-0.2905495f,-0.3830654f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095028f,1.30903f,0.1327872f,-0.7030529f,-0.01431301f,-0.009675525f,0.7109277f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.1203465f);
Get(0x6E70).SetLocalPose(0.3359937f,1.607735f,0.08009482f,0.3912695f,-0.3775095f,-0.6474695f,0.5340207f);
Get(0x6E82).SetLocalPose(0.3727794f,1.430986f,0.3485676f,0.4952759f,-0.009895241f,-0.7177534f,-0.48932f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.474577f);
Get(0x6EC6).SetLocalPose(0.5067934f,1.420609f,0.2522752f,-0.2318591f,-0.8407636f,-0.2761338f,-0.4038667f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095189f,1.309086f,0.132979f,-0.7030728f,-0.0143896f,-0.009659235f,0.7109067f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.227184f);
Get(0x6E70).SetLocalPose(0.35024f,1.587532f,0.04390676f,0.3964775f,-0.3750677f,-0.6551572f,0.5223972f);
Get(0x6E82).SetLocalPose(0.3733009f,1.433715f,0.3042796f,0.4911959f,-0.005873056f,-0.7471958f,-0.44765f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.581415f);
Get(0x6EC6).SetLocalPose(0.516057f,1.419504f,0.2139876f,-0.2589547f,-0.8035985f,-0.2427976f,-0.4777252f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095486f,1.309505f,0.1329533f,-0.7030638f,-0.01439526f,-0.009612399f,0.7109162f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.2920089f);
Get(0x6E70).SetLocalPose(0.3591412f,1.577276f,0.02405111f,0.4029995f,-0.3720142f,-0.6551937f,0.5195363f);
Get(0x6E82).SetLocalPose(0.3736087f,1.440614f,0.279497f,0.5099341f,-0.004897368f,-0.7430595f,-0.4333656f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.64624f);
Get(0x6EC6).SetLocalPose(0.5233395f,1.421481f,0.1911663f,-0.2789209f,-0.776072f,-0.2231126f,-0.5197464f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095728f,1.309497f,0.1329564f,-0.7030391f,-0.01440913f,-0.009617656f,0.7109402f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.3519104f);
Get(0x6E70).SetLocalPose(0.368325f,1.569234f,0.005150694f,0.4111872f,-0.3685311f,-0.6538894f,0.5172414f);
Get(0x6E82).SetLocalPose(0.3766244f,1.452794f,0.2436347f,0.5393624f,-0.004956813f,-0.7327711f,-0.4148616f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.706141f);
Get(0x6EC6).SetLocalPose(0.5309187f,1.425208f,0.1677869f,-0.2866717f,-0.7491381f,-0.2006394f,-0.5624549f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095424f,1.309627f,0.1328526f,-0.7030496f,-0.01444511f,-0.009578876f,0.7109296f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.4116307f);
Get(0x6E70).SetLocalPose(0.3776404f,1.564065f,-0.01241061f,0.4189197f,-0.3658345f,-0.6559546f,0.5102891f);
Get(0x6E82).SetLocalPose(0.3807392f,1.464376f,0.2148233f,0.5516729f,-0.007469733f,-0.7340348f,-0.3959724f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.765861f);
Get(0x6EC6).SetLocalPose(0.5377337f,1.429997f,0.1520209f,-0.2855243f,-0.7330081f,-0.1837641f,-0.5894114f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095314f,1.309732f,0.132774f,-0.7030616f,-0.01442194f,-0.009573575f,0.7109182f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.4718941f);
Get(0x6E70).SetLocalPose(0.3866554f,1.562458f,-0.02705024f,0.4250691f,-0.3634593f,-0.6620419f,0.498913f);
Get(0x6E82).SetLocalPose(0.3867406f,1.477583f,0.1842438f,0.5581535f,-0.01449917f,-0.7431286f,-0.3688012f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.826125f);
Get(0x6EC6).SetLocalPose(0.5530224f,1.440784f,0.1217714f,-0.2784888f,-0.7012977f,-0.1547868f,-0.6377043f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095317f,1.309798f,0.1328743f,-0.7030559f,-0.01441175f,-0.00956976f,0.7109241f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.5316271f);
Get(0x6E70).SetLocalPose(0.3956119f,1.56303f,-0.04116423f,0.4319269f,-0.3597243f,-0.6700039f,0.4849046f);
Get(0x6E82).SetLocalPose(0.3962838f,1.491417f,0.1549836f,0.5529769f,-0.01858759f,-0.754208f,-0.3536117f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.885858f);
Get(0x6EC6).SetLocalPose(0.5637577f,1.449063f,0.1003729f,-0.281703f,-0.6779138f,-0.1352237f,-0.6654254f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095127f,1.309473f,0.1328006f,-0.7030341f,-0.01440065f,-0.009591484f,0.7109457f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.5914249f);
Get(0x6E70).SetLocalPose(0.4070086f,1.566109f,-0.05808346f,0.4405761f,-0.353811f,-0.6798159f,0.4675049f);
Get(0x6E82).SetLocalPose(0.4072241f,1.504197f,0.1308706f,0.5420951f,-0.03149226f,-0.7659115f,-0.3442684f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.945655f);
Get(0x6EC6).SetLocalPose(0.5756847f,1.460631f,0.07523372f,-0.2755252f,-0.6624241f,-0.1129901f,-0.6873962f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.5914249f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.945655f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095584f,1.309419f,0.1328607f,-0.7030509f,-0.0144748f,-0.009578465f,0.7109277f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.6899936f);
Get(0x6E70).SetLocalPose(0.4253905f,1.579028f,-0.08079552f,0.4433076f,-0.346557f,-0.6972718f,0.4440594f);
Get(0x6E82).SetLocalPose(0.4329052f,1.528533f,0.08427576f,0.5397221f,-0.0633572f,-0.7746374f,-0.3234544f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.044224f);
Get(0x6EC6).SetLocalPose(0.5941435f,1.478884f,0.02995107f,-0.2458011f,-0.6799729f,-0.0817681f,-0.6859539f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095285f,1.309241f,0.1327862f,-0.7030371f,-0.01444215f,-0.00958001f,0.710942f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.7597825f);
Get(0x6E70).SetLocalPose(0.436291f,1.590124f,-0.09166984f,0.4364402f,-0.344126f,-0.708625f,0.4346814f);
Get(0x6E82).SetLocalPose(0.4498936f,1.54207f,0.05906418f,0.5351121f,-0.07893924f,-0.7770996f,-0.3217762f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.114013f);
Get(0x6EC6).SetLocalPose(0.6070992f,1.488759f,0.007802051f,-0.2362642f,-0.6882318f,-0.06984322f,-0.6823769f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095044f,1.309215f,0.1326994f,-0.7030569f,-0.0144145f,-0.009624092f,0.7109224f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.8197126f);
Get(0x6E70).SetLocalPose(0.4462951f,1.599751f,-0.1005851f,0.4283708f,-0.3422253f,-0.7168738f,0.4306648f);
Get(0x6E82).SetLocalPose(0.4618841f,1.550681f,0.04293448f,0.5263676f,-0.0911373f,-0.7837507f,-0.316806f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.173943f);
Get(0x6EC6).SetLocalPose(0.6182353f,1.4943f,-0.01191916f,-0.2338476f,-0.6859031f,-0.05867721f,-0.6865925f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095023f,1.309428f,0.1327334f,-0.7030234f,-0.01441969f,-0.009643666f,0.7109552f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.8857305f);
Get(0x6E70).SetLocalPose(0.4582509f,1.610526f,-0.1113455f,0.4187172f,-0.3399192f,-0.7235159f,0.4308777f);
Get(0x6E82).SetLocalPose(0.4751028f,1.557122f,0.02650757f,0.5185643f,-0.1003371f,-0.7879213f,-0.3165494f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.239961f);
Get(0x6EC6).SetLocalPose(0.6292449f,1.498999f,-0.03063914f,-0.2366231f,-0.686074f,-0.04857455f,-0.6862599f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095244f,1.309586f,0.1326287f,-0.7030388f,-0.0144491f,-0.009633718f,0.7109395f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.945168f);
Get(0x6E70).SetLocalPose(0.4684203f,1.617311f,-0.1217784f,0.4100997f,-0.338442f,-0.7271351f,0.4342233f);
Get(0x6E82).SetLocalPose(0.4872597f,1.56006f,0.01268628f,0.5136476f,-0.1033635f,-0.7887714f,-0.3214373f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.299398f);
Get(0x6EC6).SetLocalPose(0.6384178f,1.500296f,-0.04705406f,-0.2441628f,-0.6893672f,-0.04103463f,-0.680789f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095371f,1.309778f,0.1328269f,-0.7030326f,-0.01444716f,-0.00962958f,0.7109457f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.006365f);
Get(0x6E70).SetLocalPose(0.4778214f,1.621621f,-0.133026f,0.4008237f,-0.3378308f,-0.7297807f,0.4388973f);
Get(0x6E82).SetLocalPose(0.4977227f,1.559812f,0.0006420164f,0.5040939f,-0.1034032f,-0.7916975f,-0.32926f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.360595f);
Get(0x6EC6).SetLocalPose(0.6465998f,1.497624f,-0.06352318f,-0.254106f,-0.6933418f,-0.03671357f,-0.6733196f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095497f,1.309682f,0.1330176f,-0.7030523f,-0.01440315f,-0.009657042f,0.7109268f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.065909f);
Get(0x6E70).SetLocalPose(0.4856624f,1.621706f,-0.1451849f,0.3921691f,-0.33695f,-0.7324684f,0.4428976f);
Get(0x6E82).SetLocalPose(0.5078142f,1.555012f,-0.01003243f,0.4894855f,-0.1054617f,-0.796908f,-0.3379635f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.420139f);
Get(0x6EC6).SetLocalPose(0.65395f,1.49189f,-0.08112032f,-0.2670882f,-0.6973895f,-0.03607942f,-0.664086f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.065909f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.420139f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095368f,1.309583f,0.1330446f,-0.7030526f,-0.0143913f,-0.009646476f,0.7109268f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.20475f);
Get(0x6E70).SetLocalPose(0.4967566f,1.609924f,-0.1740112f,0.3803563f,-0.3326408f,-0.7397304f,0.4443851f);
Get(0x6E82).SetLocalPose(0.5258681f,1.528327f,-0.03915013f,0.4780749f,-0.1132693f,-0.7934646f,-0.3592052f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.55898f);
Get(0x6EC6).SetLocalPose(0.662962f,1.469908f,-0.1181893f,-0.2938055f,-0.7121997f,-0.04718874f,-0.6357855f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095376f,1.309632f,0.1330784f,-0.7030581f,-0.01440102f,-0.00964366f,0.7109212f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.263257f);
Get(0x6E70).SetLocalPose(0.5007427f,1.600335f,-0.1879579f,0.3773582f,-0.3310782f,-0.7424582f,0.4435582f);
Get(0x6E82).SetLocalPose(0.5301962f,1.511892f,-0.05337754f,0.4847156f,-0.1059852f,-0.7840211f,-0.3729998f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.617488f);
Get(0x6EC6).SetLocalPose(0.664367f,1.455416f,-0.1308845f,-0.3090587f,-0.7120012f,-0.05195395f,-0.6283613f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095392f,1.309558f,0.1331362f,-0.7030668f,-0.01440907f,-0.009624743f,0.7109127f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.324456f);
Get(0x6E70).SetLocalPose(0.5034384f,1.589137f,-0.2008809f,0.3755319f,-0.3303518f,-0.7436198f,0.4437038f);
Get(0x6E82).SetLocalPose(0.5344332f,1.49308f,-0.07140503f,0.4882893f,-0.09604511f,-0.7760687f,-0.3873838f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.678687f);
Get(0x6EC6).SetLocalPose(0.6654792f,1.435774f,-0.1445742f,-0.32553f,-0.7048754f,-0.0570574f,-0.6276348f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094938f,1.30962f,0.1331744f,-0.7030292f,-0.01441094f,-0.00964273f,0.7109497f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.385588f);
Get(0x6E70).SetLocalPose(0.5045305f,1.57232f,-0.2173641f,0.374784f,-0.3308138f,-0.7427238f,0.4454891f);
Get(0x6E82).SetLocalPose(0.5369819f,1.474165f,-0.08925377f,0.4928729f,-0.09208215f,-0.7690222f,-0.3964871f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.739819f);
Get(0x6EC6).SetLocalPose(0.6670842f,1.41861f,-0.1579568f,-0.3309391f,-0.7001849f,-0.06408308f,-0.6293757f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095166f,1.309506f,0.1331033f,-0.7030493f,-0.01438905f,-0.00960484f,0.7109307f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.444472f);
Get(0x6E70).SetLocalPose(0.5037681f,1.556874f,-0.2307185f,0.3748933f,-0.3321959f,-0.741011f,0.4472177f);
Get(0x6E82).SetLocalPose(0.5386538f,1.454558f,-0.1060992f,0.5062f,-0.08643022f,-0.7548744f,-0.4079903f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.798702f);
Get(0x6EC6).SetLocalPose(0.6671218f,1.400447f,-0.1728768f,-0.3372341f,-0.7017519f,-0.07091278f,-0.6235294f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094961f,1.309392f,0.1329439f,-0.7030499f,-0.01438581f,-0.009644966f,0.7109296f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.504503f);
Get(0x6E70).SetLocalPose(0.5015463f,1.539623f,-0.2447691f,0.3757423f,-0.3339854f,-0.7397667f,0.4472324f);
Get(0x6E82).SetLocalPose(0.5395527f,1.437651f,-0.120057f,0.5169191f,-0.08369375f,-0.7426998f,-0.4173573f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.858733f);
Get(0x6EC6).SetLocalPose(0.6680368f,1.382267f,-0.1894474f,-0.3407431f,-0.712881f,-0.07655331f,-0.6081402f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095026f,1.309416f,0.1328253f,-0.7030553f,-0.01440066f,-0.009638729f,0.7109241f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.532297f);
Get(0x6E70).SetLocalPose(0.500184f,1.531469f,-0.2514746f,0.3766138f,-0.3344106f,-0.7396209f,0.446422f);
Get(0x6E82).SetLocalPose(0.5394068f,1.427862f,-0.1283913f,0.5232621f,-0.07814382f,-0.7380831f,-0.4187167f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.886527f);
Get(0x6EC6).SetLocalPose(0.6685474f,1.37478f,-0.1960681f,-0.3392556f,-0.7183995f,-0.07887597f,-0.6021515f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09475f,1.309517f,0.1330684f,-0.70306f,-0.0143166f,-0.009682085f,0.7109205f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.633693f);
Get(0x6E70).SetLocalPose(0.4952645f,1.507662f,-0.2716257f,0.3824134f,-0.3327051f,-0.7396888f,0.4426373f);
Get(0x6E82).SetLocalPose(0.5374249f,1.404545f,-0.1487262f,0.5323951f,-0.0756701f,-0.7337819f,-0.4152034f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.987923f);
Get(0x6EC6).SetLocalPose(0.6672858f,1.350176f,-0.217952f,-0.3282458f,-0.7347152f,-0.0829035f,-0.5878565f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095047f,1.309355f,0.1331253f,-0.7030861f,-0.01440744f,-0.009642298f,0.7108935f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.699488f);
Get(0x6E70).SetLocalPose(0.4905843f,1.496262f,-0.2814797f,0.3888291f,-0.3304226f,-0.7375746f,0.4422857f);
Get(0x6E82).SetLocalPose(0.5335314f,1.394908f,-0.159871f,0.5416972f,-0.09001953f,-0.7338343f,-0.3999347f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.053718f);
Get(0x6EC6).SetLocalPose(0.6647345f,1.34041f,-0.2274883f,-0.313987f,-0.7441987f,-0.07994302f,-0.5841144f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095155f,1.309383f,0.1332189f,-0.7031037f,-0.01440291f,-0.009634511f,0.7108762f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.758691f);
Get(0x6E70).SetLocalPose(0.4843834f,1.488288f,-0.2889706f,0.3950592f,-0.329402f,-0.735158f,0.4415487f);
Get(0x6E82).SetLocalPose(0.5277877f,1.387504f,-0.1684349f,0.5509529f,-0.08807036f,-0.7334874f,-0.388189f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.112921f);
Get(0x6EC6).SetLocalPose(0.6607325f,1.332525f,-0.2377432f,-0.2979484f,-0.7534087f,-0.08095741f,-0.5805583f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095255f,1.30912f,0.1332852f,-0.7030986f,-0.01440816f,-0.009669341f,0.7108807f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.81937f);
Get(0x6E70).SetLocalPose(0.4783972f,1.484831f,-0.2944406f,0.3992374f,-0.3302514f,-0.7339001f,0.4392428f);
Get(0x6E82).SetLocalPose(0.5187215f,1.382226f,-0.1752532f,0.5577033f,-0.07600896f,-0.7295377f,-0.3885415f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.1736f);
Get(0x6EC6).SetLocalPose(0.6587712f,1.330504f,-0.2433421f,-0.2903478f,-0.753071f,-0.07943358f,-0.5850407f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095201f,1.309013f,0.1333729f,-0.70309f,-0.01439881f,-0.00968489f,0.7108892f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.877334f);
Get(0x6E70).SetLocalPose(0.4720349f,1.485028f,-0.2986501f,0.4038383f,-0.3322596f,-0.7321011f,0.4365161f);
Get(0x6E82).SetLocalPose(0.5107999f,1.381338f,-0.1799178f,0.5674648f,-0.07089845f,-0.7237399f,-0.3862095f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.231564f);
Get(0x6EC6).SetLocalPose(0.6533459f,1.329195f,-0.2463112f,-0.2885746f,-0.7507992f,-0.07815224f,-0.5889971f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095301f,1.309168f,0.1334679f,-0.7030907f,-0.01442134f,-0.009660623f,0.7108883f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.934489f);
Get(0x6E70).SetLocalPose(0.4643669f,1.489255f,-0.3020177f,0.4094266f,-0.3351552f,-0.7290668f,0.4341686f);
Get(0x6E82).SetLocalPose(0.5016035f,1.383141f,-0.1838566f,0.5822572f,-0.06928739f,-0.7141175f,-0.3823769f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.288719f);
Get(0x6EC6).SetLocalPose(0.6463096f,1.332763f,-0.2457746f,-0.2867873f,-0.7502978f,-0.07868008f,-0.5904369f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095177f,1.309166f,0.1333897f,-0.7031073f,-0.01444664f,-0.009630214f,0.7108718f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.992748f);
Get(0x6E70).SetLocalPose(0.4559055f,1.495623f,-0.3033159f,0.4135644f,-0.3384849f,-0.7258357f,0.4330763f);
Get(0x6E82).SetLocalPose(0.4924491f,1.387247f,-0.1853674f,0.594381f,-0.06867382f,-0.7053251f,-0.3801469f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.346978f);
Get(0x6EC6).SetLocalPose(0.6375322f,1.338271f,-0.2440853f,-0.2858042f,-0.7504392f,-0.08097074f,-0.5904243f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09522f,1.309157f,0.1333763f,-0.7031123f,-0.01440081f,-0.009666246f,0.7108673f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.021102f);
Get(0x6E70).SetLocalPose(0.4528837f,1.498636f,-0.3031963f,0.4148201f,-0.339761f,-0.7244139f,0.4332565f);
Get(0x6E82).SetLocalPose(0.4873591f,1.389756f,-0.1850315f,0.598585f,-0.06746685f,-0.702138f,-0.3796662f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.375331f);
Get(0x6EC6).SetLocalPose(0.6332902f,1.341618f,-0.2429308f,-0.2857799f,-0.7501492f,-0.08281725f,-0.5905483f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095265f,1.309564f,0.1331833f,-0.7030674f,-0.01441486f,-0.009663192f,0.7109115f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.122092f);
Get(0x6E70).SetLocalPose(0.4377378f,1.514745f,-0.2997973f,0.4186303f,-0.3443063f,-0.7170042f,0.4382999f);
Get(0x6E82).SetLocalPose(0.470041f,1.401571f,-0.1776873f,0.6015988f,-0.05634141f,-0.6961103f,-0.3877305f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.476321f);
Get(0x6EC6).SetLocalPose(0.6172192f,1.354809f,-0.2346422f,-0.2900109f,-0.7478408f,-0.09138012f,-0.5901505f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095422f,1.309337f,0.1332186f,-0.7030766f,-0.01447669f,-0.00958934f,0.7109022f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.187174f);
Get(0x6E70).SetLocalPose(0.427249f,1.526188f,-0.2953272f,0.4195594f,-0.3466897f,-0.7119583f,0.4437246f);
Get(0x6E82).SetLocalPose(0.460436f,1.407524f,-0.1704763f,0.6017291f,-0.05030379f,-0.6933843f,-0.3932046f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.541404f);
Get(0x6EC6).SetLocalPose(0.6052802f,1.36262f,-0.2277588f,-0.2879326f,-0.7489707f,-0.09950119f,-0.5884194f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095279f,1.30946f,0.1330253f,-0.7030891f,-0.01447174f,-0.009605855f,0.7108896f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.244747f);
Get(0x6E70).SetLocalPose(0.4170794f,1.537024f,-0.2899644f,0.4199184f,-0.3487455f,-0.7067372f,0.4500753f);
Get(0x6E82).SetLocalPose(0.4508746f,1.412944f,-0.163242f,0.6048542f,-0.04735373f,-0.6899673f,-0.3947839f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.598976f);
Get(0x6EC6).SetLocalPose(0.5941207f,1.36807f,-0.2208808f,-0.2840859f,-0.7511133f,-0.1086805f,-0.5859287f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095391f,1.309428f,0.1330637f,-0.7030757f,-0.01445706f,-0.009625124f,0.7109029f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.306067f);
Get(0x6E70).SetLocalPose(0.4054074f,1.547306f,-0.2832514f,0.4208699f,-0.3506851f,-0.6997505f,0.4585169f);
Get(0x6E82).SetLocalPose(0.4382803f,1.418714f,-0.1529986f,0.6091147f,-0.04552186f,-0.6860095f,-0.3953456f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.660296f);
Get(0x6EC6).SetLocalPose(0.5818935f,1.373901f,-0.2115688f,-0.2798535f,-0.7527285f,-0.1196027f,-0.5837612f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095294f,1.309318f,0.133056f,-0.7030545f,-0.0144402f,-0.00959958f,0.7109245f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.366108f);
Get(0x6E70).SetLocalPose(0.3930243f,1.556125f,-0.2755188f,0.4225664f,-0.3523232f,-0.6919929f,0.4673883f);
Get(0x6E82).SetLocalPose(0.4275316f,1.422097f,-0.1431221f,0.6105691f,-0.04264829f,-0.6836711f,-0.3974675f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.720338f);
Get(0x6EC6).SetLocalPose(0.5714232f,1.377529f,-0.2025806f,-0.2770155f,-0.7527629f,-0.1302901f,-0.5827821f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095354f,1.30978f,0.133178f,-0.7030671f,-0.0145059f,-0.009545778f,0.7109115f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.427686f);
Get(0x6E70).SetLocalPose(0.3796586f,1.564039f,-0.266847f,0.4247902f,-0.3537937f,-0.6841886f,0.4756778f);
Get(0x6E82).SetLocalPose(0.4146484f,1.423651f,-0.1310589f,0.6105061f,-0.03882594f,-0.6827882f,-0.3994686f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.781915f);
Get(0x6EC6).SetLocalPose(0.5589385f,1.381177f,-0.1905902f,-0.2734542f,-0.7526222f,-0.1428082f,-0.5817115f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095084f,1.309825f,0.1330418f,-0.703081f,-0.01442913f,-0.009628312f,0.7108982f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.487347f);
Get(0x6E70).SetLocalPose(0.3667758f,1.569112f,-0.2591911f,0.4278782f,-0.3544253f,-0.6774672f,0.4820179f);
Get(0x6E82).SetLocalPose(0.4003769f,1.423664f,-0.1183589f,0.6108562f,-0.0336443f,-0.6816207f,-0.4013925f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.841576f);
Get(0x6EC6).SetLocalPose(0.5461909f,1.385174f,-0.1768798f,-0.2703669f,-0.7525625f,-0.1551043f,-0.580081f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.487347f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.841576f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095227f,1.309394f,0.1331982f,-0.7030472f,-0.01442107f,-0.009679251f,0.7109312f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.608484f);
Get(0x6E70).SetLocalPose(0.3320904f,1.574889f,-0.2389607f,0.4451777f,-0.3517253f,-0.6632371f,0.4880807f);
Get(0x6E82).SetLocalPose(0.3680118f,1.420507f,-0.08971759f,0.6076819f,-0.01969266f,-0.678595f,-0.4121211f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.962713f);
Get(0x6EC6).SetLocalPose(0.5139496f,1.387882f,-0.1446771f,-0.2620779f,-0.7530947f,-0.1845487f,-0.574548f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095341f,1.309339f,0.1332094f,-0.703043f,-0.01440575f,-0.009671654f,0.7109357f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.66496f);
Get(0x6E70).SetLocalPose(0.3233891f,1.576062f,-0.2340507f,0.4506476f,-0.3505585f,-0.6611088f,0.4867862f);
Get(0x6E82).SetLocalPose(0.3598452f,1.418326f,-0.08076032f,0.6020435f,-0.01502738f,-0.6788756f,-0.4200543f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.019189f);
Get(0x6EC6).SetLocalPose(0.5051158f,1.388156f,-0.1358565f,-0.258299f,-0.752243f,-0.1945716f,-0.5740679f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095237f,1.309039f,0.1331304f,-0.7030672f,-0.01437811f,-0.009672403f,0.7109123f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.733246f);
Get(0x6E70).SetLocalPose(0.3098394f,1.578042f,-0.2253452f,0.4588065f,-0.3495699f,-0.6583717f,0.4835745f);
Get(0x6E82).SetLocalPose(0.3469467f,1.412986f,-0.06457608f,0.5877011f,-0.006616909f,-0.6815484f,-0.4359536f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.087475f);
Get(0x6EC6).SetLocalPose(0.4931902f,1.387637f,-0.1217769f,-0.2537557f,-0.7504225f,-0.2107537f,-0.5727625f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095228f,1.309044f,0.1331463f,-0.7030699f,-0.01438263f,-0.009676402f,0.7109095f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.794665f);
Get(0x6E70).SetLocalPose(0.2968703f,1.580066f,-0.2170196f,0.465932f,-0.3497971f,-0.655916f,0.4799204f);
Get(0x6E82).SetLocalPose(0.3353068f,1.407633f,-0.04906576f,0.5680252f,0.006610533f,-0.6835896f,-0.4582675f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.148894f);
Get(0x6EC6).SetLocalPose(0.4836912f,1.384202f,-0.1107038f,-0.2538943f,-0.7504303f,-0.2261391f,-0.5667919f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095203f,1.309479f,0.1331825f,-0.7030604f,-0.01441266f,-0.009626339f,0.7109188f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.856894f);
Get(0x6E70).SetLocalPose(0.284135f,1.581599f,-0.2084628f,0.4735474f,-0.3506739f,-0.6532426f,0.4754522f);
Get(0x6E82).SetLocalPose(0.3247889f,1.400846f,-0.03305563f,0.5489278f,0.02500679f,-0.6801673f,-0.4852066f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.211123f);
Get(0x6EC6).SetLocalPose(0.4741062f,1.379587f,-0.09770457f,-0.2599322f,-0.7562474f,-0.2455969f,-0.5479118f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095123f,1.309423f,0.133171f,-0.7030511f,-0.01441152f,-0.009601954f,0.7109285f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.918976f);
Get(0x6E70).SetLocalPose(0.2718144f,1.583265f,-0.2001923f,0.4827258f,-0.3512751f,-0.6504441f,0.4695787f);
Get(0x6E82).SetLocalPose(0.3157833f,1.3922f,-0.01802287f,0.5308812f,0.04008827f,-0.6721842f,-0.5145158f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.273205f);
Get(0x6EC6).SetLocalPose(0.4655732f,1.375368f,-0.08795311f,-0.2677783f,-0.7631915f,-0.2650298f,-0.5249692f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.0955f,1.309581f,0.132865f,-0.7030764f,-0.01445878f,-0.009583228f,0.7109028f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.98037f);
Get(0x6E70).SetLocalPose(0.2600584f,1.586643f,-0.1925452f,0.4920776f,-0.3527052f,-0.6478294f,0.462359f);
Get(0x6E82).SetLocalPose(0.3079094f,1.38286f,-0.001917703f,0.5041577f,0.04249267f,-0.6677157f,-0.5460542f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.334599f);
Get(0x6EC6).SetLocalPose(0.45649f,1.368614f,-0.07588653f,-0.276462f,-0.7626144f,-0.294097f,-0.505465f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.98037f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.334599f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09534f,1.309499f,0.1332192f,-0.7030628f,-0.01439524f,-0.009612334f,0.7109171f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.03623354f);
Get(0x6E70).SetLocalPose(0.2357452f,1.597265f,-0.1759668f,0.5062466f,-0.3624633f,-0.6440782f,0.4444077f);
Get(0x6E82).SetLocalPose(0.290392f,1.358226f,0.02843401f,0.4451145f,0.04407532f,-0.6695302f,-0.5930092f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.03623354f);
Get(0x6EC6).SetLocalPose(0.4426405f,1.351226f,-0.05451728f,-0.2895181f,-0.7544585f,-0.353285f,-0.4713401f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095286f,1.309378f,0.1331421f,-0.7030838f,-0.01444651f,-0.009624512f,0.7108951f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.09579846f);
Get(0x6E70).SetLocalPose(0.2275856f,1.602267f,-0.1697152f,0.507856f,-0.3685428f,-0.643239f,0.4387506f);
Get(0x6E82).SetLocalPose(0.2843103f,1.348808f,0.03621387f,0.435936f,0.04590342f,-0.663614f,-0.6061924f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.09579846f);
Get(0x6EC6).SetLocalPose(0.4368304f,1.341479f,-0.04617367f,-0.2927849f,-0.7506025f,-0.3805244f,-0.4539538f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095355f,1.309296f,0.1329974f,-0.7030993f,-0.0144516f,-0.009617143f,0.7108798f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.1577797f);
Get(0x6E70).SetLocalPose(0.2176287f,1.608329f,-0.1612557f,0.5087563f,-0.3763936f,-0.6410205f,0.4342667f);
Get(0x6E82).SetLocalPose(0.2746509f,1.335784f,0.0444756f,0.4294469f,0.05053588f,-0.6468658f,-0.628161f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.1577797f);
Get(0x6EC6).SetLocalPose(0.4315272f,1.329365f,-0.03907997f,-0.29949f,-0.7394839f,-0.4028469f,-0.4485352f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095449f,1.309433f,0.1332105f,-0.7030963f,-0.01441375f,-0.009679433f,0.7108827f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.2186462f);
Get(0x6E70).SetLocalPose(0.2102205f,1.612378f,-0.1552649f,0.5092672f,-0.3825137f,-0.6385738f,0.4319188f);
Get(0x6E82).SetLocalPose(0.2661911f,1.324775f,0.05017537f,0.4207338f,0.05557164f,-0.6350932f,-0.645408f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.2186462f);
Get(0x6EC6).SetLocalPose(0.4268695f,1.317808f,-0.03300034f,-0.3124452f,-0.7220047f,-0.4222442f,-0.4503301f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095275f,1.309665f,0.1331608f,-0.7030754f,-0.01440533f,-0.009639298f,0.7109041f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.2786446f);
Get(0x6E70).SetLocalPose(0.2027253f,1.615731f,-0.1494202f,0.5094171f,-0.3880806f,-0.6364324f,0.429932f);
Get(0x6E82).SetLocalPose(0.2590823f,1.314573f,0.05485951f,0.4068148f,0.05815694f,-0.6308815f,-0.6581094f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.2786446f);
Get(0x6EC6).SetLocalPose(0.4242118f,1.309263f,-0.03008464f,-0.319615f,-0.7116483f,-0.435513f,-0.4491452f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09542f,1.309494f,0.1335183f,-0.7030921f,-0.01444693f,-0.00959912f,0.7108873f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.3396311f);
Get(0x6E70).SetLocalPose(0.195435f,1.618363f,-0.1430782f,0.509653f,-0.393082f,-0.6346307f,0.4277666f);
Get(0x6E82).SetLocalPose(0.2528855f,1.306741f,0.0579804f,0.4010742f,0.0537793f,-0.6256449f,-0.666945f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.3396311f);
Get(0x6EC6).SetLocalPose(0.419291f,1.299463f,-0.02646737f,-0.3210171f,-0.7050828f,-0.4512865f,-0.4428846f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095336f,1.309541f,0.1335504f,-0.7031025f,-0.01445054f,-0.009590995f,0.7108769f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.3691376f);
Get(0x6E70).SetLocalPose(0.1912481f,1.619305f,-0.1391356f,0.5103147f,-0.395388f,-0.6336486f,0.4263058f);
Get(0x6E82).SetLocalPose(0.250203f,1.303963f,0.05827153f,0.4058307f,0.04903799f,-0.6189424f,-0.6706765f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.3691376f);
Get(0x6EC6).SetLocalPose(0.417316f,1.295551f,-0.0252823f,-0.3205821f,-0.7034444f,-0.4562393f,-0.4407255f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095549f,1.309272f,0.133495f,-0.703104f,-0.01438676f,-0.009656379f,0.710876f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.4719222f);
Get(0x6E70).SetLocalPose(0.1826625f,1.619508f,-0.1311669f,0.5130043f,-0.3964609f,-0.6333127f,0.4225641f);
Get(0x6E82).SetLocalPose(0.2423742f,1.295707f,0.05726985f,0.4282209f,0.0383913f,-0.5908633f,-0.6826665f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.4719222f);
Get(0x6EC6).SetLocalPose(0.4121657f,1.283391f,-0.02403142f,-0.3263669f,-0.6952481f,-0.4671837f,-0.4380115f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095277f,1.309204f,0.1333095f,-0.7030951f,-0.01437687f,-0.009622594f,0.7108854f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.50488f);
Get(0x6E70).SetLocalPose(0.1798981f,1.618811f,-0.1285336f,0.5140197f,-0.3956288f,-0.634131f,0.4208796f);
Get(0x6E82).SetLocalPose(0.2400567f,1.292994f,0.05682825f,0.4333916f,0.0364452f,-0.5863419f,-0.6834082f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.50488f);
Get(0x6EC6).SetLocalPose(0.410437f,1.280163f,-0.02411307f,-0.3293776f,-0.6923604f,-0.4692695f,-0.4381024f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095402f,1.309288f,0.1331096f,-0.7030767f,-0.01439802f,-0.009604879f,0.7109033f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.56886f);
Get(0x6E70).SetLocalPose(0.1764844f,1.617883f,-0.1253343f,0.5151994f,-0.3933233f,-0.6363748f,0.4182028f);
Get(0x6E82).SetLocalPose(0.2374544f,1.290379f,0.05640773f,0.4417481f,0.03816633f,-0.5833001f,-0.6805608f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.56886f);
Get(0x6EC6).SetLocalPose(0.4084042f,1.274981f,-0.02436212f,-0.3344248f,-0.6888869f,-0.4716204f,-0.4372289f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094934f,1.309358f,0.1328665f,-0.703074f,-0.01439365f,-0.009617793f,0.710906f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.6393711f);
Get(0x6E70).SetLocalPose(0.1729975f,1.616254f,-0.1220077f,0.5158207f,-0.3895507f,-0.6403064f,0.4149542f);
Get(0x6E82).SetLocalPose(0.2314783f,1.288966f,0.0537853f,0.4752007f,0.04362665f,-0.5811808f,-0.6591737f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0f);
Get(0x6EC6).SetLocalPose(0.4073743f,1.270011f,-0.02658295f,-0.3396347f,-0.6918422f,-0.4640826f,-0.4366121f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094852f,1.309261f,0.132872f,-0.7030831f,-0.01438845f,-0.009659731f,0.7108965f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0f);
Get(0x6E70).SetLocalPose(0.1700572f,1.613436f,-0.1197764f,0.5158326f,-0.3837703f,-0.645982f,0.4115148f);
Get(0x6E82).SetLocalPose(0.2256616f,1.291526f,0.04765235f,0.5096481f,0.01885422f,-0.5688306f,-0.6452404f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.03249846f);
Get(0x6EC6).SetLocalPose(0.4088632f,1.264516f,-0.03556001f,-0.3296237f,-0.7116061f,-0.4294474f,-0.4478168f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09488f,1.309283f,0.1331227f,-0.7030641f,-0.01438932f,-0.009632973f,0.7109156f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.1013738f);
Get(0x6E70).SetLocalPose(0.1688567f,1.611284f,-0.1196872f,0.5156469f,-0.3797294f,-0.6497934f,0.4094905f);
Get(0x6E82).SetLocalPose(0.225834f,1.29675f,0.03750086f,0.5466487f,-0.001803923f,-0.5461441f,-0.6347429f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.1338723f);
Get(0x6EC6).SetLocalPose(0.4083981f,1.263299f,-0.03844723f,-0.3289423f,-0.7097819f,-0.4251546f,-0.4552474f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094822f,1.309206f,0.1332276f,-0.7030783f,-0.01435092f,-0.009638522f,0.7109023f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.1569218f);
Get(0x6E70).SetLocalPose(0.1679781f,1.609873f,-0.1207304f,0.515072f,-0.3753102f,-0.654233f,0.4072129f);
Get(0x6E82).SetLocalPose(0.2275279f,1.301733f,0.0252637f,0.6003639f,-0.03736893f,-0.5155277f,-0.6102443f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.1894203f);
Get(0x6EC6).SetLocalPose(0.4073325f,1.263022f,-0.04236001f,-0.3216854f,-0.7127067f,-0.4228102f,-0.4580384f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094824f,1.309164f,0.1331258f,-0.7030788f,-0.01438103f,-0.00963676f,0.7109012f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.1924415f);
Get(0x6E70).SetLocalPose(0.1679467f,1.609208f,-0.1215629f,0.5146592f,-0.3733065f,-0.6562872f,0.40627f);
Get(0x6E82).SetLocalPose(0.2292377f,1.304248f,0.01719378f,0.6361051f,-0.0567724f,-0.4869762f,-0.59582f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.22494f);
Get(0x6EC6).SetLocalPose(0.4065492f,1.262921f,-0.04576465f,-0.3183683f,-0.7182705f,-0.4215925f,-0.452757f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.1924415f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.22494f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.1924415f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.22494f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095073f,1.309626f,0.1329929f,-0.7030542f,-0.01441239f,-0.009624748f,0.7109251f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.370775f);
Get(0x6E70).SetLocalPose(0.1680328f,1.610013f,-0.1348067f,0.509492f,-0.367718f,-0.6625564f,0.4077015f);
Get(0x6E82).SetLocalPose(0.2462099f,1.306577f,-0.03369886f,0.7629163f,-0.1212061f,-0.3698781f,-0.5161957f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.4032735f);
Get(0x6EC6).SetLocalPose(0.4010538f,1.263462f,-0.07078994f,-0.3125341f,-0.7471948f,-0.4143355f,-0.4151486f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095436f,1.309363f,0.1330418f,-0.7030877f,-0.01440949f,-0.009616632f,0.7108921f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.4296021f);
Get(0x6E70).SetLocalPose(0.1687499f,1.610634f,-0.1432925f,0.5065554f,-0.3679754f,-0.6627241f,0.4108436f);
Get(0x6E82).SetLocalPose(0.2500021f,1.304686f,-0.043401f,0.7609612f,-0.1181594f,-0.3747649f,-0.5162633f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.4621006f);
Get(0x6EC6).SetLocalPose(0.4005406f,1.263329f,-0.08071963f,-0.3124875f,-0.7501785f,-0.413277f,-0.4108359f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095376f,1.309413f,0.1332107f,-0.7030818f,-0.01439928f,-0.009635664f,0.7108979f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.4933486f);
Get(0x6E70).SetLocalPose(0.1700701f,1.610089f,-0.1527232f,0.5038027f,-0.3684328f,-0.6627672f,0.4137389f);
Get(0x6E82).SetLocalPose(0.2557406f,1.3027f,-0.05753971f,0.7743163f,-0.1370718f,-0.3565717f,-0.5044821f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.5258471f);
Get(0x6EC6).SetLocalPose(0.4007382f,1.26356f,-0.09206815f,-0.3066756f,-0.7549242f,-0.4126648f,-0.4071208f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095254f,1.309347f,0.133281f,-0.7030702f,-0.01440297f,-0.009648951f,0.7109092f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.5588716f);
Get(0x6E70).SetLocalPose(0.1727371f,1.609662f,-0.1662446f,0.5005003f,-0.3691267f,-0.6628259f,0.4170213f);
Get(0x6E82).SetLocalPose(0.2612003f,1.301767f,-0.07254642f,0.7907409f,-0.15374f,-0.3390077f,-0.4859699f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.5913702f);
Get(0x6EC6).SetLocalPose(0.401667f,1.264969f,-0.1058843f,-0.2981544f,-0.7632602f,-0.4093833f,-0.4011772f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095155f,1.309413f,0.1332251f,-0.7030643f,-0.01439951f,-0.009608933f,0.7109156f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.6229978f);
Get(0x6E70).SetLocalPose(0.1752373f,1.608237f,-0.179046f,0.4972133f,-0.369959f,-0.6629726f,0.4199723f);
Get(0x6E82).SetLocalPose(0.2630126f,1.300698f,-0.08243527f,0.791973f,-0.1564555f,-0.3414393f,-0.4813727f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.6554963f);
Get(0x6EC6).SetLocalPose(0.4031991f,1.264123f,-0.1185014f,-0.2927763f,-0.7691704f,-0.4053397f,-0.3979431f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094896f,1.309622f,0.1332812f,-0.7030718f,-0.01437955f,-0.009639118f,0.7109081f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.6845894f);
Get(0x6E70).SetLocalPose(0.1772368f,1.607408f,-0.1887113f,0.4945916f,-0.3706564f,-0.6628969f,0.4225647f);
Get(0x6E82).SetLocalPose(0.2645495f,1.299958f,-0.09023435f,0.7890499f,-0.1575317f,-0.3478381f,-0.4812408f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.717088f);
Get(0x6EC6).SetLocalPose(0.4048161f,1.263834f,-0.1279165f,-0.2901905f,-0.7721179f,-0.4020024f,-0.3975143f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.6845894f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.717088f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.6845894f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.717088f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09514f,1.309412f,0.133185f,-0.7030836f,-0.01441259f,-0.009605516f,0.7108963f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.8982294f);
Get(0x6E70).SetLocalPose(0.1912843f,1.598168f,-0.2407369f,0.4800866f,-0.3742033f,-0.6615152f,0.4380484f);
Get(0x6E82).SetLocalPose(0.2751605f,1.295118f,-0.1404153f,0.8041273f,-0.1807806f,-0.3460973f,-0.4482347f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.930728f);
Get(0x6EC6).SetLocalPose(0.4135886f,1.262798f,-0.1795187f,-0.2778515f,-0.7902272f,-0.3806053f,-0.3917643f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09509f,1.309593f,0.1331495f,-0.7030865f,-0.01434889f,-0.009621379f,0.7108945f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.9603045f);
Get(0x6E70).SetLocalPose(0.1967538f,1.594172f,-0.2584884f,0.4761733f,-0.3742994f,-0.6621804f,0.4412212f);
Get(0x6E82).SetLocalPose(0.2801301f,1.293719f,-0.1579527f,0.8080493f,-0.1864265f,-0.3479237f,-0.4373222f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.992803f);
Get(0x6EC6).SetLocalPose(0.4166723f,1.262691f,-0.1969557f,-0.2696971f,-0.798928f,-0.372609f,-0.387479f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095315f,1.309671f,0.1331648f,-0.7030848f,-0.01441237f,-0.009582263f,0.7108955f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.022685f);
Get(0x6E70).SetLocalPose(0.202465f,1.588505f,-0.279001f,0.4727394f,-0.3738363f,-0.6633479f,0.4435466f);
Get(0x6E82).SetLocalPose(0.284446f,1.292256f,-0.176203f,0.8124735f,-0.1927375f,-0.3498383f,-0.424679f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.055183f);
Get(0x6EC6).SetLocalPose(0.4197791f,1.263279f,-0.2177207f,-0.2592742f,-0.811058f,-0.363583f,-0.3778481f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095447f,1.30959f,0.1331888f,-0.7030661f,-0.01441421f,-0.009572363f,0.7109141f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.084733f);
Get(0x6E70).SetLocalPose(0.2076709f,1.584694f,-0.2961357f,0.4708073f,-0.3733837f,-0.6639646f,0.4450575f);
Get(0x6E82).SetLocalPose(0.2893642f,1.291083f,-0.1960909f,0.8217074f,-0.2021329f,-0.3445808f,-0.4064523f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.117232f);
Get(0x6EC6).SetLocalPose(0.4224302f,1.263749f,-0.2348026f,-0.2467521f,-0.8253099f,-0.3559218f,-0.3623491f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095487f,1.309374f,0.1328394f,-0.7030622f,-0.01441986f,-0.009581555f,0.7109176f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.146234f);
Get(0x6E70).SetLocalPose(0.2150637f,1.579451f,-0.3180871f,0.4692841f,-0.3735117f,-0.663864f,0.4467057f);
Get(0x6E82).SetLocalPose(0.2942553f,1.289842f,-0.2186707f,0.832641f,-0.2141476f,-0.3359976f,-0.3846496f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.178732f);
Get(0x6EC6).SetLocalPose(0.4259311f,1.264659f,-0.2558718f,-0.2301278f,-0.8443301f,-0.346028f,-0.3382492f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.146234f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.178732f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095428f,1.309436f,0.1328876f,-0.7030759f,-0.01445534f,-0.009606835f,0.710903f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.252853f);
Get(0x6E70).SetLocalPose(0.2271054f,1.572563f,-0.3550005f,0.467016f,-0.3764477f,-0.6625316f,0.4485924f);
Get(0x6E82).SetLocalPose(0.3041286f,1.29189f,-0.2546264f,0.8519222f,-0.2284427f,-0.3182081f,-0.3475431f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.285351f);
Get(0x6EC6).SetLocalPose(0.4330167f,1.269644f,-0.2965459f,-0.1801889f,-0.8916237f,-0.3222063f,-0.2621492f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095231f,1.309309f,0.132865f,-0.703065f,-0.01440059f,-0.009624805f,0.7109146f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.322625f);
Get(0x6E70).SetLocalPose(0.2320905f,1.569459f,-0.3714302f,0.4670762f,-0.3784223f,-0.6609457f,0.4492074f);
Get(0x6E82).SetLocalPose(0.3078822f,1.294907f,-0.2711906f,0.8624864f,-0.2347153f,-0.3068666f,-0.3268928f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.355124f);
Get(0x6EC6).SetLocalPose(0.4364349f,1.274164f,-0.3153104f,-0.1488597f,-0.9154294f,-0.3051069f,-0.2161936f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095213f,1.309728f,0.1330608f,-0.7030734f,-0.01438593f,-0.00967284f,0.7109059f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.385169f);
Get(0x6E70).SetLocalPose(0.2395542f,1.566472f,-0.396195f,0.4696987f,-0.3812919f,-0.6571993f,0.4495429f);
Get(0x6E82).SetLocalPose(0.3133819f,1.299406f,-0.2935167f,0.8814737f,-0.2380954f,-0.286002f,-0.2907192f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.417667f);
Get(0x6EC6).SetLocalPose(0.4399214f,1.280434f,-0.3380262f,-0.1097045f,-0.94338f,-0.2747645f,-0.1500116f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095358f,1.30997f,0.1333072f,-0.7030762f,-0.01443776f,-0.009595608f,0.7109032f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.448567f);
Get(0x6E70).SetLocalPose(0.2461458f,1.566526f,-0.4181854f,0.4728749f,-0.383434f,-0.6550015f,0.4475945f);
Get(0x6E82).SetLocalPose(0.3195093f,1.303102f,-0.3104281f,0.897504f,-0.2320764f,-0.2646149f,-0.2657179f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.481065f);
Get(0x6EC6).SetLocalPose(0.4432382f,1.28866f,-0.3574405f,-0.06901243f,-0.9639441f,-0.2439065f,-0.08098562f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095453f,1.309986f,0.1332482f,-0.7030736f,-0.01442124f,-0.009590873f,0.7109062f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.511168f);
Get(0x6E70).SetLocalPose(0.2524235f,1.569882f,-0.4376757f,0.4742599f,-0.385125f,-0.6553915f,0.4440928f);
Get(0x6E82).SetLocalPose(0.3255873f,1.308684f,-0.32509f,0.9117886f,-0.2263375f,-0.24178f,-0.2428074f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.543666f);
Get(0x6EC6).SetLocalPose(0.4488523f,1.296879f,-0.3708682f,-0.04188061f,-0.9731279f,-0.2249907f,-0.02544094f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095541f,1.310034f,0.1330056f,-0.7030545f,-0.01444859f,-0.009557934f,0.710925f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.571589f);
Get(0x6E70).SetLocalPose(0.2587479f,1.576777f,-0.4555618f,0.4750845f,-0.3860036f,-0.6557841f,0.4418633f);
Get(0x6E82).SetLocalPose(0.3315218f,1.316265f,-0.3329609f,0.9199087f,-0.2264673f,-0.221958f,-0.2306844f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.604087f);
Get(0x6EC6).SetLocalPose(0.4556677f,1.307274f,-0.3815976f,-0.02452345f,-0.9745027f,-0.2226834f,0.01245946f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095685f,1.310231f,0.1328909f,-0.7030468f,-0.014463f,-0.009525102f,0.7109327f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.03544123f);
Get(0x6E70).SetLocalPose(0.2649373f,1.586586f,-0.4711384f,0.4752877f,-0.3866263f,-0.6548448f,0.442493f);
Get(0x6E82).SetLocalPose(0.3402977f,1.326795f,-0.3387928f,0.9253217f,-0.2322892f,-0.1919062f,-0.2302033f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.669702f);
Get(0x6EC6).SetLocalPose(0.4648863f,1.320927f,-0.3924748f,-0.006606281f,-0.9707814f,-0.2341855f,0.05193468f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.03544123f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.669702f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095641f,1.310149f,0.1330137f,-0.703055f,-0.0144948f,-0.009521599f,0.710924f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.1365031f);
Get(0x6E70).SetLocalPose(0.2766592f,1.613003f,-0.4942073f,0.4707845f,-0.3898329f,-0.652056f,0.4485703f);
Get(0x6E82).SetLocalPose(0.3558884f,1.344124f,-0.3404382f,0.9213678f,-0.2604938f,-0.1418856f,-0.2511832f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0f);
Get(0x6EC6).SetLocalPose(0.4798749f,1.344732f,-0.4057474f,0.02044357f,-0.9568657f,-0.2735381f,0.09574383f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095265f,1.310101f,0.1329111f,-0.7030575f,-0.01444849f,-0.009558381f,0.710922f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.2065726f);
Get(0x6E70).SetLocalPose(0.2841986f,1.632217f,-0.5060293f,0.4653025f,-0.392356f,-0.651076f,0.453487f);
Get(0x6E82).SetLocalPose(0.3675816f,1.349651f,-0.3405564f,0.9134406f,-0.2831115f,-0.112521f,-0.2698394f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.07006954f);
Get(0x6EC6).SetLocalPose(0.4875888f,1.356949f,-0.4114483f,0.0335736f,-0.9469767f,-0.3015676f,0.105665f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095407f,1.309366f,0.1328984f,-0.703056f,-0.01443523f,-0.009583575f,0.7109234f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.2704434f);
Get(0x6E70).SetLocalPose(0.2905262f,1.649177f,-0.5159515f,0.4589211f,-0.3946777f,-0.6510557f,0.4579819f);
Get(0x6E82).SetLocalPose(0.3761245f,1.359063f,-0.3397132f,0.9101434f,-0.2940509f,-0.08898696f,-0.2779466f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.1339403f);
Get(0x6EC6).SetLocalPose(0.4936985f,1.369747f,-0.4195504f,0.036861f,-0.9420738f,-0.3167188f,0.104056f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09537f,1.309169f,0.1327646f,-0.7030665f,-0.01445835f,-0.009603264f,0.7109123f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.3313794f);
Get(0x6E70).SetLocalPose(0.2960128f,1.664966f,-0.5247878f,0.452832f,-0.396377f,-0.6510209f,0.4626016f);
Get(0x6E82).SetLocalPose(0.3799361f,1.366678f,-0.3402642f,0.9115988f,-0.2865135f,-0.08124814f,-0.2833663f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.1948763f);
Get(0x6EC6).SetLocalPose(0.499767f,1.381934f,-0.4298923f,0.02984712f,-0.9404911f,-0.3264276f,0.08961441f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095313f,1.309303f,0.1327757f,-0.7030614f,-0.01445435f,-0.009591661f,0.7109176f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.3941345f);
Get(0x6E70).SetLocalPose(0.3028558f,1.681422f,-0.5367769f,0.4451889f,-0.3981855f,-0.6498353f,0.4700737f);
Get(0x6E82).SetLocalPose(0.3837688f,1.380007f,-0.3420126f,0.9106228f,-0.268192f,-0.08489425f,-0.3027081f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.2576314f);
Get(0x6EC6).SetLocalPose(0.5034806f,1.392579f,-0.4416562f,0.02257395f,-0.9402822f,-0.330207f,0.07951901f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095166f,1.309352f,0.1328253f,-0.7030488f,-0.01444011f,-0.009597648f,0.7109302f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.4544157f);
Get(0x6E70).SetLocalPose(0.3082452f,1.691748f,-0.5487025f,0.4382842f,-0.3991825f,-0.6474568f,0.4789156f);
Get(0x6E82).SetLocalPose(0.3858097f,1.395152f,-0.3449659f,0.9032654f,-0.2544903f,-0.1065403f,-0.3286268f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.3179126f);
Get(0x6EC6).SetLocalPose(0.5054862f,1.401742f,-0.4533337f,0.01336438f,-0.9417228f,-0.3285574f,0.07091975f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095128f,1.309507f,0.1328122f,-0.7030412f,-0.01441262f,-0.009657172f,0.7109374f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.5153154f);
Get(0x6E70).SetLocalPose(0.312236f,1.696559f,-0.5611899f,0.4329129f,-0.3987466f,-0.6442678f,0.4883713f);
Get(0x6E82).SetLocalPose(0.3875593f,1.410732f,-0.3509888f,0.8853134f,-0.2398217f,-0.1461053f,-0.37062f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0f);
Get(0x6EC6).SetLocalPose(0.50736f,1.411883f,-0.4679878f,-0.003611604f,-0.945247f,-0.3232107f,0.04505479f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.5153154f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095263f,1.309691f,0.1330456f,-0.7030499f,-0.01442667f,-0.009636758f,0.7109289f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.03815169f);
Get(0x6E70).SetLocalPose(0.3192538f,1.693174f,-0.593025f,0.425061f,-0.3935401f,-0.6414636f,0.5029652f);
Get(0x6E82).SetLocalPose(0.3857554f,1.44568f,-0.3688776f,0.8133441f,-0.1909494f,-0.300063f,-0.4604043f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.1417723f);
Get(0x6EC6).SetLocalPose(0.5179326f,1.429868f,-0.5104442f,-0.08425478f,-0.9430187f,-0.3058643f,-0.1003186f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09515f,1.309719f,0.1332195f,-0.7030699f,-0.01439187f,-0.009678326f,0.7109092f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.09788492f);
Get(0x6E70).SetLocalPose(0.32182f,1.687254f,-0.6065399f,0.4224299f,-0.3916449f,-0.6419396f,0.5060442f);
Get(0x6E82).SetLocalPose(0.383377f,1.455445f,-0.3791544f,0.7652422f,-0.1535388f,-0.3886672f,-0.4896611f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.2015055f);
Get(0x6EC6).SetLocalPose(0.5238216f,1.433355f,-0.5271092f,-0.1323247f,-0.9277856f,-0.2952626f,-0.1858062f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094821f,1.309662f,0.133222f,-0.7030795f,-0.01436866f,-0.009676542f,0.7109003f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.1576508f);
Get(0x6E70).SetLocalPose(0.3240153f,1.677576f,-0.6203967f,0.4201696f,-0.3903204f,-0.6421999f,0.5086126f);
Get(0x6E82).SetLocalPose(0.3810643f,1.461368f,-0.3917366f,0.7257088f,-0.1237567f,-0.4648194f,-0.4919084f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.2612714f);
Get(0x6EC6).SetLocalPose(0.5283323f,1.434363f,-0.5430807f,-0.1692345f,-0.9099073f,-0.2757896f,-0.2595546f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095012f,1.30952f,0.1331888f,-0.7030614f,-0.01440589f,-0.009664867f,0.7109175f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.2173751f);
Get(0x6E70).SetLocalPose(0.3274367f,1.663727f,-0.63789f,0.4188433f,-0.3887303f,-0.6415761f,0.5117023f);
Get(0x6E82).SetLocalPose(0.3791109f,1.465757f,-0.4088586f,0.6990831f,-0.09855667f,-0.5213392f,-0.4793483f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.3209957f);
Get(0x6EC6).SetLocalPose(0.5310526f,1.43407f,-0.5604463f,-0.193922f,-0.8936929f,-0.2491366f,-0.3188076f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09478f,1.309482f,0.1331847f,-0.7030585f,-0.0143813f,-0.00967665f,0.7109208f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.2779311f);
Get(0x6E70).SetLocalPose(0.3302521f,1.65118f,-0.6520352f,0.4187299f,-0.3875223f,-0.6410868f,0.5133221f);
Get(0x6E82).SetLocalPose(0.3782931f,1.467748f,-0.4278368f,0.6810849f,-0.08098815f,-0.5610277f,-0.4634784f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.3815517f);
Get(0x6EC6).SetLocalPose(0.5325499f,1.43165f,-0.5800319f,-0.209256f,-0.877574f,-0.218682f,-0.3718251f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094927f,1.309318f,0.1332158f,-0.703078f,-0.01439976f,-0.009703254f,0.7109008f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.3414354f);
Get(0x6E70).SetLocalPose(0.3337445f,1.636882f,-0.667518f,0.4184971f,-0.3867965f,-0.6413106f,0.5137795f);
Get(0x6E82).SetLocalPose(0.3789199f,1.466926f,-0.4562023f,0.6558371f,-0.06817423f,-0.6108176f,-0.4383286f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.445056f);
Get(0x6EC6).SetLocalPose(0.5346841f,1.427496f,-0.6002901f,-0.2242568f,-0.8575422f,-0.1858606f,-0.424012f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095006f,1.309346f,0.1331357f,-0.7030675f,-0.01440146f,-0.009666909f,0.7109116f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.3695532f);
Get(0x6E70).SetLocalPose(0.3360057f,1.627561f,-0.676854f,0.4179458f,-0.3867871f,-0.6418006f,0.5136237f);
Get(0x6E82).SetLocalPose(0.3790776f,1.465332f,-0.4689167f,0.6452313f,-0.06406993f,-0.6310576f,-0.4258381f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.4731739f);
Get(0x6EC6).SetLocalPose(0.5361007f,1.424503f,-0.6107676f,-0.2302578f,-0.8454189f,-0.1699004f,-0.4509791f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094918f,1.308959f,0.1330825f,-0.7030748f,-0.01434786f,-0.009676555f,0.7109053f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.4747754f);
Get(0x6E70).SetLocalPose(0.3408721f,1.597804f,-0.7020342f,0.4184413f,-0.3858023f,-0.6444126f,0.5106817f);
Get(0x6E82).SetLocalPose(0.3807229f,1.457114f,-0.5179924f,0.627928f,-0.05316734f,-0.677008f,-0.3801842f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.578396f);
Get(0x6EC6).SetLocalPose(0.5380948f,1.413185f,-0.6414574f,-0.2364044f,-0.8185595f,-0.1302695f,-0.5070536f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095069f,1.309157f,0.1330306f,-0.7030753f,-0.01436341f,-0.009658622f,0.7109047f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.5097387f);
Get(0x6E70).SetLocalPose(0.3426966f,1.585696f,-0.7121276f,0.4211706f,-0.3835999f,-0.6465515f,0.5073832f);
Get(0x6E82).SetLocalPose(0.3816147f,1.454153f,-0.5311887f,0.6259743f,-0.05061562f,-0.6843473f,-0.3704904f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.6133594f);
Get(0x6EC6).SetLocalPose(0.5374859f,1.412138f,-0.643271f,-0.2360989f,-0.8177273f,-0.128436f,-0.5090026f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094851f,1.308969f,0.1330033f,-0.7030887f,-0.0143399f,-0.009700068f,0.7108914f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.5743551f);
Get(0x6E70).SetLocalPose(0.34461f,1.572953f,-0.7229767f,0.425366f,-0.3797415f,-0.6505086f,0.501696f);
Get(0x6E82).SetLocalPose(0.3826221f,1.44944f,-0.5552574f,0.6180283f,-0.04968873f,-0.698927f,-0.3564731f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.6779757f);
Get(0x6EC6).SetLocalPose(0.538075f,1.403096f,-0.6626256f,-0.2320861f,-0.8132679f,-0.115147f,-0.5210304f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094874f,1.309393f,0.1331222f,-0.7030936f,-0.01436285f,-0.009647447f,0.7108868f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.6343744f);
Get(0x6E70).SetLocalPose(0.3472532f,1.559309f,-0.7360516f,0.4318625f,-0.3731181f,-0.6574882f,0.4919218f);
Get(0x6E82).SetLocalPose(0.3854225f,1.445762f,-0.575617f,0.611111f,-0.05082998f,-0.7101845f,-0.345829f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.7379951f);
Get(0x6EC6).SetLocalPose(0.5368521f,1.395007f,-0.6797422f,-0.2308149f,-0.8112828f,-0.1135435f,-0.5250264f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094816f,1.309467f,0.1332716f,-0.7031026f,-0.01434098f,-0.00969443f,0.7108777f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.693956f);
Get(0x6E70).SetLocalPose(0.3491218f,1.551318f,-0.7455773f,0.4376405f,-0.3673364f,-0.6622509f,0.4847253f);
Get(0x6E82).SetLocalPose(0.3887258f,1.443279f,-0.5948061f,0.6074904f,-0.0495209f,-0.7170483f,-0.3381492f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.7975766f);
Get(0x6EC6).SetLocalPose(0.535476f,1.391767f,-0.6888537f,-0.2292597f,-0.8112863f,-0.1177293f,-0.5247804f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094981f,1.309592f,0.1332491f,-0.7031043f,-0.01435249f,-0.009643861f,0.7108765f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.7565876f);
Get(0x6E70).SetLocalPose(0.3510407f,1.545605f,-0.7543466f,0.4430836f,-0.3615974f,-0.6663674f,0.4784128f);
Get(0x6E82).SetLocalPose(0.3925867f,1.440768f,-0.6097726f,0.6061716f,-0.04748125f,-0.7188888f,-0.3368984f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.8602083f);
Get(0x6EC6).SetLocalPose(0.5338251f,1.391036f,-0.6962375f,-0.2239532f,-0.8145322f,-0.1238756f,-0.5206123f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09516f,1.309624f,0.1332705f,-0.7031175f,-0.01438418f,-0.009628072f,0.7108629f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.8181864f);
Get(0x6E70).SetLocalPose(0.3530065f,1.543438f,-0.7615772f,0.4461833f,-0.3568116f,-0.6704099f,0.4734517f);
Get(0x6E82).SetLocalPose(0.3957087f,1.440756f,-0.6211348f,0.6008081f,-0.04795269f,-0.7209783f,-0.3419366f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.9218071f);
Get(0x6EC6).SetLocalPose(0.5319051f,1.394242f,-0.7037174f,-0.2151933f,-0.8194154f,-0.1292438f,-0.5153118f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095067f,1.309545f,0.1333659f,-0.7031061f,-0.01438518f,-0.009642255f,0.710874f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.8477886f);
Get(0x6E70).SetLocalPose(0.3538316f,1.543971f,-0.7648804f,0.4466748f,-0.3544828f,-0.6730479f,0.4709885f);
Get(0x6E82).SetLocalPose(0.3969761f,1.441722f,-0.6244843f,0.5980957f,-0.04925054f,-0.7214937f,-0.3454024f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.9514092f);
Get(0x6EC6).SetLocalPose(0.5313951f,1.397375f,-0.7066558f,-0.2104615f,-0.823133f,-0.1310741f,-0.5108597f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094998f,1.309246f,0.1332821f,-0.7030988f,-0.01435817f,-0.009642289f,0.7108818f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.9515972f);
Get(0x6E70).SetLocalPose(0.3568614f,1.553461f,-0.7701284f,0.4439679f,-0.3500655f,-0.6791242f,0.4681208f);
Get(0x6E82).SetLocalPose(0.3996425f,1.450068f,-0.6292922f,0.5809458f,-0.05621402f,-0.7275161f,-0.3606417f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.055218f);
Get(0x6EC6).SetLocalPose(0.5316424f,1.40688f,-0.7140852f,-0.2019588f,-0.829744f,-0.1354756f,-0.5023783f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095116f,1.309243f,0.1333651f,-0.7031118f,-0.01441365f,-0.009622388f,0.7108682f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.020096f);
Get(0x6E70).SetLocalPose(0.3579636f,1.562337f,-0.7702994f,0.4410352f,-0.3499581f,-0.6798962f,0.4698496f);
Get(0x6E82).SetLocalPose(0.4003516f,1.456127f,-0.6287618f,0.569694f,-0.05830374f,-0.7314773f,-0.3701223f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.123717f);
Get(0x6EC6).SetLocalPose(0.5324781f,1.41126f,-0.7168363f,-0.1990105f,-0.8274099f,-0.1409801f,-0.5058778f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095092f,1.309133f,0.13328f,-0.7031187f,-0.01439559f,-0.009650238f,0.7108613f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.081518f);
Get(0x6E70).SetLocalPose(0.3583448f,1.571906f,-0.7690846f,0.4370497f,-0.3513572f,-0.6795795f,0.4729773f);
Get(0x6E82).SetLocalPose(0.4009337f,1.461704f,-0.6275523f,0.5615655f,-0.06122604f,-0.7332805f,-0.3784117f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.185138f);
Get(0x6EC6).SetLocalPose(0.5333221f,1.418023f,-0.7155542f,-0.1961066f,-0.8213587f,-0.1496523f,-0.5143114f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095298f,1.309258f,0.1330774f,-0.7031114f,-0.01438747f,-0.009629512f,0.710869f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.141379f);
Get(0x6E70).SetLocalPose(0.3580283f,1.582628f,-0.7662874f,0.4314837f,-0.353989f,-0.6785611f,0.4775651f);
Get(0x6E82).SetLocalPose(0.401464f,1.467631f,-0.6254621f,0.5532525f,-0.0683554f,-0.7340611f,-0.3878062f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.245f);
Get(0x6EC6).SetLocalPose(0.5281857f,1.42741f,-0.7114162f,-0.1993941f,-0.8185099f,-0.1511755f,-0.5171359f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095208f,1.309134f,0.1333501f,-0.7031186f,-0.01437014f,-0.009664948f,0.7108617f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.201767f);
Get(0x6E70).SetLocalPose(0.3567394f,1.591059f,-0.7633078f,0.4270487f,-0.3562226f,-0.6766572f,0.4825659f);
Get(0x6E82).SetLocalPose(0.3985962f,1.471383f,-0.6237753f,0.5601685f,-0.07117514f,-0.7275787f,-0.3895827f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.305388f);
Get(0x6EC6).SetLocalPose(0.5254126f,1.43434f,-0.7053184f,-0.2009504f,-0.8192009f,-0.1518693f,-0.5152326f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094886f,1.309221f,0.1333065f,-0.7031022f,-0.01434148f,-0.009667347f,0.7108786f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.264126f);
Get(0x6E70).SetLocalPose(0.354172f,1.598481f,-0.7585817f,0.423622f,-0.3581162f,-0.6728108f,0.4895128f);
Get(0x6E82).SetLocalPose(0.3942822f,1.47434f,-0.6209099f,0.5700615f,-0.07191861f,-0.7194918f,-0.3901142f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.367747f);
Get(0x6EC6).SetLocalPose(0.5218451f,1.439738f,-0.6987634f,-0.1983857f,-0.8192187f,-0.1556091f,-0.5150823f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094773f,1.309109f,0.1332203f,-0.7031205f,-0.01438012f,-0.009642059f,0.71086f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.324187f);
Get(0x6E70).SetLocalPose(0.3512623f,1.6017f,-0.7542695f,0.4218708f,-0.3591512f,-0.6693163f,0.4950265f);
Get(0x6E82).SetLocalPose(0.3888673f,1.475708f,-0.6155196f,0.5701496f,-0.0701277f,-0.7209522f,-0.3876072f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.427808f);
Get(0x6EC6).SetLocalPose(0.517158f,1.44245f,-0.6906807f,-0.1951267f,-0.8141176f,-0.1596037f,-0.5231299f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.324187f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.427808f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095102f,1.308974f,0.1330674f,-0.7030916f,-0.01437729f,-0.00968051f,0.710888f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.424284f);
Get(0x6E70).SetLocalPose(0.3418353f,1.600526f,-0.7432709f,0.4204654f,-0.3603286f,-0.6635386f,0.5030792f);
Get(0x6E82).SetLocalPose(0.378197f,1.473303f,-0.60152f,0.5612749f,-0.05730046f,-0.7299137f,-0.3858927f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.527905f);
Get(0x6EC6).SetLocalPose(0.5080465f,1.444211f,-0.6754777f,-0.1971665f,-0.8051099f,-0.1631195f,-0.5350845f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095281f,1.30902f,0.1331691f,-0.7030839f,-0.01440082f,-0.009646156f,0.7108957f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.494442f);
Get(0x6E70).SetLocalPose(0.3361356f,1.595538f,-0.7376069f,0.4217758f,-0.3602624f,-0.6615594f,0.504634f);
Get(0x6E82).SetLocalPose(0.3720792f,1.468328f,-0.5927796f,0.5554571f,-0.05128357f,-0.7362794f,-0.3830535f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.598063f);
Get(0x6EC6).SetLocalPose(0.5001283f,1.440238f,-0.6682612f,-0.1956354f,-0.8036124f,-0.1644841f,-0.5374745f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09519f,1.309363f,0.1332812f,-0.7030972f,-0.01444304f,-0.009646448f,0.7108817f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.58201f);
Get(0x6E70).SetLocalPose(0.3252798f,1.584389f,-0.7275162f,0.4259135f,-0.3600105f,-0.659862f,0.5035596f);
Get(0x6E82).SetLocalPose(0.3621332f,1.456797f,-0.5806409f,0.5479873f,-0.03997197f,-0.7451126f,-0.3780468f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.68563f);
Get(0x6EC6).SetLocalPose(0.4886537f,1.429323f,-0.6575336f,-0.1920118f,-0.8039889f,-0.1631573f,-0.5386214f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095168f,1.30935f,0.1332018f,-0.7030826f,-0.01443375f,-0.009600705f,0.7108969f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.642281f);
Get(0x6E70).SetLocalPose(0.3153867f,1.57341f,-0.7183469f,0.4297818f,-0.3599261f,-0.6598185f,0.5003803f);
Get(0x6E82).SetLocalPose(0.3538265f,1.447783f,-0.570144f,0.5419033f,-0.03102243f,-0.7511359f,-0.3757306f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.745901f);
Get(0x6EC6).SetLocalPose(0.481671f,1.422643f,-0.6491019f,-0.19293f,-0.8021045f,-0.1608375f,-0.5417911f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095152f,1.309529f,0.1332557f,-0.7030756f,-0.01444534f,-0.009622483f,0.7109033f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.704109f);
Get(0x6E70).SetLocalPose(0.3067351f,1.563385f,-0.7100882f,0.4346864f,-0.3590584f,-0.6592242f,0.4975423f);
Get(0x6E82).SetLocalPose(0.3443589f,1.436779f,-0.5594884f,0.5337908f,-0.01924926f,-0.7582549f,-0.3738267f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.807729f);
Get(0x6EC6).SetLocalPose(0.4729652f,1.411559f,-0.6392715f,-0.1955646f,-0.799246f,-0.1586753f,-0.5456946f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095094f,1.309523f,0.1331197f,-0.7030719f,-0.01442016f,-0.009656182f,0.710907f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.762821f);
Get(0x6E70).SetLocalPose(0.2966977f,1.552921f,-0.7001634f,0.4424911f,-0.3573608f,-0.6571655f,0.4945993f);
Get(0x6E82).SetLocalPose(0.3370638f,1.428788f,-0.5520411f,0.5289983f,-0.01164005f,-0.7614402f,-0.3744788f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.866442f);
Get(0x6EC6).SetLocalPose(0.4658204f,1.401589f,-0.6313841f,-0.1946789f,-0.798498f,-0.1582712f,-0.5472214f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094871f,1.309365f,0.1331175f,-0.7030814f,-0.01438889f,-0.009665477f,0.710898f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.790687f);
Get(0x6E70).SetLocalPose(0.2914353f,1.548574f,-0.6946836f,0.4465719f,-0.3567004f,-0.6558973f,0.4930893f);
Get(0x6E82).SetLocalPose(0.3324916f,1.424062f,-0.5471125f,0.5284146f,-0.009387885f,-0.7614348f,-0.3753758f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.894308f);
Get(0x6EC6).SetLocalPose(0.4605815f,1.394614f,-0.6256907f,-0.1936162f,-0.7987087f,-0.1587388f,-0.5471556f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.790687f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.894308f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09525f,1.309264f,0.1330269f,-0.7030863f,-0.01435587f,-0.009701679f,0.7108936f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.933486f);
Get(0x6E70).SetLocalPose(0.2677112f,1.539574f,-0.6645609f,0.4562503f,-0.3593873f,-0.6535535f,0.4853291f);
Get(0x6E82).SetLocalPose(0.3172678f,1.41052f,-0.5249513f,0.5424331f,-0.01444902f,-0.7473637f,-0.3834125f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.037106f);
Get(0x6EC6).SetLocalPose(0.4459488f,1.381195f,-0.5991195f,-0.2021607f,-0.7971938f,-0.1625728f,-0.5451451f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095436f,1.309411f,0.1332797f,-0.7030802f,-0.01436376f,-0.009663976f,0.7108998f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.993525f);
Get(0x6E70).SetLocalPose(0.2578948f,1.541761f,-0.6488497f,0.455794f,-0.3622972f,-0.6530969f,0.4842076f);
Get(0x6E82).SetLocalPose(0.3122903f,1.408573f,-0.513086f,0.5553077f,-0.01954986f,-0.7343771f,-0.3897968f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.097145f);
Get(0x6EC6).SetLocalPose(0.4404342f,1.37822f,-0.5855915f,-0.2105616f,-0.7952758f,-0.1660065f,-0.5437298f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095391f,1.309494f,0.1332379f,-0.7030656f,-0.01441145f,-0.0096156f,0.710914f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.051614f);
Get(0x6E70).SetLocalPose(0.2503318f,1.54572f,-0.6355686f,0.4540338f,-0.3645956f,-0.6521749f,0.4853775f);
Get(0x6E82).SetLocalPose(0.308196f,1.409185f,-0.5012624f,0.5656927f,-0.02284526f,-0.7237865f,-0.3944657f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.155234f);
Get(0x6EC6).SetLocalPose(0.4362971f,1.379084f,-0.5723506f,-0.2162373f,-0.7968251f,-0.1690376f,-0.5382728f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095102f,1.309582f,0.1332396f,-0.7030756f,-0.01443234f,-0.009624868f,0.7109035f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.110696f);
Get(0x6E70).SetLocalPose(0.2405685f,1.553315f,-0.6177069f,0.4519743f,-0.3662353f,-0.6505732f,0.4882064f);
Get(0x6E82).SetLocalPose(0.302953f,1.412332f,-0.4872723f,0.5711368f,-0.02585593f,-0.7164201f,-0.3998457f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.214316f);
Get(0x6EC6).SetLocalPose(0.4316375f,1.383801f,-0.5583718f,-0.2191618f,-0.8014287f,-0.1728218f,-0.5289735f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095118f,1.309793f,0.1331625f,-0.7030675f,-0.01438972f,-0.009597071f,0.7109127f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.170905f);
Get(0x6E70).SetLocalPose(0.2338203f,1.562083f,-0.6041696f,0.4524736f,-0.3653759f,-0.6498538f,0.4893447f);
Get(0x6E82).SetLocalPose(0.2964079f,1.419275f,-0.4672844f,0.5716223f,-0.03335633f,-0.7122114f,-0.4060669f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.274526f);
Get(0x6EC6).SetLocalPose(0.426658f,1.391217f,-0.5450801f,-0.2189361f,-0.8058043f,-0.1769402f,-0.5209976f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094876f,1.309639f,0.1330935f,-0.7030727f,-0.01445126f,-0.009569036f,0.7109067f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.25888f);
Get(0x6E70).SetLocalPose(0.2241966f,1.581856f,-0.5826069f,0.4522853f,-0.364344f,-0.6501047f,0.4899544f);
Get(0x6E82).SetLocalPose(0.2897098f,1.430986f,-0.4431583f,0.5680633f,-0.04434612f,-0.7103334f,-0.4132361f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.3625f);
Get(0x6EC6).SetLocalPose(0.4193566f,1.407993f,-0.52389f,-0.2165228f,-0.8117641f,-0.1833116f,-0.5104446f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.25888f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.3625f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095101f,1.309667f,0.1329273f,-0.703063f,-0.01443856f,-0.009604603f,0.7109161f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.359647f);
Get(0x6E70).SetLocalPose(0.2172758f,1.610248f,-0.5596018f,0.4419217f,-0.3704871f,-0.6477099f,0.497912f);
Get(0x6E82).SetLocalPose(0.2825112f,1.449815f,-0.4174286f,0.5709868f,-0.05496439f,-0.703845f,-0.4189931f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.463268f);
Get(0x6EC6).SetLocalPose(0.4125515f,1.432152f,-0.4987504f,-0.2140849f,-0.8179318f,-0.1912641f,-0.4985712f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095244f,1.309665f,0.1330757f,-0.7030576f,-0.01442309f,-0.009624283f,0.7109215f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.428438f);
Get(0x6E70).SetLocalPose(0.2143376f,1.626354f,-0.5466704f,0.4335875f,-0.3748322f,-0.6443661f,0.506256f);
Get(0x6E82).SetLocalPose(0.2792777f,1.461291f,-0.4045726f,0.5796326f,-0.06216625f,-0.697277f,-0.4170925f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.532058f);
Get(0x6EC6).SetLocalPose(0.4089049f,1.444157f,-0.4870164f,-0.2137017f,-0.8207509f,-0.1985641f,-0.4911944f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095022f,1.309508f,0.1328667f,-0.703052f,-0.01443338f,-0.009599435f,0.7109272f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.488152f);
Get(0x6E70).SetLocalPose(0.2122345f,1.64044f,-0.5353487f,0.4260955f,-0.3780001f,-0.6414362f,0.5139242f);
Get(0x6E82).SetLocalPose(0.2764112f,1.473176f,-0.3915561f,0.5912759f,-0.06907396f,-0.6869894f,-0.4167339f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.591772f);
Get(0x6EC6).SetLocalPose(0.4051013f,1.456927f,-0.4736488f,-0.2120116f,-0.8242165f,-0.2107497f,-0.4809395f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095177f,1.309575f,0.1328686f,-0.7030552f,-0.01445612f,-0.009595903f,0.7109237f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.547854f);
Get(0x6E70).SetLocalPose(0.2096935f,1.65623f,-0.5220366f,0.4177049f,-0.3806093f,-0.6383786f,0.5226203f);
Get(0x6E82).SetLocalPose(0.2744786f,1.483406f,-0.3782381f,0.6063424f,-0.08143492f,-0.6740292f,-0.4140072f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.651474f);
Get(0x6EC6).SetLocalPose(0.4011685f,1.466498f,-0.4600468f,-0.2055583f,-0.8292699f,-0.2226577f,-0.4695539f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095048f,1.309516f,0.1327635f,-0.7030379f,-0.01439472f,-0.00962683f,0.7109416f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.606059f);
Get(0x6E70).SetLocalPose(0.2075627f,1.666588f,-0.5115386f,0.4121785f,-0.3818613f,-0.6351594f,0.5299655f);
Get(0x6E82).SetLocalPose(0.2738271f,1.490523f,-0.3676057f,0.6224313f,-0.09721644f,-0.6604661f,-0.4085496f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.709679f);
Get(0x6EC6).SetLocalPose(0.3986568f,1.472117f,-0.4479322f,-0.2024231f,-0.8352164f,-0.2298815f,-0.4567198f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095417f,1.30951f,0.1328878f,-0.703037f,-0.0144073f,-0.009607765f,0.7109424f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.665098f);
Get(0x6E70).SetLocalPose(0.2048295f,1.673124f,-0.5021152f,0.4084688f,-0.3823723f,-0.630325f,0.5381775f);
Get(0x6E82).SetLocalPose(0.2765628f,1.498153f,-0.3526657f,0.6451353f,-0.1229244f,-0.6367514f,-0.4040271f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.768718f);
Get(0x6EC6).SetLocalPose(0.397386f,1.474025f,-0.4335895f,-0.2055601f,-0.8400569f,-0.2371759f,-0.4424897f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095736f,1.30961f,0.132941f,-0.703039f,-0.01450536f,-0.009570683f,0.710939f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.726649f);
Get(0x6E70).SetLocalPose(0.2007978f,1.676014f,-0.4916466f,0.4072134f,-0.3819827f,-0.6220149f,0.5489663f);
Get(0x6E82).SetLocalPose(0.2800783f,1.501833f,-0.3406216f,0.6713505f,-0.138809f,-0.6095713f,-0.3980496f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.83027f);
Get(0x6EC6).SetLocalPose(0.3970304f,1.470778f,-0.4187146f,-0.2117101f,-0.8410631f,-0.2438498f,-0.4339687f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.726649f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.83027f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09614f,1.309414f,0.133038f,-0.7030742f,-0.01443615f,-0.009629149f,0.7109047f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.865612f);
Get(0x6E70).SetLocalPose(0.1896562f,1.666573f,-0.4740555f,0.4092681f,-0.3836468f,-0.6056905f,0.564317f);
Get(0x6E82).SetLocalPose(0.2884175f,1.49987f,-0.3011113f,0.7697126f,-0.134483f,-0.5021434f,-0.3705522f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.969233f);
Get(0x6EC6).SetLocalPose(0.3969134f,1.452894f,-0.3883683f,-0.2092472f,-0.8626719f,-0.2513367f,-0.3858015f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095606f,1.309352f,0.1332849f,-0.7030763f,-0.01444252f,-0.009631303f,0.7109026f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.926974f);
Get(0x6E70).SetLocalPose(0.1842088f,1.658315f,-0.4661305f,0.4102993f,-0.3855683f,-0.5990661f,0.5693079f);
Get(0x6E82).SetLocalPose(0.288732f,1.499612f,-0.2659933f,0.7579171f,-0.1201947f,-0.5090024f,-0.389912f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.030595f);
Get(0x6EC6).SetLocalPose(0.3972989f,1.439159f,-0.3748786f,-0.2064796f,-0.877874f,-0.250487f,-0.352079f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09556f,1.309535f,0.133306f,-0.7030978f,-0.01447356f,-0.009578058f,0.7108813f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.990348f);
Get(0x6E70).SetLocalPose(0.1775013f,1.646689f,-0.4568665f,0.4117523f,-0.38777f,-0.5920231f,0.5741109f);
Get(0x6E82).SetLocalPose(0.284875f,1.499116f,-0.2241803f,0.7014806f,-0.09459103f,-0.5628999f,-0.4267566f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.093969f);
Get(0x6EC6).SetLocalPose(0.3976041f,1.42346f,-0.3621136f,-0.2139275f,-0.880917f,-0.2463832f,-0.3428058f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095196f,1.309506f,0.1332427f,-0.7031119f,-0.01442043f,-0.009641727f,0.7108676f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.051265f);
Get(0x6E70).SetLocalPose(0.1719358f,1.636304f,-0.4494239f,0.4144664f,-0.3887438f,-0.5864824f,0.5771778f);
Get(0x6E82).SetLocalPose(0.2795548f,1.49488f,-0.1828812f,0.6187735f,-0.06398831f,-0.6270697f,-0.4688373f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.154885f);
Get(0x6EC6).SetLocalPose(0.3965301f,1.407952f,-0.3507186f,-0.2234f,-0.8782366f,-0.2401058f,-0.3480548f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094877f,1.309428f,0.1332629f,-0.7031012f,-0.01438682f,-0.009661399f,0.7108787f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.112417f);
Get(0x6E70).SetLocalPose(0.1637238f,1.623246f,-0.4386788f,0.418919f,-0.3908316f,-0.5804067f,0.5786931f);
Get(0x6E82).SetLocalPose(0.2738011f,1.486966f,-0.1603211f,0.5410718f,-0.04434828f,-0.6890152f,-0.4801382f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.216038f);
Get(0x6EC6).SetLocalPose(0.391797f,1.391232f,-0.3380222f,-0.2315284f,-0.8789212f,-0.2303424f,-0.3476128f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095072f,1.309427f,0.133332f,-0.703088f,-0.01444179f,-0.009611296f,0.7108913f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.171811f);
Get(0x6E70).SetLocalPose(0.1571009f,1.613687f,-0.4289247f,0.4222195f,-0.3939509f,-0.5766637f,0.5779208f);
Get(0x6E82).SetLocalPose(0.2646891f,1.477172f,-0.1536116f,0.4756913f,-0.02915872f,-0.7503784f,-0.4580392f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.275431f);
Get(0x6EC6).SetLocalPose(0.3859516f,1.379238f,-0.3290008f,-0.2339785f,-0.8841662f,-0.2214509f,-0.338325f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095037f,1.309511f,0.1332557f,-0.7030841f,-0.0144376f,-0.009588508f,0.7108956f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.200445f);
Get(0x6E70).SetLocalPose(0.1514898f,1.608478f,-0.4205911f,0.4239418f,-0.3972221f,-0.5741897f,0.5768831f);
Get(0x6E82).SetLocalPose(0.2593848f,1.475567f,-0.1593594f,0.4805451f,-0.05213537f,-0.7551089f,-0.4429096f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.304066f);
Get(0x6EC6).SetLocalPose(0.3818412f,1.374476f,-0.3245384f,-0.2351151f,-0.886884f,-0.2158814f,-0.3339953f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.200445f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.304066f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094846f,1.309652f,0.1333871f,-0.7031217f,-0.01445191f,-0.009607778f,0.7108577f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.324599f);
Get(0x6E70).SetLocalPose(0.1337259f,1.603329f,-0.3911769f,0.4214701f,-0.409444f,-0.571264f,0.573041f);
Get(0x6E82).SetLocalPose(0.2472321f,1.472224f,-0.214608f,0.6356627f,-0.2203891f,-0.6576632f,-0.3388816f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.42822f);
Get(0x6EC6).SetLocalPose(0.3690586f,1.364184f,-0.3073595f,-0.2416779f,-0.8871791f,-0.191309f,-0.3433743f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094909f,1.309615f,0.1335924f,-0.7031187f,-0.01440246f,-0.00964328f,0.7108613f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.420296f);
Get(0x6E70).SetLocalPose(0.1246472f,1.60941f,-0.3707583f,0.4154223f,-0.4155452f,-0.5750458f,0.5692704f);
Get(0x6E82).SetLocalPose(0.2369139f,1.46457f,-0.2419044f,0.7188882f,-0.2887754f,-0.5801271f,-0.2515179f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.523917f);
Get(0x6EC6).SetLocalPose(0.3594171f,1.372229f,-0.2968933f,-0.2369857f,-0.8936817f,-0.174853f,-0.338522f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094867f,1.309261f,0.1334378f,-0.7031076f,-0.0143824f,-0.009658826f,0.7108725f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.479263f);
Get(0x6E70).SetLocalPose(0.118498f,1.618958f,-0.3545427f,0.4107831f,-0.4181361f,-0.5792955f,0.5664241f);
Get(0x6E82).SetLocalPose(0.2292203f,1.462294f,-0.2514087f,0.7522839f,-0.3164221f,-0.5417356f,-0.2011676f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.582883f);
Get(0x6EC6).SetLocalPose(0.3514662f,1.384226f,-0.289156f,-0.2278752f,-0.9021063f,-0.1656068f,-0.3268814f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095106f,1.309112f,0.1333937f,-0.7031388f,-0.01439038f,-0.009640296f,0.7108416f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.538035f);
Get(0x6E70).SetLocalPose(0.1134317f,1.628408f,-0.3402764f,0.40446f,-0.4210348f,-0.5838363f,0.5641604f);
Get(0x6E82).SetLocalPose(0.2199985f,1.464504f,-0.25503f,0.7817788f,-0.3368965f,-0.5037113f,-0.1469611f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.641656f);
Get(0x6EC6).SetLocalPose(0.345248f,1.396662f,-0.2817879f,-0.2166272f,-0.9105269f,-0.1611902f,-0.3130993f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095366f,1.308954f,0.1335248f,-0.7031233f,-0.0144198f,-0.009624813f,0.7108567f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.59624f);
Get(0x6E70).SetLocalPose(0.1090589f,1.639631f,-0.3247706f,0.3943855f,-0.4248606f,-0.5889145f,0.5631459f);
Get(0x6E82).SetLocalPose(0.211605f,1.471348f,-0.2494433f,0.8003997f,-0.3428239f,-0.4807229f,-0.1036222f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.699861f);
Get(0x6EC6).SetLocalPose(0.3390886f,1.412285f,-0.2710973f,-0.2029264f,-0.9182991f,-0.162287f,-0.2986813f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095436f,1.309182f,0.1334862f,-0.7031322f,-0.01446322f,-0.009601541f,0.7108473f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.657619f);
Get(0x6E70).SetLocalPose(0.1051431f,1.650986f,-0.3092719f,0.3824526f,-0.4276308f,-0.5929081f,0.5650858f);
Get(0x6E82).SetLocalPose(0.2035753f,1.484461f,-0.234853f,0.8160464f,-0.3256963f,-0.4715638f,-0.07495118f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.76124f);
Get(0x6EC6).SetLocalPose(0.3347566f,1.424735f,-0.2599222f,-0.1880895f,-0.9242162f,-0.1693969f,-0.2859221f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09538f,1.309363f,0.1335236f,-0.7031323f,-0.01440992f,-0.009626213f,0.7108479f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.685978f);
Get(0x6E70).SetLocalPose(0.1036192f,1.65627f,-0.3014139f,0.3763596f,-0.4282649f,-0.5943245f,0.5672045f);
Get(0x6E82).SetLocalPose(0.2003588f,1.495014f,-0.218759f,0.8229196f,-0.3015085f,-0.4760908f,-0.07234307f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.789598f);
Get(0x6EC6).SetLocalPose(0.3326822f,1.429287f,-0.2541593f,-0.1815642f,-0.9263354f,-0.1743742f,-0.2802334f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094929f,1.309489f,0.1332381f,-0.7031178f,-0.01443425f,-0.009633482f,0.7108616f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.789259f);
Get(0x6E70).SetLocalPose(0.09943362f,1.670386f,-0.2742982f,0.3553793f,-0.4278321f,-0.5970626f,0.5780844f);
Get(0x6E82).SetLocalPose(0.212853f,1.533686f,-0.1416979f,0.8449242f,-0.202944f,-0.476858f,-0.1323754f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.89288f);
Get(0x6EC6).SetLocalPose(0.3293795f,1.439702f,-0.2282355f,-0.1776294f,-0.926255f,-0.1926934f,-0.2708668f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094954f,1.309538f,0.1333527f,-0.7031106f,-0.01439478f,-0.009667163f,0.7108691f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.852633f);
Get(0x6E70).SetLocalPose(0.09698705f,1.673818f,-0.2603652f,0.3446297f,-0.4262905f,-0.5974091f,0.5853282f);
Get(0x6E82).SetLocalPose(0.2401876f,1.558018f,-0.07815046f,0.8869299f,-0.1906932f,-0.386326f,-0.1665648f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.956253f);
Get(0x6EC6).SetLocalPose(0.3292297f,1.440539f,-0.2101675f,-0.1847533f,-0.9199458f,-0.2116929f,-0.2734081f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095203f,1.309633f,0.1335553f,-0.7031039f,-0.01437814f,-0.009675466f,0.710876f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.91027f);
Get(0x6E70).SetLocalPose(0.09363229f,1.671636f,-0.2457186f,0.3372999f,-0.4223168f,-0.5969868f,0.592861f);
Get(0x6E82).SetLocalPose(0.2747768f,1.580959f,-0.000702549f,0.9338731f,-0.1993958f,-0.228984f,-0.1889145f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.013891f);
Get(0x6EC6).SetLocalPose(0.3281871f,1.436291f,-0.190656f,-0.1882126f,-0.9127945f,-0.2382563f,-0.2731596f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095181f,1.309815f,0.1335789f,-0.7030856f,-0.01440005f,-0.009665255f,0.7108938f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.968832f);
Get(0x6E70).SetLocalPose(0.08897446f,1.663489f,-0.2295714f,0.3357868f,-0.4155494f,-0.5960991f,0.5993595f);
Get(0x6E82).SetLocalPose(0.3004481f,1.592669f,0.06398763f,0.9476787f,-0.2149627f,-0.08955429f,-0.2183489f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.072453f);
Get(0x6EC6).SetLocalPose(0.3249682f,1.426459f,-0.1689997f,-0.1812492f,-0.9111826f,-0.2729977f,-0.2497344f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095491f,1.309487f,0.1334561f,-0.7031028f,-0.01443328f,-0.009613072f,0.7108768f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.031563f);
Get(0x6E70).SetLocalPose(0.08438953f,1.651607f,-0.2135802f,0.3383692f,-0.4088089f,-0.5955006f,0.6031258f);
Get(0x6E82).SetLocalPose(0.3254161f,1.602919f,0.158287f,0.9064819f,-0.2659388f,0.09672517f,-0.3133869f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.135184f);
Get(0x6EC6).SetLocalPose(0.3212178f,1.414117f,-0.1506595f,-0.1655904f,-0.9138987f,-0.3058642f,-0.2093229f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095148f,1.309599f,0.1333616f,-0.7030978f,-0.01443887f,-0.009663574f,0.710881f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.090196f);
Get(0x6E70).SetLocalPose(0.08023977f,1.639056f,-0.1990866f,0.3412406f,-0.40422f,-0.5957763f,0.6043274f);
Get(0x6E82).SetLocalPose(0.3215421f,1.608904f,0.2710656f,0.7959342f,-0.3402928f,0.1568546f,-0.4754853f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.193817f);
Get(0x6EC6).SetLocalPose(0.317337f,1.393831f,-0.1297361f,-0.1494496f,-0.9114841f,-0.3448639f,-0.1671242f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095276f,1.309598f,0.1332045f,-0.7030692f,-0.01439315f,-0.009651505f,0.7109104f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.152061f);
Get(0x6E70).SetLocalPose(0.07520513f,1.623972f,-0.182545f,0.341301f,-0.4019645f,-0.5979263f,0.6036741f);
Get(0x6E82).SetLocalPose(0.2998537f,1.600629f,0.346803f,0.6797267f,-0.3195603f,0.2637526f,-0.6052169f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.255682f);
Get(0x6EC6).SetLocalPose(0.3156964f,1.372375f,-0.1105529f,-0.1433768f,-0.9004097f,-0.383109f,-0.1480981f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.152061f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.255682f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095849f,1.309639f,0.1329944f,-0.7030836f,-0.01447481f,-0.009604027f,0.7108951f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.287192f);
Get(0x6E70).SetLocalPose(0.06447942f,1.584983f,-0.1418305f,0.3394885f,-0.4002577f,-0.6021531f,0.6016254f);
Get(0x6E82).SetLocalPose(0.2344205f,1.560989f,0.4257298f,0.4118543f,-0.3654339f,0.6695885f,-0.4984831f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.03665846f);
Get(0x6EC6).SetLocalPose(0.307956f,1.30336f,-0.07426169f,-0.1363597f,-0.8779288f,-0.4479335f,-0.1000134f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.096063f,1.30962f,0.1329114f,-0.7030901f,-0.01450878f,-0.009553777f,0.7108886f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.346897f);
Get(0x6E70).SetLocalPose(0.05934492f,1.565049f,-0.1213788f,0.3487828f,-0.3948757f,-0.5978072f,0.6041939f);
Get(0x6E82).SetLocalPose(0.2308901f,1.55564f,0.4388771f,0.4410522f,-0.3317627f,0.7197832f,-0.4210922f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0f);
Get(0x6EC6).SetLocalPose(0.2985215f,1.267194f,-0.06360963f,-0.11629f,-0.8712819f,-0.4725386f,-0.06365418f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.096095f,1.309639f,0.1329373f,-0.703085f,-0.01442115f,-0.009617325f,0.7108946f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.408773f);
Get(0x6E70).SetLocalPose(0.05256831f,1.543597f,-0.09666725f,0.3598964f,-0.3887568f,-0.5936847f,0.6057072f);
Get(0x6E82).SetLocalPose(0.2474121f,1.544853f,0.4358064f,0.619776f,-0.2987566f,0.5548388f,-0.4677353f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.061876f);
Get(0x6EC6).SetLocalPose(0.2892635f,1.226554f,-0.05341845f,-0.1072996f,-0.8552446f,-0.504391f,-0.0513149f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095819f,1.309803f,0.1332407f,-0.7030795f,-0.01447284f,-0.009598457f,0.7108992f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.466676f);
Get(0x6E70).SetLocalPose(0.04597545f,1.529007f,-0.07488537f,0.3660901f,-0.3864974f,-0.5950338f,0.6021069f);
Get(0x6E82).SetLocalPose(0.2521214f,1.524927f,0.4193954f,0.6815617f,-0.3936424f,0.3103944f,-0.5330803f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.1197794f);
Get(0x6EC6).SetLocalPose(0.2824134f,1.1924f,-0.04734616f,-0.1213277f,-0.839585f,-0.5267326f,-0.05412453f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09565f,1.309833f,0.1333219f,-0.7030907f,-0.01448244f,-0.009556569f,0.7108884f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.523839f);
Get(0x6E70).SetLocalPose(0.03729821f,1.516772f,-0.05039509f,0.3724651f,-0.3859433f,-0.5993907f,0.5941787f);
Get(0x6E82).SetLocalPose(0.2516499f,1.473063f,0.3812357f,0.6425008f,-0.5394581f,0.1297005f,-0.5285409f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.1769422f);
Get(0x6EC6).SetLocalPose(0.2751162f,1.157499f,-0.04363844f,-0.1456666f,-0.8260685f,-0.5411748f,-0.05934704f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095463f,1.309495f,0.1334075f,-0.7030967f,-0.01450562f,-0.009588225f,0.7108817f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.583489f);
Get(0x6E70).SetLocalPose(0.02572072f,1.507371f,-0.02061981f,0.3816309f,-0.3861241f,-0.6043198f,0.5831499f);
Get(0x6E82).SetLocalPose(0.2372966f,1.415831f,0.3277265f,0.6164215f,-0.6548296f,0.07452289f,-0.4308935f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.2365926f);
Get(0x6EC6).SetLocalPose(0.2665676f,1.118934f,-0.04055024f,-0.1773197f,-0.8063536f,-0.5608501f,-0.06163466f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095519f,1.309492f,0.1332685f,-0.7030819f,-0.01446249f,-0.009619098f,0.7108968f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.644801f);
Get(0x6E70).SetLocalPose(0.01259328f,1.503088f,0.008109367f,0.3929002f,-0.3856372f,-0.6051363f,0.5750857f);
Get(0x6E82).SetLocalPose(0.1911621f,1.339191f,0.2566218f,0.6347059f,-0.7180289f,0.03933107f,-0.2829064f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.297904f);
Get(0x6EC6).SetLocalPose(0.2586078f,1.084714f,-0.03784942f,-0.2133549f,-0.782249f,-0.5827319f,-0.05467921f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.644801f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.297904f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095405f,1.309781f,0.1334288f,-0.7030904f,-0.01451888f,-0.009554145f,0.7108881f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.777321f);
Get(0x6E70).SetLocalPose(-0.02971473f,1.506999f,0.08366041f,0.4309475f,-0.3863388f,-0.5894307f,0.5635584f);
Get(0x6E82).SetLocalPose(0.06281874f,1.23374f,0.1745614f,0.6550561f,-0.7385453f,-0.01092933f,-0.1591633f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.4304243f);
Get(0x6EC6).SetLocalPose(0.2429049f,1.000607f,-0.03624312f,-0.3637857f,-0.6904494f,-0.6252172f,-0.006560533f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095585f,1.309913f,0.133344f,-0.7030861f,-0.01451532f,-0.009560302f,0.7108923f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.83673f);
Get(0x6E70).SetLocalPose(-0.05800799f,1.517527f,0.122994f,0.45267f,-0.3947254f,-0.5729477f,0.5576853f);
Get(0x6E82).SetLocalPose(0.001672079f,1.214103f,0.1639435f,0.6970366f,-0.6713636f,-0.09587412f,-0.2328501f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.4898329f);
Get(0x6EC6).SetLocalPose(0.2372209f,0.9670218f,-0.03771345f,-0.4534924f,-0.6351018f,-0.625181f,0.01179583f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095692f,1.309935f,0.1336046f,-0.7030748f,-0.0144949f,-0.009566733f,0.7109039f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.898789f);
Get(0x6E70).SetLocalPose(-0.08432767f,1.530481f,0.1559418f,0.4666587f,-0.4077092f,-0.5578742f,0.5520682f);
Get(0x6E82).SetLocalPose(-0.05009043f,1.206149f,0.1831467f,0.6846917f,-0.5931424f,-0.1606552f,-0.3918793f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.5518923f);
Get(0x6EC6).SetLocalPose(0.2346759f,0.9276001f,-0.03161465f,-0.5338108f,-0.5233884f,-0.6641212f,0.007327097f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095474f,1.309724f,0.1334566f,-0.7030684f,-0.01444484f,-0.009593165f,0.7109109f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0f);
Get(0x6E70).SetLocalPose(-0.1181236f,1.549272f,0.1936423f,0.4793552f,-0.4231424f,-0.5408672f,0.5464722f);
Get(0x6E82).SetLocalPose(-0.08078786f,1.202813f,0.2048722f,0.6564705f,-0.5677947f,-0.1276343f,-0.4799637f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.6104311f);
Get(0x6EC6).SetLocalPose(0.2419983f,0.9061892f,-0.01758315f,-0.546492f,-0.4136345f,-0.7281232f,0.009466183f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095542f,1.309572f,0.1332818f,-0.7030989f,-0.01446497f,-0.00956937f,0.7108805f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.06162985f);
Get(0x6E70).SetLocalPose(-0.1554832f,1.567914f,0.2295466f,0.4907917f,-0.4384161f,-0.5203515f,0.5441959f);
Get(0x6E82).SetLocalPose(-0.1304843f,1.210387f,0.231424f,0.669658f,-0.498435f,-0.06700929f,-0.546471f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0f);
Get(0x6EC6).SetLocalPose(0.2636761f,0.9141971f,0.005823991f,-0.5074239f,-0.3783731f,-0.7705646f,0.0747334f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095496f,1.309489f,0.133109f,-0.7030959f,-0.01446127f,-0.009574471f,0.7108835f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.03245508f);
Get(0x6E70).SetLocalPose(-0.1959949f,1.582219f,0.2619663f,0.501716f,-0.4576535f,-0.4922256f,0.5445624f);
Get(0x6E82).SetLocalPose(-0.1802557f,1.231153f,0.2499309f,0.6824696f,-0.3970268f,-0.02041095f,-0.6133419f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.06103477f);
Get(0x6EC6).SetLocalPose(0.3182627f,0.9448795f,0.06228434f,-0.4715459f,-0.3284293f,-0.8060151f,0.1418397f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095348f,1.30942f,0.1330373f,-0.7030872f,-0.01443407f,-0.009606417f,0.7108923f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.061292f);
Get(0x6E70).SetLocalPose(-0.2164864f,1.586977f,0.2761756f,0.5072158f,-0.4698344f,-0.4756639f,0.5438122f);
Get(0x6E82).SetLocalPose(-0.2115f,1.245367f,0.2606369f,0.6995893f,-0.3184699f,0.002123372f,-0.6396464f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.08987169f);
Get(0x6EC6).SetLocalPose(0.350029f,0.9634965f,0.09717525f,-0.473248f,-0.3130665f,-0.8069398f,0.1639326f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095284f,1.309766f,0.1332263f,-0.7030855f,-0.01442442f,-0.009599234f,0.7108943f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.1642911f);
Get(0x6E70).SetLocalPose(-0.276592f,1.592352f,0.3106939f,0.5264587f,-0.5097418f,-0.4344299f,0.523713f);
Get(0x6E82).SetLocalPose(-0.2900748f,1.261866f,0.2847012f,0.7369909f,-0.1427609f,0.08146541f,-0.6556121f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.1928708f);
Get(0x6EC6).SetLocalPose(0.4493688f,1.053613f,0.2779849f,-0.3658285f,-0.296778f,-0.8359188f,0.2816594f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095178f,1.309661f,0.1332118f,-0.7030761f,-0.01440515f,-0.009612326f,0.7109038f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.1977326f);
Get(0x6E70).SetLocalPose(-0.3016121f,1.591803f,0.3227509f,0.5395991f,-0.5240539f,-0.4238305f,0.5045474f);
Get(0x6E82).SetLocalPose(-0.3123234f,1.261252f,0.2923317f,0.7283243f,-0.105757f,0.09205457f,-0.6707348f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.2263123f);
Get(0x6EC6).SetLocalPose(0.4704826f,1.106016f,0.3713358f,-0.2902666f,-0.3176288f,-0.8442804f,0.3194495f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095378f,1.309738f,0.1332552f,-0.7030937f,-0.01445896f,-0.009545588f,0.7108862f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.2667289f);
Get(0x6E70).SetLocalPose(-0.3336388f,1.5858f,0.3386251f,0.5639629f,-0.5393163f,-0.4094369f,0.4726999f);
Get(0x6E82).SetLocalPose(-0.353466f,1.253804f,0.311528f,0.6944538f,-0.04565695f,0.08339024f,-0.7132289f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.2953086f);
Get(0x6EC6).SetLocalPose(0.4620325f,1.222272f,0.54546f,-0.13186f,-0.3951692f,-0.8134026f,0.4059932f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095263f,1.309655f,0.1330134f,-0.7030914f,-0.01444724f,-0.00950931f,0.7108892f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.3275735f);
Get(0x6E70).SetLocalPose(-0.3557925f,1.577745f,0.3524384f,0.5841693f,-0.5511898f,-0.3901989f,0.450201f);
Get(0x6E82).SetLocalPose(-0.379555f,1.244146f,0.3251489f,0.6784882f,-0.01531936f,0.07855875f,-0.7302381f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.3561532f);
Get(0x6EC6).SetLocalPose(0.4065859f,1.341969f,0.6934349f,-0.09441634f,-0.5090246f,-0.7504431f,0.4108707f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095405f,1.309548f,0.1331421f,-0.7030657f,-0.0144261f,-0.009571658f,0.7109142f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.3869899f);
Get(0x6E70).SetLocalPose(-0.3720116f,1.565897f,0.3679004f,0.5972176f,-0.5650443f,-0.3669135f,0.4352364f);
Get(0x6E82).SetLocalPose(-0.3918386f,1.234621f,0.3384269f,0.6806076f,0.007029796f,0.09395861f,-0.7265643f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.4155696f);
Get(0x6EC6).SetLocalPose(0.2843964f,1.470111f,0.8332736f,-0.1015651f,-0.6959302f,-0.6548404f,0.2766764f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095497f,1.309237f,0.1331528f,-0.703054f,-0.01442969f,-0.009555956f,0.7109259f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.4478191f);
Get(0x6E70).SetLocalPose(-0.3798888f,1.554026f,0.3809441f,0.6062519f,-0.5740692f,-0.3496314f,0.4250424f);
Get(0x6E82).SetLocalPose(-0.3989756f,1.223894f,0.3541369f,0.7005671f,0.0425836f,0.1084581f,-0.7040095f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.4763988f);
Get(0x6EC6).SetLocalPose(0.1053991f,1.564049f,0.9285743f,0.01599194f,-0.787151f,-0.5989367f,0.1463299f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09524f,1.309336f,0.1330307f,-0.7030913f,-0.01442866f,-0.009594972f,0.7108884f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.5347569f);
Get(0x6E70).SetLocalPose(-0.3864889f,1.530963f,0.4107052f,0.6280074f,-0.5747123f,-0.3333271f,0.4052228f);
Get(0x6E82).SetLocalPose(-0.3998501f,1.215868f,0.3780913f,0.7311091f,0.05707593f,0.06026316f,-0.677193f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.5633367f);
Get(0x6EC6).SetLocalPose(-0.1398186f,1.604723f,0.9613075f,0.1940553f,-0.8219542f,-0.5352299f,0.01621435f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.5347569f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.5633367f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095565f,1.309821f,0.1331708f,-0.7030751f,-0.01447648f,-0.009565685f,0.7109039f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.6366206f);
Get(0x6E70).SetLocalPose(-0.3901894f,1.512016f,0.4498569f,0.6389902f,-0.5667694f,-0.3424874f,0.3913648f);
Get(0x6E82).SetLocalPose(-0.394279f,1.21251f,0.4180967f,0.7677631f,0.0341051f,-0.02823868f,-0.6392021f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.6652004f);
Get(0x6EC6).SetLocalPose(-0.4090102f,1.552061f,0.8968435f,0.3547507f,-0.8022379f,-0.460575f,-0.1357829f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095444f,1.309594f,0.1331071f,-0.7030681f,-0.01443341f,-0.00956943f,0.7109118f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.7062591f);
Get(0x6E70).SetLocalPose(-0.3919262f,1.507636f,0.4685706f,0.6415589f,-0.561192f,-0.3528709f,0.3859377f);
Get(0x6E82).SetLocalPose(-0.3880591f,1.218721f,0.4410202f,0.7911403f,0.01067124f,-0.03480742f,-0.6105503f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.7348388f);
Get(0x6EC6).SetLocalPose(-0.5356308f,1.481667f,0.820743f,0.4093119f,-0.7530808f,-0.4421447f,-0.2642749f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095385f,1.309504f,0.1331667f,-0.7030634f,-0.01437219f,-0.009612887f,0.7109169f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.7688335f);
Get(0x6E70).SetLocalPose(-0.3946927f,1.508251f,0.4888522f,0.6418893f,-0.554068f,-0.3689605f,0.3805983f);
Get(0x6E82).SetLocalPose(-0.3818146f,1.22861f,0.4598345f,0.8065562f,-0.001272386f,-0.02972826f,-0.5904083f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.7974133f);
Get(0x6EC6).SetLocalPose(-0.6235403f,1.396631f,0.7283192f,0.5208604f,-0.6609405f,-0.4288571f,-0.3285481f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095302f,1.309479f,0.1332195f,-0.7030774f,-0.01444834f,-0.009576174f,0.7109021f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.8309123f);
Get(0x6E70).SetLocalPose(-0.3976032f,1.512693f,0.5067786f,0.6381847f,-0.5474234f,-0.3888006f,0.3766724f);
Get(0x6E82).SetLocalPose(-0.3761789f,1.242725f,0.4766134f,0.815922f,-0.01546711f,-0.02819111f,-0.5772671f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.8594921f);
Get(0x6EC6).SetLocalPose(-0.6603153f,1.302913f,0.6273339f,0.646503f,-0.5880247f,-0.3671635f,-0.3185151f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095223f,1.30934f,0.1330517f,-0.7030785f,-0.01448959f,-0.009610835f,0.7108997f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.8953184f);
Get(0x6E70).SetLocalPose(-0.4009757f,1.522594f,0.5220731f,0.6321177f,-0.5402148f,-0.4090033f,0.3759143f);
Get(0x6E82).SetLocalPose(-0.3701738f,1.260243f,0.4872026f,0.8265589f,-0.03412355f,-0.0225801f,-0.561361f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.9238982f);
Get(0x6EC6).SetLocalPose(-0.6632161f,1.222268f,0.5434332f,0.6910628f,-0.5602776f,-0.3076689f,-0.3374332f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095468f,1.30952f,0.1331344f,-0.7030848f,-0.01438875f,-0.009641424f,0.7108951f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.9568939f);
Get(0x6E70).SetLocalPose(-0.4034526f,1.531014f,0.5323939f,0.6257611f,-0.5359903f,-0.4206997f,0.3796699f);
Get(0x6E82).SetLocalPose(-0.3676353f,1.279075f,0.4933458f,0.835054f,-0.04801328f,-0.01721058f,-0.5477986f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.9854736f);
Get(0x6EC6).SetLocalPose(-0.6559653f,1.176646f,0.5067854f,0.6899244f,-0.524877f,-0.3147784f,-0.3865528f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095075f,1.309442f,0.1328532f,-0.7030316f,-0.01432916f,-0.00970007f,0.7109481f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.019546f);
Get(0x6E70).SetLocalPose(-0.405913f,1.543328f,0.5398393f,0.6171754f,-0.5354044f,-0.4278018f,0.3865518f);
Get(0x6E82).SetLocalPose(-0.368798f,1.296526f,0.497149f,0.8351996f,-0.05933332f,-0.03928061f,-0.545324f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.048125f);
Get(0x6EC6).SetLocalPose(-0.6307214f,1.13751f,0.4867745f,0.6711081f,-0.4864518f,-0.3592218f,-0.4288803f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.019546f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.048125f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095368f,1.31002f,0.132874f,-0.7030749f,-0.01455296f,-0.009545806f,0.7109028f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0f);
Get(0x6E70).SetLocalPose(-0.4069723f,1.569954f,0.5453897f,0.6037299f,-0.5400196f,-0.4295407f,0.399229f);
Get(0x6E82).SetLocalPose(-0.3786045f,1.320075f,0.5003195f,0.840353f,-0.02786735f,-0.08628166f,-0.5344022f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.149178f);
Get(0x6EC6).SetLocalPose(-0.5903015f,1.085165f,0.507834f,0.5894098f,-0.4557307f,-0.4790689f,-0.4641106f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095703f,1.310102f,0.1328745f,-0.7030742f,-0.01444743f,-0.009630247f,0.7109045f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.06990677f);
Get(0x6E70).SetLocalPose(-0.4049454f,1.580823f,0.5450469f,0.5999625f,-0.5415608f,-0.4263796f,0.4061494f);
Get(0x6E82).SetLocalPose(-0.3859508f,1.333525f,0.5034156f,0.8388659f,0.0005442611f,-0.1158916f,-0.5318579f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.219085f);
Get(0x6EC6).SetLocalPose(-0.5563591f,1.059211f,0.5455115f,0.520102f,-0.4434131f,-0.5662054f,-0.4607497f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095301f,1.309563f,0.133035f,-0.7030302f,-0.01438147f,-0.009685123f,0.7109486f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.1301985f);
Get(0x6E70).SetLocalPose(-0.3995257f,1.593737f,0.5418285f,0.5950546f,-0.5428424f,-0.4226116f,0.4154896f);
Get(0x6E82).SetLocalPose(-0.3902943f,1.340334f,0.5065339f,0.8364516f,0.007442165f,-0.1340996f,-0.5313292f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.279377f);
Get(0x6EC6).SetLocalPose(-0.5101323f,1.045424f,0.5937154f,0.4258257f,-0.4595851f,-0.6416193f,-0.4424689f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095065f,1.309363f,0.1329845f,-0.7030393f,-0.01449038f,-0.00953252f,0.7109394f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.1898532f);
Get(0x6E70).SetLocalPose(-0.3931181f,1.604965f,0.5380504f,0.5886478f,-0.5440134f,-0.4232633f,0.4223641f);
Get(0x6E82).SetLocalPose(-0.3936143f,1.351942f,0.5121018f,0.8304548f,0.003663525f,-0.1535797f,-0.5354854f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.339031f);
Get(0x6EC6).SetLocalPose(-0.4713025f,1.045142f,0.630946f,0.3519501f,-0.4771658f,-0.6853249f,-0.4228165f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095264f,1.309574f,0.1330791f,-0.703055f,-0.01449514f,-0.009558849f,0.7109235f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.2536858f);
Get(0x6E70).SetLocalPose(-0.3825533f,1.618861f,0.5315396f,0.5775042f,-0.5455313f,-0.4287274f,0.4302063f);
Get(0x6E82).SetLocalPose(-0.3932111f,1.361622f,0.5186801f,0.8283018f,-0.002710729f,-0.1623506f,-0.536238f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.402864f);
Get(0x6EC6).SetLocalPose(-0.4080035f,1.057118f,0.6824445f,0.2584061f,-0.5189278f,-0.7152118f,-0.3904003f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09549f,1.309768f,0.1331301f,-0.703037f,-0.01441938f,-0.009612414f,0.7109421f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.3141692f);
Get(0x6E70).SetLocalPose(-0.3715098f,1.629665f,0.5242848f,0.5656573f,-0.5463846f,-0.4348528f,0.4386329f);
Get(0x6E82).SetLocalPose(-0.391559f,1.370259f,0.5239558f,0.8377663f,0.00279871f,-0.1585739f,-0.5224885f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.463347f);
Get(0x6EC6).SetLocalPose(-0.3568355f,1.071996f,0.7156189f,0.2032573f,-0.5630051f,-0.7125078f,-0.3661208f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095774f,1.309692f,0.1333383f,-0.7030498f,-0.01444596f,-0.009561284f,0.7109296f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.3767889f);
Get(0x6E70).SetLocalPose(-0.3602187f,1.636711f,0.5155155f,0.5529611f,-0.5469715f,-0.4406765f,0.4481747f);
Get(0x6E82).SetLocalPose(-0.3876065f,1.378538f,0.5284714f,0.8531795f,0.01410342f,-0.1502327f,-0.4993155f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.525967f);
Get(0x6EC6).SetLocalPose(-0.3073692f,1.103808f,0.7443081f,0.1501224f,-0.6142395f,-0.693875f,-0.3445442f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.3767889f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.525967f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.096068f,1.309992f,0.1330475f,-0.7030743f,-0.01450769f,-0.009508594f,0.7109048f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.5122557f);
Get(0x6E70).SetLocalPose(-0.3327344f,1.647254f,0.4928858f,0.5260139f,-0.5483713f,-0.4493358f,0.4697825f);
Get(0x6E82).SetLocalPose(-0.3696455f,1.3938f,0.5414329f,0.8767558f,0.0123207f,-0.1489061f,-0.4571373f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.661434f);
Get(0x6EC6).SetLocalPose(-0.202782f,1.193639f,0.7820582f,0.04892427f,-0.7194604f,-0.6144097f,-0.3201311f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.096069f,1.309808f,0.1329964f,-0.703076f,-0.01444166f,-0.009552622f,0.7109039f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0f);
Get(0x6E70).SetLocalPose(-0.319907f,1.648977f,0.4801597f,0.5147785f,-0.5479844f,-0.4516146f,0.4803753f);
Get(0x6E82).SetLocalPose(-0.3587368f,1.400506f,0.5502461f,0.8814452f,0.006608522f,-0.1531273f,-0.4467244f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.722942f);
Get(0x6EC6).SetLocalPose(-0.16158f,1.238648f,0.7853184f,0.01619924f,-0.7649454f,-0.5641893f,-0.3103009f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095796f,1.30974f,0.1329253f,-0.7030551f,-0.01446042f,-0.009555765f,0.7109243f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.05928708f);
Get(0x6E70).SetLocalPose(-0.3109959f,1.648325f,0.4711794f,0.5081453f,-0.5468999f,-0.4529758f,0.4873415f);
Get(0x6E82).SetLocalPose(-0.3477927f,1.40552f,0.5579454f,0.8862065f,-0.001367818f,-0.1600704f,-0.4347569f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.782229f);
Get(0x6EC6).SetLocalPose(-0.1303386f,1.279821f,0.7775096f,-0.01156805f,-0.7958437f,-0.5143498f,-0.319286f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095541f,1.309642f,0.1329831f,-0.703065f,-0.01447741f,-0.009526824f,0.7109144f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.1178535f);
Get(0x6E70).SetLocalPose(-0.2947315f,1.64413f,0.4532087f,0.4986965f,-0.5432381f,-0.4567247f,0.4975909f);
Get(0x6E82).SetLocalPose(-0.3351153f,1.412055f,0.5648842f,0.8940347f,-0.003599359f,-0.167065f,-0.4156663f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.840796f);
Get(0x6EC6).SetLocalPose(-0.09660871f,1.321228f,0.7630302f,-0.04070914f,-0.8202326f,-0.4563354f,-0.3425188f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095442f,1.309726f,0.1328047f,-0.7030934f,-0.01444756f,-0.009548086f,0.7108867f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.1754243f);
Get(0x6E70).SetLocalPose(-0.2832242f,1.639897f,0.4409273f,0.4938801f,-0.5400597f,-0.4601038f,0.502715f);
Get(0x6E82).SetLocalPose(-0.3235573f,1.418028f,0.5698714f,0.8965245f,0.001723049f,-0.1817124f,-0.4040068f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.898367f);
Get(0x6EC6).SetLocalPose(-0.07599905f,1.352713f,0.744339f,-0.05160176f,-0.8395126f,-0.4060537f,-0.357318f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095069f,1.309597f,0.1328381f,-0.7030709f,-0.01439151f,-0.009607201f,0.7109092f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.2340655f);
Get(0x6E70).SetLocalPose(-0.2704947f,1.634546f,0.4280865f,0.4896228f,-0.5365099f,-0.462974f,0.5080175f);
Get(0x6E82).SetLocalPose(-0.3092859f,1.426787f,0.5731354f,0.8946594f,0.002225521f,-0.2061634f,-0.3963286f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.957008f);
Get(0x6EC6).SetLocalPose(-0.05423247f,1.388174f,0.7171238f,-0.05243125f,-0.8629259f,-0.3458244f,-0.3647125f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094883f,1.309616f,0.13282f,-0.7030469f,-0.01434786f,-0.009591776f,0.7109341f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.2940806f);
Get(0x6E70).SetLocalPose(-0.2591863f,1.630231f,0.416748f,0.4869686f,-0.5333152f,-0.4633767f,0.5135354f);
Get(0x6E82).SetLocalPose(-0.292991f,1.438665f,0.5709745f,0.8974922f,-0.0009456187f,-0.2266443f,-0.3783375f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.017023f);
Get(0x6EC6).SetLocalPose(-0.03637499f,1.418772f,0.6851826f,-0.03464717f,-0.8779359f,-0.2806645f,-0.386336f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.2940806f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.017023f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094907f,1.309149f,0.1326515f,-0.7030783f,-0.01439641f,-0.009617742f,0.7109016f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.4278597f);
Get(0x6E70).SetLocalPose(-0.2321517f,1.628803f,0.3926997f,0.4814888f,-0.5287547f,-0.4632152f,0.5234678f);
Get(0x6E82).SetLocalPose(-0.2626083f,1.466494f,0.5455353f,0.9089452f,-0.01011612f,-0.2754062f,-0.3128383f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.03601169f);
Get(0x6EC6).SetLocalPose(-0.002546782f,1.467726f,0.6125716f,0.01177744f,-0.8700463f,-0.1699087f,-0.4626143f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094969f,1.3092f,0.1326224f,-0.7030714f,-0.01434005f,-0.009639309f,0.7109094f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.4864086f);
Get(0x6E70).SetLocalPose(-0.2205605f,1.633827f,0.3829037f,0.4797294f,-0.5270228f,-0.4657021f,0.524622f);
Get(0x6E82).SetLocalPose(-0.2536002f,1.476422f,0.5346761f,0.9033476f,-0.01872212f,-0.295353f,-0.3104501f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.09456061f);
Get(0x6EC6).SetLocalPose(0.009202662f,1.4861f,0.5803669f,0.02973169f,-0.8645664f,-0.1320739f,-0.4839395f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095196f,1.309147f,0.1326781f,-0.703019f,-0.01429441f,-0.009639063f,0.7109621f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.5479584f);
Get(0x6E70).SetLocalPose(-0.2112872f,1.640622f,0.3741805f,0.4793697f,-0.5240614f,-0.4685724f,0.5253611f);
Get(0x6E82).SetLocalPose(-0.2397389f,1.491678f,0.517881f,0.9010265f,-0.05226199f,-0.3326218f,-0.2734643f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.1561105f);
Get(0x6EC6).SetLocalPose(0.01821617f,1.498605f,0.554345f,0.04364411f,-0.8624805f,-0.09987657f,-0.4942138f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095283f,1.308873f,0.1328192f,-0.7030608f,-0.01437514f,-0.00961423f,0.7109194f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.6087978f);
Get(0x6E70).SetLocalPose(-0.2015299f,1.651373f,0.3641693f,0.4789347f,-0.5195802f,-0.4734983f,0.5257922f);
Get(0x6E82).SetLocalPose(-0.2263924f,1.50316f,0.5019615f,0.9037498f,-0.05796054f,-0.3431687f,-0.2492232f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.2169498f);
Get(0x6EC6).SetLocalPose(0.0274221f,1.513861f,0.5244606f,0.05323275f,-0.8594677f,-0.06835578f,-0.5037947f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095479f,1.309075f,0.1328807f,-0.7030776f,-0.0143704f,-0.009630789f,0.7109028f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.6694399f);
Get(0x6E70).SetLocalPose(-0.1940126f,1.662621f,0.356365f,0.4775863f,-0.5157367f,-0.4791232f,0.5257071f);
Get(0x6E82).SetLocalPose(-0.2107864f,1.518001f,0.4830696f,0.9078165f,-0.0630476f,-0.3496445f,-0.2228069f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.277592f);
Get(0x6EC6).SetLocalPose(0.03286502f,1.527649f,0.5004463f,0.05123153f,-0.8553874f,-0.05482434f,-0.5125252f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095504f,1.309286f,0.1329848f,-0.7030841f,-0.01438118f,-0.009672267f,0.7108955f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.7286159f);
Get(0x6E70).SetLocalPose(-0.1864459f,1.678558f,0.348133f,0.4743682f,-0.5114326f,-0.4860907f,0.5264289f);
Get(0x6E82).SetLocalPose(-0.2017089f,1.527147f,0.4719521f,0.9077538f,-0.06442752f,-0.3567167f,-0.2111526f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.336768f);
Get(0x6EC6).SetLocalPose(0.03942503f,1.538017f,0.4835728f,0.03901415f,-0.849643f,-0.05588806f,-0.5229352f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09543f,1.309436f,0.1331593f,-0.7030782f,-0.01436837f,-0.009665556f,0.7109017f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.7553095f);
Get(0x6E70).SetLocalPose(-0.1828693f,1.686969f,0.3440092f,0.4720772f,-0.5092501f,-0.489525f,0.5274209f);
Get(0x6E82).SetLocalPose(-0.1936991f,1.537298f,0.4633605f,0.9034422f,-0.06117348f,-0.3696785f,-0.2082974f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.3634615f);
Get(0x6EC6).SetLocalPose(0.04153717f,1.544135f,0.4751186f,0.03236773f,-0.8454638f,-0.06126707f,-0.5295183f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095413f,1.309384f,0.1330198f,-0.7030842f,-0.0144333f,-0.00962578f,0.710895f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.8596187f);
Get(0x6E70).SetLocalPose(-0.1722155f,1.71569f,0.331666f,0.4615229f,-0.5032242f,-0.4994098f,0.5332465f);
Get(0x6E82).SetLocalPose(-0.1755362f,1.560752f,0.4470464f,0.8782651f,-0.0716818f,-0.4161382f,-0.2243685f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.4677708f);
Get(0x6EC6).SetLocalPose(0.04620599f,1.558448f,0.4473331f,0.01274666f,-0.8385594f,-0.08217409f,-0.5384265f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095476f,1.309466f,0.1330711f,-0.7030826f,-0.01440886f,-0.009646301f,0.7108968f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.926846f);
Get(0x6E70).SetLocalPose(-0.1659688f,1.731868f,0.3229816f,0.4530144f,-0.5003766f,-0.5038721f,0.5389937f);
Get(0x6E82).SetLocalPose(-0.1659667f,1.569719f,0.4386221f,0.8645096f,-0.08320983f,-0.4376976f,-0.2326373f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.5349981f);
Get(0x6EC6).SetLocalPose(0.04677073f,1.56363f,0.4311018f,0.00444379f,-0.8401755f,-0.0903794f,-0.5347121f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095037f,1.309435f,0.133026f,-0.7030863f,-0.0143718f,-0.009668775f,0.7108936f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.9866645f);
Get(0x6E70).SetLocalPose(-0.1590825f,1.743874f,0.3120011f,0.4431984f,-0.4976667f,-0.5055966f,0.5479738f);
Get(0x6E82).SetLocalPose(-0.1562088f,1.575712f,0.4281315f,0.8519711f,-0.09209251f,-0.4585492f,-0.2353651f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.5948166f);
Get(0x6EC6).SetLocalPose(0.04786296f,1.565032f,0.4151992f,-0.001433017f,-0.8400513f,-0.09803624f,-0.5335735f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09498f,1.309457f,0.1330433f,-0.7030483f,-0.01441897f,-0.009620885f,0.7109308f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.045775f);
Get(0x6E70).SetLocalPose(-0.1533754f,1.746999f,0.3013213f,0.4378715f,-0.4926911f,-0.5053194f,0.5569348f);
Get(0x6E82).SetLocalPose(-0.1472812f,1.575409f,0.418336f,0.8405516f,-0.09865363f,-0.4764397f,-0.2382139f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.6539273f);
Get(0x6EC6).SetLocalPose(0.04942571f,1.561359f,0.3993388f,-0.00872934f,-0.8350231f,-0.1068377f,-0.5396721f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094918f,1.309611f,0.1330951f,-0.7030798f,-0.0144119f,-0.0096245f,0.7108998f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.106916f);
Get(0x6E70).SetLocalPose(-0.1486803f,1.745769f,0.290864f,0.4361402f,-0.4870356f,-0.505901f,0.5627098f);
Get(0x6E82).SetLocalPose(-0.1368752f,1.573251f,0.4061411f,0.8210119f,-0.1041872f,-0.5038042f,-0.2475195f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.7150679f);
Get(0x6EC6).SetLocalPose(0.05033965f,1.556357f,0.3838493f,-0.01571129f,-0.8284906f,-0.1157076f,-0.5476937f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094964f,1.309245f,0.1330908f,-0.7030786f,-0.01436359f,-0.009634852f,0.7109018f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.164607f);
Get(0x6E70).SetLocalPose(-0.143138f,1.741464f,0.278948f,0.434179f,-0.4818856f,-0.5088502f,0.5659916f);
Get(0x6E82).SetLocalPose(-0.1301083f,1.56985f,0.3998649f,0.8075072f,-0.1056574f,-0.520552f,-0.2565041f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.7727587f);
Get(0x6EC6).SetLocalPose(0.05108441f,1.54993f,0.370561f,-0.01830277f,-0.8269026f,-0.1210771f,-0.548851f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095051f,1.309309f,0.1331562f,-0.7030724f,-0.0144216f,-0.009634797f,0.7109068f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.226454f);
Get(0x6E70).SetLocalPose(-0.1375283f,1.735687f,0.2660975f,0.4298487f,-0.4789249f,-0.5153071f,0.5659679f);
Get(0x6E82).SetLocalPose(-0.1218113f,1.56234f,0.390121f,0.7925104f,-0.1006968f,-0.5396f,-0.265743f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.8346064f);
Get(0x6EC6).SetLocalPose(0.05167476f,1.539705f,0.3557462f,-0.01782546f,-0.8306487f,-0.1235573f,-0.5426219f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.226454f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.8346064f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095158f,1.309431f,0.1333047f,-0.7030737f,-0.01441153f,-0.00967207f,0.7109051f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.363571f);
Get(0x6E70).SetLocalPose(-0.1236583f,1.710191f,0.235808f,0.4191799f,-0.4731657f,-0.5302922f,0.5649714f);
Get(0x6E82).SetLocalPose(-0.1053524f,1.537412f,0.3674989f,0.7679976f,-0.08605364f,-0.5685058f,-0.2820916f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.9717233f);
Get(0x6EC6).SetLocalPose(0.05592462f,1.509879f,0.3260782f,-0.03021682f,-0.8339328f,-0.1269026f,-0.5362264f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095141f,1.3096f,0.1333926f,-0.7031077f,-0.01440709f,-0.009671276f,0.7108716f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.422557f);
Get(0x6E70).SetLocalPose(-0.1178993f,1.697433f,0.2230352f,0.4163261f,-0.4708804f,-0.5347224f,0.5648152f);
Get(0x6E82).SetLocalPose(-0.09800416f,1.521931f,0.3567477f,0.7592492f,-0.07257097f,-0.5787971f,-0.2885622f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.03071f);
Get(0x6EC6).SetLocalPose(0.05821472f,1.492813f,0.3128292f,-0.0412088f,-0.8356407f,-0.1292188f,-0.5322676f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09512f,1.309665f,0.1334411f,-0.7030965f,-0.0143678f,-0.009646175f,0.7108839f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.48211f);
Get(0x6E70).SetLocalPose(-0.1107784f,1.683532f,0.2094548f,0.4140184f,-0.4690228f,-0.5387889f,0.5641924f);
Get(0x6E82).SetLocalPose(-0.0902092f,1.505723f,0.3464522f,0.7544486f,-0.05778104f,-0.58241f,-0.2970982f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.090262f);
Get(0x6EC6).SetLocalPose(0.06006024f,1.476779f,0.3016965f,-0.04467597f,-0.8410126f,-0.1354475f,-0.5218773f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094981f,1.309367f,0.1331224f,-0.7030709f,-0.01439557f,-0.009662339f,0.7109085f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.545411f);
Get(0x6E70).SetLocalPose(-0.1021093f,1.667766f,0.1934094f,0.4123878f,-0.4669673f,-0.5425375f,0.5634988f);
Get(0x6E82).SetLocalPose(-0.07932049f,1.489699f,0.3348243f,0.7519996f,-0.04193799f,-0.5795892f,-0.3111497f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.153563f);
Get(0x6EC6).SetLocalPose(0.06523082f,1.457953f,0.2889611f,-0.04288764f,-0.848092f,-0.1455111f,-0.5076683f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094647f,1.309191f,0.1330679f,-0.7030723f,-0.01436377f,-0.009688254f,0.7109073f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.607573f);
Get(0x6E70).SetLocalPose(-0.09329703f,1.654109f,0.179269f,0.4123322f,-0.4638857f,-0.5464266f,0.5623257f);
Get(0x6E82).SetLocalPose(-0.06693292f,1.469733f,0.3215607f,0.762737f,-0.02402245f,-0.5585251f,-0.3251231f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.215725f);
Get(0x6EC6).SetLocalPose(0.07335622f,1.4408f,0.2770008f,-0.05307023f,-0.8544248f,-0.1516122f,-0.494121f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09481f,1.309224f,0.1330607f,-0.7030746f,-0.01436692f,-0.009655442f,0.7109054f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.668344f);
Get(0x6E70).SetLocalPose(-0.08458827f,1.643244f,0.1663909f,0.4140836f,-0.4599113f,-0.5512826f,0.5595569f);
Get(0x6E82).SetLocalPose(-0.0550857f,1.449871f,0.3124188f,0.7677408f,-0.00272849f,-0.5404695f,-0.3441794f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.276496f);
Get(0x6EC6).SetLocalPose(0.08278921f,1.424048f,0.2677652f,-0.0760261f,-0.855976f,-0.1611249f,-0.4853492f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095066f,1.309392f,0.1332709f,-0.703073f,-0.01440339f,-0.009671943f,0.710906f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.69865f);
Get(0x6E70).SetLocalPose(-0.07713582f,1.63591f,0.1560128f,0.4165843f,-0.4561052f,-0.5559046f,0.5562336f);
Get(0x6E82).SetLocalPose(-0.04916978f,1.440563f,0.3075128f,0.7676254f,0.01141204f,-0.532725f,-0.3561254f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.306802f);
Get(0x6EC6).SetLocalPose(0.09033278f,1.413034f,0.2620516f,-0.09635256f,-0.8544081f,-0.170117f,-0.4814178f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.69865f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.306802f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095118f,1.309312f,0.1330785f,-0.7030644f,-0.01439206f,-0.009652303f,0.7109151f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.836755f);
Get(0x6E70).SetLocalPose(-0.05232883f,1.622172f,0.1260964f,0.4249091f,-0.4446108f,-0.569662f,0.5452144f);
Get(0x6E82).SetLocalPose(-0.01917442f,1.398724f,0.288781f,0.7729279f,0.05366264f,-0.4730177f,-0.4194725f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.444907f);
Get(0x6EC6).SetLocalPose(0.1175971f,1.37172f,0.2424931f,-0.1466972f,-0.8484629f,-0.2300567f,-0.4535025f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095152f,1.309517f,0.1329884f,-0.7030541f,-0.01443731f,-0.009650262f,0.7109244f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.898722f);
Get(0x6E70).SetLocalPose(-0.04093591f,1.617944f,0.1128909f,0.4284644f,-0.4398606f,-0.5732684f,0.5424982f);
Get(0x6E82).SetLocalPose(-0.004771511f,1.37633f,0.2766618f,0.771818f,0.0633581f,-0.4481936f,-0.4465481f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.506874f);
Get(0x6EC6).SetLocalPose(0.1279964f,1.357058f,0.2331538f,-0.1515891f,-0.8439719f,-0.2557271f,-0.4464706f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095371f,1.309461f,0.1329393f,-0.703063f,-0.01442575f,-0.009623453f,0.7109162f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.959616f);
Get(0x6E70).SetLocalPose(-0.02707526f,1.616266f,0.09804333f,0.431902f,-0.4346289f,-0.5776191f,0.539365f);
Get(0x6E82).SetLocalPose(0.002849889f,1.359853f,0.2648906f,0.761967f,0.08420923f,-0.4404394f,-0.4672562f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.567768f);
Get(0x6EC6).SetLocalPose(0.1390648f,1.340979f,0.2203762f,-0.1583953f,-0.8365312f,-0.2837516f,-0.441148f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095335f,1.309258f,0.1329013f,-0.7030805f,-0.01443838f,-0.009581343f,0.7108991f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.021649f);
Get(0x6E70).SetLocalPose(-0.01503679f,1.618677f,0.08525742f,0.4323754f,-0.4309929f,-0.5836942f,0.5353484f);
Get(0x6E82).SetLocalPose(0.01226608f,1.346637f,0.2519499f,0.7462049f,0.1008065f,-0.4373091f,-0.4917084f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.629801f);
Get(0x6EC6).SetLocalPose(0.1475093f,1.332511f,0.2087102f,-0.1678278f,-0.830623f,-0.3037236f,-0.4354898f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095052f,1.309291f,0.1329324f,-0.703056f,-0.01438699f,-0.009648605f,0.7109236f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.080975f);
Get(0x6E70).SetLocalPose(-0.003015674f,1.623591f,0.07251795f,0.4314163f,-0.4271423f,-0.5898596f,0.5324426f);
Get(0x6E82).SetLocalPose(0.02272771f,1.33845f,0.2363562f,0.7374529f,0.1028318f,-0.4321869f,-0.5087273f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.689127f);
Get(0x6EC6).SetLocalPose(0.1581855f,1.327202f,0.1915792f,-0.1777994f,-0.8250516f,-0.3279602f,-0.4244046f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095565f,1.309394f,0.133073f,-0.7030858f,-0.01437449f,-0.009610031f,0.7108948f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.143314f);
Get(0x6E70).SetLocalPose(0.007911153f,1.629357f,0.06044165f,0.430723f,-0.4223619f,-0.5935093f,0.5327617f);
Get(0x6E82).SetLocalPose(0.03158224f,1.335015f,0.2192901f,0.7377853f,0.09674291f,-0.4198387f,-0.5196625f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.751466f);
Get(0x6EC6).SetLocalPose(0.1666501f,1.326729f,0.1746836f,-0.1810108f,-0.8201011f,-0.3488768f,-0.4158778f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095585f,1.309542f,0.1331452f,-0.7030984f,-0.01438133f,-0.009584283f,0.7108825f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.17281f);
Get(0x6E70).SetLocalPose(0.01291901f,1.632712f,0.05430003f,0.4305692f,-0.4196632f,-0.5945072f,0.5339046f);
Get(0x6E82).SetLocalPose(0.03713091f,1.335641f,0.2091074f,0.7396533f,0.0910226f,-0.4130617f,-0.5234576f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.780962f);
Get(0x6EC6).SetLocalPose(0.1704089f,1.327066f,0.1659905f,-0.1821409f,-0.8178773f,-0.3569012f,-0.4129443f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095548f,1.309567f,0.1330757f,-0.7030641f,-0.01441996f,-0.009599458f,0.7109154f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.27555f);
Get(0x6E70).SetLocalPose(0.02945119f,1.649379f,0.03452664f,0.4278276f,-0.4107195f,-0.6005482f,0.5362974f);
Get(0x6E82).SetLocalPose(0.05222261f,1.344673f,0.1829607f,0.7352443f,0.07616816f,-0.4120777f,-0.5327347f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.883702f);
Get(0x6EC6).SetLocalPose(0.1811091f,1.332726f,0.139742f,-0.1890398f,-0.8139642f,-0.3726186f,-0.4035859f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095507f,1.309524f,0.1329157f,-0.7030436f,-0.01440046f,-0.009581903f,0.7109364f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.340863f);
Get(0x6E70).SetLocalPose(0.03745515f,1.659375f,0.0250028f,0.4250485f,-0.4063569f,-0.6069551f,0.5346152f);
Get(0x6E82).SetLocalPose(0.06007364f,1.353376f,0.1702651f,0.7280195f,0.06974067f,-0.4164088f,-0.5401182f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.949015f);
Get(0x6EC6).SetLocalPose(0.1880441f,1.336866f,0.1230904f,-0.2001138f,-0.8141115f,-0.3755687f,-0.3951265f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095179f,1.309432f,0.1329594f,-0.7030516f,-0.01439818f,-0.009595663f,0.7109284f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.400268f);
Get(0x6E70).SetLocalPose(0.04401939f,1.669525f,0.01649613f,0.4217745f,-0.4026806f,-0.6142569f,0.5316419f);
Get(0x6E82).SetLocalPose(0.06656349f,1.360336f,0.1603498f,0.723594f,0.06159858f,-0.4169318f,-0.5466126f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.00842f);
Get(0x6EC6).SetLocalPose(0.1927288f,1.341221f,0.1121194f,-0.2117513f,-0.8149137f,-0.3758545f,-0.3870534f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095086f,1.309408f,0.1327908f,-0.7030612f,-0.01437692f,-0.009595828f,0.7109193f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.462281f);
Get(0x6E70).SetLocalPose(0.05239043f,1.684536f,0.003822582f,0.4162308f,-0.3973131f,-0.6254281f,0.5270047f);
Get(0x6E82).SetLocalPose(0.07547518f,1.369344f,0.1492248f,0.720104f,0.0481476f,-0.4125447f,-0.5558228f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.070434f);
Get(0x6EC6).SetLocalPose(0.1992788f,1.34677f,0.09798332f,-0.2289835f,-0.8144285f,-0.3784138f,-0.3756006f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095101f,1.309482f,0.1328312f,-0.7030466f,-0.01437042f,-0.009588523f,0.710934f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.520038f);
Get(0x6E70).SetLocalPose(0.05760672f,1.695832f,-0.005903195f,0.4116845f,-0.3934778f,-0.632015f,0.5255931f);
Get(0x6E82).SetLocalPose(0.08490986f,1.378751f,0.1389551f,0.7149221f,0.03391868f,-0.4063595f,-0.5679858f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.12819f);
Get(0x6EC6).SetLocalPose(0.2054228f,1.351895f,0.08559707f,-0.2421741f,-0.8144866f,-0.3835367f,-0.3617498f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095342f,1.309453f,0.1329191f,-0.703043f,-0.01438072f,-0.009619142f,0.7109369f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.577362f);
Get(0x6E70).SetLocalPose(0.06177947f,1.703158f,-0.01440793f,0.4074887f,-0.3905263f,-0.6355758f,0.526769f);
Get(0x6E82).SetLocalPose(0.09206627f,1.383619f,0.1305911f,0.7051359f,0.02636282f,-0.4075954f,-0.5796156f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.185514f);
Get(0x6EC6).SetLocalPose(0.2097731f,1.356058f,0.07533187f,-0.2512654f,-0.8157708f,-0.3852214f,-0.3506966f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095155f,1.309307f,0.132922f,-0.7030428f,-0.01438939f,-0.009602644f,0.7109371f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.634418f);
Get(0x6E70).SetLocalPose(0.06569576f,1.70948f,-0.02563251f,0.4023223f,-0.3873785f,-0.6370848f,0.531223f);
Get(0x6E82).SetLocalPose(0.09813765f,1.385832f,0.1226383f,0.6888552f,0.02006062f,-0.416262f,-0.5931292f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.24257f);
Get(0x6EC6).SetLocalPose(0.2151431f,1.359031f,0.06165738f,-0.2608663f,-0.8176255f,-0.3855165f,-0.3388429f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.634418f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.24257f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095261f,1.308934f,0.1330255f,-0.7030612f,-0.01434278f,-0.00966992f,0.7109189f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.767551f);
Get(0x6E70).SetLocalPose(0.06998854f,1.709436f,-0.05175246f,0.3937639f,-0.382927f,-0.6374077f,0.5403965f);
Get(0x6E82).SetLocalPose(0.1076489f,1.383992f,0.1051183f,0.6499408f,0.006695192f,-0.441546f,-0.6185219f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.375703f);
Get(0x6EC6).SetLocalPose(0.2245499f,1.360273f,0.03362048f,-0.272119f,-0.8225608f,-0.3839261f,-0.3192897f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095272f,1.309009f,0.1331047f,-0.7030869f,-0.01438542f,-0.00964608f,0.710893f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.825252f);
Get(0x6E70).SetLocalPose(0.07033997f,1.703376f,-0.06660323f,0.3908136f,-0.382456f,-0.6395084f,0.5403898f);
Get(0x6E82).SetLocalPose(0.1104326f,1.38047f,0.095777f,0.6442887f,0.0006643675f,-0.446436f,-0.6209561f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.433405f);
Get(0x6EC6).SetLocalPose(0.2279649f,1.355641f,0.02153798f,-0.274165f,-0.8246457f,-0.3831927f,-0.3129801f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095141f,1.308894f,0.1329804f,-0.7030655f,-0.01439657f,-0.009658382f,0.7109137f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.885115f);
Get(0x6E70).SetLocalPose(0.06934328f,1.69579f,-0.07966192f,0.3898892f,-0.3832805f,-0.6409393f,0.5387759f);
Get(0x6E82).SetLocalPose(0.1120126f,1.373347f,0.08459172f,0.6475874f,0.001499435f,-0.4473055f,-0.6168842f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.493268f);
Get(0x6EC6).SetLocalPose(0.2295762f,1.350305f,0.01164225f,-0.2747521f,-0.8262127f,-0.3823034f,-0.3093994f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095381f,1.309269f,0.1329474f,-0.7030648f,-0.01440818f,-0.009635583f,0.7109146f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.03128431f);
Get(0x6E70).SetLocalPose(0.06821811f,1.684046f,-0.09528746f,0.3908081f,-0.3856717f,-0.6410538f,0.5362616f);
Get(0x6E82).SetLocalPose(0.112784f,1.365312f,0.0742264f,0.6520439f,0.01205096f,-0.4433983f,-0.6148915f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.550858f);
Get(0x6EC6).SetLocalPose(0.2310168f,1.343811f,0.003133032f,-0.274282f,-0.8297556f,-0.3777099f,-0.3059579f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095427f,1.309266f,0.1329526f,-0.7030548f,-0.01438809f,-0.009622909f,0.710925f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.09181847f);
Get(0x6E70).SetLocalPose(0.06746083f,1.670059f,-0.1122787f,0.3945301f,-0.3894606f,-0.6398824f,0.5321814f);
Get(0x6E82).SetLocalPose(0.1135195f,1.357429f,0.0655828f,0.6485875f,0.02552596f,-0.447002f,-0.6155258f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.611392f);
Get(0x6EC6).SetLocalPose(0.2332952f,1.336064f,-0.00643067f,-0.2740583f,-0.8348962f,-0.3667786f,-0.3054731f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095466f,1.309466f,0.1328463f,-0.7030452f,-0.01440926f,-0.009610055f,0.7109343f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.138148f);
Get(0x6E70).SetLocalPose(0.06760973f,1.656109f,-0.1291718f,0.3999072f,-0.3941828f,-0.6388056f,0.5259484f);
Get(0x6E82).SetLocalPose(0.1162392f,1.352438f,0.05574822f,0.6473245f,0.03548963f,-0.4564407f,-0.6094041f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.657722f);
Get(0x6EC6).SetLocalPose(0.2364445f,1.329648f,-0.01590282f,-0.2807072f,-0.8337463f,-0.356327f,-0.3148042f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09542f,1.309669f,0.1328988f,-0.7030507f,-0.01443051f,-0.009603783f,0.7109284f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.1908619f);
Get(0x6E70).SetLocalPose(0.06886879f,1.645121f,-0.1430164f,0.4043358f,-0.3988957f,-0.6384059f,0.5194542f);
Get(0x6E82).SetLocalPose(0.117613f,1.352981f,0.04969388f,0.6470361f,0.04062569f,-0.463467f,-0.604063f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.710436f);
Get(0x6EC6).SetLocalPose(0.2396263f,1.32662f,-0.02350586f,-0.2870033f,-0.8304478f,-0.3454917f,-0.3295771f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095333f,1.309965f,0.1331018f,-0.7030709f,-0.01441627f,-0.009608744f,0.7109087f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.2949791f);
Get(0x6E70).SetLocalPose(0.07817809f,1.616335f,-0.1816394f,0.4100154f,-0.414066f,-0.641825f,0.4984952f);
Get(0x6E82).SetLocalPose(0.1230085f,1.363703f,0.02117749f,0.658703f,0.041419f,-0.4913535f,-0.5683015f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.814553f);
Get(0x6EC6).SetLocalPose(0.2487509f,1.330444f,-0.04959755f,-0.2881267f,-0.832919f,-0.2959314f,-0.3683117f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094971f,1.309636f,0.1330934f,-0.7030553f,-0.0144037f,-0.009650725f,0.7109239f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.3590496f);
Get(0x6E70).SetLocalPose(0.08805149f,1.598574f,-0.205785f,0.4096112f,-0.423544f,-0.6471969f,0.4836996f);
Get(0x6E82).SetLocalPose(0.1267719f,1.373063f,-0.0008341739f,0.6750095f,0.03180247f,-0.4982199f,-0.5432566f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.878623f);
Get(0x6EC6).SetLocalPose(0.256143f,1.335906f,-0.07293859f,-0.2780643f,-0.8386434f,-0.2582202f,-0.3907427f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095183f,1.309707f,0.133206f,-0.7030478f,-0.0144084f,-0.00961662f,0.7109317f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.4208923f);
Get(0x6E70).SetLocalPose(0.1008166f,1.580096f,-0.2305541f,0.4063947f,-0.4319272f,-0.6547385f,0.4686148f);
Get(0x6E82).SetLocalPose(0.1338041f,1.387457f,-0.04094312f,0.7048107f,0.01186207f,-0.5016212f,-0.5014752f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.940466f);
Get(0x6EC6).SetLocalPose(0.2649778f,1.341524f,-0.1024214f,-0.2676529f,-0.842081f,-0.2160331f,-0.415441f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095016f,1.309287f,0.133042f,-0.7030662f,-0.01440016f,-0.009650731f,0.7109132f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.4821665f);
Get(0x6E70).SetLocalPose(0.1147764f,1.562711f,-0.2537667f,0.4011878f,-0.4388101f,-0.662405f,0.4557563f);
Get(0x6E82).SetLocalPose(0.1429028f,1.396498f,-0.07699157f,0.7204478f,-0.01256889f,-0.50815f,-0.4717846f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.001741f);
Get(0x6EC6).SetLocalPose(0.273532f,1.342649f,-0.1298579f,-0.2628821f,-0.8406383f,-0.1814203f,-0.4373866f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095024f,1.309223f,0.1329928f,-0.703073f,-0.01438929f,-0.009668956f,0.7109064f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.03257323f);
Get(0x6E70).SetLocalPose(0.1316975f,1.541909f,-0.2800184f,0.3939037f,-0.4456305f,-0.6709933f,0.4427429f);
Get(0x6E82).SetLocalPose(0.1521328f,1.39903f,-0.1095973f,0.7246538f,-0.04156603f,-0.5191871f,-0.4512138f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.061137f);
Get(0x6EC6).SetLocalPose(0.2837531f,1.337851f,-0.161296f,-0.2601622f,-0.8357663f,-0.144095f,-0.4615701f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09528f,1.309349f,0.1330041f,-0.7030847f,-0.01441156f,-0.009626812f,0.7108949f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.09467908f);
Get(0x6E70).SetLocalPose(0.1517291f,1.517774f,-0.3090072f,0.3839878f,-0.4519175f,-0.6802694f,0.430764f);
Get(0x6E82).SetLocalPose(0.1637709f,1.396119f,-0.1451587f,0.7238137f,-0.08594526f,-0.5328852f,-0.4298147f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.123242f);
Get(0x6EC6).SetLocalPose(0.2923707f,1.331465f,-0.192172f,-0.2582196f,-0.8353649f,-0.1145957f,-0.4715466f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095143f,1.309256f,0.1332256f,-0.70309f,-0.01442814f,-0.009652876f,0.7108891f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.1532043f);
Get(0x6E70).SetLocalPose(0.1676849f,1.497334f,-0.3316174f,0.3737214f,-0.4557964f,-0.6876748f,0.4238932f);
Get(0x6E82).SetLocalPose(0.1764623f,1.387055f,-0.1826949f,0.7262766f,-0.143219f,-0.5377201f,-0.4035688f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.181767f);
Get(0x6EC6).SetLocalPose(0.3022344f,1.318469f,-0.2269814f,-0.2535017f,-0.8388391f,-0.08694524f,-0.4738421f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.1532043f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.181767f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095284f,1.309349f,0.1333295f,-0.7031116f,-0.01442786f,-0.009634564f,0.7108679f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.2525373f);
Get(0x6E70).SetLocalPose(0.1995883f,1.460752f,-0.3702425f,0.3463493f,-0.4558335f,-0.7027738f,0.4223351f);
Get(0x6E82).SetLocalPose(0.1971459f,1.362414f,-0.2406048f,0.7343482f,-0.1963232f,-0.5252058f,-0.3825557f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.2811f);
Get(0x6EC6).SetLocalPose(0.3169141f,1.286585f,-0.2817723f,-0.2612181f,-0.8238907f,-0.05591007f,-0.4998432f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095097f,1.30941f,0.1333268f,-0.7030954f,-0.01443512f,-0.009653473f,0.7108835f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.3218591f);
Get(0x6E70).SetLocalPose(0.2128469f,1.443467f,-0.3867744f,0.3339468f,-0.4507889f,-0.7103955f,0.424979f);
Get(0x6E82).SetLocalPose(0.2077417f,1.344706f,-0.2660737f,0.7249648f,-0.1989291f,-0.5279614f,-0.3951077f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.350422f);
Get(0x6EC6).SetLocalPose(0.3211125f,1.26358f,-0.3069346f,-0.2679508f,-0.8206932f,-0.04760552f,-0.5023929f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095464f,1.309648f,0.133512f,-0.7031211f,-0.01446372f,-0.009586032f,0.7108584f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.3791157f);
Get(0x6E70).SetLocalPose(0.2248233f,1.427383f,-0.4033058f,0.3229341f,-0.4425405f,-0.7197105f,0.4264838f);
Get(0x6E82).SetLocalPose(0.2179765f,1.326836f,-0.2860467f,0.7077729f,-0.2175071f,-0.5382443f,-0.4025437f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.407679f);
Get(0x6EC6).SetLocalPose(0.3227836f,1.243068f,-0.3304369f,-0.2700373f,-0.8278259f,-0.04546097f,-0.4896094f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095252f,1.309502f,0.1338555f,-0.7031275f,-0.01442282f,-0.009664854f,0.7108518f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.4646797f);
Get(0x6E70).SetLocalPose(0.2333232f,1.412332f,-0.421267f,0.3134275f,-0.431468f,-0.7300618f,0.427327f);
Get(0x6E82).SetLocalPose(0.2284411f,1.305466f,-0.3051458f,0.6895716f,-0.2265818f,-0.5513489f,-0.4112983f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.493243f);
Get(0x6EC6).SetLocalPose(0.3282975f,1.217268f,-0.3563361f,-0.2772516f,-0.834188f,-0.04665683f,-0.4744314f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095398f,1.309667f,0.1337123f,-0.7031177f,-0.0144326f,-0.009634676f,0.7108618f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.5272483f);
Get(0x6E70).SetLocalPose(0.2364412f,1.407011f,-0.4328804f,0.3104769f,-0.4237588f,-0.7324915f,0.4329998f);
Get(0x6E82).SetLocalPose(0.2352449f,1.288676f,-0.3161719f,0.6811055f,-0.2289834f,-0.5570343f,-0.4163828f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.555811f);
Get(0x6EC6).SetLocalPose(0.3343945f,1.201944f,-0.3710291f,-0.2885579f,-0.8311267f,-0.04856068f,-0.4728684f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095356f,1.309698f,0.1335243f,-0.7031177f,-0.01443685f,-0.009601233f,0.7108622f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.5866492f);
Get(0x6E70).SetLocalPose(0.2354868f,1.4086f,-0.4403922f,0.3074778f,-0.4200808f,-0.7310852f,0.4410261f);
Get(0x6E82).SetLocalPose(0.2393254f,1.277526f,-0.3215922f,0.6786723f,-0.2229844f,-0.5557284f,-0.4252621f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.615212f);
Get(0x6EC6).SetLocalPose(0.3402567f,1.192319f,-0.3789736f,-0.3002978f,-0.8308688f,-0.0526685f,-0.465515f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095269f,1.309143f,0.1332473f,-0.7031182f,-0.01437913f,-0.00968667f,0.7108617f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.6464163f);
Get(0x6E70).SetLocalPose(0.2322517f,1.41382f,-0.4441477f,0.3056971f,-0.4192471f,-0.7282031f,0.4477739f);
Get(0x6E82).SetLocalPose(0.2420356f,1.270703f,-0.3234226f,0.67876f,-0.2071318f,-0.5489736f,-0.4415986f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.674979f);
Get(0x6EC6).SetLocalPose(0.3424158f,1.186501f,-0.3812865f,-0.3123044f,-0.8325996f,-0.06054447f,-0.4534073f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.6464163f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.674979f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094923f,1.309217f,0.1332496f,-0.7030815f,-0.01437086f,-0.009650975f,0.7108985f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.7508034f);
Get(0x6E70).SetLocalPose(0.2146803f,1.437301f,-0.446916f,0.3135812f,-0.4177031f,-0.7156838f,0.4636678f);
Get(0x6E82).SetLocalPose(0.2394596f,1.272787f,-0.315342f,0.6712405f,-0.1830622f,-0.5453379f,-0.467473f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.779366f);
Get(0x6EC6).SetLocalPose(0.3429494f,1.19135f,-0.3759869f,-0.3309979f,-0.8310606f,-0.07653785f,-0.4403639f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095123f,1.30933f,0.133133f,-0.7030599f,-0.01443055f,-0.00962486f,0.7109191f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.821489f);
Get(0x6E70).SetLocalPose(0.2028312f,1.452589f,-0.4441682f,0.3194197f,-0.4157308f,-0.7079096f,0.4732896f);
Get(0x6E82).SetLocalPose(0.2346647f,1.280523f,-0.3058334f,0.6671819f,-0.1772067f,-0.545835f,-0.4749003f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.850052f);
Get(0x6EC6).SetLocalPose(0.3363219f,1.205782f,-0.3678739f,-0.3299946f,-0.8343446f,-0.09276648f,-0.4317026f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095112f,1.309405f,0.133096f,-0.703051f,-0.01439064f,-0.009657175f,0.7109283f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.8823062f);
Get(0x6E70).SetLocalPose(0.1908466f,1.469874f,-0.4387403f,0.3239294f,-0.4134666f,-0.6989098f,0.4854281f);
Get(0x6E82).SetLocalPose(0.2279869f,1.289777f,-0.2953534f,0.667123f,-0.1725923f,-0.5484284f,-0.473693f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.910869f);
Get(0x6EC6).SetLocalPose(0.3285674f,1.220675f,-0.3594822f,-0.3214084f,-0.8395516f,-0.1112253f,-0.4236493f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095023f,1.309234f,0.1329805f,-0.7030495f,-0.01434364f,-0.009664988f,0.7109305f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.941833f);
Get(0x6E70).SetLocalPose(0.1788923f,1.48673f,-0.4319945f,0.3271228f,-0.4116682f,-0.6895982f,0.4979701f);
Get(0x6E82).SetLocalPose(0.2187231f,1.300817f,-0.2830068f,0.6699483f,-0.1648248f,-0.5498664f,-0.4707963f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.970396f);
Get(0x6EC6).SetLocalPose(0.3188547f,1.234469f,-0.3492326f,-0.3138842f,-0.8432116f,-0.1268581f,-0.417586f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095222f,1.309104f,0.1329256f,-0.7030307f,-0.01439503f,-0.009619854f,0.7109487f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.002928f);
Get(0x6E70).SetLocalPose(0.1652854f,1.505712f,-0.4229186f,0.3305745f,-0.4105578f,-0.6780678f,0.5122371f);
Get(0x6E82).SetLocalPose(0.2093921f,1.311096f,-0.2695609f,0.6729316f,-0.1544698f,-0.5504332f,-0.4693885f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.031491f);
Get(0x6EC6).SetLocalPose(0.309765f,1.251012f,-0.3330159f,-0.309698f,-0.8439267f,-0.1424204f,-0.4142359f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095321f,1.309246f,0.1328358f,-0.7030364f,-0.01443049f,-0.009597178f,0.7109427f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.062459f);
Get(0x6E70).SetLocalPose(0.1511377f,1.525044f,-0.4124792f,0.3337392f,-0.4108702f,-0.6662151f,0.5253202f);
Get(0x6E82).SetLocalPose(0.1990913f,1.322441f,-0.253444f,0.67527f,-0.1392993f,-0.5515662f,-0.4694476f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.091022f);
Get(0x6EC6).SetLocalPose(0.3012176f,1.266228f,-0.3163516f,-0.3087386f,-0.8436821f,-0.1544468f,-0.4111293f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095229f,1.309547f,0.1329285f,-0.7030457f,-0.01437694f,-0.009650833f,0.7109339f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.121158f);
Get(0x6E70).SetLocalPose(0.1367563f,1.543841f,-0.4011071f,0.3358805f,-0.4126926f,-0.6547669f,0.5367956f);
Get(0x6E82).SetLocalPose(0.1897445f,1.333732f,-0.2370935f,0.6775929f,-0.1222981f,-0.5517146f,-0.4706615f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.149721f);
Get(0x6EC6).SetLocalPose(0.2917928f,1.281674f,-0.2987105f,-0.3068473f,-0.8451146f,-0.1668647f,-0.4047002f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.121158f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.149721f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095525f,1.309354f,0.1327854f,-0.703029f,-0.01442177f,-0.009568482f,0.7109506f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.260519f);
Get(0x6E70).SetLocalPose(0.1047649f,1.580092f,-0.3721215f,0.3367077f,-0.4195062f,-0.6312833f,0.5586804f);
Get(0x6E82).SetLocalPose(0.169195f,1.357751f,-0.1916515f,0.696777f,-0.07645164f,-0.5376049f,-0.4686555f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.289082f);
Get(0x6EC6).SetLocalPose(0.2811236f,1.305733f,-0.2614076f,-0.2987404f,-0.8555871f,-0.1985121f,-0.3732529f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095664f,1.309274f,0.1328345f,-0.7030348f,-0.01445396f,-0.00960114f,0.7109438f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0f);
Get(0x6E70).SetLocalPose(0.09021159f,1.593901f,-0.3576651f,0.3377505f,-0.4221721f,-0.6213961f,0.5670645f);
Get(0x6E82).SetLocalPose(0.1633306f,1.366034f,-0.1745401f,0.7083926f,-0.06643707f,-0.522732f,-0.4695929f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.349654f);
Get(0x6EC6).SetLocalPose(0.2758656f,1.317178f,-0.2438256f,-0.2929144f,-0.8612409f,-0.217756f,-0.3536209f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09577f,1.309341f,0.1329119f,-0.7030523f,-0.01443836f,-0.009604903f,0.7109267f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.05926031f);
Get(0x6E70).SetLocalPose(0.07784099f,1.604058f,-0.3446391f,0.339862f,-0.4239799f,-0.6132269f,0.5733129f);
Get(0x6E82).SetLocalPose(0.156178f,1.374726f,-0.1512726f,0.7085689f,-0.07155942f,-0.5149223f,-0.477142f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.408914f);
Get(0x6EC6).SetLocalPose(0.2715347f,1.328839f,-0.2270278f,-0.283097f,-0.8671777f,-0.234877f,-0.335696f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095877f,1.309286f,0.1331517f,-0.703064f,-0.01443722f,-0.009577175f,0.7109156f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.1185738f);
Get(0x6E70).SetLocalPose(0.06457819f,1.614173f,-0.3299001f,0.3437372f,-0.4249485f,-0.6046954f,0.579316f);
Get(0x6E82).SetLocalPose(0.1501073f,1.380188f,-0.1330103f,0.7029086f,-0.07929699f,-0.517713f,-0.4812534f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.03098246f);
Get(0x6EC6).SetLocalPose(0.2697145f,1.337277f,-0.2119948f,-0.2739986f,-0.8706822f,-0.2501073f,-0.32293f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095687f,1.309629f,0.1331409f,-0.7030501f,-0.01447195f,-0.009556237f,0.7109288f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.1766871f);
Get(0x6E70).SetLocalPose(0.05236297f,1.624075f,-0.3155566f,0.3494793f,-0.4245147f,-0.5971715f,0.5839843f);
Get(0x6E82).SetLocalPose(0.1435503f,1.386571f,-0.1138599f,0.6886848f,-0.07943948f,-0.528224f,-0.4902878f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.0890957f);
Get(0x6EC6).SetLocalPose(0.2686808f,1.345298f,-0.196446f,-0.2669231f,-0.872277f,-0.2624431f,-0.3146562f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095379f,1.309463f,0.1330566f,-0.7030563f,-0.01442755f,-0.00959144f,0.7109231f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.2372849f);
Get(0x6E70).SetLocalPose(0.04299589f,1.63248f,-0.3031644f,0.3559513f,-0.4231549f,-0.5919684f,0.5863549f);
Get(0x6E82).SetLocalPose(0.1341005f,1.394205f,-0.09295521f,0.6807845f,-0.06143316f,-0.5363597f,-0.4950522f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.1496935f);
Get(0x6EC6).SetLocalPose(0.2663766f,1.356184f,-0.1824688f,-0.2622906f,-0.8742786f,-0.2692333f,-0.307171f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095174f,1.309391f,0.1329275f,-0.703082f,-0.01439604f,-0.009615499f,0.7108981f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.2649609f);
Get(0x6E70).SetLocalPose(0.03798215f,1.63894f,-0.2954282f,0.3601193f,-0.4222978f,-0.5897782f,0.5866348f);
Get(0x6E82).SetLocalPose(0.1293206f,1.397979f,-0.08517519f,0.6784637f,-0.05084844f,-0.537298f,-0.4984099f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0f);
Get(0x6EC6).SetLocalPose(0.2651545f,1.360387f,-0.1762589f,-0.2613488f,-0.8762903f,-0.2726642f,-0.2991092f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.2649609f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094863f,1.309419f,0.1329402f,-0.7030503f,-0.01438529f,-0.009647736f,0.7109292f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.4146185f);
Get(0x6E70).SetLocalPose(0.02470615f,1.668978f,-0.2672662f,0.3634166f,-0.4274012f,-0.5905309f,0.580112f);
Get(0x6E82).SetLocalPose(0.1127377f,1.421019f,-0.05925807f,0.6337333f,-0.09529848f,-0.5888314f,-0.4925219f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.1496575f);
Get(0x6EC6).SetLocalPose(0.2562589f,1.38212f,-0.1531744f,-0.2624933f,-0.8758832f,-0.2857406f,-0.2868417f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095129f,1.309422f,0.1328365f,-0.7030525f,-0.0144164f,-0.009654248f,0.7109263f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.4758378f);
Get(0x6E70).SetLocalPose(0.0220251f,1.679748f,-0.2569446f,0.3597782f,-0.4311324f,-0.5920712f,0.5780451f);
Get(0x6E82).SetLocalPose(0.1075845f,1.430596f,-0.0566343f,0.6510389f,-0.1006091f,-0.5792489f,-0.480101f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.2108769f);
Get(0x6EC6).SetLocalPose(0.2518333f,1.391017f,-0.1434171f,-0.2653229f,-0.8744332f,-0.2879719f,-0.2864306f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095213f,1.309279f,0.132973f,-0.7030477f,-0.01437833f,-0.009689474f,0.7109313f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.5384748f);
Get(0x6E70).SetLocalPose(0.01979273f,1.689487f,-0.246557f,0.356683f,-0.4327641f,-0.5927363f,0.5780624f);
Get(0x6E82).SetLocalPose(0.1055671f,1.439106f,-0.05340267f,0.6640626f,-0.1057247f,-0.5734743f,-0.4679429f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.2735139f);
Get(0x6EC6).SetLocalPose(0.2484709f,1.397084f,-0.136133f,-0.2691588f,-0.87536f,-0.2877581f,-0.2801675f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095164f,1.309386f,0.1329983f,-0.7030536f,-0.01440144f,-0.009648355f,0.7109256f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.03348523f);
Get(0x6E70).SetLocalPose(0.01844906f,1.696277f,-0.2370434f,0.3551866f,-0.4324824f,-0.5927366f,0.5791932f);
Get(0x6E82).SetLocalPose(0.1070714f,1.445016f,-0.04702897f,0.6716908f,-0.1093195f,-0.5677586f,-0.463175f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.33472f);
Get(0x6EC6).SetLocalPose(0.2464432f,1.39947f,-0.1296719f,-0.267797f,-0.8774357f,-0.2849325f,-0.2778577f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095203f,1.309467f,0.1328825f,-0.7030464f,-0.01446143f,-0.009601929f,0.7109321f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.09425662f);
Get(0x6E70).SetLocalPose(0.0174816f,1.701379f,-0.2254683f,0.3532884f,-0.4319912f,-0.5923774f,0.5810853f);
Get(0x6E82).SetLocalPose(0.1114467f,1.450169f,-0.03528966f,0.6836896f,-0.1087593f,-0.5489129f,-0.4684384f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.3954914f);
Get(0x6EC6).SetLocalPose(0.246329f,1.39615f,-0.1213527f,-0.276942f,-0.8725821f,-0.280801f,-0.2881916f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095256f,1.309341f,0.132978f,-0.7030684f,-0.0144283f,-0.009622517f,0.7109107f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.1519689f);
Get(0x6E70).SetLocalPose(0.01644071f,1.701938f,-0.216665f,0.3508924f,-0.4320782f,-0.591919f,0.5829365f);
Get(0x6E82).SetLocalPose(0.1179485f,1.454006f,-0.0185358f,0.6930102f,-0.1065755f,-0.5282f,-0.4789398f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.4532037f);
Get(0x6EC6).SetLocalPose(0.2470724f,1.388719f,-0.1117587f,-0.2928469f,-0.8594964f,-0.2840383f,-0.307943f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09519f,1.309369f,0.1330734f,-0.7030762f,-0.01441295f,-0.00966328f,0.7109029f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.1802677f);
Get(0x6E70).SetLocalPose(0.01600537f,1.700119f,-0.2116563f,0.3499146f,-0.4318611f,-0.5917394f,0.5838667f);
Get(0x6E82).SetLocalPose(0.121566f,1.456276f,-0.006339142f,0.6973621f,-0.1002772f,-0.516127f,-0.4870766f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.4815024f);
Get(0x6EC6).SetLocalPose(0.2468895f,1.382138f,-0.10556f,-0.3031837f,-0.8509533f,-0.2863382f,-0.3193252f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095307f,1.309562f,0.1331815f,-0.7030571f,-0.01442583f,-0.009654816f,0.7109216f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.2812837f);
Get(0x6E70).SetLocalPose(0.01443269f,1.690759f,-0.1996377f,0.3497154f,-0.4300501f,-0.5918927f,0.5851659f);
Get(0x6E82).SetLocalPose(0.1360235f,1.467904f,0.03728222f,0.7335342f,-0.09890721f,-0.4540931f,-0.495928f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.5825185f);
Get(0x6EC6).SetLocalPose(0.2417815f,1.348986f,-0.08087954f,-0.3316129f,-0.8295806f,-0.3084696f,-0.326612f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095362f,1.3096f,0.1331823f,-0.7030573f,-0.01448505f,-0.009599802f,0.7109209f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.3467006f);
Get(0x6E70).SetLocalPose(0.0119313f,1.674843f,-0.1865155f,0.3516673f,-0.4265246f,-0.5936595f,0.5847867f);
Get(0x6E82).SetLocalPose(0.1505166f,1.478545f,0.07594165f,0.7947953f,-0.1122802f,-0.3602049f,-0.4753377f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.6479353f);
Get(0x6EC6).SetLocalPose(0.2363159f,1.321012f,-0.06354532f,-0.3471978f,-0.8163201f,-0.3382139f,-0.3141442f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095278f,1.309438f,0.1329838f,-0.7030461f,-0.01441039f,-0.009624998f,0.7109331f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.40738f);
Get(0x6E70).SetLocalPose(0.009201505f,1.656982f,-0.1749967f,0.3565783f,-0.421784f,-0.592836f,0.5860851f);
Get(0x6E82).SetLocalPose(0.1650111f,1.488161f,0.1185993f,0.859462f,-0.1111522f,-0.2429028f,-0.4358539f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.7086147f);
Get(0x6EC6).SetLocalPose(0.2314164f,1.287238f,-0.04551126f,-0.3633499f,-0.7970178f,-0.3749968f,-0.3035074f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095336f,1.309525f,0.1330744f,-0.7030587f,-0.01439169f,-0.009676362f,0.7109205f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0f);
Get(0x6E70).SetLocalPose(0.005838803f,1.635988f,-0.1637693f,0.3643708f,-0.417307f,-0.5880667f,0.5892931f);
Get(0x6E82).SetLocalPose(0.180003f,1.496837f,0.1730358f,0.899104f,-0.1350334f,-0.1097247f,-0.4016697f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.7682608f);
Get(0x6EC6).SetLocalPose(0.2253441f,1.236438f,-0.02170368f,-0.3777192f,-0.7671434f,-0.4285548f,-0.2918219f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095361f,1.30948f,0.1331525f,-0.7030522f,-0.01445821f,-0.009621684f,0.7109263f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.05945816f);
Get(0x6E70).SetLocalPose(0.001579745f,1.613662f,-0.1515524f,0.3740359f,-0.4144856f,-0.5806248f,0.5925992f);
Get(0x6E82).SetLocalPose(0.1876969f,1.502384f,0.2220758f,0.8980046f,-0.1881501f,0.005803428f,-0.3976854f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.03205231f);
Get(0x6EC6).SetLocalPose(0.2228928f,1.188718f,-0.004242617f,-0.3830282f,-0.737901f,-0.4792986f,-0.2811841f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095502f,1.309661f,0.1331923f,-0.7030638f,-0.01449404f,-0.009579476f,0.7109146f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.117652f);
Get(0x6E70).SetLocalPose(-0.003363711f,1.594364f,-0.1396876f,0.3841039f,-0.4136076f,-0.5719718f,0.5951818f);
Get(0x6E82).SetLocalPose(0.1854992f,1.509722f,0.2830677f,0.8557301f,-0.2641035f,0.1094347f,-0.4312766f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.09024616f);
Get(0x6EC6).SetLocalPose(0.2246352f,1.130077f,0.01137401f,-0.3804063f,-0.7021458f,-0.5413474f,-0.2631071f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095472f,1.309862f,0.1331893f,-0.7030732f,-0.01450996f,-0.009580007f,0.710905f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.1811505f);
Get(0x6E70).SetLocalPose(-0.01024171f,1.574081f,-0.1244723f,0.392513f,-0.4162871f,-0.5619586f,0.5973618f);
Get(0x6E82).SetLocalPose(0.1656676f,1.518834f,0.3312185f,0.8206776f,-0.2942559f,0.1470401f,-0.4672055f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.1537446f);
Get(0x6EC6).SetLocalPose(0.2332835f,1.058569f,0.02003621f,-0.3994452f,-0.661064f,-0.5891017f,-0.2374809f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.1811505f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.1537446f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095432f,1.309709f,0.1331798f,-0.7030649f,-0.01445313f,-0.009593281f,0.7109141f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.3175532f);
Get(0x6E70).SetLocalPose(-0.03172527f,1.541828f,-0.08483502f,0.4061984f,-0.4288919f,-0.5444427f,0.5955139f);
Get(0x6E82).SetLocalPose(0.09389787f,1.543144f,0.3600643f,0.7984955f,-0.3535945f,0.06745225f,-0.4825206f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.2901474f);
Get(0x6EC6).SetLocalPose(0.2678545f,0.9171541f,0.01067602f,-0.4886788f,-0.5510091f,-0.6560115f,-0.1650179f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095315f,1.309742f,0.1330801f,-0.7030643f,-0.01450185f,-0.009543248f,0.7109144f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.378904f);
Get(0x6E70).SetLocalPose(-0.04722219f,1.532361f,-0.06316713f,0.420104f,-0.4338802f,-0.5370009f,0.5889743f);
Get(0x6E82).SetLocalPose(0.06171141f,1.539928f,0.3385122f,0.8031939f,-0.3687528f,0.0691593f,-0.4627288f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.3514982f);
Get(0x6EC6).SetLocalPose(0.2894897f,0.8588711f,-0.003841188f,-0.5093943f,-0.479513f,-0.7049942f,-0.1164817f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09537f,1.309456f,0.1329993f,-0.7030836f,-0.01451363f,-0.009595202f,0.7108944f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.4399963f);
Get(0x6E70).SetLocalPose(-0.06877918f,1.528134f,-0.03696863f,0.4385952f,-0.4385196f,-0.5293574f,0.5788917f);
Get(0x6E82).SetLocalPose(0.03468465f,1.526816f,0.3156542f,0.7939355f,-0.4099579f,0.02800984f,-0.4481255f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.4125905f);
Get(0x6EC6).SetLocalPose(0.3144993f,0.8123098f,-0.02592241f,-0.5033144f,-0.4014573f,-0.7637027f,-0.04759007f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095589f,1.309668f,0.1331348f,-0.7030842f,-0.01447913f,-0.009575552f,0.7108946f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.5016086f);
Get(0x6E70).SetLocalPose(-0.09290584f,1.5277f,-0.01086575f,0.4579236f,-0.4411508f,-0.5197487f,0.5705728f);
Get(0x6E82).SetLocalPose(-0.00877643f,1.496565f,0.2790815f,0.7583067f,-0.4811254f,-0.0494168f,-0.4370894f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.4742028f);
Get(0x6EC6).SetLocalPose(0.3402175f,0.7920214f,-0.04450576f,-0.4490651f,-0.3511708f,-0.8203526f,0.04517983f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095726f,1.30996f,0.1332287f,-0.7030488f,-0.01449156f,-0.009538488f,0.7109299f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.5617606f);
Get(0x6E70).SetLocalPose(-0.1208842f,1.531339f,0.0155408f,0.4811935f,-0.4441369f,-0.5038719f,0.5633013f);
Get(0x6E82).SetLocalPose(-0.05138479f,1.457688f,0.2443146f,0.7418767f,-0.5049772f,-0.06821959f,-0.4358476f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.5343547f);
Get(0x6EC6).SetLocalPose(0.3660133f,0.7907184f,-0.05537817f,-0.4057429f,-0.3045577f,-0.853157f,0.1214101f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095319f,1.309765f,0.1330731f,-0.7030641f,-0.01449741f,-0.009533789f,0.7109148f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.621913f);
Get(0x6E70).SetLocalPose(-0.1451891f,1.537697f,0.03609946f,0.5018675f,-0.4485348f,-0.4860384f,0.5574157f);
Get(0x6E82).SetLocalPose(-0.09496315f,1.414268f,0.2114694f,0.7444686f,-0.5032172f,-0.06536371f,-0.4338971f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.5945071f);
Get(0x6EC6).SetLocalPose(0.4111006f,0.8085575f,-0.06230725f,-0.426887f,-0.2408282f,-0.8511872f,0.1877491f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095379f,1.309801f,0.1331339f,-0.7030777f,-0.01451548f,-0.009558269f,0.7109007f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.6519111f);
Get(0x6E70).SetLocalPose(-0.1667815f,1.544637f,0.05321113f,0.5199271f,-0.4546364f,-0.4673598f,0.5518663f);
Get(0x6E82).SetLocalPose(-0.1255892f,1.382924f,0.1912251f,0.7570314f,-0.4835489f,-0.0629105f,-0.4348864f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.6245053f);
Get(0x6EC6).SetLocalPose(0.4327511f,0.8270493f,-0.05787358f,-0.4438757f,-0.224465f,-0.8394857f,0.2187543f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095417f,1.309605f,0.132724f,-0.7030533f,-0.01438687f,-0.009611508f,0.7109267f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.7568884f);
Get(0x6E70).SetLocalPose(-0.2201421f,1.564105f,0.09406354f,0.555429f,-0.4826435f,-0.4131936f,0.5364932f);
Get(0x6E82).SetLocalPose(-0.1981709f,1.29785f,0.1536149f,0.7394667f,-0.4318778f,-0.07728799f,-0.5105851f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.7294825f);
Get(0x6EC6).SetLocalPose(0.4993029f,0.9198458f,0.01611162f,-0.404265f,-0.2135371f,-0.8326057f,0.3126333f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095434f,1.309475f,0.1328746f,-0.7030424f,-0.01444518f,-0.009577949f,0.7109367f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.7918708f);
Get(0x6E70).SetLocalPose(-0.2357521f,1.570212f,0.1059945f,0.5612559f,-0.4954122f,-0.3966348f,0.531262f);
Get(0x6E82).SetLocalPose(-0.2089297f,1.280839f,0.1503838f,0.7150603f,-0.4133225f,-0.08271926f,-0.5576834f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.764465f);
Get(0x6EC6).SetLocalPose(0.5199888f,0.9625047f,0.06393401f,-0.3557241f,-0.2098918f,-0.8458046f,0.337669f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095591f,1.309438f,0.1328324f,-0.7030497f,-0.01447903f,-0.009525497f,0.7109295f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.8551807f);
Get(0x6E70).SetLocalPose(-0.2671332f,1.580908f,0.130988f,0.5668062f,-0.5280414f,-0.3627544f,0.5179886f);
Get(0x6E82).SetLocalPose(-0.2323567f,1.241624f,0.1443084f,0.659342f,-0.3300397f,-0.08762361f,-0.6698239f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.8277748f);
Get(0x6EC6).SetLocalPose(0.548292f,1.048261f,0.1649387f,-0.2821966f,-0.2123292f,-0.853687f,0.382753f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095549f,1.309608f,0.1329729f,-0.703077f,-0.01446137f,-0.00957093f,0.7109023f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.9160675f);
Get(0x6E70).SetLocalPose(-0.2911094f,1.583768f,0.1518495f,0.5673532f,-0.55177f,-0.3435853f,0.5055783f);
Get(0x6E82).SetLocalPose(-0.2530668f,1.208556f,0.137825f,0.6258396f,-0.2140969f,-0.07107492f,-0.7466161f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.8886616f);
Get(0x6EC6).SetLocalPose(0.5606329f,1.138559f,0.2721802f,-0.2355998f,-0.2463586f,-0.8363745f,0.4292762f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095245f,1.309328f,0.1328585f,-0.7030829f,-0.01440626f,-0.00964292f,0.7108966f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.9766746f);
Get(0x6E70).SetLocalPose(-0.3120625f,1.580785f,0.1740902f,0.5735813f,-0.5650637f,-0.3360203f,0.4886696f);
Get(0x6E82).SetLocalPose(-0.2705463f,1.185746f,0.136795f,0.6019562f,-0.09151191f,-0.04241195f,-0.7921336f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.9492687f);
Get(0x6EC6).SetLocalPose(0.5366762f,1.266034f,0.4241887f,-0.1709872f,-0.3404107f,-0.7956638f,0.4709598f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095357f,1.309347f,0.1328519f,-0.7030382f,-0.0144052f,-0.009634146f,0.710941f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.03792f);
Get(0x6E70).SetLocalPose(-0.3260496f,1.571624f,0.1946425f,0.5884987f,-0.5652536f,-0.3320564f,0.4731768f);
Get(0x6E82).SetLocalPose(-0.2817381f,1.174223f,0.1395245f,0.5790468f,0.004035821f,-0.03212569f,-0.8146511f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.010514f);
Get(0x6EC6).SetLocalPose(0.480855f,1.359346f,0.5417766f,-0.1016456f,-0.4142905f,-0.7710748f,0.4727317f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095509f,1.309504f,0.1329937f,-0.7030627f,-0.01447642f,-0.009579917f,0.710916f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.127294f);
Get(0x6E70).SetLocalPose(-0.3316446f,1.551778f,0.2231568f,0.6235765f,-0.5446753f,-0.3240612f,0.4576741f);
Get(0x6E82).SetLocalPose(-0.2982839f,1.161511f,0.1510075f,0.5372028f,0.161681f,-0.05510462f,-0.8259757f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.099888f);
Get(0x6EC6).SetLocalPose(0.2678539f,1.520299f,0.7396416f,0.09135175f,-0.5266828f,-0.7280852f,0.4291294f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.127294f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.099888f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095197f,1.309336f,0.1330527f,-0.703086f,-0.01441771f,-0.009619687f,0.7108936f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0f);
Get(0x6E70).SetLocalPose(-0.3250631f,1.537879f,0.2551904f,0.652324f,-0.5189953f,-0.3338619f,0.4400609f);
Get(0x6E82).SetLocalPose(-0.302579f,1.159744f,0.17531f,0.5214871f,0.1801561f,-0.1218815f,-0.8250696f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.202146f);
Get(0x6EC6).SetLocalPose(-0.01024026f,1.611191f,0.808844f,0.2527579f,-0.6621794f,-0.6289988f,0.3193627f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095289f,1.309605f,0.1331996f,-0.7030585f,-0.01444278f,-0.009606418f,0.7109204f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.06998862f);
Get(0x6E70).SetLocalPose(-0.319373f,1.537096f,0.2691035f,0.6569288f,-0.5121084f,-0.3467094f,0.4312565f);
Get(0x6E82).SetLocalPose(-0.3030548f,1.163882f,0.1910063f,0.5345771f,0.1838061f,-0.1256654f,-0.8152613f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.272134f);
Get(0x6EC6).SetLocalPose(-0.2044818f,1.617856f,0.7799496f,0.3208716f,-0.7371584f,-0.5924894f,0.05094428f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095506f,1.309442f,0.1331294f,-0.7030739f,-0.01446619f,-0.009615112f,0.7109047f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.1293456f);
Get(0x6E70).SetLocalPose(-0.3121825f,1.541329f,0.2834291f,0.6566637f,-0.5079696f,-0.3623437f,0.4236354f);
Get(0x6E82).SetLocalPose(-0.3009084f,1.168955f,0.2018554f,0.5551999f,0.1752292f,-0.1164608f,-0.8046643f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.331491f);
Get(0x6EC6).SetLocalPose(-0.3391047f,1.583907f,0.7267387f,0.4098172f,-0.7130269f,-0.5634724f,-0.07836793f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09529f,1.309684f,0.133219f,-0.7030914f,-0.01447051f,-0.009603273f,0.7108874f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.1911957f);
Get(0x6E70).SetLocalPose(-0.3037232f,1.54838f,0.2973657f,0.6508276f,-0.506293f,-0.3811715f,0.4180899f);
Get(0x6E82).SetLocalPose(-0.2890671f,1.184795f,0.2220482f,0.5992672f,0.1084857f,-0.09374855f,-0.7876046f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.393341f);
Get(0x6EC6).SetLocalPose(-0.4411233f,1.527976f,0.6550546f,0.458425f,-0.6742414f,-0.538124f,-0.2137f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095359f,1.309815f,0.1333569f,-0.7030774f,-0.01447399f,-0.009607316f,0.7109011f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.250405f);
Get(0x6E70).SetLocalPose(-0.2971448f,1.554803f,0.3063253f,0.6432118f,-0.5057896f,-0.3970562f,0.4156945f);
Get(0x6E82).SetLocalPose(-0.2772298f,1.203743f,0.2365837f,0.6182f,0.03742207f,-0.09669662f,-0.7791522f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.452551f);
Get(0x6EC6).SetLocalPose(-0.5107821f,1.472274f,0.5839528f,0.4952698f,-0.6075903f,-0.5271153f,-0.3281636f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095071f,1.309434f,0.1331986f,-0.7030544f,-0.01444645f,-0.00962694f,0.7109242f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.3094853f);
Get(0x6E70).SetLocalPose(-0.2913013f,1.562959f,0.314239f,0.6337851f,-0.5060192f,-0.412232f,0.4151214f);
Get(0x6E82).SetLocalPose(-0.2699116f,1.225863f,0.2477162f,0.6347752f,-0.005179785f,-0.1195148f,-0.7633806f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.511631f);
Get(0x6EC6).SetLocalPose(-0.5583867f,1.405754f,0.4978799f,0.5584654f,-0.5326577f,-0.5008463f,-0.3918485f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095099f,1.309764f,0.1332949f,-0.7030632f,-0.01444533f,-0.009641583f,0.7109153f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.03267108f);
Get(0x6E70).SetLocalPose(-0.2855891f,1.572024f,0.3215221f,0.622163f,-0.5064846f,-0.4285834f,0.4155753f);
Get(0x6E82).SetLocalPose(-0.2640807f,1.25086f,0.2535072f,0.6559963f,-0.02286023f,-0.1366831f,-0.7419327f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.575198f);
Get(0x6EC6).SetLocalPose(-0.5714319f,1.341553f,0.4200034f,0.5975408f,-0.4780042f,-0.4756995f,-0.4337823f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.03267108f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.575198f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095587f,1.309495f,0.1330275f,-0.7030745f,-0.01441801f,-0.009636411f,0.7109048f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.1714154f);
Get(0x6E70).SetLocalPose(-0.2738371f,1.589055f,0.3284987f,0.598464f,-0.5057661f,-0.4581078f,0.4197366f);
Get(0x6E82).SetLocalPose(-0.2596036f,1.297682f,0.2577069f,0.707125f,-0.02742273f,-0.1556639f,-0.689196f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.713943f);
Get(0x6EC6).SetLocalPose(-0.55427f,1.214987f,0.3018527f,0.6429139f,-0.4171936f,-0.4660077f,-0.442095f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095319f,1.309245f,0.1332426f,-0.7030839f,-0.01441717f,-0.009650121f,0.7108953f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.2323215f);
Get(0x6E70).SetLocalPose(-0.2679603f,1.595279f,0.3261275f,0.5928387f,-0.5047154f,-0.4662032f,0.4200706f);
Get(0x6E82).SetLocalPose(-0.2566422f,1.31176f,0.2562619f,0.706246f,-0.02429669f,-0.156076f,-0.6901207f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.774849f);
Get(0x6EC6).SetLocalPose(-0.5318696f,1.168809f,0.2786306f,0.6309634f,-0.4034917f,-0.4897676f,-0.4463263f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095384f,1.309284f,0.1331986f,-0.7031001f,-0.01441349f,-0.009644207f,0.7108794f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.2910148f);
Get(0x6E70).SetLocalPose(-0.2628037f,1.599241f,0.3210413f,0.5918052f,-0.5022401f,-0.4714037f,0.4186884f);
Get(0x6E82).SetLocalPose(-0.2532574f,1.321669f,0.2548841f,0.7067944f,-0.01652341f,-0.1587543f,-0.6891777f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.833542f);
Get(0x6EC6).SetLocalPose(-0.5019585f,1.128248f,0.2760632f,0.5737883f,-0.3776518f,-0.5574328f,-0.4662777f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.0954f,1.30943f,0.1332188f,-0.7030941f,-0.01442005f,-0.009626397f,0.7108855f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.3487702f);
Get(0x6E70).SetLocalPose(-0.2554367f,1.601806f,0.3132825f,0.5924861f,-0.498354f,-0.4756482f,0.4175673f);
Get(0x6E82).SetLocalPose(-0.2482036f,1.329386f,0.2505943f,0.7307104f,-0.02501054f,-0.1456237f,-0.6665063f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.891297f);
Get(0x6EC6).SetLocalPose(-0.4656493f,1.084713f,0.2812918f,0.5111215f,-0.3431527f,-0.6298026f,-0.4736558f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095221f,1.309358f,0.1332328f,-0.7030857f,-0.01440807f,-0.009670522f,0.7108934f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.4067824f);
Get(0x6E70).SetLocalPose(-0.2459408f,1.604588f,0.3045203f,0.5920603f,-0.4953889f,-0.4784086f,0.4185447f);
Get(0x6E82).SetLocalPose(-0.2435181f,1.334402f,0.2462427f,0.7501097f,-0.02279868f,-0.1170327f,-0.6504761f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.949309f);
Get(0x6EC6).SetLocalPose(-0.4332061f,1.053865f,0.2885799f,0.493169f,-0.3303915f,-0.6620318f,-0.4575365f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094903f,1.309287f,0.1332529f,-0.7030834f,-0.01441236f,-0.009672609f,0.7108956f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.4637347f);
Get(0x6E70).SetLocalPose(-0.2339962f,1.608598f,0.293372f,0.5876305f,-0.4957826f,-0.4801838f,0.4222719f);
Get(0x6E82).SetLocalPose(-0.2371443f,1.337506f,0.2408238f,0.7692378f,-0.01086253f,-0.0852342f,-0.633159f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.006262f);
Get(0x6EC6).SetLocalPose(-0.381317f,1.015336f,0.3007926f,0.4965834f,-0.3445598f,-0.6770863f,-0.4198067f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094642f,1.30927f,0.1332298f,-0.7030702f,-0.01441345f,-0.009694088f,0.7109082f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.03226831f);
Get(0x6E70).SetLocalPose(-0.2211532f,1.614178f,0.2813203f,0.5788804f,-0.5014241f,-0.4812973f,0.4264086f);
Get(0x6E82).SetLocalPose(-0.2281279f,1.337726f,0.2321265f,0.7877384f,0.01255779f,-0.06818098f,-0.6120963f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.067814f);
Get(0x6EC6).SetLocalPose(-0.3403135f,0.9953659f,0.3180043f,0.4765934f,-0.3556555f,-0.6950176f,-0.4041271f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.03226831f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.067814f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094957f,1.309662f,0.1333732f,-0.7030767f,-0.01442266f,-0.009672469f,0.710902f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.1660831f);
Get(0x6E70).SetLocalPose(-0.1897114f,1.621951f,0.2503838f,0.5564554f,-0.522459f,-0.4774969f,0.4351906f);
Get(0x6E82).SetLocalPose(-0.2153941f,1.333099f,0.2191992f,0.7880179f,0.04429922f,-0.1145103f,-0.6032851f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.03448677f);
Get(0x6EC6).SetLocalPose(-0.2041114f,0.9594332f,0.3890008f,0.3191929f,-0.3767081f,-0.7925464f,-0.3578787f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094738f,1.309428f,0.133219f,-0.7030599f,-0.01442348f,-0.009651648f,0.710919f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.2266883f);
Get(0x6E70).SetLocalPose(-0.1749313f,1.623325f,0.2342546f,0.5479952f,-0.5315248f,-0.4727189f,0.4401357f);
Get(0x6E82).SetLocalPose(-0.2102951f,1.329919f,0.2134851f,0.7887475f,0.05707897f,-0.1177688f,-0.6006247f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.095092f);
Get(0x6EC6).SetLocalPose(-0.1614696f,0.9596946f,0.408799f,0.2846703f,-0.4131126f,-0.7974316f,-0.3352666f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094785f,1.309735f,0.1332344f,-0.7030526f,-0.01441861f,-0.009647248f,0.7109262f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.2871477f);
Get(0x6E70).SetLocalPose(-0.1599534f,1.622805f,0.2194553f,0.5415818f,-0.5380886f,-0.4682766f,0.4448223f);
Get(0x6E82).SetLocalPose(-0.1993859f,1.32506f,0.2022854f,0.7960311f,0.07104933f,-0.1136112f,-0.5902364f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.1555514f);
Get(0x6EC6).SetLocalPose(-0.09077353f,0.9726903f,0.4385222f,0.2255067f,-0.4756409f,-0.7913299f,-0.3109815f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095018f,1.309601f,0.1331656f,-0.7030528f,-0.01440703f,-0.009674026f,0.7109259f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.3461437f);
Get(0x6E70).SetLocalPose(-0.1432383f,1.620814f,0.2030836f,0.5352329f,-0.5437033f,-0.4641013f,0.450025f);
Get(0x6E82).SetLocalPose(-0.1876921f,1.321705f,0.1912441f,0.8061334f,0.06451133f,-0.1134181f,-0.5771686f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.2145474f);
Get(0x6EC6).SetLocalPose(-0.03300432f,0.9927987f,0.462203f,0.1729467f,-0.5243478f,-0.7796482f,-0.2954613f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095397f,1.309614f,0.1332f,-0.7030563f,-0.01439762f,-0.009658961f,0.7109229f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.4057886f);
Get(0x6E70).SetLocalPose(-0.1275319f,1.619793f,0.1885627f,0.5296676f,-0.5480577f,-0.4608615f,0.4546334f);
Get(0x6E82).SetLocalPose(-0.1776218f,1.319962f,0.18122f,0.8194681f,0.05745505f,-0.1153659f,-0.5584458f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.2741923f);
Get(0x6EC6).SetLocalPose(0.01684465f,1.017265f,0.4802252f,0.1345294f,-0.5758197f,-0.7579446f,-0.2754151f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095394f,1.309513f,0.1332905f,-0.7030317f,-0.01444879f,-0.009633879f,0.7109464f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.4668588f);
Get(0x6E70).SetLocalPose(-0.1097142f,1.618734f,0.1730841f,0.5236085f,-0.552303f,-0.4578497f,0.4595315f);
Get(0x6E82).SetLocalPose(-0.1652654f,1.319223f,0.1699896f,0.8321772f,0.06886164f,-0.1081521f,-0.5394834f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.3352624f);
Get(0x6EC6).SetLocalPose(0.06458435f,1.052868f,0.4939499f,0.0927198f,-0.6302326f,-0.7260931f,-0.258841f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095114f,1.309199f,0.1330199f,-0.7030621f,-0.01440505f,-0.009636792f,0.7109174f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.4934843f);
Get(0x6E70).SetLocalPose(-0.0989925f,1.618029f,0.1638515f,0.5202098f,-0.554382f,-0.4563805f,0.4623411f);
Get(0x6E82).SetLocalPose(-0.1589659f,1.319774f,0.1648153f,0.8366186f,0.07919898f,-0.104202f,-0.5319199f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.361888f);
Get(0x6EC6).SetLocalPose(0.08777912f,1.073282f,0.4992507f,0.07236584f,-0.654197f,-0.7081528f,-0.2555564f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095238f,1.309224f,0.1328257f,-0.7030538f,-0.01437029f,-0.009674867f,0.7109256f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.5982628f);
Get(0x6E70).SetLocalPose(-0.06908667f,1.620305f,0.1392007f,0.512066f,-0.5578011f,-0.4532819f,0.4702998f);
Get(0x6E82).SetLocalPose(-0.1366379f,1.327089f,0.1505812f,0.8499849f,0.08939742f,-0.1036592f,-0.5087126f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.4666665f);
Get(0x6EC6).SetLocalPose(0.1549221f,1.151586f,0.5009102f,0.03233427f,-0.7273403f,-0.6342722f,-0.2600569f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09533f,1.309169f,0.1328341f,-0.7030545f,-0.0143776f,-0.009622462f,0.7109255f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.6621501f);
Get(0x6E70).SetLocalPose(-0.05216019f,1.624143f,0.1256295f,0.5082828f,-0.5579959f,-0.4518103f,0.4755592f);
Get(0x6E82).SetLocalPose(-0.1235028f,1.334396f,0.1453839f,0.8521954f,0.08129138f,-0.1032879f,-0.5064449f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.5305538f);
Get(0x6EC6).SetLocalPose(0.1818309f,1.194149f,0.4912321f,0.03038356f,-0.7627833f,-0.590837f,-0.2610556f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09526f,1.308923f,0.1327295f,-0.7030453f,-0.01439751f,-0.009615912f,0.7109343f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.7247218f);
Get(0x6E70).SetLocalPose(-0.03811615f,1.630748f,0.1142222f,0.5049345f,-0.5573477f,-0.4515173f,0.4801424f);
Get(0x6E82).SetLocalPose(-0.106835f,1.3455f,0.139867f,0.8549244f,0.05975369f,-0.1086506f,-0.503715f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.5931255f);
Get(0x6EC6).SetLocalPose(0.2080334f,1.236481f,0.4770876f,0.02847926f,-0.7933677f,-0.5484535f,-0.2625938f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095078f,1.309094f,0.1327355f,-0.7030566f,-0.01438122f,-0.00963091f,0.7109234f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.7849301f);
Get(0x6E70).SetLocalPose(-0.02405467f,1.639057f,0.1035536f,0.5010333f,-0.5559967f,-0.4526953f,0.4846652f);
Get(0x6E82).SetLocalPose(-0.09171487f,1.35748f,0.1348981f,0.856952f,0.04126782f,-0.1170302f,-0.5002341f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.6533338f);
Get(0x6EC6).SetLocalPose(0.2336168f,1.279738f,0.4579353f,0.02045366f,-0.819722f,-0.5041836f,-0.2709916f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095043f,1.309152f,0.1327238f,-0.7030423f,-0.01435783f,-0.009654737f,0.7109376f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.8451138f);
Get(0x6E70).SetLocalPose(-0.008091276f,1.651376f,0.09145181f,0.4948913f,-0.5532694f,-0.4567164f,0.4902914f);
Get(0x6E82).SetLocalPose(-0.0771015f,1.371344f,0.130509f,0.8565357f,0.02614788f,-0.1311317f,-0.4984651f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.7135175f);
Get(0x6EC6).SetLocalPose(0.2556262f,1.319309f,0.4341737f,0.0126943f,-0.8417484f,-0.4627629f,-0.2777571f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095192f,1.309026f,0.1330103f,-0.7030445f,-0.01438097f,-0.009640259f,0.7109351f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.9077446f);
Get(0x6E70).SetLocalPose(0.004834679f,1.664867f,0.08064611f,0.4879862f,-0.5493707f,-0.4633151f,0.4953791f);
Get(0x6E82).SetLocalPose(-0.06126857f,1.385584f,0.1275234f,0.8534118f,0.006233452f,-0.1506717f,-0.4989464f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.7761483f);
Get(0x6EC6).SetLocalPose(0.2759179f,1.35476f,0.4085729f,0.002807773f,-0.8588287f,-0.4260159f,-0.2844573f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095436f,1.309004f,0.1330809f,-0.7030789f,-0.01442674f,-0.009591541f,0.7109008f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.9674382f);
Get(0x6E70).SetLocalPose(0.01628123f,1.681486f,0.07115112f,0.4801837f,-0.5440548f,-0.4720714f,0.5005764f);
Get(0x6E82).SetLocalPose(-0.04611589f,1.399367f,0.1252064f,0.8474615f,-0.01546449f,-0.169838f,-0.5027177f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.8358418f);
Get(0x6EC6).SetLocalPose(0.2911526f,1.382241f,0.3847094f,-0.00681567f,-0.8689436f,-0.4007561f,-0.290319f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.9674382f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.8358418f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095236f,1.309573f,0.133093f,-0.7030715f,-0.01436952f,-0.009611841f,0.7109091f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.067101f);
Get(0x6E70).SetLocalPose(0.0353731f,1.715741f,0.05530937f,0.4649305f,-0.5329896f,-0.488814f,0.5107081f);
Get(0x6E82).SetLocalPose(-0.01656914f,1.427634f,0.1201232f,0.8307261f,-0.05914809f,-0.2031621f,-0.514899f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.9355049f);
Get(0x6EC6).SetLocalPose(0.3156751f,1.427571f,0.3327281f,-0.02511275f,-0.8826446f,-0.3621894f,-0.2985411f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09516f,1.309623f,0.133124f,-0.7030631f,-0.01440338f,-0.009601525f,0.7109168f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.140556f);
Get(0x6E70).SetLocalPose(0.04131461f,1.729149f,0.04906711f,0.458185f,-0.5291493f,-0.4947292f,0.5150832f);
Get(0x6E82).SetLocalPose(0.0005548191f,1.4418f,0.1143444f,0.8211813f,-0.08461819f,-0.225095f,-0.5175261f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.00896f);
Get(0x6EC6).SetLocalPose(0.3251654f,1.44537f,0.3069581f,-0.03395143f,-0.8881438f,-0.3478186f,-0.2984461f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094896f,1.309569f,0.1329138f,-0.7030562f,-0.01440239f,-0.009600855f,0.7109237f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.201225f);
Get(0x6E70).SetLocalPose(0.05071659f,1.750665f,0.03668025f,0.444765f,-0.5232889f,-0.5025806f,0.5251337f);
Get(0x6E82).SetLocalPose(0.01280315f,1.453023f,0.1088241f,0.8101038f,-0.09838001f,-0.2460175f,-0.5229996f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.069628f);
Get(0x6EC6).SetLocalPose(0.3318312f,1.455731f,0.2879123f,-0.0418378f,-0.8911293f,-0.3390734f,-0.298609f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094871f,1.309268f,0.1329156f,-0.703063f,-0.0143484f,-0.009659538f,0.7109172f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.260941f);
Get(0x6E70).SetLocalPose(0.05713572f,1.762232f,0.02602665f,0.4347009f,-0.5195782f,-0.5052021f,0.5346443f);
Get(0x6E82).SetLocalPose(0.02492116f,1.463068f,0.1016051f,0.793684f,-0.1144613f,-0.2767862f,-0.5294845f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.129344f);
Get(0x6EC6).SetLocalPose(0.3407268f,1.469466f,0.2569796f,-0.05741407f,-0.8927929f,-0.3270795f,-0.304374f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095019f,1.309123f,0.1329173f,-0.703056f,-0.0143755f,-0.009682439f,0.7109233f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.320825f);
Get(0x6E70).SetLocalPose(0.06184641f,1.767307f,0.01601018f,0.428378f,-0.5155599f,-0.506204f,0.5426305f);
Get(0x6E82).SetLocalPose(0.03530951f,1.469438f,0.09375718f,0.7783518f,-0.1316298f,-0.3061555f,-0.5320816f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.189228f);
Get(0x6EC6).SetLocalPose(0.3469332f,1.476621f,0.2291315f,-0.06680924f,-0.8942624f,-0.31591f,-0.3098906f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095001f,1.309119f,0.1329617f,-0.7030426f,-0.01433656f,-0.009676028f,0.7109374f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.381895f);
Get(0x6E70).SetLocalPose(0.06672175f,1.768538f,0.003680843f,0.4251209f,-0.5096367f,-0.5081302f,0.5489503f);
Get(0x6E82).SetLocalPose(0.04548794f,1.472302f,0.08328068f,0.767694f,-0.1490476f,-0.3279015f,-0.5300108f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.250299f);
Get(0x6EC6).SetLocalPose(0.3511002f,1.479003f,0.205814f,-0.07139049f,-0.8975682f,-0.3050393f,-0.310203f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095162f,1.309058f,0.1329345f,-0.7030612f,-0.01437902f,-0.009655633f,0.7109184f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.443454f);
Get(0x6E70).SetLocalPose(0.07141804f,1.766372f,-0.009255431f,0.4223655f,-0.5035779f,-0.5123557f,0.5527281f);
Get(0x6E82).SetLocalPose(0.05559528f,1.472007f,0.06852731f,0.7644485f,-0.1670634f,-0.3398269f,-0.5217527f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.311858f);
Get(0x6EC6).SetLocalPose(0.3544524f,1.477985f,0.1865029f,-0.07653003f,-0.9001178f,-0.2962979f,-0.3100626f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.443454f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.311858f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095129f,1.309062f,0.1326972f,-0.7030572f,-0.01433298f,-0.009685648f,0.710923f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.57881f);
Get(0x6E70).SetLocalPose(0.08152641f,1.749942f,-0.03942331f,0.4135876f,-0.4913337f,-0.5254308f,0.5580851f);
Get(0x6E82).SetLocalPose(0.07394399f,1.457753f,0.04092343f,0.765927f,-0.2017556f,-0.3510166f,-0.4994376f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.447214f);
Get(0x6EC6).SetLocalPose(0.3601203f,1.461933f,0.1396877f,-0.09249759f,-0.9009192f,-0.2793157f,-0.3190164f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095115f,1.309024f,0.1327767f,-0.7030404f,-0.01431849f,-0.009687939f,0.7109397f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.63822f);
Get(0x6E70).SetLocalPose(0.08626776f,1.736077f,-0.05347977f,0.410684f,-0.4856122f,-0.5303594f,0.5605696f);
Get(0x6E82).SetLocalPose(0.08368591f,1.442894f,0.02305687f,0.7669436f,-0.2139049f,-0.3571075f,-0.4883814f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.506624f);
Get(0x6EC6).SetLocalPose(0.3612704f,1.449942f,0.1200453f,-0.09229695f,-0.9025139f,-0.2747908f,-0.3184963f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09513f,1.309405f,0.1329073f,-0.7030562f,-0.01438934f,-0.009644845f,0.7109234f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.700167f);
Get(0x6E70).SetLocalPose(0.09033848f,1.719704f,-0.06762692f,0.4091529f,-0.480058f,-0.5340681f,0.5629473f);
Get(0x6E82).SetLocalPose(0.09040423f,1.426131f,0.008011567f,0.7665243f,-0.2145994f,-0.3657471f,-0.4823036f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.568571f);
Get(0x6EC6).SetLocalPose(0.3618623f,1.436705f,0.1029997f,-0.08929346f,-0.9050873f,-0.2713144f,-0.3150116f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095205f,1.309339f,0.1329661f,-0.7030485f,-0.01434691f,-0.009629274f,0.710932f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.726557f);
Get(0x6E70).SetLocalPose(0.09304693f,1.707905f,-0.07744896f,0.4084446f,-0.4766502f,-0.5364872f,0.564056f);
Get(0x6E82).SetLocalPose(0.09416037f,1.414167f,-0.0002374028f,0.7645857f,-0.2127681f,-0.3723329f,-0.4811515f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.59496f);
Get(0x6EC6).SetLocalPose(0.3619146f,1.426735f,0.09223806f,-0.08821979f,-0.9060815f,-0.2702236f,-0.3133894f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094932f,1.308968f,0.1328583f,-0.7030621f,-0.01432524f,-0.009656278f,0.7109187f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.833063f);
Get(0x6E70).SetLocalPose(0.09938926f,1.682549f,-0.09834278f,0.4092455f,-0.4696529f,-0.5400072f,0.5659828f);
Get(0x6E82).SetLocalPose(0.1070784f,1.381351f,-0.01785193f,0.7548599f,-0.2069142f,-0.3886324f,-0.4861461f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.701467f);
Get(0x6EC6).SetLocalPose(0.3645688f,1.396082f,0.06724779f,-0.0932547f,-0.9014881f,-0.2746304f,-0.321249f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094974f,1.309022f,0.1330294f,-0.7030767f,-0.01433639f,-0.009656036f,0.7109039f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.891646f);
Get(0x6E70).SetLocalPose(0.1042592f,1.666511f,-0.1103819f,0.4119263f,-0.4651048f,-0.5414892f,0.5663778f);
Get(0x6E82).SetLocalPose(0.1160021f,1.361096f,-0.02676333f,0.746991f,-0.2019439f,-0.395968f,-0.4944012f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.760049f);
Get(0x6EC6).SetLocalPose(0.3663227f,1.370939f,0.05016362f,-0.1015408f,-0.8949925f,-0.2831825f,-0.3293714f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095048f,1.309119f,0.1328517f,-0.7030713f,-0.01435636f,-0.009637566f,0.7109091f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.92004f);
Get(0x6E70).SetLocalPose(0.1070572f,1.657734f,-0.1170863f,0.4146576f,-0.462083f,-0.5425347f,0.5658573f);
Get(0x6E82).SetLocalPose(0.1223106f,1.347016f,-0.03345257f,0.7418305f,-0.1947445f,-0.4000327f,-0.501733f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.788444f);
Get(0x6EC6).SetLocalPose(0.3670058f,1.36087f,0.04389162f,-0.1038817f,-0.892775f,-0.2880729f,-0.3304168f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.92004f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.788444f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094744f,1.309514f,0.132913f,-0.7030739f,-0.01436131f,-0.009635526f,0.7109064f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.062047f);
Get(0x6E70).SetLocalPose(0.1201369f,1.625194f,-0.1481073f,0.4381164f,-0.4441546f,-0.5523573f,0.5528854f);
Get(0x6E82).SetLocalPose(0.1454103f,1.299588f,-0.05674221f,0.7062643f,-0.1465701f,-0.4254334f,-0.5465478f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.93045f);
Get(0x6EC6).SetLocalPose(0.3708111f,1.298504f,0.01114447f,-0.1321181f,-0.8708192f,-0.334859f,-0.3347961f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094936f,1.309557f,0.1330891f,-0.7030793f,-0.01441179f,-0.009634061f,0.7109001f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.122603f);
Get(0x6E70).SetLocalPose(0.1271555f,1.612455f,-0.1648881f,0.453778f,-0.4342152f,-0.5591521f,0.5411947f);
Get(0x6E82).SetLocalPose(0.1550042f,1.28218f,-0.06851891f,0.6813618f,-0.1240471f,-0.4442081f,-0.5683641f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.991007f);
Get(0x6EC6).SetLocalPose(0.3729212f,1.275756f,-0.002837741f,-0.1526704f,-0.8539158f,-0.3579687f,-0.3455114f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095009f,1.309556f,0.1330731f,-0.7030677f,-0.01442853f,-0.009601319f,0.7109118f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.181009f);
Get(0x6E70).SetLocalPose(0.1330802f,1.603531f,-0.1789515f,0.467292f,-0.4261303f,-0.5640458f,0.5309457f);
Get(0x6E82).SetLocalPose(0.161734f,1.270406f,-0.08266995f,0.6656022f,-0.1000528f,-0.4545873f,-0.5833641f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.049412f);
Get(0x6EC6).SetLocalPose(0.3753901f,1.252166f,-0.02269772f,-0.1693471f,-0.8367882f,-0.3824314f,-0.353346f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095353f,1.309642f,0.1331886f,-0.7030653f,-0.01442202f,-0.009578223f,0.7109146f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.237747f);
Get(0x6E70).SetLocalPose(0.1389599f,1.596923f,-0.1932966f,0.4811258f,-0.4181304f,-0.567636f,0.521032f);
Get(0x6E82).SetLocalPose(0.1663142f,1.262976f,-0.1004055f,0.6595259f,-0.0736507f,-0.4545606f,-0.5941176f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.106151f);
Get(0x6EC6).SetLocalPose(0.3767711f,1.234884f,-0.04456221f,-0.1736696f,-0.8256448f,-0.4064812f,-0.3506031f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095516f,1.309141f,0.1329695f,-0.7030627f,-0.01441627f,-0.00956764f,0.7109174f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.323014f);
Get(0x6E70).SetLocalPose(0.1481034f,1.591847f,-0.2146646f,0.5017056f,-0.407143f,-0.5698336f,0.5077556f);
Get(0x6E82).SetLocalPose(0.171541f,1.258025f,-0.1275626f,0.6557863f,-0.04038478f,-0.4501819f,-0.6046898f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.191418f);
Get(0x6EC6).SetLocalPose(0.3811921f,1.217993f,-0.07823166f,-0.1768078f,-0.8093371f,-0.4373238f,-0.3499435f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095671f,1.309225f,0.132977f,-0.7030708f,-0.01444353f,-0.009536709f,0.7109092f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.381745f);
Get(0x6E70).SetLocalPose(0.1546575f,1.591825f,-0.229344f,0.5139759f,-0.4011784f,-0.5708334f,0.499033f);
Get(0x6E82).SetLocalPose(0.176033f,1.257109f,-0.1489427f,0.6513095f,-0.02280696f,-0.4485958f,-0.6115862f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.250149f);
Get(0x6EC6).SetLocalPose(0.3862967f,1.210359f,-0.1002914f,-0.1827872f,-0.7965523f,-0.4545147f,-0.3542733f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.381745f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.250149f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095344f,1.309579f,0.1329855f,-0.7030767f,-0.01442197f,-0.009581539f,0.7109033f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.487285f);
Get(0x6E70).SetLocalPose(0.1646799f,1.598091f,-0.2553546f,0.5324983f,-0.3916959f,-0.5752355f,0.4817925f);
Get(0x6E82).SetLocalPose(0.1848343f,1.261403f,-0.1890999f,0.6454685f,-0.005010863f,-0.4371908f,-0.6262664f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.355689f);
Get(0x6EC6).SetLocalPose(0.3983828f,1.20632f,-0.1456406f,-0.1906172f,-0.7727323f,-0.4880988f,-0.3582031f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095122f,1.309361f,0.1331053f,-0.7031113f,-0.01440539f,-0.009640886f,0.7108686f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.555461f);
Get(0x6E70).SetLocalPose(0.1679417f,1.60179f,-0.2678843f,0.5409488f,-0.386973f,-0.5777586f,0.4730977f);
Get(0x6E82).SetLocalPose(0.1893835f,1.268746f,-0.209801f,0.649129f,-0.006232008f,-0.4257343f,-0.6303515f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.423865f);
Get(0x6EC6).SetLocalPose(0.4046851f,1.20777f,-0.165914f,-0.1906901f,-0.764472f,-0.5019863f,-0.3566927f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095032f,1.309412f,0.1330696f,-0.7030864f,-0.01442139f,-0.009643946f,0.7108927f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.618307f);
Get(0x6E70).SetLocalPose(0.1717012f,1.609158f,-0.283784f,0.5496817f,-0.3817449f,-0.5804234f,0.4639284f);
Get(0x6E82).SetLocalPose(0.1924034f,1.278587f,-0.2308414f,0.6579288f,-0.01340136f,-0.4136739f,-0.6291454f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.486711f);
Get(0x6EC6).SetLocalPose(0.4115458f,1.210193f,-0.1867838f,-0.1901556f,-0.7592949f,-0.5134363f,-0.3517033f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095213f,1.309441f,0.1331634f,-0.7030745f,-0.01434832f,-0.009658681f,0.7109059f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.681371f);
Get(0x6E70).SetLocalPose(0.1747257f,1.616682f,-0.2990723f,0.5552382f,-0.3785488f,-0.5822136f,0.4576446f);
Get(0x6E82).SetLocalPose(0.1939474f,1.289431f,-0.2495909f,0.668527f,-0.02147209f,-0.4011879f,-0.6258266f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.549775f);
Get(0x6EC6).SetLocalPose(0.4189092f,1.213922f,-0.2061745f,-0.1924065f,-0.7543885f,-0.5226579f,-0.3474286f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095285f,1.309252f,0.1331548f,-0.7030909f,-0.01441273f,-0.009620759f,0.7108889f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.741811f);
Get(0x6E70).SetLocalPose(0.1760176f,1.624163f,-0.3131621f,0.5577057f,-0.3773036f,-0.5833765f,0.4541785f);
Get(0x6E82).SetLocalPose(0.1951349f,1.3012f,-0.2673673f,0.6778746f,-0.02709976f,-0.390073f,-0.6225712f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.610214f);
Get(0x6EC6).SetLocalPose(0.4261369f,1.218463f,-0.2240793f,-0.1983229f,-0.7495998f,-0.5300458f,-0.3432489f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095448f,1.309463f,0.1331612f,-0.7031f,-0.01442704f,-0.009600728f,0.7108799f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.801563f);
Get(0x6E70).SetLocalPose(0.1769483f,1.630193f,-0.3242188f,0.5591085f,-0.3767669f,-0.5837024f,0.4524776f);
Get(0x6E82).SetLocalPose(0.1951959f,1.310311f,-0.2804436f,0.6835972f,-0.02839343f,-0.3835183f,-0.6203244f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.669966f);
Get(0x6EC6).SetLocalPose(0.4325573f,1.223075f,-0.2412961f,-0.2043931f,-0.7451247f,-0.5360709f,-0.34006f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095222f,1.309465f,0.1330945f,-0.7030866f,-0.01442195f,-0.009607202f,0.710893f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.862491f);
Get(0x6E70).SetLocalPose(0.1772279f,1.636719f,-0.3393322f,0.5613677f,-0.3762347f,-0.5833286f,0.4506014f);
Get(0x6E82).SetLocalPose(0.1938222f,1.323532f,-0.297245f,0.6882249f,-0.02770979f,-0.3772354f,-0.6190897f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.730895f);
Get(0x6EC6).SetLocalPose(0.4375696f,1.22866f,-0.2578384f,-0.2061909f,-0.7420281f,-0.541743f,-0.3367407f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.862491f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.730895f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095127f,1.309041f,0.1329742f,-0.7030863f,-0.01438485f,-0.009644223f,0.7108937f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.968112f);
Get(0x6E70).SetLocalPose(0.1775473f,1.643435f,-0.3662477f,0.5649567f,-0.3760688f,-0.5832014f,0.4463993f);
Get(0x6E82).SetLocalPose(0.1904703f,1.339017f,-0.3206164f,0.6921942f,-0.02591016f,-0.3739692f,-0.6167195f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.836516f);
Get(0x6EC6).SetLocalPose(0.4430753f,1.239069f,-0.2865708f,-0.1956158f,-0.7453429f,-0.5481079f,-0.3252328f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095038f,1.309415f,0.1330556f,-0.7030925f,-0.01435003f,-0.00966619f,0.7108879f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.04161f);
Get(0x6E70).SetLocalPose(0.1769097f,1.64623f,-0.382853f,0.5655657f,-0.3771262f,-0.5838879f,0.4438313f);
Get(0x6E82).SetLocalPose(0.1866927f,1.345621f,-0.333944f,0.6950089f,-0.02336634f,-0.3722477f,-0.6146938f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.910014f);
Get(0x6EC6).SetLocalPose(0.4449466f,1.245373f,-0.303673f,-0.1865887f,-0.7496489f,-0.5489901f,-0.3190942f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09501f,1.309517f,0.1331407f,-0.7030668f,-0.01436545f,-0.009626446f,0.7109136f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.1016f);
Get(0x6E70).SetLocalPose(0.1767331f,1.647712f,-0.3963153f,0.5652422f,-0.3783198f,-0.5845205f,0.4423926f);
Get(0x6E82).SetLocalPose(0.1836627f,1.348639f,-0.3444978f,0.6969463f,-0.02011662f,-0.3715335f,-0.613045f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.970004f);
Get(0x6EC6).SetLocalPose(0.44617f,1.249165f,-0.3170756f,-0.1796163f,-0.7532877f,-0.5482652f,-0.3157544f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094849f,1.309097f,0.1329982f,-0.7030816f,-0.01435398f,-0.009645016f,0.7108989f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.161871f);
Get(0x6E70).SetLocalPose(0.1772871f,1.648284f,-0.4127612f,0.5640797f,-0.379802f,-0.5860263f,0.4406107f);
Get(0x6E82).SetLocalPose(0.1810537f,1.349703f,-0.3553997f,0.6978059f,-0.01926317f,-0.3724201f,-0.6115548f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.030275f);
Get(0x6EC6).SetLocalPose(0.4473526f,1.252015f,-0.3333623f,-0.1715465f,-0.7581266f,-0.5461472f,-0.3123126f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094557f,1.309152f,0.132819f,-0.7030584f,-0.01431843f,-0.009626718f,0.7109228f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.221632f);
Get(0x6E70).SetLocalPose(0.1766537f,1.647521f,-0.4251464f,0.562657f,-0.3807694f,-0.5884998f,0.4382919f);
Get(0x6E82).SetLocalPose(0.1794297f,1.349124f,-0.3635058f,0.6982135f,-0.02032868f,-0.3749805f,-0.6094869f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.090036f);
Get(0x6EC6).SetLocalPose(0.447965f,1.253228f,-0.3435881f,-0.1679122f,-0.7613513f,-0.5442274f,-0.3097844f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094712f,1.309231f,0.1328495f,-0.7030514f,-0.01432431f,-0.009642236f,0.7109294f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.283345f);
Get(0x6E70).SetLocalPose(0.1763983f,1.645769f,-0.4388245f,0.5607053f,-0.3811193f,-0.593074f,0.4343051f);
Get(0x6E82).SetLocalPose(0.1781816f,1.347053f,-0.3728379f,0.696249f,-0.0225366f,-0.3784822f,-0.6094921f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.151749f);
Get(0x6EC6).SetLocalPose(0.4487743f,1.253631f,-0.3564025f,-0.1656898f,-0.765156f,-0.5418345f,-0.3057756f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094845f,1.309307f,0.1328877f,-0.703057f,-0.01435074f,-0.00962063f,0.7109236f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.344992f);
Get(0x6E70).SetLocalPose(0.1758917f,1.643011f,-0.4518267f,0.5582445f,-0.3803832f,-0.5999832f,0.4285931f);
Get(0x6E82).SetLocalPose(0.1778077f,1.341287f,-0.3852968f,0.6880466f,-0.0257895f,-0.3821875f,-0.6163275f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.213396f);
Get(0x6EC6).SetLocalPose(0.4490018f,1.253028f,-0.3753629f,-0.1645263f,-0.7712921f,-0.5386268f,-0.2965143f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.344992f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.213396f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095054f,1.309482f,0.1331964f,-0.703065f,-0.014321f,-0.009654155f,0.7109159f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.479999f);
Get(0x6E70).SetLocalPose(0.1753493f,1.635163f,-0.4784532f,0.5490125f,-0.3731913f,-0.6262223f,0.4088511f);
Get(0x6E82).SetLocalPose(0.1811118f,1.32697f,-0.4039818f,0.6748752f,-0.04612094f,-0.3838587f,-0.628545f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.348403f);
Get(0x6EC6).SetLocalPose(0.446054f,1.250513f,-0.4086533f,-0.1637958f,-0.7836697f,-0.5325084f,-0.2747137f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09486f,1.309452f,0.1330025f,-0.7030541f,-0.01436818f,-0.009666165f,0.7109255f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.542745f);
Get(0x6E70).SetLocalPose(0.1752664f,1.630184f,-0.4881496f,0.542956f,-0.3677164f,-0.6414463f,0.3981585f);
Get(0x6E82).SetLocalPose(0.183385f,1.319377f,-0.4136035f,0.6756679f,-0.05835349f,-0.3770311f,-0.6308053f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.411149f);
Get(0x6EC6).SetLocalPose(0.4435579f,1.24865f,-0.425392f,-0.1678524f,-0.7874373f,-0.5299329f,-0.2663441f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094842f,1.309233f,0.1328199f,-0.7030777f,-0.01432557f,-0.009663329f,0.710903f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.605254f);
Get(0x6E70).SetLocalPose(0.1761038f,1.623657f,-0.4957546f,0.5368592f,-0.3614184f,-0.6563295f,0.3878022f);
Get(0x6E82).SetLocalPose(0.1844364f,1.3144f,-0.4199835f,0.6762174f,-0.0644968f,-0.3699282f,-0.6338166f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.473658f);
Get(0x6EC6).SetLocalPose(0.441173f,1.247037f,-0.4424393f,-0.1749782f,-0.7897177f,-0.5275438f,-0.259665f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095018f,1.309004f,0.1329549f,-0.7030917f,-0.01431962f,-0.009694379f,0.710889f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.666382f);
Get(0x6E70).SetLocalPose(0.1760822f,1.615264f,-0.5037336f,0.5294546f,-0.3524688f,-0.6743837f,0.3750336f);
Get(0x6E82).SetLocalPose(0.1841816f,1.306281f,-0.4300145f,0.6682981f,-0.0704828f,-0.3686452f,-0.6422698f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.534786f);
Get(0x6EC6).SetLocalPose(0.4378889f,1.244506f,-0.4598712f,-0.1825595f,-0.7918365f,-0.5256258f,-0.251763f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095384f,1.30903f,0.1330426f,-0.703077f,-0.01434889f,-0.009660142f,0.7109033f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.726117f);
Get(0x6E70).SetLocalPose(0.1758318f,1.605361f,-0.5110018f,0.5220131f,-0.3406321f,-0.6937783f,0.3607545f);
Get(0x6E82).SetLocalPose(0.1804147f,1.303368f,-0.4370398f,0.656276f,-0.06750429f,-0.3876292f,-0.6438079f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.594521f);
Get(0x6EC6).SetLocalPose(0.4346334f,1.241632f,-0.4764588f,-0.1892259f,-0.7938683f,-0.5239207f,-0.2438723f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095295f,1.309078f,0.1330306f,-0.7030728f,-0.0143697f,-0.009675864f,0.7109069f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.785733f);
Get(0x6E70).SetLocalPose(0.1744773f,1.593622f,-0.5182104f,0.5156282f,-0.3254713f,-0.7134428f,0.3452468f);
Get(0x6E82).SetLocalPose(0.1747255f,1.302646f,-0.445851f,0.6460834f,-0.05660789f,-0.4104419f,-0.641022f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.654137f);
Get(0x6EC6).SetLocalPose(0.4304278f,1.237656f,-0.4954174f,-0.1971173f,-0.7958217f,-0.5218725f,-0.2355032f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095029f,1.309122f,0.1329814f,-0.703082f,-0.01434745f,-0.009676788f,0.7108982f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.815321f);
Get(0x6E70).SetLocalPose(0.1737035f,1.586128f,-0.5221405f,0.5131616f,-0.3168711f,-0.7227719f,0.3374295f);
Get(0x6E82).SetLocalPose(0.1698845f,1.304254f,-0.4514343f,0.6446607f,-0.04805434f,-0.4194135f,-0.6373349f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.683725f);
Get(0x6EC6).SetLocalPose(0.427765f,1.234915f,-0.5073594f,-0.2018325f,-0.7970927f,-0.5202985f,-0.230643f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094893f,1.309523f,0.1332112f,-0.7030842f,-0.01436933f,-0.00964898f,0.7108959f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.920678f);
Get(0x6E70).SetLocalPose(0.1689098f,1.561721f,-0.5349104f,0.5083923f,-0.2856524f,-0.7494307f,0.3135183f);
Get(0x6E82).SetLocalPose(0.149636f,1.318303f,-0.4679758f,0.6790574f,-0.01482723f,-0.4170102f,-0.6039568f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.789082f);
Get(0x6EC6).SetLocalPose(0.4211792f,1.2292f,-0.5373546f,-0.2159577f,-0.800541f,-0.5133669f,-0.2212484f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095055f,1.309455f,0.1330689f,-0.7030755f,-0.01436234f,-0.009629332f,0.710905f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.955758f);
Get(0x6E70).SetLocalPose(0.1666793f,1.553405f,-0.5392599f,0.5077842f,-0.2746534f,-0.7568789f,0.3063577f);
Get(0x6E82).SetLocalPose(0.1410671f,1.325568f,-0.4716475f,0.6917773f,-6.059324E-05f,-0.4134706f,-0.5920189f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.824162f);
Get(0x6EC6).SetLocalPose(0.419263f,1.228228f,-0.5484449f,-0.2234509f,-0.8027689f,-0.5078725f,-0.2183974f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094681f,1.309353f,0.1331338f,-0.7030754f,-0.01433276f,-0.009687355f,0.710905f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.047554f);
Get(0x6E70).SetLocalPose(0.1596923f,1.536262f,-0.5486782f,0.5073205f,-0.2512407f,-0.7712536f,0.2909845f);
Get(0x6E82).SetLocalPose(0.1192052f,1.344051f,-0.4769464f,0.7109173f,0.03176042f,-0.4197771f,-0.5633606f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.915958f);
Get(0x6EC6).SetLocalPose(0.4164664f,1.232794f,-0.5740649f,-0.2444215f,-0.8124689f,-0.4858489f,-0.2100079f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094903f,1.309035f,0.1328281f,-0.7030568f,-0.01441547f,-0.009661829f,0.710922f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.108758f);
Get(0x6E70).SetLocalPose(0.1528411f,1.525901f,-0.5556637f,0.5091404f,-0.2369223f,-0.7787031f,0.2797597f);
Get(0x6E82).SetLocalPose(0.09780788f,1.363692f,-0.4820669f,0.7251716f,0.05096102f,-0.4300477f,-0.5353394f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.977162f);
Get(0x6EC6).SetLocalPose(0.4134382f,1.245667f,-0.5965037f,-0.2593791f,-0.8260726f,-0.4593038f,-0.19841f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095237f,1.308996f,0.1331656f,-0.7030836f,-0.01438902f,-0.009694609f,0.7108955f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.168836f);
Get(0x6E70).SetLocalPose(0.1461022f,1.517606f,-0.5628211f,0.5123268f,-0.2262908f,-0.7835807f,0.2689146f);
Get(0x6E82).SetLocalPose(0.08208509f,1.379631f,-0.4887205f,0.7472863f,0.05680934f,-0.4269742f,-0.5059932f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0f);
Get(0x6EC6).SetLocalPose(0.4095444f,1.262114f,-0.6143976f,-0.26127f,-0.8407401f,-0.4338553f,-0.1914779f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095146f,1.309101f,0.1332493f,-0.7030972f,-0.01439678f,-0.009683862f,0.7108821f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.227916f);
Get(0x6E70).SetLocalPose(0.1380369f,1.510493f,-0.5727499f,0.5174713f,-0.2164395f,-0.78734f,0.2558774f);
Get(0x6E82).SetLocalPose(0.06264574f,1.402765f,-0.5013551f,0.7846127f,0.05799526f,-0.4122758f,-0.4593999f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.05908062f);
Get(0x6EC6).SetLocalPose(0.4050485f,1.282686f,-0.633064f,-0.2591637f,-0.8576349f,-0.4034523f,-0.1858033f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09529f,1.309113f,0.1334318f,-0.7031269f,-0.01442358f,-0.009657373f,0.7108525f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.290244f);
Get(0x6E70).SetLocalPose(0.130873f,1.506282f,-0.581319f,0.5225917f,-0.210253f,-0.7889527f,0.2454492f);
Get(0x6E82).SetLocalPose(0.04605374f,1.422344f,-0.5168788f,0.8214526f,0.06105233f,-0.3885743f,-0.4129143f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.1214083f);
Get(0x6EC6).SetLocalPose(0.3978702f,1.309984f,-0.6553786f,-0.2544985f,-0.878551f,-0.3635813f,-0.1765994f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.290244f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.1214083f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095179f,1.309347f,0.1335108f,-0.703108f,-0.01440879f,-0.009657219f,0.7108716f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.388713f);
Get(0x6E70).SetLocalPose(0.1181125f,1.503168f,-0.5958268f,0.5303605f,-0.2051738f,-0.78894f,0.2327989f);
Get(0x6E82).SetLocalPose(0.02189156f,1.453614f,-0.5487692f,0.8655452f,0.05276027f,-0.3592903f,-0.3449036f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.2198772f);
Get(0x6EC6).SetLocalPose(0.3867024f,1.356537f,-0.6886411f,-0.2377427f,-0.9082122f,-0.3016289f,-0.1662802f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095282f,1.309276f,0.1335782f,-0.7031245f,-0.01442188f,-0.009643234f,0.7108551f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.458012f);
Get(0x6E70).SetLocalPose(0.1119178f,1.504119f,-0.6033588f,0.5336249f,-0.2050173f,-0.7878762f,0.229049f);
Get(0x6E82).SetLocalPose(0.01336971f,1.468182f,-0.5658136f,0.8840964f,0.03945331f,-0.3413776f,-0.3166679f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.2891757f);
Get(0x6EC6).SetLocalPose(0.3823737f,1.377149f,-0.7023683f,-0.2318329f,-0.9191982f,-0.2741689f,-0.1617397f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095043f,1.309093f,0.1333528f,-0.7031211f,-0.01437876f,-0.009679976f,0.7108589f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.516195f);
Get(0x6E70).SetLocalPose(0.1040194f,1.506181f,-0.6127059f,0.5371289f,-0.2071853f,-0.7854974f,0.2270699f);
Get(0x6E82).SetLocalPose(0.006769101f,1.481852f,-0.5867785f,0.9082137f,0.02526702f,-0.3083805f,-0.2817994f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.3473594f);
Get(0x6EC6).SetLocalPose(0.3782283f,1.403909f,-0.7200179f,-0.2325878f,-0.9309162f,-0.2355146f,-0.1543722f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095141f,1.308822f,0.1331775f,-0.7031086f,-0.01435926f,-0.009685377f,0.7108715f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.59813f);
Get(0x6E70).SetLocalPose(0.09568223f,1.509513f,-0.6233953f,0.5412789f,-0.212207f,-0.7812768f,0.2271386f);
Get(0x6E82).SetLocalPose(0.0009936679f,1.496884f,-0.6115026f,0.9308733f,0.0003206292f,-0.2703669f,-0.2457166f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.4292942f);
Get(0x6EC6).SetLocalPose(0.3743894f,1.432742f,-0.737537f,-0.2362358f,-0.937197f,-0.2029945f,-0.1569959f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094964f,1.309305f,0.1332545f,-0.7030908f,-0.01434588f,-0.009671208f,0.7108896f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.655231f);
Get(0x6E70).SetLocalPose(0.08869892f,1.511845f,-0.6316345f,0.5449809f,-0.2178698f,-0.7769558f,0.2277463f);
Get(0x6E82).SetLocalPose(-0.0004387464f,1.505155f,-0.6283839f,0.9391464f,-0.03305626f,-0.2502414f,-0.2330034f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.4863954f);
Get(0x6EC6).SetLocalPose(0.3712415f,1.453821f,-0.7476084f,-0.2338284f,-0.9387284f,-0.1902626f,-0.167073f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094765f,1.309411f,0.1332184f,-0.7030711f,-0.01438276f,-0.0096564f,0.7109086f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.713836f);
Get(0x6E70).SetLocalPose(0.08016706f,1.516498f,-0.6415687f,0.5500083f,-0.2265892f,-0.7709561f,0.227541f);
Get(0x6E82).SetLocalPose(-0.001548901f,1.513072f,-0.6434064f,0.943737f,-0.06546828f,-0.2301508f,-0.2282654f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.545f);
Get(0x6EC6).SetLocalPose(0.3669685f,1.472657f,-0.7558347f,-0.2304956f,-0.9400653f,-0.1823118f,-0.1729491f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094581f,1.309593f,0.1328377f,-0.7030542f,-0.01436902f,-0.009634987f,0.7109259f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.772581f);
Get(0x6E70).SetLocalPose(0.07138281f,1.519197f,-0.650614f,0.5551479f,-0.2356643f,-0.7650668f,0.225712f);
Get(0x6E82).SetLocalPose(0.0001006588f,1.518654f,-0.659412f,0.9495649f,-0.09940009f,-0.1985606f,-0.2214042f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.6037446f);
Get(0x6EC6).SetLocalPose(0.3594204f,1.49369f,-0.7644459f,-0.2252645f,-0.9423017f,-0.17838f,-0.1717672f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.772581f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.6037446f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094944f,1.30967f,0.1330008f,-0.7030466f,-0.01442365f,-0.009601593f,0.7109327f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.90636f);
Get(0x6E70).SetLocalPose(0.0552306f,1.521767f,-0.675557f,0.5709214f,-0.2541105f,-0.7495799f,0.2181894f);
Get(0x6E82).SetLocalPose(0.001096826f,1.525699f,-0.6879497f,0.9483646f,-0.1601695f,-0.1517987f,-0.2278321f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.737524f);
Get(0x6EC6).SetLocalPose(0.3378967f,1.525434f,-0.7748249f,-0.2160181f,-0.9427611f,-0.1885802f,-0.1702212f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095187f,1.309825f,0.1331961f,-0.703056f,-0.01444348f,-0.009590519f,0.7109231f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.966195f);
Get(0x6E70).SetLocalPose(0.04947422f,1.522999f,-0.6880815f,0.5772706f,-0.2611369f,-0.7430836f,0.2153908f);
Get(0x6E82).SetLocalPose(-0.003114839f,1.528551f,-0.6964076f,0.9322905f,-0.1781815f,-0.1799238f,-0.258289f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.7973582f);
Get(0x6EC6).SetLocalPose(0.3306958f,1.53204f,-0.775943f,-0.2172397f,-0.9398531f,-0.1953942f,-0.17693f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095144f,1.309552f,0.1330124f,-0.7030637f,-0.01444286f,-0.009598029f,0.7109154f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.028431f);
Get(0x6E70).SetLocalPose(0.0449752f,1.525324f,-0.6996303f,0.5782015f,-0.26576f,-0.7416945f,0.212f);
Get(0x6E82).SetLocalPose(-0.00943719f,1.531154f,-0.7062593f,0.9311199f,-0.1796069f,-0.1807313f,-0.2609473f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.8595948f);
Get(0x6EC6).SetLocalPose(0.3173902f,1.540694f,-0.7776633f,-0.2273037f,-0.9319346f,-0.2133317f,-0.185258f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095204f,1.309312f,0.1329351f,-0.7030549f,-0.01444701f,-0.009588127f,0.7109243f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.08699f);
Get(0x6E70).SetLocalPose(0.0395163f,1.527043f,-0.7104487f,0.5782049f,-0.2703242f,-0.7407009f,0.2096811f);
Get(0x6E82).SetLocalPose(-0.01485461f,1.531699f,-0.7171714f,0.9350021f,-0.1728944f,-0.1710762f,-0.2580923f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.9181539f);
Get(0x6EC6).SetLocalPose(0.3058197f,1.546068f,-0.7788165f,-0.2264573f,-0.9286879f,-0.2348111f,-0.1764074f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095518f,1.308982f,0.1332566f,-0.7030686f,-0.0144574f,-0.009624444f,0.71091f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.147217f);
Get(0x6E70).SetLocalPose(0.03492822f,1.529258f,-0.7256279f,0.5839523f,-0.2741619f,-0.7346774f,0.2099622f);
Get(0x6E82).SetLocalPose(-0.01976237f,1.532549f,-0.7322159f,0.9332067f,-0.1827658f,-0.161796f,-0.263712f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.978381f);
Get(0x6EC6).SetLocalPose(0.2934819f,1.551979f,-0.7805358f,-0.2140871f,-0.9273887f,-0.2571255f,-0.167342f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095679f,1.309164f,0.1330677f,-0.7030642f,-0.01446813f,-0.00957813f,0.7109147f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.208936f);
Get(0x6E70).SetLocalPose(0.03007831f,1.531138f,-0.739691f,0.5928286f,-0.2738757f,-0.7262945f,0.2145757f);
Get(0x6E82).SetLocalPose(-0.02229966f,1.533668f,-0.7471581f,0.9368018f,-0.1813742f,-0.1463114f,-0.2609577f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.0401f);
Get(0x6EC6).SetLocalPose(0.2833752f,1.553363f,-0.7850281f,-0.1986977f,-0.9261028f,-0.2666194f,-0.1782331f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095475f,1.309119f,0.132928f,-0.7030675f,-0.01443947f,-0.009612523f,0.7109116f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.235765f);
Get(0x6E70).SetLocalPose(0.02839046f,1.531859f,-0.7479526f,0.5977749f,-0.2724021f,-0.7215748f,0.2186141f);
Get(0x6E82).SetLocalPose(-0.02354882f,1.534173f,-0.7547051f,0.9395602f,-0.178284f,-0.1385208f,-0.2573973f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.066929f);
Get(0x6EC6).SetLocalPose(0.2790946f,1.553525f,-0.7879301f,-0.1924613f,-0.925298f,-0.2693191f,-0.1850663f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095573f,1.309041f,0.1329251f,-0.7030737f,-0.01443753f,-0.009631312f,0.7109053f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.33918f);
Get(0x6E70).SetLocalPose(0.02479308f,1.530625f,-0.7698153f,0.6101778f,-0.2649179f,-0.7090171f,0.2340863f);
Get(0x6E82).SetLocalPose(-0.02714514f,1.536359f,-0.7821916f,0.9473736f,-0.1744648f,-0.1127886f,-0.2435653f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.170344f);
Get(0x6EC6).SetLocalPose(0.2651475f,1.553205f,-0.8026194f,-0.1643221f,-0.924358f,-0.2785942f,-0.2023512f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095574f,1.309548f,0.1331072f,-0.7030864f,-0.01447716f,-0.009615192f,0.710892f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.370893f);
Get(0x6E70).SetLocalPose(0.02284664f,1.530501f,-0.7779933f,0.6143677f,-0.2631259f,-0.7038244f,0.2407245f);
Get(0x6E82).SetLocalPose(-0.02755693f,1.537392f,-0.7901062f,0.949829f,-0.1723662f,-0.1050218f,-0.2389248f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.202057f);
Get(0x6EC6).SetLocalPose(0.2607616f,1.553111f,-0.8073547f,-0.1498258f,-0.925249f,-0.2811591f,-0.2059517f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095635f,1.309597f,0.1332629f,-0.7030831f,-0.0144615f,-0.009577204f,0.7108961f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.43865f);
Get(0x6E70).SetLocalPose(0.01918289f,1.532979f,-0.793906f,0.6189743f,-0.2654685f,-0.6964851f,0.2476002f);
Get(0x6E82).SetLocalPose(-0.02886401f,1.538622f,-0.8059581f,0.9532338f,-0.1701239f,-0.09177592f,-0.2323367f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.269814f);
Get(0x6EC6).SetLocalPose(0.2540803f,1.552992f,-0.8174669f,-0.1403887f,-0.9259349f,-0.2856532f,-0.2033175f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095369f,1.309873f,0.1333611f,-0.7030869f,-0.01448666f,-0.009565585f,0.7108921f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.52556f);
Get(0x6E70).SetLocalPose(0.0145091f,1.541391f,-0.8147058f,0.624695f,-0.2764722f,-0.6862533f,0.2497513f);
Get(0x6E82).SetLocalPose(-0.03182296f,1.541782f,-0.8286268f,0.9561973f,-0.1648544f,-0.08864701f,-0.2250591f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.356724f);
Get(0x6EC6).SetLocalPose(0.2524354f,1.551915f,-0.833174f,-0.1493709f,-0.9218292f,-0.2705366f,-0.2339429f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09539f,1.31009f,0.1333646f,-0.7030874f,-0.01444448f,-0.009541593f,0.7108927f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.583964f);
Get(0x6E70).SetLocalPose(0.01261054f,1.549514f,-0.8320259f,0.6264611f,-0.293719f,-0.6775388f,0.249433f);
Get(0x6E82).SetLocalPose(-0.03468947f,1.546587f,-0.8444853f,0.9603458f,-0.1569844f,-0.08056246f,-0.2158742f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.415128f);
Get(0x6EC6).SetLocalPose(0.2490125f,1.552654f,-0.8451194f,-0.1470894f,-0.9270866f,-0.257439f,-0.2293479f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095176f,1.309761f,0.1333623f,-0.7030779f,-0.0143967f,-0.009612058f,0.7109022f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.646005f);
Get(0x6E70).SetLocalPose(0.01182679f,1.555791f,-0.8516624f,0.6278998f,-0.3177076f,-0.666416f,0.2463603f);
Get(0x6E82).SetLocalPose(-0.03690676f,1.552213f,-0.8626596f,0.9659086f,-0.1482444f,-0.06476949f,-0.2021119f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.477169f);
Get(0x6EC6).SetLocalPose(0.2468f,1.554435f,-0.8573164f,-0.1458568f,-0.9272923f,-0.2476076f,-0.239886f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095109f,1.30982f,0.1333252f,-0.7030773f,-0.01444476f,-0.009591669f,0.710902f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.706776f);
Get(0x6E70).SetLocalPose(0.009981259f,1.560821f,-0.8713524f,0.6317856f,-0.3394955f,-0.6545529f,0.2390614f);
Get(0x6E82).SetLocalPose(-0.03848207f,1.558102f,-0.8833482f,0.9694579f,-0.1446666f,-0.04789976f,-0.1921679f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.53794f);
Get(0x6EC6).SetLocalPose(0.2449347f,1.5557f,-0.8686692f,-0.1428505f,-0.9242777f,-0.2458286f,-0.2547013f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.706776f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.53794f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095f,1.309507f,0.1331116f,-0.7030872f,-0.01442715f,-0.009637322f,0.7108921f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.80505f);
Get(0x6E70).SetLocalPose(0.00958599f,1.570989f,-0.9041131f,0.6392592f,-0.3686849f,-0.6363204f,0.2247567f);
Get(0x6E82).SetLocalPose(-0.03827138f,1.567788f,-0.9173582f,0.9730182f,-0.1410403f,-0.0207125f,-0.1814231f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.636214f);
Get(0x6EC6).SetLocalPose(0.2428807f,1.558713f,-0.8874244f,-0.1424897f,-0.9153634f,-0.2451433f,-0.2858519f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094807f,1.309635f,0.1330014f,-0.7030835f,-0.01443206f,-0.00962707f,0.7108958f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.872763f);
Get(0x6E70).SetLocalPose(0.01080431f,1.574493f,-0.9232474f,0.6426413f,-0.3801625f,-0.6275561f,0.2205946f);
Get(0x6E82).SetLocalPose(-0.03605755f,1.571208f,-0.9352798f,0.973919f,-0.1424256f,-0.006176854f,-0.1765178f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.703927f);
Get(0x6EC6).SetLocalPose(0.2430004f,1.558401f,-0.9000965f,-0.1494577f,-0.9111775f,-0.2379391f,-0.3013352f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094677f,1.309636f,0.1332127f,-0.703086f,-0.01440758f,-0.009635597f,0.7108937f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 5.93253f);
Get(0x6E70).SetLocalPose(0.01129746f,1.576056f,-0.9382377f,0.6427975f,-0.3852202f,-0.6245239f,0.2199697f);
Get(0x6E82).SetLocalPose(-0.03279543f,1.574035f,-0.9552624f,0.9739211f,-0.1467778f,0.004536806f,-0.1729552f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.763694f);
Get(0x6EC6).SetLocalPose(0.2434962f,1.558476f,-0.9110228f,-0.1574232f,-0.9055601f,-0.2323238f,-0.3181263f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095019f,1.30942f,0.1331288f,-0.7030639f,-0.01438165f,-0.009657334f,0.7109157f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.018051f);
Get(0x6E70).SetLocalPose(0.01369081f,1.574092f,-0.9540492f,0.6363211f,-0.3809882f,-0.6313449f,0.226599f);
Get(0x6E82).SetLocalPose(-0.02734869f,1.577783f,-0.9752176f,0.9704729f,-0.159334f,0.005771f,-0.1810024f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.849215f);
Get(0x6EC6).SetLocalPose(0.245684f,1.558568f,-0.9312705f,-0.1740739f,-0.8986921f,-0.2226077f,-0.3354052f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095361f,1.308964f,0.1330733f,-0.7031069f,-0.01441537f,-0.009666013f,0.7108724f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.078146f);
Get(0x6E70).SetLocalPose(0.01612569f,1.572007f,-0.9621792f,0.6271878f,-0.3716306f,-0.641589f,0.2385155f);
Get(0x6E82).SetLocalPose(-0.0222319f,1.579397f,-0.9866081f,0.968261f,-0.1671348f,0.005341644f,-0.1857632f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.909309f);
Get(0x6EC6).SetLocalPose(0.2503089f,1.559321f,-0.9489235f,-0.1884403f,-0.8922176f,-0.2136492f,-0.3504169f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095019f,1.308937f,0.13306f,-0.7030874f,-0.01439365f,-0.009658988f,0.7108921f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.136617f);
Get(0x6E70).SetLocalPose(0.01916078f,1.572365f,-0.9678917f,0.617726f,-0.3612648f,-0.6506796f,0.2540049f);
Get(0x6E82).SetLocalPose(-0.01571135f,1.577397f,-0.9977713f,0.9681328f,-0.1703826f,0.001745041f,-0.1835368f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 1.967781f);
Get(0x6EC6).SetLocalPose(0.2557422f,1.561109f,-0.9665604f,-0.1982974f,-0.8920825f,-0.2052019f,-0.35037f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095114f,1.309038f,0.1330825f,-0.7030833f,-0.01439863f,-0.009653349f,0.7108963f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.194391f);
Get(0x6E70).SetLocalPose(0.02455925f,1.571177f,-0.9751974f,0.6088263f,-0.3485771f,-0.6583999f,0.2726428f);
Get(0x6E82).SetLocalPose(-0.0101422f,1.576345f,-1.006162f,0.9680454f,-0.1716293f,-0.00151724f,-0.1828369f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.025555f);
Get(0x6EC6).SetLocalPose(0.2610952f,1.563767f,-0.980701f,-0.2021623f,-0.8957111f,-0.1972809f,-0.3433835f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.194391f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.025555f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09505f,1.309184f,0.1329783f,-0.7030886f,-0.01439976f,-0.009655419f,0.7108908f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.295077f);
Get(0x6E70).SetLocalPose(0.0442964f,1.567274f,-0.9983104f,0.5925407f,-0.3218178f,-0.6717194f,0.306793f);
Get(0x6E82).SetLocalPose(0.001805353f,1.574901f,-1.024564f,0.9689344f,-0.1676362f,-0.01654406f,-0.1810819f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.12624f);
Get(0x6EC6).SetLocalPose(0.2741474f,1.571981f,-1.021768f,-0.2026647f,-0.9170025f,-0.174658f,-0.2958515f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095076f,1.309089f,0.1331006f,-0.7030739f,-0.01437576f,-0.009654369f,0.7109059f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.363781f);
Get(0x6E70).SetLocalPose(0.05654873f,1.568089f,-1.016617f,0.5897889f,-0.3124979f,-0.6748875f,0.3146761f);
Get(0x6E82).SetLocalPose(0.006533572f,1.575443f,-1.034074f,0.9706246f,-0.1604628f,-0.03275084f,-0.1762587f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.194945f);
Get(0x6EC6).SetLocalPose(0.2790209f,1.57484f,-1.037884f,-0.2002887f,-0.9240102f,-0.1646069f,-0.2810591f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095416f,1.30938f,0.1330925f,-0.7030541f,-0.01441669f,-0.009598888f,0.7109254f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.446032f);
Get(0x6E70).SetLocalPose(0.06628377f,1.571182f,-1.035498f,0.5896391f,-0.3126725f,-0.6730801f,0.3186296f);
Get(0x6E82).SetLocalPose(0.01168574f,1.578556f,-1.047236f,0.9725819f,-0.1492534f,-0.06027919f,-0.167852f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.277195f);
Get(0x6EC6).SetLocalPose(0.2844265f,1.576817f,-1.056627f,-0.1954984f,-0.931587f,-0.1537079f,-0.2651415f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095228f,1.309201f,0.1331561f,-0.7030512f,-0.01439414f,-0.009626058f,0.7109284f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.502572f);
Get(0x6E70).SetLocalPose(0.07125095f,1.577441f,-1.049627f,0.591136f,-0.3207086f,-0.6681136f,0.3183214f);
Get(0x6E82).SetLocalPose(0.01339283f,1.581191f,-1.056003f,0.9736165f,-0.1430322f,-0.07888333f,-0.1593431f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.333735f);
Get(0x6EC6).SetLocalPose(0.2863999f,1.578369f,-1.065938f,-0.189904f,-0.9366709f,-0.1492979f,-0.2535631f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095307f,1.309302f,0.1330506f,-0.7030496f,-0.01440434f,-0.009636894f,0.7109297f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.561031f);
Get(0x6E70).SetLocalPose(0.07246389f,1.583823f,-1.061075f,0.5922928f,-0.337216f,-0.6606358f,0.314698f);
Get(0x6E82).SetLocalPose(0.01392919f,1.584631f,-1.064343f,0.9749923f,-0.1374425f,-0.09396766f,-0.1472066f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.392194f);
Get(0x6EC6).SetLocalPose(0.2880862f,1.581022f,-1.075559f,-0.1787711f,-0.9432209f,-0.1421812f,-0.2411635f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095374f,1.309507f,0.1330144f,-0.7030481f,-0.01439319f,-0.009620355f,0.7109317f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.620002f);
Get(0x6E70).SetLocalPose(0.07259361f,1.589921f,-1.070233f,0.591091f,-0.3518674f,-0.6555476f,0.3115416f);
Get(0x6E82).SetLocalPose(0.01387745f,1.59059f,-1.073474f,0.9771267f,-0.1317123f,-0.1019244f,-0.1322377f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.451166f);
Get(0x6EC6).SetLocalPose(0.2906542f,1.583229f,-1.082646f,-0.1672708f,-0.9459444f,-0.1402134f,-0.2398955f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095178f,1.30956f,0.1331186f,-0.703091f,-0.01440264f,-0.009626132f,0.7108889f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.680771f);
Get(0x6E70).SetLocalPose(0.07063171f,1.596006f,-1.079104f,0.5900122f,-0.3655262f,-0.648515f,0.3125774f);
Get(0x6E82).SetLocalPose(0.01232889f,1.59507f,-1.081122f,0.9799689f,-0.1263854f,-0.1002949f,-0.1167416f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.511935f);
Get(0x6EC6).SetLocalPose(0.2933206f,1.58459f,-1.090135f,-0.1572962f,-0.9461139f,-0.1435379f,-0.243974f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.680771f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.511935f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094996f,1.309421f,0.1327949f,-0.7030593f,-0.01439209f,-0.009632746f,0.7109203f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.814997f);
Get(0x6E70).SetLocalPose(0.07255352f,1.604322f,-1.094268f,0.5844877f,-0.3728975f,-0.6397839f,0.3316596f);
Get(0x6E82).SetLocalPose(0.01598093f,1.605058f,-1.100898f,0.9826561f,-0.1359318f,-0.08391414f,-0.09416989f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.64616f);
Get(0x6EC6).SetLocalPose(0.298418f,1.593297f,-1.109547f,-0.1510802f,-0.943296f,-0.1447824f,-0.2576928f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094929f,1.309478f,0.1329021f,-0.7030643f,-0.01439897f,-0.009630525f,0.7109153f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.875569f);
Get(0x6E70).SetLocalPose(0.07394421f,1.604539f,-1.098937f,0.5802816f,-0.3635528f,-0.6415007f,0.3458028f);
Get(0x6E82).SetLocalPose(0.01926327f,1.606349f,-1.108862f,0.9831437f,-0.1440574f,-0.07834275f,-0.08086038f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.706732f);
Get(0x6EC6).SetLocalPose(0.3000798f,1.59847f,-1.117461f,-0.1556677f,-0.9399225f,-0.1447161f,-0.2671526f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095016f,1.309451f,0.1329736f,-0.7030751f,-0.01440256f,-0.009623723f,0.7109047f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.936545f);
Get(0x6E70).SetLocalPose(0.07586085f,1.602672f,-1.1035f,0.5745059f,-0.3481185f,-0.6461473f,0.3622846f);
Get(0x6E82).SetLocalPose(0.01976744f,1.609235f,-1.115492f,0.9833947f,-0.1520528f,-0.07113292f,-0.0689568f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.767708f);
Get(0x6EC6).SetLocalPose(0.3021711f,1.599882f,-1.125716f,-0.1662342f,-0.9365965f,-0.1411114f,-0.2743005f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094985f,1.309338f,0.1331043f,-0.7030641f,-0.01443194f,-0.00961913f,0.7109151f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 6.996022f);
Get(0x6E70).SetLocalPose(0.07844529f,1.600897f,-1.106346f,0.5678042f,-0.3328996f,-0.6521361f,0.3761579f);
Get(0x6E82).SetLocalPose(0.02076666f,1.611792f,-1.121438f,0.9831515f,-0.1606361f,-0.06797704f,-0.05466577f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.827185f);
Get(0x6EC6).SetLocalPose(0.3035814f,1.600418f,-1.135866f,-0.1734157f,-0.9355551f,-0.1298734f,-0.2789204f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095147f,1.309117f,0.1330753f,-0.7030682f,-0.01442108f,-0.009620492f,0.7109111f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 7.054707f);
Get(0x6E70).SetLocalPose(0.0802483f,1.600012f,-1.110129f,0.5602769f,-0.322355f,-0.6578017f,0.3866186f);
Get(0x6E82).SetLocalPose(0.02168086f,1.614079f,-1.128557f,0.9827678f,-0.163434f,-0.07492045f,-0.04293965f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.88587f);
Get(0x6EC6).SetLocalPose(0.3026469f,1.601051f,-1.147878f,-0.1761971f,-0.9402843f,-0.1088024f,-0.2701522f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09548f,1.309102f,0.1330204f,-0.7030508f,-0.01440865f,-0.009599452f,0.7109289f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 7.116613f);
Get(0x6E70).SetLocalPose(0.08178505f,1.598052f,-1.113164f,0.5530473f,-0.3164093f,-0.6613305f,0.3958104f);
Get(0x6E82).SetLocalPose(0.02395842f,1.613577f,-1.133351f,0.9818045f,-0.1643343f,-0.08761968f,-0.03710653f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.947777f);
Get(0x6EC6).SetLocalPose(0.301314f,1.603609f,-1.159598f,-0.1778146f,-0.9461187f,-0.09182081f,-0.2545789f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095587f,1.309029f,0.1330533f,-0.7030679f,-0.01443012f,-0.009604945f,0.7109115f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 7.145896f);
Get(0x6E70).SetLocalPose(0.08234182f,1.597712f,-1.114762f,0.5506285f,-0.3158201f,-0.6618753f,0.3987318f);
Get(0x6E82).SetLocalPose(0.02411379f,1.613958f,-1.136418f,0.9811968f,-0.164847f,-0.09380668f,-0.0357567f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.977059f);
Get(0x6EC6).SetLocalPose(0.3007396f,1.605868f,-1.164624f,-0.1784847f,-0.948023f,-0.08726957f,-0.2485553f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 7.145896f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 2.977059f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095304f,1.309307f,0.1329018f,-0.7030641f,-0.01442693f,-0.009632323f,0.7109149f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 7.28832f);
Get(0x6E70).SetLocalPose(0.08344199f,1.601578f,-1.125147f,0.5398411f,-0.3320993f,-0.6597664f,0.4037201f);
Get(0x6E82).SetLocalPose(0.02122268f,1.62021f,-1.147888f,0.9782726f,-0.1736925f,-0.1044471f,-0.04364196f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.119483f);
Get(0x6EC6).SetLocalPose(0.2971664f,1.610242f,-1.177266f,-0.1756636f,-0.9517168f,-0.07745635f,-0.2395373f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095232f,1.309524f,0.133072f,-0.7030821f,-0.01441432f,-0.009649266f,0.7108971f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 7.347878f);
Get(0x6E70).SetLocalPose(0.08055516f,1.606399f,-1.132135f,0.5384639f,-0.3399771f,-0.6569454f,0.4036026f);
Get(0x6E82).SetLocalPose(0.01805635f,1.624187f,-1.154474f,0.9776281f,-0.1823048f,-0.09440471f,-0.04578489f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.179042f);
Get(0x6EC6).SetLocalPose(0.2951572f,1.611497f,-1.179536f,-0.1724088f,-0.9525728f,-0.07516356f,-0.2392296f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095305f,1.309766f,0.133124f,-0.7030773f,-0.01445355f,-0.009617261f,0.7109016f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 7.408638f);
Get(0x6E70).SetLocalPose(0.07626934f,1.607295f,-1.136359f,0.5392585f,-0.344858f,-0.6538838f,0.4033724f);
Get(0x6E82).SetLocalPose(0.01363462f,1.6286f,-1.160177f,0.9761317f,-0.1942448f,-0.08068692f,-0.05408791f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.239801f);
Get(0x6EC6).SetLocalPose(0.2935648f,1.613f,-1.183297f,-0.1681578f,-0.953872f,-0.0752364f,-0.2370456f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095255f,1.309737f,0.1333763f,-0.7030917f,-0.01447377f,-0.009609051f,0.710887f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 7.471135f);
Get(0x6E70).SetLocalPose(0.07231497f,1.607996f,-1.139899f,0.5375575f,-0.3466261f,-0.6538043f,0.4042552f);
Get(0x6E82).SetLocalPose(0.004560013f,1.634363f,-1.165615f,0.9721014f,-0.2084138f,-0.08349385f,-0.06790718f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.302298f);
Get(0x6EC6).SetLocalPose(0.2923065f,1.613608f,-1.186657f,-0.1642196f,-0.9549875f,-0.07709722f,-0.2347059f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095358f,1.309381f,0.1332458f,-0.7030927f,-0.014483f,-0.009608191f,0.7108858f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 7.53217f);
Get(0x6E70).SetLocalPose(0.07011205f,1.610587f,-1.150874f,0.5343337f,-0.3454497f,-0.6558507f,0.4062166f);
Get(0x6E82).SetLocalPose(-0.008600418f,1.643233f,-1.176222f,0.9722854f,-0.2005374f,-0.1022152f,-0.06322791f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.363333f);
Get(0x6EC6).SetLocalPose(0.290915f,1.614027f,-1.18971f,-0.1618668f,-0.9562197f,-0.07676181f,-0.2314099f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09529f,1.309366f,0.1331631f,-0.703079f,-0.01446881f,-0.00958886f,0.7108999f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 7.590777f);
Get(0x6E70).SetLocalPose(0.06850873f,1.611537f,-1.150564f,0.5305061f,-0.3440258f,-0.6585045f,0.4081439f);
Get(0x6E82).SetLocalPose(-0.0229993f,1.650931f,-1.187093f,0.9779902f,-0.1681709f,-0.1159528f,-0.04252979f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.42194f);
Get(0x6EC6).SetLocalPose(0.289696f,1.613895f,-1.192143f,-0.1617002f,-0.9575553f,-0.0741811f,-0.2268001f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095116f,1.309417f,0.1331038f,-0.7030623f,-0.01448453f,-0.009596201f,0.710916f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 7.619679f);
Get(0x6E70).SetLocalPose(0.069502f,1.611867f,-1.149853f,0.5291548f,-0.3420851f,-0.6598257f,0.4093935f);
Get(0x6E82).SetLocalPose(-0.03130338f,1.654472f,-1.194118f,0.9811932f,-0.1424305f,-0.1277634f,-0.02549311f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.450841f);
Get(0x6EC6).SetLocalPose(0.2889848f,1.614063f,-1.193604f,-0.161597f,-0.9581912f,-0.07261553f,-0.2246844f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095385f,1.309876f,0.1332651f,-0.7030643f,-0.01447487f,-0.009574979f,0.7109145f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 7.733454f);
Get(0x6E70).SetLocalPose(0.06483867f,1.60856f,-1.148553f,0.5268708f,-0.3319033f,-0.6652732f,0.4118968f);
Get(0x6E82).SetLocalPose(-0.05553996f,1.669548f,-1.218526f,0.9837764f,-0.04861209f,-0.1699582f,0.03057877f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.564616f);
Get(0x6EC6).SetLocalPose(0.2881117f,1.611369f,-1.196047f,-0.1622935f,-0.9600205f,-0.07274818f,-0.2161697f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095441f,1.309873f,0.1333874f,-0.7030796f,-0.01443073f,-0.009597491f,0.7108999f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 7.801249f);
Get(0x6E70).SetLocalPose(0.06413671f,1.606825f,-1.147158f,0.5276452f,-0.324683f,-0.6678906f,0.4124243f);
Get(0x6E82).SetLocalPose(-0.0644532f,1.675406f,-1.233778f,0.9812381f,-0.009482997f,-0.1853179f,0.05233581f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.632411f);
Get(0x6EC6).SetLocalPose(0.2887863f,1.609946f,-1.195472f,-0.1669109f,-0.9589542f,-0.07459515f,-0.2167558f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095587f,1.310055f,0.133237f,-0.703066f,-0.01451488f,-0.009542566f,0.7109125f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 7.860167f);
Get(0x6E70).SetLocalPose(0.06268374f,1.604367f,-1.145621f,0.5300135f,-0.3167513f,-0.6695989f,0.4127853f);
Get(0x6E82).SetLocalPose(-0.06467042f,1.677736f,-1.245558f,0.9812636f,0.005085996f,-0.1794745f,0.06989144f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.691329f);
Get(0x6EC6).SetLocalPose(0.2905497f,1.608627f,-1.194248f,-0.1738684f,-0.9555125f,-0.07921838f,-0.2247003f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095675f,1.30973f,0.1331441f,-0.7030782f,-0.01448324f,-0.009581501f,0.7109005f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 7.920146f);
Get(0x6E70).SetLocalPose(0.0609299f,1.601814f,-1.143764f,0.5334983f,-0.3082893f,-0.6707139f,0.4128926f);
Get(0x6E82).SetLocalPose(-0.06117396f,1.680196f,-1.261932f,0.9835213f,0.0158199f,-0.1485828f,0.1017777f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.751307f);
Get(0x6EC6).SetLocalPose(0.2917411f,1.607881f,-1.192026f,-0.1795382f,-0.9522375f,-0.087157f,-0.2311138f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095247f,1.309712f,0.1334401f,-0.7030836f,-0.01443439f,-0.009637483f,0.7108954f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 7.977613f);
Get(0x6E70).SetLocalPose(0.05960429f,1.598304f,-1.141992f,0.5372646f,-0.3006902f,-0.6713265f,0.4126171f);
Get(0x6E82).SetLocalPose(-0.05725742f,1.680392f,-1.273055f,0.9834478f,0.02364874f,-0.1227962f,0.1311191f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.808775f);
Get(0x6EC6).SetLocalPose(0.2925009f,1.607616f,-1.189943f,-0.184522f,-0.9501539f,-0.09603894f,-0.2322409f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095307f,1.309691f,0.133357f,-0.703078f,-0.01445151f,-0.009631273f,0.7109006f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 8.037626f);
Get(0x6E70).SetLocalPose(0.05835988f,1.594344f,-1.14018f,0.5412669f,-0.2934438f,-0.6718166f,0.4118048f);
Get(0x6E82).SetLocalPose(-0.05053766f,1.679615f,-1.285136f,0.9806253f,0.02639976f,-0.1064415f,0.1623189f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.868788f);
Get(0x6EC6).SetLocalPose(0.2938643f,1.605191f,-1.187606f,-0.1914814f,-0.949163f,-0.1007117f,-0.2286517f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095327f,1.309545f,0.133364f,-0.7030602f,-0.0144457f,-0.009618774f,0.7109186f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 8.096523f);
Get(0x6E70).SetLocalPose(0.05679037f,1.588131f,-1.137808f,0.5456591f,-0.2859729f,-0.6723215f,0.4104382f);
Get(0x6E82).SetLocalPose(-0.04426704f,1.679293f,-1.297159f,0.978236f,0.0236683f,-0.09672289f,0.1820409f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.927684f);
Get(0x6EC6).SetLocalPose(0.2942823f,1.602386f,-1.186858f,-0.1971659f,-0.9495838f,-0.09402198f,-0.2248915f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 8.096523f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 3.927684f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095544f,1.309262f,0.133336f,-0.703097f,-0.01438246f,-0.009678042f,0.7108827f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 8.229987f);
Get(0x6E70).SetLocalPose(0.05129046f,1.574641f,-1.131999f,0.5540717f,-0.2711947f,-0.674358f,0.4058318f);
Get(0x6E82).SetLocalPose(-0.02951727f,1.680288f,-1.321917f,0.9778418f,0.001314172f,-0.07530357f,0.1953283f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.061148f);
Get(0x6EC6).SetLocalPose(0.289927f,1.593908f,-1.186365f,-0.1928175f,-0.9575253f,-0.06979017f,-0.2027217f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095388f,1.309457f,0.1332734f,-0.7031096f,-0.01439123f,-0.009674045f,0.7108701f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 8.287676f);
Get(0x6E70).SetLocalPose(0.04992932f,1.573793f,-1.129055f,0.5589048f,-0.2660716f,-0.6734272f,0.4041376f);
Get(0x6E82).SetLocalPose(-0.02480152f,1.679214f,-1.32757f,0.978311f,-0.00339583f,-0.05953507f,0.1983729f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.118837f);
Get(0x6EC6).SetLocalPose(0.2870821f,1.589556f,-1.18548f,-0.1898948f,-0.961253f,-0.06266933f,-0.1897504f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095613f,1.309329f,0.1332921f,-0.7031208f,-0.01441506f,-0.009649011f,0.7108588f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 8.346544f);
Get(0x6E70).SetLocalPose(0.04814328f,1.572616f,-1.126059f,0.564042f,-0.2625012f,-0.6720696f,0.4015872f);
Get(0x6E82).SetLocalPose(-0.01400831f,1.678667f,-1.333091f,0.9786323f,0.0006541015f,-0.01604934f,0.2049898f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.177706f);
Get(0x6EC6).SetLocalPose(0.2840595f,1.580058f,-1.181935f,-0.1839274f,-0.965134f,-0.059049f,-0.1766361f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095244f,1.309194f,0.1332639f,-0.7031137f,-0.01444062f,-0.009630194f,0.7108656f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 8.404292f);
Get(0x6E70).SetLocalPose(0.0470959f,1.571488f,-1.123661f,0.5667391f,-0.2605741f,-0.6725517f,0.3982239f);
Get(0x6E82).SetLocalPose(-0.01013034f,1.679065f,-1.336189f,0.976967f,0.008401742f,0.01950369f,0.2123311f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 4.235453f);
Get(0x6EC6).SetLocalPose(0.2823695f,1.574616f,-1.179954f,-0.1766874f,-0.9669238f,-0.05923918f,-0.1741573f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095048f,1.309135f,0.1331304f,-0.7030984f,-0.01443804f,-0.009627103f,0.7108808f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 8.432463f);
Get(0x6E70).SetLocalPose(0.04637885f,1.571867f,-1.121466f,0.5678846f,-0.2590003f,-0.6738244f,0.3954576f);
Get(0x6E82).SetLocalPose(-0.007835928f,1.680225f,-1.337462f,0.9758685f,0.01245372f,0.0338107f,0.2153658f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0f);
Get(0x6EC6).SetLocalPose(0.280437f,1.570602f,-1.178878f,-0.170716f,-0.9679046f,-0.05913297f,-0.1747f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095521f,1.309332f,0.1332805f,-0.7031076f,-0.0144577f,-0.009612726f,0.7108715f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 8.5361f);
Get(0x6E70).SetLocalPose(0.04687205f,1.570888f,-1.118851f,0.5703709f,-0.2554461f,-0.6761979f,0.3901036f);
Get(0x6E82).SetLocalPose(-0.004477799f,1.682582f,-1.336905f,0.97861f,0.003389166f,0.03565751f,0.2025824f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 0.05223662f);
Get(0x6EC6).SetLocalPose(0.2785041f,1.563885f,-1.17713f,-0.1664707f,-0.9700753f,-0.05583858f,-0.167701f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095521f,1.309308f,0.1332592f,-0.7030978f,-0.01448469f,-0.009596014f,0.7108809f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 8.565077f);
Get(0x6E70).SetLocalPose(0.04737774f,1.570599f,-1.118577f,0.5710245f,-0.2543712f,-0.6767569f,0.3888786f);
Get(0x6E82).SetLocalPose(-0.003632286f,1.684325f,-1.336599f,0.9813866f,-0.003501422f,0.03243504f,0.1892512f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0f);
Get(0x6EC6).SetLocalPose(0.2777677f,1.561027f,-1.176372f,-0.1660801f,-0.9712727f,-0.05578374f,-0.161043f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 8.565077f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095044f,1.309678f,0.13298f,-0.7031555f,-0.01445494f,-0.009578774f,0.7108247f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 8.707502f);
Get(0x6E70).SetLocalPose(0.05036121f,1.563569f,-1.113389f,0.5721259f,-0.2470779f,-0.6837512f,0.3796165f);
Get(0x6E82).SetLocalPose(-0.002260193f,1.686075f,-1.335535f,0.98882f,-0.02947857f,0.02664713f,0.1437226f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.1424252f);
Get(0x6EC6).SetLocalPose(0.2782297f,1.552088f,-1.172089f,-0.1575042f,-0.9738905f,-0.0674201f,-0.1489442f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095216f,1.309706f,0.1328349f,-0.7031401f,-0.01446355f,-0.00954832f,0.7108402f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 8.765198f);
Get(0x6E70).SetLocalPose(0.05188823f,1.561654f,-1.11131f,0.5714331f,-0.2437792f,-0.6867711f,0.3773347f);
Get(0x6E82).SetLocalPose(-0.00371735f,1.686594f,-1.336833f,0.9907097f,-0.03673179f,0.02225614f,0.1290343f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.2001209f);
Get(0x6EC6).SetLocalPose(0.2810876f,1.549401f,-1.170279f,-0.1591967f,-0.9715455f,-0.0784158f,-0.1568657f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095322f,1.309254f,0.1329252f,-0.7031821f,-0.01440433f,-0.009551342f,0.7107998f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 8.827111f);
Get(0x6E70).SetLocalPose(0.05385834f,1.559905f,-1.109282f,0.5710414f,-0.2397252f,-0.6894498f,0.3756361f);
Get(0x6E82).SetLocalPose(-0.004995051f,1.687162f,-1.335721f,0.9922493f,-0.042984f,0.01381607f,0.1157703f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.2620345f);
Get(0x6EC6).SetLocalPose(0.2837134f,1.546891f,-1.169171f,-0.159873f,-0.9691607f,-0.0893185f,-0.1648954f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095422f,1.309614f,0.1330561f,-0.7031631f,-0.0144484f,-0.009560867f,0.7108175f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 8.893229f);
Get(0x6E70).SetLocalPose(0.05583986f,1.55653f,-1.107248f,0.5698236f,-0.2358677f,-0.69204f,0.3751643f);
Get(0x6E82).SetLocalPose(-0.003565339f,1.686297f,-1.329205f,0.992598f,-0.04858046f,0.007135359f,0.1110779f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.3281517f);
Get(0x6EC6).SetLocalPose(0.2855944f,1.54593f,-1.168053f,-0.1604065f,-0.9670829f,-0.1003451f,-0.1701505f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094978f,1.309804f,0.1329685f,-0.7031893f,-0.01439484f,-0.009550284f,0.7107928f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 8.964317f);
Get(0x6E70).SetLocalPose(0.05794818f,1.55412f,-1.104849f,0.567775f,-0.2309841f,-0.6947249f,0.3763447f);
Get(0x6E82).SetLocalPose(0.003178042f,1.685769f,-1.321569f,0.9922923f,-0.05442508f,-0.003138864f,0.1112843f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.3992406f);
Get(0x6EC6).SetLocalPose(0.2876943f,1.545372f,-1.166427f,-0.1639254f,-0.9655083f,-0.1098013f,-0.1699001f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095026f,1.309571f,0.1329199f,-0.7032136f,-0.01435164f,-0.009586469f,0.7107692f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 9.001424f);
Get(0x6E70).SetLocalPose(0.05984566f,1.552048f,-1.103897f,0.5664314f,-0.2273765f,-0.6962046f,0.3778287f);
Get(0x6E82).SetLocalPose(0.003349222f,1.685387f,-1.316743f,0.9926701f,-0.0572959f,-0.01227139f,0.1057007f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.4363474f);
Get(0x6EC6).SetLocalPose(0.2892019f,1.545322f,-1.165832f,-0.1649643f,-0.9645515f,-0.1147535f,-0.1710522f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094946f,1.309328f,0.1330106f,-0.7031571f,-0.01416265f,-0.009666892f,0.7108278f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 9.054033f);
Get(0x6E70).SetLocalPose(0.06226182f,1.550298f,-1.102509f,0.5648748f,-0.2231251f,-0.6976995f,0.3799304f);
Get(0x6E82).SetLocalPose(0.001335944f,1.688619f,-1.31219f,0.9936892f,-0.05705357f,-0.01780128f,0.09492017f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.4889566f);
Get(0x6EC6).SetLocalPose(0.2916467f,1.544025f,-1.165299f,-0.1659085f,-0.9634025f,-0.11808f,-0.1743194f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 9.054033f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.4889566f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.096099f,1.308951f,0.1331696f,-0.7030283f,-0.01410107f,-0.009612209f,0.7109572f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 9.208156f);
Get(0x6E70).SetLocalPose(0.06940629f,1.548473f,-1.098761f,0.5582263f,-0.2132473f,-0.7035379f,0.384634f);
Get(0x6E82).SetLocalPose(0.003498079f,1.693144f,-1.3095f,0.9938429f,-0.04645207f,0.0006051672f,0.1005888f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.6430787f);
Get(0x6EC6).SetLocalPose(0.2982976f,1.543666f,-1.166862f,-0.1627944f,-0.9644767f,-0.1052474f,-0.1794599f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095916f,1.308837f,0.133147f,-0.703145f,-0.01410699f,-0.009560488f,0.7108424f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 9.275599f);
Get(0x6E70).SetLocalPose(0.0730997f,1.548675f,-1.097243f,0.5553253f,-0.2091489f,-0.7062843f,0.3860481f);
Get(0x6E82).SetLocalPose(0.007496517f,1.695529f,-1.309469f,0.9941402f,-0.04403045f,0.003318735f,0.09866857f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.7105221f);
Get(0x6EC6).SetLocalPose(0.3008381f,1.543433f,-1.167347f,-0.1628404f,-0.9659531f,-0.09809686f,-0.1754837f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095765f,1.308929f,0.1330262f,-0.7031494f,-0.01404265f,-0.009628849f,0.7108383f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 9.338053f);
Get(0x6E70).SetLocalPose(0.07583981f,1.547349f,-1.096014f,0.5532035f,-0.2069239f,-0.7082312f,0.386726f);
Get(0x6E82).SetLocalPose(0.01020629f,1.697871f,-1.309008f,0.9945779f,-0.04755534f,-0.0009679008f,0.09247932f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.772976f);
Get(0x6EC6).SetLocalPose(0.3034796f,1.544601f,-1.167639f,-0.1596657f,-0.9668241f,-0.09705455f,-0.1741798f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095582f,1.309097f,0.1332863f,-0.7031534f,-0.01402021f,-0.009650111f,0.7108344f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 9.398673f);
Get(0x6E70).SetLocalPose(0.0783219f,1.546213f,-1.095408f,0.5503891f,-0.2055951f,-0.7104747f,0.3873347f);
Get(0x6E82).SetLocalPose(0.009597837f,1.700744f,-1.309473f,0.9950347f,-0.04903315f,-0.006432803f,0.08637359f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.8335966f);
Get(0x6EC6).SetLocalPose(0.3059907f,1.545104f,-1.168403f,-0.1553614f,-0.9672686f,-0.09718397f,-0.175527f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095379f,1.309175f,0.1335354f,-0.7032048f,-0.01405821f,-0.009620299f,0.7107832f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 9.458657f);
Get(0x6E70).SetLocalPose(0.08140904f,1.545466f,-1.094845f,0.5475954f,-0.2041559f,-0.712391f,0.3885342f);
Get(0x6E82).SetLocalPose(0.008828651f,1.703642f,-1.308417f,0.9953094f,-0.05103963f,-0.01170938f,0.08134651f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.8935806f);
Get(0x6EC6).SetLocalPose(0.3084214f,1.545254f,-1.16903f,-0.1490844f,-0.968259f,-0.0962937f,-0.1759999f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095108f,1.309365f,0.1336397f,-0.7032563f,-0.01415209f,-0.009629278f,0.7107303f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 9.517738f);
Get(0x6E70).SetLocalPose(0.08427256f,1.545002f,-1.09383f,0.5446916f,-0.2019933f,-0.71425f,0.3903292f);
Get(0x6E82).SetLocalPose(0.0103552f,1.705665f,-1.308716f,0.9956248f,-0.05297278f,-0.01665967f,0.0751513f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.9526615f);
Get(0x6EC6).SetLocalPose(0.3098743f,1.543871f,-1.17069f,-0.1420779f,-0.9701825f,-0.09406219f,-0.172372f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 9.517738f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.9526615f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095385f,1.309233f,0.133436f,-0.7031618f,-0.01397893f,-0.009656054f,0.7108269f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 9.619279f);
Get(0x6E70).SetLocalPose(0.08782487f,1.544559f,-1.091663f,0.5390905f,-0.1971897f,-0.7179117f,0.3938282f);
Get(0x6E82).SetLocalPose(0.01439785f,1.706964f,-1.306954f,0.9957923f,-0.0570709f,-0.01760853f,0.06950281f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.054202f);
Get(0x6EC6).SetLocalPose(0.311617f,1.544065f,-1.174282f,-0.1383191f,-0.974167f,-0.08613686f,-0.1563549f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095711f,1.309379f,0.1334278f,-0.7028816f,-0.01387794f,-0.009765162f,0.7111045f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 9.686877f);
Get(0x6E70).SetLocalPose(0.09070753f,1.544167f,-1.090887f,0.5351405f,-0.1933527f,-0.7205281f,0.3963315f);
Get(0x6E82).SetLocalPose(0.01529371f,1.707801f,-1.304519f,0.9956403f,-0.0603091f,-0.01538136f,0.06947423f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.1218f);
Get(0x6EC6).SetLocalPose(0.3130559f,1.544439f,-1.175929f,-0.1386615f,-0.9757279f,-0.08259601f,-0.1480073f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09578f,1.309445f,0.1332451f,-0.7029586f,-0.01387996f,-0.009670381f,0.7110296f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 9.74698f);
Get(0x6E70).SetLocalPose(0.09305331f,1.543126f,-1.090515f,0.5326234f,-0.190852f,-0.7223362f,0.3976407f);
Get(0x6E82).SetLocalPose(0.01391409f,1.709252f,-1.303195f,0.995351f,-0.06654008f,-0.02029554f,0.06661022f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.181902f);
Get(0x6EC6).SetLocalPose(0.3148652f,1.543096f,-1.17766f,-0.1382392f,-0.9768999f,-0.08021557f,-0.1418525f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09598f,1.309342f,0.1328535f,-0.7031259f,-0.01421938f,-0.009667026f,0.7108575f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 9.831862f);
Get(0x6E70).SetLocalPose(0.09711578f,1.542565f,-1.089854f,0.5275322f,-0.1874526f,-0.7262702f,0.3988771f);
Get(0x6E82).SetLocalPose(0.01327209f,1.712309f,-1.301856f,0.994855f,-0.0768184f,-0.02686048f,0.06034041f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.266785f);
Get(0x6EC6).SetLocalPose(0.3183804f,1.54167f,-1.179472f,-0.1369305f,-0.978148f,-0.07901124f,-0.1350325f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.096029f,1.309236f,0.1329556f,-0.7030628f,-0.01418618f,-0.00964951f,0.7109209f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 9.891913f);
Get(0x6E70).SetLocalPose(0.099093f,1.54079f,-1.089344f,0.5242052f,-0.1854316f,-0.7289976f,0.3992326f);
Get(0x6E82).SetLocalPose(0.01282026f,1.71469f,-1.302318f,0.9942209f,-0.08546283f,-0.02894638f,0.05816527f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.326835f);
Get(0x6EC6).SetLocalPose(0.3217266f,1.540592f,-1.181348f,-0.136287f,-0.9789935f,-0.07864418f,-0.129664f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.096065f,1.309314f,0.1330979f,-0.702962f,-0.01396394f,-0.009594739f,0.7110257f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 9.95297f);
Get(0x6E70).SetLocalPose(0.1019176f,1.540322f,-1.088739f,0.5203627f,-0.1823885f,-0.7323022f,0.3996131f);
Get(0x6E82).SetLocalPose(0.01234569f,1.715317f,-1.30158f,0.9933971f,-0.09399553f,-0.02953048f,0.05878077f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.387891f);
Get(0x6EC6).SetLocalPose(0.3242658f,1.539591f,-1.182584f,-0.1353338f,-0.9798364f,-0.07775084f,-0.124741f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.096037f,1.309302f,0.1331138f,-0.7029409f,-0.0139714f,-0.009653226f,0.7110455f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 9.984129f);
Get(0x6E70).SetLocalPose(0.1037254f,1.539514f,-1.088414f,0.5176908f,-0.1797522f,-0.7345853f,0.4000874f);
Get(0x6E82).SetLocalPose(0.01175878f,1.715525f,-1.301399f,0.9928859f,-0.09852669f,-0.03052307f,0.05948513f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.41905f);
Get(0x6EC6).SetLocalPose(0.3260772f,1.538819f,-1.184104f,-0.1347211f,-0.9802981f,-0.0775759f,-0.1218517f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 9.984129f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.41905f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095857f,1.309379f,0.1329706f,-0.7029777f,-0.01395748f,-0.009600272f,0.7110102f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 10.13357f);
Get(0x6E70).SetLocalPose(0.1106738f,1.537295f,-1.088699f,0.5088103f,-0.1687729f,-0.7427121f,0.4012562f);
Get(0x6E82).SetLocalPose(0.01746345f,1.718218f,-1.298931f,0.9892296f,-0.1225905f,-0.03712802f,0.07083881f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.568493f);
Get(0x6EC6).SetLocalPose(0.3316846f,1.539598f,-1.189698f,-0.1310622f,-0.9814219f,-0.07846193f,-0.1160921f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095676f,1.309456f,0.133146f,-0.7029492f,-0.01395817f,-0.00968924f,0.7110371f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 10.17031f);
Get(0x6E70).SetLocalPose(0.1130998f,1.537241f,-1.0887f,0.505751f,-0.1651804f,-0.74533f,0.4017644f);
Get(0x6E82).SetLocalPose(0.01759869f,1.717985f,-1.298606f,0.9880299f,-0.1273363f,-0.03856472f,0.0780724f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.605234f);
Get(0x6EC6).SetLocalPose(0.3334949f,1.539583f,-1.191711f,-0.1309467f,-0.9817182f,-0.07791408f,-0.1140688f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095736f,1.309459f,0.1331649f,-0.7029853f,-0.0139522f,-0.009638391f,0.7110022f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 10.22289f);
Get(0x6E70).SetLocalPose(0.1154937f,1.536881f,-1.087969f,0.5021744f,-0.1615323f,-0.7480502f,0.4026775f);
Get(0x6E82).SetLocalPose(0.01729458f,1.717406f,-1.297055f,0.986067f,-0.134641f,-0.04366227f,0.08739153f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.657813f);
Get(0x6EC6).SetLocalPose(0.3358019f,1.53903f,-1.194716f,-0.1313697f,-0.9821482f,-0.07717665f,-0.1103217f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095793f,1.309386f,0.133238f,-0.703058f,-0.01393564f,-0.00956076f,0.7109317f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 10.30996f);
Get(0x6E70).SetLocalPose(0.1196406f,1.535383f,-1.087797f,0.4965001f,-0.1568478f,-0.7519474f,0.4043038f);
Get(0x6E82).SetLocalPose(0.01703081f,1.71673f,-1.295077f,0.9832525f,-0.1427414f,-0.05324245f,0.1000239f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.74488f);
Get(0x6EC6).SetLocalPose(0.3395281f,1.537949f,-1.198582f,-0.1323046f,-0.9826105f,-0.07824559f,-0.1041619f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095897f,1.309533f,0.1334317f,-0.7029227f,-0.01399633f,-0.009588461f,0.7110639f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 10.38041f);
Get(0x6E70).SetLocalPose(0.1231371f,1.534075f,-1.087891f,0.4917511f,-0.1542947f,-0.7551022f,0.4052094f);
Get(0x6E82).SetLocalPose(0.01778098f,1.715324f,-1.294521f,0.9808274f,-0.1499971f,-0.06491045f,0.1061377f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.815335f);
Get(0x6EC6).SetLocalPose(0.3422577f,1.538596f,-1.202815f,-0.1320472f,-0.982923f,-0.08142215f,-0.09897705f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09596f,1.309605f,0.1333443f,-0.7028568f,-0.01393907f,-0.009508544f,0.7111312f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 10.42151f);
Get(0x6E70).SetLocalPose(0.1273441f,1.534208f,-1.088195f,0.4864494f,-0.1522904f,-0.7586938f,0.4056578f);
Get(0x6E82).SetLocalPose(0.01898681f,1.715004f,-1.294233f,0.9791803f,-0.1541876f,-0.07323346f,0.1098589f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.856436f);
Get(0x6EC6).SetLocalPose(0.3446405f,1.538373f,-1.20511f,-0.1308047f,-0.983215f,-0.08327498f,-0.09614395f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.096163f,1.309586f,0.1336761f,-0.7029106f,-0.0139604f,-0.009467351f,0.7110782f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 10.4613f);
Get(0x6E70).SetLocalPose(0.1292738f,1.533507f,-1.088514f,0.4836766f,-0.1517069f,-0.7606003f,0.4056219f);
Get(0x6E82).SetLocalPose(0.02074213f,1.715155f,-1.293752f,0.9778001f,-0.157169f,-0.08052327f,0.1127877f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.89622f);
Get(0x6EC6).SetLocalPose(0.3461482f,1.538586f,-1.2077f,-0.1291596f,-0.9835498f,-0.08375157f,-0.09451583f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.096272f,1.309459f,0.1338144f,-0.7031001f,-0.01402587f,-0.009488747f,0.7108892f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 10.57087f);
Get(0x6E70).SetLocalPose(0.1371588f,1.53122f,-1.090215f,0.4737105f,-0.150337f,-0.7674314f,0.4050263f);
Get(0x6E82).SetLocalPose(0.0269924f,1.712983f,-1.290989f,0.9737229f,-0.1658038f,-0.1007451f,0.1192611f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.005791f);
Get(0x6EC6).SetLocalPose(0.3519465f,1.536777f,-1.214868f,-0.1240282f,-0.9855422f,-0.08284397f,-0.08037636f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.096224f,1.309557f,0.1338862f,-0.7031588f,-0.01408853f,-0.009386205f,0.7108313f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 10.60853f);
Get(0x6E70).SetLocalPose(0.1396851f,1.530947f,-1.090747f,0.470717f,-0.1494977f,-0.7696344f,0.4046468f);
Get(0x6E82).SetLocalPose(0.02850565f,1.71262f,-1.289081f,0.9725124f,-0.1679765f,-0.1068867f,0.1207428f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.043455f);
Get(0x6EC6).SetLocalPose(0.3542708f,1.536273f,-1.217685f,-0.122709f,-0.9862809f,-0.08298859f,-0.0728379f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.096092f,1.309375f,0.1339754f,-0.7032546f,-0.0141267f,-0.009323908f,0.7107367f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 10.68662f);
Get(0x6E70).SetLocalPose(0.1453394f,1.528787f,-1.092777f,0.4647848f,-0.147087f,-0.7745728f,0.4029611f);
Get(0x6E82).SetLocalPose(0.03062164f,1.710637f,-1.286409f,0.9711336f,-0.1679637f,-0.1156928f,0.1237048f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.121544f);
Get(0x6EC6).SetLocalPose(0.3591553f,1.534565f,-1.22335f,-0.1227564f,-0.9863783f,-0.08689009f,-0.0666257f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.096087f,1.309443f,0.1340504f,-0.7032179f,-0.01404906f,-0.009446868f,0.7107729f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 10.72937f);
Get(0x6E70).SetLocalPose(0.1485829f,1.5284f,-1.093355f,0.4615656f,-0.145279f,-0.7773469f,0.4019739f);
Get(0x6E82).SetLocalPose(0.03296465f,1.711398f,-1.285022f,0.9706786f,-0.1638809f,-0.1229551f,0.1257311f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.164295f);
Get(0x6EC6).SetLocalPose(0.3637497f,1.533104f,-1.226914f,-0.1251445f,-0.9851577f,-0.09409767f,-0.07034905f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.096267f,1.309565f,0.1339776f,-0.7031323f,-0.01405348f,-0.009447548f,0.7108573f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 10.77657f);
Get(0x6E70).SetLocalPose(0.1528478f,1.52734f,-1.094622f,0.4579664f,-0.1427711f,-0.78031f,0.4012474f);
Get(0x6E82).SetLocalPose(0.03690957f,1.711065f,-1.283202f,0.9705608f,-0.1573254f,-0.1337791f,0.1239503f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.211493f);
Get(0x6EC6).SetLocalPose(0.3693579f,1.531474f,-1.230641f,-0.128462f,-0.9831246f,-0.1051091f,-0.07691329f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.096333f,1.309574f,0.1338697f,-0.7030063f,-0.0142005f,-0.009312036f,0.7109809f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 10.8594f);
Get(0x6E70).SetLocalPose(0.160623f,1.52795f,-1.096854f,0.4522185f,-0.1371647f,-0.784768f,0.4010281f);
Get(0x6E82).SetLocalPose(0.04066557f,1.710789f,-1.279677f,0.9704484f,-0.1487788f,-0.1512975f,0.1149078f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.294324f);
Get(0x6EC6).SetLocalPose(0.375594f,1.530158f,-1.234325f,-0.133792f,-0.9806314f,-0.1171278f,-0.08211484f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.096102f,1.309669f,0.1336984f,-0.703003f,-0.01426432f,-0.009201253f,0.7109843f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001", 0, 10.90037f);
Get(0x6E70).SetLocalPose(0.1663648f,1.527635f,-1.098166f,0.4477723f,-0.1319293f,-0.7880555f,0.4013268f);
Get(0x6E82).SetLocalPose(0.04178753f,1.710276f,-1.275544f,0.9705039f,-0.1413192f,-0.1641665f,0.1058317f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.335293f);
Get(0x6EC6).SetLocalPose(0.3865107f,1.527811f,-1.2402f,-0.1462514f,-0.9768545f,-0.1322818f,-0.08286881f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.096047f,1.309678f,0.1335034f,-0.7030259f,-0.01422486f,-0.009320343f,0.7109609f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0f);
Get(0x6E70).SetLocalPose(0.1722321f,1.52618f,-1.100019f,0.4434102f,-0.1264597f,-0.7910958f,0.4019489f);
Get(0x6E82).SetLocalPose(0.04357355f,1.709215f,-1.271328f,0.9704905f,-0.1333307f,-0.1760112f,0.09690814f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.379006f);
Get(0x6EC6).SetLocalPose(0.3931128f,1.526388f,-1.244029f,-0.1561862f,-0.9746765f,-0.1389987f,-0.07931583f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.096007f,1.309477f,0.1334449f,-0.7030275f,-0.01415154f,-0.009325672f,0.7109607f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.1060477f);
Get(0x6E70).SetLocalPose(0.1862328f,1.524196f,-1.106697f,0.4318541f,-0.114805f,-0.7984864f,0.403412f);
Get(0x6E82).SetLocalPose(0.0517507f,1.709768f,-1.259728f,0.9698536f,-0.1095093f,-0.2073877f,0.06619815f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.485054f);
Get(0x6EC6).SetLocalPose(0.4116282f,1.521685f,-1.254282f,-0.1798421f,-0.9695681f,-0.1511004f,-0.06901585f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095841f,1.309747f,0.133279f,-0.7030428f,-0.0142322f,-0.009231438f,0.7109452f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.1814938f);
Get(0x6E70).SetLocalPose(0.1953926f,1.523937f,-1.110334f,0.4231323f,-0.1110059f,-0.8030322f,0.4046928f);
Get(0x6E82).SetLocalPose(0.05498478f,1.708766f,-1.250412f,0.9690667f,-0.08848176f,-0.2257989f,0.04577689f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.5605f);
Get(0x6EC6).SetLocalPose(0.4223439f,1.517365f,-1.260355f,-0.1898861f,-0.9672531f,-0.1579839f,-0.05835846f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095584f,1.309647f,0.1331865f,-0.7030002f,-0.01422906f,-0.009295037f,0.7109866f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.2421818f);
Get(0x6E70).SetLocalPose(0.2044129f,1.524965f,-1.113443f,0.4133824f,-0.1093429f,-0.8074361f,0.4064555f);
Get(0x6E82).SetLocalPose(0.05657173f,1.706964f,-1.241335f,0.9663083f,-0.06646658f,-0.2471867f,0.02700729f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.621188f);
Get(0x6EC6).SetLocalPose(0.4320864f,1.513417f,-1.265482f,-0.1985396f,-0.964886f,-0.1660801f,-0.04466098f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095484f,1.309512f,0.1333338f,-0.7029526f,-0.01413742f,-0.009251627f,0.711036f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.3005409f);
Get(0x6E70).SetLocalPose(0.216801f,1.528572f,-1.118013f,0.3983182f,-0.1079525f,-0.81328f,0.4102006f);
Get(0x6E82).SetLocalPose(0.05835776f,1.705248f,-1.22678f,0.96128f,-0.04051498f,-0.2725721f,0.001960505f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.679547f);
Get(0x6EC6).SetLocalPose(0.4437521f,1.507738f,-1.273218f,-0.2095689f,-0.961241f,-0.1778629f,-0.02147775f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095557f,1.309358f,0.1334844f,-0.7029634f,-0.01406803f,-0.009158175f,0.711028f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.3598547f);
Get(0x6E70).SetLocalPose(0.227113f,1.529887f,-1.122198f,0.384559f,-0.1069835f,-0.8181016f,0.413979f);
Get(0x6E82).SetLocalPose(0.06155313f,1.703692f,-1.212756f,0.9552943f,-0.01519241f,-0.2941645f,-0.02548137f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.738861f);
Get(0x6EC6).SetLocalPose(0.4529965f,1.502915f,-1.280078f,-0.218214f,-0.9583901f,-0.184034f,-0.001605634f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095469f,1.308893f,0.1331907f,-0.7029318f,-0.01402232f,-0.00912726f,0.7110605f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.4241612f);
Get(0x6E70).SetLocalPose(0.2381324f,1.531875f,-1.126297f,0.3707249f,-0.1052947f,-0.8229377f,0.4174321f);
Get(0x6E82).SetLocalPose(0.06808057f,1.697893f,-1.196475f,0.9498698f,0.008036957f,-0.3078097f,-0.05418491f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.803167f);
Get(0x6EC6).SetLocalPose(0.4591097f,1.50009f,-1.285551f,-0.2233826f,-0.9569314f,-0.1851813f,0.009520689f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095639f,1.308876f,0.1330629f,-0.7029809f,-0.01384184f,-0.008961012f,0.7110175f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.4895233f);
Get(0x6E70).SetLocalPose(0.2498417f,1.532663f,-1.131279f,0.3557921f,-0.1023078f,-0.8287764f,0.4196126f);
Get(0x6E82).SetLocalPose(0.07669229f,1.687707f,-1.176754f,0.9453544f,0.02803428f,-0.3128879f,-0.08729417f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.868529f);
Get(0x6EC6).SetLocalPose(0.4694938f,1.494384f,-1.29574f,-0.2333582f,-0.9542259f,-0.1856631f,0.02293744f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.4895233f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.868529f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.096161f,1.308881f,0.1330976f,-0.703086f,-0.01392127f,-0.009071787f,0.7109108f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.5895615f);
Get(0x6E70).SetLocalPose(0.2681567f,1.534599f,-1.138782f,0.3314177f,-0.09577917f,-0.8385358f,0.4217184f);
Get(0x6E82).SetLocalPose(0.09277977f,1.670404f,-1.141438f,0.9424658f,0.03861664f,-0.3009744f,-0.1402902f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.968567f);
Get(0x6EC6).SetLocalPose(0.4842135f,1.485868f,-1.312981f,-0.2481075f,-0.9487602f,-0.1918597f,0.03855941f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095969f,1.309073f,0.1333786f,-0.7029651f,-0.01407419f,-0.008908528f,0.7110293f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.6651165f);
Get(0x6E70).SetLocalPose(0.2773136f,1.536323f,-1.141996f,0.3190317f,-0.09224074f,-0.8426883f,0.4237769f);
Get(0x6E82).SetLocalPose(0.1060295f,1.656276f,-1.121421f,0.9404193f,0.03418924f,-0.2907653f,-0.172911f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.044122f);
Get(0x6EC6).SetLocalPose(0.4907636f,1.481357f,-1.323256f,-0.2529608f,-0.9468799f,-0.1927648f,0.04765626f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.096243f,1.309174f,0.133333f,-0.7028778f,-0.01415759f,-0.008905338f,0.711114f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.7262492f);
Get(0x6E70).SetLocalPose(0.2881794f,1.538399f,-1.145582f,0.3035631f,-0.08782719f,-0.8471685f,0.4271316f);
Get(0x6E82).SetLocalPose(0.1189985f,1.643859f,-1.105004f,0.9355428f,0.02444318f,-0.2879974f,-0.2030265f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.105255f);
Get(0x6EC6).SetLocalPose(0.49499f,1.478753f,-1.331372f,-0.2570209f,-0.9455491f,-0.1912562f,0.05742967f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.096262f,1.309425f,0.1331022f,-0.7028519f,-0.01417769f,-0.00916547f,0.7111359f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.7851492f);
Get(0x6E70).SetLocalPose(0.2968605f,1.539733f,-1.148506f,0.2915946f,-0.084102f,-0.8503583f,0.4298723f);
Get(0x6E82).SetLocalPose(0.1310079f,1.628489f,-1.090454f,0.9274134f,0.01223384f,-0.2924674f,-0.2328467f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.164155f);
Get(0x6EC6).SetLocalPose(0.4998119f,1.475878f,-1.341498f,-0.2627927f,-0.9437001f,-0.1870005f,0.07349043f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.096353f,1.309552f,0.1329702f,-0.7028525f,-0.01411661f,-0.009251432f,0.7111354f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.8427054f);
Get(0x6E70).SetLocalPose(0.3070239f,1.541226f,-1.151696f,0.2785811f,-0.07966288f,-0.853707f,0.4327019f);
Get(0x6E82).SetLocalPose(0.1408489f,1.617314f,-1.081006f,0.9193851f,0.0008843291f,-0.2986571f,-0.2559963f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.221711f);
Get(0x6EC6).SetLocalPose(0.5030809f,1.475049f,-1.349173f,-0.2662354f,-0.9420362f,-0.1840415f,0.08840489f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.096181f,1.309263f,0.1334164f,-0.702808f,-0.0141117f,-0.009314018f,0.7111787f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.9027168f);
Get(0x6E70).SetLocalPose(0.3146834f,1.543134f,-1.153667f,0.2688129f,-0.07646392f,-0.8559965f,0.4349284f);
Get(0x6E82).SetLocalPose(0.1528786f,1.601748f,-1.071661f,0.9081961f,-0.01777966f,-0.3069194f,-0.2840146f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.281723f);
Get(0x6EC6).SetLocalPose(0.5061899f,1.475317f,-1.357666f,-0.2665747f,-0.9404283f,-0.1809018f,0.1086601f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.096234f,1.309143f,0.1337637f,-0.7027691f,-0.01424626f,-0.009408181f,0.7112131f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.9610934f);
Get(0x6E70).SetLocalPose(0.3222642f,1.545605f,-1.154689f,0.2582285f,-0.0737113f,-0.8581054f,0.4376527f);
Get(0x6E82).SetLocalPose(0.1634774f,1.591946f,-1.066833f,0.8996147f,-0.03521793f,-0.313817f,-0.3016158f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.340099f);
Get(0x6EC6).SetLocalPose(0.5081792f,1.475934f,-1.364158f,-0.2651134f,-0.9394946f,-0.1763851f,0.1263057f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 0.9610934f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.340099f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095875f,1.309356f,0.1334075f,-0.7028617f,-0.01416382f,-0.009449326f,0.7111228f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.059768f);
Get(0x6E70).SetLocalPose(0.3355161f,1.548217f,-1.156215f,0.2419183f,-0.06978856f,-0.8609432f,0.4420204f);
Get(0x6E82).SetLocalPose(0.1827738f,1.575936f,-1.064609f,0.8920791f,-0.0626006f,-0.3198514f,-0.3130035f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.438774f);
Get(0x6EC6).SetLocalPose(0.5109861f,1.479084f,-1.376366f,-0.2604025f,-0.9383303f,-0.162038f,0.1595948f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095756f,1.309355f,0.1335124f,-0.7029171f,-0.01449301f,-0.009483541f,0.7110609f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.165716f);
Get(0x6E70).SetLocalPose(0.3462311f,1.549146f,-1.155871f,0.2302806f,-0.06664035f,-0.8629349f,0.4448296f);
Get(0x6E82).SetLocalPose(0.1989423f,1.566109f,-1.067209f,0.8917291f,-0.07678106f,-0.3246412f,-0.3058298f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.544722f);
Get(0x6EC6).SetLocalPose(0.511539f,1.482264f,-1.383694f,-0.2515869f,-0.9383567f,-0.1509348f,0.1827827f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095659f,1.309386f,0.1336297f,-0.7028486f,-0.01441527f,-0.009375363f,0.7111316f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.224061f);
Get(0x6E70).SetLocalPose(0.351631f,1.549013f,-1.155225f,0.2255744f,-0.06507299f,-0.8637315f,0.4459257f);
Get(0x6E82).SetLocalPose(0.2075858f,1.562232f,-1.069135f,0.8918166f,-0.08043784f,-0.3295494f,-0.299316f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.603067f);
Get(0x6EC6).SetLocalPose(0.511349f,1.485186f,-1.386708f,-0.245328f,-0.938705f,-0.145318f,0.1937261f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095961f,1.309422f,0.1338702f,-0.7028368f,-0.01441264f,-0.00943053f,0.7111427f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.280805f);
Get(0x6E70).SetLocalPose(0.3571808f,1.548943f,-1.153943f,0.2213389f,-0.06347027f,-0.8646085f,0.446579f);
Get(0x6E82).SetLocalPose(0.2173482f,1.559964f,-1.070296f,0.8906582f,-0.08417123f,-0.3381111f,-0.2921029f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.659811f);
Get(0x6EC6).SetLocalPose(0.5108119f,1.487009f,-1.390063f,-0.2385817f,-0.9393313f,-0.1380187f,0.2041722f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095942f,1.309457f,0.1337426f,-0.7029549f,-0.01448968f,-0.009524611f,0.7110231f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.340011f);
Get(0x6E70).SetLocalPose(0.3621568f,1.548122f,-1.15249f,0.2182198f,-0.06204696f,-0.8655125f,0.4465631f);
Get(0x6E82).SetLocalPose(0.2265173f,1.557978f,-1.071568f,0.8893546f,-0.08919501f,-0.3465861f,-0.2845536f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.719018f);
Get(0x6EC6).SetLocalPose(0.5097411f,1.489565f,-1.391917f,-0.2330511f,-0.9395182f,-0.1310008f,0.214083f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095499f,1.309395f,0.1335154f,-0.7030426f,-0.01445479f,-0.009486763f,0.7109376f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.40016f);
Get(0x6E70).SetLocalPose(0.367878f,1.54876f,-1.150227f,0.2154256f,-0.06028239f,-0.8666603f,0.4459347f);
Get(0x6E82).SetLocalPose(0.2353588f,1.556994f,-1.073392f,0.8882119f,-0.0925159f,-0.353865f,-0.278029f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.779166f);
Get(0x6EC6).SetLocalPose(0.5085159f,1.491095f,-1.392676f,-0.2271546f,-0.9388728f,-0.1239448f,0.2270601f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09549f,1.309454f,0.1334598f,-0.7030364f,-0.01445736f,-0.009478495f,0.7109438f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.42865f);
Get(0x6E70).SetLocalPose(0.3699225f,1.548881f,-1.149239f,0.2144818f,-0.0595424f,-0.8671091f,0.4456166f);
Get(0x6E82).SetLocalPose(0.2415882f,1.556039f,-1.073893f,0.8872037f,-0.09381334f,-0.3590443f,-0.2741459f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.807657f);
Get(0x6EC6).SetLocalPose(0.5081017f,1.491261f,-1.393f,-0.2243894f,-0.9384726f,-0.1216968f,0.2326122f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.42865f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.807657f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095681f,1.309966f,0.1337327f,-0.7030017f,-0.01432316f,-0.009543668f,0.71098f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.578418f);
Get(0x6E70).SetLocalPose(0.3835199f,1.546094f,-1.141632f,0.2100041f,-0.05592512f,-0.8697158f,0.4431311f);
Get(0x6E82).SetLocalPose(0.2636144f,1.552176f,-1.074127f,0.8820932f,-0.1015985f,-0.3799326f,-0.2593078f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.957424f);
Get(0x6EC6).SetLocalPose(0.5063486f,1.490736f,-1.390248f,-0.202081f,-0.93497f,-0.1188947f,0.2661927f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095389f,1.31003f,0.1337737f,-0.7030028f,-0.01440745f,-0.009535467f,0.7109773f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.639022f);
Get(0x6E70).SetLocalPose(0.3882468f,1.545144f,-1.138152f,0.2089808f,-0.05484237f,-0.8705657f,0.4420801f);
Get(0x6E82).SetLocalPose(0.2754431f,1.548347f,-1.074369f,0.8804857f,-0.1101656f,-0.386716f,-0.2511165f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.018029f);
Get(0x6EC6).SetLocalPose(0.5054172f,1.490798f,-1.387096f,-0.1905643f,-0.9337295f,-0.1217235f,0.277521f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095298f,1.309932f,0.1336067f,-0.7031301f,-0.01443603f,-0.009569244f,0.7108503f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.69881f);
Get(0x6E70).SetLocalPose(0.3947705f,1.543664f,-1.133653f,0.2080251f,-0.05353897f,-0.8716505f,0.4405505f);
Get(0x6E82).SetLocalPose(0.2865154f,1.544663f,-1.074503f,0.8791469f,-0.1208672f,-0.3907169f,-0.2446058f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.077817f);
Get(0x6EC6).SetLocalPose(0.5045841f,1.490921f,-1.382694f,-0.1777673f,-0.9323738f,-0.1260839f,0.2884107f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.09517f,1.309867f,0.1333708f,-0.7031054f,-0.01439338f,-0.009608812f,0.710875f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.757171f);
Get(0x6E70).SetLocalPose(0.4016915f,1.542087f,-1.128073f,0.2071313f,-0.05252564f,-0.8726519f,0.4391088f);
Get(0x6E82).SetLocalPose(0.2977948f,1.541049f,-1.074215f,0.8770872f,-0.13298f,-0.3945746f,-0.2394687f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.136178f);
Get(0x6EC6).SetLocalPose(0.5031369f,1.491407f,-1.376695f,-0.1614069f,-0.9291362f,-0.1319934f,0.3053383f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095171f,1.309468f,0.133363f,-0.7030244f,-0.01432635f,-0.009641987f,0.7109561f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.818638f);
Get(0x6E70).SetLocalPose(0.4084567f,1.540924f,-1.122843f,0.2060103f,-0.05193588f,-0.8735586f,0.4379017f);
Get(0x6E82).SetLocalPose(0.3079624f,1.538262f,-1.073119f,0.8745691f,-0.1453826f,-0.3984528f,-0.2350064f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.197645f);
Get(0x6EC6).SetLocalPose(0.5022383f,1.491397f,-1.368953f,-0.1439904f,-0.9228324f,-0.1371513f,0.3299043f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095114f,1.3091f,0.1331899f,-0.7030542f,-0.01434829f,-0.009600891f,0.7109268f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.883512f);
Get(0x6E70).SetLocalPose(0.4153912f,1.537922f,-1.11802f,0.204515f,-0.05174829f,-0.8746996f,0.4363443f);
Get(0x6E82).SetLocalPose(0.3206588f,1.534279f,-1.071469f,0.8710763f,-0.1613074f,-0.4035091f,-0.2288808f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.262518f);
Get(0x6EC6).SetLocalPose(0.5015099f,1.492251f,-1.362729f,-0.1328585f,-0.917449f,-0.1402994f,0.3477816f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094853f,1.308899f,0.1331338f,-0.7030592f,-0.01433671f,-0.009649488f,0.7109213f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 1.911409f);
Get(0x6E70).SetLocalPose(0.4199079f,1.535934f,-1.113929f,0.2033758f,-0.0516139f,-0.8756943f,0.4348951f);
Get(0x6E82).SetLocalPose(0.3266351f,1.53168f,-1.070903f,0.8692079f,-0.1684365f,-0.4061355f,-0.2261874f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.290416f);
Get(0x6EC6).SetLocalPose(0.5019169f,1.49281f,-1.356806f,-0.123771f,-0.9130133f,-0.1442292f,0.3609509f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.094608f,1.30918f,0.133069f,-0.7030437f,-0.01434713f,-0.009665235f,0.7109362f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.015441f);
Get(0x6E70).SetLocalPose(0.4311767f,1.529477f,-1.103692f,0.2013012f,-0.05092563f,-0.8780208f,0.4312354f);
Get(0x6E82).SetLocalPose(0.3481208f,1.524533f,-1.06781f,0.8608698f,-0.1903575f,-0.4160549f,-0.2226333f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.394448f);
Get(0x6EC6).SetLocalPose(0.5058991f,1.493826f,-1.341749f,-0.1053312f,-0.9057095f,-0.1556721f,0.3799497f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095015f,1.309226f,0.1330046f,-0.7030452f,-0.01428522f,-0.009663619f,0.710936f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.084224f);
Get(0x6E70).SetLocalPose(0.43938f,1.52415f,-1.095538f,0.2000647f,-0.05039549f,-0.8795133f,0.4288248f);
Get(0x6E82).SetLocalPose(0.3579663f,1.520897f,-1.063883f,0.8570117f,-0.1961708f,-0.4213923f,-0.2224333f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.463231f);
Get(0x6EC6).SetLocalPose(0.5093921f,1.49421f,-1.332325f,-0.09688393f,-0.9033047f,-0.1636974f,0.3845222f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095008f,1.309404f,0.1332751f,-0.7030314f,-0.01432819f,-0.009682064f,0.7109485f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.14393f);
Get(0x6E70).SetLocalPose(0.4456368f,1.520168f,-1.089324f,0.1991684f,-0.04988099f,-0.8805537f,0.4271641f);
Get(0x6E82).SetLocalPose(0.3681986f,1.517627f,-1.058673f,0.8534964f,-0.1996114f,-0.4270991f,-0.2220037f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.522937f);
Get(0x6EC6).SetLocalPose(0.5125791f,1.493986f,-1.324481f,-0.09185673f,-0.9019804f,-0.1700254f,0.3861153f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095251f,1.309599f,0.1334059f,-0.7030372f,-0.01434437f,-0.00963736f,0.7109431f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.202171f);
Get(0x6E70).SetLocalPose(0.4502312f,1.520046f,-1.084507f,0.1983943f,-0.04919616f,-0.8817071f,0.42522f);
Get(0x6E82).SetLocalPose(0.3787465f,1.513967f,-1.052358f,0.8509743f,-0.2013647f,-0.4318467f,-0.2209153f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.581178f);
Get(0x6EC6).SetLocalPose(0.5157044f,1.492716f,-1.313994f,-0.08751017f,-0.9006481f,-0.1757487f,0.3876693f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095131f,1.309483f,0.133059f,-0.7030422f,-0.01434417f,-0.009640113f,0.7109381f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.261755f);
Get(0x6E70).SetLocalPose(0.456283f,1.516297f,-1.078209f,0.1975845f,-0.04815599f,-0.8827953f,0.4234547f);
Get(0x6E82).SetLocalPose(0.3871716f,1.511294f,-1.045894f,0.8492018f,-0.2011709f,-0.4353653f,-0.2210057f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.640762f);
Get(0x6EC6).SetLocalPose(0.5195207f,1.4916f,-1.305385f,-0.08352261f,-0.8995085f,-0.179476f,0.3894826f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095192f,1.309439f,0.1328575f,-0.7030264f,-0.01435622f,-0.009700935f,0.7109527f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.322643f);
Get(0x6E70).SetLocalPose(0.4622901f,1.511984f,-1.073158f,0.1968075f,-0.04677432f,-0.8836665f,0.4221522f);
Get(0x6E82).SetLocalPose(0.3958275f,1.509068f,-1.03829f,0.8475815f,-0.1985681f,-0.438812f,-0.2227563f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.701649f);
Get(0x6EC6).SetLocalPose(0.5231891f,1.490845f,-1.296834f,-0.08047194f,-0.8985466f,-0.1812976f,0.3914965f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095427f,1.309226f,0.1329145f,-0.703018f,-0.01434462f,-0.009629221f,0.7109623f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.385438f);
Get(0x6E70).SetLocalPose(0.4697258f,1.508586f,-1.064635f,0.1962716f,-0.04494185f,-0.8842261f,0.4214284f);
Get(0x6E82).SetLocalPose(0.4050253f,1.507103f,-1.028608f,0.8455797f,-0.1928446f,-0.4434509f,-0.2261798f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.764445f);
Get(0x6EC6).SetLocalPose(0.5289086f,1.49046f,-1.285961f,-0.07869688f,-0.8968557f,-0.1826211f,0.3951026f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.385438f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.764445f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095256f,1.309265f,0.1330308f,-0.7030788f,-0.01440629f,-0.009677514f,0.7109002f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.485474f);
Get(0x6E70).SetLocalPose(0.4822727f,1.505826f,-1.047954f,0.1973233f,-0.04087359f,-0.8848646f,0.4200089f);
Get(0x6E82).SetLocalPose(0.419604f,1.505876f,-1.011664f,0.8410351f,-0.1826563f,-0.4523333f,-0.2338614f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.86448f);
Get(0x6EC6).SetLocalPose(0.5385113f,1.490648f,-1.268637f,-0.07747182f,-0.8928801f,-0.1895024f,0.4010636f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095592f,1.309595f,0.1329456f,-0.7030361f,-0.01439468f,-0.009578134f,0.7109439f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.58108f);
Get(0x6E70).SetLocalPose(0.4917305f,1.504694f,-1.032624f,0.2003317f,-0.03691544f,-0.885968f,0.4166116f);
Get(0x6E82).SetLocalPose(0.4287926f,1.504508f,-0.998753f,0.8381372f,-0.1752104f,-0.4572819f,-0.240251f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 4.960087f);
Get(0x6EC6).SetLocalPose(0.5475177f,1.489824f,-1.255047f,-0.07709967f,-0.8899527f,-0.1962394f,0.4043884f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095695f,1.309693f,0.133264f,-0.7030315f,-0.01442514f,-0.009574146f,0.710948f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.640501f);
Get(0x6E70).SetLocalPose(0.4983111f,1.505006f,-1.021844f,0.2042065f,-0.03368736f,-0.8867357f,0.413358f);
Get(0x6E82).SetLocalPose(0.4374305f,1.50333f,-0.9864119f,0.8354608f,-0.1685436f,-0.4610651f,-0.2470167f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.019507f);
Get(0x6EC6).SetLocalPose(0.554128f,1.488488f,-1.2462f,-0.07805439f,-0.8886745f,-0.1992339f,0.4055502f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095708f,1.309726f,0.1332839f,-0.7030498f,-0.01443496f,-0.009600038f,0.7109294f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.668895f);
Get(0x6E70).SetLocalPose(0.5019686f,1.504715f,-1.016038f,0.2069577f,-0.03188755f,-0.8871355f,0.4112693f);
Get(0x6E82).SetLocalPose(0.4400409f,1.503031f,-0.9819028f,0.8346029f,-0.1670125f,-0.4620398f,-0.2491267f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.047901f);
Get(0x6EC6).SetLocalPose(0.558478f,1.487931f,-1.240691f,-0.07843252f,-0.8876607f,-0.2011061f,0.4067716f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095646f,1.309633f,0.1333777f,-0.703092f,-0.01442158f,-0.009591595f,0.7108879f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.761207f);
Get(0x6E70).SetLocalPose(0.5105831f,1.503538f,-0.9997547f,0.2138927f,-0.02847857f,-0.8881534f,0.4057367f);
Get(0x6E82).SetLocalPose(0.4483859f,1.50311f,-0.970175f,0.8322501f,-0.1649871f,-0.4641548f,-0.2543609f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.140214f);
Get(0x6EC6).SetLocalPose(0.5677989f,1.487655f,-1.228131f,-0.07831375f,-0.8845226f,-0.2066345f,0.4108392f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095366f,1.30949f,0.1333351f,-0.7030739f,-0.01442026f,-0.009585081f,0.7109061f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.818698f);
Get(0x6E70).SetLocalPose(0.5151944f,1.503667f,-0.9919269f,0.2169931f,-0.02716978f,-0.8887226f,0.4029242f);
Get(0x6E82).SetLocalPose(0.4587383f,1.500954f,-0.9574406f,0.829643f,-0.1651338f,-0.4659955f,-0.2593678f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.197705f);
Get(0x6EC6).SetLocalPose(0.5743273f,1.487941f,-1.21929f,-0.07759739f,-0.8813044f,-0.212317f,0.414973f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095373f,1.309289f,0.1333845f,-0.7030805f,-0.01439018f,-0.009627681f,0.7108995f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.87459f);
Get(0x6E70).SetLocalPose(0.525855f,1.515343f,-0.9803153f,0.2209732f,-0.02530755f,-0.8888039f,0.4006969f);
Get(0x6E82).SetLocalPose(0.4666132f,1.498965f,-0.9491008f,0.8279653f,-0.1656959f,-0.4673763f,-0.2618736f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.253597f);
Get(0x6EC6).SetLocalPose(0.5803378f,1.487992f,-1.210896f,-0.07596939f,-0.8779952f,-0.2177206f,0.419465f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 2.87459f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.253597f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(4.095193f,1.309248f,0.1332941f,-0.703072f,-0.01438405f,-0.009660054f,0.7109076f);
Get(0x6E66).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 3.005901f);
Get(0x6E70).SetLocalPose(0.5364769f,1.512137f,-0.9603801f,0.2243036f,-0.02417924f,-0.8897154f,0.3968751f);
Get(0x6E82).SetLocalPose(0.4818284f,1.496162f,-0.9328857f,0.8238624f,-0.1649342f,-0.4736421f,-0.2640279f);
Get(0x6E9E).GetComponent<Animator>().Play("Armature_ArmatureAction_001 0", 0, 5.384908f);
Get(0x6EC6).SetLocalPose(0.5932436f,1.489027f,-1.193897f,-0.06964147f,-0.870473f,-0.2263299f,0.4315108f);
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

