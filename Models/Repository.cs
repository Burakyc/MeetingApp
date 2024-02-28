namespace MeetingApp.Models
{
    public class Repository
    {
        
        private static List<UserInfo> _users = new();
        static Repository()
        {
            _users.Add(new UserInfo(){Id=1,Name="Mustafaa",Email="mustafa@gmail.com",Phone="5888888888",WillAttend=true});
            _users.Add(new UserInfo(){Id=2,Name="Semih",Email="Semih@gmail.com",Phone="5999999999",WillAttend=true});
            _users.Add(new UserInfo(){Id=3,Name="Tarık",Email="Tarik@gmail.com",Phone="5777777777",WillAttend=false});
        }
        public static List<UserInfo> Users 
        {
            get{
                return _users;
            }
             
        }
        public static void CreateUser(UserInfo user)
        {
            user.Id=Users.Count + 1 ;
            _users.Add(user);
        }

        public static UserInfo GetById(int id)
        {
            return _users.FirstOrDefault(user => user.Id == id);
        }
    }
}