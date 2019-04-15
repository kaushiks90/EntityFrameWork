EntityFramework

Instead of creating Migrations you can directly create tables in database
-------------------------------------------------------------------------
	CreateDatabaseIfNotExists  (Default)
	DropCreateDatabaseIfModelChanges
	DropCreateDatabaseAlways

Migration Types
-----------------------------
	Automatic Migration
	Codebased Migration

To Enable Automatic Migration
------------------------------------------
	Set AutomaticMigrationAllowed  to true
	AutomaticMigrationDataLoss true


Codebased Migration
----------------------
	Enable Migration
	Add Migration
	Change Migration Script
	Update Database

Exercise
---------------------
	Add Table
	Add Property
	Update Property
	Rename Property
	Insert Record in table
	Rename the column after inserting the records
	Delete the table after taking the backup
	Go to previous Migration
	Update the table
	Seed data
	Data Annotation Foreign Key
	Foreign Key using Fluent Api
	Relation Ship(One to On=e,One to Many,Many to One,Many to Many)

Commands
-------------------------------------
	Enable-migrations
	add-migration "Migration Name"
	update-database -targetmigration 201904130859123_AddedSubjectTable

Example Tables
-----------------------------
	Students  one-one Address
	Teachers one-many Classes
	Students Many-Many Classes