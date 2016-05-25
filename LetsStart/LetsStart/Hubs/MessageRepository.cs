
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using ModelLayer;
namespace LetsStart.Hubs
{
    public class MessagesRepository
    {
        readonly string _connString = ConfigurationManager.ConnectionStrings["DefaultConnectionString"].ConnectionString;

        public IEnumerable<MLMessages> GetAllMessages()
        {
            List<MLMessages> objListMessage = new List<MLMessages>();
            using (var connection = new SqlConnection(_connString))
            {
                connection.Open();
                using (var command = new SqlCommand(@"SELECT [ErrorID], [Message], [Host], [TimeUtc] FROM [dbo].[ELMAH_Error]", connection))
                {
                    command.Notification = null;

                    var dependency = new SqlDependency(command);
                    dependency.OnChange += new OnChangeEventHandler(dependency_OnChange);

                    if (connection.State == ConnectionState.Closed)
                        connection.Open();

                    var reader = command.ExecuteReader();

                    while (reader.Read())
                    {
                        objListMessage.Add(new MLMessages { 
                           // ErrorID = (string)reader["ErrorId"], 
                            Message = (string)reader["Message"], 
                            Host = reader["Host"] != DBNull.Value ? (string)reader["Host"] : "", 
                            Date = Convert.ToDateTime(reader["TimeUtc"]) 
                        });
                    }
                }

            }
            return objListMessage;


        }

        private void dependency_OnChange(object sender, SqlNotificationEventArgs e)
        {
            if (e.Type == SqlNotificationType.Change)
            {
                MessagesHub.SendMessages();
            }
        }
    }
}