﻿using QMS_System.Data.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace QMS_System.Data.BLL
{
    public class BLLConfig
    {
        #region constructor
        QMSSystemEntities db;
        static object key = new object();
        private static volatile BLLConfig _Instance;  //volatile =>  tranh dung thread
        public static BLLConfig Instance
        {
            get
            {
                if (_Instance == null)
                    lock (key)
                        _Instance = new BLLConfig();

                return _Instance;
            }
        }
        private BLLConfig() { }
        #endregion
        public List<ConfigModel> Gets()
        {
            using (db = new QMSSystemEntities())
            {
                return db.Q_Config.Where(x => !x.IsDeleted).Select(x => new ConfigModel() { Id = x.Id, Code = x.Code, Value = x.Value, Note = x.Note, IsActived = x.IsActived }).ToList();
            }
        }

        public List<ModelSelectItem> GetLookUp()
        {
            using (db = new QMSSystemEntities())
            {
                return db.Q_Config.Where(x => !x.IsDeleted).Select(x => new ModelSelectItem() { Id = x.Id, Name = x.Code }).ToList();
            }
        }

        public int Insert(Q_Config obj)
        {
            using (db = new QMSSystemEntities())
            {
                db.Q_Config.Add(obj);
                db.SaveChanges();
                return obj.Id;
            }
        }

        public bool Update(Q_Config model)
        {
            using (db = new QMSSystemEntities())
            {
                var obj = db.Q_Config.FirstOrDefault(x => !x.IsDeleted && x.Id == model.Id);
                if (obj != null)
                { 
                    obj.Value = model.Value;
                    obj.IsActived = model.IsActived;
                    obj.Note = model.Note;
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
        }

        public bool Update(string code, string value)
        {
            using (db = new QMSSystemEntities())
            {
                var obj = db.Q_Config.FirstOrDefault(x => !x.IsDeleted && x.Code.Trim().ToUpper().Equals( code.Trim().ToUpper()));
                if (obj != null)
                { 
                    obj.Value = value; 
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
        }

        public bool Delete(int Id)
        {
            using (db = new QMSSystemEntities())
            {
                var obj = db.Q_Config.FirstOrDefault(x => !x.IsDeleted && x.Id == Id);
                if (obj != null)
                {
                    obj.IsDeleted = true;
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
        }

        public string GetConfigByCode(string code)
        {
            using (db = new QMSSystemEntities())
            {
                var obj = db.Q_Config.FirstOrDefault(x => !x.IsDeleted && x.IsActived == true && x.Code.Trim().ToUpper().Equals(code.Trim().ToUpper()));
                return obj != null ? obj.Value : string.Empty;
            }
        }
        public bool UpdateConfigValueFromInterface(Q_Config model)
        {
            using (db = new QMSSystemEntities())
            {
                var obj = db.Q_Config.FirstOrDefault(x => !x.IsDeleted && x.Id == model.Id);
                if (obj != null)
                {
                    //obj.Code = obj.Code;
                    obj.Value = model.Value;
                    //obj.IsActived = obj.IsActived;
                    //obj.Note = obj.Note;
                    db.SaveChanges();
                    return true;
                }
                return false;
            }
        }
    }
}