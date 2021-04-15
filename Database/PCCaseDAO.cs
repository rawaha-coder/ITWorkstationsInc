using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SQLite;
using ITWorkstationsInc.Model;

namespace ITWorkstationsInc.Database
{
    class PCCaseDAO:DAO
    {
        public const string TABLE_CASE = "CaseBox";
        public const string COLUMN_CASE_ID = "CaseId";
        public const string COLUMN_CASE_NAME = "CaseName";
        public const string COLUMN_CASE_PRICE = "CasePrice";

        private static PCCaseDAO instance = new PCCaseDAO();

        private PCCaseDAO() : base()
        {
        }

        public static PCCaseDAO getInstance()
        {
            if (instance == null)
            {
                instance = new PCCaseDAO();
            }
            return instance;
        }

        //*************************************************************
        //Get data farm as Dictionary by farm name
        //*************************************************************
        internal Dictionary<string, CaseBox> CaseBoxDictionary()
        {
            Dictionary<string, CaseBox> dictionary = new Dictionary<string, CaseBox>();

            var selectStmt = "SELECT * FROM " + TABLE_CASE + " ORDER BY " + COLUMN_CASE_NAME + " ASC;";

            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(selectStmt, mSQLiteConnection);
                OpenConnection();
                SQLiteDataReader result = sQLiteCommand.ExecuteReader();
                if (result.HasRows)
                {
                    while (result.Read())
                    {
                        CaseBox caseBox = new CaseBox
                        {
                            CaseId = Convert.ToInt32((result[COLUMN_CASE_ID]).ToString()),
                            CaseName = (string)result[COLUMN_CASE_NAME],
                            CasePrice = (double)result[COLUMN_CASE_PRICE]
                        };
                        dictionary.Add(caseBox.CaseName, caseBox);
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
        //Get all farm data
        //*******************************
        public List<CaseBox> getData()
        {
            List<CaseBox> list = new List<CaseBox>();
            var selectStmt = "SELECT * FROM " + TABLE_CASE + " ORDER BY " + COLUMN_CASE_NAME + " ASC;";

            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(selectStmt, mSQLiteConnection);
                OpenConnection();
                SQLiteDataReader result = sQLiteCommand.ExecuteReader();
                if (result.HasRows)
                {
                    while (result.Read())
                    {
                        CaseBox caseBox = new CaseBox
                        {
                            CaseId = Convert.ToInt32((result[COLUMN_CASE_ID]).ToString()),
                            CaseName = (string)result[COLUMN_CASE_NAME],
                            CasePrice = (double)result[COLUMN_CASE_PRICE]
                        };
                        list.Add(caseBox);
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
        //Add new farm data 
        //*******************************
        public bool addData(CaseBox caseBox)
        {
            string insertStmt = "INSERT INTO " + TABLE_CASE + " ("
                    + COLUMN_CASE_NAME + ", "
                    + COLUMN_CASE_PRICE + 
                    " ) VALUES ( "
                    + "@" + COLUMN_CASE_NAME + ", "
                    + "@" + COLUMN_CASE_PRICE
                    + " )";
            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(insertStmt, mSQLiteConnection);
                OpenConnection();
                sQLiteCommand.Parameters.AddWithValue(COLUMN_CASE_NAME, caseBox.CaseName);
                sQLiteCommand.Parameters.AddWithValue(COLUMN_CASE_PRICE, caseBox.CasePrice);
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
        //Update farm data
        //*******************************
        internal bool UpdateData(CaseBox caseBox)
        {
            String updateStmt = "UPDATE " + TABLE_CASE + " SET "
                 + COLUMN_CASE_NAME + " =@" + COLUMN_CASE_NAME + ", "
                 + COLUMN_CASE_PRICE + " =@" + COLUMN_CASE_PRICE + " "
                + " WHERE " + COLUMN_CASE_ID + " = " + caseBox.CaseId + " ";

            try
            {
                SQLiteCommand sQLiteCommand = new SQLiteCommand(updateStmt, mSQLiteConnection);
                OpenConnection();
                sQLiteCommand.Parameters.Add(new SQLiteParameter(COLUMN_CASE_NAME, caseBox.CaseName));
                sQLiteCommand.Parameters.Add(new SQLiteParameter(COLUMN_CASE_PRICE, caseBox.CasePrice));
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
        //Delete farm data (hide)
        //*******************************
        public bool DeleteData(CaseBox caseBox)
        {
            string deleteStmt = "DELETE FROM " + TABLE_CASE + " WHERE " + COLUMN_CASE_ID + " = " + caseBox.CaseId + " ";

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
            String createStmt = "CREATE TABLE " + TABLE_CASE
                    + "(" + COLUMN_CASE_ID + " INTEGER PRIMARY KEY, "
                    + COLUMN_CASE_NAME + " TEXT UNIQUE NOT NULL, "
                    + COLUMN_CASE_PRICE + " REAL NOT NULL )";

            SQLiteCommand sQLiteCommand = new SQLiteCommand(createStmt, mSQLiteConnection);
            OpenConnection();
            sQLiteCommand.ExecuteNonQuery();
            CloseConnection();
        }

        /*

         CREATE TABLE "CaseBox" (
            	"CaseId"	INTEGER NOT NULL UNIQUE,
            	"CaseName"	TEXT NOT NULL,
            	"CasePrice"	INTEGER NOT NULL,
             	PRIMARY KEY("CaseId" AUTOINCREMENT)
        );
 
         * */
    }
}
