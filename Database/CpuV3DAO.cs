using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using ITWorkstationsInc.Model;

namespace ITWorkstationsInc.Database
{
    class CpuV3DAO:DAO
    {
        public const string TABLE_CPUV3 = "CPUV3";
        public const string COLUMN_CPUV3_ID = "CPUV3Id";
        public const string COLUMN_CPUV3_NAME = "CPUV3Name";
        public const string COLUMN_CPUV3_PRICE = "CPUV3Price";

        private static CpuV3DAO instance = new CpuV3DAO();

        private CpuV3DAO() : base()
        {
        }

        public static CpuV3DAO getInstance()
        {
            if (instance == null)
            {
                instance = new CpuV3DAO();
            }
            return instance;
        }

        //*************************************************************
        //Get data CPUV3 as Dictionary by CPUV3 name
        //*************************************************************
        internal Dictionary<string, CPUV3> CPUV3Dictionary()
        {
            Dictionary<string, CPUV3> dictionary = new Dictionary<string, CPUV3>();

            var selectStmt = "SELECT * FROM " + TABLE_CPUV3 + " ORDER BY " + COLUMN_CPUV3_NAME + " ASC;";

            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(selectStmt, mSQLiteConnection);
                OpenConnection();
                SQLiteDataReader result = sQLiteCommand.ExecuteReader();
                if (result.HasRows)
                {
                    while (result.Read())
                    {
                        CPUV3 cpuv3 = new CPUV3
                        {
                            Cpuv3Id = Convert.ToInt32((result[COLUMN_CPUV3_ID]).ToString()),
                            Cpuv3Name = (string)result[COLUMN_CPUV3_NAME],
                            Cpuv3Price = (double)result[COLUMN_CPUV3_PRICE]
                        };
                        dictionary.Add(cpuv3.Cpuv3Name, cpuv3);
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
        //Get all CPUV3 data
        //*******************************
        public List<CPUV3> getData()
        {
            List<CPUV3> list = new List<CPUV3>();
            var selectStmt = "SELECT * FROM " + TABLE_CPUV3 + " ORDER BY " + COLUMN_CPUV3_NAME + " ASC;";

            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(selectStmt, mSQLiteConnection);
                OpenConnection();
                SQLiteDataReader result = sQLiteCommand.ExecuteReader();
                if (result.HasRows)
                {
                    while (result.Read())
                    {
                        CPUV3 cpuv3 = new CPUV3
                        {
                            Cpuv3Id = Convert.ToInt32((result[COLUMN_CPUV3_ID]).ToString()),
                            Cpuv3Name = (string)result[COLUMN_CPUV3_NAME],
                            Cpuv3Price = (double)result[COLUMN_CPUV3_PRICE]
                        };
                        list.Add(cpuv3);
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
        //Add new CPUV3 data 
        //*******************************
        public bool addData(CPUV3 cpuv3)
        {
            string insertStmt = "INSERT INTO " + TABLE_CPUV3 + " ("
                    + COLUMN_CPUV3_NAME + ", "
                    + COLUMN_CPUV3_PRICE +
                    " ) VALUES ( "
                    + "@" + COLUMN_CPUV3_NAME + ", "
                    + "@" + COLUMN_CPUV3_PRICE
                    + " )";
            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(insertStmt, mSQLiteConnection);
                OpenConnection();
                sQLiteCommand.Parameters.AddWithValue(COLUMN_CPUV3_NAME, cpuv3.Cpuv3Name);
                sQLiteCommand.Parameters.AddWithValue(COLUMN_CPUV3_PRICE, cpuv3.Cpuv3Price);
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
        //Update CPUV3 data
        //*******************************
        internal bool UpdateData(CPUV3 cpuv3)
        {
            String updateStmt = "UPDATE " + TABLE_CPUV3 + " SET "
                 + COLUMN_CPUV3_PRICE + " =@" + COLUMN_CPUV3_PRICE + " "
                + " WHERE " + COLUMN_CPUV3_ID + " = " + cpuv3.Cpuv3Id + " ";

            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(updateStmt, mSQLiteConnection);
                OpenConnection();
                sQLiteCommand.Parameters.Add(new SQLiteParameter(COLUMN_CPUV3_PRICE, cpuv3.Cpuv3Price));
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
        //Delete CPUV3 data (hide)
        //*******************************
        public bool DeleteData(CPUV3 cpuv3)
        {
            string deleteStmt = "DELETE FROM " + TABLE_CPUV3 + " WHERE " + COLUMN_CPUV3_ID + " = " + cpuv3.Cpuv3Id + " ";

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
            string createStmt = "CREATE TABLE " + TABLE_CPUV3
                    + "(" + COLUMN_CPUV3_ID + " INTEGER PRIMARY KEY, "
                    + COLUMN_CPUV3_NAME + " TEXT UNIQUE NOT NULL, "
                    + COLUMN_CPUV3_PRICE + " REAL NOT NULL )";

            SQLiteCommand sQLiteCommand = new SQLiteCommand(createStmt, mSQLiteConnection);
            OpenConnection();
            sQLiteCommand.ExecuteNonQuery();
            CloseConnection();
        }
    }
}
