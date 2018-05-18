using System;
using System.Collections.Generic;
using System.Linq;

namespace Telegram.Bot.Tests.Integ.Framework
{
    public class TestConfigurations
    {
        public string ApiToken { get; set; }

        public string AllowedUserNames { get; set; }

        public ICollection<string> AllowedUserNamesArray =>
            _allowedUsers ??
                (_allowedUsers = AllowedUserNames
                    .Split(",".ToCharArray(), StringSplitOptions.RemoveEmptyEntries)
                    .Select(n => n.Trim())
                    .ToList()
                );

        public string SuperGroupChatId { get; set; }

        public string ChannelChatId { get; set; }

        public string PaymentProviderToken { get; set; }

        public long? TesterPrivateChatId { get; set; }

        public int? StickerOwnerUserId { get; set; }

        public string RegularGroupMemberId { get; set; }

        private ICollection<string> _allowedUsers;
    }
}
