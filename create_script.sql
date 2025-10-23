
drop table if exists PartnerServices;
drop table if exists Materials;
drop table if exists OrderPositions;
drop table if exists Orders;
drop table if exists Staff;
drop table if exists Partners;
drop table if exists MaterialType;

drop table if exists [Services];
drop table if exists ServiceType;


create table MaterialType(
[name] nvarchar(100) primary key,
[overspending_percen] float not null
);

create table Partners(
[type] nvarchar(100) not null,
[name] nvarchar(100) primary key,
[director] nvarchar(100) not null,
[email] nvarchar(100) not null,
[phone] nvarchar(100) not null,
[address] nvarchar(200) not null,
[inn] nvarchar(100) not null,
[rating] int not null,
);


create table PartnerServices(
sevice nvarchar(100),
partner_name nvarchar(100) not null,
service_amount int not null,
date_complite DateTime not null
constraint partner_type_FK foreign key ([partner_name]) references Partners ([name]),
constraint servise_name_FK foreign key (sevice) references [Services] ([name])
);


create table ServiceType(
[name] nvarchar(100) primary key,
[difficulty_factor] float not null
);

create table [Services](
[type] nvarchar(100) not null,
[name] nvarchar(100) primary key,
[code] nvarchar(100) not null,
[min_partner_price] float not null,
constraint service_type_FK foreign key ([type]) references ServiceType ([name])
);

create table Materials(
[type] nvarchar(100) not null,
[name] nvarchar(100) not null,
[provider] nvarchar(100) not null,
[amount_in_package] int not null,
price float not null,
[curr_amount] int not null
constraint material_type_FK foreign key ([type]) references MaterialType ([name])
);

create table Staff(
[login] nvarchar(100) primary key,
[pasword] nvarchar(100) not null,
[full_name] nvarchar(100) not null,
[birth_day] DateTime,
[passport_data] nvarchar(100),
[bank_data] nvarchar(200),
[post] nvarchar(100) not null,
health_state nvarchar(100)
);

create table Orders(
[id] int identity(1,1) primary key,
[partner_name] nvarchar(100) not null,
[manager_logni] nvarchar(100),
[status] nvarchar(100) not null,
[prepay_complite]  bit,
[date_create] DateTime not null
constraint order_partner_FK foreign key ([partner_name]) references Partners ([name]),
constraint order_manager_FK foreign key ([manager_logni]) references Staff ([login])
);

create table OrderPositions(
[id] int identity(1,1) primary key,
[order] int not null,
[service] nvarchar(100) not null,
[price] float,
[date_complite] DateTime
constraint order_id_FK foreign key ([id]) references Orders ([id]),
constraint servise_id_FK foreign key ([service]) references [Services] ([name])
)

--create table Partners(
--[login] nvarchar(100) not null,
--[pasword] nvarchar(100) not null,
--[type] nvarchar(100) not null,
--[name] nvarchar(100) primary key,
--[address] nvarchar(100) not null,
--[inn] nvarchar(100) not null,
--[director_full_name] nvarchar(100)  not null,
--phone nvarchar(100) not null,
--email nvarchar(100) not null,
--logo nvarchar(100)
--);
