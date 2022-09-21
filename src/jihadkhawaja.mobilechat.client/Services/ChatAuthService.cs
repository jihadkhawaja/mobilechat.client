using jihadkhawaja.mobilechat.client.Interfaces;
using Microsoft.AspNetCore.SignalR.Client;

namespace jihadkhawaja.mobilechat.client.Services
{
    public class ChatAuthService : IChatAuth
    {
        public async Task<dynamic?> SignUp(string displayname, string username, string email, string password)
        {
            if (MobileChat.SignalR is null)
            {
                return null;
            }

            return await MobileChat.SignalR.HubConnection.InvokeAsync<object?>("SignUp", displayname, username, email, password);
        }

        public async Task<dynamic?> SignIn(string emailorusername, string password)
        {
            if (MobileChat.SignalR is null)
            {
                return null;
            }

            return await MobileChat.SignalR.HubConnection.InvokeAsync<object>("SignIn", emailorusername, password);
        }

        public async Task<bool> ChangePassword(string emailorusername, string oldpassword, string newpassword)
        {
            if (MobileChat.SignalR is null)
            {
                return false;
            }

            return await MobileChat.SignalR.HubConnection.InvokeAsync<bool>("ChangePassword", emailorusername, oldpassword, newpassword);
        }
    }
}
