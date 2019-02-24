// <copyright file="EditFormConnect.cs" company="DeliaSoft">
//     Company copyright tag.
// </copyright>

namespace WebApiApplication
{
    using System;
    using System.Collections.Generic;
    using System.Data.SqlClient;
    using WebApiApplication.Models;

    public class EditFormConnect
    {
        private string connectionString = @"data source = (localdb)\MSSQLLocalDB; Initial Catalog = EditFormApplication.Models.NewFormContext; Integrated Security=True";

        public NewForm getNewFormData(int id, NewForm newForm)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandText = "SELECT * FROM NewForms WHERE Id = " + id + "";
                command.Connection = connection;
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

        public List<Field> getFieldData(int id, List<Field> fields)
            {
            using (SqlConnection connection2 = new SqlConnection(connectionString))
            {
                connection2.Open();

                SqlCommand command2 = new SqlCommand();
                command2.CommandText = "SELECT * FROM Fields WHERE NewFormId = " + id + "";
                command2.Connection = connection2;
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