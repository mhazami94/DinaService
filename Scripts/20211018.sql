use dinaservice
go
EXEC sp_rename 'Files.Context', 'Content', 'COLUMN';
go
EXEC sp_rename 'Files.ContextType', 'ContentType', 'COLUMN';
go
EXEC sp_rename 'Files.Title', 'Name', 'COLUMN';
go
EXEC sp_rename 'Files.FileSize', 'Size', 'COLUMN';
go
alter table [dbo].[Files] add [Extension] varchar(10) null
go
alter table [dbo].[Files] add CreateDate datetime null
