using System;

namespace Chat.Messages
{
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

		public Message(string username) : this()
		{
			Username = username;
		}
	}
}
