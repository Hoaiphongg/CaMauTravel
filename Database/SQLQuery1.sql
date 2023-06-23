
Create database CaMauTravel
go
use CaMauTravel
go

Create table [Account](
	[account_id] int identity primary key,
	[username] varchar(50) not null,
	[password] varchar(200) not null,
	[roll] int not null,
	-- 1: customer, 2: employee, 3: manager
	[name] nvarchar(50) not null,
	[gender] bit not null,
	-- 0: female, 1: male
	[birthday] date not null,
	[address] nvarchar(100) not null,
	[phone] varchar(15) not null,
	[email] varchar(50),
	[status] bit not null default 1
	-- 0: disable, --1: enable
)
go
Create table [PlaceType](
	[ID] int primary key identity,
	[Name] nvarchar(100) not null,
	[Description] nvarchar(1000) not null,
	[MetaTitle] varchar(100),
	[ParentID] bigint,
	[DisplayOrder] int default 0,
	[SeoTitle] nvarchar(250),
	[CreateDate] datetime default getdate(),
	[MetaWords] nvarchar(250),
	[MetaDescription] nchar(250),
	[Status] bit default 1
)

go
Create table [TouristAttraction](
	[ID] bigint primary key identity,
	[Name] nvarchar(100) not null,
	[Description] nvarchar(1000),
	[PlaceTypeID] int,
	[MetaTitle] varchar(100),
	[ParentID] bigint,
	[DisplayOrder] int default 0,
	[SeoTitle] nvarchar(250),
	[CreateDate] datetime default getdate(),
	[MetaWords] nvarchar(250),
	[MetaDescription] nchar(250),
	[Status] bit default 1
)

ALTER TABLE [TouristAttraction]
ALTER COLUMN [Description] nvarchar(4000)

ALTER TABLE [TouristAttraction]
add [Images] varchar(250);


go

Create table [TourisAttrDetail](
	[ID] bigint primary key identity,
	[SelectTourisAttraction] varchar(50)
)
ALTER TABLE [TourisAttrDetail]
ALTER COLUMN [SelectTourisAttraction] nvarchar(500)



go
Create table [Touris](
	[ID] bigint primary key identity,
	[Name] nvarchar(100) not null,
	[Description] nvarchar(1000),
	[Image] varchar(250),
	[MoreImage] xml,
	[Price] decimal(18,0) default 0,
	[PlaceTypeID] int FOREIGN KEY ([PlaceTypeID]) references [PlaceType] ([ID]),
	[Schedule] nvarchar(2000),
	[PromotionPrice] decimal(18,0),
	[Quanlity] int default 0,
	[TourisDetailID] bigint FOREIGN KEY ([TourisDetailID]) references [TourisAttrDetail] ([ID]),
	[MetaTitle] varchar(100),
	[ParentID] bigint,
	[DisplayOrder] int,
	[SeoTitle] nvarchar(250),
	[CreateDate] datetime,
	[MetaWords] nvarchar(250),
	[MetaDescription] nchar(250),
	[Status] bit default 1,
	[TopHot] datetime
)

ALTER TABLE [Touris]
ALTER COLUMN [Schedule] nvarchar(4000)

ALTER TABLE [Touris]
ALTER COLUMN [Schedule] ntext


ALTER TABLE [Touris]
ALTER COLUMN [Description] nvarchar(4000)


go
Create table [NewsCategory](
	[ID] bigint primary key identity,
	[Name] nvarchar(100) not null,
	[Description] nvarchar(100),
	[MetaTitle] varchar(100),
	[ParentID] bigint,
	[DisplayOrder] int default 0,
	[SeoTitle] nvarchar(250),
	[CreateDate] datetime default getdate(),
	[MetaWords] nvarchar(250),
	[MetaDescription] nchar(250),
	[Status] bit default 1
)

go
Create table [News](
	[ID] bigint primary key identity,
	[Name] nvarchar(100) not null,
	[Description] nvarchar(100),
	[Image] varchar(250),
	[NewsCategoryID] bigint,
	[MetaTitle] varchar(100),
	[ParentID] bigint,
	[DisplayOrder] int,
	[SeoTitle] nvarchar(250),
	[CreateDate] datetime,
	[MetaWords] nvarchar(250),
	[MetaDescription] nchar(250),
	[Status] bit default 1,
	[TopHot] datetime
)
ALTER TABLE [News]
ALTER COLUMN [Description] nvarchar(4000)


go
Create table [About](
	[ID] bigint primary key identity,
	[Name] nvarchar(100) not null,
	[Description] nvarchar(100),
	[MetaTitle] varchar(100),
	[ParentID] bigint,
	[DisplayOrder] int,
	[SeoTitle] nvarchar(250),
	[CreateDate] datetime,
	[MetaWords] nvarchar(250),
	[MetaDescription] nchar(250),
	[Status] bit default 1,
)

go
Create table [Contact](
	[ID] bigint primary key identity,
	[Content] ntext,
	[Status] bit default 1,
)

go
Create table [Feedback](
	[ID] bigint primary key identity,
	[Name] nvarchar(100) not null,
	[Phone] varchar(11),
	[Email] varchar(100),
	[Address] nvarchar(1000),
	[Content] nvarchar(1000),
	[CreateDate] datetime,
	[Status] bit default 1,
)


go
Create table [Oder](
	[ID] bigint primary key identity,
	[CustomerID] bigint,
	[CreateDate] datetime
)

ALTER TABLE [Oder]
  ADD [ShipName] nvarchar(200),
      [Mobile] varchar(10),
      [Address] nvarchar(200),
      [Email] nvarchar(200);

ALTER TABLE [Oder]
  ADD [Status] bit default 1;
go
Create table [OderDetail](
	[TourisID] bigint,
	[OrderID] bigint,
	[Quanlity] int default 1,
	[Price] decimal(18,0),
	primary key([TourisID], [OrderID])
)