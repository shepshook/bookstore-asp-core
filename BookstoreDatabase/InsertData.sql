﻿USE [Bookstore];

-- All data generated using http://mockaroo.com

INSERT INTO [dbo].[Publisher] ([Id], [Name])
VALUES
('5D82A620-9D63-47DC-ABE6-E39F2F5CA51E', 'Feedspan'),
('708A991E-7812-47B7-9B77-C351F2152FDD', 'Babbleopia'),
('6C04133E-402A-466D-944F-3D23EFAAB80D', 'Yotz'),
('A1EBCA33-408F-4410-949D-3B0462D217AD', 'Quimba'),
('5E8A2F8B-8308-426E-AA39-531759A8F0A9', 'Skyvu')


INSERT INTO [dbo].[Book] ([Id], [Title], [Description], [PublicationDate], [Rating], [CoverImage], [PublisherId])
VALUES
(N'16B0E5E8-DBC6-4627-985D-144544226E02', N'Lepus arcticus', N'Self-enabling didactic structure', N'2014-04-08', 4.3, null, N'6C04133E-402A-466D-944F-3D23EFAAB80D');
(N'D8189216-737E-4BE8-B545-2933F984B6B1', N'Tiliqua scincoides', null, N'1994-03-03', 2.6, N'http://dummyimage.com/186x179.png/dddddd/000000', N'A1EBCA33-408F-4410-949D-3B0462D217AD');
(N'5BBB6911-4CA4-4B73-BCE8-414B3D53D1EA', N'Choloepus hoffmani', N'Optional interactive frame', N'1982-06-01', 2, N'http://dummyimage.com/101x249.png/ff4444/ffffff', N'5D82A620-9D63-47DC-ABE6-E39F2F5CA51E');
(N'D840CD0D-D134-4C4E-9376-4850435FEA2D', N'Ictalurus furcatus', N'Streamlined stable pricing structure', N'1998-09-14', null, N'http://dummyimage.com/241x115.png/ff4444/ffffff', N'5E8A2F8B-8308-426E-AA39-531759A8F0A9');
(N'D3B46546-E063-4C90-9914-5BE1ECBC7E54', N'Larus dominicanus', N'Assimilated full-range orchestration', N'1996-04-28', null, N'http://dummyimage.com/166x246.png/dddddd/000000', N'708A991E-7812-47B7-9B77-C351F2152FDD');
(N'615DC7AF-1402-4CD0-8F41-69B6C315CDEE', N'Agelaius phoeniceus', N'Cross-group zero administration initiative', N'2008-06-23', 1, N'https://media.giphy.com/media/1qZ7Ny4dYqhxwftGvG/giphy.gif', N'6C04133E-402A-466D-944F-3D23EFAAB80D');
(N'6F295C80-6397-408F-9CEE-A1962B6F1F4C', N'Pycnonotus barbatus', N'Enhanced multi-state access', N'2000-09-14', 4.8, N'http://dummyimage.com/122x196.png/ff4444/ffffff', N'6C04133E-402A-466D-944F-3D23EFAAB80D');
(N'266DEA79-749D-4D2E-8D26-A6A959993912', N'My new book!!', N'A book about some funny things', N'2020-03-22', 5, N'https://i.imgur.com/CfbsDLX.gif', N'6C04133E-402A-466D-944F-3D23EFAAB80D');
(N'CDA0856F-A6E3-46CD-8073-AF9FBE94A642', N'Nasua nasua', N'Multi-layered 24 hour open system', N'2014-06-24', 4.9, N'https://media.giphy.com/media/IeXFm8RPjpKCkuCvT0/giphy.gif', N'5D82A620-9D63-47DC-ABE6-E39F2F5CA51E');
(N'2F5FB24D-E8FF-4F68-94CC-B57DA5381B80', N'Priodontes maximus', N'Public-key bottom-line methodology', N'1986-07-11', 3.2, N'http://dummyimage.com/149x185.png/5fa2dd/ffffff', null);
(N'4764157A-7EB9-461D-B6CA-DF2EB50E96DF', N'Dusicyon thous', null, N'1986-10-12', 3.9, null, null);
(N'6154ECCE-4C8B-4F10-A228-E558662BBA88', N'Zenaida asiatica', N'Reverse-engineered modular ability', N'2009-12-09', 4.4, N'http://dummyimage.com/202x185.png/dddddd/000000', N'A1EBCA33-408F-4410-949D-3B0462D217AD');
(N'3C630427-6E78-48E9-8630-F08E29755761', N'Sarkidornis melanotos', N'Sharable asynchronous algorithm', N'2012-07-22', 0.3, N'http://dummyimage.com/122x182.png/ff4444/ffffff', N'6C04133E-402A-466D-944F-3D23EFAAB80D');
(N'0826705D-EEC4-4C1D-8D8B-F1B9DD2A741A', N'Felis concolor', N'Persistent regional ability', N'2004-12-25', 3.2, N'https://media.giphy.com/media/l2JhL0Gpfbvs4Y07K/giphy.gif', N'A1EBCA33-408F-4410-949D-3B0462D217AD');
(N'A18D2195-B0BA-4C23-A25A-F7F65C6A34FE', N'Neotis denhami', N'Multi-channelled zero tolerance ability', N'2019-09-26', 2.8, N'http://dummyimage.com/130x220.png/5fa2dd/ffffff', N'708A991E-7812-47B7-9B77-C351F2152FDD');

INSERT INTO [dbo].[Author] (Id, FirstName, LastName)
VALUES
('EEC75704-168E-4CAB-B9F6-A9F5434B6AF4', 'Ozzie', 'Desson'),
('A6B58150-EE56-4FBA-9AD8-AB9294E95092', 'Jazmin', 'Bielby'),
('2D8BAC45-F1E7-4793-B408-956FC8D374B4', 'Caro', 'Browne'),
('F4A048DF-FD9A-41DF-9B35-535D2A9ABFE9', 'Gun', 'Boud'),
('3A428B29-9BFB-4130-8AE4-C928521990DF', 'Bertie', 'Olyunin'),
('4A6BB0E1-39A4-49D5-B1D4-0E7ED9D3772B', 'Mahmoud', 'Van der Daal'),
('66722209-2675-40AB-BFE1-4BF62EA7F39C', 'Valry', 'Rigglesford'),
('6E9A42C2-2439-4E36-9CBB-0DB1C3B4898D', 'Thayne', 'Bergeau')


INSERT INTO [dbo].[BookAuthor] ([BookId], [AuthorId])
VALUES
('D3B46546-E063-4C90-9914-5BE1ECBC7E54', 'A6B58150-EE56-4FBA-9AD8-AB9294E95092'),
('2F5FB24D-E8FF-4F68-94CC-B57DA5381B80', '2D8BAC45-F1E7-4793-B408-956FC8D374B4'),
('6F295C80-6397-408F-9CEE-A1962B6F1F4C', '2D8BAC45-F1E7-4793-B408-956FC8D374B4'),
('2F5FB24D-E8FF-4F68-94CC-B57DA5381B80', '66722209-2675-40AB-BFE1-4BF62EA7F39C'),
('615DC7AF-1402-4CD0-8F41-69B6C315CDEE', '6E9A42C2-2439-4E36-9CBB-0DB1C3B4898D'),
('16B0E5E8-DBC6-4627-985D-144544226E02', 'F4A048DF-FD9A-41DF-9B35-535D2A9ABFE9'),
('D8189216-737E-4BE8-B545-2933F984B6B1', 'A6B58150-EE56-4FBA-9AD8-AB9294E95092'),
('A18D2195-B0BA-4C23-A25A-F7F65C6A34FE', '3A428B29-9BFB-4130-8AE4-C928521990DF'),
('5BBB6911-4CA4-4B73-BCE8-414B3D53D1EA', 'A6B58150-EE56-4FBA-9AD8-AB9294E95092'),
('6154ECCE-4C8B-4F10-A228-E558662BBA88', '66722209-2675-40AB-BFE1-4BF62EA7F39C'),
('D8189216-737E-4BE8-B545-2933F984B6B1', '2D8BAC45-F1E7-4793-B408-956FC8D374B4'),
('4764157A-7EB9-461D-B6CA-DF2EB50E96DF', '4A6BB0E1-39A4-49D5-B1D4-0E7ED9D3772B'),
('CDA0856F-A6E3-46CD-8073-AF9FBE94A642', 'F4A048DF-FD9A-41DF-9B35-535D2A9ABFE9'),
('6F295C80-6397-408F-9CEE-A1962B6F1F4C', '3A428B29-9BFB-4130-8AE4-C928521990DF'),
('5BBB6911-4CA4-4B73-BCE8-414B3D53D1EA', '2D8BAC45-F1E7-4793-B408-956FC8D374B4'),
('615DC7AF-1402-4CD0-8F41-69B6C315CDEE', '2D8BAC45-F1E7-4793-B408-956FC8D374B4'),
('D3B46546-E063-4C90-9914-5BE1ECBC7E54', 'EEC75704-168E-4CAB-B9F6-A9F5434B6AF4'),
('0826705D-EEC4-4C1D-8D8B-F1B9DD2A741A', '66722209-2675-40AB-BFE1-4BF62EA7F39C'),
('6F295C80-6397-408F-9CEE-A1962B6F1F4C', '6E9A42C2-2439-4E36-9CBB-0DB1C3B4898D'),
('2F5FB24D-E8FF-4F68-94CC-B57DA5381B80', 'EEC75704-168E-4CAB-B9F6-A9F5434B6AF4'),
('6F295C80-6397-408F-9CEE-A1962B6F1F4C', '66722209-2675-40AB-BFE1-4BF62EA7F39C'),
('5BBB6911-4CA4-4B73-BCE8-414B3D53D1EA', '3A428B29-9BFB-4130-8AE4-C928521990DF'),
('D840CD0D-D134-4C4E-9376-4850435FEA2D', '6E9A42C2-2439-4E36-9CBB-0DB1C3B4898D'),
('2F5FB24D-E8FF-4F68-94CC-B57DA5381B80', '3A428B29-9BFB-4130-8AE4-C928521990DF'),
('0826705D-EEC4-4C1D-8D8B-F1B9DD2A741A', '6E9A42C2-2439-4E36-9CBB-0DB1C3B4898D'),
('D840CD0D-D134-4C4E-9376-4850435FEA2D', '2D8BAC45-F1E7-4793-B408-956FC8D374B4'),
('615DC7AF-1402-4CD0-8F41-69B6C315CDEE', '3A428B29-9BFB-4130-8AE4-C928521990DF')
