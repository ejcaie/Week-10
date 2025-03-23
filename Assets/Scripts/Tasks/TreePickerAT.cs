using NodeCanvas.Framework;
using ParadoxNotion.Design;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;

namespace NodeCanvas.Tasks.Actions {

	public class TreePickerAT : ActionTask {

		public BBParameter<List<Transform>> treeLocations;
		public BBParameter<Transform> currentTree;
		public BBParameter<bool> areTrees;


		protected override void OnExecute() 
		{
            treeLocations.value.RemoveAt(0);
            currentTree.value = treeLocations.value.ElementAt(0);
			EndAction(true);
		}
	}
}