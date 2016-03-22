using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TheWorld.Models
{
    public class WorldContextSeedData
    {
        private WorldContext _context;
        private UserManager<WorldUser> _userManager;

        public WorldContextSeedData(WorldContext context, UserManager<WorldUser> userManager)
        {
            _context = context;
            _userManager = userManager;
        }
        public async Task EnsureSeedDataAsync()
        {
            if (await _userManager.FindByEmailAsync("diego@gmail.com") == null)
            {
                var newUser = new WorldUser
                {
                    UserName = "diegoneves",
                    Email= "diego@gmail.com"
                };

               await _userManager.CreateAsync(newUser, "P@ssw0rld!");
            }

            if (!_context.Trips.Any())
            {
                var usTrip = new Trip
                {
                    Name = "US Trip",
                    Created = DateTime.UtcNow,
                    UserName = "Diego Neves",
                    Stops = new List<Stop>
                    {
                        new Stop()
                        {
                            Name = "Atlanta, GA",Arrival = new DateTime(2015,2,1), Latitude = 33.748995, Longitude = -84.387982, Order = 0
                        }
                    }
                };

                _context.Trips.Add(usTrip);
               //_context.Stops.AddRange(usTrip.Stops);
                _context.SaveChanges();
            }
        }
    }
}
