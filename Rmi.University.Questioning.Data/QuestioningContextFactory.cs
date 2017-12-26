using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace Rmi.University.Questioning.Data
{
    public class QuestioningContextFactory : IDesignTimeDbContextFactory<QuestioningContext>
    {
	    public QuestioningContext CreateDbContext(string[] args)
	    {
		    var optionsBuilder = new DbContextOptionsBuilder<QuestioningContext>();
		    optionsBuilder.UseNpgsql("User ID=questioning;Password=P@ssw0rd;Host=localhost;Port=5432;Database=questioningdb;Pooling=true;");

		    return new QuestioningContext(optionsBuilder.Options);
	    }
    }
}
