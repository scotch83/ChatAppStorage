using System;
namespace Chat.Messages
{
	public class PhotoMessage : Message
	{
		public string Base64Photo { get; set; }
		public string FileExtension { get; set; }
		public PhotoMessage(string username) : 
			base(username)
		{
		}
	}
}
