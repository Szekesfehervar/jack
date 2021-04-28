using cernyjack.Models;
using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cernyjack.Data
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public DbSet<Card> Cards { get; set; }
        public DbSet<ApplicationUser> ApplicationUsers { get; set; }
        public DbSet<UserCard> UserCards { get; set; }
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }



        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<Card>().HasData(new Card { Id = 1, Value = 2  });
            modelBuilder.Entity<Card>().HasData(new Card { Id = 2, Value = 3  });
            modelBuilder.Entity<Card>().HasData(new Card { Id = 3, Value = 4  });
            modelBuilder.Entity<Card>().HasData(new Card { Id = 4, Value = 5  });
            modelBuilder.Entity<Card>().HasData(new Card { Id = 5, Value = 6  });
            modelBuilder.Entity<Card>().HasData(new Card { Id = 6, Value = 7  });
            modelBuilder.Entity<Card>().HasData(new Card { Id = 7, Value = 8  });
            modelBuilder.Entity<Card>().HasData(new Card { Id = 8, Value = 9  });
            modelBuilder.Entity<Card>().HasData(new Card { Id = 9, Value = 10  });
            modelBuilder.Entity<Card>().HasData(new Card { Id = 10, Value = 10  }); //j
            modelBuilder.Entity<Card>().HasData(new Card { Id = 11, Value = 10  }); //q
            modelBuilder.Entity<Card>().HasData(new Card { Id = 12, Value = 10  }); //k
            modelBuilder.Entity<Card>().HasData(new Card { Id = 13, Value = 10  }); //ace

            modelBuilder.Entity<Card>().HasData(new Card { Id = 14, Value = 2  });
            modelBuilder.Entity<Card>().HasData(new Card { Id = 15, Value = 3  });
            modelBuilder.Entity<Card>().HasData(new Card { Id = 16, Value = 4  });
            modelBuilder.Entity<Card>().HasData(new Card { Id = 17, Value = 5  });
            modelBuilder.Entity<Card>().HasData(new Card { Id = 18, Value = 6  });
            modelBuilder.Entity<Card>().HasData(new Card { Id = 19, Value = 7  });
            modelBuilder.Entity<Card>().HasData(new Card { Id = 20, Value = 8  });
            modelBuilder.Entity<Card>().HasData(new Card { Id = 21, Value = 9  });
            modelBuilder.Entity<Card>().HasData(new Card { Id = 22, Value = 10  });
            modelBuilder.Entity<Card>().HasData(new Card { Id = 23, Value = 10  }); //j
            modelBuilder.Entity<Card>().HasData(new Card { Id = 24, Value = 10  }); //q
            modelBuilder.Entity<Card>().HasData(new Card { Id = 25, Value = 10  }); //k
            modelBuilder.Entity<Card>().HasData(new Card { Id = 26, Value = 10  }); //ace

            modelBuilder.Entity<Card>().HasData(new Card { Id = 27, Value = 2  });
            modelBuilder.Entity<Card>().HasData(new Card { Id = 28, Value = 3  });
            modelBuilder.Entity<Card>().HasData(new Card { Id = 29, Value = 4  });
            modelBuilder.Entity<Card>().HasData(new Card { Id = 30, Value = 5  });
            modelBuilder.Entity<Card>().HasData(new Card { Id = 31, Value = 6  });
            modelBuilder.Entity<Card>().HasData(new Card { Id = 32, Value = 7  });
            modelBuilder.Entity<Card>().HasData(new Card { Id = 33, Value = 8  });
            modelBuilder.Entity<Card>().HasData(new Card { Id = 34, Value = 9  });
            modelBuilder.Entity<Card>().HasData(new Card { Id = 35, Value = 10  });
            modelBuilder.Entity<Card>().HasData(new Card { Id = 36, Value = 10  }); //j
            modelBuilder.Entity<Card>().HasData(new Card { Id = 37, Value = 10  }); //q
            modelBuilder.Entity<Card>().HasData(new Card { Id = 38, Value = 10  }); //k
            modelBuilder.Entity<Card>().HasData(new Card { Id = 39, Value = 10  }); //ace

            modelBuilder.Entity<Card>().HasData(new Card { Id = 40, Value = 2  });
            modelBuilder.Entity<Card>().HasData(new Card { Id = 41, Value = 3  });
            modelBuilder.Entity<Card>().HasData(new Card { Id = 42, Value = 4  });
            modelBuilder.Entity<Card>().HasData(new Card { Id = 43, Value = 5  });
            modelBuilder.Entity<Card>().HasData(new Card { Id = 44, Value = 6  });
            modelBuilder.Entity<Card>().HasData(new Card { Id = 45, Value = 7  });
            modelBuilder.Entity<Card>().HasData(new Card { Id = 46, Value = 8  });
            modelBuilder.Entity<Card>().HasData(new Card { Id = 47, Value = 9  });
            modelBuilder.Entity<Card>().HasData(new Card { Id = 48, Value = 10  });
            modelBuilder.Entity<Card>().HasData(new Card { Id = 49, Value = 10  }); //j
            modelBuilder.Entity<Card>().HasData(new Card { Id = 50, Value = 10  }); //q
            modelBuilder.Entity<Card>().HasData(new Card { Id = 51, Value = 10  }); //k
            modelBuilder.Entity<Card>().HasData(new Card { Id = 52, Value = 10  }); //ace


        }
    }
}
