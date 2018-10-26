﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace SmallCommitsWorkshop.Models {
	public class UsersContext : DbContext {
		public UsersContext( DbContextOptions<UsersContext> options )
			: base( options ) { }

		public DbSet<User> Users { get; set; }
	}
}
