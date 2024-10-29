using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "POMPOUS TRASH/Dialogue Node")]
public class DialogueNode : ScriptableObject
{
	public enum Event
	{
		None = 0
	}

	[Header("Feel")]
	public float CharactersPerSecond;
	public float DelayBetweenLines = 1f;

	[Header("Content")]
	[TextArea]
	public string[] Text;
	public Event[] EventsToThrowOnStart;
	public Event[] EventsToThrowOnLastLine;
	public string LeftLabel, RightLabel;
	public DialogueNode LeftChoice, RightChoice;
}
