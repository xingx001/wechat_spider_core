﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;
using wechat_spider_core.ef;

namespace wechat_spider_core.Migrations
{
    [DbContext(typeof(SpiderContext))]
    partial class SpiderContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn)
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            modelBuilder.Entity("wechat_spider_core.ef.SpiderRole", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Role")
                        .IsRequired()
                        .HasColumnName("role")
                        .HasColumnType("character varying(20)")
                        .HasMaxLength(20);

                    b.Property<long?>("account_id")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("account_id");

                    b.ToTable("spider_role");
                });

            modelBuilder.Entity("wechat_spider_core.ef.TaskStartSign", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<long>("ClientId")
                        .HasColumnName("client_id")
                        .HasColumnType("bigint");

                    b.Property<bool>("RunStatus")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("run_status")
                        .HasColumnType("boolean")
                        .HasDefaultValue(false);

                    b.Property<DateTime>("StartDate")
                        .HasColumnName("start_date")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.ToTable("task_start_sign");
                });

            modelBuilder.Entity("wechat_spider_core.ef.WeChatAccount", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<string>("Alias")
                        .HasColumnName("alias")
                        .HasColumnType("character varying(128)")
                        .HasMaxLength(128);

                    b.Property<string>("FakeId")
                        .HasColumnName("fackid")
                        .HasColumnType("character varying(128)")
                        .HasMaxLength(128);

                    b.Property<DateTime?>("LastUpdate")
                        .HasColumnName("last_update_time")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("NickName")
                        .IsRequired()
                        .HasColumnName("nick_name")
                        .HasColumnType("character varying(128)")
                        .HasMaxLength(128);

                    b.Property<string>("RoundHeadImg")
                        .HasColumnName("round_head_img")
                        .HasColumnType("character varying(500)")
                        .HasMaxLength(500);

                    b.Property<int>("ServiceType")
                        .HasColumnName("service_type")
                        .HasColumnType("integer");

                    b.Property<long?>("task_sign_id")
                        .HasColumnType("bigint");

                    b.HasKey("Id");

                    b.HasIndex("task_sign_id");

                    b.ToTable("wechat_account");
                });

            modelBuilder.Entity("wechat_spider_core.ef.WeChatArticle", b =>
                {
                    b.Property<long>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("bigint")
                        .HasAnnotation("Npgsql:ValueGenerationStrategy", NpgsqlValueGenerationStrategy.IdentityByDefaultColumn);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnName("create_date")
                        .HasColumnType("timestamp without time zone");

                    b.Property<bool>("Download")
                        .HasColumnName("download")
                        .HasColumnType("boolean");

                    b.Property<string>("LocalPath")
                        .HasColumnName("local_path")
                        .HasColumnType("character varying(255)")
                        .HasMaxLength(255);

                    b.Property<long?>("account_id")
                        .HasColumnType("bigint");

                    b.Property<string>("aid")
                        .HasColumnType("text");

                    b.Property<string>("album_id")
                        .HasColumnType("text");

                    b.Property<long>("appmsgid")
                        .HasColumnType("bigint");

                    b.Property<int>("checking")
                        .HasColumnType("integer");

                    b.Property<int>("copyright_type")
                        .HasColumnType("integer");

                    b.Property<string>("cover")
                        .HasColumnType("text");

                    b.Property<DateTime>("create_time")
                        .HasColumnType("timestamp without time zone");

                    b.Property<string>("digest")
                        .HasColumnType("text");

                    b.Property<int>("has_red_packet_cover")
                        .HasColumnType("integer");

                    b.Property<int>("is_original")
                        .HasColumnType("integer");

                    b.Property<int>("is_pay_subscribe")
                        .HasColumnType("integer");

                    b.Property<int>("item_show_type")
                        .HasColumnType("integer");

                    b.Property<int>("itemidx")
                        .HasColumnType("integer");

                    b.Property<string>("link")
                        .HasColumnType("text");

                    b.Property<string>("media_duration")
                        .HasColumnType("text");

                    b.Property<int>("mediaapi_publish_status")
                        .HasColumnType("integer");

                    b.Property<string>("tagid")
                        .HasColumnType("text");

                    b.Property<string>("title")
                        .HasColumnType("text");

                    b.Property<DateTime>("update_time")
                        .HasColumnType("timestamp without time zone");

                    b.HasKey("Id");

                    b.HasIndex("account_id");

                    b.ToTable("wechat_article");
                });

            modelBuilder.Entity("wechat_spider_core.ef.SpiderRole", b =>
                {
                    b.HasOne("wechat_spider_core.ef.WeChatAccount", "WeChatAccount")
                        .WithMany("SpiderRoles")
                        .HasForeignKey("account_id");
                });

            modelBuilder.Entity("wechat_spider_core.ef.WeChatAccount", b =>
                {
                    b.HasOne("wechat_spider_core.ef.TaskStartSign", "TaskStartSign")
                        .WithMany()
                        .HasForeignKey("task_sign_id");
                });

            modelBuilder.Entity("wechat_spider_core.ef.WeChatArticle", b =>
                {
                    b.HasOne("wechat_spider_core.ef.WeChatAccount", "WeChatAccount")
                        .WithMany()
                        .HasForeignKey("account_id");
                });
#pragma warning restore 612, 618
        }
    }
}
