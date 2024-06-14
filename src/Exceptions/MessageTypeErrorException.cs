namespace FeishuNetSdk.Exceptions
{
    /// <summary>
    /// 消息类型不支持
    /// </summary>
    public class MessageTypeNotSupportedException : Exception
    {
        /// <summary>
        /// 
        /// </summary>
        public MessageTypeNotSupportedException()
        {
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="message"></param>
        public MessageTypeNotSupportedException(string? message) : base(message)
        {
        }
    }
}
