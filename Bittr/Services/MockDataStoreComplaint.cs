using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Bittr.Models;
using Bittr.ViewModels;

namespace Bittr.Services
{
    public class MockDataStoreComplaint : IDataStore<Complaint>
    {
        List<Complaint> items;

        public MockDataStoreComplaint()
        {
            User jack = new User() { FullName= "Reeece Jack", Username = "gamblt589", Avatar = "LemonFace.png" };

            items = new List<Complaint>();
            var mockItems = new List<Complaint>
            {
                new Complaint() {
                    Id= new Guid().ToString(),
                    Text = "Loyd is cold!!!!! 🥶",
                    Timestamp = DateTime.Now,
                    Creator = jack,
                    ImageName = "http://static.vibe.com/uploads/2014/01/VIBE-Vixen-Cold-Weather-Meme-7.png",
                    Tags = new List<Tag>() {
                        new Tag() { Text="#anger"},
                        new Tag() { Text = "#bitter" },
                        new Tag() { Text = "#frigid" }
                    }
                },


                new Complaint() {
                    Id= new Guid().ToString(),
                    Text = "😠 Reece always takes my seat.😠😠😠😠😠😠😠",
                    Timestamp = DateTime.Now,
                    Creator = jack,
                    ImageName = "https://scontent-atl3-1.xx.fbcdn.net/v/t1.0-9/44735374_2144069972587194_8140258589919936512_n.jpg?_nc_cat=109&_nc_oc=AQnhFDWDeCvtLyo7RC9QtX8YUrLx_B5R1NlEyqSIsEycDyRxB2lb1jJppVWkqoooeZQ&_nc_ht=scontent-atl3-1.xx&oh=417f8001dbd45b3f8bc9e6ecef54771f&oe=5E28FD70",

                    Tags = new List<Tag>() {
                        new Tag() { Text="#reece"},
                        new Tag() { Text = "#stealer" },
                        new Tag() { Text = "#jack" },
                        new Tag() { Text = "#cis388" },
                        new Tag() { Text = "#4kTV" }
                    }}
            };

            foreach (var item in mockItems)
            {
                items.Add(item);
            }
        }

        public async Task<bool> AddItemAsync(Complaint item)
        {
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> UpdateItemAsync(Complaint item)
        {
            var oldItem = items.Where((Complaint arg) => arg.Id == item.Id).FirstOrDefault();
            items.Remove(oldItem);
            items.Add(item);

            return await Task.FromResult(true);
        }

        public async Task<bool> DeleteItemAsync(string id)
        {
            var oldItem = items.Where((Complaint arg) => arg.Id == id).FirstOrDefault();
            items.Remove(oldItem);

            return await Task.FromResult(true);
        }

        public async Task<Complaint> GetItemAsync(string id)
        {
            return await Task.FromResult(items.FirstOrDefault(s => s.Id == id));
        }

        public async Task<IEnumerable<Complaint>> GetItemsAsync(bool forceRefresh = false)
        {
            return await Task.FromResult(items);
        }
    }
}