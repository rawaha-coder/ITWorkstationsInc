using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using ITWorkstationsInc.Model;

namespace ITWorkstationsInc.Database
{
    class HDDStorageDAO:DAO
    {
        public const string TABLE_HDD = "HDD";
        public const string COLUMN_HDD_ID = "Id";
        public const string COLUMN_HDD_NAME = "Name";
        public const string COLUMN_HDD_PRICE = "Price";

        private static HDDStorageDAO instance = new HDDStorageDAO();

        private HDDStorageDAO() : base()
        {
        }

        public static HDDStorageDAO getInstance()
        {
            if (instance == null)
            {
                instance = new HDDStorageDAO();
            }
            return instance;
        }

        //*************************************************************
        //Get data HDD as Dictionary by HDD name
        //*************************************************************
        internal Dictionary<string, HDDStorage> HDDDictionary()
        {
            Dictionary<string, HDDStorage> dictionary = new Dictionary<string, HDDStorage>();

            var selectStmt = "SELECT * FROM " + TABLE_HDD + " ORDER BY " + COLUMN_HDD_NAME + " ASC;";

            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(selectStmt, mSQLiteConnection);
                OpenConnection();
                SQLiteDataReader result = sQLiteCommand.ExecuteReader();
                if (result.HasRows)
                {
                    while (result.Read())
                    {
                        HDDStorage item = new HDDStorage
                        {
                            Id = Convert.ToInt32((result[COLUMN_HDD_ID]).ToString()),
                            Name = (string)result[COLUMN_HDD_NAME],
                            Price = (double)result[COLUMN_HDD_PRICE]
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
        //Get all HDD data
        //*******************************
        public List<HDDStorage> getData()
        {
            List<HDDStorage> list = new List<HDDStorage>();
            var selectStmt = "SELECT * FROM " + TABLE_HDD + " ORDER BY " + COLUMN_HDD_NAME + " ASC;";

            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(selectStmt, mSQLiteConnection);
                OpenConnection();
                SQLiteDataReader result = sQLiteCommand.ExecuteReader();
                if (result.HasRows)
                {
                    while (result.Read())
                    {
                        HDDStorage item = new HDDStorage
                        {
                            Id = Convert.ToInt32((result[COLUMN_HDD_ID]).ToString()),
                            Name = (string)result[COLUMN_HDD_NAME],
                            Price = (double)result[COLUMN_HDD_PRICE]
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
        //Add new HDD data 
        //*******************************
        public bool addData(HDDStorage item)
        {
            string insertStmt = "INSERT INTO " + TABLE_HDD + " ("
                    + COLUMN_HDD_NAME + ", "
                    + COLUMN_HDD_PRICE +
                    " ) VALUES ( "
                    + "@" + COLUMN_HDD_NAME + ", "
                    + "@" + COLUMN_HDD_PRICE
                    + " )";
            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(insertStmt, mSQLiteConnection);
                OpenConnection();
                sQLiteCommand.Parameters.AddWithValue(COLUMN_HDD_NAME, item.Name);
                sQLiteCommand.Parameters.AddWithValue(COLUMN_HDD_PRICE, item.Price);
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
        //Update HDD data
        //*******************************
        internal bool UpdateData(HDDStorage item)
        {
            String updateStmt = "UPDATE " + TABLE_HDD + " SET "
                 + COLUMN_HDD_PRICE + " =@" + COLUMN_HDD_PRICE + " "
                + " WHERE " + COLUMN_HDD_ID + " = " + item.Id + " ";

            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(updateStmt, mSQLiteConnection);
                OpenConnection();
                sQLiteCommand.Parameters.Add(new SQLiteParameter(COLUMN_HDD_PRICE, item.Price));
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
        //Delete HDD data (hide)
        //*******************************
        public bool DeleteData(HDDStorage item)
        {
            string deleteStmt = "DELETE FROM " + TABLE_HDD + " WHERE " + COLUMN_HDD_ID + " = " + item.Id + " ";

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
            string createStmt = "CREATE TABLE " + TABLE_HDD
                    + "(" + COLUMN_HDD_ID + " INTEGER PRIMARY KEY, "
                    + COLUMN_HDD_NAME + " TEXT UNIQUE NOT NULL, "
                    + COLUMN_HDD_PRICE + " REAL NOT NULL )";

            SQLiteCommand sQLiteCommand = new SQLiteCommand(createStmt, mSQLiteConnection);
            OpenConnection();
            sQLiteCommand.ExecuteNonQuery();
            CloseConnection();
        }
    }
}
