﻿using Microsoft.EntityFrameworkCore;

namespace MyDiary.Data
{
    /// <inheritdoc />
    /// <summary>
    /// Class DbContextBase.
    /// </summary>
    /// <seealso cref="T:Microsoft.EntityFrameworkCore.DbContext" />
    public class DbContextBase : DbContext
    {
        /// <inheritdoc />
        /// <summary>
        /// Initializes a new instance of the <see cref="T:TMT.Data.DbContextBase" /> class.
        /// </summary>
        /// <param name="dbContextOptions">The database context options.</param>
        /// <param name="schemaName">Name of the schema.</param>
        public DbContextBase(DbContextOptions dbContextOptions, string schemaName)
            : base(dbContextOptions)
        {
            SchemaName = schemaName;
        }

        /// <summary>
        /// Database schema name
        /// </summary>
        public string SchemaName { get; }

        /// <inheritdoc />
        /// <summary>
        /// Applying the configuration of dbContext entities
        /// </summary>
        /// <param name="modelBuilder"></param>
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
        }
    }
}