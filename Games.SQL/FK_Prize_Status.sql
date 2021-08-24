ALTER TABLE [dbo].[Prize]
	ADD CONSTRAINT [FK_Prize_Status]
	FOREIGN KEY (StatusId)
	REFERENCES [Status] ([Id])
