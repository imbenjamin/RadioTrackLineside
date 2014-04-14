using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MySql.Data.MySqlClient;

namespace MainTestProject
{
    [TestClass]
    public class DbFunctions
    {
        MySqlConnection conn = new MySqlConnection("server=imbenjamin.no-ip.biz;port=3306;user id=testuser;password=test;persistsecurityinfo=True;database=test_schema");

        [TestCategory("Database Functions"), TestMethod]
        public void TestINSERT()
        {
            int actual;
            int expected = 1;
            string query = "INSERT INTO test_table VALUES(42, 'Foo')";
            MySqlCommand cmd = new MySqlCommand(query, conn);

            if (conn.State == System.Data.ConnectionState.Closed) conn.Open();
            actual = cmd.ExecuteNonQuery();
            if (conn.State == System.Data.ConnectionState.Open) conn.Close();

            Assert.AreEqual(expected, actual);
        }

        [TestCategory("Database Functions"), TestMethod]
        public void TestSELECT()
        {
            string actual = "";
            string expected = "Foo";
            string query = "SELECT * FROM test_table WHERE col1_int_10_pk = 42";
            MySqlCommand cmd = new MySqlCommand(query, conn);

            if (conn.State == System.Data.ConnectionState.Closed) conn.Open();
            MySqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
                actual = reader["col2_varchar_10"].ToString();
            if (conn.State == System.Data.ConnectionState.Open) conn.Close();

            Assert.AreEqual(expected, actual);
        }

        [TestCategory("Database Functions"), TestMethod]
        public void TestUPDATE()
        {
            int actual;
            int expected = 1;
            string query = "UPDATE test_table SET col2_varchar_10 = 'Bar' WHERE col1_int_10_pk = 42";
            MySqlCommand cmd = new MySqlCommand(query, conn);

            if (conn.State == System.Data.ConnectionState.Closed) conn.Open();
            actual = cmd.ExecuteNonQuery();
            if (conn.State == System.Data.ConnectionState.Open) conn.Close();

            Assert.AreEqual(expected, actual);
        }

        [TestCategory("Database Functions"), TestMethod]
        public void TestDELETE()
        {
            int actual;
            int expected = 1;
            string query = "DELETE FROM test_table WHERE col1_int_10_pk = 42";
            MySqlCommand cmd = new MySqlCommand(query, conn);

            if (conn.State == System.Data.ConnectionState.Closed) conn.Open();
            actual = cmd.ExecuteNonQuery();
            if (conn.State == System.Data.ConnectionState.Open) conn.Close();

            Assert.AreEqual(expected, actual);
        }
    }
}
