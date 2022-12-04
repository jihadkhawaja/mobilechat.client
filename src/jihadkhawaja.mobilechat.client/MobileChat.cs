using jihadkhawaja.mobilechat.client.Core;

namespace jihadkhawaja.mobilechat.client
{
    /// <summary>
    /// Access SignalR hub and events
    /// </summary>
    public static class MobileChat
    {
        /// <summary>
        /// MobileChat SignalR Abstraction
        /// </summary>
        public static SignalR? SignalR { get; private set; }
        public static void Initialize(string url, string token = "")
        {
            SignalR = new(url, token);
        }
    }
}