using System;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
public class ReplayPC4 : ReplayBase {
private List<Action> Execute() {
var r = new List<Action>();
r.Add(delegate{
});
return r;
}
public override List<Action> SuperExecute() {
     List<Action> actions = new List<Action>();
     actions = actions.Concat(Execute()).ToList();
     return actions;
}
}

