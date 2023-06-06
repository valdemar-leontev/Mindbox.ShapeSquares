-- Database creation

use [master];
go

drop database if exists [Mindbox.Database];
go

create database [Mindbox.Database];
go

-- Schema creation

use [Mindbox.Database];
go

create schema [Business];
go

-- Tables creation

create table [Business].[Category]
(
    [Id] int identity(1, 1) not null,
    [Name] nvarchar(64) not null

    constraint [PK_Business_Category_Id] primary key ([Id])
);

create table [Business].[Product]
(
    [Id] int identity(1, 1) not null,
    [Name] nvarchar(64) not null,

    constraint [PK_Business_Product_Id] primary key ([Id])
);

create table [Business].[ProductLinkCategory]
(
    [Id] int identity(1, 1) not null,
    [ProductId] int not null,
    [CategoryId] int not null

    constraint [PK_Business_ProductLinkCategory_Id] primary key ([Id]),
    constraint [FK_Business_ProductLinkCategory_ProductId_Business_Product_Id] foreign key ([ProductId]) references [Business].[Product]([Id]),
    constraint [FK_Business_ProductLinkCategory_CategoryId_Business_Category_Id] foreign key ([CategoryId]) references [Business].[Category]([Id])
);
go

-- PostDeployment

set identity_insert [Business].[Category] on;

insert into [Business].[Category]
([Id], [Name])
values
    (1, 'Phone'),
    (2, 'Laptop'),
    (3, 'Tablet'),
    (4, 'Lamp'),
    (5, 'Gadget')

set identity_insert [Business].[Category] off;

set identity_insert [Business].[Product] on;

insert into [Business].[Product]
([Id], [Name])
values
    (1, 'MacBook pro'),
    (2, 'MateBook 16s'),
    (3, 'Iphone 14 pro'),
    (4, 'Samsung A51'),
    (5, 'Mi Notebook Pro 15'),
    (6, 'Xiaomi Mijia Pipi Lamp')

set identity_insert [Business].[Product] off;

set identity_insert [Business].[ProductLinkCategory] on;

insert into [Business].[ProductLinkCategory]
([Id], [ProductId], [CategoryId])
values
    (1, 1, 2),
    (2, 2, 2),
    (3, 3, 1),
    (4, 4, 1),
    (5, 5, 3),
    (6, 4, 5)

set identity_insert [Business].[ProductLinkCategory] off;