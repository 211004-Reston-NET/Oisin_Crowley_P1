using Microsoft.EntityFrameworkCore.Migrations;

namespace SupplyShopDL.Migrations
{
    public partial class infomigration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customer",
                columns: table => new
                {
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Customer_Name = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    cust_StreetAdd = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    cust_City = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    cust_State = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    cust_Zip = table.Column<int>(type: "int", nullable: false),
                    cust_Email = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    cust_Phone = table.Column<string>(type: "varchar(11)", unicode: false, maxLength: 11, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Pk_CustomerId", x => x.CustomerID);
                });

            migrationBuilder.CreateTable(
                name: "StoreFront",
                columns: table => new
                {
                    StoreID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StoreName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    StreetAdd = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: false),
                    Store_City = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Store_State = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: false),
                    Store_Zip = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    OrderID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("primary_key_StoreID", x => x.StoreID);
                });

            migrationBuilder.CreateTable(
                name: "Items",
                columns: table => new
                {
                    ProductID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    itemPrice = table.Column<double>(type: "float", nullable: false),
                    prodQuantity = table.Column<int>(type: "int", nullable: false),
                    itemName = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    itemDesc = table.Column<string>(type: "varchar(100)", unicode: false, maxLength: 100, nullable: true),
                    category = table.Column<string>(type: "varchar(50)", unicode: false, maxLength: 50, nullable: true),
                    StoreID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Pk_ProductID", x => x.ProductID);
                    table.ForeignKey(
                        name: "fok_StoreID",
                        column: x => x.StoreID,
                        principalTable: "StoreFront",
                        principalColumn: "StoreID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Orders",
                columns: table => new
                {
                    OrdersID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    totalPrice = table.Column<double>(type: "float", nullable: false),
                    StoreID = table.Column<int>(type: "int", nullable: false),
                    CustomerID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Pk_OrdersID", x => x.OrdersID);
                    table.ForeignKey(
                        name: "FK_CustomerID",
                        column: x => x.CustomerID,
                        principalTable: "Customer",
                        principalColumn: "CustomerID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "fk_StoreID",
                        column: x => x.StoreID,
                        principalTable: "StoreFront",
                        principalColumn: "StoreID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "LineItems",
                columns: table => new
                {
                    LineItemID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Quantity = table.Column<int>(type: "int", nullable: false),
                    ProductID = table.Column<int>(type: "int", nullable: false),
                    OrdersID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("Pk_LineItemID", x => x.LineItemID);
                    table.ForeignKey(
                        name: "frk_ProductID",
                        column: x => x.ProductID,
                        principalTable: "Items",
                        principalColumn: "ProductID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "frkey_orderID",
                        column: x => x.OrdersID,
                        principalTable: "Orders",
                        principalColumn: "OrdersID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Items_StoreID",
                table: "Items",
                column: "StoreID");

            migrationBuilder.CreateIndex(
                name: "IX_LineItems_OrdersID",
                table: "LineItems",
                column: "OrdersID");

            migrationBuilder.CreateIndex(
                name: "IX_LineItems_ProductID",
                table: "LineItems",
                column: "ProductID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_CustomerID",
                table: "Orders",
                column: "CustomerID");

            migrationBuilder.CreateIndex(
                name: "IX_Orders_StoreID",
                table: "Orders",
                column: "StoreID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "LineItems");

            migrationBuilder.DropTable(
                name: "Items");

            migrationBuilder.DropTable(
                name: "Orders");

            migrationBuilder.DropTable(
                name: "Customer");

            migrationBuilder.DropTable(
                name: "StoreFront");
        }
    }
}
