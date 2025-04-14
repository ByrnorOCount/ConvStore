namespace ConvStore
{
    public static class UserSession
    {
        public static int UserID { get; set; }
        public static string Username { get; set; }
        public static string Role { get; set; }
        public static string StoreBranch { get; set; }
        public static string Permission { get; set; }

        public static void Clear()
        {
            UserID = 0;
            Username = null;
            Role = null;
            StoreBranch = null;
            Permission = null;
        }
    }
}
