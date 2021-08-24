using Games.Common.State;
using Microsoft.AspNetCore.Http;
using Newtonsoft.Json;

namespace Games.Common.Extensions
{
    public static class StateExtensions
    {
        public static SessionState GetSessionState(this ISession session)
        {
            var sessionState = session.Get<SessionState>(nameof(SessionState));
            if (sessionState == null)
            {
                sessionState = new SessionState();
                SetSessionState(session, sessionState);
            }
            return sessionState;
        }
        public static void SetSessionState(this ISession session, SessionState sessionState)
        {
            session.Set(nameof(SessionState), sessionState);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="session"></param>
        /// <param name="key"></param>
        /// <param name="value"></param>
        public static void Set<T>(this ISession session, string key, T value) where T : class
        {
            session.SetString(key, JsonConvert.SerializeObject(value));
        }
        /// <summary>
        /// 
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="session"></param>
        /// <param name="key"></param>
        /// <returns></returns>
        public static T Get<T>(this ISession session, string key) where T : class
        {

            var value = session.GetString(key);
            var @return = null as T;
            if (value != null)
            {
                @return = JsonConvert.DeserializeObject<T>(value);
            }
            return @return;
        }
    }
}
