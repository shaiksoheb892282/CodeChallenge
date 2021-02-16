create table Customer(
    CustomerID int not null,
    LastName varchar(50) not null,
    FirstName varchar(50) not null,
    Email varchar(100) not null,
    Phone varchar(10) not null,
    AddressLine1 varchar(50) not null,
    AddressLine2 varchar(50) not null,
    City varchar(50) not null,
    State varchar(50) not null,
    PostalCode varchar(10) not null,
    Country varchar(50) not null,
    EmailVerified char(1) not null
)

create table Product(
    ProductID int not null,
    ProductDesc varchar(50) not null,
    VendorDesc varchar(50) not null,
    Rating int not null,
    SellingPrice decimal(9,2) not null,
    Discount int not null
)

create table Orders(
    OrderID int not null,
    CustomerID int not null,
    OrderDate date not null,
    ShipmentDate date not null,
    Status char(1) not null,
    Comments varchar(50)
)

create table ProdOrdCount(
    ProdOrdID int not null,
    OrderID int not null,
    ProductID int not null,
    Quantity int not null
)

Alter table Customer
add constraint pk_Customer primary key(CustomerID)


alter table Product
add constraint pk_Product primary key(ProductID)

alter table Product
add constraint ck_Rating Check(Rating >=0 and Rating <=5)

alter table Orders
add constraint pk_Orders primary key(OrderID)

alter table Orders
add constraint fk_Orders_Customer foreign key (CustomerID) references Customer(CustomerID)

alter table ProdOrdCount
add constraint pk_ProdOrdCount primary key(ProdOrdID)

alter table ProdOrdCount
add constraint fk_ProdOrdCount_Product foreign key(ProductID) references Product(ProductID)

alter table ProdOrdCount
add constraint fk_ProdOrdCount_Orders foreign key(OrderID) references Orders(OrderID)
go
