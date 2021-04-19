using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using ITWorkstationsInc.Model;

namespace ITWorkstationsInc.Database
{
    class ProductDAO:DAO
    {
        public const string TABLE_PRODUCT = "Product";
        public const string COLUMN_PRODUCT_ID = "Id";
        public const string COLUMN_PRODUCT_NAME = "Name";
        public const string COLUMN_PRODUCT_PRICE = "Price";
        public const string COLUMN_PRODUCT_TYPE = "Type";

        private static ProductDAO instance = new ProductDAO();

        private ProductDAO() : base()
        {
        }

        public static ProductDAO getInstance()
        {
            if (instance == null)
            {
                instance = new ProductDAO();
            }
            return instance;
        }


        //*************************************************************
        //Get Product data as Dictionary by product name
        //*************************************************************
        internal Dictionary<string, Product> ProductDictionary(int type)
        {
            Dictionary<string, Product> dictionary = new Dictionary<string, Product>();

            var selectStmt = "SELECT * FROM " + TABLE_PRODUCT
                + " WHERE " + COLUMN_PRODUCT_TYPE + " = " + type + " "
                + " ORDER BY " + COLUMN_PRODUCT_NAME + " ASC;";

            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(selectStmt, mSQLiteConnection);
                OpenConnection();
                SQLiteDataReader result = sQLiteCommand.ExecuteReader();
                if (result.HasRows)
                {
                    while (result.Read())
                    {
                        Product item = new Product
                        {
                            Id = Convert.ToInt32((result[COLUMN_PRODUCT_ID]).ToString()),
                            Name = (string)result[COLUMN_PRODUCT_NAME],
                            Price = (double)result[COLUMN_PRODUCT_PRICE],
                            Type = Convert.ToInt32((result[COLUMN_PRODUCT_TYPE]).ToString())
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
        //Get all Product data
        //*******************************
        public List<Product> getData(int type)
        {
            List<Product> list = new List<Product>();
            var selectStmt = "SELECT * FROM " + TABLE_PRODUCT
                + " WHERE " + COLUMN_PRODUCT_TYPE + " = " + type + " "
                + " ORDER BY " + COLUMN_PRODUCT_NAME + " ASC;";

            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(selectStmt, mSQLiteConnection);
                OpenConnection();
                SQLiteDataReader result = sQLiteCommand.ExecuteReader();
                if (result.HasRows)
                {
                    while (result.Read())
                    {
                        Product item = new Product
                        {
                            Id = Convert.ToInt32((result[COLUMN_PRODUCT_ID]).ToString()),
                            Name = (string)result[COLUMN_PRODUCT_NAME],
                            Price = (double)result[COLUMN_PRODUCT_PRICE],
                            Type = Convert.ToInt32((result[COLUMN_PRODUCT_TYPE]).ToString())
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
        //Add new Product data 
        //*******************************
        public bool addData(Product item)
        {
            string insertStmt = "INSERT INTO " + TABLE_PRODUCT + " ("
                    + COLUMN_PRODUCT_NAME + ", "
                    + COLUMN_PRODUCT_PRICE + ", "
                    + COLUMN_PRODUCT_TYPE +
                    " ) VALUES ( "
                    + "@" + COLUMN_PRODUCT_NAME + ", "
                    + "@" + COLUMN_PRODUCT_PRICE + ", "
                    + "@" + COLUMN_PRODUCT_TYPE
                    + " )";
            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(insertStmt, mSQLiteConnection);
                OpenConnection();
                sQLiteCommand.Parameters.AddWithValue(COLUMN_PRODUCT_NAME, item.Name);
                sQLiteCommand.Parameters.AddWithValue(COLUMN_PRODUCT_PRICE, item.Price);
                sQLiteCommand.Parameters.AddWithValue(COLUMN_PRODUCT_TYPE, item.Type);
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
        //Update PRODUCT data
        //*******************************
        internal bool UpdateData(Product item)
        {
            String updateStmt = "UPDATE " + TABLE_PRODUCT + " SET "
                 + COLUMN_PRODUCT_PRICE + " =@" + COLUMN_PRODUCT_PRICE + " "
                + " WHERE " + COLUMN_PRODUCT_ID + " = " + item.Id + " ";

            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(updateStmt, mSQLiteConnection);
                OpenConnection();
                sQLiteCommand.Parameters.Add(new SQLiteParameter(COLUMN_PRODUCT_PRICE, item.Price));
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
        //Delete PRODUCT data (hide)
        //*******************************
        public bool DeleteData(Product item)
        {
            string deleteStmt = "DELETE FROM " + TABLE_PRODUCT + " WHERE " + COLUMN_PRODUCT_ID + " = " + item.Id + " ";

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
            string createStmt = "CREATE TABLE " + TABLE_PRODUCT
                    + "(" + COLUMN_PRODUCT_ID + " INTEGER PRIMARY KEY, "
                    + COLUMN_PRODUCT_NAME + " TEXT UNIQUE NOT NULL, "
                    + COLUMN_PRODUCT_PRICE + " REAL NOT NULL, "
                    + COLUMN_PRODUCT_TYPE + " INTEGER NOT NULL )";

            SQLiteCommand sQLiteCommand = new SQLiteCommand(createStmt, mSQLiteConnection);
            OpenConnection();
            sQLiteCommand.ExecuteNonQuery();
            CloseConnection();
        }

    }
}
