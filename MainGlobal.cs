using Discord.WebSocket;

namespace SallyBot
{
    internal static class MainGlobal
    {
        internal static SocketGuild Server { get; set; }
        internal static DiscordSocketClient Client { get; set; }

        internal static string conS = "Discord bot API token goes here";
        internal static ulong guildId = SERVER_ID;


        internal static string googleApiKey = "Google API key goes here"; // OPTIONAL (you can leave this as-is if you don't want to use it)
    }
}
