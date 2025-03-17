using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Conditions {

	public class InRangeCT : ConditionTask {

		public BBParameter<Transform> playerCursor;

		protected override bool OnCheck() 
		{
			if (Input.GetMouseButtonDown(0))
			{
				Ray mouseRay = Camera.main.ScreenPointToRay(Input.mousePosition);

				if (Physics.Raycast(mouseRay, out RaycastHit hitinfo))
				{
					playerCursor.value.position = hitinfo.point;
					return true;
				}
			}

			return false;
		}
	}
}