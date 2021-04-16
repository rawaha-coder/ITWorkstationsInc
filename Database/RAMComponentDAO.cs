using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using ITWorkstationsInc.Model;

namespace ITWorkstationsInc.Database
{
    class RAMComponentDAO:DAO
    {
        public const string TABLE_RAM_COMPONENT = "RAMComponent";
        public const string COLUMN_RAM_COMPONENT_ID = "Id";
        public const string COLUMN_RAM_COMPONENT_NAME = "Name";
        public const string COLUMN_RAM_COMPONENT_PRICE = "Price";

        private static RAMComponentDAO instance = new RAMComponentDAO();

        private RAMComponentDAO() : base()
        {
        }

        public static RAMComponentDAO getInstance()
        {
            if (instance == null)
            {
                instance = new RAMComponentDAO();
            }
            return instance;
        }

        //*************************************************************
        //Get data COMPONENT as Dictionary by COMPONENT name
        //*************************************************************
        internal Dictionary<string, RAMComponent> RAMComponentDictionary()
        {
            Dictionary<string, RAMComponent> dictionary = new Dictionary<string, RAMComponent>();

            var selectStmt = "SELECT * FROM " + TABLE_RAM_COMPONENT + " ORDER BY " + COLUMN_RAM_COMPONENT_NAME + " ASC;";

            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(selectStmt, mSQLiteConnection);
                OpenConnection();
                SQLiteDataReader result = sQLiteCommand.ExecuteReader();
                if (result.HasRows)
                {
                    while (result.Read())
                    {
                        RAMComponent item = new RAMComponent
                        {
                            Id = Convert.ToInt32((result[COLUMN_RAM_COMPONENT_ID]).ToString()),
                            Name = (string)result[COLUMN_RAM_COMPONENT_NAME],
                            Price = (double)result[COLUMN_RAM_COMPONENT_PRICE]
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
        //Get all COMPONENT data
        //*******************************
        public List<RAMComponent> getData()
        {
            List<RAMComponent> list = new List<RAMComponent>();
            var selectStmt = "SELECT * FROM " + TABLE_RAM_COMPONENT + " ORDER BY " + COLUMN_RAM_COMPONENT_NAME + " ASC;";

            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(selectStmt, mSQLiteConnection);
                OpenConnection();
                SQLiteDataReader result = sQLiteCommand.ExecuteReader();
                if (result.HasRows)
                {
                    while (result.Read())
                    {
                        RAMComponent item = new RAMComponent
                        {
                            Id = Convert.ToInt32((result[COLUMN_RAM_COMPONENT_ID]).ToString()),
                            Name = (string)result[COLUMN_RAM_COMPONENT_NAME],
                            Price = (double)result[COLUMN_RAM_COMPONENT_PRICE]
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
        //Add new RAM_COMPONENT data 
        //*******************************
        public bool addData(RAMComponent item)
        {
            string insertStmt = "INSERT INTO " + TABLE_RAM_COMPONENT + " ("
                    + COLUMN_RAM_COMPONENT_NAME + ", "
                    + COLUMN_RAM_COMPONENT_PRICE +
                    " ) VALUES ( "
                    + "@" + COLUMN_RAM_COMPONENT_NAME + ", "
                    + "@" + COLUMN_RAM_COMPONENT_PRICE
                    + " )";
            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(insertStmt, mSQLiteConnection);
                OpenConnection();
                sQLiteCommand.Parameters.AddWithValue(COLUMN_RAM_COMPONENT_NAME, item.Name);
                sQLiteCommand.Parameters.AddWithValue(COLUMN_RAM_COMPONENT_PRICE, item.Price);
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
        //Update RAM_COMPONENT data
        //*******************************
        internal bool UpdateData(RAMComponent item)
        {
            String updateStmt = "UPDATE " + TABLE_RAM_COMPONENT + " SET "
                 + COLUMN_RAM_COMPONENT_PRICE + " =@" + COLUMN_RAM_COMPONENT_PRICE + " "
                + " WHERE " + COLUMN_RAM_COMPONENT_ID + " = " + item.Id + " ";

            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(updateStmt, mSQLiteConnection);
                OpenConnection();
                sQLiteCommand.Parameters.Add(new SQLiteParameter(COLUMN_RAM_COMPONENT_PRICE, item.Price));
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
        //Delete RAM_COMPONENT data (hide)
        //*******************************
        public bool DeleteData(RAMComponent item)
        {
            string deleteStmt = "DELETE FROM " + TABLE_RAM_COMPONENT + " WHERE " + COLUMN_RAM_COMPONENT_ID + " = " + item.Id + " ";

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
            string createStmt = "CREATE TABLE " + TABLE_RAM_COMPONENT
                    + "(" + COLUMN_RAM_COMPONENT_ID + " INTEGER PRIMARY KEY, "
                    + COLUMN_RAM_COMPONENT_NAME + " TEXT UNIQUE NOT NULL, "
                    + COLUMN_RAM_COMPONENT_PRICE + " REAL NOT NULL )";

            SQLiteCommand sQLiteCommand = new SQLiteCommand(createStmt, mSQLiteConnection);
            OpenConnection();
            sQLiteCommand.ExecuteNonQuery();
            CloseConnection();
        }
    }
}
