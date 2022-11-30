using jihadkhawaja.mobilechat.client.Interfaces;
using jihadkhawaja.mobilechat.client.Models;
using Microsoft.AspNetCore.SignalR.Client;

namespace jihadkhawaja.mobilechat.client.Services
{
    public class ChatChannelService : IChatChannel
    {
        public async Task<Channel?> CreateChannel(params string[] usernames)
        {
            if (MobileChat.SignalR is null)
            {
                throw new NullReferenceException("MobileChat SignalR not initialized");
            }

            return await MobileChat.SignalR.HubConnection.InvokeAsync<Channel>("CreateChannel", usernames);
        }

        public async Task<bool> AddChannelUsers(Guid channelId, params string[] friendEmailorusername)
        {
            if (MobileChat.SignalR is null)
            {
                throw new NullReferenceException("MobileChat SignalR not initialized");
            }

            return await MobileChat.SignalR.HubConnection.InvokeAsync<bool>("AddChannelUsers", channelId, friendEmailorusername);
        }

        public async Task<User[]?> GetChannelUsers(Guid channelid)
        {
            if (MobileChat.SignalR is null)
            {
                throw new NullReferenceException("MobileChat SignalR not initialized");
            }

            return await MobileChat.SignalR.HubConnection.InvokeAsync<User[]>("GetChannelUsers", channelid);
        }

        public async Task<Channel[]?> GetUserChannels()
        {
            if (MobileChat.SignalR is null)
            {
                throw new NullReferenceException("MobileChat SignalR not initialized");
            }

            return await MobileChat.SignalR.HubConnection.InvokeAsync<Channel[]>("GetUserChannels");
        }

        public async Task<bool> ChannelContainUser(Guid channelId, Guid userId)
        {
            if (MobileChat.SignalR is null)
            {
                throw new NullReferenceException("MobileChat SignalR not initialized");
            }

            return await MobileChat.SignalR.HubConnection.InvokeAsync<bool>("ChannelContainUser", channelId, userId);
        }

        public async Task<bool> IsChannelAdmin(Guid channelId, Guid userId)
        {
            if (MobileChat.SignalR is null)
            {
                throw new NullReferenceException("MobileChat SignalR not initialized");
            }

            return await MobileChat.SignalR.HubConnection.InvokeAsync<bool>("IsChannelAdmin", channelId, userId);
        }

        public async Task<bool> DeleteChannel(Guid channelId)
        {
            if (MobileChat.SignalR is null)
            {
                throw new NullReferenceException("MobileChat SignalR not initialized");
            }

            return await MobileChat.SignalR.HubConnection.InvokeAsync<bool>("DeleteChannel", channelId);
        }

        public async Task<bool> LeaveChannel(Guid channelId)
        {
            if (MobileChat.SignalR is null)
            {
                throw new NullReferenceException("MobileChat SignalR not initialized");
            }

            return await MobileChat.SignalR.HubConnection.InvokeAsync<bool>("LeaveChannel", channelId);
        }
    }
}
