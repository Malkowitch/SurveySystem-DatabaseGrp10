namespace SurveySystem.Models
{
    using System.Data.Entity;
    public class SurveyConnection : DbContext
    {
        // Your context has been configured to use a 'ImageSharingDBConnection' connection string from your application's 
        // configuration file (App.config or Web.config). By default, this connection string targets the 
        // 'ImageSharing.Models.ImageSharingDBConnection' database on your LocalDb instance. 
        // 
        // If you wish to target a different database and/or database provider, modify the 'ImageSharingDBConnection' 
        // connection string in the application configuration file.
        public SurveyConnection()
            : base("name=SurveyConnection")
        {
        }

        // Add a DbSet for each entity type that you want to include in your model. For more information 
        // on configuring and using a Code First model, see http://go.microsoft.com/fwlink/?LinkId=390109.
        
    }
}