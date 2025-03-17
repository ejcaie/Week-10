using NodeCanvas.Framework;
using ParadoxNotion.Design;
using UnityEngine;


namespace NodeCanvas.Tasks.Actions {

	public class ColorChangeAT : ActionTask {

		public Renderer renderer;
		public Color targetColor = Color.white;
		public float durationInSeconds = 1f;

		private Color startColor;
		private float startTime;

		protected override string OnInit() 
		{
			startColor = renderer.material.color;
			return null;
		}

		protected override void OnUpdate()
		{
			float stepValue = Mathf.PingPong(Time.time, 1f);

			renderer.material.color = Color.Lerp(startColor, targetColor, stepValue);
		}


		protected override void OnStop()
		{
			renderer.material.color = startColor;
		}
	}
}