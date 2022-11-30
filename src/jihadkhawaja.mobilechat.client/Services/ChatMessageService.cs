using jihadkhawaja.mobilechat.client.Interfaces;
using jihadkhawaja.mobilechat.client.Models;
using Microsoft.AspNetCore.SignalR.Client;

namespace jihadkhawaja.mobilechat.client.Services
{
    public class ChatMessageService : IChatMessage
    {
        public async Task<bool> SendMessage(Message message)
        {
            if (MobileChat.SignalR is null)
            {
                throw new NullReferenceException("MobileChat SignalR not initialized");
            }

            return await MobileChat.SignalR.HubConnection.InvokeAsync<bool>("SendMessage", message);
        }

        public async Task<Message[]?> ReceiveMessageHistory(Guid channelid)
        {
            if (MobileChat.SignalR is null)
            {
                throw new NullReferenceException("MobileChat SignalR not initialized");
            }

            return await MobileChat.SignalR.HubConnection.InvokeAsync<Message[]>("ReceiveMessageHistory", channelid);
        }

        public async Task<Message[]?> ReceiveMessageHistoryRange(Guid channelid, int index, int range)
        {
            if (MobileChat.SignalR is null)
            {
                throw new NullReferenceException("MobileChat SignalR not initialized");
            }

            return await MobileChat.SignalR.HubConnection.InvokeAsync<Message[]>("ReceiveMessageHistoryRange", channelid, index, range);
        }

        public async Task<bool> UpdateMessage(Message message)
        {
            if (MobileChat.SignalR is null)
            {
                throw new NullReferenceException("MobileChat SignalR not initialized");
            }

            return await MobileChat.SignalR.HubConnection.InvokeAsync<bool>("message", message);
        }
    }
}
