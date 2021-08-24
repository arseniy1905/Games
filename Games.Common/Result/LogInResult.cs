namespace Games.Common.Result
{
    public class LogInResult
    {
        private static readonly LogInResult _success = new LogInResult { Succeeded = true };
        private static readonly LogInResult _failed = new LogInResult();
        private static readonly LogInResult _lockedOut = new LogInResult { IsLockedOut = true };
        private static readonly LogInResult _notAllowed = new LogInResult { IsNotAllowed = true };
        private static readonly LogInResult _twoFactorRequired = new LogInResult { RequiresTwoFactor = true };

        /// <summary>
        /// Returns a flag indication whether the sign-in was successful.
        /// </summary>
        /// <value>True if the sign-in was successful, otherwise false.</value>
        public bool Succeeded { get; protected set; }

        /// <summary>
        /// Returns a flag indication whether the user attempting to sign-in is locked out.
        /// </summary>
        /// <value>True if the user attempting to sign-in is locked out, otherwise false.</value>
        public bool IsLockedOut { get; protected set; }

        /// <summary>
        /// Returns a flag indication whether the user attempting to sign-in is not allowed to sign-in.
        /// </summary>
        /// <value>True if the user attempting to sign-in is not allowed to sign-in, otherwise false.</value>
        public bool IsNotAllowed { get; protected set; }

        /// <summary>
        /// Returns a flag indication whether the user attempting to sign-in requires two factor authentication.
        /// </summary>
        /// <value>True if the user attempting to sign-in requires two factor authentication, otherwise false.</value>
        public bool RequiresTwoFactor { get; protected set; }

        /// <summary>
        /// Returns a <see cref="SignInResult"/> that represents a successful sign-in.
        /// </summary>
        /// <returns>A <see cref="SignInResult"/> that represents a successful sign-in.</returns>
        public static LogInResult Success => _success;

        /// <summary>
        /// Returns a <see cref="SignInResult"/> that represents a failed sign-in.
        /// </summary>
        /// <returns>A <see cref="SignInResult"/> that represents a failed sign-in.</returns>
        public static LogInResult Failed => _failed;

        /// <summary>
        /// Returns a <see cref="SignInResult"/> that represents a sign-in attempt that failed because 
        /// the user was logged out.
        /// </summary>
        /// <returns>A <see cref="SignInResult"/> that represents sign-in attempt that failed due to the
        /// user being locked out.</returns>
        public static LogInResult LockedOut => _lockedOut;

        /// <summary>
        /// Returns a <see cref="SignInResult"/> that represents a sign-in attempt that failed because 
        /// the user is not allowed to sign-in.
        /// </summary>
        /// <returns>A <see cref="SignInResult"/> that represents sign-in attempt that failed due to the
        /// user is not allowed to sign-in.</returns>
        public static LogInResult NotAllowed => _notAllowed;

        /// <summary>
        /// Returns a <see cref="SignInResult"/> that represents a sign-in attempt that needs two-factor 
        /// authentication.
        /// </summary>
        /// <returns>A <see cref="SignInResult"/> that represents sign-in attempt that needs two-factor
        /// authentication.</returns>
        public static LogInResult TwoFactorRequired => _twoFactorRequired;

        /// <summary>
        /// Converts the value of the current <see cref="SignInResult"/> object to its equivalent string representation.
        /// </summary>
        /// <returns>A string representation of value of the current <see cref="SignInResult"/> object.</returns>
        public override string ToString()
        {
            return IsLockedOut ? "Lockedout" :
                      IsNotAllowed ? "NotAllowed" :
                   RequiresTwoFactor ? "RequiresTwoFactor" :
                   Succeeded ? "Succeeded" : "Failed";
        }
    }
}
