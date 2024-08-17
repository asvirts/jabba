namespace Jabba.App.Models
{
    public class ChatMessage
    {
        public required Guid Id { get; set; }
        public required string Message { get; set; }
        public required Guid Sender { get; set; }
        public required DateTime TimeSent { get; set; } = DateTime.Now;

        public ChatMessage()
        {
            
        }
    }
}
