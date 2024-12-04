namespace JMWebAPI.Models.DTO
{
    /// <summary>
    /// WebSocket 消息體
    /// </summary>
    public class ChatMessage
    {
        /// <summary>
        /// 發送者
        /// </summary>
        public string Sender { get; set; }

        /// <summary>
        /// 消息內容
        /// </summary>
        public string Content { get; set; }

        /// <summary>
        /// 無參構造函數
        /// </summary>
        public ChatMessage()
        {
        }

        /// <summary>
        /// 帶參構造函數
        /// </summary>
        /// <param name="sender">發送者</param>
        /// <param name="content">消息內容</param>
        public ChatMessage(string sender, string content)
        {
            Sender = sender;
            Content = content;
        }
    }
}
