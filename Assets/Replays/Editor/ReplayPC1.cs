using System;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class ReplayPC1 : ReplayBase {
private List<Action> Execute() {
var r = new List<Action>();
r.Add(delegate{
Add(0xFFFFFB48, GameObject.Find("/Main Camera"));
Get(0xFFFFFB48).SetLocalPose(0f,1f,-10f,0f,0f,0f,1f);
});
return r;
}
private List<Action> Execute0() {
var r = new List<Action>();
r.Add(delegate{
});
r.Add(delegate{
});
r.Add(delegate{
});
r.Add(delegate{
});
r.Add(delegate{
});
r.Add(delegate{
});
r.Add(delegate{
});
r.Add(delegate{
});
r.Add(delegate{
});
r.Add(delegate{
});
r.Add(delegate{
});
r.Add(delegate{
});
r.Add(delegate{
});
r.Add(delegate{
});
r.Add(delegate{
});
r.Add(delegate{
});
r.Add(delegate{
});
r.Add(delegate{
});
r.Add(delegate{
});
r.Add(delegate{
});
r.Add(delegate{
});
r.Add(delegate{
});
r.Add(delegate{
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
