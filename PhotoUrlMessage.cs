using System;
namespace Chat.Messages
{
	public class PhotoUrlMessage : Message
	{
		public string Url { get; set; }
		public PhotoUrlMessage(string username) : 
			base(username)
		{
		}
	}
}
