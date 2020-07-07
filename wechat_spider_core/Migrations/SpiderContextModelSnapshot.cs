﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
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
                .HasAnnotation("ProductVersion", "3.1.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 64);

            modelBuilder.Entity("wechat_spider_core.ef.TaskStartSign", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnName("id")
                        .HasColumnType("varchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("StartDate")
                        .IsRequired()
                        .HasColumnName("start_date")
                        .HasColumnType("text");

                    b.HasKey("Id");

                    b.ToTable("task_start_sign");
                });

            modelBuilder.Entity("wechat_spider_core.ef.WeChatAccount", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnName("id")
                        .HasColumnType("int");

                    b.Property<string>("Alias")
                        .HasColumnName("alias")
                        .HasColumnType("varchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("FakeId")
                        .HasColumnName("fackid")
                        .HasColumnType("varchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("Homeownid")
                        .HasColumnName("hometownid")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<DateTime?>("LastUpdate")
                        .HasColumnName("last_update_time")
                        .HasColumnType("datetime");

                    b.Property<string>("NickName")
                        .IsRequired()
                        .HasColumnName("nick_name")
                        .HasColumnType("varchar(128)")
                        .HasMaxLength(128);

                    b.Property<string>("RoundHeadImg")
                        .HasColumnName("round_head_img")
                        .HasColumnType("varchar(500)")
                        .HasMaxLength(500);

                    b.Property<int>("ServiceType")
                        .HasColumnName("service_type")
                        .HasColumnType("int");

                    b.Property<string>("SpiderRole")
                        .HasColumnName("spider_role")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("SpiderRole1")
                        .HasColumnName("spider_role1")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("SpiderRole2")
                        .HasColumnName("spider_role2")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("SpiderRole3")
                        .HasColumnName("spider_role3")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("SpiderRole4")
                        .HasColumnName("spider_role4")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20);

                    b.Property<string>("SpiderRole5")
                        .HasColumnName("spider_role5")
                        .HasColumnType("varchar(20)")
                        .HasMaxLength(20);

                    b.HasKey("Id");

                    b.ToTable("wechat_account");
                });

            modelBuilder.Entity("wechat_spider_core.ef.WeChatArticle", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnName("id")
                        .HasColumnType("varchar(128)")
                        .HasMaxLength(128);

                    b.Property<DateTime>("CreateDate")
                        .HasColumnName("create_date")
                        .HasColumnType("datetime");

                    b.Property<bool>("Download")
                        .HasColumnName("download")
                        .HasColumnType("bit");

                    b.Property<string>("Homeownid")
                        .HasColumnName("hometownid")
                        .HasColumnType("varchar(50)")
                        .HasMaxLength(50);

                    b.Property<string>("LocalPath")
                        .HasColumnName("local_path")
                        .HasColumnType("varchar(255)")
                        .HasMaxLength(255);

                    b.Property<int?>("account_id")
                        .HasColumnType("int");

                    b.Property<string>("aid")
                        .HasColumnType("text");

                    b.Property<string>("album_id")
                        .HasColumnType("text");

                    b.Property<long>("appmsgid")
                        .HasColumnType("bigint");

                    b.Property<int>("checking")
                        .HasColumnType("int");

                    b.Property<int>("copyright_type")
                        .HasColumnType("int");

                    b.Property<string>("cover")
                        .HasColumnType("text");

                    b.Property<DateTime>("create_time")
                        .HasColumnType("datetime");

                    b.Property<string>("digest")
                        .HasColumnType("text");

                    b.Property<int>("has_red_packet_cover")
                        .HasColumnType("int");

                    b.Property<int>("is_original")
                        .HasColumnType("int");

                    b.Property<int>("is_pay_subscribe")
                        .HasColumnType("int");

                    b.Property<int>("item_show_type")
                        .HasColumnType("int");

                    b.Property<int>("itemidx")
                        .HasColumnType("int");

                    b.Property<string>("link")
                        .HasColumnType("text");

                    b.Property<string>("media_duration")
                        .HasColumnType("text");

                    b.Property<int>("mediaapi_publish_status")
                        .HasColumnType("int");

                    b.Property<string>("tagid")
                        .HasColumnType("text");

                    b.Property<string>("title")
                        .HasColumnType("text");

                    b.Property<DateTime>("update_time")
                        .HasColumnType("datetime");

                    b.HasKey("Id");

                    b.HasIndex("account_id");

                    b.ToTable("wechat_article");
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
