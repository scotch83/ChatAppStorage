using System;
namespace Chat.Messages
{
	public class SimpleTextMessage : Message
	{
		public string Text { get; set; }
		public SimpleTextMessage(string username) : 
			base(username)
		{
		}
	}
}
