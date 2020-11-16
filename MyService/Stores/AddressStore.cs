using System.Collections.Concurrent;
using System.Linq;
using System.Threading.Tasks;

namespace MyService.Stores
{
    public class AddressStore
    {
        ConcurrentDictionary<int, Address> _addresses = new ConcurrentDictionary<int, Address>();

        int keyIdentity = 1;

        public AddressStore()
        {
            AddAddress(new Address()
            {
                StreetAddress = "123 Acme St",
                City = "Highland",
                State = "UT",
                Zip = "84003"
            });

            AddAddress(new Address()
            {
                StreetAddress = "789 Greenspot Rd",
                City = "Mentone",
                State = "CA",
                Zip = "92359"
            });
        }

        public Task<Address[]> GetAddressesAsync()
        {
            return Task.FromResult(_addresses.Values.ToArray());
        }

        public Task<Address> GetAddressByIdAsync(int addressId)
        {
            if (_addresses.TryGetValue(addressId, out var address))
                return Task.FromResult(address);

            return Task.FromResult((Address)null);
        }

        public Task AddAddressAsync(Address address)
        {
            AddAddress(address);

            return Task.CompletedTask;
        }

        void AddAddress(Address address)
        {
            address.AddressId = keyIdentity++;

            _addresses.TryAdd(address.AddressId, address);
        }

        public Task<bool> UpdateAddressAsync(Address address)
        {
            if (_addresses.TryGetValue(address.AddressId, out var existing))
            {
                return Task.FromResult(_addresses.TryUpdate(address.AddressId, address, existing));
            }

            return Task.FromResult(false);
        }
    }
}
