using System;
namespace Chat.Messages
{
	public class UserConnectedMessage : Message
	{
		public UserConnectedMessage(string username) : 
			base(username)
		{
		}
	}
}
