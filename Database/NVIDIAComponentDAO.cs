using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using ITWorkstationsInc.Model;

namespace ITWorkstationsInc.Database
{
    class NVIDIAComponentDAO:DAO
    {
        public const string TABLE_NVIDIA_COMPONENT = "NVIDIAComponent";
        public const string COLUMN_NVIDIA_COMPONENT_ID = "Id";
        public const string COLUMN_NVIDIA_COMPONENT_NAME = "Name";
        public const string COLUMN_NVIDIA_COMPONENT_PRICE = "Price";

        private static NVIDIAComponentDAO instance = new NVIDIAComponentDAO();

        private NVIDIAComponentDAO() : base()
        {
        }

        public static NVIDIAComponentDAO getInstance()
        {
            if (instance == null)
            {
                instance = new NVIDIAComponentDAO();
            }
            return instance;
        }

        //*************************************************************
        //Get data COMPONENT as Dictionary by COMPONENT name
        //*************************************************************
        internal Dictionary<string, NVIDIAComponent> NVIDIAComponentDictionary()
        {
            Dictionary<string, NVIDIAComponent> dictionary = new Dictionary<string, NVIDIAComponent>();

            var selectStmt = "SELECT * FROM " + TABLE_NVIDIA_COMPONENT + " ORDER BY " + COLUMN_NVIDIA_COMPONENT_NAME + " ASC;";

            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(selectStmt, mSQLiteConnection);
                OpenConnection();
                SQLiteDataReader result = sQLiteCommand.ExecuteReader();
                if (result.HasRows)
                {
                    while (result.Read())
                    {
                        NVIDIAComponent item = new NVIDIAComponent
                        {
                            Id = Convert.ToInt32((result[COLUMN_NVIDIA_COMPONENT_ID]).ToString()),
                            Name = (string)result[COLUMN_NVIDIA_COMPONENT_NAME],
                            Price = (double)result[COLUMN_NVIDIA_COMPONENT_PRICE]
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
        public List<NVIDIAComponent> getData()
        {
            List<NVIDIAComponent> list = new List<NVIDIAComponent>();
            var selectStmt = "SELECT * FROM " + TABLE_NVIDIA_COMPONENT + " ORDER BY " + COLUMN_NVIDIA_COMPONENT_NAME + " ASC;";

            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(selectStmt, mSQLiteConnection);
                OpenConnection();
                SQLiteDataReader result = sQLiteCommand.ExecuteReader();
                if (result.HasRows)
                {
                    while (result.Read())
                    {
                        NVIDIAComponent item = new NVIDIAComponent
                        {
                            Id = Convert.ToInt32((result[COLUMN_NVIDIA_COMPONENT_ID]).ToString()),
                            Name = (string)result[COLUMN_NVIDIA_COMPONENT_NAME],
                            Price = (double)result[COLUMN_NVIDIA_COMPONENT_PRICE]
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
        //Add new NVIDIA_COMPONENT data 
        //*******************************
        public bool addData(NVIDIAComponent item)
        {
            string insertStmt = "INSERT INTO " + TABLE_NVIDIA_COMPONENT + " ("
                    + COLUMN_NVIDIA_COMPONENT_NAME + ", "
                    + COLUMN_NVIDIA_COMPONENT_PRICE +
                    " ) VALUES ( "
                    + "@" + COLUMN_NVIDIA_COMPONENT_NAME + ", "
                    + "@" + COLUMN_NVIDIA_COMPONENT_PRICE
                    + " )";
            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(insertStmt, mSQLiteConnection);
                OpenConnection();
                sQLiteCommand.Parameters.AddWithValue(COLUMN_NVIDIA_COMPONENT_NAME, item.Name);
                sQLiteCommand.Parameters.AddWithValue(COLUMN_NVIDIA_COMPONENT_PRICE, item.Price);
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
        //Update NVIDIA_COMPONENT data
        //*******************************
        internal bool UpdateData(NVIDIAComponent item)
        {
            String updateStmt = "UPDATE " + TABLE_NVIDIA_COMPONENT + " SET "
                 + COLUMN_NVIDIA_COMPONENT_PRICE + " =@" + COLUMN_NVIDIA_COMPONENT_PRICE + " "
                + " WHERE " + COLUMN_NVIDIA_COMPONENT_ID + " = " + item.Id + " ";

            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(updateStmt, mSQLiteConnection);
                OpenConnection();
                sQLiteCommand.Parameters.Add(new SQLiteParameter(COLUMN_NVIDIA_COMPONENT_PRICE, item.Price));
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
        //Delete NVIDIA_COMPONENT data (hide)
        //*******************************
        public bool DeleteData(NVIDIAComponent item)
        {
            string deleteStmt = "DELETE FROM " + TABLE_NVIDIA_COMPONENT + " WHERE " + COLUMN_NVIDIA_COMPONENT_ID + " = " + item.Id + " ";

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
            string createStmt = "CREATE TABLE " + TABLE_NVIDIA_COMPONENT
                    + "(" + COLUMN_NVIDIA_COMPONENT_ID + " INTEGER PRIMARY KEY, "
                    + COLUMN_NVIDIA_COMPONENT_NAME + " TEXT UNIQUE NOT NULL, "
                    + COLUMN_NVIDIA_COMPONENT_PRICE + " REAL NOT NULL )";

            SQLiteCommand sQLiteCommand = new SQLiteCommand(createStmt, mSQLiteConnection);
            OpenConnection();
            sQLiteCommand.ExecuteNonQuery();
            CloseConnection();
        }
    }
}
