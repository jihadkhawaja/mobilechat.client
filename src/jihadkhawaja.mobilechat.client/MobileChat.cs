using jihadkhawaja.mobilechat.client.Core;

namespace jihadkhawaja.mobilechat.client
{
    public static class MobileChat
    {
        public static SignalR? SignalR { get; private set; }
        public static void Initialize(string url, string token = "")
        {
            SignalR = new(url, token);
        }
    }
}