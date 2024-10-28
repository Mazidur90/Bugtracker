﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using bugTracker.Core.Persistence;

namespace bugTracker.Core.Persistence.Migrations
{
    [DbContext(typeof(BugContext))]
    partial class BugContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.1.1-rtm-30846");

            modelBuilder.Entity("bugTracker.Core.Entities.Bug", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int?>("AssignedUserId");

                    b.Property<DateTime>("Created");

                    b.Property<string>("Description");

                    b.Property<DateTime>("Modified");

                    b.Property<int>("Status");

                    b.Property<string>("Title");

                    b.HasKey("Id");

                    b.HasIndex("AssignedUserId");

                    b.ToTable("bugs");
                });

            modelBuilder.Entity("bugTracker.Core.Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<DateTime>("Created");

                    b.Property<DateTime>("Modified");

                    b.Property<string>("Username");

                    b.HasKey("Id");

                    b.ToTable("users");
                });

            modelBuilder.Entity("bugTracker.Core.Entities.Bug", b =>
                {
                    b.HasOne("bugTracker.Core.Entities.User", "AssignedUser")
                        .WithMany()
                        .HasForeignKey("AssignedUserId");
                });
#pragma warning restore 612, 618
        }
    }
}
