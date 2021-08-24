ALTER TABLE [dbo].[Feedback]
	ADD CONSTRAINT [FK_Feedback_Status]
	FOREIGN KEY (StatusId)
	REFERENCES [Status] (Id)
