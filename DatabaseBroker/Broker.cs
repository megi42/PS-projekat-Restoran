﻿using Domain;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;

namespace DatabaseBroker
{
    public class Broker
    {
        private SqlConnection connection;
        private SqlTransaction transaction;
        public Broker()
        {
            connection = new SqlConnection(ConfigurationManager.ConnectionStrings["ProductsDatabase"].ConnectionString);
        }

        public void OpenConnection()
        {
            connection.Open();
        }

        public void CloseConnection()
        {
            connection.Close();
        }

        public void BeginTransaction()
        {
            transaction = connection.BeginTransaction();
        }

        public void Commit()
        {
            transaction?.Commit();
        }

        public void Rollback()
        {
            transaction?.Rollback();
        }

        public List<IEntity> GetAll(IEntity entity)
        {
            List<IEntity> result;
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"select {entity.SelectValues} from {entity.TableName} {entity.TableAlias} {entity.JoinTable} {entity.JoinCondition}";
            SqlDataReader reader = command.ExecuteReader();
            result = entity.GetEntities(reader);
            reader.Close();
            return result;
        }

        public void Update(IEntity entity)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"update {entity.TableName} set {entity.UpdateValues} where ({entity.UpdateCondition})"; 
            if (command.ExecuteNonQuery() != 1)
            {
                throw new Exception("Database error!");
            }
        }

        public List<IEntity> Search(IEntity entity)
        {
            List<IEntity> result;
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"select {entity.SelectValues} from {entity.TableName} {entity.TableAlias} {entity.JoinTable} {entity.JoinCondition} where {entity.SearchCondition}";
            SqlDataReader reader = command.ExecuteReader();
            result = entity.GetEntities(reader);
            reader.Close();
            return result;
        }

        public void Save(IEntity entity)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"insert into {entity.TableName} values ({entity.InsertValues})";
            if (command.ExecuteNonQuery() != 1)
            {
                throw new Exception("Database error!");
            }
        }

        public void Delete(IEntity entity)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"delete from {entity.TableName} where {entity.DeleteCondition}";
            command.ExecuteNonQuery();
        }

        public int GetMaxId(IEntity entity)
        {
            SqlCommand command = new SqlCommand("", connection, transaction);
            command.CommandText = $"select max({entity.IdName}) from {entity.TableName}";
            object result = command.ExecuteScalar();
            return (int)result;
        }

    }
}
