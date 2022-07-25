## For the Database you can execute the next Script

```
USE master
GO

CREATE DATABASE eCommerce
GO

USE eCommerce
GO

CREATE SCHEMA [production]
GO

CREATE TABLE [production].[Product](
	[ProductID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](64) NOT NULL,
	[ProductNumber] [varchar](32) NOT NULL,
	[ListPrice] [decimal](8, 2) NOT NULL
 CONSTRAINT [PK_Product_ProductID] PRIMARY KEY CLUSTERED ([ProductID] ASC ) ON [PRIMARY]
) ON [PRIMARY];

CREATE TABLE [production].[ProductCategory](
	[ProductCategoryID] [int] IDENTITY(1,1) NOT NULL,
	[Name] [varchar](64) NOT NULL,
	[ModifiedDate] [datetime] NOT NULL,
 CONSTRAINT [PK_ProductCategory_ProductCategoryID] PRIMARY KEY CLUSTERED ([ProductCategoryID] ASC) ON [PRIMARY]
) ON [PRIMARY];
```

### Connection String for MultiSubnetFailover

"DataContext": "Server=<server>; Database=ecommerce; user id=admin;password=<password>; MultiSubnetFailover=True"
"DataContext": "Server=<server>; Database=ecommerce; user id=postgres;password=<password>; MultiSubnetFailover=True"


### Environment variables

export DB_HOST=<>
export DB_PORT=<>
export DB_NAME=<>
export DB_USER=<>
export DB_PASS=<>

### Docker image

docker build -t aspnetapp .
docker run -d -p 8080:80 --name myapp aspnetapp