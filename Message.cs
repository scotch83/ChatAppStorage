using System;

namespace Chat.Messages
{
    // I will add here some comments for git submodules testing purposes
	public class Message
	{
		public Type TypeInfo { get; set; }
		public string Id { get; set; }
		public string Username { get; set; }
		public DateTimeOffset Timestamp { get; set; }

		public Message()
		{
			TypeInfo = GetType();
			Id = Guid.NewGuid().ToString();
			Timestamp = DateTimeOffset.Now;
		}

		public Message(string username)
		{
			Username = username;
		}
	}
}
