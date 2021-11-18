﻿using Microsoft.AspNetCore.SignalR;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingService.Hubs
{
    public class UsersHub : Hub
    {
        private static readonly ConcurrentDictionary<string, bool> _onlineUsers = new ConcurrentDictionary<string, bool>();

        public override async Task OnConnectedAsync()
        {
            var userGuid = this.Context.User.Identity.Name;

            _onlineUsers.TryAdd(userGuid, true);

            await UpdateOnlineUsers();

            await base.OnConnectedAsync();
        }

        public override async Task OnDisconnectedAsync(Exception exception)
        {
            var userGuid = this.Context.User.Identity.Name;

            if (!_onlineUsers.TryRemove(userGuid, out _))
                _onlineUsers.TryUpdate(userGuid, false, true);

            await UpdateOnlineUsers();

            await base.OnDisconnectedAsync(exception);
        }

        private Task UpdateOnlineUsers()
        {
            var count = GetOnlineUsersCount();
            return Clients.All.SendAsync("UpdateOnlineUsers", _onlineUsers.Keys);
        }

        public static int GetOnlineUsersCount()
        {
            return _onlineUsers.Count(p => p.Value);
        }
    }
}
