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

SET IDENTITY_INSERT dbo.Products ON;  
GO
--Products
Insert Into Products(Id,Name, Description, OriginalPrice, PromotionalPrice, CategoryId, Available, Image,SpecialTagsID)
values (1,'Heart', 'Lovers choice', 799, 749, 1, 1, '\images\ProductImage\1.jpg',1);

Insert Into Products(Id,Name, Description, OriginalPrice,PromotionalPrice, CategoryId, Available, Image)
values (2,'Diamond1', 'Beutiful choice', 2500.00,0, 1, 1, '\images\ProductImage\2.jpg');

Insert Into Products(Id,Name, Description, OriginalPrice, PromotionalPrice, CategoryId, Available, Image,SpecialTagsID)
values (3,'Diamond2', 'Classic Diamond Ring', 1700, 0, 1, 1, '\images\ProductImage\3.jpg',3);

Insert Into Products(Id,Name, Description, OriginalPrice, PromotionalPrice, CategoryId, Available, Image)
values (4,'Flower', 'Flower Bracelet', 1300, 1199, 2, 0, '\images\ProductImage\4.jpg');

Insert Into Products(Id,Name, Description, OriginalPrice, PromotionalPrice, CategoryId, Available, Image)
values (5,'Royal', 'Royal Ring', 2700, 0, 1, 0, '\images\ProductImage\5.jpg');

Insert Into Products(Id,Name, Description, OriginalPrice, PromotionalPrice, CategoryId, Available, Image,SpecialTagsID)
values (6,'Traditional', 'Best gift for your Grandmother', 600, 459, 1, 1, '\images\ProductImage\6.jpg',2);

Insert Into Products(Id,Name, Description, OriginalPrice, PromotionalPrice, CategoryId, Available, Image,SpecialTagsID)
values (7,'Stylish', 'Perfect price now', 400, 0, 3, 1, '\images\ProductImage\7.jpg',2);

Insert Into Products(Id,Name, Description, OriginalPrice, PromotionalPrice, CategoryId, Available, Image)
values (8,'Traditional1', 'Rememebrance', 800, 599, 3, 1, '\images\ProductImage\8.jpg');

Insert Into Products(Id,Name, Description, OriginalPrice, PromotionalPrice, CategoryId, Available, Image,SpecialTagsID)
values (9,'GoldenPocket', 'Golden Pocket Watch', 1800, 1700, 3, 0, '\images\ProductImage\9.jpg',4);

Insert Into Products(Id,Name, Description, OriginalPrice, PromotionalPrice, CategoryId, Available, Image)
values (10,'Classic', 'Classic Simple', 350.00, 199.99, 3, 1, '\images\ProductImage\10.jpg');
SET IDENTITY_INSERT dbo.Products OFF;  
GO

INSERT INTO Reviews VALUES ('Mahmoud','Good item to buy',1);
INSERT INTO Reviews VALUES ('Ali','Too Expensive',1);
INSERT INTO Reviews VALUES ('Abdul','Recommended',2);