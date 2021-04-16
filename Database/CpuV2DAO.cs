using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using ITWorkstationsInc.Model;

namespace ITWorkstationsInc.Database
{
    class CpuV2DAO:DAO
    {
        public const string TABLE_CPUV2 = "CPUV2";
        public const string COLUMN_CPUV2_ID = "CPUV2Id";
        public const string COLUMN_CPUV2_NAME = "CPUV2Name";
        public const string COLUMN_CPUV2_PRICE = "CPUV2Price";

        private static CpuV2DAO instance = new CpuV2DAO();

        private CpuV2DAO() : base()
        {
        }

        public static CpuV2DAO getInstance()
        {
            if (instance == null)
            {
                instance = new CpuV2DAO();
            }
            return instance;
        }

        //*************************************************************
        //Get data CPUV2 as Dictionary by CPUV2 name
        //*************************************************************
        internal Dictionary<string, CPUV2> CPUV2Dictionary()
        {
            Dictionary<string, CPUV2> dictionary = new Dictionary<string, CPUV2>();

            var selectStmt = "SELECT * FROM " + TABLE_CPUV2 + " ORDER BY " + COLUMN_CPUV2_NAME + " ASC;";

            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(selectStmt, mSQLiteConnection);
                OpenConnection();
                SQLiteDataReader result = sQLiteCommand.ExecuteReader();
                if (result.HasRows)
                {
                    while (result.Read())
                    {
                        CPUV2 cpuv2 = new CPUV2
                        {
                            Cpuv2Id = Convert.ToInt32((result[COLUMN_CPUV2_ID]).ToString()),
                            Cpuv2Name = (string)result[COLUMN_CPUV2_NAME],
                            Cpuv2Price = (double)result[COLUMN_CPUV2_PRICE]
                        };
                        dictionary.Add(cpuv2.Cpuv2Name, cpuv2);
                    }
                }
                return dictionary;
            }
            catch (SQLiteException e)
            {
                Console.WriteLine(e.StackTrace);
                return dictionary;
            }
            finally
            {
                CloseConnection();
            }
        }

        //*******************************
        //Get all CPUV2 data
        //*******************************
        public List<CPUV2> getData()
        {
            List<CPUV2> list = new List<CPUV2>();
            var selectStmt = "SELECT * FROM " + TABLE_CPUV2 + " ORDER BY " + COLUMN_CPUV2_NAME + " ASC;";

            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(selectStmt, mSQLiteConnection);
                OpenConnection();
                SQLiteDataReader result = sQLiteCommand.ExecuteReader();
                if (result.HasRows)
                {
                    while (result.Read())
                    {
                        CPUV2 cpuv2 = new CPUV2
                        {
                            Cpuv2Id = Convert.ToInt32((result[COLUMN_CPUV2_ID]).ToString()),
                            Cpuv2Name = (string)result[COLUMN_CPUV2_NAME],
                            Cpuv2Price = (double)result[COLUMN_CPUV2_PRICE]
                        };
                        list.Add(cpuv2);
                    }
                }
                return list;
            }
            catch (SQLiteException e)
            {
                Console.WriteLine(e.StackTrace);
                return list;
            }
            finally
            {
                CloseConnection();
            }
        }

        //*******************************
        //Add new CPUV2 data 
        //*******************************
        public bool addData(CPUV2 cpuv2)
        {
            string insertStmt = "INSERT INTO " + TABLE_CPUV2 + " ("
                    + COLUMN_CPUV2_NAME + ", "
                    + COLUMN_CPUV2_PRICE +
                    " ) VALUES ( "
                    + "@" + COLUMN_CPUV2_NAME + ", "
                    + "@" + COLUMN_CPUV2_PRICE
                    + " )";
            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(insertStmt, mSQLiteConnection);
                OpenConnection();
                sQLiteCommand.Parameters.AddWithValue(COLUMN_CPUV2_NAME, cpuv2.Cpuv2Name);
                sQLiteCommand.Parameters.AddWithValue(COLUMN_CPUV2_PRICE, cpuv2.Cpuv2Price);
                sQLiteCommand.ExecuteNonQuery();
                return true;
            }
            catch (SQLiteException e)
            {
                Console.WriteLine(e.StackTrace);
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }


        //*******************************
        //Update CPUV2 data
        //*******************************
        internal bool UpdateData(CPUV2 cpuv2)
        {
            String updateStmt = "UPDATE " + TABLE_CPUV2 + " SET "
                 + COLUMN_CPUV2_PRICE + " =@" + COLUMN_CPUV2_PRICE + " "
                + " WHERE " + COLUMN_CPUV2_ID + " = " + cpuv2.Cpuv2Id + " ";

            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(updateStmt, mSQLiteConnection);
                OpenConnection();
                sQLiteCommand.Parameters.Add(new SQLiteParameter(COLUMN_CPUV2_PRICE, cpuv2.Cpuv2Price));
                sQLiteCommand.ExecuteNonQuery();
                return true;
            }
            catch (SQLiteException e)
            {
                Console.WriteLine(e.StackTrace);
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }

        //*******************************
        //Delete CPUV2 data (hide)
        //*******************************
        public bool DeleteData(CPUV2 cpuv2)
        {
            string deleteStmt = "DELETE FROM " + TABLE_CPUV2 + " WHERE " + COLUMN_CPUV2_ID + " = " + cpuv2.Cpuv2Id + " ";

            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(deleteStmt, mSQLiteConnection);
                OpenConnection();
                sQLiteCommand.ExecuteNonQuery();
                return true;
            }
            catch (SQLiteException e)
            {
                Console.WriteLine(e.Message);
                return false;
            }
            finally
            {
                CloseConnection();
            }
        }



        public void CreateTable()
        {
            string createStmt = "CREATE TABLE " + TABLE_CPUV2
                    + "(" + COLUMN_CPUV2_ID + " INTEGER PRIMARY KEY, "
                    + COLUMN_CPUV2_NAME + " TEXT UNIQUE NOT NULL, "
                    + COLUMN_CPUV2_PRICE + " REAL NOT NULL )";

            SQLiteCommand sQLiteCommand = new SQLiteCommand(createStmt, mSQLiteConnection);
            OpenConnection();
            sQLiteCommand.ExecuteNonQuery();
            CloseConnection();
        }
    }
}
