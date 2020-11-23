using System.Collections.Concurrent;
using System.Linq;
using System.Threading.Tasks;

namespace MyService.Stores
{
    public class UserStore
    {
        ConcurrentDictionary<int, User> _users = new ConcurrentDictionary<int, User>();

        int keyIdentity = 1;

        public UserStore()
        {
            AddUser(new User()
            {
                Username = "John",
                EmailAddress = "john@acme.com"
            });

            AddUser(new User()
            {
                Username = "Bob",
                EmailAddress = "bob@acme.com"
            });
        }

        public Task<User[]> GetUsersAsync()
        {
            return Task.FromResult(_users.Values.ToArray());
        }

        public Task<User> GetUserByIdAsync(int userId)
        {
            if (_users.TryGetValue(userId, out var user))
                return Task.FromResult(user);

            return Task.FromResult((User)null);
        }

        public Task AddUserAsync(User user)
        {
            AddUser(user);

            return Task.CompletedTask;
        }

        void AddUser(User user)
        {
            user.UserId = keyIdentity++;

            _users.TryAdd(user.UserId, user);
        }

        public Task<bool> UpdateUserAsync(User user)
        {
            if (_users.TryGetValue(user.UserId, out var existing))
            {
                return Task.FromResult(_users.TryUpdate(user.UserId, user, existing));
            }

            return Task.FromResult(false);
        }
    }
}
