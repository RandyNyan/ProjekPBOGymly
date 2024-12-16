﻿using Npgsql;
using PBO_Gymly.DataBase;
using PBO_Gymly.StrukturData;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PBO_Gymly.CRUD
{
    internal class BagianMembership : DatabaseMembership
    {
        private static string table = "membership";
        public static DataTable All()
        {
            string query = @"
            SELECT
                m.id,
                m.nama,
                m.id_status,
                p.status_membership
            FROM
                membership m
            JOIN
                status p ON m.id_status = p.id";

            DataTable dataMembership = queryExecutor(query);
            return dataMembership;
        }

        public static DataTable getMembershipById(int id)
        {
            string query = @"
                SELECT 
                    m.id,
                    m.nama,
                    m.id_status,
                    p.status_membership  
                FROM 
                    membership m
                JOIN 
                    status p ON m.id_status = p.id
                WHERE 
                    m.id = @id";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id", NpgsqlTypes.NpgsqlDbType.Integer) { Value = id }
            };

            DataTable dataMembership = queryExecutor(query, parameters);
            return dataMembership;
        }

        public static void AddMembership(StrukturMembership membershipBaru)
        {
            string query = $"INSERT INTO {table} (nama, id_status) VALUES(@nama, @id_prodi)";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@nama", membershipBaru.nama_membership),
                new NpgsqlParameter("@id_prodi", membershipBaru.id_status)
            };

            commandExecutor(query, parameters);
        }

        public static void UpdateMmembership(StrukturMembership membership)
        {
            string query = $"UPDATE {table} SET nama = @nama, id_status = @id_status WHERE id = @id";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@nama", membership.nama_membership),
                new NpgsqlParameter("@id_status", membership.id_status),
                new NpgsqlParameter("@id", membership.id_membership)
            };

            commandExecutor(query, parameters);
        }

        public static void DeleteMembership(int id)
        {
            string query = $"DELETE FROM {table} WHERE id = @id";

            NpgsqlParameter[] parameters =
            {
                new NpgsqlParameter("@id", id)
            };

            commandExecutor(query, parameters);
        }
    }
}
