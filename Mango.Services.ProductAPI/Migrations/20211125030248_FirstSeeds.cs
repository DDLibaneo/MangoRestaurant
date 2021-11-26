using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Mango.Services.ProductAPI.Migrations
{
    public partial class FirstSeeds : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
			// Insert Categories 
            migrationBuilder.Sql(
			$@"
				INSERT INTO [dbo].[Categories]
				(
					 [Id]
					,[Name]
					,[Description]
				)
				VALUES
				(
					 '9F210192-0FCD-4566-91E0-0B828D76100D' --<Id, uniqueidentifier,>
					,'Appetizer' --,<Name, nvarchar(max),>
					,'Appetizer is something you eat before the good stuff comes in' --,<Description, nvarchar(max),>
				)

				INSERT INTO [dbo].[Categories]
				(
					 [Id]
					,[Name]
					,[Description]
				)
				VALUES
				(
					 '2EE0C895-2906-4167-8A99-5051AE8AB69E' --<Id, uniqueidentifier,>
					,'Entree' --,<Name, nvarchar(max),>
					,'Mostly salad' --,<Description, nvarchar(max),>
				)

				INSERT INTO [dbo].[Categories]
				(
					 [Id]
					,[Name]
					,[Description]
				)
				VALUES
				(
					 '4E897A07-F424-4303-B01B-6AA3760288D2' --<Id, uniqueidentifier,>
					,'Main course' --,<Name, nvarchar(max),>
					,'The reason you came to the restaurant' --,<Description, nvarchar(max),>
				)

				INSERT INTO [dbo].[Categories]
				(
					 [Id]
					,[Name]
					,[Description]
				)
				VALUES
				(
					 '9817DB18-C29B-487E-8F14-D85E0438A6FB' --<Id, uniqueidentifier,>
					,'Dessert' --,<Name, nvarchar(max),>
					,'It''s sweet' --,<Description, nvarchar(max),>
				)
			");

			// Insert Products
			migrationBuilder.Sql(@$"
				INSERT INTO [dbo].[Products]
				([Id]
				,[Name]
				,[Price]
				,[Description]
				,[CategoryId])
				VALUES
				(
					 '553E9223-006D-453F-A499-18F855BFA911'--<Id, uniqueidentifier,>
					,'Samosa'--<Name, nvarchar(max),>
					,15--<Price, float,>
					,'Praesent scelerisque, mi sed ultrices condimentum, lacus ipsum viverra massa, in lobortis sapien eros in arcu. Quisque vel lacus ac magna vehicula sagittis ut non lacus.<br/>Sed volutpat tellus lorem, lacinia tincidunt tellus varius nec. Vestibulum arcu turpis, facilisis sed ligula ac, maximus malesuada neque. Phasellus commodo cursus pretium.'--<Description, nvarchar(max),>
					,'9F210192-0FCD-4566-91E0-0B828D76100D'--<CategoryId, uniqueidentifier,>
				)

				INSERT INTO [dbo].[Products]
						   ([Id]
						   ,[Name]
						   ,[Price]
						   ,[Description]
						   ,[CategoryId])
				VALUES
				(
					 '0C1F9C73-6652-4537-97E1-EAD791F68C58'--<Id, uniqueidentifier,>
					,'Paneer Tikka'--<Name, nvarchar(max),>
					,13.99--<Price, float,>
					,'Praesent scelerisque, mi sed ultrices condimentum, lacus ipsum viverra massa, in lobortis sapien eros in arcu. Quisque vel lacus ac magna vehicula sagittis ut non lacus.<br/>Sed volutpat tellus lorem, lacinia tincidunt tellus varius nec. Vestibulum arcu turpis, facilisis sed ligula ac, maximus malesuada neque. Phasellus commodo cursus pretium.'--<Description, nvarchar(max),>
					,'9F210192-0FCD-4566-91E0-0B828D76100D'--<CategoryId, uniqueidentifier,>
				)

				INSERT INTO [dbo].[Products]
						   ([Id]
						   ,[Name]
						   ,[Price]
						   ,[Description]
						   ,[CategoryId])
				VALUES
				(
					 'EA7F96E6-B40D-408B-A14B-D0AF1C3B6032'--<Id, uniqueidentifier,>
					,'Sweet pie'--<Name, nvarchar(max),>
					,10.99--<Price, float,>
					,'Praesent scelerisque, mi sed ultrices condimentum, lacus ipsum viverra massa, in lobortis sapien eros in arcu. Quisque vel lacus ac magna vehicula sagittis ut non lacus.<br/>Sed volutpat tellus lorem, lacinia tincidunt tellus varius nec. Vestibulum arcu turpis, facilisis sed ligula ac, maximus malesuada neque. Phasellus commodo cursus pretium.'--<Description, nvarchar(max),>
					,'9817DB18-C29B-487E-8F14-D85E0438A6FB'--<CategoryId, uniqueidentifier,>
				)

				INSERT INTO [dbo].[Products]
				(
					 [Id]
					,[Name]
					,[Price]
					,[Description]
					,[CategoryId]
				)
				VALUES
				(
					 '44D3FBAB-0BED-4DB5-8469-50446B9DC084'--<Id, uniqueidentifier,>
					,'Pav Bhaji'--<Name, nvarchar(max),>
					,15--<Price, float,>
					,'Praesent scelerisque, mi sed ultrices condimentum, lacus ipsum viverra massa, in lobortis sapien eros in arcu. Quisque vel lacus ac magna vehicula sagittis ut non lacus.<br/>Sed volutpat tellus lorem, lacinia tincidunt tellus varius nec. Vestibulum arcu turpis, facilisis sed ligula ac, maximus malesuada neque. Phasellus commodo cursus pretium.'--<Description, nvarchar(max),>
					,'2EE0C895-2906-4167-8A99-5051AE8AB69E'--<CategoryId, uniqueidentifier,>
				)
			");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {

        }
    }
}
