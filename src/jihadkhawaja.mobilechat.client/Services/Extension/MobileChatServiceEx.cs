using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using jihadkhawaja.mobilechat.client.Interfaces;

namespace jihadkhawaja.mobilechat.client.Services.Extension
{
    public static class MobileChatServiceEx
    {
        public static IServiceCollection AddMobileChatServices(this IServiceCollection services)
        {
            //chat services
            services.AddScoped<IChatAuth, ChatAuthService>();
            services.AddScoped<IChatUser, ChatUserService>();
            services.AddScoped<IChatChannel, ChatChannelService>();
            services.AddScoped<IChatMessage, ChatMessageService>();

            return services;
        }
    }
}
