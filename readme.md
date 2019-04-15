EntityFramework

Instead of creating Migrations you can directly create tables in database
	1.CreateDatabaseIfNotExists  (Default)
	2.DropCreateDatabaseIfModelChanges
	3.DropCreateDatabaseAlways

Migration Types
	1.Automatic Migration
	2.Codebased Migration

To Enable Automatic Migration
	 1.Set AutomaticMigrationAllowed  to true
	 2.AutomaticMigrationDataLoss true


Codebased Migration
----------------------
	Enable Migration
	Add Migration
	Change Migration Script
	Update Database

Exercise
---------------------
1.Add Table
2.Add Property
3.Update Property
4.Rename Property
5.Insert Record in table
6.Rename the column after inserting the records
7.Delete the table after taking the backup
8.Go to previous Migration
9.Update the table
10.Seed data
11.Data Annotation Foreign Key
12.Foreign Key using Fluent Api
13.Relation Ship(One to One,One to Many,Many to One,Many to Many)

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