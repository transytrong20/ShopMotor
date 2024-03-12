using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Motor.Migrations
{
    public partial class database : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "blog",
                columns: table => new
                {
                    id = table.Column<string>(type: "text", nullable: false),
                    created_by = table.Column<string>(type: "text", nullable: true),
                    content = table.Column<string>(type: "text", nullable: true),
                    title = table.Column<string>(type: "text", nullable: true),
                    img = table.Column<string>(type: "text", nullable: true),
                    created_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true),
                    modify_date = table.Column<DateTime>(type: "timestamp without time zone", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("blog_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "cart_shop",
                columns: table => new
                {
                    cartid = table.Column<string>(type: "text", nullable: false),
                    quantity = table.Column<int>(type: "integer", nullable: false),
                    motorId = table.Column<string>(type: "text", nullable: false),
                    datecreated = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    createby = table.Column<string>(type: "text", nullable: false),
                    totalprice = table.Column<string>(type: "text", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("cartitem_pkey", x => x.cartid);
                });

            migrationBuilder.CreateTable(
                name: "imgmotor",
                columns: table => new
                {
                    id = table.Column<string>(type: "text", nullable: false),
                    imgbase64 = table.Column<string>(type: "text", nullable: true),
                    idmotor = table.Column<string>(type: "text", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("imgmotor_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "motor",
                columns: table => new
                {
                    id = table.Column<string>(type: "text", nullable: false),
                    name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    type = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    description = table.Column<string>(type: "text", nullable: true),
                    price = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    createdby = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    createddate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    status = table.Column<int>(type: "integer", nullable: true),
                    famous = table.Column<int>(type: "integer", nullable: true),
                    sale_price = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("motor_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "motor_cmt",
                columns: table => new
                {
                    id = table.Column<string>(type: "text", nullable: false),
                    createdby = table.Column<string>(type: "text", nullable: true),
                    motor_id = table.Column<string>(type: "text", nullable: true),
                    comment = table.Column<string>(type: "text", nullable: true),
                    createdate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    modifydate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("motor_cmt_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "order",
                columns: table => new
                {
                    orderId = table.Column<string>(type: "text", nullable: false),
                    createdby = table.Column<string>(type: "text", nullable: true),
                    createddate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    totalprice = table.Column<string>(type: "text", nullable: true),
                    address = table.Column<string>(type: "text", nullable: true),
                    status = table.Column<int>(type: "integer", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("order_pkey", x => x.orderId);
                });

            migrationBuilder.CreateTable(
                name: "order_detial",
                columns: table => new
                {
                    id = table.Column<string>(type: "text", nullable: false),
                    orderId = table.Column<string>(type: "text", nullable: true),
                    motorId = table.Column<string>(type: "text", nullable: true),
                    price = table.Column<string>(type: "text", nullable: true),
                    quantity = table.Column<int>(type: "integer", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("order_detial_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "role",
                columns: table => new
                {
                    id = table.Column<string>(type: "text", nullable: false),
                    code = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true),
                    name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("role_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "type",
                columns: table => new
                {
                    id = table.Column<string>(type: "text", nullable: false),
                    code = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    name = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    status = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("type_pkey", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "users",
                columns: table => new
                {
                    id = table.Column<string>(type: "text", nullable: false),
                    phone = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    password = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    fullname = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: false),
                    status = table.Column<int>(type: "integer", nullable: true),
                    createddate = table.Column<DateTime>(type: "timestamp without time zone", nullable: false),
                    roleid = table.Column<string>(type: "text", nullable: false),
                    email = table.Column<string>(type: "character varying(255)", maxLength: 255, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("users_pkey", x => x.id);
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "blog");

            migrationBuilder.DropTable(
                name: "cart_shop");

            migrationBuilder.DropTable(
                name: "imgmotor");

            migrationBuilder.DropTable(
                name: "motor");

            migrationBuilder.DropTable(
                name: "motor_cmt");

            migrationBuilder.DropTable(
                name: "order");

            migrationBuilder.DropTable(
                name: "order_detial");

            migrationBuilder.DropTable(
                name: "role");

            migrationBuilder.DropTable(
                name: "type");

            migrationBuilder.DropTable(
                name: "users");
        }
    }
}
