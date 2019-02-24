// <copyright file="EditFormConnect.cs" company="DeliaSoft">
//     Company copyright tag.
// </copyright>

namespace WebApiApplication
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using WebApiApplication.Models;

    /// <summary>
    /// Data connect for EditFormTable
    /// </summary>
    public class EditFormConnect
    {
        /// <summary>
        /// String for connect to data
        /// </summary>
        private readonly string connectionString = @"data source = (localdb)\MSSQLLocalDB; Initial Catalog = EditFormApplication.Models.NewFormContext; Integrated Security=True";

        /// <summary>
        /// Get NewFormData
        /// </summary>
        /// <param name = "id">integer type id parameter</param>
        /// <param name = "newForm">NewForm type newForm parameter</param>
        /// <returns>The View Result</returns>
        public NewForm GetNewFormData(int id, NewForm newForm)
        {
            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand
                {
                    CommandText = "SELECT * FROM NewForms WHERE Id = " + id + " ",
                    Connection = connection
                };
                var reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        newForm.HeadForm = reader.GetString(1);
                        newForm.DescriptionForm = reader.GetString(2);
                    }
                }

                connection.Close();
                return newForm;
            }
        }

        /// <summary>
        /// Get NewFormData
        /// </summary>
        /// <param name = "id">integer type id parameter</param>
        /// <param name = "fields">List type newForm parameter</param>
        /// <returns>The View Result</returns>
        public List<Field> GetFieldData(int id, List<Field> fields)
            {
            using (SqlConnection connection2 = new SqlConnection(this.connectionString))
            {
                connection2.Open();

                SqlCommand command2 = new SqlCommand
                {
                    CommandText = "SELECT * FROM Fields WHERE NewFormId = " + id + " ",
                    Connection = connection2
                };
                var reader2 = command2.ExecuteReader();
                if (reader2.HasRows)
                {
                    while (reader2.Read())
                    {
                        fields.Add(new Field()
                        {
                            HeadField = reader2.GetString(2),
                            TypeFields = reader2.GetString(4),
                            Check = reader2.GetBoolean(1)
                        });
                    }
                }

                return fields;
            }
        }
    }
}