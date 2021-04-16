using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using ITWorkstationsInc.Model;

namespace ITWorkstationsInc.Database
{
    class SDDStorageDAO:DAO
    {
        public const string TABLE_SDD = "SDD";
        public const string COLUMN_SDD_ID = "Id";
        public const string COLUMN_SDD_NAME = "Name";
        public const string COLUMN_SDD_PRICE = "Price";

        private static SDDStorageDAO instance = new SDDStorageDAO();

        private SDDStorageDAO() : base()
        {
        }

        public static SDDStorageDAO getInstance()
        {
            if (instance == null)
            {
                instance = new SDDStorageDAO();
            }
            return instance;
        }

        //*************************************************************
        //Get data SDD as Dictionary by SDD name
        //*************************************************************
        internal Dictionary<string, SDDStorage> SDDDictionary()
        {
            Dictionary<string, SDDStorage> dictionary = new Dictionary<string, SDDStorage>();

            var selectStmt = "SELECT * FROM " + TABLE_SDD + " ORDER BY " + COLUMN_SDD_NAME + " ASC;";

            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(selectStmt, mSQLiteConnection);
                OpenConnection();
                SQLiteDataReader result = sQLiteCommand.ExecuteReader();
                if (result.HasRows)
                {
                    while (result.Read())
                    {
                        SDDStorage item = new SDDStorage
                        {
                            Id = Convert.ToInt32((result[COLUMN_SDD_ID]).ToString()),
                            Name = (string)result[COLUMN_SDD_NAME],
                            Price = (double)result[COLUMN_SDD_PRICE]
                        };
                        dictionary.Add(item.Name, item);
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
        //Get all SDD data
        //*******************************
        public List<SDDStorage> getData()
        {
            List<SDDStorage> list = new List<SDDStorage>();
            var selectStmt = "SELECT * FROM " + TABLE_SDD + " ORDER BY " + COLUMN_SDD_NAME + " ASC;";

            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(selectStmt, mSQLiteConnection);
                OpenConnection();
                SQLiteDataReader result = sQLiteCommand.ExecuteReader();
                if (result.HasRows)
                {
                    while (result.Read())
                    {
                        SDDStorage item = new SDDStorage
                        {
                            Id = Convert.ToInt32((result[COLUMN_SDD_ID]).ToString()),
                            Name = (string)result[COLUMN_SDD_NAME],
                            Price = (double)result[COLUMN_SDD_PRICE]
                        };
                        list.Add(item);
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
        //Add new SDD data 
        //*******************************
        public bool addData(SDDStorage item)
        {
            string insertStmt = "INSERT INTO " + TABLE_SDD + " ("
                    + COLUMN_SDD_NAME + ", "
                    + COLUMN_SDD_PRICE +
                    " ) VALUES ( "
                    + "@" + COLUMN_SDD_NAME + ", "
                    + "@" + COLUMN_SDD_PRICE
                    + " )";
            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(insertStmt, mSQLiteConnection);
                OpenConnection();
                sQLiteCommand.Parameters.AddWithValue(COLUMN_SDD_NAME, item.Name);
                sQLiteCommand.Parameters.AddWithValue(COLUMN_SDD_PRICE, item.Price);
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
        //Update SDD data
        //*******************************
        internal bool UpdateData(SDDStorage item)
        {
            String updateStmt = "UPDATE " + TABLE_SDD + " SET "
                 + COLUMN_SDD_PRICE + " =@" + COLUMN_SDD_PRICE + " "
                + " WHERE " + COLUMN_SDD_ID + " = " + item.Id + " ";

            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(updateStmt, mSQLiteConnection);
                OpenConnection();
                sQLiteCommand.Parameters.Add(new SQLiteParameter(COLUMN_SDD_PRICE, item.Price));
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
        //Delete SDD data (hide)
        //*******************************
        public bool DeleteData(SDDStorage item)
        {
            string deleteStmt = "DELETE FROM " + TABLE_SDD + " WHERE " + COLUMN_SDD_ID + " = " + item.Id + " ";

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
            string createStmt = "CREATE TABLE " + TABLE_SDD
                    + "(" + COLUMN_SDD_ID + " INTEGER PRIMARY KEY, "
                    + COLUMN_SDD_NAME + " TEXT UNIQUE NOT NULL, "
                    + COLUMN_SDD_PRICE + " REAL NOT NULL )";

            SQLiteCommand sQLiteCommand = new SQLiteCommand(createStmt, mSQLiteConnection);
            OpenConnection();
            sQLiteCommand.ExecuteNonQuery();
            CloseConnection();
        }

    }
}
