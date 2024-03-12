﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Motor.Models;
using Npgsql.EntityFrameworkCore.PostgreSQL.Metadata;

#nullable disable

namespace Motor.Migrations
{
    [DbContext(typeof(R4rContext))]
    partial class R4rContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 63);

            NpgsqlModelBuilderExtensions.UseIdentityByDefaultColumns(modelBuilder);

            modelBuilder.Entity("Motor.Models.Blog", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text")
                        .HasColumnName("id");

                    b.Property<string>("Content")
                        .HasColumnType("text")
                        .HasColumnName("content");

                    b.Property<string>("Createdby")
                        .HasColumnType("text")
                        .HasColumnName("created_by");

                    b.Property<string>("Img")
                        .HasColumnType("text")
                        .HasColumnName("img");

                    b.Property<string>("Title")
                        .HasColumnType("text")
                        .HasColumnName("title");

                    b.Property<DateTime?>("createdDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("created_date");

                    b.Property<DateTime?>("modifyDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("modify_date");

                    b.HasKey("Id")
                        .HasName("blog_pkey");

                    b.ToTable("blog", (string)null);
                });

            modelBuilder.Entity("Motor.Models.CartItem", b =>
                {
                    b.Property<string>("CartId")
                        .HasColumnType("text")
                        .HasColumnName("cartid");

                    b.Property<DateTime>("DateCreated")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("datecreated");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer")
                        .HasColumnName("quantity");

                    b.Property<string>("createBy")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("createby");

                    b.Property<string>("motorId")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("motorId");

                    b.Property<string>("totalprice")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("totalprice");

                    b.HasKey("CartId")
                        .HasName("cartitem_pkey");

                    b.ToTable("cart_shop", (string)null);
                });

            modelBuilder.Entity("Motor.Models.Comment", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text")
                        .HasColumnName("id");

                    b.Property<string>("Createdby")
                        .HasColumnType("text")
                        .HasColumnName("createdby");

                    b.Property<string>("comment")
                        .HasColumnType("text")
                        .HasColumnName("comment");

                    b.Property<DateTime>("createdDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("createdate");

                    b.Property<DateTime>("modifyDate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("modifydate");

                    b.Property<string>("motorId")
                        .HasColumnType("text")
                        .HasColumnName("motor_id");

                    b.HasKey("Id")
                        .HasName("motor_cmt_pkey");

                    b.ToTable("motor_cmt", (string)null);
                });

            modelBuilder.Entity("Motor.Models.imgMotor", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text")
                        .HasColumnName("id");

                    b.Property<string>("Imgbase64")
                        .HasColumnType("text")
                        .HasColumnName("imgbase64");

                    b.Property<string>("idMotor")
                        .HasColumnType("text")
                        .HasColumnName("idmotor");

                    b.HasKey("Id")
                        .HasName("imgmotor_pkey");

                    b.ToTable("imgmotor", (string)null);
                });

            modelBuilder.Entity("Motor.Models.MotorModel", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text")
                        .HasColumnName("id");

                    b.Property<string>("Createdby")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("createdby");

                    b.Property<DateTime>("Createddate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("createddate");

                    b.Property<string>("Description")
                        .HasColumnType("text")
                        .HasColumnName("description");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("name");

                    b.Property<string>("Price")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("price");

                    b.Property<int?>("Status")
                        .HasColumnType("integer")
                        .HasColumnName("status");

                    b.Property<string>("Type")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("type");

                    b.Property<int?>("farmous")
                        .HasColumnType("integer")
                        .HasColumnName("famous");

                    b.Property<string>("salePrice")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("sale_price");

                    b.HasKey("Id")
                        .HasName("motor_pkey");

                    b.ToTable("motor", (string)null);
                });

            modelBuilder.Entity("Motor.Models.Order", b =>
                {
                    b.Property<string>("orderId")
                        .HasColumnType("text")
                        .HasColumnName("orderId");

                    b.Property<string>("Createdby")
                        .HasColumnType("text")
                        .HasColumnName("createdby");

                    b.Property<DateTime>("Createddate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("createddate");

                    b.Property<int?>("Status")
                        .HasColumnType("integer")
                        .HasColumnName("status");

                    b.Property<string>("address")
                        .HasColumnType("text")
                        .HasColumnName("address");

                    b.Property<string>("totalPrice")
                        .HasColumnType("text")
                        .HasColumnName("totalprice");

                    b.HasKey("orderId")
                        .HasName("order_pkey");

                    b.ToTable("order", (string)null);
                });

            modelBuilder.Entity("Motor.Models.OrderDetail", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text")
                        .HasColumnName("id");

                    b.Property<int>("Quantity")
                        .HasColumnType("integer")
                        .HasColumnName("quantity");

                    b.Property<string>("motorId")
                        .HasColumnType("text")
                        .HasColumnName("motorId");

                    b.Property<string>("orderId")
                        .HasColumnType("text")
                        .HasColumnName("orderId");

                    b.Property<string>("price")
                        .HasColumnType("text")
                        .HasColumnName("price");

                    b.HasKey("Id")
                        .HasName("order_detial_pkey");

                    b.ToTable("order_detial", (string)null);
                });

            modelBuilder.Entity("Motor.Models.Role", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text")
                        .HasColumnName("id");

                    b.Property<string>("Code")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("code");

                    b.Property<string>("Name")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("name");

                    b.HasKey("Id")
                        .HasName("role_pkey");

                    b.ToTable("role", (string)null);
                });

            modelBuilder.Entity("Motor.Models.TypeMotor", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text")
                        .HasColumnName("id");

                    b.Property<string>("Code")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("code");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("name");

                    b.Property<string>("Status")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("status");

                    b.HasKey("Id")
                        .HasName("type_pkey");

                    b.ToTable("type", (string)null);
                });

            modelBuilder.Entity("Motor.Models.User", b =>
                {
                    b.Property<string>("Id")
                        .HasColumnType("text")
                        .HasColumnName("id");

                    b.Property<DateTime>("Createddate")
                        .HasColumnType("timestamp without time zone")
                        .HasColumnName("createddate");

                    b.Property<string>("Email")
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("email");

                    b.Property<string>("Fullname")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("fullname");

                    b.Property<string>("Password")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("password");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(255)
                        .HasColumnType("character varying(255)")
                        .HasColumnName("phone");

                    b.Property<string>("Roleid")
                        .IsRequired()
                        .HasColumnType("text")
                        .HasColumnName("roleid");

                    b.Property<int?>("Status")
                        .HasColumnType("integer")
                        .HasColumnName("status");

                    b.HasKey("Id")
                        .HasName("users_pkey");

                    b.ToTable("users", (string)null);
                });
#pragma warning restore 612, 618
        }
    }
}