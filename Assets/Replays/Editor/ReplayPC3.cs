using System;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class ReplayPC3 : ReplayBase {
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
Get(0x6E82).SetLocalPose(-0.1718941f,0.9177832f,-0.3061971f,-0.3398127f,0.07116593f,0.04202904f,0.9368545f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.02f);
Get(0x6E70).SetLocalPose(-0.1150752f,1.675821f,-0.4369137f,0.421283f,-0.3935589f,-0.5722248f,0.5832589f);
Get(0x6E82).SetLocalPose(-0.1710709f,0.9196459f,-0.304638f,-0.3431614f,0.07059056f,0.04370173f,0.9356f);
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
Get(0x6E38).SetLocalPose(1.322129f,1.538597f,0.483446f,-0.6545919f,-0.208233f,-0.2497486f,0.6824765f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.3533334f);
Get(0x6E70).SetLocalPose(-0.1097111f,1.642929f,-0.4234191f,0.4553424f,-0.3220816f,-0.6453404f,0.5219796f);
Get(0x6E82).SetLocalPose(-0.05744771f,1.217721f,-0.2226682f,-0.7112671f,0.08614079f,0.2028728f,0.6674742f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.3533334f);
Get(0x6EC6).SetLocalPose(0.1395893f,1.236201f,-0.2795033f,-0.08545193f,-0.8044642f,-0.5701891f,0.1428978f);
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
Get(0x6E38).SetLocalPose(1.322065f,1.538466f,0.4835418f,-0.6545965f,-0.2082244f,-0.2497327f,0.6824805f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.4203851f);
Get(0x6E70).SetLocalPose(-0.1107814f,1.642628f,-0.4238754f,0.4585215f,-0.3230395f,-0.6447459f,0.5193327f);
Get(0x6E82).SetLocalPose(-0.0568958f,1.216716f,-0.223583f,-0.7123368f,0.09040296f,0.1996625f,0.6667372f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.4203851f);
Get(0x6EC6).SetLocalPose(0.1379805f,1.234488f,-0.2784609f,-0.08453161f,-0.8020629f,-0.5743542f,0.1402384f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322231f,1.53845f,0.4833389f,-0.654583f,-0.2082598f,-0.2497196f,0.6824874f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.4522774f);
Get(0x6E70).SetLocalPose(-0.1122914f,1.642137f,-0.4242507f,0.4615242f,-0.3243706f,-0.6431468f,0.5178236f);
Get(0x6E82).SetLocalPose(-0.05675221f,1.216287f,-0.2242869f,-0.7113386f,0.09211958f,0.1997885f,0.6675298f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.4522774f);
Get(0x6EC6).SetLocalPose(0.1378641f,1.233711f,-0.2789728f,-0.08426532f,-0.8015577f,-0.5752175f,0.1397484f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32233f,1.538426f,0.4832379f,-0.6545898f,-0.2082629f,-0.249721f,0.6824794f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.466258f);
Get(0x6E70).SetLocalPose(-0.1133596f,1.641841f,-0.4244136f,0.4636177f,-0.3255328f,-0.6418408f,0.5168438f);
Get(0x6E82).SetLocalPose(-0.05658631f,1.216118f,-0.2246504f,-0.7106728f,0.09282354f,0.2002176f,0.6680127f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.466258f);
Get(0x6EC6).SetLocalPose(0.1378753f,1.232539f,-0.278962f,-0.08490807f,-0.8009928f,-0.5761011f,0.1389555f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322297f,1.538367f,0.4832857f,-0.654574f,-0.2082583f,-0.249733f,0.6824916f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.4888513f);
Get(0x6E70).SetLocalPose(-0.1156658f,1.641917f,-0.424474f,0.4681096f,-0.3283824f,-0.6388705f,0.5146677f);
Get(0x6E82).SetLocalPose(-0.05577046f,1.215831f,-0.225543f,-0.708526f,0.095346f,0.2023356f,0.6692985f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.4888513f);
Get(0x6EC6).SetLocalPose(0.1381282f,1.230763f,-0.2784305f,-0.08730164f,-0.7997215f,-0.5784225f,0.1350978f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322431f,1.538313f,0.4832014f,-0.6545851f,-0.2082562f,-0.249736f,0.6824805f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.5196602f);
Get(0x6E70).SetLocalPose(-0.1193551f,1.642902f,-0.426324f,0.4769722f,-0.3346074f,-0.6328126f,0.509984f);
Get(0x6E82).SetLocalPose(-0.05309098f,1.214791f,-0.2274318f,-0.7062781f,0.1011632f,0.2050102f,0.670006f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.5196602f);
Get(0x6EC6).SetLocalPose(0.1396439f,1.22711f,-0.2782282f,-0.09308527f,-0.7967389f,-0.5832205f,0.1280472f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322457f,1.538415f,0.4831747f,-0.6545985f,-0.208262f,-0.2497344f,0.6824664f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.5340419f);
Get(0x6E70).SetLocalPose(-0.121893f,1.642568f,-0.4269735f,0.4825482f,-0.3391649f,-0.6288138f,0.5066632f);
Get(0x6E82).SetLocalPose(-0.05127921f,1.213908f,-0.2287547f,-0.7050231f,0.1051693f,0.2066007f,0.6702224f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.5340419f);
Get(0x6EC6).SetLocalPose(0.1412681f,1.224836f,-0.2779479f,-0.09833074f,-0.7938148f,-0.5873017f,0.1235556f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322477f,1.53844f,0.4832011f,-0.6545725f,-0.2082712f,-0.2497305f,0.6824901f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.5525392f);
Get(0x6E70).SetLocalPose(-0.1246758f,1.642242f,-0.4282059f,0.4884082f,-0.3441387f,-0.624531f,0.5029783f);
Get(0x6E82).SetLocalPose(-0.04882461f,1.212985f,-0.2302815f,-0.7036573f,0.1108442f,0.2085098f,0.670152f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.5525392f);
Get(0x6EC6).SetLocalPose(0.1433676f,1.221973f,-0.2773259f,-0.1053486f,-0.7895784f,-0.5927302f,0.1189056f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322513f,1.538378f,0.4831783f,-0.65456f,-0.208263f,-0.2497178f,0.6825092f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.5674509f);
Get(0x6E70).SetLocalPose(-0.1280951f,1.642161f,-0.4294052f,0.4952757f,-0.3499905f,-0.6194388f,0.4985021f);
Get(0x6E82).SetLocalPose(-0.0467895f,1.211747f,-0.2316702f,-0.7027373f,0.1158615f,0.2098134f,0.6698618f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.5674509f);
Get(0x6EC6).SetLocalPose(0.1456995f,1.21914f,-0.2765367f,-0.1118962f,-0.7849431f,-0.5984272f,0.1150149f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322635f,1.538447f,0.4831238f,-0.6545686f,-0.2082828f,-0.2497066f,0.6824991f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.5837345f);
Get(0x6E70).SetLocalPose(-0.1309305f,1.642096f,-0.4305226f,0.5013909f,-0.3552662f,-0.6148235f,0.4943534f);
Get(0x6E82).SetLocalPose(-0.04401549f,1.210101f,-0.2331393f,-0.7016243f,0.122497f,0.2109401f,0.6694939f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.5837345f);
Get(0x6EC6).SetLocalPose(0.1481525f,1.215898f,-0.2757887f,-0.1178673f,-0.7800786f,-0.6041993f,0.1119274f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322335f,1.538484f,0.4833229f,-0.6545703f,-0.2082753f,-0.2496979f,0.6825027f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.6014158f);
Get(0x6E70).SetLocalPose(-0.1343777f,1.642505f,-0.4318207f,0.5079718f,-0.3612141f,-0.6098501f,0.4894608f);
Get(0x6E82).SetLocalPose(-0.04179834f,1.208524f,-0.2342397f,-0.700111f,0.1282893f,0.2115874f,0.669789f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.6014158f);
Get(0x6EC6).SetLocalPose(0.1504712f,1.212692f,-0.275677f,-0.122238f,-0.7759033f,-0.6088411f,0.1111057f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322412f,1.538475f,0.4832812f,-0.6545885f,-0.2082711f,-0.2497082f,0.6824829f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.6306921f);
Get(0x6E70).SetLocalPose(-0.1388688f,1.642421f,-0.4345761f,0.517173f,-0.3698067f,-0.6026842f,0.4822313f);
Get(0x6E82).SetLocalPose(-0.0377572f,1.206147f,-0.235553f,-0.6966779f,0.1370015f,0.2124562f,0.6713666f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.6306921f);
Get(0x6EC6).SetLocalPose(0.1543664f,1.207656f,-0.2760093f,-0.1273962f,-0.7696383f,-0.6152592f,0.1135038f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322296f,1.538403f,0.4833384f,-0.6546064f,-0.2082648f,-0.2497377f,0.6824569f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.6487621f);
Get(0x6E70).SetLocalPose(-0.1411909f,1.642437f,-0.4359739f,0.5221772f,-0.3745129f,-0.5985793f,0.4783031f);
Get(0x6E82).SetLocalPose(-0.03619894f,1.205184f,-0.2360169f,-0.6954082f,0.1399494f,0.2120323f,0.6722084f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.6487621f);
Get(0x6EC6).SetLocalPose(0.15665f,1.204558f,-0.2766643f,-0.1300421f,-0.7658406f,-0.6190823f,0.1153875f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32231f,1.53839f,0.4832968f,-0.6545897f,-0.208258f,-0.2497363f,0.6824754f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.6775273f);
Get(0x6E70).SetLocalPose(-0.1442979f,1.642416f,-0.4372472f,0.5276342f,-0.3795031f,-0.5938975f,0.4741996f);
Get(0x6E82).SetLocalPose(-0.03392886f,1.20352f,-0.2362632f,-0.6935586f,0.1429001f,0.2109996f,0.6738213f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.6775273f);
Get(0x6EC6).SetLocalPose(0.1595217f,1.200201f,-0.2777059f,-0.1331134f,-0.7602043f,-0.6248374f,0.1181039f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322315f,1.538433f,0.4832155f,-0.6545615f,-0.2082913f,-0.2497223f,0.6824976f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.6994316f);
Get(0x6E70).SetLocalPose(-0.147252f,1.6426f,-0.4383042f,0.5328281f,-0.3836916f,-0.5894142f,0.4706015f);
Get(0x6E82).SetLocalPose(-0.03342454f,1.202044f,-0.2358973f,-0.6913073f,0.1433833f,0.209772f,0.6764105f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.6994316f);
Get(0x6EC6).SetLocalPose(0.1616412f,1.195823f,-0.2788068f,-0.1352363f,-0.7552979f,-0.6298876f,0.1203239f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.6994316f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.6994316f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322364f,1.53849f,0.4831495f,-0.6545562f,-0.208305f,-0.2497218f,0.6824985f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.7270318f);
Get(0x6E70).SetLocalPose(-0.1494682f,1.642386f,-0.4388881f,0.5361678f,-0.3860339f,-0.5866793f,0.4683048f);
Get(0x6E82).SetLocalPose(-0.03325306f,1.199906f,-0.2353562f,-0.6898116f,0.1441487f,0.2068028f,0.6786852f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.7270318f);
Get(0x6EC6).SetLocalPose(0.1625309f,1.191959f,-0.2806433f,-0.1351718f,-0.75236f,-0.6329625f,0.1226442f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322362f,1.538424f,0.4832345f,-0.65455f,-0.2083004f,-0.2497213f,0.6825061f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.746271f);
Get(0x6E70).SetLocalPose(-0.15016f,1.641977f,-0.4393225f,0.5373878f,-0.3865573f,-0.5857415f,0.467648f);
Get(0x6E82).SetLocalPose(-0.0332257f,1.198922f,-0.2352832f,-0.6901343f,0.1455523f,0.2033829f,0.6790909f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.746271f);
Get(0x6EC6).SetLocalPose(0.1629046f,1.190757f,-0.2816526f,-0.1340801f,-0.7514784f,-0.6338618f,0.1245871f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322338f,1.53845f,0.4832678f,-0.6545661f,-0.2082673f,-0.2497377f,0.6824948f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.7746174f);
Get(0x6E70).SetLocalPose(-0.1513458f,1.641514f,-0.43867f,0.5388016f,-0.3869968f,-0.5845721f,0.4671207f);
Get(0x6E82).SetLocalPose(-0.03268538f,1.197346f,-0.235044f,-0.691585f,0.1498411f,0.1951135f,0.6791087f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.7746174f);
Get(0x6EC6).SetLocalPose(0.163553f,1.187592f,-0.2833682f,-0.131596f,-0.7498955f,-0.6356485f,0.1276331f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322335f,1.53841f,0.4833252f,-0.6545707f,-0.2082805f,-0.2497499f,0.6824818f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.789699f);
Get(0x6E70).SetLocalPose(-0.1524107f,1.640892f,-0.4387867f,0.5400099f,-0.3869363f,-0.5835616f,0.467039f);
Get(0x6E82).SetLocalPose(-0.03179131f,1.195475f,-0.235408f,-0.6943272f,0.1561797f,0.1854812f,0.6775798f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.789699f);
Get(0x6EC6).SetLocalPose(0.163861f,1.185768f,-0.2842242f,-0.1299026f,-0.7486922f,-0.6371711f,0.128835f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322444f,1.538514f,0.4831633f,-0.6545576f,-0.2082603f,-0.2497499f,0.6825006f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.814948f);
Get(0x6E70).SetLocalPose(-0.1529774f,1.640237f,-0.4391173f,0.5405417f,-0.3868367f,-0.5830536f,0.4671409f);
Get(0x6E82).SetLocalPose(-0.03029666f,1.193654f,-0.2355989f,-0.6993635f,0.1654301f,0.173769f,0.6732963f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.814948f);
Get(0x6EC6).SetLocalPose(0.1643918f,1.183898f,-0.2851136f,-0.1282091f,-0.7479054f,-0.6381946f,0.1300291f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322468f,1.538557f,0.4830426f,-0.654562f,-0.2082818f,-0.2496977f,0.6825089f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.8312908f);
Get(0x6E70).SetLocalPose(-0.153703f,1.640109f,-0.4392956f,0.541371f,-0.3865519f,-0.5821823f,0.4675029f);
Get(0x6E82).SetLocalPose(-0.02961936f,1.192812f,-0.2357845f,-0.7031217f,0.173312f,0.1652639f,0.6695302f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.8312908f);
Get(0x6EC6).SetLocalPose(0.1644675f,1.182976f,-0.2856303f,-0.1269245f,-0.7476227f,-0.6385659f,0.1310885f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322472f,1.538396f,0.4830997f,-0.6545529f,-0.2082779f,-0.2496968f,0.6825192f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.8587347f);
Get(0x6E70).SetLocalPose(-0.154984f,1.640535f,-0.4392783f,0.5419462f,-0.3864041f,-0.5813761f,0.4679616f);
Get(0x6E82).SetLocalPose(-0.02799465f,1.192045f,-0.2368515f,-0.7150506f,0.1949088f,0.1386383f,0.656881f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.8587347f);
Get(0x6EC6).SetLocalPose(0.1640334f,1.182425f,-0.2860821f,-0.1236409f,-0.7478867f,-0.6382791f,0.1340827f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322346f,1.538564f,0.4831546f,-0.6545336f,-0.2083011f,-0.249701f,0.6825291f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.8723021f);
Get(0x6E70).SetLocalPose(-0.1551109f,1.640585f,-0.4394954f,0.5422723f,-0.3865343f,-0.5807634f,0.4682372f);
Get(0x6E82).SetLocalPose(-0.02712377f,1.189562f,-0.2387589f,-0.7292111f,0.2137338f,0.1129055f,0.640173f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.8723021f);
Get(0x6EC6).SetLocalPose(0.1638622f,1.182355f,-0.2862386f,-0.1216465f,-0.7483669f,-0.6377161f,0.1358945f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322397f,1.53839f,0.483194f,-0.6545368f,-0.2082886f,-0.2497104f,0.6825264f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.8878197f);
Get(0x6E70).SetLocalPose(-0.1553577f,1.64091f,-0.4395104f,0.5424225f,-0.3867845f,-0.5803103f,0.468418f);
Get(0x6E82).SetLocalPose(-0.02608515f,1.187946f,-0.2409312f,-0.7415385f,0.2305973f,0.09128255f,0.6233884f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.8878197f);
Get(0x6EC6).SetLocalPose(0.1636953f,1.18255f,-0.2862391f,-0.119934f,-0.7488317f,-0.6371983f,0.1372781f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.3225f,1.538309f,0.4832045f,-0.6545497f,-0.2082873f,-0.2497162f,0.6825122f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.9023111f);
Get(0x6E70).SetLocalPose(-0.155842f,1.640658f,-0.4395659f,0.5425847f,-0.3874978f,-0.5795687f,0.468559f);
Get(0x6E82).SetLocalPose(-0.02568591f,1.18658f,-0.2425665f,-0.7492429f,0.2431564f,0.0784675f,0.6110262f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.9023111f);
Get(0x6EC6).SetLocalPose(0.1634117f,1.182839f,-0.2863674f,-0.1192979f,-0.7492018f,-0.6368747f,0.1373148f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322715f,1.538327f,0.4831499f,-0.6545537f,-0.208281f,-0.2497145f,0.6825109f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.9361246f);
Get(0x6E70).SetLocalPose(-0.1562089f,1.640933f,-0.4404637f,0.5430354f,-0.3885435f,-0.5784534f,0.468549f);
Get(0x6E82).SetLocalPose(-0.02638081f,1.185592f,-0.2448335f,-0.7532485f,0.2544065f,0.07217413f,0.6022332f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.9361246f);
Get(0x6EC6).SetLocalPose(0.1623432f,1.183663f,-0.2865633f,-0.1159267f,-0.751144f,-0.6351287f,0.137678f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322612f,1.538186f,0.4830755f,-0.6545594f,-0.2082976f,-0.2497118f,0.6825014f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.9472841f);
Get(0x6E70).SetLocalPose(-0.1564414f,1.641089f,-0.4406812f,0.543193f,-0.3890558f,-0.5780472f,0.4684427f);
Get(0x6E82).SetLocalPose(-0.02613424f,1.185841f,-0.2456257f,-0.7552818f,0.2580737f,0.06907585f,0.598478f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.9472841f);
Get(0x6EC6).SetLocalPose(0.1614898f,1.183927f,-0.286722f,-0.1131196f,-0.7525068f,-0.6337521f,0.1389094f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32262f,1.538285f,0.4830913f,-0.6545775f,-0.2082747f,-0.249697f,0.6824965f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.9710308f);
Get(0x6E70).SetLocalPose(-0.1563046f,1.641449f,-0.4415187f,0.5433676f,-0.3900779f,-0.5776114f,0.4679275f);
Get(0x6E82).SetLocalPose(-0.02575509f,1.18535f,-0.2475418f,-0.7618302f,0.2682357f,0.05967952f,0.5866028f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.9710308f);
Get(0x6EC6).SetLocalPose(0.1584739f,1.184191f,-0.2871599f,-0.1036815f,-0.7565342f,-0.6296947f,0.1427967f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322405f,1.538326f,0.4832138f,-0.6545619f,-0.2082814f,-0.2497249f,0.6824992f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 0.9993724f);
Get(0x6E70).SetLocalPose(-0.1562026f,1.641681f,-0.4422582f,0.5433694f,-0.3914236f,-0.5774776f,0.4669656f);
Get(0x6E82).SetLocalPose(-0.02535911f,1.18589f,-0.2498129f,-0.7670091f,0.2771509f,0.05391544f,0.5761749f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 0.9993724f);
Get(0x6EC6).SetLocalPose(0.1546168f,1.184565f,-0.2874113f,-0.09164282f,-0.760775f,-0.6258858f,0.1452244f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322272f,1.538459f,0.4833037f,-0.6545508f,-0.208275f,-0.2497242f,0.682512f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.012935f);
Get(0x6E70).SetLocalPose(-0.1555828f,1.641518f,-0.4422984f,0.5432766f,-0.3923071f,-0.5775123f,0.4662888f);
Get(0x6E82).SetLocalPose(-0.02526371f,1.186242f,-0.250916f,-0.7695073f,0.2814421f,0.05206995f,0.5709094f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.012935f);
Get(0x6EC6).SetLocalPose(0.1523803f,1.185177f,-0.2875381f,-0.08545221f,-0.7629737f,-0.6239288f,0.1458835f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322375f,1.53848f,0.4832161f,-0.6545337f,-0.2082479f,-0.2497126f,0.6825409f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.0365f);
Get(0x6E70).SetLocalPose(-0.1553557f,1.641921f,-0.442522f,0.5431901f,-0.3932169f,-0.5776348f,0.4654708f);
Get(0x6E82).SetLocalPose(-0.02522999f,1.186518f,-0.2523867f,-0.7740399f,0.2869489f,0.05030096f,0.5621321f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.0365f);
Get(0x6EC6).SetLocalPose(0.1490433f,1.186202f,-0.2880592f,-0.0747552f,-0.7670456f,-0.6200061f,0.1471228f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322384f,1.538523f,0.4831711f,-0.6545637f,-0.2082776f,-0.2497174f,0.6825014f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.051756f);
Get(0x6E70).SetLocalPose(-0.1551878f,1.642238f,-0.442833f,0.543084f,-0.3937116f,-0.5778018f,0.4649689f);
Get(0x6E82).SetLocalPose(-0.02496638f,1.186457f,-0.2532635f,-0.7767935f,0.2894018f,0.04967265f,0.5571096f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.051756f);
Get(0x6EC6).SetLocalPose(0.1468286f,1.186315f,-0.2883876f,-0.0679158f,-0.7697211f,-0.6172619f,0.1480018f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322422f,1.538593f,0.4831419f,-0.6545298f,-0.2082952f,-0.24971f,0.6825312f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.067859f);
Get(0x6E70).SetLocalPose(-0.1552232f,1.642311f,-0.4428132f,0.5430294f,-0.3939147f,-0.5779017f,0.4647365f);
Get(0x6E82).SetLocalPose(-0.02498096f,1.186379f,-0.2541994f,-0.7796403f,0.2912159f,0.04967453f,0.5521657f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.067859f);
Get(0x6EC6).SetLocalPose(0.1446683f,1.186425f,-0.2890366f,-0.06071084f,-0.772503f,-0.6142704f,0.1490812f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322424f,1.538604f,0.4830824f,-0.6545473f,-0.2082822f,-0.2497237f,0.6825134f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.098412f);
Get(0x6E70).SetLocalPose(-0.1546577f,1.642535f,-0.4429559f,0.542723f,-0.3946165f,-0.5784323f,0.463838f);
Get(0x6E82).SetLocalPose(-0.02479434f,1.187291f,-0.2546512f,-0.7803953f,0.2908508f,0.05451981f,0.5508326f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.098412f);
Get(0x6EC6).SetLocalPose(0.1412411f,1.186957f,-0.2893852f,-0.0513438f,-0.7758918f,-0.6109847f,0.1485039f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322456f,1.5386f,0.4830084f,-0.6545556f,-0.2083001f,-0.2496986f,0.6825091f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.118447f);
Get(0x6E70).SetLocalPose(-0.1543252f,1.642583f,-0.4431894f,0.5424778f,-0.3947075f,-0.5788421f,0.463536f);
Get(0x6E82).SetLocalPose(-0.0248256f,1.1889f,-0.25476f,-0.7784865f,0.2887846f,0.06035592f,0.5540031f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.118447f);
Get(0x6EC6).SetLocalPose(0.1390969f,1.187173f,-0.2893594f,-0.04820419f,-0.7771901f,-0.6101941f,0.1459967f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322518f,1.538465f,0.4829093f,-0.6545349f,-0.2082749f,-0.2497057f,0.682534f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.12994f);
Get(0x6E70).SetLocalPose(-0.1537075f,1.642734f,-0.4433316f,0.5424154f,-0.3946415f,-0.5789894f,0.4634812f);
Get(0x6E82).SetLocalPose(-0.02467822f,1.1898f,-0.2549382f,-0.7770072f,0.2872319f,0.06413649f,0.5564569f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.12994f);
Get(0x6EC6).SetLocalPose(0.1379649f,1.187278f,-0.2893842f,-0.04704794f,-0.777746f,-0.61007f,0.1439172f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322578f,1.538441f,0.4830265f,-0.654538f,-0.2082876f,-0.2496848f,0.6825349f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.156956f);
Get(0x6E70).SetLocalPose(-0.1534014f,1.642476f,-0.4434835f,0.5420943f,-0.3944073f,-0.5794919f,0.4634283f);
Get(0x6E82).SetLocalPose(-0.02444079f,1.190386f,-0.2555715f,-0.7750543f,0.2848909f,0.06970511f,0.5597046f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.156956f);
Get(0x6EC6).SetLocalPose(0.135607f,1.188223f,-0.2897257f,-0.04534953f,-0.7787953f,-0.6099324f,0.1392976f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322663f,1.538433f,0.483055f,-0.6545383f,-0.2082927f,-0.2497051f,0.6825256f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.167659f);
Get(0x6E70).SetLocalPose(-0.1533877f,1.643209f,-0.4436687f,0.5418761f,-0.3942894f,-0.5797102f,0.4635108f);
Get(0x6E82).SetLocalPose(-0.02432495f,1.190687f,-0.2561479f,-0.7745788f,0.2845843f,0.0706875f,0.5603952f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.167659f);
Get(0x6EC6).SetLocalPose(0.1344863f,1.188522f,-0.289763f,-0.04446958f,-0.7793073f,-0.6096822f,0.1378053f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322491f,1.538376f,0.4828634f,-0.6545294f,-0.20828f,-0.2497038f,0.6825385f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.192416f);
Get(0x6E70).SetLocalPose(-0.1528868f,1.643723f,-0.4441942f,0.5410936f,-0.3944547f,-0.5801164f,0.4637759f);
Get(0x6E82).SetLocalPose(-0.02425589f,1.191576f,-0.2565425f,-0.7734201f,0.2843226f,0.07160318f,0.5620099f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.192416f);
Get(0x6EC6).SetLocalPose(0.1326127f,1.189057f,-0.2899927f,-0.04261204f,-0.7799788f,-0.6093884f,0.1358792f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322622f,1.538494f,0.4828725f,-0.654528f,-0.2082652f,-0.2497192f,0.6825387f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.219499f);
Get(0x6E70).SetLocalPose(-0.1525777f,1.643942f,-0.4444217f,0.5403761f,-0.3948185f,-0.5802749f,0.4641046f);
Get(0x6E82).SetLocalPose(-0.02441447f,1.192203f,-0.2568458f,-0.7707862f,0.2832426f,0.07410881f,0.5658359f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.219499f);
Get(0x6EC6).SetLocalPose(0.1306255f,1.189116f,-0.2900281f,-0.04133431f,-0.7799697f,-0.6098999f,0.1340187f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322683f,1.538468f,0.482854f,-0.6545309f,-0.2082532f,-0.2497071f,0.682544f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.238018f);
Get(0x6E70).SetLocalPose(-0.1524592f,1.643669f,-0.4447676f,0.5394967f,-0.3953026f,-0.5803843f,0.4645785f);
Get(0x6E82).SetLocalPose(-0.02450687f,1.191943f,-0.2564778f,-0.7683677f,0.2816497f,0.07645432f,0.5695956f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.238018f);
Get(0x6EC6).SetLocalPose(0.1297728f,1.188767f,-0.2898825f,-0.0411123f,-0.7794853f,-0.6109186f,0.1322528f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.254511f);
Get(0x6E70).SetLocalPose(-0.1524643f,1.643651f,-0.4447172f,0.5392801f,-0.3954277f,-0.5803889f,0.464718f);
Get(0x6E82).SetLocalPose(-0.02550309f,1.191889f,-0.2562703f,-0.766472f,0.2806084f,0.07751855f,0.5725124f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.254511f);
Get(0x6EC6).SetLocalPose(0.129382f,1.188566f,-0.2897555f,-0.04107124f,-0.7788486f,-0.6121415f,0.1303487f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.3225f,1.538408f,0.482867f,-0.6545141f,-0.2082697f,-0.2497286f,0.6825472f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.27143f);
Get(0x6E70).SetLocalPose(-0.1524146f,1.643739f,-0.4448018f,0.5390415f,-0.3955531f,-0.5804011f,0.4648727f);
Get(0x6E82).SetLocalPose(-0.02643527f,1.190897f,-0.256046f,-0.7653804f,0.2801438f,0.0774639f,0.5742052f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.27143f);
Get(0x6EC6).SetLocalPose(0.1289281f,1.188107f,-0.2895567f,-0.04098207f,-0.7783023f,-0.6130759f,0.129244f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322301f,1.538684f,0.483041f,-0.6545204f,-0.208279f,-0.2497542f,0.682529f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.297629f);
Get(0x6E70).SetLocalPose(-0.150997f,1.643868f,-0.4456357f,0.5374172f,-0.3964102f,-0.5804285f,0.4659878f);
Get(0x6E82).SetLocalPose(-0.02763388f,1.189138f,-0.2561816f,-0.7633491f,0.2791508f,0.07662974f,0.5774954f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.297629f);
Get(0x6EC6).SetLocalPose(0.1284348f,1.18739f,-0.2895772f,-0.04037817f,-0.7773607f,-0.6144739f,0.1284593f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322172f,1.538532f,0.483068f,-0.654543f,-0.2082586f,-0.2497315f,0.6825219f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.315861f);
Get(0x6E70).SetLocalPose(-0.1497335f,1.644234f,-0.4467187f,0.5357336f,-0.3973246f,-0.5802331f,0.4673888f);
Get(0x6E82).SetLocalPose(-0.02817739f,1.188053f,-0.2563077f,-0.7620791f,0.2783526f,0.07669061f,0.5795462f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.315861f);
Get(0x6EC6).SetLocalPose(0.1285166f,1.186398f,-0.2898442f,-0.03968358f,-0.7767398f,-0.6152865f,0.1285421f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322155f,1.538568f,0.4830444f,-0.6545557f,-0.2082552f,-0.2497834f,0.6824917f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.334159f);
Get(0x6E70).SetLocalPose(-0.1494263f,1.645308f,-0.4467953f,0.5343547f,-0.3981446f,-0.5799565f,0.4686113f);
Get(0x6E82).SetLocalPose(-0.02881059f,1.186773f,-0.2563339f,-0.7600104f,0.2767569f,0.07739146f,0.5829241f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.334159f);
Get(0x6EC6).SetLocalPose(0.1288736f,1.185712f,-0.2901085f,-0.0394591f,-0.7761319f,-0.6161178f,0.1283012f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322202f,1.538362f,0.4830711f,-0.6545538f,-0.2082478f,-0.2497849f,0.6824952f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.359006f);
Get(0x6E70).SetLocalPose(-0.148394f,1.646189f,-0.4471959f,0.5320032f,-0.3995241f,-0.5792838f,0.4709389f);
Get(0x6E82).SetLocalPose(-0.02945941f,1.186046f,-0.2563469f,-0.7584585f,0.2753939f,0.07790631f,0.5855165f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.359006f);
Get(0x6EC6).SetLocalPose(0.1296293f,1.18437f,-0.2902025f,-0.03962885f,-0.7746378f,-0.6181146f,0.1276727f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322173f,1.538361f,0.4830739f,-0.6545427f,-0.2082507f,-0.2497783f,0.6825074f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.375488f);
Get(0x6E70).SetLocalPose(-0.1480151f,1.647256f,-0.4470415f,0.5304452f,-0.4004308f,-0.5786869f,0.472657f);
Get(0x6E82).SetLocalPose(-0.03087494f,1.183742f,-0.2559191f,-0.7558821f,0.2729871f,0.0780733f,0.5899364f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.375488f);
Get(0x6EC6).SetLocalPose(0.1301568f,1.183433f,-0.2903664f,-0.03958764f,-0.7735649f,-0.6193994f,0.1279636f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322228f,1.538293f,0.4830497f,-0.654541f,-0.2082474f,-0.2497736f,0.6825118f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.39297f);
Get(0x6E70).SetLocalPose(-0.1473437f,1.64803f,-0.4472637f,0.5286146f,-0.4014558f,-0.577962f,0.4747207f);
Get(0x6E82).SetLocalPose(-0.03239363f,1.182017f,-0.2556727f,-0.754075f,0.2705838f,0.07790763f,0.5933681f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.39297f);
Get(0x6EC6).SetLocalPose(0.1307732f,1.182585f,-0.2906463f,-0.03957059f,-0.7724391f,-0.6206462f,0.1287251f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322192f,1.53828f,0.4830672f,-0.6545451f,-0.2082346f,-0.2497545f,0.6825187f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.412988f);
Get(0x6E70).SetLocalPose(-0.1468922f,1.648106f,-0.4473539f,0.5265098f,-0.4026241f,-0.5771548f,0.4770469f);
Get(0x6E82).SetLocalPose(-0.0340399f,1.180636f,-0.2556356f,-0.7522808f,0.2677508f,0.07849443f,0.5968433f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.412988f);
Get(0x6EC6).SetLocalPose(0.1316096f,1.181943f,-0.2908349f,-0.04001079f,-0.7710202f,-0.6222177f,0.1295076f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322209f,1.538334f,0.4829921f,-0.6545236f,-0.2082553f,-0.2497494f,0.6825349f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.438607f);
Get(0x6E70).SetLocalPose(-0.1467579f,1.650237f,-0.4475007f,0.5237784f,-0.4040472f,-0.5759302f,0.4803191f);
Get(0x6E82).SetLocalPose(-0.03715428f,1.180093f,-0.2555803f,-0.7479538f,0.2608215f,0.08185466f,0.6048447f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.438607f);
Get(0x6EC6).SetLocalPose(0.1330168f,1.18013f,-0.2908978f,-0.04150942f,-0.7685602f,-0.6251094f,0.129732f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322242f,1.538288f,0.4829574f,-0.6545275f,-0.2082345f,-0.2497381f,0.6825416f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.454293f);
Get(0x6E70).SetLocalPose(-0.1465338f,1.650701f,-0.4477172f,0.5225163f,-0.4046775f,-0.5752641f,0.4819587f);
Get(0x6E82).SetLocalPose(-0.03929846f,1.178593f,-0.2547311f,-0.7437247f,0.2538941f,0.08619521f,0.6123576f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.454293f);
Get(0x6EC6).SetLocalPose(0.1339692f,1.178922f,-0.2907324f,-0.04288728f,-0.766427f,-0.6277564f,0.1291211f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322273f,1.538307f,0.4830796f,-0.654551f,-0.2082441f,-0.2497459f,0.6825132f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.478929f);
Get(0x6E70).SetLocalPose(-0.1458091f,1.651766f,-0.4475816f,0.5207577f,-0.405535f,-0.5742249f,0.4843744f);
Get(0x6E82).SetLocalPose(-0.04341214f,1.175573f,-0.2531957f,-0.7343198f,0.2400527f,0.09538305f,0.627735f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.478929f);
Get(0x6EC6).SetLocalPose(0.1356172f,1.176681f,-0.2903003f,-0.04552819f,-0.7627119f,-0.6323719f,0.1276847f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322299f,1.5385f,0.4830652f,-0.6545536f,-0.208251f,-0.2497439f,0.6825095f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.495338f);
Get(0x6E70).SetLocalPose(-0.1445436f,1.652398f,-0.447859f,0.5189368f,-0.4064283f,-0.5730041f,0.4870185f);
Get(0x6E82).SetLocalPose(-0.04673029f,1.172881f,-0.2518421f,-0.7250348f,0.2280342f,0.1031575f,0.6416257f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.495338f);
Get(0x6EC6).SetLocalPose(0.1371154f,1.174313f,-0.2899227f,-0.0484363f,-0.7592116f,-0.6367504f,0.1257007f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32239f,1.538434f,0.4829904f,-0.6545606f,-0.2082477f,-0.2497269f,0.68251f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.518591f);
Get(0x6E70).SetLocalPose(-0.1436753f,1.653347f,-0.4484892f,0.5170809f,-0.4073442f,-0.5718763f,0.4895462f);
Get(0x6E82).SetLocalPose(-0.05186724f,1.168667f,-0.249693f,-0.7109509f,0.2126395f,0.1132287f,0.660691f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.518591f);
Get(0x6EC6).SetLocalPose(0.1400307f,1.168985f,-0.2888614f,-0.05456181f,-0.7512673f,-0.6466909f,0.120047f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322383f,1.538382f,0.4830797f,-0.6545479f,-0.2082616f,-0.249732f,0.682516f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.534385f);
Get(0x6E70).SetLocalPose(-0.1431623f,1.653574f,-0.4489141f,0.5157293f,-0.408017f,-0.5710346f,0.4913907f);
Get(0x6E82).SetLocalPose(-0.05660592f,1.164091f,-0.2478373f,-0.6966244f,0.1995102f,0.1216975f,0.6783066f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.534385f);
Get(0x6EC6).SetLocalPose(0.1423721f,1.163524f,-0.2874882f,-0.05926228f,-0.7424303f,-0.6573877f,0.1145719f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322461f,1.538391f,0.4830515f,-0.6545495f,-0.2082618f,-0.2497263f,0.6825165f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.550278f);
Get(0x6E70).SetLocalPose(-0.1427698f,1.65384f,-0.4493005f,0.5143879f,-0.4087183f,-0.5701736f,0.4932105f);
Get(0x6E82).SetLocalPose(-0.06104553f,1.158238f,-0.246269f,-0.6811375f,0.1869535f,0.1290611f,0.6960197f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.550278f);
Get(0x6EC6).SetLocalPose(0.1450221f,1.156917f,-0.2862164f,-0.0637863f,-0.7305054f,-0.671201f,0.1085473f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322424f,1.53853f,0.4831768f,-0.6545308f,-0.2082658f,-0.2497475f,0.6825256f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.578984f);
Get(0x6E70).SetLocalPose(-0.1422855f,1.655221f,-0.450013f,0.5123243f,-0.4098791f,-0.5687544f,0.4960255f);
Get(0x6E82).SetLocalPose(-0.06817427f,1.146444f,-0.2435419f,-0.6520513f,0.1662409f,0.1395335f,0.7264459f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.578984f);
Get(0x6EC6).SetLocalPose(0.1496773f,1.142972f,-0.2835734f,-0.07200777f,-0.7013726f,-0.7027804f,0.09482194f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322405f,1.5386f,0.483195f,-0.6545702f,-0.2082619f,-0.2497352f,0.6824934f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.597672f);
Get(0x6E70).SetLocalPose(-0.1420443f,1.656152f,-0.4508264f,0.510714f,-0.410898f,-0.5675451f,0.4982236f);
Get(0x6E82).SetLocalPose(-0.07608581f,1.13332f,-0.2400478f,-0.6214492f,0.1468665f,0.1458538f,0.7556176f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.597672f);
Get(0x6EC6).SetLocalPose(0.1529205f,1.130803f,-0.2816831f,-0.07869066f,-0.673241f,-0.7306628f,0.08177014f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.614687f);
Get(0x6E70).SetLocalPose(-0.1415855f,1.657747f,-0.451318f,0.508839f,-0.412228f,-0.565956f,0.5008442f);
Get(0x6E82).SetLocalPose(-0.08193427f,1.122452f,-0.2383718f,-0.5986153f,0.1342409f,0.1465753f,0.7759864f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.614687f);
Get(0x6EC6).SetLocalPose(0.1555384f,1.11821f,-0.2804197f,-0.08477698f,-0.6415067f,-0.7594391f,0.0673376f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32226f,1.538627f,0.4833245f,-0.6545642f,-0.2082705f,-0.2497389f,0.6824952f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.633237f);
Get(0x6E70).SetLocalPose(-0.1411697f,1.658495f,-0.4518157f,0.5069391f,-0.4136651f,-0.5644982f,0.5032253f);
Get(0x6E82).SetLocalPose(-0.08943833f,1.105954f,-0.238097f,-0.5728182f,0.1229162f,0.1405451f,0.7981341f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.633237f);
Get(0x6EC6).SetLocalPose(0.1578706f,1.104633f,-0.2802982f,-0.08921526f,-0.6070929f,-0.7877982f,0.05341351f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322258f,1.538591f,0.4831666f,-0.6545683f,-0.2082504f,-0.2497368f,0.6824982f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.651735f);
Get(0x6E70).SetLocalPose(-0.1404925f,1.659607f,-0.4522967f,0.5048773f,-0.4152522f,-0.5628061f,0.5058793f);
Get(0x6E82).SetLocalPose(-0.09470622f,1.091894f,-0.2383933f,-0.5567405f,0.1180742f,0.1320377f,0.8115816f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.651735f);
Get(0x6EC6).SetLocalPose(0.160196f,1.085691f,-0.2818183f,-0.09103152f,-0.5610723f,-0.8218552f,0.03827864f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322242f,1.538294f,0.4831536f,-0.6545691f,-0.2082639f,-0.2497413f,0.6824916f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.67976f);
Get(0x6E70).SetLocalPose(-0.1398473f,1.660811f,-0.4527109f,0.5020398f,-0.417441f,-0.560482f,0.5094693f);
Get(0x6E82).SetLocalPose(-0.1063449f,1.058289f,-0.2426116f,-0.5185529f,0.1099795f,0.1089482f,0.8409148f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.67976f);
Get(0x6EC6).SetLocalPose(0.1608669f,1.056887f,-0.2871449f,-0.0850892f,-0.5019222f,-0.8602722f,0.0276712f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322266f,1.53837f,0.483198f,-0.6545774f,-0.2082502f,-0.2497454f,0.6824862f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.695688f);
Get(0x6E70).SetLocalPose(-0.1397158f,1.66118f,-0.4529926f,0.500576f,-0.41855f,-0.5594537f,0.5111274f);
Get(0x6E82).SetLocalPose(-0.1144564f,1.037094f,-0.2466134f,-0.4927176f,0.1058067f,0.09660734f,0.8583131f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.695688f);
Get(0x6EC6).SetLocalPose(0.1609178f,1.040402f,-0.2915879f,-0.08034432f,-0.4702745f,-0.8785175f,0.024367f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322274f,1.538371f,0.483209f,-0.6545661f,-0.2082717f,-0.2497557f,0.6824868f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.719617f);
Get(0x6E70).SetLocalPose(-0.1387386f,1.662131f,-0.4538527f,0.4976995f,-0.4205054f,-0.5577197f,0.5142171f);
Get(0x6E82).SetLocalPose(-0.1237754f,1.010821f,-0.2529843f,-0.4605484f,0.1027974f,0.08157092f,0.8778805f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.719617f);
Get(0x6EC6).SetLocalPose(0.1602266f,1.014878f,-0.3017773f,-0.07124968f,-0.42413f,-0.9024956f,0.02321816f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322282f,1.538396f,0.4832125f,-0.6545746f,-0.2082926f,-0.2497762f,0.6824648f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.737465f);
Get(0x6E70).SetLocalPose(-0.1384852f,1.66299f,-0.4541955f,0.4960951f,-0.4215702f,-0.5567621f,0.5159304f);
Get(0x6E82).SetLocalPose(-0.1334607f,0.9837931f,-0.2610391f,-0.4239128f,0.1002637f,0.06462807f,0.8978131f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.737465f);
Get(0x6EC6).SetLocalPose(0.1594097f,0.9970143f,-0.309649f,-0.06127845f,-0.394472f,-0.9164834f,0.02636396f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322282f,1.53855f,0.4832869f,-0.6545601f,-0.2082682f,-0.2497786f,0.6824853f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.754903f);
Get(0x6E70).SetLocalPose(-0.1375736f,1.663272f,-0.4545698f,0.4943763f,-0.4226717f,-0.5556672f,0.517856f);
Get(0x6E82).SetLocalPose(-0.1429582f,0.9592923f,-0.2698564f,-0.3861873f,0.0970314f,0.04918857f,0.915983f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.754903f);
Get(0x6EC6).SetLocalPose(0.1577846f,0.9771751f,-0.3206183f,-0.04648163f,-0.3603877f,-0.9311364f,0.03074457f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32226f,1.538495f,0.4831924f,-0.6545501f,-0.2082701f,-0.2497764f,0.6824952f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.772144f);
Get(0x6E70).SetLocalPose(-0.1368665f,1.664161f,-0.4551982f,0.4930439f,-0.4235324f,-0.5546779f,0.519481f);
Get(0x6E82).SetLocalPose(-0.1520112f,0.9372747f,-0.2792438f,-0.3488825f,0.09386188f,0.03583069f,0.9317656f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.772144f);
Get(0x6EC6).SetLocalPose(0.1563596f,0.9565609f,-0.3329077f,-0.03164935f,-0.32446f,-0.9447743f,0.03355147f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322276f,1.538549f,0.4831785f,-0.6545535f,-0.2082772f,-0.24976f,0.6824956f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.796914f);
Get(0x6E70).SetLocalPose(-0.1362904f,1.664949f,-0.4556379f,0.4909498f,-0.4250779f,-0.5529955f,0.5219896f);
Get(0x6E82).SetLocalPose(-0.165617f,0.9074787f,-0.2949701f,-0.2953627f,0.09299111f,0.01430336f,0.9507413f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.796914f);
Get(0x6EC6).SetLocalPose(0.1550294f,0.9307064f,-0.3505531f,-0.01901813f,-0.272355f,-0.9614636f,0.03238937f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322343f,1.538483f,0.4831853f,-0.6545516f,-0.2082641f,-0.2497628f,0.6825005f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.814439f);
Get(0x6E70).SetLocalPose(-0.1360541f,1.666016f,-0.4558998f,0.4892569f,-0.4264617f,-0.5515869f,0.523937f);
Get(0x6E82).SetLocalPose(-0.1780842f,0.8823094f,-0.3105442f,-0.2450847f,0.09271227f,-0.007138059f,0.9650322f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.814439f);
Get(0x6EC6).SetLocalPose(0.1545556f,0.9140663f,-0.3631399f,-0.01487155f,-0.2354173f,-0.9713447f,0.02910446f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32222f,1.538462f,0.4832019f,-0.6545697f,-0.2082606f,-0.2497565f,0.6824865f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.838918f);
Get(0x6E70).SetLocalPose(-0.1362662f,1.667807f,-0.4562254f,0.4871131f,-0.4282567f,-0.5498787f,0.5262609f);
Get(0x6E82).SetLocalPose(-0.1934566f,0.8546268f,-0.333528f,-0.1790926f,0.08900128f,-0.03059866f,0.9793204f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.838918f);
Get(0x6EC6).SetLocalPose(0.1549015f,0.8890941f,-0.3845733f,-0.008452119f,-0.1758143f,-0.9840457f,0.0259247f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322072f,1.538479f,0.4831533f,-0.654553f,-0.208257f,-0.2497784f,0.6824956f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.856836f);
Get(0x6E70).SetLocalPose(-0.1360749f,1.668052f,-0.4568369f,0.4849369f,-0.4301766f,-0.5480211f,0.5286371f);
Get(0x6E82).SetLocalPose(-0.2031757f,0.8398699f,-0.3485537f,-0.1390044f,0.08313744f,-0.04045594f,0.9859661f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.856836f);
Get(0x6EC6).SetLocalPose(0.1548336f,0.8757322f,-0.3996568f,-0.003019518f,-0.1367522f,-0.9902808f,0.02517384f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322115f,1.538384f,0.4832143f,-0.6545708f,-0.2082553f,-0.2497679f,0.6824829f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.874161f);
Get(0x6E70).SetLocalPose(-0.1360304f,1.66873f,-0.4569811f,0.4835696f,-0.4314819f,-0.5467086f,0.5301826f);
Get(0x6E82).SetLocalPose(-0.2125021f,0.8268796f,-0.3651936f,-0.09555139f,0.07341963f,-0.04735735f,0.991583f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.874161f);
Get(0x6EC6).SetLocalPose(0.1555014f,0.8630772f,-0.4143569f,0.00135607f,-0.1014519f,-0.9945247f,0.02502851f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322195f,1.538306f,0.4832169f,-0.6545487f,-0.2082422f,-0.2497664f,0.6825085f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.892334f);
Get(0x6E70).SetLocalPose(-0.1354666f,1.669662f,-0.4572872f,0.4812212f,-0.4337214f,-0.5442667f,0.532997f);
Get(0x6E82).SetLocalPose(-0.2204779f,0.8160591f,-0.3827656f,-0.05218398f,0.06151351f,-0.05063981f,0.995454f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.892334f);
Get(0x6EC6).SetLocalPose(0.1572737f,0.8513595f,-0.4277986f,-0.0003870886f,-0.07066964f,-0.9971891f,0.02489195f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322218f,1.538311f,0.4832219f,-0.6545689f,-0.2082801f,-0.2497479f,0.6824844f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.912684f);
Get(0x6E70).SetLocalPose(-0.1351287f,1.670016f,-0.4576106f,0.4787404f,-0.4362267f,-0.5412737f,0.5362245f);
Get(0x6E82).SetLocalPose(-0.2269112f,0.8084931f,-0.3977746f,-0.02134427f,0.05174735f,-0.05087501f,0.9971352f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.912684f);
Get(0x6EC6).SetLocalPose(0.1592781f,0.8403049f,-0.4418744f,-0.0134747f,-0.0407667f,-0.9987787f,0.02444801f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32239f,1.538216f,0.4832379f,-0.6545641f,-0.208282f,-0.2497583f,0.6824846f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.938862f);
Get(0x6E70).SetLocalPose(-0.134803f,1.67175f,-0.4576609f,0.4758577f,-0.4393648f,-0.5371149f,0.5403939f);
Get(0x6E82).SetLocalPose(-0.2331085f,0.8029071f,-0.4159324f,0.009458966f,0.03555752f,-0.04691937f,0.9982208f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.938862f);
Get(0x6EC6).SetLocalPose(0.1630929f,0.829299f,-0.4578602f,-0.04188411f,-0.009571529f,-0.9987848f,0.02414367f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322309f,1.538287f,0.4832644f,-0.6545565f,-0.2082551f,-0.2497557f,0.6825011f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.95488f);
Get(0x6E70).SetLocalPose(-0.1342775f,1.672086f,-0.4580614f,0.4745409f,-0.4408742f,-0.5349345f,0.5424812f);
Get(0x6E82).SetLocalPose(-0.2355216f,0.8006217f,-0.4235724f,0.02801822f,0.01159439f,-0.03936265f,0.9987649f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.95488f);
Get(0x6EC6).SetLocalPose(0.1659763f,0.8236192f,-0.4679741f,-0.06660964f,0.008359856f,-0.9974744f,0.02319715f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322306f,1.538365f,0.4831423f,-0.6545553f,-0.2082847f,-0.2497338f,0.6825013f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.973099f);
Get(0x6E70).SetLocalPose(-0.1340333f,1.673563f,-0.4584372f,0.4728743f,-0.4428433f,-0.5320399f,0.5451726f);
Get(0x6E82).SetLocalPose(-0.2390446f,0.7994777f,-0.4290975f,0.04038475f,-0.02906128f,-0.02464936f,0.9984573f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.973099f);
Get(0x6EC6).SetLocalPose(0.169185f,0.8214352f,-0.4744477f,-0.1038039f,0.02665984f,-0.9941185f,0.01557276f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322287f,1.538489f,0.4832303f,-0.6545461f,-0.2082698f,-0.2497353f,0.682514f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 1.999672f);
Get(0x6E70).SetLocalPose(-0.1336342f,1.674718f,-0.4589511f,0.4707432f,-0.4454258f,-0.5286094f,0.5482416f);
Get(0x6E82).SetLocalPose(-0.2445888f,0.8006635f,-0.4336797f,0.04419753f,-0.09559971f,-0.004376227f,0.9944286f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 1.999672f);
Get(0x6EC6).SetLocalPose(0.173996f,0.8175282f,-0.4827869f,-0.1542346f,0.03794546f,-0.9872924f,0.005064349f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322396f,1.538599f,0.4831212f,-0.6545533f,-0.2082978f,-0.249723f,0.6825031f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 2.016351f);
Get(0x6E70).SetLocalPose(-0.1341055f,1.675928f,-0.4590575f,0.468519f,-0.4481988f,-0.5252475f,0.5511106f);
Get(0x6E82).SetLocalPose(-0.2473423f,0.801443f,-0.4352297f,0.04119024f,-0.1246335f,0.008010957f,0.9913151f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 2.016351f);
Get(0x6EC6).SetLocalPose(0.1762276f,0.8169771f,-0.4849962f,-0.174095f,0.03797997f,-0.9839956f,-0.001104586f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322413f,1.538611f,0.4831198f,-0.654538f,-0.208278f,-0.2497214f,0.6825244f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 2.033625f);
Get(0x6E70).SetLocalPose(-0.1342009f,1.67663f,-0.4590231f,0.4672016f,-0.4500089f,-0.5231277f,0.5527678f);
Get(0x6E82).SetLocalPose(-0.2483589f,0.8032934f,-0.4354795f,0.03569004f,-0.1372714f,0.0123437f,0.9898133f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 2.033625f);
Get(0x6EC6).SetLocalPose(0.1765517f,0.8186134f,-0.484906f,-0.1856403f,0.03519284f,-0.9819783f,-0.004216079f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322562f,1.538331f,0.4831218f,-0.6545367f,-0.2082895f,-0.2497451f,0.6825134f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 2.058701f);
Get(0x6E70).SetLocalPose(-0.1343769f,1.67813f,-0.4596736f,0.4647425f,-0.4537879f,-0.5191797f,0.5554669f);
Get(0x6E82).SetLocalPose(-0.2484005f,0.8070108f,-0.435665f,0.02137891f,-0.1336815f,0.007011294f,0.9907689f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 2.058701f);
Get(0x6EC6).SetLocalPose(0.177034f,0.8186866f,-0.4854598f,-0.1909613f,0.02819653f,-0.9811895f,-0.002423056f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322431f,1.53829f,0.4830053f,-0.6545357f,-0.2082881f,-0.249731f,0.6825201f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 2.075539f);
Get(0x6E70).SetLocalPose(-0.1345588f,1.679242f,-0.4602205f,0.4638114f,-0.4556465f,-0.5173422f,0.5564373f);
Get(0x6E82).SetLocalPose(-0.2483633f,0.8095184f,-0.4350195f,0.01439862f,-0.13059f,0.001836932f,0.9913303f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 2.075539f);
Get(0x6EC6).SetLocalPose(0.1766168f,0.8204468f,-0.4859494f,-0.1905168f,0.02394139f,-0.9813918f,-0.0004015536f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322419f,1.538352f,0.4831302f,-0.6545249f,-0.208291f,-0.2497212f,0.6825331f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 2.09904f);
Get(0x6E70).SetLocalPose(-0.1345612f,1.679763f,-0.461058f,0.4631028f,-0.4579919f,-0.5149585f,0.5573123f);
Get(0x6E82).SetLocalPose(-0.2489041f,0.8119683f,-0.4355392f,0.00562179f,-0.1277967f,-0.004434461f,0.9917746f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 2.09904f);
Get(0x6EC6).SetLocalPose(0.1752167f,0.8226586f,-0.4861972f,-0.1869856f,0.01748059f,-0.9822029f,0.002886453f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322462f,1.538466f,0.4830771f,-0.6545228f,-0.2082961f,-0.2497252f,0.682532f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 2.11519f);
Get(0x6E70).SetLocalPose(-0.1342929f,1.680429f,-0.4615935f,0.4630403f,-0.4594061f,-0.5133922f,0.5576451f);
Get(0x6E82).SetLocalPose(-0.2485273f,0.8133048f,-0.4352134f,-0.0004580571f,-0.1250146f,-0.008754188f,0.9921162f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 2.11519f);
Get(0x6EC6).SetLocalPose(0.1748361f,0.8227167f,-0.4851658f,-0.182333f,0.01204735f,-0.9831433f,0.00623519f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322508f,1.53841f,0.483164f,-0.6545339f,-0.2082886f,-0.249745f,0.6825165f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 2.13985f);
Get(0x6E70).SetLocalPose(-0.13438f,1.682298f,-0.4625821f,0.4635382f,-0.4613485f,-0.5112095f,0.5576332f);
Get(0x6E82).SetLocalPose(-0.2468476f,0.8137928f,-0.4341972f,-0.006291947f,-0.1217798f,-0.01244166f,0.9924592f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 2.13985f);
Get(0x6EC6).SetLocalPose(0.1744986f,0.8224712f,-0.4836912f,-0.1755302f,0.004239439f,-0.9844088f,0.01052023f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322541f,1.538488f,0.4832133f,-0.6545355f,-0.2082843f,-0.249737f,0.6825192f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 2.157784f);
Get(0x6E70).SetLocalPose(-0.1348696f,1.682364f,-0.4632258f,0.4640858f,-0.4626235f,-0.5099927f,0.5572355f);
Get(0x6E82).SetLocalPose(-0.2460551f,0.8147502f,-0.4347395f,-0.009015374f,-0.1194638f,-0.01502679f,0.9926839f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 2.157784f);
Get(0x6EC6).SetLocalPose(0.1731765f,0.8234572f,-0.4843321f,-0.1702032f,-0.001648731f,-0.9853162f,0.01342981f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322458f,1.538545f,0.4831038f,-0.65453f,-0.2082793f,-0.2497308f,0.6825282f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 2.174685f);
Get(0x6E70).SetLocalPose(-0.1348137f,1.682192f,-0.4639114f,0.4646634f,-0.463593f,-0.5090563f,0.5568045f);
Get(0x6E82).SetLocalPose(-0.2465391f,0.8149507f,-0.434409f,-0.009947751f,-0.117091f,-0.0171554f,0.9929233f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 2.174685f);
Get(0x6EC6).SetLocalPose(0.173307f,0.8233656f,-0.4830149f,-0.1658417f,-0.006037885f,-0.9860104f,0.01561179f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322459f,1.538484f,0.4830194f,-0.654541f,-0.2082774f,-0.2497329f,0.6825175f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 2.198982f);
Get(0x6E70).SetLocalPose(-0.1348501f,1.681823f,-0.4647654f,0.4655975f,-0.4650699f,-0.5076019f,0.5561199f);
Get(0x6E82).SetLocalPose(-0.2463617f,0.8141152f,-0.4355421f,-0.009038724f,-0.1149971f,-0.01840823f,0.9931541f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 2.198982f);
Get(0x6EC6).SetLocalPose(0.1728829f,0.8238492f,-0.4818512f,-0.1607336f,-0.009165606f,-0.986801f,0.01744995f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322384f,1.538533f,0.4832271f,-0.6545396f,-0.2082691f,-0.249724f,0.6825246f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 2.215397f);
Get(0x6E70).SetLocalPose(-0.1349354f,1.68206f,-0.4651049f,0.4659268f,-0.4657377f,-0.5069331f,0.5558953f);
Get(0x6E82).SetLocalPose(-0.2462644f,0.8139118f,-0.4360111f,-0.007722688f,-0.1144282f,-0.01814185f,0.9932358f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 2.215397f);
Get(0x6EC6).SetLocalPose(0.1725703f,0.8239937f,-0.4810389f,-0.1570662f,-0.01026834f,-0.9873688f,0.01810242f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322437f,1.538537f,0.4832446f,-0.654529f,-0.208267f,-0.2497479f,0.6825268f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 2.238861f);
Get(0x6E70).SetLocalPose(-0.1349643f,1.682058f,-0.4657733f,0.4664419f,-0.4669821f,-0.5057744f,0.5554745f);
Get(0x6E82).SetLocalPose(-0.2457879f,0.8145547f,-0.4357554f,-0.005769975f,-0.1138299f,-0.01746776f,0.9933299f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 2.238861f);
Get(0x6EC6).SetLocalPose(0.1711541f,0.8240033f,-0.4806488f,-0.1522234f,-0.01083074f,-0.988125f,0.01787957f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322501f,1.538553f,0.483223f,-0.6545436f,-0.2082912f,-0.2497168f,0.6825167f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 2.254526f);
Get(0x6E70).SetLocalPose(-0.1348598f,1.682356f,-0.466172f,0.4666799f,-0.4678026f,-0.5051054f,0.5551929f);
Get(0x6E82).SetLocalPose(-0.2465514f,0.8135249f,-0.4350066f,-0.005386954f,-0.1130665f,-0.01747993f,0.9934191f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 2.254526f);
Get(0x6EC6).SetLocalPose(0.1705559f,0.8232111f,-0.4795953f,-0.1496442f,-0.01071153f,-0.9885296f,0.0173569f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322444f,1.538407f,0.483142f,-0.6545421f,-0.2082831f,-0.2497233f,0.6825182f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 2.278994f);
Get(0x6E70).SetLocalPose(-0.1346196f,1.682324f,-0.4668232f,0.4669151f,-0.4687635f,-0.5041903f,0.5550164f);
Get(0x6E82).SetLocalPose(-0.2466342f,0.8132572f,-0.4344501f,-0.005498755f,-0.1113664f,-0.0182011f,0.9935975f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 2.278994f);
Get(0x6EC6).SetLocalPose(0.1696715f,0.8234525f,-0.4782265f,-0.1471517f,-0.009859713f,-0.9889299f,0.01633335f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322499f,1.538352f,0.4831617f,-0.6545577f,-0.2082664f,-0.2496885f,0.6825211f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 2.296337f);
Get(0x6E70).SetLocalPose(-0.1343422f,1.682572f,-0.4670734f,0.4670891f,-0.4692978f,-0.5036582f,0.5549017f);
Get(0x6E82).SetLocalPose(-0.2465307f,0.8133417f,-0.4343407f,-0.006185734f,-0.1101319f,-0.0187808f,0.9937203f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 2.296337f);
Get(0x6EC6).SetLocalPose(0.1687647f,0.823961f,-0.4766401f,-0.1455858f,-0.009063655f,-0.9891801f,0.01566468f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32241f,1.538356f,0.48317f,-0.654552f,-0.2082739f,-0.2497138f,0.682515f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 2.314566f);
Get(0x6E70).SetLocalPose(-0.1343563f,1.682542f,-0.46722f,0.4672333f,-0.4697521f,-0.5032373f,0.5547777f);
Get(0x6E82).SetLocalPose(-0.2465892f,0.813746f,-0.4343815f,-0.006878949f,-0.1086572f,-0.01957722f,0.9938627f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 2.314566f);
Get(0x6EC6).SetLocalPose(0.1683444f,0.8244275f,-0.4758838f,-0.1436004f,-0.008267462f,-0.9894806f,0.01545596f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322451f,1.538265f,0.4832959f,-0.6545741f,-0.2082768f,-0.2497167f,0.6824919f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 2.338998f);
Get(0x6E70).SetLocalPose(-0.1343704f,1.682998f,-0.4670548f,0.4673669f,-0.470396f,-0.50284f,0.5544797f);
Get(0x6E82).SetLocalPose(-0.2464271f,0.8144174f,-0.4351757f,-0.008851857f,-0.1055304f,-0.02135527f,0.9941474f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 2.338998f);
Get(0x6EC6).SetLocalPose(0.167577f,0.8245227f,-0.4750964f,-0.1411462f,-0.007956238f,-0.9898254f,0.01612877f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322517f,1.538323f,0.483351f,-0.654575f,-0.2083066f,-0.2497115f,0.6824837f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 2.358138f);
Get(0x6E70).SetLocalPose(-0.1345457f,1.683658f,-0.4669452f,0.467459f,-0.4706651f,-0.5028375f,0.554176f);
Get(0x6E82).SetLocalPose(-0.2464789f,0.8154498f,-0.4353409f,-0.01066043f,-0.1036314f,-0.0230216f,0.9942922f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 2.358138f);
Get(0x6EC6).SetLocalPose(0.1672758f,0.8232903f,-0.4738549f,-0.1395795f,-0.007931583f,-0.9900299f,0.01719069f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322481f,1.538342f,0.4832464f,-0.6545802f,-0.2082766f,-0.2497263f,0.6824825f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 2.376232f);
Get(0x6E70).SetLocalPose(-0.1345495f,1.683762f,-0.4670237f,0.4675592f,-0.471008f,-0.5030249f,0.5536297f);
Get(0x6E82).SetLocalPose(-0.2459364f,0.8156492f,-0.4364102f,-0.01220608f,-0.102071f,-0.02433975f,0.9944044f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 2.376232f);
Get(0x6EC6).SetLocalPose(0.1672079f,0.8238314f,-0.4730011f,-0.1378128f,-0.007852985f,-0.9902363f,0.01944719f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322556f,1.538377f,0.4832256f,-0.6545649f,-0.2082708f,-0.249726f,0.6824991f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 2.39454f);
Get(0x6E70).SetLocalPose(-0.1344835f,1.68382f,-0.4671685f,0.4677052f,-0.4712411f,-0.5032583f,0.5530955f);
Get(0x6E82).SetLocalPose(-0.2456753f,0.8159207f,-0.4364111f,-0.01379952f,-0.1003298f,-0.02535477f,0.9945354f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 2.39454f);
Get(0x6EC6).SetLocalPose(0.1667984f,0.8244756f,-0.4726935f,-0.1361098f,-0.008339462f,-0.9904186f,0.02181073f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322454f,1.53847f,0.4833028f,-0.6545672f,-0.2082926f,-0.2497187f,0.682493f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 2.418406f);
Get(0x6E70).SetLocalPose(-0.134214f,1.684201f,-0.467541f,0.4679818f,-0.4713879f,-0.5034196f,0.5525896f);
Get(0x6E82).SetLocalPose(-0.2452168f,0.8160464f,-0.4362646f,-0.01604056f,-0.09780683f,-0.02630611f,0.9947284f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 2.418406f);
Get(0x6EC6).SetLocalPose(0.1663588f,0.8264943f,-0.4715888f,-0.1329592f,-0.01072918f,-0.9907421f,0.02523567f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322484f,1.538417f,0.4833553f,-0.6545555f,-0.2082716f,-0.2497276f,0.6825073f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 2.425851f);
Get(0x6E70).SetLocalPose(-0.1340275f,1.684114f,-0.4676374f,0.4681191f,-0.4714527f,-0.5034487f,0.5523916f);
Get(0x6E82).SetLocalPose(-0.245149f,0.816117f,-0.4356345f,-0.01692513f,-0.09696385f,-0.02663033f,0.9947876f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 2.425851f);
Get(0x6EC6).SetLocalPose(0.1661504f,0.8277907f,-0.4717114f,-0.1314678f,-0.01210822f,-0.9908897f,0.02659688f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322498f,1.538346f,0.4832433f,-0.6545494f,-0.208282f,-0.2497124f,0.6825156f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 2.459623f);
Get(0x6E70).SetLocalPose(-0.1338848f,1.683948f,-0.4681168f,0.4686177f,-0.4716127f,-0.5033773f,0.5518969f);
Get(0x6E82).SetLocalPose(-0.2445121f,0.8164026f,-0.4354962f,-0.01940628f,-0.09518717f,-0.02801751f,0.9948758f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 2.459623f);
Get(0x6EC6).SetLocalPose(0.1664858f,0.8287348f,-0.4694648f,-0.1288743f,-0.01509431f,-0.9911079f,0.02947517f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322423f,1.538565f,0.4832158f,-0.6545737f,-0.2082773f,-0.2497156f,0.6824925f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 2.476321f);
Get(0x6E70).SetLocalPose(-0.1340003f,1.683423f,-0.4687121f,0.468916f,-0.471739f,-0.5032652f,0.5516378f);
Get(0x6E82).SetLocalPose(-0.2444791f,0.8162881f,-0.4347692f,-0.02066745f,-0.09427115f,-0.02888965f,0.9949127f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 2.476321f);
Get(0x6EC6).SetLocalPose(0.166399f,0.8296898f,-0.4680049f,-0.1269908f,-0.01706649f,-0.9912578f,0.03146436f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322505f,1.538493f,0.4831896f,-0.6545699f,-0.2082955f,-0.2497174f,0.6824899f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 2.494409f);
Get(0x6E70).SetLocalPose(-0.133903f,1.683398f,-0.4692684f,0.4693135f,-0.4718637f,-0.5030427f,0.551396f);
Get(0x6E82).SetLocalPose(-0.2441001f,0.8154134f,-0.4336056f,-0.02236447f,-0.09263156f,-0.0299064f,0.9949999f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 2.494409f);
Get(0x6EC6).SetLocalPose(0.167561f,0.8287033f,-0.4679435f,-0.1246769f,-0.01932934f,-0.9914388f,0.03363416f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322442f,1.538486f,0.4833587f,-0.6545749f,-0.2082827f,-0.2497233f,0.6824869f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 2.518633f);
Get(0x6E70).SetLocalPose(-0.1338922f,1.683065f,-0.469902f,0.4698286f,-0.4721068f,-0.5026239f,0.5511311f);
Get(0x6E82).SetLocalPose(-0.2448999f,0.8152831f,-0.4311171f,-0.02383076f,-0.0912671f,-0.03119419f,0.9950525f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 2.518633f);
Get(0x6EC6).SetLocalPose(0.1682943f,0.8279888f,-0.4676759f,-0.1218448f,-0.02264253f,-0.9916515f,0.0356176f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322394f,1.538478f,0.4833912f,-0.6545712f,-0.2082802f,-0.2497261f,0.6824902f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 2.536328f);
Get(0x6E70).SetLocalPose(-0.1335947f,1.683098f,-0.4704994f,0.4701561f,-0.4722299f,-0.5023808f,0.550968f);
Get(0x6E82).SetLocalPose(-0.245411f,0.8139384f,-0.4309824f,-0.02400281f,-0.0919427f,-0.03182053f,0.9949663f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 2.536328f);
Get(0x6EC6).SetLocalPose(0.1686247f,0.8269896f,-0.4678472f,-0.1197476f,-0.02548374f,-0.9918036f,0.03656129f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322344f,1.538388f,0.4833648f,-0.6545824f,-0.2082993f,-0.2497221f,0.6824751f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 2.55317f);
Get(0x6E70).SetLocalPose(-0.1337344f,1.682767f,-0.4709168f,0.4704399f,-0.472525f,-0.5021486f,0.5506845f);
Get(0x6E82).SetLocalPose(-0.2460188f,0.8139337f,-0.4306578f,-0.0231559f,-0.0946463f,-0.03177715f,0.9947342f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 2.55317f);
Get(0x6EC6).SetLocalPose(0.169043f,0.8266043f,-0.4671801f,-0.1185421f,-0.02760831f,-0.9918676f,0.037206f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322472f,1.538486f,0.4832431f,-0.6545626f,-0.2083073f,-0.2497173f,0.6824934f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 2.577971f);
Get(0x6E70).SetLocalPose(-0.1337064f,1.682961f,-0.4715645f,0.4708214f,-0.4728384f,-0.5018532f,0.5503585f);
Get(0x6E82).SetLocalPose(-0.245942f,0.815231f,-0.430182f,-0.02109635f,-0.09835178f,-0.03080606f,0.994451f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 2.577971f);
Get(0x6EC6).SetLocalPose(0.1690127f,0.8268194f,-0.4668914f,-0.1169633f,-0.03025792f,-0.9919475f,0.03800327f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322438f,1.538432f,0.4832393f,-0.6545692f,-0.2082896f,-0.2497048f,0.682497f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 2.595407f);
Get(0x6E70).SetLocalPose(-0.1337704f,1.683084f,-0.4720728f,0.4711569f,-0.4730592f,-0.5016847f,0.5500352f);
Get(0x6E82).SetLocalPose(-0.2452948f,0.8160881f,-0.4301873f,-0.01987806f,-0.09878708f,-0.03050731f,0.9944422f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 2.595407f);
Get(0x6EC6).SetLocalPose(0.1692348f,0.8268392f,-0.4661649f,-0.1158934f,-0.03146642f,-0.9920195f,0.03841731f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322473f,1.538441f,0.4832678f,-0.6545537f,-0.2083076f,-0.2497293f,0.6824976f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 2.619035f);
Get(0x6E70).SetLocalPose(-0.1337207f,1.682972f,-0.4729094f,0.4716013f,-0.4732723f,-0.5015079f,0.5496321f);
Get(0x6E82).SetLocalPose(-0.2438594f,0.8175088f,-0.4310294f,-0.02020557f,-0.09627423f,-0.03187469f,0.9946392f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 2.619035f);
Get(0x6EC6).SetLocalPose(0.1694931f,0.8271932f,-0.4656986f,-0.1138241f,-0.03349084f,-0.9921573f,0.039322f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322447f,1.538378f,0.4832968f,-0.6545505f,-0.2082972f,-0.2497466f,0.6824973f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 2.635433f);
Get(0x6E70).SetLocalPose(-0.1336193f,1.683219f,-0.473137f,0.4718011f,-0.473482f,-0.5013445f,0.5494291f);
Get(0x6E82).SetLocalPose(-0.2433955f,0.8175806f,-0.431281f,-0.020855f,-0.09446897f,-0.03325485f,0.9947537f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 2.635433f);
Get(0x6EC6).SetLocalPose(0.1696847f,0.8276531f,-0.4645105f,-0.1125824f,-0.03511927f,-0.9922127f,0.04007287f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322287f,1.538404f,0.4833615f,-0.6545565f,-0.208279f,-0.2497415f,0.6824991f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 2.652035f);
Get(0x6E70).SetLocalPose(-0.1333785f,1.683201f,-0.4738116f,0.4719634f,-0.4737894f,-0.5012143f,0.5491434f);
Get(0x6E82).SetLocalPose(-0.2435859f,0.8168214f,-0.4306121f,-0.02062022f,-0.09337389f,-0.03412929f,0.9948323f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 2.652035f);
Get(0x6EC6).SetLocalPose(0.1696928f,0.8285485f,-0.4641861f,-0.1119603f,-0.0367188f,-0.9921927f,0.04086841f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32216f,1.538389f,0.4832968f,-0.6545662f,-0.2082728f,-0.2497464f,0.6824899f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 2.676721f);
Get(0x6E70).SetLocalPose(-0.1332096f,1.683454f,-0.4746895f,0.471863f,-0.4744189f,-0.5010005f,0.5488811f);
Get(0x6E82).SetLocalPose(-0.2442521f,0.8155754f,-0.4286275f,-0.01872455f,-0.09487249f,-0.03406501f,0.9947302f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 2.676721f);
Get(0x6EC6).SetLocalPose(0.1694851f,0.8294083f,-0.4644685f,-0.1110265f,-0.03951187f,-0.9921281f,0.04235297f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322179f,1.538375f,0.483315f,-0.6545641f,-0.2082851f,-0.2497316f,0.6824935f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 2.695358f);
Get(0x6E70).SetLocalPose(-0.1332706f,1.68373f,-0.475239f,0.4715087f,-0.4749115f,-0.5009452f,0.5488101f);
Get(0x6E82).SetLocalPose(-0.2454866f,0.8152875f,-0.426057f,-0.01840975f,-0.0984626f,-0.03350401f,0.9944062f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 2.695358f);
Get(0x6EC6).SetLocalPose(0.1694318f,0.829668f,-0.4645829f,-0.1100732f,-0.0425849f,-0.9920375f,0.04395492f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322146f,1.538418f,0.4834026f,-0.6545728f,-0.2082548f,-0.2497461f,0.6824891f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 2.719662f);
Get(0x6E70).SetLocalPose(-0.1335097f,1.684004f,-0.4760345f,0.4708577f,-0.4756061f,-0.5007258f,0.5489678f);
Get(0x6E82).SetLocalPose(-0.2490264f,0.8159186f,-0.4193553f,-0.0240442f,-0.1033437f,-0.03406165f,0.9937715f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 2.719662f);
Get(0x6EC6).SetLocalPose(0.1696488f,0.8300816f,-0.4646474f,-0.1090205f,-0.04703666f,-0.9918649f,0.04589277f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322127f,1.538446f,0.4833939f,-0.6545696f,-0.2082559f,-0.2497286f,0.6824982f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 2.736549f);
Get(0x6E70).SetLocalPose(-0.133736f,1.684117f,-0.4765041f,0.4704361f,-0.4760591f,-0.5003498f,0.5492792f);
Get(0x6E82).SetLocalPose(-0.2526824f,0.8182821f,-0.4134281f,-0.03115165f,-0.1062867f,-0.03731646f,0.9931467f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 2.736549f);
Get(0x6EC6).SetLocalPose(0.169655f,0.8302588f,-0.4643084f,-0.1083963f,-0.05068129f,-0.9916926f,0.04719519f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322168f,1.538421f,0.4831858f,-0.6545753f,-0.2082604f,-0.2497417f,0.6824866f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 2.752766f);
Get(0x6E70).SetLocalPose(-0.1336265f,1.683981f,-0.4767951f,0.4701144f,-0.4764746f,-0.4999277f,0.5495786f);
Get(0x6E82).SetLocalPose(-0.2573596f,0.8201666f,-0.4057071f,-0.04004111f,-0.1090715f,-0.04269833f,0.9923089f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 2.752766f);
Get(0x6EC6).SetLocalPose(0.1696164f,0.8307819f,-0.4633349f,-0.10766f,-0.05526739f,-0.9914619f,0.04856147f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322253f,1.538473f,0.4832519f,-0.6545841f,-0.2082598f,-0.249751f,0.682475f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 2.770767f);
Get(0x6E70).SetLocalPose(-0.1334558f,1.684304f,-0.4775188f,0.4697316f,-0.4768704f,-0.4995182f,0.5499349f);
Get(0x6E82).SetLocalPose(-0.2640239f,0.8240268f,-0.3941745f,-0.05148679f,-0.1118847f,-0.05059893f,0.9910957f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 2.770767f);
Get(0x6EC6).SetLocalPose(0.1688605f,0.8324706f,-0.4635737f,-0.1068992f,-0.06030592f,-0.991181f,0.04996093f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322226f,1.538397f,0.4833058f,-0.6545683f,-0.2082314f,-0.2497501f,0.6824991f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 2.796859f);
Get(0x6E70).SetLocalPose(-0.133018f,1.683934f,-0.4783034f,0.4689537f,-0.4773774f,-0.4993608f,0.5503018f);
Get(0x6E82).SetLocalPose(-0.2750136f,0.8334868f,-0.3753034f,-0.070191f,-0.116329f,-0.06367701f,0.9886789f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 2.796859f);
Get(0x6EC6).SetLocalPose(0.1684648f,0.8335329f,-0.4629638f,-0.1057809f,-0.06710096f,-0.9907734f,0.0517313f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322339f,1.538403f,0.483174f,-0.6545806f,-0.2082278f,-0.2497625f,0.6824839f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 2.815009f);
Get(0x6E70).SetLocalPose(-0.1325609f,1.683667f,-0.4793273f,0.4686578f,-0.4774327f,-0.4992266f,0.5506275f);
Get(0x6E82).SetLocalPose(-0.2843877f,0.8412633f,-0.3604831f,-0.08542751f,-0.1217282f,-0.07223081f,0.9862389f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 2.815009f);
Get(0x6EC6).SetLocalPose(0.1688525f,0.8339435f,-0.4628234f,-0.104647f,-0.07145591f,-0.9905137f,0.05315755f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322453f,1.538312f,0.4831455f,-0.6545889f,-0.2082468f,-0.2497605f,0.6824709f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 2.832566f);
Get(0x6E70).SetLocalPose(-0.1324871f,1.683517f,-0.4798597f,0.4687771f,-0.4773413f,-0.4989914f,0.5508184f);
Get(0x6E82).SetLocalPose(-0.2934306f,0.8498414f,-0.3458478f,-0.1013085f,-0.1294872f,-0.07843736f,0.9832687f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 2.832566f);
Get(0x6EC6).SetLocalPose(0.1688689f,0.8344285f,-0.462109f,-0.1028126f,-0.07524035f,-0.9903393f,0.05473974f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322227f,1.538363f,0.4833429f,-0.6545927f,-0.2082395f,-0.2497557f,0.6824712f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 2.859313f);
Get(0x6E70).SetLocalPose(-0.1323972f,1.683524f,-0.4811965f,0.4695897f,-0.4772512f,-0.4978093f,0.5512738f);
Get(0x6E82).SetLocalPose(-0.309932f,0.8676423f,-0.3183606f,-0.1382631f,-0.1462109f,-0.09032772f,0.97537f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 2.859313f);
Get(0x6EC6).SetLocalPose(0.1682307f,0.8344117f,-0.4608124f,-0.09913659f,-0.07891453f,-0.9903166f,0.05672335f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322168f,1.538334f,0.4832989f,-0.6545708f,-0.2082465f,-0.2497583f,0.6824891f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 2.875933f);
Get(0x6E70).SetLocalPose(-0.1327019f,1.68371f,-0.482017f,0.4701065f,-0.4773772f,-0.4969918f,0.5514618f);
Get(0x6E82).SetLocalPose(-0.3201483f,0.8820117f,-0.3014747f,-0.1646653f,-0.1559865f,-0.09785498f,0.9690088f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 2.875933f);
Get(0x6EC6).SetLocalPose(0.1677869f,0.8345672f,-0.4600179f,-0.09568634f,-0.08131602f,-0.9903594f,0.0584815f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322182f,1.538266f,0.4832588f,-0.6545588f,-0.2082753f,-0.2497559f,0.6824927f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 2.892786f);
Get(0x6E70).SetLocalPose(-0.1329688f,1.683811f,-0.4826867f,0.4706324f,-0.4776497f,-0.4960834f,0.5515952f);
Get(0x6E82).SetLocalPose(-0.3317221f,0.900255f,-0.2813657f,-0.1974201f,-0.168367f,-0.1062848f,0.9598861f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 2.892786f);
Get(0x6EC6).SetLocalPose(0.1677597f,0.8344747f,-0.4594652f,-0.09244309f,-0.08346469f,-0.9903767f,0.06034915f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322179f,1.538406f,0.483254f,-0.6545495f,-0.2082541f,-0.2497565f,0.6825078f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 2.919111f);
Get(0x6E70).SetLocalPose(-0.1332572f,1.684372f,-0.4837245f,0.471491f,-0.4782976f,-0.4948789f,0.5513825f);
Get(0x6E82).SetLocalPose(-0.3494244f,0.9301016f,-0.2549246f,-0.247575f,-0.1849753f,-0.1203772f,0.9433982f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 2.919111f);
Get(0x6EC6).SetLocalPose(0.1673611f,0.8350993f,-0.4577582f,-0.08746895f,-0.08772432f,-0.9902342f,0.06395245f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322262f,1.538391f,0.4831786f,-0.6545495f,-0.2082612f,-0.2497611f,0.6825039f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 2.937884f);
Get(0x6E70).SetLocalPose(-0.1337727f,1.684327f,-0.4847232f,0.472299f,-0.4788994f,-0.4941961f,0.5507805f);
Get(0x6E82).SetLocalPose(-0.3644764f,0.9578328f,-0.2327821f,-0.295254f,-0.1958081f,-0.1365026f,0.9251223f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 2.937884f);
Get(0x6EC6).SetLocalPose(0.1675618f,0.8355784f,-0.4577759f,-0.08489173f,-0.09066853f,-0.9900451f,0.0662072f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322189f,1.538304f,0.4832492f,-0.6545619f,-0.208244f,-0.2497696f,0.6824942f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 2.955068f);
Get(0x6E70).SetLocalPose(-0.1343756f,1.684315f,-0.4851973f,0.4730488f,-0.4793687f,-0.4937944f,0.5500888f);
Get(0x6E82).SetLocalPose(-0.3773965f,0.9871449f,-0.2138691f,-0.3409477f,-0.2031923f,-0.1530399f,0.9050119f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 2.955068f);
Get(0x6EC6).SetLocalPose(0.1681038f,0.8351352f,-0.4572132f,-0.08281372f,-0.09333821f,-0.9898374f,0.06820433f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322161f,1.538346f,0.4832037f,-0.654568f,-0.2082515f,-0.2497735f,0.6824846f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 2.972177f);
Get(0x6E70).SetLocalPose(-0.1347949f,1.683766f,-0.4855861f,0.4739136f,-0.479732f,-0.493402f,0.5493793f);
Get(0x6E82).SetLocalPose(-0.3844393f,1.003207f,-0.2052754f,-0.3679883f,-0.2071743f,-0.1631423f,0.8916546f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 2.972177f);
Get(0x6EC6).SetLocalPose(0.1684554f,0.8359203f,-0.4573924f,-0.08027957f,-0.09611813f,-0.9896297f,0.07035264f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322314f,1.538309f,0.4830956f,-0.6545588f,-0.2082523f,-0.2497555f,0.6824998f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 2.997818f);
Get(0x6E70).SetLocalPose(-0.1351956f,1.683632f,-0.4865071f,0.4751614f,-0.4803037f,-0.4929481f,0.5482081f);
Get(0x6E82).SetLocalPose(-0.4038797f,1.053542f,-0.1825712f,-0.4435519f,-0.2221082f,-0.1900735f,0.8472319f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 2.997818f);
Get(0x6EC6).SetLocalPose(0.1691747f,0.8365f,-0.4572511f,-0.07655954f,-0.1001474f,-0.9892933f,0.07353776f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322201f,1.538471f,0.4831145f,-0.6545522f,-0.2082715f,-0.2497481f,0.682503f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 3.014377f);
Get(0x6E70).SetLocalPose(-0.1354301f,1.683364f,-0.4868673f,0.4757939f,-0.4807191f,-0.4929047f,0.5473338f);
Get(0x6E82).SetLocalPose(-0.4142321f,1.086408f,-0.172132f,-0.4870154f,-0.2323546f,-0.2046065f,0.8166783f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 3.014377f);
Get(0x6EC6).SetLocalPose(0.1692383f,0.836252f,-0.4575036f,-0.07437528f,-0.1025553f,-0.9890807f,0.07529986f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322272f,1.53841f,0.4831063f,-0.6545594f,-0.2082521f,-0.2497494f,0.6825016f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 3.037507f);
Get(0x6E70).SetLocalPose(-0.1356877f,1.682975f,-0.4875253f,0.4765849f,-0.4809819f,-0.493141f,0.5462007f);
Get(0x6E82).SetLocalPose(-0.4256889f,1.127988f,-0.1617501f,-0.542478f,-0.2447408f,-0.2241794f,0.7717274f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 3.037507f);
Get(0x6EC6).SetLocalPose(0.1690282f,0.8371925f,-0.4581766f,-0.0710476f,-0.1056374f,-0.9888325f,0.07748227f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322263f,1.538391f,0.4830948f,-0.654578f,-0.2082648f,-0.2497621f,0.6824752f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 3.054151f);
Get(0x6E70).SetLocalPose(-0.1360882f,1.682604f,-0.4878531f,0.4771674f,-0.4809994f,-0.4933904f,0.545451f);
Get(0x6E82).SetLocalPose(-0.4322914f,1.160114f,-0.1564075f,-0.5808876f,-0.2537591f,-0.2348803f,0.7368903f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 3.054151f);
Get(0x6EC6).SetLocalPose(0.1692906f,0.8371065f,-0.4588105f,-0.06902128f,-0.1073658f,-0.9886956f,0.07867385f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322338f,1.538307f,0.4831466f,-0.6545835f,-0.2082449f,-0.2497658f,0.6824747f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 3.079086f);
Get(0x6E70).SetLocalPose(-0.1363464f,1.682082f,-0.4879005f,0.4785846f,-0.4806985f,-0.494056f,0.5438698f);
Get(0x6E82).SetLocalPose(-0.4400646f,1.212003f,-0.1522804f,-0.6353242f,-0.2669989f,-0.2440651f,0.6822807f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 3.079086f);
Get(0x6EC6).SetLocalPose(0.1684876f,0.8371605f,-0.4589516f,-0.06656106f,-0.1095791f,-0.9885159f,0.07999042f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322378f,1.538357f,0.4832305f,-0.654572f,-0.2082764f,-0.2497569f,0.6824793f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 3.095226f);
Get(0x6E70).SetLocalPose(-0.1366483f,1.682292f,-0.4878834f,0.4795314f,-0.4803044f,-0.4944905f,0.5429885f);
Get(0x6E82).SetLocalPose(-0.4428764f,1.242837f,-0.1529125f,-0.6679155f,-0.2729217f,-0.2463799f,0.6470701f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 3.095226f);
Get(0x6EC6).SetLocalPose(0.1680446f,0.8370017f,-0.4590184f,-0.06505006f,-0.1112264f,-0.9883529f,0.08096796f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322406f,1.538357f,0.4833296f,-0.654574f,-0.208309f,-0.2497117f,0.682484f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 3.11956f);
Get(0x6E70).SetLocalPose(-0.1373382f,1.681748f,-0.487717f,0.480465f,-0.4799025f,-0.4951638f,0.5419039f);
Get(0x6E82).SetLocalPose(-0.4426438f,1.284674f,-0.1567651f,-0.7122691f,-0.2757019f,-0.2485043f,0.5957406f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 3.11956f);
Get(0x6EC6).SetLocalPose(0.1673512f,0.8378953f,-0.4589662f,-0.06366544f,-0.1133698f,-0.9880816f,0.0823934f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322453f,1.53851f,0.4832684f,-0.6545706f,-0.2082923f,-0.2497151f,0.6824911f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 3.137192f);
Get(0x6E70).SetLocalPose(-0.1369786f,1.681195f,-0.4877546f,0.4808891f,-0.4796917f,-0.4956504f,0.5412692f);
Get(0x6E82).SetLocalPose(-0.4404207f,1.314506f,-0.1619825f,-0.7424583f,-0.273981f,-0.2501502f,0.5577768f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 3.137192f);
Get(0x6EC6).SetLocalPose(0.167233f,0.8379627f,-0.4585382f,-0.06349183f,-0.1146687f,-0.9878561f,0.0834281f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322424f,1.538534f,0.4832886f,-0.654569f,-0.2082839f,-0.2497189f,0.6824937f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 3.157248f);
Get(0x6E70).SetLocalPose(-0.1369182f,1.681171f,-0.4873081f,0.4810896f,-0.4795859f,-0.4963412f,0.5405512f);
Get(0x6E82).SetLocalPose(-0.435333f,1.350822f,-0.1716171f,-0.7781886f,-0.2680041f,-0.2521343f,0.5089447f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 3.157248f);
Get(0x6EC6).SetLocalPose(0.1668792f,0.8382955f,-0.4573839f,-0.06413511f,-0.1166961f,-0.9874259f,0.08519936f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322436f,1.538444f,0.4831742f,-0.6545695f,-0.2083073f,-0.2497605f,0.6824709f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 3.177194f);
Get(0x6E70).SetLocalPose(-0.1365296f,1.681709f,-0.4870338f,0.4809998f,-0.4793831f,-0.4975327f,0.5397151f);
Get(0x6E82).SetLocalPose(-0.4276359f,1.383083f,-0.1839522f,-0.8110717f,-0.2577148f,-0.2546361f,0.4592455f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 3.177194f);
Get(0x6EC6).SetLocalPose(0.1666296f,0.8381646f,-0.4569076f,-0.06561026f,-0.1184819f,-0.9869428f,0.08718561f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322449f,1.53835f,0.4831457f,-0.6545589f,-0.2082787f,-0.2497415f,0.6824968f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 3.194825f);
Get(0x6E70).SetLocalPose(-0.1363445f,1.681894f,-0.48664f,0.4808845f,-0.4792427f,-0.4984226f,0.539121f);
Get(0x6E82).SetLocalPose(-0.4201173f,1.405962f,-0.1954039f,-0.8361151f,-0.2453614f,-0.258341f,0.4170962f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 3.194825f);
Get(0x6EC6).SetLocalPose(0.1668783f,0.8383965f,-0.4565543f,-0.06686199f,-0.1194756f,-0.9866303f,0.08840639f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32243f,1.538402f,0.4830682f,-0.6545491f,-0.208305f,-0.2497449f,0.682497f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 3.218848f);
Get(0x6E70).SetLocalPose(-0.1359446f,1.681695f,-0.4862962f,0.4805573f,-0.478899f,-0.500093f,0.5381706f);
Get(0x6E82).SetLocalPose(-0.4059402f,1.437258f,-0.2147253f,-0.8714051f,-0.2159005f,-0.2706162f,0.3475733f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 3.218848f);
Get(0x6EC6).SetLocalPose(0.166958f,0.836394f,-0.4566877f,-0.07095087f,-0.1215875f,-0.9857805f,0.09175739f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32244f,1.538418f,0.4830842f,-0.6545415f,-0.208279f,-0.2497395f,0.6825142f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 3.234564f);
Get(0x6E70).SetLocalPose(-0.1355235f,1.681378f,-0.4856728f,0.480009f,-0.4785276f,-0.5022026f,0.5370246f);
Get(0x6E82).SetLocalPose(-0.395737f,1.4537f,-0.2273513f,-0.8907825f,-0.1927963f,-0.2836898f,0.2980878f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 3.234564f);
Get(0x6EC6).SetLocalPose(0.1671372f,0.8360284f,-0.4568858f,-0.07331016f,-0.1223635f,-0.9853737f,0.0932284f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322459f,1.538341f,0.4831937f,-0.654547f,-0.2083304f,-0.2497404f,0.6824929f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 3.254527f);
Get(0x6E70).SetLocalPose(-0.1347244f,1.681604f,-0.4850903f,0.4791802f,-0.4781275f,-0.50484f,0.5356464f);
Get(0x6E82).SetLocalPose(-0.3829064f,1.469975f,-0.2413588f,-0.9090559f,-0.1679782f,-0.2962161f,0.2401181f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 3.254527f);
Get(0x6EC6).SetLocalPose(0.1670769f,0.8368096f,-0.4580478f,-0.07729772f,-0.12312f,-0.9848282f,0.09476272f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322446f,1.538421f,0.4832864f,-0.6545401f,-0.2083088f,-0.2497434f,0.682505f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 3.271507f);
Get(0x6E70).SetLocalPose(-0.1343873f,1.682289f,-0.4846574f,0.4786456f,-0.4777827f,-0.5065339f,0.5348321f);
Get(0x6E82).SetLocalPose(-0.369896f,1.482617f,-0.2571492f,-0.9237815f,-0.1449671f,-0.3039031f,0.1823603f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 3.271507f);
Get(0x6EC6).SetLocalPose(0.1676035f,0.8358936f,-0.4591039f,-0.08039837f,-0.1233037f,-0.9845138f,0.0952097f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322285f,1.538497f,0.4834487f,-0.6545529f,-0.2082713f,-0.2497455f,0.6825033f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 3.298826f);
Get(0x6E70).SetLocalPose(-0.1330658f,1.682299f,-0.4842196f,0.4773536f,-0.4770625f,-0.5098476f,0.5334795f);
Get(0x6E82).SetLocalPose(-0.3505304f,1.49533f,-0.2840734f,-0.940245f,-0.1099083f,-0.3092108f,0.09081989f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 3.298826f);
Get(0x6EC6).SetLocalPose(0.1677057f,0.8353339f,-0.4604695f,-0.08608326f,-0.1226153f,-0.9841602f,0.09478353f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322182f,1.538332f,0.4833982f,-0.6545587f,-0.2082695f,-0.2497786f,0.6824861f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 3.315463f);
Get(0x6E70).SetLocalPose(-0.1325985f,1.682588f,-0.4837743f,0.4767681f,-0.4767187f,-0.5110618f,0.5331485f);
Get(0x6E82).SetLocalPose(-0.3381476f,1.501268f,-0.2977087f,-0.9463187f,-0.08893859f,-0.3083975f,0.03823531f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 3.315463f);
Get(0x6EC6).SetLocalPose(0.1677811f,0.8343134f,-0.4612003f,-0.08959353f,-0.1220017f,-0.9839729f,0.0942649f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322099f,1.538237f,0.4834781f,-0.6545661f,-0.2082737f,-0.2497736f,0.6824797f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 3.336102f);
Get(0x6E70).SetLocalPose(-0.1323666f,1.682641f,-0.4834374f,0.476281f,-0.476493f,-0.5118834f,0.5329975f);
Get(0x6E82).SetLocalPose(-0.3233552f,1.503906f,-0.3148928f,-0.9496269f,-0.06130788f,-0.3063178f,-0.0248906f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 3.336102f);
Get(0x6EC6).SetLocalPose(0.1681271f,0.8334224f,-0.4612579f,-0.09446326f,-0.1214571f,-0.9836474f,0.093609f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321952f,1.53813f,0.4834687f,-0.6545804f,-0.2082334f,-0.2498006f,0.6824684f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 3.353656f);
Get(0x6E70).SetLocalPose(-0.1314854f,1.682101f,-0.4833208f,0.4756274f,-0.4761565f,-0.5129396f,0.5328663f);
Get(0x6E82).SetLocalPose(-0.3107365f,1.503389f,-0.3296045f,-0.9493415f,-0.03736166f,-0.3023237f,-0.07717015f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 3.353656f);
Get(0x6EC6).SetLocalPose(0.1683074f,0.8333157f,-0.4615196f,-0.09669702f,-0.1213626f,-0.9834591f,0.0934303f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321825f,1.538152f,0.4834262f,-0.6545604f,-0.20825f,-0.2498295f,0.6824719f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 3.378865f);
Get(0x6E70).SetLocalPose(-0.130547f,1.68175f,-0.4828034f,0.4738125f,-0.4752478f,-0.5151716f,0.5331411f);
Get(0x6E82).SetLocalPose(-0.2934267f,1.501897f,-0.3480749f,-0.9470294f,-0.00854239f,-0.2895642f,-0.1386184f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 3.378865f);
Get(0x6EC6).SetLocalPose(0.1680032f,0.8332025f,-0.4622205f,-0.1036865f,-0.12172f,-0.9827373f,0.09306341f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321731f,1.538226f,0.483447f,-0.6545441f,-0.2082266f,-0.2498375f,0.6824918f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 3.397008f);
Get(0x6E70).SetLocalPose(-0.1299264f,1.681808f,-0.4824842f,0.4724497f,-0.4746657f,-0.5161956f,0.5338781f);
Get(0x6E82).SetLocalPose(-0.2797416f,1.505542f,-0.3602671f,-0.9466428f,0.008116846f,-0.2742473f,-0.1690858f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 3.397008f);
Get(0x6EC6).SetLocalPose(0.1683785f,0.8330735f,-0.462286f,-0.1084655f,-0.1223001f,-0.9821661f,0.09288617f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321684f,1.538198f,0.4832483f,-0.6545489f,-0.2082286f,-0.2498447f,0.6824838f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 3.413439f);
Get(0x6E70).SetLocalPose(-0.1291287f,1.682072f,-0.4825852f,0.47136f,-0.4743138f,-0.5166408f,0.5347228f);
Get(0x6E82).SetLocalPose(-0.2701307f,1.504432f,-0.3692008f,-0.9464785f,0.02220182f,-0.26006f,-0.1898796f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 3.413439f);
Get(0x6EC6).SetLocalPose(0.1681429f,0.833042f,-0.4624684f,-0.1125856f,-0.1227285f,-0.9816669f,0.09269447f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321749f,1.538191f,0.4831877f,-0.6545482f,-0.2082156f,-0.2498815f,0.6824751f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 3.437086f);
Get(0x6E70).SetLocalPose(-0.1282004f,1.682351f,-0.482652f,0.4700461f,-0.4738355f,-0.5169958f,0.5359589f);
Get(0x6E82).SetLocalPose(-0.2592232f,1.500053f,-0.3787554f,-0.9452292f,0.03707555f,-0.2412748f,-0.2166881f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 3.437086f);
Get(0x6EC6).SetLocalPose(0.1684956f,0.8329173f,-0.4626902f,-0.1171093f,-0.1231597f,-0.9811022f,0.09249707f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321734f,1.53808f,0.4831735f,-0.654564f,-0.2082066f,-0.2498963f,0.6824571f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 3.455788f);
Get(0x6E70).SetLocalPose(-0.1273832f,1.682321f,-0.482779f,0.4688489f,-0.4734782f,-0.5171748f,0.5371493f);
Get(0x6E82).SetLocalPose(-0.254665f,1.49582f,-0.3836991f,-0.9452554f,0.04124917f,-0.2276891f,-0.230105f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 3.455788f);
Get(0x6EC6).SetLocalPose(0.1684946f,0.8331742f,-0.4632731f,-0.1198578f,-0.1233499f,-0.9807672f,0.09227468f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321613f,1.538024f,0.4831254f,-0.6545675f,-0.2081987f,-0.2498773f,0.6824633f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 3.473069f);
Get(0x6E70).SetLocalPose(-0.1270771f,1.682857f,-0.4828385f,0.4681593f,-0.4731673f,-0.5171594f,0.5380388f);
Get(0x6E82).SetLocalPose(-0.2540742f,1.494325f,-0.3858248f,-0.9481676f,0.03561219f,-0.2170838f,-0.2293134f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 3.473069f);
Get(0x6EC6).SetLocalPose(0.168652f,0.8329672f,-0.4635539f,-0.1236639f,-0.1237531f,-0.9802649f,0.09204945f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32164f,1.53803f,0.4831882f,-0.6545423f,-0.2082271f,-0.2499096f,0.6824669f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 3.497927f);
Get(0x6E70).SetLocalPose(-0.1269073f,1.683568f,-0.4828793f,0.4672595f,-0.4726519f,-0.5169394f,0.5394835f);
Get(0x6E82).SetLocalPose(-0.2603317f,1.496211f,-0.3831306f,-0.9575531f,0.005771605f,-0.2112972f,-0.1959903f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 3.497927f);
Get(0x6EC6).SetLocalPose(0.1687404f,0.8329565f,-0.4628638f,-0.1270549f,-0.1242813f,-0.9798058f,0.09160693f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321619f,1.538094f,0.4831439f,-0.6545376f,-0.2082245f,-0.2499042f,0.6824743f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 3.514468f);
Get(0x6E70).SetLocalPose(-0.1263621f,1.683775f,-0.48336f,0.4667985f,-0.4724599f,-0.5167114f,0.5402687f);
Get(0x6E82).SetLocalPose(-0.2662979f,1.502125f,-0.3781213f,-0.963919f,-0.0272597f,-0.2092041f,-0.1623294f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 3.514468f);
Get(0x6EC6).SetLocalPose(0.1687582f,0.8328596f,-0.4628951f,-0.1289271f,-0.1246994f,-0.9795461f,0.09119932f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321633f,1.538129f,0.4833003f,-0.6545445f,-0.2082547f,-0.2499135f,0.682455f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 3.53864f);
Get(0x6E70).SetLocalPose(-0.1258052f,1.683672f,-0.4840966f,0.4662119f,-0.4725701f,-0.5162643f,0.5411054f);
Get(0x6E82).SetLocalPose(-0.2854294f,1.512431f,-0.3641543f,-0.9691125f,-0.09642112f,-0.2070914f,-0.09293596f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 3.53864f);
Get(0x6EC6).SetLocalPose(0.1687114f,0.8327465f,-0.4629646f,-0.130581f,-0.125345f,-0.9792975f,0.0906295f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32167f,1.537975f,0.4833231f,-0.6545404f,-0.2082507f,-0.2499059f,0.6824629f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 3.555694f);
Get(0x6E70).SetLocalPose(-0.1258788f,1.68357f,-0.4845597f,0.4658608f,-0.4728338f,-0.5160792f,0.5413541f);
Get(0x6E82).SetLocalPose(-0.3003858f,1.518706f,-0.3529565f,-0.9675197f,-0.1381876f,-0.2060529f,-0.04849813f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 3.555694f);
Get(0x6EC6).SetLocalPose(0.1687633f,0.832724f,-0.462608f,-0.1310513f,-0.125692f,-0.9792113f,0.09040145f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321645f,1.538119f,0.4834293f,-0.6545404f,-0.2082332f,-0.2499083f,0.6824674f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 3.579465f);
Get(0x6E70).SetLocalPose(-0.1257148f,1.683285f,-0.4855412f,0.4650743f,-0.4737004f,-0.5159424f,0.5414031f);
Get(0x6E82).SetLocalPose(-0.32736f,1.529222f,-0.3336195f,-0.9525185f,-0.2267726f,-0.1975539f,0.04748853f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 3.579465f);
Get(0x6EC6).SetLocalPose(0.1685423f,0.8339757f,-0.4622635f,-0.1312299f,-0.1261547f,-0.9791598f,0.09005527f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321497f,1.5381f,0.4833824f,-0.6545365f,-0.2082095f,-0.249934f,0.682469f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 3.597885f);
Get(0x6E70).SetLocalPose(-0.1253569f,1.683129f,-0.4865966f,0.4645458f,-0.4743876f,-0.5160527f,0.54115f);
Get(0x6E82).SetLocalPose(-0.3480952f,1.536553f,-0.3199388f,-0.9362034f,-0.283154f,-0.17642f,0.110557f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 3.597885f);
Get(0x6EC6).SetLocalPose(0.1682709f,0.8346509f,-0.4619623f,-0.1307783f,-0.1263593f,-0.9792036f,0.08994911f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321566f,1.538031f,0.4832827f,-0.6545377f,-0.2081953f,-0.249944f,0.6824685f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 3.614503f);
Get(0x6E70).SetLocalPose(-0.1249461f,1.683034f,-0.487404f,0.4641248f,-0.4749942f,-0.5162303f,0.5408096f);
Get(0x6E82).SetLocalPose(-0.3671953f,1.537829f,-0.3086453f,-0.9193806f,-0.3278842f,-0.1351393f,0.1702019f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 3.614503f);
Get(0x6EC6).SetLocalPose(0.1683401f,0.8341728f,-0.4621232f,-0.1304778f,-0.1264391f,-0.9792276f,0.09001141f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321569f,1.538032f,0.4831475f,-0.6545374f,-0.2082007f,-0.2499414f,0.6824681f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 3.638237f);
Get(0x6E70).SetLocalPose(-0.1244086f,1.682913f,-0.4888059f,0.4634381f,-0.476096f,-0.5167724f,0.5399111f);
Get(0x6E82).SetLocalPose(-0.3922957f,1.537303f,-0.2940845f,-0.8991029f,-0.3614522f,-0.09508047f,0.2278729f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 3.638237f);
Get(0x6EC6).SetLocalPose(0.1679701f,0.834029f,-0.4624472f,-0.1289759f,-0.1264823f,-0.9794068f,0.09016531f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321436f,1.538101f,0.4831749f,-0.654542f,-0.2081792f,-0.2499309f,0.6824741f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 3.657041f);
Get(0x6E70).SetLocalPose(-0.1241719f,1.683521f,-0.489446f,0.4634422f,-0.4765189f,-0.5170761f,0.5392433f);
Get(0x6E82).SetLocalPose(-0.4004816f,1.53579f,-0.2878776f,-0.8959422f,-0.3631916f,-0.1162811f,0.227724f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 3.657041f);
Get(0x6EC6).SetLocalPose(0.1681107f,0.8334488f,-0.4623982f,-0.1271473f,-0.1264906f,-0.9796199f,0.09043628f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32148f,1.537994f,0.4831062f,-0.6545259f,-0.208201f,-0.2499098f,0.6824905f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 3.674799f);
Get(0x6E70).SetLocalPose(-0.1244327f,1.683504f,-0.490061f,0.4637291f,-0.4765854f,-0.5173301f,0.5386941f);
Get(0x6E82).SetLocalPose(-0.4015068f,1.53292f,-0.2850467f,-0.9001183f,-0.3534916f,-0.1501196f,0.2056574f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 3.674799f);
Get(0x6EC6).SetLocalPose(0.1679841f,0.8331071f,-0.4622305f,-0.1248063f,-0.1264868f,-0.9798759f,0.09092698f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321425f,1.538168f,0.4831611f,-0.6545305f,-0.2082123f,-0.2499051f,0.6824844f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 3.693454f);
Get(0x6E70).SetLocalPose(-0.1245145f,1.683361f,-0.4906405f,0.4640449f,-0.4762985f,-0.5176572f,0.5383616f);
Get(0x6E82).SetLocalPose(-0.3968835f,1.530706f,-0.2856618f,-0.9078807f,-0.334143f,-0.1903191f,0.1669728f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 3.693454f);
Get(0x6EC6).SetLocalPose(0.1680423f,0.83218f,-0.4626048f,-0.1224784f,-0.1265547f,-0.9801079f,0.09149643f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321464f,1.538168f,0.4831008f,-0.654529f,-0.2081925f,-0.2499053f,0.6824918f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 3.712049f);
Get(0x6E70).SetLocalPose(-0.1245524f,1.683313f,-0.4908003f,0.4639994f,-0.4759643f,-0.5179054f,0.5384576f);
Get(0x6E82).SetLocalPose(-0.3889506f,1.527961f,-0.2881528f,-0.920491f,-0.3000383f,-0.2175312f,0.1239098f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 3.712049f);
Get(0x6EC6).SetLocalPose(0.1680769f,0.8308794f,-0.4620448f,-0.1190756f,-0.127039f,-0.9803706f,0.0924972f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321543f,1.538013f,0.4830991f,-0.6545369f,-0.2082332f,-0.2499286f,0.6824633f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 3.737478f);
Get(0x6E70).SetLocalPose(-0.1250737f,1.683828f,-0.4901305f,0.4629131f,-0.4756518f,-0.5182863f,0.5393015f);
Get(0x6E82).SetLocalPose(-0.3738559f,1.524364f,-0.2970915f,-0.9372858f,-0.2475583f,-0.2333642f,0.07583807f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 3.737478f);
Get(0x6EC6).SetLocalPose(0.1681743f,0.8309228f,-0.4612781f,-0.1145096f,-0.1285708f,-0.9805237f,0.0945013f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321613f,1.537961f,0.4831724f,-0.6545228f,-0.2082358f,-0.2499308f,0.6824753f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 3.753948f);
Get(0x6E70).SetLocalPose(-0.1252844f,1.684217f,-0.4897717f,0.4614657f,-0.4756243f,-0.5185944f,0.5402693f);
Get(0x6E82).SetLocalPose(-0.3585597f,1.523093f,-0.3037736f,-0.9484562f,-0.2029584f,-0.2407603f,0.03568141f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 3.753948f);
Get(0x6EC6).SetLocalPose(0.1682835f,0.8322515f,-0.4609125f,-0.1122253f,-0.1301185f,-0.9804195f,0.0961888f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321619f,1.538006f,0.4831605f,-0.6545214f,-0.2082199f,-0.2499353f,0.6824797f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 3.77766f);
Get(0x6E70).SetLocalPose(-0.1256855f,1.684268f,-0.4890155f,0.459798f,-0.4754711f,-0.5191107f,0.541329f);
Get(0x6E82).SetLocalPose(-0.3391202f,1.51938f,-0.3150997f,-0.9587675f,-0.1402591f,-0.2465046f,-0.01810494f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 3.77766f);
Get(0x6EC6).SetLocalPose(0.1688484f,0.8325679f,-0.4608247f,-0.1107034f,-0.1323262f,-0.9800951f,0.09822589f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321684f,1.538033f,0.4832427f,-0.6545209f,-0.2082282f,-0.249927f,0.6824808f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 3.794891f);
Get(0x6E70).SetLocalPose(-0.1255994f,1.684805f,-0.4883566f,0.4589702f,-0.4748103f,-0.5197264f,0.5420204f);
Get(0x6E82).SetLocalPose(-0.3219977f,1.5146f,-0.3255399f,-0.9627229f,-0.08330406f,-0.2491313f,-0.06448841f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 3.794891f);
Get(0x6EC6).SetLocalPose(0.1688393f,0.8333279f,-0.4609492f,-0.1104051f,-0.1347541f,-0.9796088f,0.100093f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321736f,1.538137f,0.4831365f,-0.6545275f,-0.2082352f,-0.2498955f,0.6824838f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 3.819601f);
Get(0x6E70).SetLocalPose(-0.1262732f,1.684464f,-0.4871714f,0.4589807f,-0.473233f,-0.5207965f,0.5423636f);
Get(0x6E82).SetLocalPose(-0.2999594f,1.506048f,-0.3382277f,-0.9560711f,-0.01043776f,-0.2595671f,-0.135809f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 3.819601f);
Get(0x6EC6).SetLocalPose(0.1690577f,0.8331823f,-0.4609745f,-0.1108082f,-0.1363156f,-0.9792321f,0.1012136f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32169f,1.53806f,0.4830685f,-0.6545156f,-0.2082236f,-0.249886f,0.6825022f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 3.838169f);
Get(0x6E70).SetLocalPose(-0.1262923f,1.684271f,-0.4870793f,0.4594747f,-0.4720478f,-0.5212809f,0.5425127f);
Get(0x6E82).SetLocalPose(-0.2862603f,1.501887f,-0.3483311f,-0.9467475f,0.02646039f,-0.2627343f,-0.1842274f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 3.838169f);
Get(0x6EC6).SetLocalPose(0.1689406f,0.8330119f,-0.4611231f,-0.1109421f,-0.1364047f,-0.9791941f,0.1013143f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321785f,1.538131f,0.4829694f,-0.6545017f,-0.2082478f,-0.2498893f,0.6825069f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 3.854441f);
Get(0x6E70).SetLocalPose(-0.1268889f,1.683772f,-0.4867285f,0.4598309f,-0.471237f,-0.5214367f,0.5427661f);
Get(0x6E82).SetLocalPose(-0.278861f,1.499647f,-0.3550119f,-0.9428864f,0.04142969f,-0.2583743f,-0.2061352f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 3.854441f);
Get(0x6EC6).SetLocalPose(0.168715f,0.8332298f,-0.4612372f,-0.1108179f,-0.1360663f,-0.9792495f,0.1013695f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321703f,1.538099f,0.483049f,-0.6545008f,-0.2082116f,-0.2499076f,0.6825121f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 3.879863f);
Get(0x6E70).SetLocalPose(-0.1276325f,1.68304f,-0.4861636f,0.4597575f,-0.4708834f,-0.5211779f,0.5433834f);
Get(0x6E82).SetLocalPose(-0.2694274f,1.501853f,-0.3637142f,-0.9440779f,0.04022519f,-0.2443646f,-0.2176806f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 3.879863f);
Get(0x6EC6).SetLocalPose(0.1682485f,0.8329957f,-0.4618715f,-0.1108197f,-0.1353284f,-0.9793399f,0.1014825f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321732f,1.538126f,0.4830596f,-0.6545045f,-0.208215f,-0.2499174f,0.6825039f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 3.896304f);
Get(0x6E70).SetLocalPose(-0.1279413f,1.683224f,-0.4858471f,0.4595929f,-0.4709635f,-0.5209599f,0.5436622f);
Get(0x6E82).SetLocalPose(-0.2683831f,1.503907f,-0.3652995f,-0.9477852f,0.02733596f,-0.2374793f,-0.2110915f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 3.896304f);
Get(0x6EC6).SetLocalPose(0.1680031f,0.8329876f,-0.462216f,-0.1115984f,-0.134537f,-0.9793645f,0.1014437f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321707f,1.538055f,0.4831588f,-0.654504f,-0.208216f,-0.2499099f,0.6825069f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 3.914477f);
Get(0x6E70).SetLocalPose(-0.128297f,1.683441f,-0.4858713f,0.4596142f,-0.4709461f,-0.5206106f,0.5439938f);
Get(0x6E82).SetLocalPose(-0.2697424f,1.504117f,-0.3664792f,-0.9502795f,0.01813591f,-0.233879f,-0.2047945f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 3.914477f);
Get(0x6EC6).SetLocalPose(0.1678617f,0.8327798f,-0.4624254f,-0.1123005f,-0.1339353f,-0.9793813f,0.1013026f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321677f,1.538244f,0.4831437f,-0.6545103f,-0.2082064f,-0.2499098f,0.6825038f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 3.939934f);
Get(0x6E70).SetLocalPose(-0.1286213f,1.683174f,-0.4860917f,0.4600632f,-0.4706902f,-0.5202405f,0.5441898f);
Get(0x6E82).SetLocalPose(-0.2783831f,1.512043f,-0.366038f,-0.9602066f,-0.03044838f,-0.220924f,-0.1681335f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 3.939934f);
Get(0x6EC6).SetLocalPose(0.1681553f,0.8328857f,-0.4621432f,-0.1135372f,-0.1329052f,-0.9794131f,0.1009726f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321582f,1.538134f,0.4831171f,-0.6545059f,-0.2082059f,-0.2499209f,0.6825042f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 3.958974f);
Get(0x6E70).SetLocalPose(-0.1287413f,1.682571f,-0.4864467f,0.4610031f,-0.4702649f,-0.519815f,0.5441685f);
Get(0x6E82).SetLocalPose(-0.2937216f,1.525046f,-0.3612655f,-0.9672996f,-0.09587617f,-0.2046233f,-0.1151901f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 3.958974f);
Get(0x6EC6).SetLocalPose(0.168063f,0.832281f,-0.4626887f,-0.1153504f,-0.1311834f,-0.9795283f,0.1000477f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321595f,1.538121f,0.4831444f,-0.6544945f,-0.208229f,-0.2499078f,0.6825128f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 3.977514f);
Get(0x6E70).SetLocalPose(-0.1286449f,1.682592f,-0.4870029f,0.4613745f,-0.4702921f,-0.5196821f,0.5439573f);
Get(0x6E82).SetLocalPose(-0.3199433f,1.535876f,-0.3539104f,-0.9670401f,-0.184788f,-0.1708613f,-0.03864224f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 3.977514f);
Get(0x6EC6).SetLocalPose(0.168079f,0.8320998f,-0.4630685f,-0.1169805f,-0.1295703f,-0.9796717f,0.09884583f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321643f,1.538141f,0.4829384f,-0.6545188f,-0.2082038f,-0.2499296f,0.6824893f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 3.995876f);
Get(0x6E70).SetLocalPose(-0.1284734f,1.682829f,-0.4876126f,0.4612426f,-0.470644f,-0.5197414f,0.543708f);
Get(0x6E82).SetLocalPose(-0.3480827f,1.547819f,-0.3428749f,-0.9518245f,-0.2782808f,-0.1192019f,0.04879349f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 3.995876f);
Get(0x6EC6).SetLocalPose(0.1684147f,0.8321363f,-0.4624906f,-0.1173198f,-0.129564f,-0.9796906f,0.09826328f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321661f,1.538066f,0.4829781f,-0.6545151f,-0.2082044f,-0.2499277f,0.6824934f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 4.012504f);
Get(0x6E70).SetLocalPose(-0.127986f,1.683024f,-0.4882532f,0.4609027f,-0.4710451f,-0.5199023f,0.543495f);
Get(0x6E82).SetLocalPose(-0.3614849f,1.552227f,-0.3347879f,-0.9390388f,-0.3171321f,-0.09686459f,0.09083297f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 4.012504f);
Get(0x6EC6).SetLocalPose(0.1684648f,0.8331397f,-0.4617757f,-0.1162709f,-0.1304507f,-0.9796788f,0.09845394f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321477f,1.538092f,0.4831934f,-0.6545235f,-0.2082359f,-0.249941f,0.6824707f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 4.037135f);
Get(0x6E70).SetLocalPose(-0.1276528f,1.683263f,-0.4887103f,0.4604093f,-0.4716452f,-0.5201728f,0.5431339f);
Get(0x6E82).SetLocalPose(-0.3772397f,1.557181f,-0.3219768f,-0.9220179f,-0.345606f,-0.1048554f,0.1394446f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 4.037135f);
Get(0x6EC6).SetLocalPose(0.1684851f,0.8330938f,-0.46121f,-0.1140823f,-0.1317236f,-0.9797287f,0.09882255f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321499f,1.537981f,0.4832582f,-0.6545349f,-0.2082041f,-0.2499514f,0.6824657f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 4.053742f);
Get(0x6E70).SetLocalPose(-0.1275635f,1.683493f,-0.4890305f,0.4601876f,-0.4719253f,-0.5203287f,0.5429292f);
Get(0x6E82).SetLocalPose(-0.3812989f,1.558503f,-0.3166119f,-0.9160249f,-0.3494945f,-0.1252777f,0.1518473f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 4.053742f);
Get(0x6EC6).SetLocalPose(0.1684873f,0.8327956f,-0.4610808f,-0.1125813f,-0.1324f,-0.9797953f,0.09897891f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321443f,1.537874f,0.4830112f,-0.6545365f,-0.2082022f,-0.2499446f,0.6824672f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 4.077088f);
Get(0x6E70).SetLocalPose(-0.1272717f,1.683844f,-0.4895733f,0.459318f,-0.4725921f,-0.5210758f,0.5423686f);
Get(0x6E82).SetLocalPose(-0.3817644f,1.557177f,-0.3117187f,-0.9139472f,-0.3425549f,-0.1565958f,0.1511111f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 4.077088f);
Get(0x6EC6).SetLocalPose(0.1679074f,0.8328877f,-0.4612686f,-0.1099447f,-0.1331701f,-0.9799715f,0.09916601f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321478f,1.537897f,0.4829341f,-0.6545122f,-0.2082145f,-0.2499554f,0.6824828f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 4.096007f);
Get(0x6E70).SetLocalPose(-0.1266083f,1.684503f,-0.4897614f,0.4583363f,-0.4727674f,-0.5215676f,0.5425737f);
Get(0x6E82).SetLocalPose(-0.3759725f,1.558064f,-0.3112294f,-0.919868f,-0.3238678f,-0.1740974f,0.1365384f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 4.096007f);
Get(0x6EC6).SetLocalPose(0.1671839f,0.8327192f,-0.4615747f,-0.1088423f,-0.1334665f,-0.9800389f,0.09931669f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321519f,1.538026f,0.4829959f,-0.6545141f,-0.2082205f,-0.2499316f,0.6824879f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 4.114188f);
Get(0x6E70).SetLocalPose(-0.1261958f,1.684633f,-0.4896788f,0.4574526f,-0.4727244f,-0.5218636f,0.543072f);
Get(0x6E82).SetLocalPose(-0.3659841f,1.557888f,-0.3128963f,-0.9298045f,-0.2948152f,-0.1872115f,0.1161873f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 4.114188f);
Get(0x6EC6).SetLocalPose(0.1666755f,0.8326703f,-0.4612305f,-0.1071144f,-0.1341134f,-0.9800895f,0.09982282f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321541f,1.538034f,0.4830307f,-0.6545241f,-0.2082278f,-0.249915f,0.6824822f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 4.135709f);
Get(0x6E70).SetLocalPose(-0.1257116f,1.684935f,-0.4893095f,0.4560472f,-0.4724934f,-0.5222774f,0.5440564f);
Get(0x6E82).SetLocalPose(-0.3520751f,1.55493f,-0.3174836f,-0.9402037f,-0.2551307f,-0.2081629f,0.08714132f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 4.135709f);
Get(0x6EC6).SetLocalPose(0.168006f,0.8326753f,-0.4601009f,-0.1046043f,-0.135583f,-0.9800223f,0.1011509f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321543f,1.53815f,0.4832042f,-0.6545318f,-0.2082221f,-0.2499442f,0.6824659f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 4.158157f);
Get(0x6E70).SetLocalPose(-0.1247335f,1.685378f,-0.4889365f,0.4546289f,-0.4719613f,-0.5229284f,0.5450789f);
Get(0x6E82).SetLocalPose(-0.3337509f,1.550028f,-0.3225067f,-0.9502147f,-0.2024192f,-0.2330178f,0.04267548f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 4.158157f);
Get(0x6EC6).SetLocalPose(0.1685081f,0.8327121f,-0.4602635f,-0.1040032f,-0.1366448f,-0.979822f,0.1022765f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321496f,1.53813f,0.483196f,-0.6545324f,-0.2082219f,-0.249938f,0.6824676f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 4.179634f);
Get(0x6E70).SetLocalPose(-0.1245293f,1.685423f,-0.4884037f,0.4536017f,-0.4711598f,-0.5238031f,0.5457878f);
Get(0x6E82).SetLocalPose(-0.3148142f,1.542873f,-0.3307622f,-0.9567612f,-0.1461923f,-0.2512645f,-0.01009343f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 4.179634f);
Get(0x6EC6).SetLocalPose(0.1685055f,0.8332155f,-0.4608642f,-0.1039811f,-0.1375559f,-0.9795567f,0.1036098f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321354f,1.538075f,0.4833223f,-0.6545355f,-0.2082322f,-0.2499472f,0.6824581f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 4.197381f);
Get(0x6E70).SetLocalPose(-0.1244268f,1.684875f,-0.487942f,0.453391f,-0.4701226f,-0.5245553f,0.5461348f);
Get(0x6E82).SetLocalPose(-0.2968391f,1.534872f,-0.3384585f,-0.9600588f,-0.0944799f,-0.2561909f,-0.06104762f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 4.197381f);
Get(0x6EC6).SetLocalPose(0.1682724f,0.8326722f,-0.4614451f,-0.1045022f,-0.1378362f,-0.9794001f,0.1041919f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321175f,1.538068f,0.4833429f,-0.6545398f,-0.2082227f,-0.2499669f,0.6824497f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 4.213481f);
Get(0x6E70).SetLocalPose(-0.1243938f,1.68457f,-0.4874114f,0.4535004f,-0.4691179f,-0.5252144f,0.5462743f);
Get(0x6E82).SetLocalPose(-0.2849461f,1.528028f,-0.3458863f,-0.9600692f,-0.05438028f,-0.2549362f,-0.1015747f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 4.213481f);
Get(0x6EC6).SetLocalPose(0.1682468f,0.8326223f,-0.4617726f,-0.1051071f,-0.1377189f,-0.9793538f,0.1041737f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321333f,1.53794f,0.4833404f,-0.6545121f,-0.2081865f,-0.2499496f,0.6824936f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 4.239523f);
Get(0x6E70).SetLocalPose(-0.1241307f,1.684518f,-0.4867226f,0.4539921f,-0.4675826f,-0.5260572f,0.5463712f);
Get(0x6E82).SetLocalPose(-0.2676938f,1.513802f,-0.35855f,-0.954152f,0.001324988f,-0.2493292f,-0.1656117f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 4.239523f);
Get(0x6EC6).SetLocalPose(0.1681552f,0.8323711f,-0.4631075f,-0.1065627f,-0.1372335f,-0.9793372f,0.1034897f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321393f,1.537991f,0.4833327f,-0.6545394f,-0.2081982f,-0.2499218f,0.6824741f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 4.25704f);
Get(0x6E70).SetLocalPose(-0.1241855f,1.683687f,-0.4863161f,0.4541989f,-0.4668241f,-0.5265357f,0.5463871f);
Get(0x6E82).SetLocalPose(-0.2570448f,1.507932f,-0.3672671f,-0.9493641f,0.0306757f,-0.2420174f,-0.1979761f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 4.25704f);
Get(0x6EC6).SetLocalPose(0.1681351f,0.8323264f,-0.4639011f,-0.1075666f,-0.136915f,-0.9793183f,0.1030508f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321429f,1.537995f,0.4833203f,-0.6545204f,-0.2081907f,-0.2499376f,0.6824889f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 4.27377f);
Get(0x6E70).SetLocalPose(-0.1242252f,1.683344f,-0.4861613f,0.4543023f,-0.4663792f,-0.5267527f,0.5464719f);
Get(0x6E82).SetLocalPose(-0.2482565f,1.503946f,-0.3738765f,-0.9465285f,0.05331283f,-0.2351521f,-0.2143479f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 4.27377f);
Get(0x6EC6).SetLocalPose(0.1681504f,0.8331012f,-0.464011f,-0.1095153f,-0.1365806f,-0.9792072f,0.1024968f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321469f,1.538109f,0.4832162f,-0.6545202f,-0.208189f,-0.2499405f,0.6824884f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 4.297847f);
Get(0x6E70).SetLocalPose(-0.1247241f,1.683252f,-0.4859009f,0.454745f,-0.4657361f,-0.5267462f,0.5466583f);
Get(0x6E82).SetLocalPose(-0.2399684f,1.503253f,-0.3786678f,-0.9463758f,0.06270459f,-0.2310715f,-0.2169029f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 4.297847f);
Get(0x6EC6).SetLocalPose(0.1681565f,0.8332657f,-0.4637538f,-0.1121998f,-0.1362133f,-0.9789984f,0.1020751f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32156f,1.538081f,0.4830831f,-0.6545327f,-0.208183f,-0.2499312f,0.6824816f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 4.315071f);
Get(0x6E70).SetLocalPose(-0.1247425f,1.682608f,-0.4859144f,0.4552933f,-0.465334f,-0.5264565f,0.5468233f);
Get(0x6E82).SetLocalPose(-0.2393891f,1.504312f,-0.3797173f,-0.948602f,0.05423387f,-0.2305338f,-0.2099218f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 4.315071f);
Get(0x6EC6).SetLocalPose(0.1682123f,0.8332358f,-0.4639719f,-0.1144921f,-0.1357454f,-0.9788404f,0.1016677f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32149f,1.537975f,0.482983f,-0.6545249f,-0.2081879f,-0.2499654f,0.6824751f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 4.339034f);
Get(0x6E70).SetLocalPose(-0.1243583f,1.682354f,-0.4859972f,0.4563743f,-0.4648702f,-0.5258343f,0.5469156f);
Get(0x6E82).SetLocalPose(-0.2446613f,1.510791f,-0.3768154f,-0.9565181f,0.01552778f,-0.2299741f,-0.1787288f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 4.339034f);
Get(0x6EC6).SetLocalPose(0.1683535f,0.8326377f,-0.463979f,-0.1180997f,-0.1349942f,-0.9785957f,0.1008934f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321472f,1.537947f,0.4829278f,-0.6545276f,-0.2081923f,-0.2499376f,0.6824814f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 4.356079f);
Get(0x6E70).SetLocalPose(-0.1242462f,1.68177f,-0.4861158f,0.4570816f,-0.4648054f,-0.5254923f,0.5467086f);
Get(0x6E82).SetLocalPose(-0.2517556f,1.516874f,-0.373958f,-0.961978f,-0.01528489f,-0.2280996f,-0.1494503f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 4.356079f);
Get(0x6EC6).SetLocalPose(0.1687236f,0.8323908f,-0.4642535f,-0.1204729f,-0.1345362f,-0.9784382f,0.1002245f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32146f,1.537958f,0.4829244f,-0.6545138f,-0.208208f,-0.249936f,0.6824904f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 4.374781f);
Get(0x6E70).SetLocalPose(-0.1238774f,1.681567f,-0.4865421f,0.4577937f,-0.4649472f,-0.525243f,0.5462315f);
Get(0x6E82).SetLocalPose(-0.2690416f,1.527543f,-0.3652359f,-0.9683463f,-0.06552413f,-0.2210571f,-0.09563388f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 4.374781f);
Get(0x6EC6).SetLocalPose(0.1691148f,0.8324385f,-0.4645039f,-0.1221739f,-0.134296f,-0.9783139f,0.09969931f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321566f,1.537987f,0.4829169f,-0.654511f,-0.2082064f,-0.2499044f,0.6825051f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 4.392719f);
Get(0x6E70).SetLocalPose(-0.1236218f,1.681666f,-0.4866802f,0.4582776f,-0.4652552f,-0.5251006f,0.5457001f);
Get(0x6E82).SetLocalPose(-0.284365f,1.537802f,-0.3580284f,-0.9707786f,-0.1171033f,-0.2060515f,-0.03766408f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 4.392719f);
Get(0x6EC6).SetLocalPose(0.1696713f,0.8329901f,-0.4645574f,-0.1237997f,-0.1341524f,-0.9781827f,0.09917361f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321691f,1.538045f,0.482907f,-0.654495f,-0.2082405f,-0.2499407f,0.6824968f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 4.416756f);
Get(0x6E70).SetLocalPose(-0.1235707f,1.682597f,-0.4871179f,0.4588018f,-0.4657849f,-0.5249732f,0.5449298f);
Get(0x6E82).SetLocalPose(-0.3075749f,1.546566f,-0.3466273f,-0.9666468f,-0.1809613f,-0.1775346f,0.03644841f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 4.416756f);
Get(0x6EC6).SetLocalPose(0.1701571f,0.833168f,-0.4653086f,-0.1247777f,-0.1341307f,-0.9780877f,0.09891453f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321554f,1.538084f,0.4831351f,-0.6545135f,-0.2082212f,-0.2499482f,0.6824823f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 4.434259f);
Get(0x6E70).SetLocalPose(-0.1233069f,1.682623f,-0.4874329f,0.458874f,-0.4662744f,-0.5250287f,0.5443966f);
Get(0x6E82).SetLocalPose(-0.3255679f,1.551913f,-0.3401742f,-0.9589953f,-0.2157984f,-0.1648362f,0.08116803f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 4.434259f);
Get(0x6EC6).SetLocalPose(0.1703744f,0.8327911f,-0.465128f,-0.1249827f,-0.1341765f,-0.978054f,0.09892631f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321591f,1.538098f,0.4831783f,-0.6545129f,-0.2082351f,-0.2499415f,0.682481f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 4.458107f);
Get(0x6E70).SetLocalPose(-0.1228812f,1.683018f,-0.487789f,0.4587562f,-0.4668448f,-0.5253396f,0.5437068f);
Get(0x6E82).SetLocalPose(-0.3408433f,1.556969f,-0.3293184f,-0.9482287f,-0.2378973f,-0.1749544f,0.1168683f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 4.458107f);
Get(0x6EC6).SetLocalPose(0.17068f,0.832298f,-0.4649701f,-0.1249637f,-0.1341553f,-0.9780579f,0.09894021f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321622f,1.538128f,0.4830969f,-0.6544928f,-0.2082381f,-0.2499404f,0.6824998f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 4.476728f);
Get(0x6E70).SetLocalPose(-0.12336f,1.683332f,-0.4878686f,0.4582744f,-0.467391f,-0.5257758f,0.5432221f);
Get(0x6E82).SetLocalPose(-0.3485034f,1.5572f,-0.3230053f,-0.9418093f,-0.2437494f,-0.1946162f,0.1253242f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 4.476728f);
Get(0x6EC6).SetLocalPose(0.1707489f,0.8320162f,-0.4649268f,-0.1246547f,-0.1339377f,-0.9781325f,0.09888747f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321478f,1.538023f,0.4831166f,-0.6545085f,-0.2082323f,-0.2499401f,0.6824865f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 4.499941f);
Get(0x6E70).SetLocalPose(-0.12314f,1.683495f,-0.4880327f,0.4572775f,-0.4679456f,-0.5262783f,0.543098f);
Get(0x6E82).SetLocalPose(-0.3548423f,1.555035f,-0.3184523f,-0.9368361f,-0.2429129f,-0.2199747f,0.1222399f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 4.499941f);
Get(0x6EC6).SetLocalPose(0.1706538f,0.8321547f,-0.4649102f,-0.124241f,-0.133712f,-0.9782214f,0.09883394f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321418f,1.538108f,0.4832616f,-0.654499f,-0.2082243f,-0.2499603f,0.6824907f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 4.519316f);
Get(0x6E70).SetLocalPose(-0.1225985f,1.683767f,-0.4882354f,0.4565254f,-0.4681326f,-0.5264388f,0.5434139f);
Get(0x6E82).SetLocalPose(-0.3583118f,1.551725f,-0.3147188f,-0.935105f,-0.2374291f,-0.2354035f,0.1174359f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 4.519316f);
Get(0x6EC6).SetLocalPose(0.1705893f,0.8322218f,-0.4654012f,-0.1236247f,-0.1336703f,-0.9782971f,0.09891447f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321406f,1.538058f,0.4832188f,-0.6545116f,-0.2082131f,-0.2499518f,0.6824852f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 4.536821f);
Get(0x6E70).SetLocalPose(-0.1223021f,1.683868f,-0.488233f,0.4557306f,-0.4682194f,-0.5264629f,0.5439826f);
Get(0x6E82).SetLocalPose(-0.3607131f,1.549138f,-0.3109631f,-0.934548f,-0.2324822f,-0.2416311f,0.1191078f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 4.536821f);
Get(0x6EC6).SetLocalPose(0.1703579f,0.8323162f,-0.4657717f,-0.1230377f,-0.133741f,-0.9783483f,0.09904367f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321469f,1.53814f,0.4831594f,-0.6545191f,-0.2082224f,-0.249949f,0.6824762f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 4.554976f);
Get(0x6E70).SetLocalPose(-0.1221249f,1.684088f,-0.488398f,0.4550974f,-0.4680862f,-0.5265337f,0.5445585f);
Get(0x6E82).SetLocalPose(-0.362899f,1.544909f,-0.3049384f,-0.9342905f,-0.2262924f,-0.2431551f,0.1294939f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 4.554976f);
Get(0x6EC6).SetLocalPose(0.1704081f,0.8325502f,-0.4659472f,-0.1221961f,-0.1337985f,-0.9784288f,0.09921296f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321411f,1.537957f,0.4831477f,-0.654524f,-0.208223f,-0.2499711f,0.6824632f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 4.57925f);
Get(0x6E70).SetLocalPose(-0.1223178f,1.683754f,-0.4881613f,0.4545234f,-0.4678536f,-0.5266694f,0.5451063f);
Get(0x6E82).SetLocalPose(-0.3655288f,1.539348f,-0.2967381f,-0.9324976f,-0.2189073f,-0.2447287f,0.1504515f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 4.57925f);
Get(0x6EC6).SetLocalPose(0.1698032f,0.8334026f,-0.4664281f,-0.1212583f,-0.1337243f,-0.9785427f,0.09934078f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321363f,1.537987f,0.4832648f,-0.6545212f,-0.2082169f,-0.2499655f,0.6824697f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 4.596241f);
Get(0x6E70).SetLocalPose(-0.1221852f,1.683727f,-0.4881337f,0.4543575f,-0.4676201f,-0.5267353f,0.5453811f);
Get(0x6E82).SetLocalPose(-0.3654143f,1.53723f,-0.2893802f,-0.9303147f,-0.213744f,-0.2469572f,0.1668543f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 4.596241f);
Get(0x6EC6).SetLocalPose(0.1692693f,0.8340852f,-0.4667987f,-0.1204943f,-0.1335706f,-0.978651f,0.0994103f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321432f,1.538055f,0.483255f,-0.6545193f,-0.2082019f,-0.2499518f,0.6824813f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 4.613269f);
Get(0x6E70).SetLocalPose(-0.1223935f,1.683721f,-0.4882914f,0.4543854f,-0.4673471f,-0.5267994f,0.54553f);
Get(0x6E82).SetLocalPose(-0.3658083f,1.529411f,-0.2820754f,-0.9269839f,-0.2074677f,-0.2496971f,0.1879078f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 4.613269f);
Get(0x6EC6).SetLocalPose(0.1690958f,0.8335266f,-0.4664516f,-0.1194949f,-0.1333823f,-0.9787927f,0.09947381f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321531f,1.538119f,0.4832453f,-0.6545209f,-0.2082061f,-0.2499775f,0.682469f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 4.637445f);
Get(0x6E70).SetLocalPose(-0.1228545f,1.683432f,-0.4881448f,0.4547377f,-0.467132f,-0.5267348f,0.5454831f);
Get(0x6E82).SetLocalPose(-0.3697574f,1.517198f,-0.2716889f,-0.9215486f,-0.1988586f,-0.2505166f,0.2201021f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 4.637445f);
Get(0x6EC6).SetLocalPose(0.1684571f,0.8329684f,-0.4664186f,-0.1184326f,-0.1330567f,-0.9789641f,0.09949305f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321231f,1.538065f,0.4833459f,-0.6545361f,-0.2081923f,-0.2499601f,0.682465f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 4.653818f);
Get(0x6E70).SetLocalPose(-0.1227895f,1.683289f,-0.4880213f,0.4551431f,-0.4670011f,-0.526566f,0.5454201f);
Get(0x6E82).SetLocalPose(-0.3716803f,1.508657f,-0.2630725f,-0.9158213f,-0.192665f,-0.2535028f,0.2447204f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 4.653818f);
Get(0x6EC6).SetLocalPose(0.1682432f,0.832924f,-0.4670215f,-0.1177229f,-0.1329161f,-0.9790741f,0.09944166f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321246f,1.538135f,0.4832556f,-0.6545344f,-0.208216f,-0.249941f,0.6824663f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 4.673251f);
Get(0x6E70).SetLocalPose(-0.1228536f,1.683219f,-0.4880489f,0.4556404f,-0.4668846f,-0.5263215f,0.5453405f);
Get(0x6E82).SetLocalPose(-0.3746864f,1.498056f,-0.254011f,-0.9081021f,-0.1873432f,-0.2604343f,0.2691228f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 4.673251f);
Get(0x6EC6).SetLocalPose(0.1683958f,0.8326877f,-0.4668767f,-0.1168078f,-0.1329484f,-0.9791865f,0.09937048f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321342f,1.53796f,0.4830603f,-0.6545443f,-0.2082148f,-0.2499306f,0.6824611f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 4.699915f);
Get(0x6E70).SetLocalPose(-0.1231906f,1.683711f,-0.488065f,0.4561901f,-0.4668226f,-0.525893f,0.5453475f);
Get(0x6E82).SetLocalPose(-0.3791169f,1.478294f,-0.2380508f,-0.8931575f,-0.1800513f,-0.2717348f,0.3098571f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 4.699915f);
Get(0x6EC6).SetLocalPose(0.1680967f,0.8323451f,-0.4670187f,-0.1155151f,-0.1332036f,-0.9792994f,0.09942756f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321234f,1.538064f,0.4831036f,-0.6545287f,-0.2082037f,-0.2499582f,0.6824692f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 4.716065f);
Get(0x6E70).SetLocalPose(-0.1236319f,1.68326f,-0.4877942f,0.4564579f,-0.4669007f,-0.5254713f,0.545463f);
Get(0x6E82).SetLocalPose(-0.3822118f,1.465365f,-0.2292795f,-0.8835276f,-0.1770297f,-0.2740157f,0.3360874f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 4.716065f);
Get(0x6EC6).SetLocalPose(0.1677987f,0.8321938f,-0.4668272f,-0.1152809f,-0.1333972f,-0.9793023f,0.09941109f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321396f,1.53805f,0.4830765f,-0.6545435f,-0.2081804f,-0.2499395f,0.682469f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 4.73317f);
Get(0x6E70).SetLocalPose(-0.1239154f,1.683685f,-0.4877235f,0.4565025f,-0.4669712f,-0.5252332f,0.5455946f);
Get(0x6E82).SetLocalPose(-0.3860154f,1.450473f,-0.2205329f,-0.8727667f,-0.1738957f,-0.2738154f,0.364779f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 4.73317f);
Get(0x6EC6).SetLocalPose(0.1676558f,0.8324493f,-0.466516f,-0.1144143f,-0.1338905f,-0.9793221f,0.09955295f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321516f,1.538011f,0.4829656f,-0.6545236f,-0.2081768f,-0.2499439f,0.6824877f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 4.758656f);
Get(0x6E70).SetLocalPose(-0.1244436f,1.684515f,-0.487516f,0.4564923f,-0.4670733f,-0.5246497f,0.546077f);
Get(0x6E82).SetLocalPose(-0.3917908f,1.425451f,-0.2058799f,-0.8538651f,-0.1692146f,-0.2708659f,0.4109895f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 4.758656f);
Get(0x6EC6).SetLocalPose(0.1673985f,0.8328906f,-0.4661861f,-0.1134505f,-0.1344476f,-0.9793425f,0.09970567f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321544f,1.538065f,0.4829916f,-0.6545138f,-0.2082012f,-0.2499233f,0.6824971f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 4.776021f);
Get(0x6E70).SetLocalPose(-0.1244532f,1.68449f,-0.4871854f,0.4563465f,-0.4670202f,-0.5244499f,0.5464361f);
Get(0x6E82).SetLocalPose(-0.3959004f,1.40314f,-0.1942807f,-0.835827f,-0.1672672f,-0.263672f,0.4515441f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 4.776021f);
Get(0x6EC6).SetLocalPose(0.1668435f,0.8336039f,-0.4663162f,-0.1130825f,-0.134506f,-0.9793716f,0.09975878f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321554f,1.538009f,0.4831207f,-0.6545478f,-0.2081999f,-0.2499106f,0.6824697f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 4.794194f);
Get(0x6E70).SetLocalPose(-0.1243436f,1.684292f,-0.4868887f,0.4559979f,-0.4669003f,-0.5244969f,0.5467843f);
Get(0x6E82).SetLocalPose(-0.3992952f,1.382794f,-0.1862138f,-0.8184115f,-0.1674895f,-0.253268f,0.4878578f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 4.794194f);
Get(0x6EC6).SetLocalPose(0.1666228f,0.834604f,-0.4664926f,-0.112689f,-0.134277f,-0.9794455f,0.09978674f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321621f,1.538166f,0.4831664f,-0.6545443f,-0.2081911f,-0.2499128f,0.6824749f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 4.812226f);
Get(0x6E70).SetLocalPose(-0.1244379f,1.683897f,-0.4867156f,0.4554999f,-0.4666762f,-0.5245973f,0.5472941f);
Get(0x6E82).SetLocalPose(-0.4020108f,1.359074f,-0.1788218f,-0.798142f,-0.169253f,-0.2403944f,0.5258645f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 4.812226f);
Get(0x6EC6).SetLocalPose(0.166175f,0.8353578f,-0.4665582f,-0.1123904f,-0.1338939f,-0.9795327f,0.0997825f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321665f,1.538171f,0.4831156f,-0.6545402f,-0.2082298f,-0.2498971f,0.6824726f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 4.838726f);
Get(0x6E70).SetLocalPose(-0.1244726f,1.68407f,-0.4864027f,0.454734f,-0.4662933f,-0.5247601f,0.5481007f);
Get(0x6E82).SetLocalPose(-0.4045944f,1.321646f,-0.1708735f,-0.7685798f,-0.1702229f,-0.2224354f,0.5751798f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 4.838726f);
Get(0x6EC6).SetLocalPose(0.1658873f,0.8367982f,-0.467036f,-0.1117283f,-0.1331083f,-0.9796999f,0.09993497f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32172f,1.538083f,0.4831112f,-0.6545396f,-0.208219f,-0.2498972f,0.6824765f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 4.857311f);
Get(0x6E70).SetLocalPose(-0.1246561f,1.68387f,-0.4859728f,0.4539545f,-0.4661122f,-0.5249487f,0.5487201f);
Get(0x6E82).SetLocalPose(-0.4047716f,1.299316f,-0.1677591f,-0.7494804f,-0.1658913f,-0.2155925f,0.6035554f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 4.857311f);
Get(0x6EC6).SetLocalPose(0.1660368f,0.836251f,-0.4676093f,-0.1111367f,-0.1327827f,-0.9797641f,0.100398f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321625f,1.538107f,0.4832245f,-0.6545399f,-0.2081914f,-0.2498917f,0.6824867f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 4.875501f);
Get(0x6E70).SetLocalPose(-0.124809f,1.684f,-0.4857818f,0.4531503f,-0.4659383f,-0.5251937f,0.5492977f);
Get(0x6E82).SetLocalPose(-0.4038934f,1.275978f,-0.1659065f,-0.7295427f,-0.159927f,-0.2113817f,0.6304829f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 4.875501f);
Get(0x6EC6).SetLocalPose(0.1661507f,0.8363842f,-0.46774f,-0.1108999f,-0.1326783f,-0.9797841f,0.1006027f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321546f,1.538068f,0.483273f,-0.6545303f,-0.208198f,-0.2499129f,0.6824861f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 4.894369f);
Get(0x6E70).SetLocalPose(-0.1254828f,1.684643f,-0.4850502f,0.4521808f,-0.4657024f,-0.5254322f,0.550068f);
Get(0x6E82).SetLocalPose(-0.4013273f,1.24166f,-0.1657005f,-0.7009884f,-0.1521474f,-0.2072623f,0.6652135f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 4.894369f);
Get(0x6EC6).SetLocalPose(0.1669755f,0.8363067f,-0.4686345f,-0.1099567f,-0.1322381f,-0.9798244f,0.1018177f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321634f,1.538131f,0.4831515f,-0.6545227f,-0.2081936f,-0.249903f,0.6824983f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 4.910793f);
Get(0x6E70).SetLocalPose(-0.1260729f,1.684872f,-0.484144f,0.4509568f,-0.4654964f,-0.5257272f,0.5509647f);
Get(0x6E82).SetLocalPose(-0.3992822f,1.217787f,-0.1670047f,-0.6798793f,-0.1489011f,-0.2048381f,0.6882108f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 4.910793f);
Get(0x6EC6).SetLocalPose(0.1681968f,0.8363492f,-0.4695784f,-0.109187f,-0.131548f,-0.9798442f,0.1033385f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321655f,1.538179f,0.4831536f,-0.6545131f,-0.2082115f,-0.2499185f,0.6824964f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 4.92763f);
Get(0x6E70).SetLocalPose(-0.1267396f,1.685296f,-0.4832532f,0.4497686f,-0.4655021f,-0.5260492f,0.5516233f);
Get(0x6E82).SetLocalPose(-0.395646f,1.182541f,-0.1711541f,-0.6461514f,-0.1455413f,-0.1997573f,0.7220826f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 4.92763f);
Get(0x6EC6).SetLocalPose(0.1689722f,0.8359011f,-0.4705088f,-0.1087029f,-0.1306325f,-0.9798661f,0.1047908f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32162f,1.538248f,0.4831276f,-0.65452f,-0.2082213f,-0.2499073f,0.6824909f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 4.950454f);
Get(0x6E70).SetLocalPose(-0.1274404f,1.685461f,-0.482399f,0.4488001f,-0.4657399f,-0.5264058f,0.5518712f);
Get(0x6E82).SetLocalPose(-0.3929835f,1.159331f,-0.1744967f,-0.6209756f,-0.1413961f,-0.1957833f,0.7456979f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 4.950454f);
Get(0x6EC6).SetLocalPose(0.1694537f,0.8361166f,-0.4711844f,-0.1085247f,-0.1298342f,-0.9798915f,0.1057268f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321655f,1.538176f,0.4830054f,-0.654506f,-0.2082339f,-0.2499017f,0.6825026f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 4.978783f);
Get(0x6E70).SetLocalPose(-0.1279939f,1.685851f,-0.4817234f,0.4479332f,-0.4658369f,-0.5269502f,0.5519741f);
Get(0x6E82).SetLocalPose(-0.3874329f,1.122135f,-0.1816982f,-0.5769333f,-0.1295971f,-0.186958f,0.784474f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 4.978783f);
Get(0x6EC6).SetLocalPose(0.170444f,0.8356025f,-0.4721834f,-0.1084308f,-0.1286385f,-0.9799163f,0.1070461f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 4.978783f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 4.978783f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321506f,1.538111f,0.483106f,-0.6545289f,-0.2082126f,-0.2499281f,0.6824775f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 5.015145f);
Get(0x6E70).SetLocalPose(-0.1289849f,1.685832f,-0.4807014f,0.4470461f,-0.4650893f,-0.5282651f,0.5520669f);
Get(0x6E82).SetLocalPose(-0.3781081f,1.070506f,-0.1962668f,-0.5022601f,-0.1192619f,-0.1652945f,0.8403506f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 5.015145f);
Get(0x6EC6).SetLocalPose(0.1720515f,0.8355196f,-0.4736136f,-0.1085705f,-0.1265013f,-0.9799368f,0.1092414f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321423f,1.537998f,0.483094f,-0.6545292f,-0.2081768f,-0.2499342f,0.6824858f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 5.036304f);
Get(0x6E70).SetLocalPose(-0.1295653f,1.685604f,-0.4799613f,0.4467543f,-0.4643463f,-0.5290031f,0.5522218f);
Get(0x6E82).SetLocalPose(-0.3709154f,1.038931f,-0.2084481f,-0.4567869f,-0.1162641f,-0.1557021f,0.8680929f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 5.036304f);
Get(0x6EC6).SetLocalPose(0.1722246f,0.8357576f,-0.4743089f,-0.1088806f,-0.1253766f,-0.9799411f,0.1101878f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321516f,1.537909f,0.4829938f,-0.6545396f,-0.2081685f,-0.2499452f,0.6824743f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 5.04853f);
Get(0x6E70).SetLocalPose(-0.1299328f,1.685616f,-0.4796053f,0.4466936f,-0.4637251f,-0.5293363f,0.5524735f);
Get(0x6E82).SetLocalPose(-0.3643435f,1.015842f,-0.2191096f,-0.4229929f,-0.1116439f,-0.1521227f,0.8862682f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 5.04853f);
Get(0x6EC6).SetLocalPose(0.1723107f,0.8360283f,-0.4749077f,-0.1095014f,-0.1241576f,-0.9799395f,0.1109639f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321459f,1.537855f,0.4828881f,-0.6545303f,-0.2081647f,-0.2499464f,0.682484f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 5.073769f);
Get(0x6E70).SetLocalPose(-0.1303951f,1.685642f,-0.4791895f,0.446656f,-0.4627375f,-0.5295952f,0.5530835f);
Get(0x6E82).SetLocalPose(-0.3531431f,0.9835266f,-0.2367426f,-0.377913f,-0.09824865f,-0.150233f,0.9082726f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 5.073769f);
Get(0x6EC6).SetLocalPose(0.1725421f,0.8359499f,-0.4754247f,-0.110757f,-0.1231282f,-0.9798378f,0.1117604f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321465f,1.537928f,0.4828396f,-0.6545169f,-0.2081858f,-0.2499326f,0.6824954f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 5.096441f);
Get(0x6E70).SetLocalPose(-0.1309799f,1.685695f,-0.4787272f,0.446437f,-0.4620013f,-0.5297347f,0.5537419f);
Get(0x6E82).SetLocalPose(-0.341727f,0.9551747f,-0.2548744f,-0.3373536f,-0.0811922f,-0.1490396f,0.9259523f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 5.096441f);
Get(0x6EC6).SetLocalPose(0.1735354f,0.8349742f,-0.475938f,-0.1119094f,-0.1224843f,-0.9797007f,0.1125185f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321433f,1.537965f,0.4829822f,-0.6545277f,-0.2081991f,-0.2499458f,0.6824762f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 5.1172f);
Get(0x6E70).SetLocalPose(-0.1313317f,1.685875f,-0.4782789f,0.446333f,-0.4615206f,-0.5295923f,0.5543623f);
Get(0x6E82).SetLocalPose(-0.3286182f,0.9269142f,-0.2758864f,-0.2930818f,-0.06306802f,-0.1445651f,0.942988f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 5.1172f);
Get(0x6EC6).SetLocalPose(0.1744197f,0.8350999f,-0.4762542f,-0.113811f,-0.1218527f,-0.9794392f,0.1135689f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321296f,1.537919f,0.4830036f,-0.654534f,-0.2081786f,-0.2499493f,0.6824751f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 5.137328f);
Get(0x6E70).SetLocalPose(-0.1315436f,1.685106f,-0.4779089f,0.4462649f,-0.461017f,-0.5292752f,0.5551385f);
Get(0x6E82).SetLocalPose(-0.3151599f,0.9009026f,-0.2982762f,-0.2471676f,-0.04354065f,-0.1325157f,0.9588805f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 5.137328f);
Get(0x6EC6).SetLocalPose(0.1739952f,0.8358574f,-0.477071f,-0.1156188f,-0.1215514f,-0.9791957f,0.1141641f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321362f,1.537963f,0.483032f,-0.6545298f,-0.2081597f,-0.2499508f,0.6824844f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 5.157916f);
Get(0x6E70).SetLocalPose(-0.1319037f,1.684228f,-0.4774045f,0.4463693f,-0.460428f,-0.5287993f,0.5559964f);
Get(0x6E82).SetLocalPose(-0.3065475f,0.8856799f,-0.3128321f,-0.2171854f,-0.02966022f,-0.1231107f,0.9678815f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 5.157916f);
Get(0x6EC6).SetLocalPose(0.1739959f,0.8357209f,-0.4778161f,-0.1177232f,-0.1212346f,-0.9789732f,0.1142582f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321209f,1.538071f,0.4830688f,-0.6545278f,-0.2081761f,-0.2499487f,0.682482f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 5.178211f);
Get(0x6E70).SetLocalPose(-0.1323843f,1.683744f,-0.4769515f,0.4465297f,-0.4598252f,-0.5283847f,0.5567601f);
Get(0x6E82).SetLocalPose(-0.2931837f,0.8634844f,-0.3372481f,-0.1672196f,-0.01369792f,-0.1093654f,0.9797394f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 5.178211f);
Get(0x6EC6).SetLocalPose(0.1737616f,0.8359108f,-0.4781109f,-0.1196466f,-0.1212004f,-0.9787582f,0.1141388f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321304f,1.538124f,0.483044f,-0.6545123f,-0.2081734f,-0.2499312f,0.6825042f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 5.198058f);
Get(0x6E70).SetLocalPose(-0.1330262f,1.684193f,-0.4763923f,0.4465274f,-0.4592872f,-0.5280494f,0.5575234f);
Get(0x6E82).SetLocalPose(-0.28392f,0.8485838f,-0.3561565f,-0.1318382f,-0.01225297f,-0.1024459f,0.9858872f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 5.198058f);
Get(0x6EC6).SetLocalPose(0.1733581f,0.8353481f,-0.4787418f,-0.1209786f,-0.1215842f,-0.9785429f,0.1141725f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321436f,1.537998f,0.4829945f,-0.6545004f,-0.2081831f,-0.2499249f,0.682515f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 5.217667f);
Get(0x6E70).SetLocalPose(-0.1334418f,1.684997f,-0.4759694f,0.4463758f,-0.4588027f,-0.5276886f,0.5583846f);
Get(0x6E82).SetLocalPose(-0.2749679f,0.836507f,-0.3733014f,-0.1036136f,-0.01231027f,-0.09645238f,0.9898533f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 5.217667f);
Get(0x6EC6).SetLocalPose(0.1729692f,0.8343536f,-0.479773f,-0.1221522f,-0.1219656f,-0.9783493f,0.114175f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321542f,1.53804f,0.4829438f,-0.6544983f,-0.2081818f,-0.2499108f,0.6825225f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 5.238934f);
Get(0x6E70).SetLocalPose(-0.1338181f,1.685043f,-0.4757128f,0.4463242f,-0.4584078f,-0.5273319f,0.5590869f);
Get(0x6E82).SetLocalPose(-0.2651608f,0.8251962f,-0.3919835f,-0.073398f,-0.008724669f,-0.08704508f,0.9934585f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 5.238934f);
Get(0x6EC6).SetLocalPose(0.1724509f,0.8342319f,-0.4803888f,-0.12299f,-0.1219926f,-0.9782634f,0.1139823f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321543f,1.538088f,0.4830264f,-0.6545115f,-0.2082129f,-0.2499147f,0.6824989f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 5.25873f);
Get(0x6E70).SetLocalPose(-0.1343669f,1.684715f,-0.4749532f,0.4465545f,-0.4579604f,-0.526883f,0.5596925f);
Get(0x6E82).SetLocalPose(-0.2581917f,0.8182032f,-0.4048406f,-0.05669057f,-0.01214132f,-0.07851228f,0.9952259f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 5.25873f);
Get(0x6EC6).SetLocalPose(0.1722338f,0.8345486f,-0.4807996f,-0.1241743f,-0.1216643f,-0.9782149f,0.1134651f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321594f,1.538025f,0.4828788f,-0.6545029f,-0.2082071f,-0.2499251f,0.6825051f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 5.278205f);
Get(0x6E70).SetLocalPose(-0.134801f,1.684496f,-0.4746681f,0.4470797f,-0.4574915f,-0.5265253f,0.5599931f);
Get(0x6E82).SetLocalPose(-0.2536671f,0.8158f,-0.4132666f,-0.04746913f,-0.02167607f,-0.07112002f,0.9961018f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 5.278205f);
Get(0x6EC6).SetLocalPose(0.1720997f,0.8341855f,-0.4807064f,-0.1247796f,-0.121295f,-0.9782219f,0.113135f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321638f,1.53806f,0.4830185f,-0.6544982f,-0.2082144f,-0.2499266f,0.6825069f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 5.290917f);
Get(0x6E70).SetLocalPose(-0.1355183f,1.683977f,-0.4744973f,0.4474667f,-0.4572926f,-0.5262892f,0.5600685f);
Get(0x6E82).SetLocalPose(-0.2503098f,0.8142225f,-0.419962f,-0.04275263f,-0.03246349f,-0.06536817f,0.9964163f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 5.290917f);
Get(0x6EC6).SetLocalPose(0.172595f,0.8352749f,-0.4797975f,-0.1255154f,-0.1206026f,-0.9782308f,0.112985f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321719f,1.538077f,0.4829361f,-0.654483f,-0.2082121f,-0.2499543f,0.682512f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 5.315497f);
Get(0x6E70).SetLocalPose(-0.1362633f,1.683623f,-0.4739808f,0.4484055f,-0.456969f,-0.5255707f,0.5602566f);
Get(0x6E82).SetLocalPose(-0.2459762f,0.8127398f,-0.4279791f,-0.03833476f,-0.05016048f,-0.05823965f,0.9963045f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 5.315497f);
Get(0x6EC6).SetLocalPose(0.1733636f,0.8360715f,-0.4791269f,-0.1264673f,-0.1198667f,-0.9781547f,0.1133644f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321677f,1.537953f,0.4829361f,-0.6544996f,-0.2082609f,-0.2499289f,0.6824905f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 5.335893f);
Get(0x6E70).SetLocalPose(-0.1371068f,1.683601f,-0.4737507f,0.4493035f,-0.4567363f,-0.5247987f,0.5604505f);
Get(0x6E82).SetLocalPose(-0.2446671f,0.8124219f,-0.4318822f,-0.03272685f,-0.07371207f,-0.05287945f,0.9953388f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 5.335893f);
Get(0x6EC6).SetLocalPose(0.1735006f,0.8362251f,-0.4786931f,-0.1266906f,-0.1195696f,-0.978107f,0.1138393f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321561f,1.538066f,0.4831689f,-0.6544994f,-0.2082684f,-0.2499418f,0.6824838f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 5.356795f);
Get(0x6E70).SetLocalPose(-0.1378288f,1.682625f,-0.473571f,0.4506328f,-0.4564543f,-0.5237338f,0.5606091f);
Get(0x6E82).SetLocalPose(-0.2457008f,0.8126284f,-0.4337929f,-0.02573898f,-0.1158772f,-0.04441135f,0.9919363f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 5.356795f);
Get(0x6EC6).SetLocalPose(0.1739783f,0.8359088f,-0.4776537f,-0.1263186f,-0.1193157f,-0.9781263f,0.1143525f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321566f,1.538131f,0.4829822f,-0.654493f,-0.208237f,-0.2499497f,0.6824965f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 5.377816f);
Get(0x6E70).SetLocalPose(-0.1390782f,1.682061f,-0.4735208f,0.4517498f,-0.4562813f,-0.5229822f,0.5605525f);
Get(0x6E82).SetLocalPose(-0.2482617f,0.812611f,-0.4339357f,-0.02612956f,-0.133325f,-0.03818642f,0.9899917f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 5.377816f);
Get(0x6EC6).SetLocalPose(0.1743442f,0.8356904f,-0.4769687f,-0.1255995f,-0.1191729f,-0.9782046f,0.114623f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321509f,1.538137f,0.4831023f,-0.6545016f,-0.2082284f,-0.2499351f,0.6824962f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 5.398433f);
Get(0x6E70).SetLocalPose(-0.1400293f,1.681678f,-0.4734223f,0.4531693f,-0.4561057f,-0.5220618f,0.5604075f);
Get(0x6E82).SetLocalPose(-0.2495773f,0.8131465f,-0.4339255f,-0.02955002f,-0.1310111f,-0.03652587f,0.990267f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 5.398433f);
Get(0x6EC6).SetLocalPose(0.1744023f,0.835394f,-0.4762172f,-0.1248039f,-0.1191591f,-0.9782856f,0.1148154f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321419f,1.53812f,0.4831132f,-0.6544931f,-0.2082113f,-0.249944f,0.6825063f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 5.419507f);
Get(0x6E70).SetLocalPose(-0.1410018f,1.681594f,-0.4733463f,0.4542297f,-0.4560481f,-0.5215537f,0.560069f);
Get(0x6E82).SetLocalPose(-0.2512666f,0.8149052f,-0.4332184f,-0.03267965f,-0.1193469f,-0.03183449f,0.9918039f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 5.419507f);
Get(0x6EC6).SetLocalPose(0.1744945f,0.8348439f,-0.4756379f,-0.1233341f,-0.1194103f,-0.9784108f,0.1150744f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321393f,1.538095f,0.4831353f,-0.6544889f,-0.2081889f,-0.2499431f,0.6825175f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 5.429022f);
Get(0x6E70).SetLocalPose(-0.1415197f,1.681323f,-0.4734091f,0.4549468f,-0.4560128f,-0.5213105f,0.559742f);
Get(0x6E82).SetLocalPose(-0.2518728f,0.8161181f,-0.4330964f,-0.0308809f,-0.1145144f,-0.02706902f,0.9925725f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 5.429022f);
Get(0x6EC6).SetLocalPose(0.1740912f,0.8347546f,-0.475366f,-0.1224327f,-0.1196031f,-0.9784859f,0.1151983f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321402f,1.538098f,0.4830384f,-0.6545148f,-0.2081842f,-0.2499674f,0.6824852f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 5.451527f);
Get(0x6E70).SetLocalPose(-0.1419996f,1.680966f,-0.4737732f,0.4559566f,-0.4558998f,-0.5210761f,0.5592304f);
Get(0x6E82).SetLocalPose(-0.2520544f,0.8175717f,-0.4316688f,-0.02651318f,-0.1059754f,-0.01802769f,0.9938517f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 5.451527f);
Get(0x6EC6).SetLocalPose(0.173822f,0.8349202f,-0.4750238f,-0.1203366f,-0.1199932f,-0.9786754f,0.1153926f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321401f,1.538038f,0.4830166f,-0.6545216f,-0.2082049f,-0.2499498f,0.6824789f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 5.472294f);
Get(0x6E70).SetLocalPose(-0.1425718f,1.680586f,-0.4737948f,0.4569967f,-0.4557636f,-0.5208536f,0.5586994f);
Get(0x6E82).SetLocalPose(-0.2518293f,0.8182955f,-0.430468f,-0.02349421f,-0.09983189f,-0.01188735f,0.9946559f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 5.472294f);
Get(0x6EC6).SetLocalPose(0.1731373f,0.834987f,-0.4738864f,-0.1172535f,-0.1209646f,-0.9788777f,0.1158348f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321451f,1.538038f,0.4829935f,-0.6545084f,-0.2082346f,-0.2499486f,0.6824828f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 5.492229f);
Get(0x6E70).SetLocalPose(-0.1428053f,1.680477f,-0.4739273f,0.4574922f,-0.4557501f,-0.5208296f,0.5583273f);
Get(0x6E82).SetLocalPose(-0.2524273f,0.819061f,-0.4294468f,-0.02183197f,-0.09631509f,-0.008974297f,0.9950709f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 5.492229f);
Get(0x6EC6).SetLocalPose(0.172938f,0.8344503f,-0.4730809f,-0.1146719f,-0.1220498f,-0.9789857f,0.1163667f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321464f,1.537997f,0.4830175f,-0.654514f,-0.2082126f,-0.2499249f,0.6824929f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 5.513568f);
Get(0x6E70).SetLocalPose(-0.1423461f,1.680816f,-0.4744744f,0.457894f,-0.4559204f,-0.5208279f,0.5578602f);
Get(0x6E82).SetLocalPose(-0.2524456f,0.8190716f,-0.42896f,-0.02108857f,-0.09386662f,-0.008455677f,0.9953255f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 5.513568f);
Get(0x6EC6).SetLocalPose(0.1724984f,0.8346631f,-0.471384f,-0.1096997f,-0.123867f,-0.9792772f,0.1167868f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321502f,1.537873f,0.4831059f,-0.6545352f,-0.2082117f,-0.2499408f,0.6824669f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 5.533988f);
Get(0x6E70).SetLocalPose(-0.1425813f,1.681311f,-0.4747214f,0.4578021f,-0.4562125f,-0.5208784f,0.5576496f);
Get(0x6E82).SetLocalPose(-0.2528184f,0.8184556f,-0.4278703f,-0.02085723f,-0.09318249f,-0.009071027f,0.9953893f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 5.533988f);
Get(0x6EC6).SetLocalPose(0.1721823f,0.8352236f,-0.4693377f,-0.1030041f,-0.1268982f,-0.9795326f,0.117486f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321528f,1.537788f,0.4830658f,-0.6545154f,-0.2081994f,-0.2499405f,0.6824899f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 5.553315f);
Get(0x6E70).SetLocalPose(-0.1428048f,1.681114f,-0.4749798f,0.4576632f,-0.4564529f,-0.520812f,0.5576289f);
Get(0x6E82).SetLocalPose(-0.2526834f,0.8182217f,-0.4269992f,-0.02070893f,-0.09246664f,-0.009769616f,0.9954525f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 5.553315f);
Get(0x6EC6).SetLocalPose(0.17174f,0.8359705f,-0.4669285f,-0.09244262f,-0.1350158f,-0.9793612f,0.1186458f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321469f,1.537789f,0.4831423f,-0.654521f,-0.2082082f,-0.249934f,0.6824841f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 5.574105f);
Get(0x6E70).SetLocalPose(-0.1430093f,1.681677f,-0.4746554f,0.457622f,-0.456556f,-0.520694f,0.5576886f);
Get(0x6E82).SetLocalPose(-0.2517649f,0.8172854f,-0.4269364f,-0.02187097f,-0.08984236f,-0.01189787f,0.9956447f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 5.574105f);
Get(0x6EC6).SetLocalPose(0.171799f,0.8385985f,-0.4638663f,-0.08129513f,-0.1444868f,-0.9788616f,0.1197695f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321439f,1.537978f,0.4830588f,-0.6545302f,-0.2081859f,-0.249935f,0.6824818f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 5.593817f);
Get(0x6E70).SetLocalPose(-0.1436921f,1.681579f,-0.4752488f,0.4575425f,-0.4567244f,-0.5205644f,0.5577369f);
Get(0x6E82).SetLocalPose(-0.2502771f,0.8162209f,-0.4277308f,-0.02407799f,-0.0857954f,-0.01470872f,0.9959132f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 5.593817f);
Get(0x6EC6).SetLocalPose(0.1723996f,0.841216f,-0.460199f,-0.06048559f,-0.1617217f,-0.9772584f,0.1231f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321362f,1.538188f,0.4832415f,-0.654515f,-0.208206f,-0.249928f,0.6824929f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 5.613908f);
Get(0x6E70).SetLocalPose(-0.1438637f,1.681453f,-0.4753717f,0.4573129f,-0.4568928f,-0.5205984f,0.5577556f);
Get(0x6E82).SetLocalPose(-0.2488133f,0.8147653f,-0.4278543f,-0.02639369f,-0.08188105f,-0.01737082f,0.9961411f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 5.613908f);
Get(0x6EC6).SetLocalPose(0.1745426f,0.8471979f,-0.4539914f,-0.02282777f,-0.1902697f,-0.9718246f,0.1372343f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321453f,1.538181f,0.4832401f,-0.6545239f,-0.2081882f,-0.249907f,0.6824974f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 5.634081f);
Get(0x6E70).SetLocalPose(-0.1444634f,1.681101f,-0.4754286f,0.4569191f,-0.4570826f,-0.5207672f,0.5577653f);
Get(0x6E82).SetLocalPose(-0.2470494f,0.8141485f,-0.4260846f,-0.02986446f,-0.076395f,-0.02120826f,0.9964046f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 5.634081f);
Get(0x6EC6).SetLocalPose(0.1774163f,0.85193f,-0.4469423f,0.01574827f,-0.218669f,-0.963103f,0.1561041f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321471f,1.538132f,0.483127f,-0.6545528f,-0.2081907f,-0.2499139f,0.6824663f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 5.654352f);
Get(0x6E70).SetLocalPose(-0.1452142f,1.680999f,-0.4752295f,0.4564859f,-0.4572989f,-0.5210109f,0.557715f);
Get(0x6E82).SetLocalPose(-0.2454599f,0.8154891f,-0.4252352f,-0.03340361f,-0.07001012f,-0.0257112f,0.9966553f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 5.654352f);
Get(0x6EC6).SetLocalPose(0.1818461f,0.8593329f,-0.4382648f,0.04891057f,-0.2507698f,-0.9507988f,0.1752253f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32141f,1.538008f,0.4830626f,-0.6545314f,-0.2081908f,-0.2499577f,0.6824709f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 5.674366f);
Get(0x6E70).SetLocalPose(-0.1456281f,1.681319f,-0.4752592f,0.4563843f,-0.4572788f,-0.5212381f,0.5576023f);
Get(0x6E82).SetLocalPose(-0.2440074f,0.8156263f,-0.4226622f,-0.03712853f,-0.06210726f,-0.03039092f,0.9969155f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 5.674366f);
Get(0x6EC6).SetLocalPose(0.189319f,0.8703353f,-0.4265611f,0.06485637f,-0.2833488f,-0.9375094f,0.1912677f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321458f,1.537962f,0.4830754f,-0.6545247f,-0.2081868f,-0.2499355f,0.6824866f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 5.693852f);
Get(0x6E70).SetLocalPose(-0.1462506f,1.681341f,-0.4751279f,0.4563937f,-0.4571778f,-0.521462f,0.5574681f);
Get(0x6E82).SetLocalPose(-0.2429092f,0.8161869f,-0.4213896f,-0.04054014f,-0.05438406f,-0.03420629f,0.9971102f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 5.693852f);
Get(0x6EC6).SetLocalPose(0.1996882f,0.8840565f,-0.4105558f,0.06261067f,-0.3170247f,-0.9236667f,0.2059493f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321476f,1.537956f,0.4829764f,-0.6545299f,-0.2081898f,-0.2499242f,0.6824849f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 5.713955f);
Get(0x6E70).SetLocalPose(-0.1466195f,1.681431f,-0.4749747f,0.4564179f,-0.4570382f,-0.5216368f,0.5573993f);
Get(0x6E82).SetLocalPose(-0.2424763f,0.8173369f,-0.4210345f,-0.0453039f,-0.0422915f,-0.03816231f,0.9973478f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 5.713955f);
Get(0x6EC6).SetLocalPose(0.20906f,0.8972399f,-0.3975832f,0.05450191f,-0.3431782f,-0.9121629f,0.2172949f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321448f,1.537919f,0.4829573f,-0.6545133f,-0.2081618f,-0.2499406f,0.6825033f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 5.733972f);
Get(0x6E70).SetLocalPose(-0.1466239f,1.681305f,-0.4751208f,0.4563252f,-0.4569292f,-0.5217904f,0.5574207f);
Get(0x6E82).SetLocalPose(-0.2410564f,0.8175242f,-0.4195199f,-0.04961054f,-0.02903023f,-0.04038689f,0.9975294f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 5.733972f);
Get(0x6EC6).SetLocalPose(0.2279952f,0.9272913f,-0.3725098f,0.03632117f,-0.3991598f,-0.8830979f,0.2439065f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321484f,1.538095f,0.4830661f,-0.6545182f,-0.2081421f,-0.2499454f,0.6825029f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 5.753923f);
Get(0x6E70).SetLocalPose(-0.1467823f,1.681431f,-0.4750975f,0.4563077f,-0.4567523f,-0.5219691f,0.5574128f);
Get(0x6E82).SetLocalPose(-0.2406955f,0.8167967f,-0.4195065f,-0.05188616f,-0.01863333f,-0.0416683f,0.9976094f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 5.753923f);
Get(0x6EC6).SetLocalPose(0.2428716f,0.9591367f,-0.352073f,0.02143347f,-0.4463507f,-0.853667f,0.2675151f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321468f,1.538134f,0.4831632f,-0.6545138f,-0.2081537f,-0.2499283f,0.6825098f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 5.774653f);
Get(0x6E70).SetLocalPose(-0.1464515f,1.681353f,-0.4750198f,0.4563292f,-0.4562703f,-0.5225051f,0.5572876f);
Get(0x6E82).SetLocalPose(-0.2403417f,0.8171005f,-0.4190851f,-0.05357875f,-0.007518525f,-0.04262606f,0.9976251f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 5.774653f);
Get(0x6EC6).SetLocalPose(0.25992f,0.9970468f,-0.3323966f,0.0008009964f,-0.496097f,-0.8184901f,0.2897606f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321428f,1.538262f,0.4832927f,-0.6545159f,-0.2081636f,-0.2499154f,0.6825095f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 5.794556f);
Get(0x6E70).SetLocalPose(-0.1459822f,1.680873f,-0.4747454f,0.4564873f,-0.4557152f,-0.5231833f,0.556976f);
Get(0x6E82).SetLocalPose(-0.2401904f,0.8183795f,-0.4194158f,-0.05452931f,0.001002462f,-0.04290528f,0.9975895f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 5.794556f);
Get(0x6EC6).SetLocalPose(0.2758712f,1.037466f,-0.3158789f,-0.02209691f,-0.5434731f,-0.7804153f,0.3083843f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321341f,1.538279f,0.4831133f,-0.6545171f,-0.2081944f,-0.2499171f,0.6824983f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 5.814813f);
Get(0x6E70).SetLocalPose(-0.1450298f,1.681482f,-0.4743195f,0.4565899f,-0.455053f,-0.5243559f,0.5563303f);
Get(0x6E82).SetLocalPose(-0.2402076f,0.8189519f,-0.419053f,-0.05514268f,0.008074908f,-0.04263826f,0.997535f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 5.814813f);
Get(0x6EC6).SetLocalPose(0.2906018f,1.083272f,-0.3022285f,-0.04383231f,-0.5919169f,-0.7355517f,0.3266144f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321329f,1.538126f,0.4831275f,-0.6545098f,-0.208198f,-0.2499375f,0.6824968f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 5.834731f);
Get(0x6E70).SetLocalPose(-0.1441938f,1.681354f,-0.4740317f,0.4564336f,-0.4543002f,-0.5259606f,0.5555585f);
Get(0x6E82).SetLocalPose(-0.2402881f,0.8200989f,-0.4190616f,-0.05512972f,0.01636597f,-0.04188757f,0.997466f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 5.834731f);
Get(0x6EC6).SetLocalPose(0.3026414f,1.131171f,-0.2936126f,-0.06241328f,-0.6403154f,-0.6844655f,0.34294f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321308f,1.53816f,0.4831379f,-0.654519f,-0.2081919f,-0.2499372f,0.68249f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 5.855072f);
Get(0x6E70).SetLocalPose(-0.143017f,1.680838f,-0.4735892f,0.4560075f,-0.4533367f,-0.5279924f,0.5547677f);
Get(0x6E82).SetLocalPose(-0.2400302f,0.8207457f,-0.4185544f,-0.05479192f,0.02407173f,-0.04118198f,0.9973578f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 5.855072f);
Get(0x6EC6).SetLocalPose(0.3110398f,1.179593f,-0.2902239f,-0.0781857f,-0.6845355f,-0.6341249f,0.3509757f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32128f,1.538234f,0.4831885f,-0.6545098f,-0.2081818f,-0.2499474f,0.6824981f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 5.874494f);
Get(0x6E70).SetLocalPose(-0.1419156f,1.681089f,-0.4732928f,0.4554262f,-0.4524567f,-0.5297659f,0.5542726f);
Get(0x6E82).SetLocalPose(-0.2396517f,0.821216f,-0.4179631f,-0.0547137f,0.03108647f,-0.04097314f,0.9971766f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 5.874494f);
Get(0x6EC6).SetLocalPose(0.3160046f,1.227779f,-0.2920182f,-0.09159426f,-0.7282171f,-0.5803021f,0.3529305f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321376f,1.537958f,0.4832132f,-0.6545298f,-0.2081998f,-0.2499411f,0.6824757f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 5.894463f);
Get(0x6E70).SetLocalPose(-0.1407771f,1.680851f,-0.473098f,0.4547572f,-0.4517314f,-0.5312202f,0.5540214f);
Get(0x6E82).SetLocalPose(-0.239663f,0.8223943f,-0.4163731f,-0.05525603f,0.04019663f,-0.04217726f,0.9967709f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 5.894463f);
Get(0x6EC6).SetLocalPose(0.3181316f,1.280369f,-0.2988607f,-0.1002113f,-0.7736372f,-0.5153617f,0.3547472f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321466f,1.537958f,0.4831957f,-0.6545382f,-0.2081837f,-0.249947f,0.6824704f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 5.915341f);
Get(0x6E70).SetLocalPose(-0.1397832f,1.6811f,-0.4728526f,0.4537329f,-0.4507737f,-0.5329586f,0.5539718f);
Get(0x6E82).SetLocalPose(-0.2391352f,0.8234897f,-0.4152447f,-0.0562138f,0.04836288f,-0.0445403f,0.9962516f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 5.915341f);
Get(0x6EC6).SetLocalPose(0.3165049f,1.335702f,-0.3117084f,-0.1036954f,-0.8179469f,-0.4360661f,0.3606335f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321411f,1.53798f,0.4831143f,-0.6545254f,-0.2081946f,-0.2499245f,0.6824876f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 5.939831f);
Get(0x6E70).SetLocalPose(-0.1383094f,1.681031f,-0.4721989f,0.4525098f,-0.449565f,-0.5350935f,0.5538964f);
Get(0x6E82).SetLocalPose(-0.2375869f,0.8237777f,-0.4123523f,-0.05898631f,0.06362326f,-0.04901244f,0.9950229f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 5.939831f);
Get(0x6EC6).SetLocalPose(0.3115193f,1.385671f,-0.328495f,-0.1038701f,-0.8549423f,-0.3550482f,0.3636282f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321496f,1.53792f,0.4830477f,-0.6545296f,-0.2082176f,-0.2499479f,0.682468f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 5.959953f);
Get(0x6E70).SetLocalPose(-0.1375582f,1.680938f,-0.4712303f,0.4516535f,-0.4482712f,-0.5370352f,0.5537647f);
Get(0x6E82).SetLocalPose(-0.2352554f,0.8242499f,-0.4104834f,-0.06157787f,0.07400537f,-0.05143102f,0.9940253f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 5.959953f);
Get(0x6EC6).SetLocalPose(0.3048378f,1.428641f,-0.3485349f,-0.1009648f,-0.8846003f,-0.2772238f,0.3611586f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321501f,1.538f,0.48316f,-0.6545234f,-0.2082351f,-0.2499316f,0.6824746f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 5.969317f);
Get(0x6E70).SetLocalPose(-0.1372532f,1.680885f,-0.4708158f,0.4513413f,-0.4475395f,-0.5380173f,0.5536575f);
Get(0x6E82).SetLocalPose(-0.2339301f,0.8246208f,-0.4088153f,-0.06360459f,0.08069224f,-0.05288078f,0.993301f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 5.969317f);
Get(0x6EC6).SetLocalPose(0.3021876f,1.44267f,-0.3557148f,-0.09930559f,-0.8932765f,-0.2506856f,0.3596556f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321567f,1.53795f,0.4833277f,-0.6545327f,-0.2082146f,-0.2499396f,0.682469f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 5.99111f);
Get(0x6E70).SetLocalPose(-0.1363093f,1.680723f,-0.4700268f,0.4508746f,-0.4457574f,-0.5400842f,0.5534632f);
Get(0x6E82).SetLocalPose(-0.2323693f,0.8254002f,-0.4072952f,-0.06729812f,0.0907454f,-0.0550249f,0.9920728f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 5.99111f);
Get(0x6EC6).SetLocalPose(0.2955556f,1.472237f,-0.3733785f,-0.09370127f,-0.9104316f,-0.1873243f,0.3567126f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32163f,1.5381f,0.483354f,-0.6545218f,-0.208245f,-0.2499364f,0.6824713f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 6.019867f);
Get(0x6E70).SetLocalPose(-0.1360575f,1.681252f,-0.4690648f,0.4506328f,-0.443717f,-0.5422457f,0.5531862f);
Get(0x6E82).SetLocalPose(-0.2303569f,0.8267741f,-0.4061388f,-0.07264883f,0.1017857f,-0.05775338f,0.9904678f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 6.019867f);
Get(0x6EC6).SetLocalPose(0.2847625f,1.50779f,-0.3982129f,-0.08414415f,-0.9259769f,-0.107052f,0.3521741f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321617f,1.538171f,0.4832194f,-0.6545208f,-0.2082397f,-0.2499227f,0.6824789f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 6.029555f);
Get(0x6E70).SetLocalPose(-0.1358269f,1.680435f,-0.4688005f,0.450457f,-0.4426532f,-0.5433961f,0.5530526f);
Get(0x6E82).SetLocalPose(-0.2289172f,0.8264245f,-0.406229f,-0.07471955f,0.1055128f,-0.05863382f,0.9898719f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 6.029555f);
Get(0x6EC6).SetLocalPose(0.2803246f,1.518753f,-0.4078062f,-0.0794937f,-0.9306415f,-0.0763291f,0.3489428f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321605f,1.538068f,0.483075f,-0.6545035f,-0.2082124f,-0.2499522f,0.682493f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 6.051403f);
Get(0x6E70).SetLocalPose(-0.1357226f,1.680023f,-0.4681796f,0.4501505f,-0.4413054f,-0.5448304f,0.5529682f);
Get(0x6E82).SetLocalPose(-0.2266108f,0.8251089f,-0.4062797f,-0.07723927f,0.1104491f,-0.05960941f,0.9890814f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 6.051403f);
Get(0x6EC6).SetLocalPose(0.2725622f,1.534413f,-0.4228968f,-0.07090839f,-0.9363106f,-0.02964073f,0.3426601f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321465f,1.538094f,0.4830215f,-0.6545071f,-0.2081901f,-0.2499481f,0.6824979f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 6.071576f);
Get(0x6E70).SetLocalPose(-0.1363035f,1.680147f,-0.4675598f,0.4497896f,-0.4404663f,-0.5456597f,0.5531133f);
Get(0x6E82).SetLocalPose(-0.2240794f,0.8241778f,-0.4047444f,-0.07910781f,0.1135518f,-0.0597491f,0.9885737f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 6.071576f);
Get(0x6EC6).SetLocalPose(0.2642258f,1.548928f,-0.4383801f,-0.06107321f,-0.9396272f,0.01310771f,0.3364505f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321425f,1.538024f,0.4828976f,-0.6545123f,-0.2081941f,-0.2499569f,0.6824885f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 6.091846f);
Get(0x6E70).SetLocalPose(-0.1366939f,1.680397f,-0.4671526f,0.4495389f,-0.4400245f,-0.5459124f,0.5534193f);
Get(0x6E82).SetLocalPose(-0.2222044f,0.8237839f,-0.4040598f,-0.08049956f,0.1151738f,-0.05931808f,0.9882997f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 6.091846f);
Get(0x6EC6).SetLocalPose(0.2552818f,1.558698f,-0.452325f,-0.05001788f,-0.9410343f,0.05271452f,0.3304147f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32135f,1.53809f,0.4828843f,-0.6544896f,-0.2081981f,-0.2499752f,0.6825023f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 6.111868f);
Get(0x6E70).SetLocalPose(-0.1371621f,1.680098f,-0.4666926f,0.4493333f,-0.4398547f,-0.5456917f,0.5539386f);
Get(0x6E82).SetLocalPose(-0.2202689f,0.8244856f,-0.4029274f,-0.08189891f,0.1160711f,-0.05840225f,0.9881343f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 6.111868f);
Get(0x6EC6).SetLocalPose(0.2462299f,1.565417f,-0.4663589f,-0.0351962f,-0.9412287f,0.09205243f,0.3230728f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321362f,1.538002f,0.4829718f,-0.6544915f,-0.2082144f,-0.2499749f,0.6824956f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 6.132265f);
Get(0x6E70).SetLocalPose(-0.1372651f,1.679907f,-0.4662287f,0.4492623f,-0.4398216f,-0.5451863f,0.5545198f);
Get(0x6E82).SetLocalPose(-0.2193318f,0.8247911f,-0.4022547f,-0.08301296f,0.1166008f,-0.0575833f,0.988027f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 6.132265f);
Get(0x6EC6).SetLocalPose(0.2381509f,1.566835f,-0.4773662f,-0.01921384f,-0.9402358f,0.1259043f,0.3158094f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321496f,1.538034f,0.482913f,-0.6544948f,-0.2082275f,-0.2499646f,0.6824922f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 6.15218f);
Get(0x6E70).SetLocalPose(-0.1375721f,1.679632f,-0.4654126f,0.4491068f,-0.4399907f,-0.5445065f,0.5551792f);
Get(0x6E82).SetLocalPose(-0.2186763f,0.8242661f,-0.4024642f,-0.08394648f,0.1174626f,-0.05691112f,0.987885f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 6.15218f);
Get(0x6EC6).SetLocalPose(0.2319912f,1.564884f,-0.4859066f,-0.002968844f,-0.9380108f,0.1556488f,0.3096779f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321589f,1.538111f,0.4829228f,-0.6545122f,-0.2082236f,-0.2499463f,0.6824834f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 6.172088f);
Get(0x6E70).SetLocalPose(-0.1378688f,1.679333f,-0.4648087f,0.4489286f,-0.4401708f,-0.5440758f,0.5556027f);
Get(0x6E82).SetLocalPose(-0.218142f,0.8241483f,-0.4029428f,-0.08475269f,0.1185542f,-0.05681201f,0.9876914f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 6.172088f);
Get(0x6EC6).SetLocalPose(0.227651f,1.562676f,-0.4919216f,0.01009313f,-0.9350976f,0.1781249f,0.3062059f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321624f,1.538092f,0.4830259f,-0.6545152f,-0.2082038f,-0.2499275f,0.6824934f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 6.192072f);
Get(0x6E70).SetLocalPose(-0.1379889f,1.678254f,-0.4644232f,0.4487949f,-0.4402137f,-0.5439301f,0.5558193f);
Get(0x6E82).SetLocalPose(-0.2178098f,0.8239056f,-0.4030859f,-0.08544348f,0.1189483f,-0.05689128f,0.9875799f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 6.192072f);
Get(0x6EC6).SetLocalPose(0.2197279f,1.558588f,-0.5038826f,0.0353955f,-0.9279177f,0.2186173f,0.2998708f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321625f,1.538074f,0.4830458f,-0.6545032f,-0.2082449f,-0.2499465f,0.6824855f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 6.212213f);
Get(0x6E70).SetLocalPose(-0.1385522f,1.678601f,-0.463689f,0.4488639f,-0.4400624f,-0.5438728f,0.5559394f);
Get(0x6E82).SetLocalPose(-0.2182881f,0.8238819f,-0.4030173f,-0.085922f,0.118137f,-0.05692614f,0.9876338f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 6.212213f);
Get(0x6EC6).SetLocalPose(0.2175118f,1.552552f,-0.5086161f,0.05076813f,-0.9222825f,0.2440232f,0.2954155f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321517f,1.538032f,0.4831395f,-0.6545022f,-0.2082069f,-0.2499469f,0.6824979f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 6.231759f);
Get(0x6E70).SetLocalPose(-0.1389723f,1.678107f,-0.4631371f,0.4491239f,-0.4397764f,-0.5438847f,0.5559443f);
Get(0x6E82).SetLocalPose(-0.218661f,0.8231849f,-0.403229f,-0.08637164f,0.116724f,-0.05675022f,0.9877727f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 6.231759f);
Get(0x6EC6).SetLocalPose(0.2174847f,1.548022f,-0.5129276f,0.06253437f,-0.9163583f,0.2668501f,0.2918355f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321499f,1.538078f,0.4832369f,-0.6545169f,-0.208213f,-0.2499377f,0.6824853f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 6.252128f);
Get(0x6E70).SetLocalPose(-0.1395604f,1.678624f,-0.4620619f,0.4495573f,-0.4392999f,-0.5440199f,0.5558383f);
Get(0x6E82).SetLocalPose(-0.2188844f,0.8226923f,-0.4047008f,-0.08690249f,0.1149232f,-0.05642305f,0.987956f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 6.252128f);
Get(0x6EC6).SetLocalPose(0.2193303f,1.545182f,-0.515601f,0.07073112f,-0.910497f,0.2861214f,0.2900465f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321545f,1.537985f,0.4833435f,-0.6545219f,-0.2082096f,-0.2499399f,0.6824807f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 6.272304f);
Get(0x6E70).SetLocalPose(-0.1400918f,1.678503f,-0.4614133f,0.449956f,-0.4387234f,-0.5444074f,0.5555916f);
Get(0x6E82).SetLocalPose(-0.2194734f,0.8220096f,-0.4052841f,-0.08773082f,0.1137703f,-0.05603373f,0.9880384f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 6.272304f);
Get(0x6EC6).SetLocalPose(0.2274386f,1.542808f,-0.5132987f,0.07070792f,-0.9056869f,0.296819f,0.2943301f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321614f,1.538071f,0.4832057f,-0.654521f,-0.2081985f,-0.2499589f,0.682478f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 6.292464f);
Get(0x6E70).SetLocalPose(-0.140597f,1.678566f,-0.4609212f,0.450295f,-0.4379972f,-0.5449671f,0.5553412f);
Get(0x6E82).SetLocalPose(-0.2198561f,0.8210965f,-0.4055693f,-0.08831403f,0.1132218f,-0.05574407f,0.9880658f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 6.292464f);
Get(0x6EC6).SetLocalPose(0.233612f,1.542569f,-0.5120153f,0.06401582f,-0.9035658f,0.2968982f,0.3021959f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321557f,1.538108f,0.4830353f,-0.6545174f,-0.2082043f,-0.2499329f,0.6824893f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 6.312127f);
Get(0x6E70).SetLocalPose(-0.1412349f,1.678885f,-0.4599988f,0.4505089f,-0.4373755f,-0.5453807f,0.5552517f);
Get(0x6E82).SetLocalPose(-0.219853f,0.8211512f,-0.4046142f,-0.08811098f,0.1130591f,-0.05525855f,0.9881299f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 6.312127f);
Get(0x6EC6).SetLocalPose(0.2455932f,1.543748f,-0.5100178f,0.04691637f,-0.903418f,0.2866271f,0.315404f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321629f,1.538025f,0.4830173f,-0.6545305f,-0.2082113f,-0.2499245f,0.6824776f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 6.33301f);
Get(0x6E70).SetLocalPose(-0.1416051f,1.678779f,-0.4597349f,0.4506837f,-0.4368662f,-0.5456443f,0.5552516f);
Get(0x6E82).SetLocalPose(-0.2199772f,0.8209503f,-0.404688f,-0.08774891f,0.1131073f,-0.05457858f,0.9881943f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 6.33301f);
Get(0x6EC6).SetLocalPose(0.2579305f,1.548336f,-0.5095015f,0.02633812f,-0.9058987f,0.2702109f,0.3250233f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321439f,1.538021f,0.4830749f,-0.6545295f,-0.2082074f,-0.2499477f,0.6824713f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 6.353051f);
Get(0x6E70).SetLocalPose(-0.1426283f,1.679072f,-0.459141f,0.4509564f,-0.4359199f,-0.5461816f,0.5552458f);
Get(0x6E82).SetLocalPose(-0.22015f,0.8209125f,-0.4042529f,-0.08762573f,0.1134585f,-0.05388925f,0.9882029f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 6.353051f);
Get(0x6EC6).SetLocalPose(0.2707492f,1.550747f,-0.5092995f,0.0006534985f,-0.9096582f,0.2489454f,0.3324872f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321475f,1.538065f,0.48308f,-0.6545153f,-0.2081923f,-0.2499394f,0.6824925f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 6.373787f);
Get(0x6E70).SetLocalPose(-0.143167f,1.678897f,-0.4585506f,0.4510154f,-0.4352041f,-0.5467952f,0.5551554f);
Get(0x6E82).SetLocalPose(-0.2202044f,0.8212581f,-0.4035496f,-0.08778103f,0.1143927f,-0.05311589f,0.9881232f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 6.373787f);
Get(0x6EC6).SetLocalPose(0.2882808f,1.552958f,-0.5090492f,-0.03934007f,-0.9130084f,0.222766f,0.3394752f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32154f,1.538042f,0.4830085f,-0.6545171f,-0.2081865f,-0.2499221f,0.682499f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 6.394256f);
Get(0x6E70).SetLocalPose(-0.1439941f,1.678347f,-0.4580614f,0.4511203f,-0.4343888f,-0.5475717f,0.5549433f);
Get(0x6E82).SetLocalPose(-0.2200203f,0.8210237f,-0.403464f,-0.08768485f,0.1155578f,-0.05215584f,0.9880474f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 6.394256f);
Get(0x6EC6).SetLocalPose(0.306158f,1.555489f,-0.5100763f,-0.09255589f,-0.915638f,0.1906705f,0.3415921f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321521f,1.538023f,0.4829732f,-0.654515f,-0.2081834f,-0.2499302f,0.6824989f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 6.414606f);
Get(0x6E70).SetLocalPose(-0.144694f,1.678403f,-0.457509f,0.4513453f,-0.4332953f,-0.548418f,0.5547795f);
Get(0x6E82).SetLocalPose(-0.2197926f,0.8208069f,-0.4027824f,-0.08787256f,0.1170498f,-0.05072413f,0.9879296f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 6.414606f);
Get(0x6EC6).SetLocalPose(0.3276307f,1.558546f,-0.5096899f,-0.1645886f,-0.9154207f,0.148365f,0.3360111f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321456f,1.537931f,0.4831065f,-0.6545328f,-0.2081907f,-0.2499138f,0.6824855f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 6.434756f);
Get(0x6E70).SetLocalPose(-0.1461455f,1.677971f,-0.4567817f,0.4517103f,-0.4321587f,-0.5491436f,0.5546512f);
Get(0x6E82).SetLocalPose(-0.2197334f,0.820902f,-0.4026237f,-0.08864534f,0.1187881f,-0.04902377f,0.9877389f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 6.434756f);
Get(0x6EC6).SetLocalPose(0.3484524f,1.562417f,-0.5113955f,-0.2399633f,-0.9146701f,0.09784582f,0.3101977f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321372f,1.538003f,0.4831236f,-0.6545352f,-0.2082241f,-0.2499317f,0.6824666f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 6.453808f);
Get(0x6E70).SetLocalPose(-0.1473176f,1.676708f,-0.4564406f,0.4522595f,-0.4312206f,-0.5495036f,0.5545774f);
Get(0x6E82).SetLocalPose(-0.2199675f,0.8202504f,-0.4013557f,-0.09063008f,0.1211001f,-0.04661502f,0.9873946f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 6.453808f);
Get(0x6EC6).SetLocalPose(0.3761843f,1.566899f,-0.5142927f,-0.3424196f,-0.90412f,0.02743658f,0.2540925f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321504f,1.538022f,0.483138f,-0.6545371f,-0.208206f,-0.2499255f,0.6824725f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 6.473758f);
Get(0x6E70).SetLocalPose(-0.1482574f,1.676548f,-0.4564666f,0.4528518f,-0.4305519f,-0.5495551f,0.5545624f);
Get(0x6E82).SetLocalPose(-0.2198317f,0.8198968f,-0.4006737f,-0.09363121f,0.1232071f,-0.04402797f,0.9869726f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 6.473758f);
Get(0x6EC6).SetLocalPose(0.3971207f,1.569844f,-0.5182664f,-0.4244556f,-0.8799354f,-0.03043097f,0.2112469f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321505f,1.537982f,0.4831208f,-0.6545263f,-0.2082054f,-0.2499426f,0.6824769f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 6.493219f);
Get(0x6E70).SetLocalPose(-0.1501364f,1.675927f,-0.4560478f,0.454089f,-0.429757f,-0.5490272f,0.5546903f);
Get(0x6E82).SetLocalPose(-0.2194269f,0.8192906f,-0.4004305f,-0.09598272f,0.1247108f,-0.04164036f,0.9866614f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 6.493219f);
Get(0x6EC6).SetLocalPose(0.4113606f,1.570896f,-0.5226868f,-0.49026f,-0.8458496f,-0.08463386f,0.1924077f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321396f,1.538142f,0.4832713f,-0.6545331f,-0.2082054f,-0.2499448f,0.6824694f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 6.512941f);
Get(0x6E70).SetLocalPose(-0.1512064f,1.675757f,-0.4558234f,0.4552401f,-0.429211f,-0.5482548f,0.5549334f);
Get(0x6E82).SetLocalPose(-0.219181f,0.8194689f,-0.3998476f,-0.09822266f,0.1253723f,-0.039013f,0.9864644f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 6.512941f);
Get(0x6EC6).SetLocalPose(0.4122429f,1.573281f,-0.5246582f,-0.4932874f,-0.8392352f,-0.1057535f,0.2028994f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321469f,1.538068f,0.4832646f,-0.65455f,-0.2082221f,-0.2499182f,0.682458f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 6.533675f);
Get(0x6E70).SetLocalPose(-0.15226f,1.676039f,-0.4552822f,0.4570934f,-0.4285757f,-0.546802f,0.5553342f);
Get(0x6E82).SetLocalPose(-0.2185292f,0.820255f,-0.3991746f,-0.1008027f,0.1258897f,-0.03614939f,0.9862474f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 6.533675f);
Get(0x6EC6).SetLocalPose(0.4008928f,1.575359f,-0.5282922f,-0.4601121f,-0.8536306f,-0.09322713f,0.2256555f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321488f,1.538042f,0.4834198f,-0.6545538f,-0.2082334f,-0.2499191f,0.6824505f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 6.553952f);
Get(0x6E70).SetLocalPose(-0.15291f,1.675772f,-0.4551789f,0.4592694f,-0.4280644f,-0.5449185f,0.5557845f);
Get(0x6E82).SetLocalPose(-0.2180001f,0.8205919f,-0.3985963f,-0.1030137f,0.1262332f,-0.03458814f,0.9860309f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 6.553952f);
Get(0x6EC6).SetLocalPose(0.3822382f,1.575798f,-0.5311891f,-0.4133342f,-0.8689225f,-0.06040795f,0.2654798f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321406f,1.538152f,0.4835006f,-0.6545513f,-0.2082341f,-0.2499331f,0.6824475f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 6.574256f);
Get(0x6E70).SetLocalPose(-0.1530521f,1.675482f,-0.455153f,0.4614199f,-0.4277484f,-0.5428394f,0.5562808f);
Get(0x6E82).SetLocalPose(-0.2179319f,0.8205099f,-0.3977523f,-0.104976f,0.1265285f,-0.03413502f,0.9858019f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 6.574256f);
Get(0x6EC6).SetLocalPose(0.3621347f,1.573551f,-0.5323048f,-0.3631418f,-0.8799897f,-0.02041559f,0.3054986f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321495f,1.538071f,0.4833356f,-0.6545469f,-0.2082369f,-0.249903f,0.682462f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 6.595129f);
Get(0x6E70).SetLocalPose(-0.1532593f,1.675186f,-0.4544905f,0.463456f,-0.4277305f,-0.5406998f,0.5566857f);
Get(0x6E82).SetLocalPose(-0.217639f,0.8209513f,-0.3976928f,-0.1071307f,0.1270369f,-0.03475935f,0.9854829f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 6.595129f);
Get(0x6EC6).SetLocalPose(0.3342011f,1.568541f,-0.5343145f,-0.2879245f,-0.8926217f,0.04070534f,0.3444838f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321536f,1.538153f,0.4833199f,-0.6545379f,-0.208238f,-0.2499063f,0.6824691f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 6.614444f);
Get(0x6E70).SetLocalPose(-0.1530797f,1.67495f,-0.4538988f,0.4645421f,-0.4278913f,-0.5396658f,0.5566602f);
Get(0x6E82).SetLocalPose(-0.2172906f,0.821738f,-0.3974842f,-0.1084143f,0.1276089f,-0.0361264f,0.9852194f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 6.614444f);
Get(0x6EC6).SetLocalPose(0.3129756f,1.56214f,-0.5369109f,-0.2276023f,-0.9016528f,0.09065699f,0.3563718f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321595f,1.537977f,0.4832773f,-0.6545417f,-0.2082753f,-0.2499084f,0.6824532f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 6.634079f);
Get(0x6E70).SetLocalPose(-0.1523982f,1.674529f,-0.4530192f,0.4654561f,-0.4279067f,-0.539274f,0.5562645f);
Get(0x6E82).SetLocalPose(-0.2166967f,0.8211056f,-0.3974098f,-0.1090374f,0.1284239f,-0.03741141f,0.9849967f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 6.634079f);
Get(0x6EC6).SetLocalPose(0.2917938f,1.554426f,-0.5394778f,-0.1568712f,-0.9092923f,0.1464731f,0.3565454f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.3217f,1.537934f,0.4831722f,-0.654539f,-0.2082486f,-0.2499117f,0.6824628f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 6.653356f);
Get(0x6E70).SetLocalPose(-0.1519493f,1.674254f,-0.4525134f,0.4662848f,-0.4276355f,-0.5397037f,0.5553614f);
Get(0x6E82).SetLocalPose(-0.2160346f,0.8210884f,-0.3975551f,-0.1087858f,0.1289625f,-0.03821439f,0.9849234f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 6.653356f);
Get(0x6EC6).SetLocalPose(0.2732977f,1.546275f,-0.5403063f,-0.09249584f,-0.9097218f,0.1963754f,0.3539598f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321655f,1.537944f,0.4832058f,-0.6545279f,-0.2082121f,-0.249902f,0.6824881f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 6.673359f);
Get(0x6E70).SetLocalPose(-0.1514672f,1.674419f,-0.4517836f,0.466735f,-0.4273867f,-0.5405778f,0.5543237f);
Get(0x6E82).SetLocalPose(-0.2152354f,0.8209203f,-0.3988531f,-0.1079919f,0.128731f,-0.03839232f,0.985034f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 6.673359f);
Get(0x6EC6).SetLocalPose(0.2554898f,1.535014f,-0.5412701f,-0.02061401f,-0.8993292f,0.2574462f,0.3528507f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321756f,1.537958f,0.4831714f,-0.6545168f,-0.2082172f,-0.2499299f,0.682487f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 6.693089f);
Get(0x6E70).SetLocalPose(-0.150967f,1.67425f,-0.451597f,0.4667459f,-0.427291f,-0.5413579f,0.5536265f);
Get(0x6E82).SetLocalPose(-0.2151212f,0.8195893f,-0.3992825f,-0.1071993f,0.1279317f,-0.03835556f,0.9852262f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 6.693089f);
Get(0x6EC6).SetLocalPose(0.2432598f,1.527132f,-0.5397844f,0.02973963f,-0.8834067f,0.3086135f,0.3513773f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321648f,1.537967f,0.4830767f,-0.6545022f,-0.2082018f,-0.2499229f,0.6825083f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 6.711911f);
Get(0x6E70).SetLocalPose(-0.1505266f,1.674355f,-0.451225f,0.4664121f,-0.4273529f,-0.5421538f,0.553081f);
Get(0x6E82).SetLocalPose(-0.2153457f,0.8191176f,-0.3994062f,-0.1068818f,0.1275524f,-0.03843223f,0.9853069f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 6.711911f);
Get(0x6EC6).SetLocalPose(0.2359072f,1.521971f,-0.538756f,0.0608052f,-0.8693301f,0.3449366f,0.3486929f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32157f,1.538094f,0.4828786f,-0.654518f,-0.2082085f,-0.2499148f,0.682494f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 6.73996f);
Get(0x6E70).SetLocalPose(-0.1493472f,1.673979f,-0.4515842f,0.4655502f,-0.4273798f,-0.5430577f,0.5528996f);
Get(0x6E82).SetLocalPose(-0.215657f,0.819113f,-0.3990304f,-0.1071444f,0.1278753f,-0.03833295f,0.9852404f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 6.73996f);
Get(0x6EC6).SetLocalPose(0.2342214f,1.521855f,-0.5356912f,0.07152256f,-0.8665425f,0.3538841f,0.3446079f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321526f,1.538099f,0.4829859f,-0.6545079f,-0.2082006f,-0.24993f,0.6825005f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 6.759666f);
Get(0x6E70).SetLocalPose(-0.1489291f,1.674155f,-0.4517221f,0.4645803f,-0.4273203f,-0.5438347f,0.5529976f);
Get(0x6E82).SetLocalPose(-0.2159396f,0.8187937f,-0.3987406f,-0.1077599f,0.1288092f,-0.03789692f,0.9850684f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 6.759666f);
Get(0x6EC6).SetLocalPose(0.2375898f,1.52687f,-0.5339252f,0.05808705f,-0.8747878f,0.3383668f,0.3418774f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32149f,1.538145f,0.4829186f,-0.6545057f,-0.2082195f,-0.24991f,0.6825042f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 6.779242f);
Get(0x6E70).SetLocalPose(-0.1486483f,1.673948f,-0.4519715f,0.4633289f,-0.4273475f,-0.5447369f,0.5531386f);
Get(0x6E82).SetLocalPose(-0.215874f,0.8198982f,-0.3986639f,-0.108381f,0.1299266f,-0.03724718f,0.9848783f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 6.779242f);
Get(0x6EC6).SetLocalPose(0.2465435f,1.530998f,-0.5310302f,0.02838926f,-0.8857704f,0.3162084f,0.3385515f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321516f,1.538093f,0.4829189f,-0.6544809f,-0.2082163f,-0.2499298f,0.6825216f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 6.799507f);
Get(0x6E70).SetLocalPose(-0.1488498f,1.674318f,-0.451933f,0.4622451f,-0.4272098f,-0.5455433f,0.5533569f);
Get(0x6E82).SetLocalPose(-0.2159952f,0.8209848f,-0.3981764f,-0.1085385f,0.1313198f,-0.03665697f,0.9846983f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 6.799507f);
Get(0x6EC6).SetLocalPose(0.2577514f,1.536012f,-0.5290068f,-0.01792253f,-0.8969593f,0.2879405f,0.335012f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321535f,1.538109f,0.4830804f,-0.6544886f,-0.2082454f,-0.2499176f,0.68251f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 6.819005f);
Get(0x6E70).SetLocalPose(-0.1490057f,1.674301f,-0.4520392f,0.4612493f,-0.4267635f,-0.5463325f,0.5537534f);
Get(0x6E82).SetLocalPose(-0.2161668f,0.8215922f,-0.3979921f,-0.1085206f,0.1326323f,-0.03587484f,0.9845532f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 6.819005f);
Get(0x6EC6).SetLocalPose(0.2620181f,1.542846f,-0.5287647f,-0.08038524f,-0.9062953f,0.2512403f,0.3302203f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321502f,1.538201f,0.483201f,-0.6544984f,-0.2082278f,-0.2499321f,0.6825006f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 6.838933f);
Get(0x6E70).SetLocalPose(-0.1493228f,1.673936f,-0.4522412f,0.460637f,-0.4263542f,-0.5466986f,0.5542167f);
Get(0x6E82).SetLocalPose(-0.2161686f,0.8224583f,-0.3969938f,-0.1084937f,0.1338281f,-0.0350524f,0.984424f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 6.838933f);
Get(0x6EC6).SetLocalPose(0.275396f,1.551749f,-0.5244126f,-0.1495694f,-0.9103681f,0.2071961f,0.325467f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321624f,1.538063f,0.4830477f,-0.6545098f,-0.208226f,-0.2499162f,0.682496f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 6.858525f);
Get(0x6E70).SetLocalPose(-0.1498466f,1.674425f,-0.4522788f,0.4598995f,-0.4258459f,-0.5468799f,0.5550406f);
Get(0x6E82).SetLocalPose(-0.2162084f,0.8227937f,-0.3966962f,-0.1087855f,0.1351443f,-0.03405278f,0.984247f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 6.858525f);
Get(0x6EC6).SetLocalPose(0.2970209f,1.560176f,-0.5254433f,-0.237456f,-0.9114994f,0.1329771f,0.3083841f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32161f,1.538031f,0.4831404f,-0.6545212f,-0.2081884f,-0.2499119f,0.6824981f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 6.877901f);
Get(0x6E70).SetLocalPose(-0.1503914f,1.67491f,-0.4527346f,0.459281f,-0.425541f,-0.5468893f,0.555777f);
Get(0x6E82).SetLocalPose(-0.2163629f,0.8228915f,-0.3969603f,-0.1093401f,0.1369957f,-0.03287469f,0.9839696f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 6.877901f);
Get(0x6EC6).SetLocalPose(0.3134497f,1.567285f,-0.5233101f,-0.2970611f,-0.9108527f,0.05788035f,0.2806281f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321637f,1.537982f,0.4831499f,-0.6545092f,-0.2082033f,-0.2499344f,0.6824969f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 6.896854f);
Get(0x6E70).SetLocalPose(-0.1511027f,1.675409f,-0.4527822f,0.458819f,-0.4254063f,-0.5467327f,0.5564153f);
Get(0x6E82).SetLocalPose(-0.2162451f,0.8240116f,-0.3970417f,-0.1096338f,0.1388415f,-0.03215579f,0.9837019f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 6.896854f);
Get(0x6EC6).SetLocalPose(0.3268352f,1.573016f,-0.5212459f,-0.3306437f,-0.9056064f,-0.0189219f,0.2649412f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32161f,1.537964f,0.4830587f,-0.6545134f,-0.2082056f,-0.2499195f,0.6824975f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 6.915585f);
Get(0x6E70).SetLocalPose(-0.1514634f,1.675708f,-0.452959f,0.4586751f,-0.4252237f,-0.5463129f,0.5570855f);
Get(0x6E82).SetLocalPose(-0.2161294f,0.8243092f,-0.3970281f,-0.1095949f,0.1404698f,-0.03176645f,0.9834878f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 6.915585f);
Get(0x6EC6).SetLocalPose(0.3310289f,1.57662f,-0.5193427f,-0.3339278f,-0.8935817f,-0.06150817f,0.2936335f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321613f,1.537983f,0.4831333f,-0.6545337f,-0.2082229f,-0.2499024f,0.6824791f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 6.934289f);
Get(0x6E70).SetLocalPose(-0.1512064f,1.67516f,-0.453546f,0.4588392f,-0.4250085f,-0.5457143f,0.5577009f);
Get(0x6E82).SetLocalPose(-0.216015f,0.8243963f,-0.396414f,-0.1096557f,0.1419593f,-0.03158205f,0.983273f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 6.934289f);
Get(0x6EC6).SetLocalPose(0.3282974f,1.57768f,-0.5179194f,-0.3169302f,-0.8898314f,-0.06731319f,0.3212855f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321671f,1.538111f,0.4831307f,-0.6545333f,-0.2082392f,-0.249915f,0.6824699f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 6.953915f);
Get(0x6E70).SetLocalPose(-0.1513538f,1.675519f,-0.4537656f,0.4590875f,-0.4249059f,-0.5452235f,0.5580547f);
Get(0x6E82).SetLocalPose(-0.2161248f,0.8246937f,-0.3964182f,-0.1096133f,0.1434624f,-0.03168387f,0.9830562f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 6.953915f);
Get(0x6EC6).SetLocalPose(0.318786f,1.574993f,-0.5169706f,-0.2777393f,-0.8906106f,-0.0406409f,0.3578016f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321713f,1.538125f,0.483109f,-0.6545191f,-0.2082433f,-0.2499127f,0.6824831f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 6.973646f);
Get(0x6E70).SetLocalPose(-0.151202f,1.675615f,-0.4536905f,0.4592628f,-0.4250242f,-0.5450295f,0.5580097f);
Get(0x6E82).SetLocalPose(-0.2162839f,0.8242502f,-0.3965446f,-0.1094013f,0.1448594f,-0.03208162f,0.9828621f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 6.973646f);
Get(0x6EC6).SetLocalPose(0.3082608f,1.570966f,-0.5174714f,-0.2376975f,-0.8927917f,0.0006634807f,0.3826518f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321742f,1.538108f,0.4829653f,-0.6545163f,-0.2082533f,-0.2499196f,0.6824803f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 6.993268f);
Get(0x6E70).SetLocalPose(-0.1503696f,1.675205f,-0.4536269f,0.459287f,-0.4253855f,-0.5447962f,0.5579424f);
Get(0x6E82).SetLocalPose(-0.2164027f,0.8243815f,-0.3965264f,-0.1093184f,0.1455234f,-0.03278598f,0.98275f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 6.993268f);
Get(0x6EC6).SetLocalPose(0.293517f,1.565462f,-0.5197172f,-0.1825722f,-0.8964363f,0.05378085f,0.4002213f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321758f,1.538204f,0.4830902f,-0.6545188f,-0.2082565f,-0.2499271f,0.682474f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 7.01283f);
Get(0x6E70).SetLocalPose(-0.1496386f,1.675238f,-0.4535172f,0.4592564f,-0.4259776f,-0.5444943f,0.5578106f);
Get(0x6E82).SetLocalPose(-0.2165317f,0.8242245f,-0.3963749f,-0.1094344f,0.1454246f,-0.03355157f,0.9827259f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 7.01283f);
Get(0x6EC6).SetLocalPose(0.2802674f,1.557487f,-0.5223399f,-0.1212702f,-0.8986986f,0.1077547f,0.4074599f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321775f,1.538113f,0.4830879f,-0.6545168f,-0.208248f,-0.2499024f,0.6824877f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 7.032609f);
Get(0x6E70).SetLocalPose(-0.1489442f,1.675349f,-0.4535332f,0.4591889f,-0.4266258f,-0.5443535f,0.5575081f);
Get(0x6E82).SetLocalPose(-0.2167182f,0.823446f,-0.3971331f,-0.1099523f,0.1449735f,-0.03402311f,0.9827185f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 7.032609f);
Get(0x6EC6).SetLocalPose(0.2681478f,1.547842f,-0.5232754f,-0.06491417f,-0.895887f,0.1647966f,0.4074493f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321745f,1.538032f,0.4831491f,-0.6545358f,-0.2082438f,-0.2499168f,0.6824655f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 7.051708f);
Get(0x6E70).SetLocalPose(-0.1480481f,1.675208f,-0.4536498f,0.4591261f,-0.4271061f,-0.5445862f,0.5569646f);
Get(0x6E82).SetLocalPose(-0.2166231f,0.82289f,-0.3975347f,-0.1104095f,0.1447818f,-0.03432575f,0.982685f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 7.051708f);
Get(0x6EC6).SetLocalPose(0.25725f,1.538299f,-0.5264581f,-0.01792587f,-0.8903978f,0.2158564f,0.4003453f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321639f,1.537934f,0.4832541f,-0.6545423f,-0.2082485f,-0.2498836f,0.68247f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 7.079343f);
Get(0x6E70).SetLocalPose(-0.1468527f,1.675062f,-0.4535933f,0.4590882f,-0.4275126f,-0.5455672f,0.5557225f);
Get(0x6E82).SetLocalPose(-0.2163506f,0.8223912f,-0.3980747f,-0.1105581f,0.1446076f,-0.03471885f,0.9826801f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 7.079343f);
Get(0x6EC6).SetLocalPose(0.2451719f,1.525227f,-0.5292875f,0.04018453f,-0.8789622f,0.2908145f,0.3758157f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321655f,1.538037f,0.4832332f,-0.6545449f,-0.2082465f,-0.2498912f,0.6824653f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 7.098727f);
Get(0x6E70).SetLocalPose(-0.1459841f,1.674997f,-0.4535162f,0.458751f,-0.4279073f,-0.5466468f,0.5546352f);
Get(0x6E82).SetLocalPose(-0.2160765f,0.8224254f,-0.3984137f,-0.1103964f,0.1445592f,-0.03481714f,0.982702f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 7.098727f);
Get(0x6EC6).SetLocalPose(0.2424196f,1.520375f,-0.5312089f,0.05471376f,-0.8731054f,0.3240933f,0.3600792f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321585f,1.538083f,0.4832965f,-0.6545565f,-0.2082546f,-0.249908f,0.6824455f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 7.118832f);
Get(0x6E70).SetLocalPose(-0.145428f,1.67494f,-0.453664f,0.4581976f,-0.4282473f,-0.5476856f,0.5538048f);
Get(0x6E82).SetLocalPose(-0.2158801f,0.8227088f,-0.3990801f,-0.1098721f,0.1442713f,-0.03471297f,0.9828067f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 7.118832f);
Get(0x6EC6).SetLocalPose(0.2435816f,1.520319f,-0.5308101f,0.04537481f,-0.8726378f,0.3347068f,0.3527263f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321578f,1.538048f,0.4833688f,-0.6545461f,-0.2082331f,-0.2499095f,0.6824614f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 7.138171f);
Get(0x6E70).SetLocalPose(-0.1447566f,1.675092f,-0.4540509f,0.457431f,-0.4285539f,-0.5487544f,0.5531428f);
Get(0x6E82).SetLocalPose(-0.2156256f,0.8228288f,-0.399937f,-0.1093102f,0.1441032f,-0.03439972f,0.982905f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 7.138171f);
Get(0x6EC6).SetLocalPose(0.2480521f,1.524215f,-0.5302476f,0.01797335f,-0.8827419f,0.3142473f,0.3488443f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321434f,1.538069f,0.4834399f,-0.6545491f,-0.2082155f,-0.2499376f,0.6824538f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 7.15839f);
Get(0x6E70).SetLocalPose(-0.1443115f,1.675606f,-0.4544685f,0.4565685f,-0.4288407f,-0.5496132f,0.5527804f);
Get(0x6E82).SetLocalPose(-0.2154066f,0.8229716f,-0.4000636f,-0.1088947f,0.1441272f,-0.03425792f,0.9829526f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 7.15839f);
Get(0x6EC6).SetLocalPose(0.256409f,1.532049f,-0.5307357f,-0.02458706f,-0.8976005f,0.2769216f,0.3420867f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321435f,1.538083f,0.4833521f,-0.654544f,-0.2082207f,-0.2499223f,0.6824626f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 7.17762f);
Get(0x6E70).SetLocalPose(-0.1440399f,1.6755f,-0.4549621f,0.4560283f,-0.4290367f,-0.5499817f,0.5527077f);
Get(0x6E82).SetLocalPose(-0.2151272f,0.8238877f,-0.4000069f,-0.1087963f,0.144633f,-0.03434115f,0.9828863f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 7.17762f);
Get(0x6EC6).SetLocalPose(0.2594146f,1.53715f,-0.5299742f,-0.08122487f,-0.9089807f,0.2319536f,0.3366811f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321413f,1.538094f,0.4834115f,-0.6545389f,-0.2082396f,-0.2499073f,0.6824672f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 7.196724f);
Get(0x6E70).SetLocalPose(-0.144555f,1.675997f,-0.4552447f,0.4555067f,-0.4291574f,-0.5502149f,0.552812f);
Get(0x6E82).SetLocalPose(-0.2148077f,0.8246229f,-0.39983f,-0.1091483f,0.1457578f,-0.0345341f,0.9826742f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 7.196724f);
Get(0x6EC6).SetLocalPose(0.270577f,1.543672f,-0.5299472f,-0.1471677f,-0.9143876f,0.181104f,0.3308145f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321406f,1.538104f,0.483342f,-0.6545587f,-0.2082448f,-0.249927f,0.6824395f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 7.216264f);
Get(0x6E70).SetLocalPose(-0.1449644f,1.676098f,-0.4557576f,0.4553415f,-0.4290632f,-0.5501671f,0.5530688f);
Get(0x6E82).SetLocalPose(-0.214861f,0.8253739f,-0.3993081f,-0.1094915f,0.1471883f,-0.03468481f,0.9824175f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 7.216264f);
Get(0x6EC6).SetLocalPose(0.2858113f,1.550565f,-0.5265016f,-0.2189075f,-0.9118602f,0.1214963f,0.3253141f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321374f,1.537988f,0.4831914f,-0.654538f,-0.2082257f,-0.2499571f,0.6824541f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 7.236347f);
Get(0x6E70).SetLocalPose(-0.145208f,1.675873f,-0.4563509f,0.4554268f,-0.4288827f,-0.5499439f,0.5533605f);
Get(0x6E82).SetLocalPose(-0.2147912f,0.8250942f,-0.3986956f,-0.1097942f,0.1491209f,-0.03477469f,0.9820891f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 7.236347f);
Get(0x6EC6).SetLocalPose(0.3014068f,1.555366f,-0.5212572f,-0.2829518f,-0.9028561f,0.05302687f,0.3193389f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321365f,1.537941f,0.4831819f,-0.6545081f,-0.2082062f,-0.2499838f,0.682479f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 7.25669f);
Get(0x6E70).SetLocalPose(-0.1455033f,1.675778f,-0.4573309f,0.4556338f,-0.4287325f,-0.5494992f,0.5537481f);
Get(0x6E82).SetLocalPose(-0.2144747f,0.8257899f,-0.3981862f,-0.1102207f,0.1514094f,-0.03502981f,0.981682f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 7.25669f);
Get(0x6EC6).SetLocalPose(0.3165862f,1.558325f,-0.5160787f,-0.3228054f,-0.8922949f,-0.01912474f,0.3150252f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32129f,1.53803f,0.4831474f,-0.6545112f,-0.208178f,-0.2499697f,0.6824897f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 7.276841f);
Get(0x6E70).SetLocalPose(-0.1462016f,1.675977f,-0.4581229f,0.455861f,-0.428732f,-0.5486785f,0.5543749f);
Get(0x6E82).SetLocalPose(-0.2147443f,0.8264126f,-0.3978452f,-0.1109591f,0.1534248f,-0.03532206f,0.9812754f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 7.276841f);
Get(0x6EC6).SetLocalPose(0.3248915f,1.559092f,-0.5130043f,-0.3306747f,-0.888972f,-0.05609038f,0.3118283f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321271f,1.53808f,0.4832333f,-0.6545254f,-0.2081862f,-0.2499696f,0.6824737f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 7.297216f);
Get(0x6E70).SetLocalPose(-0.1466545f,1.675963f,-0.458919f,0.4562492f,-0.4289867f,-0.5472385f,0.5552812f);
Get(0x6E82).SetLocalPose(-0.2152606f,0.8265948f,-0.3978352f,-0.1121299f,0.1555738f,-0.03583707f,0.9807851f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 7.297216f);
Get(0x6EC6).SetLocalPose(0.3265896f,1.555166f,-0.5122827f,-0.3240835f,-0.8922402f,-0.05652745f,0.3093252f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321338f,1.538077f,0.4830799f,-0.6545256f,-0.2081705f,-0.2499307f,0.6824925f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 7.317572f);
Get(0x6E70).SetLocalPose(-0.1471559f,1.675862f,-0.4596378f,0.4568041f,-0.429359f,-0.545514f,0.5562332f);
Get(0x6E82).SetLocalPose(-0.2157098f,0.8267342f,-0.3978038f,-0.1140474f,0.1576903f,-0.03682329f,0.9801893f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 7.317572f);
Get(0x6EC6).SetLocalPose(0.3224911f,1.549401f,-0.5119048f,-0.3022357f,-0.8963305f,-0.03426542f,0.3226007f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32142f,1.538069f,0.4830986f,-0.6545309f,-0.2081939f,-0.249943f,0.6824757f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 7.338136f);
Get(0x6E70).SetLocalPose(-0.1477834f,1.676006f,-0.4599459f,0.4573773f,-0.429963f,-0.543636f,0.5571336f);
Get(0x6E82).SetLocalPose(-0.2159145f,0.8268105f,-0.397392f,-0.1157345f,0.1580971f,-0.03784717f,0.979887f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 7.338136f);
Get(0x6EC6).SetLocalPose(0.3138644f,1.544558f,-0.511431f,-0.2736662f,-0.8942543f,0.0002152952f,0.3541413f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321292f,1.538035f,0.4830518f,-0.6545117f,-0.2081815f,-0.2499424f,0.6824982f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 7.358558f);
Get(0x6E70).SetLocalPose(-0.1482706f,1.676121f,-0.4596294f,0.4577238f,-0.4306137f,-0.5422378f,0.5577087f);
Get(0x6E82).SetLocalPose(-0.2161169f,0.8275889f,-0.3968583f,-0.1170871f,0.1571641f,-0.0388835f,0.9798358f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 7.358558f);
Get(0x6EC6).SetLocalPose(0.3111581f,1.542593f,-0.5109458f,-0.2604675f,-0.893141f,0.01500013f,0.3663754f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321393f,1.53801f,0.4830393f,-0.6545234f,-0.2081936f,-0.2499266f,0.682489f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 7.37847f);
Get(0x6E70).SetLocalPose(-0.148971f,1.676434f,-0.4593931f,0.4584869f,-0.4315237f,-0.5403625f,0.5581984f);
Get(0x6E82).SetLocalPose(-0.216397f,0.8279443f,-0.397378f,-0.1174015f,0.1557002f,-0.03933638f,0.9800138f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 7.37847f);
Get(0x6EC6).SetLocalPose(0.3062072f,1.53961f,-0.5105117f,-0.2394159f,-0.8919786f,0.03629358f,0.3817554f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321487f,1.537904f,0.4829668f,-0.6545095f,-0.2081887f,-0.2499365f,0.6825002f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 7.398755f);
Get(0x6E70).SetLocalPose(-0.1490627f,1.67616f,-0.4590414f,0.4599931f,-0.4320742f,-0.539022f,0.5578293f);
Get(0x6E82).SetLocalPose(-0.2167857f,0.8279365f,-0.3981339f,-0.1171526f,0.1537547f,-0.03931235f,0.9803516f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 7.398755f);
Get(0x6EC6).SetLocalPose(0.299656f,1.534829f,-0.5108807f,-0.2083677f,-0.8911037f,0.06703304f,0.397522f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321506f,1.537878f,0.4830998f,-0.6545147f,-0.2082112f,-0.2499545f,0.6824818f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 7.41925f);
Get(0x6E70).SetLocalPose(-0.1494582f,1.67581f,-0.4590889f,0.4612646f,-0.4321477f,-0.5387858f,0.5569499f);
Get(0x6E82).SetLocalPose(-0.2169856f,0.8274584f,-0.3985746f,-0.1161888f,0.15171f,-0.0386134f,0.9808126f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 7.41925f);
Get(0x6EC6).SetLocalPose(0.2912197f,1.529029f,-0.5117477f,-0.1765515f,-0.8938909f,0.1047118f,0.3985275f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321544f,1.538027f,0.4829196f,-0.654516f,-0.2082024f,-0.2499378f,0.6824894f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 7.439445f);
Get(0x6E70).SetLocalPose(-0.1498094f,1.675565f,-0.4589235f,0.4628539f,-0.4321967f,-0.5388535f,0.555526f);
Get(0x6E82).SetLocalPose(-0.2170801f,0.826932f,-0.3995731f,-0.1151514f,0.1514228f,-0.03789221f,0.9810074f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 7.439445f);
Get(0x6EC6).SetLocalPose(0.2863537f,1.526502f,-0.5134464f,-0.1645343f,-0.901285f,0.1187749f,0.3827614f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321687f,1.537886f,0.4828872f,-0.6545104f,-0.2082221f,-0.2499287f,0.682492f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 7.458626f);
Get(0x6E70).SetLocalPose(-0.1497721f,1.675006f,-0.4591716f,0.4639086f,-0.4323223f,-0.5391432f,0.5542662f);
Get(0x6E82).SetLocalPose(-0.2170326f,0.8267685f,-0.4006822f,-0.1138368f,0.1514036f,-0.03717087f,0.9811913f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 7.458626f);
Get(0x6EC6).SetLocalPose(0.2838129f,1.525707f,-0.5142218f,-0.1582315f,-0.9055305f,0.1236942f,0.3737341f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321632f,1.537944f,0.4830677f,-0.6545179f,-0.2082182f,-0.2499319f,0.6824849f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 7.478548f);
Get(0x6E70).SetLocalPose(-0.149355f,1.674997f,-0.4597674f,0.4647582f,-0.43243f,-0.539633f,0.5529922f);
Get(0x6E82).SetLocalPose(-0.2169403f,0.8266397f,-0.4012896f,-0.1125318f,0.1507673f,-0.03639708f,0.9814689f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 7.478548f);
Get(0x6EC6).SetLocalPose(0.2794042f,1.525524f,-0.5149563f,-0.1518287f,-0.907721f,0.1299568f,0.3689198f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321705f,1.538032f,0.483004f,-0.6545233f,-0.2081966f,-0.2499225f,0.6824898f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 7.498816f);
Get(0x6E70).SetLocalPose(-0.1493124f,1.675065f,-0.4603932f,0.4652114f,-0.4324523f,-0.540211f,0.5520285f);
Get(0x6E82).SetLocalPose(-0.2165245f,0.8261041f,-0.4018151f,-0.1114392f,0.1489172f,-0.035469f,0.9819099f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 7.498816f);
Get(0x6EC6).SetLocalPose(0.2756633f,1.525481f,-0.5153298f,-0.1462374f,-0.9083009f,0.1376965f,0.3669384f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321531f,1.538083f,0.483214f,-0.6544968f,-0.208231f,-0.2499375f,0.6824991f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 7.51868f);
Get(0x6E70).SetLocalPose(-0.1488966f,1.674957f,-0.4608581f,0.4653265f,-0.4323393f,-0.5405998f,0.5516393f);
Get(0x6E82).SetLocalPose(-0.2165595f,0.825561f,-0.4025061f,-0.1112609f,0.1471629f,-0.03502857f,0.9822103f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 7.51868f);
Get(0x6EC6).SetLocalPose(0.2742247f,1.525909f,-0.5155049f,-0.1413743f,-0.909772f,0.14425f,0.3626572f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321436f,1.538091f,0.4832236f,-0.6545206f,-0.2082267f,-0.2499281f,0.6824811f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 7.539403f);
Get(0x6E70).SetLocalPose(-0.1488514f,1.674404f,-0.4616057f,0.465369f,-0.4321591f,-0.5408759f,0.5514739f);
Get(0x6E82).SetLocalPose(-0.2159601f,0.8259915f,-0.4023082f,-0.1117242f,0.1455863f,-0.03500337f,0.9823936f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 7.539403f);
Get(0x6EC6).SetLocalPose(0.2730785f,1.526197f,-0.5154691f,-0.1401048f,-0.9115124f,0.1476683f,0.357365f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321512f,1.538148f,0.4832088f,-0.6545366f,-0.2082222f,-0.249933f,0.6824653f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 7.559238f);
Get(0x6E70).SetLocalPose(-0.1488726f,1.674861f,-0.461721f,0.4651866f,-0.4320072f,-0.5409366f,0.5516871f);
Get(0x6E82).SetLocalPose(-0.215603f,0.825689f,-0.4021321f,-0.1124347f,0.1450077f,-0.0351713f,0.9823921f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 7.559238f);
Get(0x6EC6).SetLocalPose(0.2731898f,1.527459f,-0.5155324f,-0.1429522f,-0.9132993f,0.1464966f,0.3521192f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321355f,1.538027f,0.483271f,-0.6545295f,-0.2081995f,-0.2499084f,0.682488f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 7.578635f);
Get(0x6E70).SetLocalPose(-0.1489935f,1.674821f,-0.4619453f,0.4649316f,-0.4318546f,-0.5408459f,0.5521104f);
Get(0x6E82).SetLocalPose(-0.2154289f,0.8256881f,-0.401708f,-0.1131765f,0.1449813f,-0.0352284f,0.9823088f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 7.578635f);
Get(0x6EC6).SetLocalPose(0.274174f,1.529218f,-0.5147655f,-0.1483304f,-0.9151978f,0.1407364f,0.3472813f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32147f,1.538062f,0.4832361f,-0.6545277f,-0.2082229f,-0.2499246f,0.6824767f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 7.598818f);
Get(0x6E70).SetLocalPose(-0.1491276f,1.674839f,-0.4623742f,0.4647745f,-0.431667f,-0.5405783f,0.5526512f);
Get(0x6E82).SetLocalPose(-0.2151756f,0.8256263f,-0.4014035f,-0.1139434f,0.1452329f,-0.03531888f,0.9821797f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 7.598818f);
Get(0x6EC6).SetLocalPose(0.2757725f,1.529914f,-0.5139385f,-0.1539474f,-0.9177014f,0.1312325f,0.3419099f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321501f,1.538089f,0.4831724f,-0.6545321f,-0.2082164f,-0.2499251f,0.6824744f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 7.618001f);
Get(0x6E70).SetLocalPose(-0.1493248f,1.674874f,-0.4622923f,0.4648111f,-0.4315075f,-0.5402089f,0.553106f);
Get(0x6E82).SetLocalPose(-0.2151767f,0.82613f,-0.4004439f,-0.1146117f,0.1455825f,-0.03555756f,0.9820416f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 7.618001f);
Get(0x6EC6).SetLocalPose(0.2784811f,1.531168f,-0.5124146f,-0.1589337f,-0.9209934f,0.1193697f,0.3350555f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321533f,1.538101f,0.4832741f,-0.6545241f,-0.2082169f,-0.2499081f,0.682488f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 7.637253f);
Get(0x6E70).SetLocalPose(-0.1493477f,1.674342f,-0.4624317f,0.4650413f,-0.4313765f,-0.5397544f,0.5534583f);
Get(0x6E82).SetLocalPose(-0.2152265f,0.826467f,-0.3999437f,-0.1153996f,0.1460929f,-0.03581699f,0.9818641f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 7.637253f);
Get(0x6EC6).SetLocalPose(0.2816367f,1.531324f,-0.5107721f,-0.1629247f,-0.9233567f,0.1089232f,0.3301574f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321582f,1.538133f,0.4832443f,-0.6545402f,-0.2082347f,-0.2499069f,0.6824676f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 7.656874f);
Get(0x6E70).SetLocalPose(-0.149839f,1.67403f,-0.4625306f,0.4653341f,-0.4313264f,-0.5393342f,0.5536608f);
Get(0x6E82).SetLocalPose(-0.2151574f,0.8267814f,-0.399381f,-0.1162736f,0.1465418f,-0.03591572f,0.9816903f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 7.656874f);
Get(0x6EC6).SetLocalPose(0.2865389f,1.531569f,-0.5074756f,-0.1719601f,-0.9244243f,0.09370901f,0.3272432f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321477f,1.53818f,0.4833414f,-0.6545299f,-0.2081995f,-0.2499146f,0.6824853f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 7.676433f);
Get(0x6E70).SetLocalPose(-0.1503865f,1.674277f,-0.4626653f,0.4656821f,-0.4312774f,-0.5388696f,0.553859f);
Get(0x6E82).SetLocalPose(-0.2151353f,0.8270098f,-0.3992586f,-0.1166992f,0.1469171f,-0.03587678f,0.9815853f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 7.676433f);
Get(0x6EC6).SetLocalPose(0.2907374f,1.530917f,-0.5043807f,-0.1802176f,-0.923376f,0.08137491f,0.3290538f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321622f,1.538167f,0.4830805f,-0.6545162f,-0.2082096f,-0.24991f,0.6824973f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 7.696038f);
Get(0x6E70).SetLocalPose(-0.1508486f,1.674086f,-0.4628049f,0.4659633f,-0.4313295f,-0.5383952f,0.5540431f);
Get(0x6E82).SetLocalPose(-0.214995f,0.8268082f,-0.3992811f,-0.1167193f,0.1473845f,-0.03582211f,0.9815148f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 7.696038f);
Get(0x6EC6).SetLocalPose(0.2932166f,1.530842f,-0.5023916f,-0.1839374f,-0.9226949f,0.07521256f,0.3303699f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321675f,1.538301f,0.4829576f,-0.6545028f,-0.2082272f,-0.2498959f,0.6825098f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 7.70535f);
Get(0x6E70).SetLocalPose(-0.1508728f,1.674141f,-0.4627822f,0.4661089f,-0.4313554f,-0.5381345f,0.5541538f);
Get(0x6E82).SetLocalPose(-0.2150268f,0.8263701f,-0.3994997f,-0.1167073f,0.1476571f,-0.03575173f,0.9814777f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 7.70535f);
Get(0x6EC6).SetLocalPose(0.3008474f,1.528541f,-0.4976559f,-0.193464f,-0.9207052f,0.05719668f,0.334069f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321695f,1.538178f,0.4830442f,-0.6545018f,-0.208214f,-0.2499008f,0.682513f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 7.737166f);
Get(0x6E70).SetLocalPose(-0.151651f,1.674129f,-0.4633475f,0.4664766f,-0.4313471f,-0.5374446f,0.5545202f);
Get(0x6E82).SetLocalPose(-0.2146181f,0.8254162f,-0.400297f,-0.1165723f,0.1483743f,-0.03537052f,0.9813995f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 7.737166f);
Get(0x6EC6).SetLocalPose(0.3158543f,1.5238f,-0.4894411f,-0.2082263f,-0.9173372f,0.01827728f,0.3388216f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321718f,1.538157f,0.4830541f,-0.6545174f,-0.2082157f,-0.2499057f,0.6824957f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 7.750302f);
Get(0x6E70).SetLocalPose(-0.1519184f,1.674068f,-0.4636038f,0.4666575f,-0.4312287f,-0.5370867f,0.5548067f);
Get(0x6E82).SetLocalPose(-0.2143651f,0.8254083f,-0.4007732f,-0.1164846f,0.1484575f,-0.03524168f,0.981402f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 7.750302f);
Get(0x6EC6).SetLocalPose(0.3223719f,1.520479f,-0.4851221f,-0.2157645f,-0.9158064f,-0.002406922f,0.3387311f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321684f,1.538043f,0.4829807f,-0.6544952f,-0.2082283f,-0.2499188f,0.6825083f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 7.778024f);
Get(0x6E70).SetLocalPose(-0.1520617f,1.674432f,-0.4634366f,0.4668686f,-0.4310613f,-0.5366282f,0.5552027f);
Get(0x6E82).SetLocalPose(-0.214183f,0.8262139f,-0.40075f,-0.116516f,0.1486326f,-0.03498441f,0.9813809f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 7.778024f);
Get(0x6EC6).SetLocalPose(0.3293314f,1.516592f,-0.4799288f,-0.2251092f,-0.9139028f,-0.02470535f,0.3368936f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321712f,1.538037f,0.4829714f,-0.6545008f,-0.2082226f,-0.2499048f,0.6825099f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 7.789938f);
Get(0x6E70).SetLocalPose(-0.1521447f,1.674489f,-0.4634125f,0.4669385f,-0.430934f,-0.5364362f,0.5554283f);
Get(0x6E82).SetLocalPose(-0.2141201f,0.8266454f,-0.4008311f,-0.1164718f,0.1487811f,-0.03492211f,0.9813659f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 7.789938f);
Get(0x6EC6).SetLocalPose(0.3348287f,1.511451f,-0.4758139f,-0.234878f,-0.911642f,-0.04526614f,0.3342037f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321688f,1.538157f,0.482949f,-0.6544952f,-0.2082157f,-0.2499038f,0.6825177f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 7.81827f);
Get(0x6E70).SetLocalPose(-0.1520496f,1.675004f,-0.4637256f,0.4670848f,-0.4305299f,-0.5360908f,0.5559519f);
Get(0x6E82).SetLocalPose(-0.2140218f,0.8267282f,-0.401383f,-0.1165348f,0.1492199f,-0.03474169f,0.9812982f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 7.81827f);
Get(0x6EC6).SetLocalPose(0.3518907f,1.49712f,-0.4605957f,-0.2651615f,-0.9008306f,-0.1051855f,0.3273067f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321709f,1.538114f,0.4829386f,-0.6545006f,-0.2082377f,-0.2498943f,0.6825092f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 7.834689f);
Get(0x6E70).SetLocalPose(-0.1526256f,1.67483f,-0.464331f,0.4671482f,-0.4301885f,-0.5358249f,0.5564191f);
Get(0x6E82).SetLocalPose(-0.2142942f,0.8271038f,-0.4013911f,-0.1165565f,0.14961f,-0.03467208f,0.9812387f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 7.834689f);
Get(0x6EC6).SetLocalPose(0.3659461f,1.480211f,-0.4464245f,-0.2916004f,-0.8871475f,-0.1598395f,0.319984f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321503f,1.538006f,0.4832236f,-0.6545199f,-0.2082275f,-0.2499495f,0.6824737f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 7.856719f);
Get(0x6E70).SetLocalPose(-0.1528343f,1.675257f,-0.4647339f,0.4672614f,-0.4298024f,-0.5353422f,0.5570866f);
Get(0x6E82).SetLocalPose(-0.2142139f,0.8269597f,-0.4012187f,-0.1165102f,0.1503599f,-0.03463703f,0.9811308f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 7.856719f);
Get(0x6EC6).SetLocalPose(0.3769943f,1.463664f,-0.4333596f,-0.3116805f,-0.8734434f,-0.2084894f,0.3106191f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321536f,1.537923f,0.4831914f,-0.654536f,-0.208217f,-0.2499204f,0.6824721f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 7.875739f);
Get(0x6E70).SetLocalPose(-0.1530068f,1.675307f,-0.4652352f,0.4673122f,-0.4295605f,-0.5347324f,0.5578157f);
Get(0x6E82).SetLocalPose(-0.214157f,0.8265173f,-0.4014395f,-0.1163527f,0.1511537f,-0.03457937f,0.9810296f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 7.875739f);
Get(0x6EC6).SetLocalPose(0.3882425f,1.442505f,-0.4184472f,-0.3273869f,-0.8526829f,-0.2723932f,0.3025751f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321581f,1.537922f,0.4831851f,-0.6545333f,-0.2082092f,-0.2499098f,0.682481f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 7.895017f);
Get(0x6E70).SetLocalPose(-0.1530904f,1.674822f,-0.4658528f,0.4672776f,-0.429572f,-0.533818f,0.558711f);
Get(0x6E82).SetLocalPose(-0.2141521f,0.8255092f,-0.4008707f,-0.1162217f,0.1520201f,-0.03465695f,0.9809084f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 7.895017f);
Get(0x6EC6).SetLocalPose(0.3958816f,1.423005f,-0.4056961f,-0.3336024f,-0.8296056f,-0.3304351f,0.3021204f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321538f,1.538027f,0.483097f,-0.6545243f,-0.2082113f,-0.2499263f,0.6824829f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 7.914381f);
Get(0x6E70).SetLocalPose(-0.1531886f,1.674606f,-0.4663143f,0.4671469f,-0.4298756f,-0.532893f,0.5594692f);
Get(0x6E82).SetLocalPose(-0.2142076f,0.8252324f,-0.4004463f,-0.1162865f,0.1527911f,-0.03478272f,0.9807765f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 7.914381f);
Get(0x6EC6).SetLocalPose(0.4019972f,1.400191f,-0.3931179f,-0.3376659f,-0.8016014f,-0.3888292f,0.3036921f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321504f,1.537947f,0.4830545f,-0.6545346f,-0.2082033f,-0.2499352f,0.6824721f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 7.933992f);
Get(0x6E70).SetLocalPose(-0.1532308f,1.674354f,-0.4668605f,0.46687f,-0.4306071f,-0.5317816f,0.5601949f);
Get(0x6E82).SetLocalPose(-0.2143353f,0.8247526f,-0.4003942f,-0.1165806f,0.1538185f,-0.03506007f,0.9805711f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 7.933992f);
Get(0x6EC6).SetLocalPose(0.407611f,1.366481f,-0.3776699f,-0.3446065f,-0.7614889f,-0.4598547f,0.2998577f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321544f,1.538029f,0.4830724f,-0.6545146f,-0.2082218f,-0.2499344f,0.6824861f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 7.953493f);
Get(0x6E70).SetLocalPose(-0.152509f,1.673865f,-0.4674864f,0.4666634f,-0.4314111f,-0.5307176f,0.5607571f);
Get(0x6E82).SetLocalPose(-0.2147483f,0.8244157f,-0.3999837f,-0.1172138f,0.154791f,-0.03545436f,0.9803284f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 7.953493f);
Get(0x6EC6).SetLocalPose(0.4098795f,1.339261f,-0.3677109f,-0.3487915f,-0.7305702f,-0.5098202f,0.2910242f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321431f,1.53797f,0.4831662f,-0.6545219f,-0.2082328f,-0.2499491f,0.6824703f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 7.972746f);
Get(0x6E70).SetLocalPose(-0.152085f,1.673948f,-0.4680212f,0.4665977f,-0.4322951f,-0.5296695f,0.5611219f);
Get(0x6E82).SetLocalPose(-0.2145079f,0.8247595f,-0.4001488f,-0.1181609f,0.1557217f,-0.03590121f,0.980051f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 7.972746f);
Get(0x6EC6).SetLocalPose(0.4104245f,1.301737f,-0.3563164f,-0.3477219f,-0.6864491f,-0.5760601f,0.2757392f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32151f,1.537997f,0.4832069f,-0.6545114f,-0.2082517f,-0.2499234f,0.682484f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 7.991697f);
Get(0x6E70).SetLocalPose(-0.1517837f,1.674468f,-0.4686427f,0.4666011f,-0.4333913f,-0.528687f,0.5612001f);
Get(0x6E82).SetLocalPose(-0.2142747f,0.8256814f,-0.4009759f,-0.1189899f,0.1560884f,-0.03630663f,0.9798774f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 7.991697f);
Get(0x6EC6).SetLocalPose(0.4087951f,1.269754f,-0.3486013f,-0.3434834f,-0.6470154f,-0.6283484f,0.2618559f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321429f,1.538068f,0.4832762f,-0.6545113f,-0.2082571f,-0.2499356f,0.682478f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 8.012073f);
Get(0x6E70).SetLocalPose(-0.151827f,1.674849f,-0.4691376f,0.4664713f,-0.4347808f,-0.5277309f,0.5611331f);
Get(0x6E82).SetLocalPose(-0.2146272f,0.8266979f,-0.4011164f,-0.1197366f,0.1561981f,-0.03685308f,0.9797485f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 8.012073f);
Get(0x6EC6).SetLocalPose(0.4028117f,1.222848f,-0.3413591f,-0.3387762f,-0.5884081f,-0.6941808f,0.2389973f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321566f,1.537966f,0.483272f,-0.6545188f,-0.2082157f,-0.2499474f,0.682479f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 8.031384f);
Get(0x6E70).SetLocalPose(-0.1514978f,1.675527f,-0.4696163f,0.4663131f,-0.436188f,-0.5266948f,0.5611459f);
Get(0x6E82).SetLocalPose(-0.2150014f,0.8274289f,-0.4010155f,-0.1204238f,0.1561155f,-0.03757742f,0.97965f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 8.031384f);
Get(0x6EC6).SetLocalPose(0.3958088f,1.187232f,-0.3386237f,-0.3364348f,-0.5448382f,-0.7359318f,0.2199263f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321661f,1.537973f,0.4832529f,-0.6545339f,-0.2082202f,-0.2499243f,0.6824718f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 8.059716f);
Get(0x6E70).SetLocalPose(-0.1507178f,1.676509f,-0.4700097f,0.4658316f,-0.438339f,-0.5252729f,0.5612025f);
Get(0x6E82).SetLocalPose(-0.2161106f,0.8284105f,-0.4001923f,-0.1215172f,0.1558138f,-0.03902576f,0.9795064f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 8.059716f);
Get(0x6EC6).SetLocalPose(0.3777835f,1.12609f,-0.3387406f,-0.3160059f,-0.4684178f,-0.8030613f,0.1892555f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32166f,1.538012f,0.4832144f,-0.6545309f,-0.208267f,-0.249914f,0.6824641f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 8.07852f);
Get(0x6E70).SetLocalPose(-0.15016f,1.677492f,-0.4703544f,0.4653354f,-0.4400457f,-0.5243757f,0.5611176f);
Get(0x6E82).SetLocalPose(-0.216712f,0.8287348f,-0.4006813f,-0.1221315f,0.1550113f,-0.04009205f,0.9795142f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 8.07852f);
Get(0x6EC6).SetLocalPose(0.3646686f,1.091436f,-0.3419419f,-0.2978916f,-0.423547f,-0.8375439f,0.174324f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321621f,1.538016f,0.4831601f,-0.6545463f,-0.2082257f,-0.2499258f,0.6824575f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 8.097702f);
Get(0x6E70).SetLocalPose(-0.1497115f,1.677553f,-0.4706882f,0.4649501f,-0.4417585f,-0.5233287f,0.5610687f);
Get(0x6E82).SetLocalPose(-0.2182225f,0.8292521f,-0.4012681f,-0.1225464f,0.1536793f,-0.04149542f,0.9796138f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 8.097702f);
Get(0x6EC6).SetLocalPose(0.3470816f,1.048536f,-0.3492663f,-0.2810971f,-0.369417f,-0.8717631f,0.156667f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321548f,1.537948f,0.4831997f,-0.654544f,-0.2082131f,-0.2499186f,0.6824663f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 8.117146f);
Get(0x6E70).SetLocalPose(-0.1496137f,1.678085f,-0.4711151f,0.4647177f,-0.4432862f,-0.5223504f,0.5609678f);
Get(0x6E82).SetLocalPose(-0.2191191f,0.8295181f,-0.4016434f,-0.1225859f,0.1522178f,-0.04275608f,0.9797828f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 8.117146f);
Get(0x6EC6).SetLocalPose(0.3269679f,1.008043f,-0.3605085f,-0.2700333f,-0.3196482f,-0.8973128f,0.1404875f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32154f,1.537981f,0.4832382f,-0.6545502f,-0.2082023f,-0.2499238f,0.6824617f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 8.136609f);
Get(0x6E70).SetLocalPose(-0.1490164f,1.678665f,-0.4713474f,0.4642154f,-0.4452749f,-0.521341f,0.5607477f);
Get(0x6E82).SetLocalPose(-0.220019f,0.8297387f,-0.402659f,-0.1219948f,0.1504331f,-0.04377677f,0.9800871f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 8.136609f);
Get(0x6EC6).SetLocalPose(0.308037f,0.974797f,-0.3721457f,-0.2513909f,-0.2726154f,-0.9205348f,0.1228792f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321421f,1.538104f,0.4832306f,-0.6545594f,-0.2082289f,-0.2499404f,0.6824387f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 8.155846f);
Get(0x6E70).SetLocalPose(-0.1480535f,1.679352f,-0.4716274f,0.4636417f,-0.4468829f,-0.5207276f,0.560513f);
Get(0x6E82).SetLocalPose(-0.221194f,0.83011f,-0.403381f,-0.121439f,0.1487169f,-0.04368172f,0.9804223f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 8.155846f);
Get(0x6EC6).SetLocalPose(0.2878185f,0.9452249f,-0.3853686f,-0.2202901f,-0.2223514f,-0.9438857f,0.1054127f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321305f,1.5382f,0.4832934f,-0.6545439f,-0.2082053f,-0.2499201f,0.6824682f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 8.174836f);
Get(0x6E70).SetLocalPose(-0.1471277f,1.679585f,-0.4719561f,0.4630775f,-0.4484174f,-0.5200199f,0.5604109f);
Get(0x6E82).SetLocalPose(-0.2218484f,0.8305179f,-0.4044266f,-0.120402f,0.1465386f,-0.04310812f,0.9809034f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 8.174836f);
Get(0x6EC6).SetLocalPose(0.2709284f,0.9216725f,-0.3988059f,-0.1910043f,-0.1796935f,-0.9605301f,0.0927876f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32139f,1.53807f,0.4833568f,-0.6545493f,-0.208212f,-0.2499386f,0.6824542f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 8.193685f);
Get(0x6E70).SetLocalPose(-0.1462374f,1.679512f,-0.4722657f,0.4625244f,-0.4498858f,-0.5191121f,0.5605324f);
Get(0x6E82).SetLocalPose(-0.2232711f,0.8301775f,-0.405916f,-0.1188082f,0.1430061f,-0.04227969f,0.9816549f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 8.193685f);
Get(0x6EC6).SetLocalPose(0.2465718f,0.8917063f,-0.4189074f,-0.1629772f,-0.1230542f,-0.9756399f,0.0801441f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321512f,1.537973f,0.483295f,-0.6545515f,-0.2082234f,-0.2498988f,0.6824631f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 8.213081f);
Get(0x6E70).SetLocalPose(-0.145307f,1.680353f,-0.4722392f,0.4616067f,-0.4519536f,-0.5174837f,0.5611309f);
Get(0x6E82).SetLocalPose(-0.2242489f,0.8301851f,-0.4071679f,-0.1175663f,0.1381039f,-0.04100346f,0.98256f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 8.213081f);
Get(0x6EC6).SetLocalPose(0.2318144f,0.8747132f,-0.4326047f,-0.1548873f,-0.08649817f,-0.9815179f,0.07176761f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321614f,1.538013f,0.48324f,-0.6545505f,-0.2082341f,-0.2499028f,0.6824595f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 8.233602f);
Get(0x6E70).SetLocalPose(-0.1440203f,1.680863f,-0.4722742f,0.4605811f,-0.4537633f,-0.516179f,0.5617145f);
Get(0x6E82).SetLocalPose(-0.2252812f,0.830633f,-0.4089093f,-0.1164985f,0.1300897f,-0.03845344f,0.9838832f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 8.233602f);
Get(0x6EC6).SetLocalPose(0.2124558f,0.8535109f,-0.4516171f,-0.1414407f,-0.03418209f,-0.9877483f,0.05638842f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321607f,1.53804f,0.4832036f,-0.6545444f,-0.2081999f,-0.2499207f,0.6824692f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 8.253359f);
Get(0x6E70).SetLocalPose(-0.1425573f,1.681291f,-0.472009f,0.4594165f,-0.4554964f,-0.515226f,0.5621403f);
Get(0x6E82).SetLocalPose(-0.2263382f,0.8314023f,-0.4106354f,-0.1156979f,0.1236049f,-0.03677475f,0.9848773f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 8.253359f);
Get(0x6EC6).SetLocalPose(0.1971394f,0.8399755f,-0.4667177f,-0.1330445f,-0.0002366848f,-0.9900823f,0.04512612f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32165f,1.53801f,0.4832093f,-0.6545469f,-0.208227f,-0.2499204f,0.6824586f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 8.273616f);
Get(0x6E70).SetLocalPose(-0.1412573f,1.681121f,-0.4721415f,0.4587414f,-0.4566304f,-0.5144734f,0.5624607f);
Get(0x6E82).SetLocalPose(-0.2273533f,0.8316768f,-0.412063f,-0.1150467f,0.1154324f,-0.03566617f,0.9859856f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 8.273616f);
Get(0x6EC6).SetLocalPose(0.1886842f,0.8328147f,-0.4761261f,-0.1352711f,0.01593446f,-0.9899275f,0.03861883f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321648f,1.538048f,0.4831464f,-0.6545458f,-0.2082281f,-0.2499231f,0.6824582f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 8.29361f);
Get(0x6E70).SetLocalPose(-0.1400165f,1.681632f,-0.4721831f,0.4583541f,-0.4575027f,-0.5134623f,0.5629914f);
Get(0x6E82).SetLocalPose(-0.228692f,0.8316333f,-0.4137787f,-0.1143712f,0.1059615f,-0.03573237f,0.9871244f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 8.29361f);
Get(0x6EC6).SetLocalPose(0.1787808f,0.8266442f,-0.4857727f,-0.1493099f,0.02807891f,-0.9878204f,0.03359823f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321692f,1.538228f,0.4832116f,-0.6545473f,-0.2082377f,-0.2498993f,0.6824626f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 8.313518f);
Get(0x6E70).SetLocalPose(-0.1386283f,1.6824f,-0.4723681f,0.4581144f,-0.4583585f,-0.5124328f,0.5634283f);
Get(0x6E82).SetLocalPose(-0.2295087f,0.8310975f,-0.4147407f,-0.1143784f,0.09448457f,-0.03692187f,0.9882444f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 8.313518f);
Get(0x6EC6).SetLocalPose(0.1737879f,0.8243368f,-0.4901422f,-0.165159f,0.0340383f,-0.9852107f,0.03039756f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321649f,1.538391f,0.4833188f,-0.6545516f,-0.2082373f,-0.2498847f,0.682464f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 8.332541f);
Get(0x6E70).SetLocalPose(-0.1376134f,1.682393f,-0.4721948f,0.4578525f,-0.4591417f,-0.5118743f,0.5635111f);
Get(0x6E82).SetLocalPose(-0.230528f,0.8312153f,-0.4153369f,-0.1149038f,0.08287301f,-0.03836512f,0.98917f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 8.332541f);
Get(0x6EC6).SetLocalPose(0.1695967f,0.820209f,-0.494921f,-0.2057949f,0.04442306f,-0.9772158f,0.02691483f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321725f,1.538571f,0.4833144f,-0.6545487f,-0.2082556f,-0.2498737f,0.6824653f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 8.351647f);
Get(0x6E70).SetLocalPose(-0.1367507f,1.682397f,-0.4721657f,0.4578196f,-0.4597045f,-0.5117297f,0.5632103f);
Get(0x6E82).SetLocalPose(-0.2319537f,0.8310148f,-0.415858f,-0.1156314f,0.06951428f,-0.0399832f,0.9900498f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 8.351647f);
Get(0x6EC6).SetLocalPose(0.1721134f,0.8183953f,-0.497792f,-0.2468811f,0.04125106f,-0.9675598f,0.03429517f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.3217f,1.538418f,0.483414f,-0.6545632f,-0.2082423f,-0.2498941f,0.6824479f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 8.379436f);
Get(0x6E70).SetLocalPose(-0.1357192f,1.683153f,-0.4722207f,0.4584196f,-0.4600073f,-0.5117456f,0.5624601f);
Get(0x6E82).SetLocalPose(-0.2348046f,0.8312355f,-0.4170318f,-0.1169153f,0.05006839f,-0.04213532f,0.9909837f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 8.379436f);
Get(0x6EC6).SetLocalPose(0.1735492f,0.8196092f,-0.4987077f,-0.2534999f,0.02402394f,-0.9657169f,0.05051249f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321689f,1.538123f,0.4835094f,-0.6545641f,-0.208222f,-0.2499134f,0.6824462f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 8.399181f);
Get(0x6E70).SetLocalPose(-0.1351602f,1.68278f,-0.4723114f,0.4594048f,-0.4600894f,-0.5115652f,0.5617527f);
Get(0x6E82).SetLocalPose(-0.2363461f,0.8306139f,-0.4182499f,-0.1176916f,0.03601979f,-0.04345264f,0.991445f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 8.399181f);
Get(0x6EC6).SetLocalPose(0.174461f,0.8227675f,-0.4997656f,-0.256578f,0.01608742f,-0.9648274f,0.05492781f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321457f,1.537987f,0.4836746f,-0.6545645f,-0.2082245f,-0.2499131f,0.6824452f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 8.418444f);
Get(0x6E70).SetLocalPose(-0.1347494f,1.682918f,-0.472157f,0.4604244f,-0.4599941f,-0.5114454f,0.5611047f);
Get(0x6E82).SetLocalPose(-0.2380269f,0.8306563f,-0.4189115f,-0.1180204f,0.02305695f,-0.04436668f,0.9917516f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 8.418444f);
Get(0x6EC6).SetLocalPose(0.1756396f,0.824227f,-0.5000507f,-0.2563778f,0.01428144f,-0.9650297f,0.05276538f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321495f,1.53788f,0.4836138f,-0.6545507f,-0.2082125f,-0.2499028f,0.6824659f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 8.437465f);
Get(0x6E70).SetLocalPose(-0.1345561f,1.682628f,-0.4725344f,0.4616107f,-0.4596522f,-0.5117835f,0.560101f);
Get(0x6E82).SetLocalPose(-0.2389574f,0.8302237f,-0.4186229f,-0.1179629f,0.01359992f,-0.04465628f,0.9919202f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 8.437465f);
Get(0x6EC6).SetLocalPose(0.1756997f,0.8266524f,-0.5008978f,-0.2505803f,0.01483186f,-0.9667169f,0.04947727f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321534f,1.537864f,0.4833456f,-0.6545491f,-0.2081919f,-0.2499286f,0.6824641f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 8.456396f);
Get(0x6E70).SetLocalPose(-0.1342122f,1.681968f,-0.4728886f,0.4627387f,-0.4592212f,-0.5123543f,0.5590008f);
Get(0x6E82).SetLocalPose(-0.2398898f,0.8293316f,-0.4183395f,-0.1177748f,0.006672079f,-0.04459724f,0.992016f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 8.456396f);
Get(0x6EC6).SetLocalPose(0.1766049f,0.8292918f,-0.5013684f,-0.2398573f,0.01716251f,-0.9695726f,0.04585595f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321334f,1.537944f,0.483272f,-0.6545421f,-0.2082163f,-0.2499304f,0.6824627f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 8.475577f);
Get(0x6E70).SetLocalPose(-0.1344327f,1.681567f,-0.4731694f,0.464081f,-0.4588573f,-0.512972f,0.5576187f);
Get(0x6E82).SetLocalPose(-0.2403134f,0.8298473f,-0.4172515f,-0.1176148f,0.003186479f,-0.04469958f,0.9920477f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 8.475577f);
Get(0x6EC6).SetLocalPose(0.1766566f,0.8296944f,-0.5018715f,-0.2315167f,0.01895143f,-0.9716554f,0.04389522f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321304f,1.537975f,0.4833376f,-0.6545529f,-0.2082187f,-0.2499186f,0.682456f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 8.494811f);
Get(0x6E70).SetLocalPose(-0.1345884f,1.681002f,-0.4736494f,0.4652935f,-0.4586789f,-0.5133184f,0.5564349f);
Get(0x6E82).SetLocalPose(-0.2404241f,0.8294027f,-0.4156179f,-0.1180693f,0.001877449f,-0.0454446f,0.9919632f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 8.494811f);
Get(0x6EC6).SetLocalPose(0.1766887f,0.8295537f,-0.5037498f,-0.2173751f,0.02084469f,-0.974972f,0.04175158f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321341f,1.537965f,0.4832576f,-0.6545588f,-0.2081993f,-0.2499403f,0.6824483f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 8.514729f);
Get(0x6E70).SetLocalPose(-0.1347407f,1.681451f,-0.4739111f,0.466492f,-0.4585874f,-0.5135156f,0.5553239f);
Get(0x6E82).SetLocalPose(-0.2403391f,0.828679f,-0.414216f,-0.1185906f,0.005911311f,-0.04603645f,0.9918579f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 8.514729f);
Get(0x6EC6).SetLocalPose(0.1772821f,0.8303244f,-0.50344f,-0.210296f,0.02156798f,-0.9765395f,0.04100152f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321432f,1.538108f,0.4832386f,-0.6545557f,-0.2082159f,-0.2499468f,0.6824439f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 8.534669f);
Get(0x6E70).SetLocalPose(-0.134948f,1.681124f,-0.4742804f,0.4673706f,-0.4585358f,-0.5136929f,0.5544631f);
Get(0x6E82).SetLocalPose(-0.2395849f,0.8284244f,-0.4119392f,-0.1210376f,0.0207912f,-0.04736779f,0.9912991f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 8.534669f);
Get(0x6EC6).SetLocalPose(0.177136f,0.8298017f,-0.5038894f,-0.2072647f,0.02229723f,-0.9771819f,0.04073948f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321492f,1.53807f,0.4831128f,-0.6545641f,-0.2082081f,-0.2499152f,0.6824497f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 8.554083f);
Get(0x6E70).SetLocalPose(-0.1349264f,1.68032f,-0.4745118f,0.468147f,-0.4583983f,-0.5139123f,0.553718f);
Get(0x6E82).SetLocalPose(-0.239849f,0.828648f,-0.4099624f,-0.1258606f,0.03799822f,-0.05217636f,0.9899459f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 8.554083f);
Get(0x6EC6).SetLocalPose(0.176861f,0.8296888f,-0.5044832f,-0.2064733f,0.02337158f,-0.9773432f,0.04028489f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321495f,1.538126f,0.4831688f,-0.6545449f,-0.2082081f,-0.2499376f,0.68246f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 8.574008f);
Get(0x6E70).SetLocalPose(-0.1349607f,1.680268f,-0.4750779f,0.4691133f,-0.4579292f,-0.5143068f,0.5529214f);
Get(0x6E82).SetLocalPose(-0.2413923f,0.8288873f,-0.405827f,-0.1343358f,0.05289643f,-0.06052203f,0.9876705f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 8.574008f);
Get(0x6EC6).SetLocalPose(0.1777976f,0.8279884f,-0.5036345f,-0.2058522f,0.02438384f,-0.977468f,0.03983249f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321472f,1.538106f,0.4832099f,-0.654536f,-0.2082237f,-0.2499129f,0.6824728f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 8.593684f);
Get(0x6E70).SetLocalPose(-0.1351462f,1.679572f,-0.4757727f,0.4700927f,-0.4572934f,-0.5147486f,0.5522043f);
Get(0x6E82).SetLocalPose(-0.2436023f,0.8285031f,-0.4013753f,-0.1406382f,0.05653989f,-0.06648679f,0.9862067f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 8.593684f);
Get(0x6EC6).SetLocalPose(0.1778708f,0.8269552f,-0.5014818f,-0.2031238f,0.02394008f,-0.9780368f,0.04014469f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321458f,1.538147f,0.4833052f,-0.6545531f,-0.2082284f,-0.2499066f,0.6824573f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 8.613282f);
Get(0x6E70).SetLocalPose(-0.1351374f,1.679103f,-0.4763742f,0.4706405f,-0.4568736f,-0.5148205f,0.5520181f);
Get(0x6E82).SetLocalPose(-0.2498139f,0.8294395f,-0.3913659f,-0.1457289f,0.04599266f,-0.07415786f,0.9854686f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 8.613282f);
Get(0x6EC6).SetLocalPose(0.1778176f,0.8268637f,-0.5006019f,-0.1995235f,0.02184395f,-0.9787528f,0.0419079f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321473f,1.538247f,0.4833506f,-0.654546f,-0.2082623f,-0.2499062f,0.6824539f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 8.63273f);
Get(0x6E70).SetLocalPose(-0.1350164f,1.678849f,-0.4771809f,0.4709405f,-0.4566573f,-0.5146599f,0.5520911f);
Get(0x6E82).SetLocalPose(-0.2562121f,0.8311476f,-0.3816636f,-0.1492584f,0.02927039f,-0.07923993f,0.9851834f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 8.63273f);
Get(0x6EC6).SetLocalPose(0.1770223f,0.8266975f,-0.4998292f,-0.1960501f,0.01950553f,-0.9794022f,0.0442175f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321572f,1.538157f,0.4832878f,-0.654534f,-0.2082389f,-0.2498831f,0.682481f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 8.652523f);
Get(0x6E70).SetLocalPose(-0.1344615f,1.678761f,-0.4783658f,0.4713034f,-0.4564596f,-0.5144523f,0.5521383f);
Get(0x6E82).SetLocalPose(-0.267834f,0.8355569f,-0.3644349f,-0.1552669f,-0.001945473f,-0.08512509f,0.9841962f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 8.652523f);
Get(0x6EC6).SetLocalPose(0.175328f,0.8265704f,-0.4988005f,-0.1902546f,0.01554668f,-0.9804159f,0.04843765f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321601f,1.538116f,0.483381f,-0.6545426f,-0.2082335f,-0.2498799f,0.6824755f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 8.672116f);
Get(0x6E70).SetLocalPose(-0.134375f,1.678717f,-0.4792908f,0.4716203f,-0.4563773f,-0.514406f,0.5519788f);
Get(0x6E82).SetLocalPose(-0.2818779f,0.8436736f,-0.3454084f,-0.1655894f,-0.03536545f,-0.09005333f,0.9814377f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 8.672116f);
Get(0x6EC6).SetLocalPose(0.174487f,0.8278109f,-0.4971429f,-0.1861032f,0.01292008f,-0.9811124f,0.05115987f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321542f,1.538156f,0.4834233f,-0.6545479f,-0.2082281f,-0.2499038f,0.6824633f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 8.699358f);
Get(0x6E70).SetLocalPose(-0.1342587f,1.678947f,-0.4809785f,0.4720526f,-0.4563982f,-0.5142752f,0.5517138f);
Get(0x6E82).SetLocalPose(-0.3014498f,0.8576297f,-0.3178302f,-0.1888912f,-0.07735771f,-0.0998328f,0.9738426f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 8.699358f);
Get(0x6EC6).SetLocalPose(0.1735844f,0.8275345f,-0.494667f,-0.1802221f,0.01001437f,-0.9821029f,0.05379248f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321652f,1.538317f,0.48326f,-0.6545424f,-0.208234f,-0.2499038f,0.6824668f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 8.719395f);
Get(0x6E70).SetLocalPose(-0.1344308f,1.679274f,-0.4820337f,0.4720995f,-0.4567285f,-0.5140644f,0.5515968f);
Get(0x6E82).SetLocalPose(-0.3186883f,0.8731597f,-0.2948475f,-0.2137378f,-0.1087861f,-0.1098686f,0.9645779f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 8.719395f);
Get(0x6EC6).SetLocalPose(0.1731334f,0.8272328f,-0.4938284f,-0.1772275f,0.008724675f,-0.9826227f,0.05446852f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321676f,1.53821f,0.4832859f,-0.6545492f,-0.2082484f,-0.2499123f,0.6824528f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 8.739227f);
Get(0x6E70).SetLocalPose(-0.1346188f,1.679477f,-0.4829405f,0.4718454f,-0.4572983f,-0.5139245f,0.5514725f);
Get(0x6E82).SetLocalPose(-0.3333071f,0.8888139f,-0.2752356f,-0.2378077f,-0.1341541f,-0.1193267f,0.9545739f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 8.739227f);
Get(0x6EC6).SetLocalPose(0.1729884f,0.828639f,-0.4937781f,-0.1745144f,0.007377237f,-0.9830731f,0.05529591f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321646f,1.538238f,0.4832918f,-0.6545555f,-0.2082456f,-0.2498802f,0.6824594f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 8.75919f);
Get(0x6E70).SetLocalPose(-0.1347379f,1.679347f,-0.4837987f,0.4716318f,-0.457827f,-0.5138984f,0.5512407f);
Get(0x6E82).SetLocalPose(-0.3559915f,0.9171802f,-0.2453696f,-0.2804685f,-0.1727016f,-0.1395511f,0.9338293f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 8.75919f);
Get(0x6EC6).SetLocalPose(0.1736509f,0.8295131f,-0.4940995f,-0.1721144f,0.0056754f,-0.9834308f,0.05664233f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321713f,1.538095f,0.4833148f,-0.6545513f,-0.2082542f,-0.2498825f,0.68246f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 8.779021f);
Get(0x6E70).SetLocalPose(-0.1344815f,1.679097f,-0.4849766f,0.4714816f,-0.4583751f,-0.5140885f,0.5507362f);
Get(0x6E82).SetLocalPose(-0.3734926f,0.9443973f,-0.2221383f,-0.3188716f,-0.1983477f,-0.1623399f,0.9124827f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 8.779021f);
Get(0x6EC6).SetLocalPose(0.174275f,0.8297008f,-0.4937545f,-0.1700648f,0.003261227f,-0.9837007f,0.05831161f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321687f,1.538072f,0.4832716f,-0.654557f,-0.2082644f,-0.2498943f,0.6824471f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 8.798749f);
Get(0x6E70).SetLocalPose(-0.1349823f,1.679673f,-0.4859378f,0.4714263f,-0.4587632f,-0.5144292f,0.5501421f);
Get(0x6E82).SetLocalPose(-0.3950656f,0.9839277f,-0.1963946f,-0.3714577f,-0.2317848f,-0.1890382f,0.8789538f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 8.798749f);
Get(0x6EC6).SetLocalPose(0.1744118f,0.829583f,-0.4938397f,-0.1687483f,0.00165955f,-0.9838544f,0.05959842f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321646f,1.538152f,0.4834334f,-0.6545688f,-0.2082571f,-0.2498881f,0.6824403f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 8.818442f);
Get(0x6E70).SetLocalPose(-0.1347435f,1.679962f,-0.4870739f,0.4713385f,-0.4591027f,-0.5147709f,0.5496141f);
Get(0x6E82).SetLocalPose(-0.4131653f,1.021797f,-0.1757262f,-0.4148514f,-0.2647381f,-0.2018654f,0.8467954f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 8.818442f);
Get(0x6EC6).SetLocalPose(0.1750168f,0.8298656f,-0.4928078f,-0.1679182f,0.0004205983f,-0.9839427f,0.06049862f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321701f,1.53816f,0.4834066f,-0.6545656f,-0.2082611f,-0.2498814f,0.6824446f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 8.837958f);
Get(0x6E70).SetLocalPose(-0.1348787f,1.680076f,-0.4880967f,0.471087f,-0.4595479f,-0.5150678f,0.5491794f);
Get(0x6E82).SetLocalPose(-0.4293541f,1.060808f,-0.1591647f,-0.455685f,-0.299958f,-0.2048789f,0.8126507f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 8.837958f);
Get(0x6EC6).SetLocalPose(0.1754713f,0.8288398f,-0.4930766f,-0.1672811f,7.785577E-05f,-0.984028f,0.06087683f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321395f,1.538254f,0.4835411f,-0.6545386f,-0.2082904f,-0.2499294f,0.6824439f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 8.858895f);
Get(0x6E70).SetLocalPose(-0.1345013f,1.68075f,-0.4890377f,0.4708759f,-0.4600628f,-0.5153793f,0.5486368f);
Get(0x6E82).SetLocalPose(-0.4463772f,1.107783f,-0.1445075f,-0.5019699f,-0.3389565f,-0.2025999f,0.7694726f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 8.858895f);
Get(0x6EC6).SetLocalPose(0.175742f,0.828867f,-0.4928258f,-0.1664826f,0.0001411673f,-0.9841455f,0.06116669f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321531f,1.538067f,0.4833274f,-0.654545f,-0.2082694f,-0.2499195f,0.6824478f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 8.87845f);
Get(0x6E70).SetLocalPose(-0.1344808f,1.681063f,-0.489669f,0.4707965f,-0.4605437f,-0.5156273f,0.548068f);
Get(0x6E82).SetLocalPose(-0.4623379f,1.161419f,-0.1342237f,-0.5518959f,-0.3767712f,-0.1926831f,0.7185594f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 8.87845f);
Get(0x6EC6).SetLocalPose(0.175646f,0.8303624f,-0.4921661f,-0.1652005f,6.018567E-05f,-0.9843366f,0.06156719f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321467f,1.538204f,0.4832546f,-0.6545497f,-0.2082632f,-0.2499161f,0.6824464f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 8.899133f);
Get(0x6E70).SetLocalPose(-0.1349094f,1.681458f,-0.4900601f,0.4707702f,-0.4609464f,-0.5158116f,0.5475786f);
Get(0x6E82).SetLocalPose(-0.4725296f,1.207927f,-0.1304019f,-0.5952189f,-0.4060267f,-0.1759968f,0.6707324f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 8.899133f);
Get(0x6EC6).SetLocalPose(0.1754319f,0.8315679f,-0.4925685f,-0.1641151f,-0.0004215917f,-0.9844861f,0.06207392f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321424f,1.538257f,0.4833309f,-0.6545349f,-0.2082919f,-0.2498952f,0.6824596f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 8.919012f);
Get(0x6E70).SetLocalPose(-0.1355256f,1.681847f,-0.4906898f,0.4708092f,-0.4614275f,-0.5158488f,0.5471047f);
Get(0x6E82).SetLocalPose(-0.4801644f,1.262444f,-0.1317649f,-0.6434835f,-0.4330593f,-0.1483525f,0.6134983f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 8.919012f);
Get(0x6EC6).SetLocalPose(0.175527f,0.8316755f,-0.4925531f,-0.1627987f,-0.001375005f,-0.9846604f,0.06275716f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321293f,1.538348f,0.4833442f,-0.6545317f,-0.2082868f,-0.2498919f,0.6824654f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 8.938558f);
Get(0x6E70).SetLocalPose(-0.1356784f,1.68158f,-0.4913004f,0.4707027f,-0.4618694f,-0.515726f,0.5469392f);
Get(0x6E82).SetLocalPose(-0.4832878f,1.311996f,-0.1380771f,-0.685506f,-0.4472629f,-0.1166981f,0.5625114f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 8.938558f);
Get(0x6EC6).SetLocalPose(0.1759453f,0.8316317f,-0.4923898f,-0.1612675f,-0.002570863f,-0.9848579f,0.06356917f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321677f,1.53839f,0.4832257f,-0.6545357f,-0.2082703f,-0.2498779f,0.6824718f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 8.958035f);
Get(0x6E70).SetLocalPose(-0.1357604f,1.681515f,-0.4914775f,0.4702868f,-0.4623787f,-0.5154688f,0.5471088f);
Get(0x6E82).SetLocalPose(-0.4822997f,1.351425f,-0.1477641f,-0.7216444f,-0.4495491f,-0.08759995f,0.5190966f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 8.958035f);
Get(0x6EC6).SetLocalPose(0.1762044f,0.8316119f,-0.4919632f,-0.1602295f,-0.003684276f,-0.9849737f,0.0643416f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321822f,1.53829f,0.4832339f,-0.6545263f,-0.2082727f,-0.2498736f,0.6824815f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 8.977117f);
Get(0x6E70).SetLocalPose(-0.1357374f,1.681472f,-0.4914235f,0.4698247f,-0.4626776f,-0.5153099f,0.5474029f);
Get(0x6E82).SetLocalPose(-0.4751862f,1.405695f,-0.1679388f,-0.7734337f,-0.437885f,-0.05353735f,0.4551822f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 8.977117f);
Get(0x6EC6).SetLocalPose(0.1758093f,0.8312233f,-0.491575f,-0.1598921f,-0.005018971f,-0.9849702f,0.06513841f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321855f,1.538373f,0.4833186f,-0.6545308f,-0.2082611f,-0.2498719f,0.6824814f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 8.996335f);
Get(0x6E70).SetLocalPose(-0.1354732f,1.682371f,-0.4913264f,0.4684359f,-0.4632875f,-0.5151049f,0.5482695f);
Get(0x6E82).SetLocalPose(-0.4657607f,1.443045f,-0.1854818f,-0.8106855f,-0.4203708f,-0.03648169f,0.4058899f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 8.996335f);
Get(0x6EC6).SetLocalPose(0.1757614f,0.8306323f,-0.4910687f,-0.1597836f,-0.006431082f,-0.9849242f,0.06597177f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321859f,1.538192f,0.483243f,-0.6545121f,-0.208264f,-0.2498851f,0.6824936f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 9.01545f);
Get(0x6E70).SetLocalPose(-0.135283f,1.682209f,-0.4911273f,0.4673774f,-0.4634649f,-0.5151632f,0.5489677f);
Get(0x6E82).SetLocalPose(-0.4560198f,1.473026f,-0.203519f,-0.8408541f,-0.4006003f,-0.02329183f,0.3632372f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 9.01545f);
Get(0x6EC6).SetLocalPose(0.1757444f,0.8307411f,-0.4899399f,-0.1598936f,-0.007058554f,-0.9848757f,0.06636268f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321753f,1.538316f,0.4831602f,-0.6545152f,-0.2082606f,-0.2499034f,0.682485f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 9.034693f);
Get(0x6E70).SetLocalPose(-0.1352873f,1.682334f,-0.4909277f,0.4669938f,-0.4634563f,-0.5151423f,0.5493209f);
Get(0x6E82).SetLocalPose(-0.4361965f,1.513368f,-0.2361966f,-0.8887692f,-0.3562455f,-0.006528215f,0.2883329f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 9.034693f);
Get(0x6EC6).SetLocalPose(0.17605f,0.8297234f,-0.489925f,-0.1601787f,-0.008143203f,-0.9847793f,0.06697978f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321853f,1.538297f,0.4831205f,-0.6544998f,-0.2082833f,-0.2498761f,0.6825028f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 9.05372f);
Get(0x6E70).SetLocalPose(-0.1351114f,1.682456f,-0.4908037f,0.4665336f,-0.4633358f,-0.5150797f,0.5498722f);
Get(0x6E82).SetLocalPose(-0.4171882f,1.539518f,-0.2645921f,-0.9248995f,-0.309419f,-0.01078962f,0.220691f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 9.05372f);
Get(0x6EC6).SetLocalPose(0.1765062f,0.828853f,-0.490312f,-0.1611106f,-0.009793182f,-0.9845644f,0.06767867f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321942f,1.538337f,0.4831427f,-0.6545117f,-0.2082729f,-0.2498647f,0.6824988f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 9.073044f);
Get(0x6E70).SetLocalPose(-0.1353901f,1.682834f,-0.4906746f,0.465785f,-0.4630324f,-0.5148337f,0.5509915f);
Get(0x6E82).SetLocalPose(-0.3945675f,1.558072f,-0.2939895f,-0.9550362f,-0.2571611f,-0.03862805f,0.142415f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 9.073044f);
Get(0x6EC6).SetLocalPose(0.1770234f,0.8284823f,-0.4900665f,-0.1617685f,-0.01080879f,-0.9844323f,0.06787711f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321957f,1.538373f,0.4831306f,-0.6545053f,-0.2082721f,-0.2498633f,0.6825057f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 9.092199f);
Get(0x6E70).SetLocalPose(-0.1345692f,1.682131f,-0.4909211f,0.4652365f,-0.4628254f,-0.5146914f,0.5517612f);
Get(0x6E82).SetLocalPose(-0.3712238f,1.568092f,-0.3207757f,-0.9746868f,-0.2019657f,-0.07662269f,0.05765932f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 9.092199f);
Get(0x6EC6).SetLocalPose(0.1776505f,0.8278928f,-0.4901014f,-0.1624144f,-0.01233122f,-0.9842916f,0.06811453f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321973f,1.538251f,0.4831678f,-0.6545107f,-0.2082655f,-0.2498823f,0.6824955f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 9.111854f);
Get(0x6E70).SetLocalPose(-0.134341f,1.682165f,-0.4908774f,0.4645357f,-0.4627305f,-0.5145083f,0.5526015f);
Get(0x6E82).SetLocalPose(-0.3465017f,1.572315f,-0.344985f,-0.9822464f,-0.1452814f,-0.115002f,-0.02932258f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 9.111854f);
Get(0x6EC6).SetLocalPose(0.1775807f,0.8277101f,-0.4898325f,-0.1631478f,-0.01418799f,-0.9841426f,0.06815313f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321919f,1.538266f,0.4831226f,-0.6544986f,-0.2082813f,-0.2498999f,0.6824958f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 9.139871f);
Get(0x6E70).SetLocalPose(-0.1339377f,1.68277f,-0.491376f,0.4634595f,-0.4627334f,-0.5139663f,0.5540052f);
Get(0x6E82).SetLocalPose(-0.3139891f,1.567382f,-0.3748835f,-0.9732569f,-0.06837915f,-0.1617678f,-0.1480755f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 9.139871f);
Get(0x6EC6).SetLocalPose(0.1778293f,0.8272402f,-0.4887217f,-0.1636305f,-0.01658088f,-0.9840257f,0.06814391f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321965f,1.538223f,0.483046f,-0.6544832f,-0.2082753f,-0.2498724f,0.6825225f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 9.159049f);
Get(0x6E70).SetLocalPose(-0.1342978f,1.684127f,-0.4915121f,0.4622113f,-0.4630758f,-0.5131295f,0.5555354f);
Get(0x6E82).SetLocalPose(-0.2941037f,1.560031f,-0.3889667f,-0.9575473f,-0.02517715f,-0.1847652f,-0.2198434f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 9.159049f);
Get(0x6EC6).SetLocalPose(0.177376f,0.8271427f,-0.490194f,-0.1646151f,-0.0191828f,-0.9838367f,0.06781951f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321717f,1.53833f,0.4831676f,-0.6544964f,-0.2082698f,-0.2498845f,0.6825072f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 9.178719f);
Get(0x6E70).SetLocalPose(-0.1342129f,1.684651f,-0.4912497f,0.4605862f,-0.4638587f,-0.5123968f,0.5569067f);
Get(0x6E82).SetLocalPose(-0.2747585f,1.551271f,-0.4013335f,-0.9380451f,0.01264581f,-0.1956451f,-0.2857175f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 9.178719f);
Get(0x6EC6).SetLocalPose(0.1771587f,0.8280699f,-0.4905124f,-0.1660232f,-0.02022364f,-0.9836043f,0.06745427f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321687f,1.538201f,0.4831762f,-0.6545138f,-0.2082336f,-0.2498983f,0.6824964f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 9.198146f);
Get(0x6E70).SetLocalPose(-0.1341223f,1.685586f,-0.4913929f,0.4587362f,-0.4647647f,-0.5118958f,0.5581377f);
Get(0x6E82).SetLocalPose(-0.2579295f,1.542062f,-0.4128462f,-0.923789f,0.04395478f,-0.1915503f,-0.3286186f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 9.198146f);
Get(0x6EC6).SetLocalPose(0.1772065f,0.8283942f,-0.4911171f,-0.16787f,-0.02087194f,-0.9833173f,0.06686693f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321689f,1.538073f,0.4831475f,-0.6545077f,-0.2082481f,-0.2499065f,0.6824948f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 9.216812f);
Get(0x6E70).SetLocalPose(-0.1335404f,1.685864f,-0.4919308f,0.4572547f,-0.465356f,-0.511573f,0.5591556f);
Get(0x6E82).SetLocalPose(-0.2462086f,1.535717f,-0.419432f,-0.9179801f,0.06350022f,-0.1854388f,-0.3448083f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 9.216812f);
Get(0x6EC6).SetLocalPose(0.1773988f,0.8277656f,-0.4912368f,-0.1701626f,-0.02100548f,-0.9829802f,0.06598138f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321468f,1.537924f,0.4831716f,-0.6544933f,-0.2082311f,-0.2499273f,0.6825061f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 9.235468f);
Get(0x6E70).SetLocalPose(-0.133512f,1.685685f,-0.4923124f,0.4561438f,-0.4656262f,-0.5112245f,0.5601559f);
Get(0x6E82).SetLocalPose(-0.237375f,1.531284f,-0.4231976f,-0.916212f,0.06754401f,-0.1882439f,-0.347214f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 9.235468f);
Get(0x6EC6).SetLocalPose(0.1772994f,0.8270739f,-0.4920844f,-0.1714443f,-0.02107996f,-0.9827864f,0.06552436f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321359f,1.538038f,0.4832769f,-0.6545274f,-0.20825f,-0.2499215f,0.6824699f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 9.254494f);
Get(0x6E70).SetLocalPose(-0.1334455f,1.685667f,-0.492331f,0.4555554f,-0.4656798f,-0.5109283f,0.56086f);
Get(0x6E82).SetLocalPose(-0.2349399f,1.532003f,-0.423055f,-0.9181234f,0.05335006f,-0.1996589f,-0.3381414f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 9.254494f);
Get(0x6EC6).SetLocalPose(0.1773167f,0.8267233f,-0.4921759f,-0.1727206f,-0.02164982f,-0.9825727f,0.06519074f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321387f,1.53794f,0.4833141f,-0.6545218f,-0.2082465f,-0.2499381f,0.6824703f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 9.273705f);
Get(0x6E70).SetLocalPose(-0.13291f,1.685774f,-0.4929454f,0.454297f,-0.4653418f,-0.5097955f,0.5631872f);
Get(0x6E82).SetLocalPose(-0.2396093f,1.536267f,-0.419508f,-0.9225541f,0.01539456f,-0.2191296f,-0.3172367f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 9.273705f);
Get(0x6EC6).SetLocalPose(0.1768321f,0.8262448f,-0.4923399f,-0.1732906f,-0.02282874f,-0.9824435f,0.06522277f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321559f,1.538139f,0.4831928f,-0.6545051f,-0.2082358f,-0.2499394f,0.682489f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 9.292704f);
Get(0x6E70).SetLocalPose(-0.1325574f,1.685433f,-0.4932834f,0.4540274f,-0.4648505f,-0.5092449f,0.5643073f);
Get(0x6E82).SetLocalPose(-0.2535344f,1.548095f,-0.4127675f,-0.9308926f,-0.04712657f,-0.2359882f,-0.2748226f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 9.292704f);
Get(0x6EC6).SetLocalPose(0.1766686f,0.8258203f,-0.4921546f,-0.173164f,-0.02354322f,-0.9824635f,0.06500355f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321508f,1.5382f,0.483176f,-0.6545019f,-0.2082646f,-0.2499035f,0.6824965f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 9.311834f);
Get(0x6E70).SetLocalPose(-0.1320729f,1.685276f,-0.493805f,0.4541767f,-0.4638763f,-0.5086384f,0.5655345f);
Get(0x6E82).SetLocalPose(-0.274346f,1.566815f,-0.4023972f,-0.9411489f,-0.1216674f,-0.2376144f,-0.2073049f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 9.311834f);
Get(0x6EC6).SetLocalPose(0.1760138f,0.8252003f,-0.4925899f,-0.1723902f,-0.02468021f,-0.982592f,0.06469616f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321622f,1.538096f,0.4831744f,-0.6545088f,-0.2082459f,-0.2499271f,0.682487f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 9.33179f);
Get(0x6E70).SetLocalPose(-0.1319051f,1.685314f,-0.4942521f,0.4545228f,-0.46314f,-0.5081605f,0.566289f);
Get(0x6E82).SetLocalPose(-0.3110752f,1.583741f,-0.3892879f,-0.9464825f,-0.2168217f,-0.211601f,-0.1112847f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 9.33179f);
Get(0x6EC6).SetLocalPose(0.1753774f,0.8254852f,-0.4928709f,-0.1713454f,-0.02587887f,-0.9827413f,0.06473497f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321629f,1.538165f,0.483109f,-0.6545194f,-0.2082315f,-0.2499086f,0.6824878f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 9.35123f);
Get(0x6E70).SetLocalPose(-0.131657f,1.6853f,-0.4947521f,0.4548625f,-0.4623637f,-0.5076985f,0.5670645f);
Get(0x6E82).SetLocalPose(-0.3419598f,1.594772f,-0.3783012f,-0.943345f,-0.2910042f,-0.1578289f,-0.02251408f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 9.35123f);
Get(0x6EC6).SetLocalPose(0.1751845f,0.8270108f,-0.4930978f,-0.1704661f,-0.02682281f,-0.9828422f,0.06513932f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321702f,1.538038f,0.4831121f,-0.6545182f,-0.2082165f,-0.249926f,0.6824873f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 9.372031f);
Get(0x6E70).SetLocalPose(-0.1313898f,1.685427f,-0.4954091f,0.4551404f,-0.4615379f,-0.5075683f,0.5676305f);
Get(0x6E82).SetLocalPose(-0.383126f,1.606135f,-0.3604528f,-0.9233825f,-0.3691121f,-0.06099121f,0.08603036f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 9.372031f);
Get(0x6EC6).SetLocalPose(0.1747583f,0.8279906f,-0.4937102f,-0.1698794f,-0.02735804f,-0.9829063f,0.06548131f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321771f,1.53807f,0.482904f,-0.6545169f,-0.2082397f,-0.2499159f,0.682485f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 9.399896f);
Get(0x6E70).SetLocalPose(-0.1312799f,1.684791f,-0.4962723f,0.4559589f,-0.4600761f,-0.5082248f,0.5675729f);
Get(0x6E82).SetLocalPose(-0.4176152f,1.609778f,-0.3413867f,-0.8899153f,-0.4193772f,0.01497309f,0.1787434f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 9.399896f);
Get(0x6EC6).SetLocalPose(0.1748407f,0.8287809f,-0.4935969f,-0.1687698f,-0.02810035f,-0.9830455f,0.06594435f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321764f,1.538128f,0.4829655f,-0.6545188f,-0.208246f,-0.2499271f,0.6824772f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 9.419937f);
Get(0x6E70).SetLocalPose(-0.1312934f,1.684149f,-0.496989f,0.4568904f,-0.4591479f,-0.5093017f,0.5666093f);
Get(0x6E82).SetLocalPose(-0.4276667f,1.613049f,-0.3272634f,-0.8851606f,-0.4132034f,-0.02893851f,0.2119344f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 9.419937f);
Get(0x6EC6).SetLocalPose(0.1749629f,0.8280391f,-0.4930657f,-0.166395f,-0.02961227f,-0.9833493f,0.06678327f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321691f,1.538185f,0.4832274f,-0.6545226f,-0.2082636f,-0.2499236f,0.6824695f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 9.43973f);
Get(0x6E70).SetLocalPose(-0.1316013f,1.68389f,-0.4972751f,0.4578989f,-0.4584775f,-0.5102072f,0.5655224f);
Get(0x6E82).SetLocalPose(-0.4235266f,1.614107f,-0.3167046f,-0.8957908f,-0.3833764f,-0.1086666f,0.1969086f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 9.43973f);
Get(0x6EC6).SetLocalPose(0.1749652f,0.8288884f,-0.4916728f,-0.163843f,-0.0309264f,-0.9836879f,0.06750759f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321568f,1.538356f,0.4833644f,-0.6545299f,-0.2082607f,-0.2499245f,0.682463f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 9.458932f);
Get(0x6E70).SetLocalPose(-0.1320374f,1.683373f,-0.4974428f,0.4591795f,-0.4577954f,-0.5108675f,0.5644396f);
Get(0x6E82).SetLocalPose(-0.411585f,1.613548f,-0.309627f,-0.9078309f,-0.338981f,-0.1965592f,0.1493304f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 9.458932f);
Get(0x6EC6).SetLocalPose(0.1744027f,0.8298132f,-0.490142f,-0.1603094f,-0.03215794f,-0.9841846f,0.06817245f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321642f,1.538275f,0.483246f,-0.6545169f,-0.2082913f,-0.249915f,0.6824697f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 9.478502f);
Get(0x6E70).SetLocalPose(-0.1324304f,1.683405f,-0.4972709f,0.4600827f,-0.4573762f,-0.5111943f,0.5637477f);
Get(0x6E82).SetLocalPose(-0.3977525f,1.61005f,-0.3066551f,-0.9207683f,-0.2768896f,-0.2570994f,0.09704558f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 9.478502f);
Get(0x6EC6).SetLocalPose(0.1738586f,0.8307437f,-0.4904403f,-0.1564949f,-0.03346603f,-0.9847149f,0.06874587f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321711f,1.538212f,0.4832391f,-0.6545147f,-0.208268f,-0.2499051f,0.6824826f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 9.497057f);
Get(0x6E70).SetLocalPose(-0.1327662f,1.683416f,-0.4968812f,0.460181f,-0.457468f,-0.5113042f,0.5634931f);
Get(0x6E82).SetLocalPose(-0.3784003f,1.606523f,-0.3052864f,-0.9314272f,-0.1971431f,-0.3038199f,0.03565811f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 9.497057f);
Get(0x6EC6).SetLocalPose(0.1737856f,0.8315393f,-0.4891482f,-0.1517358f,-0.03625332f,-0.9852817f,0.06987164f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321608f,1.538279f,0.4833704f,-0.6545263f,-0.2082691f,-0.2499097f,0.6824694f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 9.516193f);
Get(0x6E70).SetLocalPose(-0.1333531f,1.68366f,-0.4960165f,0.4596008f,-0.4579642f,-0.511469f,0.5634142f);
Get(0x6E82).SetLocalPose(-0.3609195f,1.600628f,-0.306895f,-0.9361488f,-0.123665f,-0.3284111f,-0.02187362f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 9.516193f);
Get(0x6EC6).SetLocalPose(0.173536f,0.8318803f,-0.4875739f,-0.1472394f,-0.04054399f,-0.9856752f,0.07156211f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321638f,1.538192f,0.4832555f,-0.6545331f,-0.2082576f,-0.249909f,0.6824667f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 9.535437f);
Get(0x6E70).SetLocalPose(-0.1334003f,1.683553f,-0.4955863f,0.4589013f,-0.4584077f,-0.5119106f,0.5632225f);
Get(0x6E82).SetLocalPose(-0.3425067f,1.589334f,-0.3130839f,-0.9352019f,-0.03137365f,-0.3399901f,-0.09391442f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 9.535437f);
Get(0x6EC6).SetLocalPose(0.1729529f,0.8322345f,-0.4859405f,-0.1439368f,-0.04504634f,-0.9858173f,0.07360311f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321645f,1.538204f,0.4833521f,-0.654525f,-0.2082444f,-0.2498776f,0.6824899f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 9.555349f);
Get(0x6E70).SetLocalPose(-0.1334329f,1.683596f,-0.4947055f,0.4585761f,-0.4584366f,-0.512627f,0.5628121f);
Get(0x6E82).SetLocalPose(-0.3291576f,1.576487f,-0.3179014f,-0.9265755f,0.0384648f,-0.340359f,-0.1553514f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 9.555349f);
Get(0x6EC6).SetLocalPose(0.172525f,0.8328844f,-0.484068f,-0.1413186f,-0.04935783f,-0.985819f,0.07585406f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321691f,1.538087f,0.4833731f,-0.6545378f,-0.2082568f,-0.2498944f,0.6824677f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 9.574468f);
Get(0x6E70).SetLocalPose(-0.1332337f,1.683249f,-0.4938945f,0.4586311f,-0.4581639f,-0.5133306f,0.5623478f);
Get(0x6E82).SetLocalPose(-0.3183114f,1.567172f,-0.3225869f,-0.9130604f,0.09261137f,-0.3359452f,-0.2118602f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 9.574468f);
Get(0x6EC6).SetLocalPose(0.1722373f,0.8337141f,-0.4819968f,-0.1385774f,-0.05385843f,-0.985752f,0.07866862f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321766f,1.53816f,0.4833074f,-0.6545328f,-0.2082518f,-0.2499093f,0.6824687f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 9.593538f);
Get(0x6E70).SetLocalPose(-0.1337104f,1.683106f,-0.493086f,0.4588851f,-0.4577623f,-0.5140034f,0.5618529f);
Get(0x6E82).SetLocalPose(-0.3103069f,1.561187f,-0.3272074f,-0.9004411f,0.1224039f,-0.3323916f,-0.2524657f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 9.593538f);
Get(0x6EC6).SetLocalPose(0.1721288f,0.8341985f,-0.4819336f,-0.1374979f,-0.05562266f,-0.9857078f,0.07987941f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321799f,1.538312f,0.4832433f,-0.654524f,-0.2082665f,-0.2499095f,0.6824725f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 9.612584f);
Get(0x6E70).SetLocalPose(-0.13402f,1.682957f,-0.4921841f,0.459048f,-0.4573964f,-0.5145264f,0.561539f);
Get(0x6E82).SetLocalPose(-0.3023631f,1.563341f,-0.3294058f,-0.9025199f,0.1133261f,-0.3312286f,-0.2508039f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 9.612584f);
Get(0x6EC6).SetLocalPose(0.1712299f,0.835937f,-0.4812758f,-0.1354648f,-0.05973869f,-0.9855768f,0.08196994f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321732f,1.538254f,0.4833021f,-0.6545377f,-0.2082719f,-0.2498995f,0.6824614f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 9.631361f);
Get(0x6E70).SetLocalPose(-0.1336583f,1.683655f,-0.491454f,0.4593674f,-0.4568391f,-0.5147425f,0.5615335f);
Get(0x6E82).SetLocalPose(-0.3014043f,1.57107f,-0.3323052f,-0.91934f,0.08383793f,-0.3168364f,-0.2177153f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 9.631361f);
Get(0x6EC6).SetLocalPose(0.1701321f,0.8361716f,-0.4807877f,-0.1351528f,-0.06239606f,-0.9854126f,0.08247685f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32159f,1.538288f,0.4832891f,-0.6545497f,-0.20824f,-0.2498836f,0.6824654f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 9.659836f);
Get(0x6E70).SetLocalPose(-0.1330326f,1.683221f,-0.4903138f,0.4600835f,-0.4561428f,-0.5143443f,0.561878f);
Get(0x6E82).SetLocalPose(-0.3224121f,1.586942f,-0.3449501f,-0.9538037f,-0.004593369f,-0.265546f,-0.1404377f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 9.659836f);
Get(0x6EC6).SetLocalPose(0.1694863f,0.8367699f,-0.4803742f,-0.1366444f,-0.06473789f,-0.985131f,0.08157422f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321617f,1.538262f,0.4833459f,-0.6545305f,-0.2082591f,-0.2498791f,0.6824796f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 9.669144f);
Get(0x6E70).SetLocalPose(-0.1326804f,1.682922f,-0.4899104f,0.4603653f,-0.4560701f,-0.5141261f,0.5619059f);
Get(0x6E82).SetLocalPose(-0.3304428f,1.595168f,-0.3482722f,-0.9661112f,-0.05130762f,-0.2328536f,-0.09887333f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 9.669144f);
Get(0x6EC6).SetLocalPose(0.1690759f,0.8362725f,-0.4804939f,-0.1376606f,-0.06526317f,-0.9850258f,0.08071274f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321589f,1.538069f,0.483249f,-0.6545318f,-0.2082725f,-0.2498783f,0.6824747f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 9.699899f);
Get(0x6E70).SetLocalPose(-0.1325754f,1.682957f,-0.4891782f,0.4604962f,-0.4564496f,-0.5141209f,0.5614951f);
Get(0x6E82).SetLocalPose(-0.36339f,1.606881f,-0.3509221f,-0.9814193f,-0.144482f,-0.1262589f,-0.0001724588f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 9.699899f);
Get(0x6EC6).SetLocalPose(0.1681046f,0.8357421f,-0.4812638f,-0.1405332f,-0.06550694f,-0.9847812f,0.0785189f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321524f,1.538163f,0.4833554f,-0.6545213f,-0.2082763f,-0.2498773f,0.6824838f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 9.710499f);
Get(0x6E70).SetLocalPose(-0.1324369f,1.68309f,-0.488893f,0.460332f,-0.4568146f,-0.5143185f,0.5611519f);
Get(0x6E82).SetLocalPose(-0.3702598f,1.608722f,-0.3537757f,-0.9807991f,-0.1625401f,-0.1067811f,0.01454816f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 9.710499f);
Get(0x6EC6).SetLocalPose(0.168213f,0.835043f,-0.4816591f,-0.1420029f,-0.06523961f,-0.984632f,0.07796704f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321662f,1.538142f,0.4832367f,-0.6545505f,-0.2082495f,-0.2498752f,0.6824648f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 9.732508f);
Get(0x6E70).SetLocalPose(-0.1319367f,1.68317f,-0.4887812f,0.4598278f,-0.4576925f,-0.5148962f,0.5603194f);
Get(0x6E82).SetLocalPose(-0.3748871f,1.607324f,-0.3588681f,-0.9772246f,-0.1731066f,-0.1227444f,-0.0002978262f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 9.732508f);
Get(0x6EC6).SetLocalPose(0.1681553f,0.8342048f,-0.4815666f,-0.1446914f,-0.06483516f,-0.9843194f,0.07730588f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321633f,1.538049f,0.4833119f,-0.6545524f,-0.2082438f,-0.24991f,0.682452f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 9.752532f);
Get(0x6E70).SetLocalPose(-0.1319662f,1.684008f,-0.4882777f,0.4591783f,-0.4584621f,-0.5156072f,0.5595687f);
Get(0x6E82).SetLocalPose(-0.3729341f,1.600317f,-0.365383f,-0.972697f,-0.1675679f,-0.1533757f,-0.04751201f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 9.752532f);
Get(0x6EC6).SetLocalPose(0.1685183f,0.833562f,-0.4821886f,-0.1474736f,-0.06453075f,-0.9839501f,0.07700387f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321577f,1.538236f,0.4833947f,-0.6545545f,-0.208249f,-0.2499195f,0.6824449f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 9.773111f);
Get(0x6E70).SetLocalPose(-0.1318929f,1.684721f,-0.4878416f,0.4583727f,-0.4591053f,-0.5161305f,0.5592192f);
Get(0x6E82).SetLocalPose(-0.362952f,1.591377f,-0.3762257f,-0.9676285f,-0.1473526f,-0.1719919f,-0.1113604f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 9.773111f);
Get(0x6EC6).SetLocalPose(0.1691297f,0.8319656f,-0.4827611f,-0.1498041f,-0.06413567f,-0.9836183f,0.07707524f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321527f,1.538137f,0.4833452f,-0.6545516f,-0.208232f,-0.2499008f,0.6824597f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 9.79376f);
Get(0x6E70).SetLocalPose(-0.1311082f,1.68495f,-0.4873524f,0.4568395f,-0.4599257f,-0.5164956f,0.5594626f);
Get(0x6E82).SetLocalPose(-0.3524639f,1.580794f,-0.3851584f,-0.9608383f,-0.1159372f,-0.1858403f,-0.1697403f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 9.79376f);
Get(0x6EC6).SetLocalPose(0.1691248f,0.8304743f,-0.483682f,-0.1509473f,-0.0638864f,-0.9834313f,0.07743604f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321748f,1.538235f,0.4832075f,-0.6545447f,-0.2082459f,-0.2498864f,0.6824675f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 9.813221f);
Get(0x6E70).SetLocalPose(-0.1305431f,1.685444f,-0.4866057f,0.4553252f,-0.46069f,-0.5166289f,0.5599447f);
Get(0x6E82).SetLocalPose(-0.3417337f,1.570186f,-0.3926946f,-0.9500581f,-0.08532675f,-0.2024568f,-0.2216309f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 9.813221f);
Get(0x6EC6).SetLocalPose(0.1687212f,0.8295935f,-0.4843525f,-0.1515523f,-0.06407387f,-0.9832849f,0.07795769f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321733f,1.538226f,0.4832902f,-0.6545511f,-0.2082533f,-0.2498942f,0.6824561f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 9.832558f);
Get(0x6E70).SetLocalPose(-0.1306216f,1.685657f,-0.4857362f,0.4533757f,-0.4615568f,-0.5167124f,0.5607354f);
Get(0x6E82).SetLocalPose(-0.3322428f,1.563894f,-0.3974009f,-0.936316f,-0.07110889f,-0.2240828f,-0.2608499f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 9.832558f);
Get(0x6EC6).SetLocalPose(0.1685017f,0.8296694f,-0.4848031f,-0.1518172f,-0.06466211f,-0.9831444f,0.07872408f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321765f,1.538265f,0.4832483f,-0.6545281f,-0.2082451f,-0.2498895f,0.6824825f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 9.853233f);
Get(0x6E70).SetLocalPose(-0.1300222f,1.685845f,-0.4852072f,0.4519696f,-0.4617728f,-0.5169729f,0.5614521f);
Get(0x6E82).SetLocalPose(-0.3279428f,1.561282f,-0.3988096f,-0.9305667f,-0.07765743f,-0.236546f,-0.2684417f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 9.853233f);
Get(0x6EC6).SetLocalPose(0.1688603f,0.8291827f,-0.4849811f,-0.1521394f,-0.06554591f,-0.9829745f,0.07948974f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321705f,1.538193f,0.4832384f,-0.65452f,-0.2082287f,-0.2498955f,0.682493f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 9.872854f);
Get(0x6E70).SetLocalPose(-0.1299386f,1.685404f,-0.4848338f,0.4517951f,-0.4612786f,-0.5172876f,0.5617089f);
Get(0x6E82).SetLocalPose(-0.3301554f,1.562234f,-0.397658f,-0.9379394f,-0.1080884f,-0.2259628f,-0.2398487f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 9.872854f);
Get(0x6EC6).SetLocalPose(0.1685578f,0.8296301f,-0.4846196f,-0.1527774f,-0.06599042f,-0.9828338f,0.07963683f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321744f,1.538184f,0.4831847f,-0.654524f,-0.2082502f,-0.249905f,0.6824791f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 9.8923f);
Get(0x6E70).SetLocalPose(-0.1298237f,1.685306f,-0.4848308f,0.4526479f,-0.4601958f,-0.5175995f,0.561623f);
Get(0x6E82).SetLocalPose(-0.3391418f,1.568601f,-0.3976147f,-0.9484893f,-0.1637843f,-0.1973183f,-0.1860331f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 9.8923f);
Get(0x6EC6).SetLocalPose(0.1682574f,0.829963f,-0.4845402f,-0.15395f,-0.06565294f,-0.9827271f,0.07897171f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32169f,1.538116f,0.4831621f,-0.6545436f,-0.2082294f,-0.2499173f,0.6824622f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 9.912466f);
Get(0x6E70).SetLocalPose(-0.1291656f,1.685063f,-0.4849905f,0.4536428f,-0.4592507f,-0.51796f,0.5612615f);
Get(0x6E82).SetLocalPose(-0.3579785f,1.570782f,-0.3961647f,-0.9508844f,-0.2397905f,-0.1556429f,-0.1187211f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 9.912466f);
Get(0x6EC6).SetLocalPose(0.1683287f,0.8302166f,-0.4844317f,-0.1549f,-0.06513731f,-0.9826669f,0.07828805f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321514f,1.538132f,0.4832206f,-0.6545385f,-0.2082462f,-0.2498946f,0.6824703f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 9.931955f);
Get(0x6E70).SetLocalPose(-0.1287758f,1.684834f,-0.4850067f,0.4546576f,-0.4584844f,-0.5184138f,0.5606476f);
Get(0x6E82).SetLocalPose(-0.3768565f,1.576109f,-0.3915977f,-0.9418437f,-0.3166323f,-0.1011353f,-0.04945789f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 9.931955f);
Get(0x6EC6).SetLocalPose(0.1677097f,0.8307177f,-0.484566f,-0.1560263f,-0.06484757f,-0.9825803f,0.07737244f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321584f,1.538055f,0.4831637f,-0.6545438f,-0.2082547f,-0.249868f,0.6824723f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 9.95349f);
Get(0x6E70).SetLocalPose(-0.1283181f,1.684586f,-0.4850206f,0.4552713f,-0.4580985f,-0.5186402f,0.5602556f);
Get(0x6E82).SetLocalPose(-0.4052674f,1.580047f,-0.3845616f,-0.920482f,-0.3894009f,-0.01472231f,0.02937866f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 9.95349f);
Get(0x6EC6).SetLocalPose(0.1671641f,0.8293712f,-0.48533f,-0.1569774f,-0.06491736f,-0.9824604f,0.07691155f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321714f,1.538201f,0.4831624f,-0.6545342f,-0.2082495f,-0.2498798f,0.6824788f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 9.973229f);
Get(0x6E70).SetLocalPose(-0.1282169f,1.684721f,-0.4849524f,0.4554403f,-0.458105f,-0.5188723f,0.5598979f);
Get(0x6E82).SetLocalPose(-0.4176502f,1.579679f,-0.3802287f,-0.9098777f,-0.4101374f,0.01339378f,0.0610779f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 9.973229f);
Get(0x6EC6).SetLocalPose(0.1665458f,0.8290425f,-0.4858862f,-0.1573175f,-0.06508294f,-0.9823949f,0.07691334f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32175f,1.538197f,0.4831939f,-0.6545318f,-0.2082634f,-0.2498816f,0.6824761f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 9.992824f);
Get(0x6E70).SetLocalPose(-0.127763f,1.684597f,-0.4855982f,0.4553453f,-0.4583651f,-0.5194026f,0.5592701f);
Get(0x6E82).SetLocalPose(-0.4235069f,1.575916f,-0.3769238f,-0.9074388f,-0.4154758f,-0.006601277f,0.06238062f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 9.992824f);
Get(0x6EC6).SetLocalPose(0.1662606f,0.8289974f,-0.4860367f,-0.1573969f,-0.06514897f,-0.9823665f,0.07705791f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321664f,1.538359f,0.4832878f,-0.6545234f,-0.2082525f,-0.2499106f,0.6824769f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 10.01241f);
Get(0x6E70).SetLocalPose(-0.1277788f,1.68458f,-0.4859371f,0.4550112f,-0.4587315f,-0.5199274f,0.5587537f);
Get(0x6E82).SetLocalPose(-0.4193167f,1.57218f,-0.3776261f,-0.9115734f,-0.4065638f,-0.05251769f,0.03133371f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 10.01241f);
Get(0x6EC6).SetLocalPose(0.1663812f,0.8294615f,-0.4860338f,-0.1573106f,-0.06499635f,-0.9823968f,0.07697631f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321599f,1.53818f,0.4832434f,-0.6545186f,-0.2082455f,-0.2498886f,0.6824917f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 10.03219f);
Get(0x6E70).SetLocalPose(-0.1277821f,1.684893f,-0.4861287f,0.4542804f,-0.4592224f,-0.5204241f,0.5584826f);
Get(0x6E82).SetLocalPose(-0.4098328f,1.56726f,-0.3810759f,-0.9166017f,-0.3855875f,-0.1040422f,-0.01840966f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 10.03219f);
Get(0x6EC6).SetLocalPose(0.1662215f,0.8293169f,-0.4861624f,-0.1571127f,-0.06481477f,-0.982451f,0.07684177f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321693f,1.53819f,0.4830686f,-0.6545043f,-0.208235f,-0.2499218f,0.6824964f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 10.05285f);
Get(0x6E70).SetLocalPose(-0.1273696f,1.684673f,-0.4865153f,0.4532414f,-0.4597392f,-0.5206826f,0.5586606f);
Get(0x6E82).SetLocalPose(-0.3959694f,1.561465f,-0.3859756f,-0.9242461f,-0.3425929f,-0.1501729f,-0.07646807f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 10.05285f);
Get(0x6EC6).SetLocalPose(0.1664056f,0.8297319f,-0.4857516f,-0.1573497f,-0.06470407f,-0.9824028f,0.07706653f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321757f,1.538176f,0.4829939f,-0.6545166f,-0.2082394f,-0.2499198f,0.6824841f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 10.07337f);
Get(0x6E70).SetLocalPose(-0.1270661f,1.684906f,-0.4866011f,0.4518913f,-0.4602169f,-0.5206372f,0.5594029f);
Get(0x6E82).SetLocalPose(-0.3816139f,1.559569f,-0.3895092f,-0.9311209f,-0.2889345f,-0.1867639f,-0.1210365f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 10.07337f);
Get(0x6EC6).SetLocalPose(0.1668079f,0.8298194f,-0.4861322f,-0.1577053f,-0.06494693f,-0.9822745f,0.07776735f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321517f,1.538169f,0.4830758f,-0.6545191f,-0.2082283f,-0.2499467f,0.6824752f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 10.0835f);
Get(0x6E82).SetLocalPose(-0.371845f,1.55785f,-0.3903905f,-0.9329922f,-0.2498642f,-0.2120016f,-0.1488249f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 10.0835f);
Get(0x6EC6).SetLocalPose(0.1671365f,0.8295481f,-0.4858087f,-0.1580111f,-0.06525005f,-0.9821557f,0.07839093f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321425f,1.538042f,0.4832759f,-0.654516f,-0.2082369f,-0.2499241f,0.6824838f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 10.11507f);
Get(0x6E70).SetLocalPose(-0.1272759f,1.684415f,-0.4866958f,0.4499494f,-0.4605883f,-0.5204229f,0.5608601f);
Get(0x6E82).SetLocalPose(-0.3535716f,1.553854f,-0.389065f,-0.9297368f,-0.1791403f,-0.256411f,-0.1942981f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 10.11507f);
Get(0x6EC6).SetLocalPose(0.1678875f,0.8300515f,-0.4862053f,-0.1581202f,-0.0661282f,-0.9819548f,0.07993784f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321476f,1.538031f,0.4831345f,-0.6545159f,-0.2082155f,-0.2499262f,0.6824898f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 10.13464f);
Get(0x6E70).SetLocalPose(-0.1274826f,1.685178f,-0.4873672f,0.4499222f,-0.4599216f,-0.520508f,0.5613497f);
Get(0x6E82).SetLocalPose(-0.3455042f,1.551294f,-0.3886717f,-0.9273856f,-0.1456395f,-0.2738474f,-0.2091714f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 10.13464f);
Get(0x6EC6).SetLocalPose(0.1686537f,0.8308586f,-0.4855493f,-0.1579719f,-0.06662288f,-0.9818649f,0.08091633f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321495f,1.537919f,0.4831607f,-0.6545282f,-0.2082227f,-0.2499251f,0.6824761f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 10.15362f);
Get(0x6E70).SetLocalPose(-0.1276156f,1.684868f,-0.4876955f,0.4507897f,-0.4591829f,-0.5205444f,0.5612248f);
Get(0x6E82).SetLocalPose(-0.3389466f,1.551147f,-0.3865757f,-0.9284381f,-0.1234434f,-0.2817358f,-0.2083013f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 10.15362f);
Get(0x6EC6).SetLocalPose(0.1690823f,0.8305377f,-0.4854122f,-0.1576919f,-0.06696314f,-0.9818322f,0.08157677f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321537f,1.538002f,0.4831476f,-0.6545228f,-0.2082155f,-0.2499135f,0.6824877f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 10.17221f);
Get(0x6E70).SetLocalPose(-0.1277117f,1.684601f,-0.4880433f,0.451585f,-0.4587758f,-0.5204077f,0.5610451f);
Get(0x6E82).SetLocalPose(-0.3370421f,1.552622f,-0.381509f,-0.9336954f,-0.116032f,-0.278359f,-0.1930437f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 10.17221f);
Get(0x6EC6).SetLocalPose(0.1696474f,0.8312234f,-0.485149f,-0.1574966f,-0.06687845f,-0.98187f,0.08156916f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321524f,1.538087f,0.4831191f,-0.6545221f,-0.2082434f,-0.2499149f,0.6824794f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 10.19159f);
Get(0x6E70).SetLocalPose(-0.1278712f,1.684247f,-0.4884157f,0.4526004f,-0.4585669f,-0.5198857f,0.5608816f);
Get(0x6E82).SetLocalPose(-0.3403033f,1.549378f,-0.3798404f,-0.9396937f,-0.1200647f,-0.2692478f,-0.1733949f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 10.19159f);
Get(0x6EC6).SetLocalPose(0.1697939f,0.8324638f,-0.4844374f,-0.1576856f,-0.06648769f,-0.9819344f,0.08074266f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321441f,1.53821f,0.4831357f,-0.6545134f,-0.2082518f,-0.2499027f,0.6824896f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 10.21927f);
Get(0x6E70).SetLocalPose(-0.1280373f,1.684477f,-0.4886501f,0.4535951f,-0.4588078f,-0.5189139f,0.5607809f);
Get(0x6E82).SetLocalPose(-0.3486082f,1.550852f,-0.3767003f,-0.9479645f,-0.1380056f,-0.2508546f,-0.1392471f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 10.21927f);
Get(0x6EC6).SetLocalPose(0.1698815f,0.8319514f,-0.4831113f,-0.1570838f,-0.06776228f,-0.9820047f,0.07999905f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321552f,1.538383f,0.4832427f,-0.6545084f,-0.208241f,-0.2499076f,0.682496f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 10.23946f);
Get(0x6E70).SetLocalPose(-0.1284281f,1.684192f,-0.488781f,0.4540875f,-0.459485f,-0.51802f,0.5606545f);
Get(0x6E82).SetLocalPose(-0.3536675f,1.552215f,-0.3744036f,-0.9522226f,-0.1550773f,-0.2392026f,-0.1095681f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 10.23946f);
Get(0x6EC6).SetLocalPose(0.170153f,0.8317629f,-0.4826595f,-0.1565466f,-0.06946171f,-0.9819599f,0.08014481f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321704f,1.538182f,0.4831525f,-0.6544966f,-0.2082455f,-0.2499106f,0.6825048f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 10.25916f);
Get(0x6E70).SetLocalPose(-0.1285567f,1.683851f,-0.4893317f,0.4541321f,-0.4602199f,-0.5174348f,0.5605558f);
Get(0x6E82).SetLocalPose(-0.3601209f,1.552678f,-0.3700458f,-0.9543395f,-0.1690599f,-0.2312109f,-0.08483176f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 10.25916f);
Get(0x6EC6).SetLocalPose(0.1698026f,0.8310899f,-0.4834271f,-0.1565481f,-0.07103913f,-0.981844f,0.08017828f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321604f,1.538285f,0.4831429f,-0.6544933f,-0.2082507f,-0.2499143f,0.682505f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 10.27883f);
Get(0x6E70).SetLocalPose(-0.1285802f,1.684257f,-0.4896998f,0.4538743f,-0.4610899f,-0.516943f,0.5605034f);
Get(0x6E82).SetLocalPose(-0.3659438f,1.553224f,-0.365951f,-0.9555713f,-0.183359f,-0.2225382f,-0.06115341f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 10.27883f);
Get(0x6EC6).SetLocalPose(0.1696376f,0.8315587f,-0.4834435f,-0.1570522f,-0.07210013f,-0.9816973f,0.08004149f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321512f,1.538251f,0.4831564f,-0.6544909f,-0.2082678f,-0.249925f,0.6824982f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 10.29854f);
Get(0x6E70).SetLocalPose(-0.1280373f,1.684907f,-0.4900753f,0.453236f,-0.4618582f,-0.5168189f,0.5605019f);
Get(0x6E82).SetLocalPose(-0.3733844f,1.553709f,-0.360774f,-0.9553549f,-0.2024312f,-0.2122477f,-0.03563105f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 10.29854f);
Get(0x6EC6).SetLocalPose(0.1694131f,0.8310363f,-0.4845669f,-0.1581193f,-0.07246235f,-0.9815227f,0.07975378f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32164f,1.538237f,0.4831534f,-0.6544983f,-0.2082547f,-0.2499197f,0.682497f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 10.31791f);
Get(0x6E70).SetLocalPose(-0.1275504f,1.684613f,-0.4904495f,0.4525836f,-0.4623213f,-0.5169992f,0.5604811f);
Get(0x6E82).SetLocalPose(-0.3821382f,1.551208f,-0.3543855f,-0.9539075f,-0.2188358f,-0.204756f,-0.01569658f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 10.31791f);
Get(0x6EC6).SetLocalPose(0.1693074f,0.8310325f,-0.485244f,-0.1590043f,-0.07231276f,-0.9814143f,0.07946356f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321702f,1.538206f,0.4831336f,-0.6545061f,-0.2082818f,-0.2499114f,0.6824843f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 10.33722f);
Get(0x6E70).SetLocalPose(-0.1271233f,1.684506f,-0.4906291f,0.4517744f,-0.4626044f,-0.5174361f,0.5604971f);
Get(0x6E82).SetLocalPose(-0.3887931f,1.548824f,-0.3481426f,-0.9515688f,-0.2366558f,-0.1960525f,0.008622076f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 10.33722f);
Get(0x6EC6).SetLocalPose(0.1691249f,0.8301154f,-0.4861998f,-0.16026f,-0.07180902f,-0.9812759f,0.07910668f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321738f,1.538213f,0.4830646f,-0.6545085f,-0.208251f,-0.2499172f,0.6824892f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 10.35691f);
Get(0x6E70).SetLocalPose(-0.127464f,1.68441f,-0.490729f,0.4508782f,-0.4626408f,-0.5180766f,0.560597f);
Get(0x6E82).SetLocalPose(-0.3983766f,1.547671f,-0.3367438f,-0.9480042f,-0.2538647f,-0.1874648f,0.04120134f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 10.35691f);
Get(0x6EC6).SetLocalPose(0.1696192f,0.8296611f,-0.486174f,-0.1614383f,-0.07152236f,-0.9811182f,0.07892647f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321764f,1.538143f,0.4831037f,-0.6544972f,-0.2082571f,-0.2498934f,0.6825069f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 10.37738f);
Get(0x6E70).SetLocalPose(-0.127292f,1.684873f,-0.490502f,0.4499912f,-0.4625686f,-0.5186067f,0.5608791f);
Get(0x6E82).SetLocalPose(-0.4061573f,1.544223f,-0.3285264f,-0.9435263f,-0.2651382f,-0.1843388f,0.07402175f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 10.37738f);
Get(0x6EC6).SetLocalPose(0.1696897f,0.8292227f,-0.4863188f,-0.1622166f,-0.0714688f,-0.9809997f,0.07885166f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321656f,1.5382f,0.4830414f,-0.6544952f,-0.2082401f,-0.2498826f,0.6825179f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 10.3966f);
Get(0x6E70).SetLocalPose(-0.1273455f,1.685194f,-0.4903835f,0.4491228f,-0.4624355f,-0.5190457f,0.5612787f);
Get(0x6E82).SetLocalPose(-0.4150486f,1.541227f,-0.3181902f,-0.9364366f,-0.2745332f,-0.185102f,0.1159972f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 10.3966f);
Get(0x6EC6).SetLocalPose(0.1698886f,0.8296695f,-0.4855783f,-0.1626606f,-0.07147946f,-0.9809229f,0.07888395f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321812f,1.538206f,0.4829499f,-0.6545105f,-0.2082496f,-0.249891f,0.6824973f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 10.41626f);
Get(0x6E70).SetLocalPose(-0.1273258f,1.685289f,-0.4900605f,0.448073f,-0.4622765f,-0.5195183f,0.5618113f);
Get(0x6E82).SetLocalPose(-0.4248912f,1.531493f,-0.3078238f,-0.9277321f,-0.2814579f,-0.1873091f,0.1581455f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 10.41626f);
Get(0x6EC6).SetLocalPose(0.1699454f,0.8302493f,-0.4855337f,-0.1630051f,-0.07115798f,-0.9808906f,0.07886383f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321864f,1.538164f,0.4830423f,-0.6544976f,-0.2082676f,-0.2498794f,0.6825085f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 10.43502f);
Get(0x6E70).SetLocalPose(-0.1273424f,1.685467f,-0.4896677f,0.4473271f,-0.4621687f,-0.5197711f,0.5622603f);
Get(0x6E82).SetLocalPose(-0.4357305f,1.522561f,-0.2922866f,-0.915753f,-0.2891599f,-0.1861645f,0.2076674f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 10.43502f);
Get(0x6EC6).SetLocalPose(0.169768f,0.8305334f,-0.4856226f,-0.1629724f,-0.07078744f,-0.9809343f,0.07872248f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321852f,1.538061f,0.4831752f,-0.6545062f,-0.2082707f,-0.2498976f,0.6824927f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 10.45507f);
Get(0x6E70).SetLocalPose(-0.1270375f,1.685651f,-0.4897534f,0.4467901f,-0.4619519f,-0.5198371f,0.562804f);
Get(0x6E82).SetLocalPose(-0.4465268f,1.511502f,-0.2758356f,-0.9003639f,-0.2989317f,-0.1838516f,0.2572612f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 10.45507f);
Get(0x6EC6).SetLocalPose(0.1690283f,0.8306348f,-0.4856117f,-0.1627963f,-0.07056459f,-0.9810019f,0.07844316f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321802f,1.537924f,0.4832288f,-0.6545244f,-0.2082595f,-0.249898f,0.6824784f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 10.47395f);
Get(0x6E70).SetLocalPose(-0.1270418f,1.685819f,-0.4892523f,0.4463125f,-0.4618238f,-0.519734f,0.5633832f);
Get(0x6E82).SetLocalPose(-0.4556742f,1.499886f,-0.2637006f,-0.8852642f,-0.3070288f,-0.182702f,0.2977593f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 10.47395f);
Get(0x6EC6).SetLocalPose(0.1687583f,0.8305633f,-0.4854136f,-0.1626526f,-0.07069363f,-0.9810229f,0.07836215f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321434f,1.538254f,0.48334f,-0.6545237f,-0.2082265f,-0.2499018f,0.6824877f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 10.4929f);
Get(0x6E70).SetLocalPose(-0.1270788f,1.686208f,-0.4891463f,0.4459028f,-0.4617304f,-0.519595f,0.5639121f);
Get(0x6E82).SetLocalPose(-0.4677009f,1.476487f,-0.2452882f,-0.857839f,-0.3184526f,-0.1834227f,0.3592441f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 10.4929f);
Get(0x6EC6).SetLocalPose(0.1686468f,0.8303779f,-0.4856169f,-0.1623854f,-0.07098702f,-0.9810363f,0.07848366f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321592f,1.538311f,0.4832485f,-0.6545274f,-0.2082604f,-0.2498918f,0.6824775f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 10.51201f);
Get(0x6E70).SetLocalPose(-0.1268258f,1.685536f,-0.4887319f,0.4454286f,-0.4617855f,-0.5194238f,0.5643992f);
Get(0x6E82).SetLocalPose(-0.475189f,1.456764f,-0.2331581f,-0.8353598f,-0.32609f,-0.1836212f,0.4026445f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 10.51201f);
Get(0x6EC6).SetLocalPose(0.1685573f,0.8303278f,-0.4855956f,-0.1621271f,-0.07114499f,-0.9810562f,0.07862586f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321672f,1.538263f,0.4832576f,-0.6545216f,-0.2082772f,-0.2498884f,0.6824793f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 10.53104f);
Get(0x6E70).SetLocalPose(-0.1268564f,1.685535f,-0.488581f,0.4452763f,-0.4618016f,-0.5193525f,0.5645718f);
Get(0x6E82).SetLocalPose(-0.4826615f,1.433132f,-0.2204511f,-0.8072719f,-0.3317446f,-0.1816829f,0.4530441f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 10.53104f);
Get(0x6EC6).SetLocalPose(0.1686038f,0.8299329f,-0.4856101f,-0.1616663f,-0.07134477f,-0.9811035f,0.07880349f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321735f,1.538146f,0.4832517f,-0.6545285f,-0.208231f,-0.2499236f,0.6824738f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 10.55085f);
Get(0x6E70).SetLocalPose(-0.1268038f,1.68529f,-0.4885497f,0.4450954f,-0.4617711f,-0.5191892f,0.5648895f);
Get(0x6E82).SetLocalPose(-0.4888976f,1.405231f,-0.2065381f,-0.7736253f,-0.3331546f,-0.1806517f,0.5078158f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 10.55085f);
Get(0x6EC6).SetLocalPose(0.1683982f,0.8306572f,-0.4860056f,-0.1612486f,-0.07145184f,-0.9811333f,0.07918961f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321698f,1.538216f,0.4832689f,-0.654539f,-0.2082322f,-0.2498968f,0.6824733f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 10.5798f);
Get(0x6E70).SetLocalPose(-0.1268102f,1.685554f,-0.4879736f,0.4451531f,-0.4617069f,-0.5187455f,0.565304f);
Get(0x6E82).SetLocalPose(-0.4938351f,1.352654f,-0.1887319f,-0.7149155f,-0.3297758f,-0.1875371f,0.5873447f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 10.5798f);
Get(0x6EC6).SetLocalPose(0.1676492f,0.8308694f,-0.486536f,-0.1601322f,-0.07172664f,-0.9812086f,0.08026684f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321767f,1.538005f,0.4830824f,-0.6545414f,-0.2082516f,-0.2498907f,0.6824672f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 10.59996f);
Get(0x6E70).SetLocalPose(-0.127027f,1.6856f,-0.4874445f,0.4455187f,-0.4614994f,-0.5182384f,0.5656505f);
Get(0x6E82).SetLocalPose(-0.4943357f,1.314531f,-0.1817372f,-0.6738091f,-0.3305191f,-0.1856591f,0.6342469f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 10.59996f);
Get(0x6EC6).SetLocalPose(0.1667439f,0.8316296f,-0.4870973f,-0.1597936f,-0.07162841f,-0.9812462f,0.08056958f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32177f,1.538124f,0.4830204f,-0.6545305f,-0.2082523f,-0.2498755f,0.6824831f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 10.61928f);
Get(0x6E70).SetLocalPose(-0.126884f,1.685315f,-0.486951f,0.4464109f,-0.4608729f,-0.517583f,0.5660578f);
Get(0x6E82).SetLocalPose(-0.494506f,1.277878f,-0.1783147f,-0.6350909f,-0.3375735f,-0.1667636f,0.674458f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 10.61928f);
Get(0x6EC6).SetLocalPose(0.1667284f,0.8322507f,-0.4876156f,-0.159504f,-0.07162149f,-0.9812441f,0.08117229f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321751f,1.537999f,0.4830925f,-0.6545429f,-0.208237f,-0.2498785f,0.6824747f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 10.63858f);
Get(0x6E70).SetLocalPose(-0.12722f,1.684913f,-0.4864748f,0.4484121f,-0.4595264f,-0.5166302f,0.5664409f);
Get(0x6E82).SetLocalPose(-0.4940565f,1.239559f,-0.1783555f,-0.5905606f,-0.3483447f,-0.1341934f,0.7154623f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 10.63858f);
Get(0x6EC6).SetLocalPose(0.1669858f,0.8320997f,-0.4875527f,-0.1597422f,-0.07171711f,-0.9811594f,0.08164152f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321692f,1.538166f,0.4832079f,-0.6545442f,-0.2082758f,-0.2498655f,0.6824664f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 10.65824f);
Get(0x6E70).SetLocalPose(-0.1277665f,1.684223f,-0.4859621f,0.4506882f,-0.4582098f,-0.5157721f,0.5664831f);
Get(0x6E82).SetLocalPose(-0.4925485f,1.201537f,-0.181045f,-0.5414532f,-0.3630204f,-0.1024016f,0.7513711f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 10.65824f);
Get(0x6EC6).SetLocalPose(0.1671477f,0.832006f,-0.4876744f,-0.1599885f,-0.07180052f,-0.9810849f,0.08198056f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321863f,1.53826f,0.4832629f,-0.6545286f,-0.2082634f,-0.2498639f,0.6824858f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 10.6775f);
Get(0x6E70).SetLocalPose(-0.1281129f,1.683545f,-0.485469f,0.4527634f,-0.4571947f,-0.515067f,0.56629f);
Get(0x6E82).SetLocalPose(-0.4892159f,1.158191f,-0.1871492f,-0.4817266f,-0.3867291f,-0.06991329f,0.7832574f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 10.6775f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32188f,1.538217f,0.4833113f,-0.6545621f,-0.2082964f,-0.2498565f,0.6824462f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 10.69671f);
Get(0x6E70).SetLocalPose(-0.1286458f,1.682992f,-0.4851558f,0.4550718f,-0.4562387f,-0.5143519f,0.5658606f);
Get(0x6E82).SetLocalPose(-0.4850337f,1.123549f,-0.1949264f,-0.4336239f,-0.4060263f,-0.04787636f,0.8030073f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 10.69671f);
Get(0x6EC6).SetLocalPose(0.167175f,0.8325449f,-0.4871543f,-0.1603798f,-0.07190669f,-0.9809819f,0.08235483f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 10.71589f);
Get(0x6E70).SetLocalPose(-0.1295974f,1.682099f,-0.4845193f,0.4571145f,-0.4555775f,-0.513597f,0.5654323f);
Get(0x6E82).SetLocalPose(-0.4772536f,1.082275f,-0.2070071f,-0.3756311f,-0.4185006f,-0.03769191f,0.8260375f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 10.71589f);
Get(0x6EC6).SetLocalPose(0.168095f,0.8318461f,-0.4872798f,-0.1613308f,-0.07210574f,-0.9807478f,0.08310793f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321965f,1.538306f,0.4833021f,-0.6545296f,-0.2082641f,-0.2498663f,0.6824837f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 10.73557f);
Get(0x6E70).SetLocalPose(-0.1300756f,1.681783f,-0.4839016f,0.4582827f,-0.4551797f,-0.5129682f,0.5653777f);
Get(0x6E82).SetLocalPose(-0.4664273f,1.045892f,-0.2205977f,-0.3286397f,-0.4173142f,-0.04861158f,0.8458616f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 10.73557f);
Get(0x6EC6).SetLocalPose(0.1690498f,0.8308784f,-0.4868099f,-0.1628555f,-0.07242108f,-0.9803756f,0.08424316f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321837f,1.538474f,0.4833758f,-0.6545533f,-0.2082798f,-0.2498733f,0.6824536f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 10.75523f);
Get(0x6E70).SetLocalPose(-0.1309379f,1.681648f,-0.4827687f,0.459527f,-0.4547489f,-0.5120489f,0.5655478f);
Get(0x6E82).SetLocalPose(-0.4567803f,1.018352f,-0.2330924f,-0.2972253f,-0.410889f,-0.06268468f,0.8595917f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 10.75523f);
Get(0x6EC6).SetLocalPose(0.1700138f,0.8296713f,-0.4873336f,-0.1658168f,-0.07243903f,-0.9797261f,0.08598893f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32175f,1.538207f,0.4834325f,-0.6545447f,-0.2082422f,-0.249902f,0.6824629f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 10.77467f);
Get(0x6E70).SetLocalPose(-0.13117f,1.681305f,-0.4820031f,0.4604547f,-0.4542385f,-0.5113837f,0.5658053f);
Get(0x6E82).SetLocalPose(-0.4408557f,0.9811696f,-0.2527483f,-0.2548348f,-0.3968828f,-0.08249629f,0.8779166f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 10.77467f);
Get(0x6EC6).SetLocalPose(0.1702818f,0.8296297f,-0.4873014f,-0.1675433f,-0.07235093f,-0.9793726f,0.08674124f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321768f,1.538336f,0.4832889f,-0.6545457f,-0.2082654f,-0.2498718f,0.6824659f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 10.79432f);
Get(0x6E70).SetLocalPose(-0.1318601f,1.681312f,-0.4811076f,0.4612168f,-0.453616f,-0.5110391f,0.5659953f);
Get(0x6E82).SetLocalPose(-0.4287824f,0.9555936f,-0.268914f,-0.2243596f,-0.3883546f,-0.09039155f,0.8891979f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 10.79432f);
Get(0x6EC6).SetLocalPose(0.1706895f,0.830652f,-0.4872297f,-0.170672f,-0.07218952f,-0.9787834f,0.08742312f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321751f,1.538289f,0.4831466f,-0.6545284f,-0.2082595f,-0.2498712f,0.6824844f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 10.81366f);
Get(0x6E70).SetLocalPose(-0.1326875f,1.680828f,-0.4798601f,0.4620979f,-0.4525791f,-0.510882f,0.5662485f);
Get(0x6E82).SetLocalPose(-0.4137695f,0.9263029f,-0.2899065f,-0.1856498f,-0.3850306f,-0.09053124f,0.8994941f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 10.81366f);
Get(0x6EC6).SetLocalPose(0.1707482f,0.8308402f,-0.487924f,-0.1716184f,-0.07210533f,-0.9786146f,0.08752859f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321597f,1.538187f,0.4832137f,-0.6545274f,-0.2082379f,-0.2498978f,0.6824823f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 10.83257f);
Get(0x6E70).SetLocalPose(-0.1330217f,1.680817f,-0.4791805f,0.4623739f,-0.4520816f,-0.5108991f,0.5664051f);
Get(0x6E82).SetLocalPose(-0.4036346f,0.9060675f,-0.3063231f,-0.1560529f,-0.3866895f,-0.08841607f,0.9046f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 10.83257f);
Get(0x6EC6).SetLocalPose(0.1707567f,0.8308794f,-0.4880087f,-0.173008f,-0.07198632f,-0.9783797f,0.08751843f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321647f,1.538154f,0.4831445f,-0.6545505f,-0.2082549f,-0.2498892f,0.682458f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 10.85132f);
Get(0x6E70).SetLocalPose(-0.1335271f,1.680271f,-0.4777992f,0.4625213f,-0.4514712f,-0.5108679f,0.5667997f);
Get(0x6E82).SetLocalPose(-0.3916768f,0.8850732f,-0.3263265f,-0.1201554f,-0.3876304f,-0.08735891f,0.9097658f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 10.85132f);
Get(0x6EC6).SetLocalPose(0.171011f,0.8309228f,-0.4886875f,-0.178424f,-0.07168093f,-0.9774714f,0.08704238f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321638f,1.53814f,0.4832557f,-0.65456f,-0.2082366f,-0.2498911f,0.6824539f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 10.87984f);
Get(0x6E70).SetLocalPose(-0.133714f,1.680326f,-0.4767193f,0.4625502f,-0.4509666f,-0.5109614f,0.5670934f);
Get(0x6E82).SetLocalPose(-0.3723437f,0.8588196f,-0.3529498f,-0.07332291f,-0.3730785f,-0.08709627f,0.920788f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 10.87984f);
Get(0x6EC6).SetLocalPose(0.1710859f,0.831867f,-0.4890405f,-0.1822523f,-0.07153442f,-0.9767854f,0.08693276f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321521f,1.538119f,0.4834425f,-0.6545638f,-0.2082281f,-0.2499029f,0.6824485f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 10.89966f);
Get(0x6E70).SetLocalPose(-0.1337472f,1.680351f,-0.4754198f,0.4627555f,-0.4506504f,-0.511422f,0.5667619f);
Get(0x6E82).SetLocalPose(-0.3610409f,0.8456373f,-0.3694378f,-0.04807861f,-0.3579242f,-0.08634482f,0.928506f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 10.89966f);
Get(0x6EC6).SetLocalPose(0.1715384f,0.8316112f,-0.4896053f,-0.1869269f,-0.07112264f,-0.975897f,0.08732109f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321485f,1.538255f,0.4833735f,-0.6545427f,-0.2082173f,-0.249908f,0.6824701f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 10.91926f);
Get(0x6E70).SetLocalPose(-0.1343215f,1.680133f,-0.474524f,0.4629869f,-0.4505105f,-0.5119774f,0.5661824f);
Get(0x6E82).SetLocalPose(-0.3489635f,0.8336204f,-0.3866858f,-0.02443495f,-0.3414355f,-0.08522665f,0.9357142f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 10.91926f);
Get(0x6EC6).SetLocalPose(0.1713531f,0.832179f,-0.4905959f,-0.1907031f,-0.07005575f,-0.9752415f,0.08734176f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321459f,1.538249f,0.4833063f,-0.6545518f,-0.2082162f,-0.249899f,0.682465f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 10.93843f);
Get(0x6E70).SetLocalPose(-0.1350417f,1.679836f,-0.474117f,0.4629754f,-0.4504401f,-0.5124843f,0.5657892f);
Get(0x6E82).SetLocalPose(-0.3391518f,0.8255621f,-0.4001955f,-0.007335732f,-0.328098f,-0.08410475f,0.9408635f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 10.93843f);
Get(0x6EC6).SetLocalPose(0.171417f,0.8315708f,-0.4923564f,-0.1955626f,-0.0683011f,-0.9744517f,0.08679949f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321665f,1.538215f,0.4831947f,-0.6545358f,-0.2082231f,-0.2498856f,0.6824831f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 10.95721f);
Get(0x6E70).SetLocalPose(-0.1358723f,1.679918f,-0.4735187f,0.4627807f,-0.4504413f,-0.5129395f,0.5655351f);
Get(0x6E82).SetLocalPose(-0.3264433f,0.8176299f,-0.4144041f,0.01320836f,-0.3062994f,-0.08037262f,0.9484442f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 10.95721f);
Get(0x6EC6).SetLocalPose(0.1718354f,0.8307882f,-0.492386f,-0.1979829f,-0.06727719f,-0.9740746f,0.08634358f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321721f,1.538176f,0.4831783f,-0.654521f,-0.2082256f,-0.2499133f,0.6824864f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 10.97591f);
Get(0x6E70).SetLocalPose(-0.1366267f,1.679999f,-0.4725021f,0.4622735f,-0.4505322f,-0.513509f,0.5653605f);
Get(0x6E82).SetLocalPose(-0.3158607f,0.8113568f,-0.4255701f,0.02852049f,-0.2855821f,-0.07302105f,0.9551426f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 10.97591f);
Get(0x6EC6).SetLocalPose(0.1723952f,0.8306266f,-0.4926727f,-0.199537f,-0.06684276f,-0.9738197f,0.08597881f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321776f,1.538184f,0.4832377f,-0.6545355f,-0.2082445f,-0.2498712f,0.6824822f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 10.99609f);
Get(0x6E70).SetLocalPose(-0.1375104f,1.679795f,-0.4717329f,0.4615458f,-0.4505107f,-0.5143053f,0.5652484f);
Get(0x6E82).SetLocalPose(-0.3048345f,0.8058828f,-0.4375773f,0.04098517f,-0.2716504f,-0.05571811f,0.9599072f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 10.99609f);
Get(0x6EC6).SetLocalPose(0.1747296f,0.8300858f,-0.4925715f,-0.202354f,-0.06600212f,-0.9734107f,0.08466563f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321717f,1.538171f,0.4832822f,-0.6545389f,-0.2082465f,-0.2498813f,0.6824747f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 11.01561f);
Get(0x6E70).SetLocalPose(-0.1385312f,1.680525f,-0.4710582f,0.4605541f,-0.4502039f,-0.5153584f,0.5653425f);
Get(0x6E82).SetLocalPose(-0.2977752f,0.8035799f,-0.4448984f,0.04716568f,-0.2713315f,-0.04131241f,0.9604416f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 11.01561f);
Get(0x6EC6).SetLocalPose(0.1770328f,0.8306976f,-0.4917381f,-0.2016201f,-0.06447753f,-0.9736374f,0.08498345f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321738f,1.538154f,0.4832864f,-0.6545353f,-0.2082699f,-0.2498586f,0.6824793f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 11.03569f);
Get(0x6E70).SetLocalPose(-0.1391277f,1.680611f,-0.4704485f,0.4598418f,-0.449939f,-0.5158682f,0.5656681f);
Get(0x6E82).SetLocalPose(-0.2921972f,0.8020774f,-0.4513839f,0.05355677f,-0.2738062f,-0.02835181f,0.959874f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 11.03569f);
Get(0x6EC6).SetLocalPose(0.1808188f,0.8331085f,-0.4898571f,-0.1957027f,-0.06359816f,-0.974558f,0.08884002f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321748f,1.538238f,0.4832144f,-0.6545458f,-0.2082673f,-0.2498674f,0.6824667f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 11.05523f);
Get(0x6E70).SetLocalPose(-0.1404893f,1.680846f,-0.4695005f,0.4586336f,-0.4493642f,-0.5164073f,0.5666134f);
Get(0x6E82).SetLocalPose(-0.287537f,0.8024345f,-0.4561665f,0.05916621f,-0.2714981f,-0.01878702f,0.960435f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 11.05523f);
Get(0x6EC6).SetLocalPose(0.1844997f,0.8344662f,-0.4866131f,-0.1910468f,-0.06453605f,-0.9750426f,0.0928876f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321748f,1.538201f,0.4832432f,-0.6545365f,-0.2082596f,-0.2498907f,0.6824694f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 11.07454f);
Get(0x6E70).SetLocalPose(-0.1412177f,1.680714f,-0.4686586f,0.4576599f,-0.4488987f,-0.5167216f,0.5674823f);
Get(0x6E82).SetLocalPose(-0.2828163f,0.8033866f,-0.4576359f,0.05983756f,-0.2602567f,-0.009901248f,0.9636326f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 11.07454f);
Get(0x6EC6).SetLocalPose(0.1957127f,0.8398525f,-0.4761084f,-0.1812015f,-0.07667837f,-0.9749898f,0.1033508f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321649f,1.538334f,0.4833306f,-0.6545402f,-0.2082855f,-0.2498559f,0.6824707f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 11.09412f);
Get(0x6E70).SetLocalPose(-0.1417107f,1.68077f,-0.4678719f,0.4568985f,-0.4484699f,-0.5172113f,0.5679886f);
Get(0x6E82).SetLocalPose(-0.2775695f,0.8047419f,-0.4585066f,0.05155077f,-0.240115f,-0.00491217f,0.9693623f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 11.09412f);
Get(0x6EC6).SetLocalPose(0.2078945f,0.848635f,-0.4651521f,-0.1760386f,-0.09599149f,-0.9727956f,0.1160382f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321874f,1.538418f,0.4832579f,-0.6545386f,-0.2082906f,-0.2498608f,0.682469f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 11.11336f);
Get(0x6E70).SetLocalPose(-0.1428674f,1.680433f,-0.4668892f,0.4561187f,-0.4479561f,-0.5181628f,0.5681536f);
Get(0x6E82).SetLocalPose(-0.2747257f,0.8073766f,-0.4576043f,0.04092249f,-0.2218221f,-0.007443767f,0.9741996f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 11.11336f);
Get(0x6EC6).SetLocalPose(0.2213559f,0.8573416f,-0.455131f,-0.1776173f,-0.1162357f,-0.9687956f,0.1279707f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321951f,1.538393f,0.4832886f,-0.6545696f,-0.2083268f,-0.249847f,0.6824332f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 11.1331f);
Get(0x6E70).SetLocalPose(-0.144201f,1.680757f,-0.4665174f,0.4557866f,-0.4474524f,-0.51907f,0.5679889f);
Get(0x6E82).SetLocalPose(-0.275685f,0.8076382f,-0.4553307f,0.03978923f,-0.2173076f,-0.01089356f,0.9752311f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 11.1331f);
Get(0x6EC6).SetLocalPose(0.2393012f,0.87085f,-0.4424055f,-0.1880291f,-0.1445735f,-0.9611879f,0.1409306f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321829f,1.538231f,0.4832582f,-0.6545576f,-0.2082822f,-0.2498746f,0.6824481f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 11.1534f);
Get(0x6E70).SetLocalPose(-0.1452074f,1.680631f,-0.4663281f,0.4555444f,-0.4468686f,-0.5199875f,0.5678034f);
Get(0x6E82).SetLocalPose(-0.2762436f,0.8073104f,-0.4544703f,0.04389184f,-0.2154827f,-0.01013116f,0.9754682f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 11.1534f);
Get(0x6EC6).SetLocalPose(0.2595986f,0.8903186f,-0.4262283f,-0.2063043f,-0.1794602f,-0.9501676f,0.1497134f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321886f,1.538206f,0.4833266f,-0.6545592f,-0.2082896f,-0.2498957f,0.6824367f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 11.17219f);
Get(0x6E70).SetLocalPose(-0.1460157f,1.680183f,-0.4663678f,0.4553161f,-0.446489f,-0.5206535f,0.5676749f);
Get(0x6E82).SetLocalPose(-0.2757653f,0.8063093f,-0.4528175f,0.04591277f,-0.2079797f,-0.00865769f,0.9770166f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 11.17219f);
Get(0x6EC6).SetLocalPose(0.2774759f,0.9093396f,-0.4119848f,-0.22329f,-0.2138497f,-0.9384667f,0.1539166f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321629f,1.538187f,0.4835296f,-0.6545566f,-0.2082659f,-0.2498902f,0.6824484f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 11.19952f);
Get(0x6E70).SetLocalPose(-0.1469899f,1.680501f,-0.4661093f,0.4550728f,-0.4461739f,-0.5211805f,0.5676342f);
Get(0x6E82).SetLocalPose(-0.2744279f,0.8051379f,-0.4502602f,0.04626807f,-0.1917981f,-0.00755834f,0.980314f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 11.19952f);
Get(0x6EC6).SetLocalPose(0.311881f,0.9589475f,-0.3836413f,-0.2508281f,-0.2923609f,-0.9088405f,0.1600607f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32171f,1.538252f,0.4833536f,-0.6545551f,-0.208278f,-0.2498875f,0.6824473f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 11.21831f);
Get(0x6E70).SetLocalPose(-0.1477241f,1.680714f,-0.4660042f,0.4550323f,-0.4459074f,-0.5213607f,0.5677106f);
Get(0x6E82).SetLocalPose(-0.2735826f,0.803563f,-0.4479447f,0.04656756f,-0.1811064f,-0.009305576f,0.9823164f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 11.21831f);
Get(0x6EC6).SetLocalPose(0.3310342f,0.9965382f,-0.3680611f,-0.260969f,-0.3454801f,-0.8854064f,0.1690979f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321768f,1.53812f,0.4833544f,-0.6545444f,-0.2082664f,-0.2499035f,0.6824552f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 11.23836f);
Get(0x6E70).SetLocalPose(-0.1481789f,1.680993f,-0.4658669f,0.4552208f,-0.445699f,-0.5213028f,0.5677763f);
Get(0x6E82).SetLocalPose(-0.2725049f,0.8032938f,-0.4448315f,0.04677973f,-0.1692872f,-0.01237679f,0.9843782f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 11.23836f);
Get(0x6EC6).SetLocalPose(0.350085f,1.045386f,-0.3519967f,-0.2632549f,-0.4088256f,-0.8535979f,0.186893f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321646f,1.538243f,0.4832512f,-0.6545246f,-0.208248f,-0.2499082f,0.6824781f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 11.25788f);
Get(0x6E70).SetLocalPose(-0.1484708f,1.680383f,-0.4658691f,0.4556601f,-0.4453796f,-0.5212815f,0.5676941f);
Get(0x6E82).SetLocalPose(-0.2712564f,0.8034376f,-0.4427043f,0.04670284f,-0.1580795f,-0.01437296f,0.9862167f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 11.25788f);
Get(0x6EC6).SetLocalPose(0.3648267f,1.101358f,-0.3409948f,-0.2564881f,-0.4759823f,-0.8139356f,0.2125172f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321778f,1.538293f,0.4831984f,-0.654499f,-0.2082833f,-0.2499041f,0.6824933f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 11.27824f);
Get(0x6E70).SetLocalPose(-0.1487775f,1.680111f,-0.4659906f,0.4562125f,-0.4450387f,-0.521284f,0.5675154f);
Get(0x6E82).SetLocalPose(-0.2694438f,0.803492f,-0.439425f,0.04601019f,-0.143694f,-0.01639134f,0.9884161f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 11.27824f);
Get(0x6EC6).SetLocalPose(0.3740957f,1.159489f,-0.3337342f,-0.2434966f,-0.5405366f,-0.7682648f,0.2414514f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321823f,1.538236f,0.4831492f,-0.6545036f,-0.2082839f,-0.2498952f,0.682492f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 11.29792f);
Get(0x6E70).SetLocalPose(-0.149006f,1.679894f,-0.4660547f,0.4568705f,-0.4446767f,-0.5211734f,0.5673714f);
Get(0x6E82).SetLocalPose(-0.2670308f,0.8044785f,-0.4372048f,0.04493643f,-0.1315041f,-0.01864622f,0.9901211f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 11.29792f);
Get(0x6EC6).SetLocalPose(0.3778084f,1.221876f,-0.3326109f,-0.2271455f,-0.6030412f,-0.7153752f,0.2701568f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321768f,1.53827f,0.4832254f,-0.6545027f,-0.2083017f,-0.2499046f,0.6824839f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 11.31784f);
Get(0x6E70).SetLocalPose(-0.1496825f,1.680031f,-0.4655843f,0.4575899f,-0.4443627f,-0.5210095f,0.5671881f);
Get(0x6E82).SetLocalPose(-0.265056f,0.8050253f,-0.4350777f,0.04423311f,-0.1218491f,-0.02036848f,0.9913533f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 11.31784f);
Get(0x6EC6).SetLocalPose(0.376234f,1.277937f,-0.3372518f,-0.2144003f,-0.6583968f,-0.6587977f,0.294163f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321649f,1.538266f,0.4833825f,-0.6544943f,-0.2082721f,-0.249929f,0.682492f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 11.33772f);
Get(0x6E70).SetLocalPose(-0.1506352f,1.679894f,-0.465271f,0.4583117f,-0.4441299f,-0.5207828f,0.566996f);
Get(0x6E82).SetLocalPose(-0.263018f,0.8056137f,-0.4322992f,0.04189041f,-0.1125261f,-0.02140842f,0.9925346f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 11.33772f);
Get(0x6EC6).SetLocalPose(0.3697182f,1.334175f,-0.3482836f,-0.2016669f,-0.7166532f,-0.5845312f,0.3225861f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321703f,1.538151f,0.4831476f,-0.6544784f,-0.2082856f,-0.2499072f,0.6825112f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 11.3572f);
Get(0x6E70).SetLocalPose(-0.1511116f,1.679956f,-0.4651139f,0.4591844f,-0.4438462f,-0.5205007f,0.5667709f);
Get(0x6E82).SetLocalPose(-0.2612146f,0.8059816f,-0.4301324f,0.03974297f,-0.106949f,-0.0219497f,0.9932274f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 11.3572f);
Get(0x6EC6).SetLocalPose(0.3603707f,1.378848f,-0.3614967f,-0.1895051f,-0.7619364f,-0.5133056f,0.3464941f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321747f,1.538073f,0.4830633f,-0.6544688f,-0.2083053f,-0.2499121f,0.6825126f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 11.37704f);
Get(0x6E70).SetLocalPose(-0.1515249f,1.680025f,-0.4648688f,0.4603311f,-0.443465f,-0.5199966f,0.5666019f);
Get(0x6E82).SetLocalPose(-0.2597465f,0.8061283f,-0.4272835f,0.03772047f,-0.101521f,-0.02286734f,0.993855f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 11.37704f);
Get(0x6EC6).SetLocalPose(0.3455614f,1.42862f,-0.3825913f,-0.1732376f,-0.8145691f,-0.4151447f,0.3662249f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321936f,1.538177f,0.4829382f,-0.6544775f,-0.2082773f,-0.24989f,0.6825209f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 11.39672f);
Get(0x6E70).SetLocalPose(-0.1520541f,1.679608f,-0.4645636f,0.4611825f,-0.443177f,-0.5196367f,0.566465f);
Get(0x6E82).SetLocalPose(-0.2581322f,0.8061354f,-0.4251698f,0.03586003f,-0.09724404f,-0.02372471f,0.9943314f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 11.39672f);
Get(0x6EC6).SetLocalPose(0.3327426f,1.460943f,-0.401486f,-0.1622196f,-0.8493412f,-0.3403076f,0.3694524f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321907f,1.538124f,0.4830148f,-0.654486f,-0.2082716f,-0.2498972f,0.6825119f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 11.41684f);
Get(0x6E70).SetLocalPose(-0.1522664f,1.678502f,-0.4646363f,0.4619965f,-0.4428938f,-0.5192718f,0.5663578f);
Get(0x6E82).SetLocalPose(-0.256051f,0.8061603f,-0.4229679f,0.03276423f,-0.09023932f,-0.02457217f,0.9950777f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 11.41684f);
Get(0x6EC6).SetLocalPose(0.3111226f,1.497825f,-0.4303885f,-0.1460108f,-0.8930379f,-0.2297505f,0.3583004f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321808f,1.538171f,0.48305f,-0.6544908f,-0.208266f,-0.2498788f,0.6825156f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 11.43771f);
Get(0x6E70).SetLocalPose(-0.1531384f,1.678046f,-0.464304f,0.4627847f,-0.442439f,-0.5190209f,0.5662998f);
Get(0x6E82).SetLocalPose(-0.2529017f,0.8075482f,-0.4208421f,0.02969869f,-0.07907966f,-0.02574198f,0.9960933f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 11.43771f);
Get(0x6EC6).SetLocalPose(0.2924393f,1.519356f,-0.4551072f,-0.1293968f,-0.9228172f,-0.1361714f,0.3363366f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321701f,1.538253f,0.4830756f,-0.6544843f,-0.2082578f,-0.2499111f,0.6825126f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 11.45759f);
Get(0x6E70).SetLocalPose(-0.1536231f,1.677955f,-0.4638667f,0.4634068f,-0.4420026f,-0.5187921f,0.5663415f);
Get(0x6E82).SetLocalPose(-0.2505837f,0.8073693f,-0.4199419f,0.02623632f,-0.0675476f,-0.02734049f,0.9969962f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 11.45759f);
Get(0x6EC6).SetLocalPose(0.2766159f,1.533135f,-0.4754993f,-0.1097182f,-0.9427602f,-0.05416662f,0.3102114f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321803f,1.538281f,0.4830427f,-0.6544847f,-0.2082756f,-0.2498957f,0.6825125f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 11.47804f);
Get(0x6E70).SetLocalPose(-0.1547017f,1.67848f,-0.4630225f,0.4644558f,-0.4411647f,-0.518262f,0.5666208f);
Get(0x6E82).SetLocalPose(-0.2478618f,0.8085288f,-0.4185705f,0.02081306f,-0.05296533f,-0.03041943f,0.9979159f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 11.47804f);
Get(0x6EC6).SetLocalPose(0.2563461f,1.544376f,-0.4981504f,-0.07777292f,-0.9559646f,0.03968502f,0.2801933f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321644f,1.538248f,0.4830682f,-0.6544968f,-0.2082745f,-0.2499123f,0.6824951f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 11.49807f);
Get(0x6E70).SetLocalPose(-0.1558268f,1.678002f,-0.4625156f,0.4655526f,-0.4403633f,-0.5175518f,0.5669931f);
Get(0x6E82).SetLocalPose(-0.2451112f,0.8085773f,-0.4182833f,0.01553857f,-0.04144258f,-0.03358553f,0.9984553f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 11.49807f);
Get(0x6EC6).SetLocalPose(0.2389666f,1.547017f,-0.5149612f,-0.0404271f,-0.9572733f,0.117138f,0.2612897f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321738f,1.53826f,0.4829874f,-0.6544917f,-0.2082763f,-0.249891f,0.6825072f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 11.51808f);
Get(0x6E70).SetLocalPose(-0.1564314f,1.677562f,-0.4625441f,0.4664584f,-0.4398153f,-0.5170544f,0.5671278f);
Get(0x6E82).SetLocalPose(-0.2437814f,0.806363f,-0.41759f,0.0115681f,-0.03325853f,-0.03593975f,0.9987335f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 11.51808f);
Get(0x6EC6).SetLocalPose(0.2277763f,1.546482f,-0.5247186f,-0.008319374f,-0.9514326f,0.1769318f,0.2517973f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321772f,1.538242f,0.4830459f,-0.6544862f,-0.2082639f,-0.2499116f,0.6825088f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 11.53806f);
Get(0x6E70).SetLocalPose(-0.157524f,1.677088f,-0.4623203f,0.4673912f,-0.4394502f,-0.5166069f,0.5670505f);
Get(0x6E82).SetLocalPose(-0.2420303f,0.8062417f,-0.4159076f,0.009862032f,-0.02717352f,-0.03663415f,0.9989105f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 11.53806f);
Get(0x6EC6).SetLocalPose(0.217781f,1.541226f,-0.5364357f,0.03436128f,-0.9292595f,0.2761946f,0.2429253f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321735f,1.538093f,0.4830346f,-0.6545003f,-0.2082679f,-0.2499157f,0.6824926f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 11.55756f);
Get(0x6E70).SetLocalPose(-0.1589972f,1.676809f,-0.4618019f,0.4683293f,-0.4392243f,-0.516211f,0.566812f);
Get(0x6E82).SetLocalPose(-0.2411569f,0.8065887f,-0.4144076f,0.00925598f,-0.02159335f,-0.03601326f,0.9990752f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 11.55756f);
Get(0x6EC6).SetLocalPose(0.2156794f,1.538774f,-0.5402859f,0.04775091f,-0.9097854f,0.3317299f,0.2448791f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321806f,1.53815f,0.4830697f,-0.6544833f,-0.2082716f,-0.2499006f,0.6825132f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 11.57729f);
Get(0x6E70).SetLocalPose(-0.1600997f,1.675771f,-0.4619539f,0.4690991f,-0.4390979f,-0.5160999f,0.5663744f);
Get(0x6E82).SetLocalPose(-0.2396893f,0.8065932f,-0.4135234f,0.008705063f,-0.01385102f,-0.03479332f,0.9992607f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 11.57729f);
Get(0x6EC6).SetLocalPose(0.2186569f,1.541331f,-0.5414332f,0.04538685f,-0.8986876f,0.3532298f,0.255987f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321742f,1.538074f,0.4830635f,-0.6545153f,-0.2082443f,-0.2499097f,0.6824875f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 11.59602f);
Get(0x6E70).SetLocalPose(-0.1608971f,1.674845f,-0.4621795f,0.4696662f,-0.4390444f,-0.5162169f,0.565839f);
Get(0x6E82).SetLocalPose(-0.2389092f,0.8069823f,-0.4124644f,0.008109247f,-0.007194369f,-0.03428474f,0.9993533f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 11.59602f);
Get(0x6EC6).SetLocalPose(0.2262155f,1.548201f,-0.5415384f,0.03482888f,-0.901585f,0.3399261f,0.2652955f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321652f,1.538011f,0.4831927f,-0.6545196f,-0.2082449f,-0.2499257f,0.6824774f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 11.61535f);
Get(0x6E70).SetLocalPose(-0.1622012f,1.675479f,-0.4626408f,0.4702815f,-0.4389797f,-0.5164027f,0.5652081f);
Get(0x6E82).SetLocalPose(-0.2381319f,0.8060557f,-0.4112579f,0.007036735f,-0.001120558f,-0.03403981f,0.9993951f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 11.61535f);
Get(0x6EC6).SetLocalPose(0.2390794f,1.557683f,-0.5401257f,0.007998905f,-0.9125673f,0.3069225f,0.2701032f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321513f,1.538132f,0.4832421f,-0.6545194f,-0.208237f,-0.2499138f,0.6824843f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 11.63511f);
Get(0x6E70).SetLocalPose(-0.1631685f,1.675215f,-0.4627691f,0.4704318f,-0.4389704f,-0.5165577f,0.5649487f);
Get(0x6E82).SetLocalPose(-0.2374247f,0.8065293f,-0.4110782f,0.005879416f,0.003907256f,-0.03362458f,0.9994096f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 11.63511f);
Get(0x6EC6).SetLocalPose(0.2512172f,1.564121f,-0.539349f,-0.03177481f,-0.9254797f,0.2691261f,0.2646676f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321394f,1.538151f,0.4833197f,-0.6545213f,-0.2082323f,-0.2499262f,0.6824794f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 11.65552f);
Get(0x6E70).SetLocalPose(-0.1647075f,1.674958f,-0.4629155f,0.4705758f,-0.4388143f,-0.5165347f,0.5649711f);
Get(0x6E82).SetLocalPose(-0.2369615f,0.8061105f,-0.4098293f,0.004242535f,0.009047015f,-0.03313711f,0.9994009f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 11.65552f);
Get(0x6EC6).SetLocalPose(0.2737859f,1.576828f,-0.5340638f,-0.1044843f,-0.9441931f,0.2059574f,0.2348703f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321364f,1.53825f,0.4832778f,-0.6545148f,-0.2082499f,-0.2499186f,0.682483f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 11.67493f);
Get(0x6E70).SetLocalPose(-0.1663912f,1.674788f,-0.4631571f,0.4708881f,-0.438199f,-0.516277f,0.5654238f);
Get(0x6E82).SetLocalPose(-0.2370855f,0.8068243f,-0.4083798f,0.003116914f,0.0116471f,-0.03297792f,0.9993834f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 11.67493f);
Get(0x6EC6).SetLocalPose(0.2925287f,1.5854f,-0.5314732f,-0.172567f,-0.9553729f,0.144608f,0.1912374f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32136f,1.538353f,0.483294f,-0.6545053f,-0.2082674f,-0.2499057f,0.6824916f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 11.69517f);
Get(0x6E70).SetLocalPose(-0.1678957f,1.674445f,-0.4631754f,0.4714322f,-0.4374021f,-0.5159749f,0.5658631f);
Get(0x6E82).SetLocalPose(-0.2367394f,0.8078229f,-0.4067549f,0.001845392f,0.01458153f,-0.03286403f,0.9993518f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 11.69517f);
Get(0x6EC6).SetLocalPose(0.3202197f,1.595415f,-0.5287724f,-0.2592297f,-0.9556471f,0.0581915f,0.1270923f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321481f,1.538206f,0.4832551f,-0.6545388f,-0.2082429f,-0.2499061f,0.6824667f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 11.71464f);
Get(0x6E70).SetLocalPose(-0.1684632f,1.674568f,-0.4634579f,0.4723581f,-0.4365509f,-0.5156573f,0.5660378f);
Get(0x6E82).SetLocalPose(-0.2362834f,0.8082444f,-0.4059648f,0.00032819f,0.01703443f,-0.03291886f,0.9993128f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 11.71464f);
Get(0x6EC6).SetLocalPose(0.3429666f,1.603087f,-0.5239613f,-0.3281614f,-0.9402632f,-0.01020222f,0.09006215f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321682f,1.538245f,0.483171f,-0.6545306f,-0.2082803f,-0.2498833f,0.6824715f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 11.73442f);
Get(0x6E70).SetLocalPose(-0.1695367f,1.67435f,-0.4636011f,0.4738833f,-0.4355014f,-0.5153482f,0.5658528f);
Get(0x6E82).SetLocalPose(-0.2360895f,0.8082355f,-0.4055291f,-0.0009836927f,0.01767562f,-0.03323419f,0.9992908f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 11.73442f);
Get(0x6EC6).SetLocalPose(0.356984f,1.606215f,-0.5222107f,-0.3805833f,-0.9186315f,-0.05681887f,0.08968975f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321756f,1.538299f,0.4831679f,-0.6545104f,-0.2082614f,-0.2498795f,0.682498f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 11.75471f);
Get(0x6E70).SetLocalPose(-0.17062f,1.673935f,-0.4636581f,0.4753967f,-0.4345545f,-0.5151889f,0.5654563f);
Get(0x6E82).SetLocalPose(-0.2363929f,0.8085452f,-0.4044304f,-0.002207019f,0.01676381f,-0.03332616f,0.9993016f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 11.75471f);
Get(0x6EC6).SetLocalPose(0.360881f,1.614042f,-0.5211537f,-0.4066311f,-0.9013575f,-0.09446153f,0.1152512f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32187f,1.538252f,0.4830867f,-0.6544969f,-0.208275f,-0.2498905f,0.6825028f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 11.77402f);
Get(0x6E70).SetLocalPose(-0.171023f,1.673162f,-0.4640121f,0.4773058f,-0.4335039f,-0.5146327f,0.5651609f);
Get(0x6E82).SetLocalPose(-0.2365768f,0.8088277f,-0.4035919f,-0.002762843f,0.01588069f,-0.03308934f,0.9993225f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 11.77402f);
Get(0x6EC6).SetLocalPose(0.3557329f,1.617783f,-0.520743f,-0.3891493f,-0.9051862f,-0.1022245f,0.1369339f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32188f,1.538302f,0.4831004f,-0.6545138f,-0.2082772f,-0.2498939f,0.6824847f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 11.79307f);
Get(0x6E70).SetLocalPose(-0.1718325f,1.672653f,-0.4643266f,0.4789737f,-0.4330074f,-0.5132723f,0.5653675f);
Get(0x6E82).SetLocalPose(-0.2368686f,0.8091244f,-0.4031798f,-0.003274674f,0.01581393f,-0.03290087f,0.9993281f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 11.79307f);
Get(0x6EC6).SetLocalPose(0.3397979f,1.619161f,-0.524799f,-0.3486499f,-0.9195514f,-0.08144245f,0.1619738f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321666f,1.538274f,0.4833921f,-0.654525f,-0.2082773f,-0.2498985f,0.6824723f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 11.8124f);
Get(0x6E70).SetLocalPose(-0.1719886f,1.671954f,-0.4644244f,0.4805208f,-0.4328955f,-0.5113182f,0.5659108f);
Get(0x6E82).SetLocalPose(-0.236662f,0.8093895f,-0.4030096f,-0.004277803f,0.01623053f,-0.03309114f,0.9993114f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 11.8124f);
Get(0x6EC6).SetLocalPose(0.3186263f,1.617828f,-0.5293507f,-0.2971972f,-0.9334513f,-0.03431782f,0.1979009f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321655f,1.538338f,0.4833553f,-0.6545234f,-0.2082887f,-0.2499196f,0.6824626f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 11.83214f);
Get(0x6E70).SetLocalPose(-0.1729047f,1.671402f,-0.464205f,0.4822213f,-0.4329661f,-0.5091838f,0.5663345f);
Get(0x6E82).SetLocalPose(-0.2366255f,0.8089029f,-0.4037265f,-0.005225067f,0.01648807f,-0.03337301f,0.9992933f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 11.83214f);
Get(0x6EC6).SetLocalPose(0.2945204f,1.612478f,-0.5346736f,-0.2395628f,-0.9417816f,0.03145665f,0.2338107f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321719f,1.538215f,0.4832399f,-0.6545275f,-0.208254f,-0.2499019f,0.6824757f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 11.85133f);
Get(0x6E70).SetLocalPose(-0.1729742f,1.670919f,-0.4637879f,0.4844883f,-0.4328139f,-0.507326f,0.5661833f);
Get(0x6E82).SetLocalPose(-0.2364601f,0.8086041f,-0.404224f,-0.005165809f,0.01671011f,-0.03311029f,0.9992987f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 11.85133f);
Get(0x6EC6).SetLocalPose(0.2729484f,1.604541f,-0.5408409f,-0.1809372f,-0.9444634f,0.09998594f,0.2554474f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32147f,1.538215f,0.4834324f,-0.6545354f,-0.2082608f,-0.2499205f,0.6824593f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 11.87083f);
Get(0x6E70).SetLocalPose(-0.1730559f,1.670029f,-0.4636214f,0.4865749f,-0.4323805f,-0.5066029f,0.565372f);
Get(0x6E82).SetLocalPose(-0.2357129f,0.8084506f,-0.4046352f,-0.003883691f,0.01767317f,-0.03231235f,0.9993141f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 11.87083f);
Get(0x6EC6).SetLocalPose(0.2505854f,1.594384f,-0.5446351f,-0.108179f,-0.9402899f,0.1818988f,0.2665807f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32161f,1.538186f,0.4832546f,-0.6545053f,-0.2082919f,-0.2498992f,0.6824865f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 11.89937f);
Get(0x6E70).SetLocalPose(-0.1735586f,1.66958f,-0.4629282f,0.4889241f,-0.4316545f,-0.5063564f,0.5641195f);
Get(0x6E82).SetLocalPose(-0.2350461f,0.8089713f,-0.4049042f,-0.001711434f,0.02048697f,-0.03097678f,0.9993087f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 11.89937f);
Get(0x6EC6).SetLocalPose(0.2262137f,1.575013f,-0.5491112f,-0.002642604f,-0.9143843f,0.2993076f,0.2725973f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321727f,1.538051f,0.4831667f,-0.6545167f,-0.208261f,-0.24989f,0.6824883f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 11.91934f);
Get(0x6E70).SetLocalPose(-0.1734598f,1.669775f,-0.4624341f,0.4906848f,-0.4311549f,-0.5064142f,0.5629197f);
Get(0x6E82).SetLocalPose(-0.2344051f,0.8086957f,-0.4052365f,-0.0009498885f,0.02187779f,-0.03045793f,0.9992962f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 11.91934f);
Get(0x6EC6).SetLocalPose(0.2133966f,1.562321f,-0.5490426f,0.06629358f,-0.8793231f,0.3816803f,0.2769774f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321784f,1.538034f,0.4831935f,-0.6545323f,-0.2082835f,-0.2498942f,0.6824649f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 11.93879f);
Get(0x6E70).SetLocalPose(-0.1732965f,1.669752f,-0.4623761f,0.4915362f,-0.4308639f,-0.506591f,0.5622402f);
Get(0x6E82).SetLocalPose(-0.2342739f,0.808789f,-0.4057733f,-0.001180615f,0.02200749f,-0.03034106f,0.9992967f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 11.93879f);
Get(0x6EC6).SetLocalPose(0.2077897f,1.556575f,-0.5474277f,0.09721135f,-0.8565903f,0.4187475f,0.2854005f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321792f,1.538051f,0.4832366f,-0.6545238f,-0.2082639f,-0.249924f,0.6824682f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 11.9578f);
Get(0x6E70).SetLocalPose(-0.1732904f,1.669871f,-0.4622643f,0.49191f,-0.4307491f,-0.5068584f,0.5617601f);
Get(0x6E82).SetLocalPose(-0.2341861f,0.8087354f,-0.405933f,-0.002059965f,0.02165795f,-0.030774f,0.9992896f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 11.9578f);
Get(0x6EC6).SetLocalPose(0.2061818f,1.556548f,-0.5445854f,0.1083572f,-0.8483023f,0.4269398f,0.2938781f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321727f,1.538247f,0.4832336f,-0.6545107f,-0.2082472f,-0.2499107f,0.6824908f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 11.97698f);
Get(0x6E70).SetLocalPose(-0.1729844f,1.669598f,-0.4624251f,0.4917041f,-0.4308339f,-0.5071736f,0.5615908f);
Get(0x6E82).SetLocalPose(-0.2337391f,0.8089374f,-0.40557f,-0.003539636f,0.02179301f,-0.03161971f,0.9992561f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 11.97698f);
Get(0x6EC6).SetLocalPose(0.2089481f,1.560869f,-0.5430351f,0.1038026f,-0.8579915f,0.4108083f,0.2903656f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321826f,1.538155f,0.48317f,-0.6545153f,-0.2082602f,-0.249916f,0.6824804f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 11.99593f);
Get(0x6E70).SetLocalPose(-0.1731286f,1.669442f,-0.4624287f,0.4907713f,-0.4311966f,-0.5078704f,0.5614987f);
Get(0x6E82).SetLocalPose(-0.2328265f,0.8095966f,-0.4062636f,-0.005291503f,0.0227831f,-0.03258966f,0.9991951f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 11.99593f);
Get(0x6EC6).SetLocalPose(0.2178269f,1.569242f,-0.5409251f,0.08187599f,-0.876941f,0.3808033f,0.2815309f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321529f,1.538153f,0.4832596f,-0.6545322f,-0.2082576f,-0.2499005f,0.6824707f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 12.01481f);
Get(0x6E70).SetLocalPose(-0.1733302f,1.669674f,-0.4623361f,0.4895729f,-0.4314868f,-0.508755f,0.561521f);
Get(0x6E82).SetLocalPose(-0.2323258f,0.809979f,-0.4065716f,-0.006649478f,0.02443648f,-0.0330614f,0.9991324f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 12.01481f);
Get(0x6EC6).SetLocalPose(0.2252485f,1.577863f,-0.5388848f,0.05371356f,-0.8914425f,0.3538292f,0.277939f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321445f,1.538189f,0.483204f,-0.6545324f,-0.2082336f,-0.2499215f,0.68247f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 12.03389f);
Get(0x6E70).SetLocalPose(-0.1733231f,1.67004f,-0.4623909f,0.4883313f,-0.4314003f,-0.5096124f,0.5618911f);
Get(0x6E82).SetLocalPose(-0.2317562f,0.8099908f,-0.4062524f,-0.007839682f,0.02658642f,-0.03330937f,0.9990607f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 12.03389f);
Get(0x6EC6).SetLocalPose(0.232215f,1.576005f,-0.5353373f,0.01606181f,-0.9037145f,0.3236974f,0.2797538f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321389f,1.538143f,0.4833066f,-0.6545347f,-0.2082356f,-0.2499118f,0.6824708f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 12.05399f);
Get(0x6E70).SetLocalPose(-0.1735784f,1.670098f,-0.4625411f,0.4873087f,-0.431033f,-0.5100764f,0.5626393f);
Get(0x6E82).SetLocalPose(-0.2319061f,0.8101619f,-0.4066079f,-0.008315715f,0.02806885f,-0.03346179f,0.9990112f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 12.05399f);
Get(0x6EC6).SetLocalPose(0.2484807f,1.584989f,-0.5295578f,-0.04861281f,-0.9169553f,0.274937f,0.2850254f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321513f,1.538072f,0.4833584f,-0.6545386f,-0.2082497f,-0.2499154f,0.6824614f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 12.07286f);
Get(0x6E70).SetLocalPose(-0.1730879f,1.669848f,-0.46256f,0.4865114f,-0.4306899f,-0.5100733f,0.563594f);
Get(0x6E82).SetLocalPose(-0.2324794f,0.8102826f,-0.4074428f,-0.008488234f,0.02935721f,-0.03365257f,0.9989663f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 12.07286f);
Get(0x6EC6).SetLocalPose(0.2583404f,1.594166f,-0.5208986f,-0.1127669f,-0.9273686f,0.2239744f,0.2776809f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321571f,1.538063f,0.4834048f,-0.6545274f,-0.2082587f,-0.2499099f,0.6824715f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 12.09253f);
Get(0x6E70).SetLocalPose(-0.1732846f,1.669889f,-0.4624187f,0.4859006f,-0.4306374f,-0.5099563f,0.5642664f);
Get(0x6E82).SetLocalPose(-0.2334257f,0.8108865f,-0.408199f,-0.008621431f,0.03034664f,-0.03382799f,0.9989297f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 12.09253f);
Get(0x6EC6).SetLocalPose(0.273829f,1.603342f,-0.5184044f,-0.1908263f,-0.9379848f,0.1547596f,0.2445799f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321536f,1.538179f,0.4835444f,-0.6545398f,-0.2082326f,-0.2499048f,0.6824694f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 12.11161f);
Get(0x6E70).SetLocalPose(-0.1734294f,1.671084f,-0.462526f,0.485137f,-0.4307892f,-0.5098683f,0.5648868f);
Get(0x6E82).SetLocalPose(-0.2339228f,0.8113682f,-0.4086322f,-0.008380931f,0.03137355f,-0.03388801f,0.998898f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 12.11161f);
Get(0x6EC6).SetLocalPose(0.2972746f,1.612216f,-0.5178794f,-0.2930544f,-0.9399471f,0.05753077f,0.1652538f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321459f,1.538158f,0.4835212f,-0.6545329f,-0.2082242f,-0.2499092f,0.6824769f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 12.13109f);
Get(0x6E70).SetLocalPose(-0.1736045f,1.671022f,-0.4623345f,0.4842719f,-0.4313143f,-0.5099097f,0.565191f);
Get(0x6E82).SetLocalPose(-0.2347972f,0.8114472f,-0.4090949f,-0.007965088f,0.03268065f,-0.03384764f,0.9988608f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 12.13109f);
Get(0x6EC6).SetLocalPose(0.3160767f,1.617628f,-0.5190007f,-0.3784666f,-0.9208547f,-0.03548025f,0.08678006f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321476f,1.538213f,0.4832132f,-0.6545212f,-0.2082192f,-0.2499384f,0.6824791f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 12.15981f);
Get(0x6E70).SetLocalPose(-0.1731853f,1.671734f,-0.4629854f,0.4832996f,-0.4323428f,-0.5095665f,0.5655468f);
Get(0x6E82).SetLocalPose(-0.2355704f,0.8108048f,-0.4096998f,-0.007949055f,0.03404692f,-0.0342616f,0.9988012f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 12.15981f);
Get(0x6EC6).SetLocalPose(0.3297815f,1.62865f,-0.5186593f,-0.4300432f,-0.8893566f,-0.1482285f,0.04621982f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321533f,1.538192f,0.4830145f,-0.6545261f,-0.2082485f,-0.249898f,0.6824803f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 12.17913f);
Get(0x6E70).SetLocalPose(-0.1727119f,1.671651f,-0.4630767f,0.4825746f,-0.4334069f,-0.5093029f,0.5655889f);
Get(0x6E82).SetLocalPose(-0.2358188f,0.8117465f,-0.4090364f,-0.008650179f,0.03459061f,-0.03499945f,0.9987512f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 12.17913f);
Get(0x6EC6).SetLocalPose(0.3230328f,1.630775f,-0.5197388f,-0.3930902f,-0.9022825f,-0.1684748f,0.05461344f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321612f,1.538126f,0.4830281f,-0.6545097f,-0.2082221f,-0.2499081f,0.6825003f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 12.19821f);
Get(0x6E70).SetLocalPose(-0.172212f,1.671907f,-0.4634504f,0.4819334f,-0.4341582f,-0.509463f,0.5654153f);
Get(0x6E82).SetLocalPose(-0.2367605f,0.8121806f,-0.4082331f,-0.009974607f,0.0353772f,-0.03595271f,0.9986773f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 12.19821f);
Get(0x6EC6).SetLocalPose(0.306421f,1.628947f,-0.5252752f,-0.3557839f,-0.9198912f,-0.1364055f,0.09279944f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321636f,1.538179f,0.4830881f,-0.6545137f,-0.2082454f,-0.2499024f,0.6824914f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 12.21735f);
Get(0x6E70).SetLocalPose(-0.1711538f,1.672373f,-0.4637991f,0.4810786f,-0.4349929f,-0.5097659f,0.5652286f);
Get(0x6E82).SetLocalPose(-0.2371069f,0.8126917f,-0.4087452f,-0.01132168f,0.03600452f,-0.03675128f,0.9986115f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 12.21735f);
Get(0x6EC6).SetLocalPose(0.287827f,1.623821f,-0.5295928f,-0.3175434f,-0.9351696f,-0.07870603f,0.1357547f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32167f,1.538224f,0.4830563f,-0.6545099f,-0.2082499f,-0.2499152f,0.682489f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 12.23721f);
Get(0x6E70).SetLocalPose(-0.170146f,1.673073f,-0.4635229f,0.4803445f,-0.435663f,-0.5097916f,0.5653136f);
Get(0x6E82).SetLocalPose(-0.2374628f,0.8127015f,-0.4091717f,-0.01280936f,0.03676529f,-0.03753882f,0.9985365f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 12.23721f);
Get(0x6EC6).SetLocalPose(0.2653385f,1.615161f,-0.5351263f,-0.2596821f,-0.9517314f,-0.003616699f,0.1635832f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321669f,1.538165f,0.4830098f,-0.654507f,-0.2082434f,-0.2499219f,0.6824912f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 12.25681f);
Get(0x6E70).SetLocalPose(-0.1690836f,1.673637f,-0.4632384f,0.4794137f,-0.4364665f,-0.5098858f,0.565399f);
Get(0x6E82).SetLocalPose(-0.2373681f,0.8138121f,-0.4087975f,-0.01442272f,0.03741706f,-0.03812545f,0.9984681f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 12.25681f);
Get(0x6EC6).SetLocalPose(0.24764f,1.605562f,-0.5405525f,-0.2030373f,-0.9628096f,0.05217382f,0.1704452f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321688f,1.538178f,0.4830503f,-0.6545018f,-0.2082591f,-0.2499084f,0.6824964f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 12.27645f);
Get(0x6E70).SetLocalPose(-0.1674612f,1.674193f,-0.4632286f,0.4781516f,-0.4371637f,-0.5105121f,0.565364f);
Get(0x6E82).SetLocalPose(-0.2367688f,0.8156077f,-0.4091867f,-0.01615296f,0.03793339f,-0.03866471f,0.9984013f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 12.27645f);
Get(0x6EC6).SetLocalPose(0.2286562f,1.596778f,-0.5462039f,-0.1388699f,-0.966857f,0.1179323f,0.1788707f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321685f,1.538103f,0.4831601f,-0.6545055f,-0.2082805f,-0.249907f,0.6824868f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 12.29728f);
Get(0x6E70).SetLocalPose(-0.166515f,1.674507f,-0.4631047f,0.4772204f,-0.4373046f,-0.5115312f,0.5651205f);
Get(0x6E82).SetLocalPose(-0.2365823f,0.8170762f,-0.4084201f,-0.01823828f,0.03848185f,-0.03968151f,0.9983045f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 12.29728f);
Get(0x6EC6).SetLocalPose(0.2126321f,1.584983f,-0.5500432f,-0.07280074f,-0.9595065f,0.1948542f,0.1899453f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321755f,1.538005f,0.4830332f,-0.6544992f,-0.208278f,-0.2499092f,0.6824928f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 12.31701f);
Get(0x6E70).SetLocalPose(-0.1655381f,1.674852f,-0.4627504f,0.4762789f,-0.4371179f,-0.5131409f,0.5645997f);
Get(0x6E82).SetLocalPose(-0.2359848f,0.8178906f,-0.4077944f,-0.0201051f,0.03898777f,-0.04094453f,0.9981981f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 12.31701f);
Get(0x6EC6).SetLocalPose(0.2009297f,1.570774f,-0.5532217f,0.0006230428f,-0.9360848f,0.2901035f,0.1989597f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321895f,1.537991f,0.4830174f,-0.6545029f,-0.2082905f,-0.249904f,0.6824874f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 12.33683f);
Get(0x6E70).SetLocalPose(-0.1649157f,1.675587f,-0.4627943f,0.4753131f,-0.4366888f,-0.5150728f,0.5639861f);
Get(0x6E82).SetLocalPose(-0.2355793f,0.8186041f,-0.4074177f,-0.0219303f,0.03976013f,-0.0426015f,0.9980598f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 12.33683f);
Get(0x6EC6).SetLocalPose(0.1962963f,1.559634f,-0.5529105f,0.05831647f,-0.9037687f,0.3711243f,0.2051051f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32184f,1.538008f,0.4831583f,-0.654513f,-0.208261f,-0.2499063f,0.6824859f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 12.35726f);
Get(0x6E70).SetLocalPose(-0.1639419f,1.67541f,-0.4630488f,0.4744796f,-0.4359605f,-0.5170891f,0.5634061f);
Get(0x6E82).SetLocalPose(-0.2353209f,0.8182117f,-0.406741f,-0.02441334f,0.04108631f,-0.04472034f,0.9978557f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 12.35726f);
Get(0x6EC6).SetLocalPose(0.1956135f,1.551591f,-0.5494696f,0.09058379f,-0.8667515f,0.4384139f,0.2198401f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321689f,1.538155f,0.4832136f,-0.6545276f,-0.2082456f,-0.2499101f,0.6824752f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 12.37729f);
Get(0x6E70).SetLocalPose(-0.1635454f,1.675334f,-0.4631947f,0.4738795f,-0.4348835f,-0.5189478f,0.5630344f);
Get(0x6E82).SetLocalPose(-0.235178f,0.818309f,-0.4067933f,-0.02702955f,0.04220133f,-0.04668669f,0.9976516f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 12.37729f);
Get(0x6EC6).SetLocalPose(0.1983366f,1.551985f,-0.5431871f,0.09330376f,-0.8469114f,0.464637f,0.2411391f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321833f,1.538225f,0.4832609f,-0.6545314f,-0.208261f,-0.2499093f,0.6824672f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 12.38682f);
Get(0x6E70).SetLocalPose(-0.1635708f,1.674528f,-0.4634637f,0.473692f,-0.4342892f,-0.5196609f,0.5629932f);
Get(0x6E82).SetLocalPose(-0.2346297f,0.8185009f,-0.4070644f,-0.02952101f,0.04321747f,-0.04787413f,0.9974813f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 12.38682f);
Get(0x6EC6).SetLocalPose(0.1987203f,1.559983f,-0.5440018f,0.08742136f,-0.8538064f,0.4484788f,0.2494774f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321709f,1.538234f,0.4833857f,-0.6545542f,-0.2082889f,-0.2498907f,0.6824436f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 12.41847f);
Get(0x6E70).SetLocalPose(-0.1629174f,1.673383f,-0.4639923f,0.4731416f,-0.4333936f,-0.5204278f,0.5634376f);
Get(0x6E82).SetLocalPose(-0.2337136f,0.8183209f,-0.4061888f,-0.03268889f,0.04492988f,-0.04805801f,0.9972979f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 12.41847f);
Get(0x6EC6).SetLocalPose(0.2086091f,1.575287f,-0.5418859f,0.05457f,-0.8889417f,0.382779f,0.2455303f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321612f,1.538136f,0.4834702f,-0.654547f,-0.2082807f,-0.2499069f,0.6824471f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 12.43827f);
Get(0x6E70).SetLocalPose(-0.1627685f,1.673405f,-0.4644282f,0.4724981f,-0.4333196f,-0.5206274f,0.56385f);
Get(0x6E82).SetLocalPose(-0.233272f,0.818387f,-0.4059233f,-0.03398735f,0.04595038f,-0.04706002f,0.9972556f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 12.43827f);
Get(0x6EC6).SetLocalPose(0.2179398f,1.579639f,-0.5447569f,0.01854315f,-0.9131204f,0.3322791f,0.2354951f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321711f,1.538123f,0.4833353f,-0.6545289f,-0.2082696f,-0.2498971f,0.6824714f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 12.45771f);
Get(0x6E70).SetLocalPose(-0.1628463f,1.673234f,-0.464834f,0.4718776f,-0.4334286f,-0.5206909f,0.564227f);
Get(0x6E82).SetLocalPose(-0.2328216f,0.8184189f,-0.4057868f,-0.03429462f,0.04689533f,-0.04530463f,0.9972824f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 12.45771f);
Get(0x6EC6).SetLocalPose(0.2326218f,1.583025f,-0.5369823f,-0.03006901f,-0.929675f,0.2811066f,0.2361763f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321769f,1.538215f,0.4833965f,-0.6545461f,-0.2082856f,-0.2498861f,0.682454f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 12.47745f);
Get(0x6E70).SetLocalPose(-0.163718f,1.673436f,-0.46543f,0.4716609f,-0.4333899f,-0.5206235f,0.5645001f);
Get(0x6E82).SetLocalPose(-0.2321345f,0.8183871f,-0.4060721f,-0.03438598f,0.04844369f,-0.04299598f,0.9973075f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 12.47745f);
Get(0x6EC6).SetLocalPose(0.2398729f,1.589088f,-0.5237589f,-0.08319252f,-0.9364798f,0.2300825f,0.2512902f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321755f,1.53811f,0.48331f,-0.6545281f,-0.20825f,-0.2499224f,0.6824689f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 12.49634f);
Get(0x6E70).SetLocalPose(-0.1644959f,1.673244f,-0.4661418f,0.471809f,-0.4333764f,-0.5204357f,0.56456f);
Get(0x6E82).SetLocalPose(-0.2313221f,0.8186711f,-0.4061455f,-0.03478814f,0.05061999f,-0.0410531f,0.9972673f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 12.49634f);
Get(0x6EC6).SetLocalPose(0.2590818f,1.594345f,-0.5140128f,-0.1379838f,-0.9380639f,0.1703961f,0.2682573f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321742f,1.538086f,0.4833039f,-0.654532f,-0.2082505f,-0.2499311f,0.6824619f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 12.51618f);
Get(0x6E70).SetLocalPose(-0.1655309f,1.674055f,-0.4667481f,0.4720499f,-0.4334156f,-0.5201578f,0.5645846f);
Get(0x6E82).SetLocalPose(-0.2309522f,0.8187528f,-0.4063394f,-0.0354022f,0.0534873f,-0.03992557f,0.9971418f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 12.51618f);
Get(0x6EC6).SetLocalPose(0.2832049f,1.603342f,-0.5046345f,-0.2188634f,-0.9340862f,0.07779468f,0.271164f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321651f,1.538116f,0.4833092f,-0.6545398f,-0.2082261f,-0.2499434f,0.6824572f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 12.5356f);
Get(0x6E70).SetLocalPose(-0.166026f,1.674058f,-0.4674362f,0.4722585f,-0.4336735f,-0.5196369f,0.5646917f);
Get(0x6E82).SetLocalPose(-0.2312153f,0.8190392f,-0.4065095f,-0.03588663f,0.0553724f,-0.04018007f,0.9970113f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 12.5356f);
Get(0x6EC6).SetLocalPose(0.3033776f,1.610549f,-0.4970802f,-0.29397f,-0.9238324f,-0.02223595f,0.2441739f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321584f,1.538038f,0.4832178f,-0.654538f,-0.2082479f,-0.2499177f,0.6824617f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 12.55442f);
Get(0x6E70).SetLocalPose(-0.1660888f,1.674224f,-0.467959f,0.4722231f,-0.4341945f,-0.5189457f,0.5649566f);
Get(0x6E82).SetLocalPose(-0.2315902f,0.8188257f,-0.40674f,-0.0360566f,0.05637281f,-0.04072036f,0.9969272f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 12.55442f);
Get(0x6EC6).SetLocalPose(0.3230248f,1.614262f,-0.4923171f,-0.3552339f,-0.9049249f,-0.1306503f,0.1945515f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321458f,1.53814f,0.4832541f,-0.6545532f,-0.208237f,-0.249925f,0.6824479f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 12.57365f);
Get(0x6E70).SetLocalPose(-0.1661239f,1.674593f,-0.4690669f,0.4722522f,-0.4349863f,-0.5176217f,0.5655375f);
Get(0x6E82).SetLocalPose(-0.2322377f,0.8194503f,-0.4069265f,-0.03614238f,0.05676508f,-0.04101449f,0.9968898f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 12.57365f);
Get(0x6EC6).SetLocalPose(0.3358614f,1.617653f,-0.4876163f,-0.3746619f,-0.8898754f,-0.2007444f,0.165686f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.3215f,1.538127f,0.483254f,-0.654546f,-0.2082339f,-0.2499222f,0.6824567f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 12.59261f);
Get(0x6E70).SetLocalPose(-0.1661491f,1.674887f,-0.4699192f,0.4723018f,-0.4356935f,-0.5162196f,0.5662328f);
Get(0x6E82).SetLocalPose(-0.2329618f,0.8195306f,-0.4073952f,-0.03651367f,0.05665886f,-0.04126429f,0.9968721f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 12.59261f);
Get(0x6EC6).SetLocalPose(0.3393978f,1.616567f,-0.4866164f,-0.3715646f,-0.8880302f,-0.2130066f,0.167243f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321487f,1.538133f,0.4832174f,-0.6545426f,-0.2082462f,-0.2499021f,0.6824636f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 12.61163f);
Get(0x6E70).SetLocalPose(-0.1662252f,1.674727f,-0.4704922f,0.4724819f,-0.4364485f,-0.5146663f,0.5669146f);
Get(0x6E82).SetLocalPose(-0.2338513f,0.8192649f,-0.4075235f,-0.03705737f,0.05635861f,-0.04183957f,0.996845f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 12.61163f);
Get(0x6EC6).SetLocalPose(0.3348139f,1.613701f,-0.4871736f,-0.3484159f,-0.8950575f,-0.1903112f,0.2031261f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321435f,1.53818f,0.4834148f,-0.6545608f,-0.2082389f,-0.24992f,0.6824417f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 12.63139f);
Get(0x6E70).SetLocalPose(-0.1665539f,1.674429f,-0.4706821f,0.4727576f,-0.4368615f,-0.5136216f,0.567314f);
Get(0x6E82).SetLocalPose(-0.2347947f,0.8191596f,-0.4081212f,-0.03757023f,0.05571559f,-0.04299849f,0.9968126f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 12.63139f);
Get(0x6EC6).SetLocalPose(0.3274771f,1.609311f,-0.4872189f,-0.3245251f,-0.8982599f,-0.1504153f,0.2553192f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321538f,1.538173f,0.4834242f,-0.6545714f,-0.208254f,-0.2498835f,0.6824404f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 12.65075f);
Get(0x6E70).SetLocalPose(-0.1664726f,1.673879f,-0.4710818f,0.4732474f,-0.4370947f,-0.5126023f,0.5676479f);
Get(0x6E82).SetLocalPose(-0.2351324f,0.8202628f,-0.4087369f,-0.03759379f,0.05488093f,-0.04414161f,0.9968081f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 12.65075f);
Get(0x6EC6).SetLocalPose(0.3217399f,1.606982f,-0.4872519f,-0.3036365f,-0.9005079f,-0.1238813f,0.2855588f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32185f,1.538452f,0.4831752f,-0.6545147f,-0.2082957f,-0.2498817f,0.6824827f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 12.67925f);
Get(0x6E70).SetLocalPose(-0.1658325f,1.673747f,-0.4716799f,0.4750955f,-0.4377144f,-0.5099046f,0.568056f);
Get(0x6E82).SetLocalPose(-0.2358472f,0.819315f,-0.4093302f,-0.03747327f,0.05425832f,-0.04543358f,0.9967887f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 12.67925f);
Get(0x6EC6).SetLocalPose(0.3159873f,1.602747f,-0.4872207f,-0.2804957f,-0.9032063f,-0.1023879f,0.3083138f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321908f,1.5382f,0.4831981f,-0.654519f,-0.2083023f,-0.2498701f,0.6824808f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 12.69852f);
Get(0x6E70).SetLocalPose(-0.1655431f,1.67367f,-0.4719559f,0.4760202f,-0.4381796f,-0.5091456f,0.5676041f);
Get(0x6E82).SetLocalPose(-0.2359504f,0.8199697f,-0.4097799f,-0.03716337f,0.05429441f,-0.04610834f,0.9967673f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 12.69852f);
Get(0x6EC6).SetLocalPose(0.3136068f,1.601665f,-0.4887055f,-0.277692f,-0.9075611f,-0.0995795f,0.2988376f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321923f,1.53814f,0.4830901f,-0.654516f,-0.2082853f,-0.2498761f,0.6824867f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 12.7185f);
Get(0x6E70).SetLocalPose(-0.1653863f,1.673826f,-0.4725672f,0.4766552f,-0.4385294f,-0.5091015f,0.5668399f);
Get(0x6E82).SetLocalPose(-0.2362069f,0.8208781f,-0.4088929f,-0.03668414f,0.05453903f,-0.04661432f,0.9967481f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 12.7185f);
Get(0x6EC6).SetLocalPose(0.3124543f,1.600773f,-0.4911415f,-0.2785337f,-0.9133128f,-0.1040243f,0.2783122f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321974f,1.538275f,0.4830818f,-0.6545184f,-0.2082776f,-0.2498782f,0.6824859f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 12.73788f);
Get(0x6E70).SetLocalPose(-0.1648027f,1.674093f,-0.4731532f,0.4770983f,-0.4388584f,-0.5095999f,0.5657637f);
Get(0x6E82).SetLocalPose(-0.2363712f,0.8212494f,-0.4087303f,-0.03659278f,0.05484037f,-0.04689445f,0.9967219f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 12.73788f);
Get(0x6EC6).SetLocalPose(0.3123418f,1.600261f,-0.4925062f,-0.2800483f,-0.9175701f,-0.1107893f,0.2595455f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321945f,1.538263f,0.4831504f,-0.6545122f,-0.2082752f,-0.2498708f,0.6824953f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 12.75723f);
Get(0x6E70).SetLocalPose(-0.1648547f,1.674859f,-0.4734831f,0.4771838f,-0.4391134f,-0.510298f,0.5648637f);
Get(0x6E82).SetLocalPose(-0.2363562f,0.821377f,-0.4089198f,-0.03704007f,0.05558876f,-0.0470945f,0.9966544f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 12.75723f);
Get(0x6EC6).SetLocalPose(0.3129063f,1.599446f,-0.4924913f,-0.280243f,-0.9193096f,-0.1154729f,0.2509977f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32184f,1.538336f,0.4833289f,-0.6545233f,-0.2082915f,-0.2498745f,0.6824784f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 12.77644f);
Get(0x6E70).SetLocalPose(-0.1640196f,1.674359f,-0.473956f,0.4768074f,-0.4394235f,-0.5111594f,0.564161f);
Get(0x6E82).SetLocalPose(-0.2364153f,0.8206455f,-0.4089393f,-0.03830574f,0.05696955f,-0.04743948f,0.9965122f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 12.77644f);
Get(0x6EC6).SetLocalPose(0.3131014f,1.598233f,-0.4913066f,-0.2795662f,-0.9188108f,-0.1173173f,0.2527174f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321792f,1.53813f,0.4833049f,-0.65452f,-0.2082892f,-0.2498852f,0.6824783f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 12.79683f);
Get(0x6E70).SetLocalPose(-0.163565f,1.674289f,-0.4742679f,0.4761106f,-0.4396019f,-0.5118217f,0.5640101f);
Get(0x6E82).SetLocalPose(-0.2360052f,0.820305f,-0.4082806f,-0.04089329f,0.0595782f,-0.04830099f,0.9962155f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 12.79683f);
Get(0x6EC6).SetLocalPose(0.3134329f,1.596003f,-0.4900738f,-0.2786934f,-0.9169414f,-0.1175573f,0.2602476f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321857f,1.538161f,0.483273f,-0.6545299f,-0.2082861f,-0.2498718f,0.6824747f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 12.81597f);
Get(0x6E70).SetLocalPose(-0.1635429f,1.674553f,-0.4744799f,0.4753436f,-0.4396801f,-0.5121764f,0.5642741f);
Get(0x6E82).SetLocalPose(-0.2353587f,0.8209594f,-0.4075092f,-0.04384952f,0.0623075f,-0.04944259f,0.9958667f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 12.81597f);
Get(0x6EC6).SetLocalPose(0.3148408f,1.593235f,-0.4879479f,-0.2774234f,-0.9149089f,-0.1190089f,0.2679831f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321859f,1.538209f,0.4833273f,-0.6545087f,-0.2082962f,-0.2498844f,0.6824873f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 12.8353f);
Get(0x6E70).SetLocalPose(-0.1631971f,1.674648f,-0.4748435f,0.4746844f,-0.4396331f,-0.5122061f,0.5648383f);
Get(0x6E82).SetLocalPose(-0.2347209f,0.8206294f,-0.4068182f,-0.04799569f,0.06597003f,-0.05140801f,0.9953399f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 12.8353f);
Get(0x6EC6).SetLocalPose(0.3166327f,1.589572f,-0.4851502f,-0.2758979f,-0.913332f,-0.1241264f,0.2725762f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32194f,1.538216f,0.4832884f,-0.6545157f,-0.2082909f,-0.2498817f,0.6824831f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 12.85432f);
Get(0x6E70).SetLocalPose(-0.162814f,1.674723f,-0.475177f,0.4740641f,-0.4395301f,-0.5120621f,0.5655696f);
Get(0x6E82).SetLocalPose(-0.2347809f,0.820559f,-0.4060004f,-0.05311305f,0.07021947f,-0.05415085f,0.9946436f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 12.85432f);
Get(0x6EC6).SetLocalPose(0.3199357f,1.584566f,-0.4805192f,-0.2759135f,-0.9120573f,-0.1330815f,0.272603f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321758f,1.538045f,0.4833272f,-0.6545203f,-0.2082839f,-0.2498955f,0.6824759f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 12.87388f);
Get(0x6E70).SetLocalPose(-0.1626621f,1.675401f,-0.4755914f,0.4736698f,-0.4394548f,-0.5117285f,0.56626f);
Get(0x6E82).SetLocalPose(-0.2348077f,0.8195688f,-0.4051303f,-0.05857875f,0.07433139f,-0.05711602f,0.9938718f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 12.87388f);
Get(0x6EC6).SetLocalPose(0.3237925f,1.57778f,-0.4749869f,-0.2790509f,-0.909736f,-0.1450713f,0.2710447f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321711f,1.538015f,0.4832827f,-0.6545217f,-0.2082523f,-0.2499098f,0.6824788f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 12.89318f);
Get(0x6E70).SetLocalPose(-0.1624517f,1.675217f,-0.4761261f,0.4733475f,-0.4395199f,-0.5112512f,0.5669096f);
Get(0x6E82).SetLocalPose(-0.2344856f,0.8192487f,-0.4041586f,-0.06375625f,0.07789011f,-0.05982596f,0.9931209f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 12.89318f);
Get(0x6EC6).SetLocalPose(0.3279071f,1.570838f,-0.4691278f,-0.2832353f,-0.9056543f,-0.156969f,0.2737316f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321765f,1.538059f,0.483283f,-0.6545289f,-0.2082689f,-0.2498954f,0.6824723f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 12.91195f);
Get(0x6E70).SetLocalPose(-0.162067f,1.674868f,-0.4766964f,0.4730955f,-0.4396889f,-0.5107692f,0.5674232f);
Get(0x6E82).SetLocalPose(-0.2343333f,0.8205379f,-0.4024905f,-0.07087244f,0.08157392f,-0.06319483f,0.9921337f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 12.91195f);
Get(0x6EC6).SetLocalPose(0.3326382f,1.561935f,-0.4608769f,-0.2868153f,-0.8996362f,-0.1728213f,0.2802225f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321741f,1.5381f,0.4831777f,-0.6545322f,-0.2082579f,-0.2499008f,0.6824704f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 12.93114f);
Get(0x6E70).SetLocalPose(-0.1615904f,1.675018f,-0.4770235f,0.4730572f,-0.4399059f,-0.5102688f,0.5677372f);
Get(0x6E82).SetLocalPose(-0.2341568f,0.8213356f,-0.4011462f,-0.07643994f,0.08302335f,-0.06521767f,0.991469f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 12.93114f);
Get(0x6EC6).SetLocalPose(0.3379672f,1.550684f,-0.4516479f,-0.2883049f,-0.8928747f,-0.1937247f,0.2865759f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32182f,1.538107f,0.4830978f,-0.6545218f,-0.2082388f,-0.2498956f,0.6824881f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 12.95955f);
Get(0x6E70).SetLocalPose(-0.1610407f,1.675385f,-0.4777232f,0.4730417f,-0.4403463f,-0.5096891f,0.5679293f);
Get(0x6E82).SetLocalPose(-0.234252f,0.8218641f,-0.3978263f,-0.08405326f,0.08359186f,-0.06730644f,0.9906651f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 12.95955f);
Get(0x6EC6).SetLocalPose(0.346959f,1.530919f,-0.4364414f,-0.2906883f,-0.881726f,-0.2337943f,0.2887906f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321536f,1.537964f,0.4831079f,-0.654534f,-0.2082124f,-0.2499189f,0.682476f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 12.97884f);
Get(0x6E70).SetLocalPose(-0.1606836f,1.675563f,-0.4782781f,0.473024f,-0.4407362f,-0.5094709f,0.5678374f);
Get(0x6E82).SetLocalPose(-0.2345304f,0.8227599f,-0.3963224f,-0.08773176f,0.08403388f,-0.0680883f,0.9902553f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 12.97884f);
Get(0x6EC6).SetLocalPose(0.3531594f,1.51665f,-0.4261825f,-0.2935242f,-0.8717496f,-0.2641932f,0.2899968f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321427f,1.538073f,0.4832524f,-0.6545211f,-0.2082029f,-0.2499378f,0.6824843f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 12.99848f);
Get(0x6E70).SetLocalPose(-0.1605219f,1.675362f,-0.4783759f,0.4729773f,-0.4412701f,-0.5091922f,0.5677117f);
Get(0x6E82).SetLocalPose(-0.2345538f,0.823866f,-0.3950258f,-0.09036728f,0.08509547f,-0.06849902f,0.9898992f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 12.99848f);
Get(0x6EC6).SetLocalPose(0.3603897f,1.497236f,-0.4127325f,-0.2964914f,-0.8564702f,-0.2999091f,0.2976682f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32129f,1.538149f,0.4832971f,-0.6545194f,-0.2082363f,-0.2499367f,0.6824761f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 13.01845f);
Get(0x6E70).SetLocalPose(-0.1606361f,1.675312f,-0.478657f,0.472881f,-0.4418095f,-0.5089923f,0.5675517f);
Get(0x6E82).SetLocalPose(-0.2351303f,0.8255227f,-0.3940752f,-0.09280813f,0.087428f,-0.06881516f,0.9894481f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 13.01845f);
Get(0x6EC6).SetLocalPose(0.3678771f,1.473893f,-0.3974567f,-0.2988892f,-0.8354172f,-0.3442984f,0.3069235f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321358f,1.538105f,0.4832527f,-0.6545432f,-0.2082179f,-0.2499207f,0.6824649f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 13.03786f);
Get(0x6E70).SetLocalPose(-0.1603107f,1.675758f,-0.4789211f,0.4729051f,-0.4421874f,-0.5088092f,0.5674013f);
Get(0x6E82).SetLocalPose(-0.2356355f,0.8270457f,-0.3927792f,-0.09530551f,0.09069376f,-0.06906172f,0.9888994f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 13.03786f);
Get(0x6EC6).SetLocalPose(0.3738907f,1.453101f,-0.3847909f,-0.2988825f,-0.8159609f,-0.3849294f,0.3109766f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321368f,1.538041f,0.4832274f,-0.6545315f,-0.2081921f,-0.2499283f,0.6824811f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 13.05719f);
Get(0x6E70).SetLocalPose(-0.1600531f,1.675247f,-0.4792558f,0.472947f,-0.4425381f,-0.5087351f,0.5671594f);
Get(0x6E82).SetLocalPose(-0.2362554f,0.8288677f,-0.3923615f,-0.09780543f,0.09450024f,-0.06953598f,0.9882655f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 13.05719f);
Get(0x6EC6).SetLocalPose(0.3802703f,1.425493f,-0.3702074f,-0.2952057f,-0.7883937f,-0.4397704f,0.3128754f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321293f,1.538255f,0.4833422f,-0.6545398f,-0.2081859f,-0.2499229f,0.682477f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 13.07695f);
Get(0x6E70).SetLocalPose(-0.15951f,1.675854f,-0.4794087f,0.4729583f,-0.4427202f,-0.5087937f,0.5669554f);
Get(0x6E82).SetLocalPose(-0.2364379f,0.8293477f,-0.3923965f,-0.1003917f,0.09829548f,-0.07006676f,0.9875982f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 13.07695f);
Get(0x6EC6).SetLocalPose(0.3855346f,1.396499f,-0.3573272f,-0.2893598f,-0.7596696f,-0.4917098f,0.312081f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321334f,1.538213f,0.4832596f,-0.6545355f,-0.2082104f,-0.2499395f,0.6824676f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 13.09648f);
Get(0x6E70).SetLocalPose(-0.1587806f,1.675847f,-0.4798022f,0.472816f,-0.443014f,-0.5089273f,0.5667245f);
Get(0x6E82).SetLocalPose(-0.2367545f,0.8288692f,-0.3926818f,-0.1029065f,0.1014884f,-0.07094276f,0.9869537f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 13.09648f);
Get(0x6EC6).SetLocalPose(0.3895508f,1.365666f,-0.3459955f,-0.2821513f,-0.729582f,-0.5403413f,0.3100516f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321378f,1.538268f,0.4832505f,-0.6545117f,-0.2082013f,-0.2499469f,0.6824905f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 13.11621f);
Get(0x6E70).SetLocalPose(-0.1577265f,1.676178f,-0.4800605f,0.4724787f,-0.4433393f,-0.5091147f,0.566583f);
Get(0x6E82).SetLocalPose(-0.2366478f,0.8294339f,-0.3922041f,-0.1049718f,0.1036555f,-0.07196988f,0.9864365f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 13.11621f);
Get(0x6EC6).SetLocalPose(0.3921779f,1.327516f,-0.334898f,-0.2703845f,-0.6913361f,-0.5948244f,0.3084325f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321513f,1.538076f,0.4832009f,-0.6545427f,-0.2082098f,-0.2499334f,0.6824632f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 13.13668f);
Get(0x6E70).SetLocalPose(-0.1569712f,1.67628f,-0.4800833f,0.4722165f,-0.4435173f,-0.5093839f,0.5664203f);
Get(0x6E82).SetLocalPose(-0.2370684f,0.8304287f,-0.39049f,-0.1071127f,0.10547f,-0.07359476f,0.9858939f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 13.13668f);
Get(0x6EC6).SetLocalPose(0.3923323f,1.290419f,-0.3262458f,-0.2542109f,-0.6519804f,-0.6457447f,0.3054707f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321578f,1.538018f,0.483097f,-0.6545323f,-0.2082209f,-0.2499439f,0.6824659f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 13.15605f);
Get(0x6E70).SetLocalPose(-0.1559491f,1.676242f,-0.4801137f,0.4719346f,-0.4436315f,-0.5097721f,0.5662166f);
Get(0x6E82).SetLocalPose(-0.2377155f,0.8312855f,-0.3894383f,-0.108526f,0.1060916f,-0.07513192f,0.9855567f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 13.15605f);
Get(0x6EC6).SetLocalPose(0.3904472f,1.247529f,-0.3191194f,-0.2321946f,-0.6020165f,-0.7044525f,0.2956492f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321496f,1.538127f,0.4832096f,-0.6545468f,-0.2081771f,-0.249936f,0.6824682f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 13.17506f);
Get(0x6E70).SetLocalPose(-0.1555889f,1.676221f,-0.4801105f,0.4716976f,-0.4437279f,-0.5100479f,0.5660903f);
Get(0x6E82).SetLocalPose(-0.2387456f,0.8316513f,-0.3883973f,-0.1097321f,0.1059587f,-0.07670527f,0.9853162f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 13.17506f);
Get(0x6EC6).SetLocalPose(0.3861329f,1.206494f,-0.3161868f,-0.2136366f,-0.5534862f,-0.7541117f,0.2816521f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32138f,1.537986f,0.4831932f,-0.6545424f,-0.2081823f,-0.2499512f,0.6824652f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 13.19392f);
Get(0x6E70).SetLocalPose(-0.1548006f,1.676846f,-0.4800746f,0.4714924f,-0.4438469f,-0.5101862f,0.5660432f);
Get(0x6E82).SetLocalPose(-0.2396926f,0.8316852f,-0.3879591f,-0.1107485f,0.1050668f,-0.07845869f,0.9851599f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 13.19392f);
Get(0x6EC6).SetLocalPose(0.3804178f,1.1704f,-0.3161403f,-0.1983247f,-0.5109333f,-0.7919981f,0.2689859f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321408f,1.538067f,0.4831657f,-0.6545475f,-0.208205f,-0.2499588f,0.6824507f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 13.21342f);
Get(0x6E70).SetLocalPose(-0.1538374f,1.676597f,-0.4801648f,0.4712798f,-0.4440792f,-0.5102339f,0.565995f);
Get(0x6E82).SetLocalPose(-0.2399912f,0.8318942f,-0.3887723f,-0.1115426f,0.103613f,-0.08027679f,0.9850778f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 13.21342f);
Get(0x6EC6).SetLocalPose(0.3699386f,1.12392f,-0.3187527f,-0.1722658f,-0.4533429f,-0.837888f,0.2504963f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321522f,1.538012f,0.4830659f,-0.6545432f,-0.2082045f,-0.2499457f,0.6824598f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 13.23376f);
Get(0x6E70).SetLocalPose(-0.1528589f,1.676769f,-0.4801183f,0.4709694f,-0.4444435f,-0.5105225f,0.5657072f);
Get(0x6E82).SetLocalPose(-0.2403297f,0.8321873f,-0.3896406f,-0.1120537f,0.1020828f,-0.08222541f,0.9850189f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 13.23376f);
Get(0x6EC6).SetLocalPose(0.3553213f,1.078435f,-0.3255677f,-0.1320261f,-0.3898003f,-0.8809636f,0.2335121f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321469f,1.537981f,0.4832358f,-0.6545578f,-0.2082067f,-0.2499254f,0.6824526f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 13.25394f);
Get(0x6E70).SetLocalPose(-0.152161f,1.67697f,-0.4797983f,0.4705946f,-0.4448806f,-0.5110698f,0.565181f);
Get(0x6E82).SetLocalPose(-0.2405462f,0.832179f,-0.3910394f,-0.1121615f,0.1010606f,-0.08350934f,0.9850039f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 13.25394f);
Get(0x6EC6).SetLocalPose(0.3398216f,1.036816f,-0.335725f,-0.09104455f,-0.3301688f,-0.9136751f,0.2188543f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321534f,1.538091f,0.4832058f,-0.6545409f,-0.2082296f,-0.2499092f,0.6824676f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 13.27452f);
Get(0x6E70).SetLocalPose(-0.1509799f,1.676747f,-0.4796741f,0.4702079f,-0.4454127f,-0.5114914f,0.5647023f);
Get(0x6E82).SetLocalPose(-0.2406943f,0.8319012f,-0.3918478f,-0.1117995f,0.1004449f,-0.08439745f,0.9850324f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 13.27452f);
Get(0x6EC6).SetLocalPose(0.3217357f,0.9947156f,-0.3512853f,-0.05454019f,-0.2650639f,-0.9419321f,0.1988228f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321427f,1.53801f,0.4833438f,-0.6545607f,-0.2082143f,-0.2499102f,0.682453f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 13.2942f);
Get(0x6E70).SetLocalPose(-0.1500456f,1.676575f,-0.4793128f,0.4696288f,-0.4462025f,-0.5117169f,0.5643563f);
Get(0x6E82).SetLocalPose(-0.2410936f,0.830973f,-0.3940272f,-0.110833f,0.09988075f,-0.0848856f,0.985157f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 13.2942f);
Get(0x6EC6).SetLocalPose(0.3056411f,0.959192f,-0.368165f,-0.0276862f,-0.2022596f,-0.9629546f,0.1761904f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321571f,1.53809f,0.4833238f,-0.6545697f,-0.2082304f,-0.2498737f,0.6824527f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 13.31535f);
Get(0x6E70).SetLocalPose(-0.149154f,1.676855f,-0.4787742f,0.4687658f,-0.4472325f,-0.5118268f,0.5641588f);
Get(0x6E82).SetLocalPose(-0.2413043f,0.8303731f,-0.3954258f,-0.109634f,0.09911223f,-0.0850201f,0.9853572f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 13.31535f);
Get(0x6EC6).SetLocalPose(0.2893795f,0.9290525f,-0.3870895f,-0.009779177f,-0.1456475f,-0.9771165f,0.1547087f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321691f,1.537984f,0.4832636f,-0.6545412f,-0.2082302f,-0.2499145f,0.6824653f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 13.33616f);
Get(0x6E70).SetLocalPose(-0.1487336f,1.677868f,-0.4777164f,0.4674106f,-0.4485821f,-0.5121035f,0.5639606f);
Get(0x6E82).SetLocalPose(-0.2412159f,0.830323f,-0.3968652f,-0.1084658f,0.09798776f,-0.08494297f,0.9856056f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 13.33616f);
Get(0x6EC6).SetLocalPose(0.2722256f,0.9014959f,-0.4068781f,-0.001077686f,-0.09439874f,-0.9864922f,0.1338694f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321617f,1.537988f,0.4831997f,-0.6545517f,-0.2082351f,-0.2498941f,0.6824612f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 13.35671f);
Get(0x6E70).SetLocalPose(-0.1477377f,1.678796f,-0.4770074f,0.4658706f,-0.4498464f,-0.5127203f,0.5636672f);
Get(0x6E82).SetLocalPose(-0.2407477f,0.8297807f,-0.3984146f,-0.1075811f,0.09638062f,-0.08482063f,0.9858715f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 13.35671f);
Get(0x6EC6).SetLocalPose(0.2578756f,0.8807102f,-0.4247843f,0.00376613f,-0.05709867f,-0.991478f,0.1170343f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321635f,1.538092f,0.4831442f,-0.6545435f,-0.2082605f,-0.2499059f,0.6824569f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 13.37696f);
Get(0x6E70).SetLocalPose(-0.146384f,1.679066f,-0.4762342f,0.4644066f,-0.4509495f,-0.5135127f,0.5632725f);
Get(0x6E82).SetLocalPose(-0.2402707f,0.829502f,-0.3998193f,-0.1067857f,0.09418929f,-0.08444481f,0.9862019f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 13.37696f);
Get(0x6EC6).SetLocalPose(0.2426892f,0.8630776f,-0.4415152f,0.003509743f,-0.0275062f,-0.9945747f,0.1002611f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321692f,1.538101f,0.4831796f,-0.6545337f,-0.2082343f,-0.2499085f,0.6824734f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 13.39686f);
Get(0x6E70).SetLocalPose(-0.1453039f,1.679692f,-0.4756382f,0.4635321f,-0.4515726f,-0.5140735f,0.5629818f);
Get(0x6E82).SetLocalPose(-0.2399744f,0.830499f,-0.4022795f,-0.1057538f,0.09183401f,-0.08365685f,0.9866024f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 13.39686f);
Get(0x6EC6).SetLocalPose(0.2322449f,0.8520864f,-0.4534278f,-0.008301266f,-0.009965357f,-0.996175f,0.08641315f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321729f,1.538104f,0.4832075f,-0.6545364f,-0.2082435f,-0.2498987f,0.6824716f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 13.41695f);
Get(0x6E70).SetLocalPose(-0.1433243f,1.680014f,-0.4749669f,0.4622135f,-0.4524949f,-0.5148594f,0.5626072f);
Get(0x6E82).SetLocalPose(-0.2399779f,0.8307973f,-0.4039045f,-0.1045594f,0.08858806f,-0.0822628f,0.9871435f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 13.41695f);
Get(0x6EC6).SetLocalPose(0.223264f,0.8419573f,-0.4652594f,-0.03471003f,0.004260809f,-0.9967808f,0.07214732f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321728f,1.538113f,0.4830676f,-0.6545272f,-0.2082308f,-0.2498875f,0.6824884f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 13.43681f);
Get(0x6E70).SetLocalPose(-0.1419803f,1.680239f,-0.4744098f,0.4612881f,-0.4531401f,-0.5153165f,0.5624289f);
Get(0x6E82).SetLocalPose(-0.2403724f,0.8309383f,-0.4057991f,-0.1023347f,0.08369146f,-0.0799045f,0.9879973f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 13.43681f);
Get(0x6EC6).SetLocalPose(0.2157987f,0.8338938f,-0.4755335f,-0.06592239f,0.01485014f,-0.9960145f,0.05821423f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321759f,1.538132f,0.4830659f,-0.6545315f,-0.2082113f,-0.249882f,0.6824921f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 13.45653f);
Get(0x6E70).SetLocalPose(-0.1409165f,1.679942f,-0.4737093f,0.4604765f,-0.4537142f,-0.5157598f,0.5622249f);
Get(0x6E82).SetLocalPose(-0.2407499f,0.8304266f,-0.4080244f,-0.09742039f,0.07587864f,-0.0763588f,0.9894044f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 13.45653f);
Get(0x6EC6).SetLocalPose(0.2103047f,0.8302627f,-0.48221f,-0.09123813f,0.02473227f,-0.9945011f,0.04507288f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321637f,1.537939f,0.4831674f,-0.6545389f,-0.2082112f,-0.2499018f,0.6824779f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 13.47598f);
Get(0x6E70).SetLocalPose(-0.1397667f,1.680437f,-0.472962f,0.4595388f,-0.4543857f,-0.5164604f,0.5618064f);
Get(0x6E82).SetLocalPose(-0.241728f,0.8302913f,-0.4102267f,-0.08829653f,0.06451946f,-0.06934963f,0.9915804f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 13.47598f);
Get(0x6EC6).SetLocalPose(0.2061191f,0.8274665f,-0.487503f,-0.109481f,0.03358735f,-0.9928546f,0.03354848f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 13.49558f);
Get(0x6E70).SetLocalPose(-0.1392331f,1.681265f,-0.4724098f,0.4590176f,-0.4547054f,-0.5169638f,0.5615109f);
Get(0x6E82).SetLocalPose(-0.2415455f,0.8281903f,-0.4134603f,-0.07116766f,0.05164889f,-0.05548897f,0.9945796f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 13.49558f);
Get(0x6EC6).SetLocalPose(0.2014568f,0.8262966f,-0.4921893f,-0.1264035f,0.04321593f,-0.9908205f,0.02072458f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321617f,1.538012f,0.4831464f,-0.654548f,-0.2082032f,-0.2499218f,0.6824642f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 13.51554f);
Get(0x6E70).SetLocalPose(-0.1388577f,1.681479f,-0.4717669f,0.458526f,-0.4549169f,-0.5174425f,0.5613002f);
Get(0x6E82).SetLocalPose(-0.2410788f,0.8272722f,-0.4160963f,-0.05373044f,0.04391113f,-0.04074005f,0.9967573f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 13.51554f);
Get(0x6EC6).SetLocalPose(0.1913785f,0.8223141f,-0.5001327f,-0.1549042f,0.06031376f,-0.98606f,-0.007263834f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321463f,1.538078f,0.4833685f,-0.6545411f,-0.2082002f,-0.2499177f,0.6824733f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 13.5362f);
Get(0x6E70).SetLocalPose(-0.138262f,1.681563f,-0.4710076f,0.4581756f,-0.4549975f,-0.5178418f,0.5611526f);
Get(0x6E82).SetLocalPose(-0.2396348f,0.8246513f,-0.4202951f,-0.02807441f,0.0375936f,-0.01848726f,0.9987277f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 13.5362f);
Get(0x6EC6).SetLocalPose(0.1804605f,0.8201307f,-0.5070179f,-0.179922f,0.07066493f,-0.9804998f,-0.03542194f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321504f,1.538047f,0.4832584f,-0.6545236f,-0.2081959f,-0.249945f,0.6824814f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 13.5569f);
Get(0x6E70).SetLocalPose(-0.1371767f,1.681395f,-0.4704548f,0.4580283f,-0.454859f,-0.5181121f,0.5611357f);
Get(0x6E82).SetLocalPose(-0.2377374f,0.8221962f,-0.425515f,-0.008466217f,0.03470481f,-0.0007809684f,0.9993615f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 13.5569f);
Get(0x6EC6).SetLocalPose(0.1737155f,0.8201892f,-0.5087696f,-0.1937987f,0.07301466f,-0.9771556f,-0.04772724f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321497f,1.538024f,0.4832563f,-0.6545392f,-0.2082191f,-0.2499263f,0.6824663f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 13.57607f);
Get(0x6E70).SetLocalPose(-0.1364696f,1.681659f,-0.4701795f,0.4580858f,-0.4546663f,-0.518306f,0.5610659f);
Get(0x6E82).SetLocalPose(-0.2355959f,0.8212379f,-0.4281809f,0.004222924f,0.03164428f,0.01152451f,0.9994239f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 13.57607f);
Get(0x6EC6).SetLocalPose(0.1718483f,0.8182477f,-0.5102853f,-0.2070597f,0.07240267f,-0.9743639f,-0.04999296f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321392f,1.537999f,0.4832444f,-0.6545424f,-0.2081959f,-0.2499271f,0.6824699f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 13.59482f);
Get(0x6E70).SetLocalPose(-0.1357793f,1.681754f,-0.4699973f,0.4581788f,-0.4544883f,-0.5184371f,0.5610129f);
Get(0x6E82).SetLocalPose(-0.2344164f,0.8210023f,-0.4306661f,0.01383909f,0.02188095f,0.02087696f,0.9994468f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 13.59482f);
Get(0x6EC6).SetLocalPose(0.1716797f,0.8167279f,-0.5111743f,-0.2201129f,0.06615011f,-0.9721817f,-0.04513726f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321509f,1.537947f,0.4832039f,-0.6545441f,-0.2082041f,-0.2499422f,0.6824602f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 13.61313f);
Get(0x6E70).SetLocalPose(-0.1349286f,1.681645f,-0.4699242f,0.4583544f,-0.4542564f,-0.518496f,0.5610029f);
Get(0x6E82).SetLocalPose(-0.233774f,0.8201814f,-0.4313902f,0.02227101f,0.01133785f,0.02837289f,0.999285f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 13.61313f);
Get(0x6EC6).SetLocalPose(0.1731035f,0.8145508f,-0.5138482f,-0.2297664f,0.06206068f,-0.9703376f,-0.0424364f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321443f,1.538004f,0.4830755f,-0.6545328f,-0.2082036f,-0.2499337f,0.6824743f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 13.63247f);
Get(0x6E70).SetLocalPose(-0.133651f,1.681989f,-0.4695363f,0.4584497f,-0.4540833f,-0.5183889f,0.5611641f);
Get(0x6E82).SetLocalPose(-0.2330266f,0.8205718f,-0.4321691f,0.02972708f,0.005414517f,0.03551272f,0.9989123f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 13.63247f);
Get(0x6EC6).SetLocalPose(0.1748964f,0.8138568f,-0.5152571f,-0.2371809f,0.06427999f,-0.9683564f,-0.04358189f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321369f,1.538202f,0.4831358f,-0.6545272f,-0.2081856f,-0.2499682f,0.6824725f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 13.65237f);
Get(0x6E70).SetLocalPose(-0.1328531f,1.681759f,-0.4696282f,0.4582961f,-0.454118f,-0.5182127f,0.5614242f);
Get(0x6E82).SetLocalPose(-0.231642f,0.8209611f,-0.4327338f,0.03503165f,0.00337987f,0.04033212f,0.9985663f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 13.65237f);
Get(0x6EC6).SetLocalPose(0.1760976f,0.8128148f,-0.5160251f,-0.2399767f,0.06711063f,-0.9674523f,-0.04408433f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321303f,1.538245f,0.4831755f,-0.6545415f,-0.2081857f,-0.2499844f,0.682453f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 13.67116f);
Get(0x6E70).SetLocalPose(-0.1325505f,1.681696f,-0.4698291f,0.4579871f,-0.4542312f,-0.51819f,0.5616058f);
Get(0x6E82).SetLocalPose(-0.2306882f,0.821698f,-0.4322927f,0.03767781f,0.002587575f,0.04257104f,0.9983794f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 13.67116f);
Get(0x6EC6).SetLocalPose(0.1775873f,0.8116212f,-0.5160576f,-0.2393746f,0.06958761f,-0.9674741f,-0.04302631f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321142f,1.538076f,0.4832156f,-0.6545119f,-0.2081858f,-0.2499762f,0.6824843f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 13.69926f);
Get(0x6E70).SetLocalPose(-0.1321037f,1.68126f,-0.4701251f,0.4577493f,-0.4540975f,-0.5183885f,0.5617245f);
Get(0x6E82).SetLocalPose(-0.2286865f,0.8222402f,-0.4308678f,0.03726182f,0.003273683f,0.04154474f,0.9984363f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 13.69926f);
Get(0x6EC6).SetLocalPose(0.1800996f,0.8123856f,-0.5167849f,-0.2338462f,0.06924875f,-0.9689553f,-0.04057198f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321229f,1.538022f,0.4832041f,-0.6545249f,-0.2081947f,-0.2499416f,0.6824818f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 13.71814f);
Get(0x6E70).SetLocalPose(-0.1315346f,1.681645f,-0.4705613f,0.4578477f,-0.4538289f,-0.5185531f,0.5617095f);
Get(0x6E82).SetLocalPose(-0.2283885f,0.8224142f,-0.4283769f,0.02964753f,0.007094073f,0.0383691f,0.9987985f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 13.71814f);
Get(0x6EC6).SetLocalPose(0.1808958f,0.8115863f,-0.5157048f,-0.2286291f,0.06796782f,-0.9703627f,-0.03879932f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321191f,1.538104f,0.4833084f,-0.6545355f,-0.2082072f,-0.2499519f,0.6824639f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 13.73688f);
Get(0x6E70).SetLocalPose(-0.1310151f,1.681178f,-0.4710008f,0.4579023f,-0.4536279f,-0.5187595f,0.5616367f);
Get(0x6E82).SetLocalPose(-0.2285068f,0.8223622f,-0.4254994f,0.01717797f,0.01270297f,0.03379981f,0.9992002f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 13.73688f);
Get(0x6EC6).SetLocalPose(0.1810983f,0.8133178f,-0.512533f,-0.2229138f,0.06698609f,-0.9718184f,-0.03730234f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321356f,1.537961f,0.4832258f,-0.654506f,-0.2082042f,-0.2499862f,0.6824807f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 13.75681f);
Get(0x6E70).SetLocalPose(-0.1305299f,1.681641f,-0.4712788f,0.4577615f,-0.4536223f,-0.5187266f,0.5617864f);
Get(0x6E82).SetLocalPose(-0.2303667f,0.8216789f,-0.4195887f,-0.00187186f,0.01944318f,0.02544264f,0.9994854f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 13.75681f);
Get(0x6EC6).SetLocalPose(0.1812121f,0.8164286f,-0.5122157f,-0.2170894f,0.06633412f,-0.9732347f,-0.03586503f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321404f,1.53805f,0.4832328f,-0.6545172f,-0.2082164f,-0.2499575f,0.6824767f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 13.77622f);
Get(0x6E70).SetLocalPose(-0.129518f,1.681654f,-0.4719796f,0.4573129f,-0.4538566f,-0.518636f,0.5620461f);
Get(0x6E82).SetLocalPose(-0.2318424f,0.8218072f,-0.4135065f,-0.02196259f,0.02510562f,0.01542785f,0.9993244f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 13.77622f);
Get(0x6EC6).SetLocalPose(0.1798835f,0.8179048f,-0.511076f,-0.2118202f,0.0655386f,-0.9744899f,-0.03473522f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321529f,1.537953f,0.4830374f,-0.6545057f,-0.2082017f,-0.249968f,0.6824884f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 13.79563f);
Get(0x6E70).SetLocalPose(-0.1287743f,1.681252f,-0.4725319f,0.4567435f,-0.4541299f,-0.5186685f,0.5622584f);
Get(0x6E82).SetLocalPose(-0.2357495f,0.823548f,-0.4051034f,-0.04879621f,0.03125767f,-0.0006857342f,0.9983193f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 13.79563f);
Get(0x6EC6).SetLocalPose(0.1793742f,0.8186971f,-0.5082918f,-0.2083845f,0.06445373f,-0.9753376f,-0.03373625f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32155f,1.537861f,0.4831285f,-0.6545237f,-0.2082064f,-0.2499737f,0.6824675f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 13.81548f);
Get(0x6E70).SetLocalPose(-0.1279208f,1.680906f,-0.4735627f,0.4561611f,-0.4542036f,-0.5190496f,0.5623199f);
Get(0x6E82).SetLocalPose(-0.2386643f,0.8270546f,-0.3953957f,-0.07054906f,0.03504905f,-0.01729185f,0.9967424f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 13.81548f);
Get(0x6EC6).SetLocalPose(0.1784375f,0.8200465f,-0.5080357f,-0.2053157f,0.06319538f,-0.9761112f,-0.03253722f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32149f,1.537899f,0.4830741f,-0.6545165f,-0.208211f,-0.249969f,0.6824749f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 13.83477f);
Get(0x6E70).SetLocalPose(-0.1271704f,1.680962f,-0.474276f,0.4556054f,-0.4541556f,-0.5195689f,0.5623296f);
Get(0x6E82).SetLocalPose(-0.2463967f,0.8331072f,-0.3794596f,-0.09944335f,0.04241529f,-0.04060812f,0.9933091f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 13.83477f);
Get(0x6EC6).SetLocalPose(0.1775336f,0.8217092f,-0.5060664f,-0.2021288f,0.0610799f,-0.976966f,-0.03083381f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321472f,1.537958f,0.4830744f,-0.654534f,-0.208205f,-0.2499472f,0.6824678f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 13.85473f);
Get(0x6E70).SetLocalPose(-0.1265553f,1.681097f,-0.4750406f,0.454915f,-0.4541328f,-0.5199264f,0.5625765f);
Get(0x6E82).SetLocalPose(-0.253356f,0.839947f,-0.3647803f,-0.1269141f,0.04453719f,-0.05986468f,0.9891034f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 13.85473f);
Get(0x6EC6).SetLocalPose(0.1761844f,0.8213352f,-0.5057819f,-0.2000311f,0.05867628f,-0.9775955f,-0.02918246f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321442f,1.538058f,0.4830011f,-0.6545292f,-0.2081979f,-0.2499399f,0.6824773f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 13.87404f);
Get(0x6E70).SetLocalPose(-0.1260408f,1.681918f,-0.4754872f,0.453971f,-0.4544027f,-0.519895f,0.5631499f);
Get(0x6E82).SetLocalPose(-0.2631932f,0.8499699f,-0.3444033f,-0.1593894f,0.03626951f,-0.07902759f,0.983379f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 13.87404f);
Get(0x6EC6).SetLocalPose(0.1752671f,0.8215911f,-0.5046216f,-0.1985805f,0.05581377f,-0.9781046f,-0.0276039f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321442f,1.538095f,0.4829929f,-0.6545447f,-0.2082134f,-0.2499498f,0.6824542f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 13.89352f);
Get(0x6E70).SetLocalPose(-0.1250378f,1.682243f,-0.4760807f,0.452535f,-0.4551117f,-0.5196956f,0.5639166f);
Get(0x6E82).SetLocalPose(-0.2752232f,0.8635194f,-0.3190631f,-0.194464f,0.01781f,-0.0968474f,0.9759545f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 13.89352f);
Get(0x6EC6).SetLocalPose(0.17518f,0.8208637f,-0.5030088f,-0.1979467f,0.05349218f,-0.9783895f,-0.02664015f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321537f,1.537855f,0.4829867f,-0.6545228f,-0.2082145f,-0.2499573f,0.682472f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 13.91287f);
Get(0x6E70).SetLocalPose(-0.1241463f,1.683118f,-0.476841f,0.4510749f,-0.4560386f,-0.5196931f,0.5643398f);
Get(0x6E82).SetLocalPose(-0.2884028f,0.8783302f,-0.2965169f,-0.229055f,-0.00669477f,-0.112401f,0.966879f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 13.91287f);
Get(0x6EC6).SetLocalPose(0.1747299f,0.8204318f,-0.502795f,-0.1974643f,0.05163663f,-0.9786061f,-0.02591583f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321532f,1.537886f,0.4829274f,-0.654515f,-0.2081953f,-0.2499213f,0.6824986f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 13.93195f);
Get(0x6E70).SetLocalPose(-0.1234708f,1.684112f,-0.4771854f,0.4495703f,-0.4571386f,-0.5200968f,0.5642785f);
Get(0x6E82).SetLocalPose(-0.3035441f,0.9008737f,-0.2697155f,-0.2728884f,-0.0404974f,-0.1266513f,0.9528124f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 13.93195f);
Get(0x6EC6).SetLocalPose(0.1747198f,0.8203399f,-0.5029806f,-0.1965053f,0.04851421f,-0.9789922f,-0.02462288f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321514f,1.537879f,0.4830503f,-0.6545349f,-0.2082133f,-0.2499348f,0.682469f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 13.95206f);
Get(0x6E70).SetLocalPose(-0.1223562f,1.684605f,-0.4777486f,0.4482798f,-0.4582246f,-0.5208209f,0.5637563f);
Get(0x6E82).SetLocalPose(-0.3203839f,0.9311631f,-0.2407227f,-0.3242169f,-0.07991039f,-0.1374815f,0.9325217f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 13.95206f);
Get(0x6EC6).SetLocalPose(0.1752893f,0.8194112f,-0.5027414f,-0.1958452f,0.04540216f,-0.979307f,-0.02326304f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321573f,1.538097f,0.4831818f,-0.6545264f,-0.208237f,-0.2499301f,0.6824716f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 13.97962f);
Get(0x6E70).SetLocalPose(-0.1203226f,1.68477f,-0.4792396f,0.4467683f,-0.4596935f,-0.5224646f,0.5622373f);
Get(0x6E82).SetLocalPose(-0.3433222f,0.9789163f,-0.204432f,-0.3995047f,-0.1400427f,-0.1455411f,0.8942046f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 13.97962f);
Get(0x6EC6).SetLocalPose(0.1757639f,0.8188678f,-0.5026991f,-0.1964231f,0.04224054f,-0.9793566f,-0.02223284f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321537f,1.538137f,0.4832246f,-0.6545183f,-0.2082075f,-0.2499048f,0.6824977f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 13.9897f);
Get(0x6E70).SetLocalPose(-0.1192163f,1.68479f,-0.4798574f,0.4461055f,-0.4603874f,-0.5233804f,0.5613433f);
Get(0x6E82).SetLocalPose(-0.3523406f,1.000835f,-0.1926247f,-0.4293536f,-0.1636877f,-0.1462508f,0.8760551f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 13.9897f);
Get(0x6EC6).SetLocalPose(0.1758267f,0.8184146f,-0.5022553f,-0.196896f,0.04146738f,-0.9792992f,-0.02203505f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321645f,1.538069f,0.4830875f,-0.6545157f,-0.2082502f,-0.2499163f,0.6824829f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 14.01075f);
Get(0x6E70).SetLocalPose(-0.1181477f,1.68536f,-0.4806838f,0.4451741f,-0.461384f,-0.5248516f,0.559889f);
Get(0x6E82).SetLocalPose(-0.3681915f,1.043819f,-0.1727967f,-0.4829898f,-0.2025655f,-0.1456146f,0.8393357f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 14.01075f);
Get(0x6EC6).SetLocalPose(0.1760658f,0.8196737f,-0.503173f,-0.1972689f,0.04028047f,-0.979288f,-0.0213877f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321698f,1.538158f,0.4831087f,-0.6545081f,-0.2082042f,-0.2499254f,0.6825009f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 14.0307f);
Get(0x6E70).SetLocalPose(-0.1168571f,1.685542f,-0.4815681f,0.4441349f,-0.4624862f,-0.5266045f,0.5581564f);
Get(0x6E82).SetLocalPose(-0.3852496f,1.093193f,-0.1573119f,-0.5447275f,-0.2425727f,-0.1437249f,0.7897934f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 14.0307f);
Get(0x6EC6).SetLocalPose(0.1765895f,0.8195096f,-0.5036458f,-0.1967314f,0.0388784f,-0.9794707f,-0.02055001f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321624f,1.538074f,0.4831303f,-0.6545212f,-0.2082199f,-0.2499125f,0.6824883f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 14.05988f);
Get(0x6E70).SetLocalPose(-0.1156441f,1.686354f,-0.4824049f,0.443084f,-0.4636253f,-0.5285847f,0.5561711f);
Get(0x6E82).SetLocalPose(-0.4047647f,1.167079f,-0.1446786f,-0.6282403f,-0.282297f,-0.1387265f,0.7116021f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 14.05988f);
Get(0x6EC6).SetLocalPose(0.1771283f,0.8199038f,-0.5029327f,-0.1941409f,0.03568632f,-0.9801463f,-0.01868083f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321542f,1.53806f,0.48313f,-0.6545156f,-0.2082531f,-0.2499261f,0.6824785f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 14.06944f);
Get(0x6E70).SetLocalPose(-0.1149697f,1.686324f,-0.4827771f,0.4425783f,-0.4641974f,-0.5297247f,0.5550109f);
Get(0x6E82).SetLocalPose(-0.411037f,1.195552f,-0.1425799f,-0.6567823f,-0.2913371f,-0.1355445f,0.6821932f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 14.06944f);
Get(0x6EC6).SetLocalPose(0.1776495f,0.8195533f,-0.5028441f,-0.1927416f,0.03367506f,-0.9805117f,-0.01770889f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321574f,1.53806f,0.4831236f,-0.6545172f,-0.2082052f,-0.2499265f,0.6824915f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 14.0912f);
Get(0x6E70).SetLocalPose(-0.1138112f,1.686529f,-0.483514f,0.4419095f,-0.4649327f,-0.5314824f,0.5532451f);
Get(0x6E82).SetLocalPose(-0.4201233f,1.248642f,-0.1426148f,-0.710393f,-0.2997853f,-0.1345674f,0.6223844f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 14.0912f);
Get(0x6EC6).SetLocalPose(0.1781785f,0.8193738f,-0.5025098f,-0.1903817f,0.03060767f,-0.9810962f,-0.01637723f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321487f,1.537932f,0.4831619f,-0.6545185f,-0.208205f,-0.2499405f,0.6824852f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 14.11114f);
Get(0x6E70).SetLocalPose(-0.1130138f,1.686781f,-0.4836851f,0.4413848f,-0.4654892f,-0.532897f,0.5518334f);
Get(0x6E82).SetLocalPose(-0.426098f,1.294118f,-0.1460645f,-0.7538345f,-0.298758f,-0.1440589f,0.5672073f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 14.11114f);
Get(0x6EC6).SetLocalPose(0.1781466f,0.8185568f,-0.5023636f,-0.1888624f,0.02885249f,-0.9814503f,-0.01593237f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321563f,1.537881f,0.4831455f,-0.6545255f,-0.2082006f,-0.2499291f,0.682484f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 14.13083f);
Get(0x6E70).SetLocalPose(-0.1123365f,1.687096f,-0.4835596f,0.4408501f,-0.4659918f,-0.5342376f,0.5505388f);
Get(0x6E82).SetLocalPose(-0.4301882f,1.349663f,-0.1552225f,-0.8020359f,-0.2929674f,-0.1619061f,0.4946667f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 14.13083f);
Get(0x6EC6).SetLocalPose(0.1784748f,0.8192524f,-0.5019174f,-0.1860995f,0.02706764f,-0.9820353f,-0.01551972f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321447f,1.53803f,0.4831581f,-0.6545171f,-0.2082524f,-0.2499283f,0.6824766f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 14.15181f);
Get(0x6E70).SetLocalPose(-0.1115323f,1.687355f,-0.4836043f,0.4403456f,-0.4664327f,-0.5355306f,0.5493117f);
Get(0x6E82).SetLocalPose(-0.4307439f,1.390977f,-0.1674354f,-0.8386354f,-0.284445f,-0.1765149f,0.4296792f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 14.15181f);
Get(0x6EC6).SetLocalPose(0.178609f,0.8203013f,-0.5027381f,-0.1838203f,0.02621746f,-0.9825003f,-0.01469533f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321574f,1.538028f,0.4831287f,-0.6545303f,-0.2082304f,-0.2499214f,0.6824731f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 14.17196f);
Get(0x6E70).SetLocalPose(-0.1113646f,1.687706f,-0.4832661f,0.4400611f,-0.4666585f,-0.5364394f,0.5484605f);
Get(0x6E82).SetLocalPose(-0.4281985f,1.432598f,-0.1845381f,-0.8725976f,-0.2717471f,-0.1920061f,0.3575762f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 14.17196f);
Get(0x6EC6).SetLocalPose(0.1791293f,0.8208424f,-0.502674f,-0.1823926f,0.02600806f,-0.98278f,-0.0141441f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321619f,1.53811f,0.483195f,-0.6545272f,-0.2082241f,-0.2499185f,0.682479f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 14.19164f);
Get(0x6E70).SetLocalPose(-0.1103034f,1.687991f,-0.4828533f,0.4398569f,-0.4668532f,-0.5373866f,0.5475306f);
Get(0x6E82).SetLocalPose(-0.4219112f,1.470687f,-0.2028571f,-0.8995488f,-0.2503754f,-0.2090469f,0.2905571f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 14.19164f);
Get(0x6EC6).SetLocalPose(0.1793024f,0.8217255f,-0.5031953f,-0.1814836f,0.02584207f,-0.982953f,-0.01412176f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321414f,1.538212f,0.4831716f,-0.6545346f,-0.2082f,-0.2499428f,0.6824705f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 14.21988f);
Get(0x6E70).SetLocalPose(-0.1093652f,1.688136f,-0.4822884f,0.4395834f,-0.4671876f,-0.5386232f,0.5462484f);
Get(0x6E82).SetLocalPose(-0.4078563f,1.514575f,-0.2306101f,-0.9272146f,-0.2041297f,-0.2498637f,0.1901902f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 14.21988f);
Get(0x6EC6).SetLocalPose(0.1792242f,0.8213422f,-0.5034654f,-0.1811727f,0.0248688f,-0.9830334f,-0.01426618f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321439f,1.538153f,0.4832078f,-0.654543f,-0.2082161f,-0.2499586f,0.6824517f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 14.23874f);
Get(0x6E70).SetLocalPose(-0.1089913f,1.687956f,-0.4819532f,0.4393636f,-0.467479f,-0.5392938f,0.5455137f);
Get(0x6E82).SetLocalPose(-0.397801f,1.535998f,-0.2499125f,-0.9377091f,-0.1721632f,-0.2757118f,0.1226564f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 14.23874f);
Get(0x6EC6).SetLocalPose(0.1792395f,0.8202639f,-0.5033796f,-0.1810491f,0.0242756f,-0.9830735f,-0.01408594f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321429f,1.538201f,0.4832438f,-0.6545414f,-0.2082065f,-0.2499743f,0.6824504f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 14.25729f);
Get(0x6E70).SetLocalPose(-0.1085908f,1.687924f,-0.4816614f,0.4393092f,-0.4676413f,-0.5396437f,0.5450722f);
Get(0x6E82).SetLocalPose(-0.3863143f,1.552039f,-0.2692963f,-0.9428169f,-0.1364404f,-0.2995375f,0.05251418f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 14.25729f);
Get(0x6EC6).SetLocalPose(0.1795019f,0.8203914f,-0.5031492f,-0.1807572f,0.02391372f,-0.9831426f,-0.01362684f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321378f,1.538035f,0.4831393f,-0.6545436f,-0.2081935f,-0.2499423f,0.6824639f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 14.27732f);
Get(0x6E70).SetLocalPose(-0.1081159f,1.687227f,-0.4816373f,0.4393766f,-0.4680645f,-0.5401476f,0.5441548f);
Get(0x6E82).SetLocalPose(-0.3698959f,1.567086f,-0.2909938f,-0.9398054f,-0.09316268f,-0.3265313f,-0.03826051f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 14.27732f);
Get(0x6EC6).SetLocalPose(0.17998f,0.820036f,-0.5024204f,-0.1801295f,0.02349976f,-0.9832771f,-0.01293932f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32134f,1.537925f,0.4831399f,-0.6545427f,-0.2081776f,-0.24995f,0.6824669f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 14.29626f);
Get(0x6E70).SetLocalPose(-0.1078848f,1.687384f,-0.4813361f,0.4393843f,-0.4684415f,-0.5401423f,0.5438293f);
Get(0x6E82).SetLocalPose(-0.3557903f,1.577644f,-0.3069016f,-0.9323766f,-0.06187456f,-0.3392673f,-0.1083656f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 14.29626f);
Get(0x6EC6).SetLocalPose(0.1801674f,0.819572f,-0.5019524f,-0.1792044f,0.02300584f,-0.9834624f,-0.0125847f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32137f,1.538062f,0.4831754f,-0.6545582f,-0.2081857f,-0.2499517f,0.682449f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 14.31532f);
Get(0x6E70).SetLocalPose(-0.1079294f,1.6876f,-0.4811643f,0.4393595f,-0.4686992f,-0.540124f,0.5436455f);
Get(0x6E82).SetLocalPose(-0.3416075f,1.585573f,-0.3240651f,-0.9203647f,-0.03282014f,-0.3487547f,-0.1738444f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 14.31532f);
Get(0x6EC6).SetLocalPose(0.1802651f,0.8190641f,-0.5018259f,-0.1778661f,0.02232574f,-0.9837264f,-0.01215033f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321434f,1.538102f,0.4830719f,-0.6545373f,-0.2081964f,-0.2499435f,0.6824687f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 14.33414f);
Get(0x6E70).SetLocalPose(-0.107408f,1.687992f,-0.480877f,0.4390828f,-0.469483f,-0.539887f,0.5434281f);
Get(0x6E82).SetLocalPose(-0.3326033f,1.588891f,-0.3406215f,-0.9090975f,-0.01519564f,-0.3532654f,-0.22026f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 14.33414f);
Get(0x6EC6).SetLocalPose(0.1802142f,0.8195873f,-0.5016404f,-0.1765692f,0.02176743f,-0.9839783f,-0.01167518f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321356f,1.538108f,0.4832936f,-0.6545335f,-0.2081633f,-0.2499463f,0.6824814f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 14.35427f);
Get(0x6E70).SetLocalPose(-0.1069189f,1.688351f,-0.4805169f,0.4382378f,-0.4707274f,-0.5396649f,0.5432544f);
Get(0x6E82).SetLocalPose(-0.3238871f,1.593698f,-0.3550534f,-0.8993925f,-0.006244355f,-0.3519033f,-0.259265f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 14.35427f);
Get(0x6EC6).SetLocalPose(0.1799625f,0.8195831f,-0.5018445f,-0.1751453f,0.0210865f,-0.9842525f,-0.01124978f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32135f,1.538244f,0.4832549f,-0.654533f,-0.2081848f,-0.2499586f,0.6824709f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 14.37358f);
Get(0x6E70).SetLocalPose(-0.1067701f,1.688705f,-0.4801538f,0.4377342f,-0.4715479f,-0.5395126f,0.5430999f);
Get(0x6E82).SetLocalPose(-0.3203742f,1.597909f,-0.3668477f,-0.894251f,-0.009867102f,-0.3469891f,-0.2825178f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 14.37358f);
Get(0x6EC6).SetLocalPose(0.1793224f,0.8180734f,-0.5011482f,-0.173808f,0.02032841f,-0.9845094f,-0.01089573f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321391f,1.538237f,0.4831596f,-0.6545253f,-0.2081833f,-0.2499534f,0.6824806f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 14.39285f);
Get(0x6E70).SetLocalPose(-0.1060899f,1.688795f,-0.4801285f,0.4376418f,-0.4720229f,-0.5394167f,0.5428569f);
Get(0x6E82).SetLocalPose(-0.3196311f,1.605155f,-0.3752398f,-0.8937323f,-0.02645732f,-0.3430294f,-0.2878775f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 14.39285f);
Get(0x6EC6).SetLocalPose(0.1791175f,0.8177086f,-0.4999791f,-0.1727854f,0.01967387f,-0.9847044f,-0.0107412f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321429f,1.538061f,0.483109f,-0.6545216f,-0.2081927f,-0.2499461f,0.6824839f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 14.41223f);
Get(0x6E70).SetLocalPose(-0.1055179f,1.688912f,-0.4801705f,0.438062f,-0.4725401f,-0.5393711f,0.5421128f);
Get(0x6E82).SetLocalPose(-0.3221003f,1.616852f,-0.3813593f,-0.8972418f,-0.0601876f,-0.3403923f,-0.274714f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 14.41223f);
Get(0x6EC6).SetLocalPose(0.1783651f,0.8189328f,-0.4989555f,-0.171614f,0.01891156f,-0.9849228f,-0.01087202f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32128f,1.538131f,0.483191f,-0.6545278f,-0.2081792f,-0.2499443f,0.6824827f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 14.43089f);
Get(0x6E70).SetLocalPose(-0.1051759f,1.689088f,-0.4805222f,0.4387554f,-0.4729118f,-0.5392957f,0.5413024f);
Get(0x6E82).SetLocalPose(-0.3319764f,1.625516f,-0.3844247f,-0.9031655f,-0.1111556f,-0.332861f,-0.2472651f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 14.43089f);
Get(0x6EC6).SetLocalPose(0.1778027f,0.819262f,-0.4972091f,-0.1695789f,0.01847373f,-0.9852801f,-0.01117768f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321384f,1.538035f,0.4832715f,-0.6545529f,-0.2082103f,-0.2499378f,0.6824516f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 14.45983f);
Get(0x6E70).SetLocalPose(-0.1045474f,1.689349f,-0.4811667f,0.4398574f,-0.4736735f,-0.5388024f,0.5402323f);
Get(0x6E82).SetLocalPose(-0.3558583f,1.641872f,-0.3868447f,-0.922713f,-0.2022264f,-0.2754712f,-0.1783841f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 14.45983f);
Get(0x6EC6).SetLocalPose(0.1770271f,0.8187184f,-0.4947041f,-0.1654175f,0.01880623f,-0.9859716f,-0.01197957f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321429f,1.537985f,0.4833183f,-0.6545619f,-0.2081766f,-0.2499197f,0.6824598f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 14.47973f);
Get(0x6E70).SetLocalPose(-0.1040629f,1.689519f,-0.481381f,0.4403572f,-0.4745846f,-0.5383506f,0.5394753f);
Get(0x6E82).SetLocalPose(-0.3793505f,1.650616f,-0.3869802f,-0.9341989f,-0.2726004f,-0.2039413f,-0.1066276f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 14.47973f);
Get(0x6EC6).SetLocalPose(0.1764686f,0.8198274f,-0.4925206f,-0.1616439f,0.0184886f,-0.9866033f,-0.01197526f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321456f,1.537872f,0.4833165f,-0.6545319f,-0.2081757f,-0.2499556f,0.6824757f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 14.49867f);
Get(0x6E70).SetLocalPose(-0.1030708f,1.68973f,-0.4819132f,0.4404188f,-0.4755928f,-0.5381296f,0.5387571f);
Get(0x6E82).SetLocalPose(-0.4033072f,1.659349f,-0.3853096f,-0.9326038f,-0.3400932f,-0.1176352f,-0.027364f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 14.49867f);
Get(0x6EC6).SetLocalPose(0.1765388f,0.8193845f,-0.4916868f,-0.1583408f,0.01776592f,-0.9871563f,-0.01162356f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321513f,1.537902f,0.4832177f,-0.6545531f,-0.2082044f,-0.2499223f,0.6824589f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 14.51798f);
Get(0x6E70).SetLocalPose(-0.1024447f,1.689678f,-0.4824419f,0.4400474f,-0.476869f,-0.5382283f,0.5378333f);
Get(0x6E82).SetLocalPose(-0.4249646f,1.662878f,-0.3840621f,-0.926131f,-0.3740695f,-0.02499515f,0.04157582f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 14.51798f);
Get(0x6EC6).SetLocalPose(0.1765786f,0.8199161f,-0.4914714f,-0.1543785f,0.01636028f,-0.9878175f,-0.01077926f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321595f,1.537925f,0.4831741f,-0.6545438f,-0.2082016f,-0.2499251f,0.6824676f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 14.53828f);
Get(0x6E70).SetLocalPose(-0.1017457f,1.690208f,-0.4826603f,0.4394271f,-0.4780217f,-0.538722f,0.5368218f);
Get(0x6E82).SetLocalPose(-0.4316784f,1.6639f,-0.3839497f,-0.9244851f,-0.3743804f,0.003954867f,0.07176995f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 14.53828f);
Get(0x6EC6).SetLocalPose(0.1761552f,0.8218994f,-0.4900823f,-0.1505791f,0.01403874f,-0.988451f,-0.009671893f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321632f,1.537885f,0.4832322f,-0.6545452f,-0.2082154f,-0.2499185f,0.6824645f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 14.55761f);
Get(0x6E70).SetLocalPose(-0.1008326f,1.690031f,-0.4828371f,0.4388928f,-0.4790262f,-0.5396039f,0.5354762f);
Get(0x6E82).SetLocalPose(-0.4266719f,1.660649f,-0.384955f,-0.9304863f,-0.3599648f,-0.04217227f,0.05331107f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 14.55761f);
Get(0x6EC6).SetLocalPose(0.1759639f,0.8220538f,-0.4886376f,-0.1479563f,0.01228022f,-0.9888785f,-0.00880173f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321523f,1.537949f,0.4834112f,-0.6545654f,-0.2082274f,-0.2499177f,0.6824417f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 14.57641f);
Get(0x6E70).SetLocalPose(-0.1004945f,1.690053f,-0.4829573f,0.4386609f,-0.479532f,-0.5402598f,0.5345512f);
Get(0x6E82).SetLocalPose(-0.4120919f,1.655436f,-0.388876f,-0.9371794f,-0.3297638f,-0.1135021f,-0.008244489f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 14.57641f);
Get(0x6EC6).SetLocalPose(0.1757412f,0.8228562f,-0.4871482f,-0.145605f,0.01177435f,-0.9892362f,-0.008501008f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321462f,1.537951f,0.4834673f,-0.6545784f,-0.2082264f,-0.2499259f,0.6824265f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 14.59571f);
Get(0x6E70).SetLocalPose(-0.09998287f,1.690158f,-0.4829507f,0.4382464f,-0.4800093f,-0.5409459f,0.5337685f);
Get(0x6E82).SetLocalPose(-0.3926224f,1.649552f,-0.3938157f,-0.9373264f,-0.2834773f,-0.1821903f,-0.08869367f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 14.59571f);
Get(0x6EC6).SetLocalPose(0.1755896f,0.8233403f,-0.4856459f,-0.1426098f,0.0119334f,-0.9896716f,-0.008373083f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321428f,1.537997f,0.4833902f,-0.6545775f,-0.2082134f,-0.2499273f,0.6824308f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 14.61558f);
Get(0x6E70).SetLocalPose(-0.09897749f,1.690489f,-0.4828596f,0.4367219f,-0.4807951f,-0.5415458f,0.5337024f);
Get(0x6E82).SetLocalPose(-0.3746935f,1.641419f,-0.3987218f,-0.9344792f,-0.2235281f,-0.227723f,-0.1578799f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 14.61558f);
Get(0x6EC6).SetLocalPose(0.1756986f,0.8226947f,-0.4860213f,-0.1393257f,0.01196905f,-0.9901432f,-0.007843146f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321498f,1.538033f,0.4833812f,-0.6545535f,-0.208209f,-0.2499367f,0.6824518f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 14.63501f);
Get(0x6E70).SetLocalPose(-0.09890489f,1.690537f,-0.4828095f,0.4365159f,-0.4808854f,-0.5416065f,0.533728f);
Get(0x6E82).SetLocalPose(-0.3572485f,1.635053f,-0.4029114f,-0.9286062f,-0.1625182f,-0.256865f,-0.2128352f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 14.63501f);
Get(0x6EC6).SetLocalPose(0.1755204f,0.8211077f,-0.4857251f,-0.1367538f,0.010947f,-0.9905214f,-0.006774368f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321438f,1.537946f,0.4832812f,-0.6545528f,-0.2081983f,-0.2499273f,0.6824592f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 14.65366f);
Get(0x6E70).SetLocalPose(-0.09886129f,1.690567f,-0.4827776f,0.4363124f,-0.4809869f,-0.5416528f,0.533756f);
Get(0x6E82).SetLocalPose(-0.3371097f,1.623332f,-0.4103728f,-0.9126689f,-0.08743854f,-0.2864934f,-0.2780496f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 14.65366f);
Get(0x6EC6).SetLocalPose(0.1758305f,0.8203519f,-0.4844505f,-0.1347602f,0.009368224f,-0.9908169f,-0.005820937f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321474f,1.538056f,0.4833317f,-0.6545496f,-0.2082322f,-0.2499282f,0.6824515f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 14.6729f);
Get(0x6E70).SetLocalPose(-0.09766705f,1.691564f,-0.4819371f,0.4329995f,-0.4820492f,-0.542613f,0.5345196f);
Get(0x6E82).SetLocalPose(-0.3228421f,1.614861f,-0.4138515f,-0.8965836f,-0.03677551f,-0.3065482f,-0.3175116f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 14.6729f);
Get(0x6EC6).SetLocalPose(0.1757082f,0.8189578f,-0.4839337f,-0.1332731f,0.008092462f,-0.9910329f,-0.005164068f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321435f,1.538046f,0.4833822f,-0.6545469f,-0.2082209f,-0.2499208f,0.6824603f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 14.69211f);
Get(0x6E70).SetLocalPose(-0.09738573f,1.691928f,-0.4808829f,0.4306089f,-0.481869f,-0.5441431f,0.5350575f);
Get(0x6E82).SetLocalPose(-0.3095714f,1.608832f,-0.4174688f,-0.8843762f,-0.007008876f,-0.3179595f,-0.3416596f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 14.69211f);
Get(0x6EC6).SetLocalPose(0.1755097f,0.8189495f,-0.4836065f,-0.1323567f,0.008064348f,-0.9911567f,-0.005018057f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321503f,1.538166f,0.4834148f,-0.6545554f,-0.2082249f,-0.2499172f,0.6824523f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 14.70125f);
Get(0x6E70).SetLocalPose(-0.09730051f,1.692165f,-0.4799555f,0.4300473f,-0.4813504f,-0.5451522f,0.5349488f);
Get(0x6E82).SetLocalPose(-0.3047309f,1.607218f,-0.4202433f,-0.8841881f,-0.003776442f,-0.3140191f,-0.3458165f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 14.70125f);
Get(0x6EC6).SetLocalPose(0.1755634f,0.8182108f,-0.4835288f,-0.132129f,0.008306349f,-0.9911836f,-0.005280592f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32156f,1.538087f,0.4833019f,-0.6545601f,-0.2082072f,-0.2499311f,0.682448f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 14.73147f);
Get(0x6E70).SetLocalPose(-0.09678513f,1.691809f,-0.4794911f,0.4299882f,-0.480258f,-0.5464728f,0.5346306f);
Get(0x6E82).SetLocalPose(-0.3034134f,1.611508f,-0.4275018f,-0.908249f,-0.03766999f,-0.2725743f,-0.315227f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 14.73147f);
Get(0x6EC6).SetLocalPose(0.1748906f,0.8200752f,-0.4832652f,-0.1325656f,0.00906533f,-0.9911124f,-0.006366929f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321595f,1.537998f,0.4833443f,-0.6545621f,-0.2082045f,-0.2499139f,0.6824533f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 14.75948f);
Get(0x6E70).SetLocalPose(-0.09603368f,1.691265f,-0.4797542f,0.4309653f,-0.4793381f,-0.5469364f,0.5341951f);
Get(0x6E82).SetLocalPose(-0.3189902f,1.620298f,-0.4353384f,-0.9376661f,-0.1259414f,-0.2071631f,-0.2490075f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 14.75948f);
Get(0x6EC6).SetLocalPose(0.1742763f,0.8205149f,-0.4828205f,-0.1330216f,0.009279437f,-0.9910418f,-0.007436653f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321594f,1.538027f,0.4833789f,-0.6545357f,-0.2082194f,-0.2498993f,0.6824794f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 14.77918f);
Get(0x6E70).SetLocalPose(-0.09550994f,1.690935f,-0.4800132f,0.4318287f,-0.4788358f,-0.5470038f,0.5338793f);
Get(0x6E82).SetLocalPose(-0.3414766f,1.632814f,-0.4355417f,-0.9494298f,-0.1984653f,-0.1534238f,-0.1888272f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 14.77918f);
Get(0x6EC6).SetLocalPose(0.1734791f,0.8204125f,-0.482087f,-0.1321076f,0.008690719f,-0.9911663f,-0.007836323f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321624f,1.538105f,0.4834036f,-0.6545399f,-0.2082283f,-0.2499105f,0.6824685f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 14.79818f);
Get(0x6E70).SetLocalPose(-0.09470449f,1.690588f,-0.4800361f,0.4328293f,-0.478425f,-0.5469112f,0.5335321f);
Get(0x6E82).SetLocalPose(-0.3647399f,1.642091f,-0.4337393f,-0.9541131f,-0.2589379f,-0.08470459f,-0.1242769f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 14.79818f);
Get(0x6EC6).SetLocalPose(0.1731731f,0.8198883f,-0.4806547f,-0.1302133f,0.007780259f,-0.9914249f,-0.007785898f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321625f,1.53808f,0.4831749f,-0.6545039f,-0.2082083f,-0.2499324f,0.6825012f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 14.81778f);
Get(0x6E70).SetLocalPose(-0.09429792f,1.690405f,-0.4799946f,0.4335198f,-0.4782917f,-0.5469278f,0.5330737f);
Get(0x6E82).SetLocalPose(-0.3886149f,1.6489f,-0.430501f,-0.9482692f,-0.3130692f,0.00888209f,-0.05190732f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 14.81778f);
Get(0x6EC6).SetLocalPose(0.172294f,0.8200478f,-0.4791072f,-0.1278572f,0.006927013f,-0.9917384f,-0.007713362f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321658f,1.5381f,0.4831413f,-0.6545273f,-0.2082137f,-0.2499161f,0.682483f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 14.83676f);
Get(0x6E70).SetLocalPose(-0.09379327f,1.690411f,-0.4799488f,0.4338193f,-0.4783966f,-0.5470065f,0.5326551f);
Get(0x6E82).SetLocalPose(-0.4072693f,1.653704f,-0.4266548f,-0.935451f,-0.3440563f,0.08090539f,-0.003329284f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 14.83676f);
Get(0x6EC6).SetLocalPose(0.1720228f,0.8202756f,-0.4784783f,-0.1250547f,0.006046309f,-0.9921034f,-0.007461699f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321611f,1.53818f,0.4831218f,-0.6545189f,-0.208206f,-0.2499335f,0.6824871f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 14.8554f);
Get(0x6E70).SetLocalPose(-0.09335173f,1.690639f,-0.4801111f,0.4341035f,-0.4785837f,-0.5471004f,0.5321587f);
Get(0x6E82).SetLocalPose(-0.4132913f,1.653215f,-0.4259041f,-0.934257f,-0.3457373f,0.08671948f,0.01044941f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 14.8554f);
Get(0x6EC6).SetLocalPose(0.1715993f,0.8220023f,-0.4789375f,-0.1224372f,0.005258536f,-0.9924355f,-0.007306879f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321495f,1.538097f,0.4830652f,-0.6545295f,-0.2081651f,-0.2499419f,0.6824862f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 14.87473f);
Get(0x6E70).SetLocalPose(-0.09302694f,1.690897f,-0.4803149f,0.4342683f,-0.4788868f,-0.5472288f,0.5316194f);
Get(0x6E82).SetLocalPose(-0.4081312f,1.649152f,-0.4239494f,-0.9419279f,-0.3342768f,0.01041133f,-0.03037208f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 14.87473f);
Get(0x6EC6).SetLocalPose(0.1720971f,0.8214836f,-0.4794445f,-0.1207146f,0.004416751f,-0.9926522f,-0.007071265f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321552f,1.538124f,0.4828279f,-0.6545014f,-0.2081932f,-0.2499231f,0.6825115f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 14.89414f);
Get(0x6E70).SetLocalPose(-0.09245922f,1.691617f,-0.4806257f,0.4343024f,-0.4792916f,-0.5474933f,0.530954f);
Get(0x6E82).SetLocalPose(-0.3924718f,1.646742f,-0.4231072f,-0.9435604f,-0.3046446f,-0.08371908f,-0.09938157f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 14.89414f);
Get(0x6EC6).SetLocalPose(0.1724836f,0.8210173f,-0.4796649f,-0.1196666f,0.003284402f,-0.9927878f,-0.0064522f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321459f,1.53805f,0.4829684f,-0.6544977f,-0.2081893f,-0.2499362f,0.6825114f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 14.91405f);
Get(0x6E70).SetLocalPose(-0.09174322f,1.691943f,-0.4805517f,0.4337816f,-0.4798321f,-0.5478624f,0.5305108f);
Get(0x6E82).SetLocalPose(-0.3750771f,1.643407f,-0.4220157f,-0.9381467f,-0.256171f,-0.1645712f,-0.1648445f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 14.91405f);
Get(0x6EC6).SetLocalPose(0.1729188f,0.8195637f,-0.4802087f,-0.1194107f,0.002060765f,-0.9928266f,-0.005669829f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321516f,1.538107f,0.4829652f,-0.6545041f,-0.208192f,-0.2499375f,0.682504f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 14.93256f);
Get(0x6E70).SetLocalPose(-0.09107836f,1.692096f,-0.4803937f,0.4324326f,-0.4805322f,-0.5483432f,0.5304815f);
Get(0x6E82).SetLocalPose(-0.3588037f,1.639624f,-0.4235523f,-0.9253959f,-0.1963093f,-0.2335143f,-0.2248918f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 14.93256f);
Get(0x6EC6).SetLocalPose(0.1727446f,0.8188904f,-0.4804198f,-0.1194688f,0.0009494884f,-0.9928253f,-0.004917772f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321535f,1.538104f,0.4829955f,-0.6545049f,-0.2081997f,-0.2499445f,0.6824983f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 14.95215f);
Get(0x6E70).SetLocalPose(-0.09044269f,1.692074f,-0.4807103f,0.4308862f,-0.4810846f,-0.5489059f,0.5306572f);
Get(0x6E82).SetLocalPose(-0.3406923f,1.632033f,-0.421525f,-0.9039668f,-0.1315061f,-0.2867362f,-0.2886738f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 14.95215f);
Get(0x6EC6).SetLocalPose(0.1732278f,0.8187394f,-0.4795012f,-0.1204535f,-0.0004312811f,-0.9927104f,-0.004093613f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321369f,1.538054f,0.4830868f,-0.6545169f,-0.2082115f,-0.2499368f,0.6824861f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 14.97991f);
Get(0x6E70).SetLocalPose(-0.09017629f,1.692091f,-0.4801521f,0.4284743f,-0.4815319f,-0.5500574f,0.5310119f);
Get(0x6E82).SetLocalPose(-0.3221663f,1.624536f,-0.4198219f,-0.877242f,-0.07154439f,-0.3159701f,-0.3542466f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 14.97991f);
Get(0x6EC6).SetLocalPose(0.1739624f,0.8183056f,-0.4793816f,-0.1228173f,-0.0009671993f,-0.9924214f,-0.003838451f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321389f,1.538026f,0.4831701f,-0.6545041f,-0.2081968f,-0.2499427f,0.6825008f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 14.99979f);
Get(0x6E70).SetLocalPose(-0.08991277f,1.691448f,-0.4799892f,0.4280234f,-0.4806962f,-0.5509042f,0.5312548f);
Get(0x6E82).SetLocalPose(-0.3136234f,1.621882f,-0.4190857f,-0.875364f,-0.0523508f,-0.3214751f,-0.3572827f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 14.99979f);
Get(0x6EC6).SetLocalPose(0.173898f,0.8172457f,-0.480807f,-0.1251118f,-0.0006210368f,-0.992134f,-0.004097034f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321411f,1.538047f,0.4831305f,-0.6545107f,-0.2081859f,-0.2499388f,0.6824991f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 15.01967f);
Get(0x6E70).SetLocalPose(-0.08999927f,1.691446f,-0.4798426f,0.4283912f,-0.4797494f,-0.5513417f,0.5313604f);
Get(0x6E82).SetLocalPose(-0.3094819f,1.624251f,-0.4206185f,-0.889431f,-0.05537733f,-0.3068012f,-0.3342439f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 15.01967f);
Get(0x6EC6).SetLocalPose(0.1734256f,0.8180704f,-0.4809591f,-0.1276879f,-0.0007569249f,-0.9918042f,-0.004437578f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321521f,1.538039f,0.4830432f,-0.6545036f,-0.2082323f,-0.2499432f,0.6824901f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 15.0393f);
Get(0x6E70).SetLocalPose(-0.08992857f,1.690834f,-0.479878f,0.4291981f,-0.4784439f,-0.5514978f,0.5317242f);
Get(0x6E82).SetLocalPose(-0.3130158f,1.625943f,-0.4241997f,-0.9111739f,-0.09319408f,-0.2716722f,-0.2954172f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 15.0393f);
Get(0x6EC6).SetLocalPose(0.1734598f,0.8178954f,-0.4803695f,-0.1294463f,-0.001317999f,-0.9915755f,-0.004473468f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321589f,1.537998f,0.4831528f,-0.6545236f,-0.2082267f,-0.2499295f,0.6824777f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 15.05976f);
Get(0x6E70).SetLocalPose(-0.08944155f,1.69065f,-0.4799469f,0.4300067f,-0.4775468f,-0.551048f,0.5323432f);
Get(0x6E82).SetLocalPose(-0.322684f,1.635424f,-0.4264611f,-0.9326171f,-0.1464434f,-0.2241317f,-0.2419603f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 15.05976f);
Get(0x6EC6).SetLocalPose(0.1730108f,0.8197057f,-0.4806438f,-0.130479f,-0.00227986f,-0.9914384f,-0.004468455f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321627f,1.537917f,0.4832298f,-0.6545104f,-0.2082419f,-0.2499481f,0.6824789f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 15.0698f);
Get(0x6E70).SetLocalPose(-0.0894115f,1.690526f,-0.479997f,0.4303371f,-0.4772694f,-0.5507468f,0.5326368f);
Get(0x6E82).SetLocalPose(-0.3337218f,1.638558f,-0.4265674f,-0.9415842f,-0.1772032f,-0.1956055f,-0.2091813f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 15.0698f);
Get(0x6EC6).SetLocalPose(0.1729624f,0.8198393f,-0.4814113f,-0.1307553f,-0.002731825f,-0.9914004f,-0.00456555f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321613f,1.53785f,0.483306f,-0.6545193f,-0.2082288f,-0.2499427f,0.6824763f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 15.09224f);
Get(0x6E70).SetLocalPose(-0.08854915f,1.690806f,-0.4802707f,0.4309746f,-0.4769341f,-0.5498228f,0.5333757f);
Get(0x6E82).SetLocalPose(-0.3551342f,1.648229f,-0.4276547f,-0.9526023f,-0.2491724f,-0.1203039f,-0.1264478f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 15.09224f);
Get(0x6EC6).SetLocalPose(0.1732055f,0.8207672f,-0.4815396f,-0.1309815f,-0.003205541f,-0.991367f,-0.005017563f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321418f,1.537823f,0.4833091f,-0.6544988f,-0.2082159f,-0.249978f,0.682487f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 15.11268f);
Get(0x6E70).SetLocalPose(-0.08769704f,1.690678f,-0.4806966f,0.4310769f,-0.4770848f,-0.5493565f,0.5336388f);
Get(0x6E82).SetLocalPose(-0.3776502f,1.655599f,-0.4286516f,-0.9482452f,-0.3148136f,-0.02406515f,-0.03382588f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 15.11268f);
Get(0x6EC6).SetLocalPose(0.1733187f,0.8217768f,-0.4812334f,-0.1308279f,-0.003615697f,-0.9913847f,-0.005239998f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321459f,1.537935f,0.4831265f,-0.6545012f,-0.2082159f,-0.2499418f,0.6824979f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 15.13279f);
Get(0x6E70).SetLocalPose(-0.08710825f,1.690829f,-0.4808131f,0.4311559f,-0.4772102f,-0.5492269f,0.5335961f);
Get(0x6E82).SetLocalPose(-0.3994099f,1.65868f,-0.4252013f,-0.9301502f,-0.3599254f,0.05768877f,0.04411841f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 15.13279f);
Get(0x6EC6).SetLocalPose(0.1733876f,0.8215968f,-0.4813825f,-0.1308329f,-0.003931853f,-0.9913826f,-0.00527786f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321364f,1.537965f,0.4832237f,-0.6545063f,-0.208216f,-0.2499526f,0.6824891f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 15.15238f);
Get(0x6E70).SetLocalPose(-0.08671877f,1.690683f,-0.4810624f,0.4313492f,-0.477406f,-0.5493084f,0.5331807f);
Get(0x6E82).SetLocalPose(-0.4107377f,1.660737f,-0.4235606f,-0.9173406f,-0.3794523f,0.09418796f,0.07503907f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 15.15238f);
Get(0x6EC6).SetLocalPose(0.1740806f,0.8213422f,-0.4814008f,-0.1310977f,-0.004259533f,-0.9913478f,-0.004984821f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321428f,1.538069f,0.4830468f,-0.6545217f,-0.2081801f,-0.2499519f,0.6824855f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 15.17252f);
Get(0x6E70).SetLocalPose(-0.08659724f,1.690742f,-0.4814997f,0.4316925f,-0.4776621f,-0.5497208f,0.5322478f);
Get(0x6E82).SetLocalPose(-0.4113881f,1.66052f,-0.4238387f,-0.9220624f,-0.3796389f,0.05323098f,0.05330867f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 15.17252f);
Get(0x6EC6).SetLocalPose(0.174515f,0.8207931f,-0.4817417f,-0.1313197f,-0.004495033f,-0.9913187f,-0.004723389f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321336f,1.538201f,0.483027f,-0.6545153f,-0.2081911f,-0.2499573f,0.6824863f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 15.19255f);
Get(0x6E70).SetLocalPose(-0.08645876f,1.69068f,-0.4820178f,0.432126f,-0.4777873f,-0.5500774f,0.5314143f);
Get(0x6E82).SetLocalPose(-0.4027593f,1.655588f,-0.4245238f,-0.9296488f,-0.3668582f,-0.03171575f,-0.01274494f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 15.19255f);
Get(0x6EC6).SetLocalPose(0.1749634f,0.8204197f,-0.4834789f,-0.1310093f,-0.00489144f,-0.9913586f,-0.004553673f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321409f,1.538073f,0.4830534f,-0.654502f,-0.2081863f,-0.2499686f,0.6824964f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 15.21258f);
Get(0x6E70).SetLocalPose(-0.08647723f,1.690908f,-0.4825462f,0.432462f,-0.4778678f,-0.5504335f,0.5306997f);
Get(0x6E82).SetLocalPose(-0.3897938f,1.649208f,-0.4228224f,-0.9263116f,-0.3392058f,-0.1320375f,-0.09722326f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 15.21258f);
Get(0x6EC6).SetLocalPose(0.1756332f,0.819815f,-0.4841877f,-0.1301301f,-0.00529457f,-0.9914736f,-0.004255797f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32138f,1.538006f,0.4831523f,-0.654519f,-0.2082007f,-0.2499758f,0.6824731f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 15.23223f);
Get(0x6E70).SetLocalPose(-0.08653239f,1.690782f,-0.4827795f,0.4322523f,-0.4780689f,-0.5507205f,0.5303913f);
Get(0x6E82).SetLocalPose(-0.376115f,1.646305f,-0.4197524f,-0.9112807f,-0.2984761f,-0.2201513f,-0.1789218f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 15.23223f);
Get(0x6EC6).SetLocalPose(0.1763042f,0.820091f,-0.4841259f,-0.1288707f,-0.005979485f,-0.9916371f,-0.003534693f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321375f,1.538004f,0.4830636f,-0.6545125f,-0.2081808f,-0.2499784f,0.6824844f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 15.25314f);
Get(0x6E70).SetLocalPose(-0.08608094f,1.690719f,-0.482729f,0.431542f,-0.4783307f,-0.550881f,0.5305671f);
Get(0x6E82).SetLocalPose(-0.3649045f,1.640975f,-0.4167838f,-0.8925605f,-0.2579802f,-0.2848358f,-0.2359036f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 15.25314f);
Get(0x6EC6).SetLocalPose(0.1768275f,0.8181897f,-0.4835132f,-0.1273467f,-0.007167537f,-0.9918292f,-0.002488022f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321339f,1.53789f,0.4830518f,-0.6545293f,-0.2081829f,-0.2499575f,0.6824753f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 15.27339f);
Get(0x6E70).SetLocalPose(-0.08571338f,1.690671f,-0.4825969f,0.4303904f,-0.478585f,-0.5512427f,0.5308974f);
Get(0x6E82).SetLocalPose(-0.3559692f,1.637824f,-0.4135523f,-0.8809825f,-0.2255762f,-0.3234536f,-0.2614633f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 15.27339f);
Get(0x6EC6).SetLocalPose(0.177522f,0.8172249f,-0.4831947f,-0.1260225f,-0.008425402f,-0.9919903f,-0.001613212f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32137f,1.537883f,0.4830752f,-0.6545138f,-0.2081725f,-0.2499468f,0.6824973f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 15.29328f);
Get(0x6E70).SetLocalPose(-0.08612106f,1.691537f,-0.4825305f,0.4293748f,-0.4786936f,-0.5516987f,0.5311481f);
Get(0x6E82).SetLocalPose(-0.3495061f,1.637375f,-0.4109952f,-0.8862952f,-0.2061995f,-0.3255046f,-0.256923f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 15.29328f);
Get(0x6EC6).SetLocalPose(0.1778013f,0.8171428f,-0.483555f,-0.1247645f,-0.009993202f,-0.9921359f,-0.0004072096f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321438f,1.538088f,0.4830149f,-0.6545174f,-0.2081878f,-0.2499318f,0.6824947f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 15.313f);
Get(0x6E70).SetLocalPose(-0.0863623f,1.691798f,-0.4824929f,0.4286125f,-0.478583f,-0.5521387f,0.5314062f);
Get(0x6E82).SetLocalPose(-0.3461607f,1.639525f,-0.4079637f,-0.9006225f,-0.2007774f,-0.3063191f,-0.2339578f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 15.313f);
Get(0x6EC6).SetLocalPose(0.1781325f,0.8169166f,-0.4836527f,-0.1244132f,-0.01066571f,-0.9921731f,0.0003022104f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321525f,1.538037f,0.4830035f,-0.6545172f,-0.2081937f,-0.2499472f,0.6824874f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 15.33226f);
Get(0x6E70).SetLocalPose(-0.08629739f,1.691285f,-0.4822396f,0.4279141f,-0.4781114f,-0.5525191f,0.531998f);
Get(0x6E82).SetLocalPose(-0.3470695f,1.638344f,-0.4068435f,-0.9121725f,-0.2039341f,-0.2873138f,-0.2092918f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 15.33226f);
Get(0x6EC6).SetLocalPose(0.1780997f,0.8165027f,-0.4836845f,-0.1245054f,-0.01056486f,-0.9921625f,0.0004907306f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32154f,1.538065f,0.4829597f,-0.6545239f,-0.2081552f,-0.2499324f,0.6824982f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 15.35237f);
Get(0x6E70).SetLocalPose(-0.08656018f,1.691051f,-0.4823097f,0.4280516f,-0.4772168f,-0.5525726f,0.5326346f);
Get(0x6E82).SetLocalPose(-0.3536473f,1.637082f,-0.405088f,-0.9206423f,-0.2115505f,-0.2723025f,-0.1830721f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 15.35237f);
Get(0x6EC6).SetLocalPose(0.1776755f,0.8154576f,-0.4837015f,-0.1250513f,-0.01026948f,-0.9920971f,0.0002848683f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321497f,1.537946f,0.4830699f,-0.6545338f,-0.2081712f,-0.2499609f,0.6824734f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 15.37138f);
Get(0x6E70).SetLocalPose(-0.08702152f,1.690792f,-0.48232f,0.4286165f,-0.4763417f,-0.5525382f,0.5329992f);
Get(0x6E82).SetLocalPose(-0.3586718f,1.637017f,-0.4007655f,-0.9253201f,-0.2203852f,-0.2633231f,-0.1608534f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 15.37138f);
Get(0x6EC6).SetLocalPose(0.1776289f,0.8153758f,-0.4839255f,-0.1256711f,-0.01019834f,-0.9920195f,0.0001088213f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321405f,1.537938f,0.4830309f,-0.6545194f,-0.208174f,-0.2499648f,0.6824849f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 15.3909f);
Get(0x6E70).SetLocalPose(-0.08745065f,1.690392f,-0.4822549f,0.4291557f,-0.4758698f,-0.5524229f,0.5331062f);
Get(0x6E82).SetLocalPose(-0.3626229f,1.638944f,-0.3976479f,-0.9268733f,-0.2252217f,-0.2610873f,-0.1483729f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 15.3909f);
Get(0x6EC6).SetLocalPose(0.177682f,0.8156298f,-0.4840686f,-0.1259501f,-0.01044858f,-0.9919816f,0.0001555365f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321383f,1.538074f,0.4830216f,-0.6545191f,-0.2081778f,-0.2499356f,0.6824948f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 15.41066f);
Get(0x6E70).SetLocalPose(-0.08756626f,1.690447f,-0.4824321f,0.4295191f,-0.4756626f,-0.5523145f,0.5331109f);
Get(0x6E82).SetLocalPose(-0.3658188f,1.641398f,-0.3945957f,-0.9273257f,-0.2310269f,-0.2606451f,-0.1369596f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 15.41066f);
Get(0x6EC6).SetLocalPose(0.1776458f,0.8163878f,-0.4844941f,-0.1260086f,-0.01084438f,-0.9919698f,0.0005620299f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321426f,1.538196f,0.4830773f,-0.6545426f,-0.2082123f,-0.2499199f,0.6824675f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 15.4391f);
Get(0x6E70).SetLocalPose(-0.08799247f,1.690619f,-0.4824829f,0.4298573f,-0.4758718f,-0.5521085f,0.5328648f);
Get(0x6E82).SetLocalPose(-0.3731113f,1.641955f,-0.3904015f,-0.9276654f,-0.2419713f,-0.2591176f,-0.1172381f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 15.4391f);
Get(0x6EC6).SetLocalPose(0.1775212f,0.8166404f,-0.4841623f,-0.1261339f,-0.0111476f,-0.9919502f,0.0009466037f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321437f,1.538048f,0.4833028f,-0.6545404f,-0.2082002f,-0.2499229f,0.6824721f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 15.45938f);
Get(0x6E70).SetLocalPose(-0.08807261f,1.690753f,-0.4829014f,0.4299004f,-0.4761093f,-0.5519567f,0.5327752f);
Get(0x6E82).SetLocalPose(-0.3794484f,1.640552f,-0.3864602f,-0.9294974f,-0.2479328f,-0.2539489f,-0.1003687f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 15.45938f);
Get(0x6EC6).SetLocalPose(0.1775111f,0.8171991f,-0.4836456f,-0.1265092f,-0.01142639f,-0.9918987f,0.001336685f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321518f,1.538065f,0.48322f,-0.6545298f,-0.2081926f,-0.24995f,0.6824747f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 15.47822f);
Get(0x6E70).SetLocalPose(-0.0882172f,1.690777f,-0.4829443f,0.4296393f,-0.4762581f,-0.5518813f,0.5329309f);
Get(0x6E82).SetLocalPose(-0.3830647f,1.64055f,-0.3837269f,-0.9312207f,-0.2505768f,-0.2496656f,-0.08778743f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 15.47822f);
Get(0x6EC6).SetLocalPose(0.1778241f,0.8174671f,-0.4836664f,-0.1271935f,-0.01171079f,-0.9918074f,0.001709061f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321576f,1.538062f,0.4831442f,-0.6545312f,-0.208209f,-0.2499443f,0.6824703f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 15.49778f);
Get(0x6E70).SetLocalPose(-0.08837955f,1.690717f,-0.4826891f,0.4290124f,-0.4764432f,-0.5518376f,0.5333156f);
Get(0x6E82).SetLocalPose(-0.3860207f,1.638532f,-0.3814993f,-0.9317697f,-0.2511159f,-0.2506556f,-0.07692812f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 15.49778f);
Get(0x6EC6).SetLocalPose(0.1781295f,0.8176953f,-0.4838267f,-0.1280297f,-0.01195936f,-0.9916964f,0.001900063f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321472f,1.537978f,0.4832996f,-0.6545345f,-0.2082012f,-0.2499538f,0.6824661f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 15.51709f);
Get(0x6E70).SetLocalPose(-0.08862362f,1.690353f,-0.4824409f,0.4282291f,-0.4765504f,-0.5518922f,0.5337928f);
Get(0x6E82).SetLocalPose(-0.3872905f,1.636889f,-0.3767114f,-0.9310525f,-0.2497537f,-0.2568828f,-0.06910579f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 15.51709f);
Get(0x6EC6).SetLocalPose(0.1780983f,0.8185562f,-0.4837533f,-0.1291139f,-0.01197352f,-0.9915555f,0.002000893f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321438f,1.537963f,0.4832725f,-0.6545257f,-0.2082225f,-0.2499433f,0.6824719f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 15.53667f);
Get(0x6E70).SetLocalPose(-0.08915138f,1.690169f,-0.4820378f,0.4274813f,-0.4764421f,-0.5521305f,0.5342421f);
Get(0x6E82).SetLocalPose(-0.3889796f,1.636288f,-0.3722865f,-0.9302909f,-0.2480303f,-0.2629937f,-0.06224295f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 15.53667f);
Get(0x6EC6).SetLocalPose(0.1778154f,0.8190302f,-0.4837994f,-0.1303163f,-0.01179257f,-0.9914001f,0.002125937f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321481f,1.537955f,0.4832781f,-0.6545491f,-0.2082328f,-0.2499295f,0.6824514f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 15.55558f);
Get(0x6E70).SetLocalPose(-0.08938883f,1.690167f,-0.4814885f,0.4267331f,-0.4761643f,-0.5524575f,0.5347497f);
Get(0x6E82).SetLocalPose(-0.3913851f,1.63275f,-0.366734f,-0.9296545f,-0.2462307f,-0.2691821f,-0.05151639f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 15.55558f);
Get(0x6EC6).SetLocalPose(0.1778306f,0.8197075f,-0.4841456f,-0.1313854f,-0.01157296f,-0.9912612f,0.002290338f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321528f,1.537859f,0.4833654f,-0.6545472f,-0.2082073f,-0.2499399f,0.6824573f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 15.57493f);
Get(0x6E70).SetLocalPose(-0.08960481f,1.690325f,-0.4810262f,0.4261485f,-0.4757544f,-0.5527763f,0.535251f);
Get(0x6E82).SetLocalPose(-0.3938333f,1.629857f,-0.3625361f,-0.9291751f,-0.2453881f,-0.2734406f,-0.04060311f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 15.57493f);
Get(0x6EC6).SetLocalPose(0.1780182f,0.8196401f,-0.4846361f,-0.1324211f,-0.01137109f,-0.9911247f,0.002684928f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321566f,1.537811f,0.4833259f,-0.6545523f,-0.2082483f,-0.2499359f,0.6824412f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 15.59375f);
Get(0x6E70).SetLocalPose(-0.08991711f,1.690289f,-0.4804969f,0.4255556f,-0.4753056f,-0.5531018f,0.5357849f);
Get(0x6E82).SetLocalPose(-0.3967943f,1.627574f,-0.3566647f,-0.9281405f,-0.2456228f,-0.2782632f,-0.02818371f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 15.59375f);
Get(0x6EC6).SetLocalPose(0.1778804f,0.8193729f,-0.4849621f,-0.1332306f,-0.01128342f,-0.9910163f,0.003007979f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321596f,1.537915f,0.4832639f,-0.6545411f,-0.2082139f,-0.2499428f,0.6824599f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 15.61364f);
Get(0x6E70).SetLocalPose(-0.09013949f,1.690136f,-0.4801613f,0.4251239f,-0.4749223f,-0.5532769f,0.5362866f);
Get(0x6E82).SetLocalPose(-0.4003078f,1.624008f,-0.3506875f,-0.9259854f,-0.2474825f,-0.2847764f,-0.0143519f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 15.61364f);
Get(0x6EC6).SetLocalPose(0.1775023f,0.8199769f,-0.4852778f,-0.1338354f,-0.01119534f,-0.9909346f,0.0033655f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321457f,1.537995f,0.4832646f,-0.6545326f,-0.2082008f,-0.2499405f,0.6824729f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 15.6333f);
Get(0x6E70).SetLocalPose(-0.09073226f,1.690233f,-0.4799964f,0.4248711f,-0.4747337f,-0.5532175f,0.536715f);
Get(0x6E82).SetLocalPose(-0.4047942f,1.619341f,-0.3447725f,-0.9238325f,-0.2497369f,-0.2901046f,-0.002050031f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 15.6333f);
Get(0x6EC6).SetLocalPose(0.1771507f,0.8193296f,-0.4853697f,-0.1341435f,-0.01126427f,-0.9908911f,0.00367935f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321564f,1.538058f,0.4831283f,-0.6545348f,-0.2081874f,-0.2499442f,0.6824736f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 15.65263f);
Get(0x6E70).SetLocalPose(-0.09128246f,1.690581f,-0.4798079f,0.4246145f,-0.4746158f,-0.5531557f,0.5370858f);
Get(0x6E82).SetLocalPose(-0.4093838f,1.613739f,-0.3373189f,-0.9214867f,-0.2521503f,-0.2950458f,0.01518729f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 15.65263f);
Get(0x6EC6).SetLocalPose(0.1771434f,0.8192895f,-0.4852133f,-0.1344404f,-0.01105306f,-0.9908518f,0.004052897f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321494f,1.538136f,0.483099f,-0.6545532f,-0.2082069f,-0.2499648f,0.6824425f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 15.67161f);
Get(0x6E70).SetLocalPose(-0.09173158f,1.691096f,-0.4796328f,0.4244206f,-0.4745631f,-0.5531412f,0.5373006f);
Get(0x6E82).SetLocalPose(-0.4134485f,1.606956f,-0.3289644f,-0.9197134f,-0.2539688f,-0.2974086f,0.03428207f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 15.67161f);
Get(0x6EC6).SetLocalPose(0.176551f,0.8192217f,-0.4860132f,-0.1347544f,-0.01074769f,-0.990811f,0.004380408f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321281f,1.538125f,0.4831954f,-0.6545523f,-0.2082121f,-0.2499558f,0.6824449f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 15.69128f);
Get(0x6E70).SetLocalPose(-0.09230082f,1.690829f,-0.4794675f,0.4242208f,-0.474568f,-0.5530285f,0.5375701f);
Get(0x6E82).SetLocalPose(-0.4188715f,1.598179f,-0.3190262f,-0.9183503f,-0.2555156f,-0.2963883f,0.05914692f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 15.69128f);
Get(0x6EC6).SetLocalPose(0.1764375f,0.8193823f,-0.4863537f,-0.1348085f,-0.01060207f,-0.9908029f,0.004881698f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321271f,1.538045f,0.4833061f,-0.6545362f,-0.2082352f,-0.2499322f,0.682462f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 15.71914f);
Get(0x6E70).SetLocalPose(-0.09345768f,1.690848f,-0.4789992f,0.4239597f,-0.4746513f,-0.5526859f,0.5380546f);
Get(0x6E82).SetLocalPose(-0.4265207f,1.583687f,-0.3039314f,-0.9167359f,-0.2555621f,-0.2904752f,0.09953668f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 15.71914f);
Get(0x6EC6).SetLocalPose(0.1761331f,0.8187617f,-0.4872781f,-0.1345859f,-0.01045321f,-0.9908304f,0.005710494f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321282f,1.538138f,0.4834616f,-0.6545347f,-0.2082159f,-0.249937f,0.6824676f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 15.738f);
Get(0x6E70).SetLocalPose(-0.09432409f,1.690807f,-0.4787592f,0.4237957f,-0.4747465f,-0.5523673f,0.5384267f);
Get(0x6E82).SetLocalPose(-0.4320363f,1.566212f,-0.2899314f,-0.9138442f,-0.2509767f,-0.2855152f,0.1427606f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 15.738f);
Get(0x6EC6).SetLocalPose(0.1763636f,0.8179033f,-0.4870763f,-0.1343722f,-0.01029867f,-0.990858f,0.006218113f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321386f,1.538006f,0.4834056f,-0.6545255f,-0.2082351f,-0.2499408f,0.6824691f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 15.7573f);
Get(0x6E70).SetLocalPose(-0.09504303f,1.690753f,-0.4785884f,0.4237162f,-0.4747788f,-0.5519578f,0.5388806f);
Get(0x6E82).SetLocalPose(-0.4375586f,1.549825f,-0.2754319f,-0.9094003f,-0.2441934f,-0.2816112f,0.1845421f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 15.7573f);
Get(0x6EC6).SetLocalPose(0.1765948f,0.8168066f,-0.4872369f,-0.1340857f,-0.01012918f,-0.9908949f,0.006768963f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321501f,1.538096f,0.4833148f,-0.6545281f,-0.2082504f,-0.2499111f,0.6824728f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 15.77673f);
Get(0x6E70).SetLocalPose(-0.09621651f,1.690869f,-0.4782033f,0.423726f,-0.474746f,-0.5512996f,0.5395751f);
Get(0x6E82).SetLocalPose(-0.4429049f,1.527199f,-0.2601532f,-0.9014056f,-0.2372977f,-0.276571f,0.2338084f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 15.77673f);
Get(0x6EC6).SetLocalPose(0.1764282f,0.8152904f,-0.487293f,-0.1337014f,-0.01001043f,-0.9909431f,0.007444231f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321635f,1.538128f,0.4833438f,-0.6545188f,-0.2082098f,-0.249933f,0.6824862f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 15.79621f);
Get(0x6E70).SetLocalPose(-0.09744497f,1.691015f,-0.4781209f,0.4237989f,-0.4746113f,-0.5502619f,0.5406945f);
Get(0x6E82).SetLocalPose(-0.446383f,1.50233f,-0.2450552f,-0.8894469f,-0.2329467f,-0.2718505f,0.2841083f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 15.79621f);
Get(0x6EC6).SetLocalPose(0.1762462f,0.814613f,-0.4877208f,-0.1330754f,-0.01002921f,-0.99102f,0.008348437f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321628f,1.538065f,0.4832568f,-0.6545411f,-0.2081925f,-0.2499108f,0.6824782f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 15.8154f);
Get(0x6E70).SetLocalPose(-0.09900113f,1.6915f,-0.4778963f,0.4237926f,-0.4745797f,-0.5492566f,0.5417482f);
Get(0x6E82).SetLocalPose(-0.4488076f,1.477112f,-0.2310155f,-0.8737828f,-0.2286191f,-0.2696416f,0.3339618f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 15.8154f);
Get(0x6EC6).SetLocalPose(0.1752253f,0.8149295f,-0.4881495f,-0.1324018f,-0.01019365f,-0.9911011f,0.009191473f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321738f,1.538141f,0.4831423f,-0.6545295f,-0.2082318f,-0.2499357f,0.6824682f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 15.83513f);
Get(0x6E70).SetLocalPose(-0.1002915f,1.69134f,-0.4776674f,0.4238555f,-0.4746045f,-0.5480024f,0.5429461f);
Get(0x6E82).SetLocalPose(-0.4506011f,1.441248f,-0.2145208f,-0.8463302f,-0.217779f,-0.2687713f,0.4050427f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 15.83513f);
Get(0x6EC6).SetLocalPose(0.1751902f,0.8141928f,-0.488351f,-0.1313333f,-0.01040428f,-0.9912308f,0.01023352f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32153f,1.538014f,0.4832847f,-0.654528f,-0.208219f,-0.2499307f,0.6824754f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 15.85392f);
Get(0x6E70).SetLocalPose(-0.1012337f,1.691216f,-0.4773904f,0.4239328f,-0.4746462f,-0.5471885f,0.5436696f);
Get(0x6E82).SetLocalPose(-0.4501522f,1.410177f,-0.2026209f,-0.8170618f,-0.203432f,-0.265872f,0.4694014f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 15.85392f);
Get(0x6EC6).SetLocalPose(0.1747748f,0.815465f,-0.487109f,-0.1304551f,-0.01059888f,-0.9913363f,0.01102388f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321617f,1.538097f,0.4832335f,-0.6545346f,-0.2081895f,-0.2499467f,0.6824721f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 15.87328f);
Get(0x6E70).SetLocalPose(-0.1030885f,1.691065f,-0.4768859f,0.4241552f,-0.4746471f,-0.5452949f,0.5453953f);
Get(0x6E82).SetLocalPose(-0.4465582f,1.370216f,-0.1913426f,-0.7793827f,-0.1855916f,-0.2584704f,0.5397328f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 15.87328f);
Get(0x6EC6).SetLocalPose(0.1734641f,0.8178319f,-0.4865073f,-0.1291447f,-0.01099589f,-0.9914853f,0.01256079f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321519f,1.537942f,0.4831684f,-0.6545183f,-0.2081903f,-0.2499492f,0.6824867f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 15.89267f);
Get(0x6E70).SetLocalPose(-0.1048001f,1.691423f,-0.4762492f,0.4241647f,-0.474582f,-0.5436981f,0.5470362f);
Get(0x6E82).SetLocalPose(-0.4415351f,1.329448f,-0.1841849f,-0.7433335f,-0.1702287f,-0.251322f,0.5960829f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 15.89267f);
Get(0x6EC6).SetLocalPose(0.1725955f,0.819043f,-0.4861938f,-0.1282788f,-0.0114864f,-0.9915712f,0.01411016f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321459f,1.537901f,0.483145f,-0.65452f,-0.2081778f,-0.2499645f,0.6824833f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 15.91211f);
Get(0x6E70).SetLocalPose(-0.1066933f,1.691623f,-0.4757152f,0.4240417f,-0.4743502f,-0.5420117f,0.5490026f);
Get(0x6E82).SetLocalPose(-0.4347928f,1.29303f,-0.1808024f,-0.7100365f,-0.1536256f,-0.2466651f,0.6414077f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 15.91211f);
Get(0x6EC6).SetLocalPose(0.1716156f,0.8206372f,-0.4863831f,-0.1273885f,-0.01210359f,-0.9916558f,0.01564112f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321434f,1.537886f,0.4830155f,-0.6545154f,-0.2081913f,-0.2499819f,0.6824771f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 15.93177f);
Get(0x6E70).SetLocalPose(-0.1086548f,1.691334f,-0.4749534f,0.4239132f,-0.4739755f,-0.5402908f,0.5511177f);
Get(0x6E82).SetLocalPose(-0.4237047f,1.245325f,-0.1810943f,-0.6675249f,-0.1250715f,-0.2421989f,0.6928978f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 15.93177f);
Get(0x6EC6).SetLocalPose(0.1710383f,0.8222243f,-0.486409f,-0.1263166f,-0.0128438f,-0.991755f,0.01735339f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321331f,1.538058f,0.4832002f,-0.654524f,-0.208176f,-0.2499763f,0.6824756f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 15.95154f);
Get(0x6E70).SetLocalPose(-0.1103224f,1.691108f,-0.4741823f,0.4237763f,-0.4734502f,-0.5388219f,0.553109f);
Get(0x6E82).SetLocalPose(-0.4093005f,1.195807f,-0.1853073f,-0.6281446f,-0.0917822f,-0.2389163f,0.7347989f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 15.95154f);
Get(0x6EC6).SetLocalPose(0.1694885f,0.8234002f,-0.4864709f,-0.1255922f,-0.01344473f,-0.9918097f,0.01895962f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321235f,1.537923f,0.4831229f,-0.6545184f,-0.2081838f,-0.2499564f,0.6824859f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 15.9796f);
Get(0x6E70).SetLocalPose(-0.1125275f,1.691343f,-0.4729851f,0.4232273f,-0.4725508f,-0.5364569f,0.5565864f);
Get(0x6E82).SetLocalPose(-0.3859164f,1.128271f,-0.1994966f,-0.5763049f,-0.04019465f,-0.232733f,0.7823634f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 15.9796f);
Get(0x6EC6).SetLocalPose(0.1691963f,0.8253582f,-0.4865566f,-0.1249279f,-0.01463787f,-0.9918149f,0.02195789f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321222f,1.537833f,0.4832335f,-0.6545522f,-0.2081931f,-0.2499615f,0.6824487f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 15.99943f);
Get(0x6E70).SetLocalPose(-0.114913f,1.691502f,-0.4720758f,0.4224173f,-0.4718713f,-0.5345913f,0.5595652f);
Get(0x6E82).SetLocalPose(-0.3695523f,1.085104f,-0.2135408f,-0.5432141f,-0.002266183f,-0.2249396f,0.8088977f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 15.99943f);
Get(0x6EC6).SetLocalPose(0.1691262f,0.8257556f,-0.4858702f,-0.1250193f,-0.01577409f,-0.9917302f,0.02434488f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321185f,1.538008f,0.4832378f,-0.654538f,-0.208181f,-0.2499462f,0.6824717f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 16.01846f);
Get(0x6E70).SetLocalPose(-0.1164807f,1.691389f,-0.471457f,0.4218071f,-0.4714557f,-0.5334072f,0.5615025f);
Get(0x6E82).SetLocalPose(-0.3512191f,1.039961f,-0.2322825f,-0.5073712f,0.0363097f,-0.2121111f,0.834425f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 16.01846f);
Get(0x6EC6).SetLocalPose(0.1696306f,0.8275751f,-0.485892f,-0.1251528f,-0.01690646f,-0.9916331f,0.02673669f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321178f,1.537839f,0.4831845f,-0.6545367f,-0.2081811f,-0.2499447f,0.6824735f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 16.03767f);
Get(0x6E70).SetLocalPose(-0.1189166f,1.691751f,-0.4702209f,0.4209194f,-0.4706803f,-0.5316103f,0.5645153f);
Get(0x6E82).SetLocalPose(-0.3392761f,1.011018f,-0.2466863f,-0.479317f,0.05845562f,-0.2016311f,0.8521638f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 16.03767f);
Get(0x6EC6).SetLocalPose(0.1697055f,0.8283493f,-0.4860061f,-0.1253876f,-0.01792581f,-0.9915221f,0.02899162f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321163f,1.53801f,0.4832597f,-0.6545268f,-0.2081684f,-0.249988f,0.682471f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 16.05713f);
Get(0x6E70).SetLocalPose(-0.1210847f,1.691589f,-0.4692086f,0.4201178f,-0.4699745f,-0.530003f,0.5672053f);
Get(0x6E82).SetLocalPose(-0.321877f,0.9676844f,-0.2707831f,-0.4255451f,0.07858921f,-0.1798651f,0.8833933f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 16.05713f);
Get(0x6EC6).SetLocalPose(0.1693933f,0.8293961f,-0.4866782f,-0.1259076f,-0.01913501f,-0.9913527f,0.03163894f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321362f,1.537951f,0.4831604f,-0.6545346f,-0.2081898f,-0.2499839f,0.6824585f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 16.07642f);
Get(0x6E70).SetLocalPose(-0.1237708f,1.691822f,-0.4680983f,0.4194987f,-0.4692717f,-0.5286348f,0.5695175f);
Get(0x6E82).SetLocalPose(-0.3084376f,0.9316173f,-0.2939681f,-0.3692206f,0.08133082f,-0.1527951f,0.91308f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 16.07642f);
Get(0x6EC6).SetLocalPose(0.169149f,0.8297108f,-0.4867756f,-0.1265739f,-0.0204731f,-0.9911619f,0.03403063f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321574f,1.538041f,0.4831337f,-0.6545225f,-0.2082097f,-0.2499495f,0.6824766f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 16.0955f);
Get(0x6E70).SetLocalPose(-0.1267774f,1.691833f,-0.4672182f,0.419083f,-0.4682047f,-0.5268171f,0.5723788f);
Get(0x6E82).SetLocalPose(-0.2979872f,0.9039729f,-0.3142395f,-0.3161977f,0.07425514f,-0.1259199f,0.937363f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 16.0955f);
Get(0x6EC6).SetLocalPose(0.1696471f,0.8298041f,-0.487666f,-0.1273873f,-0.0220094f,-0.9909366f,0.03650608f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321626f,1.538098f,0.483097f,-0.654511f,-0.2082074f,-0.2499611f,0.682484f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 16.11516f);
Get(0x6E70).SetLocalPose(-0.129484f,1.691594f,-0.4661747f,0.4192107f,-0.4671448f,-0.5252786f,0.5745611f);
Get(0x6E82).SetLocalPose(-0.2877018f,0.8749251f,-0.3387645f,-0.2528732f,0.05138292f,-0.09567283f,0.9613854f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 16.11516f);
Get(0x6EC6).SetLocalPose(0.1699207f,0.8295993f,-0.4881267f,-0.1281479f,-0.02348239f,-0.9907148f,0.03887036f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321706f,1.538017f,0.483041f,-0.6545017f,-0.2082243f,-0.2499558f,0.6824898f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 16.1349f);
Get(0x6E70).SetLocalPose(-0.1327937f,1.691328f,-0.4652888f,0.4199593f,-0.4657775f,-0.523379f,0.5768536f);
Get(0x6E82).SetLocalPose(-0.280669f,0.8533342f,-0.359209f,-0.2019785f,0.02130163f,-0.07350345f,0.9763955f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 16.1349f);
Get(0x6EC6).SetLocalPose(0.1698484f,0.829266f,-0.4887908f,-0.1288385f,-0.02505141f,-0.990503f,0.0409495f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321519f,1.537955f,0.4830143f,-0.6544937f,-0.2082176f,-0.2499644f,0.6824963f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 16.15436f);
Get(0x6E70).SetLocalPose(-0.1356457f,1.690131f,-0.4643535f,0.4212056f,-0.464465f,-0.5214404f,0.5787557f);
Get(0x6E82).SetLocalPose(-0.275075f,0.8382002f,-0.3760432f,-0.1563712f,-0.01095938f,-0.05381202f,0.9861705f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 16.15436f);
Get(0x6EC6).SetLocalPose(0.1697308f,0.8280058f,-0.4892284f,-0.1295113f,-0.02662017f,-0.9903f,0.04270923f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321625f,1.53809f,0.4829601f,-0.6545119f,-0.2082582f,-0.2499403f,0.6824754f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 16.17373f);
Get(0x6E70).SetLocalPose(-0.1382838f,1.689767f,-0.4636028f,0.4226893f,-0.4632629f,-0.5197324f,0.580172f);
Get(0x6E82).SetLocalPose(-0.2671107f,0.8199038f,-0.3991495f,-0.08910972f,-0.05290091f,-0.0244029f,0.9943166f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 16.17373f);
Get(0x6EC6).SetLocalPose(0.1695887f,0.8286108f,-0.4887837f,-0.1297678f,-0.02773519f,-0.9901813f,0.04395461f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321586f,1.538058f,0.4831092f,-0.6544924f,-0.2082532f,-0.2499479f,0.6824927f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 16.19292f);
Get(0x6E70).SetLocalPose(-0.1415386f,1.689342f,-0.4631819f,0.424621f,-0.4619629f,-0.5179678f,0.5813749f);
Get(0x6E82).SetLocalPose(-0.2614625f,0.8105214f,-0.4138844f,-0.04288429f,-0.06984997f,-0.00197694f,0.9966334f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 16.19292f);
Get(0x6EC6).SetLocalPose(0.1706356f,0.8294299f,-0.4881918f,-0.1286334f,-0.02903267f,-0.9902555f,0.04477526f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321515f,1.538107f,0.4830914f,-0.6544982f,-0.2082417f,-0.2499575f,0.6824872f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 16.21233f);
Get(0x6E70).SetLocalPose(-0.1447771f,1.688433f,-0.4623645f,0.4267309f,-0.4607544f,-0.5160442f,0.5824985f);
Get(0x6E82).SetLocalPose(-0.2523929f,0.8030789f,-0.4279601f,-0.00165351f,-0.06999267f,0.02304763f,0.9972799f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 16.21233f);
Get(0x6EC6).SetLocalPose(0.1725767f,0.8321657f,-0.4868751f,-0.1258136f,-0.0310199f,-0.9905246f,0.04549478f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321626f,1.538092f,0.4830615f,-0.6544966f,-0.2082598f,-0.2499543f,0.6824844f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 16.23133f);
Get(0x6E70).SetLocalPose(-0.1471339f,1.687991f,-0.4618036f,0.4280859f,-0.4600197f,-0.5145676f,0.5833906f);
Get(0x6E82).SetLocalPose(-0.2445224f,0.7985978f,-0.4370908f,0.02451257f,-0.06112718f,0.04199485f,0.9969449f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 16.23133f);
Get(0x6EC6).SetLocalPose(0.1767708f,0.8341338f,-0.4849351f,-0.1241714f,-0.03563599f,-0.9904231f,0.04872184f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32144f,1.538243f,0.483088f,-0.6545143f,-0.2082234f,-0.2499682f,0.6824734f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 16.26f);
Get(0x6E70).SetLocalPose(-0.1510616f,1.687402f,-0.4603882f,0.4295003f,-0.459547f,-0.5113052f,0.5855878f);
Get(0x6E82).SetLocalPose(-0.2451248f,0.7963389f,-0.4395165f,0.04059537f,-0.09369772f,0.06267185f,0.9927966f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 16.26f);
Get(0x6EC6).SetLocalPose(0.1867197f,0.8377487f,-0.4806009f,-0.1366956f,-0.04845065f,-0.9875889f,0.06029175f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321407f,1.538181f,0.4831678f,-0.6545095f,-0.2082332f,-0.2499746f,0.6824727f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 16.27959f);
Get(0x6E70).SetLocalPose(-0.1532856f,1.687553f,-0.4595631f,0.4297775f,-0.4595769f,-0.5091123f,0.5872691f);
Get(0x6E82).SetLocalPose(-0.249411f,0.798358f,-0.4343675f,0.02072902f,-0.1060093f,0.05476608f,0.9926394f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 16.27959f);
Get(0x6EC6).SetLocalPose(0.1979987f,0.8422323f,-0.476142f,-0.1614249f,-0.06272367f,-0.9822966f,0.07142282f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321338f,1.537978f,0.4832273f,-0.6545245f,-0.2082015f,-0.2499619f,0.6824726f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 16.29987f);
Get(0x6E70).SetLocalPose(-0.1555803f,1.687211f,-0.4586769f,0.4301847f,-0.4593697f,-0.5068555f,0.5890825f);
Get(0x6E82).SetLocalPose(-0.2516569f,0.8007188f,-0.430627f,0.001391777f,-0.09728428f,0.04846916f,0.9940748f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 16.29987f);
Get(0x6EC6).SetLocalPose(0.2127939f,0.8459419f,-0.4716511f,-0.1977912f,-0.08019869f,-0.9734558f,0.08264747f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321299f,1.537976f,0.4831976f,-0.6545092f,-0.2081864f,-0.2499829f,0.6824843f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 16.30957f);
Get(0x6E70).SetLocalPose(-0.1573605f,1.687048f,-0.4579785f,0.4309743f,-0.4587331f,-0.5056628f,0.5900256f);
Get(0x6E82).SetLocalPose(-0.2522089f,0.8031651f,-0.4293206f,-0.009306563f,-0.08266784f,0.04739939f,0.9954059f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 16.30957f);
Get(0x6EC6).SetLocalPose(0.2252192f,0.8507803f,-0.4685908f,-0.2275015f,-0.09232676f,-0.9652181f,0.08985004f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321323f,1.537929f,0.4831897f,-0.6545192f,-0.2082129f,-0.2499531f,0.6824775f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 16.33951f);
Get(0x6E70).SetLocalPose(-0.1594218f,1.68613f,-0.4567112f,0.4333885f,-0.4566577f,-0.5048009f,0.5906049f);
Get(0x6E82).SetLocalPose(-0.2528331f,0.809505f,-0.4250349f,-0.03046727f,-0.0310845f,0.04675495f,0.9979577f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 16.33951f);
Get(0x6EC6).SetLocalPose(0.2529082f,0.8601258f,-0.4628037f,-0.2862029f,-0.1116227f,-0.9460135f,0.1033768f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321502f,1.537964f,0.4831027f,-0.6545107f,-0.2082217f,-0.2499629f,0.6824794f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 16.35975f);
Get(0x6E70).SetLocalPose(-0.1616103f,1.684545f,-0.4555641f,0.4363494f,-0.4540614f,-0.5055068f,0.5898223f);
Get(0x6E82).SetLocalPose(-0.2531487f,0.8140496f,-0.4215779f,-0.03481673f,0.002804262f,0.04788972f,0.9982418f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 16.35975f);
Get(0x6EC6).SetLocalPose(0.2760575f,0.8692362f,-0.4593423f,-0.3299958f,-0.1252308f,-0.928573f,0.1147704f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321525f,1.537899f,0.483143f,-0.6545072f,-0.2082312f,-0.2499596f,0.6824809f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 16.37944f);
Get(0x6E70).SetLocalPose(-0.1634809f,1.683314f,-0.45494f,0.4389567f,-0.4515995f,-0.5069518f,0.5885361f);
Get(0x6E82).SetLocalPose(-0.2523658f,0.8169813f,-0.4191599f,-0.03331993f,0.02973856f,0.04719857f,0.9978867f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 16.37944f);
Get(0x6EC6).SetLocalPose(0.3000584f,0.8813669f,-0.4551255f,-0.3705315f,-0.1415692f,-0.9088562f,0.1290156f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321467f,1.538039f,0.483168f,-0.6545027f,-0.2082125f,-0.2499478f,0.6824954f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 16.39928f);
Get(0x6E70).SetLocalPose(-0.1652947f,1.68179f,-0.454538f,0.4411045f,-0.4493384f,-0.5087429f,0.5871137f);
Get(0x6E82).SetLocalPose(-0.2509806f,0.8186867f,-0.4168556f,-0.03061455f,0.04462767f,0.04642183f,0.9974549f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 16.39928f);
Get(0x6EC6).SetLocalPose(0.3229758f,0.8937187f,-0.4518487f,-0.404362f,-0.1587065f,-0.8892421f,0.14336f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321401f,1.538195f,0.483148f,-0.6544921f,-0.2082459f,-0.2499462f,0.682496f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 16.41901f);
Get(0x6E70).SetLocalPose(-0.1670474f,1.681286f,-0.454024f,0.4426872f,-0.4474204f,-0.5105592f,0.5858092f);
Get(0x6E82).SetLocalPose(-0.2494911f,0.8203068f,-0.4142285f,-0.03045542f,0.05805773f,0.04546761f,0.9968122f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 16.41901f);
Get(0x6EC6).SetLocalPose(0.3508412f,0.9120218f,-0.4490846f,-0.4400415f,-0.1827857f,-0.8639708f,0.1628108f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.3215f,1.538135f,0.4831694f,-0.6544853f,-0.2082075f,-0.2499292f,0.6825204f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 16.43902f);
Get(0x6E70).SetLocalPose(-0.1682741f,1.680578f,-0.4537536f,0.4438561f,-0.4457082f,-0.5121839f,0.5848108f);
Get(0x6E82).SetLocalPose(-0.2467726f,0.8202492f,-0.4122173f,-0.03316374f,0.07395299f,0.04300475f,0.995782f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 16.43902f);
Get(0x6EC6).SetLocalPose(0.3770695f,0.9314417f,-0.4455293f,-0.4671856f,-0.2077528f,-0.8402155f,0.1805945f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321608f,1.538109f,0.4830036f,-0.6544814f,-0.2081881f,-0.2499316f,0.6825292f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 16.45931f);
Get(0x6E70).SetLocalPose(-0.1693702f,1.680464f,-0.4533012f,0.4448085f,-0.4440396f,-0.5135653f,0.5841446f);
Get(0x6E82).SetLocalPose(-0.2436949f,0.8206118f,-0.4113929f,-0.03604447f,0.08726769f,0.03982617f,0.9947357f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 16.45931f);
Get(0x6EC6).SetLocalPose(0.4000409f,0.9511663f,-0.4431141f,-0.4887387f,-0.2329247f,-0.8176519f,0.1957702f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321465f,1.537987f,0.4830435f,-0.6544895f,-0.2081763f,-0.2499586f,0.6825151f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 16.47926f);
Get(0x6E70).SetLocalPose(-0.1707088f,1.679467f,-0.4530677f,0.445687f,-0.4420753f,-0.5151601f,0.5835604f);
Get(0x6E82).SetLocalPose(-0.2410183f,0.8201715f,-0.4098695f,-0.0376895f,0.09824029f,0.03722258f,0.9937519f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 16.47926f);
Get(0x6EC6).SetLocalPose(0.425434f,0.9762105f,-0.4408357f,-0.5120635f,-0.2641526f,-0.7891602f,0.2126986f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321651f,1.537912f,0.4830135f,-0.6544997f,-0.2081906f,-0.2499514f,0.6825036f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 16.49972f);
Get(0x6E70).SetLocalPose(-0.1716324f,1.679361f,-0.4525495f,0.4464464f,-0.4402647f,-0.5165851f,0.5830888f);
Get(0x6E82).SetLocalPose(-0.2372625f,0.817894f,-0.4073625f,-0.03785164f,0.1090239f,0.03668112f,0.9926407f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 16.49972f);
Get(0x6EC6).SetLocalPose(0.4502341f,1.00415f,-0.4395946f,-0.5353209f,-0.2964615f,-0.7570004f,0.2291124f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321635f,1.537921f,0.4829865f,-0.6545127f,-0.2081849f,-0.249941f,0.6824967f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 16.51959f);
Get(0x6E70).SetLocalPose(-0.1727261f,1.6782f,-0.4521683f,0.4474649f,-0.4377246f,-0.5187497f,0.5822981f);
Get(0x6E82).SetLocalPose(-0.2352409f,0.8164251f,-0.4058123f,-0.03643888f,0.1151035f,0.03827523f,0.9919468f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 16.51959f);
Get(0x6EC6).SetLocalPose(0.4747218f,1.037473f,-0.4394534f,-0.5587649f,-0.3320686f,-0.719069f,0.2458697f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32152f,1.537983f,0.4829178f,-0.6545057f,-0.2081777f,-0.2499483f,0.682503f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 16.53886f);
Get(0x6E70).SetLocalPose(-0.173664f,1.677992f,-0.4518915f,0.4485711f,-0.4352044f,-0.5207722f,0.5815304f);
Get(0x6E82).SetLocalPose(-0.232009f,0.8157647f,-0.4037131f,-0.03396745f,0.1190191f,0.0401317f,0.9914989f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 16.53886f);
Get(0x6EC6).SetLocalPose(0.4974425f,1.070805f,-0.4408683f,-0.5776054f,-0.3710442f,-0.6776609f,0.2635789f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321444f,1.537922f,0.4828992f,-0.6544811f,-0.2081819f,-0.2499757f,0.6825151f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 16.55819f);
Get(0x6E70).SetLocalPose(-0.1741993f,1.67669f,-0.4512118f,0.4498649f,-0.4321494f,-0.5231915f,0.5806369f);
Get(0x6E82).SetLocalPose(-0.2289697f,0.815452f,-0.4020854f,-0.03134814f,0.1215526f,0.04090195f,0.9912463f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 16.55819f);
Get(0x6EC6).SetLocalPose(0.5133785f,1.100438f,-0.4419492f,-0.5877379f,-0.4015911f,-0.6452078f,0.277481f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321269f,1.538178f,0.4829617f,-0.6545001f,-0.2081647f,-0.2499663f,0.6825057f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 16.57719f);
Get(0x6E70).SetLocalPose(-0.1749079f,1.67555f,-0.4505246f,0.4511576f,-0.428963f,-0.5257062f,0.5797247f);
Get(0x6E82).SetLocalPose(-0.2251325f,0.8163444f,-0.4008611f,-0.02914359f,0.1256311f,0.04074862f,0.9908113f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 16.57719f);
Get(0x6EC6).SetLocalPose(0.5312147f,1.140313f,-0.4444847f,-0.5961084f,-0.4392908f,-0.6044219f,0.2938581f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321422f,1.538044f,0.4828469f,-0.6545021f,-0.2081567f,-0.2499718f,0.6825042f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 16.59673f);
Get(0x6E70).SetLocalPose(-0.1753298f,1.674231f,-0.4497581f,0.4524212f,-0.4257735f,-0.5282302f,0.5787961f);
Get(0x6E82).SetLocalPose(-0.2223461f,0.8156763f,-0.400391f,-0.02853005f,0.13113f,0.03980601f,0.9901547f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 16.59673f);
Get(0x6EC6).SetLocalPose(0.5446811f,1.176374f,-0.4474457f,-0.5989697f,-0.4719897f,-0.5691026f,0.3075441f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321493f,1.537933f,0.4829346f,-0.6544967f,-0.2081691f,-0.2499712f,0.6825058f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 16.61673f);
Get(0x6E70).SetLocalPose(-0.1755757f,1.67337f,-0.4489049f,0.4534872f,-0.4228299f,-0.5305149f,0.5780296f);
Get(0x6E82).SetLocalPose(-0.2195266f,0.8158533f,-0.4004287f,-0.0287519f,0.139102f,0.0383949f,0.9891157f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 16.61673f);
Get(0x6EC6).SetLocalPose(0.555539f,1.216416f,-0.4518816f,-0.5919756f,-0.5076926f,-0.5315621f,0.3305372f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321459f,1.537844f,0.4828834f,-0.6545215f,-0.2081862f,-0.2499665f,0.6824785f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 16.63643f);
Get(0x6E70).SetLocalPose(-0.1758599f,1.672658f,-0.4482035f,0.4546337f,-0.4196959f,-0.5327776f,0.5773315f);
Get(0x6E82).SetLocalPose(-0.2166372f,0.8154954f,-0.4003429f,-0.02893566f,0.1473234f,0.03695535f,0.9879742f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 16.63643f);
Get(0x6EC6).SetLocalPose(0.5621805f,1.256314f,-0.4560164f,-0.575951f,-0.5410154f,-0.4934637f,0.3634231f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321337f,1.537946f,0.4830241f,-0.6544951f,-0.2081819f,-0.2499413f,0.6825143f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 16.65767f);
Get(0x6E70).SetLocalPose(-0.175884f,1.671223f,-0.447102f,0.4561803f,-0.4157728f,-0.5353749f,0.5765468f);
Get(0x6E82).SetLocalPose(-0.2138855f,0.8166855f,-0.3995717f,-0.02823356f,0.1552889f,0.03651135f,0.9867903f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 16.65767f);
Get(0x6EC6).SetLocalPose(0.5658899f,1.306124f,-0.462353f,-0.5523202f,-0.5798392f,-0.4435915f,0.4024371f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321275f,1.537924f,0.482981f,-0.654493f,-0.2082257f,-0.2499559f,0.6824977f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 16.67746f);
Get(0x6E70).SetLocalPose(-0.1763723f,1.670294f,-0.4461088f,0.4576755f,-0.4123609f,-0.5373765f,0.5759497f);
Get(0x6E82).SetLocalPose(-0.2113388f,0.8177492f,-0.3990633f,-0.02699021f,0.1623222f,0.03686535f,0.9856795f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 16.67746f);
Get(0x6EC6).SetLocalPose(0.5647602f,1.347405f,-0.4692174f,-0.5329248f,-0.6129739f,-0.3967755f,0.4275785f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321276f,1.538004f,0.4831079f,-0.6545075f,-0.2081694f,-0.2499732f,0.6824946f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 16.69726f);
Get(0x6E70).SetLocalPose(-0.1765118f,1.668911f,-0.4448892f,0.4593486f,-0.4091396f,-0.538883f,0.5755075f);
Get(0x6E82).SetLocalPose(-0.2104492f,0.8175303f,-0.3979947f,-0.02641586f,0.1685418f,0.03719728f,0.9846382f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 16.69726f);
Get(0x6EC6).SetLocalPose(0.5583767f,1.392316f,-0.4774553f,-0.5084812f,-0.6492141f,-0.3479764f,0.4459601f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321301f,1.538088f,0.4832401f,-0.6545133f,-0.208185f,-0.2499517f,0.6824921f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 16.71691f);
Get(0x6E70).SetLocalPose(-0.1774318f,1.667948f,-0.4433851f,0.4607988f,-0.4068734f,-0.5395899f,0.5752924f);
Get(0x6E82).SetLocalPose(-0.2096976f,0.8183557f,-0.3972547f,-0.0262601f,0.1745924f,0.03714561f,0.9835894f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 16.71691f);
Get(0x6EC6).SetLocalPose(0.5483534f,1.428401f,-0.485086f,-0.4841912f,-0.6769206f,-0.3088045f,0.4604098f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321343f,1.538181f,0.4832726f,-0.6545221f,-0.2081805f,-0.2499606f,0.6824818f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 16.73653f);
Get(0x6E70).SetLocalPose(-0.1778381f,1.667304f,-0.4425181f,0.4621872f,-0.4052845f,-0.5397927f,0.5751099f);
Get(0x6E82).SetLocalPose(-0.2097505f,0.818261f,-0.397337f,-0.0267997f,0.1792935f,0.03666442f,0.9827468f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 16.73653f);
Get(0x6EC6).SetLocalPose(0.5288845f,1.475029f,-0.4954802f,-0.4468542f,-0.7132835f,-0.2556946f,0.4755714f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321391f,1.538169f,0.4832566f,-0.65453f,-0.2081911f,-0.2499561f,0.6824726f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 16.75575f);
Get(0x6E70).SetLocalPose(-0.1787532f,1.667179f,-0.4414627f,0.4636764f,-0.4040251f,-0.5395017f,0.5750703f);
Get(0x6E82).SetLocalPose(-0.2099231f,0.8181137f,-0.3971296f,-0.02771156f,0.1809572f,0.0364329f,0.9824252f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 16.75575f);
Get(0x6EC6).SetLocalPose(0.5100639f,1.506418f,-0.5037842f,-0.4170875f,-0.7398747f,-0.2179651f,0.4807438f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321532f,1.538141f,0.4831616f,-0.6545279f,-0.2081871f,-0.2499618f,0.6824738f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 16.77493f);
Get(0x6E70).SetLocalPose(-0.1790157f,1.667572f,-0.4406792f,0.4649402f,-0.4033819f,-0.538599f,0.5753477f);
Get(0x6E82).SetLocalPose(-0.2101565f,0.8185639f,-0.3972088f,-0.02919873f,0.1813792f,0.03609705f,0.9823167f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 16.77493f);
Get(0x6EC6).SetLocalPose(0.4843408f,1.538132f,-0.5131739f,-0.3789456f,-0.7689685f,-0.1722734f,0.4851904f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321595f,1.538102f,0.4832127f,-0.654528f,-0.2082316f,-0.2499444f,0.6824666f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 16.7947f);
Get(0x6E70).SetLocalPose(-0.1793381f,1.667364f,-0.4400989f,0.465826f,-0.4030997f,-0.5371599f,0.5761737f);
Get(0x6E82).SetLocalPose(-0.2113271f,0.8186274f,-0.3963136f,-0.03093011f,0.1807973f,0.03561508f,0.9823886f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 16.7947f);
Get(0x6EC6).SetLocalPose(0.4510134f,1.56759f,-0.5231885f,-0.3329602f,-0.7970171f,-0.1214356f,0.4890344f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321615f,1.538084f,0.4830217f,-0.6545192f,-0.2082081f,-0.2499634f,0.6824751f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 16.81566f);
Get(0x6E70).SetLocalPose(-0.179282f,1.667802f,-0.4393268f,0.4665831f,-0.402846f,-0.5351694f,0.577589f);
Get(0x6E82).SetLocalPose(-0.2114246f,0.8175657f,-0.3958785f,-0.03192712f,0.1799202f,0.0351929f,0.9825329f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 16.81566f);
Get(0x6EC6).SetLocalPose(0.4135584f,1.592733f,-0.5327718f,-0.2778087f,-0.8232033f,-0.06731067f,0.4905383f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321589f,1.538107f,0.4830099f,-0.6545228f,-0.2082223f,-0.2499468f,0.6824735f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 16.83537f);
Get(0x6E70).SetLocalPose(-0.1793151f,1.668066f,-0.4383986f,0.4673034f,-0.402692f,-0.5333781f,0.5787699f);
Get(0x6E82).SetLocalPose(-0.211782f,0.8172349f,-0.3958242f,-0.0319338f,0.1789429f,0.03453385f,0.9827345f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 16.83537f);
Get(0x6EC6).SetLocalPose(0.3745923f,1.610569f,-0.5412709f,-0.2199691f,-0.8462774f,-0.01800712f,0.4848752f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321637f,1.537994f,0.4830198f,-0.6545021f,-0.2082366f,-0.2499434f,0.6824903f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 16.85534f);
Get(0x6E70).SetLocalPose(-0.1788798f,1.667918f,-0.4384706f,0.4682235f,-0.4024631f,-0.5318763f,0.579567f);
Get(0x6E82).SetLocalPose(-0.2121285f,0.8174927f,-0.3959783f,-0.03151875f,0.1781195f,0.03386071f,0.9829209f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 16.85534f);
Get(0x6EC6).SetLocalPose(0.3457838f,1.619303f,-0.5470721f,-0.1777402f,-0.8607941f,0.01555558f,0.476655f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321653f,1.53793f,0.483077f,-0.6545089f,-0.2082386f,-0.2499262f,0.6824893f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 16.87444f);
Get(0x6E70).SetLocalPose(-0.1780485f,1.667799f,-0.438452f,0.4691122f,-0.4023246f,-0.5306541f,0.5800646f);
Get(0x6E82).SetLocalPose(-0.2121717f,0.816848f,-0.3961386f,-0.03062242f,0.1771225f,0.03352885f,0.9831407f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 16.87444f);
Get(0x6EC6).SetLocalPose(0.3116471f,1.627354f,-0.5529656f,-0.1253672f,-0.8755487f,0.05373123f,0.4634766f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321659f,1.537865f,0.4831096f,-0.6545122f,-0.2082321f,-0.2499485f,0.68248f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 16.89373f);
Get(0x6E70).SetLocalPose(-0.1778676f,1.667589f,-0.4386654f,0.4694929f,-0.4022685f,-0.5299722f,0.5804188f);
Get(0x6E82).SetLocalPose(-0.2118533f,0.8171819f,-0.3962422f,-0.0288432f,0.1755752f,0.03384368f,0.9834613f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 16.89373f);
Get(0x6EC6).SetLocalPose(0.2787777f,1.627225f,-0.5578223f,-0.07378756f,-0.8869197f,0.08758035f,0.4475025f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32147f,1.537935f,0.4832285f,-0.6545123f,-0.2082199f,-0.2499466f,0.6824844f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 16.91356f);
Get(0x6E70).SetLocalPose(-0.1776413f,1.667634f,-0.4388331f,0.4695785f,-0.4021419f,-0.5293415f,0.5810125f);
Get(0x6E82).SetLocalPose(-0.2110628f,0.8173991f,-0.3960565f,-0.0267111f,0.1738034f,0.03474674f,0.9838047f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 16.91356f);
Get(0x6EC6).SetLocalPose(0.2470641f,1.62234f,-0.5628275f,-0.02068062f,-0.8947926f,0.1190393f,0.4298236f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321365f,1.538004f,0.4833117f,-0.654525f,-0.2082167f,-0.2499689f,0.682465f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 16.93362f);
Get(0x6E70).SetLocalPose(-0.1771937f,1.667871f,-0.4393276f,0.4694335f,-0.4020295f,-0.5288093f,0.5816917f);
Get(0x6E82).SetLocalPose(-0.2097863f,0.8166924f,-0.3960995f,-0.0251106f,0.1722894f,0.03544352f,0.9840882f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 16.93362f);
Get(0x6EC6).SetLocalPose(0.2223504f,1.613566f,-0.5675073f,0.03267267f,-0.8986608f,0.1526465f,0.4099275f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321368f,1.53788f,0.4833761f,-0.6545202f,-0.2082075f,-0.2499612f,0.6824752f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 16.95354f);
Get(0x6E70).SetLocalPose(-0.1766885f,1.667747f,-0.4395868f,0.4691696f,-0.4021022f,-0.5284401f,0.5821897f);
Get(0x6E82).SetLocalPose(-0.209011f,0.8169163f,-0.3962445f,-0.02475294f,0.1720423f,0.03577102f,0.9841287f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 16.95354f);
Get(0x6EC6).SetLocalPose(0.2064748f,1.604436f,-0.5722325f,0.07975818f,-0.8971281f,0.1907486f,0.3904034f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321235f,1.537992f,0.4833705f,-0.6545224f,-0.2082027f,-0.2499749f,0.6824695f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 16.97264f);
Get(0x6E70).SetLocalPose(-0.1766809f,1.668483f,-0.4397646f,0.4687458f,-0.4023327f,-0.528433f,0.5823782f);
Get(0x6E82).SetLocalPose(-0.2075427f,0.8166358f,-0.3959288f,-0.02541674f,0.1732834f,0.03561248f,0.9838997f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 16.97264f);
Get(0x6EC6).SetLocalPose(0.1980801f,1.595938f,-0.5747619f,0.112984f,-0.8895413f,0.2303464f,0.3780099f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321358f,1.537984f,0.4832797f,-0.6545125f,-0.2082022f,-0.2499677f,0.6824818f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 16.99197f);
Get(0x6E70).SetLocalPose(-0.1767024f,1.667789f,-0.4404149f,0.4678328f,-0.4028409f,-0.5289878f,0.5822573f);
Get(0x6E82).SetLocalPose(-0.2059557f,0.8172815f,-0.395369f,-0.02644343f,0.1760036f,0.03556703f,0.9833913f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 16.99197f);
Get(0x6EC6).SetLocalPose(0.1979436f,1.590946f,-0.5741617f,0.1258146f,-0.8808789f,0.2631938f,0.3727627f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321476f,1.53791f,0.4830867f,-0.6545309f,-0.2082214f,-0.2499674f,0.6824584f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 17.01175f);
Get(0x6E70).SetLocalPose(-0.1771822f,1.667765f,-0.4411116f,0.4668022f,-0.4032978f,-0.5296478f,0.5821682f);
Get(0x6E82).SetLocalPose(-0.2042127f,0.817101f,-0.3954304f,-0.02726257f,0.179757f,0.03594899f,0.9826759f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 17.01175f);
Get(0x6EC6).SetLocalPose(0.2049961f,1.590145f,-0.5716195f,0.1160716f,-0.8748806f,0.2833401f,0.3752729f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32147f,1.537984f,0.4830959f,-0.6545432f,-0.2082481f,-0.2499757f,0.6824355f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 17.03158f);
Get(0x6E70).SetLocalPose(-0.1786983f,1.667941f,-0.4414496f,0.4657537f,-0.4037826f,-0.5300438f,0.5823115f);
Get(0x6E82).SetLocalPose(-0.202696f,0.8173611f,-0.3949778f,-0.02778941f,0.1837413f,0.03631125f,0.9819106f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 17.03158f);
Get(0x6EC6).SetLocalPose(0.2154863f,1.596229f,-0.5663843f,0.08534475f,-0.8747997f,0.2844778f,0.3827718f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321525f,1.537946f,0.4831339f,-0.6545203f,-0.2082397f,-0.2499613f,0.6824653f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 17.04066f);
Get(0x6E70).SetLocalPose(-0.1788148f,1.667531f,-0.4416754f,0.4653397f,-0.4040076f,-0.5300547f,0.5824765f);
Get(0x6E82).SetLocalPose(-0.2020708f,0.8177807f,-0.3957894f,-0.02816329f,0.1859813f,0.03637533f,0.9814758f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 17.04066f);
Get(0x6EC6).SetLocalPose(0.220777f,1.598915f,-0.564719f,0.06638941f,-0.8754635f,0.2816794f,0.3870566f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321486f,1.537911f,0.4831668f,-0.6545092f,-0.2082024f,-0.2499583f,0.6824883f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 17.07159f);
Get(0x6E70).SetLocalPose(-0.1792458f,1.667246f,-0.44242f,0.4645531f,-0.404451f,-0.529539f,0.5832652f);
Get(0x6E82).SetLocalPose(-0.2010578f,0.818365f,-0.3948486f,-0.02989178f,0.1921901f,0.03624899f,0.9802324f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 17.07159f);
Get(0x6EC6).SetLocalPose(0.25002f,1.603919f,-0.5634264f,-0.02509784f,-0.8750234f,0.2623447f,0.4060534f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321415f,1.537954f,0.4831233f,-0.6545076f,-0.2082197f,-0.2499705f,0.6824801f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 17.09129f);
Get(0x6E70).SetLocalPose(-0.179524f,1.668311f,-0.4425396f,0.4644157f,-0.404643f,-0.5289983f,0.5837319f);
Get(0x6E82).SetLocalPose(-0.200522f,0.8183882f,-0.3938153f,-0.03067525f,0.1954148f,0.03604794f,0.9795778f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 17.09129f);
Get(0x6EC6).SetLocalPose(0.2747672f,1.612369f,-0.5603036f,-0.1052175f,-0.8711869f,0.2338802f,0.4186438f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321437f,1.538013f,0.4831426f,-0.6545032f,-0.2082083f,-0.2499727f,0.682487f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 17.11109f);
Get(0x6E70).SetLocalPose(-0.1802222f,1.667886f,-0.4429844f,0.4645019f,-0.4047287f,-0.5285625f,0.5839987f);
Get(0x6E82).SetLocalPose(-0.2001639f,0.819217f,-0.3939303f,-0.03052721f,0.1977296f,0.03620618f,0.979112f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 17.11109f);
Get(0x6EC6).SetLocalPose(0.2968493f,1.617864f,-0.5616521f,-0.172896f,-0.8716366f,0.1911709f,0.4169056f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321494f,1.537985f,0.4831614f,-0.6545056f,-0.2081858f,-0.2499789f,0.6824894f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 17.13937f);
Get(0x6E70).SetLocalPose(-0.181118f,1.66849f,-0.4437138f,0.4649335f,-0.4046356f,-0.5286415f,0.5836481f);
Get(0x6E82).SetLocalPose(-0.199683f,0.8195031f,-0.3935731f,-0.02928941f,0.2012305f,0.03662039f,0.9784209f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 17.13937f);
Get(0x6EC6).SetLocalPose(0.3338754f,1.622254f,-0.5628953f,-0.2575114f,-0.8710495f,0.1234593f,0.399648f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321359f,1.538009f,0.4831661f,-0.654516f,-0.2081851f,-0.2499785f,0.6824797f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 17.1591f);
Get(0x6E70).SetLocalPose(-0.1808227f,1.668578f,-0.4444516f,0.4653491f,-0.4044996f,-0.5292125f,0.5828931f);
Get(0x6E82).SetLocalPose(-0.1998065f,0.8188755f,-0.3930501f,-0.02862625f,0.2039151f,0.03680581f,0.9778776f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 17.1591f);
Get(0x6EC6).SetLocalPose(0.3592011f,1.626098f,-0.5637591f,-0.3258336f,-0.8638467f,0.05642274f,0.3800236f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321303f,1.537951f,0.4831404f,-0.6545168f,-0.2081859f,-0.2499796f,0.6824783f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 17.17825f);
Get(0x6E70).SetLocalPose(-0.181283f,1.668092f,-0.4447895f,0.4660437f,-0.4041406f,-0.5297863f,0.5820655f);
Get(0x6E82).SetLocalPose(-0.1998032f,0.8183192f,-0.3924356f,-0.02802296f,0.2061f,0.03677969f,0.9774379f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 17.17825f);
Get(0x6EC6).SetLocalPose(0.3781699f,1.630218f,-0.5647065f,-0.3838707f,-0.8495996f,-0.02346805f,0.3609336f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321325f,1.538074f,0.4830272f,-0.6545018f,-0.2081873f,-0.2499868f,0.6824896f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 17.19719f);
Get(0x6E70).SetLocalPose(-0.1815283f,1.667213f,-0.4454822f,0.4671158f,-0.4036212f,-0.5297062f,0.5816392f);
Get(0x6E82).SetLocalPose(-0.200206f,0.8182833f,-0.3921401f,-0.02763504f,0.208316f,0.03651905f,0.9769889f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 17.19719f);
Get(0x6EC6).SetLocalPose(0.3892168f,1.633175f,-0.5649469f,-0.4073317f,-0.8412459f,-0.0944273f,0.3427385f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32146f,1.538117f,0.482927f,-0.6544958f,-0.2082076f,-0.2499491f,0.682503f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 17.21709f);
Get(0x6E70).SetLocalPose(-0.1813404f,1.66674f,-0.4456085f,0.4686367f,-0.4032236f,-0.5288969f,0.5814281f);
Get(0x6E82).SetLocalPose(-0.200598f,0.8181801f,-0.3920743f,-0.0279632f,0.2111738f,0.03610116f,0.9763813f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 17.21709f);
Get(0x6EC6).SetLocalPose(0.384839f,1.630984f,-0.5678863f,-0.3984117f,-0.8471195f,-0.09895156f,0.3374393f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321446f,1.538042f,0.4829544f,-0.6545069f,-0.2082006f,-0.2499692f,0.6824872f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 17.23568f);
Get(0x6E70).SetLocalPose(-0.1805398f,1.666121f,-0.4457026f,0.4696167f,-0.4032277f,-0.528205f,0.5812634f);
Get(0x6E82).SetLocalPose(-0.2010036f,0.8186554f,-0.3911655f,-0.02893689f,0.2140112f,0.03638829f,0.9757243f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 17.23568f);
Get(0x6EC6).SetLocalPose(0.3727865f,1.629769f,-0.5694284f,-0.370832f,-0.85501f,-0.08236767f,0.3530684f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321433f,1.538142f,0.4829709f,-0.6545242f,-0.2081849f,-0.2499753f,0.6824732f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 17.25505f);
Get(0x6E70).SetLocalPose(-0.1796383f,1.665962f,-0.4458354f,0.4706902f,-0.4032301f,-0.5273661f,0.581155f);
Get(0x6E82).SetLocalPose(-0.2012384f,0.8190155f,-0.3903025f,-0.03041288f,0.2179271f,0.03678791f,0.9747972f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 17.25505f);
Get(0x6EC6).SetLocalPose(0.3524298f,1.627555f,-0.5703672f,-0.3244506f,-0.8630047f,-0.04317297f,0.3848259f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321371f,1.538133f,0.4830426f,-0.6545149f,-0.2081977f,-0.2499695f,0.6824802f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 17.27411f);
Get(0x6E70).SetLocalPose(-0.1783947f,1.665714f,-0.4456531f,0.4723343f,-0.403066f,-0.5263845f,0.5808248f);
Get(0x6E82).SetLocalPose(-0.2011688f,0.8197439f,-0.3898386f,-0.03089432f,0.2199243f,0.03664077f,0.9743389f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 17.27411f);
Get(0x6EC6).SetLocalPose(0.3307535f,1.624971f,-0.5730963f,-0.2731847f,-0.8736108f,0.001692684f,0.4027051f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321279f,1.538187f,0.4831242f,-0.6545224f,-0.2081998f,-0.2499759f,0.68247f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 17.294f);
Get(0x6E70).SetLocalPose(-0.177601f,1.665403f,-0.4455584f,0.4737304f,-0.4031439f,-0.5259797f,0.5799998f);
Get(0x6E82).SetLocalPose(-0.2007742f,0.8206466f,-0.3895772f,-0.03085306f,0.221257f,0.03643649f,0.9740462f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 17.294f);
Get(0x6EC6).SetLocalPose(0.3036938f,1.61936f,-0.5767772f,-0.1986798f,-0.887067f,0.07091794f,0.4106204f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321388f,1.538074f,0.4830372f,-0.6545107f,-0.2082108f,-0.2499625f,0.6824829f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 17.31346f);
Get(0x6E70).SetLocalPose(-0.1762664f,1.666067f,-0.4454881f,0.474916f,-0.403423f,-0.5263333f,0.5785137f);
Get(0x6E82).SetLocalPose(-0.2002852f,0.8215973f,-0.3894896f,-0.03073314f,0.222652f,0.03639644f,0.9737335f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 17.31346f);
Get(0x6EC6).SetLocalPose(0.2826406f,1.611645f,-0.5792892f,-0.1316504f,-0.8930364f,0.1364101f,0.4081011f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321236f,1.538149f,0.4832688f,-0.6545278f,-0.2082039f,-0.2499489f,0.6824735f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 17.33315f);
Get(0x6E70).SetLocalPose(-0.1748869f,1.666446f,-0.445689f,0.4759109f,-0.403744f,-0.5270582f,0.5768096f);
Get(0x6E82).SetLocalPose(-0.2000936f,0.8220028f,-0.3899766f,-0.03018807f,0.2244389f,0.03670086f,0.9733288f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 17.33315f);
Get(0x6EC6).SetLocalPose(0.2608113f,1.601097f,-0.5826142f,-0.0528932f,-0.8902288f,0.2124388f,0.3994556f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321307f,1.538087f,0.4832576f,-0.6545147f,-0.2081917f,-0.2499489f,0.6824898f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 17.35212f);
Get(0x6E70).SetLocalPose(-0.1734861f,1.666774f,-0.4460178f,0.4768247f,-0.4042437f,-0.5275793f,0.5752262f);
Get(0x6E82).SetLocalPose(-0.1997722f,0.8224643f,-0.3905649f,-0.02965395f,0.2259158f,0.03695718f,0.9729939f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 17.35212f);
Get(0x6EC6).SetLocalPose(0.2437297f,1.589055f,-0.5840868f,0.02194953f,-0.8751934f,0.2894387f,0.3870141f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321285f,1.537938f,0.4831806f,-0.6545194f,-0.2081859f,-0.2499469f,0.6824877f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 17.37163f);
Get(0x6E70).SetLocalPose(-0.1724352f,1.667375f,-0.4466336f,0.4772363f,-0.4051591f,-0.5279335f,0.5739145f);
Get(0x6E82).SetLocalPose(-0.1992331f,0.8242843f,-0.3912382f,-0.02914184f,0.2277451f,0.0368927f,0.9725852f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 17.37163f);
Get(0x6EC6).SetLocalPose(0.230791f,1.578797f,-0.5850411f,0.07950123f,-0.8525475f,0.3557922f,0.3745054f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32134f,1.53786f,0.483181f,-0.6545108f,-0.2081726f,-0.2499467f,0.6825002f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 17.39094f);
Get(0x6E70).SetLocalPose(-0.1712065f,1.66724f,-0.4469824f,0.477052f,-0.4062638f,-0.5280941f,0.5731386f);
Get(0x6E82).SetLocalPose(-0.1990192f,0.8248802f,-0.391912f,-0.02858673f,0.229711f,0.03636243f,0.9721592f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 17.39094f);
Get(0x6EC6).SetLocalPose(0.2220375f,1.571096f,-0.5844718f,0.116805f,-0.8304105f,0.4054256f,0.3638753f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321274f,1.537879f,0.483152f,-0.6545106f,-0.2081845f,-0.2499689f,0.6824886f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 17.41085f);
Get(0x6E70).SetLocalPose(-0.1697883f,1.667349f,-0.4474135f,0.4766079f,-0.4074193f,-0.5279208f,0.5728473f);
Get(0x6E82).SetLocalPose(-0.1983426f,0.8257071f,-0.3923194f,-0.02827512f,0.2314877f,0.0359191f,0.9717633f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 17.41085f);
Get(0x6EC6).SetLocalPose(0.2168911f,1.569422f,-0.5834085f,0.1321976f,-0.8195247f,0.4277533f,0.3576735f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321527f,1.537934f,0.4829716f,-0.6545328f,-0.2082159f,-0.2499567f,0.6824622f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 17.43936f);
Get(0x6E70).SetLocalPose(-0.1689984f,1.66714f,-0.4482844f,0.4754642f,-0.4091215f,-0.5274888f,0.5729825f);
Get(0x6E82).SetLocalPose(-0.1980013f,0.825612f,-0.3932468f,-0.02817872f,0.2329592f,0.03542058f,0.9714326f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 17.43936f);
Get(0x6EC6).SetLocalPose(0.2181812f,1.574269f,-0.5820373f,0.1260885f,-0.8263202f,0.4248472f,0.3475648f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32167f,1.537842f,0.4830477f,-0.6545321f,-0.2081974f,-0.2499727f,0.6824626f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 17.45824f);
Get(0x6E70).SetLocalPose(-0.1688669f,1.667683f,-0.4485007f,0.4745571f,-0.4101302f,-0.5274926f,0.57301f);
Get(0x6E82).SetLocalPose(-0.1981441f,0.8252198f,-0.3933504f,-0.02810399f,0.2324913f,0.03493089f,0.9715646f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 17.45824f);
Get(0x6EC6).SetLocalPose(0.2220087f,1.580505f,-0.582099f,0.1093905f,-0.8342128f,0.4188361f,0.3416126f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321528f,1.537928f,0.4832143f,-0.6545264f,-0.2082295f,-0.2499672f,0.6824603f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 17.47743f);
Get(0x6E70).SetLocalPose(-0.1684785f,1.668005f,-0.4490151f,0.47335f,-0.4110006f,-0.5280678f,0.5728549f);
Get(0x6E82).SetLocalPose(-0.1984932f,0.824859f,-0.3935793f,-0.02824061f,0.2316533f,0.03464435f,0.9717711f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 17.47743f);
Get(0x6EC6).SetLocalPose(0.2334439f,1.584476f,-0.583055f,0.08533658f,-0.8434835f,0.4070589f,0.3399359f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321434f,1.538077f,0.4833542f,-0.6545284f,-0.2082437f,-0.2499882f,0.6824464f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 17.49661f);
Get(0x6E70).SetLocalPose(-0.1682003f,1.668704f,-0.449167f,0.4721147f,-0.4114496f,-0.5290064f,0.5726859f);
Get(0x6E82).SetLocalPose(-0.1987135f,0.8239393f,-0.3935289f,-0.02837694f,0.2309756f,0.03445248f,0.9719352f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 17.49661f);
Get(0x6EC6).SetLocalPose(0.2474179f,1.591434f,-0.5809718f,0.05543181f,-0.851674f,0.3892286f,0.3465254f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321424f,1.538126f,0.4831906f,-0.6545356f,-0.2082284f,-0.2499843f,0.6824456f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 17.51606f);
Get(0x6E70).SetLocalPose(-0.1681452f,1.668105f,-0.4495164f,0.4710782f,-0.4116794f,-0.529744f,0.5726926f);
Get(0x6E82).SetLocalPose(-0.1991601f,0.8232665f,-0.3936518f,-0.02821192f,0.2303307f,0.03448552f,0.9720919f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 17.51606f);
Get(0x6EC6).SetLocalPose(0.2592484f,1.587083f,-0.5749287f,0.01756768f,-0.8587102f,0.3656654f,0.3586041f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321476f,1.538046f,0.4830849f,-0.654515f,-0.2082153f,-0.2499674f,0.6824756f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 17.53509f);
Get(0x6E70).SetLocalPose(-0.1685201f,1.668582f,-0.4496339f,0.4702614f,-0.4117916f,-0.530206f,0.5728555f);
Get(0x6E82).SetLocalPose(-0.1996525f,0.8229792f,-0.3942491f,-0.02801205f,0.2296749f,0.03476216f,0.972243f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 17.53509f);
Get(0x6EC6).SetLocalPose(0.2725661f,1.588357f,-0.5727884f,-0.02917527f,-0.8654278f,0.3364451f,0.3701193f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321384f,1.537907f,0.4832425f,-0.65452f,-0.2082152f,-0.2499982f,0.6824594f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 17.5544f);
Get(0x6E70).SetLocalPose(-0.1690958f,1.668858f,-0.4497454f,0.4693552f,-0.4119389f,-0.5305454f,0.5731787f);
Get(0x6E82).SetLocalPose(-0.199967f,0.8231986f,-0.3941533f,-0.02818753f,0.2288409f,0.03557784f,0.9724051f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 17.5544f);
Get(0x6EC6).SetLocalPose(0.2922925f,1.595379f,-0.567879f,-0.1104905f,-0.8712957f,0.2836602f,0.3849318f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321382f,1.538108f,0.483211f,-0.6545177f,-0.2082037f,-0.2499659f,0.682477f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 17.57417f);
Get(0x6E70).SetLocalPose(-0.1691862f,1.668744f,-0.4498318f,0.468661f,-0.4119479f,-0.5307994f,0.5735049f);
Get(0x6E82).SetLocalPose(-0.2001844f,0.8241276f,-0.3941427f,-0.02858916f,0.2280077f,0.03642843f,0.9725575f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 17.57417f);
Get(0x6EC6).SetLocalPose(0.3124558f,1.611644f,-0.5599185f,-0.2001723f,-0.8772643f,0.2118106f,0.3814115f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321381f,1.538035f,0.4832534f,-0.6545415f,-0.2081911f,-0.2499698f,0.6824566f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 17.59341f);
Get(0x6E70).SetLocalPose(-0.1695006f,1.668626f,-0.4496868f,0.4679795f,-0.4120239f,-0.5312222f,0.5736153f);
Get(0x6E82).SetLocalPose(-0.200775f,0.8247532f,-0.394299f,-0.02874819f,0.2272502f,0.0372146f,0.9727004f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 17.59341f);
Get(0x6EC6).SetLocalPose(0.3379997f,1.618892f,-0.557826f,-0.3016719f,-0.8821011f,0.1132385f,0.3436112f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321307f,1.538025f,0.4833086f,-0.6545379f,-0.2082043f,-0.2499653f,0.6824577f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 17.61348f);
Get(0x6E70).SetLocalPose(-0.1698985f,1.668518f,-0.4498117f,0.4672888f,-0.4121992f,-0.5317861f,0.57353f);
Get(0x6E82).SetLocalPose(-0.2015194f,0.8249835f,-0.3951916f,-0.02848036f,0.2257035f,0.03862411f,0.9730134f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 17.61348f);
Get(0x6EC6).SetLocalPose(0.3601738f,1.6259f,-0.5580238f,-0.3964947f,-0.8719923f,0.009308001f,0.2869405f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321256f,1.537912f,0.4832815f,-0.6545318f,-0.2081834f,-0.2499948f,0.6824592f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 17.63352f);
Get(0x6E70).SetLocalPose(-0.1698609f,1.668788f,-0.4497807f,0.4668409f,-0.4123572f,-0.5320095f,0.5735739f);
Get(0x6E82).SetLocalPose(-0.2022636f,0.8253754f,-0.3949484f,-0.02795511f,0.2238605f,0.0400902f,0.973395f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 17.63352f);
Get(0x6EC6).SetLocalPose(0.3822404f,1.631453f,-0.5563071f,-0.4759493f,-0.836486f,-0.1151031f,0.2459977f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321275f,1.537977f,0.4832721f,-0.6545218f,-0.2082087f,-0.2499824f,0.6824656f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 17.6531f);
Get(0x6E70).SetLocalPose(-0.1695734f,1.668844f,-0.4494619f,0.4669387f,-0.4124433f,-0.531688f,0.5737306f);
Get(0x6E82).SetLocalPose(-0.2031267f,0.8255019f,-0.3946776f,-0.02749333f,0.2217346f,0.04150214f,0.9738355f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 17.6531f);
Get(0x6EC6).SetLocalPose(0.3891531f,1.634377f,-0.5516561f,-0.4886354f,-0.8134919f,-0.1970326f,0.2462611f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321253f,1.537969f,0.4833724f,-0.6545327f,-0.2082027f,-0.2499749f,0.6824597f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 17.67319f);
Get(0x6E70).SetLocalPose(-0.1693724f,1.669252f,-0.4493356f,0.4671754f,-0.412443f,-0.5315959f,0.5736235f);
Get(0x6E82).SetLocalPose(-0.2044951f,0.8246196f,-0.3948818f,-0.02646923f,0.2191304f,0.0430777f,0.9743847f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 17.67319f);
Get(0x6EC6).SetLocalPose(0.3852648f,1.634593f,-0.5474053f,-0.465456f,-0.8165502f,-0.2283858f,0.2538435f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32131f,1.537871f,0.4833268f,-0.6545465f,-0.2081814f,-0.2499958f,0.6824453f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 17.69296f);
Get(0x6E70).SetLocalPose(-0.1689443f,1.669553f,-0.4492792f,0.4673943f,-0.4121796f,-0.5321782f,0.5730943f);
Get(0x6E82).SetLocalPose(-0.2049336f,0.8242401f,-0.3947929f,-0.02392215f,0.2169115f,0.04440496f,0.9748874f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 17.69296f);
Get(0x6EC6).SetLocalPose(0.3709139f,1.632622f,-0.5465717f,-0.4353196f,-0.8307346f,-0.1935254f,0.2879666f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321286f,1.537847f,0.4832892f,-0.6545621f,-0.2081946f,-0.2499903f,0.6824283f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 17.71282f);
Get(0x6E70).SetLocalPose(-0.1684348f,1.669139f,-0.4490616f,0.4677706f,-0.4117911f,-0.5326179f,0.5726578f);
Get(0x6E82).SetLocalPose(-0.2048915f,0.8242006f,-0.3954016f,-0.02052748f,0.2152216f,0.04612252f,0.9752595f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 17.71282f);
Get(0x6EC6).SetLocalPose(0.3532643f,1.629251f,-0.5466926f,-0.3943536f,-0.8477061f,-0.1361293f,0.3276407f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321388f,1.5379f,0.4833234f,-0.6545677f,-0.2082222f,-0.2499696f,0.6824222f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 17.73274f);
Get(0x6E70).SetLocalPose(-0.1676731f,1.668669f,-0.4490006f,0.4681219f,-0.4118158f,-0.5323972f,0.5725583f);
Get(0x6E82).SetLocalPose(-0.2048638f,0.8245059f,-0.3955503f,-0.01695515f,0.2133349f,0.04800786f,0.9756516f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 17.73274f);
Get(0x6EC6).SetLocalPose(0.3321262f,1.624398f,-0.5493826f,-0.3379801f,-0.867826f,-0.07352579f,0.3567092f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321449f,1.538047f,0.4831998f,-0.6545587f,-0.208219f,-0.2499799f,0.6824279f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 17.75271f);
Get(0x6E70).SetLocalPose(-0.1667415f,1.669407f,-0.4487455f,0.4682799f,-0.4124617f,-0.5315547f,0.5727469f);
Get(0x6E82).SetLocalPose(-0.2044185f,0.8254414f,-0.3949369f,-0.01452871f,0.2113124f,0.04966489f,0.9760479f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 17.75271f);
Get(0x6EC6).SetLocalPose(0.3101466f,1.616413f,-0.5541904f,-0.2738533f,-0.8858541f,-0.003382063f,0.3745071f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321355f,1.537981f,0.4832301f,-0.654555f,-0.208202f,-0.2499581f,0.6824446f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 17.7722f);
Get(0x6E70).SetLocalPose(-0.1655856f,1.66919f,-0.4485227f,0.4683012f,-0.4133215f,-0.5308513f,0.5727618f);
Get(0x6E82).SetLocalPose(-0.2041983f,0.8263008f,-0.3950792f,-0.0130139f,0.2095832f,0.05105103f,0.9763705f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 17.7722f);
Get(0x6EC6).SetLocalPose(0.2909197f,1.609132f,-0.559072f,-0.2158778f,-0.8945746f,0.06780318f,0.3854033f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321369f,1.53801f,0.4832853f,-0.6545478f,-0.2082147f,-0.249935f,0.6824561f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 17.7921f);
Get(0x6E70).SetLocalPose(-0.1645285f,1.669457f,-0.4482966f,0.4684804f,-0.4138294f,-0.5306673f,0.5724191f);
Get(0x6E82).SetLocalPose(-0.2042724f,0.8282558f,-0.3958541f,-0.0120177f,0.2084484f,0.05215953f,0.9765676f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 17.7921f);
Get(0x6EC6).SetLocalPose(0.2703691f,1.600764f,-0.5649332f,-0.1508643f,-0.8972428f,0.1507379f,0.386618f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321352f,1.538059f,0.4831931f,-0.6545435f,-0.2082102f,-0.2499508f,0.6824559f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 17.81208f);
Get(0x6E70).SetLocalPose(-0.1632277f,1.668948f,-0.4484056f,0.4686496f,-0.4142527f,-0.5311588f,0.5715178f);
Get(0x6E82).SetLocalPose(-0.204219f,0.8283145f,-0.396874f,-0.01160339f,0.2082188f,0.05259868f,0.976598f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 17.81208f);
Get(0x6EC6).SetLocalPose(0.2516174f,1.590866f,-0.5680469f,-0.08907993f,-0.8948721f,0.2259231f,0.3744697f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321381f,1.537974f,0.4830458f,-0.6545328f,-0.2082026f,-0.249975f,0.6824596f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 17.83264f);
Get(0x6E70).SetLocalPose(-0.1625258f,1.669444f,-0.4483762f,0.4688966f,-0.414672f,-0.5320234f,0.5702055f);
Get(0x6E82).SetLocalPose(-0.2040286f,0.8286294f,-0.3977119f,-0.0119041f,0.2093634f,0.05172408f,0.9763964f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 17.83264f);
Get(0x6EC6).SetLocalPose(0.2350429f,1.580276f,-0.5725304f,-0.02983765f,-0.887102f,0.2866411f,0.3605505f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321382f,1.537934f,0.4830304f,-0.6545278f,-0.2082164f,-0.2499754f,0.68246f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 17.85233f);
Get(0x6E70).SetLocalPose(-0.162144f,1.669652f,-0.4483617f,0.4690369f,-0.4150981f,-0.5326192f,0.5692229f);
Get(0x6E82).SetLocalPose(-0.2036294f,0.8286425f,-0.3981301f,-0.01290409f,0.2112664f,0.0502566f,0.9760504f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 17.85233f);
Get(0x6EC6).SetLocalPose(0.2237118f,1.574773f,-0.5752472f,0.007004181f,-0.8813065f,0.3180916f,0.3493816f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321355f,1.538077f,0.4831866f,-0.6545154f,-0.2081922f,-0.2499735f,0.6824799f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 17.87242f);
Get(0x6E70).SetLocalPose(-0.1611897f,1.669658f,-0.4484215f,0.4690264f,-0.4157864f,-0.533134f,0.5682466f);
Get(0x6E82).SetLocalPose(-0.2036169f,0.8281615f,-0.3988109f,-0.01395164f,0.2133765f,0.04901189f,0.9756401f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 17.87242f);
Get(0x6EC6).SetLocalPose(0.2165273f,1.570874f,-0.5766445f,0.0295976f,-0.8787678f,0.3332446f,0.3403518f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321457f,1.538018f,0.4831907f,-0.6545215f,-0.2082162f,-0.2499595f,0.6824719f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 17.89229f);
Get(0x6E70).SetLocalPose(-0.160818f,1.670274f,-0.4484761f,0.4685508f,-0.4166371f,-0.533646f,0.5675348f);
Get(0x6E82).SetLocalPose(-0.2027125f,0.8275239f,-0.398633f,-0.01505043f,0.215539f,0.04792723f,0.9752023f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 17.89229f);
Get(0x6EC6).SetLocalPose(0.214623f,1.568674f,-0.5774233f,0.04196477f,-0.8813497f,0.3363199f,0.3291667f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321455f,1.537909f,0.4831722f,-0.6545153f,-0.2082156f,-0.249957f,0.682479f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 17.91219f);
Get(0x6E70).SetLocalPose(-0.1600427f,1.670339f,-0.4485796f,0.4677053f,-0.4175256f,-0.5344014f,0.5668678f);
Get(0x6E82).SetLocalPose(-0.2019364f,0.8268949f,-0.3986342f,-0.01579037f,0.2166132f,0.04711531f,0.9749921f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 17.91219f);
Get(0x6EC6).SetLocalPose(0.2179044f,1.569824f,-0.57703f,0.04636174f,-0.8874928f,0.3309905f,0.3172575f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321649f,1.537965f,0.4830141f,-0.654525f,-0.2082167f,-0.2499413f,0.6824751f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 17.93232f);
Get(0x6E70).SetLocalPose(-0.159169f,1.670546f,-0.4488723f,0.4667484f,-0.418153f,-0.5354229f,0.56623f);
Get(0x6E82).SetLocalPose(-0.2009407f,0.8261767f,-0.398164f,-0.01687109f,0.2175548f,0.04648656f,0.9747945f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 17.93232f);
Get(0x6EC6).SetLocalPose(0.2217805f,1.571374f,-0.576296f,0.0398956f,-0.8925385f,0.3222645f,0.3129359f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321655f,1.538008f,0.4829015f,-0.6545243f,-0.2082358f,-0.2499537f,0.6824654f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 17.95264f);
Get(0x6E70).SetLocalPose(-0.1582372f,1.671435f,-0.4493379f,0.4656661f,-0.4184251f,-0.5369074f,0.5655138f);
Get(0x6E82).SetLocalPose(-0.2007175f,0.8265643f,-0.3980514f,-0.01784083f,0.2186879f,0.04610381f,0.9745418f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 17.95264f);
Get(0x6EC6).SetLocalPose(0.22935f,1.571973f,-0.5725258f,0.02134937f,-0.8991653f,0.3045546f,0.3135164f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321578f,1.538002f,0.4829685f,-0.6545271f,-0.2082037f,-0.2499407f,0.6824773f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 17.97256f);
Get(0x6E70).SetLocalPose(-0.1577791f,1.671965f,-0.4498165f,0.4646684f,-0.4183368f,-0.5382761f,0.5650987f);
Get(0x6E82).SetLocalPose(-0.2009785f,0.8272743f,-0.3985251f,-0.01864215f,0.2197246f,0.04581125f,0.9743074f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 17.97256f);
Get(0x6EC6).SetLocalPose(0.2390601f,1.57542f,-0.5704409f,-0.004681861f,-0.9064094f,0.279158f,0.3169713f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321676f,1.53809f,0.4829857f,-0.6545197f,-0.208206f,-0.2499518f,0.6824796f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 17.99196f);
Get(0x6E70).SetLocalPose(-0.1574392f,1.672266f,-0.4501841f,0.4639685f,-0.4179177f,-0.5392276f,0.5650768f);
Get(0x6E82).SetLocalPose(-0.2004309f,0.8271371f,-0.3990004f,-0.01932257f,0.2204484f,0.04560272f,0.9741404f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 17.99196f);
Get(0x6EC6).SetLocalPose(0.2415762f,1.576521f,-0.5692151f,-0.03427377f,-0.9134377f,0.2478743f,0.32096f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321493f,1.538025f,0.4830662f,-0.6545327f,-0.2081912f,-0.2499578f,0.6824695f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 18.01263f);
Get(0x6E70).SetLocalPose(-0.1566379f,1.672185f,-0.4506704f,0.4632282f,-0.4173665f,-0.5400105f,0.5653438f);
Get(0x6E82).SetLocalPose(-0.2004069f,0.8280625f,-0.3990115f,-0.01970504f,0.2206749f,0.04544791f,0.9740887f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 18.01263f);
Get(0x6EC6).SetLocalPose(0.255477f,1.584149f,-0.56223f,-0.070067f,-0.9205668f,0.2069496f,0.3237581f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321365f,1.537994f,0.4831366f,-0.6545216f,-0.2082152f,-0.2499441f,0.6824778f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 18.03305f);
Get(0x6E70).SetLocalPose(-0.1564278f,1.671636f,-0.4510544f,0.4625852f,-0.416936f,-0.5406252f,0.5656003f);
Get(0x6E82).SetLocalPose(-0.2009865f,0.8294795f,-0.3989999f,-0.01997369f,0.2205546f,0.04540893f,0.9741123f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 18.03305f);
Get(0x6EC6).SetLocalPose(0.2696558f,1.588219f,-0.5551807f,-0.1048833f,-0.9232342f,0.1701592f,0.3281526f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321312f,1.538074f,0.4832307f,-0.6545272f,-0.2082019f,-0.2499449f,0.6824761f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 18.05259f);
Get(0x6E70).SetLocalPose(-0.1556451f,1.671841f,-0.4516925f,0.4622609f,-0.4164222f,-0.5411104f,0.56578f);
Get(0x6E82).SetLocalPose(-0.2016841f,0.8302295f,-0.3998533f,-0.02009026f,0.2204535f,0.04547713f,0.9741296f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 18.05259f);
Get(0x6EC6).SetLocalPose(0.2882955f,1.590265f,-0.5491058f,-0.1416593f,-0.920611f,0.1328332f,0.3387674f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32143f,1.538019f,0.4832815f,-0.6545324f,-0.2082023f,-0.2499571f,0.6824666f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 18.07224f);
Get(0x6E70).SetLocalPose(-0.1553423f,1.672214f,-0.452269f,0.4622561f,-0.4158178f,-0.5415924f,0.5657672f);
Get(0x6E82).SetLocalPose(-0.2021231f,0.8306517f,-0.4002576f,-0.02014617f,0.219989f,0.04552268f,0.9742313f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 18.07224f);
Get(0x6EC6).SetLocalPose(0.3057188f,1.590981f,-0.5425492f,-0.1791764f,-0.9143371f,0.0904417f,0.3517156f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321371f,1.538007f,0.4832674f,-0.6545416f,-0.2082041f,-0.2499463f,0.6824611f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 18.09255f);
Get(0x6E70).SetLocalPose(-0.1553604f,1.672201f,-0.4527231f,0.4624008f,-0.4153263f,-0.541948f,0.5656695f);
Get(0x6E82).SetLocalPose(-0.2027578f,0.830462f,-0.4008952f,-0.01972694f,0.2192171f,0.04579001f,0.9744014f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 18.09255f);
Get(0x6EC6).SetLocalPose(0.319518f,1.591789f,-0.5378166f,-0.2099557f,-0.9096444f,0.04855912f,0.3551164f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321294f,1.538059f,0.4834588f,-0.6545615f,-0.208205f,-0.2499746f,0.6824315f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 18.11186f);
Get(0x6E70).SetLocalPose(-0.1553509f,1.671734f,-0.452894f,0.4625456f,-0.4150925f,-0.5420086f,0.5656646f);
Get(0x6E82).SetLocalPose(-0.2029252f,0.8296452f,-0.4003819f,-0.01938127f,0.2183663f,0.04597693f,0.9745905f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 18.11186f);
Get(0x6EC6).SetLocalPose(0.3347468f,1.589509f,-0.5360845f,-0.2359814f,-0.9075269f,0.007380953f,0.3473517f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321348f,1.538134f,0.4834664f,-0.6545367f,-0.2082103f,-0.249961f,0.6824586f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 18.13187f);
Get(0x6E70).SetLocalPose(-0.1555617f,1.671879f,-0.4535599f,0.4627965f,-0.4149726f,-0.5412696f,0.5662547f);
Get(0x6E82).SetLocalPose(-0.2037006f,0.8296846f,-0.400512f,-0.0192733f,0.2173232f,0.04580285f,0.974834f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 18.13187f);
Get(0x6EC6).SetLocalPose(0.3456873f,1.585045f,-0.5357268f,-0.2581744f,-0.9072298f,-0.02232236f,0.3313333f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32139f,1.538032f,0.4833287f,-0.6545324f,-0.2081937f,-0.2499617f,0.6824675f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 18.15178f);
Get(0x6E70).SetLocalPose(-0.1555698f,1.671928f,-0.4540576f,0.4631938f,-0.4150865f,-0.5399317f,0.567123f);
Get(0x6E82).SetLocalPose(-0.2049491f,0.829837f,-0.4002415f,-0.01950095f,0.2158758f,0.0451223f,0.9751828f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 18.15178f);
Get(0x6EC6).SetLocalPose(0.3507219f,1.58137f,-0.5359261f,-0.2725071f,-0.9050696f,-0.03521455f,0.3245748f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321415f,1.538061f,0.4833155f,-0.6545425f,-0.2081906f,-0.2499559f,0.6824609f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 18.1714f);
Get(0x6E70).SetLocalPose(-0.155382f,1.671512f,-0.4542489f,0.4636964f,-0.4155209f,-0.5378667f,0.5683551f);
Get(0x6E82).SetLocalPose(-0.2058067f,0.8299983f,-0.4006238f,-0.01971565f,0.2144664f,0.04429227f,0.9755274f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 18.1714f);
Get(0x6EC6).SetLocalPose(0.354232f,1.575967f,-0.5352311f,-0.2822063f,-0.9013621f,-0.04059338f,0.3259726f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321325f,1.538081f,0.4832994f,-0.654531f,-0.208198f,-0.2499428f,0.6824744f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 18.19189f);
Get(0x6E70).SetLocalPose(-0.1550022f,1.67164f,-0.4546276f,0.4641114f,-0.4160005f,-0.5362573f,0.5691857f);
Get(0x6E82).SetLocalPose(-0.2063286f,0.8296192f,-0.4008502f,-0.02002734f,0.212716f,0.04306881f,0.975959f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 18.19189f);
Get(0x6EC6).SetLocalPose(0.3570021f,1.569621f,-0.534439f,-0.2850197f,-0.8991244f,-0.03916933f,0.3298557f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321213f,1.538135f,0.4831715f,-0.6545361f,-0.2082046f,-0.2499395f,0.6824688f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 18.21084f);
Get(0x6E70).SetLocalPose(-0.1547161f,1.671324f,-0.4548607f,0.4645879f,-0.4164805f,-0.5348123f,0.5698051f);
Get(0x6E82).SetLocalPose(-0.2068809f,0.8291596f,-0.4013244f,-0.02051331f,0.2118528f,0.04187058f,0.9761888f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 18.21084f);
Get(0x6EC6).SetLocalPose(0.3577057f,1.563336f,-0.5341158f,-0.2850032f,-0.896997f,-0.03430529f,0.3361441f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321255f,1.5381f,0.4830731f,-0.6545531f,-0.2081837f,-0.2499498f,0.6824552f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 18.23118f);
Get(0x6E70).SetLocalPose(-0.1540191f,1.67143f,-0.4549208f,0.4651622f,-0.4168266f,-0.5336977f,0.5701286f);
Get(0x6E82).SetLocalPose(-0.207501f,0.8294934f,-0.4029211f,-0.02161364f,0.2119972f,0.04018372f,0.9762046f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 18.23118f);
Get(0x6EC6).SetLocalPose(0.3587341f,1.557944f,-0.5333644f,-0.285027f,-0.8944682f,-0.03019502f,0.3431829f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321373f,1.538034f,0.4831229f,-0.6545386f,-0.2081794f,-0.249961f,0.6824662f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 18.25148f);
Get(0x6E70).SetLocalPose(-0.1535033f,1.671699f,-0.4553835f,0.465855f,-0.4168048f,-0.5328778f,0.5703456f);
Get(0x6E82).SetLocalPose(-0.2074393f,0.8291684f,-0.403421f,-0.02464694f,0.2136533f,0.03772798f,0.9758696f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 18.25148f);
Get(0x6EC6).SetLocalPose(0.3599819f,1.552147f,-0.531064f,-0.2869928f,-0.8911398f,-0.03079086f,0.3500811f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321309f,1.537914f,0.4832184f,-0.6545459f,-0.2081669f,-0.2499544f,0.6824654f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 18.27987f);
Get(0x6E70).SetLocalPose(-0.153158f,1.67089f,-0.4558119f,0.4666948f,-0.4163733f,-0.5320338f,0.570762f);
Get(0x6E82).SetLocalPose(-0.2069299f,0.8293586f,-0.4041521f,-0.03339053f,0.218273f,0.03270615f,0.9747679f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 18.27987f);
Get(0x6EC6).SetLocalPose(0.3638279f,1.541019f,-0.5254956f,-0.2963778f,-0.8835499f,-0.04325471f,0.36004f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321219f,1.538039f,0.4833042f,-0.6545681f,-0.2082082f,-0.249964f,0.6824281f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 18.28911f);
Get(0x6E70).SetLocalPose(-0.152972f,1.670574f,-0.4558495f,0.4669292f,-0.4161399f,-0.5318418f,0.5709195f);
Get(0x6E82).SetLocalPose(-0.2066631f,0.8299156f,-0.4037507f,-0.03866087f,0.2208591f,0.02999333f,0.9740775f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 18.28911f);
Get(0x6EC6).SetLocalPose(0.3652097f,1.537723f,-0.5238997f,-0.3002261f,-0.8809736f,-0.04936893f,0.3623706f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321285f,1.537978f,0.4832885f,-0.6545537f,-0.2081763f,-0.2499541f,0.6824552f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 18.31123f);
Get(0x6E70).SetLocalPose(-0.1525763f,1.670264f,-0.4561191f,0.4672422f,-0.4156025f,-0.5317259f,0.5711627f);
Get(0x6E82).SetLocalPose(-0.2062143f,0.8312985f,-0.4035494f,-0.04818995f,0.2248774f,0.02510281f,0.9728709f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 18.31123f);
Get(0x6EC6).SetLocalPose(0.3702106f,1.52959f,-0.5170766f,-0.3111223f,-0.873765f,-0.06970861f,0.3672581f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321238f,1.537875f,0.4834356f,-0.6545667f,-0.2081761f,-0.2499736f,0.6824357f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 18.33144f);
Get(0x6E70).SetLocalPose(-0.1520301f,1.670205f,-0.456525f,0.4671863f,-0.4152968f,-0.5318123f,0.5713505f);
Get(0x6E82).SetLocalPose(-0.2057189f,0.8323197f,-0.4024553f,-0.05704743f,0.2280959f,0.02076979f,0.9717441f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 18.33144f);
Get(0x6EC6).SetLocalPose(0.3769632f,1.519399f,-0.5098231f,-0.3236019f,-0.865703f,-0.09661116f,0.3694677f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321264f,1.537809f,0.4835089f,-0.6545685f,-0.2081975f,-0.2499596f,0.6824325f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 18.35176f);
Get(0x6E70).SetLocalPose(-0.1514594f,1.670878f,-0.4568887f,0.4668813f,-0.4152f,-0.5318736f,0.5716129f);
Get(0x6E82).SetLocalPose(-0.2058745f,0.8324348f,-0.4006513f,-0.06761413f,0.2310025f,0.01570914f,0.9704739f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 18.35176f);
Get(0x6EC6).SetLocalPose(0.38415f,1.506667f,-0.5027775f,-0.3366174f,-0.8561822f,-0.1288413f,0.3701903f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321476f,1.537992f,0.4833602f,-0.6545563f,-0.2081974f,-0.2499349f,0.6824533f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 18.37127f);
Get(0x6E70).SetLocalPose(-0.1507907f,1.670726f,-0.4574842f,0.4665092f,-0.4153501f,-0.531809f,0.5718677f);
Get(0x6E82).SetLocalPose(-0.2052565f,0.8331522f,-0.3994422f,-0.07568707f,0.2322509f,0.0121301f,0.9696308f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 18.37127f);
Get(0x6EC6).SetLocalPose(0.3941165f,1.49096f,-0.4927022f,-0.3513153f,-0.8431134f,-0.1687654f,0.3704803f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321452f,1.537962f,0.4833537f,-0.6545548f,-0.2082063f,-0.2499538f,0.6824451f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 18.39101f);
Get(0x6E70).SetLocalPose(-0.1502833f,1.670584f,-0.4580579f,0.4660583f,-0.4157723f,-0.5315617f,0.5721583f);
Get(0x6E82).SetLocalPose(-0.2048715f,0.8337804f,-0.3987342f,-0.08537503f,0.232594f,0.008300983f,0.9687839f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 18.39101f);
Get(0x6EC6).SetLocalPose(0.4019125f,1.476452f,-0.4838874f,-0.3629603f,-0.82952f,-0.204211f,0.3720943f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321465f,1.537882f,0.4833026f,-0.6545407f,-0.2082315f,-0.2499752f,0.682443f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 18.41037f);
Get(0x6E70).SetLocalPose(-0.1496049f,1.671121f,-0.4585443f,0.4656067f,-0.416452f,-0.531182f,0.5723844f);
Get(0x6E82).SetLocalPose(-0.2048724f,0.834285f,-0.3981064f,-0.09290344f,0.2321154f,0.005395032f,0.9682264f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 18.41037f);
Get(0x6EC6).SetLocalPose(0.4120669f,1.45607f,-0.4716656f,-0.3727269f,-0.8105611f,-0.2497742f,0.3764016f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321467f,1.537928f,0.4830113f,-0.654528f,-0.2082102f,-0.249972f,0.682463f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 18.43085f);
Get(0x6E70).SetLocalPose(-0.1490449f,1.670861f,-0.4592332f,0.4650304f,-0.4173311f,-0.5309058f,0.5724688f);
Get(0x6E82).SetLocalPose(-0.2039576f,0.8348277f,-0.3968093f,-0.1010996f,0.230971f,0.0021883f,0.9676914f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 18.43085f);
Get(0x6EC6).SetLocalPose(0.420056f,1.435232f,-0.4611486f,-0.3775067f,-0.793473f,-0.2885584f,0.3802939f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321487f,1.538039f,0.4831029f,-0.6545295f,-0.2082267f,-0.2499769f,0.6824547f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 18.45157f);
Get(0x6E70).SetLocalPose(-0.1483487f,1.671612f,-0.4605376f,0.4643335f,-0.4185459f,-0.5304788f,0.5725435f);
Get(0x6E82).SetLocalPose(-0.2036721f,0.8350284f,-0.3956141f,-0.107373f,0.2298175f,-0.0005145969f,0.9672924f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 18.45157f);
Get(0x6EC6).SetLocalPose(0.427552f,1.411591f,-0.4491652f,-0.3804402f,-0.7736298f,-0.3303848f,0.3841979f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321416f,1.53817f,0.4832953f,-0.6545255f,-0.2082257f,-0.2499722f,0.6824605f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 18.47145f);
Get(0x6E70).SetLocalPose(-0.1478156f,1.671547f,-0.4616485f,0.4638826f,-0.419595f,-0.5299264f,0.5726526f);
Get(0x6E82).SetLocalPose(-0.2044437f,0.8355224f,-0.3947165f,-0.1126861f,0.2287606f,-0.003378859f,0.9669328f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 18.47145f);
Get(0x6EC6).SetLocalPose(0.4333679f,1.387334f,-0.4384722f,-0.3795929f,-0.7536078f,-0.3713292f,0.3874265f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321543f,1.538139f,0.4832975f,-0.6545268f,-0.2082568f,-0.2499328f,0.6824642f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 18.49132f);
Get(0x6E70).SetLocalPose(-0.1471189f,1.67193f,-0.4623523f,0.4634921f,-0.4210672f,-0.5287958f,0.5729332f);
Get(0x6E82).SetLocalPose(-0.2046757f,0.8367641f,-0.3934999f,-0.1168919f,0.2278736f,-0.006215012f,0.9666288f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 18.49132f);
Get(0x6EC6).SetLocalPose(0.4385328f,1.35942f,-0.4276601f,-0.3759873f,-0.7299743f,-0.4175648f,0.3891153f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32159f,1.538092f,0.4832455f,-0.6545277f,-0.2082393f,-0.2499413f,0.6824656f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 18.51182f);
Get(0x6E70).SetLocalPose(-0.1463548f,1.671862f,-0.4633812f,0.4631765f,-0.4225022f,-0.5275607f,0.5732706f);
Get(0x6E82).SetLocalPose(-0.204884f,0.8371038f,-0.3923736f,-0.1219253f,0.2263524f,-0.01032126f,0.9663293f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 18.51182f);
Get(0x6EC6).SetLocalPose(0.4428744f,1.329033f,-0.4176608f,-0.3727366f,-0.7029259f,-0.4656116f,0.3875158f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321613f,1.538162f,0.4832064f,-0.6545153f,-0.2082813f,-0.249941f,0.6824648f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 18.53155f);
Get(0x6E70).SetLocalPose(-0.1458881f,1.672881f,-0.4642877f,0.4629426f,-0.4241448f,-0.5259973f,0.5736831f);
Get(0x6E82).SetLocalPose(-0.2046711f,0.8371162f,-0.3914149f,-0.1254085f,0.2249664f,-0.01311349f,0.9661734f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 18.53155f);
Get(0x6EC6).SetLocalPose(0.4453254f,1.303551f,-0.4104997f,-0.3699789f,-0.6790076f,-0.5041563f,0.3845656f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321569f,1.538054f,0.4831976f,-0.6545252f,-0.2082591f,-0.2499616f,0.6824546f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 18.55116f);
Get(0x6E70).SetLocalPose(-0.1453146f,1.673724f,-0.4653174f,0.4629051f,-0.4256019f,-0.5244406f,0.5740592f);
Get(0x6E82).SetLocalPose(-0.2052109f,0.8382692f,-0.3910101f,-0.1284664f,0.2232408f,-0.01608122f,0.966127f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 18.55116f);
Get(0x6EC6).SetLocalPose(0.4466043f,1.266358f,-0.4017511f,-0.361165f,-0.6430226f,-0.5602042f,0.3771646f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321436f,1.538082f,0.4833251f,-0.6545353f,-0.208238f,-0.2499646f,0.6824502f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 18.57977f);
Get(0x6E70).SetLocalPose(-0.1446115f,1.674221f,-0.4665151f,0.4630122f,-0.4274488f,-0.5224966f,0.5743732f);
Get(0x6E82).SetLocalPose(-0.2061436f,0.8388938f,-0.3901742f,-0.1317594f,0.2208112f,-0.02114161f,0.9661444f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 18.57977f);
Get(0x6EC6).SetLocalPose(0.4447291f,1.222189f,-0.3942846f,-0.3499743f,-0.5981654f,-0.6214997f,0.365314f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321457f,1.538107f,0.4832959f,-0.6545185f,-0.2082288f,-0.2499457f,0.682476f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 18.58939f);
Get(0x6E70).SetLocalPose(-0.1442591f,1.6744f,-0.4668936f,0.4630972f,-0.4286362f,-0.5212497f,0.5745527f);
Get(0x6E82).SetLocalPose(-0.2065399f,0.8387191f,-0.3898509f,-0.1325684f,0.2201182f,-0.02313447f,0.9661462f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 18.58939f);
Get(0x6EC6).SetLocalPose(0.4427155f,1.201466f,-0.3919674f,-0.3466312f,-0.5773254f,-0.6464195f,0.3587257f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321557f,1.538112f,0.4832804f,-0.6545264f,-0.2082541f,-0.2499601f,0.6824555f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 18.61073f);
Get(0x6E70).SetLocalPose(-0.1434058f,1.674955f,-0.4676985f,0.4631893f,-0.4305342f,-0.5194116f,0.574724f);
Get(0x6E82).SetLocalPose(-0.2072973f,0.8389022f,-0.3894983f,-0.1341125f,0.218922f,-0.02716837f,0.9660999f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 18.61073f);
Get(0x6EC6).SetLocalPose(0.4395934f,1.176237f,-0.3902069f,-0.3425256f,-0.5519758f,-0.6753603f,0.3491238f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321454f,1.538167f,0.4833232f,-0.6545192f,-0.2082105f,-0.2499543f,0.6824778f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 18.63226f);
Get(0x6E70).SetLocalPose(-0.1427093f,1.675241f,-0.4686767f,0.4631457f,-0.432578f,-0.5178059f,0.5746734f);
Get(0x6E82).SetLocalPose(-0.2090059f,0.8396803f,-0.3902262f,-0.1355445f,0.2181911f,-0.03123602f,0.9659424f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 18.63226f);
Get(0x6EC6).SetLocalPose(0.4329486f,1.13427f,-0.389056f,-0.3353386f,-0.5061025f,-0.7246169f,0.326096f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321382f,1.538167f,0.4832264f,-0.6545132f,-0.2082372f,-0.2499607f,0.6824729f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 18.65221f);
Get(0x6E70).SetLocalPose(-0.1414966f,1.675331f,-0.4698456f,0.4630157f,-0.4347571f,-0.5165f,0.5743087f);
Get(0x6E82).SetLocalPose(-0.2099507f,0.8396265f,-0.3909962f,-0.1363222f,0.21789f,-0.03416445f,0.9658017f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 18.65221f);
Get(0x6EC6).SetLocalPose(0.4251884f,1.098665f,-0.3905277f,-0.3323318f,-0.463028f,-0.7642283f,0.3018535f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321368f,1.538108f,0.4832886f,-0.6545274f,-0.20822f,-0.2499694f,0.6824615f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 18.67214f);
Get(0x6E70).SetLocalPose(-0.1403981f,1.676195f,-0.4704427f,0.4628762f,-0.4371629f,-0.5151801f,0.5737802f);
Get(0x6E82).SetLocalPose(-0.2109292f,0.8398427f,-0.3919838f,-0.1364753f,0.2176979f,-0.03624174f,0.9657478f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 18.67214f);
Get(0x6EC6).SetLocalPose(0.4158724f,1.063732f,-0.3936885f,-0.333326f,-0.4153453f,-0.7999922f,0.2763958f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321481f,1.53813f,0.4831497f,-0.6545126f,-0.2082313f,-0.2499508f,0.682479f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 18.69189f);
Get(0x6E70).SetLocalPose(-0.1391525f,1.676956f,-0.4707021f,0.4628051f,-0.4391709f,-0.5141818f,0.5731993f);
Get(0x6E82).SetLocalPose(-0.2122274f,0.8397f,-0.3932388f,-0.1360997f,0.2173755f,-0.03820521f,0.9657977f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 18.69189f);
Get(0x6EC6).SetLocalPose(0.4051604f,1.03446f,-0.3981952f,-0.3312415f,-0.3728361f,-0.8285098f,0.2546448f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321444f,1.538101f,0.4832218f,-0.6545175f,-0.2082405f,-0.2499599f,0.6824682f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 18.71173f);
Get(0x6E70).SetLocalPose(-0.137941f,1.67757f,-0.4712336f,0.4626016f,-0.4416924f,-0.5131176f,0.5723792f);
Get(0x6E82).SetLocalPose(-0.213349f,0.8397473f,-0.3943855f,-0.1355637f,0.2169476f,-0.03959385f,0.9659134f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 18.71173f);
Get(0x6EC6).SetLocalPose(0.3908778f,1.002447f,-0.4054181f,-0.3224137f,-0.3292903f,-0.857122f,0.2301285f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321487f,1.537981f,0.4831563f,-0.6545277f,-0.2082056f,-0.249964f,0.6824676f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 18.73176f);
Get(0x6E70).SetLocalPose(-0.1366263f,1.677629f,-0.4718461f,0.4622775f,-0.4438393f,-0.5123464f,0.5716707f);
Get(0x6E82).SetLocalPose(-0.2147284f,0.8391876f,-0.3953407f,-0.1347717f,0.2161079f,-0.04151902f,0.9661316f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 18.73176f);
Get(0x6EC6).SetLocalPose(0.3771145f,0.9775438f,-0.4130383f,-0.3122619f,-0.298563f,-0.8767116f,0.2114932f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321519f,1.538032f,0.4830272f,-0.6545134f,-0.2082098f,-0.2499373f,0.6824898f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 18.7513f);
Get(0x6E70).SetLocalPose(-0.135365f,1.677968f,-0.4725308f,0.4619561f,-0.4462363f,-0.5115297f,0.5707952f);
Get(0x6E82).SetLocalPose(-0.2164215f,0.8398581f,-0.3966901f,-0.1341303f,0.2148569f,-0.04337053f,0.9664184f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 18.7513f);
Get(0x6EC6).SetLocalPose(0.3605616f,0.952756f,-0.4226009f,-0.2968233f,-0.2695364f,-0.8951258f,0.1949252f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321474f,1.537996f,0.4829261f,-0.6544958f,-0.2082067f,-0.2499554f,0.6825009f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 18.77103f);
Get(0x6E70).SetLocalPose(-0.1338042f,1.678874f,-0.4730853f,0.4615881f,-0.4486908f,-0.5108257f,0.5697983f);
Get(0x6E82).SetLocalPose(-0.2175559f,0.8401825f,-0.3976178f,-0.1336105f,0.2129271f,-0.04485766f,0.9668496f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 18.77103f);
Get(0x6EC6).SetLocalPose(0.3448516f,0.9327381f,-0.431456f,-0.2799877f,-0.2460367f,-0.909738f,0.1828928f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321522f,1.538083f,0.4831195f,-0.6545184f,-0.2082167f,-0.2499329f,0.6824844f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 18.79151f);
Get(0x6E70).SetLocalPose(-0.1322115f,1.679536f,-0.4737735f,0.4611925f,-0.451427f,-0.5100749f,0.5686288f);
Get(0x6E82).SetLocalPose(-0.2188229f,0.8406814f,-0.3991191f,-0.1329498f,0.2098676f,-0.04628965f,0.9675419f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 18.79151f);
Get(0x6EC6).SetLocalPose(0.3253879f,0.9106833f,-0.4428816f,-0.2592472f,-0.2191166f,-0.925454f,0.1682669f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321534f,1.53809f,0.4830398f,-0.6545168f,-0.2081992f,-0.249942f,0.682488f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 18.81221f);
Get(0x6E70).SetLocalPose(-0.1302755f,1.680682f,-0.4741781f,0.4609404f,-0.4538772f,-0.5093714f,0.5675124f);
Get(0x6E82).SetLocalPose(-0.2201259f,0.8402842f,-0.4008763f,-0.1323228f,0.2056996f,-0.04770376f,0.9684538f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 18.81221f);
Get(0x6EC6).SetLocalPose(0.3078425f,0.8932992f,-0.4536529f,-0.2461183f,-0.1944166f,-0.9371413f,0.1529521f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321537f,1.538141f,0.4832047f,-0.6545381f,-0.2082323f,-0.2499296f,0.682462f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 18.83244f);
Get(0x6E70).SetLocalPose(-0.1283127f,1.681243f,-0.4745611f,0.4608012f,-0.4561716f,-0.5088605f,0.5662426f);
Get(0x6E82).SetLocalPose(-0.2213501f,0.8397884f,-0.4028691f,-0.1318917f,0.2011953f,-0.04853935f,0.9694169f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 18.83244f);
Get(0x6EC6).SetLocalPose(0.2893747f,0.8750886f,-0.4649701f,-0.2394565f,-0.1656621f,-0.9477366f,0.1304304f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321548f,1.538102f,0.4832298f,-0.654537f,-0.2082319f,-0.2499236f,0.6824654f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 18.85233f);
Get(0x6E70).SetLocalPose(-0.1259226f,1.682063f,-0.4750259f,0.4608359f,-0.4581125f,-0.5086477f,0.564837f);
Get(0x6E82).SetLocalPose(-0.2227334f,0.839587f,-0.4045405f,-0.1308406f,0.1962025f,-0.04881809f,0.970568f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 18.85233f);
Get(0x6EC6).SetLocalPose(0.2770918f,0.863439f,-0.4730207f,-0.2403291f,-0.1433185f,-0.9536613f,0.1105979f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321553f,1.537942f,0.4832505f,-0.6545352f,-0.2082151f,-0.2499205f,0.6824734f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 18.87242f);
Get(0x6E70).SetLocalPose(-0.1241746f,1.682588f,-0.4752556f,0.4611146f,-0.4598232f,-0.508377f,0.5634615f);
Get(0x6E82).SetLocalPose(-0.223627f,0.8393792f,-0.40601f,-0.1287606f,0.191087f,-0.04838392f,0.9718876f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 18.87242f);
Get(0x6EC6).SetLocalPose(0.2612999f,0.8488122f,-0.4833909f,-0.2491352f,-0.1114993f,-0.9585378f,0.08188451f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321591f,1.537923f,0.4831945f,-0.6545371f,-0.2082047f,-0.2499289f,0.6824717f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 18.89243f);
Get(0x6E70).SetLocalPose(-0.1224233f,1.682965f,-0.4754432f,0.4615376f,-0.4613659f,-0.5081617f,0.5620465f);
Get(0x6E82).SetLocalPose(-0.2243252f,0.8387498f,-0.407979f,-0.1230146f,0.1815368f,-0.04524183f,0.9746102f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 18.89243f);
Get(0x6EC6).SetLocalPose(0.248309f,0.8388036f,-0.4921682f,-0.2637122f,-0.08284584f,-0.9593952f,0.05615509f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321507f,1.537932f,0.4832744f,-0.6545571f,-0.2082019f,-0.2499504f,0.6824454f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 18.91231f);
Get(0x6E70).SetLocalPose(-0.1205706f,1.682496f,-0.4755956f,0.4618846f,-0.4626612f,-0.5082273f,0.5606356f);
Get(0x6E82).SetLocalPose(-0.2249467f,0.839211f,-0.4104438f,-0.1137102f,0.1702537f,-0.03926565f,0.9780297f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 18.91231f);
Get(0x6EC6).SetLocalPose(0.2347952f,0.8301916f,-0.5012436f,-0.2802255f,-0.05309829f,-0.9579909f,0.03012763f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321507f,1.53794f,0.4832022f,-0.6545522f,-0.208186f,-0.2499327f,0.6824616f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 18.93298f);
Get(0x6E70).SetLocalPose(-0.1184612f,1.682515f,-0.4757218f,0.4622081f,-0.4639381f,-0.5088711f,0.5587266f);
Get(0x6E82).SetLocalPose(-0.225783f,0.8428783f,-0.4123605f,-0.09922943f,0.1560971f,-0.03007854f,0.9822843f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 18.93298f);
Get(0x6EC6).SetLocalPose(0.2239585f,0.8229347f,-0.5081114f,-0.2937953f,-0.02976052f,-0.9553598f,0.009297416f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321392f,1.538014f,0.4831062f,-0.6545486f,-0.2081809f,-0.2499407f,0.6824635f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 18.95671f);
Get(0x6E70).SetLocalPose(-0.1166923f,1.682238f,-0.4761017f,0.4625778f,-0.4647348f,-0.5099115f,0.5568066f);
Get(0x6E82).SetLocalPose(-0.226229f,0.843583f,-0.4159002f,-0.07641882f,0.1363053f,-0.01476446f,0.9876047f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 18.95671f);
Get(0x6EC6).SetLocalPose(0.2127749f,0.8184031f,-0.5153089f,-0.3082461f,-0.00821383f,-0.9512063f,-0.01111476f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.3213f,1.538098f,0.4832765f,-0.6545501f,-0.2081892f,-0.2499364f,0.6824611f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 18.97068f);
Get(0x6E70).SetLocalPose(-0.1149269f,1.682248f,-0.4765413f,0.462837f,-0.4651386f,-0.5107282f,0.555504f);
Get(0x6E82).SetLocalPose(-0.2258099f,0.8436351f,-0.4172594f,-0.06484804f,0.1272703f,-0.006648525f,0.9897236f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 18.97068f);
Get(0x6EC6).SetLocalPose(0.2070039f,0.8138605f,-0.5181733f,-0.3155811f,0.002010613f,-0.9486465f,-0.02177859f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321375f,1.537955f,0.4832754f,-0.6545361f,-0.2082029f,-0.2499511f,0.6824651f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 18.99854f);
Get(0x6E70).SetLocalPose(-0.1117431f,1.682169f,-0.4771317f,0.4630817f,-0.4657265f,-0.5120401f,0.5535966f);
Get(0x6E82).SetLocalPose(-0.2252685f,0.8420563f,-0.4202063f,-0.05885348f,0.1166016f,-0.004141763f,0.9914248f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 18.99854f);
Get(0x6EC6).SetLocalPose(0.1982159f,0.8108834f,-0.5205968f,-0.3197972f,0.01195827f,-0.9468555f,-0.03242413f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321458f,1.537912f,0.4831341f,-0.654544f,-0.2081961f,-0.2499611f,0.6824558f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 19.01341f);
Get(0x6E70).SetLocalPose(-0.1095546f,1.682031f,-0.4773315f,0.4631354f,-0.4660953f,-0.5131829f,0.5521812f);
Get(0x6E82).SetLocalPose(-0.2247576f,0.8426956f,-0.4206623f,-0.05936434f,0.113617f,-0.004593444f,0.9917389f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 19.01341f);
Get(0x6EC6).SetLocalPose(0.1930384f,0.80989f,-0.5208144f,-0.3127502f,0.01227473f,-0.9492952f,-0.02958456f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321444f,1.537984f,0.4831073f,-0.6545499f,-0.2082104f,-0.249965f,0.6824445f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 19.03056f);
Get(0x6E70).SetLocalPose(-0.1078299f,1.682158f,-0.4774713f,0.4632025f,-0.4662511f,-0.514088f,0.5511504f);
Get(0x6E82).SetLocalPose(-0.2244561f,0.8426334f,-0.4204417f,-0.05947256f,0.1145443f,-0.004710509f,0.9916252f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 19.03056f);
Get(0x6EC6).SetLocalPose(0.1899143f,0.8104233f,-0.5199866f,-0.3017728f,0.007480585f,-0.9531223f,-0.02085992f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321409f,1.537954f,0.4830663f,-0.6545395f,-0.2082066f,-0.2499715f,0.6824532f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 19.05025f);
Get(0x6E70).SetLocalPose(-0.1057253f,1.682042f,-0.477901f,0.4632874f,-0.466292f,-0.5155069f,0.5497174f);
Get(0x6E82).SetLocalPose(-0.224545f,0.8432003f,-0.4188043f,-0.0583273f,0.1151522f,-0.004113448f,0.9916254f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 19.05025f);
Get(0x6EC6).SetLocalPose(0.1866716f,0.8091217f,-0.5197123f,-0.2904299f,0.003476415f,-0.9567939f,-0.01355563f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321414f,1.538011f,0.48313f,-0.6545449f,-0.2081931f,-0.2499595f,0.6824565f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 19.06451f);
Get(0x6E70).SetLocalPose(-0.1039313f,1.681634f,-0.4782587f,0.4633652f,-0.4662069f,-0.5168687f,0.5484438f);
Get(0x6E82).SetLocalPose(-0.2251379f,0.8435482f,-0.4172944f,-0.05631384f,0.1111773f,-0.002657942f,0.9922003f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 19.06451f);
Get(0x6EC6).SetLocalPose(0.1874345f,0.8099166f,-0.5183257f,-0.2888686f,0.002911096f,-0.9572816f,-0.01258731f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321358f,1.538033f,0.4832369f,-0.6545248f,-0.2082045f,-0.249961f,0.6824718f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 19.08181f);
Get(0x6E70).SetLocalPose(-0.101707f,1.681394f,-0.4790087f,0.4633871f,-0.4659486f,-0.5190113f,0.5466182f);
Get(0x6E82).SetLocalPose(-0.2278279f,0.84402f,-0.4117528f,-0.05540707f,0.09553969f,-0.004228526f,0.9938734f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 19.08181f);
Get(0x6EC6).SetLocalPose(0.1894987f,0.8117622f,-0.5173121f,-0.2851245f,0.003472788f,-0.9584082f,-0.01207188f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321447f,1.537992f,0.4832805f,-0.6545445f,-0.2082213f,-0.2499455f,0.6824534f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 19.11771f);
Get(0x6E70).SetLocalPose(-0.09956408f,1.682063f,-0.4797347f,0.4632341f,-0.4656729f,-0.5213552f,0.5447493f);
Get(0x6E82).SetLocalPose(-0.2334393f,0.8453648f,-0.4019234f,-0.06292631f,0.07043196f,-0.01152205f,0.9954632f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 19.11771f);
Get(0x6EC6).SetLocalPose(0.1919176f,0.8114191f,-0.5157408f,-0.2773532f,0.007459251f,-0.96065f,-0.01308308f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321311f,1.53804f,0.4832801f,-0.6545243f,-0.2082312f,-0.2499736f,0.6824595f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 19.13344f);
Get(0x6E70).SetLocalPose(-0.09754632f,1.682468f,-0.4802232f,0.4630009f,-0.4655717f,-0.5231357f,0.5433252f);
Get(0x6E82).SetLocalPose(-0.239026f,0.8479849f,-0.3913285f,-0.07473631f,0.05191529f,-0.01910273f,0.9956679f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 19.13344f);
Get(0x6EC6).SetLocalPose(0.1927272f,0.8116278f,-0.5154065f,-0.2709385f,0.01101583f,-0.9624255f,-0.01442889f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321392f,1.538044f,0.4833179f,-0.6545132f,-0.2082248f,-0.2499658f,0.6824749f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 19.15972f);
Get(0x6E70).SetLocalPose(-0.09593104f,1.682891f,-0.4809292f,0.4624215f,-0.4656836f,-0.5253419f,0.5415913f);
Get(0x6E82).SetLocalPose(-0.2495155f,0.8548402f,-0.3738556f,-0.1002994f,0.02291042f,-0.0347424f,0.9940866f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 19.15972f);
Get(0x6EC6).SetLocalPose(0.1940085f,0.81353f,-0.5151225f,-0.2576497f,0.01634962f,-0.9659476f,-0.01716346f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32149f,1.53792f,0.4830571f,-0.6545051f,-0.2082122f,-0.2499887f,0.6824781f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 19.17053f);
Get(0x6E70).SetLocalPose(-0.09480053f,1.682519f,-0.4818869f,0.4620113f,-0.4658546f,-0.5264646f,0.5407033f);
Get(0x6E82).SetLocalPose(-0.2546906f,0.8582644f,-0.3661765f,-0.1118909f,0.0101801f,-0.04134456f,0.9928079f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 19.17053f);
Get(0x6EC6).SetLocalPose(0.1945164f,0.8138251f,-0.5149689f,-0.2530884f,0.01823259f,-0.9671027f,-0.01805983f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321502f,1.537892f,0.4830198f,-0.6544978f,-0.2081984f,-0.2499724f,0.6824954f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 19.19254f);
Get(0x6E70).SetLocalPose(-0.09373782f,1.682438f,-0.4829655f,0.4614004f,-0.4662975f,-0.5277599f,0.5395794f);
Get(0x6E82).SetLocalPose(-0.2673255f,0.8677067f,-0.3475234f,-0.1403349f,-0.02082809f,-0.05429156f,0.9883951f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 19.19254f);
Get(0x6EC6).SetLocalPose(0.1950468f,0.8133286f,-0.512754f,-0.2457715f,0.02184281f,-0.9688727f,-0.02012736f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321383f,1.537961f,0.4830759f,-0.6545135f,-0.2082039f,-0.249959f,0.6824835f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 19.21237f);
Get(0x6E70).SetLocalPose(-0.09245156f,1.68272f,-0.4840722f,0.4607975f,-0.4671766f,-0.5289337f,0.5381829f);
Get(0x6E82).SetLocalPose(-0.2783513f,0.8778707f,-0.3314008f,-0.1662768f,-0.04939466f,-0.06236096f,0.9828649f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 19.21237f);
Get(0x6EC6).SetLocalPose(0.195257f,0.8140347f,-0.5113805f,-0.241774f,0.02500072f,-0.9697641f,-0.02186451f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321339f,1.537829f,0.4829285f,-0.6546873f,-0.2081972f,-0.2499827f,0.6823102f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 19.23268f);
Get(0x6E70).SetLocalPose(-0.09163406f,1.68315f,-0.4850191f,0.4603659f,-0.4681866f,-0.5297108f,0.5369089f);
Get(0x6E82).SetLocalPose(-0.292343f,0.8907445f,-0.3103637f,-0.1972794f,-0.08740988f,-0.06764816f,0.9740966f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 19.23268f);
Get(0x6EC6).SetLocalPose(0.1942768f,0.8145365f,-0.510277f,-0.2386293f,0.02876598f,-0.970374f,-0.02455442f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321339f,1.537911f,0.4827684f,-0.6548992f,-0.2082487f,-0.2499565f,0.6821007f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 19.25256f);
Get(0x6E70).SetLocalPose(-0.09023724f,1.683128f,-0.4867092f,0.4600633f,-0.469521f,-0.530318f,0.5354015f);
Get(0x6E82).SetLocalPose(-0.3108176f,0.9130183f,-0.285481f,-0.235751f,-0.1386131f,-0.07175393f,0.9591972f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 19.25256f);
Get(0x6EC6).SetLocalPose(0.1938488f,0.8159004f,-0.5106094f,-0.2336272f,0.03255425f,-0.9713945f,-0.027411f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32123f,1.537808f,0.4828126f,-0.6550357f,-0.2082415f,-0.2499648f,0.6819688f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 19.27255f);
Get(0x6E70).SetLocalPose(-0.08928833f,1.683104f,-0.4879269f,0.4600504f,-0.4704605f,-0.5304717f,0.5344345f);
Get(0x6E82).SetLocalPose(-0.3289547f,0.9358832f,-0.2622709f,-0.2760997f,-0.1923733f,-0.07479696f,0.9387049f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 19.27255f);
Get(0x6EC6).SetLocalPose(0.1917043f,0.8158777f,-0.5097136f,-0.2250749f,0.03487586f,-0.9732893f,-0.02886005f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321336f,1.538006f,0.4826655f,-0.6550986f,-0.2081479f,-0.2500011f,0.6819236f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 19.29264f);
Get(0x6E70).SetLocalPose(-0.08910154f,1.683372f,-0.4889183f,0.4601731f,-0.4714767f,-0.5304716f,0.5334327f);
Get(0x6E82).SetLocalPose(-0.3487744f,0.9644689f,-0.2399393f,-0.3197378f,-0.252979f,-0.07523081f,0.9100053f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 19.29264f);
Get(0x6EC6).SetLocalPose(0.1899535f,0.8153337f,-0.5082241f,-0.2145502f,0.03505902f,-0.9756866f,-0.0278344f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321398f,1.537966f,0.4827763f,-0.6550167f,-0.2080066f,-0.2500778f,0.6820172f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 19.31207f);
Get(0x6E70).SetLocalPose(-0.08839703f,1.683098f,-0.4898956f,0.4604911f,-0.4723518f,-0.5302979f,0.532556f);
Get(0x6E82).SetLocalPose(-0.3693324f,0.9989628f,-0.2197951f,-0.3609666f,-0.3168134f,-0.06658932f,0.8745846f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 19.31207f);
Get(0x6EC6).SetLocalPose(0.1883274f,0.8163918f,-0.5069668f,-0.2049462f,0.03356579f,-0.9778705f,-0.02529134f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321372f,1.538031f,0.4829144f,-0.6547822f,-0.2078837f,-0.2501376f,0.682258f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 19.33253f);
Get(0x6E70).SetLocalPose(-0.08848906f,1.68346f,-0.4909541f,0.4610151f,-0.4727532f,-0.5300922f,0.5319509f);
Get(0x6E82).SetLocalPose(-0.3919839f,1.039145f,-0.2009568f,-0.4032963f,-0.3885637f,-0.04393486f,0.827309f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 19.33253f);
Get(0x6EC6).SetLocalPose(0.187893f,0.8168906f,-0.5063869f,-0.1997464f,0.03192156f,-0.97905f,-0.02331316f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321447f,1.537872f,0.483151f,-0.6546019f,-0.2077234f,-0.250137f,0.6824799f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 19.35185f);
Get(0x6E70).SetLocalPose(-0.08840914f,1.683606f,-0.4919429f,0.4617711f,-0.4730056f,-0.5298679f,0.5312938f);
Get(0x6E82).SetLocalPose(-0.414366f,1.084433f,-0.1864773f,-0.4450515f,-0.456955f,-0.01256309f,0.7700411f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 19.35185f);
Get(0x6EC6).SetLocalPose(0.1877158f,0.8174591f,-0.5061078f,-0.1952493f,0.03046576f,-0.9800459f,-0.02143824f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321335f,1.537775f,0.4832854f,-0.6544409f,-0.2077703f,-0.2500303f,0.6826591f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 19.37177f);
Get(0x6E70).SetLocalPose(-0.08868206f,1.683624f,-0.4929116f,0.4624762f,-0.4731409f,-0.5296555f,0.5307717f);
Get(0x6E82).SetLocalPose(-0.4336078f,1.129007f,-0.1774322f,-0.4819991f,-0.5095059f,0.01824096f,0.7125643f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 19.37177f);
Get(0x6EC6).SetLocalPose(0.1880845f,0.8184636f,-0.5055894f,-0.1909313f,0.02953289f,-0.9809595f,-0.01979047f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321317f,1.537782f,0.4830946f,-0.6544006f,-0.2079695f,-0.2499874f,0.6826528f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 19.39123f);
Get(0x6E70).SetLocalPose(-0.08935212f,1.683336f,-0.493737f,0.4630384f,-0.4732279f,-0.5294223f,0.5304364f);
Get(0x6E82).SetLocalPose(-0.4520522f,1.179945f,-0.1730065f,-0.5250033f,-0.5537758f,0.05244797f,0.6441686f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 19.39123f);
Get(0x6EC6).SetLocalPose(0.188582f,0.8194973f,-0.504462f,-0.1861457f,0.02918989f,-0.9819268f,-0.01781644f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321005f,1.537806f,0.4828995f,-0.6546161f,-0.2083049f,-0.2496688f,0.6824605f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 19.41996f);
Get(0x6E70).SetLocalPose(-0.08973065f,1.683032f,-0.4947918f,0.4637033f,-0.4731358f,-0.52894f,0.530419f);
Get(0x6E82).SetLocalPose(-0.4697164f,1.253718f,-0.1748181f,-0.59004f,-0.5816935f,0.09546378f,0.5516994f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 19.41996f);
Get(0x6EC6).SetLocalPose(0.1889667f,0.815571f,-0.5038779f,-0.1792907f,0.02883057f,-0.983254f,-0.01533584f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.320968f,1.537873f,0.4829126f,-0.6546796f,-0.2082691f,-0.2495649f,0.6824486f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 19.4295f);
Get(0x6E70).SetLocalPose(-0.08998887f,1.683122f,-0.4950816f,0.4638511f,-0.4731045f,-0.5287092f,0.5305478f);
Get(0x6E82).SetLocalPose(-0.4728989f,1.281593f,-0.1782787f,-0.6159765f,-0.5802786f,0.1060199f,0.5221202f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 19.4295f);
Get(0x6EC6).SetLocalPose(0.1894224f,0.8153155f,-0.503536f,-0.1764382f,0.02846822f,-0.9837946f,-0.01439798f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.320975f,1.537926f,0.4831053f,-0.6547076f,-0.2081735f,-0.2495706f,0.6824488f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 19.4515f);
Get(0x6E70).SetLocalPose(-0.09060978f,1.683013f,-0.4954927f,0.4638328f,-0.4732501f,-0.5283162f,0.5308254f);
Get(0x6E82).SetLocalPose(-0.4740827f,1.335665f,-0.1889783f,-0.675995f,-0.5590661f,0.1127842f,0.4666429f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 19.4515f);
Get(0x6EC6).SetLocalPose(0.1901532f,0.8149112f,-0.5033532f,-0.1714775f,0.02737667f,-0.9847237f,-0.01285668f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321009f,1.538028f,0.4833581f,-0.6546101f,-0.2081538f,-0.2497655f,0.6824771f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 19.46034f);
Get(0x6E70).SetLocalPose(-0.09103019f,1.683386f,-0.4957479f,0.463682f,-0.4735333f,-0.5280068f,0.5310123f);
Get(0x6E82).SetLocalPose(-0.4693976f,1.379295f,-0.2022361f,-0.731392f,-0.5256278f,0.1030954f,0.4220813f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 19.46034f);
Get(0x6EC6).SetLocalPose(0.1900235f,0.8152251f,-0.5025524f,-0.1681118f,0.02616992f,-0.9853524f,-0.01158892f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321224f,1.538105f,0.4836733f,-0.6543705f,-0.2080957f,-0.2500069f,0.6826361f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 19.49243f);
Get(0x6E70).SetLocalPose(-0.09191526f,1.683918f,-0.4962159f,0.4632775f,-0.4744508f,-0.5273217f,0.5312273f);
Get(0x6E82).SetLocalPose(-0.4507059f,1.446435f,-0.2305408f,-0.8241518f,-0.4462894f,0.05830401f,0.3438027f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 19.49243f);
Get(0x6EC6).SetLocalPose(0.1909601f,0.8163427f,-0.5013885f,-0.1626588f,0.02359407f,-0.9863613f,-0.008769082f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321276f,1.538007f,0.4833409f,-0.6543726f,-0.2082183f,-0.2497143f,0.6827037f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 19.51279f);
Get(0x6E70).SetLocalPose(-0.09204943f,1.684424f,-0.4965367f,0.4630024f,-0.4750465f,-0.5268832f,0.5313697f);
Get(0x6E82).SetLocalPose(-0.4298633f,1.488325f,-0.2549865f,-0.8860187f,-0.3737469f,0.009243853f,0.2742237f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 19.51279f);
Get(0x6EC6).SetLocalPose(0.1909941f,0.8180986f,-0.499429f,-0.1587273f,0.02176558f,-0.9870626f,-0.006272162f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32105f,1.53808f,0.4832961f,-0.6544058f,-0.2083993f,-0.2494631f,0.6827086f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 19.53315f);
Get(0x6E70).SetLocalPose(-0.09277306f,1.685382f,-0.4971072f,0.4625885f,-0.4757414f,-0.5262239f,0.5317618f);
Get(0x6E82).SetLocalPose(-0.4085597f,1.515209f,-0.2762968f,-0.9254264f,-0.3129258f,-0.03511836f,0.2107848f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 19.53315f);
Get(0x6EC6).SetLocalPose(0.1912224f,0.8194466f,-0.4979175f,-0.1561107f,0.02102602f,-0.9875051f,-0.004571443f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32095f,1.538236f,0.483244f,-0.6545091f,-0.2084481f,-0.2493067f,0.6826518f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 19.55303f);
Get(0x6E70).SetLocalPose(-0.09319926f,1.68517f,-0.497273f,0.4621575f,-0.476184f,-0.5258016f,0.5321577f);
Get(0x6E82).SetLocalPose(-0.3724923f,1.54662f,-0.3085488f,-0.9644471f,-0.221346f,-0.1029736f,0.1012136f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 19.55303f);
Get(0x6EC6).SetLocalPose(0.190568f,0.8216223f,-0.4970349f,-0.1538043f,0.02061307f,-0.9878808f,-0.003298343f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321041f,1.538106f,0.4831693f,-0.6545625f,-0.2083626f,-0.2494511f,0.6825739f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 19.5727f);
Get(0x6E70).SetLocalPose(-0.09359753f,1.685579f,-0.4972939f,0.4617239f,-0.476362f,-0.525531f,0.532642f);
Get(0x6E82).SetLocalPose(-0.3411106f,1.559778f,-0.3356346f,-0.9774998f,-0.13934f,-0.1582445f,-0.006108429f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 19.5727f);
Get(0x6EC6).SetLocalPose(0.1902302f,0.8228404f,-0.4965704f,-0.1511982f,0.02016968f,-0.9882951f,-0.002239669f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321083f,1.538146f,0.483329f,-0.6545681f,-0.2082214f,-0.2498152f,0.6824785f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 19.59292f);
Get(0x6E70).SetLocalPose(-0.09376666f,1.68603f,-0.4972188f,0.461208f,-0.4763984f,-0.5250489f,0.5335311f);
Get(0x6E82).SetLocalPose(-0.3164941f,1.565627f,-0.3555483f,-0.9754674f,-0.07249181f,-0.1879359f,-0.08881751f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 19.59292f);
Get(0x6EC6).SetLocalPose(0.1890005f,0.8231614f,-0.4947439f,-0.1484163f,0.01916152f,-0.9887389f,-0.0009805802f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321083f,1.538154f,0.4833182f,-0.65451f,-0.2080393f,-0.2498609f,0.6825729f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 19.61379f);
Get(0x6E70).SetLocalPose(-0.09343127f,1.685753f,-0.4971095f,0.4606189f,-0.4763778f,-0.5244583f,0.534638f);
Get(0x6E82).SetLocalPose(-0.2954858f,1.566586f,-0.373024f,-0.9632093f,0.001430003f,-0.2092887f,-0.1685943f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 19.61379f);
Get(0x6EC6).SetLocalPose(0.1876308f,0.821095f,-0.4946911f,-0.1462545f,0.01739637f,-0.9890938f,0.000665796f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321054f,1.538119f,0.4831441f,-0.6544529f,-0.2081266f,-0.2496739f,0.6826695f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 19.63341f);
Get(0x6E70).SetLocalPose(-0.0932398f,1.685328f,-0.4967636f,0.4598733f,-0.4764719f,-0.5240615f,0.5355844f);
Get(0x6E82).SetLocalPose(-0.2761375f,1.567956f,-0.3846014f,-0.9422097f,0.05157363f,-0.2299598f,-0.2381169f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 19.63341f);
Get(0x6EC6).SetLocalPose(0.1873917f,0.8190477f,-0.4937012f,-0.1443585f,0.01490933f,-0.9894098f,0.002573889f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.320867f,1.538026f,0.4831603f,-0.6544068f,-0.2083829f,-0.2494589f,0.6827142f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 19.65326f);
Get(0x6E70).SetLocalPose(-0.09282576f,1.685297f,-0.496492f,0.4592257f,-0.4763094f,-0.5238365f,0.5365039f);
Get(0x6E82).SetLocalPose(-0.2662719f,1.572421f,-0.389286f,-0.9294825f,0.06515718f,-0.246794f,-0.2662889f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 19.65326f);
Get(0x6EC6).SetLocalPose(0.1870335f,0.8182274f,-0.4934609f,-0.142917f,0.01264868f,-0.9896458f,0.003972889f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.320667f,1.53801f,0.4830836f,-0.6543992f,-0.2085643f,-0.2492693f,0.6827353f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 19.67261f);
Get(0x6E70).SetLocalPose(-0.09231899f,1.684521f,-0.4963493f,0.4591514f,-0.475839f,-0.5238537f,0.5369679f);
Get(0x6E82).SetLocalPose(-0.2626002f,1.580401f,-0.3885832f,-0.9272873f,0.06531807f,-0.2626322f,-0.2586429f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 19.67261f);
Get(0x6EC6).SetLocalPose(0.187404f,0.8152693f,-0.4936438f,-0.1414766f,0.01065914f,-0.9898745f,0.004378578f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.320655f,1.537938f,0.4831387f,-0.6543828f,-0.2086003f,-0.2492941f,0.682731f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 19.69277f);
Get(0x6E70).SetLocalPose(-0.09169606f,1.683831f,-0.4962218f,0.4595169f,-0.4750172f,-0.5239654f,0.5372738f);
Get(0x6E82).SetLocalPose(-0.2674562f,1.592103f,-0.3852901f,-0.9328547f,0.0433703f,-0.2756882f,-0.2278095f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 19.69277f);
Get(0x6EC6).SetLocalPose(0.1870919f,0.814415f,-0.4935264f,-0.1402377f,0.009366969f,-0.9900658f,0.003935993f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.320755f,1.537859f,0.4832053f,-0.6543544f,-0.2085816f,-0.2494237f,0.6827166f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 19.71319f);
Get(0x6E70).SetLocalPose(-0.0910516f,1.683215f,-0.4962195f,0.459967f,-0.4741147f,-0.5242394f,0.5374187f);
Get(0x6E82).SetLocalPose(-0.2795373f,1.608313f,-0.3807047f,-0.9420498f,-0.005542366f,-0.2837403f,-0.1788934f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 19.71319f);
Get(0x6EC6).SetLocalPose(0.1870228f,0.8130943f,-0.4935321f,-0.1391062f,0.008183936f,-0.9902381f,0.00329852f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.320797f,1.537864f,0.4831783f,-0.6543996f,-0.2085402f,-0.249425f,0.6826854f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 19.73384f);
Get(0x6E70).SetLocalPose(-0.09064167f,1.683063f,-0.4960656f,0.4600613f,-0.4736694f,-0.524502f,0.5374742f);
Get(0x6E82).SetLocalPose(-0.3044068f,1.626046f,-0.3710324f,-0.9529303f,-0.08865022f,-0.2739531f,-0.09494497f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 19.73384f);
Get(0x6EC6).SetLocalPose(0.1877616f,0.8130538f,-0.4932268f,-0.1384225f,0.006658217f,-0.9903471f,0.002744574f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32066f,1.537699f,0.4831072f,-0.6544814f,-0.2085459f,-0.2493563f,0.6826303f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 19.75362f);
Get(0x6E70).SetLocalPose(-0.08985498f,1.683382f,-0.4960398f,0.4599825f,-0.4731875f,-0.5249655f,0.5375136f);
Get(0x6E82).SetLocalPose(-0.3323051f,1.642132f,-0.3630082f,-0.9585962f,-0.1824058f,-0.2182269f,0.01408644f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 19.75362f);
Get(0x6EC6).SetLocalPose(0.188017f,0.8127726f,-0.4934402f,-0.1382172f,0.00526791f,-0.9903848f,0.00251276f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.320723f,1.537901f,0.483151f,-0.6545871f,-0.2085267f,-0.2492754f,0.6825644f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 19.77316f);
Get(0x6E70).SetLocalPose(-0.0885167f,1.68369f,-0.4960329f,0.4591292f,-0.472808f,-0.5261943f,0.5373757f);
Get(0x6E82).SetLocalPose(-0.3614436f,1.654073f,-0.3582143f,-0.952379f,-0.2576003f,-0.1040954f,0.1256204f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 19.77316f);
Get(0x6EC6).SetLocalPose(0.1883801f,0.8134065f,-0.4928558f,-0.1377298f,0.003634963f,-0.9904598f,0.002593191f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.320896f,1.537674f,0.4831648f,-0.6546509f,-0.2084181f,-0.2492608f,0.6825418f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 19.79323f);
Get(0x6E70).SetLocalPose(-0.08716757f,1.685075f,-0.4956611f,0.4567279f,-0.4726707f,-0.5289069f,0.5368795f);
Get(0x6E82).SetLocalPose(-0.3798795f,1.661314f,-0.3554358f,-0.9392018f,-0.2859329f,-0.03259336f,0.1872965f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 19.79323f);
Get(0x6EC6).SetLocalPose(0.1892469f,0.8142272f,-0.491702f,-0.1368238f,0.001449142f,-0.9905893f,0.003175256f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321131f,1.537888f,0.4831338f,-0.6547127f,-0.208344f,-0.2493952f,0.682456f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 19.81435f);
Get(0x6E70).SetLocalPose(-0.08592451f,1.685114f,-0.495459f,0.4550902f,-0.4724265f,-0.5310335f,0.5363856f);
Get(0x6E82).SetLocalPose(-0.382182f,1.657974f,-0.3582225f,-0.9414176f,-0.2773363f,-0.080107f,0.1743569f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 19.81435f);
Get(0x6EC6).SetLocalPose(0.1897976f,0.8143126f,-0.4919539f,-0.1356249f,-0.0008267839f,-0.9907527f,0.003780104f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32124f,1.537966f,0.4829884f,-0.6547913f,-0.2082053f,-0.249531f,0.6823732f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 19.83488f);
Get(0x6E70).SetLocalPose(-0.08519979f,1.685388f,-0.49516f,0.4538577f,-0.4721547f,-0.5326647f,0.5360518f);
Get(0x6E82).SetLocalPose(-0.3687139f,1.650884f,-0.3685015f,-0.9495636f,-0.2418369f,-0.180959f,0.08424781f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 19.83488f);
Get(0x6EC6).SetLocalPose(0.189736f,0.8151609f,-0.4925609f,-0.1342819f,-0.003227003f,-0.9909275f,0.004559508f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321054f,1.538096f,0.4830828f,-0.6547962f,-0.2082012f,-0.2496055f,0.6823425f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 19.85479f);
Get(0x6E70).SetLocalPose(-0.08456865f,1.685562f,-0.4947214f,0.4522358f,-0.4721355f,-0.5340238f,0.5360872f);
Get(0x6E82).SetLocalPose(-0.351052f,1.640537f,-0.3780321f,-0.9377593f,-0.2093542f,-0.2747709f,-0.03576621f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 19.85479f);
Get(0x6EC6).SetLocalPose(0.1894208f,0.8156996f,-0.4921189f,-0.1328001f,-0.006597364f,-0.9911041f,0.00578385f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321001f,1.537981f,0.4831134f,-0.6546399f,-0.2083102f,-0.2497479f,0.6824071f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 19.8745f);
Get(0x6E70).SetLocalPose(-0.08377507f,1.685853f,-0.49378f,0.4490582f,-0.4726573f,-0.5353891f,0.536936f);
Get(0x6E82).SetLocalPose(-0.3357873f,1.629895f,-0.3872713f,-0.9248942f,-0.1628814f,-0.3153955f,-0.1362584f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 19.8745f);
Get(0x6EC6).SetLocalPose(0.1897229f,0.8162607f,-0.4919376f,-0.1314356f,-0.01089555f,-0.9912332f,0.007927322f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.320908f,1.537976f,0.483136f,-0.6545419f,-0.208369f,-0.2497335f,0.6824886f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 19.89356f);
Get(0x6E70).SetLocalPose(-0.08363369f,1.686081f,-0.4934977f,0.4479857f,-0.4728659f,-0.5357461f,0.5372922f);
Get(0x6E82).SetLocalPose(-0.3215201f,1.617293f,-0.3996445f,-0.9127929f,-0.1054015f,-0.3242894f,-0.2248022f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 19.89356f);
Get(0x6EC6).SetLocalPose(0.1898772f,0.8162272f,-0.4919495f,-0.1308124f,-0.01593457f,-0.9912221f,0.01062112f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32081f,1.538062f,0.4830987f,-0.6544318f,-0.208508f,-0.2496405f,0.6825856f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 19.91258f);
Get(0x6E70).SetLocalPose(-0.08238912f,1.68661f,-0.4922468f,0.4431342f,-0.4733495f,-0.5373592f,0.5392751f);
Get(0x6E82).SetLocalPose(-0.3112068f,1.60432f,-0.4093091f,-0.9012304f,-0.06200119f,-0.3162255f,-0.2897259f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 19.91258f);
Get(0x6EC6).SetLocalPose(0.1893421f,0.8148593f,-0.4928025f,-0.1308416f,-0.02091219f,-0.9910913f,0.01346246f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.320685f,1.538311f,0.4830472f,-0.6543764f,-0.2084933f,-0.2496473f,0.6826407f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 19.93237f);
Get(0x6E70).SetLocalPose(-0.08231881f,1.687018f,-0.4916047f,0.4416167f,-0.4729207f,-0.5382833f,0.5399739f);
Get(0x6E82).SetLocalPose(-0.3007239f,1.596747f,-0.4170626f,-0.8850186f,-0.039531f,-0.3107761f,-0.3443801f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 19.93237f);
Get(0x6EC6).SetLocalPose(0.1879734f,0.8145624f,-0.4939304f,-0.1310901f,-0.0238878f,-0.9909614f,0.0154961f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.320724f,1.538343f,0.4830969f,-0.6543939f,-0.2083007f,-0.2497186f,0.6826566f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 19.95108f);
Get(0x6E70).SetLocalPose(-0.08292958f,1.68769f,-0.4909356f,0.4406767f,-0.4712726f,-0.5402005f,0.5402682f);
Get(0x6E82).SetLocalPose(-0.29471f,1.594665f,-0.4217125f,-0.8801866f,-0.05054801f,-0.3107908f,-0.3551418f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 19.95108f);
Get(0x6EC6).SetLocalPose(0.1853317f,0.8153301f,-0.4949597f,-0.1309236f,-0.02451204f,-0.9909542f,0.01636866f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.320874f,1.538271f,0.4830084f,-0.6543883f,-0.2080607f,-0.2499463f,0.6826519f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 19.97899f);
Get(0x6E70).SetLocalPose(-0.08330674f,1.687014f,-0.4905555f,0.440904f,-0.4691458f,-0.5418563f,0.5402755f);
Get(0x6E82).SetLocalPose(-0.2966727f,1.598061f,-0.4254007f,-0.8994958f,-0.07486818f,-0.2970226f,-0.3115761f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 19.97899f);
Get(0x6EC6).SetLocalPose(0.1840211f,0.8153725f,-0.4955232f,-0.1306151f,-0.02382845f,-0.99101f,0.01646991f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321132f,1.538146f,0.4828351f,-0.65442f,-0.2079315f,-0.2502411f,0.6825529f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 19.99908f);
Get(0x6E70).SetLocalPose(-0.0831362f,1.68654f,-0.4902983f,0.4413616f,-0.4679889f,-0.5424914f,0.540268f);
Get(0x6E82).SetLocalPose(-0.3115396f,1.606445f,-0.4235772f,-0.9163031f,-0.1224015f,-0.2746457f,-0.2645303f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 19.99908f);
Get(0x6EC6).SetLocalPose(0.1834867f,0.8171204f,-0.4952511f,-0.130343f,-0.02335433f,-0.9910588f,0.01636503f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321187f,1.538007f,0.4827492f,-0.6544936f,-0.2079076f,-0.2502269f,0.6824947f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 20.0186f);
Get(0x6E70).SetLocalPose(-0.08362105f,1.685291f,-0.489806f,0.4429063f,-0.4658061f,-0.5433117f,0.540066f);
Get(0x6E82).SetLocalPose(-0.3231046f,1.614455f,-0.4205294f,-0.9253455f,-0.1653705f,-0.2568173f,-0.2245732f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 20.0186f);
Get(0x6EC6).SetLocalPose(0.1830082f,0.8180118f,-0.495669f,-0.129403f,-0.02393533f,-0.9911634f,0.01664847f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321146f,1.537941f,0.482776f,-0.6546f,-0.2079531f,-0.2501263f,0.6824157f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 20.03728f);
Get(0x6E70).SetLocalPose(-0.08364401f,1.685217f,-0.4899615f,0.4434244f,-0.4652349f,-0.5434338f,0.5400103f);
Get(0x6E82).SetLocalPose(-0.3522879f,1.623506f,-0.4121819f,-0.9327446f,-0.228241f,-0.2291644f,-0.1593026f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 20.03728f);
Get(0x6EC6).SetLocalPose(0.1832045f,0.8179257f,-0.4957308f,-0.1282521f,-0.02506493f,-0.9912738f,0.0173038f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321123f,1.537915f,0.4828821f,-0.6545648f,-0.2082215f,-0.2499535f,0.682431f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 20.05655f);
Get(0x6E70).SetLocalPose(-0.08371345f,1.685179f,-0.4898838f,0.4460081f,-0.4628277f,-0.5436435f,0.5397397f);
Get(0x6E82).SetLocalPose(-0.3753868f,1.630937f,-0.405192f,-0.9336519f,-0.2801691f,-0.199341f,-0.1003125f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 20.05655f);
Get(0x6EC6).SetLocalPose(0.1833988f,0.8179391f,-0.4953883f,-0.126191f,-0.0268492f,-0.9914715f,0.01841524f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321056f,1.537861f,0.4830305f,-0.6544527f,-0.2083932f,-0.2496772f,0.6825872f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 20.07534f);
Get(0x6E70).SetLocalPose(-0.0838967f,1.684557f,-0.4899553f,0.447374f,-0.4615464f,-0.5435638f,0.5397869f);
Get(0x6E82).SetLocalPose(-0.3975095f,1.636363f,-0.3974804f,-0.9304744f,-0.3249233f,-0.1648035f,-0.03849716f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 20.07534f);
Get(0x6EC6).SetLocalPose(0.1835879f,0.8176038f,-0.4951262f,-0.1241072f,-0.02886196f,-0.9916576f,0.01948392f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.320931f,1.537987f,0.4830201f,-0.6544191f,-0.2083254f,-0.2497144f,0.6826265f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 20.09568f);
Get(0x6E70).SetLocalPose(-0.08374722f,1.683901f,-0.4900231f,0.447594f,-0.4613242f,-0.5434614f,0.5398976f);
Get(0x6E82).SetLocalPose(-0.4201046f,1.638378f,-0.3879768f,-0.9245287f,-0.3547349f,-0.1376962f,0.02120443f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 20.09568f);
Get(0x6EC6).SetLocalPose(0.1848382f,0.8194323f,-0.493603f,-0.1221627f,-0.0317032f,-0.9917854f,0.02080649f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.320888f,1.538078f,0.4830248f,-0.6544313f,-0.2082449f,-0.2498764f,0.68258f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 20.11619f);
Get(0x6E70).SetLocalPose(-0.08371979f,1.684044f,-0.4897723f,0.4475903f,-0.461326f,-0.5434567f,0.5399039f);
Get(0x6E82).SetLocalPose(-0.439595f,1.636079f,-0.3740472f,-0.9145558f,-0.3699124f,-0.1496797f,0.0659441f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 20.11619f);
Get(0x6EC6).SetLocalPose(0.1854838f,0.8202256f,-0.4926134f,-0.1212915f,-0.03339573f,-0.9918215f,0.02152022f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32091f,1.53827f,0.4830155f,-0.6544927f,-0.2080674f,-0.2501075f,0.6824908f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 20.13625f);
Get(0x6E70).SetLocalPose(-0.08362347f,1.683502f,-0.4898119f,0.4476807f,-0.4613735f,-0.5434047f,0.5398406f);
Get(0x6E82).SetLocalPose(-0.4506807f,1.630377f,-0.3620107f,-0.9031187f,-0.3797069f,-0.1799554f,0.08840547f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 20.13625f);
Get(0x6EC6).SetLocalPose(0.186511f,0.8221648f,-0.4931359f,-0.1204078f,-0.03591678f,-0.9918202f,0.0224687f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321198f,1.538067f,0.4831408f,-0.654671f,-0.2079604f,-0.250178f,0.6823265f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 20.15535f);
Get(0x6E70).SetLocalPose(-0.08383776f,1.683582f,-0.489382f,0.4476855f,-0.4613442f,-0.5434601f,0.5398059f);
Get(0x6E82).SetLocalPose(-0.4592542f,1.625992f,-0.352012f,-0.8957295f,-0.3800943f,-0.2065446f,0.1026465f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 20.15535f);
Get(0x6EC6).SetLocalPose(0.1875704f,0.8230699f,-0.4932989f,-0.1201679f,-0.03777273f,-0.9917589f,0.02339044f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321184f,1.537746f,0.4832409f,-0.6546078f,-0.2081663f,-0.2501111f,0.6823488f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 20.17471f);
Get(0x6E70).SetLocalPose(-0.08347753f,1.683379f,-0.4889134f,0.447095f,-0.4613518f,-0.5436013f,0.5401465f);
Get(0x6E82).SetLocalPose(-0.4660828f,1.618534f,-0.3401028f,-0.8907838f,-0.3710052f,-0.2335019f,0.1197341f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 20.17471f);
Get(0x6EC6).SetLocalPose(0.1884256f,0.822809f,-0.4930537f,-0.1203373f,-0.03891864f,-0.9916747f,0.02419986f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321188f,1.537537f,0.4832344f,-0.6545548f,-0.2082857f,-0.2498773f,0.6824488f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 20.19394f);
Get(0x6E70).SetLocalPose(-0.08360662f,1.683258f,-0.4885845f,0.4459688f,-0.4614785f,-0.5438427f,0.5407261f);
Get(0x6E82).SetLocalPose(-0.4703591f,1.611703f,-0.3281084f,-0.8858915f,-0.3593401f,-0.2574117f,0.140749f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 20.19394f);
Get(0x6EC6).SetLocalPose(0.1897201f,0.8231461f,-0.4931429f,-0.1211744f,-0.03994467f,-0.9915074f,0.02518603f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321167f,1.53777f,0.4832236f,-0.6544652f,-0.2083796f,-0.2496623f,0.6825848f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 20.21385f);
Get(0x6E70).SetLocalPose(-0.08375919f,1.684511f,-0.4882053f,0.4443302f,-0.4614904f,-0.5443146f,0.5415891f);
Get(0x6E82).SetLocalPose(-0.4741326f,1.602235f,-0.3169672f,-0.8797234f,-0.3454295f,-0.2790299f,0.1700225f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 20.21385f);
Get(0x6EC6).SetLocalPose(0.1904258f,0.8228452f,-0.4939074f,-0.1222356f,-0.04074435f,-0.9913207f,0.02611002f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321147f,1.538195f,0.4833423f,-0.6544213f,-0.2084003f,-0.249724f,0.6825981f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 20.23341f);
Get(0x6E70).SetLocalPose(-0.08387716f,1.684638f,-0.4874766f,0.4428934f,-0.4614529f,-0.5448366f,0.5422729f);
Get(0x6E82).SetLocalPose(-0.4776105f,1.593516f,-0.3074332f,-0.8742917f,-0.3337233f,-0.293211f,0.1956275f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 20.23341f);
Get(0x6EC6).SetLocalPose(0.1906322f,0.8235642f,-0.4943528f,-0.1231383f,-0.04117528f,-0.991173f,0.02679278f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32127f,1.538316f,0.4832203f,-0.6544778f,-0.2082371f,-0.249867f,0.6825414f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 20.25254f);
Get(0x6E70).SetLocalPose(-0.08445345f,1.684563f,-0.4864536f,0.441284f,-0.4610279f,-0.5457777f,0.5429994f);
Get(0x6E82).SetLocalPose(-0.4811079f,1.58062f,-0.297891f,-0.867766f,-0.3229701f,-0.3052357f,0.2224941f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 20.25254f);
Get(0x6EC6).SetLocalPose(0.1904284f,0.8229029f,-0.4953835f,-0.1247283f,-0.04106115f,-0.9909536f,0.02771275f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321523f,1.538214f,0.483009f,-0.6545705f,-0.2080851f,-0.250013f,0.6824453f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 20.27179f);
Get(0x6E70).SetLocalPose(-0.08486596f,1.684593f,-0.4854957f,0.4405566f,-0.4602266f,-0.5465588f,0.543484f);
Get(0x6E82).SetLocalPose(-0.4840867f,1.568507f,-0.2910742f,-0.8625911f,-0.3162754f,-0.3122216f,0.2417107f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 20.27179f);
Get(0x6EC6).SetLocalPose(0.190028f,0.8225793f,-0.4960829f,-0.1258361f,-0.04023266f,-0.9908373f,0.02807298f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321587f,1.538048f,0.4830846f,-0.6546407f,-0.2080632f,-0.2501858f,0.6823213f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 20.29094f);
Get(0x6E70).SetLocalPose(-0.08538393f,1.684702f,-0.4849459f,0.4404968f,-0.459403f,-0.5470912f,0.5436935f);
Get(0x6E82).SetLocalPose(-0.4885068f,1.551882f,-0.2796156f,-0.8547876f,-0.3095442f,-0.3201484f,0.2665063f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 20.29094f);
Get(0x6EC6).SetLocalPose(0.1900368f,0.8219796f,-0.4965743f,-0.1267763f,-0.03919319f,-0.9907578f,0.02812273f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321477f,1.537922f,0.4832393f,-0.6546357f,-0.2081129f,-0.2500761f,0.6823512f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 20.31896f);
Get(0x6E70).SetLocalPose(-0.08621795f,1.684817f,-0.4840913f,0.4411687f,-0.4580145f,-0.5474561f,0.5439529f);
Get(0x6E82).SetLocalPose(-0.4934964f,1.527118f,-0.2669428f,-0.8417842f,-0.3051153f,-0.3288297f,0.3002916f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 20.31896f);
Get(0x6EC6).SetLocalPose(0.1899099f,0.8216881f,-0.4975799f,-0.1289838f,-0.03716097f,-0.9905626f,0.02771416f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321326f,1.537997f,0.483279f,-0.6545412f,-0.2082835f,-0.2498766f,0.6824629f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 20.33809f);
Get(0x6E70).SetLocalPose(-0.08688907f,1.684502f,-0.4836628f,0.4420974f,-0.4571211f,-0.5473433f,0.5440639f);
Get(0x6E82).SetLocalPose(-0.4970205f,1.504697f,-0.2565431f,-0.8280181f,-0.302366f,-0.3359367f,0.3318245f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 20.33809f);
Get(0x6EC6).SetLocalPose(0.189358f,0.8216698f,-0.4976948f,-0.1302645f,-0.0364029f,-0.990432f,0.02739609f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321242f,1.53818f,0.4832715f,-0.6544489f,-0.2083988f,-0.2497747f,0.6825535f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 20.35769f);
Get(0x6E70).SetLocalPose(-0.08758388f,1.683771f,-0.4830274f,0.4430604f,-0.4564766f,-0.5471167f,0.5440497f);
Get(0x6E82).SetLocalPose(-0.499985f,1.478898f,-0.2451268f,-0.8121108f,-0.2992802f,-0.3398639f,0.3679672f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 20.35769f);
Get(0x6EC6).SetLocalPose(0.1889447f,0.8220517f,-0.4979173f,-0.1310112f,-0.03613317f,-0.9903477f,0.02723917f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.320978f,1.538362f,0.4833258f,-0.6544535f,-0.2083292f,-0.2497313f,0.6825862f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 20.37741f);
Get(0x6E70).SetLocalPose(-0.08848903f,1.683126f,-0.4823195f,0.4444212f,-0.4558305f,-0.5466816f,0.5439187f);
Get(0x6E82).SetLocalPose(-0.5012472f,1.451667f,-0.2356186f,-0.7957472f,-0.2933105f,-0.3409994f,0.4055551f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 20.37741f);
Get(0x6EC6).SetLocalPose(0.187815f,0.8222775f,-0.4976338f,-0.1309804f,-0.03613215f,-0.9903492f,0.02733243f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321036f,1.538448f,0.4832914f,-0.6545069f,-0.208252f,-0.2499053f,0.6824949f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 20.3978f);
Get(0x6E70).SetLocalPose(-0.08930687f,1.682625f,-0.4819474f,0.4460872f,-0.4552159f,-0.5461505f,0.5436032f);
Get(0x6E82).SetLocalPose(-0.5011376f,1.418945f,-0.225124f,-0.7727036f,-0.282363f,-0.3400066f,0.4556268f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 20.3978f);
Get(0x6EC6).SetLocalPose(0.1868895f,0.8218184f,-0.4978211f,-0.1303571f,-0.03613606f,-0.9904261f,0.02751921f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321176f,1.538332f,0.4831768f,-0.6545664f,-0.208167f,-0.2500732f,0.6824023f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 20.41713f);
Get(0x6E70).SetLocalPose(-0.08993031f,1.682248f,-0.4814524f,0.4477266f,-0.4548065f,-0.5455212f,0.5432297f);
Get(0x6E82).SetLocalPose(-0.4995568f,1.385967f,-0.2161817f,-0.7472715f,-0.2706282f,-0.3349902f,0.5060903f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 20.41713f);
Get(0x6EC6).SetLocalPose(0.1861531f,0.8223005f,-0.4978676f,-0.1294738f,-0.03613416f,-0.9905377f,0.02767776f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321424f,1.538184f,0.4831593f,-0.65463f,-0.2080867f,-0.2501052f,0.6823539f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 20.43699f);
Get(0x6E70).SetLocalPose(-0.090928f,1.682293f,-0.4809627f,0.4497676f,-0.4544705f,-0.5445089f,0.5428404f);
Get(0x6E82).SetLocalPose(-0.4948636f,1.343873f,-0.2077352f,-0.7151493f,-0.2556675f,-0.3244926f,0.5638264f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 20.43699f);
Get(0x6EC6).SetLocalPose(0.1858441f,0.8223532f,-0.4977114f,-0.1287918f,-0.03609392f,-0.9906263f,0.02773847f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321444f,1.538142f,0.4832218f,-0.6546129f,-0.2081155f,-0.2500546f,0.6823801f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 20.45594f);
Get(0x6E70).SetLocalPose(-0.09159753f,1.682141f,-0.4806159f,0.4516551f,-0.4542876f,-0.5432228f,0.5427148f);
Get(0x6E82).SetLocalPose(-0.4883177f,1.304961f,-0.2034858f,-0.6860262f,-0.2397519f,-0.311879f,0.612061f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 20.45594f);
Get(0x6EC6).SetLocalPose(0.1855179f,0.8217124f,-0.4978263f,-0.1283424f,-0.03609772f,-0.9906897f,0.02755455f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321255f,1.538063f,0.4831789f,-0.6545116f,-0.2082736f,-0.249967f,0.6824611f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 20.47477f);
Get(0x6E70).SetLocalPose(-0.09245684f,1.681653f,-0.4802238f,0.4537836f,-0.4542566f,-0.5415853f,0.5426018f);
Get(0x6E82).SetLocalPose(-0.4789909f,1.263073f,-0.2019646f,-0.6515927f,-0.2202709f,-0.2955359f,0.6629979f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 20.47477f);
Get(0x6EC6).SetLocalPose(0.1852222f,0.821451f,-0.4981382f,-0.1281282f,-0.03624326f,-0.9907098f,0.02763733f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321171f,1.537933f,0.4833485f,-0.6544721f,-0.208343f,-0.2498306f,0.6825277f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 20.4938f);
Get(0x6E70).SetLocalPose(-0.09336651f,1.681519f,-0.4797159f,0.4555994f,-0.4543839f,-0.5401933f,0.5423613f);
Get(0x6E82).SetLocalPose(-0.4681905f,1.219704f,-0.2032478f,-0.6103758f,-0.2008927f,-0.2741404f,0.7154933f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 20.4938f);
Get(0x6EC6).SetLocalPose(0.1853188f,0.820639f,-0.4978893f,-0.128478f,-0.0363843f,-0.9906502f,0.0279622f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321032f,1.538022f,0.4832204f,-0.6544764f,-0.2083495f,-0.2497444f,0.6825532f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 20.51319f);
Get(0x6E70).SetLocalPose(-0.09396395f,1.681116f,-0.4793003f,0.4573765f,-0.4544459f,-0.5391096f,0.5418916f);
Get(0x6E82).SetLocalPose(-0.4638112f,1.204409f,-0.2044165f,-0.5940208f,-0.1944801f,-0.2654362f,0.7340712f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 20.51319f);
Get(0x6EC6).SetLocalPose(0.1850657f,0.8205132f,-0.4981747f,-0.128893f,-0.03650139f,-0.9905821f,0.02830897f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321118f,1.538171f,0.4830948f,-0.6544589f,-0.2083286f,-0.2498413f,0.682541f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 20.53265f);
Get(0x6E70).SetLocalPose(-0.09469803f,1.680544f,-0.478782f,0.4583362f,-0.4546383f,-0.5384987f,0.5415267f);
Get(0x6E82).SetLocalPose(-0.4422066f,1.137719f,-0.2135136f,-0.512949f,-0.1709787f,-0.2248202f,0.8106204f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 20.53265f);
Get(0x6EC6).SetLocalPose(0.184973f,0.820039f,-0.4978466f,-0.1297167f,-0.03661491f,-0.9904501f,0.02900676f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321301f,1.538167f,0.4830402f,-0.6545525f,-0.208229f,-0.2499777f,0.6824316f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 20.55162f);
Get(0x6E70).SetLocalPose(-0.09547295f,1.680115f,-0.4778471f,0.4588594f,-0.4550527f,-0.5378456f,0.5413846f);
Get(0x6E82).SetLocalPose(-0.4225642f,1.084412f,-0.2270515f,-0.4469446f,-0.151441f,-0.1953221f,0.8597415f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 20.55162f);
Get(0x6EC6).SetLocalPose(0.1849099f,0.8204415f,-0.497724f,-0.1305199f,-0.03645086f,-0.9903325f,0.02961947f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321421f,1.538066f,0.4831355f,-0.6546094f,-0.2081167f,-0.2500634f,0.6823799f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 20.571f);
Get(0x6E70).SetLocalPose(-0.09651009f,1.6803f,-0.4768939f,0.4590315f,-0.4555064f,-0.5370749f,0.5416222f);
Get(0x6E82).SetLocalPose(-0.4055249f,1.042253f,-0.2419987f,-0.3888671f,-0.1315717f,-0.1696873f,0.8959227f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 20.571f);
Get(0x6EC6).SetLocalPose(0.1845766f,0.8208091f,-0.4978285f,-0.1319491f,-0.03565517f,-0.9901571f,0.03011801f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321638f,1.538083f,0.4831785f,-0.6545846f,-0.2081614f,-0.250069f,0.6823879f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 20.59954f);
Get(0x6E70).SetLocalPose(-0.09790587f,1.679718f,-0.4751776f,0.4593445f,-0.45572f,-0.5363175f,0.5419275f);
Get(0x6E82).SetLocalPose(-0.3776502f,0.979178f,-0.2723196f,-0.2954397f,-0.1193945f,-0.1280443f,0.9391832f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 20.59954f);
Get(0x6EC6).SetLocalPose(0.1834346f,0.8202317f,-0.4987685f,-0.1338484f,-0.03386622f,-0.9899572f,0.03037456f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321475f,1.538018f,0.4833938f,-0.6545218f,-0.208256f,-0.2498879f,0.6824858f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 20.61904f);
Get(0x6E70).SetLocalPose(-0.09875312f,1.679065f,-0.4739336f,0.459558f,-0.4555224f,-0.5362074f,0.5420217f);
Get(0x6E82).SetLocalPose(-0.3608333f,0.9415411f,-0.2953328f,-0.238704f,-0.1289772f,-0.1065188f,0.9565768f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 20.61904f);
Get(0x6EC6).SetLocalPose(0.1834338f,0.820592f,-0.4996468f,-0.1353108f,-0.03225886f,-0.9898127f,0.03035355f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32133f,1.53801f,0.4834737f,-0.6544859f,-0.2082949f,-0.2498008f,0.6825401f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 20.63885f);
Get(0x6E70).SetLocalPose(-0.09983887f,1.678971f,-0.4725657f,0.4594476f,-0.4550036f,-0.5363743f,0.5423858f);
Get(0x6E82).SetLocalPose(-0.3475697f,0.9147409f,-0.3140678f,-0.1961339f,-0.1337491f,-0.09362927f,0.96689f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 20.63885f);
Get(0x6EC6).SetLocalPose(0.1834534f,0.8206559f,-0.5005585f,-0.1375598f,-0.02999933f,-0.9895772f,0.03023823f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321194f,1.53818f,0.4835205f,-0.6544809f,-0.2083955f,-0.2497683f,0.6825261f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 20.6585f);
Get(0x6E70).SetLocalPose(-0.1010356f,1.679446f,-0.4711525f,0.4590882f,-0.4542802f,-0.5366154f,0.5430575f);
Get(0x6E82).SetLocalPose(-0.3277287f,0.8779926f,-0.3444256f,-0.1359706f,-0.1321181f,-0.07814686f,0.9787492f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 20.6585f);
Get(0x6EC6).SetLocalPose(0.183214f,0.8203489f,-0.5017604f,-0.1401681f,-0.02754025f,-0.9892878f,0.03006906f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321136f,1.538253f,0.4834936f,-0.6545066f,-0.2083249f,-0.2498318f,0.6824999f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 20.67745f);
Get(0x6E70).SetLocalPose(-0.1021865f,1.679342f,-0.4696745f,0.4584677f,-0.4531724f,-0.5369955f,0.5441306f);
Get(0x6E82).SetLocalPose(-0.3154742f,0.8590528f,-0.3630313f,-0.1043885f,-0.1350966f,-0.06964651f,0.9828537f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 20.67745f);
Get(0x6EC6).SetLocalPose(0.1828944f,0.8198286f,-0.5023506f,-0.143942f,-0.02371026f,-0.9888722f,0.02916202f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321425f,1.538391f,0.4833203f,-0.6546101f,-0.208213f,-0.2499265f,0.6824f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 20.69712f);
Get(0x6E70).SetLocalPose(-0.1031371f,1.679095f,-0.4680514f,0.4575132f,-0.4514771f,-0.5376431f,0.5457014f);
Get(0x6E82).SetLocalPose(-0.2977619f,0.8325493f,-0.3929234f,-0.05475148f,-0.1562736f,-0.05486322f,0.9846679f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 20.69712f);
Get(0x6EC6).SetLocalPose(0.1825613f,0.8193505f,-0.5031254f,-0.1498884f,-0.01721485f,-0.9881862f,0.02693019f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321652f,1.538341f,0.4834301f,-0.6546333f,-0.2081771f,-0.2500444f,0.6823455f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 20.71629f);
Get(0x6E70).SetLocalPose(-0.1040698f,1.678937f,-0.4668097f,0.4567164f,-0.4496389f,-0.5382655f,0.5472708f);
Get(0x6E82).SetLocalPose(-0.2832112f,0.8162574f,-0.4162635f,-0.01259763f,-0.1844083f,-0.03796699f,0.9820354f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 20.71629f);
Get(0x6EC6).SetLocalPose(0.1822219f,0.819684f,-0.5042665f,-0.1558856f,-0.009390502f,-0.9874318f,0.02429012f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321935f,1.538448f,0.4833966f,-0.6546208f,-0.2081672f,-0.2499846f,0.6823825f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 20.73565f);
Get(0x6E70).SetLocalPose(-0.1052973f,1.679213f,-0.4652278f,0.4559034f,-0.4471906f,-0.5389962f,0.5492321f);
Get(0x6E82).SetLocalPose(-0.2698269f,0.8064822f,-0.4335865f,0.02255633f,-0.2006617f,-0.01875902f,0.9792213f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 20.73565f);
Get(0x6EC6).SetLocalPose(0.1820955f,0.8197832f,-0.5052582f,-0.1621131f,0.0009158815f,-0.9865506f,0.02089396f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322031f,1.53867f,0.4833089f,-0.6545932f,-0.2082264f,-0.2498957f,0.6824234f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 20.75557f);
Get(0x6E70).SetLocalPose(-0.1061681f,1.679108f,-0.4638881f,0.4552785f,-0.4444576f,-0.5398373f,0.5511395f);
Get(0x6E82).SetLocalPose(-0.2488007f,0.7975414f,-0.454707f,0.06917591f,-0.1975889f,0.01382296f,0.9777435f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 20.75557f);
Get(0x6EC6).SetLocalPose(0.1827783f,0.8178742f,-0.5071943f,-0.1695846f,0.0137174f,-0.9852897f,0.01603617f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322039f,1.538811f,0.4833442f,-0.6545101f,-0.2083962f,-0.2497461f,0.682506f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 20.77521f);
Get(0x6E70).SetLocalPose(-0.1071875f,1.67847f,-0.462603f,0.4548878f,-0.4416258f,-0.5405481f,0.5530384f);
Get(0x6E82).SetLocalPose(-0.2378314f,0.7948586f,-0.4641009f,0.09702867f,-0.2021374f,0.04190978f,0.9736372f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 20.77521f);
Get(0x6EC6).SetLocalPose(0.1837724f,0.8158525f,-0.5086641f,-0.176697f,0.0269612f,-0.9838419f,0.01031443f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322088f,1.538918f,0.4832098f,-0.6544889f,-0.2084467f,-0.2496399f,0.6825498f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 20.79531f);
Get(0x6E70).SetLocalPose(-0.1079421f,1.678424f,-0.4613526f,0.4547673f,-0.4392567f,-0.5407535f,0.5548206f);
Get(0x6E82).SetLocalPose(-0.2409398f,0.8000941f,-0.4629767f,0.05754697f,-0.2087355f,0.00715722f,0.9762513f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 20.79531f);
Get(0x6EC6).SetLocalPose(0.1848692f,0.8139945f,-0.5090876f,-0.1840416f,0.03997066f,-0.9820998f,0.003320564f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322224f,1.53895f,0.4828534f,-0.6545185f,-0.2084135f,-0.2495928f,0.6825488f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 20.816f);
Get(0x6E70).SetLocalPose(-0.1085559f,1.677828f,-0.4598432f,0.4546606f,-0.4368286f,-0.5402985f,0.557263f);
Get(0x6E82).SetLocalPose(-0.2451827f,0.8061025f,-0.4594691f,0.0428464f,-0.2153848f,-0.004585962f,0.9755781f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 20.816f);
Get(0x6EC6).SetLocalPose(0.1841973f,0.814311f,-0.5066787f,-0.1902583f,0.04701021f,-0.9806069f,-0.001414374f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322278f,1.539118f,0.4829021f,-0.6545495f,-0.2083506f,-0.249709f,0.6824957f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 20.83585f);
Get(0x6E70).SetLocalPose(-0.1090644f,1.676973f,-0.4590723f,0.4544692f,-0.4357877f,-0.539504f,0.5590012f);
Get(0x6E82).SetLocalPose(-0.2487828f,0.809673f,-0.4564744f,0.04514106f,-0.2147923f,0.009709632f,0.9755676f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 20.83585f);
Get(0x6EC6).SetLocalPose(0.1855197f,0.8145055f,-0.5045511f,-0.1960066f,0.04951642f,-0.9793469f,-0.003041506f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322656f,1.539056f,0.4828301f,-0.6545746f,-0.2082881f,-0.2497552f,0.6824738f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 20.85625f);
Get(0x6E70).SetLocalPose(-0.1094811f,1.676539f,-0.4584036f,0.4544961f,-0.435375f,-0.5388723f,0.5599095f);
Get(0x6E82).SetLocalPose(-0.2504945f,0.8135939f,-0.4557014f,0.04659116f,-0.1942863f,0.02003607f,0.979633f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 20.85625f);
Get(0x6EC6).SetLocalPose(0.1861805f,0.8149036f,-0.5030544f,-0.1984848f,0.04891356f,-0.9788789f,-0.002756037f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322875f,1.539063f,0.4827961f,-0.6545551f,-0.208274f,-0.2497466f,0.6825001f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 20.8765f);
Get(0x6E70).SetLocalPose(-0.1096496f,1.676335f,-0.4581035f,0.4550012f,-0.4350923f,-0.5387118f,0.5598735f);
Get(0x6E82).SetLocalPose(-0.2505231f,0.8163812f,-0.4547252f,0.04961479f,-0.1693694f,0.0301934f,0.9838398f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 20.8765f);
Get(0x6EC6).SetLocalPose(0.1866807f,0.8137035f,-0.5022528f,-0.1980453f,0.04780552f,-0.9790245f,-0.001945881f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.323121f,1.538987f,0.4827957f,-0.654479f,-0.208368f,-0.249661f,0.6825755f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 20.89672f);
Get(0x6E70).SetLocalPose(-0.1101046f,1.675388f,-0.4581505f,0.4562347f,-0.4346929f,-0.5388068f,0.5590879f);
Get(0x6E82).SetLocalPose(-0.2518689f,0.8173351f,-0.4539538f,0.05705921f,-0.1519461f,0.03689377f,0.9860505f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 20.89672f);
Get(0x6EC6).SetLocalPose(0.1861347f,0.8139691f,-0.5009554f,-0.1964472f,0.04770172f,-0.9793518f,-0.001737395f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.323145f,1.538977f,0.4829047f,-0.6544445f,-0.2084468f,-0.2495403f,0.6826288f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 20.91672f);
Get(0x6E70).SetLocalPose(-0.1105627f,1.674754f,-0.457998f,0.4579018f,-0.4344259f,-0.5388656f,0.5578745f);
Get(0x6E82).SetLocalPose(-0.2522128f,0.8177236f,-0.4533148f,0.06344404f,-0.1441641f,0.03914822f,0.9867417f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 20.91672f);
Get(0x6EC6).SetLocalPose(0.185599f,0.8139467f,-0.49977f,-0.1936176f,0.0477748f,-0.9799121f,-0.001474679f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.323148f,1.53869f,0.482893f,-0.6544432f,-0.2084714f,-0.2494321f,0.6826621f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 20.93662f);
Get(0x6E70).SetLocalPose(-0.1111263f,1.674205f,-0.4580055f,0.4592066f,-0.4347872f,-0.5388388f,0.5565449f);
Get(0x6E82).SetLocalPose(-0.2520585f,0.817319f,-0.4523912f,0.0662597f,-0.139649f,0.03988519f,0.9871763f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 20.93662f);
Get(0x6EC6).SetLocalPose(0.1854699f,0.8145637f,-0.4984263f,-0.1902933f,0.04844116f,-0.9805303f,-0.001502859f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322992f,1.538622f,0.482817f,-0.6544722f,-0.2084629f,-0.2494811f,0.6826189f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 20.95664f);
Get(0x6E70).SetLocalPose(-0.1116605f,1.674201f,-0.4579038f,0.4598624f,-0.4358352f,-0.5385201f,0.5554912f);
Get(0x6E82).SetLocalPose(-0.2513789f,0.8167164f,-0.4520249f,0.06915609f,-0.1385316f,0.0429329f,0.9870073f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 20.95664f);
Get(0x6EC6).SetLocalPose(0.1856643f,0.815257f,-0.4966229f,-0.1867805f,0.04984642f,-0.9811347f,-0.001765794f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.323004f,1.538466f,0.4828201f,-0.6545241f,-0.2083565f,-0.2495847f,0.6825637f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 20.97527f);
Get(0x6E70).SetLocalPose(-0.1122217f,1.674257f,-0.457968f,0.4598123f,-0.4371925f,-0.5380614f,0.5549101f);
Get(0x6E82).SetLocalPose(-0.2496094f,0.8162256f,-0.4526459f,0.07145374f,-0.1376739f,0.04431069f,0.9869027f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 20.97527f);
Get(0x6EC6).SetLocalPose(0.1858443f,0.8150371f,-0.4945055f,-0.1829252f,0.05072214f,-0.9818164f,-0.001516689f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322992f,1.538455f,0.4827163f,-0.6545295f,-0.2082976f,-0.2496217f,0.6825631f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 20.99387f);
Get(0x6E70).SetLocalPose(-0.1129776f,1.674565f,-0.4574323f,0.4593403f,-0.4388242f,-0.5373785f,0.5546748f);
Get(0x6E82).SetLocalPose(-0.2467145f,0.8146657f,-0.452933f,0.07230709f,-0.1337774f,0.04224728f,0.9874667f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 20.99387f);
Get(0x6EC6).SetLocalPose(0.1863483f,0.8151251f,-0.4936518f,-0.1788611f,0.05110721f,-0.9825458f,-0.0007517189f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322704f,1.538284f,0.4830295f,-0.6545398f,-0.2082108f,-0.2497829f,0.6825207f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 21.01526f);
Get(0x6E70).SetLocalPose(-0.1135143f,1.675346f,-0.4570433f,0.4588106f,-0.4403009f,-0.5366185f,0.5546789f);
Get(0x6E82).SetLocalPose(-0.2447366f,0.8122314f,-0.4519893f,0.07137845f,-0.1297296f,0.03806381f,0.9882442f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 21.01526f);
Get(0x6EC6).SetLocalPose(0.184739f,0.815378f,-0.4918327f,-0.1750468f,0.05121876f,-0.983227f,-1.40192E-05f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 21.01526f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 21.01526f);
});
r.Add(delegate{
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 21.01526f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 21.01526f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322458f,1.538398f,0.4831593f,-0.6544796f,-0.2083814f,-0.2496084f,0.6825902f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 21.07723f);
Get(0x6E70).SetLocalPose(-0.1143682f,1.676974f,-0.4555847f,0.4582759f,-0.442015f,-0.5350809f,0.5552427f);
Get(0x6E82).SetLocalPose(-0.2429017f,0.8110879f,-0.4479929f,0.06351831f,-0.1330798f,0.02780677f,0.988677f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 21.07723f);
Get(0x6EC6).SetLocalPose(0.1800072f,0.8199047f,-0.491228f,-0.1677421f,0.05173565f,-0.9844714f,0.001450699f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322183f,1.538561f,0.4832323f,-0.6545097f,-0.2084078f,-0.2496052f,0.6825544f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 21.09369f);
Get(0x6E70).SetLocalPose(-0.114615f,1.67696f,-0.4554335f,0.4584189f,-0.4419849f,-0.5349208f,0.5553028f);
Get(0x6E82).SetLocalPose(-0.2434972f,0.8112074f,-0.4475743f,0.06164022f,-0.1329081f,0.02572977f,0.9888752f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 21.09369f);
Get(0x6EC6).SetLocalPose(0.1799353f,0.8199511f,-0.4923512f,-0.166889f,0.05194849f,-0.9846046f,0.001788649f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322335f,1.538347f,0.4831412f,-0.654542f,-0.2083365f,-0.2497034f,0.6825092f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 21.11907f);
Get(0x6E70).SetLocalPose(-0.1145745f,1.676286f,-0.454906f,0.4588929f,-0.4418792f,-0.534618f,0.5552871f);
Get(0x6E82).SetLocalPose(-0.2440759f,0.8120323f,-0.4475134f,0.05956703f,-0.1324254f,0.02411442f,0.9891076f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 21.11907f);
Get(0x6EC6).SetLocalPose(0.1805022f,0.8194316f,-0.4935609f,-0.1670753f,0.05205407f,-0.9845662f,0.002411365f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322294f,1.538437f,0.4831105f,-0.6545554f,-0.2082696f,-0.2497663f,0.6824938f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 21.13101f);
Get(0x6E70).SetLocalPose(-0.1147498f,1.676287f,-0.454546f,0.4592019f,-0.441808f,-0.534479f,0.5552221f);
Get(0x6E82).SetLocalPose(-0.2444961f,0.8126937f,-0.4475203f,0.05969337f,-0.1322386f,0.023934f,0.9891294f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 21.13101f);
Get(0x6EC6).SetLocalPose(0.1802254f,0.8178361f,-0.4936485f,-0.1678942f,0.05206655f,-0.9844255f,0.002680034f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322203f,1.538186f,0.4831099f,-0.6545578f,-0.2081711f,-0.2498656f,0.6824852f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 21.15787f);
Get(0x6E70).SetLocalPose(-0.1146731f,1.676289f,-0.4540396f,0.4599753f,-0.4418184f,-0.5341662f,0.5548746f);
Get(0x6E82).SetLocalPose(-0.2446039f,0.8136457f,-0.4475901f,0.05960215f,-0.131904f,0.02405685f,0.9891765f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 21.15787f);
Get(0x6EC6).SetLocalPose(0.1801607f,0.8179277f,-0.4940329f,-0.170088f,0.05227977f,-0.9840366f,0.002969204f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322236f,1.538229f,0.4831774f,-0.6545525f,-0.2081984f,-0.2498172f,0.6824998f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 21.17271f);
Get(0x6E70).SetLocalPose(-0.115027f,1.676661f,-0.453743f,0.460487f,-0.4419285f,-0.5339989f,0.5545233f);
Get(0x6E82).SetLocalPose(-0.2448276f,0.81414f,-0.4475472f,0.05941514f,-0.1318434f,0.02383542f,0.9892013f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 21.17271f);
Get(0x6EC6).SetLocalPose(0.1802591f,0.8174556f,-0.4935897f,-0.1715465f,0.05238466f,-0.9837779f,0.002980468f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322253f,1.538142f,0.4831504f,-0.6545049f,-0.2082858f,-0.2497525f,0.6825424f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 21.19564f);
Get(0x6E70).SetLocalPose(-0.115015f,1.676776f,-0.4534849f,0.4609751f,-0.4420941f,-0.5338345f,0.554144f);
Get(0x6E82).SetLocalPose(-0.2443134f,0.8148333f,-0.448061f,0.05987279f,-0.1324739f,0.02403597f,0.9890845f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 21.19564f);
Get(0x6EC6).SetLocalPose(0.1810339f,0.8190232f,-0.4935615f,-0.1724898f,0.05223181f,-0.9836206f,0.003100712f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322301f,1.538155f,0.4831616f,-0.6544994f,-0.208371f,-0.2496767f,0.6825494f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 21.21631f);
Get(0x6E70).SetLocalPose(-0.1154172f,1.676355f,-0.453042f,0.4613316f,-0.4422621f,-0.5337746f,0.5537708f);
Get(0x6E82).SetLocalPose(-0.2440401f,0.8157838f,-0.4482051f,0.06064818f,-0.1330239f,0.02418435f,0.9889599f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 21.21631f);
Get(0x6EC6).SetLocalPose(0.18151f,0.8185452f,-0.4931264f,-0.1733699f,0.0523141f,-0.9834613f,0.003157308f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322232f,1.538426f,0.4831969f,-0.6545408f,-0.2083693f,-0.2496412f,0.6825231f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 21.23856f);
Get(0x6E70).SetLocalPose(-0.1157398f,1.676009f,-0.4526405f,0.4617238f,-0.4423409f,-0.5337272f,0.5534266f);
Get(0x6E82).SetLocalPose(-0.243676f,0.814999f,-0.4494528f,0.06183276f,-0.1338842f,0.0241111f,0.9887722f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 21.23856f);
Get(0x6EC6).SetLocalPose(0.1814687f,0.8187253f,-0.4923273f,-0.1742216f,0.05207975f,-0.9833231f,0.003196016f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322242f,1.5384f,0.483141f,-0.6545514f,-0.2083857f,-0.2497114f,0.6824823f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 21.24964f);
Get(0x6E70).SetLocalPose(-0.1159389f,1.675818f,-0.4524246f,0.4619004f,-0.4423605f,-0.5337189f,0.5532715f);
Get(0x6E82).SetLocalPose(-0.2439031f,0.8148689f,-0.4503444f,0.06244618f,-0.1343683f,0.02396605f,0.9886715f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 21.24964f);
Get(0x6EC6).SetLocalPose(0.1818399f,0.8187249f,-0.4917434f,-0.1748974f,0.05205034f,-0.9832049f,0.00312456f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322315f,1.538497f,0.483168f,-0.6545609f,-0.2082905f,-0.2498081f,0.6824669f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 21.27553f);
Get(0x6E70).SetLocalPose(-0.1163636f,1.676009f,-0.451447f,0.462264f,-0.4423725f,-0.5335962f,0.5530766f);
Get(0x6E82).SetLocalPose(-0.2445831f,0.8141168f,-0.4506677f,0.06368382f,-0.1350013f,0.02269911f,0.9885362f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 21.27553f);
Get(0x6EC6).SetLocalPose(0.1820317f,0.8200743f,-0.4908368f,-0.1752798f,0.05252089f,-0.9831094f,0.003824454f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32244f,1.538356f,0.4831417f,-0.6545602f,-0.208231f,-0.2498446f,0.6824723f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 21.29913f);
Get(0x6E70).SetLocalPose(-0.1171159f,1.676162f,-0.4506271f,0.4626054f,-0.4425385f,-0.533229f,0.5530124f);
Get(0x6E82).SetLocalPose(-0.2446088f,0.8152401f,-0.4493091f,0.06360951f,-0.1325278f,0.01901121f,0.9889534f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 21.29913f);
Get(0x6EC6).SetLocalPose(0.183293f,0.8230923f,-0.4903072f,-0.1756837f,0.05214677f,-0.9830281f,0.008462779f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322393f,1.538176f,0.4832183f,-0.6545432f,-0.2082644f,-0.2498163f,0.6824889f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 21.31998f);
Get(0x6E70).SetLocalPose(-0.1180446f,1.67666f,-0.4501653f,0.4626252f,-0.4430277f,-0.5327712f,0.5530454f);
Get(0x6E82).SetLocalPose(-0.2435491f,0.8159417f,-0.4491102f,0.06420165f,-0.12846f,0.01387996f,0.9895371f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 21.31998f);
Get(0x6EC6).SetLocalPose(0.1844008f,0.8261188f,-0.489109f,-0.175959f,0.05315687f,-0.9828139f,0.0170233f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322412f,1.538328f,0.4833136f,-0.6545286f,-0.2082796f,-0.2497998f,0.6825042f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 21.3289f);
Get(0x6E70).SetLocalPose(-0.1180649f,1.676683f,-0.4498414f,0.4625203f,-0.4433634f,-0.5325412f,0.5530856f);
Get(0x6E82).SetLocalPose(-0.2435679f,0.8172576f,-0.449035f,0.06491229f,-0.1247004f,0.008572123f,0.9900317f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 21.3289f);
Get(0x6EC6).SetLocalPose(0.1860493f,0.8268999f,-0.4894058f,-0.175086f,0.05400097f,-0.9828179f,0.02231183f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322364f,1.538318f,0.4831913f,-0.6545321f,-0.2083501f,-0.2496973f,0.6825169f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 21.35138f);
Get(0x6E70).SetLocalPose(-0.1181118f,1.677101f,-0.4489222f,0.4623005f,-0.4438796f,-0.5320969f,0.553283f);
Get(0x6E82).SetLocalPose(-0.2439153f,0.8179958f,-0.4486047f,0.06638821f,-0.1168983f,-0.003578201f,0.9909161f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 21.35138f);
Get(0x6EC6).SetLocalPose(0.1879655f,0.8300769f,-0.4896217f,-0.171139f,0.05588181f,-0.9830655f,0.03421996f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322322f,1.538327f,0.4831978f,-0.6545461f,-0.2083767f,-0.2496599f,0.682509f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 21.37201f);
Get(0x6E70).SetLocalPose(-0.1185717f,1.67689f,-0.448201f,0.4621555f,-0.4438978f,-0.5319083f,0.5535707f);
Get(0x6E82).SetLocalPose(-0.2452755f,0.8209667f,-0.4474504f,0.06736443f,-0.107176f,-0.01733132f,0.9918039f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 21.37201f);
Get(0x6EC6).SetLocalPose(0.1899923f,0.833138f,-0.490591f,-0.1624785f,0.0577393f,-0.9838539f,0.04794039f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322259f,1.538436f,0.4831703f,-0.6545613f,-0.2083853f,-0.2497055f,0.6824751f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 21.39163f);
Get(0x6E70).SetLocalPose(-0.1190703f,1.677102f,-0.4473272f,0.4622568f,-0.4436932f,-0.5317078f,0.5538428f);
Get(0x6E82).SetLocalPose(-0.2477296f,0.82358f,-0.4460731f,0.0680961f,-0.08912073f,-0.03746865f,0.9929836f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 21.39163f);
Get(0x6EC6).SetLocalPose(0.1904951f,0.8369166f,-0.4931861f,-0.1497006f,0.06298066f,-0.9846268f,0.06429005f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322287f,1.538442f,0.4831693f,-0.6545621f,-0.2082943f,-0.2497485f,0.6824864f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 21.41233f);
Get(0x6E70).SetLocalPose(-0.1195307f,1.676846f,-0.446436f,0.4626173f,-0.4431188f,-0.5315076f,0.5541937f);
Get(0x6E82).SetLocalPose(-0.2514138f,0.8265194f,-0.4452448f,0.06891564f,-0.06605506f,-0.0591528f,0.9936742f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 21.41233f);
Get(0x6EC6).SetLocalPose(0.1930645f,0.8396578f,-0.4962687f,-0.1341656f,0.07258677f,-0.9850354f,0.08022562f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322276f,1.538337f,0.4832734f,-0.6545531f,-0.208247f,-0.2498085f,0.6824875f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 21.43278f);
Get(0x6E70).SetLocalPose(-0.1197366f,1.676079f,-0.4456578f,0.4631784f,-0.4423698f,-0.5314308f,0.554397f);
Get(0x6E82).SetLocalPose(-0.2537873f,0.8310255f,-0.444276f,0.06987955f,-0.04698768f,-0.07643837f,0.993512f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 21.43278f);
Get(0x6EC6).SetLocalPose(0.1951004f,0.8413602f,-0.5012695f,-0.1216341f,0.08517936f,-0.9846405f,0.0918292f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322334f,1.538458f,0.4833448f,-0.65454f,-0.2082712f,-0.2498117f,0.6824915f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 21.45531f);
Get(0x6E70).SetLocalPose(-0.1204141f,1.675734f,-0.4445583f,0.4639941f,-0.4415517f,-0.531417f,0.5543804f);
Get(0x6E82).SetLocalPose(-0.2575159f,0.8358568f,-0.443903f,0.07203646f,-0.02883675f,-0.09110858f,0.9928134f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 21.45531f);
Get(0x6EC6).SetLocalPose(0.1984329f,0.8424635f,-0.5088556f,-0.1035995f,0.1026742f,-0.9841675f,0.1006956f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322299f,1.538499f,0.4833266f,-0.6545354f,-0.2083f,-0.2497486f,0.6825103f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 21.46676f);
Get(0x6E70).SetLocalPose(-0.1208624f,1.675617f,-0.4437906f,0.4646924f,-0.4410406f,-0.5314208f,0.5541987f);
Get(0x6E82).SetLocalPose(-0.2594763f,0.8381532f,-0.4442245f,0.0752176f,-0.02251279f,-0.09703728f,0.9921791f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 21.46676f);
Get(0x6EC6).SetLocalPose(0.1996891f,0.8426555f,-0.5129603f,-0.09247125f,0.1138755f,-0.9838924f,0.1021619f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322399f,1.53851f,0.4832722f,-0.6545277f,-0.2083522f,-0.2496954f,0.682521f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 21.49105f);
Get(0x6E70).SetLocalPose(-0.121678f,1.674901f,-0.4425996f,0.4660321f,-0.4403666f,-0.5313423f,0.5536846f);
Get(0x6E82).SetLocalPose(-0.2625703f,0.8421907f,-0.4465024f,0.08542233f,-0.01139729f,-0.1032245f,0.9909177f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 21.49105f);
Get(0x6EC6).SetLocalPose(0.2044962f,0.84278f,-0.522195f,-0.0792877f,0.1388558f,-0.9826254f,0.09423281f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322473f,1.538558f,0.4831394f,-0.6545193f,-0.2084177f,-0.2496199f,0.6825368f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 21.51965f);
Get(0x6E70).SetLocalPose(-0.1224961f,1.674378f,-0.441821f,0.4681855f,-0.439318f,-0.53179f,0.5522693f);
Get(0x6E82).SetLocalPose(-0.2647892f,0.8438861f,-0.4499257f,0.09900196f,0.0008399423f,-0.1025807f,0.9897854f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 21.51965f);
Get(0x6EC6).SetLocalPose(0.209308f,0.8450147f,-0.5318508f,-0.08296571f,0.1703343f,-0.9793047f,0.07117017f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322464f,1.538531f,0.4831157f,-0.6545381f,-0.2083767f,-0.2496594f,0.6825169f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 21.53843f);
Get(0x6E70).SetLocalPose(-0.1231658f,1.673725f,-0.4409363f,0.469425f,-0.4387412f,-0.5324335f,0.5510544f);
Get(0x6E82).SetLocalPose(-0.268512f,0.8464437f,-0.4531479f,0.118349f,0.002542987f,-0.09199492f,0.9886981f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 21.53843f);
Get(0x6EC6).SetLocalPose(0.212299f,0.8482193f,-0.5369643f,-0.1025677f,0.1919179f,-0.9751961f,0.04049619f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32253f,1.538542f,0.483108f,-0.6545398f,-0.2083251f,-0.2497087f,0.682513f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 21.54848f);
Get(0x6E70).SetLocalPose(-0.1232593f,1.673355f,-0.440653f,0.4701979f,-0.438361f,-0.5329938f,0.5501556f);
Get(0x6E82).SetLocalPose(-0.2699296f,0.8475311f,-0.4543406f,0.1255886f,0.001174662f,-0.08570185f,0.9883731f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 21.54848f);
Get(0x6EC6).SetLocalPose(0.2118757f,0.8484352f,-0.5417486f,-0.1205559f,0.2037372f,-0.971434f,0.01653869f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322441f,1.53841f,0.4832136f,-0.6545393f,-0.2082404f,-0.2497978f,0.6825067f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 21.57452f);
Get(0x6E70).SetLocalPose(-0.1237236f,1.67268f,-0.4391164f,0.4716976f,-0.437484f,-0.5341726f,0.5484239f);
Get(0x6E82).SetLocalPose(-0.2727605f,0.850154f,-0.458119f,0.1405329f,-0.004959743f,-0.06825373f,0.9877082f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 21.57452f);
Get(0x6EC6).SetLocalPose(0.2132597f,0.8493173f,-0.5471924f,-0.1582839f,0.2213321f,-0.9616541f,-0.03434654f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322471f,1.5385f,0.4831944f,-0.6545409f,-0.2082178f,-0.2497942f,0.6825133f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 21.59741f);
Get(0x6E70).SetLocalPose(-0.1242274f,1.672528f,-0.4377044f,0.473585f,-0.4361697f,-0.5351775f,0.5468624f);
Get(0x6E82).SetLocalPose(-0.2740469f,0.8511676f,-0.4626662f,0.1537611f,-0.01785017f,-0.04390638f,0.9869707f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 21.59741f);
Get(0x6EC6).SetLocalPose(0.2150406f,0.8548658f,-0.5486067f,-0.179362f,0.2162541f,-0.9576063f,-0.06366894f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322472f,1.538366f,0.4830506f,-0.6545267f,-0.2082805f,-0.249752f,0.6825233f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 21.61959f);
Get(0x6E70).SetLocalPose(-0.124274f,1.67087f,-0.4371882f,0.4758703f,-0.4346123f,-0.5359002f,0.5454086f);
Get(0x6E82).SetLocalPose(-0.2741797f,0.8537588f,-0.4652879f,0.1642414f,-0.03285279f,-0.01736704f,0.98572f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 21.61959f);
Get(0x6EC6).SetLocalPose(0.2182615f,0.8579561f,-0.5472383f,-0.2017182f,0.1889461f,-0.957984f,-0.07665472f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322356f,1.538295f,0.4830776f,-0.654542f,-0.2083224f,-0.2497252f,0.6825056f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 21.63014f);
Get(0x6E70).SetLocalPose(-0.1248615f,1.670842f,-0.4362991f,0.4769971f,-0.4338549f,-0.5364406f,0.5444954f);
Get(0x6E82).SetLocalPose(-0.2730851f,0.8540373f,-0.4656375f,0.1658989f,-0.04102857f,-0.005890746f,0.9852713f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 21.63014f);
Get(0x6EC6).SetLocalPose(0.2190762f,0.8581243f,-0.5488214f,-0.2095295f,0.1758415f,-0.9588135f,-0.07650997f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322204f,1.538348f,0.4831632f,-0.6545502f,-0.2083464f,-0.2496927f,0.6825023f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 21.65395f);
Get(0x6E70).SetLocalPose(-0.1253964f,1.67058f,-0.4345926f,0.4788912f,-0.432535f,-0.5376968f,0.5426407f);
Get(0x6E82).SetLocalPose(-0.2742165f,0.8537934f,-0.4689078f,0.1625288f,-0.06479856f,0.01408452f,0.9844731f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 21.65395f);
Get(0x6EC6).SetLocalPose(0.2231767f,0.85985f,-0.5514881f,-0.2350775f,0.1340234f,-0.9601624f,-0.06974537f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322088f,1.538444f,0.4832121f,-0.6545745f,-0.2083228f,-0.2496939f,0.6824858f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 21.67521f);
Get(0x6E70).SetLocalPose(-0.1260146f,1.66949f,-0.4335662f,0.4807169f,-0.4310839f,-0.5391744f,0.5407114f);
Get(0x6E82).SetLocalPose(-0.2756591f,0.8537738f,-0.4694435f,0.1562073f,-0.07963352f,0.01916191f,0.9843225f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 21.67521f);
Get(0x6EC6).SetLocalPose(0.2244164f,0.8598861f,-0.5520871f,-0.2639838f,0.1071348f,-0.9563805f,-0.06458415f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321965f,1.53838f,0.4832871f,-0.6545801f,-0.2082712f,-0.2497836f,0.6824634f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 21.69564f);
Get(0x6E70).SetLocalPose(-0.1267091f,1.668196f,-0.4323814f,0.4821766f,-0.4299133f,-0.5405939f,0.5389236f);
Get(0x6E82).SetLocalPose(-0.2770278f,0.853032f,-0.4707718f,0.1506061f,-0.09475237f,0.02471543f,0.9837322f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 21.69564f);
Get(0x6EC6).SetLocalPose(0.2266817f,0.8601825f,-0.5518838f,-0.2989782f,0.07970535f,-0.9490439f,-0.05978978f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321982f,1.538284f,0.483263f,-0.6545786f,-0.2082049f,-0.2498457f,0.6824623f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 21.71576f);
Get(0x6E70).SetLocalPose(-0.1272223f,1.667885f,-0.4313576f,0.4835449f,-0.4289766f,-0.5418849f,0.5371445f);
Get(0x6E82).SetLocalPose(-0.2800497f,0.8523385f,-0.4707797f,0.1432319f,-0.1143787f,0.03424398f,0.982461f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 21.71576f);
Get(0x6EC6).SetLocalPose(0.2251683f,0.8649605f,-0.5484717f,-0.324268f,0.05815553f,-0.9428421f,-0.0501716f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322071f,1.538347f,0.4831678f,-0.6545738f,-0.2081956f,-0.2498457f,0.6824697f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 21.7352f);
Get(0x6E70).SetLocalPose(-0.1272145f,1.667464f,-0.4304161f,0.4845889f,-0.4285158f,-0.5427842f,0.5356615f);
Get(0x6E82).SetLocalPose(-0.2817841f,0.8512094f,-0.4708122f,0.1359732f,-0.1366051f,0.04311321f,0.9803018f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 21.7352f);
Get(0x6EC6).SetLocalPose(0.223549f,0.8665437f,-0.5484591f,-0.3297315f,0.04228193f,-0.9424137f,-0.03668591f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322111f,1.538381f,0.483273f,-0.654568f,-0.2082663f,-0.2498007f,0.6824702f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 21.75469f);
Get(0x6E70).SetLocalPose(-0.1275179f,1.667602f,-0.4296688f,0.4857836f,-0.4283286f,-0.5432994f,0.5342048f);
Get(0x6E82).SetLocalPose(-0.2832505f,0.8523762f,-0.4719562f,0.1272234f,-0.1534932f,0.05030717f,0.9786334f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 21.75469f);
Get(0x6EC6).SetLocalPose(0.2222369f,0.8684213f,-0.5462913f,-0.3399206f,0.02709032f,-0.9398115f,-0.02178149f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322078f,1.538372f,0.4832873f,-0.6545549f,-0.2083092f,-0.249734f,0.6824941f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 21.7753f);
Get(0x6E70).SetLocalPose(-0.1277063f,1.667323f,-0.4286586f,0.4866816f,-0.4285257f,-0.5434194f,0.5331061f);
Get(0x6E82).SetLocalPose(-0.2875343f,0.854455f,-0.4726123f,0.117755f,-0.1808848f,0.05916227f,0.9746355f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 21.7753f);
Get(0x6EC6).SetLocalPose(0.2220646f,0.8699155f,-0.5455497f,-0.3499703f,0.02007087f,-0.9364385f,-0.01417407f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.3221f,1.538426f,0.4831479f,-0.6545507f,-0.2083599f,-0.2497084f,0.682492f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 21.79524f);
Get(0x6E70).SetLocalPose(-0.1281619f,1.666898f,-0.4278285f,0.4879152f,-0.4288734f,-0.5435321f,0.5315818f);
Get(0x6E82).SetLocalPose(-0.2893181f,0.8574888f,-0.4761868f,0.1140756f,-0.1886115f,0.06342658f,0.9733394f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 21.79524f);
Get(0x6EC6).SetLocalPose(0.2238125f,0.8701738f,-0.5416561f,-0.3654144f,0.01010189f,-0.9307748f,-0.005336284f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.322119f,1.538535f,0.4830228f,-0.6545304f,-0.2083312f,-0.2497229f,0.682515f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 21.81483f);
Get(0x6E70).SetLocalPose(-0.1288063f,1.66601f,-0.4269475f,0.489479f,-0.429251f,-0.5436649f,0.5297003f);
Get(0x6E82).SetLocalPose(-0.2909881f,0.8601326f,-0.480092f,0.1088797f,-0.1945166f,0.06789583f,0.9724704f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 21.81483f);
Get(0x6EC6).SetLocalPose(0.2236979f,0.8741244f,-0.5363891f,-0.3721897f,-0.004224035f,-0.9281349f,0.004761021f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321983f,1.538334f,0.4830917f,-0.6545175f,-0.208266f,-0.2497832f,0.6825252f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 21.83454f);
Get(0x6E70).SetLocalPose(-0.1290264f,1.665535f,-0.4259022f,0.4907311f,-0.4296075f,-0.543465f,0.5284565f);
Get(0x6E82).SetLocalPose(-0.2939118f,0.8648723f,-0.4846605f,0.106166f,-0.2034322f,0.07432605f,0.9704739f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 21.83454f);
Get(0x6EC6).SetLocalPose(0.224474f,0.8792872f,-0.5319889f,-0.3743938f,-0.01594711f,-0.9270527f,0.01218209f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321883f,1.538283f,0.4833487f,-0.6545221f,-0.2082431f,-0.2498307f,0.6825103f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 21.85331f);
Get(0x6E70).SetLocalPose(-0.1287362f,1.665884f,-0.4253187f,0.4914573f,-0.4299324f,-0.5432658f,0.5277216f);
Get(0x6E82).SetLocalPose(-0.2964393f,0.8688328f,-0.4899679f,0.1068079f,-0.2171685f,0.08403627f,0.9666271f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 21.85331f);
Get(0x6EC6).SetLocalPose(0.2250995f,0.8828574f,-0.5247277f,-0.3756797f,-0.02586064f,-0.9261463f,0.02119006f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321958f,1.538072f,0.4834128f,-0.6545606f,-0.2082174f,-0.2498748f,0.6824651f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 21.87413f);
Get(0x6E70).SetLocalPose(-0.1287229f,1.665932f,-0.4246586f,0.4917421f,-0.4302513f,-0.5437239f,0.5267239f);
Get(0x6E82).SetLocalPose(-0.3005569f,0.872591f,-0.4976646f,0.1132944f,-0.2322438f,0.09597182f,0.9612578f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 21.87413f);
Get(0x6EC6).SetLocalPose(0.2246809f,0.8848627f,-0.5188518f,-0.3707224f,-0.0322321f,-0.9277307f,0.02901122f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321965f,1.53798f,0.4833545f,-0.654542f,-0.2082352f,-0.2498918f,0.6824713f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 21.89312f);
Get(0x6E70).SetLocalPose(-0.1283577f,1.666298f,-0.4240571f,0.4919759f,-0.4303213f,-0.5456709f,0.5244299f);
Get(0x6E82).SetLocalPose(-0.3040571f,0.8747418f,-0.5041195f,0.1178726f,-0.2424559f,0.1025837f,0.9574956f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 21.89312f);
Get(0x6EC6).SetLocalPose(0.2233632f,0.8865587f,-0.5143369f,-0.3642747f,-0.03601176f,-0.9299997f,0.03328197f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321758f,1.537886f,0.4833969f,-0.6545387f,-0.2082792f,-0.2498623f,0.6824718f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 21.91352f);
Get(0x6E70).SetLocalPose(-0.1277654f,1.666555f,-0.4236017f,0.492202f,-0.429981f,-0.5479187f,0.5221481f);
Get(0x6E82).SetLocalPose(-0.308235f,0.8771842f,-0.510574f,0.1223972f,-0.2545927f,0.1076504f,0.9532119f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 21.91352f);
Get(0x6EC6).SetLocalPose(0.2207182f,0.8871134f,-0.50841f,-0.3484862f,-0.0416995f,-0.9355283f,0.04006604f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321726f,1.537817f,0.4833415f,-0.6545444f,-0.2083327f,-0.2498402f,0.682458f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 21.93281f);
Get(0x6E70).SetLocalPose(-0.1274047f,1.666796f,-0.4237691f,0.4921018f,-0.429499f,-0.5505533f,0.5198631f);
Get(0x6E82).SetLocalPose(-0.3124358f,0.8801093f,-0.5188318f,0.1229707f,-0.2660802f,0.1088845f,0.9498546f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 21.93281f);
Get(0x6EC6).SetLocalPose(0.2146271f,0.8898558f,-0.5033025f,-0.3308614f,-0.04378333f,-0.9414664f,0.04748441f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321648f,1.537877f,0.4832702f,-0.6545254f,-0.2083616f,-0.2498508f,0.6824636f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 21.95195f);
Get(0x6E70).SetLocalPose(-0.1262656f,1.667125f,-0.4236191f,0.4909577f,-0.428712f,-0.5549683f,0.5168916f);
Get(0x6E82).SetLocalPose(-0.315164f,0.8820737f,-0.5255631f,0.1237682f,-0.2724713f,0.1091122f,0.947911f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 21.95195f);
Get(0x6EC6).SetLocalPose(0.2119317f,0.8914664f,-0.5009862f,-0.3246603f,-0.04271542f,-0.9433609f,0.05330471f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321505f,1.538039f,0.4833431f,-0.654514f,-0.2082585f,-0.2499333f,0.6824759f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 21.97877f);
Get(0x6E70).SetLocalPose(-0.1253557f,1.667221f,-0.4234547f,0.4886704f,-0.4277462f,-0.5590268f,0.5154838f);
Get(0x6E82).SetLocalPose(-0.3174428f,0.8825914f,-0.5325223f,0.1275144f,-0.2844827f,0.1092476f,0.9438615f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 21.97877f);
Get(0x6EC6).SetLocalPose(0.2124468f,0.8908479f,-0.5000716f,-0.3204304f,-0.03836015f,-0.9447589f,0.05730361f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.32158f,1.537971f,0.483321f,-0.654502f,-0.208252f,-0.2499779f,0.6824729f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 21.99025f);
Get(0x6E70).SetLocalPose(-0.1249869f,1.666973f,-0.423601f,0.4873992f,-0.4272445f,-0.5603653f,0.51565f);
Get(0x6E82).SetLocalPose(-0.3189158f,0.8814686f,-0.5339873f,0.1277385f,-0.2904484f,0.1061545f,0.9423661f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 21.99025f);
Get(0x6EC6).SetLocalPose(0.2123327f,0.8907592f,-0.4999414f,-0.3190055f,-0.03736395f,-0.9452781f,0.05734768f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321429f,1.538002f,0.4834645f,-0.6545499f,-0.2082076f,-0.2499815f,0.6824393f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 22.01943f);
Get(0x6E70).SetLocalPose(-0.1241576f,1.667136f,-0.4234805f,0.4842179f,-0.4259466f,-0.562681f,0.517197f);
Get(0x6E82).SetLocalPose(-0.3210875f,0.8794206f,-0.5317447f,0.1247585f,-0.2920586f,0.09917372f,0.943028f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 22.01943f);
Get(0x6EC6).SetLocalPose(0.2130676f,0.890765f,-0.5015242f,-0.3072193f,-0.02793184f,-0.9497679f,0.05269822f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321472f,1.538041f,0.4833714f,-0.6545568f,-0.208229f,-0.2499896f,0.6824232f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 22.03833f);
Get(0x6E70).SetLocalPose(-0.1234721f,1.666449f,-0.4232894f,0.4820706f,-0.4247068f,-0.5640686f,0.5187088f);
Get(0x6E82).SetLocalPose(-0.321796f,0.8793017f,-0.5286784f,0.1188975f,-0.2846182f,0.08731113f,0.9472237f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 22.03833f);
Get(0x6EC6).SetLocalPose(0.2132773f,0.8886393f,-0.503109f,-0.297445f,-0.01862763f,-0.9534594f,0.04576846f);
});
r.Add(delegate{
Get(0x6E38).SetLocalPose(1.321368f,1.538009f,0.4833105f,-0.6545275f,-0.2082859f,-0.2499729f,0.68244f);
Get(0x6E66).GetComponent<Animator>().Play("New State", 0, 22.05737f);
Get(0x6E70).SetLocalPose(-0.1232733f,1.666316f,-0.4229991f,0.4795868f,-0.4225477f,-0.5657076f,0.5209847f);
Get(0x6E82).SetLocalPose(-0.3217332f,0.8764207f,-0.5233097f,0.110385f,-0.277716f,0.06907678f,0.951797f);
Get(0x6E9E).GetComponent<Animator>().Play("New State", 0, 22.05737f);
Get(0x6EC6).SetLocalPose(0.2142188f,0.8858161f,-0.5062565f,-0.2877917f,-0.00786837f,-0.95706f,0.03391298f);
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

