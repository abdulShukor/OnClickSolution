DELETE FROM categories;
DELETE FROM SpecialTags;
GO
SET IDENTITY_INSERT dbo.Categories ON;  
GO
--Categories
INSERT INTO Categories(Id,Name) VALUES (1,'Rings');

INSERT INTO Categories(Id,Name) VALUES (2,'Bracelets');

INSERT INTO Categories(Id,Name) VALUES (3,'Watches');

INSERT INTO Categories(Id,Name) VALUES (4,'Earings');
SET IDENTITY_INSERT Categories OFF;  
GO
SET IDENTITY_INSERT SpecialTags ON;  
GO
INSERT INTO SpecialTags(Id,Name) VALUES(1,'Clearance');
INSERT INTO SpecialTags(Id,Name) VALUES(2,'Free Delivery');
INSERT INTO SpecialTags(Id,Name) VALUES(3,'Hand Made');
INSERT INTO SpecialTags(Id,Name) VALUES(4,'Certified');
SET IDENTITY_INSERT SpecialTags OFF;
GO
--Products
Insert Into Products(Name, Description, OriginalPrice, PromotionalPrice, CategoryId, Available, Image,SpecialTagsID)
values ('Heart', 'Lovers choice', 799, 749, 1, 1, '\images\ProductImage\1.jpg',1);

Insert Into Products(Name, Description, OriginalPrice,PromotionalPrice, CategoryId, Available, Image)
values ('Diamond1', 'Beutiful choice', 2500.00,0, 1, 1, '\images\ProductImage\2.jpg');

Insert Into Products(Name, Description, OriginalPrice, PromotionalPrice, CategoryId, Available, Image,SpecialTagsID)
values ('Diamond2', 'Classic Diamond Ring', 1700, 0, 1, 1, '\images\ProductImage\3.jpg',3);

Insert Into Products(Name, Description, OriginalPrice, PromotionalPrice, CategoryId, Available, Image)
values ('Flower', 'Flower Bracelet', 1300, 1199, 2, 0, '\images\ProductImage\4.jpg');

Insert Into Products(Name, Description, OriginalPrice, PromotionalPrice, CategoryId, Available, Image)
values ('Royal', 'Royal Ring', 2700, 0, 1, 0, '\images\ProductImage\5.jpg');

Insert Into Products(Name, Description, OriginalPrice, PromotionalPrice, CategoryId, Available, Image,SpecialTagsID)
values ('Traditional', 'Best gift for your Grandmother', 600, 459, 1, 1, '\images\ProductImage\6.jpg',2);

Insert Into Products(Name, Description, OriginalPrice, PromotionalPrice, CategoryId, Available, Image,SpecialTagsID)
values ('Stylish', 'Perfect price now', 400, 0, 3, 1, '\images\ProductImage\7.jpg',2);

Insert Into Products(Name, Description, OriginalPrice, PromotionalPrice, CategoryId, Available, Image)
values ('Traditional1', 'Rememebrance', 800, 599, 3, 1, '\images\ProductImage\8.jpg');

Insert Into Products(Name, Description, OriginalPrice, PromotionalPrice, CategoryId, Available, Image,SpecialTagsID)
values ('GoldenPocket', 'Golden Pocket Watch', 1800, 1700, 3, 0, '\images\ProductImage\9.jpg',4);

Insert Into Products(Name, Description, OriginalPrice, PromotionalPrice, CategoryId, Available, Image)
values ('Classic', 'Classic Simple', 350.00, 199.99, 3, 1, '\images\ProductImage\10.jpg');
