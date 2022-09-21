using jihadkhawaja.mobilechat.client.Interfaces;
using jihadkhawaja.mobilechat.client.Models;
using Microsoft.AspNetCore.SignalR.Client;

namespace jihadkhawaja.mobilechat.client.Services
{
    public class ChatUserService : IChatUser
    {
        public async Task<bool> AddFriend(string friendEmailorusername)
        {
            if (MobileChat.SignalR is null)
            {
                return false;
            }

            return await MobileChat.SignalR.HubConnection.InvokeAsync<bool>("AddFriend", friendEmailorusername);
        }

        public async Task<bool> RemoveFriend(string friendEmailorusername)
        {
            if (MobileChat.SignalR is null)
            {
                return false;
            }

            return await MobileChat.SignalR.HubConnection.InvokeAsync<bool>("RemoveFriend", friendEmailorusername);
        }

        public async Task<string?> GetUserDisplayName(Guid userId)
        {
            if (MobileChat.SignalR is null)
            {
                return null;
            }

            return await MobileChat.SignalR.HubConnection.InvokeAsync<string>("GetUserDisplayName", userId);
        }

        public async Task<string?> GetUserUsername(Guid userId)
        {
            if (MobileChat.SignalR is null)
            {
                return null;
            }

            return await MobileChat.SignalR.HubConnection.InvokeAsync<string>("GetUserUsername", userId);
        }

        public async Task<bool> GetUserIsFriend(Guid userId, Guid friendId)
        {
            if (MobileChat.SignalR is null)
            {
                return false;
            }

            return await MobileChat.SignalR.HubConnection.InvokeAsync<bool>("GetUserIsFriend", userId, friendId);
        }

        public async Task<UserFriend[]?> GetUserFriends(Guid userId)
        {
            if (MobileChat.SignalR is null)
            {
                return null;
            }

            return await MobileChat.SignalR.HubConnection.InvokeAsync<UserFriend[]>("GetUserFriends", userId);
        }

        public async Task<UserFriend[]?> GetUserFriendRequests(Guid userId)
        {
            if (MobileChat.SignalR is null)
            {
                return null;
            }

            return await MobileChat.SignalR.HubConnection.InvokeAsync<UserFriend[]>("GetUserFriendRequests", userId);
        }

        public async Task<bool> AcceptFriend(Guid friendId)
        {
            if (MobileChat.SignalR is null)
            {
                return false;
            }

            return await MobileChat.SignalR.HubConnection.InvokeAsync<bool>("AcceptFriend", friendId);
        }

        public async Task<bool> DenyFriend(Guid friendId)
        {
            if (MobileChat.SignalR is null)
            {
                return false;
            }

            return await MobileChat.SignalR.HubConnection.InvokeAsync<bool>("DenyFriend", friendId);
        }
    }
}
