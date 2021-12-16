﻿// <auto-generated />
using System;
using DataAccess.Persistence;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace DataAccess.Migrations
{
    [DbContext(typeof(ChatContext))]
    [Migration("20211216151654_ConnectionMigration")]
    partial class ConnectionMigration
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "5.0.11");

            modelBuilder.Entity("Entities.Connection", b =>
                {
                    b.Property<string>("ConnectionID")
                        .HasColumnType("TEXT");

                    b.Property<bool>("Connected")
                        .HasColumnType("INTEGER");

                    b.Property<string>("UserAgent")
                        .HasColumnType("TEXT");

                    b.Property<int?>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("ConnectionID");

                    b.HasIndex("UserId");

                    b.ToTable("Connections");
                });

            modelBuilder.Entity("Entities.Friendship", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("CloseFriend")
                        .HasColumnType("INTEGER");

                    b.Property<int>("FriendUserId")
                        .HasColumnType("INTEGER");

                    b.Property<int>("UserId")
                        .HasColumnType("INTEGER");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Friendships");
                });

            modelBuilder.Entity("Entities.GroupChat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("GroupName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("GroupChats");
                });

            modelBuilder.Entity("Entities.Message", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int?>("ForwardedMessageId")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("GroupChatId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("LocalDateTime")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Mine")
                        .HasColumnType("INTEGER");

                    b.Property<bool?>("PinnedMessage")
                        .HasColumnType("INTEGER");

                    b.Property<int?>("PrivateChatId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("ReceiverUsername")
                        .HasColumnType("TEXT");

                    b.Property<int?>("RepliedMessageId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("SenderUsername")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Text")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("GroupChatId");

                    b.HasIndex("PrivateChatId");

                    b.ToTable("Messages");
                });

            modelBuilder.Entity("Entities.Participant", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<bool>("Admin")
                        .HasColumnType("INTEGER");

                    b.Property<int>("GroupChatId")
                        .HasColumnType("INTEGER");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.HasIndex("GroupChatId");

                    b.ToTable("Participants");
                });

            modelBuilder.Entity("Entities.PrivateChat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("Participant1")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Participant2")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("PrivateChats");
                });

            modelBuilder.Entity("Entities.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("Entities.Connection", b =>
                {
                    b.HasOne("Entities.User", null)
                        .WithMany("Connections")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("Entities.Friendship", b =>
                {
                    b.HasOne("Entities.User", null)
                        .WithMany("Friends")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.Message", b =>
                {
                    b.HasOne("Entities.GroupChat", null)
                        .WithMany("Messages")
                        .HasForeignKey("GroupChatId");

                    b.HasOne("Entities.PrivateChat", null)
                        .WithMany("Messages")
                        .HasForeignKey("PrivateChatId");
                });

            modelBuilder.Entity("Entities.Participant", b =>
                {
                    b.HasOne("Entities.GroupChat", null)
                        .WithMany("Participants")
                        .HasForeignKey("GroupChatId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entities.GroupChat", b =>
                {
                    b.Navigation("Messages");

                    b.Navigation("Participants");
                });

            modelBuilder.Entity("Entities.PrivateChat", b =>
                {
                    b.Navigation("Messages");
                });

            modelBuilder.Entity("Entities.User", b =>
                {
                    b.Navigation("Connections");

                    b.Navigation("Friends");
                });
#pragma warning restore 612, 618
        }
    }
}
